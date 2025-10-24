using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Represents a field using an internal metadata token.</summary>
	// Token: 0x0200017C RID: 380
	[ComVisible(true)]
	[Serializable]
	public struct RuntimeFieldHandle : ISerializable
	{
		// Token: 0x06000EF9 RID: 3833 RVA: 0x0003F404 File Offset: 0x0003D604
		internal RuntimeFieldHandle(IntPtr v)
		{
			this.value = v;
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x0003F410 File Offset: 0x0003D610
		private RuntimeFieldHandle(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			RuntimeFieldInfo runtimeFieldInfo = (RuntimeFieldInfo)info.GetValue("FieldObj", typeof(RuntimeFieldInfo));
			this.value = runtimeFieldInfo.FieldHandle.Value;
			if (this.value == IntPtr.Zero)
			{
				throw new SerializationException("Insufficient state.");
			}
		}

		/// <summary>Gets a handle to the field represented by the current instance.</summary>
		/// <returns>An <see cref="T:System.IntPtr" /> that contains the handle to the field represented by the current instance.</returns>
		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x0003F477 File Offset: 0x0003D677
		public IntPtr Value
		{
			get
			{
				return this.value;
			}
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data necessary to deserialize the field represented by the current instance.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object to populate with serialization information. </param>
		/// <param name="context">(Reserved) The place to store and retrieve serialized data. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <see cref="P:System.RuntimeFieldHandle.Value" /> property of the current instance is not a valid handle. </exception>
		// Token: 0x06000EFC RID: 3836 RVA: 0x0003F480 File Offset: 0x0003D680
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			if (this.value == IntPtr.Zero)
			{
				throw new SerializationException("Object fields may not be properly initialized");
			}
			info.AddValue("FieldObj", (RuntimeFieldInfo)FieldInfo.GetFieldFromHandle(this), typeof(RuntimeFieldInfo));
		}

		/// <summary>Indicates whether the current instance is equal to the specified object.</summary>
		/// <param name="obj">The object to compare to the current instance.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> is a <see cref="T:System.RuntimeFieldHandle" /> and equal to the value of the current instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000EFD RID: 3837 RVA: 0x0003F4E0 File Offset: 0x0003D6E0
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public override bool Equals(object obj)
		{
			return obj != null && !(base.GetType() != obj.GetType()) && this.value == ((RuntimeFieldHandle)obj).Value;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer that is the hash code for this instance.</returns>
		// Token: 0x06000EFE RID: 3838 RVA: 0x0003F528 File Offset: 0x0003D728
		public override int GetHashCode()
		{
			return this.value.GetHashCode();
		}

		// Token: 0x06000EFF RID: 3839
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetValueInternal(FieldInfo fi, object obj, object value);

		// Token: 0x06000F00 RID: 3840 RVA: 0x0003F535 File Offset: 0x0003D735
		internal static void SetValue(RuntimeFieldInfo field, object obj, object value, RuntimeType fieldType, FieldAttributes fieldAttr, RuntimeType declaringType, ref bool domainInitialized)
		{
			RuntimeFieldHandle.SetValueInternal(field, obj, value);
		}

		// Token: 0x06000F01 RID: 3841
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern void SetValueDirect(RuntimeFieldInfo field, RuntimeType fieldType, void* pTypedRef, object value, RuntimeType contextType);

		// Token: 0x040005B0 RID: 1456
		private IntPtr value;
	}
}
