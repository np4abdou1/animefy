using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when there is an attempt to dynamically access a class member that does not exist or that is not declared as public. If a member in a class library has been removed or renamed, recompile any assemblies that reference that library.</summary>
	// Token: 0x0200012A RID: 298
	[Serializable]
	public class MissingMemberException : MemberAccessException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.MissingMemberException" /> class.</summary>
		// Token: 0x06000B88 RID: 2952 RVA: 0x0002FE98 File Offset: 0x0002E098
		public MissingMemberException() : base("Attempted to access a missing member.")
		{
			base.HResult = -2146233070;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.MissingMemberException" /> class with a specified error message.</summary>
		/// <param name="message">The message that describes the error. </param>
		// Token: 0x06000B89 RID: 2953 RVA: 0x0002FEB0 File Offset: 0x0002E0B0
		public MissingMemberException(string message) : base(message)
		{
			base.HResult = -2146233070;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.MissingMemberException" /> class with a specified error message and a reference to the inner exception that is the root cause of this exception.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		/// <param name="inner">An instance of <see cref="T:System.Exception" /> that is the cause of the current <see langword="Exception" />. If <paramref name="inner" /> is not a null reference (<see langword="Nothing" /> in Visual Basic), then the current <see langword="Exception" /> is raised in a catch block handling <paramref name="inner" />. </param>
		// Token: 0x06000B8A RID: 2954 RVA: 0x0002FEC4 File Offset: 0x0002E0C4
		public MissingMemberException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233070;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.MissingMemberException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x06000B8B RID: 2955 RVA: 0x0002FEDC File Offset: 0x0002E0DC
		protected MissingMemberException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.ClassName = info.GetString("MMClassName");
			this.MemberName = info.GetString("MMMemberName");
			this.Signature = (byte[])info.GetValue("MMSignature", typeof(byte[]));
		}

		/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the class name, the member name, the signature of the missing member, and additional exception information.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> object is <see langword="null" />. </exception>
		// Token: 0x06000B8C RID: 2956 RVA: 0x0002FF34 File Offset: 0x0002E134
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("MMClassName", this.ClassName, typeof(string));
			info.AddValue("MMMemberName", this.MemberName, typeof(string));
			info.AddValue("MMSignature", this.Signature, typeof(byte[]));
		}

		/// <summary>Gets the text string showing the class name, the member name, and the signature of the missing member.</summary>
		/// <returns>The error message string.</returns>
		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x0002FF9C File Offset: 0x0002E19C
		public override string Message
		{
			get
			{
				if (this.ClassName == null)
				{
					return base.Message;
				}
				return SR.Format("Member '{0}' not found.", this.ClassName + "." + this.MemberName + ((this.Signature != null) ? (" " + MissingMemberException.FormatSignature(this.Signature)) : string.Empty));
			}
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00011C1B File Offset: 0x0000FE1B
		internal static string FormatSignature(byte[] signature)
		{
			return string.Empty;
		}

		/// <summary>Holds the class name of the missing member.</summary>
		// Token: 0x040003DB RID: 987
		protected string ClassName;

		/// <summary>Holds the name of the missing member.</summary>
		// Token: 0x040003DC RID: 988
		protected string MemberName;

		/// <summary>Holds the signature of the missing member.</summary>
		// Token: 0x040003DD RID: 989
		protected byte[] Signature;
	}
}
