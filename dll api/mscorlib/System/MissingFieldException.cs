using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when there is an attempt to dynamically access a field that does not exist. If a field in a class library has been removed or renamed, recompile any assemblies that reference that library.</summary>
	// Token: 0x02000129 RID: 297
	[Serializable]
	public class MissingFieldException : MissingMemberException, ISerializable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.MissingFieldException" /> class.</summary>
		// Token: 0x06000B83 RID: 2947 RVA: 0x0002FE0B File Offset: 0x0002E00B
		public MissingFieldException() : base("Attempted to access a non-existing field.")
		{
			base.HResult = -2146233071;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.MissingFieldException" /> class with a specified error message.</summary>
		/// <param name="message">A <see cref="T:System.String" /> that describes the error. </param>
		// Token: 0x06000B84 RID: 2948 RVA: 0x0002FE23 File Offset: 0x0002E023
		public MissingFieldException(string message) : base(message)
		{
			base.HResult = -2146233071;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.MissingFieldException" /> class with the specified class name and field name.</summary>
		/// <param name="className">The name of the class in which access to a nonexistent field was attempted. </param>
		/// <param name="fieldName">The name of the field that cannot be accessed. </param>
		// Token: 0x06000B85 RID: 2949 RVA: 0x0001DF26 File Offset: 0x0001C126
		public MissingFieldException(string className, string fieldName)
		{
			this.ClassName = className;
			this.MemberName = fieldName;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.MissingFieldException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		// Token: 0x06000B86 RID: 2950 RVA: 0x0001DF3C File Offset: 0x0001C13C
		protected MissingFieldException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Gets the text string showing the signature of the missing field, the class name, and the field name. This property is read-only.</summary>
		/// <returns>The error message string.</returns>
		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x0002FE38 File Offset: 0x0002E038
		public override string Message
		{
			get
			{
				if (this.ClassName == null)
				{
					return base.Message;
				}
				return SR.Format("Field '{0}' not found.", ((this.Signature != null) ? (MissingMemberException.FormatSignature(this.Signature) + " ") : "") + this.ClassName + "." + this.MemberName);
			}
		}
	}
}
