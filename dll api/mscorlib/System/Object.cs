using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Supports all classes in the .NET Framework class hierarchy and provides low-level services to derived classes. This is the ultimate base class of all classes in the .NET Framework; it is the root of the type hierarchy.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x02000179 RID: 377
	[ClassInterface(ClassInterfaceType.AutoDual)]
	[ComVisible(true)]
	[Serializable]
	public class Object
	{
		/// <summary>Determines whether the specified object is equal to the current object.</summary>
		/// <param name="obj">The object to compare with the current object. </param>
		/// <returns>
		///     <see langword="true" /> if the specified object  is equal to the current object; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000EEE RID: 3822 RVA: 0x0002B2FC File Offset: 0x000294FC
		public virtual bool Equals(object obj)
		{
			return this == obj;
		}

		/// <summary>Determines whether the specified object instances are considered equal.</summary>
		/// <param name="objA">The first object to compare. </param>
		/// <param name="objB">The second object to compare. </param>
		/// <returns>
		///     <see langword="true" /> if the objects are considered equal; otherwise, <see langword="false" />. If both <paramref name="objA" /> and <paramref name="objB" /> are null, the method returns <see langword="true" />.</returns>
		// Token: 0x06000EEF RID: 3823 RVA: 0x0003F3D8 File Offset: 0x0003D5D8
		public static bool Equals(object objA, object objB)
		{
			return objA == objB || (objA != null && objB != null && objA.Equals(objB));
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
		// Token: 0x06000EF0 RID: 3824 RVA: 0x00002A7D File Offset: 0x00000C7D
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public Object()
		{
		}

		/// <summary>Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.</summary>
		// Token: 0x06000EF1 RID: 3825 RVA: 0x00002A7D File Offset: 0x00000C7D
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		protected virtual void Finalize()
		{
		}

		/// <summary>Serves as the default hash function. </summary>
		/// <returns>A hash code for the current object.</returns>
		// Token: 0x06000EF2 RID: 3826 RVA: 0x0003F3EF File Offset: 0x0003D5EF
		public virtual int GetHashCode()
		{
			return object.InternalGetHashCode(this);
		}

		/// <summary>Gets the <see cref="T:System.Type" /> of the current instance.</summary>
		/// <returns>The exact runtime type of the current instance.</returns>
		// Token: 0x06000EF3 RID: 3827
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Type GetType();

		/// <summary>Creates a shallow copy of the current <see cref="T:System.Object" />.</summary>
		/// <returns>A shallow copy of the current <see cref="T:System.Object" />.</returns>
		// Token: 0x06000EF4 RID: 3828
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected extern object MemberwiseClone();

		/// <summary>Returns a string that represents the current object.</summary>
		/// <returns>A string that represents the current object.</returns>
		// Token: 0x06000EF5 RID: 3829 RVA: 0x0003F3F7 File Offset: 0x0003D5F7
		public virtual string ToString()
		{
			return this.GetType().ToString();
		}

		// Token: 0x06000EF6 RID: 3830
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int InternalGetHashCode(object o);

		// Token: 0x06000EF7 RID: 3831 RVA: 0x00002A7D File Offset: 0x00000C7D
		private void FieldGetter(string typeName, string fieldName, ref object val)
		{
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x00002A7D File Offset: 0x00000C7D
		private void FieldSetter(string typeName, string fieldName, object val)
		{
		}
	}
}
