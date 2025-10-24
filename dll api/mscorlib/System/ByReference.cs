using System;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x02000133 RID: 307
	internal ref struct ByReference<T>
	{
		// Token: 0x06000C1E RID: 3102 RVA: 0x0002AD12 File Offset: 0x00028F12
		[Intrinsic]
		public ByReference(ref T value)
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x0002AD12 File Offset: 0x00028F12
		public ref T Value
		{
			[Intrinsic]
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x040003ED RID: 1005
		private IntPtr _value;
	}
}
