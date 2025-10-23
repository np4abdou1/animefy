using System;

namespace System.Xml.Schema
{
	/// <summary>Represents the W3C XML Schema Definition Language (XSD) schema types.</summary>
	// Token: 0x0200032B RID: 811
	public enum XmlTypeCode
	{
		/// <summary>No type information.</summary>
		// Token: 0x04001192 RID: 4498
		None,
		/// <summary>An item such as a node or atomic value.</summary>
		// Token: 0x04001193 RID: 4499
		Item,
		/// <summary>This value supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		// Token: 0x04001194 RID: 4500
		Node,
		/// <summary>This value supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		// Token: 0x04001195 RID: 4501
		Document,
		/// <summary>This value supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		// Token: 0x04001196 RID: 4502
		Element,
		/// <summary>This value supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		// Token: 0x04001197 RID: 4503
		Attribute,
		/// <summary>This value supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		// Token: 0x04001198 RID: 4504
		Namespace,
		/// <summary>This value supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		// Token: 0x04001199 RID: 4505
		ProcessingInstruction,
		/// <summary>This value supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		// Token: 0x0400119A RID: 4506
		Comment,
		/// <summary>This value supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		// Token: 0x0400119B RID: 4507
		Text,
		/// <summary>Any atomic value of a union.</summary>
		// Token: 0x0400119C RID: 4508
		AnyAtomicType,
		/// <summary>An untyped atomic value.</summary>
		// Token: 0x0400119D RID: 4509
		UntypedAtomic,
		/// <summary>A W3C XML Schema <see langword="xs:string" /> type.</summary>
		// Token: 0x0400119E RID: 4510
		String,
		/// <summary>A W3C XML Schema <see langword="xs:boolean" /> type.</summary>
		// Token: 0x0400119F RID: 4511
		Boolean,
		/// <summary>A W3C XML Schema <see langword="xs:decimal" /> type.</summary>
		// Token: 0x040011A0 RID: 4512
		Decimal,
		/// <summary>A W3C XML Schema <see langword="xs:float" /> type.</summary>
		// Token: 0x040011A1 RID: 4513
		Float,
		/// <summary>A W3C XML Schema <see langword="xs:double" /> type.</summary>
		// Token: 0x040011A2 RID: 4514
		Double,
		/// <summary>A W3C XML Schema <see langword="xs:Duration" /> type.</summary>
		// Token: 0x040011A3 RID: 4515
		Duration,
		/// <summary>A W3C XML Schema <see langword="xs:dateTime" /> type.</summary>
		// Token: 0x040011A4 RID: 4516
		DateTime,
		/// <summary>A W3C XML Schema <see langword="xs:time" /> type.</summary>
		// Token: 0x040011A5 RID: 4517
		Time,
		/// <summary>A W3C XML Schema <see langword="xs:date" /> type.</summary>
		// Token: 0x040011A6 RID: 4518
		Date,
		/// <summary>A W3C XML Schema <see langword="xs:gYearMonth" /> type.</summary>
		// Token: 0x040011A7 RID: 4519
		GYearMonth,
		/// <summary>A W3C XML Schema <see langword="xs:gYear" /> type.</summary>
		// Token: 0x040011A8 RID: 4520
		GYear,
		/// <summary>A W3C XML Schema <see langword="xs:gMonthDay" /> type.</summary>
		// Token: 0x040011A9 RID: 4521
		GMonthDay,
		/// <summary>A W3C XML Schema <see langword="xs:gDay" /> type.</summary>
		// Token: 0x040011AA RID: 4522
		GDay,
		/// <summary>A W3C XML Schema <see langword="xs:gMonth" /> type.</summary>
		// Token: 0x040011AB RID: 4523
		GMonth,
		/// <summary>A W3C XML Schema <see langword="xs:hexBinary" /> type.</summary>
		// Token: 0x040011AC RID: 4524
		HexBinary,
		/// <summary>A W3C XML Schema <see langword="xs:base64Binary" /> type.</summary>
		// Token: 0x040011AD RID: 4525
		Base64Binary,
		/// <summary>A W3C XML Schema <see langword="xs:anyURI" /> type.</summary>
		// Token: 0x040011AE RID: 4526
		AnyUri,
		/// <summary>A W3C XML Schema <see langword="xs:QName" /> type.</summary>
		// Token: 0x040011AF RID: 4527
		QName,
		/// <summary>A W3C XML Schema <see langword="xs:NOTATION" /> type.</summary>
		// Token: 0x040011B0 RID: 4528
		Notation,
		/// <summary>A W3C XML Schema <see langword="xs:normalizedString" /> type.</summary>
		// Token: 0x040011B1 RID: 4529
		NormalizedString,
		/// <summary>A W3C XML Schema <see langword="xs:token" /> type.</summary>
		// Token: 0x040011B2 RID: 4530
		Token,
		/// <summary>A W3C XML Schema <see langword="xs:language" /> type.</summary>
		// Token: 0x040011B3 RID: 4531
		Language,
		/// <summary>A W3C XML Schema <see langword="xs:NMTOKEN" /> type.</summary>
		// Token: 0x040011B4 RID: 4532
		NmToken,
		/// <summary>A W3C XML Schema <see langword="xs:Name" /> type.</summary>
		// Token: 0x040011B5 RID: 4533
		Name,
		/// <summary>A W3C XML Schema <see langword="xs:NCName" /> type.</summary>
		// Token: 0x040011B6 RID: 4534
		NCName,
		/// <summary>A W3C XML Schema <see langword="xs:ID" /> type.</summary>
		// Token: 0x040011B7 RID: 4535
		Id,
		/// <summary>A W3C XML Schema <see langword="xs:IDREF" /> type.</summary>
		// Token: 0x040011B8 RID: 4536
		Idref,
		/// <summary>A W3C XML Schema <see langword="xs:ENTITY" /> type.</summary>
		// Token: 0x040011B9 RID: 4537
		Entity,
		/// <summary>A W3C XML Schema <see langword="xs:integer" /> type.</summary>
		// Token: 0x040011BA RID: 4538
		Integer,
		/// <summary>A W3C XML Schema <see langword="xs:nonPositiveInteger" /> type.</summary>
		// Token: 0x040011BB RID: 4539
		NonPositiveInteger,
		/// <summary>A W3C XML Schema <see langword="xs:negativeInteger" /> type.</summary>
		// Token: 0x040011BC RID: 4540
		NegativeInteger,
		/// <summary>A W3C XML Schema <see langword="xs:long" /> type.</summary>
		// Token: 0x040011BD RID: 4541
		Long,
		/// <summary>A W3C XML Schema <see langword="xs:int" /> type.</summary>
		// Token: 0x040011BE RID: 4542
		Int,
		/// <summary>A W3C XML Schema <see langword="xs:short" /> type.</summary>
		// Token: 0x040011BF RID: 4543
		Short,
		/// <summary>A W3C XML Schema <see langword="xs:byte" /> type.</summary>
		// Token: 0x040011C0 RID: 4544
		Byte,
		/// <summary>A W3C XML Schema <see langword="xs:nonNegativeInteger" /> type.</summary>
		// Token: 0x040011C1 RID: 4545
		NonNegativeInteger,
		/// <summary>A W3C XML Schema <see langword="xs:unsignedLong" /> type.</summary>
		// Token: 0x040011C2 RID: 4546
		UnsignedLong,
		/// <summary>A W3C XML Schema <see langword="xs:unsignedInt" /> type.</summary>
		// Token: 0x040011C3 RID: 4547
		UnsignedInt,
		/// <summary>A W3C XML Schema <see langword="xs:unsignedShort" /> type.</summary>
		// Token: 0x040011C4 RID: 4548
		UnsignedShort,
		/// <summary>A W3C XML Schema <see langword="xs:unsignedByte" /> type.</summary>
		// Token: 0x040011C5 RID: 4549
		UnsignedByte,
		/// <summary>A W3C XML Schema <see langword="xs:positiveInteger" /> type.</summary>
		// Token: 0x040011C6 RID: 4550
		PositiveInteger,
		/// <summary>This value supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		// Token: 0x040011C7 RID: 4551
		YearMonthDuration,
		/// <summary>This value supports the .NET Framework infrastructure and is not intended to be used directly from your code.</summary>
		// Token: 0x040011C8 RID: 4552
		DayTimeDuration
	}
}
