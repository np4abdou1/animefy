using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;

namespace System
{
	/// <summary>Describes objects that contain both a managed pointer to a location and a runtime representation of the type that may be stored at that location.</summary>
	// Token: 0x0200015C RID: 348
	[CLSCompliant(false)]
	[ComVisible(true)]
	[NonVersionable]
	public ref struct TypedReference
	{
		/// <summary>Makes a <see langword="TypedReference" /> for a field identified by a specified object and list of field descriptions.</summary>
		/// <param name="target">An object that contains the field described by the first element of <paramref name="flds" />. </param>
		/// <param name="flds">A list of field descriptions where each element describes a field that contains the field described by the succeeding element. Each described field must be a value type. The field descriptions must be <see langword="RuntimeFieldInfo" /> objects supplied by the type system.</param>
		/// <returns>A <see cref="T:System.TypedReference" /> for the field described by the last element of <paramref name="flds" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="target" /> or <paramref name="flds" /> is <see langword="null" />.-or- An element of <paramref name="flds" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="flds" /> array has no elements.-or- An element of <paramref name="flds" /> is not a <see langword="RuntimeFieldInfo" /> object. -or- The <see cref="P:System.Reflection.FieldInfo.IsInitOnly" /> or <see cref="P:System.Reflection.FieldInfo.IsStatic" /> property of an element of <paramref name="flds" /> is <see langword="true" />. </exception>
		/// <exception cref="T:System.MissingMemberException">Parameter <paramref name="target" /> does not contain the field described by the first element of <paramref name="flds" />, or an element of <paramref name="flds" /> describes a field that is not contained in the field described by the succeeding element of <paramref name="flds" />.-or- The field described by an element of <paramref name="flds" /> is not a value type. </exception>
		// Token: 0x06000DF1 RID: 3569 RVA: 0x0003B544 File Offset: 0x00039744
		[SecurityCritical]
		[CLSCompliant(false)]
		public unsafe static TypedReference MakeTypedReference(object target, FieldInfo[] flds)
		{
			if (target == null)
			{
				throw new ArgumentNullException("target");
			}
			if (flds == null)
			{
				throw new ArgumentNullException("flds");
			}
			if (flds.Length == 0)
			{
				throw new ArgumentException(Environment.GetResourceString("Array must not be of length zero."), "flds");
			}
			IntPtr[] array = new IntPtr[flds.Length];
			RuntimeType runtimeType = (RuntimeType)target.GetType();
			for (int i = 0; i < flds.Length; i++)
			{
				RuntimeFieldInfo runtimeFieldInfo = flds[i] as RuntimeFieldInfo;
				if (runtimeFieldInfo == null)
				{
					throw new ArgumentException(Environment.GetResourceString("FieldInfo must be a runtime FieldInfo object."));
				}
				if (runtimeFieldInfo.IsStatic)
				{
					throw new ArgumentException(Environment.GetResourceString("Field in TypedReferences cannot be static or init only."));
				}
				if (runtimeType != runtimeFieldInfo.GetDeclaringTypeInternal() && !runtimeType.IsSubclassOf(runtimeFieldInfo.GetDeclaringTypeInternal()))
				{
					throw new MissingMemberException(Environment.GetResourceString("FieldInfo does not match the target Type."));
				}
				RuntimeType runtimeType2 = (RuntimeType)runtimeFieldInfo.FieldType;
				if (runtimeType2.IsPrimitive)
				{
					throw new ArgumentException(Environment.GetResourceString("TypedReferences cannot be redefined as primitives."));
				}
				if (i < flds.Length - 1 && !runtimeType2.IsValueType)
				{
					throw new MissingMemberException(Environment.GetResourceString("TypedReference can only be made on nested value Types."));
				}
				array[i] = runtimeFieldInfo.FieldHandle.Value;
				runtimeType = runtimeType2;
			}
			TypedReference result = default(TypedReference);
			TypedReference.InternalMakeTypedReference((void*)(&result), target, array, runtimeType);
			return result;
		}

		// Token: 0x06000DF2 RID: 3570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void InternalMakeTypedReference(void* result, object target, IntPtr[] flds, RuntimeType lastFieldType);

		/// <summary>Returns the hash code of this object.</summary>
		/// <returns>The hash code of this object.</returns>
		// Token: 0x06000DF3 RID: 3571 RVA: 0x0003B68C File Offset: 0x0003988C
		public override int GetHashCode()
		{
			if (this.Type == IntPtr.Zero)
			{
				return 0;
			}
			return __reftype(this).GetHashCode();
		}

		/// <summary>Checks if this object is equal to the specified object.</summary>
		/// <param name="o">The object with which to compare the current object. </param>
		/// <returns>
		///     <see langword="true" /> if this object is equal to the specified object; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.NotSupportedException">This method is not implemented. </exception>
		// Token: 0x06000DF4 RID: 3572 RVA: 0x0003B6B4 File Offset: 0x000398B4
		public override bool Equals(object o)
		{
			throw new NotSupportedException(Environment.GetResourceString("This feature is not currently implemented."));
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x0003B6C5 File Offset: 0x000398C5
		internal bool IsNull
		{
			get
			{
				return this.Value == IntPtr.Zero && this.Type == IntPtr.Zero;
			}
		}

		/// <summary>Converts the specified value to a <see langword="TypedReference" />. This method is not supported.</summary>
		/// <param name="target">The target of the conversion. </param>
		/// <param name="value">The value to be converted. </param>
		/// <exception cref="T:System.NotSupportedException">In all cases. </exception>
		// Token: 0x06000DF6 RID: 3574 RVA: 0x0003B6EB File Offset: 0x000398EB
		[SecuritySafeCritical]
		[CLSCompliant(false)]
		public static void SetTypedReference(TypedReference target, object value)
		{
			throw new NotImplementedException("SetTypedReference");
		}

		// Token: 0x040004F6 RID: 1270
		private RuntimeTypeHandle type;

		// Token: 0x040004F7 RID: 1271
		private IntPtr Value;

		// Token: 0x040004F8 RID: 1272
		private IntPtr Type;
	}
}
