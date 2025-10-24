using System;

namespace System.Xml.Serialization
{
	// Token: 0x020001D7 RID: 471
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	internal class XmlTypeConvertorAttribute : Attribute
	{
		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000FAA RID: 4010 RVA: 0x00063090 File Offset: 0x00061290
		// (set) Token: 0x06000FAB RID: 4011 RVA: 0x00063098 File Offset: 0x00061298
		public string Method { get; private set; }

		// Token: 0x06000FAC RID: 4012 RVA: 0x000630A1 File Offset: 0x000612A1
		public XmlTypeConvertorAttribute(string method)
		{
			this.Method = method;
		}
	}
}
