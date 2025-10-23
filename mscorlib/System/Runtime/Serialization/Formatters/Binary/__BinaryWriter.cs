using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Security;
using System.Text;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003E0 RID: 992
	internal sealed class __BinaryWriter
	{
		// Token: 0x06001E09 RID: 7689 RVA: 0x0007F1F8 File Offset: 0x0007D3F8
		internal __BinaryWriter(Stream sout, ObjectWriter objectWriter, FormatterTypeStyle formatterTypeStyle)
		{
			this.sout = sout;
			this.formatterTypeStyle = formatterTypeStyle;
			this.objectWriter = objectWriter;
			this.m_nestedObjectCount = 0;
			this.dataWriter = new BinaryWriter(sout, Encoding.UTF8);
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x00002A7D File Offset: 0x00000C7D
		internal void WriteBegin()
		{
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x0007F238 File Offset: 0x0007D438
		internal void WriteEnd()
		{
			this.dataWriter.Flush();
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x0007F245 File Offset: 0x0007D445
		internal void WriteBoolean(bool value)
		{
			this.dataWriter.Write(value);
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x0007F253 File Offset: 0x0007D453
		internal void WriteByte(byte value)
		{
			this.dataWriter.Write(value);
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x0007F261 File Offset: 0x0007D461
		private void WriteBytes(byte[] value)
		{
			this.dataWriter.Write(value);
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x0007F26F File Offset: 0x0007D46F
		private void WriteBytes(byte[] byteA, int offset, int size)
		{
			this.dataWriter.Write(byteA, offset, size);
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x0007F27F File Offset: 0x0007D47F
		internal void WriteChar(char value)
		{
			this.dataWriter.Write(value);
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x0007F28D File Offset: 0x0007D48D
		internal void WriteChars(char[] value)
		{
			this.dataWriter.Write(value);
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x0007F29B File Offset: 0x0007D49B
		internal void WriteDecimal(decimal value)
		{
			this.WriteString(value.ToString(CultureInfo.InvariantCulture));
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x0007F2AF File Offset: 0x0007D4AF
		internal void WriteSingle(float value)
		{
			this.dataWriter.Write(value);
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x0007F2BD File Offset: 0x0007D4BD
		internal void WriteDouble(double value)
		{
			this.dataWriter.Write(value);
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x0007F2CB File Offset: 0x0007D4CB
		internal void WriteInt16(short value)
		{
			this.dataWriter.Write(value);
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x0007F2D9 File Offset: 0x0007D4D9
		internal void WriteInt32(int value)
		{
			this.dataWriter.Write(value);
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x0007F2E7 File Offset: 0x0007D4E7
		internal void WriteInt64(long value)
		{
			this.dataWriter.Write(value);
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x0007F2F5 File Offset: 0x0007D4F5
		internal void WriteSByte(sbyte value)
		{
			this.WriteByte((byte)value);
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x0007F2FF File Offset: 0x0007D4FF
		internal void WriteString(string value)
		{
			this.dataWriter.Write(value);
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x0007F30D File Offset: 0x0007D50D
		internal void WriteTimeSpan(TimeSpan value)
		{
			this.WriteInt64(value.Ticks);
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x0007F31C File Offset: 0x0007D51C
		internal void WriteDateTime(DateTime value)
		{
			this.WriteInt64(value.ToBinaryRaw());
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x0007F32B File Offset: 0x0007D52B
		internal void WriteUInt16(ushort value)
		{
			this.dataWriter.Write(value);
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x0007F339 File Offset: 0x0007D539
		internal void WriteUInt32(uint value)
		{
			this.dataWriter.Write(value);
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x0007F347 File Offset: 0x0007D547
		internal void WriteUInt64(ulong value)
		{
			this.dataWriter.Write(value);
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x00002A7D File Offset: 0x00000C7D
		internal void WriteObjectEnd(NameInfo memberNameInfo, NameInfo typeNameInfo)
		{
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x0007F355 File Offset: 0x0007D555
		internal void WriteSerializationHeaderEnd()
		{
			MessageEnd messageEnd = new MessageEnd();
			messageEnd.Dump(this.sout);
			messageEnd.Write(this);
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x0007F36E File Offset: 0x0007D56E
		internal void WriteSerializationHeader(int topId, int headerId, int minorVersion, int majorVersion)
		{
			SerializationHeaderRecord serializationHeaderRecord = new SerializationHeaderRecord(BinaryHeaderEnum.SerializedStreamHeader, topId, headerId, minorVersion, majorVersion);
			serializationHeaderRecord.Dump();
			serializationHeaderRecord.Write(this);
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x0007F387 File Offset: 0x0007D587
		internal void WriteMethodCall()
		{
			if (this.binaryMethodCall == null)
			{
				this.binaryMethodCall = new BinaryMethodCall();
			}
			this.binaryMethodCall.Dump();
			this.binaryMethodCall.Write(this);
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x0007F3B4 File Offset: 0x0007D5B4
		internal object[] WriteCallArray(string uri, string methodName, string typeName, Type[] instArgs, object[] args, object methodSignature, object callContext, object[] properties)
		{
			if (this.binaryMethodCall == null)
			{
				this.binaryMethodCall = new BinaryMethodCall();
			}
			return this.binaryMethodCall.WriteArray(uri, methodName, typeName, instArgs, args, methodSignature, callContext, properties);
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x0007F3EC File Offset: 0x0007D5EC
		internal void WriteMethodReturn()
		{
			if (this.binaryMethodReturn == null)
			{
				this.binaryMethodReturn = new BinaryMethodReturn();
			}
			this.binaryMethodReturn.Dump();
			this.binaryMethodReturn.Write(this);
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x0007F418 File Offset: 0x0007D618
		internal object[] WriteReturnArray(object returnValue, object[] args, Exception exception, object callContext, object[] properties)
		{
			if (this.binaryMethodReturn == null)
			{
				this.binaryMethodReturn = new BinaryMethodReturn();
			}
			return this.binaryMethodReturn.WriteArray(returnValue, args, exception, callContext, properties);
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x0007F440 File Offset: 0x0007D640
		internal void WriteObject(NameInfo nameInfo, NameInfo typeNameInfo, int numMembers, string[] memberNames, Type[] memberTypes, WriteObjectInfo[] memberObjectInfos)
		{
			this.InternalWriteItemNull();
			int num = (int)nameInfo.NIobjectId;
			string niname;
			if (num < 0)
			{
				niname = typeNameInfo.NIname;
			}
			else
			{
				niname = nameInfo.NIname;
			}
			if (this.objectMapTable == null)
			{
				this.objectMapTable = new Hashtable();
			}
			ObjectMapInfo objectMapInfo = (ObjectMapInfo)this.objectMapTable[niname];
			if (objectMapInfo != null && objectMapInfo.isCompatible(numMembers, memberNames, memberTypes))
			{
				if (this.binaryObject == null)
				{
					this.binaryObject = new BinaryObject();
				}
				this.binaryObject.Set(num, objectMapInfo.objectId);
				this.binaryObject.Write(this);
				return;
			}
			if (!typeNameInfo.NItransmitTypeOnObject)
			{
				if (this.binaryObjectWithMap == null)
				{
					this.binaryObjectWithMap = new BinaryObjectWithMap();
				}
				int num2 = (int)typeNameInfo.NIassemId;
				this.binaryObjectWithMap.Set(num, niname, numMembers, memberNames, num2);
				this.binaryObjectWithMap.Dump();
				this.binaryObjectWithMap.Write(this);
				if (objectMapInfo == null)
				{
					this.objectMapTable.Add(niname, new ObjectMapInfo(num, numMembers, memberNames, memberTypes));
					return;
				}
			}
			else
			{
				BinaryTypeEnum[] array = new BinaryTypeEnum[numMembers];
				object[] array2 = new object[numMembers];
				int[] array3 = new int[numMembers];
				int num2;
				for (int i = 0; i < numMembers; i++)
				{
					object obj = null;
					array[i] = BinaryConverter.GetBinaryTypeInfo(memberTypes[i], memberObjectInfos[i], null, this.objectWriter, out obj, out num2);
					array2[i] = obj;
					array3[i] = num2;
				}
				if (this.binaryObjectWithMapTyped == null)
				{
					this.binaryObjectWithMapTyped = new BinaryObjectWithMapTyped();
				}
				num2 = (int)typeNameInfo.NIassemId;
				this.binaryObjectWithMapTyped.Set(num, niname, numMembers, memberNames, array, array2, array3, num2);
				this.binaryObjectWithMapTyped.Write(this);
				if (objectMapInfo == null)
				{
					this.objectMapTable.Add(niname, new ObjectMapInfo(num, numMembers, memberNames, memberTypes));
				}
			}
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x0007F5F4 File Offset: 0x0007D7F4
		internal void WriteObjectString(int objectId, string value)
		{
			this.InternalWriteItemNull();
			if (this.binaryObjectString == null)
			{
				this.binaryObjectString = new BinaryObjectString();
			}
			this.binaryObjectString.Set(objectId, value);
			this.binaryObjectString.Write(this);
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x0007F628 File Offset: 0x0007D828
		[SecurityCritical]
		internal void WriteSingleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Array array)
		{
			this.InternalWriteItemNull();
			int[] lengthA = new int[]
			{
				length
			};
			int[] lowerBoundA = null;
			object typeInformation = null;
			BinaryArrayTypeEnum binaryArrayTypeEnum;
			if (lowerBound == 0)
			{
				binaryArrayTypeEnum = BinaryArrayTypeEnum.Single;
			}
			else
			{
				binaryArrayTypeEnum = BinaryArrayTypeEnum.SingleOffset;
				lowerBoundA = new int[]
				{
					lowerBound
				};
			}
			int assemId;
			BinaryTypeEnum binaryTypeInfo = BinaryConverter.GetBinaryTypeInfo(arrayElemTypeNameInfo.NItype, objectInfo, arrayElemTypeNameInfo.NIname, this.objectWriter, out typeInformation, out assemId);
			if (this.binaryArray == null)
			{
				this.binaryArray = new BinaryArray();
			}
			this.binaryArray.Set((int)arrayNameInfo.NIobjectId, 1, lengthA, lowerBoundA, binaryTypeInfo, typeInformation, binaryArrayTypeEnum, assemId);
			long niobjectId = arrayNameInfo.NIobjectId;
			this.binaryArray.Write(this);
			if (Converter.IsWriteAsByteArray(arrayElemTypeNameInfo.NIprimitiveTypeEnum) && lowerBound == 0)
			{
				if (arrayElemTypeNameInfo.NIprimitiveTypeEnum == InternalPrimitiveTypeE.Byte)
				{
					this.WriteBytes((byte[])array);
					return;
				}
				if (arrayElemTypeNameInfo.NIprimitiveTypeEnum == InternalPrimitiveTypeE.Char)
				{
					this.WriteChars((char[])array);
					return;
				}
				this.WriteArrayAsBytes(array, Converter.TypeLength(arrayElemTypeNameInfo.NIprimitiveTypeEnum));
			}
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x0007F71C File Offset: 0x0007D91C
		[SecurityCritical]
		private void WriteArrayAsBytes(Array array, int typeLength)
		{
			this.InternalWriteItemNull();
			int i = 0;
			if (this.byteBuffer == null)
			{
				this.byteBuffer = new byte[this.chunkSize];
			}
			while (i < array.Length)
			{
				int num = Math.Min(this.chunkSize / typeLength, array.Length - i);
				int num2 = num * typeLength;
				Buffer.InternalBlockCopy(array, i * typeLength, this.byteBuffer, 0, num2);
				if (!BitConverter.IsLittleEndian)
				{
					for (int j = 0; j < num2; j += typeLength)
					{
						for (int k = 0; k < typeLength / 2; k++)
						{
							byte b = this.byteBuffer[j + k];
							this.byteBuffer[j + k] = this.byteBuffer[j + typeLength - 1 - k];
							this.byteBuffer[j + typeLength - 1 - k] = b;
						}
					}
				}
				this.WriteBytes(this.byteBuffer, 0, num2);
				i += num;
			}
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x0007F7FC File Offset: 0x0007D9FC
		internal void WriteJaggedArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound)
		{
			this.InternalWriteItemNull();
			int[] lengthA = new int[]
			{
				length
			};
			int[] lowerBoundA = null;
			object typeInformation = null;
			int assemId = 0;
			BinaryArrayTypeEnum binaryArrayTypeEnum;
			if (lowerBound == 0)
			{
				binaryArrayTypeEnum = BinaryArrayTypeEnum.Jagged;
			}
			else
			{
				binaryArrayTypeEnum = BinaryArrayTypeEnum.JaggedOffset;
				lowerBoundA = new int[]
				{
					lowerBound
				};
			}
			BinaryTypeEnum binaryTypeInfo = BinaryConverter.GetBinaryTypeInfo(arrayElemTypeNameInfo.NItype, objectInfo, arrayElemTypeNameInfo.NIname, this.objectWriter, out typeInformation, out assemId);
			if (this.binaryArray == null)
			{
				this.binaryArray = new BinaryArray();
			}
			this.binaryArray.Set((int)arrayNameInfo.NIobjectId, 1, lengthA, lowerBoundA, binaryTypeInfo, typeInformation, binaryArrayTypeEnum, assemId);
			long niobjectId = arrayNameInfo.NIobjectId;
			this.binaryArray.Write(this);
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x0007F89C File Offset: 0x0007DA9C
		internal void WriteRectangleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int rank, int[] lengthA, int[] lowerBoundA)
		{
			this.InternalWriteItemNull();
			BinaryArrayTypeEnum binaryArrayTypeEnum = BinaryArrayTypeEnum.Rectangular;
			object typeInformation = null;
			int assemId = 0;
			BinaryTypeEnum binaryTypeInfo = BinaryConverter.GetBinaryTypeInfo(arrayElemTypeNameInfo.NItype, objectInfo, arrayElemTypeNameInfo.NIname, this.objectWriter, out typeInformation, out assemId);
			if (this.binaryArray == null)
			{
				this.binaryArray = new BinaryArray();
			}
			for (int i = 0; i < rank; i++)
			{
				if (lowerBoundA[i] != 0)
				{
					binaryArrayTypeEnum = BinaryArrayTypeEnum.RectangularOffset;
					break;
				}
			}
			this.binaryArray.Set((int)arrayNameInfo.NIobjectId, rank, lengthA, lowerBoundA, binaryTypeInfo, typeInformation, binaryArrayTypeEnum, assemId);
			long niobjectId = arrayNameInfo.NIobjectId;
			this.binaryArray.Write(this);
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x0007F935 File Offset: 0x0007DB35
		[SecurityCritical]
		internal void WriteObjectByteArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, byte[] byteA)
		{
			this.InternalWriteItemNull();
			this.WriteSingleArray(memberNameInfo, arrayNameInfo, objectInfo, arrayElemTypeNameInfo, length, lowerBound, byteA);
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x0007F950 File Offset: 0x0007DB50
		internal void WriteMember(NameInfo memberNameInfo, NameInfo typeNameInfo, object value)
		{
			this.InternalWriteItemNull();
			InternalPrimitiveTypeE niprimitiveTypeEnum = typeNameInfo.NIprimitiveTypeEnum;
			if (memberNameInfo.NItransmitTypeOnMember)
			{
				if (this.memberPrimitiveTyped == null)
				{
					this.memberPrimitiveTyped = new MemberPrimitiveTyped();
				}
				this.memberPrimitiveTyped.Set(niprimitiveTypeEnum, value);
				bool niisArrayItem = memberNameInfo.NIisArrayItem;
				this.memberPrimitiveTyped.Dump();
				this.memberPrimitiveTyped.Write(this);
				return;
			}
			if (this.memberPrimitiveUnTyped == null)
			{
				this.memberPrimitiveUnTyped = new MemberPrimitiveUnTyped();
			}
			this.memberPrimitiveUnTyped.Set(niprimitiveTypeEnum, value);
			bool niisArrayItem2 = memberNameInfo.NIisArrayItem;
			this.memberPrimitiveUnTyped.Dump();
			this.memberPrimitiveUnTyped.Write(this);
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x0007F9F0 File Offset: 0x0007DBF0
		internal void WriteNullMember(NameInfo memberNameInfo, NameInfo typeNameInfo)
		{
			this.InternalWriteItemNull();
			if (this.objectNull == null)
			{
				this.objectNull = new ObjectNull();
			}
			if (!memberNameInfo.NIisArrayItem)
			{
				this.objectNull.SetNullCount(1);
				this.objectNull.Dump();
				this.objectNull.Write(this);
				this.nullCount = 0;
			}
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x0007FA48 File Offset: 0x0007DC48
		internal void WriteMemberObjectRef(NameInfo memberNameInfo, int idRef)
		{
			this.InternalWriteItemNull();
			if (this.memberReference == null)
			{
				this.memberReference = new MemberReference();
			}
			this.memberReference.Set(idRef);
			bool niisArrayItem = memberNameInfo.NIisArrayItem;
			this.memberReference.Dump();
			this.memberReference.Write(this);
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x0007FA98 File Offset: 0x0007DC98
		internal void WriteMemberNested(NameInfo memberNameInfo)
		{
			this.InternalWriteItemNull();
			bool niisArrayItem = memberNameInfo.NIisArrayItem;
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x0007FAA7 File Offset: 0x0007DCA7
		internal void WriteMemberString(NameInfo memberNameInfo, NameInfo typeNameInfo, string value)
		{
			this.InternalWriteItemNull();
			bool niisArrayItem = memberNameInfo.NIisArrayItem;
			this.WriteObjectString((int)typeNameInfo.NIobjectId, value);
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x0007FAC4 File Offset: 0x0007DCC4
		internal void WriteItem(NameInfo itemNameInfo, NameInfo typeNameInfo, object value)
		{
			this.InternalWriteItemNull();
			this.WriteMember(itemNameInfo, typeNameInfo, value);
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x0007FAD5 File Offset: 0x0007DCD5
		internal void WriteNullItem(NameInfo itemNameInfo, NameInfo typeNameInfo)
		{
			this.nullCount++;
			this.InternalWriteItemNull();
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x0007FAEB File Offset: 0x0007DCEB
		internal void WriteDelayedNullItem()
		{
			this.nullCount++;
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x0007FAFB File Offset: 0x0007DCFB
		internal void WriteItemEnd()
		{
			this.InternalWriteItemNull();
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x0007FB04 File Offset: 0x0007DD04
		private void InternalWriteItemNull()
		{
			if (this.nullCount > 0)
			{
				if (this.objectNull == null)
				{
					this.objectNull = new ObjectNull();
				}
				this.objectNull.SetNullCount(this.nullCount);
				this.objectNull.Dump();
				this.objectNull.Write(this);
				this.nullCount = 0;
			}
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x0007FB5C File Offset: 0x0007DD5C
		internal void WriteItemObjectRef(NameInfo nameInfo, int idRef)
		{
			this.InternalWriteItemNull();
			this.WriteMemberObjectRef(nameInfo, idRef);
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x0007FB6C File Offset: 0x0007DD6C
		internal void WriteAssembly(Type type, string assemblyString, int assemId, bool isNew)
		{
			this.InternalWriteItemNull();
			if (assemblyString == null)
			{
				assemblyString = string.Empty;
			}
			if (isNew)
			{
				if (this.binaryAssembly == null)
				{
					this.binaryAssembly = new BinaryAssembly();
				}
				this.binaryAssembly.Set(assemId, assemblyString);
				this.binaryAssembly.Dump();
				this.binaryAssembly.Write(this);
			}
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x0007FBC4 File Offset: 0x0007DDC4
		internal void WriteValue(InternalPrimitiveTypeE code, object value)
		{
			switch (code)
			{
			case InternalPrimitiveTypeE.Boolean:
				this.WriteBoolean(Convert.ToBoolean(value, CultureInfo.InvariantCulture));
				return;
			case InternalPrimitiveTypeE.Byte:
				this.WriteByte(Convert.ToByte(value, CultureInfo.InvariantCulture));
				return;
			case InternalPrimitiveTypeE.Char:
				this.WriteChar(Convert.ToChar(value, CultureInfo.InvariantCulture));
				return;
			case InternalPrimitiveTypeE.Decimal:
				this.WriteDecimal(Convert.ToDecimal(value, CultureInfo.InvariantCulture));
				return;
			case InternalPrimitiveTypeE.Double:
				this.WriteDouble(Convert.ToDouble(value, CultureInfo.InvariantCulture));
				return;
			case InternalPrimitiveTypeE.Int16:
				this.WriteInt16(Convert.ToInt16(value, CultureInfo.InvariantCulture));
				return;
			case InternalPrimitiveTypeE.Int32:
				this.WriteInt32(Convert.ToInt32(value, CultureInfo.InvariantCulture));
				return;
			case InternalPrimitiveTypeE.Int64:
				this.WriteInt64(Convert.ToInt64(value, CultureInfo.InvariantCulture));
				return;
			case InternalPrimitiveTypeE.SByte:
				this.WriteSByte(Convert.ToSByte(value, CultureInfo.InvariantCulture));
				return;
			case InternalPrimitiveTypeE.Single:
				this.WriteSingle(Convert.ToSingle(value, CultureInfo.InvariantCulture));
				return;
			case InternalPrimitiveTypeE.TimeSpan:
				this.WriteTimeSpan((TimeSpan)value);
				return;
			case InternalPrimitiveTypeE.DateTime:
				this.WriteDateTime((DateTime)value);
				return;
			case InternalPrimitiveTypeE.UInt16:
				this.WriteUInt16(Convert.ToUInt16(value, CultureInfo.InvariantCulture));
				return;
			case InternalPrimitiveTypeE.UInt32:
				this.WriteUInt32(Convert.ToUInt32(value, CultureInfo.InvariantCulture));
				return;
			case InternalPrimitiveTypeE.UInt64:
				this.WriteUInt64(Convert.ToUInt64(value, CultureInfo.InvariantCulture));
				return;
			}
			throw new SerializationException(Environment.GetResourceString("Invalid type code in stream '{0}'.", new object[]
			{
				code.ToString()
			}));
		}

		// Token: 0x04000D72 RID: 3442
		internal Stream sout;

		// Token: 0x04000D73 RID: 3443
		internal FormatterTypeStyle formatterTypeStyle;

		// Token: 0x04000D74 RID: 3444
		internal Hashtable objectMapTable;

		// Token: 0x04000D75 RID: 3445
		internal ObjectWriter objectWriter;

		// Token: 0x04000D76 RID: 3446
		internal BinaryWriter dataWriter;

		// Token: 0x04000D77 RID: 3447
		internal int m_nestedObjectCount;

		// Token: 0x04000D78 RID: 3448
		private int nullCount;

		// Token: 0x04000D79 RID: 3449
		internal BinaryMethodCall binaryMethodCall;

		// Token: 0x04000D7A RID: 3450
		internal BinaryMethodReturn binaryMethodReturn;

		// Token: 0x04000D7B RID: 3451
		internal BinaryObject binaryObject;

		// Token: 0x04000D7C RID: 3452
		internal BinaryObjectWithMap binaryObjectWithMap;

		// Token: 0x04000D7D RID: 3453
		internal BinaryObjectWithMapTyped binaryObjectWithMapTyped;

		// Token: 0x04000D7E RID: 3454
		internal BinaryObjectString binaryObjectString;

		// Token: 0x04000D7F RID: 3455
		internal BinaryArray binaryArray;

		// Token: 0x04000D80 RID: 3456
		private byte[] byteBuffer;

		// Token: 0x04000D81 RID: 3457
		private int chunkSize = 4096;

		// Token: 0x04000D82 RID: 3458
		internal MemberPrimitiveUnTyped memberPrimitiveUnTyped;

		// Token: 0x04000D83 RID: 3459
		internal MemberPrimitiveTyped memberPrimitiveTyped;

		// Token: 0x04000D84 RID: 3460
		internal ObjectNull objectNull;

		// Token: 0x04000D85 RID: 3461
		internal MemberReference memberReference;

		// Token: 0x04000D86 RID: 3462
		internal BinaryAssembly binaryAssembly;
	}
}
