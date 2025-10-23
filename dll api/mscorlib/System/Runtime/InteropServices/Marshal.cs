using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Cryptography;
using System.Threading;

namespace System.Runtime.InteropServices
{
	/// <summary>Provides a collection of methods for allocating unmanaged memory, copying unmanaged memory blocks, and converting managed to unmanaged types, as well as other miscellaneous methods used when interacting with unmanaged code.</summary>
	// Token: 0x02000420 RID: 1056
	public static class Marshal
	{
		/// <summary>Increments the reference count on the specified interface.</summary>
		/// <param name="pUnk">The interface reference count to increment.</param>
		/// <returns>The new value of the reference count on the <paramref name="pUnk" /> parameter.</returns>
		// Token: 0x06001F84 RID: 8068 RVA: 0x0002B1E0 File Offset: 0x000293E0
		public static int AddRef(IntPtr pUnk)
		{
			throw new NotImplementedException();
		}

		/// <summary>Allocates memory from the unmanaged memory of the process by using the pointer to the specified number of bytes.</summary>
		/// <param name="cb">The required number of bytes in memory.</param>
		/// <returns>A pointer to the newly allocated memory. This memory must be released using the <see cref="M:System.Runtime.InteropServices.Marshal.FreeHGlobal(System.IntPtr)" /> method.</returns>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory to satisfy the request.</exception>
		// Token: 0x06001F85 RID: 8069
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr AllocHGlobal(IntPtr cb);

