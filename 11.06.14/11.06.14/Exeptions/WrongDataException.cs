using System;

namespace ShapeClases
{
	public class WrongDataException : MyException
	{
		public WrongDataException()
			: base() { }

		public WrongDataException(String message)
			: base(message) { }

		public WrongDataException(String message,
		                       Exception innerException)
			: base(message, innerException) { }

		public WrongDataException(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context)
			: base(info, context) { }
	}
}

