using System;

namespace ShapeClases
{
	public class MyException : ApplicationException
	{
		public MyException()
			: base() { }

		public MyException(String message)
			: base(message) { }

		public MyException(String message, Exception innerException)
			: base(message, innerException) { }

		public MyException(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context)
			: base(info, context) { }     	}
}