		/// <summary>Allocates memory from the unmanaged memory of the process by using the specified number of bytes.</summary>
		/// <param name="cb">The required number of bytes in memory.</param>
		/// <returns>A pointer to the newly allocated memory. This memory must be released using the <see cref="M:System.Runtime.InteropServices.Marshal.FreeHGlobal(System.IntPtr)" /> method.</returns>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory to satisfy the request.</exception>
		// Token: 0x06001F86 RID: 8070 RVA: 0x00086CFB File Offset: 0x00084EFB
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static IntPtr AllocHGlobal(int cb)
		{
			return Marshal.AllocHGlobal((IntPtr)cb);
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x00086D08 File Offset: 0x00084F08
		internal static void copy_to_unmanaged(Array source, int startIndex, IntPtr destination, int length)
		{
			Marshal.copy_to_unmanaged_fixed(source, startIndex, destination, length, null);
		}

		// Token: 0x06001F88 RID: 8072
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void copy_to_unmanaged_fixed(Array source, int startIndex, IntPtr destination, int length, void* fixed_source_element);

		// Token: 0x06001F89 RID: 8073 RVA: 0x00086D15 File Offset: 0x00084F15
		private static bool skip_fixed(Array array, int startIndex)
		{
			return startIndex < 0 || startIndex >= array.Length;
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x00086D2C File Offset: 0x00084F2C
		internal unsafe static void copy_to_unmanaged(byte[] source, int startIndex, IntPtr destination, int length)
		{
			if (Marshal.skip_fixed(source, startIndex))
			{
				Marshal.copy_to_unmanaged_fixed(source, startIndex, destination, length, null);
				return;
			}
			fixed (byte* ptr = &source[startIndex])
			{
				void* fixed_source_element = (void*)ptr;
				Marshal.copy_to_unmanaged_fixed(source, startIndex, destination, length, fixed_source_element);
			}
		}

		/// <summary>Copies data from a one-dimensional, managed 8-bit unsigned integer array to an unmanaged memory pointer.</summary>
		/// <param name="source">The one-dimensional array to copy from.</param>
		/// <param name="startIndex">The zero-based index in the source array where copying should start.</param>
		/// <param name="destination">The memory pointer to copy to.</param>
		/// <param name="length">The number of array elements to copy.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startIndex" /> and <paramref name="length" /> are not valid.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" />, <paramref name="startIndex" />, <paramref name="destination" />, or <paramref name="length" /> is <see langword="null" />.</exception>
		// Token: 0x06001F8B RID: 8075 RVA: 0x00086D68 File Offset: 0x00084F68
		public unsafe static void Copy(byte[] source, int startIndex, IntPtr destination, int length)
		{
			if (Marshal.skip_fixed(source, startIndex))
			{
				Marshal.copy_to_unmanaged(source, startIndex, destination, length);
				return;
			}
			fixed (byte* ptr = &source[startIndex])
			{
				void* fixed_source_element = (void*)ptr;
				Marshal.copy_to_unmanaged_fixed(source, startIndex, destination, length, fixed_source_element);
			}
		}

		/// <summary>Copies data from a one-dimensional, managed 16-bit signed integer array to an unmanaged memory pointer.</summary>
		/// <param name="source">The one-dimensional array to copy from.</param>
		/// <param name="startIndex">The zero-based index in the source array where copying should start.</param>
		/// <param name="destination">The memory pointer to copy to.</param>
		/// <param name="length">The number of array elements to copy.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startIndex" /> and <paramref name="length" /> are not valid.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" />, <paramref name="startIndex" />, <paramref name="destination" />, or <paramref name="length" /> is <see langword="null" />.</exception>
		// Token: 0x06001F8C RID: 8076 RVA: 0x00086DA0 File Offset: 0x00084FA0
		public unsafe static void Copy(short[] source, int startIndex, IntPtr destination, int length)
		{
			if (Marshal.skip_fixed(source, startIndex))
			{
				Marshal.copy_to_unmanaged(source, startIndex, destination, length);
				return;
			}
			fixed (short* ptr = &source[startIndex])
			{
				void* fixed_source_element = (void*)ptr;
				Marshal.copy_to_unmanaged_fixed(source, startIndex, destination, length, fixed_source_element);
			}
		}

		/// <summary>Copies data from a one-dimensional, managed 32-bit signed integer array to an unmanaged memory pointer.</summary>
		/// <param name="source">The one-dimensional array to copy from.</param>
		/// <param name="startIndex">The zero-based index in the source array where copying should start.</param>
		/// <param name="destination">The memory pointer to copy to.</param>
		/// <param name="length">The number of array elements to copy.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="startIndex" /> and <paramref name="length" /> are not valid.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="startIndex" /> or <paramref name="length" /> is <see langword="null" />.</exception>
		// Token: 0x06001F8D RID: 8077 RVA: 0x00086DD8 File Offset: 0x00084FD8
		public unsafe static void Copy(int[] source, int startIndex, IntPtr destination, int length)
		{
			if (Marshal.skip_fixed(source, startIndex))
			{
				Marshal.copy_to_unmanaged(source, startIndex, destination, length);
				return;
			}
			fixed (int* ptr = &source[startIndex])
			{
				void* fixed_source_element = (void*)ptr;
				Marshal.copy_to_unmanaged_fixed(source, startIndex, destination, length, fixed_source_element);
			}
		}

		/// <summary>Copies data from a one-dimensional, managed <see cref="T:System.IntPtr" /> array to an unmanaged memory pointer.</summary>
		/// <param name="source">The one-dimensional array to copy from.</param>
		/// <param name="startIndex">The zero-based index in the source array where copying should start.</param>
		/// <param name="destination">The memory pointer to copy to.</param>
		/// <param name="length">The number of array elements to copy.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" />, or <paramref name="length" /> is <see langword="null" />.</exception>
		// Token: 0x06001F8E RID: 8078 RVA: 0x00086E10 File Offset: 0x00085010
		public unsafe static void Copy(IntPtr[] source, int startIndex, IntPtr destination, int length)
		{
			if (Marshal.skip_fixed(source, startIndex))
			{
				Marshal.copy_to_unmanaged(source, startIndex, destination, length);
				return;
			}
			fixed (IntPtr* ptr = &source[startIndex])
			{
				void* fixed_source_element = (void*)ptr;
				Marshal.copy_to_unmanaged_fixed(source, startIndex, destination, length, fixed_source_element);
			}
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x00086E48 File Offset: 0x00085048
		internal static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length)
		{
			Marshal.copy_from_unmanaged_fixed(source, startIndex, destination, length, null);
		}

		// Token: 0x06001F90 RID: 8080
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void copy_from_unmanaged_fixed(IntPtr source, int startIndex, Array destination, int length, void* fixed_destination_element);

		/// <summary>Copies data from an unmanaged memory pointer to a managed 8-bit unsigned integer array.</summary>
		/// <param name="source">The memory pointer to copy from.</param>
		/// <param name="destination">The array to copy to.</param>
		/// <param name="startIndex">The zero-based index in the destination array where copying should start.</param>
		/// <param name="length">The number of array elements to copy.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" />, or <paramref name="length" /> is <see langword="null" />.</exception>
		// Token: 0x06001F91 RID: 8081 RVA: 0x00086E58 File Offset: 0x00085058
		public unsafe static void Copy(IntPtr source, byte[] destination, int startIndex, int length)
		{
			if (Marshal.skip_fixed(destination, startIndex))
			{
				Marshal.copy_from_unmanaged(source, startIndex, destination, length);
				return;
			}
			fixed (byte* ptr = &destination[startIndex])
			{
				void* fixed_destination_element = (void*)ptr;
				Marshal.copy_from_unmanaged_fixed(source, startIndex, destination, length, fixed_destination_element);
			}
		}

		/// <summary>Copies data from an unmanaged memory pointer to a managed character array.</summary>
		/// <param name="source">The memory pointer to copy from.</param>
		/// <param name="destination">The array to copy to.</param>
		/// <param name="startIndex">The zero-based index in the destination array where copying should start.</param>
		/// <param name="length">The number of array elements to copy.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" />, or <paramref name="length" /> is <see langword="null" />.</exception>
		// Token: 0x06001F92 RID: 8082 RVA: 0x00086E90 File Offset: 0x00085090
		public unsafe static void Copy(IntPtr source, char[] destination, int startIndex, int length)
		{
			if (Marshal.skip_fixed(destination, startIndex))
			{
				Marshal.copy_from_unmanaged(source, startIndex, destination, length);
				return;
			}
			fixed (char* ptr = &destination[startIndex])
			{
				void* fixed_destination_element = (void*)ptr;
				Marshal.copy_from_unmanaged_fixed(source, startIndex, destination, length, fixed_destination_element);
			}
		}

		/// <summary>Copies data from an unmanaged memory pointer to a managed 32-bit signed integer array.</summary>
		/// <param name="source">The memory pointer to copy from.</param>
		/// <param name="destination">The array to copy to.</param>
		/// <param name="startIndex">The zero-based index in the destination array where copying should start.</param>
		/// <param name="length">The number of array elements to copy.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" />, or <paramref name="length" /> is <see langword="null" />.</exception>
		// Token: 0x06001F93 RID: 8083 RVA: 0x00086EC8 File Offset: 0x000850C8
		public unsafe static void Copy(IntPtr source, int[] destination, int startIndex, int length)
		{
			if (Marshal.skip_fixed(destination, startIndex))
			{
				Marshal.copy_from_unmanaged(source, startIndex, destination, length);
				return;
			}
			fixed (int* ptr = &destination[startIndex])
			{
				void* fixed_destination_element = (void*)ptr;
				Marshal.copy_from_unmanaged_fixed(source, startIndex, destination, length, fixed_destination_element);
			}
		}

		/// <summary>Copies data from an unmanaged memory pointer to a managed <see cref="T:System.IntPtr" /> array.</summary>
		/// <param name="source">The memory pointer to copy from. </param>
		/// <param name="destination">The array to copy to.</param>
		/// <param name="startIndex">The zero-based index in the destination array where copying should start.</param>
		/// <param name="length">The number of array elements to copy.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="source" />, <paramref name="destination" />, <paramref name="startIndex" />, or <paramref name="length" /> is <see langword="null" />.</exception>
		// Token: 0x06001F94 RID: 8084 RVA: 0x00086F00 File Offset: 0x00085100
		public unsafe static void Copy(IntPtr source, IntPtr[] destination, int startIndex, int length)
		{
			if (Marshal.skip_fixed(destination, startIndex))
			{
				Marshal.copy_from_unmanaged(source, startIndex, destination, length);
				return;
			}
			fixed (IntPtr* ptr = &destination[startIndex])
			{
				void* fixed_destination_element = (void*)ptr;
				Marshal.copy_from_unmanaged_fixed(source, startIndex, destination, length, fixed_destination_element);
			}
		}

		/// <summary>Frees a <see langword="BSTR" /> using the COM SysFreeString function.</summary>
		/// <param name="ptr">The address of the BSTR to be freed. </param>
		// Token: 0x06001F95 RID: 8085
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FreeBSTR(IntPtr ptr);

		/// <summary>Frees memory previously allocated from the unmanaged memory of the process.</summary>
		/// <param name="hglobal">The handle returned by the original matching call to <see cref="M:System.Runtime.InteropServices.Marshal.AllocHGlobal(System.IntPtr)" />. </param>
		// Token: 0x06001F96 RID: 8086
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FreeHGlobal(IntPtr hglobal);

		// Token: 0x06001F97 RID: 8087 RVA: 0x00086F38 File Offset: 0x00085138
		private static void ClearAnsi(IntPtr ptr)
		{
			int num = 0;
			while (Marshal.ReadByte(ptr, num) != 0)
			{
				Marshal.WriteByte(ptr, num, 0);
				num++;
			}
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x00086F60 File Offset: 0x00085160
		private static void ClearUnicode(IntPtr ptr)
		{
			int num = 0;
			while (Marshal.ReadInt16(ptr, num) != 0)
			{
				Marshal.WriteInt16(ptr, num, 0);
				num += 2;
			}
		}

		/// <summary>Frees an unmanaged string pointer that was allocated using the <see cref="M:System.Runtime.InteropServices.Marshal.SecureStringToGlobalAllocAnsi(System.Security.SecureString)" /> method.</summary>
		/// <param name="s">The address of the unmanaged string to free.</param>
		// Token: 0x06001F99 RID: 8089 RVA: 0x00086F86 File Offset: 0x00085186
		public static void ZeroFreeGlobalAllocAnsi(IntPtr s)
		{
			Marshal.ClearAnsi(s);
			Marshal.FreeHGlobal(s);
		}

		/// <summary>Frees an unmanaged string pointer that was allocated using the <see cref="M:System.Runtime.InteropServices.Marshal.SecureStringToGlobalAllocUnicode(System.Security.SecureString)" /> method.</summary>
		/// <param name="s">The address of the unmanaged string to free.</param>
		// Token: 0x06001F9A RID: 8090 RVA: 0x00086F94 File Offset: 0x00085194
		public static void ZeroFreeGlobalAllocUnicode(IntPtr s)
		{
			Marshal.ClearUnicode(s);
			Marshal.FreeHGlobal(s);
		}

		// Token: 0x06001F9B RID: 8091
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr GetIUnknownForObjectInternal(object o);

		/// <summary>Returns an IUnknown interface from a managed object.</summary>
		/// <param name="o">The object whose <see langword="IUnknown" /> interface is requested.</param>
		/// <returns>The <see langword="IUnknown" /> pointer for the <paramref name="o" /> parameter.</returns>
		// Token: 0x06001F9C RID: 8092 RVA: 0x00086FA2 File Offset: 0x000851A2
		public static IntPtr GetIUnknownForObject(object o)
		{
			IntPtr iunknownForObjectInternal = Marshal.GetIUnknownForObjectInternal(o);
			Marshal.AddRef(iunknownForObjectInternal);
			return iunknownForObjectInternal;
		}

		/// <summary>Returns an instance of a type that represents a COM object by a pointer to its IUnknown interface.</summary>
		/// <param name="pUnk">A pointer to the <see langword="IUnknown" /> interface. </param>
		/// <returns>An object that represents the specified unmanaged COM object.</returns>
		// Token: 0x06001F9D RID: 8093 RVA: 0x0002FCDD File Offset: 0x0002DEDD
		public static object GetObjectForIUnknown(IntPtr pUnk)
		{
			throw new PlatformNotSupportedException();
		}

		/// <summary>Indicates whether a specified object represents a COM object.</summary>
		/// <param name="o">The object to check.</param>
		/// <returns>
		///     <see langword="true" /> if the <paramref name="o" /> parameter is a COM type; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="o" /> is <see langword="null" />. </exception>
		// Token: 0x06001F9E RID: 8094 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public static bool IsComObject(object o)
		{
			return false;
		}

		/// <summary>Returns the error code returned by the last unmanaged function that was called using platform invoke that has the <see cref="F:System.Runtime.InteropServices.DllImportAttribute.SetLastError" /> flag set.</summary>
		/// <returns>The last error code set by a call to the Win32 SetLastError function.</returns>
		// Token: 0x06001F9F RID: 8095
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetLastWin32Error();

		/// <summary>Copies all characters up to the first null character from an unmanaged ANSI string to a managed <see cref="T:System.String" />, and widens each ANSI character to Unicode.</summary>
		/// <param name="ptr">The address of the first character of the unmanaged string.</param>
		/// <returns>A managed string that holds a copy of the unmanaged ANSI string. If <paramref name="ptr" /> is <see langword="null" />, the method returns a null string.</returns>
		// Token: 0x06001FA0 RID: 8096
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string PtrToStringAnsi(IntPtr ptr);

		/// <summary>Allocates a managed <see cref="T:System.String" />, copies a specified number of characters from an unmanaged ANSI string into it, and widens each ANSI character to Unicode.</summary>
		/// <param name="ptr">The address of the first character of the unmanaged string.</param>
		/// <param name="len">The byte count of the input string to copy.</param>
		/// <returns>A managed string that holds a copy of the native ANSI string if the value of the <paramref name="ptr" /> parameter is not <see langword="null" />; otherwise, this method returns <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="len" /> is less than zero.</exception>
		// Token: 0x06001FA1 RID: 8097
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string PtrToStringAnsi(IntPtr ptr, int len);

		/// <summary>Allocates a managed <see cref="T:System.String" /> and copies all characters up to the first null character from an unmanaged Unicode string into it.</summary>
		/// <param name="ptr">The address of the first character of the unmanaged string.</param>
		/// <returns>A managed string that holds a copy of the unmanaged string if the value of the <paramref name="ptr" /> parameter is not <see langword="null" />; otherwise, this method returns <see langword="null" />.</returns>
		// Token: 0x06001FA2 RID: 8098
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern string PtrToStringUni(IntPtr ptr);

		/// <summary>Marshals data from an unmanaged block of memory to a newly allocated managed object of the specified type.</summary>
		/// <param name="ptr">A pointer to an unmanaged block of memory.</param>
		/// <param name="structureType">The type of object to be created. This object must represent a formatted class or a structure.</param>
		/// <returns>A managed object containing the data pointed to by the <paramref name="ptr" /> parameter.</returns>
		/// <exception cref="T:System.ArgumentException">The <paramref name="structureType" /> parameter layout is not sequential or explicit.-or-The <paramref name="structureType" /> parameter is a generic type.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="structureType" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.MissingMethodException">
		///         The class specified by <paramref name="structureType" /> does not have an accessible default constructor. </exception>
		// Token: 0x06001FA3 RID: 8099
		[ComVisible(true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern object PtrToStructure(IntPtr ptr, Type structureType);

		/// <summary>Requests a pointer to a specified interface from a COM object.</summary>
		/// <param name="pUnk">The interface to be queried.</param>
		/// <param name="iid">The interface identifier (IID) of the requested interface.</param>
		/// <param name="ppv">When this method returns, contains a reference to the returned interface.</param>
		/// <returns>An HRESULT that indicates the success or failure of the call.</returns>
		// Token: 0x06001FA4 RID: 8100 RVA: 0x0002B1E0 File Offset: 0x000293E0
		public static int QueryInterface(IntPtr pUnk, ref Guid iid, out IntPtr ppv)
		{
			throw new NotImplementedException();
		}

		/// <summary>Reads a single byte at a given offset (or index) from unmanaged memory.</summary>
		/// <param name="ptr">The base address in unmanaged memory from which to read.</param>
		/// <param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before reading.</param>
		/// <returns>The byte read from unmanaged memory at the given offset.</returns>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		// Token: 0x06001FA5 RID: 8101 RVA: 0x00086FB1 File Offset: 0x000851B1
		public unsafe static byte ReadByte(IntPtr ptr, int ofs)
		{
			return ((byte*)((void*)ptr))[ofs];
		}

		/// <summary>Reads a 16-bit signed integer at a given offset from unmanaged memory.</summary>
		/// <param name="ptr">The base address in unmanaged memory from which to read.</param>
		/// <param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before reading.</param>
		/// <returns>The 16-bit signed integer read from unmanaged memory at the given offset.</returns>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		// Token: 0x06001FA6 RID: 8102 RVA: 0x00086FBC File Offset: 0x000851BC
		public unsafe static short ReadInt16(IntPtr ptr, int ofs)
		{
			byte* ptr2 = (byte*)((void*)ptr) + ofs;
			if ((ptr2 & 1U) == 0U)
			{
				return *(short*)ptr2;
			}
			short result;
			Buffer.Memcpy((byte*)(&result), ptr2, 2);
			return result;
		}

		/// <summary>Reads a 32-bit signed integer from unmanaged memory.</summary>
		/// <param name="ptr">The address in unmanaged memory from which to read.</param>
		/// <returns>The 32-bit signed integer read from unmanaged memory.</returns>
		/// <exception cref="T:System.AccessViolationException">
		///         <paramref name="ptr" /> is not a recognized format.-or-
		///         <paramref name="ptr" /> is <see langword="null" />.-or-
		///         <paramref name="ptr" /> is invalid.</exception>
		// Token: 0x06001FA7 RID: 8103 RVA: 0x00086FE8 File Offset: 0x000851E8
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public unsafe static int ReadInt32(IntPtr ptr)
		{
			byte* ptr2 = (byte*)((void*)ptr);
			if ((ptr2 & 3U) == 0U)
			{
				return *(int*)ptr2;
			}
			int result;
			Buffer.Memcpy((byte*)(&result), ptr2, 4);
			return result;
		}

		/// <summary>Reads a 32-bit signed integer at a given offset from unmanaged memory.</summary>
		/// <param name="ptr">The base address in unmanaged memory from which to read.</param>
		/// <param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before reading.</param>
		/// <returns>The 32-bit signed integer read from unmanaged memory.</returns>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		// Token: 0x06001FA8 RID: 8104 RVA: 0x00087010 File Offset: 0x00085210
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public unsafe static int ReadInt32(IntPtr ptr, int ofs)
		{
			byte* ptr2 = (byte*)((void*)ptr) + ofs;
			if ((ptr2 & 3) == 0)
			{
				return *(int*)ptr2;
			}
			int result;
			Buffer.Memcpy((byte*)(&result), ptr2, 4);
			return result;
		}

		/// <summary>Reads a 64-bit signed integer from unmanaged memory.</summary>
		/// <param name="ptr">The address in unmanaged memory from which to read.</param>
		/// <returns>The 64-bit signed integer read from unmanaged memory.</returns>
		/// <exception cref="T:System.AccessViolationException">
		///         <paramref name="ptr" /> is not a recognized format.-or-
		///         <paramref name="ptr" /> is <see langword="null" />.-or-
		///         <paramref name="ptr" /> is invalid.</exception>
		// Token: 0x06001FA9 RID: 8105 RVA: 0x0008703C File Offset: 0x0008523C
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public unsafe static long ReadInt64(IntPtr ptr)
		{
			byte* ptr2 = (byte*)((void*)ptr);
			if ((ptr2 & 7U) == 0U)
			{
				return *(long*)((void*)ptr);
			}
			long result;
			Buffer.Memcpy((byte*)(&result), ptr2, 8);
			return result;
		}

		/// <summary>Reads a 64-bit signed integer at a given offset from unmanaged memory.</summary>
		/// <param name="ptr">The base address in unmanaged memory from which to read.</param>
		/// <param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before reading.</param>
		/// <returns>The 64-bit signed integer read from unmanaged memory at the given offset.</returns>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		// Token: 0x06001FAA RID: 8106 RVA: 0x0008706C File Offset: 0x0008526C
		public unsafe static long ReadInt64(IntPtr ptr, int ofs)
		{
			byte* ptr2 = (byte*)((void*)ptr) + ofs;
			if ((ptr2 & 7U) == 0U)
			{
				return *(long*)ptr2;
			}
			long result;
			Buffer.Memcpy((byte*)(&result), ptr2, 8);
			return result;
		}

		/// <summary>Reads a processor native-sized integer from unmanaged memory.</summary>
		/// <param name="ptr">The address in unmanaged memory from which to read.</param>
		/// <returns>The integer read from unmanaged memory. A 32 bit integer is returned on 32 bit machines and a 64 bit integer is returned on 64 bit machines.</returns>
		/// <exception cref="T:System.AccessViolationException">
		///         <paramref name="ptr" /> is not a recognized format.-or-
		///         <paramref name="ptr" /> is <see langword="null" />. -or-
		///         <paramref name="ptr" /> is invalid.</exception>
		// Token: 0x06001FAB RID: 8107 RVA: 0x00087096 File Offset: 0x00085296
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static IntPtr ReadIntPtr(IntPtr ptr)
		{
			if (IntPtr.Size == 4)
			{
				return (IntPtr)Marshal.ReadInt32(ptr);
			}
			return (IntPtr)Marshal.ReadInt64(ptr);
		}

		/// <summary>Reads a processor native sized integer at a given offset from unmanaged memory.</summary>
		/// <param name="ptr">The base address in unmanaged memory from which to read.</param>
		/// <param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before reading.</param>
		/// <returns>The integer read from unmanaged memory at the given offset.</returns>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		// Token: 0x06001FAC RID: 8108 RVA: 0x000870B7 File Offset: 0x000852B7
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static IntPtr ReadIntPtr(IntPtr ptr, int ofs)
		{
			if (IntPtr.Size == 4)
			{
				return (IntPtr)Marshal.ReadInt32(ptr, ofs);
			}
			return (IntPtr)Marshal.ReadInt64(ptr, ofs);
		}

		/// <summary>Decrements the reference count on the specified interface.</summary>
		/// <param name="pUnk">The interface to release.</param>
		/// <returns>The new value of the reference count on the interface specified by the <paramref name="pUnk" /> parameter.</returns>
		// Token: 0x06001FAD RID: 8109 RVA: 0x0002B1E0 File Offset: 0x000293E0
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static int Release(IntPtr pUnk)
		{
			throw new NotImplementedException();
		}

		/// <summary>Returns the size of an unmanaged type in bytes.</summary>
		/// <param name="t">The type whose size is to be returned.</param>
		/// <returns>The size of the specified type in unmanaged code.</returns>
		/// <exception cref="T:System.ArgumentException">The <paramref name="t" /> parameter is a generic type.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="t" /> parameter is <see langword="null" />.</exception>
		// Token: 0x06001FAE RID: 8110
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int SizeOf(Type t);

		// Token: 0x06001FAF RID: 8111
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern IntPtr StringToHGlobalAnsi(char* s, int length);

		/// <summary>Copies the contents of a managed <see cref="T:System.String" /> into unmanaged memory, converting into ANSI format as it copies.</summary>
		/// <param name="s">A managed string to be copied.</param>
		/// <returns>The address, in unmanaged memory, to where <paramref name="s" /> was copied, or 0 if <paramref name="s" /> is <see langword="null" />.</returns>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory available.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="s" /> parameter exceeds the maximum length allowed by the operating system.</exception>
		// Token: 0x06001FB0 RID: 8112 RVA: 0x000870DC File Offset: 0x000852DC
		public unsafe static IntPtr StringToHGlobalAnsi(string s)
		{
			char* ptr = s;
			if (ptr != null)
			{
				ptr += RuntimeHelpers.OffsetToStringData / 2;
			}
			return Marshal.StringToHGlobalAnsi(ptr, (s != null) ? s.Length : 0);
		}

		// Token: 0x06001FB1 RID: 8113 RVA: 0x0008710B File Offset: 0x0008530B
		internal static IntPtr SecureStringGlobalAllocator(int len)
		{
			return Marshal.AllocHGlobal(len);
		}

		// Token: 0x06001FB2 RID: 8114 RVA: 0x00087114 File Offset: 0x00085314
		internal static IntPtr SecureStringToUnicode(SecureString s, Marshal.SecureStringAllocator allocator)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			int length = s.Length;
			IntPtr intPtr = allocator(length * 2 + 2);
			byte[] array = null;
			try
			{
				array = s.GetBuffer();
				for (int i = 0; i < length; i++)
				{
					Marshal.WriteInt16(intPtr, i * 2, (short)((int)array[i * 2] << 8 | (int)array[i * 2 + 1]));
				}
				Marshal.WriteInt16(intPtr, array.Length, 0);
			}
			finally
			{
				if (array != null)
				{
					int j = array.Length;
					while (j > 0)
					{
						j--;
						array[j] = 0;
					}
				}
			}
			return intPtr;
		}

		/// <summary>Copies the contents of a managed <see cref="T:System.Security.SecureString" /> object into unmanaged memory.</summary>
		/// <param name="s">The managed object to copy.</param>
		/// <returns>The address, in unmanaged memory, where <paramref name="s" /> was copied, or 0 if <paramref name="s" /> is a <see cref="T:System.Security.SecureString" /> object whose length is 0.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="s" /> parameter is <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">The current computer is not running Windows 2000 Service Pack 3 or later.</exception>
		/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory available.</exception>
		// Token: 0x06001FB3 RID: 8115 RVA: 0x000871A8 File Offset: 0x000853A8
		public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s)
		{
			if (s == null)
			{
				throw new ArgumentNullException("s");
			}
			return Marshal.SecureStringToUnicode(s, new Marshal.SecureStringAllocator(Marshal.SecureStringGlobalAllocator));
		}

		/// <summary>Marshals data from a managed object to an unmanaged block of memory.</summary>
		/// <param name="structure">A managed object that holds the data to be marshaled. This object must be a structure or an instance of a formatted class.</param>
		/// <param name="ptr">A pointer to an unmanaged block of memory, which must be allocated before this method is called.</param>
		/// <param name="fDeleteOld">
		///       <see langword="true" /> to call the <see cref="M:System.Runtime.InteropServices.Marshal.DestroyStructure(System.IntPtr,System.Type)" /> method on the <paramref name="ptr" /> parameter before this method copies the data. The block must contain valid data. Note that passing <see langword="false" /> when the memory block already contains data can lead to a memory leak.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="structure" /> is a reference type that is not a formatted class.-or-
		///         <paramref name="structure" /> is a generic type. </exception>
		// Token: 0x06001FB4 RID: 8116
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[ComVisible(true)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld);

		/// <summary>[Supported in the .NET Framework 4.5.1 and later versions] Marshals data from a managed object of a specified type to an unmanaged block of memory. </summary>
		/// <param name="structure">A managed object that holds the data to be marshaled. The object must be a structure or an instance of a formatted class. </param>
		/// <param name="ptr">A pointer to an unmanaged block of memory, which must be allocated before this method is called. </param>
		/// <param name="fDeleteOld">
		///       <see langword="true" /> to call the <see cref="M:System.Runtime.InteropServices.Marshal.DestroyStructure``1(System.IntPtr)" /> method on the <paramref name="ptr" /> parameter before this method copies the data. The block must contain valid data. Note that passing <see langword="false" /> when the memory block already contains data can lead to a memory leak.</param>
		/// <typeparam name="T">The type of the managed object. </typeparam>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="structure" /> is a reference type that is not a formatted class. </exception>
		// Token: 0x06001FB5 RID: 8117 RVA: 0x000871CA File Offset: 0x000853CA
		public static void StructureToPtr<T>(T structure, IntPtr ptr, bool fDeleteOld)
		{
			Marshal.StructureToPtr(structure, ptr, fDeleteOld);
		}

		/// <summary>Throws an exception with a specific failure HRESULT value.</summary>
		/// <param name="errorCode">The HRESULT corresponding to the desired exception.</param>
		// Token: 0x06001FB6 RID: 8118 RVA: 0x000871DC File Offset: 0x000853DC
		public static void ThrowExceptionForHR(int errorCode)
		{
			Exception exceptionForHR = Marshal.GetExceptionForHR(errorCode);
			if (exceptionForHR != null)
			{
				throw exceptionForHR;
			}
		}

		/// <summary>Gets the address of the element at the specified index inside the specified array.</summary>
		/// <param name="arr">The array that contains the desired element.</param>
		/// <param name="index">The index in the <paramref name="arr" /> parameter of the desired element.</param>
		/// <returns>The address of <paramref name="index" /> inside <paramref name="arr" />.</returns>
		// Token: 0x06001FB7 RID: 8119
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index);

		/// <summary>[Supported in the .NET Framework 4.5.1 and later versions] Gets the address of the element at the specified index in an array of a specified type. </summary>
		/// <param name="arr">The array that contains the desired element. </param>
		/// <param name="index">The index of the desired element in the <paramref name="arr" /> array. </param>
		/// <typeparam name="T">The type of the array. </typeparam>
		/// <returns>The address of <paramref name="index" /> in <paramref name="arr" />. </returns>
		// Token: 0x06001FB8 RID: 8120 RVA: 0x000871F5 File Offset: 0x000853F5
		public static IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index)
		{
			return Marshal.UnsafeAddrOfPinnedArrayElement(arr, index);
		}

		/// <summary>Writes a single byte value to unmanaged memory at a specified offset.</summary>
		/// <param name="ptr">The base address in unmanaged memory to write to.</param>
		/// <param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before writing.</param>
		/// <param name="val">The value to write.</param>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		// Token: 0x06001FB9 RID: 8121 RVA: 0x000871FE File Offset: 0x000853FE
		public unsafe static void WriteByte(IntPtr ptr, int ofs, byte val)
		{
			*(byte*)((void*)IntPtr.Add(ptr, ofs)) = val;
		}

		/// <summary>Writes a 16-bit signed integer value into unmanaged memory at a specified offset.</summary>
		/// <param name="ptr">The base address in unmanaged memory to write to.</param>
		/// <param name="ofs">An additional byte offset, which is added to the <paramref name="ptr" /> parameter before writing.</param>
		/// <param name="val">The value to write.</param>
		/// <exception cref="T:System.AccessViolationException">Base address (<paramref name="ptr" />) plus offset byte (<paramref name="ofs" />) produces a null or invalid address.</exception>
		// Token: 0x06001FBA RID: 8122 RVA: 0x00087210 File Offset: 0x00085410
		public unsafe static void WriteInt16(IntPtr ptr, int ofs, short val)
		{
			byte* ptr2 = (byte*)((void*)ptr) + ofs;
			if ((ptr2 & 1U) == 0U)
			{
				*(short*)ptr2 = val;
				return;
			}
			Buffer.Memcpy(ptr2, (byte*)(&val), 2);
		}

		/// <summary>Writes a 32-bit signed integer value to unmanaged memory.</summary>
		/// <param name="ptr">The address in unmanaged memory to write to.</param>
		/// <param name="val">The value to write.</param>
		/// <exception cref="T:System.AccessViolationException">
		///         <paramref name="ptr" /> is not a recognized format.-or-
		///         <paramref name="ptr" /> is <see langword="null" />. -or-
		///         <paramref name="ptr" /> is invalid.</exception>
		// Token: 0x06001FBB RID: 8123 RVA: 0x0008723C File Offset: 0x0008543C
		public unsafe static void WriteInt32(IntPtr ptr, int val)
		{
			byte* ptr2 = (byte*)((void*)ptr);
			if ((ptr2 & 3U) == 0U)
			{
				*(int*)ptr2 = val;
				return;
			}
			Buffer.Memcpy(ptr2, (byte*)(&val), 4);
		}

		/// <summary>Writes a 64-bit signed integer value to unmanaged memory.</summary>
		/// <param name="ptr">The address in unmanaged memory to write to.</param>
		/// <param name="val">The value to write.</param>
		/// <exception cref="T:System.AccessViolationException">
		///         <paramref name="ptr" /> is not a recognized format.-or-
		///         <paramref name="ptr" /> is <see langword="null" />.-or-
		///         <paramref name="ptr" /> is invalid.</exception>
		// Token: 0x06001FBC RID: 8124 RVA: 0x00087264 File Offset: 0x00085464
		public unsafe static void WriteInt64(IntPtr ptr, long val)
		{
			byte* ptr2 = (byte*)((void*)ptr);
			if ((ptr2 & 7U) == 0U)
			{
				*(long*)ptr2 = val;
				return;
			}
			Buffer.Memcpy(ptr2, (byte*)(&val), 8);
		}

		/// <summary>Writes a processor native sized integer value into unmanaged memory.</summary>
		/// <param name="ptr">The address in unmanaged memory to write to.</param>
		/// <param name="val">The value to write.</param>
		/// <exception cref="T:System.AccessViolationException">
		///         <paramref name="ptr" /> is not a recognized format.-or-
		///         <paramref name="ptr" /> is <see langword="null" />.-or-
		///         <paramref name="ptr" /> is invalid.</exception>
		// Token: 0x06001FBD RID: 8125 RVA: 0x0008728C File Offset: 0x0008548C
		public static void WriteIntPtr(IntPtr ptr, IntPtr val)
		{
			if (IntPtr.Size == 4)
			{
				Marshal.WriteInt32(ptr, (int)val);
				return;
			}
			Marshal.WriteInt64(ptr, (long)val);
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x000872B0 File Offset: 0x000854B0
		private static Exception ConvertHrToException(int errorCode)
		{
			if (errorCode > -2147024362)
			{
				if (errorCode <= -2146232828)
				{
					if (errorCode <= -2146893792)
					{
						if (errorCode != -2147023895)
						{
							if (errorCode != -2146893792)
							{
								goto IL_3A9;
							}
							return new CryptographicException();
						}
					}
					else
					{
						if (errorCode == -2146234348)
						{
							return new AppDomainUnloadedException();
						}
						switch (errorCode)
						{
						case -2146233088:
							return new Exception();
						case -2146233087:
							return new SystemException();
						case -2146233086:
							return new ArgumentOutOfRangeException();
						case -2146233085:
							return new ArrayTypeMismatchException();
						case -2146233084:
							return new ContextMarshalException();
						case -2146233083:
						case -2146233074:
						case -2146233073:
						case -2146233061:
						case -2146233060:
						case -2146233059:
						case -2146233058:
						case -2146233057:
						case -2146233055:
						case -2146233053:
						case -2146233052:
						case -2146233051:
						case -2146233050:
						case -2146233046:
						case -2146233045:
						case -2146233044:
						case -2146233043:
						case -2146233042:
						case -2146233041:
						case -2146233040:
						case -2146233035:
						case -2146233034:
							goto IL_3A9;
						case -2146233082:
							return new ExecutionEngineException();
						case -2146233081:
							return new FieldAccessException();
						case -2146233080:
							return new IndexOutOfRangeException();
						case -2146233079:
							return new InvalidOperationException();
						case -2146233078:
							return new SecurityException();
						case -2146233077:
							return new RemotingException();
						case -2146233076:
							return new SerializationException();
						case -2146233075:
							return new VerificationException();
						case -2146233072:
							return new MethodAccessException();
						case -2146233071:
							return new MissingFieldException();
						case -2146233070:
							return new MissingMemberException();
						case -2146233069:
							return new MissingMethodException();
						case -2146233068:
							return new MulticastNotSupportedException();
						case -2146233067:
							return new NotSupportedException();
						case -2146233066:
							return new OverflowException();
						case -2146233065:
							return new RankException();
						case -2146233064:
							return new SynchronizationLockException();
						case -2146233063:
							return new ThreadInterruptedException();
						case -2146233062:
							return new MemberAccessException();
						case -2146233056:
							return new ThreadStateException();
						case -2146233054:
							return new TypeLoadException();
						case -2146233049:
							return new InvalidComObjectException();
						case -2146233048:
							return new NotFiniteNumberException();
						case -2146233047:
							return new DuplicateWaitObjectException();
						case -2146233039:
							return new InvalidOleVariantTypeException();
						case -2146233038:
							return new MissingManifestResourceException();
						case -2146233037:
							return new SafeArrayTypeMismatchException();
						case -2146233036:
							return new TypeInitializationException("", null);
						case -2146233033:
							return new FormatException();
						default:
							switch (errorCode)
							{
							case -2146232832:
								return new ApplicationException();
							case -2146232831:
								return new InvalidFilterCriteriaException();
							case -2146232830:
								return new ReflectionTypeLoadException(new Type[0], new Exception[0]);
							case -2146232829:
								return new TargetException();
							case -2146232828:
								return new TargetInvocationException(null);
							default:
								goto IL_3A9;
							}
							break;
						}
					}
				}
				else if (errorCode <= 3)
				{
					if (errorCode == -2146232800)
					{
						return new IOException();
					}
					if (errorCode == 2)
					{
						goto IL_2A6;
					}
					if (errorCode != 3)
					{
						goto IL_3A9;
					}
					goto IL_27C;
				}
				else
				{
					if (errorCode == 11)
					{
						goto IL_26A;
					}
					if (errorCode == 206)
					{
						goto IL_32A;
					}
					if (errorCode != 1001)
					{
						goto IL_3A9;
					}
				}
				return new StackOverflowException();
			}
			if (errorCode <= -2147024893)
			{
				if (errorCode <= -2147352562)
				{
					switch (errorCode)
					{
					case -2147467263:
						return new NotImplementedException();
					case -2147467262:
						return new InvalidCastException();
					case -2147467261:
						return new NullReferenceException();
					default:
						if (errorCode != -2147352562)
						{
							goto IL_3A9;
						}
						return new TargetParameterCountException();
					}
				}
				else
				{
					if (errorCode == -2147352558)
					{
						return new DivideByZeroException();
					}
					if (errorCode == -2147024894)
					{
						goto IL_2A6;
					}
					if (errorCode != -2147024893)
					{
						goto IL_3A9;
					}
					goto IL_27C;
				}
			}
			else if (errorCode <= -2147024858)
			{
				if (errorCode != -2147024885)
				{
					if (errorCode == -2147024882)
					{
						return new OutOfMemoryException();
					}
					if (errorCode != -2147024858)
					{
						goto IL_3A9;
					}
					return new EndOfStreamException();
				}
			}
			else
			{
				if (errorCode == -2147024809)
				{
					return new ArgumentException();
				}
				if (errorCode == -2147024690)
				{
					goto IL_32A;
				}
				if (errorCode != -2147024362)
				{
					goto IL_3A9;
				}
				return new ArithmeticException();
			}
			IL_26A:
			return new BadImageFormatException();
			IL_27C:
			return new DirectoryNotFoundException();
			IL_2A6:
			return new FileNotFoundException();
			IL_32A:
			return new PathTooLongException();
			IL_3A9:
			if (errorCode < 0)
			{
				return new COMException("", errorCode);
			}
			return null;
		}

		// Token: 0x06001FBF RID: 8127
		[DllImport("oleaut32.dll", CharSet = CharSet.Unicode, EntryPoint = "GetErrorInfo")]
		private static extern int _GetErrorInfo(int dwReserved, [MarshalAs(UnmanagedType.Interface)] out IErrorInfo ppIErrorInfo);

		// Token: 0x06001FC0 RID: 8128 RVA: 0x00087678 File Offset: 0x00085878
		internal static int GetErrorInfo(int dwReserved, out IErrorInfo errorInfo)
		{
			int result = 0;
			errorInfo = null;
			if (Marshal.GetErrorInfoNotAvailable)
			{
				return -1;
			}
			try
			{
				result = Marshal._GetErrorInfo(dwReserved, out errorInfo);
			}
			catch (Exception)
			{
				Marshal.GetErrorInfoNotAvailable = true;
			}
			return result;
		}

		/// <summary>Converts the specified HRESULT error code to a corresponding <see cref="T:System.Exception" /> object.</summary>
		/// <param name="errorCode">The HRESULT to be converted.</param>
		/// <returns>An object that represents the converted HRESULT.</returns>
		// Token: 0x06001FC1 RID: 8129 RVA: 0x000876B8 File Offset: 0x000858B8
		public static Exception GetExceptionForHR(int errorCode)
		{
			return Marshal.GetExceptionForHR(errorCode, IntPtr.Zero);
		}

		/// <summary>Converts the specified HRESULT error code to a corresponding <see cref="T:System.Exception" /> object, with additional error information passed in an IErrorInfo interface for the exception object.</summary>
		/// <param name="errorCode">The HRESULT to be converted.</param>
		/// <param name="errorInfo">A pointer to the <see langword="IErrorInfo" /> interface that provides more information about the error. You can specify IntPtr(0) to use the current <see langword="IErrorInfo" /> interface, or IntPtr(-1) to ignore the current <see langword="IErrorInfo" /> interface and construct the exception just from the error code.</param>
		/// <returns>An object that represents the converted HRESULT and information obtained from <paramref name="errorInfo" />.</returns>
		// Token: 0x06001FC2 RID: 8130 RVA: 0x000876C8 File Offset: 0x000858C8
		public static Exception GetExceptionForHR(int errorCode, IntPtr errorInfo)
		{
			IErrorInfo errorInfo2 = null;
			if (errorInfo != (IntPtr)(-1))
			{
				if (errorInfo == IntPtr.Zero)
				{
					if (Marshal.GetErrorInfo(0, out errorInfo2) != 0)
					{
						errorInfo2 = null;
					}
				}
				else
				{
					errorInfo2 = (Marshal.GetObjectForIUnknown(errorInfo) as IErrorInfo);
				}
			}
			if (errorInfo2 is ManagedErrorInfo && ((ManagedErrorInfo)errorInfo2).Exception._HResult == errorCode)
			{
				return ((ManagedErrorInfo)errorInfo2).Exception;
			}
			Exception ex = Marshal.ConvertHrToException(errorCode);
			if (errorInfo2 != null && ex != null)
			{
				uint num;
				errorInfo2.GetHelpContext(out num);
				string text;
				errorInfo2.GetSource(out text);
				ex.Source = text;
				errorInfo2.GetDescription(out text);
				ex.SetMessage(text);
				errorInfo2.GetHelpFile(out text);
				if (num == 0U)
				{
					ex.HelpLink = text;
				}
				else
				{
					ex.HelpLink = string.Format("{0}#{1}", text, num);
				}
			}
			return ex;
		}

		// Token: 0x06001FC3 RID: 8131
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr GetFunctionPointerForDelegateInternal(Delegate d);

		/// <summary>[Supported in the .NET Framework 4.5.1 and later versions] Converts a delegate of a specified type to a function pointer that is callable from unmanaged code. </summary>
		/// <param name="d">The delegate to be passed to unmanaged code. </param>
		/// <typeparam name="TDelegate">The type of delegate to convert. </typeparam>
		/// <returns>A value that can be passed to unmanaged code, which, in turn, can use it to call the underlying managed delegate. </returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="d" /> parameter is <see langword="null" />. </exception>
		// Token: 0x06001FC4 RID: 8132 RVA: 0x00087796 File Offset: 0x00085996
		public static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d)
		{
			if (d == null)
			{
				throw new ArgumentNullException("d");
			}
			return Marshal.GetFunctionPointerForDelegateInternal((Delegate)((object)d));
		}

		// Token: 0x06001FC5 RID: 8133
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetHRForException_WinRT(Exception e);

		// Token: 0x06001FC6 RID: 8134 RVA: 0x000877BC File Offset: 0x000859BC
		internal static ICustomMarshaler GetCustomMarshalerInstance(Type type, string cookie)
		{
			ValueTuple<Type, string> key = new ValueTuple<Type, string>(type, cookie);
			LazyInitializer.EnsureInitialized<Dictionary<ValueTuple<Type, string>, ICustomMarshaler>>(ref Marshal.MarshalerInstanceCache, () => new Dictionary<ValueTuple<Type, string>, ICustomMarshaler>(new Marshal.MarshalerInstanceKeyComparer()));
			object marshalerInstanceCacheLock = Marshal.MarshalerInstanceCacheLock;
			ICustomMarshaler customMarshaler;
			bool flag2;
			lock (marshalerInstanceCacheLock)
			{
				flag2 = Marshal.MarshalerInstanceCache.TryGetValue(key, out customMarshaler);
			}
			if (!flag2)
			{
				RuntimeMethodInfo runtimeMethodInfo;
				try
				{
					runtimeMethodInfo = (RuntimeMethodInfo)type.GetMethod("GetInstance", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, new Type[]
					{
						typeof(string)
					}, null);
				}
				catch (AmbiguousMatchException)
				{
					throw new ApplicationException("Custom marshaler '" + type.FullName + "' implements multiple static GetInstance methods that take a single string parameter.");
				}
				if (runtimeMethodInfo == null || runtimeMethodInfo.ReturnType != typeof(ICustomMarshaler))
				{
					throw new ApplicationException("Custom marshaler '" + type.FullName + "' does not implement a static GetInstance method that takes a single string parameter and returns an ICustomMarshaler.");
				}
				Exception ex;
				try
				{
					customMarshaler = (ICustomMarshaler)runtimeMethodInfo.InternalInvoke(null, new object[]
					{
						cookie
					}, out ex);
				}
				catch (Exception ex)
				{
					customMarshaler = null;
				}
				if (ex != null)
				{
					ExceptionDispatchInfo.Capture(ex).Throw();
				}
				if (customMarshaler == null)
				{
					throw new ApplicationException("A call to GetInstance() for custom marshaler '" + type.FullName + "' returned null, which is not allowed.");
				}
				marshalerInstanceCacheLock = Marshal.MarshalerInstanceCacheLock;
				lock (marshalerInstanceCacheLock)
				{
					Marshal.MarshalerInstanceCache[key] = customMarshaler;
				}
			}
			return customMarshaler;
		}

		/// <summary>Represents the maximum size of a double byte character set (DBCS) size, in bytes, for the current operating system. This field is read-only.</summary>
		// Token: 0x04000F14 RID: 3860
		public static readonly int SystemMaxDBCSCharSize = 2;

		/// <summary>Represents the default character size on the system; the default is 2 for Unicode systems and 1 for ANSI systems. This field is read-only.</summary>
		// Token: 0x04000F15 RID: 3861
		public static readonly int SystemDefaultCharSize = 1;

		// Token: 0x04000F16 RID: 3862
		private static bool GetErrorInfoNotAvailable;

		// Token: 0x04000F17 RID: 3863
		internal static Dictionary<ValueTuple<Type, string>, ICustomMarshaler> MarshalerInstanceCache;

		// Token: 0x04000F18 RID: 3864
		internal static readonly object MarshalerInstanceCacheLock = new object();

		// Token: 0x02000421 RID: 1057
		// (Invoke) Token: 0x06001FC9 RID: 8137
		internal delegate IntPtr SecureStringAllocator(int len);

		// Token: 0x02000422 RID: 1058
		internal class MarshalerInstanceKeyComparer : IEqualityComparer<ValueTuple<Type, string>>
		{
			// Token: 0x06001FCC RID: 8140 RVA: 0x00087980 File Offset: 0x00085B80
			public bool Equals(ValueTuple<Type, string> lhs, ValueTuple<Type, string> rhs)
			{
				return lhs.CompareTo(rhs) == 0;
			}

			// Token: 0x06001FCD RID: 8141 RVA: 0x0008798D File Offset: 0x00085B8D
			public int GetHashCode(ValueTuple<Type, string> key)
			{
				return key.GetHashCode();
			}
		}
	}
}
