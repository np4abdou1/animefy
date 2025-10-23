using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

namespace System
{
	/// <summary>
	///     <see cref="T:System.RuntimeMethodHandle" /> is a handle to the internal metadata representation of a method.</summary>
	// Token: 0x0200017D RID: 381
	[ComVisible(true)]
	[Serializable]
	public struct RuntimeMethodHandle : ISerializable
	{
		// Token: 0x06000F02 RID: 3842 RVA: 0x0003F53F File Offset: 0x0003D73F
		internal RuntimeMethodHandle(IntPtr v)
		{
			this.value = v;
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x0003F548 File Offset: 0x0003D748
		private RuntimeMethodHandle(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			RuntimeMethodInfo runtimeMethodInfo = (RuntimeMethodInfo)info.GetValue("MethodObj", typeof(RuntimeMethodInfo));
			this.value = runtimeMethodInfo.MethodHandle.Value;
			if (this.value == IntPtr.Zero)
			{
				throw new SerializationException("Insufficient state.");
			}
		}

		/// <summary>Gets the value of this instance.</summary>
		/// <returns>A <see cref="T:System.RuntimeMethodHandle" /> that is the internal metadata representation of a method.</returns>
		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x0003F5AF File Offset: 0x0003D7AF
		public IntPtr Value
		{
			get
			{
				return this.value;
			}
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data necessary to deserialize the field represented by this instance.</summary>
		/// <param name="info">The object to populate with serialization information. </param>
		/// <param name="context">(Reserved) The place to store and retrieve serialized data. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">
		///         <see cref="P:System.RuntimeMethodHandle.Value" /> is invalid. </exception>
		// Token: 0x06000F05 RID: 3845 RVA: 0x0003F5B8 File Offset: 0x0003D7B8
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
			info.AddValue("MethodObj", (RuntimeMethodInfo)MethodBase.GetMethodFromHandle(this), typeof(RuntimeMethodInfo));
		}

		/// <summary>Indicates whether this instance is equal to a specified object.</summary>
		/// <param name="obj">A <see cref="T:System.Object" /> to compare to this instance.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> is a <see cref="T:System.RuntimeMethodHandle" /> and equal to the value of this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000F06 RID: 3846 RVA: 0x0003F618 File Offset: 0x0003D818
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public override bool Equals(object obj)
		{
			return obj != null && !(base.GetType() != obj.GetType()) && this.value == ((RuntimeMethodHandle)obj).Value;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000F07 RID: 3847 RVA: 0x0003F660 File Offset: 0x0003D860
		public override int GetHashCode()
		{
			return this.value.GetHashCode();
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x0003F670 File Offset: 0x0003D870
		internal static string ConstructInstantiation(RuntimeMethodInfo method, TypeNameFormatFlags format)
		{
			StringBuilder stringBuilder = new StringBuilder();
			Type[] genericArguments = method.GetGenericArguments();
			stringBuilder.Append("[");
			for (int i = 0; i < genericArguments.Length; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(",");
				}
				stringBuilder.Append(genericArguments[i].Name);
			}
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x0003F6D5 File Offset: 0x0003D8D5
		internal bool IsNullHandle()
		{
			return this.value == IntPtr.Zero;
		}

		// Token: 0x040005B1 RID: 1457
		private IntPtr value;
	}
}
