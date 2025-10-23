using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Security
{
	/// <summary>The exception that is thrown when a security error is detected.</summary>
	// Token: 0x02000287 RID: 647
	[ComVisible(true)]
	[Serializable]
	public class SecurityException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.SecurityException" /> class with default properties.</summary>
		// Token: 0x0600168D RID: 5773 RVA: 0x0005C2F8 File Offset: 0x0005A4F8
		public SecurityException() : this(Locale.GetText("A security error has been detected."))
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.SecurityException" /> class with a specified error message.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		// Token: 0x0600168E RID: 5774 RVA: 0x0005C30A File Offset: 0x0005A50A
		public SecurityException(string message) : base(message)
		{
			base.HResult = -2146233078;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.SecurityException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info " />is<see langword=" null" />.</exception>
		// Token: 0x0600168F RID: 5775 RVA: 0x0005C320 File Offset: 0x0005A520
		protected SecurityException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			base.HResult = -2146233078;
			SerializationInfoEnumerator enumerator = info.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (enumerator.Name == "PermissionState")
				{
					this.permissionState = (string)enumerator.Value;
					return;
				}
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.SecurityException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		/// <param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not <see langword="null" />, the current exception is raised in a <see langword="catch" /> block that handles the inner exception. </param>
		// Token: 0x06001690 RID: 5776 RVA: 0x0005C375 File Offset: 0x0005A575
		public SecurityException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233078;
		}

		/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the <see cref="T:System.Security.SecurityException" />.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06001691 RID: 5777 RVA: 0x0005C38C File Offset: 0x0005A58C
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			try
			{
				info.AddValue("PermissionState", this.permissionState);
			}
			catch (SecurityException)
			{
			}
		}

		/// <summary>Returns a representation of the current <see cref="T:System.Security.SecurityException" />.</summary>
		/// <returns>A string representation of the current <see cref="T:System.Security.SecurityException" />.</returns>
		// Token: 0x06001692 RID: 5778 RVA: 0x0005C3C8 File Offset: 0x0005A5C8
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x040008C8 RID: 2248
		private string permissionState;
	}
}
