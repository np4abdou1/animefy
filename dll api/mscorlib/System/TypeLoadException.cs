using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
	/// <summary>The exception that is thrown when type-loading failures occur.</summary>
	// Token: 0x0200015D RID: 349
	[ComVisible(true)]
	[Serializable]
	public class TypeLoadException : SystemException, ISerializable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.TypeLoadException" /> class.</summary>
		// Token: 0x06000DF7 RID: 3575 RVA: 0x0003B6F7 File Offset: 0x000398F7
		public TypeLoadException() : base(Environment.GetResourceString("Failure has occurred while loading a type."))
		{
			base.SetErrorCode(-2146233054);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.TypeLoadException" /> class with a specified error message.</summary>
		/// <param name="message">The message that describes the error. </param>
		// Token: 0x06000DF8 RID: 3576 RVA: 0x0003B714 File Offset: 0x00039914
		public TypeLoadException(string message) : base(message)
		{
			base.SetErrorCode(-2146233054);
		}

		/// <summary>Gets the error message for this exception.</summary>
		/// <returns>The error message string.</returns>
		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x0003B728 File Offset: 0x00039928
		public override string Message
		{
			[SecuritySafeCritical]
			get
			{
				this.SetMessageField();
				return this._message;
			}
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x0003B738 File Offset: 0x00039938
		[SecurityCritical]
		private void SetMessageField()
		{
			if (this._message == null)
			{
				if (this.ClassName == null && this.ResourceId == 0)
				{
					this._message = Environment.GetResourceString("Failure has occurred while loading a type.");
					return;
				}
				if (this.AssemblyName == null)
				{
					this.AssemblyName = Environment.GetResourceString("[Unknown]");
				}
				if (this.ClassName == null)
				{
					this.ClassName = Environment.GetResourceString("[Unknown]");
				}
				string format = "Could not load type '{0}' from assembly '{1}'.";
				this._message = string.Format(CultureInfo.CurrentCulture, format, this.ClassName, this.AssemblyName, this.MessageArg);
			}
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x0003B7C9 File Offset: 0x000399C9
		private TypeLoadException(string className, string assemblyName) : this(className, assemblyName, null, 0)
		{
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x0003B7D5 File Offset: 0x000399D5
		[SecurityCritical]
		private TypeLoadException(string className, string assemblyName, string messageArg, int resourceId) : base(null)
		{
			base.SetErrorCode(-2146233054);
			this.ClassName = className;
			this.AssemblyName = assemblyName;
			this.MessageArg = messageArg;
			this.ResourceId = resourceId;
			this.SetMessageField();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.TypeLoadException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> object is <see langword="null" />. </exception>
		// Token: 0x06000DFD RID: 3581 RVA: 0x0003B80C File Offset: 0x00039A0C
		protected TypeLoadException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			this.ClassName = info.GetString("TypeLoadClassName");
			this.AssemblyName = info.GetString("TypeLoadAssemblyName");
			this.MessageArg = info.GetString("TypeLoadMessageArg");
			this.ResourceId = info.GetInt32("TypeLoadResourceID");
		}

		/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the class name, method name, resource ID, and additional exception information.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> object is <see langword="null" />. </exception>
		// Token: 0x06000DFE RID: 3582 RVA: 0x0003B874 File Offset: 0x00039A74
		[SecurityCritical]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			base.GetObjectData(info, context);
			info.AddValue("TypeLoadClassName", this.ClassName, typeof(string));
			info.AddValue("TypeLoadAssemblyName", this.AssemblyName, typeof(string));
			info.AddValue("TypeLoadMessageArg", this.MessageArg, typeof(string));
			info.AddValue("TypeLoadResourceID", this.ResourceId);
		}

		// Token: 0x040004F9 RID: 1273
		private string ClassName;

		// Token: 0x040004FA RID: 1274
		private string AssemblyName;

		// Token: 0x040004FB RID: 1275
		private string MessageArg;

		// Token: 0x040004FC RID: 1276
		internal int ResourceId;
	}
}
