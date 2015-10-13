using System;


namespace _09._06._14.Exeption
{
    class ForceMajeureExeption : ImosibilytiOfPerformanceExeption
    {
        public ForceMajeureExeption()
            : base() { }
        public ForceMajeureExeption(String message)
            : base(message) { }
        public ForceMajeureExeption(String message,Exception innerExeption)
            :base (message,innerExeption) { }
        public ForceMajeureExeption(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }

        private String forceMajeureDescription;
        public String ForceMajeureDescription
        {
            get { return forceMajeureDescription; }
            set { forceMajeureDescription = value; }
        }
        private Decimal extentOfDamage;
        public Decimal ExtentOfDamage
        {
            get { return extentOfDamage; }
            set { extentOfDamage = value; }
        }


    }
}
