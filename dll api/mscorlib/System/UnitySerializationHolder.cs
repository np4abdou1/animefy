using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
	// Token: 0x0200015E RID: 350
	[Serializable]
	internal class UnitySerializationHolder : ISerializable, IObjectReference
	{
		// Token: 0x06000DFF RID: 3583 RVA: 0x0003B8FC File Offset: 0x00039AFC
		internal static RuntimeType AddElementTypes(SerializationInfo info, RuntimeType type)
		{
			List<int> list = new List<int>();
			while (type.HasElementType)
			{
				if (type.IsSzArray)
				{
					list.Add(3);
				}
				else if (type.IsArray)
				{
					list.Add(type.GetArrayRank());
					list.Add(2);
				}
				else if (type.IsPointer)
				{
					list.Add(1);
				}
				else if (type.IsByRef)
				{
					list.Add(4);
				}
				type = (RuntimeType)type.GetElementType();
			}
			info.AddValue("ElementTypes", list.ToArray(), typeof(int[]));
			return type;
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x0003B990 File Offset: 0x00039B90
		internal Type MakeElementTypes(Type type)
		{
			for (int i = this.m_elementTypes.Length - 1; i >= 0; i--)
			{
				if (this.m_elementTypes[i] == 3)
				{
					type = type.MakeArrayType();
				}
				else if (this.m_elementTypes[i] == 2)
				{
					type = type.MakeArrayType(this.m_elementTypes[--i]);
				}
				else if (this.m_elementTypes[i] == 1)
				{
					type = type.MakePointerType();
				}
				else if (this.m_elementTypes[i] == 4)
				{
					type = type.MakeByRefType();
				}
			}
			return type;
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x0003BA14 File Offset: 0x00039C14
		internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType)
		{
			info.SetType(typeof(UnitySerializationHolder));
			info.AddValue("Data", null, typeof(string));
			info.AddValue("UnityType", unityType);
			info.AddValue("AssemblyName", string.Empty);
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x0003BA64 File Offset: 0x00039C64
		internal static void GetUnitySerializationInfo(SerializationInfo info, RuntimeType type)
		{
			if (type.GetRootElementType().IsGenericParameter)
			{
				type = UnitySerializationHolder.AddElementTypes(info, type);
				info.SetType(typeof(UnitySerializationHolder));
				info.AddValue("UnityType", 7);
				info.AddValue("GenericParameterPosition", type.GenericParameterPosition);
				info.AddValue("DeclaringMethod", type.DeclaringMethod, typeof(MethodBase));
				info.AddValue("DeclaringType", type.DeclaringType, typeof(Type));
				return;
			}
			int unityType = 4;
			if (!type.IsGenericTypeDefinition && type.ContainsGenericParameters)
			{
				unityType = 8;
				type = UnitySerializationHolder.AddElementTypes(info, type);
				info.AddValue("GenericArguments", type.GetGenericArguments(), typeof(Type[]));
				type = (RuntimeType)type.GetGenericTypeDefinition();
			}
			UnitySerializationHolder.GetUnitySerializationInfo(info, unityType, type.FullName, type.GetRuntimeAssembly());
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x0003BB44 File Offset: 0x00039D44
		internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType, string data, RuntimeAssembly assembly)
		{
			info.SetType(typeof(UnitySerializationHolder));
			info.AddValue("Data", data, typeof(string));
			info.AddValue("UnityType", unityType);
			string value;
			if (assembly == null)
			{
				value = string.Empty;
			}
			else
			{
				value = assembly.FullName;
			}
			info.AddValue("AssemblyName", value);
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x0003BBA8 File Offset: 0x00039DA8
		internal UnitySerializationHolder(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			this.m_unityType = info.GetInt32("UnityType");
			if (this.m_unityType == 3)
			{
				return;
			}
			if (this.m_unityType == 7)
			{
				this.m_declaringMethod = (info.GetValue("DeclaringMethod", typeof(MethodBase)) as MethodBase);
				this.m_declaringType = (info.GetValue("DeclaringType", typeof(Type)) as Type);
				this.m_genericParameterPosition = info.GetInt32("GenericParameterPosition");
				this.m_elementTypes = (info.GetValue("ElementTypes", typeof(int[])) as int[]);
				return;
			}
			if (this.m_unityType == 8)
			{
				this.m_instantiation = (info.GetValue("GenericArguments", typeof(Type[])) as Type[]);
				this.m_elementTypes = (info.GetValue("ElementTypes", typeof(int[])) as int[]);
			}
			this.m_data = info.GetString("Data");
			this.m_assemblyName = info.GetString("AssemblyName");
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0003BCCA File Offset: 0x00039ECA
		private void ThrowInsufficientInformation(string field)
		{
			throw new SerializationException(Environment.GetResourceString("Insufficient state to deserialize the object. Missing field '{0}'. More information is needed.", new object[]
			{
				field
			}));
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x0003BCE5 File Offset: 0x00039EE5
		[SecurityCritical]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new NotSupportedException(Environment.GetResourceString("The UnitySerializationHolder object is designed to transmit information about other types and is not serializable itself."));
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x0003BCF8 File Offset: 0x00039EF8
		[SecurityCritical]
		public virtual object GetRealObject(StreamingContext context)
		{
			switch (this.m_unityType)
			{
			case 1:
				return Empty.Value;
			case 2:
				return DBNull.Value;
			case 3:
				return Missing.Value;
			case 4:
				if (this.m_data == null || this.m_data.Length == 0)
				{
					this.ThrowInsufficientInformation("Data");
				}
				if (this.m_assemblyName == null)
				{
					this.ThrowInsufficientInformation("AssemblyName");
				}
				if (this.m_assemblyName.Length == 0)
				{
					return Type.GetType(this.m_data, true, false);
				}
				return Assembly.Load(this.m_assemblyName).GetType(this.m_data, true, false);
			case 5:
			{
				if (this.m_data == null || this.m_data.Length == 0)
				{
					this.ThrowInsufficientInformation("Data");
				}
				if (this.m_assemblyName == null)
				{
					this.ThrowInsufficientInformation("AssemblyName");
				}
				Module module = Assembly.Load(this.m_assemblyName).GetModule(this.m_data);
				if (module == null)
				{
					throw new SerializationException(Environment.GetResourceString("The given module {0} cannot be found within the assembly {1}.", new object[]
					{
						this.m_data,
						this.m_assemblyName
					}));
				}
				return module;
			}
			case 6:
				if (this.m_data == null || this.m_data.Length == 0)
				{
					this.ThrowInsufficientInformation("Data");
				}
				if (this.m_assemblyName == null)
				{
					this.ThrowInsufficientInformation("AssemblyName");
				}
				return Assembly.Load(this.m_assemblyName);
			case 7:
				if (this.m_declaringMethod == null && this.m_declaringType == null)
				{
					this.ThrowInsufficientInformation("DeclaringMember");
				}
				if (this.m_declaringMethod != null)
				{
					return this.m_declaringMethod.GetGenericArguments()[this.m_genericParameterPosition];
				}
				return this.MakeElementTypes(this.m_declaringType.GetGenericArguments()[this.m_genericParameterPosition]);
			case 8:
			{
				this.m_unityType = 4;
				Type type = this.GetRealObject(context) as Type;
				this.m_unityType = 8;
				if (this.m_instantiation[0] == null)
				{
					return null;
				}
				return this.MakeElementTypes(type.MakeGenericType(this.m_instantiation));
			}
			default:
				throw new ArgumentException(Environment.GetResourceString("Invalid Unity type."));
			}
		}

		// Token: 0x040004FD RID: 1277
		private Type[] m_instantiation;

		// Token: 0x040004FE RID: 1278
		private int[] m_elementTypes;

		// Token: 0x040004FF RID: 1279
		private int m_genericParameterPosition;

		// Token: 0x04000500 RID: 1280
		private Type m_declaringType;

		// Token: 0x04000501 RID: 1281
		private MethodBase m_declaringMethod;

		// Token: 0x04000502 RID: 1282
		private string m_data;

		// Token: 0x04000503 RID: 1283
		private string m_assemblyName;

		// Token: 0x04000504 RID: 1284
		private int m_unityType;
	}
}
