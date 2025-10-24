using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when one of the arguments provided to a method is not valid.</summary>
	// Token: 0x02000078 RID: 120
	[Serializable]
	public class ArgumentException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ArgumentException" /> class.</summary>
		// Token: 0x0600027F RID: 639 RVA: 0x0000E78C File Offset: 0x0000C98C
		public ArgumentException() : base("Value does not fall within the expected range.")
		{
			base.HResult = -2147024809;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ArgumentException" /> class with a specified error message.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		// Token: 0x06000280 RID: 640 RVA: 0x0000E7A4 File Offset: 0x0000C9A4
		public ArgumentException(string message) : base(message)
		{
			base.HResult = -2147024809;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ArgumentException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		/// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference, the current exception is raised in a <see langword="catch" /> block that handles the inner exception. </param>
		// Token: 0x06000281 RID: 641 RVA: 0x0000E7B8 File Offset: 0x0000C9B8
		public ArgumentException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147024809;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ArgumentException" /> class with a specified error message, the parameter name, and a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		/// <param name="paramName">The name of the parameter that caused the current exception. </param>
		/// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference, the current exception is raised in a <see langword="catch" /> block that handles the inner exception. </param>
		// Token: 0x06000282 RID: 642 RVA: 0x0000E7CD File Offset: 0x0000C9CD
		public ArgumentException(string message, string paramName, Exception innerException) : base(message, innerException)
		{
			this._paramName = paramName;
			base.HResult = -2147024809;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ArgumentException" /> class with a specified error message and the name of the parameter that causes this exception.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		/// <param name="paramName">The name of the parameter that caused the current exception. </param>
		// Token: 0x06000283 RID: 643 RVA: 0x0000E7E9 File Offset: 0x0000C9E9
		public ArgumentException(string message, string paramName) : base(message)
		{
			this._paramName = paramName;
			base.HResult = -2147024809;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ArgumentException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x06000284 RID: 644 RVA: 0x0000E804 File Offset: 0x0000CA04
		protected ArgumentException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._paramName = info.GetString("ParamName");
		}

		/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the parameter name and additional exception information.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> object is a null reference (<see langword="Nothing" /> in Visual Basic). </exception>
		// Token: 0x06000285 RID: 645 RVA: 0x0000E81F File Offset: 0x0000CA1F
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("ParamName", this._paramName, typeof(string));
		}

		/// <summary>Gets the error message and the parameter name, or only the error message if no parameter name is set.</summary>
		/// <returns>A text string describing the details of the exception. The value of this property takes one of two forms: Condition Value The <paramref name="paramName" /> is a null reference (<see langword="Nothing" /> in Visual Basic) or of zero length. The <paramref name="message" /> string passed to the constructor. The <paramref name="paramName" /> is not null reference (<see langword="Nothing" /> in Visual Basic) and it has a length greater than zero. The <paramref name="message" /> string appended with the name of the invalid parameter. </returns>
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0000E844 File Offset: 0x0000CA44
		public override string Message
		{
			get
			{
				string message = base.Message;
				if (!string.IsNullOrEmpty(this._paramName))
				{
					string str = SR.Format("Parameter name: {0}", this._paramName);
					return message + Environment.NewLine + str;
				}
				return message;
			}
		}

		// Token: 0x040001A9 RID: 425
		private string _paramName;
	}
}
