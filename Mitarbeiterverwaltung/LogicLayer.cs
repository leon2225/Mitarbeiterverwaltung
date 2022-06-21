using System.Security.Cryptography;
using System.Text;

namespace Mitarbeiterverwaltung.LL
{
    /// <summary>
    /// Possible states of a vacation request
    /// </summary>
    public enum RequestState
    {
        pending,
        accepted,
        denied,
        none
    }

    /// <summary>
    /// New datatype for saving the period of two times and check their dependencies. 
    /// </summary>
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

        /// <summary>
        /// Returns the duration between first and last date.
        /// </summary>
        /// <returns><c>TimeSpan</c> between the two dates.</returns>
        public TimeSpan getDuration()
        {
            return endDate - startDate;
        }

        /// <summary>
        /// Check if <c>day</c> is in the TimePeriod or not.
        /// </summary>
        /// <param name="day">day to verify</param>
        /// <returns><c>true</c> if the day is in <c>TimePeriod</c> and <c>false</c> if not.</returns>
        public bool isInTimespan(DateTime day)
        {
            if (day > startDate && day < endDate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Converts the two dates to one String.
        /// </summary>
        /// <returns>String containing startDate - endDate</returns>
        public override String ToString()
        {
            return startDate.ToString() + " - " + endDate.ToString();
        }

        /// <summary>
        /// Get a TimePeriod out of a String.
        /// </summary>
        /// <param name="str">The dates in the string must be separated with a dash.</param>
        /// <returns>new TimePeriod</returns>
        public static TimePeriod parse(String str)
        {
            String[] parts = str.Split(" - ");
            return new TimePeriod(DateTime.Parse(parts[0]), DateTime.Parse(parts[1]));
        }
    }

    /// <summary>
    /// Extension of the TimePeriod for the additional parameter state to represent vacation requests.
    /// </summary>
    public class VacationRequest : TimePeriod
    {
        public RequestState state { get; set; }
        public VacationRequest (DateTime startDate, DateTime endDate, RequestState state) : base (startDate, endDate)
        {
            this.state = state;
        }

        /// <summary>
        /// Converts the two dates with the corresponding state to one String.
        /// </summary>
        /// <returns>String containing startDate - endDate - state</returns>
        public override String ToString()
        {
            return startDate.ToString() + " - " + endDate.ToString() + " - " + state.ToString();
        }

        /// <summary>
        /// Get a VacationRequest out of a String.
        /// </summary>
        /// <param name="str">The dates and the state must be separated with a dash.</param>
        /// <returns>new VacationRequest</returns>
        /// <exception cref="ErrorException"></exception>
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
                throw new ErrorException("Status des Urlaubsantrags kann nicht geladen werden");
            }
        }
    }

    
    /// <summary>
    /// Handler for manipulating the system time of the application.
    /// </summary>
    /// <remarks>This is mainly used for testing.</remarks>
    public class TimeHandler
    {
        private TimeSpan offset;

        public TimeHandler()
        {
            offset = TimeSpan.Zero;
        }

        /// <summary>
        /// Get the current time with an additional offset. 
        /// </summary>
        /// <returns>Time and date as DateTime.</returns>
        public DateTime getTime()
        {
            return DateTime.Now + offset;
        }

        /// <summary>
        /// Set a new time or date to manipulate the current time. 
        /// </summary>
        /// <param name="time">desired new time</param>
        public void setTime(DateTime time)
        {
            offset = time - DateTime.Now;
        }

        /// <summary>
        /// Set the offset that should be added to current time.
        /// </summary>
        /// <param name="offset">time offset as TimeSpan</param>
        public void setOffset(TimeSpan offset)
        {
            this.offset = offset;
        }
    }

    /// <summary>
    /// Basic class to store all data about an employee.
    /// </summary>
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

        /// <summary>
        /// Creates a SHA256-Hash of any input string that can be used for password checks.
        /// </summary>
        /// <param name="inputString">String to calculate a checksum from.</param>
        /// <returns>checksum of input string.</returns>
        private byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        /// <summary>
        /// Transforms password into a string of byte-values, prepared for hash function.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private string hashPassword(string password)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(password))
                //convert byte into byte into hex string with two digits
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        /// <summary>
        /// Enable the reset Flag for changing the password.
        /// </summary>
        public void resetPassword()
        {
            resetPasswordFlag = true;
        }

        /// <summary>
        /// check if the reset password flag for current employee is set. 
        /// </summary>
        /// <returns><c>true</c> if passwordResetFlag is also <c>true</c> and <c>false</c> if passwordResetFlag is <c>false</c> </returns>
        public bool isPasswordInResetState()
        {
            return resetPasswordFlag;
        }

        /// <summary>
        /// Set a new password for the current employee.
        /// </summary>
        /// <remarks>
        /// The password is checked on three properties.
        /// 1. The new password and the repeated password must be equal.
        /// 2. The password can not be set to an empty password.
        /// 3. The password can not be set to the previous password, it must be different.
        /// </remarks>
        /// <param name="password">new password to set.</param>
        /// <param name="passwordRepeated">repetition of the new password.</param>
        /// <returns><c>true</c> if password change was successful otherwise <c>false</c></returns>
        public bool setPassword(string password, string passwordRepeated)
        {
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
                passwordHash = hashPassword(password);
                this.resetPasswordFlag = false;
                return true;
            }
        }

        /// <summary>
        /// Compare the given password string with the hash value of the employees password.
        /// </summary>
        /// <param name="password">password to check</param>
        /// <returns><c>true</c> if the password is correct otherwise <c>false</c></returns>
        public bool checkPassword(string password)
        {
            return hashPassword(password).Equals(passwordHash);
        }

        /// <summary>
        /// Escape every comma separator in input string to prevent errors while exporting to a file.
        /// </summary>
        /// <param name="input">string without escaped comma separators</param>
        /// <returns>string with escaped comma separators</returns>
        public static string escapeString(string input)
        {
            return input.Replace(" ,", "|,");
        }

        /// <summary>
        /// Remove the escape characters from an input string.
        /// </summary>
        /// <param name="input">string with escaped comma separators</param>
        /// <returns>string without escaped comma separators</returns>
        public static string unescapeString(string input)
        {
            return input.Replace("|,", " ,");
        }

        /// <summary>
        /// Extension to parse a list of properties from an employee out of a string and a convert it to a dictionary.
        /// </summary>
        /// <param name="propertyNames">list of the properties to be parsed</param>
        /// <param name="data">string containing the data</param>
        public void parse(List<string> propertyNames, string data)
        {
            List<string> values = data.Split(" ,").ToList();
            var p = propertyNames.Zip(values, (k, v) => new { k, v }).ToDictionary(x => x.k, x => unescapeString(x.v));
            parse(p);
        }

        /// <summary>
        /// Parse employee properties from dictionary and assign them to their corresponding variables.
        /// </summary>
        /// <param name="data">dictionary of properties as key and data as value</param>
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
    }

    /// <summary>
    /// Extension of the basic employee for employees with an hourly paid working time model.
    /// </summary>
    public class HourlyRatedEmployee : Employee
    {
        public TimeSpan weekTimeLimit { get; set; } = TimeSpan.Zero; //worktime per week due to contract
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

        /// <summary>
        /// Creates a new vacation request with pending state. 
        /// </summary>
        /// <param name="startTime">beginning of the vacation</param>
        /// <param name="endTime">ending of the vacation</param>
        public void requestVacation(DateTime startTime, DateTime endTime)
        {
            VacationRequest vacationRequest = new VacationRequest(startTime, endTime, RequestState.pending);
            vacations.Add(vacationRequest);
        }

        /// <summary>
        /// Check in the employee at a given time.
        /// </summary>
        /// <param name="timeHandler">time handler to get current time</param>
        /// <exception cref="ErrorException">if employee is already checked in, check in not possible</exception>
        public void checkIn(TimeHandler timeHandler)
        {
            if (isCheckedIn())
            {
                throw new ErrorException("Fehler bei der Erfassung der Stempelzeiten");
            }
            else
            {
                DateTime now = timeHandler.getTime();
                checkInOutTimes.Add(now);
            }

            return;
        }

        /// <summary>
        /// Check out the employee at a given time.
        /// </summary>
        /// <param name="timeHandler">time handler to get current time</param>
        /// <exception cref="ErrorException">if employee is already checked out, check out not possible</exception>
        public void checkOut(TimeHandler timeHandler)
        {
            if ( !isCheckedIn())
            {
                throw new ErrorException("Fehler bei der Erfassung der Stempelzeiten");
            }
            else
            {
                DateTime now = timeHandler.getTime();
                checkInOutTimes.Add(now);
            }

            return;
        }

        /// <summary>
        /// Check if the employee is already checked in.
        /// </summary>
        /// <returns><c>true</c> if the employee is checked in, otherwise <c>false</c></returns>
        public bool isCheckedIn()
        {
            return (checkInOutTimes.Count % 2) == 1;
        }

        /// <summary>
        /// Register a new period of sick days for the employee. 
        /// </summary>
        /// <param name="sickDays">TimePeriod of sick days</param>
        public void addSickday(TimePeriod sickDays)
        {
            this.sickDays.Add(sickDays);
        }

        /// <summary>
        /// Register a new period of pause time for the employee.
        /// </summary>
        /// <param name="pauseTime">TimePeriod of a pause time</param>
        public void addPause(TimePeriod pauseTime)
        {
            this.pauseTimes.Add(pauseTime);
        }

        /// <summary>
        /// //todo if implemented
        /// </summary>
        /// <returns></returns>
        public TimeSpan getTotalWorktime()
        {
            return new TimeSpan();
        }

        /// <summary>
        /// //todo if implemented
        /// </summary>
        /// <returns></returns>
        public TimeSpan getOvertime()
        {
            return new TimeSpan();
        }

        /// <summary>
        /// Calculate the working time for today from the checkInOut times.
        /// </summary>
        /// <returns>TimeSpan of time worked today</returns>
        public TimeSpan getTimeWorkedToday()
        {
            List<DateTime> currentDayTimestamps;
            currentDayTimestamps = this.checkInOutTimes.FindAll(d => d.Equals(DateTime.Now.Date));
            return getTimeWorkedForOneDay(currentDayTimestamps);
        }

        /// <summary>
        /// //todo if implemented
        /// </summary>
        /// <returns></returns>
        public TimeSpan getPauseTime()
        {
            return new TimeSpan();
        }

        /// <summary>
        /// //todo if implemented
        /// </summary>
        /// <returns></returns>
        public TimeSpan getTimeWorkedThisWeek()
        {
            return new TimeSpan();
        }

        /// <summary>
        /// Read all Properties an Employee can contain and sort them alphabetical.
        /// </summary>
        /// <returns>list of properties in alphabetical order</returns>
        public static List<String> getPropertyNames()
        {
            List<String> propertyNames = typeof(HourlyRatedEmployee).GetProperties().Select(field => field.Name).ToList();
            propertyNames.Sort();
            return propertyNames;
        }

        /// <summary>
        /// Iterate over the data of all properties in alphabetical order and concatenate them to a single string.
        /// </summary>
        /// <returns>string containing all data of employee sorted after properties</returns>
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

                returnString += escapeString(value.ToString()) + " ,";
            }
            return returnString;
        }


        /// <summary>
        /// Extension to parse a list of properties from an hourly paid employee out of a string and a convert it to a dictionary.
        /// </summary>
        /// <param name="propertyNames">list of the properties to be parsed</param>
        /// <param name="data">string containing the data</param>
        public new void parse(List<string> propertyNames, string data)
        {
            List<string> values = data.Split(" ,").ToList();
            var p = propertyNames.Zip(values, (k, v) => new { k, v }).ToDictionary(x => x.k, x => unescapeString(x.v));
            parse(p);
        }

        /// <summary>
        /// Parse hourly paid employee properties from dictionary and assign them to their corresponding variables.
        /// </summary>
        /// <param name="data">dictionary of properties as key and data as value</param>
        public new void parse(Dictionary<String, String> data)
        {
            base.parse(data);

            foreach (var (key, value) in data)
            {
                if (value != "")
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

        // add pause times stamps
        // get pause times
        // get copy of stamps for one day
        // for pauseTime in PauseTimes
        //      check for conflicting pause times
        //          if stamp out is before pause ends and if it is the last time stamped
        //              check out at beginning of pause (reduce working time)
        //          else if stamp out before pause ends and not the last time 
        //              move stamp out to end of the pause   
        //------------------------------
        //      if not stamped out at pause time beginn
        //          get last stamp in before first pause
        //          add stamp out at pause beginning
        //          add stamp in at pause end
        //

        /// <summary>
        /// Check if a selected day is in a vacation period.
        /// </summary>
        /// <param name="day">day to check</param>
        /// <returns><c>true</c> if day is in vacation period, otherwise <c>false</c></returns>
        private bool isDayVacation(DateTime day)
        {
            foreach (var vacation in this.vacations)
            {
                if (vacation.isInTimespan(day) && vacation.state == RequestState.accepted)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Check if a selected day is at weekend.
        /// </summary>
        /// <param name="day">day to check</param>
        /// <returns><c>true</c> if day is at weekend, otherwise <c>false</c></returns>
        private bool isDayWeekend(DateTime day)
        {
            if (day.DayOfWeek == DayOfWeek.Sunday || day.DayOfWeek == DayOfWeek.Saturday)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Check if a selected day is in a sick day period.
        /// </summary>
        /// <param name="day">day to check</param>
        /// <returns><c>true</c> if day is a sick day, otherwise <c>false</c></returns>
        private bool isDaySickDay(DateTime day)
        {
            //todo in eine Funktion schreiben mit find
            foreach (var sickDayPeriod in this.sickDays)
            {
                if (sickDayPeriod.isInTimespan(day))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Calculate working time for a given day.
        /// </summary>
        /// <param name="day">day to calculate</param>
        /// <returns>TimeSpan of total working time for the selected day</returns>
        /// <exception cref="ErrorException"></exception>
        public TimeSpan getTimeWorkedForOneDay(List<DateTime> day)
        {
            if (day.Count % 2 != 0)
                throw new ErrorException("Fehler bei der Berechnung der Arbeitszeit");
            TimeSpan totalTime = new TimeSpan();
            for (int i = 0; i < day.Count; i += 2)
            {
                TimePeriod workingPeriod = new TimePeriod(this.checkInOutTimes[i], this.checkInOutTimes[i + 1]);
                totalTime = totalTime.Add(workingPeriod.getDuration());
            }
            return totalTime;
        }

        /// <summary>
        /// Calculate the total working time including overtime on weekends and vacationTimes.  
        /// </summary>
        /// <exception cref="ErrorException"></exception>
        public void calcWorkingTime()
        {
            TimeSpan workingTimeDayLimit;
            TimeSpan totalWorkingTimeDay = new TimeSpan();
            TimeSpan overtimeDay = new TimeSpan();
            TimeSpan totalOvertime = new TimeSpan();
            TimeSpan totalWorkingTime = new TimeSpan();
            List<DateTime> currentDayTimestamps;
            // --- to be called on every sign in and stamp out ---
            //get week working time
            workingTimeDayLimit = this.weekTimeLimit.Divide(5);
            DateTime firstDay = this.checkInOutTimes.First().Date;
            DateTime lastDay = this.checkInOutTimes.Last().Date;
            DateTime day = firstDay;
            // https://stackoverflow.com/questions/23825438/how-to-count-datetimes-with-same-day
            var listOfDays = this.checkInOutTimes.GroupBy(x => x.Date).Select(x => x.Key).ToList();
            while (day != lastDay)

            {
                currentDayTimestamps = this.checkInOutTimes.FindAll(d => d.Equals(day));
                totalWorkingTimeDay = getTimeWorkedForOneDay(currentDayTimestamps);
                overtimeDay = TimeSpan.Zero;
                if (isDayWeekend(day))
                {
                    overtimeDay = totalWorkingTimeDay;
                    totalOvertime = totalOvertime.Add(overtimeDay);
                    continue;
                }
                else if (isDayVacation(day))
                {
                    overtimeDay = totalWorkingTimeDay;
                    // and add one working day
                }
                else if (isDaySickDay(day))
                {
                    // is possible if worked and then becomes sick --> ignore stamp times?
                    throw new ErrorException("Mitarbeiter arbeitet obwohl krank");
                }
                else
                {
                    //normal working day
                    overtimeDay = workingTimeDayLimit - totalWorkingTimeDay;

                }
                if (day == lastDay)
                {
                    //extra calc for last day
                    //only necessary if lastday is today otherwise the day is already closed
                    totalWorkingTime = totalWorkingTime.Add(totalWorkingTimeDay);
                }
                else
                {
                    totalWorkingTime = totalWorkingTime.Add(workingTimeDayLimit);
                    totalOvertime = totalOvertime.Add(overtimeDay); //add day overtime to total overtime
                }
                day.AddDays(1);
            }
            totalWorkingTime = totalWorkingTime;
            totalOvertime = totalOvertime;
            //  save new total working Time to employee
            //  round display time visible
        }
    }

    /// <summary>
    /// Basic class for management of all employees and the information to identify the owner of the system.
    /// </summary>
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

        /// <summary>
        /// Register a new Employee and assign to list of subordinates.
        /// </summary>
        /// <param name="employee"></param>
        public void addEmployee(Employee employee)
        {
            employees.Add(employee.Id, employee);
            if (employee.supervisor != null)
            {
                employee.supervisor.subordinates.Add(employee.Id, employee);
            }
            else
            {
                //employee has no supervisor -> employee should not be add as someones subordinate
            }
        }

        /// <summary>
        /// Remove a selected employee and hand over employees subordinates to next overlying supervisor.
        /// </summary>
        /// <param name="employee">Employee that should be removed</param>
        public void removeEmployee(Employee employee)
        {
            employees.Remove(employee.Id);
            if (employee.supervisor != null)
            {
                employee.supervisor.subordinates.Remove(employee.Id);
            }
            else
            {
                //employee has no supervisor -> employee should not be removed as someones subordinate
            }
            foreach (Employee subordinate in employee.subordinates.Values)
            {
                subordinate.supervisor = employee.supervisor;
            }
        }
    }
}