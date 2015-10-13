using System;


namespace _09._06._14.Exeption
{
    class Crunch : ImosibilytiOfPerformanceExeption
    {
        public Crunch() : base() { }

        public Crunch(String message)
            : base(message) { }
        public Crunch(String message, Exception innerExeption)
            : base(message, innerExeption) { }
        public Crunch(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }


      }

    
}
