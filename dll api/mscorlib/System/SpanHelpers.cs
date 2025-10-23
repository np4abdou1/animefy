using System;
using System.Globalization;
using System.Numerics;
using System.Runtime;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x020000F6 RID: 246
	internal static class SpanHelpers
	{
		// Token: 0x06000857 RID: 2135 RVA: 0x00024BA8 File Offset: 0x00022DA8
		public unsafe static int IndexOfAny(ref byte searchSpace, int searchSpaceLength, ref byte value, int valueLength)
		{
			if (valueLength == 0)
			{
				return 0;
			}
			int num = -1;
			for (int i = 0; i < valueLength; i++)
			{
				int num2 = SpanHelpers.IndexOf(ref searchSpace, *Unsafe.Add<byte>(ref value, i), searchSpaceLength);
				if (num2 < num)
				{
					num = num2;
					searchSpaceLength = num2;
					if (num == 0)
					{
						break;
					}
				}
			}
			return num;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00024BE8 File Offset: 0x00022DE8
		public unsafe static int IndexOf(ref byte searchSpace, byte value, int length)
		{
			IntPtr intPtr = (IntPtr)0;
			IntPtr intPtr2 = (IntPtr)length;
			while ((void*)intPtr2 >= 8)
			{
				intPtr2 -= 8;
				if (value == *Unsafe.AddByteOffset<byte>(ref searchSpace, intPtr))
				{
					IL_14D:
					return (void*)intPtr;
				}
				if (value == *Unsafe.AddByteOffset<byte>(ref searchSpace, intPtr + 1))
				{
					IL_155:
					return (void*)(intPtr + 1);
				}
				if (value == *Unsafe.AddByteOffset<byte>(ref searchSpace, intPtr + 2))
				{
					IL_163:
					return (void*)(intPtr + 2);
				}
				if (value == *Unsafe.AddByteOffset<byte>(ref searchSpace, intPtr + 3))
				{
					IL_171:
					return (void*)(intPtr + 3);
				}
				if (value == *Unsafe.AddByteOffset<byte>(ref searchSpace, intPtr + 4))
				{
					return (void*)(intPtr + 4);
				}
				if (value == *Unsafe.AddByteOffset<byte>(ref searchSpace, intPtr + 5))
				{
					return (void*)(intPtr + 5);
				}
				if (value == *Unsafe.AddByteOffset<byte>(ref searchSpace, intPtr + 6))
				{
					return (void*)(intPtr + 6);
				}
				if (value == *Unsafe.AddByteOffset<byte>(ref searchSpace, intPtr + 7))
				{
					return (void*)(intPtr + 7);
				}
				intPtr += 8;
			}
			if ((void*)intPtr2 >= 4)
			{
				intPtr2 -= 4;
				if (value == *Unsafe.AddByteOffset<byte>(ref searchSpace, intPtr))
				{
					goto IL_14D;
				}
				if (value == *Unsafe.AddByteOffset<byte>(ref searchSpace, intPtr + 1))
				{
					goto IL_155;
				}
				if (value == *Unsafe.AddByteOffset<byte>(ref searchSpace, intPtr + 2))
				{
					goto IL_163;
				}
				if (value == *Unsafe.AddByteOffset<byte>(ref searchSpace, intPtr + 3))
				{
					goto IL_171;
				}
				intPtr += 4;
			}
			while ((void*)intPtr2 != null)
			{
				intPtr2 -= 1;
				if (value == *Unsafe.AddByteOffset<byte>(ref searchSpace, intPtr))
				{
					goto IL_14D;
				}
				intPtr += 1;
			}
			return -1;
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00024DAC File Offset: 0x00022FAC
		public unsafe static bool SequenceEqual(ref byte first, ref byte second, ulong length)
		{
			if (!Unsafe.AreSame<byte>(ref first, ref second))
			{
				IntPtr intPtr = (IntPtr)0;
				IntPtr intPtr2 = (IntPtr)length;
				if ((void*)intPtr2 >= sizeof(UIntPtr))
				{
					intPtr2 -= sizeof(UIntPtr);
					while ((void*)intPtr2 != (void*)intPtr)
					{
						if (Unsafe.ReadUnaligned<UIntPtr>(Unsafe.AddByteOffset<byte>(ref first, intPtr)) != Unsafe.ReadUnaligned<UIntPtr>(Unsafe.AddByteOffset<byte>(ref second, intPtr)))
						{
							return false;
						}
						intPtr += sizeof(UIntPtr);
					}
					return Unsafe.ReadUnaligned<UIntPtr>(Unsafe.AddByteOffset<byte>(ref first, intPtr2)) == Unsafe.ReadUnaligned<UIntPtr>(Unsafe.AddByteOffset<byte>(ref second, intPtr2));
				}
				while ((void*)intPtr2 != (void*)intPtr)
				{
					if (*Unsafe.AddByteOffset<byte>(ref first, intPtr) != *Unsafe.AddByteOffset<byte>(ref second, intPtr))
					{
						return false;
					}
					intPtr += 1;
				}
				return true;
			}
			return true;
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00024E78 File Offset: 0x00023078
		public unsafe static int SequenceCompareTo(ref char first, int firstLength, ref char second, int secondLength)
		{
			int result = firstLength - secondLength;
			if (!Unsafe.AreSame<char>(ref first, ref second))
			{
				IntPtr intPtr = (IntPtr)((firstLength < secondLength) ? firstLength : secondLength);
				IntPtr intPtr2 = (IntPtr)0;
				if ((void*)intPtr >= sizeof(UIntPtr) / 2)
				{
					if (Vector.IsHardwareAccelerated && (void*)intPtr >= Vector<ushort>.Count)
					{
						IntPtr value = intPtr - Vector<ushort>.Count;
						while (!(Unsafe.ReadUnaligned<Vector<ushort>>(Unsafe.As<char, byte>(Unsafe.Add<char>(ref first, intPtr2))) != Unsafe.ReadUnaligned<Vector<ushort>>(Unsafe.As<char, byte>(Unsafe.Add<char>(ref second, intPtr2)))))
						{
							intPtr2 += Vector<ushort>.Count;
							if ((void*)value < (void*)intPtr2)
							{
								break;
							}
						}
					}
					while ((void*)intPtr >= (void*)(intPtr2 + sizeof(UIntPtr) / 2) && !(Unsafe.ReadUnaligned<UIntPtr>(Unsafe.As<char, byte>(Unsafe.Add<char>(ref first, intPtr2))) != Unsafe.ReadUnaligned<UIntPtr>(Unsafe.As<char, byte>(Unsafe.Add<char>(ref second, intPtr2)))))
					{
						intPtr2 += sizeof(UIntPtr) / 2;
					}
				}
				if (sizeof(UIntPtr) > 4 && (void*)intPtr >= (void*)(intPtr2 + 2) && Unsafe.ReadUnaligned<int>(Unsafe.As<char, byte>(Unsafe.Add<char>(ref first, intPtr2))) == Unsafe.ReadUnaligned<int>(Unsafe.As<char, byte>(Unsafe.Add<char>(ref second, intPtr2))))
				{
					intPtr2 += 2;
				}
				while ((void*)intPtr2 < (void*)intPtr)
				{
					int num = Unsafe.Add<char>(ref first, intPtr2).CompareTo(*Unsafe.Add<char>(ref second, intPtr2));
					if (num != 0)
					{
						return num;
					}
					intPtr2 += 1;
				}
			}
			return result;
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00024FFC File Offset: 0x000231FC
		public unsafe static int IndexOf(ref char searchSpace, char value, int length)
		{
			fixed (char* ptr = &searchSpace)
			{
				char* ptr2 = ptr;
				char* ptr3 = ptr2;
				char* ptr4 = ptr3 + length;
				if (Vector.IsHardwareAccelerated && length >= Vector<ushort>.Count * 2)
				{
					int num = (ptr3 & Unsafe.SizeOf<Vector<ushort>>() - 1) / 2;
					length = (Vector<ushort>.Count - num & Vector<ushort>.Count - 1);
				}
				Vector<ushort> vector;
				for (;;)
				{
					if (length < 4)
					{
						while (length > 0)
						{
							length--;
							if (*ptr3 == value)
							{
								goto IL_127;
							}
							ptr3++;
						}
						if (!Vector.IsHardwareAccelerated || ptr3 >= ptr4)
						{
							return -1;
						}
						length = (int)((long)(ptr4 - ptr3) & (long)(~(long)(Vector<ushort>.Count - 1)));
						Vector<ushort> left = new Vector<ushort>((ushort)value);
						while (length > 0)
						{
							vector = Vector.Equals<ushort>(left, Unsafe.Read<Vector<ushort>>((void*)ptr3));
							if (!Vector<ushort>.Zero.Equals(vector))
							{
								goto IL_F3;
							}
							ptr3 += Vector<ushort>.Count;
							length -= Vector<ushort>.Count;
						}
						if (ptr3 >= ptr4)
						{
							return -1;
						}
						length = (int)((long)(ptr4 - ptr3));
					}
					else
					{
						length -= 4;
						if (*ptr3 == value)
						{
							goto IL_127;
						}
						if (ptr3[1] == value)
						{
							goto IL_123;
						}
						if (ptr3[2] == value)
						{
							goto IL_11F;
						}
						if (ptr3[3] == value)
						{
							goto IL_11B;
						}
						ptr3 += 4;
					}
				}
				IL_F3:
				return (int)((long)(ptr3 - ptr2)) + SpanHelpers.LocateFirstFoundChar(vector);
				IL_11B:
				ptr3++;
				IL_11F:
				ptr3++;
				IL_123:
				ptr3++;
				IL_127:
				return (int)((long)(ptr3 - ptr2));
			}
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00025138 File Offset: 0x00023338
		public unsafe static int LastIndexOf(ref char searchSpace, char value, int length)
		{
			fixed (char* ptr = &searchSpace)
			{
				char* ptr2 = ptr;
				char* ptr3 = ptr2 + length;
				char* ptr4 = ptr2;
				if (Vector.IsHardwareAccelerated && length >= Vector<ushort>.Count * 2)
				{
					length = (ptr3 & Unsafe.SizeOf<Vector<ushort>>() - 1) / 2;
				}
				char* ptr5;
				Vector<ushort> vector;
				for (;;)
				{
					if (length < 4)
					{
						while (length > 0)
						{
							length--;
							ptr3--;
							if (*ptr3 == value)
							{
								goto IL_11A;
							}
						}
						if (!Vector.IsHardwareAccelerated || ptr3 == ptr4)
						{
							return -1;
						}
						length = (int)((long)(ptr3 - ptr4) & (long)(~(long)(Vector<ushort>.Count - 1)));
						Vector<ushort> left = new Vector<ushort>((ushort)value);
						while (length > 0)
						{
							ptr5 = ptr3 - Vector<ushort>.Count;
							vector = Vector.Equals<ushort>(left, Unsafe.Read<Vector<ushort>>((void*)ptr5));
							if (!Vector<ushort>.Zero.Equals(vector))
							{
								goto IL_F1;
							}
							ptr3 -= Vector<ushort>.Count;
							length -= Vector<ushort>.Count;
						}
						if (ptr3 == ptr4)
						{
							return -1;
						}
						length = (int)((long)(ptr3 - ptr4));
					}
					else
					{
						length -= 4;
						ptr3 -= 4;
						if (ptr3[3] == value)
						{
							goto IL_136;
						}
						if (ptr3[2] == value)
						{
							goto IL_12C;
						}
						if (ptr3[1] == value)
						{
							goto IL_122;
						}
						if (*ptr3 == value)
						{
							goto IL_11A;
						}
					}
				}
				IL_F1:
				return (int)((long)(ptr5 - ptr4)) + SpanHelpers.LocateLastFoundChar(vector);
				IL_11A:
				return (int)((long)(ptr3 - ptr4));
				IL_122:
				return (int)((long)(ptr3 - ptr4)) + 1;
				IL_12C:
				return (int)((long)(ptr3 - ptr4)) + 2;
				IL_136:
				return (int)((long)(ptr3 - ptr4)) + 3;
			}
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00025284 File Offset: 0x00023484
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int LocateFirstFoundChar(Vector<ushort> match)
		{
			Vector<ulong> vector = Vector.AsVectorUInt64<ushort>(match);
			ulong num = 0UL;
			int i;
			for (i = 0; i < Vector<ulong>.Count; i++)
			{
				num = vector[i];
				if (num != 0UL)
				{
					break;
				}
			}
			return i * 4 + SpanHelpers.LocateFirstFoundChar(num);
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x000252C1 File Offset: 0x000234C1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int LocateFirstFoundChar(ulong match)
		{
			return (int)((match ^ match - 1UL) * 4295098372UL >> 49);
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x000252D8 File Offset: 0x000234D8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int LocateLastFoundChar(Vector<ushort> match)
		{
			Vector<ulong> vector = Vector.AsVectorUInt64<ushort>(match);
			ulong num = 0UL;
			int i;
			for (i = Vector<ulong>.Count - 1; i >= 0; i--)
			{
				num = vector[i];
				if (num != 0UL)
				{
					break;
				}
			}
			return i * 4 + SpanHelpers.LocateLastFoundChar(num);
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00025318 File Offset: 0x00023518
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int LocateLastFoundChar(ulong match)
		{
			int num = 3;
			while (match > 0UL)
			{
				match <<= 16;
				num--;
			}
			return num;
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x0002533C File Offset: 0x0002353C
		public unsafe static int IndexOf<T>(ref T searchSpace, T value, int length) where T : IEquatable<T>
		{
			IntPtr intPtr = (IntPtr)0;
			while (length >= 8)
			{
				length -= 8;
				if (value.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr)))
				{
					IL_202:
					return (void*)intPtr;
				}
				if (value.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + 1)))
				{
					IL_20A:
					return (void*)(intPtr + 1);
				}
				if (value.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + 2)))
				{
					IL_218:
					return (void*)(intPtr + 2);
				}
				if (value.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + 3)))
				{
					IL_226:
					return (void*)(intPtr + 3);
				}
				if (value.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + 4)))
				{
					return (void*)(intPtr + 4);
				}
				if (value.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + 5)))
				{
					return (void*)(intPtr + 5);
				}
				if (value.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + 6)))
				{
					return (void*)(intPtr + 6);
				}
				if (value.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + 7)))
				{
					return (void*)(intPtr + 7);
				}
				intPtr += 8;
			}
			if (length >= 4)
			{
				length -= 4;
				if (value.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr)))
				{
					goto IL_202;
				}
				if (value.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + 1)))
				{
					goto IL_20A;
				}
				if (value.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + 2)))
				{
					goto IL_218;
				}
				if (value.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + 3)))
				{
					goto IL_226;
				}
				intPtr += 4;
			}
			while (length > 0)
			{
				if (value.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr)))
				{
					goto IL_202;
				}
				intPtr += 1;
				length--;
			}
			return -1;
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x000255B4 File Offset: 0x000237B4
		public unsafe static int IndexOfAny<T>(ref T searchSpace, int searchSpaceLength, ref T value, int valueLength) where T : IEquatable<T>
		{
			if (valueLength == 0)
			{
				return 0;
			}
			int num = -1;
			for (int i = 0; i < valueLength; i++)
			{
				int num2 = SpanHelpers.IndexOf<T>(ref searchSpace, *Unsafe.Add<T>(ref value, i), searchSpaceLength);
				if (num2 < num)
				{
					num = num2;
					searchSpaceLength = num2;
					if (num == 0)
					{
						break;
					}
				}
			}
			return num;
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x000255F8 File Offset: 0x000237F8
		public unsafe static bool SequenceEqual<T>(ref T first, ref T second, int length) where T : IEquatable<T>
		{
			if (!Unsafe.AreSame<T>(ref first, ref second))
			{
				IntPtr intPtr = (IntPtr)0;
				while (length >= 8)
				{
					length -= 8;
					if (!Unsafe.Add<T>(ref first, intPtr).Equals(*Unsafe.Add<T>(ref second, intPtr)) || !Unsafe.Add<T>(ref first, intPtr + 1).Equals(*Unsafe.Add<T>(ref second, intPtr + 1)) || !Unsafe.Add<T>(ref first, intPtr + 2).Equals(*Unsafe.Add<T>(ref second, intPtr + 2)) || !Unsafe.Add<T>(ref first, intPtr + 3).Equals(*Unsafe.Add<T>(ref second, intPtr + 3)) || !Unsafe.Add<T>(ref first, intPtr + 4).Equals(*Unsafe.Add<T>(ref second, intPtr + 4)) || !Unsafe.Add<T>(ref first, intPtr + 5).Equals(*Unsafe.Add<T>(ref second, intPtr + 5)) || !Unsafe.Add<T>(ref first, intPtr + 6).Equals(*Unsafe.Add<T>(ref second, intPtr + 6)) || !Unsafe.Add<T>(ref first, intPtr + 7).Equals(*Unsafe.Add<T>(ref second, intPtr + 7)))
					{
						return false;
					}
					intPtr += 8;
				}
				if (length >= 4)
				{
					length -= 4;
					if (!Unsafe.Add<T>(ref first, intPtr).Equals(*Unsafe.Add<T>(ref second, intPtr)) || !Unsafe.Add<T>(ref first, intPtr + 1).Equals(*Unsafe.Add<T>(ref second, intPtr + 1)) || !Unsafe.Add<T>(ref first, intPtr + 2).Equals(*Unsafe.Add<T>(ref second, intPtr + 2)) || !Unsafe.Add<T>(ref first, intPtr + 3).Equals(*Unsafe.Add<T>(ref second, intPtr + 3)))
					{
						return false;
					}
					intPtr += 4;
				}
				while (length > 0)
				{
					if (!Unsafe.Add<T>(ref first, intPtr).Equals(*Unsafe.Add<T>(ref second, intPtr)))
					{
						return false;
					}
					intPtr += 1;
					length--;
				}
			}
			return true;
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00025891 File Offset: 0x00023A91
		public static bool EndsWithCultureHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value, CompareInfo compareInfo)
		{
			if (GlobalizationMode.Invariant)
			{
				return span.EndsWith(value);
			}
			return span.Length != 0 && compareInfo.IsSuffix(span, value, CompareOptions.None);
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x000258B6 File Offset: 0x00023AB6
		public static bool EndsWithCultureIgnoreCaseHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value, CompareInfo compareInfo)
		{
			if (GlobalizationMode.Invariant)
			{
				return SpanHelpers.EndsWithOrdinalIgnoreCaseHelper(span, value);
			}
			return span.Length != 0 && compareInfo.IsSuffix(span, value, CompareOptions.IgnoreCase);
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x000258DB File Offset: 0x00023ADB
		public static bool EndsWithOrdinalIgnoreCaseHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value)
		{
			return span.Length >= value.Length && CompareInfo.CompareOrdinalIgnoreCase(span.Slice(span.Length - value.Length), value) == 0;
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00025910 File Offset: 0x00023B10
		public unsafe static void ClearWithoutReferences(ref byte b, ulong byteLength)
		{
			if (byteLength == 0UL)
			{
				return;
			}
			ulong num = byteLength - 1UL;
			if (num <= 21UL)
			{
				switch ((uint)num)
				{
				case 0U:
					b = 0;
					return;
				case 1U:
					*Unsafe.As<byte, short>(ref b) = 0;
					return;
				case 2U:
					*Unsafe.As<byte, short>(ref b) = 0;
					*Unsafe.Add<byte>(ref b, 2) = 0;
					return;
				case 3U:
					*Unsafe.As<byte, int>(ref b) = 0;
					return;
				case 4U:
					*Unsafe.As<byte, int>(ref b) = 0;
					*Unsafe.Add<byte>(ref b, 4) = 0;
					return;
				case 5U:
					*Unsafe.As<byte, int>(ref b) = 0;
					*Unsafe.As<byte, short>(Unsafe.Add<byte>(ref b, 4)) = 0;
					return;
				case 6U:
					*Unsafe.As<byte, int>(ref b) = 0;
					*Unsafe.As<byte, short>(Unsafe.Add<byte>(ref b, 4)) = 0;
					*Unsafe.Add<byte>(ref b, 6) = 0;
					return;
				case 7U:
					*Unsafe.As<byte, long>(ref b) = 0L;
					return;
				case 8U:
					*Unsafe.As<byte, long>(ref b) = 0L;
					*Unsafe.Add<byte>(ref b, 8) = 0;
					return;
				case 9U:
					*Unsafe.As<byte, long>(ref b) = 0L;
					*Unsafe.As<byte, short>(Unsafe.Add<byte>(ref b, 8)) = 0;
					return;
				case 10U:
					*Unsafe.As<byte, long>(ref b) = 0L;
					*Unsafe.As<byte, short>(Unsafe.Add<byte>(ref b, 8)) = 0;
					*Unsafe.Add<byte>(ref b, 10) = 0;
					return;
				case 11U:
					*Unsafe.As<byte, long>(ref b) = 0L;
					*Unsafe.As<byte, int>(Unsafe.Add<byte>(ref b, 8)) = 0;
					return;
				case 12U:
					*Unsafe.As<byte, long>(ref b) = 0L;
					*Unsafe.As<byte, int>(Unsafe.Add<byte>(ref b, 8)) = 0;
					*Unsafe.Add<byte>(ref b, 12) = 0;
					return;
				case 13U:
					*Unsafe.As<byte, long>(ref b) = 0L;
					*Unsafe.As<byte, int>(Unsafe.Add<byte>(ref b, 8)) = 0;
					*Unsafe.As<byte, short>(Unsafe.Add<byte>(ref b, 12)) = 0;
					return;
				case 14U:
					*Unsafe.As<byte, long>(ref b) = 0L;
					*Unsafe.As<byte, int>(Unsafe.Add<byte>(ref b, 8)) = 0;
					*Unsafe.As<byte, short>(Unsafe.Add<byte>(ref b, 12)) = 0;
					*Unsafe.Add<byte>(ref b, 14) = 0;
					return;
				case 15U:
					*Unsafe.As<byte, long>(ref b) = 0L;
					*Unsafe.As<byte, long>(Unsafe.Add<byte>(ref b, 8)) = 0L;
					return;
				case 16U:
					*Unsafe.As<byte, long>(ref b) = 0L;
					*Unsafe.As<byte, long>(Unsafe.Add<byte>(ref b, 8)) = 0L;
					*Unsafe.Add<byte>(ref b, 16) = 0;
					return;
				case 17U:
					*Unsafe.As<byte, long>(ref b) = 0L;
					*Unsafe.As<byte, long>(Unsafe.Add<byte>(ref b, 8)) = 0L;
					*Unsafe.As<byte, short>(Unsafe.Add<byte>(ref b, 16)) = 0;
					return;
				case 18U:
					*Unsafe.As<byte, long>(ref b) = 0L;
					*Unsafe.As<byte, long>(Unsafe.Add<byte>(ref b, 8)) = 0L;
					*Unsafe.As<byte, short>(Unsafe.Add<byte>(ref b, 16)) = 0;
					*Unsafe.Add<byte>(ref b, 18) = 0;
					return;
				case 19U:
					*Unsafe.As<byte, long>(ref b) = 0L;
					*Unsafe.As<byte, long>(Unsafe.Add<byte>(ref b, 8)) = 0L;
					*Unsafe.As<byte, int>(Unsafe.Add<byte>(ref b, 16)) = 0;
					return;
				case 20U:
					*Unsafe.As<byte, long>(ref b) = 0L;
					*Unsafe.As<byte, long>(Unsafe.Add<byte>(ref b, 8)) = 0L;
					*Unsafe.As<byte, int>(Unsafe.Add<byte>(ref b, 16)) = 0;
					*Unsafe.Add<byte>(ref b, 20) = 0;
					return;
				case 21U:
					*Unsafe.As<byte, long>(ref b) = 0L;
					*Unsafe.As<byte, long>(Unsafe.Add<byte>(ref b, 8)) = 0L;
					*Unsafe.As<byte, int>(Unsafe.Add<byte>(ref b, 16)) = 0;
					*Unsafe.As<byte, short>(Unsafe.Add<byte>(ref b, 20)) = 0;
					return;
				}
			}
			if (byteLength < 512UL)
			{
				ulong num2 = 0UL;
				if ((*Unsafe.As<byte, int>(ref b) & 3) != 0)
				{
					if ((*Unsafe.As<byte, int>(ref b) & 1) != 0)
					{
						*Unsafe.AddByteOffset<byte>(ref b, num2) = 0;
						num2 += 1UL;
						if ((*Unsafe.As<byte, int>(ref b) & 2) != 0)
						{
							goto IL_349;
						}
					}
					*Unsafe.As<byte, short>(Unsafe.AddByteOffset<byte>(ref b, num2)) = 0;
					num2 += 2UL;
				}
				IL_349:
				if ((*Unsafe.As<byte, int>(ref b) - 1 & 4) == 0)
				{
					*Unsafe.As<byte, int>(Unsafe.AddByteOffset<byte>(ref b, num2)) = 0;
					num2 += 4UL;
				}
				ulong num3 = byteLength - 16UL;
				byteLength -= num2;
				ulong num4;
				do
				{
					num4 = num2 + 16UL;
					*Unsafe.As<byte, long>(Unsafe.AddByteOffset<byte>(ref b, num2)) = 0L;
					*Unsafe.As<byte, long>(Unsafe.AddByteOffset<byte>(ref b, num2 + 8UL)) = 0L;
					num2 = num4;
				}
				while (num4 <= num3);
				if ((byteLength & 8UL) != 0UL)
				{
					*Unsafe.As<byte, long>(Unsafe.AddByteOffset<byte>(ref b, num2)) = 0L;
					num2 += 8UL;
				}
				if ((byteLength & 4UL) != 0UL)
				{
					*Unsafe.As<byte, int>(Unsafe.AddByteOffset<byte>(ref b, num2)) = 0;
					num2 += 4UL;
				}
				if ((byteLength & 2UL) != 0UL)
				{
					*Unsafe.As<byte, short>(Unsafe.AddByteOffset<byte>(ref b, num2)) = 0;
					num2 += 2UL;
				}
				if ((byteLength & 1UL) != 0UL)
				{
					*Unsafe.AddByteOffset<byte>(ref b, num2) = 0;
				}
				return;
			}
			RuntimeImports.RhZeroMemory(ref b, byteLength);
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00025D24 File Offset: 0x00023F24
		public unsafe static void ClearWithReferences(ref IntPtr ip, ulong pointerSizeLength)
		{
			while (pointerSizeLength >= 8UL)
			{
				*Unsafe.Add<IntPtr>(Unsafe.Add<IntPtr>(ref ip, (IntPtr)((long)pointerSizeLength)), -1) = 0;
				*Unsafe.Add<IntPtr>(Unsafe.Add<IntPtr>(ref ip, (IntPtr)((long)pointerSizeLength)), -2) = 0;
				*Unsafe.Add<IntPtr>(Unsafe.Add<IntPtr>(ref ip, (IntPtr)((long)pointerSizeLength)), -3) = 0;
				*Unsafe.Add<IntPtr>(Unsafe.Add<IntPtr>(ref ip, (IntPtr)((long)pointerSizeLength)), -4) = 0;
				*Unsafe.Add<IntPtr>(Unsafe.Add<IntPtr>(ref ip, (IntPtr)((long)pointerSizeLength)), -5) = 0;
				*Unsafe.Add<IntPtr>(Unsafe.Add<IntPtr>(ref ip, (IntPtr)((long)pointerSizeLength)), -6) = 0;
				*Unsafe.Add<IntPtr>(Unsafe.Add<IntPtr>(ref ip, (IntPtr)((long)pointerSizeLength)), -7) = 0;
				*Unsafe.Add<IntPtr>(Unsafe.Add<IntPtr>(ref ip, (IntPtr)((long)pointerSizeLength)), -8) = 0;
				pointerSizeLength -= 8UL;
			}
			if (pointerSizeLength < 4UL)
			{
				if (pointerSizeLength < 2UL)
				{
					if (pointerSizeLength <= 0UL)
					{
						return;
					}
					goto IL_15B;
				}
			}
			else
			{
				*Unsafe.Add<IntPtr>(ref ip, 2) = 0;
				*Unsafe.Add<IntPtr>(ref ip, 3) = 0;
				*Unsafe.Add<IntPtr>(Unsafe.Add<IntPtr>(ref ip, (IntPtr)((long)pointerSizeLength)), -3) = 0;
				*Unsafe.Add<IntPtr>(Unsafe.Add<IntPtr>(ref ip, (IntPtr)((long)pointerSizeLength)), -2) = 0;
			}
			*Unsafe.Add<IntPtr>(ref ip, 1) = 0;
			*Unsafe.Add<IntPtr>(Unsafe.Add<IntPtr>(ref ip, (IntPtr)((long)pointerSizeLength)), -1) = 0;
			IL_15B:
			ip = 0;
		}
	}
}
