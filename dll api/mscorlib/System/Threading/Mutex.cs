using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System.Threading
{
	/// <summary>A synchronization primitive that can also be used for interprocess synchronization. </summary>
	// Token: 0x020001F1 RID: 497
	[ComVisible(true)]
	public sealed class Mutex : WaitHandle
	{
		// Token: 0x06001219 RID: 4633
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern IntPtr CreateMutex_icall(bool initiallyOwned, char* name, int name_length, out bool created);

		// Token: 0x0600121A RID: 4634
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool ReleaseMutex_internal(IntPtr handle);

		// Token: 0x0600121B RID: 4635 RVA: 0x000494D8 File Offset: 0x000476D8
		private unsafe static IntPtr CreateMutex_internal(bool initiallyOwned, string name, out bool created)
		{
			char* ptr = name;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return Mutex.CreateMutex_icall(initiallyOwned, ptr, (name != null) ? name.Length : 0, out created);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.Mutex" /> class with a Boolean value that indicates whether the calling thread should have initial ownership of the mutex.</summary>
		/// <param name="initiallyOwned">
		///       <see langword="true" /> to give the calling thread initial ownership of the mutex; otherwise, <see langword="false" />. </param>
		// Token: 0x0600121C RID: 4636 RVA: 0x0004950C File Offset: 0x0004770C
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public Mutex(bool initiallyOwned)
		{
			bool flag;
			this.Handle = Mutex.CreateMutex_internal(initiallyOwned, null, out flag);
		}

		/// <summary>Releases the <see cref="T:System.Threading.Mutex" /> once.</summary>
		/// <exception cref="T:System.ApplicationException">The calling thread does not own the mutex. </exception>
		/// <exception cref="T:System.ObjectDisposedException">The current instance has already been disposed. </exception>
		// Token: 0x0600121D RID: 4637 RVA: 0x0004952E File Offset: 0x0004772E
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public void ReleaseMutex()
		{
			if (!Mutex.ReleaseMutex_internal(this.Handle))
			{
				throw new ApplicationException("Mutex is not owned");
			}
		}
	}
}
