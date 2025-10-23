using System;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Represents a variable-length argument list; that is, the parameters of a function that takes a variable number of arguments.</summary>
	// Token: 0x0200016A RID: 362
	[StructLayout(3)]
	public struct ArgIterator
	{
		/// <summary>This method is not supported, and always throws <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="o">An object to be compared to this instance. </param>
		/// <returns>This comparison is not supported. No value is returned.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not supported. </exception>
		// Token: 0x06000E7A RID: 3706 RVA: 0x0003D269 File Offset: 0x0003B469
		public override bool Equals(object o)
		{
			throw new NotSupportedException("ArgIterator does not support Equals.");
		}

		/// <summary>Returns the hash code of this object.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000E7B RID: 3707 RVA: 0x0003D275 File Offset: 0x0003B475
		public override int GetHashCode()
		{
			return this.sig.GetHashCode();
		}

		// Token: 0x04000572 RID: 1394
		private IntPtr sig;

		// Token: 0x04000573 RID: 1395
		private IntPtr args;

		// Token: 0x04000574 RID: 1396
		private int next_arg;

		// Token: 0x04000575 RID: 1397
		private int num_args;
	}
}
