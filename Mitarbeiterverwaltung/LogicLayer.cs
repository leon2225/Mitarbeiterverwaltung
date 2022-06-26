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
        public bool contains(DateTime day)
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
        /// Remove all weekends from timespan between start and end day to get working days count.
        /// </summary>
        /// <returns>working days between start and end date</returns>
        public double getBusinessDays()
        {
            // Source: https://alecpojidaev.wordpress.com/2009/10/29/work-days-calculation-with-c/
            // {
            double businessDays =
                1 + ((endDate.Date - startDate.Date).TotalDays * 5 -
                (startDate.DayOfWeek - endDate.DayOfWeek) * 2) / 7;

            businessDays -= (endDate.DayOfWeek == DayOfWeek.Saturday) ? 1 : 0;
            businessDays -= (startDate.DayOfWeek == DayOfWeek.Sunday) ? 1 : 0;
            // }

            businessDays -= (endDate.Hour <= 12) ? 0.5 : 0;
            businessDays -= (startDate.Hour >= 12) ? 0.5 : 0;

            return Math.Round(businessDays, 1);
        }

        /// <summary>
        /// Bounds the TimePeriod so that it is within frame.
        /// </summary>
        /// <param name="frame"> frame to which the TimePeriod should be bounded to</param>
        /// <returns>Bounded TimePeriod; startDate == endDate if there is no conjuction</returns>
        public TimePeriod boundTo(TimePeriod frame)
        {
            TimePeriod output = this;

            bool startInMonth = frame.contains(startDate);
            bool endInMonth = frame.contains(endDate);

            if (startInMonth || endInMonth)
            {
                //only consider that part of the timeperiod, that is actually in this month
                output.startDate = startInMonth ? startDate : frame.startDate;
                output.endDate = endInMonth ? endDate : frame.endDate;
            }
            else
            {
                //if there is no conjunction between the timePeriods set endDate to startData
                output.endDate = output.startDate;
            }

            return output;
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
        public bool useOvertime { get; set; }
        public VacationRequest (DateTime startDate, DateTime endDate, RequestState state, bool useOvertime) : base (startDate, endDate)
        {
            this.state = state;
            this.useOvertime = useOvertime;
        }

        /// <summary>
        /// Converts the two dates with the corresponding state to one String.
        /// </summary>
        /// <returns>String containing startDate - endDate - state</returns>
        public override String ToString()
        {
            return startDate.ToString() + " - " + endDate.ToString() + " - " + state.ToString() + " - " + useOvertime.ToString();
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
            bool useOvertime = false;
            if (Enum.TryParse<RequestState>(parts[2], out state) && bool.TryParse(parts[3], out useOvertime))
            {
                return new VacationRequest(DateTime.Parse(parts[0]), DateTime.Parse(parts[1]), state, bool.Parse(parts[3]));
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
        /// Gets the month as TimePeriod represented bý the TimeHandler
        /// </summary>
        /// <returns> TimePeriod that contains the current month represented by the TimeHandler</returns>
        public TimePeriod getMonth()
        {
            DateTime startOfMonth = new DateTime(getTime().Year, getTime().Month, 1);
            DateTime endOfMonth = startOfMonth.AddMonths(1) - new TimeSpan(0, 0, 1);
            return new TimePeriod(startOfMonth, endOfMonth);
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
        public string Id { get; private set; }
        public string passwordHash { get; private set; }
        public string name { get; private set; }
        public string surname { get; private set; }
        public string adress { get; private set; }
        public string phone { get; private set; }
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

        public Employee(string name, string surname, string adress, string phone, string password)
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
        public TimeSpan weekTimeLimit { get; private set; } = TimeSpan.Zero; //worktime per week due to contract
        public List<DateTime> checkInOutTimes { get; private set; } = new List<DateTime>();
        public List<TimePeriod> pauseTimes { get; private set; } = new List<TimePeriod>() 
        { 
            new TimePeriod(DateTime.MinValue + new TimeSpan(12,0,0), new TimeSpan(0,45,0))
        };
        public List<TimePeriod> sickDays { get; private set; } = new List<TimePeriod>();
        public List<VacationRequest> vacations{ get; private set; } = new List<VacationRequest>();
        public int vacationDays { get; private set; } = 0;
        public double vacationHalfDaysLeft { get; private set; } = 0; // stores the rest amount of vacations, in halfdays //ToDo Add to parser + to string
        private  TimeSpan overTime { get; set; } = new TimeSpan(); //ToDo Add to parser + to string


        public HourlyRatedEmployee(string name, string surname, string adress, string phone, string password, TimeSpan weekTimeLimit) : base(name, surname, adress, phone, password)
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
        /// <param name="useOvertime">true if overtime should be taken before vacationtime is consumed</param>
        public void requestVacation(DateTime startTime, DateTime endTime, bool useOvertime)
        {
            VacationRequest vacationRequest = new VacationRequest(startTime, endTime, RequestState.pending, useOvertime);
            vacations.Add(vacationRequest);
        }

        /// <summary>
        /// Functions calculates overtime and vacationsTimes for given vacation.
        /// </summary>
        /// <param name="request">Vacation request to calc</param>
        /// <param name="_overTimeLeft">Overtime as reference</param>
        /// <param name="_vacationHalfDaysLeft">VacationHalfDaysLeft as reference</param>
        /// <returns>True if vacation can be granted, False otherwise</returns>
        public bool calculateVacationRequest(VacationRequest request, ref TimeSpan _overTimeLeft, ref double _vacationHalfDaysLeft)
        {
            bool vacationPossible = true;

            if (request.useOvertime)
            {
                TimeSpan vacationTime = request.getBusinessDays() * (weekTimeLimit / 5);

                if (vacationTime < _overTimeLeft)
                {
                    //the needed vacatime can completely be covered by overtime
                    _overTimeLeft -= vacationTime;
                }
                else
                {
                    //only a part of the vacation time can be covered by overtime
                    //Time to take from vacationDaysLeft
                    double vacationHoursTake = (vacationTime - _overTimeLeft).TotalHours;
                    double hoursPerHalfDay = weekTimeLimit.TotalHours / 10;

                    double vacationHalfDaysToTake = Math.Ceiling(vacationHoursTake / hoursPerHalfDay);

                    TimeSpan overTimeToTake = vacationTime - TimeSpan.FromHours(vacationHalfDaysToTake * hoursPerHalfDay);

                    //check if there are enough vacationdays left
                    if (_vacationHalfDaysLeft > vacationHalfDaysToTake)
                    {
                        _vacationHalfDaysLeft -= vacationHalfDaysToTake;
                        _overTimeLeft -= overTimeToTake;
                    }
                    else
                    {
                        //There aren't enough vacationDaysLeft to cover the vacation
                        //Take so much overtime, that it gets negative but covers the entire vacation
                        _overTimeLeft = vacationTime - TimeSpan.FromHours(_vacationHalfDaysLeft * hoursPerHalfDay);

                        _vacationHalfDaysLeft = 0;
                        vacationPossible = false;
                    }

                }
            }
            else
            {
                _vacationHalfDaysLeft -= request.getBusinessDays() * 2;

                vacationPossible = _vacationHalfDaysLeft > request.getBusinessDays() * 2;
            }
            return vacationPossible;
        }

        /// <summary>
        /// Functions calculates overtime and vacationsTimes for granting vacation. Can be simulated.
        /// </summary>
        /// <param name="request">VacationRequest to grant</param>
        public void grantVacation(int index)
        {
            VacationRequest request = vacations[index];
            TimeSpan currentOverTime = overTime;
            Double currentVacationHalfDaysLeft = vacationHalfDaysLeft;
            calculateVacationRequest(request, ref currentOverTime, ref currentVacationHalfDaysLeft);
            overTime = currentOverTime;
            vacationHalfDaysLeft = currentVacationHalfDaysLeft;
            request.state = RequestState.accepted;
        }

        public double getVacationDaysLeft()
        {
            return vacationHalfDaysLeft / 2;
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
                DateTime monthStart = timeHandler.getMonth().startDate;

                if( this.checkInOutTimes.FindAll(d => d >= monthStart).Count == 0)
                {
                    //If there a no other checkInOutTimes in the current month -> first checkIn in new month
                    // -> call endOfMonthCallback
                    //callback should handler at least: archiving checkInOutTimes until end of last month
                    // + calc overtime in last month
                }
                else
                {
                    //checkIn is not the first of this month -> do nothing
                }

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
                TimeSpan dateOffset = now.Date - DateTime.MinValue;

                //check if there where pausetimes during the checked in time
                TimePeriod checkedInPeriod = new TimePeriod(checkInOutTimes.Last(), now);

                foreach(TimePeriod pausePeriod in pauseTimes)
                {
                    //transform pausePeriod to today
                    pausePeriod.startDate += dateOffset;
                    pausePeriod.endDate += dateOffset;

                    if (checkedInPeriod.contains(pausePeriod.startDate) && checkedInPeriod.contains(pausePeriod.endDate))
                    {
                        //pausePeriod was during checkedInPeriod -> Add checkInOutTimes for pause
                        checkInOutTimes.Add(pausePeriod.startDate);
                        checkInOutTimes.Add(pausePeriod.endDate);
                    }
                    else
                    {
                        //pausePeriod was outside checkedInPeriod -> do nothing
                        //CheckoutTime during pause -> ignore pause -> do nothing
                    }

                    //check if there where a month-change during the checked in time
                    if (checkedInPeriod.contains(timeHandler.getMonth().startDate))
                    {
                        //there where a month-change during checkedInPeriod -> split worktime up into last-month and this month
                        //add 23:59:59 at last day of the last month as checkout Time
                        checkInOutTimes.Add(timeHandler.getMonth().startDate - new TimeSpan(0, 0, 1));

                        //call endOfMonthCallback
                        //callback should handler at least: archiving checkInOutTimes until end of last month
                        // + calc overtime in last month

                        //add 00:00:00 as checkInTime
                        checkInOutTimes.Add(timeHandler.getMonth().startDate);
                    }
                    else
                    {
                        //no change of month during checkedInTime -> do nothing
                    }
                }

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
        ///  Returns the overtime in upto the date represented by timeHandler
        /// </summary>
        /// <param name="timeHandler">TimeHandler that represents the curren time</param>
        /// <returns>Overtime upto the time represented by timehandler</returns>
        public TimeSpan getOvertime(TimeHandler timeHandler)
        {
            TimeSpan contractedTime = calculateContractTime(timeHandler);
            TimeSpan workedTime = getTimeWorkedIn(timeHandler.getMonth());

            //don't add undertime until end of month if the workedTime isn't greater than the contractedTime
            return (contractedTime > workedTime) ? overTime : overTime + workedTime - contractedTime;
        }

        /// <summary>
        /// Returns a timespan for the worked Time in period until now
        /// </summary>
        /// <param name="period">TimePeriod for that the workedTime should be calculated</param>
        /// <returns>timespan containing the time worked in period</returns>
        public TimeSpan getTimeWorkedIn(TimePeriod period)
        {
            TimeSpan workTime = new TimeSpan();
            //iterates over checkOUT times only
            for (int i = 1; i < this.checkInOutTimes.Count; i+=2)
            {
                DateTime startDate = this.checkInOutTimes[i - 1];
                DateTime endDate = this.checkInOutTimes[i];


                if(period.contains(startDate))
                {
                    workTime += endDate - startDate;
                }
                else
                {
                    //checkInOutTime is not in this month -> do nothing
                }
            }
            return workTime;
        }

        /// <summary>
        /// Calculates the contracted for the month in which the current date of the timeHandler lies
        /// </summary>
        /// <param name="timeHandler">timeHandler selecting the month for that the contractedTime should be calculated</param>
        /// <returns>TimeSpan representing the contractedTime</returns>
        public TimeSpan calculateContractTime(TimeHandler timeHandler)
        {
            TimePeriod monthPeriod = timeHandler.getMonth();

            TimeSpan contractTime = monthPeriod.getBusinessDays() * (weekTimeLimit / 5);

            //subtract vacation from contracttime
            foreach(VacationRequest vacationRequest in vacations)
            {
                if(vacationRequest.state == RequestState.accepted)
                {
                    TimePeriod boundedPeriod = vacationRequest.boundTo(monthPeriod);
                    if (boundedPeriod.startDate != boundedPeriod.endDate)
                    { 
                        contractTime -= monthPeriod.getBusinessDays() * (weekTimeLimit / 5);
                    }
                    else
                    {
                        //Vacation is not in current Month -> do nothing
                    }
                }
                else
                {
                    //vacation not granted -> not taken and time should not be subtracted
                }
            }

            //subtract sickdays from contractTime
            foreach(TimePeriod sickDay in sickDays)
            {
                TimePeriod boundedPeriod = sickDay.boundTo(monthPeriod);

                if (boundedPeriod.startDate != boundedPeriod.endDate)
                {
                    contractTime -= monthPeriod.getBusinessDays() * (weekTimeLimit / 5);
                }
                else
                {
                    //Sickday is not in current Month -> do nothing
                }
            }

            // contractTime now contains the time the employee should work this month
            return contractTime;
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

                        case "vacationHalfDaysLeft":
                            this.vacationHalfDaysLeft = Int32.Parse(value);
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
    }

    /// <summary>
    /// Basic class for management of all employees and the information to identify the owner of the system.
    /// </summary>
    public class CompanyData
    {
        public Dictionary<string, Employee> employees { get; private set; }
        private string logoPath { get; set; }
        private string companyName { get; set; }


        public CompanyData(string companyName, Dictionary<string, Employee> employees, string logoPath = "logo.png")
        {
            this.employees = employees;
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