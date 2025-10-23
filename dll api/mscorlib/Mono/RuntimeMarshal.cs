using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Mono
{
	// Token: 0x02000019 RID: 25
	internal static class RuntimeMarshal
	{
		// Token: 0x0600004E RID: 78 RVA: 0x0000285C File Offset: 0x00000A5C
		internal unsafe static string PtrToUtf8String(IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
			{
				return string.Empty;
			}
			byte* ptr2 = (byte*)((void*)ptr);
			int num = 0;
			try
			{
				while (*(ptr2++) != 0)
				{
					num++;
				}
			}
			catch (NullReferenceException)
			{
				throw new ArgumentOutOfRangeException("ptr", "Value does not refer to a valid string.");
			}
			return new string((sbyte*)((void*)ptr), 0, num, Encoding.UTF8);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000028C8 File Offset: 0x00000AC8
		internal static SafeStringMarshal MarshalString(string str)
		{
			return new SafeStringMarshal(str);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000028D0 File Offset: 0x00000AD0
		private unsafe static int DecodeBlobSize(IntPtr in_ptr, out IntPtr out_ptr)
		{
			byte* ptr = (byte*)((void*)in_ptr);
			uint result;
			if ((*ptr & 128) == 0)
			{
				result = (uint)(*ptr & 127);
				ptr++;
			}
			else if ((*ptr & 64) == 0)
			{
				result = (uint)(((int)(*ptr & 63) << 8) + (int)ptr[1]);
				ptr += 2;
			}
			else
			{
				result = (uint)(((int)(*ptr & 31) << 24) + ((int)ptr[1] << 16) + ((int)ptr[2] << 8) + (int)ptr[3]);
				ptr += 4;
			}
			out_ptr = (IntPtr)((void*)ptr);
			return (int)result;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002940 File Offset: 0x00000B40
		internal static byte[] DecodeBlobArray(IntPtr ptr)
		{
			IntPtr source;
			int num = RuntimeMarshal.DecodeBlobSize(ptr, out source);
			byte[] array = new byte[num];
			Marshal.Copy(source, array, 0, num);
			return array;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002967 File Offset: 0x00000B67
		internal static int AsciHexDigitValue(int c)
		{
			if (c >= 48 && c <= 57)
			{
				return c - 48;
			}
			if (c >= 97 && c <= 102)
			{
				return c - 97 + 10;
			}
			return c - 65 + 10;
		}

		// Token: 0x06000053 RID: 83
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void FreeAssemblyName(ref MonoAssemblyName name, bool freeStruct);
	}
}
