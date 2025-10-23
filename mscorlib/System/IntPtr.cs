using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>A platform-specific type that is used to represent a pointer or a handle.</summary>
	// Token: 0x02000171 RID: 369
	[ComVisible(true)]
	[Serializable]
	public readonly struct IntPtr : ISerializable, IEquatable<IntPtr>
	{
		/// <summary>Initializes a new instance of <see cref="T:System.IntPtr" /> using the specified 32-bit pointer or handle.</summary>
		/// <param name="value">A pointer or handle contained in a 32-bit signed integer. </param>
		// Token: 0x06000EAE RID: 3758 RVA: 0x0003DFD4 File Offset: 0x0003C1D4
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public IntPtr(int value)
		{
			this.m_value = value;
		}

		/// <summary>Initializes a new instance of <see cref="T:System.IntPtr" /> using the specified 64-bit pointer.</summary>
		/// <param name="value">A pointer or handle contained in a 64-bit signed integer. </param>
		/// <exception cref="T:System.OverflowException">On a 32-bit platform, <paramref name="value" /> is too large or too small to represent as an <see cref="T:System.IntPtr" />. </exception>
		// Token: 0x06000EAF RID: 3759 RVA: 0x0003DFDE File Offset: 0x0003C1DE
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public IntPtr(long value)
		{
			this.m_value = value;
		}

		/// <summary>Initializes a new instance of <see cref="T:System.IntPtr" /> using the specified pointer to an unspecified type.</summary>
		/// <param name="value">A pointer to an unspecified type. </param>
		// Token: 0x06000EB0 RID: 3760 RVA: 0x0003DFE8 File Offset: 0x0003C1E8
		[CLSCompliant(false)]
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public unsafe IntPtr(void* value)
		{
			this.m_value = value;
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x0003DFF4 File Offset: 0x0003C1F4
		private IntPtr(SerializationInfo info, StreamingContext context)
		{
			long @int = info.GetInt64("value");
			this.m_value = @int;
		}

		/// <summary>Gets the size of this instance.</summary>
		/// <returns>
		///     The size of a pointer or handle in this process, measured in bytes. The value of this property is 4 in a 32-bit process, and 8 in a 64-bit process. You can define the process type by setting the <see langword="/platform" /> switch when you compile your code with the C# and Visual Basic compilers.</returns>
		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x0003E015 File Offset: 0x0003C215
		public unsafe static int Size
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				return sizeof(void*);
			}
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the data needed to serialize the current <see cref="T:System.IntPtr" /> object.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object to populate with data. </param>
		/// <param name="context">The destination for this serialization. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />.</exception>
		// Token: 0x06000EB3 RID: 3763 RVA: 0x0003E01D File Offset: 0x0003C21D
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("value", this.ToInt64());
		}

		/// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
		/// <param name="obj">An object to compare with this instance or <see langword="null" />. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> is an instance of <see cref="T:System.IntPtr" /> and equals the value of this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000EB4 RID: 3764 RVA: 0x0003E03E File Offset: 0x0003C23E
		public override bool Equals(object obj)
		{
			return obj is IntPtr && ((IntPtr)obj).m_value == this.m_value;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000EB5 RID: 3765 RVA: 0x0003E05D File Offset: 0x0003C25D
		public override int GetHashCode()
		{
			return this.m_value;
		}

		/// <summary>Converts the value of this instance to a 32-bit signed integer.</summary>
		/// <returns>A 32-bit signed integer equal to the value of this instance.</returns>
		/// <exception cref="T:System.OverflowException">On a 64-bit platform, the value of this instance is too large or too small to represent as a 32-bit signed integer. </exception>
		// Token: 0x06000EB6 RID: 3766 RVA: 0x0003E05D File Offset: 0x0003C25D
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public int ToInt32()
		{
			return this.m_value;
		}

		/// <summary>Converts the value of this instance to a 64-bit signed integer.</summary>
		/// <returns>A 64-bit signed integer equal to the value of this instance.</returns>
		// Token: 0x06000EB7 RID: 3767 RVA: 0x0003E066 File Offset: 0x0003C266
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public long ToInt64()
		{
			if (IntPtr.Size == 4)
			{
				return (long)this.m_value;
			}
			return this.m_value;
		}

		/// <summary>Converts the value of this instance to a pointer to an unspecified type.</summary>
		/// <returns>A pointer to <see cref="T:System.Void" />; that is, a pointer to memory containing data of an unspecified type.</returns>
		// Token: 0x06000EB8 RID: 3768 RVA: 0x0003E080 File Offset: 0x0003C280
		[CLSCompliant(false)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public unsafe void* ToPointer()
		{
			return this.m_value;
		}

		/// <summary>Converts the numeric value of the current <see cref="T:System.IntPtr" /> object to its equivalent string representation.</summary>
		/// <returns>The string representation of the value of this instance.</returns>
		// Token: 0x06000EB9 RID: 3769 RVA: 0x0003E088 File Offset: 0x0003C288
		public override string ToString()
		{
			return this.ToString(null);
		}

		/// <summary>Converts the numeric value of the current <see cref="T:System.IntPtr" /> object to its equivalent string representation.</summary>
		/// <param name="format">A format specification that governs how the current <see cref="T:System.IntPtr" /> object is converted. </param>
		/// <returns>The string representation of the value of the current <see cref="T:System.IntPtr" /> object.</returns>
		// Token: 0x06000EBA RID: 3770 RVA: 0x0003E094 File Offset: 0x0003C294
		public string ToString(string format)
		{
			if (IntPtr.Size == 4)
			{
				return this.m_value.ToString(format, null);
			}
			return this.m_value.ToString(format, null);
		}

		/// <summary>Determines whether two specified instances of <see cref="T:System.IntPtr" /> are equal.</summary>
		/// <param name="value1">The first pointer or handle to compare.</param>
		/// <param name="value2">The second pointer or handle to compare.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value1" /> equals <paramref name="value2" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000EBB RID: 3771 RVA: 0x0003E0CC File Offset: 0x0003C2CC
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static bool operator ==(IntPtr value1, IntPtr value2)
		{
			return value1.m_value == value2.m_value;
		}

		/// <summary>Determines whether two specified instances of <see cref="T:System.IntPtr" /> are not equal.</summary>
		/// <param name="value1">The first pointer or handle to compare. </param>
		/// <param name="value2">The second pointer or handle to compare. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value1" /> does not equal <paramref name="value2" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000EBC RID: 3772 RVA: 0x0003E0DE File Offset: 0x0003C2DE
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static bool operator !=(IntPtr value1, IntPtr value2)
		{
			return value1.m_value != value2.m_value;
		}

		/// <summary>Converts the value of a 32-bit signed integer to an <see cref="T:System.IntPtr" />.</summary>
		/// <param name="value">A 32-bit signed integer. </param>
		/// <returns>A new instance of <see cref="T:System.IntPtr" /> initialized to <paramref name="value" />.</returns>
		// Token: 0x06000EBD RID: 3773 RVA: 0x0003E0F3 File Offset: 0x0003C2F3
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public static explicit operator IntPtr(int value)
		{
			return new IntPtr(value);
		}

		/// <summary>Converts the value of a 64-bit signed integer to an <see cref="T:System.IntPtr" />.</summary>
		/// <param name="value">A 64-bit signed integer. </param>
		/// <returns>A new instance of <see cref="T:System.IntPtr" /> initialized to <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">On a 32-bit platform, <paramref name="value" /> is too large to represent as an <see cref="T:System.IntPtr" />. </exception>
		// Token: 0x06000EBE RID: 3774 RVA: 0x0003E0FB File Offset: 0x0003C2FB
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public static explicit operator IntPtr(long value)
		{
			return new IntPtr(value);
		}

		/// <summary>Converts the specified pointer to an unspecified type to an <see cref="T:System.IntPtr" />.</summary>
		/// <param name="value">A pointer to an unspecified type. </param>
		/// <returns>A new instance of <see cref="T:System.IntPtr" /> initialized to <paramref name="value" />.</returns>
		// Token: 0x06000EBF RID: 3775 RVA: 0x0003E103 File Offset: 0x0003C303
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		[CLSCompliant(false)]
		public unsafe static explicit operator IntPtr(void* value)
		{
			return new IntPtr(value);
		}

		/// <summary>Converts the value of the specified <see cref="T:System.IntPtr" /> to a 32-bit signed integer.</summary>
		/// <param name="value">The pointer or handle to convert.</param>
		/// <returns>The contents of <paramref name="value" />.</returns>
		/// <exception cref="T:System.OverflowException">On a 64-bit platform, the value of <paramref name="value" /> is too large to represent as a 32-bit signed integer. </exception>
		// Token: 0x06000EC0 RID: 3776 RVA: 0x0003E10B File Offset: 0x0003C30B
		public static explicit operator int(IntPtr value)
		{
			return value.m_value;
		}

		/// <summary>Converts the value of the specified <see cref="T:System.IntPtr" /> to a 64-bit signed integer.</summary>
		/// <param name="value">The pointer or handle to convert.</param>
		/// <returns>The contents of <paramref name="value" />.</returns>
		// Token: 0x06000EC1 RID: 3777 RVA: 0x0003E115 File Offset: 0x0003C315
		public static explicit operator long(IntPtr value)
		{
			return value.ToInt64();
		}

		/// <summary>Converts the value of the specified <see cref="T:System.IntPtr" /> to a pointer to an unspecified type.</summary>
		/// <param name="value">The pointer or handle to convert. </param>
		/// <returns>The contents of <paramref name="value" />.</returns>
		// Token: 0x06000EC2 RID: 3778 RVA: 0x0003E11E File Offset: 0x0003C31E
		[CLSCompliant(false)]
		public unsafe static explicit operator void*(IntPtr value)
		{
			return value.m_value;
		}

		/// <summary>Adds an offset to the value of a pointer.</summary>
		/// <param name="pointer">The pointer to add the offset to.</param>
		/// <param name="offset">The offset to add.</param>
		/// <returns>A new pointer that reflects the addition of <paramref name="offset" /> to <paramref name="pointer" />.</returns>
		// Token: 0x06000EC3 RID: 3779 RVA: 0x0003E127 File Offset: 0x0003C327
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public unsafe static IntPtr Add(IntPtr pointer, int offset)
		{
			return (IntPtr)((void*)((byte*)((void*)pointer) + offset));
		}

		/// <summary>Adds an offset to the value of a pointer.</summary>
		/// <param name="pointer">The pointer to add the offset to.</param>
		/// <param name="offset">The offset to add.</param>
		/// <returns>A new pointer that reflects the addition of <paramref name="offset" /> to <paramref name="pointer" />.</returns>
		// Token: 0x06000EC4 RID: 3780 RVA: 0x0003E127 File Offset: 0x0003C327
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public unsafe static IntPtr operator +(IntPtr pointer, int offset)
		{
			return (IntPtr)((void*)((byte*)((void*)pointer) + offset));
		}

		/// <summary>Subtracts an offset from the value of a pointer.</summary>
		/// <param name="pointer">The pointer to subtract the offset from.</param>
		/// <param name="offset">The offset to subtract.</param>
		/// <returns>A new pointer that reflects the subtraction of <paramref name="offset" /> from <paramref name="pointer" />.</returns>
		// Token: 0x06000EC5 RID: 3781 RVA: 0x0003E136 File Offset: 0x0003C336
		[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
		public unsafe static IntPtr operator -(IntPtr pointer, int offset)
		{
			return (IntPtr)((void*)((byte*)((void*)pointer) - offset));
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x0003E145 File Offset: 0x0003C345
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal bool IsNull()
		{
			return this.m_value == null;
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x0003E151 File Offset: 0x0003C351
		bool IEquatable<IntPtr>.Equals(IntPtr other)
		{
			return this.m_value == other.m_value;
		}

		// Token: 0x04000596 RID: 1430
		private unsafe readonly void* m_value;

		/// <summary>A read-only field that represents a pointer or handle that has been initialized to zero.</summary>
		// Token: 0x04000597 RID: 1431
		public static readonly IntPtr Zero;
	}
}
