using System;
using System.Text;

namespace SQLitePCL
{
	// Token: 0x02000029 RID: 41
	public readonly ref struct utf8z
	{
		// Token: 0x060001B7 RID: 439 RVA: 0x00003270 File Offset: 0x00001470
		public ref readonly byte GetPinnableReference()
		{
			return this.sp.GetPinnableReference();
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000327D File Offset: 0x0000147D
		private utf8z(ReadOnlySpan<byte> a)
		{
			this.sp = a;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00003286 File Offset: 0x00001486
		private unsafe static utf8z FromSpan(ReadOnlySpan<byte> a)
		{
			if (a.Length > 0 && *a[a.Length - 1] != 0)
			{
				throw new ArgumentException("zero terminator required");
			}
			return new utf8z(a);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000032B6 File Offset: 0x000014B6
		public static utf8z FromString(string s)
		{
			if (s == null)
			{
				return new utf8z(ReadOnlySpan<byte>.Empty);
			}
			return new utf8z(s.to_utf8_with_z());
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000032D8 File Offset: 0x000014D8
		private unsafe static long my_strlen(byte* p)
		{
			byte* ptr = p;
			while (*ptr != 0)
			{
				ptr++;
			}
			return (long)(ptr - p);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000032F8 File Offset: 0x000014F8
		private unsafe static ReadOnlySpan<byte> find_zero_terminator(byte* p)
		{
			int num = (int)utf8z.my_strlen(p);
			return new ReadOnlySpan<byte>((void*)p, num + 1);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00003316 File Offset: 0x00001516
		public unsafe static utf8z FromPtr(byte* p)
		{
			if (p == null)
			{
				return new utf8z(ReadOnlySpan<byte>.Empty);
			}
			return new utf8z(utf8z.find_zero_terminator(p));
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00003333 File Offset: 0x00001533
		public unsafe static utf8z FromPtrLen(byte* p, int len)
		{
			if (p == null)
			{
				return new utf8z(ReadOnlySpan<byte>.Empty);
			}
			return utf8z.FromSpan(new ReadOnlySpan<byte>((void*)p, len + 1));
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00003353 File Offset: 0x00001553
		public unsafe static utf8z FromIntPtr(IntPtr p)
		{
			if (p == IntPtr.Zero)
			{
				return new utf8z(ReadOnlySpan<byte>.Empty);
			}
			return new utf8z(utf8z.find_zero_terminator((byte*)p.ToPointer()));
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00003380 File Offset: 0x00001580
		public unsafe string utf8_to_string()
		{
			if (this.sp.Length == 0)
			{
				return null;
			}
			fixed (byte* pinnableReference = this.sp.GetPinnableReference())
			{
				byte* bytes = pinnableReference;
				return Encoding.UTF8.GetString(bytes, this.sp.Length - 1);
			}
		}

		// Token: 0x040000E2 RID: 226
		private readonly ReadOnlySpan<byte> sp;
	}
}
