using System.Security.Cryptography;
using System.Text;

namespace Mitarbeiterverwaltung.LL
{

    public enum RequestState
    {
        pending,
        accepted,
        denied,
        none
    }

    public class TimePeriod
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public TimePeriod(DateTime startDate, DateTime endDate)
        {
            this.startDate = startDate;
            this.endDate = endDate;
        }
        public TimePeriod(DateTime startDate, TimeSpan duration)
        {
            this.startDate = startDate;
            this.endDate = startDate + duration;
        }

        public TimeSpan getDuration()
        {
            return endDate - startDate;
        }

        public override String ToString()
        {
            return startDate.ToString() + " - " + endDate.ToString();
        }

        public static TimePeriod parse(String str)
        {
            String[] parts = str.Split(" - ");
            return new TimePeriod(DateTime.Parse(parts[0]), DateTime.Parse(parts[1]));
        }
    }

    public class VacationRequest : TimePeriod
    {
        public RequestState state { get; set; }
        public VacationRequest (DateTime startDate, DateTime endDate, RequestState state) : base (startDate, endDate)
        {
            this.state = state;
        }
        
        public override String ToString()
        {
            return startDate.ToString() + " - " + endDate.ToString() + " - " + state.ToString();
        }

        public static new VacationRequest parse(String str)
        {
            String[] parts = str.Split(" - ");

            RequestState state = RequestState.none;
            if (Enum.TryParse<RequestState>(parts[2], out state))
            {
                return new VacationRequest(DateTime.Parse(parts[0]), DateTime.Parse(parts[1]), state);
            }
            else
            {
                throw new CustomException("Could not parse RequestState", exceptionType.error);
            }
        }
    }

    
    public class TimeHandler
    {
        private TimeSpan offset;

        public TimeHandler()
        {
            offset = TimeSpan.Zero;
        }

        public DateTime getTime()
        {
            return DateTime.Now + offset;
        }

        public void setTime(DateTime time)
        {
            offset = time - DateTime.Now;
        }

        public void setOffset(TimeSpan offset)
        {
            this.offset = offset;
        }
    }

    public class Employee
    {
        private static int maxEmployeeId = 999;
        public string Id { get; set; }
        public string passwordHash { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string adress { get; set; }
        public string phone { get; set; }
        public Employee? supervisor { get; set; }
        public Dictionary<string, Employee> subordinates { get; set; }

        private bool resetPasswordFlag = false;

        public Employee()
        {
            this.name = String.Empty;
            this.surname = String.Empty;
            this.adress = String.Empty;
            this.phone = String.Empty;
            subordinates = new Dictionary<string, Employee>();
            passwordHash = String.Empty;

            Id = (1 + (maxEmployeeId)).ToString();
            maxEmployeeId++;
        }

        public Employee(string name, string surname, string adress, string phone, int holidays, string password)
        {
            this.name = name;
            this.surname = surname;
            this.adress = adress;
            this.phone = phone;

            this.subordinates = new Dictionary<string, Employee>();

            setPassword(password, password);

            Id = (1 + (maxEmployeeId)).ToString();
            maxEmployeeId++;
        }

        public void parse(Dictionary<String, String> data)
        {
            foreach (var (key, value) in data)
            {
                //This step could be done via property assignment, but this way the interface stays the same,
                //regardless off changes in propertynames
                switch (key)
                {
                    case "name":
                        this.name = value;
                        break;

                    case "surname":
                        this.surname = value;
                        break;

                    case "adress":
                        this.adress = value;
                        break;

                    case "phone":
                        this.phone = value;
                        break;

                    case "passwordHash":
                        this.passwordHash = value;
                        break;

                    case "Id":
                        Id = value;
                        maxEmployeeId = Math.Max(Int32.Parse(value), maxEmployeeId);
                        break;

                    default:
                        break;
                }
            }
        }

        private byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        private string hashPassword(string password)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(password))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }
        public void resetPassword()
        {
            resetPasswordFlag = true;
        }

        public bool isPasswordInResetState()
        {
            return resetPasswordFlag;
        }

        public bool setPassword(string password, string passwordRepeated)
        {
            //check if password valid
            if(password != passwordRepeated)    //passwords are not equal
            { 
                return false; 
            }
            else if(password == "")             //password is empty
            {
                return false;
            }
            else if(checkPassword(password))    //new password is old password
            {
                return false;
            }
            else
            {
                passwordHash = hashPassword(password); //TODO this?
                this.resetPasswordFlag = false;
                return true;
            }
        }

        public bool checkPassword(string password)
        {
            return hashPassword(password).Equals(passwordHash);
        }
    }

    public class HourlyRatedEmployee : Employee
    {
        public TimeSpan weekTimeLimit { get; set; } = TimeSpan.Zero; //worktime/week due to contract
        public List<DateTime> checkInOutTimes { get; set; } = new List<DateTime>();
        public List<TimePeriod> pauseTimes { get; set; } = new List<TimePeriod>() 
        { 
            new TimePeriod(DateTime.MinValue + new TimeSpan(12,0,0), new TimeSpan(0,45,0))
        };
        public List<TimePeriod> sickDays { get; set; } = new List<TimePeriod>();
        public List<VacationRequest> vacations{ get; set; } = new List<VacationRequest>();
        public int vacationDays { get; set; } = 0;

        public HourlyRatedEmployee(string name, string surname, string adress, string phone, int holidays, string password, TimeSpan weekTimeLimit) : base(name, surname, adress, phone, holidays, password)
        {
            this.weekTimeLimit = weekTimeLimit;
        }

        public HourlyRatedEmployee() : base()
        {

        }

        public new void parse(Dictionary<String, String> data)
        {
            base.parse(data);
            
            foreach( var (key, value) in data)
            {
                if( value != "")
                {
                    switch (key)
                    {
                        case "weekTimeLimit":
                            this.weekTimeLimit = TimeSpan.Parse(value);
                            break;

                        case "vacationDays":
                            this.vacationDays = Int32.Parse(value);
                            break;

                        case "checkInOutTimes":
                            this.checkInOutTimes = value.Split(';').Select(x => DateTime.Parse(x)).ToList();
                            break;
                            
                        case "pauseTimes":
                            this.pauseTimes = value.Split(';').Select(x => TimePeriod.parse(x)).ToList();
                            break;

                        case "sickDays":
                            this.sickDays = value.Split(';').Select(x => TimePeriod.parse(x)).ToList();
                            break;

                        case "vacations":
                            this.vacations = value.Split(';').Select(x => VacationRequest.parse(x)).ToList();
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    //value is empty -> do nothing
                }
                
            }


        }

        public void requestVacation(DateTime startTime, DateTime endTime)
        {
            VacationRequest vacationRequest = new VacationRequest(startTime, endTime, RequestState.pending);
            vacations.Add(vacationRequest);
        }

        public void checkIn(TimeHandler timeHandler)
        {
            //checkIn only possible if last action was a checkOut
            // -> len of checkInOutTime must be even
            if (isCheckedIn())
            {
                throw new CustomException("Invalid chekInOuttimes length", exceptionType.error);
            }
            else
            {
                DateTime now = timeHandler.getTime();
                checkInOutTimes.Add(now);
            }

            return;
        }

        public void checkOut(TimeHandler timeHandler)
        {
            //checkOut only possible if last action was a checkIn
            // -> len of checkInOutTime must be odd
            if ( !isCheckedIn())
            {
                throw new CustomException("Invalid chekInOuttimes length", exceptionType.error);
            }
            else
            {
                DateTime now = timeHandler.getTime();
                checkInOutTimes.Add(now);
            }

            return;
        }

        public bool isCheckedIn()
        {
            return (checkInOutTimes.Count % 2) == 1;
        }

        public void addSickday(DateTime startTime, DateTime endTime)
        {
            TimePeriod sickDays = new TimePeriod(startTime, endTime);

            this.sickDays.Add(sickDays);
        }

        public void addPause(TimePeriod pauseTime)
        {
            this.pauseTimes.Add(pauseTime);
        }

        public TimeSpan getTotalWorktime()
        {
            return new TimeSpan();
        }

        public TimeSpan getOvertime()
        {
            return new TimeSpan();
        }

        public TimeSpan getTimeWorkedToday()
        {
            return new TimeSpan();
        }

        public TimeSpan getPauseTime()
        {
            return new TimeSpan();
        }

        public TimeSpan getTimeWorkedThisWeek()
        {
            return new TimeSpan();
        }

        public static List<String> getPropertyNames()
        {
            List<String> propertyNames = typeof(HourlyRatedEmployee).GetProperties().Select(field => field.Name).ToList();
            propertyNames.Sort();
            return propertyNames;
        }
        
        public override String ToString()
        {
            String returnString = "";
            List<String> propertyNames = getPropertyNames();

            foreach (string key in propertyNames)
            {
                var value = GetType().GetProperty(key).GetValue(this);

                switch (key)
                {
                    case "holidays":
                        value = value.ToString();
                        break;

                    case "supervisor":
                        if (value == null)
                        {
                            value = "";
                        }
                        else
                        {
                            HourlyRatedEmployee supervisor = (HourlyRatedEmployee)value;
                            value = supervisor.Id;
                        }

                        break;

                    case "subordinates":
                        List<string> subordinates = ((Dictionary<string, Employee>)value).Select(kvp => kvp.Key).ToList(); ;
                        value = string.Join(";", subordinates);
                        break;

                    case "pauseTimes":
                    case "sickDays":
                        List<TimePeriod> timePeriods = (List<TimePeriod>)value; 
                        if (timePeriods.Count > 0)
                        {
                            value = string.Join(";", timePeriods);
                        }
                        else
                        {
                            value = "";
                        }
                        break;


                    case "vacations":
                        List<VacationRequest> vacations = (List<VacationRequest>)value;
                        if (vacations.Count > 0)
                        {
                            value = string.Join(";", vacations);
                        }
                        else
                        {
                            value = "";
                        }
                        break;

                    case "checkInOutTimes":
                        List<DateTime> timestamps = (List<DateTime>)value;
                        if (timestamps.Count > 0)
                        {
                            value = string.Join(";", timestamps);
                        }
                        else
                        {
                            value = "";
                        }
                        break;

                    default:
                        break;
                }

                returnString += value + ",";
            }
            return returnString;
        }
    public void calcWorkingTime()
        {
            // --- to be called on every sign in and stamp out ---
            //get week working time
            //calc working time day (weekWorkingTime/5)
            //if current day is first and not weekend
            //  delete all stamp times of previous month
            //else
            //  do nothing
            //for each day in month until current day -1
            //  check if day is weekend
            //      break
            //  check if day is holiday
            //      direct add one working day to totalTime
            //      break
            //  check if day is sickDay
            //      direct add one working day to totalTime
            //      break
            //  else calc day working time
            //      round exact stamp times
            //      check if stamp times in pause times
            //          remove invalid stamp times
            //      add stamp times for given pause times
            //      -->calc total workTime day
            //      if totalWorkTimeDay is higher than workTimeDay
            //          add overtimeWeek for surplus workingTime
            //      else if totalWorkTimeDay is lower than workTimeDay
            //          reduce overtimeWeek for deficient workingTimeDay
            //      else
            //          do nothing
            //      add one WorkingTimeDay to totalWorktimeMonth
            //calc workingTime for current day
            //  check if day is weekend
            //  check if day is holiday
            //  check if day is sickDay
            //  calc working Time day like above until now

        }
    }


    public class CompanyData
    {
        public Dictionary<string, Employee> employees { get; set; }
        public string logoPath { get; set; }
        public string companyName { get; set; }


        public CompanyData(string companyName, string logoPath = "logo.png")
        {
            employees = new Dictionary<string, Employee>();
            this.companyName = companyName;
            this.logoPath = logoPath;
        }

        public void addEmployee(Employee employee)
        {
            employees.Add(employee.Id, employee);
            if (employee.supervisor != null)
            {
                employee.supervisor.subordinates.Add(employee.Id, employee);
            }
        }

        public void removeEmployee(Employee employee)
        {
            employees.Remove(employee.Id);
            if (employee.supervisor != null)
            {
                employee.supervisor.subordinates.Remove(employee.Id);
            }
            foreach (Employee subordinate in employee.subordinates.Values)
            {
                subordinate.supervisor = employee.supervisor;
            }
        }
    }
}