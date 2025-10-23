using System;
using System.Runtime.Serialization;

namespace System.Threading
{
	/// <summary>The exception that is thrown when one thread acquires a <see cref="T:System.Threading.Mutex" /> object that another thread has abandoned by exiting without releasing it.</summary>
	// Token: 0x020001A0 RID: 416
	[Serializable]
	public class AbandonedMutexException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.AbandonedMutexException" /> class with default values.</summary>
		// Token: 0x0600103E RID: 4158 RVA: 0x00044117 File Offset: 0x00042317
		public AbandonedMutexException() : base("The wait completed due to an abandoned mutex.")
		{
			base.HResult = -2146233043;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.AbandonedMutexException" /> class with a specified index for the abandoned mutex, if applicable, and a <see cref="T:System.Threading.Mutex" /> object that represents the mutex.</summary>
		/// <param name="location">The index of the abandoned mutex in the array of wait handles if the exception is thrown for the <see cref="Overload:System.Threading.WaitHandle.WaitAny" /> method, or –1 if the exception is thrown for the <see cref="Overload:System.Threading.WaitHandle.WaitOne" /> or <see cref="Overload:System.Threading.WaitHandle.WaitAll" /> methods.</param>
		/// <param name="handle">A <see cref="T:System.Threading.Mutex" /> object that represents the abandoned mutex.</param>
		// Token: 0x0600103F RID: 4159 RVA: 0x00044136 File Offset: 0x00042336
		public AbandonedMutexException(int location, WaitHandle handle) : base("The wait completed due to an abandoned mutex.")
		{
			base.HResult = -2146233043;
			this.SetupException(location, handle);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.AbandonedMutexException" /> class with serialized data.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object that holds the serialized object data about the exception being thrown. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> object that contains contextual information about the source or destination.</param>
		// Token: 0x06001040 RID: 4160 RVA: 0x0004415D File Offset: 0x0004235D
		protected AbandonedMutexException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x0004416E File Offset: 0x0004236E
		private void SetupException(int location, WaitHandle handle)
		{
			this._mutexIndex = location;
			if (handle != null)
			{
				this._mutex = (handle as Mutex);
			}
		}

		// Token: 0x04000628 RID: 1576
		private int _mutexIndex = -1;

		// Token: 0x04000629 RID: 1577
		private Mutex _mutex;
	}
}
