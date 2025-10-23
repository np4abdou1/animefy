using System;
using System.Diagnostics;

namespace System.Runtime.ExceptionServices
{
	/// <summary>Represents an exception whose state is captured at a certain point in code. </summary>
	// Token: 0x02000430 RID: 1072
	public sealed class ExceptionDispatchInfo
	{
		// Token: 0x06001FDE RID: 8158 RVA: 0x00087B54 File Offset: 0x00085D54
		private ExceptionDispatchInfo(Exception exception)
		{
			this.m_Exception = exception;
			StackTrace[] captured_traces = exception.captured_traces;
			int num = (captured_traces == null) ? 0 : captured_traces.Length;
			StackTrace[] array = new StackTrace[num + 1];
			if (num != 0)
			{
				Array.Copy(captured_traces, 0, array, 0, num);
			}
			array[num] = new StackTrace(exception, 0, true);
			this.m_stackTrace = array;
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06001FDF RID: 8159 RVA: 0x00087BA7 File Offset: 0x00085DA7
		internal object BinaryStackTraceArray
		{
			get
			{
				return this.m_stackTrace;
			}
		}

		/// <summary>Creates an <see cref="T:System.Runtime.ExceptionServices.ExceptionDispatchInfo" /> object that represents the specified exception at the current point in code. </summary>
		/// <param name="source">The exception whose state is captured, and which is represented by the returned object. </param>
		/// <returns>An object that represents the specified exception at the current point in code. </returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="source" /> is <see langword="null" />. </exception>
		// Token: 0x06001FE0 RID: 8160 RVA: 0x00087BAF File Offset: 0x00085DAF
		public static ExceptionDispatchInfo Capture(Exception source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source", Environment.GetResourceString("Object cannot be null."));
			}
			return new ExceptionDispatchInfo(source);
		}

		/// <summary>Gets the exception that is represented by the current instance. </summary>
		/// <returns>The exception that is represented by the current instance. </returns>
		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x00087BCF File Offset: 0x00085DCF
		public Exception SourceException
		{
			get
			{
				return this.m_Exception;
			}
		}

		/// <summary>Throws the exception that is represented by the current <see cref="T:System.Runtime.ExceptionServices.ExceptionDispatchInfo" /> object, after restoring the state that was saved when the exception was captured. </summary>
		// Token: 0x06001FE2 RID: 8162 RVA: 0x00087BD7 File Offset: 0x00085DD7
		[StackTraceHidden]
		public void Throw()
		{
			this.m_Exception.RestoreExceptionDispatchInfo(this);
			throw this.m_Exception;
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x00087BEB File Offset: 0x00085DEB
		[StackTraceHidden]
		public static void Throw(Exception source)
		{
			ExceptionDispatchInfo.Capture(source).Throw();
		}

		// Token: 0x04000F27 RID: 3879
		private Exception m_Exception;

		// Token: 0x04000F28 RID: 3880
		private object m_stackTrace;
	}
}
