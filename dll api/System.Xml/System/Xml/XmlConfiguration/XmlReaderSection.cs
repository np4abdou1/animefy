using System;
using System.ComponentModel;

namespace System.Xml.XmlConfiguration
{
	/// <summary>Represents an XML reader section.</summary>
	// Token: 0x0200021E RID: 542
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class XmlReaderSection
	{
		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x0000A216 File Offset: 0x00008416
		internal static bool ProhibitDefaultUrlResolver
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x0006F42E File Offset: 0x0006D62E
		internal static XmlResolver CreateDefaultResolver()
		{
			if (XmlReaderSection.ProhibitDefaultUrlResolver)
			{
				return null;
			}
			return new XmlUrlResolver();
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x060011EF RID: 4591 RVA: 0x0000A216 File Offset: 0x00008416
		internal static bool CollapseWhiteSpaceIntoEmptyString
		{
			get
			{
				return false;
			}
		}
	}
}
