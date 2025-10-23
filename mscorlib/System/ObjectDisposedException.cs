using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when an operation is performed on a disposed object.</summary>
	// Token: 0x020000E3 RID: 227
	[Serializable]
	public class ObjectDisposedException : InvalidOperationException
	{
		// Token: 0x060007A6 RID: 1958 RVA: 0x00022DF9 File Offset: 0x00020FF9
		private ObjectDisposedException() : this(null, "Cannot access a disposed object.")
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ObjectDisposedException" /> class with a string containing the name of the disposed object.</summary>
		/// <param name="objectName">A string containing the name of the disposed object. </param>
		// Token: 0x060007A7 RID: 1959 RVA: 0x00022E07 File Offset: 0x00021007
		public ObjectDisposedException(string objectName) : this(objectName, "Cannot access a disposed object.")
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ObjectDisposedException" /> class with the specified object name and message.</summary>
		/// <param name="objectName">The name of the disposed object. </param>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		// Token: 0x060007A8 RID: 1960 RVA: 0x00022E15 File Offset: 0x00021015
		public ObjectDisposedException(string objectName, string message) : base(message)
		{
			base.HResult = -2146232798;
			this._objectName = objectName;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ObjectDisposedException" /> class with serialized data.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		// Token: 0x060007A9 RID: 1961 RVA: 0x00022E30 File Offset: 0x00021030
		protected ObjectDisposedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this._objectName = info.GetString("ObjectName");
		}

		/// <summary>Retrieves the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the parameter name and additional exception information.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		// Token: 0x060007AA RID: 1962 RVA: 0x00022E4B File Offset: 0x0002104B
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("ObjectName", this.ObjectName, typeof(string));
		}

		/// <summary>Gets the message that describes the error.</summary>
		/// <returns>A string that describes the error.</returns>
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x00022E70 File Offset: 0x00021070
		public override string Message
		{
			get
			{
				string objectName = this.ObjectName;
				if (objectName == null || objectName.Length == 0)
				{
					return base.Message;
				}
				string str = SR.Format("Object name: '{0}'.", objectName);
				return base.Message + Environment.NewLine + str;
			}
		}

		/// <summary>Gets the name of the disposed object.</summary>
		/// <returns>A string containing the name of the disposed object.</returns>
		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060007AC RID: 1964 RVA: 0x00022EB3 File Offset: 0x000210B3
		public string ObjectName
		{
			get
			{
				if (this._objectName == null)
				{
					return string.Empty;
				}
				return this._objectName;
			}
		}

		// Token: 0x04000345 RID: 837
		private string _objectName;
	}
}
