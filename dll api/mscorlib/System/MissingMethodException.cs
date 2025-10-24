using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when there is an attempt to dynamically access a method that does not exist.</summary>
	// Token: 0x020000D7 RID: 215
	[Serializable]
	public class MissingMethodException : MissingMemberException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.MissingMethodException" /> class.</summary>
		// Token: 0x06000723 RID: 1827 RVA: 0x0001DEE5 File Offset: 0x0001C0E5
		public MissingMethodException() : base("Attempted to access a missing method.")
		{
			base.HResult = -2146233069;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.MissingMethodException" /> class with a specified error message.</summary>
		/// <param name="message">A <see cref="T:System.String" /> that describes the error. </param>
		// Token: 0x06000724 RID: 1828 RVA: 0x0001DEFD File Offset: 0x0001C0FD
		public MissingMethodException(string message) : base(message)
		{
			base.HResult = -2146233069;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.MissingMethodException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		/// <param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not a null reference (<see langword="Nothing" /> in Visual Basic), the current exception is raised in a <see langword="catch" /> block that handles the inner exception. </param>
		// Token: 0x06000725 RID: 1829 RVA: 0x0001DF11 File Offset: 0x0001C111
		public MissingMethodException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233069;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.MissingMethodException" /> class with the specified class name and method name.</summary>
		/// <param name="className">The name of the class in which access to a nonexistent method was attempted. </param>
		/// <param name="methodName">The name of the method that cannot be accessed. </param>
		// Token: 0x06000726 RID: 1830 RVA: 0x0001DF26 File Offset: 0x0001C126
		public MissingMethodException(string className, string methodName)
		{
			this.ClassName = className;
			this.MemberName = methodName;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.MissingMethodException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x06000727 RID: 1831 RVA: 0x0001DF3C File Offset: 0x0001C13C
		protected MissingMethodException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Gets the text string showing the class name, the method name, and the signature of the missing method. This property is read-only.</summary>
		/// <returns>The error message string.</returns>
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x0001DF48 File Offset: 0x0001C148
		public override string Message
		{
			get
			{
				if (this.ClassName != null)
				{
					return SR.Format("Method '{0}' not found.", this.ClassName + "." + this.MemberName + ((this.Signature != null) ? (" " + MissingMemberException.FormatSignature(this.Signature)) : string.Empty));
				}
				return base.Message;
			}
		}
	}
}
