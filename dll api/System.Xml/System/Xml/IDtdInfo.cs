using System;

namespace System.Xml
{
	// Token: 0x02000029 RID: 41
	internal interface IDtdInfo
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000150 RID: 336
		XmlQualifiedName Name { get; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000151 RID: 337
		string InternalDtdSubset { get; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000152 RID: 338
		bool HasDefaultAttributes { get; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000153 RID: 339
		bool HasNonCDataAttributes { get; }

		// Token: 0x06000154 RID: 340
		IDtdAttributeListInfo LookupAttributeList(string prefix, string localName);

		// Token: 0x06000155 RID: 341
		IDtdEntityInfo LookupEntity(string name);
	}
}
