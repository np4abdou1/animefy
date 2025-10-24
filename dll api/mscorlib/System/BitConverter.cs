using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Converts base data types to an array of bytes, and an array of bytes to base data types.</summary>
	// Token: 0x02000085 RID: 133
	public static class BitConverter
	{
		/// <summary>Returns the specified Boolean value as a byte array.</summary>
		/// <param name="value">A Boolean value. </param>
		/// <returns>A byte array with length 1.</returns>
		// Token: 0x060002D0 RID: 720 RVA: 0x0000EF52 File Offset: 0x0000D152
		public static byte[] GetBytes(bool value)
		{
			return new byte[]
			{
				value ? 1 : 0
			};
		}

		/// <summary>Returns the specified Unicode character value as an array of bytes.</summary>
		/// <param name="value">A character to convert. </param>
		/// <returns>An array of bytes with length 2.</returns>
		// Token: 0x060002D1 RID: 721 RVA: 0x0000EF64 File Offset: 0x0000D164
		public unsafe static byte[] GetBytes(char value)
		{
			byte[] array = new byte[2];
			*Unsafe.As<byte, char>(ref array[0]) = value;
			return array;
		}

		/// <summary>Returns the specified 16-bit signed integer value as an array of bytes.</summary>
		/// <param name="value">The number to convert. </param>
		/// <returns>An array of bytes with length 2.</returns>
		// Token: 0x060002D2 RID: 722 RVA: 0x0000EF7A File Offset: 0x0000D17A
		public unsafe static byte[] GetBytes(short value)
		{
			byte[] array = new byte[2];
			*Unsafe.As<byte, short>(ref array[0]) = value;
			return array;
		}

		/// <summary>Returns the specified 32-bit signed integer value as an array of bytes.</summary>
		/// <param name="value">The number to convert. </param>
		/// <returns>An array of bytes with length 4.</returns>
		// Token: 0x060002D3 RID: 723 RVA: 0x0000EF90 File Offset: 0x0000D190
		public unsafe static byte[] GetBytes(int value)
		{
			byte[] array = new byte[4];
			*Unsafe.As<byte, int>(ref array[0]) = value;
			return array;
		}

		/// <summary>Returns the specified 64-bit signed integer value as an array of bytes.</summary>
		/// <param name="value">The number to convert. </param>
		/// <returns>An array of bytes with length 8.</returns>
		// Token: 0x060002D4 RID: 724 RVA: 0x0000EFA6 File Offset: 0x0000D1A6
		public unsafe static byte[] GetBytes(long value)
		{
			byte[] array = new byte[8];
			*Unsafe.As<byte, long>(ref array[0]) = value;
			return array;
		}

		/// <summary>Returns the specified 16-bit unsigned integer value as an array of bytes.</summary>
		/// <param name="value">The number to convert. </param>
		/// <returns>An array of bytes with length 2.</returns>
		// Token: 0x060002D5 RID: 725 RVA: 0x0000EFBC File Offset: 0x0000D1BC
		[CLSCompliant(false)]
		public unsafe static byte[] GetBytes(ushort value)
		{
			byte[] array = new byte[2];
			*Unsafe.As<byte, ushort>(ref array[0]) = value;
			return array;
		}

		/// <summary>Returns the specified 32-bit unsigned integer value as an array of bytes.</summary>
		/// <param name="value">The number to convert. </param>
		/// <returns>An array of bytes with length 4.</returns>
		// Token: 0x060002D6 RID: 726 RVA: 0x0000EFD2 File Offset: 0x0000D1D2
		[CLSCompliant(false)]
		public unsafe static byte[] GetBytes(uint value)
		{
			byte[] array = new byte[4];
			*Unsafe.As<byte, uint>(ref array[0]) = value;
			return array;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000EFE8 File Offset: 0x0000D1E8
		[CLSCompliant(false)]
		public static bool TryWriteBytes(Span<byte> destination, uint value)
		{
			if (destination.Length < 4)
			{
				return false;
			}
			Unsafe.WriteUnaligned<uint>(MemoryMarshal.GetReference<byte>(destination), value);
			return true;
		}

		/// <summary>Returns the specified 64-bit unsigned integer value as an array of bytes.</summary>
		/// <param name="value">The number to convert. </param>
		/// <returns>An array of bytes with length 8.</returns>
		// Token: 0x060002D8 RID: 728 RVA: 0x0000F003 File Offset: 0x0000D203
		[CLSCompliant(false)]
		public unsafe static byte[] GetBytes(ulong value)
		{
			byte[] array = new byte[8];
			*Unsafe.As<byte, ulong>(ref array[0]) = value;
			return array;
		}

		/// <summary>Returns the specified single-precision floating point value as an array of bytes.</summary>
		/// <param name="value">The number to convert. </param>
		/// <returns>An array of bytes with length 4.</returns>
		// Token: 0x060002D9 RID: 729 RVA: 0x0000F019 File Offset: 0x0000D219
		public unsafe static byte[] GetBytes(float value)
		{
			byte[] array = new byte[4];
			*Unsafe.As<byte, float>(ref array[0]) = value;
			return array;
		}

		/// <summary>Returns the specified double-precision floating point value as an array of bytes.</summary>
		/// <param name="value">The number to convert. </param>
		/// <returns>An array of bytes with length 8.</returns>
		// Token: 0x060002DA RID: 730 RVA: 0x0000F02F File Offset: 0x0000D22F
		public unsafe static byte[] GetBytes(double value)
		{
			byte[] array = new byte[8];
			*Unsafe.As<byte, double>(ref array[0]) = value;
			return array;
		}

		/// <summary>Returns a 32-bit signed integer converted from four bytes at a specified position in a byte array.</summary>
		/// <param name="value">An array of bytes. </param>
		/// <param name="startIndex">The starting position within <paramref name="value" />. </param>
		/// <returns>A 32-bit signed integer formed by four bytes beginning at <paramref name="startIndex" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="startIndex" /> is greater than or equal to the length of <paramref name="value" /> minus 3, and is less than or equal to the length of <paramref name="value" /> minus 1.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startIndex" /> is less than zero or greater than the length of <paramref name="value" /> minus 1. </exception>
		// Token: 0x060002DB RID: 731 RVA: 0x0000F045 File Offset: 0x0000D245
		public static int ToInt32(byte[] value, int startIndex)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			if (startIndex >= value.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_Index);
			}
			if (startIndex > value.Length - 4)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall, ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<int>(ref value[startIndex]);
		}

		/// <summary>Returns a 64-bit signed integer converted from eight bytes at a specified position in a byte array.</summary>
		/// <param name="value">An array of bytes. </param>
		/// <param name="startIndex">The starting position within <paramref name="value" />. </param>
		/// <returns>A 64-bit signed integer formed by eight bytes beginning at <paramref name="startIndex" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="startIndex" /> is greater than or equal to the length of <paramref name="value" /> minus 7, and is less than or equal to the length of <paramref name="value" /> minus 1.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startIndex" /> is less than zero or greater than the length of <paramref name="value" /> minus 1. </exception>
		// Token: 0x060002DC RID: 732 RVA: 0x0000F07C File Offset: 0x0000D27C
		public static long ToInt64(byte[] value, int startIndex)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			if (startIndex >= value.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_Index);
			}
			if (startIndex > value.Length - 8)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall, ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<long>(ref value[startIndex]);
		}

		/// <summary>Converts the numeric value of each element of a specified subarray of bytes to its equivalent hexadecimal string representation.</summary>
		/// <param name="value">An array of bytes. </param>
		/// <param name="startIndex">The starting position within <paramref name="value" />. </param>
		/// <param name="length">The number of array elements in <paramref name="value" /> to convert. </param>
		/// <returns>A string of hexadecimal pairs separated by hyphens, where each pair represents the corresponding element in a subarray of <paramref name="value" />; for example, "7F-2C-4A-00".</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startIndex" /> or <paramref name="length" /> is less than zero.-or-
		///         <paramref name="startIndex" /> is greater than zero and is greater than or equal to the length of <paramref name="value" />.</exception>
		/// <exception cref="T:System.ArgumentException">The combination of <paramref name="startIndex" /> and <paramref name="length" /> does not specify a position within <paramref name="value" />; that is, the <paramref name="startIndex" /> parameter is greater than the length of <paramref name="value" /> minus the <paramref name="length" /> parameter.</exception>
		// Token: 0x060002DD RID: 733 RVA: 0x0000F0B4 File Offset: 0x0000D2B4
		public unsafe static string ToString(byte[] value, int startIndex, int length)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			if (startIndex < 0 || (startIndex >= value.Length && startIndex > 0))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_Index);
			}
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length", "Value must be positive.");
			}
			if (startIndex > value.Length - length)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall, ExceptionArgument.value);
			}
			if (length == 0)
			{
				return string.Empty;
			}
			if (length > 715827882)
			{
				throw new ArgumentOutOfRangeException("length", SR.Format("The specified length exceeds the maximum value of {0}.", 715827882));
			}
			return string.Create<ValueTuple<byte[], int, int>>(length * 3 - 1, new ValueTuple<byte[], int, int>(value, startIndex, length), delegate(Span<char> dst, [TupleElementNames(new string[]
			{
				"value",
				"startIndex",
				"length"
			})] ValueTuple<byte[], int, int> state)
			{
				ReadOnlySpan<byte> readOnlySpan = new ReadOnlySpan<byte>(state.Item1, state.Item2, state.Item3);
				int i = 0;
				int num = 0;
				byte b = *readOnlySpan[i++];
				*dst[num++] = "0123456789ABCDEF"[b >> 4];
				*dst[num++] = "0123456789ABCDEF"[(int)(b & 15)];
				while (i < readOnlySpan.Length)
				{
					b = *readOnlySpan[i++];
					*dst[num++] = '-';
					*dst[num++] = "0123456789ABCDEF"[b >> 4];
					*dst[num++] = "0123456789ABCDEF"[(int)(b & 15)];
				}
			});
		}

		/// <summary>Converts the numeric value of each element of a specified array of bytes to its equivalent hexadecimal string representation.</summary>
		/// <param name="value">An array of bytes. </param>
		/// <returns>A string of hexadecimal pairs separated by hyphens, where each pair represents the corresponding element in <paramref name="value" />; for example, "7F-2C-4A-00".</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />. </exception>
		// Token: 0x060002DE RID: 734 RVA: 0x0000F167 File Offset: 0x0000D367
		public static string ToString(byte[] value)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			return BitConverter.ToString(value, 0, value.Length);
		}

		/// <summary>Converts the specified double-precision floating point number to a 64-bit signed integer.</summary>
		/// <param name="value">The number to convert. </param>
		/// <returns>A 64-bit signed integer whose value is equivalent to <paramref name="value" />.</returns>
		// Token: 0x060002DF RID: 735 RVA: 0x0000F17D File Offset: 0x0000D37D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static long DoubleToInt64Bits(double value)
		{
			return *(long*)(&value);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000F183 File Offset: 0x0000D383
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static int SingleToInt32Bits(float value)
		{
			return *(int*)(&value);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000F18C File Offset: 0x0000D38C
		unsafe static BitConverter()
		{
			ushort num = 4660;
			byte* ptr = (byte*)(&num);
			BitConverter.IsLittleEndian = (*ptr == 52);
		}

		/// <summary>Indicates the byte order ("endianness") in which data is stored in this computer architecture.</summary>
		/// <returns>
		///   <see langword="true" /> if the architecture is little-endian; <see langword="false" /> if it is big-endian. </returns>
		// Token: 0x040001CB RID: 459
		[Intrinsic]
		public static readonly bool IsLittleEndian;
	}
}
