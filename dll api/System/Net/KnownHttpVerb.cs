using System;
using System.Collections.Specialized;

namespace System.Net
{
	// Token: 0x0200015A RID: 346
	internal class KnownHttpVerb
	{
		// Token: 0x06000972 RID: 2418 RVA: 0x00033757 File Offset: 0x00031957
		internal KnownHttpVerb(string name, bool requireContentBody, bool contentBodyNotAllowed, bool connectRequest, bool expectNoContentResponse)
		{
			this.Name = name;
			this.RequireContentBody = requireContentBody;
			this.ContentBodyNotAllowed = contentBodyNotAllowed;
			this.ConnectRequest = connectRequest;
			this.ExpectNoContentResponse = expectNoContentResponse;
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00033784 File Offset: 0x00031984
		static KnownHttpVerb()
		{
			KnownHttpVerb.NamedHeaders[KnownHttpVerb.Get.Name] = KnownHttpVerb.Get;
			KnownHttpVerb.NamedHeaders[KnownHttpVerb.Connect.Name] = KnownHttpVerb.Connect;
			KnownHttpVerb.NamedHeaders[KnownHttpVerb.Head.Name] = KnownHttpVerb.Head;
			KnownHttpVerb.NamedHeaders[KnownHttpVerb.Put.Name] = KnownHttpVerb.Put;
			KnownHttpVerb.NamedHeaders[KnownHttpVerb.Post.Name] = KnownHttpVerb.Post;
			KnownHttpVerb.NamedHeaders[KnownHttpVerb.MkCol.Name] = KnownHttpVerb.MkCol;
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x000338A8 File Offset: 0x00031AA8
		public static KnownHttpVerb Parse(string name)
		{
			KnownHttpVerb knownHttpVerb = KnownHttpVerb.NamedHeaders[name] as KnownHttpVerb;
			if (knownHttpVerb == null)
			{
				knownHttpVerb = new KnownHttpVerb(name, false, false, false, false);
			}
			return knownHttpVerb;
		}

		// Token: 0x040006E7 RID: 1767
		internal string Name;

		// Token: 0x040006E8 RID: 1768
		internal bool RequireContentBody;

		// Token: 0x040006E9 RID: 1769
		internal bool ContentBodyNotAllowed;

		// Token: 0x040006EA RID: 1770
		internal bool ConnectRequest;

		// Token: 0x040006EB RID: 1771
		internal bool ExpectNoContentResponse;

		// Token: 0x040006EC RID: 1772
		private static ListDictionary NamedHeaders = new ListDictionary(CaseInsensitiveAscii.StaticInstance);

		// Token: 0x040006ED RID: 1773
		internal static KnownHttpVerb Get = new KnownHttpVerb("GET", false, true, false, false);

		// Token: 0x040006EE RID: 1774
		internal static KnownHttpVerb Connect = new KnownHttpVerb("CONNECT", false, true, true, false);

		// Token: 0x040006EF RID: 1775
		internal static KnownHttpVerb Head = new KnownHttpVerb("HEAD", false, true, false, true);

		// Token: 0x040006F0 RID: 1776
		internal static KnownHttpVerb Put = new KnownHttpVerb("PUT", true, false, false, false);

		// Token: 0x040006F1 RID: 1777
		internal static KnownHttpVerb Post = new KnownHttpVerb("POST", true, false, false, false);

		// Token: 0x040006F2 RID: 1778
		internal static KnownHttpVerb MkCol = new KnownHttpVerb("MKCOL", false, false, false, false);
	}
}
