using System;
using System.Globalization;
using System.IO;
using System.Security;
using System.Text;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003ED RID: 1005
	internal sealed class __BinaryParser
	{
		// Token: 0x06001EC4 RID: 7876 RVA: 0x00083C80 File Offset: 0x00081E80
		internal __BinaryParser(Stream stream, ObjectReader objectReader)
		{
			this.input = stream;
			this.objectReader = objectReader;
			this.dataReader = new BinaryReader(this.input, __BinaryParser.encoding);
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001EC5 RID: 7877 RVA: 0x00083CCE File Offset: 0x00081ECE
		internal BinaryAssemblyInfo SystemAssemblyInfo
		{
			get
			{
				if (this.systemAssemblyInfo == null)
				{
					this.systemAssemblyInfo = new BinaryAssemblyInfo(Converter.urtAssemblyString, Converter.urtAssembly);
				}
				return this.systemAssemblyInfo;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001EC6 RID: 7878 RVA: 0x00083CF3 File Offset: 0x00081EF3
		internal SizedArray ObjectMapIdTable
		{
			get
			{
				if (this.objectMapIdTable == null)
				{
					this.objectMapIdTable = new SizedArray();
				}
				return this.objectMapIdTable;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001EC7 RID: 7879 RVA: 0x00083D0E File Offset: 0x00081F0E
		internal SizedArray AssemIdToAssemblyTable
		{
			get
			{
				if (this.assemIdToAssemblyTable == null)
				{
					this.assemIdToAssemblyTable = new SizedArray(2);
				}
				return this.assemIdToAssemblyTable;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x00083D2A File Offset: 0x00081F2A
		internal ParseRecord prs
		{
			get
			{
				if (this.PRS == null)
				{
					this.PRS = new ParseRecord();
				}
				return this.PRS;
			}
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x00083D48 File Offset: 0x00081F48
		[SecurityCritical]
		internal void Run()
		{
			try
			{
				bool flag = true;
				this.ReadBegin();
				this.ReadSerializationHeaderRecord();
				while (flag)
				{
					BinaryHeaderEnum binaryHeaderEnum = BinaryHeaderEnum.Object;
					BinaryTypeEnum binaryTypeEnum = this.expectedType;
					if (binaryTypeEnum != BinaryTypeEnum.Primitive)
					{
						if (binaryTypeEnum - BinaryTypeEnum.String > 6)
						{
							throw new SerializationException(Environment.GetResourceString("Invalid expected type."));
						}
						byte b = this.dataReader.ReadByte();
						binaryHeaderEnum = (BinaryHeaderEnum)b;
						switch (binaryHeaderEnum)
						{
						case BinaryHeaderEnum.Object:
							this.ReadObject();
							break;
						case BinaryHeaderEnum.ObjectWithMap:
						case BinaryHeaderEnum.ObjectWithMapAssemId:
							this.ReadObjectWithMap(binaryHeaderEnum);
							break;
						case BinaryHeaderEnum.ObjectWithMapTyped:
						case BinaryHeaderEnum.ObjectWithMapTypedAssemId:
							this.ReadObjectWithMapTyped(binaryHeaderEnum);
							break;
						case BinaryHeaderEnum.ObjectString:
						case BinaryHeaderEnum.CrossAppDomainString:
							this.ReadObjectString(binaryHeaderEnum);
							break;
						case BinaryHeaderEnum.Array:
						case BinaryHeaderEnum.ArraySinglePrimitive:
						case BinaryHeaderEnum.ArraySingleObject:
						case BinaryHeaderEnum.ArraySingleString:
							this.ReadArray(binaryHeaderEnum);
							break;
						case BinaryHeaderEnum.MemberPrimitiveTyped:
							this.ReadMemberPrimitiveTyped();
							break;
						case BinaryHeaderEnum.MemberReference:
							this.ReadMemberReference();
							break;
						case BinaryHeaderEnum.ObjectNull:
						case BinaryHeaderEnum.ObjectNullMultiple256:
						case BinaryHeaderEnum.ObjectNullMultiple:
							this.ReadObjectNull(binaryHeaderEnum);
							break;
						case BinaryHeaderEnum.MessageEnd:
							flag = false;
							this.ReadMessageEnd();
							this.ReadEnd();
							break;
						case BinaryHeaderEnum.Assembly:
						case BinaryHeaderEnum.CrossAppDomainAssembly:
							this.ReadAssembly(binaryHeaderEnum);
							break;
						case BinaryHeaderEnum.CrossAppDomainMap:
							this.ReadCrossAppDomainMap();
							break;
						case BinaryHeaderEnum.MethodCall:
						case BinaryHeaderEnum.MethodReturn:
							this.ReadMethodObject(binaryHeaderEnum);
							break;
						default:
							throw new SerializationException(Environment.GetResourceString("Binary stream '{0}' does not contain a valid BinaryHeader. Possible causes are invalid stream or object version change between serialization and deserialization.", new object[]
							{
								b
							}));
						}
					}
					else
					{
						this.ReadMemberPrimitiveUnTyped();
					}
					if (binaryHeaderEnum != BinaryHeaderEnum.Assembly)
					{
						bool flag2 = false;
						while (!flag2)
						{
							ObjectProgress objectProgress = (ObjectProgress)this.stack.Peek();
							if (objectProgress == null)
							{
								this.expectedType = BinaryTypeEnum.ObjectUrt;
								this.expectedTypeInformation = null;
								flag2 = true;
							}
							else
							{
								flag2 = objectProgress.GetNext(out objectProgress.expectedType, out objectProgress.expectedTypeInformation);
								this.expectedType = objectProgress.expectedType;
								this.expectedTypeInformation = objectProgress.expectedTypeInformation;
								if (!flag2)
								{
									this.prs.Init();
									if (objectProgress.memberValueEnum == InternalMemberValueE.Nested)
									{
										this.prs.PRparseTypeEnum = InternalParseTypeE.MemberEnd;
										this.prs.PRmemberTypeEnum = objectProgress.memberTypeEnum;
										this.prs.PRmemberValueEnum = objectProgress.memberValueEnum;
										this.objectReader.Parse(this.prs);
									}
									else
									{
										this.prs.PRparseTypeEnum = InternalParseTypeE.ObjectEnd;
										this.prs.PRmemberTypeEnum = objectProgress.memberTypeEnum;
										this.prs.PRmemberValueEnum = objectProgress.memberValueEnum;
										this.objectReader.Parse(this.prs);
									}
									this.stack.Pop();
									this.PutOp(objectProgress);
								}
							}
						}
					}
				}
			}
			catch (EndOfStreamException)
			{
				throw new SerializationException(Environment.GetResourceString("End of Stream encountered before parsing was completed."));
			}
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x00002A7D File Offset: 0x00000C7D
		internal void ReadBegin()
		{
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x00002A7D File Offset: 0x00000C7D
		internal void ReadEnd()
		{
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x00084000 File Offset: 0x00082200
		internal bool ReadBoolean()
		{
			return this.dataReader.ReadBoolean();
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x0008400D File Offset: 0x0008220D
		internal byte ReadByte()
		{
			return this.dataReader.ReadByte();
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x0008401A File Offset: 0x0008221A
		internal byte[] ReadBytes(int length)
		{
			return this.dataReader.ReadBytes(length);
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x00084028 File Offset: 0x00082228
		internal void ReadBytes(byte[] byteA, int offset, int size)
		{
			while (size > 0)
			{
				int num = this.dataReader.Read(byteA, offset, size);
				if (num == 0)
				{
					__Error.EndOfFile();
				}
				offset += num;
				size -= num;
			}
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x0008405C File Offset: 0x0008225C
		internal char ReadChar()
		{
			return this.dataReader.ReadChar();
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x00084069 File Offset: 0x00082269
		internal char[] ReadChars(int length)
		{
			return this.dataReader.ReadChars(length);
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x00084077 File Offset: 0x00082277
		internal decimal ReadDecimal()
		{
			return decimal.Parse(this.dataReader.ReadString(), CultureInfo.InvariantCulture);
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x0008408E File Offset: 0x0008228E
		internal float ReadSingle()
		{
			return this.dataReader.ReadSingle();
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x0008409B File Offset: 0x0008229B
		internal double ReadDouble()
		{
			return this.dataReader.ReadDouble();
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x000840A8 File Offset: 0x000822A8
		internal short ReadInt16()
		{
			return this.dataReader.ReadInt16();
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x000840B5 File Offset: 0x000822B5
		internal int ReadInt32()
		{
			return this.dataReader.ReadInt32();
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x000840C2 File Offset: 0x000822C2
		internal long ReadInt64()
		{
			return this.dataReader.ReadInt64();
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x000840CF File Offset: 0x000822CF
		internal sbyte ReadSByte()
		{
			return (sbyte)this.ReadByte();
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x000840D8 File Offset: 0x000822D8
		internal string ReadString()
		{
			return this.dataReader.ReadString();
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x000840E5 File Offset: 0x000822E5
		internal TimeSpan ReadTimeSpan()
		{
			return new TimeSpan(this.ReadInt64());
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x000840F2 File Offset: 0x000822F2
		internal DateTime ReadDateTime()
		{
			return DateTime.FromBinaryRaw(this.ReadInt64());
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x000840FF File Offset: 0x000822FF
		internal ushort ReadUInt16()
		{
			return this.dataReader.ReadUInt16();
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x0008410C File Offset: 0x0008230C
		internal uint ReadUInt32()
		{
			return this.dataReader.ReadUInt32();
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x00084119 File Offset: 0x00082319
		internal ulong ReadUInt64()
		{
			return this.dataReader.ReadUInt64();
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x00084128 File Offset: 0x00082328
		[SecurityCritical]
		internal void ReadSerializationHeaderRecord()
		{
			SerializationHeaderRecord serializationHeaderRecord = new SerializationHeaderRecord();
			serializationHeaderRecord.Read(this);
			serializationHeaderRecord.Dump();
			this.topId = ((serializationHeaderRecord.topId > 0) ? this.objectReader.GetId((long)serializationHeaderRecord.topId) : ((long)serializationHeaderRecord.topId));
			this.headerId = ((serializationHeaderRecord.headerId > 0) ? this.objectReader.GetId((long)serializationHeaderRecord.headerId) : ((long)serializationHeaderRecord.headerId));
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x0008419C File Offset: 0x0008239C
		[SecurityCritical]
		internal void ReadAssembly(BinaryHeaderEnum binaryHeaderEnum)
		{
			BinaryAssembly binaryAssembly = new BinaryAssembly();
			if (binaryHeaderEnum == BinaryHeaderEnum.CrossAppDomainAssembly)
			{
				BinaryCrossAppDomainAssembly binaryCrossAppDomainAssembly = new BinaryCrossAppDomainAssembly();
				binaryCrossAppDomainAssembly.Read(this);
				binaryCrossAppDomainAssembly.Dump();
				binaryAssembly.assemId = binaryCrossAppDomainAssembly.assemId;
				binaryAssembly.assemblyString = (this.objectReader.CrossAppDomainArray(binaryCrossAppDomainAssembly.assemblyIndex) as string);
				if (binaryAssembly.assemblyString == null)
				{
					throw new SerializationException(Environment.GetResourceString("Cross-AppDomain BinaryFormatter error; expected '{0}' but received '{1}'.", new object[]
					{
						"String",
						binaryCrossAppDomainAssembly.assemblyIndex
					}));
				}
			}
			else
			{
				binaryAssembly.Read(this);
				binaryAssembly.Dump();
			}
			this.AssemIdToAssemblyTable[binaryAssembly.assemId] = new BinaryAssemblyInfo(binaryAssembly.assemblyString);
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x0008424C File Offset: 0x0008244C
		[SecurityCritical]
		internal void ReadMethodObject(BinaryHeaderEnum binaryHeaderEnum)
		{
			if (binaryHeaderEnum == BinaryHeaderEnum.MethodCall)
			{
				BinaryMethodCall binaryMethodCall = new BinaryMethodCall();
				binaryMethodCall.Read(this);
				binaryMethodCall.Dump();
				this.objectReader.SetMethodCall(binaryMethodCall);
				return;
			}
			BinaryMethodReturn binaryMethodReturn = new BinaryMethodReturn();
			binaryMethodReturn.Read(this);
			binaryMethodReturn.Dump();
			this.objectReader.SetMethodReturn(binaryMethodReturn);
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x000842A0 File Offset: 0x000824A0
		[SecurityCritical]
		private void ReadObject()
		{
			if (this.binaryObject == null)
			{
				this.binaryObject = new BinaryObject();
			}
			this.binaryObject.Read(this);
			this.binaryObject.Dump();
			ObjectMap objectMap = (ObjectMap)this.ObjectMapIdTable[this.binaryObject.mapId];
			if (objectMap == null)
			{
				throw new SerializationException(Environment.GetResourceString("No map for object '{0}'.", new object[]
				{
					this.binaryObject.mapId
				}));
			}
			ObjectProgress op = this.GetOp();
			ParseRecord pr = op.pr;
			this.stack.Push(op);
			op.objectTypeEnum = InternalObjectTypeE.Object;
			op.binaryTypeEnumA = objectMap.binaryTypeEnumA;
			op.memberNames = objectMap.memberNames;
			op.memberTypes = objectMap.memberTypes;
			op.typeInformationA = objectMap.typeInformationA;
			op.memberLength = op.binaryTypeEnumA.Length;
			ObjectProgress objectProgress = (ObjectProgress)this.stack.PeekPeek();
			if (objectProgress == null || objectProgress.isInitial)
			{
				op.name = objectMap.objectName;
				pr.PRparseTypeEnum = InternalParseTypeE.Object;
				op.memberValueEnum = InternalMemberValueE.Empty;
			}
			else
			{
				pr.PRparseTypeEnum = InternalParseTypeE.Member;
				pr.PRmemberValueEnum = InternalMemberValueE.Nested;
				op.memberValueEnum = InternalMemberValueE.Nested;
				InternalObjectTypeE objectTypeEnum = objectProgress.objectTypeEnum;
				if (objectTypeEnum != InternalObjectTypeE.Object)
				{
					if (objectTypeEnum != InternalObjectTypeE.Array)
					{
						throw new SerializationException(Environment.GetResourceString("No map for object '{0}'.", new object[]
						{
							objectProgress.objectTypeEnum.ToString()
						}));
					}
					pr.PRmemberTypeEnum = InternalMemberTypeE.Item;
					op.memberTypeEnum = InternalMemberTypeE.Item;
				}
				else
				{
					pr.PRname = objectProgress.name;
					pr.PRmemberTypeEnum = InternalMemberTypeE.Field;
					op.memberTypeEnum = InternalMemberTypeE.Field;
				}
			}
			pr.PRobjectId = this.objectReader.GetId((long)this.binaryObject.objectId);
			pr.PRobjectInfo = objectMap.CreateObjectInfo(ref pr.PRsi, ref pr.PRmemberData);
			if (pr.PRobjectId == this.topId)
			{
				pr.PRobjectPositionEnum = InternalObjectPositionE.Top;
			}
			pr.PRobjectTypeEnum = InternalObjectTypeE.Object;
			pr.PRkeyDt = objectMap.objectName;
			pr.PRdtType = objectMap.objectType;
			pr.PRdtTypeCode = InternalPrimitiveTypeE.Invalid;
			this.objectReader.Parse(pr);
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x000844B0 File Offset: 0x000826B0
		[SecurityCritical]
		internal void ReadCrossAppDomainMap()
		{
			BinaryCrossAppDomainMap binaryCrossAppDomainMap = new BinaryCrossAppDomainMap();
			binaryCrossAppDomainMap.Read(this);
			binaryCrossAppDomainMap.Dump();
			object obj = this.objectReader.CrossAppDomainArray(binaryCrossAppDomainMap.crossAppDomainArrayIndex);
			BinaryObjectWithMap binaryObjectWithMap = obj as BinaryObjectWithMap;
			if (binaryObjectWithMap != null)
			{
				binaryObjectWithMap.Dump();
				this.ReadObjectWithMap(binaryObjectWithMap);
				return;
			}
			BinaryObjectWithMapTyped binaryObjectWithMapTyped = obj as BinaryObjectWithMapTyped;
			if (binaryObjectWithMapTyped != null)
			{
				this.ReadObjectWithMapTyped(binaryObjectWithMapTyped);
				return;
			}
			throw new SerializationException(Environment.GetResourceString("Cross-AppDomain BinaryFormatter error; expected '{0}' but received '{1}'.", new object[]
			{
				"BinaryObjectMap",
				obj
			}));
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x00084530 File Offset: 0x00082730
		[SecurityCritical]
		internal void ReadObjectWithMap(BinaryHeaderEnum binaryHeaderEnum)
		{
			if (this.bowm == null)
			{
				this.bowm = new BinaryObjectWithMap(binaryHeaderEnum);
			}
			else
			{
				this.bowm.binaryHeaderEnum = binaryHeaderEnum;
			}
			this.bowm.Read(this);
			this.bowm.Dump();
			this.ReadObjectWithMap(this.bowm);
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x00084584 File Offset: 0x00082784
		[SecurityCritical]
		private void ReadObjectWithMap(BinaryObjectWithMap record)
		{
			BinaryAssemblyInfo binaryAssemblyInfo = null;
			ObjectProgress op = this.GetOp();
			ParseRecord pr = op.pr;
			this.stack.Push(op);
			if (record.binaryHeaderEnum == BinaryHeaderEnum.ObjectWithMapAssemId)
			{
				if (record.assemId < 1)
				{
					throw new SerializationException(Environment.GetResourceString("No assembly information is available for object on the wire, '{0}'.", new object[]
					{
						record.name
					}));
				}
				binaryAssemblyInfo = (BinaryAssemblyInfo)this.AssemIdToAssemblyTable[record.assemId];
				if (binaryAssemblyInfo == null)
				{
					throw new SerializationException(Environment.GetResourceString("No assembly information is available for object on the wire, '{0}'.", new object[]
					{
						record.assemId.ToString() + " " + record.name
					}));
				}
			}
			else if (record.binaryHeaderEnum == BinaryHeaderEnum.ObjectWithMap)
			{
				binaryAssemblyInfo = this.SystemAssemblyInfo;
			}
			Type type = this.objectReader.GetType(binaryAssemblyInfo, record.name);
			ObjectMap objectMap = ObjectMap.Create(record.name, type, record.memberNames, this.objectReader, record.objectId, binaryAssemblyInfo);
			this.ObjectMapIdTable[record.objectId] = objectMap;
			op.objectTypeEnum = InternalObjectTypeE.Object;
			op.binaryTypeEnumA = objectMap.binaryTypeEnumA;
			op.typeInformationA = objectMap.typeInformationA;
			op.memberLength = op.binaryTypeEnumA.Length;
			op.memberNames = objectMap.memberNames;
			op.memberTypes = objectMap.memberTypes;
			ObjectProgress objectProgress = (ObjectProgress)this.stack.PeekPeek();
			if (objectProgress == null || objectProgress.isInitial)
			{
				op.name = record.name;
				pr.PRparseTypeEnum = InternalParseTypeE.Object;
				op.memberValueEnum = InternalMemberValueE.Empty;
			}
			else
			{
				pr.PRparseTypeEnum = InternalParseTypeE.Member;
				pr.PRmemberValueEnum = InternalMemberValueE.Nested;
				op.memberValueEnum = InternalMemberValueE.Nested;
				InternalObjectTypeE objectTypeEnum = objectProgress.objectTypeEnum;
				if (objectTypeEnum != InternalObjectTypeE.Object)
				{
					if (objectTypeEnum != InternalObjectTypeE.Array)
					{
						throw new SerializationException(Environment.GetResourceString("Invalid ObjectTypeEnum {0}.", new object[]
						{
							objectProgress.objectTypeEnum.ToString()
						}));
					}
					pr.PRmemberTypeEnum = InternalMemberTypeE.Item;
					op.memberTypeEnum = InternalMemberTypeE.Field;
				}
				else
				{
					pr.PRname = objectProgress.name;
					pr.PRmemberTypeEnum = InternalMemberTypeE.Field;
					op.memberTypeEnum = InternalMemberTypeE.Field;
				}
			}
			pr.PRobjectTypeEnum = InternalObjectTypeE.Object;
			pr.PRobjectId = this.objectReader.GetId((long)record.objectId);
			pr.PRobjectInfo = objectMap.CreateObjectInfo(ref pr.PRsi, ref pr.PRmemberData);
			if (pr.PRobjectId == this.topId)
			{
				pr.PRobjectPositionEnum = InternalObjectPositionE.Top;
			}
			pr.PRkeyDt = record.name;
			pr.PRdtType = objectMap.objectType;
			pr.PRdtTypeCode = InternalPrimitiveTypeE.Invalid;
			this.objectReader.Parse(pr);
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x00084804 File Offset: 0x00082A04
		[SecurityCritical]
		internal void ReadObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum)
		{
			if (this.bowmt == null)
			{
				this.bowmt = new BinaryObjectWithMapTyped(binaryHeaderEnum);
			}
			else
			{
				this.bowmt.binaryHeaderEnum = binaryHeaderEnum;
			}
			this.bowmt.Read(this);
			this.ReadObjectWithMapTyped(this.bowmt);
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x00084840 File Offset: 0x00082A40
		[SecurityCritical]
		private void ReadObjectWithMapTyped(BinaryObjectWithMapTyped record)
		{
			BinaryAssemblyInfo binaryAssemblyInfo = null;
			ObjectProgress op = this.GetOp();
			ParseRecord pr = op.pr;
			this.stack.Push(op);
			if (record.binaryHeaderEnum == BinaryHeaderEnum.ObjectWithMapTypedAssemId)
			{
				if (record.assemId < 1)
				{
					throw new SerializationException(Environment.GetResourceString("No assembly ID for object type '{0}'.", new object[]
					{
						record.name
					}));
				}
				binaryAssemblyInfo = (BinaryAssemblyInfo)this.AssemIdToAssemblyTable[record.assemId];
				if (binaryAssemblyInfo == null)
				{
					throw new SerializationException(Environment.GetResourceString("No assembly ID for object type '{0}'.", new object[]
					{
						record.assemId.ToString() + " " + record.name
					}));
				}
			}
			else if (record.binaryHeaderEnum == BinaryHeaderEnum.ObjectWithMapTyped)
			{
				binaryAssemblyInfo = this.SystemAssemblyInfo;
			}
			ObjectMap objectMap = ObjectMap.Create(record.name, record.memberNames, record.binaryTypeEnumA, record.typeInformationA, record.memberAssemIds, this.objectReader, record.objectId, binaryAssemblyInfo, this.AssemIdToAssemblyTable);
			this.ObjectMapIdTable[record.objectId] = objectMap;
			op.objectTypeEnum = InternalObjectTypeE.Object;
			op.binaryTypeEnumA = objectMap.binaryTypeEnumA;
			op.typeInformationA = objectMap.typeInformationA;
			op.memberLength = op.binaryTypeEnumA.Length;
			op.memberNames = objectMap.memberNames;
			op.memberTypes = objectMap.memberTypes;
			ObjectProgress objectProgress = (ObjectProgress)this.stack.PeekPeek();
			if (objectProgress == null || objectProgress.isInitial)
			{
				op.name = record.name;
				pr.PRparseTypeEnum = InternalParseTypeE.Object;
				op.memberValueEnum = InternalMemberValueE.Empty;
			}
			else
			{
				pr.PRparseTypeEnum = InternalParseTypeE.Member;
				pr.PRmemberValueEnum = InternalMemberValueE.Nested;
				op.memberValueEnum = InternalMemberValueE.Nested;
				InternalObjectTypeE objectTypeEnum = objectProgress.objectTypeEnum;
				if (objectTypeEnum != InternalObjectTypeE.Object)
				{
					if (objectTypeEnum != InternalObjectTypeE.Array)
					{
						throw new SerializationException(Environment.GetResourceString("Invalid ObjectTypeEnum {0}.", new object[]
						{
							objectProgress.objectTypeEnum.ToString()
						}));
					}
					pr.PRmemberTypeEnum = InternalMemberTypeE.Item;
					op.memberTypeEnum = InternalMemberTypeE.Item;
				}
				else
				{
					pr.PRname = objectProgress.name;
					pr.PRmemberTypeEnum = InternalMemberTypeE.Field;
					op.memberTypeEnum = InternalMemberTypeE.Field;
				}
			}
			pr.PRobjectTypeEnum = InternalObjectTypeE.Object;
			pr.PRobjectInfo = objectMap.CreateObjectInfo(ref pr.PRsi, ref pr.PRmemberData);
			pr.PRobjectId = this.objectReader.GetId((long)record.objectId);
			if (pr.PRobjectId == this.topId)
			{
				pr.PRobjectPositionEnum = InternalObjectPositionE.Top;
			}
			pr.PRkeyDt = record.name;
			pr.PRdtType = objectMap.objectType;
			pr.PRdtTypeCode = InternalPrimitiveTypeE.Invalid;
			this.objectReader.Parse(pr);
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x00084ABC File Offset: 0x00082CBC
		[SecurityCritical]
		private void ReadObjectString(BinaryHeaderEnum binaryHeaderEnum)
		{
			if (this.objectString == null)
			{
				this.objectString = new BinaryObjectString();
			}
			if (binaryHeaderEnum == BinaryHeaderEnum.ObjectString)
			{
				this.objectString.Read(this);
				this.objectString.Dump();
			}
			else
			{
				if (this.crossAppDomainString == null)
				{
					this.crossAppDomainString = new BinaryCrossAppDomainString();
				}
				this.crossAppDomainString.Read(this);
				this.crossAppDomainString.Dump();
				this.objectString.value = (this.objectReader.CrossAppDomainArray(this.crossAppDomainString.value) as string);
				if (this.objectString.value == null)
				{
					throw new SerializationException(Environment.GetResourceString("Cross-AppDomain BinaryFormatter error; expected '{0}' but received '{1}'.", new object[]
					{
						"String",
						this.crossAppDomainString.value
					}));
				}
				this.objectString.objectId = this.crossAppDomainString.objectId;
			}
			this.prs.Init();
			this.prs.PRparseTypeEnum = InternalParseTypeE.Object;
			this.prs.PRobjectId = this.objectReader.GetId((long)this.objectString.objectId);
			if (this.prs.PRobjectId == this.topId)
			{
				this.prs.PRobjectPositionEnum = InternalObjectPositionE.Top;
			}
			this.prs.PRobjectTypeEnum = InternalObjectTypeE.Object;
			ObjectProgress objectProgress = (ObjectProgress)this.stack.Peek();
			this.prs.PRvalue = this.objectString.value;
			this.prs.PRkeyDt = "System.String";
			this.prs.PRdtType = Converter.typeofString;
			this.prs.PRdtTypeCode = InternalPrimitiveTypeE.Invalid;
			this.prs.PRvarValue = this.objectString.value;
			if (objectProgress == null)
			{
				this.prs.PRparseTypeEnum = InternalParseTypeE.Object;
				this.prs.PRname = "System.String";
			}
			else
			{
				this.prs.PRparseTypeEnum = InternalParseTypeE.Member;
				this.prs.PRmemberValueEnum = InternalMemberValueE.InlineValue;
				InternalObjectTypeE objectTypeEnum = objectProgress.objectTypeEnum;
				if (objectTypeEnum != InternalObjectTypeE.Object)
				{
					if (objectTypeEnum != InternalObjectTypeE.Array)
					{
						throw new SerializationException(Environment.GetResourceString("Invalid ObjectTypeEnum {0}.", new object[]
						{
							objectProgress.objectTypeEnum.ToString()
						}));
					}
					this.prs.PRmemberTypeEnum = InternalMemberTypeE.Item;
				}
				else
				{
					this.prs.PRname = objectProgress.name;
					this.prs.PRmemberTypeEnum = InternalMemberTypeE.Field;
				}
			}
			this.objectReader.Parse(this.prs);
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x00084D20 File Offset: 0x00082F20
		[SecurityCritical]
		private void ReadMemberPrimitiveTyped()
		{
			if (this.memberPrimitiveTyped == null)
			{
				this.memberPrimitiveTyped = new MemberPrimitiveTyped();
			}
			this.memberPrimitiveTyped.Read(this);
			this.memberPrimitiveTyped.Dump();
			this.prs.PRobjectTypeEnum = InternalObjectTypeE.Object;
			ObjectProgress objectProgress = (ObjectProgress)this.stack.Peek();
			this.prs.Init();
			this.prs.PRvarValue = this.memberPrimitiveTyped.value;
			this.prs.PRkeyDt = Converter.ToComType(this.memberPrimitiveTyped.primitiveTypeEnum);
			this.prs.PRdtType = Converter.ToType(this.memberPrimitiveTyped.primitiveTypeEnum);
			this.prs.PRdtTypeCode = this.memberPrimitiveTyped.primitiveTypeEnum;
			if (objectProgress == null)
			{
				this.prs.PRparseTypeEnum = InternalParseTypeE.Object;
				this.prs.PRname = "System.Variant";
			}
			else
			{
				this.prs.PRparseTypeEnum = InternalParseTypeE.Member;
				this.prs.PRmemberValueEnum = InternalMemberValueE.InlineValue;
				InternalObjectTypeE objectTypeEnum = objectProgress.objectTypeEnum;
				if (objectTypeEnum != InternalObjectTypeE.Object)
				{
					if (objectTypeEnum != InternalObjectTypeE.Array)
					{
						throw new SerializationException(Environment.GetResourceString("Invalid ObjectTypeEnum {0}.", new object[]
						{
							objectProgress.objectTypeEnum.ToString()
						}));
					}
					this.prs.PRmemberTypeEnum = InternalMemberTypeE.Item;
				}
				else
				{
					this.prs.PRname = objectProgress.name;
					this.prs.PRmemberTypeEnum = InternalMemberTypeE.Field;
				}
			}
			this.objectReader.Parse(this.prs);
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x00084E94 File Offset: 0x00083094
		[SecurityCritical]
		private void ReadArray(BinaryHeaderEnum binaryHeaderEnum)
		{
			BinaryArray binaryArray = new BinaryArray(binaryHeaderEnum);
			binaryArray.Read(this);
			BinaryAssemblyInfo assemblyInfo;
			if (binaryArray.binaryTypeEnum == BinaryTypeEnum.ObjectUser)
			{
				if (binaryArray.assemId < 1)
				{
					throw new SerializationException(Environment.GetResourceString("No assembly ID for object type '{0}'.", new object[]
					{
						binaryArray.typeInformation
					}));
				}
				assemblyInfo = (BinaryAssemblyInfo)this.AssemIdToAssemblyTable[binaryArray.assemId];
			}
			else
			{
				assemblyInfo = this.SystemAssemblyInfo;
			}
			ObjectProgress op = this.GetOp();
			ParseRecord pr = op.pr;
			op.objectTypeEnum = InternalObjectTypeE.Array;
			op.binaryTypeEnum = binaryArray.binaryTypeEnum;
			op.typeInformation = binaryArray.typeInformation;
			ObjectProgress objectProgress = (ObjectProgress)this.stack.PeekPeek();
			if (objectProgress == null || binaryArray.objectId > 0)
			{
				op.name = "System.Array";
				pr.PRparseTypeEnum = InternalParseTypeE.Object;
				op.memberValueEnum = InternalMemberValueE.Empty;
			}
			else
			{
				pr.PRparseTypeEnum = InternalParseTypeE.Member;
				pr.PRmemberValueEnum = InternalMemberValueE.Nested;
				op.memberValueEnum = InternalMemberValueE.Nested;
				InternalObjectTypeE objectTypeEnum = objectProgress.objectTypeEnum;
				if (objectTypeEnum != InternalObjectTypeE.Object)
				{
					if (objectTypeEnum != InternalObjectTypeE.Array)
					{
						throw new SerializationException(Environment.GetResourceString("Invalid ObjectTypeEnum {0}.", new object[]
						{
							objectProgress.objectTypeEnum.ToString()
						}));
					}
					pr.PRmemberTypeEnum = InternalMemberTypeE.Item;
					op.memberTypeEnum = InternalMemberTypeE.Item;
				}
				else
				{
					pr.PRname = objectProgress.name;
					pr.PRmemberTypeEnum = InternalMemberTypeE.Field;
					op.memberTypeEnum = InternalMemberTypeE.Field;
					pr.PRkeyDt = objectProgress.name;
					pr.PRdtType = objectProgress.dtType;
				}
			}
			pr.PRobjectId = this.objectReader.GetId((long)binaryArray.objectId);
			if (pr.PRobjectId == this.topId)
			{
				pr.PRobjectPositionEnum = InternalObjectPositionE.Top;
			}
			else if (this.headerId > 0L && pr.PRobjectId == this.headerId)
			{
				pr.PRobjectPositionEnum = InternalObjectPositionE.Headers;
			}
			else
			{
				pr.PRobjectPositionEnum = InternalObjectPositionE.Child;
			}
			pr.PRobjectTypeEnum = InternalObjectTypeE.Array;
			BinaryConverter.TypeFromInfo(binaryArray.binaryTypeEnum, binaryArray.typeInformation, this.objectReader, assemblyInfo, out pr.PRarrayElementTypeCode, out pr.PRarrayElementTypeString, out pr.PRarrayElementType, out pr.PRisArrayVariant);
			pr.PRdtTypeCode = InternalPrimitiveTypeE.Invalid;
			pr.PRrank = binaryArray.rank;
			pr.PRlengthA = binaryArray.lengthA;
			pr.PRlowerBoundA = binaryArray.lowerBoundA;
			bool flag = false;
			switch (binaryArray.binaryArrayTypeEnum)
			{
			case BinaryArrayTypeEnum.Single:
			case BinaryArrayTypeEnum.SingleOffset:
				op.numItems = binaryArray.lengthA[0];
				pr.PRarrayTypeEnum = InternalArrayTypeE.Single;
				if (Converter.IsWriteAsByteArray(pr.PRarrayElementTypeCode) && binaryArray.lowerBoundA[0] == 0)
				{
					flag = true;
					this.ReadArrayAsBytes(pr);
				}
				break;
			case BinaryArrayTypeEnum.Jagged:
			case BinaryArrayTypeEnum.JaggedOffset:
				op.numItems = binaryArray.lengthA[0];
				pr.PRarrayTypeEnum = InternalArrayTypeE.Jagged;
				break;
			case BinaryArrayTypeEnum.Rectangular:
			case BinaryArrayTypeEnum.RectangularOffset:
			{
				int num = 1;
				for (int i = 0; i < binaryArray.rank; i++)
				{
					num *= binaryArray.lengthA[i];
				}
				op.numItems = num;
				pr.PRarrayTypeEnum = InternalArrayTypeE.Rectangular;
				break;
			}
			default:
				throw new SerializationException(Environment.GetResourceString("Invalid array type '{0}'.", new object[]
				{
					binaryArray.binaryArrayTypeEnum.ToString()
				}));
			}
			if (!flag)
			{
				this.stack.Push(op);
			}
			else
			{
				this.PutOp(op);
			}
			this.objectReader.Parse(pr);
			if (flag)
			{
				pr.PRparseTypeEnum = InternalParseTypeE.ObjectEnd;
				this.objectReader.Parse(pr);
			}
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x000851E0 File Offset: 0x000833E0
		[SecurityCritical]
		private void ReadArrayAsBytes(ParseRecord pr)
		{
			if (pr.PRarrayElementTypeCode == InternalPrimitiveTypeE.Byte)
			{
				pr.PRnewObj = this.ReadBytes(pr.PRlengthA[0]);
				return;
			}
			if (pr.PRarrayElementTypeCode == InternalPrimitiveTypeE.Char)
			{
				pr.PRnewObj = this.ReadChars(pr.PRlengthA[0]);
				return;
			}
			int num = Converter.TypeLength(pr.PRarrayElementTypeCode);
			pr.PRnewObj = Converter.CreatePrimitiveArray(pr.PRarrayElementTypeCode, pr.PRlengthA[0]);
			Array array = (Array)pr.PRnewObj;
			int i = 0;
			if (this.byteBuffer == null)
			{
				this.byteBuffer = new byte[4096];
			}
			while (i < array.Length)
			{
				int num2 = Math.Min(4096 / num, array.Length - i);
				int num3 = num2 * num;
				this.ReadBytes(this.byteBuffer, 0, num3);
				if (!BitConverter.IsLittleEndian)
				{
					for (int j = 0; j < num3; j += num)
					{
						for (int k = 0; k < num / 2; k++)
						{
							byte b = this.byteBuffer[j + k];
							this.byteBuffer[j + k] = this.byteBuffer[j + num - 1 - k];
							this.byteBuffer[j + num - 1 - k] = b;
						}
					}
				}
				Buffer.InternalBlockCopy(this.byteBuffer, 0, array, i * num, num3);
				i += num2;
			}
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x00085330 File Offset: 0x00083530
		[SecurityCritical]
		private void ReadMemberPrimitiveUnTyped()
		{
			ObjectProgress objectProgress = (ObjectProgress)this.stack.Peek();
			if (this.memberPrimitiveUnTyped == null)
			{
				this.memberPrimitiveUnTyped = new MemberPrimitiveUnTyped();
			}
			this.memberPrimitiveUnTyped.Set((InternalPrimitiveTypeE)this.expectedTypeInformation);
			this.memberPrimitiveUnTyped.Read(this);
			this.memberPrimitiveUnTyped.Dump();
			this.prs.Init();
			this.prs.PRvarValue = this.memberPrimitiveUnTyped.value;
			this.prs.PRdtTypeCode = (InternalPrimitiveTypeE)this.expectedTypeInformation;
			this.prs.PRdtType = Converter.ToType(this.prs.PRdtTypeCode);
			this.prs.PRparseTypeEnum = InternalParseTypeE.Member;
			this.prs.PRmemberValueEnum = InternalMemberValueE.InlineValue;
			if (objectProgress.objectTypeEnum == InternalObjectTypeE.Object)
			{
				this.prs.PRmemberTypeEnum = InternalMemberTypeE.Field;
				this.prs.PRname = objectProgress.name;
			}
			else
			{
				this.prs.PRmemberTypeEnum = InternalMemberTypeE.Item;
			}
			this.objectReader.Parse(this.prs);
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x00085440 File Offset: 0x00083640
		[SecurityCritical]
		private void ReadMemberReference()
		{
			if (this.memberReference == null)
			{
				this.memberReference = new MemberReference();
			}
			this.memberReference.Read(this);
			this.memberReference.Dump();
			ObjectProgress objectProgress = (ObjectProgress)this.stack.Peek();
			this.prs.Init();
			this.prs.PRidRef = this.objectReader.GetId((long)this.memberReference.idRef);
			this.prs.PRparseTypeEnum = InternalParseTypeE.Member;
			this.prs.PRmemberValueEnum = InternalMemberValueE.Reference;
			if (objectProgress.objectTypeEnum == InternalObjectTypeE.Object)
			{
				this.prs.PRmemberTypeEnum = InternalMemberTypeE.Field;
				this.prs.PRname = objectProgress.name;
				this.prs.PRdtType = objectProgress.dtType;
			}
			else
			{
				this.prs.PRmemberTypeEnum = InternalMemberTypeE.Item;
			}
			this.objectReader.Parse(this.prs);
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x00085524 File Offset: 0x00083724
		[SecurityCritical]
		private void ReadObjectNull(BinaryHeaderEnum binaryHeaderEnum)
		{
			if (this.objectNull == null)
			{
				this.objectNull = new ObjectNull();
			}
			this.objectNull.Read(this, binaryHeaderEnum);
			this.objectNull.Dump();
			ObjectProgress objectProgress = (ObjectProgress)this.stack.Peek();
			this.prs.Init();
			this.prs.PRparseTypeEnum = InternalParseTypeE.Member;
			this.prs.PRmemberValueEnum = InternalMemberValueE.Null;
			if (objectProgress.objectTypeEnum == InternalObjectTypeE.Object)
			{
				this.prs.PRmemberTypeEnum = InternalMemberTypeE.Field;
				this.prs.PRname = objectProgress.name;
				this.prs.PRdtType = objectProgress.dtType;
			}
			else
			{
				this.prs.PRmemberTypeEnum = InternalMemberTypeE.Item;
				this.prs.PRnullCount = this.objectNull.nullCount;
				objectProgress.ArrayCountIncrement(this.objectNull.nullCount - 1);
			}
			this.objectReader.Parse(this.prs);
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x00085610 File Offset: 0x00083810
		[SecurityCritical]
		private void ReadMessageEnd()
		{
			if (__BinaryParser.messageEnd == null)
			{
				__BinaryParser.messageEnd = new MessageEnd();
			}
			__BinaryParser.messageEnd.Read(this);
			__BinaryParser.messageEnd.Dump();
			if (!this.stack.IsEmpty())
			{
				throw new SerializationException(Environment.GetResourceString("End of Stream encountered before parsing was completed."));
			}
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x00085668 File Offset: 0x00083868
		internal object ReadValue(InternalPrimitiveTypeE code)
		{
			switch (code)
			{
			case InternalPrimitiveTypeE.Boolean:
				return this.ReadBoolean();
			case InternalPrimitiveTypeE.Byte:
				return this.ReadByte();
			case InternalPrimitiveTypeE.Char:
				return this.ReadChar();
			case InternalPrimitiveTypeE.Decimal:
				return this.ReadDecimal();
			case InternalPrimitiveTypeE.Double:
				return this.ReadDouble();
			case InternalPrimitiveTypeE.Int16:
				return this.ReadInt16();
			case InternalPrimitiveTypeE.Int32:
				return this.ReadInt32();
			case InternalPrimitiveTypeE.Int64:
				return this.ReadInt64();
			case InternalPrimitiveTypeE.SByte:
				return this.ReadSByte();
			case InternalPrimitiveTypeE.Single:
				return this.ReadSingle();
			case InternalPrimitiveTypeE.TimeSpan:
				return this.ReadTimeSpan();
			case InternalPrimitiveTypeE.DateTime:
				return this.ReadDateTime();
			case InternalPrimitiveTypeE.UInt16:
				return this.ReadUInt16();
			case InternalPrimitiveTypeE.UInt32:
				return this.ReadUInt32();
			case InternalPrimitiveTypeE.UInt64:
				return this.ReadUInt64();
			}
			throw new SerializationException(Environment.GetResourceString("Invalid type code in stream '{0}'.", new object[]
			{
				code.ToString()
			}));
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x000857D4 File Offset: 0x000839D4
		private ObjectProgress GetOp()
		{
			ObjectProgress objectProgress;
			if (this.opPool != null && !this.opPool.IsEmpty())
			{
				objectProgress = (ObjectProgress)this.opPool.Pop();
				objectProgress.Init();
			}
			else
			{
				objectProgress = new ObjectProgress();
			}
			return objectProgress;
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x00085818 File Offset: 0x00083A18
		private void PutOp(ObjectProgress op)
		{
			if (this.opPool == null)
			{
				this.opPool = new SerStack("opPool");
			}
			this.opPool.Push(op);
		}

		// Token: 0x04000DFD RID: 3581
		internal ObjectReader objectReader;

		// Token: 0x04000DFE RID: 3582
		internal Stream input;

		// Token: 0x04000DFF RID: 3583
		internal long topId;

		// Token: 0x04000E00 RID: 3584
		internal long headerId;

		// Token: 0x04000E01 RID: 3585
		internal SizedArray objectMapIdTable;

		// Token: 0x04000E02 RID: 3586
		internal SizedArray assemIdToAssemblyTable;

		// Token: 0x04000E03 RID: 3587
		internal SerStack stack = new SerStack("ObjectProgressStack");

		// Token: 0x04000E04 RID: 3588
		internal BinaryTypeEnum expectedType = BinaryTypeEnum.ObjectUrt;

		// Token: 0x04000E05 RID: 3589
		internal object expectedTypeInformation;

		// Token: 0x04000E06 RID: 3590
		internal ParseRecord PRS;

		// Token: 0x04000E07 RID: 3591
		private BinaryAssemblyInfo systemAssemblyInfo;

		// Token: 0x04000E08 RID: 3592
		private BinaryReader dataReader;

		// Token: 0x04000E09 RID: 3593
		private static Encoding encoding = new UTF8Encoding(false, true);

		// Token: 0x04000E0A RID: 3594
		private SerStack opPool;

		// Token: 0x04000E0B RID: 3595
		private BinaryObject binaryObject;

		// Token: 0x04000E0C RID: 3596
		private BinaryObjectWithMap bowm;

		// Token: 0x04000E0D RID: 3597
		private BinaryObjectWithMapTyped bowmt;

		// Token: 0x04000E0E RID: 3598
		internal BinaryObjectString objectString;

		// Token: 0x04000E0F RID: 3599
		internal BinaryCrossAppDomainString crossAppDomainString;

		// Token: 0x04000E10 RID: 3600
		internal MemberPrimitiveTyped memberPrimitiveTyped;

		// Token: 0x04000E11 RID: 3601
		private byte[] byteBuffer;

		// Token: 0x04000E12 RID: 3602
		internal MemberPrimitiveUnTyped memberPrimitiveUnTyped;

		// Token: 0x04000E13 RID: 3603
		internal MemberReference memberReference;

		// Token: 0x04000E14 RID: 3604
		internal ObjectNull objectNull;

		// Token: 0x04000E15 RID: 3605
		internal static volatile MessageEnd messageEnd;
	}
}
