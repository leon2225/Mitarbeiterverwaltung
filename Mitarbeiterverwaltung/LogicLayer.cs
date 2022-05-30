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

    public class Absenteeism
    {
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public RequestState? state { get; set; }
        public String type { get; set; }

        public string toString()
        {
            return type.ToString() + " " + startTime.ToString() + " " + endTime.ToString() + " " + state.ToString();
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
        private static int numberOfEmployees = 0;
        public string Id { get; set; }
        public string passwordHash { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string adress { get; set; }
        public string phone { get; set; }
        public int holidays { get; set; }
        public Employee? supervisor { get; set; }
        public Dictionary<string, Employee> subordinates { get; set; }
        public List<Absenteeism> absenteeism { get; set; }

        public Employee(string name, string surname, string adress, string phone, int holidays, string password)
        {
            this.Id = (1000 + (numberOfEmployees++) + 1).ToString(); //TODO add auto Id
            this.name = name;
            this.surname = surname;
            this.adress = adress;
            this.phone = phone;
            this.holidays = holidays;

            this.subordinates = new Dictionary<string, Employee>();
            this.absenteeism = new List<Absenteeism>();

            setPassword(password);
        }

        public void requestHoliday(DateTime startTime, DateTime endTime)
        {
            Absenteeism holidayRequest = new Absenteeism();
            holidayRequest.type = "Urlaub";
            holidayRequest.startTime = startTime;
            holidayRequest.endTime = endTime;
            holidayRequest.state = RequestState.pending;

            this.absenteeism.Add(holidayRequest);
        }

        public void setSickDays(DateTime startTime, DateTime endTime)
        {
            Absenteeism sickDays = new Absenteeism();
            sickDays.type = "Krankheit";
            sickDays.startTime = startTime;
            sickDays.endTime = endTime;
            sickDays.state = null;

            this.absenteeism.Add(sickDays);
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

        public void setPassword(string password)
        {
            passwordHash = hashPassword(password);
        }

        public bool checkPassword(string password)
        {
            return hashPassword(password).Equals(passwordHash);
        }
    }

    public class HourlyRatedEmployee : Employee
    {
        public TimeSpan weekTimeLimit { get; set; } = TimeSpan.Zero; //worktime/week due to contract
        public TimeSpan totalWorktime { get; set; } = TimeSpan.Zero; //worktime for this month until now
        public DateTime startTime { get; set; } = DateTime.MinValue;
        public DateTime endTime { get; set; } = DateTime.MinValue;
        public TimeSpan timeWorkedToday { get; set; } = TimeSpan.Zero; //worktime today until last pause
        public TimeSpan pauseTime { get; set; } = TimeSpan.Zero;
        public TimeSpan overtime { get; set; } = TimeSpan.Zero; //overtime until last month

        public HourlyRatedEmployee(string name, string surname, string adress, string phone, int holidays, string password, TimeSpan weekTimeLimit) : base(name, surname, adress, phone, holidays, password)
        {
            this.weekTimeLimit = weekTimeLimit;
        }

        public bool checkIn(TimeHandler timeHandler)
        {
            //checkIn only possible if last action was a checkOut
            if (startTime > endTime)
            {
                return false;
            }

            DateTime now = timeHandler.getTime();

            //if endTime was today, then add time between endTime and now to pausetime
            if (endTime > DateTime.Today)
            {
                pauseTime += now - endTime;
            }
            else
            {
                //TODO handle holidays

                //start of new day
                timeWorkedToday = TimeSpan.Zero;

                //if endTime was last week reset totalWorktime and add overtime
                if (endTime.DayOfWeek > now.DayOfWeek)
                {
                    overtime += totalWorktime - weekTimeLimit;
                    totalWorktime = TimeSpan.Zero;
                }

            }

            startTime = now;
            return true;
        }

        public bool checkOut(TimeHandler timeHandler)
        {
            //checkOut only possible if last action was a checkIn
            if (endTime > startTime)
            {
                return false;
            }

            DateTime now = timeHandler.getTime();

            timeWorkedToday += now - startTime;
            totalWorktime += now - startTime;

            endTime = now;
            return true;
        }
    }

    public class Administrator : HourlyRatedEmployee
    {
        public Administrator(string name, string surname, string adress, string phone, int holidays, string password, TimeSpan weekTimeLimit) : base(name, surname, adress, phone, holidays, password, weekTimeLimit)
        {

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