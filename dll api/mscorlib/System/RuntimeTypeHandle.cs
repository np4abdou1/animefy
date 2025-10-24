using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;

namespace System
{
	/// <summary>Represents a type using an internal metadata token.</summary>
	// Token: 0x0200017E RID: 382
	[ComVisible(true)]
	[Serializable]
	public struct RuntimeTypeHandle : ISerializable
	{
		// Token: 0x06000F0A RID: 3850 RVA: 0x0003F6E7 File Offset: 0x0003D8E7
		internal RuntimeTypeHandle(IntPtr val)
		{
			this.value = val;
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x0003F6F0 File Offset: 0x0003D8F0
		internal RuntimeTypeHandle(RuntimeType type)
		{
			this = new RuntimeTypeHandle(type._impl.value);
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x0003F704 File Offset: 0x0003D904
		private RuntimeTypeHandle(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			RuntimeType runtimeType = (RuntimeType)info.GetValue("TypeObj", typeof(RuntimeType));
			this.value = runtimeType.TypeHandle.Value;
			if (this.value == IntPtr.Zero)
			{
				throw new SerializationException("Insufficient state.");
			}
		}

		/// <summary>Gets a handle to the type represented by this instance.</summary>
		/// <returns>A handle to the type represented by this instance.</returns>
		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000F0D RID: 3853 RVA: 0x0003F76B File Offset: 0x0003D96B
		public IntPtr Value
		{
			get
			{
				return this.value;
			}
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data necessary to deserialize the type represented by the current instance.</summary>
		/// <param name="info">The object to be populated with serialization information. </param>
		/// <param name="context">(Reserved) The location where serialized data will be stored and retrieved. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="info" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">
		///         <see cref="P:System.RuntimeTypeHandle.Value" /> is invalid. </exception>
		// Token: 0x06000F0E RID: 3854 RVA: 0x0003F774 File Offset: 0x0003D974
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
			info.AddValue("TypeObj", Type.GetTypeHandle(this), typeof(RuntimeType));
		}

		/// <summary>Indicates whether the specified object is equal to the current <see cref="T:System.RuntimeTypeHandle" /> structure.</summary>
		/// <param name="obj">An object to compare to the current instance.</param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> is a <see cref="T:System.RuntimeTypeHandle" /> structure and is equal to the value of this instance; otherwise, <see langword="false" />.</returns>
		// Token: 0x06000F0F RID: 3855 RVA: 0x0003F7D8 File Offset: 0x0003D9D8
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public override bool Equals(object obj)
		{
			return obj != null && !(base.GetType() != obj.GetType()) && this.value == ((RuntimeTypeHandle)obj).Value;
		}

		/// <summary>Returns the hash code for the current instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x06000F10 RID: 3856 RVA: 0x0003F820 File Offset: 0x0003DA20
		public override int GetHashCode()
		{
			return this.value.GetHashCode();
		}

		// Token: 0x06000F11 RID: 3857
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern TypeAttributes GetAttributes(RuntimeType type);

		// Token: 0x06000F12 RID: 3858
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetMetadataToken(RuntimeType type);

		// Token: 0x06000F13 RID: 3859 RVA: 0x0003F82D File Offset: 0x0003DA2D
		internal static int GetToken(RuntimeType type)
		{
			return RuntimeTypeHandle.GetMetadataToken(type);
		}

		// Token: 0x06000F14 RID: 3860
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Type GetGenericTypeDefinition_impl(RuntimeType type);

		// Token: 0x06000F15 RID: 3861 RVA: 0x0003F835 File Offset: 0x0003DA35
		internal static Type GetGenericTypeDefinition(RuntimeType type)
		{
			return RuntimeTypeHandle.GetGenericTypeDefinition_impl(type);
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x0003F840 File Offset: 0x0003DA40
		internal static bool IsPrimitive(RuntimeType type)
		{
			CorElementType corElementType = RuntimeTypeHandle.GetCorElementType(type);
			return (corElementType >= CorElementType.Boolean && corElementType <= CorElementType.R8) || corElementType == CorElementType.I || corElementType == CorElementType.U;
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x0003F869 File Offset: 0x0003DA69
		internal static bool IsByRef(RuntimeType type)
		{
			return RuntimeTypeHandle.GetCorElementType(type) == CorElementType.ByRef;
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x0003F875 File Offset: 0x0003DA75
		internal static bool IsPointer(RuntimeType type)
		{
			return RuntimeTypeHandle.GetCorElementType(type) == CorElementType.Ptr;
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x0003F884 File Offset: 0x0003DA84
		internal static bool IsArray(RuntimeType type)
		{
			CorElementType corElementType = RuntimeTypeHandle.GetCorElementType(type);
			return corElementType == CorElementType.Array || corElementType == CorElementType.SzArray;
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x0003F8A4 File Offset: 0x0003DAA4
		internal static bool IsSzArray(RuntimeType type)
		{
			return RuntimeTypeHandle.GetCorElementType(type) == CorElementType.SzArray;
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x0003F8B0 File Offset: 0x0003DAB0
		internal static bool HasElementType(RuntimeType type)
		{
			CorElementType corElementType = RuntimeTypeHandle.GetCorElementType(type);
			return corElementType == CorElementType.Array || corElementType == CorElementType.SzArray || corElementType == CorElementType.Ptr || corElementType == CorElementType.ByRef;
		}

		// Token: 0x06000F1C RID: 3868
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern CorElementType GetCorElementType(RuntimeType type);

		// Token: 0x06000F1D RID: 3869
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool HasInstantiation(RuntimeType type);

		// Token: 0x06000F1E RID: 3870
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool IsComObject(RuntimeType type);

		// Token: 0x06000F1F RID: 3871
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool IsInstanceOfType(RuntimeType type, object o);

		// Token: 0x06000F20 RID: 3872
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool HasReferences(RuntimeType type);

		// Token: 0x06000F21 RID: 3873 RVA: 0x0003F8DA File Offset: 0x0003DADA
		internal static bool IsComObject(RuntimeType type, bool isGenericCOM)
		{
			return !isGenericCOM && RuntimeTypeHandle.IsComObject(type);
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x0002ADE6 File Offset: 0x00028FE6
		internal static bool IsContextful(RuntimeType type)
		{
			return typeof(ContextBoundObject).IsAssignableFrom(type);
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2)
		{
			return false;
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x0003F8E7 File Offset: 0x0003DAE7
		internal static bool IsInterface(RuntimeType type)
		{
			return (type.Attributes & TypeAttributes.ClassSemanticsMask) == TypeAttributes.ClassSemanticsMask;
		}

		// Token: 0x06000F25 RID: 3877
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int GetArrayRank(RuntimeType type);

		// Token: 0x06000F26 RID: 3878
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern RuntimeAssembly GetAssembly(RuntimeType type);

		// Token: 0x06000F27 RID: 3879
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern RuntimeType GetElementType(RuntimeType type);

		// Token: 0x06000F28 RID: 3880
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern RuntimeModule GetModule(RuntimeType type);

		// Token: 0x06000F29 RID: 3881
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool IsGenericVariable(RuntimeType type);

		// Token: 0x06000F2A RID: 3882
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern RuntimeType GetBaseType(RuntimeType type);

		// Token: 0x06000F2B RID: 3883 RVA: 0x0003F8F6 File Offset: 0x0003DAF6
		internal static bool CanCastTo(RuntimeType type, RuntimeType target)
		{
			return RuntimeTypeHandle.type_is_assignable_from(target, type);
		}

		// Token: 0x06000F2C RID: 3884
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool type_is_assignable_from(Type a, Type b);

		// Token: 0x06000F2D RID: 3885
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool IsGenericTypeDefinition(RuntimeType type);

		// Token: 0x06000F2E RID: 3886
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern IntPtr GetGenericParameterInfo(RuntimeType type);

		// Token: 0x06000F2F RID: 3887 RVA: 0x0003F8FF File Offset: 0x0003DAFF
		internal static bool IsSubclassOf(RuntimeType childType, RuntimeType baseType)
		{
			return RuntimeTypeHandle.is_subclass_of(childType._impl.Value, baseType._impl.Value);
		}

		// Token: 0x06000F30 RID: 3888
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool is_subclass_of(IntPtr childType, IntPtr baseType);

		// Token: 0x06000F31 RID: 3889
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern RuntimeType internal_from_name(string name, ref StackCrawlMark stackMark, Assembly callerAssembly, bool throwOnError, bool ignoreCase, bool reflectionOnly);

		// Token: 0x06000F32 RID: 3890 RVA: 0x0003F91C File Offset: 0x0003DB1C
		internal static RuntimeType GetTypeByName(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark, bool loadTypeFromPartialName)
		{
			if (typeName == null)
			{
				throw new ArgumentNullException("typeName");
			}
			if (typeName == string.Empty)
			{
				if (throwOnError)
				{
					throw new TypeLoadException("A null or zero length string does not represent a valid Type.");
				}
				return null;
			}
			else if (reflectionOnly)
			{
				int num = typeName.IndexOf(',');
				if (num < 0 || num == 0 || num == typeName.Length - 1)
				{
					throw new ArgumentException("Assembly qualifed type name is required", "typeName");
				}
				string assemblyString = typeName.Substring(num + 1);
				Assembly assembly;
				try
				{
					assembly = Assembly.ReflectionOnlyLoad(assemblyString);
				}
				catch
				{
					if (throwOnError)
					{
						throw;
					}
					return null;
				}
				return (RuntimeType)assembly.GetType(typeName.Substring(0, num), throwOnError, ignoreCase);
			}
			else
			{
				RuntimeType runtimeType = RuntimeTypeHandle.internal_from_name(typeName, ref stackMark, null, throwOnError, ignoreCase, false);
				if (throwOnError && runtimeType == null)
				{
					throw new TypeLoadException("Error loading '" + typeName + "'");
				}
				return runtimeType;
			}
		}

		// Token: 0x040005B2 RID: 1458
		private IntPtr value;
	}
}
