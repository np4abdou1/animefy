using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Runtime.InteropServices
{
	/// <summary>Provides a way to access a managed object from unmanaged memory.</summary>
	// Token: 0x0200041D RID: 1053
	[ComVisible(true)]
	public struct GCHandle
	{
		// Token: 0x06001F69 RID: 8041 RVA: 0x00086B66 File Offset: 0x00084D66
		private GCHandle(IntPtr h)
		{
			this.handle = (int)h;
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x00086B74 File Offset: 0x00084D74
		private GCHandle(object obj)
		{
			this = new GCHandle(obj, GCHandleType.Normal);
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x00086B7E File Offset: 0x00084D7E
		internal GCHandle(object value, GCHandleType type)
		{
			if (type < GCHandleType.Weak || type > GCHandleType.Pinned)
			{
				type = GCHandleType.Normal;
			}
			this.handle = GCHandle.GetTargetHandle(value, 0, type);
		}

		/// <summary>Gets a value indicating whether the handle is allocated.</summary>
		/// <returns>
		///     <see langword="true" /> if the handle is allocated; otherwise, <see langword="false" />.</returns>
		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001F6C RID: 8044 RVA: 0x00086B99 File Offset: 0x00084D99
		public bool IsAllocated
		{
			get
			{
				return this.handle != 0;
			}
		}

		/// <summary>Gets or sets the object this handle represents.</summary>
		/// <returns>The object this handle represents.</returns>
		/// <exception cref="T:System.InvalidOperationException">The handle was freed, or never initialized. </exception>
		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06001F6D RID: 8045 RVA: 0x00086BA4 File Offset: 0x00084DA4
		// (set) Token: 0x06001F6E RID: 8046 RVA: 0x00086BC4 File Offset: 0x00084DC4
		public object Target
		{
			get
			{
				if (!this.IsAllocated)
				{
					throw new InvalidOperationException("Handle is not allocated");
				}
				return GCHandle.GetTarget(this.handle);
			}
			set
			{
				this.handle = GCHandle.GetTargetHandle(value, this.handle, (GCHandleType)(-1));
			}
		}

		/// <summary>Retrieves the address of an object in a <see cref="F:System.Runtime.InteropServices.GCHandleType.Pinned" /> handle.</summary>
		/// <returns>The address of the pinned object as an <see cref="T:System.IntPtr" />. </returns>
		/// <exception cref="T:System.InvalidOperationException">The handle is any type other than <see cref="F:System.Runtime.InteropServices.GCHandleType.Pinned" />. </exception>
		// Token: 0x06001F6F RID: 8047 RVA: 0x00086BD9 File Offset: 0x00084DD9
		public IntPtr AddrOfPinnedObject()
		{
			IntPtr addrOfPinnedObject = GCHandle.GetAddrOfPinnedObject(this.handle);
			if (addrOfPinnedObject == (IntPtr)(-1))
			{
				throw new ArgumentException("Object contains non-primitive or non-blittable data.");
			}
			if (addrOfPinnedObject == (IntPtr)(-2))
			{
				throw new InvalidOperationException("Handle is not pinned.");
			}
			return addrOfPinnedObject;
		}

		/// <summary>Allocates a <see cref="F:System.Runtime.InteropServices.GCHandleType.Normal" /> handle for the specified object.</summary>
		/// <param name="value">The object that uses the <see cref="T:System.Runtime.InteropServices.GCHandle" />. </param>
		/// <returns>A new <see cref="T:System.Runtime.InteropServices.GCHandle" /> that protects the object from garbage collection. This <see cref="T:System.Runtime.InteropServices.GCHandle" /> must be released with <see cref="M:System.Runtime.InteropServices.GCHandle.Free" /> when it is no longer needed.</returns>
		/// <exception cref="T:System.ArgumentException">An instance with nonprimitive (non-blittable) members cannot be pinned. </exception>
		// Token: 0x06001F70 RID: 8048 RVA: 0x00086C19 File Offset: 0x00084E19
		public static GCHandle Alloc(object value)
		{
			return new GCHandle(value);
		}

		/// <summary>Allocates a handle of the specified type for the specified object.</summary>
		/// <param name="value">The object that uses the <see cref="T:System.Runtime.InteropServices.GCHandle" />. </param>
		/// <param name="type">One of the <see cref="T:System.Runtime.InteropServices.GCHandleType" /> values, indicating the type of <see cref="T:System.Runtime.InteropServices.GCHandle" /> to create. </param>
		/// <returns>A new <see cref="T:System.Runtime.InteropServices.GCHandle" /> of the specified type. This <see cref="T:System.Runtime.InteropServices.GCHandle" /> must be released with <see cref="M:System.Runtime.InteropServices.GCHandle.Free" /> when it is no longer needed.</returns>
		/// <exception cref="T:System.ArgumentException">An instance with nonprimitive (non-blittable) members cannot be pinned. </exception>
		// Token: 0x06001F71 RID: 8049 RVA: 0x00086C21 File Offset: 0x00084E21
		public static GCHandle Alloc(object value, GCHandleType type)
		{
			return new GCHandle(value, type);
		}

		/// <summary>Releases a <see cref="T:System.Runtime.InteropServices.GCHandle" />.</summary>
		/// <exception cref="T:System.InvalidOperationException">The handle was freed or never initialized. </exception>
		// Token: 0x06001F72 RID: 8050 RVA: 0x00086C2C File Offset: 0x00084E2C
		public void Free()
		{
			int num = this.handle;
			if (num != 0 && Interlocked.CompareExchange(ref this.handle, 0, num) == num)
			{
				GCHandle.FreeHandle(num);
				return;
			}
			throw new InvalidOperationException("Handle is not initialized.");
		}

		/// <summary>A <see cref="T:System.Runtime.InteropServices.GCHandle" /> is stored using an internal integer representation.</summary>
		/// <param name="value">The <see cref="T:System.Runtime.InteropServices.GCHandle" /> for which the integer is required. </param>
		/// <returns>The integer value.</returns>
		// Token: 0x06001F73 RID: 8051 RVA: 0x00086C64 File Offset: 0x00084E64
		public static explicit operator IntPtr(GCHandle value)
		{
			return (IntPtr)value.handle;
		}

		/// <summary>A <see cref="T:System.Runtime.InteropServices.GCHandle" /> is stored using an internal integer representation.</summary>
		/// <param name="value">An <see cref="T:System.IntPtr" /> that indicates the handle for which the conversion is required. </param>
		/// <returns>The stored <see cref="T:System.Runtime.InteropServices.GCHandle" /> object using an internal integer representation.</returns>
		// Token: 0x06001F74 RID: 8052 RVA: 0x00086C71 File Offset: 0x00084E71
		public static explicit operator GCHandle(IntPtr value)
		{
			if (value == IntPtr.Zero)
			{
				throw new InvalidOperationException("GCHandle value cannot be zero");
			}
			if (!GCHandle.CheckCurrentDomain((int)value))
			{
				throw new ArgumentException("GCHandle value belongs to a different domain");
			}
			return new GCHandle(value);
		}

		// Token: 0x06001F75 RID: 8053
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool CheckCurrentDomain(int handle);

		// Token: 0x06001F76 RID: 8054
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern object GetTarget(int handle);

		// Token: 0x06001F77 RID: 8055
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetTargetHandle(object obj, int handle, GCHandleType type);

		// Token: 0x06001F78 RID: 8056
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void FreeHandle(int handle);

		// Token: 0x06001F79 RID: 8057
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr GetAddrOfPinnedObject(int handle);

		/// <summary>Returns a value indicating whether two <see cref="T:System.Runtime.InteropServices.GCHandle" /> objects are equal.</summary>
		/// <param name="a">A <see cref="T:System.Runtime.InteropServices.GCHandle" /> object to compare with the <paramref name="b" /> parameter. </param>
		/// <param name="b">A <see cref="T:System.Runtime.InteropServices.GCHandle" /> object to compare with the <paramref name="a" /> parameter.  </param>
		/// <returns>
		///     <see langword="true" /> if the <paramref name="a" /> and <paramref name="b" /> parameters are equal; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001F7A RID: 8058 RVA: 0x00086CA9 File Offset: 0x00084EA9
		public static bool operator ==(GCHandle a, GCHandle b)
		{
			return a.handle == b.handle;
		}

		/// <summary>Determines whether the specified <see cref="T:System.Runtime.InteropServices.GCHandle" /> object is equal to the current <see cref="T:System.Runtime.InteropServices.GCHandle" /> object.</summary>
		/// <param name="o">The <see cref="T:System.Runtime.InteropServices.GCHandle" /> object to compare with the current <see cref="T:System.Runtime.InteropServices.GCHandle" /> object.</param>
		/// <returns>
		///     <see langword="true" /> if the specified <see cref="T:System.Runtime.InteropServices.GCHandle" /> object is equal to the current <see cref="T:System.Runtime.InteropServices.GCHandle" /> object; otherwise, <see langword="false" />.</returns>
		// Token: 0x06001F7B RID: 8059 RVA: 0x00086CB9 File Offset: 0x00084EB9
		public override bool Equals(object o)
		{
			return o is GCHandle && this == (GCHandle)o;
		}

		/// <summary>Returns an identifier for the current <see cref="T:System.Runtime.InteropServices.GCHandle" /> object.</summary>
		/// <returns>An identifier for the current <see cref="T:System.Runtime.InteropServices.GCHandle" /> object.</returns>
		// Token: 0x06001F7C RID: 8060 RVA: 0x00086CD6 File Offset: 0x00084ED6
		public override int GetHashCode()
		{
			return this.handle.GetHashCode();
		}

		/// <summary>Returns a new <see cref="T:System.Runtime.InteropServices.GCHandle" /> object created from a handle to a managed object.</summary>
		/// <param name="value">An <see cref="T:System.IntPtr" /> handle to a managed object to create a <see cref="T:System.Runtime.InteropServices.GCHandle" /> object from.</param>
		/// <returns>A new <see cref="T:System.Runtime.InteropServices.GCHandle" /> object that corresponds to the value parameter.  </returns>
		/// <exception cref="T:System.InvalidOperationException">The value of the <paramref name="value" /> parameter is <see cref="F:System.IntPtr.Zero" />.</exception>
		// Token: 0x06001F7D RID: 8061 RVA: 0x00086CE3 File Offset: 0x00084EE3
		public static GCHandle FromIntPtr(IntPtr value)
		{
			return (GCHandle)value;
		}

		/// <summary>Returns the internal integer representation of a <see cref="T:System.Runtime.InteropServices.GCHandle" /> object.</summary>
		/// <param name="value">A <see cref="T:System.Runtime.InteropServices.GCHandle" /> object to retrieve an internal integer representation from.</param>
		/// <returns>An <see cref="T:System.IntPtr" /> object that represents a <see cref="T:System.Runtime.InteropServices.GCHandle" /> object. </returns>
		// Token: 0x06001F7E RID: 8062 RVA: 0x00086CEB File Offset: 0x00084EEB
		public static IntPtr ToIntPtr(GCHandle value)
		{
			return (IntPtr)value;
		}

		// Token: 0x04000F12 RID: 3858
		private int handle;
	}
}
