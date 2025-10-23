using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>A platform-specific type that is used to represent a pointer or a handle.</summary>
	// Token: 0x02000192 RID: 402
	[CLSCompliant(false)]
	[ComVisible(true)]
	[Serializable]
	public readonly struct UIntPtr : ISerializable, IEquatable<UIntPtr>
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.UIntPtr" /> structure using the specified 32-bit pointer or handle.</summary>
		/// <param name="value">A pointer or handle contained in a 32-bit unsigned integer. </param>
		// Token: 0x06000F6A RID: 3946 RVA: 0x00040CE8 File Offset: 0x0003EEE8
		public UIntPtr(uint value)
		{
			this._pointer = value;
		}

		/// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
		/// <param name="obj">An object to compare with this instance or <see langword="null" />. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> is an instance of <see cref="T:System.UIntPtr" /> and equals the value of this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000F6B RID: 3947 RVA: 0x00040CF4 File Offset: 0x0003EEF4
		public override bool Equals(object obj)
		{
			if (obj is UIntPtr)
			{
				UIntPtr uintPtr = (UIntPtr)obj;
				return this._pointer == uintPtr._pointer;
			}
			return false;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000F6C RID: 3948 RVA: 0x00040D21 File Offset: 0x0003EF21
		public override int GetHashCode()
		{
			return this._pointer;
		}

		/// <summary>Converts the numeric value of this instance to its equivalent string representation.</summary>
		/// <returns>The string representation of the value of this instance.</returns>
		// Token: 0x06000F6D RID: 3949 RVA: 0x00040D2C File Offset: 0x0003EF2C
		public override string ToString()
		{
			if (UIntPtr.Size >= 8)
			{
				return this._pointer.ToString();
			}
			return this._pointer.ToString();
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the data needed to serialize the current <see cref="T:System.UIntPtr" /> object.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object to populate with data. </param>
		/// <param name="context">The destination for this serialization. (This parameter is not used; specify <see langword="null" />.)</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />.</exception>
		// Token: 0x06000F6E RID: 3950 RVA: 0x00040D60 File Offset: 0x0003EF60
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("pointer", this._pointer);
		}

		/// <summary>Determines whether two specified instances of <see cref="T:System.UIntPtr" /> are equal.</summary>
		/// <param name="value1">The first pointer or handle to compare. </param>
		/// <param name="value2">The second pointer or handle to compare. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value1" /> equals <paramref name="value2" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000F6F RID: 3951 RVA: 0x00040D82 File Offset: 0x0003EF82
		public static bool operator ==(UIntPtr value1, UIntPtr value2)
		{
			return value1._pointer == value2._pointer;
		}

		/// <summary>Determines whether two specified instances of <see cref="T:System.UIntPtr" /> are not equal.</summary>
		/// <param name="value1">The first pointer or handle to compare. </param>
		/// <param name="value2">The second pointer or handle to compare. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="value1" /> does not equal <paramref name="value2" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000F70 RID: 3952 RVA: 0x00040D94 File Offset: 0x0003EF94
		public static bool operator !=(UIntPtr value1, UIntPtr value2)
		{
			return value1._pointer != value2._pointer;
		}

		/// <summary>Gets the size of this instance.</summary>
		/// <returns>The size of a pointer or handle on this platform, measured in bytes. The value of this property is 4 on a 32-bit platform, and 8 on a 64-bit platform.</returns>
		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000F71 RID: 3953 RVA: 0x0003E015 File Offset: 0x0003C215
		public unsafe static int Size
		{
			get
			{
				return sizeof(void*);
			}
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x00040DA9 File Offset: 0x0003EFA9
		bool IEquatable<UIntPtr>.Equals(UIntPtr other)
		{
			return this._pointer == other._pointer;
		}

		/// <summary>A read-only field that represents a pointer or handle that has been initialized to zero.</summary>
		// Token: 0x040005D9 RID: 1497
		public static readonly UIntPtr Zero = new UIntPtr(0U);

		// Token: 0x040005DA RID: 1498
		private unsafe readonly void* _pointer;
	}
}
