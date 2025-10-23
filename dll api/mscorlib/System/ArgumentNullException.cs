using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when a null reference (<see langword="Nothing" /> in Visual Basic) is passed to a method that does not accept it as a valid argument. </summary>
	// Token: 0x02000079 RID: 121
	[Serializable]
	public class ArgumentNullException : ArgumentException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ArgumentNullException" /> class.</summary>
		// Token: 0x06000287 RID: 647 RVA: 0x0000E884 File Offset: 0x0000CA84
		public ArgumentNullException() : base("Value cannot be null.")
		{
			base.HResult = -2147467261;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ArgumentNullException" /> class with the name of the parameter that causes this exception.</summary>
		/// <param name="paramName">The name of the parameter that caused the exception. </param>
		// Token: 0x06000288 RID: 648 RVA: 0x0000E89C File Offset: 0x0000CA9C
		public ArgumentNullException(string paramName) : base("Value cannot be null.", paramName)
		{
			base.HResult = -2147467261;
		}

		/// <summary>Initializes an instance of the <see cref="T:System.ArgumentNullException" /> class with a specified error message and the name of the parameter that causes this exception.</summary>
		/// <param name="paramName">The name of the parameter that caused the exception. </param>
		/// <param name="message">A message that describes the error. </param>
		// Token: 0x06000289 RID: 649 RVA: 0x0000E8B5 File Offset: 0x0000CAB5
		public ArgumentNullException(string paramName, string message) : base(message, paramName)
		{
			base.HResult = -2147467261;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ArgumentNullException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">An object that describes the source or destination of the serialized data. </param>
		// Token: 0x0600028A RID: 650 RVA: 0x0000E8CA File Offset: 0x0000CACA
		protected ArgumentNullException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
