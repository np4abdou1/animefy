using System;
using System.Reflection;
using System.Runtime.Remoting;
using System.Security;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003E4 RID: 996
	internal sealed class WriteObjectInfo
	{
		// Token: 0x06001E4C RID: 7756 RVA: 0x00003ACD File Offset: 0x00001CCD
		internal WriteObjectInfo()
		{
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x0007FF77 File Offset: 0x0007E177
		internal void ObjectEnd()
		{
			WriteObjectInfo.PutObjectInfo(this.serObjectInfoInit, this);
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x0007FF88 File Offset: 0x0007E188
		private void InternalInit()
		{
			this.obj = null;
			this.objectType = null;
			this.isSi = false;
			this.isNamed = false;
			this.isTyped = false;
			this.isArray = false;
			this.si = null;
			this.cache = null;
			this.memberData = null;
			this.objectId = 0L;
			this.assemId = 0L;
			this.binderTypeName = null;
			this.binderAssemblyString = null;
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x0007FFF4 File Offset: 0x0007E1F4
		[SecurityCritical]
		internal static WriteObjectInfo Serialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder)
		{
			WriteObjectInfo objectInfo = WriteObjectInfo.GetObjectInfo(serObjectInfoInit);
			objectInfo.InitSerialize(obj, surrogateSelector, context, serObjectInfoInit, converter, objectWriter, binder);
			return objectInfo;
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x00080018 File Offset: 0x0007E218
		[SecurityCritical]
		internal void InitSerialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder)
		{
			this.context = context;
			this.obj = obj;
			this.serObjectInfoInit = serObjectInfoInit;
			if (RemotingServices.IsTransparentProxy(obj))
			{
				this.objectType = Converter.typeofMarshalByRefObject;
			}
			else
			{
				this.objectType = obj.GetType();
			}
			if (this.objectType.IsArray)
			{
				this.isArray = true;
				this.InitNoMembers();
				return;
			}
			this.InvokeSerializationBinder(binder);
			objectWriter.ObjectManager.RegisterObject(obj);
			ISurrogateSelector surrogateSelector2;
			if (surrogateSelector != null && (this.serializationSurrogate = surrogateSelector.GetSurrogate(this.objectType, context, out surrogateSelector2)) != null)
			{
				this.si = new SerializationInfo(this.objectType, converter);
				if (!this.objectType.IsPrimitive)
				{
					this.serializationSurrogate.GetObjectData(obj, this.si, context);
				}
				this.InitSiWrite();
				return;
			}
			if (!(obj is ISerializable))
			{
				this.InitMemberInfo();
				WriteObjectInfo.CheckTypeForwardedFrom(this.cache, this.objectType, this.binderAssemblyString);
				return;
			}
			if (!this.objectType.IsSerializable)
			{
				throw new SerializationException(Environment.GetResourceString("Type '{0}' in Assembly '{1}' is not marked as serializable.", new object[]
				{
					this.objectType.FullName,
					this.objectType.Assembly.FullName
				}));
			}
			this.si = new SerializationInfo(this.objectType, converter, !FormatterServices.UnsafeTypeForwardersIsEnabled());
			((ISerializable)obj).GetObjectData(this.si, context);
			this.InitSiWrite();
			WriteObjectInfo.CheckTypeForwardedFrom(this.cache, this.objectType, this.binderAssemblyString);
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x0008019A File Offset: 0x0007E39A
		[SecurityCritical]
		internal static WriteObjectInfo Serialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder)
		{
			WriteObjectInfo objectInfo = WriteObjectInfo.GetObjectInfo(serObjectInfoInit);
			objectInfo.InitSerialize(objectType, surrogateSelector, context, serObjectInfoInit, converter, binder);
			return objectInfo;
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x000801B0 File Offset: 0x0007E3B0
		[SecurityCritical]
		internal void InitSerialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder)
		{
			this.objectType = objectType;
			this.context = context;
			this.serObjectInfoInit = serObjectInfoInit;
			if (objectType.IsArray)
			{
				this.InitNoMembers();
				return;
			}
			this.InvokeSerializationBinder(binder);
			ISurrogateSelector surrogateSelector2 = null;
			if (surrogateSelector != null)
			{
				this.serializationSurrogate = surrogateSelector.GetSurrogate(objectType, context, out surrogateSelector2);
			}
			if (this.serializationSurrogate != null)
			{
				this.si = new SerializationInfo(objectType, converter);
				this.cache = new SerObjectInfoCache(objectType);
				this.isSi = true;
			}
			else if (objectType != Converter.typeofObject && Converter.typeofISerializable.IsAssignableFrom(objectType))
			{
				this.si = new SerializationInfo(objectType, converter, !FormatterServices.UnsafeTypeForwardersIsEnabled());
				this.cache = new SerObjectInfoCache(objectType);
				WriteObjectInfo.CheckTypeForwardedFrom(this.cache, objectType, this.binderAssemblyString);
				this.isSi = true;
			}
			if (!this.isSi)
			{
				this.InitMemberInfo();
				WriteObjectInfo.CheckTypeForwardedFrom(this.cache, objectType, this.binderAssemblyString);
			}
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x0008029C File Offset: 0x0007E49C
		private void InitSiWrite()
		{
			this.isSi = true;
			SerializationInfoEnumerator enumerator = this.si.GetEnumerator();
			int memberCount = this.si.MemberCount;
			TypeInformation typeInformation = null;
			string fullTypeName = this.si.FullTypeName;
			string assemblyName = this.si.AssemblyName;
			bool hasTypeForwardedFrom = false;
			if (!this.si.IsFullTypeNameSetExplicit)
			{
				typeInformation = BinaryFormatter.GetTypeInformation(this.si.ObjectType);
				fullTypeName = typeInformation.FullTypeName;
				hasTypeForwardedFrom = typeInformation.HasTypeForwardedFrom;
			}
			if (!this.si.IsAssemblyNameSetExplicit)
			{
				if (typeInformation == null)
				{
					typeInformation = BinaryFormatter.GetTypeInformation(this.si.ObjectType);
				}
				assemblyName = typeInformation.AssemblyString;
				hasTypeForwardedFrom = typeInformation.HasTypeForwardedFrom;
			}
			this.cache = new SerObjectInfoCache(fullTypeName, assemblyName, hasTypeForwardedFrom);
			this.cache.memberNames = new string[memberCount];
			this.cache.memberTypes = new Type[memberCount];
			this.memberData = new object[memberCount];
			enumerator = this.si.GetEnumerator();
			int num = 0;
			while (enumerator.MoveNext())
			{
				this.cache.memberNames[num] = enumerator.Name;
				this.cache.memberTypes[num] = enumerator.ObjectType;
				this.memberData[num] = enumerator.Value;
				num++;
			}
			this.isNamed = true;
			this.isTyped = false;
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x000803E8 File Offset: 0x0007E5E8
		private static void CheckTypeForwardedFrom(SerObjectInfoCache cache, Type objectType, string binderAssemblyString)
		{
			if (cache.hasTypeForwardedFrom && binderAssemblyString == null && !FormatterServices.UnsafeTypeForwardersIsEnabled())
			{
				Assembly assembly = objectType.Assembly;
				if (!SerializationInfo.IsAssemblyNameAssignmentSafe(assembly.FullName, cache.assemblyString) && !assembly.IsFullyTrusted)
				{
					throw new SecurityException(Environment.GetResourceString("A type '{0}' that is defined in a partially trusted assembly cannot be type forwarded from an assembly with a different Public Key Token or without a public key token. To fix this, please either turn on unsafeTypeForwarding flag in the configuration file or remove the TypeForwardedFrom attribute.", new object[]
					{
						objectType
					}));
				}
			}
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x00080444 File Offset: 0x0007E644
		private void InitNoMembers()
		{
			this.cache = (SerObjectInfoCache)this.serObjectInfoInit.seenBeforeTable[this.objectType];
			if (this.cache == null)
			{
				this.cache = new SerObjectInfoCache(this.objectType);
				this.serObjectInfoInit.seenBeforeTable.Add(this.objectType, this.cache);
			}
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x000804A8 File Offset: 0x0007E6A8
		[SecurityCritical]
		private void InitMemberInfo()
		{
			this.cache = (SerObjectInfoCache)this.serObjectInfoInit.seenBeforeTable[this.objectType];
			if (this.cache == null)
			{
				this.cache = new SerObjectInfoCache(this.objectType);
				this.cache.memberInfos = FormatterServices.GetSerializableMembers(this.objectType, this.context);
				int num = this.cache.memberInfos.Length;
				this.cache.memberNames = new string[num];
				this.cache.memberTypes = new Type[num];
				for (int i = 0; i < num; i++)
				{
					this.cache.memberNames[i] = this.cache.memberInfos[i].Name;
					this.cache.memberTypes[i] = this.GetMemberType(this.cache.memberInfos[i]);
				}
				this.serObjectInfoInit.seenBeforeTable.Add(this.objectType, this.cache);
			}
			if (this.obj != null)
			{
				this.memberData = FormatterServices.GetObjectData(this.obj, this.cache.memberInfos);
			}
			this.isTyped = true;
			this.isNamed = true;
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x000805D7 File Offset: 0x0007E7D7
		internal string GetTypeFullName()
		{
			return this.binderTypeName ?? this.cache.fullTypeName;
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x000805EE File Offset: 0x0007E7EE
		internal string GetAssemblyString()
		{
			return this.binderAssemblyString ?? this.cache.assemblyString;
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x00080605 File Offset: 0x0007E805
		private void InvokeSerializationBinder(SerializationBinder binder)
		{
			if (binder != null)
			{
				binder.BindToName(this.objectType, out this.binderAssemblyString, out this.binderTypeName);
			}
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x00080624 File Offset: 0x0007E824
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

		// Token: 0x06001E5B RID: 7771 RVA: 0x00080680 File Offset: 0x0007E880
		internal void GetMemberInfo(out string[] outMemberNames, out Type[] outMemberTypes, out object[] outMemberData)
		{
			outMemberNames = this.cache.memberNames;
			outMemberTypes = this.cache.memberTypes;
			outMemberData = this.memberData;
			if (this.isSi && !this.isNamed)
			{
				throw new SerializationException(Environment.GetResourceString("MemberInfo requested for ISerializable type."));
			}
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x000806D0 File Offset: 0x0007E8D0
		private static WriteObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit)
		{
			WriteObjectInfo writeObjectInfo;
			if (!serObjectInfoInit.oiPool.IsEmpty())
			{
				writeObjectInfo = (WriteObjectInfo)serObjectInfoInit.oiPool.Pop();
				writeObjectInfo.InternalInit();
			}
			else
			{
				writeObjectInfo = new WriteObjectInfo();
				WriteObjectInfo writeObjectInfo2 = writeObjectInfo;
				int objectInfoIdCount = serObjectInfoInit.objectInfoIdCount;
				serObjectInfoInit.objectInfoIdCount = objectInfoIdCount + 1;
				writeObjectInfo2.objectInfoId = objectInfoIdCount;
			}
			return writeObjectInfo;
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x00080723 File Offset: 0x0007E923
		private static void PutObjectInfo(SerObjectInfoInit serObjectInfoInit, WriteObjectInfo objectInfo)
		{
			serObjectInfoInit.oiPool.Push(objectInfo);
		}

		// Token: 0x04000D99 RID: 3481
		internal int objectInfoId;

		// Token: 0x04000D9A RID: 3482
		internal object obj;

		// Token: 0x04000D9B RID: 3483
		internal Type objectType;

		// Token: 0x04000D9C RID: 3484
		internal bool isSi;

		// Token: 0x04000D9D RID: 3485
		internal bool isNamed;

		// Token: 0x04000D9E RID: 3486
		internal bool isTyped;

		// Token: 0x04000D9F RID: 3487
		internal bool isArray;

		// Token: 0x04000DA0 RID: 3488
		internal SerializationInfo si;

		// Token: 0x04000DA1 RID: 3489
		internal SerObjectInfoCache cache;

		// Token: 0x04000DA2 RID: 3490
		internal object[] memberData;

		// Token: 0x04000DA3 RID: 3491
		internal ISerializationSurrogate serializationSurrogate;

		// Token: 0x04000DA4 RID: 3492
		internal StreamingContext context;

		// Token: 0x04000DA5 RID: 3493
		internal SerObjectInfoInit serObjectInfoInit;

		// Token: 0x04000DA6 RID: 3494
		internal long objectId;

		// Token: 0x04000DA7 RID: 3495
		internal long assemId;

		// Token: 0x04000DA8 RID: 3496
		private string binderTypeName;

		// Token: 0x04000DA9 RID: 3497
		private string binderAssemblyString;
	}
}
