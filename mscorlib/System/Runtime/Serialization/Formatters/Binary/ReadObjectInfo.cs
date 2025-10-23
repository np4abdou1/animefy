using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security;
using System.Threading;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003E5 RID: 997
	internal sealed class ReadObjectInfo
	{
		// Token: 0x06001E5E RID: 7774 RVA: 0x00003ACD File Offset: 0x00001CCD
		internal ReadObjectInfo()
		{
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x00002A7D File Offset: 0x00000C7D
		internal void ObjectEnd()
		{
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x00080731 File Offset: 0x0007E931
		internal void PrepareForReuse()
		{
			this.lastPosition = 0;
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x0008073C File Offset: 0x0007E93C
		[SecurityCritical]
		internal static ReadObjectInfo Create(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
			ReadObjectInfo objectInfo = ReadObjectInfo.GetObjectInfo(serObjectInfoInit);
			objectInfo.Init(objectType, surrogateSelector, context, objectManager, serObjectInfoInit, converter, bSimpleAssembly);
			return objectInfo;
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x00080760 File Offset: 0x0007E960
		[SecurityCritical]
		internal void Init(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
			this.objectType = objectType;
			this.objectManager = objectManager;
			this.context = context;
			this.serObjectInfoInit = serObjectInfoInit;
			this.formatterConverter = converter;
			this.bSimpleAssembly = bSimpleAssembly;
			this.InitReadConstructor(objectType, surrogateSelector, context);
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x0008079C File Offset: 0x0007E99C
		[SecurityCritical]
		internal static ReadObjectInfo Create(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
			ReadObjectInfo objectInfo = ReadObjectInfo.GetObjectInfo(serObjectInfoInit);
			objectInfo.Init(objectType, memberNames, memberTypes, surrogateSelector, context, objectManager, serObjectInfoInit, converter, bSimpleAssembly);
			return objectInfo;
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x000807C4 File Offset: 0x0007E9C4
		[SecurityCritical]
		internal void Init(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
			this.objectType = objectType;
			this.objectManager = objectManager;
			this.wireMemberNames = memberNames;
			this.wireMemberTypes = memberTypes;
			this.context = context;
			this.serObjectInfoInit = serObjectInfoInit;
			this.formatterConverter = converter;
			this.bSimpleAssembly = bSimpleAssembly;
			if (memberNames != null)
			{
				this.isNamed = true;
			}
			if (memberTypes != null)
			{
				this.isTyped = true;
			}
			if (objectType != null)
			{
				this.InitReadConstructor(objectType, surrogateSelector, context);
			}
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x00080830 File Offset: 0x0007EA30
		[SecurityCritical]
		private void InitReadConstructor(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context)
		{
			if (objectType.IsArray)
			{
				this.InitNoMembers();
				return;
			}
			ISurrogateSelector surrogateSelector2 = null;
			if (surrogateSelector != null)
			{
				this.serializationSurrogate = surrogateSelector.GetSurrogate(objectType, context, out surrogateSelector2);
			}
			if (this.serializationSurrogate != null)
			{
				this.isSi = true;
			}
			else if (objectType != Converter.typeofObject && Converter.typeofISerializable.IsAssignableFrom(objectType))
			{
				this.isSi = true;
			}
			if (this.isSi)
			{
				this.InitSiRead();
				return;
			}
			this.InitMemberInfo();
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x000808A3 File Offset: 0x0007EAA3
		private void InitSiRead()
		{
			if (this.memberTypesList != null)
			{
				this.memberTypesList = new List<Type>(20);
			}
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x000808BA File Offset: 0x0007EABA
		private void InitNoMembers()
		{
			this.cache = new SerObjectInfoCache(this.objectType);
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x000808D0 File Offset: 0x0007EAD0
		[SecurityCritical]
		private void InitMemberInfo()
		{
			this.cache = new SerObjectInfoCache(this.objectType);
			this.cache.memberInfos = FormatterServices.GetSerializableMembers(this.objectType, this.context);
			this.count = this.cache.memberInfos.Length;
			this.cache.memberNames = new string[this.count];
			this.cache.memberTypes = new Type[this.count];
			for (int i = 0; i < this.count; i++)
			{
				this.cache.memberNames[i] = this.cache.memberInfos[i].Name;
				this.cache.memberTypes[i] = this.GetMemberType(this.cache.memberInfos[i]);
			}
			this.isTyped = true;
			this.isNamed = true;
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x000809A8 File Offset: 0x0007EBA8
		internal MemberInfo GetMemberInfo(string name)
		{
			if (this.cache == null)
			{
				return null;
			}
			if (this.isSi)
			{
				string key = "MemberInfo cannot be obtained for ISerialized Object '{0}'.";
				object[] array = new object[1];
				int num = 0;
				Type type = this.objectType;
				array[num] = ((type != null) ? type.ToString() : null) + " " + name;
				throw new SerializationException(Environment.GetResourceString(key, array));
			}
			if (this.cache.memberInfos == null)
			{
				string key2 = "No MemberInfo for Object {0}.";
				object[] array2 = new object[1];
				int num2 = 0;
				Type type2 = this.objectType;
				array2[num2] = ((type2 != null) ? type2.ToString() : null) + " " + name;
				throw new SerializationException(Environment.GetResourceString(key2, array2));
			}
			if (this.Position(name) != -1)
			{
				return this.cache.memberInfos[this.Position(name)];
			}
			return null;
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x00080A60 File Offset: 0x0007EC60
		internal Type GetType(string name)
		{
			int num = this.Position(name);
			if (num == -1)
			{
				return null;
			}
			Type type;
			if (this.isTyped)
			{
				type = this.cache.memberTypes[num];
			}
			else
			{
				type = this.memberTypesList[num];
			}
			if (type == null)
			{
				string key = "Types not available for ISerializable object '{0}'.";
				object[] array = new object[1];
				int num2 = 0;
				Type type2 = this.objectType;
				array[num2] = ((type2 != null) ? type2.ToString() : null) + " " + name;
				throw new SerializationException(Environment.GetResourceString(key, array));
			}
			return type;
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x00080ADC File Offset: 0x0007ECDC
		internal void AddValue(string name, object value, ref SerializationInfo si, ref object[] memberData)
		{
			if (this.isSi)
			{
				si.AddValue(name, value);
				return;
			}
			int num = this.Position(name);
			if (num != -1)
			{
				memberData[num] = value;
			}
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x00080B10 File Offset: 0x0007ED10
		internal void InitDataStore(ref SerializationInfo si, ref object[] memberData)
		{
			if (this.isSi)
			{
				if (si == null)
				{
					si = new SerializationInfo(this.objectType, this.formatterConverter);
					return;
				}
			}
			else if (memberData == null && this.cache != null)
			{
				memberData = new object[this.cache.memberNames.Length];
			}
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x00080B60 File Offset: 0x0007ED60
		internal void RecordFixup(long objectId, string name, long idRef)
		{
			if (this.isSi)
			{
				this.objectManager.RecordDelayedFixup(objectId, name, idRef);
				return;
			}
			int num = this.Position(name);
			if (num != -1)
			{
				this.objectManager.RecordFixup(objectId, this.cache.memberInfos[num], idRef);
			}
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x00080BAA File Offset: 0x0007EDAA
		[SecurityCritical]
		internal void PopulateObjectMembers(object obj, object[] memberData)
		{
			if (!this.isSi && memberData != null)
			{
				FormatterServices.PopulateObjectMembers(obj, this.cache.memberInfos, memberData);
			}
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x00080BCC File Offset: 0x0007EDCC
		private int Position(string name)
		{
			if (this.cache == null)
			{
				return -1;
			}
			if (this.cache.memberNames.Length != 0 && this.cache.memberNames[this.lastPosition].Equals(name))
			{
				return this.lastPosition;
			}
			int num = this.lastPosition + 1;
			this.lastPosition = num;
			if (num < this.cache.memberNames.Length && this.cache.memberNames[this.lastPosition].Equals(name))
			{
				return this.lastPosition;
			}
			for (int i = 0; i < this.cache.memberNames.Length; i++)
			{
				if (this.cache.memberNames[i].Equals(name))
				{
					this.lastPosition = i;
					return this.lastPosition;
				}
			}
			this.lastPosition = 0;
			return -1;
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x00080C98 File Offset: 0x0007EE98
		internal Type[] GetMemberTypes(string[] inMemberNames, Type objectType)
		{
			if (this.isSi)
			{
				throw new SerializationException(Environment.GetResourceString("Types not available for ISerializable object '{0}'.", new object[]
				{
					objectType
				}));
			}
			if (this.cache == null)
			{
				return null;
			}
			if (this.cache.memberTypes == null)
			{
				this.cache.memberTypes = new Type[this.count];
				for (int i = 0; i < this.count; i++)
				{
					this.cache.memberTypes[i] = this.GetMemberType(this.cache.memberInfos[i]);
				}
			}
			bool flag = false;
			if (inMemberNames.Length < this.cache.memberInfos.Length)
			{
				flag = true;
			}
			Type[] array = new Type[this.cache.memberInfos.Length];
			for (int j = 0; j < this.cache.memberInfos.Length; j++)
			{
				if (!flag && inMemberNames[j].Equals(this.cache.memberInfos[j].Name))
				{
					array[j] = this.cache.memberTypes[j];
				}
				else
				{
					bool flag2 = false;
					for (int k = 0; k < inMemberNames.Length; k++)
					{
						if (this.cache.memberInfos[j].Name.Equals(inMemberNames[k]))
						{
							array[j] = this.cache.memberTypes[j];
							flag2 = true;
							break;
						}
					}
					if (!flag2)
					{
						object[] customAttributes = this.cache.memberInfos[j].GetCustomAttributes(typeof(OptionalFieldAttribute), false);
						if ((customAttributes == null || customAttributes.Length == 0) && !this.bSimpleAssembly)
						{
							throw new SerializationException(Environment.GetResourceString("Member '{0}' in class '{1}' is not present in the serialized stream and is not marked with {2}.", new object[]
							{
								this.cache.memberNames[j],
								objectType,
								typeof(OptionalFieldAttribute).FullName
							}));
						}
					}
				}
			}
			return array;
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x00080E64 File Offset: 0x0007F064
		internal Type GetMemberType(MemberInfo objMember)
		{
			Type result;
			if (objMember is FieldInfo)
			{
				result = ((FieldInfo)objMember).FieldType;
			}
			else
			{
				if (!(objMember is PropertyInfo))
				{
					throw new SerializationException(Environment.GetResourceString("MemberInfo type {0} cannot be serialized.", new object[]
					{
						objMember.GetType()
					}));
				}
				result = ((PropertyInfo)objMember).PropertyType;
			}
			return result;
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x00080EBF File Offset: 0x0007F0BF
		private static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit)
		{
			return new ReadObjectInfo
			{
				objectInfoId = Interlocked.Increment(ref ReadObjectInfo.readObjectInfoCounter)
			};
		}

		// Token: 0x04000DAA RID: 3498
		internal int objectInfoId;

		// Token: 0x04000DAB RID: 3499
		internal static int readObjectInfoCounter;

		// Token: 0x04000DAC RID: 3500
		internal Type objectType;

		// Token: 0x04000DAD RID: 3501
		internal ObjectManager objectManager;

		// Token: 0x04000DAE RID: 3502
		internal int count;

		// Token: 0x04000DAF RID: 3503
		internal bool isSi;

		// Token: 0x04000DB0 RID: 3504
		internal bool isNamed;

		// Token: 0x04000DB1 RID: 3505
		internal bool isTyped;

		// Token: 0x04000DB2 RID: 3506
		internal bool bSimpleAssembly;

		// Token: 0x04000DB3 RID: 3507
		internal SerObjectInfoCache cache;

		// Token: 0x04000DB4 RID: 3508
		internal string[] wireMemberNames;

		// Token: 0x04000DB5 RID: 3509
		internal Type[] wireMemberTypes;

		// Token: 0x04000DB6 RID: 3510
		private int lastPosition;

		// Token: 0x04000DB7 RID: 3511
		internal ISerializationSurrogate serializationSurrogate;

		// Token: 0x04000DB8 RID: 3512
		internal StreamingContext context;

		// Token: 0x04000DB9 RID: 3513
		internal List<Type> memberTypesList;

		// Token: 0x04000DBA RID: 3514
		internal SerObjectInfoInit serObjectInfoInit;

		// Token: 0x04000DBB RID: 3515
		internal IFormatterConverter formatterConverter;
	}
}
