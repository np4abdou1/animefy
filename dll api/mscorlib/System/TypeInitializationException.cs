using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown as a wrapper around the exception thrown by the class initializer. This class cannot be inherited.</summary>
	// Token: 0x02000111 RID: 273
	[Serializable]
	public sealed class TypeInitializationException : SystemException
	{
		// Token: 0x06000A59 RID: 2649 RVA: 0x0002B3FF File Offset: 0x000295FF
		private TypeInitializationException() : base("Type constructor threw an exception.")
		{
			base.HResult = -2146233036;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.TypeInitializationException" /> class with the default error message, the specified type name, and a reference to the inner exception that is the root cause of this exception.</summary>
		/// <param name="fullTypeName">The fully qualified name of the type that fails to initialize. </param>
		/// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException" /> parameter is not a null reference (<see langword="Nothing" /> in Visual Basic), the current exception is raised in a <see langword="catch" /> block that handles the inner exception. </param>
		// Token: 0x06000A5A RID: 2650 RVA: 0x0002B417 File Offset: 0x00029617
		public TypeInitializationException(string fullTypeName, Exception innerException) : this(fullTypeName, SR.Format("The type initializer for '{0}' threw an exception.", fullTypeName), innerException)
		{
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x0002B42C File Offset: 0x0002962C
		internal TypeInitializationException(string fullTypeName, string message, Exception innerException) : base(message, innerException)
		{
			this._typeName = fullTypeName;
			base.HResult = -2146233036;
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x0002B448 File Offset: 0x00029648
		internal TypeInitializationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._typeName = info.GetString("TypeName");
		}

		/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the type name and additional exception information.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		// Token: 0x06000A5D RID: 2653 RVA: 0x0002B463 File Offset: 0x00029663
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("TypeName", this.TypeName, typeof(string));
		}

		/// <summary>Gets the fully qualified name of the type that fails to initialize.</summary>
		/// <returns>The fully qualified name of the type that fails to initialize.</returns>
		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x0002B488 File Offset: 0x00029688
		public string TypeName
		{
			get
			{
				if (this._typeName == null)
				{
					return string.Empty;
				}
				return this._typeName;
			}
		}

		// Token: 0x040003A5 RID: 933
		private string _typeName;
	}
}
