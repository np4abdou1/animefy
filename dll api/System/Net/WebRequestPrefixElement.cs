using System;
using System.Globalization;
using System.Reflection;

namespace System.Net
{
	// Token: 0x02000158 RID: 344
	internal class WebRequestPrefixElement
	{
		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x000336B8 File Offset: 0x000318B8
		// (set) Token: 0x0600096C RID: 2412 RVA: 0x00033738 File Offset: 0x00031938
		public IWebRequestCreate Creator
		{
			get
			{
				if (this.creator == null && this.creatorType != null)
				{
					lock (this)
					{
						if (this.creator == null)
						{
							this.creator = (IWebRequestCreate)Activator.CreateInstance(this.creatorType, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, new object[0], CultureInfo.InvariantCulture);
						}
					}
				}
				return this.creator;
			}
			set
			{
				this.creator = value;
			}
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00033741 File Offset: 0x00031941
		public WebRequestPrefixElement(string P, IWebRequestCreate C)
		{
			this.Prefix = P;
			this.Creator = C;
		}

		// Token: 0x040006E4 RID: 1764
		public string Prefix;

		// Token: 0x040006E5 RID: 1765
		internal IWebRequestCreate creator;

		// Token: 0x040006E6 RID: 1766
		internal Type creatorType;
	}
}
