using System;


namespace _09._06._14.Exeption
{
    class ImosibilytiOfPerformanceExeption : ApplicationException
    {
        public ImosibilytiOfPerformanceExeption() :base () { }

        public ImosibilytiOfPerformanceExeption(String message) : base(message) { }

        public ImosibilytiOfPerformanceExeption(String message, Exception innerException)
            : base(message, innerException) { }

        public ImosibilytiOfPerformanceExeption(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
