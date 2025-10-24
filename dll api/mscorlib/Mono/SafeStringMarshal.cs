using System;
using System.Runtime.CompilerServices;

namespace Mono
{
	// Token: 0x02000028 RID: 40
	internal struct SafeStringMarshal : IDisposable
	{
		// Token: 0x06000058 RID: 88
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr StringToUtf8_icall(ref string str);

		// Token: 0x06000059 RID: 89 RVA: 0x000029C7 File Offset: 0x00000BC7
		public static IntPtr StringToUtf8(string str)
		{
			return SafeStringMarshal.StringToUtf8_icall(ref str);
		}

		// Token: 0x0600005A RID: 90
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GFree(IntPtr ptr);

		// Token: 0x0600005B RID: 91 RVA: 0x000029D0 File Offset: 0x00000BD0
		public SafeStringMarshal(string str)
		{
			this.str = str;
			this.marshaled_string = IntPtr.Zero;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600005C RID: 92 RVA: 0x000029E4 File Offset: 0x00000BE4
		public IntPtr Value
		{
			get
			{
				if (this.marshaled_string == IntPtr.Zero && this.str != null)
				{
					this.marshaled_string = SafeStringMarshal.StringToUtf8(this.str);
				}
				return this.marshaled_string;
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002A17 File Offset: 0x00000C17
		public void Dispose()
		{
			if (this.marshaled_string != IntPtr.Zero)
			{
				SafeStringMarshal.GFree(this.marshaled_string);
				this.marshaled_string = IntPtr.Zero;
			}
		}

		// Token: 0x040000B9 RID: 185
		private readonly string str;

		// Token: 0x040000BA RID: 186
		private IntPtr marshaled_string;
	}
}
