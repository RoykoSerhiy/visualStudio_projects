using System;


namespace _09._06._14.Exeption
{
    class EmployeeBusyExeption:ImosibilytiOfPerformanceExeption
    {
        public EmployeeBusyExeption() : base() { }

        public EmployeeBusyExeption(String message) : base(message) { }

        public EmployeeBusyExeption(String message, Exception innerExeption)
            : base(message, innerExeption) { }
        public EmployeeBusyExeption(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }

        private DateTime remainingTime;
        public DateTime RemainingTime
        {
            get { return remainingTime; }
            set { remainingTime = value; }
        }
        private String workDescription
        {
            get { return workDescription; }
            set { workDescription = value; }
        }

    }
}
