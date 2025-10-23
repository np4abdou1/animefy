using System;

namespace System
{
	/// <summary>Specifies the type of an object.</summary>
	// Token: 0x02000110 RID: 272
	public enum TypeCode
	{
		/// <summary>A null reference.</summary>
		// Token: 0x04000393 RID: 915
		Empty,
		/// <summary>A general type representing any reference or value type not explicitly represented by another <see langword="TypeCode" />.</summary>
		// Token: 0x04000394 RID: 916
		Object,
		/// <summary>A database null (column) value.</summary>
		// Token: 0x04000395 RID: 917
		DBNull,
		/// <summary>A simple type representing Boolean values of <see langword="true" /> or <see langword="false" />.</summary>
		// Token: 0x04000396 RID: 918
		Boolean,
		/// <summary>An integral type representing unsigned 16-bit integers with values between 0 and 65535. The set of possible values for the <see cref="F:System.TypeCode.Char" /> type corresponds to the Unicode character set.</summary>
		// Token: 0x04000397 RID: 919
		Char,
		/// <summary>An integral type representing signed 8-bit integers with values between -128 and 127.</summary>
		// Token: 0x04000398 RID: 920
		SByte,
		/// <summary>An integral type representing unsigned 8-bit integers with values between 0 and 255.</summary>
		// Token: 0x04000399 RID: 921
		Byte,
		/// <summary>An integral type representing signed 16-bit integers with values between -32768 and 32767.</summary>
		// Token: 0x0400039A RID: 922
		Int16,
		/// <summary>An integral type representing unsigned 16-bit integers with values between 0 and 65535.</summary>
		// Token: 0x0400039B RID: 923
		UInt16,
		/// <summary>An integral type representing signed 32-bit integers with values between -2147483648 and 2147483647.</summary>
		// Token: 0x0400039C RID: 924
		Int32,
		/// <summary>An integral type representing unsigned 32-bit integers with values between 0 and 4294967295.</summary>
		// Token: 0x0400039D RID: 925
		UInt32,
		/// <summary>An integral type representing signed 64-bit integers with values between -9223372036854775808 and 9223372036854775807.</summary>
		// Token: 0x0400039E RID: 926
		Int64,
		/// <summary>An integral type representing unsigned 64-bit integers with values between 0 and 18446744073709551615.</summary>
		// Token: 0x0400039F RID: 927
		UInt64,
		/// <summary>A floating point type representing values ranging from approximately 1.5 x 10 -45 to 3.4 x 10 38 with a precision of 7 digits.</summary>
		// Token: 0x040003A0 RID: 928
		Single,
		/// <summary>A floating point type representing values ranging from approximately 5.0 x 10 -324 to 1.7 x 10 308 with a precision of 15-16 digits.</summary>
		// Token: 0x040003A1 RID: 929
		Double,
		/// <summary>A simple type representing values ranging from 1.0 x 10 -28 to approximately 7.9 x 10 28 with 28-29 significant digits.</summary>
		// Token: 0x040003A2 RID: 930
		Decimal,
		/// <summary>A type representing a date and time value.</summary>
		// Token: 0x040003A3 RID: 931
		DateTime,
		/// <summary>A sealed class type representing Unicode character strings.</summary>
		// Token: 0x040003A4 RID: 932
		String = 18
	}
}
