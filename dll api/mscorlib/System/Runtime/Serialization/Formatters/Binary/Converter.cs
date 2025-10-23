using System;
using System.Globalization;
using System.Reflection;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003DE RID: 990
	internal sealed class Converter
	{
		// Token: 0x06001DE9 RID: 7657 RVA: 0x0007E660 File Offset: 0x0007C860
		internal static InternalPrimitiveTypeE ToCode(Type type)
		{
			InternalPrimitiveTypeE result;
			if (type != null && !type.IsPrimitive)
			{
				if (type == Converter.typeofDateTime)
				{
					result = InternalPrimitiveTypeE.DateTime;
				}
				else if (type == Converter.typeofTimeSpan)
				{
					result = InternalPrimitiveTypeE.TimeSpan;
				}
				else if (type == Converter.typeofDecimal)
				{
					result = InternalPrimitiveTypeE.Decimal;
				}
				else
				{
					result = InternalPrimitiveTypeE.Invalid;
				}
			}
			else
			{
				result = Converter.ToPrimitiveTypeEnum(Type.GetTypeCode(type));
			}
			return result;
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x0007E6B0 File Offset: 0x0007C8B0
		internal static bool IsWriteAsByteArray(InternalPrimitiveTypeE code)
		{
			bool result = false;
			switch (code)
			{
			case InternalPrimitiveTypeE.Boolean:
			case InternalPrimitiveTypeE.Byte:
			case InternalPrimitiveTypeE.Char:
			case InternalPrimitiveTypeE.Double:
			case InternalPrimitiveTypeE.Int16:
			case InternalPrimitiveTypeE.Int32:
			case InternalPrimitiveTypeE.Int64:
			case InternalPrimitiveTypeE.SByte:
			case InternalPrimitiveTypeE.Single:
			case InternalPrimitiveTypeE.UInt16:
			case InternalPrimitiveTypeE.UInt32:
			case InternalPrimitiveTypeE.UInt64:
				result = true;
				break;
			}
			return result;
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x0007E70C File Offset: 0x0007C90C
		internal static int TypeLength(InternalPrimitiveTypeE code)
		{
			int result = 0;
			switch (code)
			{
			case InternalPrimitiveTypeE.Boolean:
				result = 1;
				break;
			case InternalPrimitiveTypeE.Byte:
				result = 1;
				break;
			case InternalPrimitiveTypeE.Char:
				result = 2;
				break;
			case InternalPrimitiveTypeE.Double:
				result = 8;
				break;
			case InternalPrimitiveTypeE.Int16:
				result = 2;
				break;
			case InternalPrimitiveTypeE.Int32:
				result = 4;
				break;
			case InternalPrimitiveTypeE.Int64:
				result = 8;
				break;
			case InternalPrimitiveTypeE.SByte:
				result = 1;
				break;
			case InternalPrimitiveTypeE.Single:
				result = 4;
				break;
			case InternalPrimitiveTypeE.UInt16:
				result = 2;
				break;
			case InternalPrimitiveTypeE.UInt32:
				result = 4;
				break;
			case InternalPrimitiveTypeE.UInt64:
				result = 8;
				break;
			}
			return result;
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x0007E794 File Offset: 0x0007C994
		internal static Type ToArrayType(InternalPrimitiveTypeE code)
		{
			if (Converter.arrayTypeA == null)
			{
				Converter.InitArrayTypeA();
			}
			return Converter.arrayTypeA[(int)code];
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x0007E7B0 File Offset: 0x0007C9B0
		private static void InitTypeA()
		{
			Type[] array = new Type[Converter.primitiveTypeEnumLength];
			array[0] = null;
			array[1] = Converter.typeofBoolean;
			array[2] = Converter.typeofByte;
			array[3] = Converter.typeofChar;
			array[5] = Converter.typeofDecimal;
			array[6] = Converter.typeofDouble;
			array[7] = Converter.typeofInt16;
			array[8] = Converter.typeofInt32;
			array[9] = Converter.typeofInt64;
			array[10] = Converter.typeofSByte;
			array[11] = Converter.typeofSingle;
			array[12] = Converter.typeofTimeSpan;
			array[13] = Converter.typeofDateTime;
			array[14] = Converter.typeofUInt16;
			array[15] = Converter.typeofUInt32;
			array[16] = Converter.typeofUInt64;
			Converter.typeA = array;
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x0007E854 File Offset: 0x0007CA54
		private static void InitArrayTypeA()
		{
			Type[] array = new Type[Converter.primitiveTypeEnumLength];
			array[0] = null;
			array[1] = Converter.typeofBooleanArray;
			array[2] = Converter.typeofByteArray;
			array[3] = Converter.typeofCharArray;
			array[5] = Converter.typeofDecimalArray;
			array[6] = Converter.typeofDoubleArray;
			array[7] = Converter.typeofInt16Array;
			array[8] = Converter.typeofInt32Array;
			array[9] = Converter.typeofInt64Array;
			array[10] = Converter.typeofSByteArray;
			array[11] = Converter.typeofSingleArray;
			array[12] = Converter.typeofTimeSpanArray;
			array[13] = Converter.typeofDateTimeArray;
			array[14] = Converter.typeofUInt16Array;
			array[15] = Converter.typeofUInt32Array;
			array[16] = Converter.typeofUInt64Array;
			Converter.arrayTypeA = array;
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x0007E8F6 File Offset: 0x0007CAF6
		internal static Type ToType(InternalPrimitiveTypeE code)
		{
			if (Converter.typeA == null)
			{
				Converter.InitTypeA();
			}
			return Converter.typeA[(int)code];
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x0007E910 File Offset: 0x0007CB10
		internal static Array CreatePrimitiveArray(InternalPrimitiveTypeE code, int length)
		{
			Array result = null;
			switch (code)
			{
			case InternalPrimitiveTypeE.Boolean:
				result = new bool[length];
				break;
			case InternalPrimitiveTypeE.Byte:
				result = new byte[length];
				break;
			case InternalPrimitiveTypeE.Char:
				result = new char[length];
				break;
			case InternalPrimitiveTypeE.Decimal:
				result = new decimal[length];
				break;
			case InternalPrimitiveTypeE.Double:
				result = new double[length];
				break;
			case InternalPrimitiveTypeE.Int16:
				result = new short[length];
				break;
			case InternalPrimitiveTypeE.Int32:
				result = new int[length];
				break;
			case InternalPrimitiveTypeE.Int64:
				result = new long[length];
				break;
			case InternalPrimitiveTypeE.SByte:
				result = new sbyte[length];
				break;
			case InternalPrimitiveTypeE.Single:
				result = new float[length];
				break;
			case InternalPrimitiveTypeE.TimeSpan:
				result = new TimeSpan[length];
				break;
			case InternalPrimitiveTypeE.DateTime:
				result = new DateTime[length];
				break;
			case InternalPrimitiveTypeE.UInt16:
				result = new ushort[length];
				break;
			case InternalPrimitiveTypeE.UInt32:
				result = new uint[length];
				break;
			case InternalPrimitiveTypeE.UInt64:
				result = new ulong[length];
				break;
			}
			return result;
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x0007E9F4 File Offset: 0x0007CBF4
		internal static bool IsPrimitiveArray(Type type, out object typeInformation)
		{
			typeInformation = null;
			bool result = true;
			if (type == Converter.typeofBooleanArray)
			{
				typeInformation = InternalPrimitiveTypeE.Boolean;
			}
			else if (type == Converter.typeofByteArray)
			{
				typeInformation = InternalPrimitiveTypeE.Byte;
			}
			else if (type == Converter.typeofCharArray)
			{
				typeInformation = InternalPrimitiveTypeE.Char;
			}
			else if (type == Converter.typeofDoubleArray)
			{
				typeInformation = InternalPrimitiveTypeE.Double;
			}
			else if (type == Converter.typeofInt16Array)
			{
				typeInformation = InternalPrimitiveTypeE.Int16;
			}
			else if (type == Converter.typeofInt32Array)
			{
				typeInformation = InternalPrimitiveTypeE.Int32;
			}
			else if (type == Converter.typeofInt64Array)
			{
				typeInformation = InternalPrimitiveTypeE.Int64;
			}
			else if (type == Converter.typeofSByteArray)
			{
				typeInformation = InternalPrimitiveTypeE.SByte;
			}
			else if (type == Converter.typeofSingleArray)
			{
				typeInformation = InternalPrimitiveTypeE.Single;
			}
			else if (type == Converter.typeofUInt16Array)
			{
				typeInformation = InternalPrimitiveTypeE.UInt16;
			}
			else if (type == Converter.typeofUInt32Array)
			{
				typeInformation = InternalPrimitiveTypeE.UInt32;
			}
			else if (type == Converter.typeofUInt64Array)
			{
				typeInformation = InternalPrimitiveTypeE.UInt64;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x0007EAF8 File Offset: 0x0007CCF8
		private static void InitValueA()
		{
			string[] array = new string[Converter.primitiveTypeEnumLength];
			array[0] = null;
			array[1] = "Boolean";
			array[2] = "Byte";
			array[3] = "Char";
			array[5] = "Decimal";
			array[6] = "Double";
			array[7] = "Int16";
			array[8] = "Int32";
			array[9] = "Int64";
			array[10] = "SByte";
			array[11] = "Single";
			array[12] = "TimeSpan";
			array[13] = "DateTime";
			array[14] = "UInt16";
			array[15] = "UInt32";
			array[16] = "UInt64";
			Converter.valueA = array;
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x0007EB9A File Offset: 0x0007CD9A
		internal static string ToComType(InternalPrimitiveTypeE code)
		{
			if (Converter.valueA == null)
			{
				Converter.InitValueA();
			}
			return Converter.valueA[(int)code];
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x0007EBB4 File Offset: 0x0007CDB4
		private static void InitTypeCodeA()
		{
			TypeCode[] array = new TypeCode[Converter.primitiveTypeEnumLength];
			array[0] = TypeCode.Object;
			array[1] = TypeCode.Boolean;
			array[2] = TypeCode.Byte;
			array[3] = TypeCode.Char;
			array[5] = TypeCode.Decimal;
			array[6] = TypeCode.Double;
			array[7] = TypeCode.Int16;
			array[8] = TypeCode.Int32;
			array[9] = TypeCode.Int64;
			array[10] = TypeCode.SByte;
			array[11] = TypeCode.Single;
			array[12] = TypeCode.Object;
			array[13] = TypeCode.DateTime;
			array[14] = TypeCode.UInt16;
			array[15] = TypeCode.UInt32;
			array[16] = TypeCode.UInt64;
			Converter.typeCodeA = array;
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x0007EC22 File Offset: 0x0007CE22
		internal static TypeCode ToTypeCode(InternalPrimitiveTypeE code)
		{
			if (Converter.typeCodeA == null)
			{
				Converter.InitTypeCodeA();
			}
			return Converter.typeCodeA[(int)code];
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x0007EC3C File Offset: 0x0007CE3C
		private static void InitCodeA()
		{
			Converter.codeA = new InternalPrimitiveTypeE[]
			{
				InternalPrimitiveTypeE.Invalid,
				InternalPrimitiveTypeE.Invalid,
				InternalPrimitiveTypeE.Invalid,
				InternalPrimitiveTypeE.Boolean,
				InternalPrimitiveTypeE.Char,
				InternalPrimitiveTypeE.SByte,
				InternalPrimitiveTypeE.Byte,
				InternalPrimitiveTypeE.Int16,
				InternalPrimitiveTypeE.UInt16,
				InternalPrimitiveTypeE.Int32,
				InternalPrimitiveTypeE.UInt32,
				InternalPrimitiveTypeE.Int64,
				InternalPrimitiveTypeE.UInt64,
				InternalPrimitiveTypeE.Single,
				InternalPrimitiveTypeE.Double,
				InternalPrimitiveTypeE.Decimal,
				InternalPrimitiveTypeE.DateTime,
				InternalPrimitiveTypeE.Invalid,
				InternalPrimitiveTypeE.Invalid
			};
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x0007ECB4 File Offset: 0x0007CEB4
		internal static InternalPrimitiveTypeE ToPrimitiveTypeEnum(TypeCode typeCode)
		{
			if (Converter.codeA == null)
			{
				Converter.InitCodeA();
			}
			return Converter.codeA[(int)typeCode];
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x0007ECD0 File Offset: 0x0007CED0
		internal static object FromString(string value, InternalPrimitiveTypeE code)
		{
			object result;
			if (code != InternalPrimitiveTypeE.Invalid)
			{
				result = Convert.ChangeType(value, Converter.ToTypeCode(code), CultureInfo.InvariantCulture);
			}
			else
			{
				result = value;
			}
			return result;
		}

		// Token: 0x04000D3B RID: 3387
		private static int primitiveTypeEnumLength = 17;

		// Token: 0x04000D3C RID: 3388
		private static volatile Type[] typeA;

		// Token: 0x04000D3D RID: 3389
		private static volatile Type[] arrayTypeA;

		// Token: 0x04000D3E RID: 3390
		private static volatile string[] valueA;

		// Token: 0x04000D3F RID: 3391
		private static volatile TypeCode[] typeCodeA;

		// Token: 0x04000D40 RID: 3392
		private static volatile InternalPrimitiveTypeE[] codeA;

		// Token: 0x04000D41 RID: 3393
		internal static Type typeofISerializable = typeof(ISerializable);

		// Token: 0x04000D42 RID: 3394
		internal static Type typeofString = typeof(string);

		// Token: 0x04000D43 RID: 3395
		internal static Type typeofConverter = typeof(Converter);

		// Token: 0x04000D44 RID: 3396
		internal static Type typeofBoolean = typeof(bool);

		// Token: 0x04000D45 RID: 3397
		internal static Type typeofByte = typeof(byte);

		// Token: 0x04000D46 RID: 3398
		internal static Type typeofChar = typeof(char);

		// Token: 0x04000D47 RID: 3399
		internal static Type typeofDecimal = typeof(decimal);

		// Token: 0x04000D48 RID: 3400
		internal static Type typeofDouble = typeof(double);

		// Token: 0x04000D49 RID: 3401
		internal static Type typeofInt16 = typeof(short);

		// Token: 0x04000D4A RID: 3402
		internal static Type typeofInt32 = typeof(int);

		// Token: 0x04000D4B RID: 3403
		internal static Type typeofInt64 = typeof(long);

		// Token: 0x04000D4C RID: 3404
		internal static Type typeofSByte = typeof(sbyte);

		// Token: 0x04000D4D RID: 3405
		internal static Type typeofSingle = typeof(float);

		// Token: 0x04000D4E RID: 3406
		internal static Type typeofTimeSpan = typeof(TimeSpan);

		// Token: 0x04000D4F RID: 3407
		internal static Type typeofDateTime = typeof(DateTime);

		// Token: 0x04000D50 RID: 3408
		internal static Type typeofUInt16 = typeof(ushort);

		// Token: 0x04000D51 RID: 3409
		internal static Type typeofUInt32 = typeof(uint);

		// Token: 0x04000D52 RID: 3410
		internal static Type typeofUInt64 = typeof(ulong);

		// Token: 0x04000D53 RID: 3411
		internal static Type typeofObject = typeof(object);

		// Token: 0x04000D54 RID: 3412
		internal static Type typeofSystemVoid = typeof(void);

		// Token: 0x04000D55 RID: 3413
		internal static Assembly urtAssembly = Assembly.GetAssembly(Converter.typeofString);

		// Token: 0x04000D56 RID: 3414
		internal static string urtAssemblyString = Converter.urtAssembly.FullName;

		// Token: 0x04000D57 RID: 3415
		internal static Type typeofTypeArray = typeof(Type[]);

		// Token: 0x04000D58 RID: 3416
		internal static Type typeofObjectArray = typeof(object[]);

		// Token: 0x04000D59 RID: 3417
		internal static Type typeofStringArray = typeof(string[]);

		// Token: 0x04000D5A RID: 3418
		internal static Type typeofBooleanArray = typeof(bool[]);

		// Token: 0x04000D5B RID: 3419
		internal static Type typeofByteArray = typeof(byte[]);

		// Token: 0x04000D5C RID: 3420
		internal static Type typeofCharArray = typeof(char[]);

		// Token: 0x04000D5D RID: 3421
		internal static Type typeofDecimalArray = typeof(decimal[]);

		// Token: 0x04000D5E RID: 3422
		internal static Type typeofDoubleArray = typeof(double[]);

		// Token: 0x04000D5F RID: 3423
		internal static Type typeofInt16Array = typeof(short[]);

		// Token: 0x04000D60 RID: 3424
		internal static Type typeofInt32Array = typeof(int[]);

		// Token: 0x04000D61 RID: 3425
		internal static Type typeofInt64Array = typeof(long[]);

		// Token: 0x04000D62 RID: 3426
		internal static Type typeofSByteArray = typeof(sbyte[]);

		// Token: 0x04000D63 RID: 3427
		internal static Type typeofSingleArray = typeof(float[]);

		// Token: 0x04000D64 RID: 3428
		internal static Type typeofTimeSpanArray = typeof(TimeSpan[]);

		// Token: 0x04000D65 RID: 3429
		internal static Type typeofDateTimeArray = typeof(DateTime[]);

		// Token: 0x04000D66 RID: 3430
		internal static Type typeofUInt16Array = typeof(ushort[]);

		// Token: 0x04000D67 RID: 3431
		internal static Type typeofUInt32Array = typeof(uint[]);

		// Token: 0x04000D68 RID: 3432
		internal static Type typeofUInt64Array = typeof(ulong[]);

		// Token: 0x04000D69 RID: 3433
		internal static Type typeofMarshalByRefObject = typeof(MarshalByRefObject);
	}
}
