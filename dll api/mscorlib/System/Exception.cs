using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
	/// <summary>Represents errors that occur during application execution.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x0200014A RID: 330
	[ComVisible(true)]
	[Serializable]
	[StructLayout(0)]
	public class Exception : ISerializable
	{
		// Token: 0x06000CBE RID: 3262 RVA: 0x0003561F File Offset: 0x0003381F
		private void Init()
		{
			this._message = null;
			this._stackTrace = null;
			this._dynamicMethods = null;
			this.HResult = -2146233088;
			this._safeSerializationManager = new SafeSerializationManager();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Exception" /> class.</summary>
		// Token: 0x06000CBF RID: 3263 RVA: 0x0003564C File Offset: 0x0003384C
		public Exception()
		{
			this.Init();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Exception" /> class with a specified error message.</summary>
		/// <param name="message">The message that describes the error. </param>
		// Token: 0x06000CC0 RID: 3264 RVA: 0x0003565A File Offset: 0x0003385A
		public Exception(string message)
		{
			this.Init();
			this._message = message;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Exception" /> class with a specified error message and a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="message">The error message that explains the reason for the exception. </param>
		/// <param name="innerException">The exception that is the cause of the current exception, or a null reference (<see langword="Nothing" /> in Visual Basic) if no inner exception is specified. </param>
		// Token: 0x06000CC1 RID: 3265 RVA: 0x0003566F File Offset: 0x0003386F
		public Exception(string message, Exception innerException)
		{
			this.Init();
			this._message = message;
			this._innerException = innerException;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Exception" /> class with serialized data.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is <see langword="null" />. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is <see langword="null" /> or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
		// Token: 0x06000CC2 RID: 3266 RVA: 0x0003568C File Offset: 0x0003388C
		[SecuritySafeCritical]
		protected Exception(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			this._className = info.GetString("ClassName");
			this._message = info.GetString("Message");
			this._data = (IDictionary)info.GetValueNoThrow("Data", typeof(IDictionary));
			this._innerException = (Exception)info.GetValue("InnerException", typeof(Exception));
			this._helpURL = info.GetString("HelpURL");
			this._stackTraceString = info.GetString("StackTraceString");
			this._remoteStackTraceString = info.GetString("RemoteStackTraceString");
			this._remoteStackIndex = info.GetInt32("RemoteStackIndex");
			this.HResult = info.GetInt32("HResult");
			this._source = info.GetString("Source");
			this._safeSerializationManager = (info.GetValueNoThrow("SafeSerializationManager", typeof(SafeSerializationManager)) as SafeSerializationManager);
			if (this._className == null || this.HResult == 0)
			{
				throw new SerializationException(Environment.GetResourceString("Insufficient state to return the real object."));
			}
			if (context.State == StreamingContextStates.CrossAppDomain)
			{
				this._remoteStackTraceString += this._stackTraceString;
				this._stackTraceString = null;
			}
		}

		/// <summary>Gets a message that describes the current exception.</summary>
		/// <returns>The error message that explains the reason for the exception, or an empty string ("").</returns>
		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x000357E1 File Offset: 0x000339E1
		public virtual string Message
		{
			get
			{
				if (this._message == null)
				{
					if (this._className == null)
					{
						this._className = this.GetClassName();
					}
					return Environment.GetResourceString("Exception of type '{0}' was thrown.", new object[]
					{
						this._className
					});
				}
				return this._message;
			}
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x0003581F File Offset: 0x00033A1F
		private string GetClassName()
		{
			if (this._className == null)
			{
				this._className = this.GetType().ToString();
			}
			return this._className;
		}

		/// <summary>Gets the <see cref="T:System.Exception" /> instance that caused the current exception.</summary>
		/// <returns>An object that describes the error that caused the current exception. The <see cref="P:System.Exception.InnerException" /> property returns the same value as was passed into the <see cref="M:System.Exception.#ctor(System.String,System.Exception)" /> constructor, or <see langword="null" /> if the inner exception value was not supplied to the constructor. This property is read-only.</returns>
		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x00035840 File Offset: 0x00033A40
		public Exception InnerException
		{
			get
			{
				return this._innerException;
			}
		}

		/// <summary>Gets a string representation of the immediate frames on the call stack.</summary>
		/// <returns>A string that describes the immediate frames of the call stack.</returns>
		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x00035848 File Offset: 0x00033A48
		public virtual string StackTrace
		{
			get
			{
				return this.GetStackTrace(true);
			}
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00035854 File Offset: 0x00033A54
		private string GetStackTrace(bool needFileInfo)
		{
			string text = this._stackTraceString;
			string text2 = this._remoteStackTraceString;
			if (!needFileInfo)
			{
				text = this.StripFileInfo(text, false);
				text2 = this.StripFileInfo(text2, true);
			}
			if (text != null)
			{
				return text2 + text;
			}
			if (this._stackTrace == null)
			{
				return text2;
			}
			string stackTrace = Environment.GetStackTrace(this, needFileInfo);
			return text2 + stackTrace;
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x000358A8 File Offset: 0x00033AA8
		internal void SetErrorCode(int hr)
		{
			this.HResult = hr;
		}

		/// <summary>Gets or sets a link to the help file associated with this exception.</summary>
		/// <returns>The Uniform Resource Name (URN) or Uniform Resource Locator (URL).</returns>
		// Token: 0x17000105 RID: 261
		// (set) Token: 0x06000CC9 RID: 3273 RVA: 0x000358B1 File Offset: 0x00033AB1
		public virtual string HelpLink
		{
			set
			{
				this._helpURL = value;
			}
		}

		/// <summary>Gets or sets the name of the application or the object that causes the error.</summary>
		/// <returns>The name of the application or the object that causes the error.</returns>
		/// <exception cref="T:System.ArgumentException">The object must be a runtime <see cref="N:System.Reflection" /> object</exception>
		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x000358BC File Offset: 0x00033ABC
		// (set) Token: 0x06000CCB RID: 3275 RVA: 0x00035919 File Offset: 0x00033B19
		public virtual string Source
		{
			get
			{
				if (this._source == null)
				{
					StackTrace stackTrace = new StackTrace(this, true);
					if (stackTrace.FrameCount > 0)
					{
						MethodBase method = stackTrace.GetFrame(0).GetMethod();
						if (method != null)
						{
							this._source = method.DeclaringType.Assembly.GetName().Name;
						}
					}
				}
				return this._source;
			}
			set
			{
				this._source = value;
			}
		}

		/// <summary>Creates and returns a string representation of the current exception.</summary>
		/// <returns>A string representation of the current exception.</returns>
		// Token: 0x06000CCC RID: 3276 RVA: 0x00035922 File Offset: 0x00033B22
		public override string ToString()
		{
			return this.ToString(true, true);
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x0003592C File Offset: 0x00033B2C
		private string ToString(bool needFileLineInfo, bool needMessage)
		{
			string text = needMessage ? this.Message : null;
			string text2;
			if (text == null || text.Length <= 0)
			{
				text2 = this.GetClassName();
			}
			else
			{
				text2 = this.GetClassName() + ": " + text;
			}
			if (this._innerException != null)
			{
				text2 = string.Concat(new string[]
				{
					text2,
					" ---> ",
					this._innerException.ToString(needFileLineInfo, needMessage),
					Environment.NewLine,
					"   ",
					Environment.GetResourceString("--- End of inner exception stack trace ---")
				});
			}
			string stackTrace = this.GetStackTrace(needFileLineInfo);
			if (stackTrace != null)
			{
				text2 = text2 + Environment.NewLine + stackTrace;
			}
			return text2;
		}

		/// <summary>When overridden in a derived class, sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is a null reference (<see langword="Nothing" /> in Visual Basic). </exception>
		// Token: 0x06000CCE RID: 3278 RVA: 0x000359D4 File Offset: 0x00033BD4
		[SecurityCritical]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			string text = this._stackTraceString;
			if (this._stackTrace != null && text == null)
			{
				text = Environment.GetStackTrace(this, true);
			}
			if (this._source == null)
			{
				this._source = this.Source;
			}
			info.AddValue("ClassName", this.GetClassName(), typeof(string));
			info.AddValue("Message", this._message, typeof(string));
			info.AddValue("Data", this._data, typeof(IDictionary));
			info.AddValue("InnerException", this._innerException, typeof(Exception));
			info.AddValue("HelpURL", this._helpURL, typeof(string));
			info.AddValue("StackTraceString", text, typeof(string));
			info.AddValue("RemoteStackTraceString", this._remoteStackTraceString, typeof(string));
			info.AddValue("RemoteStackIndex", this._remoteStackIndex, typeof(int));
			info.AddValue("ExceptionMethod", null);
			info.AddValue("HResult", this.HResult);
			info.AddValue("Source", this._source, typeof(string));
			if (this._safeSerializationManager != null && this._safeSerializationManager.IsActive)
			{
				info.AddValue("SafeSerializationManager", this._safeSerializationManager, typeof(SafeSerializationManager));
				this._safeSerializationManager.CompleteSerialization(this, info, context);
			}
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x00035B6B File Offset: 0x00033D6B
		[OnDeserialized]
		private void OnDeserialized(StreamingContext context)
		{
			this._stackTrace = null;
			if (this._safeSerializationManager == null)
			{
				this._safeSerializationManager = new SafeSerializationManager();
				return;
			}
			this._safeSerializationManager.CompleteDeserialization(this);
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x00035B94 File Offset: 0x00033D94
		private string StripFileInfo(string stackTrace, bool isRemoteStackTrace)
		{
			return stackTrace;
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x00035B97 File Offset: 0x00033D97
		[SecuritySafeCritical]
		internal void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo)
		{
			this.captured_traces = (StackTrace[])exceptionDispatchInfo.BinaryStackTraceArray;
			this._stackTrace = null;
			this._stackTraceString = null;
		}

		/// <summary>Gets or sets HRESULT, a coded numerical value that is assigned to a specific exception.</summary>
		/// <returns>The HRESULT value.</returns>
		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x00035BB8 File Offset: 0x00033DB8
		// (set) Token: 0x06000CD3 RID: 3283 RVA: 0x00035BC0 File Offset: 0x00033DC0
		public int HResult
		{
			get
			{
				return this._HResult;
			}
			protected set
			{
				this._HResult = value;
			}
		}

		/// <summary>Gets the runtime type of the current instance.</summary>
		/// <returns>A <see cref="T:System.Type" /> object that represents the exact runtime type of the current instance.</returns>
		// Token: 0x06000CD4 RID: 3284 RVA: 0x0002AC6C File Offset: 0x00028E6C
		public new Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x00035BC9 File Offset: 0x00033DC9
		[SecuritySafeCritical]
		internal static string GetMessageFromNativeResources(Exception.ExceptionMessageKind kind)
		{
			switch (kind)
			{
			case Exception.ExceptionMessageKind.ThreadAbort:
				return "Thread was being aborted.";
			case Exception.ExceptionMessageKind.ThreadInterrupted:
				return "Thread was interrupted from a waiting state.";
			case Exception.ExceptionMessageKind.OutOfMemory:
				return "Insufficient memory to continue the execution of the program.";
			default:
				return "";
			}
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00035BF8 File Offset: 0x00033DF8
		internal void SetMessage(string s)
		{
			this._message = s;
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00035C04 File Offset: 0x00033E04
		internal Exception FixRemotingException()
		{
			string remoteStackTraceString = string.Format((this._remoteStackIndex == 0) ? "{0}{0}Server stack trace: {0}{1}{0}{0}Exception rethrown at [{2}]: {0}" : "{1}{0}{0}Exception rethrown at [{2}]: {0}", Environment.NewLine, this.StackTrace, this._remoteStackIndex);
			this._remoteStackTraceString = remoteStackTraceString;
			this._remoteStackIndex++;
			this._stackTraceString = null;
			return this;
		}

		// Token: 0x04000424 RID: 1060
		[OptionalField]
		private static object s_EDILock = new object();

		// Token: 0x04000425 RID: 1061
		private string _className;

		// Token: 0x04000426 RID: 1062
		internal string _message;

		// Token: 0x04000427 RID: 1063
		private IDictionary _data;

		// Token: 0x04000428 RID: 1064
		private Exception _innerException;

		// Token: 0x04000429 RID: 1065
		private string _helpURL;

		// Token: 0x0400042A RID: 1066
		private object _stackTrace;

		// Token: 0x0400042B RID: 1067
		private string _stackTraceString;

		// Token: 0x0400042C RID: 1068
		private string _remoteStackTraceString;

		// Token: 0x0400042D RID: 1069
		private int _remoteStackIndex;

		// Token: 0x0400042E RID: 1070
		private object _dynamicMethods;

		// Token: 0x0400042F RID: 1071
		internal int _HResult;

		// Token: 0x04000430 RID: 1072
		private string _source;

		// Token: 0x04000431 RID: 1073
		[OptionalField(VersionAdded = 4)]
		private SafeSerializationManager _safeSerializationManager;

		// Token: 0x04000432 RID: 1074
		internal StackTrace[] captured_traces;

		// Token: 0x04000433 RID: 1075
		private IntPtr[] native_trace_ips;

		// Token: 0x04000434 RID: 1076
		private int caught_in_unmanaged;

		// Token: 0x04000435 RID: 1077
		private const int _COMPlusExceptionCode = -532462766;

		// Token: 0x0200014B RID: 331
		internal enum ExceptionMessageKind
		{
			// Token: 0x04000437 RID: 1079
			ThreadAbort = 1,
			// Token: 0x04000438 RID: 1080
			ThreadInterrupted,
			// Token: 0x04000439 RID: 1081
			OutOfMemory
		}
	}
}
