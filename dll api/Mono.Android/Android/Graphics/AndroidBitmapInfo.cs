using System;

namespace Android.Graphics
{
	// Token: 0x02000231 RID: 561
	public struct AndroidBitmapInfo : IEquatable<AndroidBitmapInfo>
	{
		// Token: 0x060013C7 RID: 5063 RVA: 0x000332DF File Offset: 0x000314DF
		public override int GetHashCode()
		{
			return (int)(this.width ^ this.height ^ this.stride ^ (uint)this.format ^ this.flags);
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x00033303 File Offset: 0x00031503
		public override bool Equals(object value)
		{
			return value is AndroidBitmapInfo && this.Equals((AndroidBitmapInfo)value);
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x0003331C File Offset: 0x0003151C
		public bool Equals(AndroidBitmapInfo value)
		{
			return value.width == this.width && value.height == this.height && value.stride == this.stride && value.format == this.format && value.flags == this.flags;
		}

		// Token: 0x040008B7 RID: 2231
		internal uint width;

		// Token: 0x040008B8 RID: 2232
		internal uint height;

		// Token: 0x040008B9 RID: 2233
		internal uint stride;

		// Token: 0x040008BA RID: 2234
		internal int format;

		// Token: 0x040008BB RID: 2235
		internal uint flags;
	}
}
