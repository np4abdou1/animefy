using System;
using System.Collections;

namespace Mono.Security.X509
{
	// Token: 0x02000017 RID: 23
	public sealed class X509ExtensionCollection : CollectionBase, IEnumerable
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x000073B7 File Offset: 0x000055B7
		public X509ExtensionCollection()
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00007C80 File Offset: 0x00005E80
		public X509ExtensionCollection(ASN1 asn1) : this()
		{
			this.readOnly = true;
			if (asn1 == null)
			{
				return;
			}
			if (asn1.Tag != 48)
			{
				throw new Exception("Invalid extensions format");
			}
			for (int i = 0; i < asn1.Count; i++)
			{
				X509Extension value = new X509Extension(asn1[i]);
				base.InnerList.Add(value);
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00007CE0 File Offset: 0x00005EE0
		public int IndexOf(string oid)
		{
			if (oid == null)
			{
				throw new ArgumentNullException("oid");
			}
			for (int i = 0; i < base.InnerList.Count; i++)
			{
				if (((X509Extension)base.InnerList[i]).Oid == oid)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000744B File Offset: 0x0000564B
		IEnumerator IEnumerable.GetEnumerator()
		{
			return base.InnerList.GetEnumerator();
		}

		// Token: 0x17000041 RID: 65
		public X509Extension this[string oid]
		{
			get
			{
				int num = this.IndexOf(oid);
				if (num == -1)
				{
					return null;
				}
				return (X509Extension)base.InnerList[num];
			}
		}

		// Token: 0x04000072 RID: 114
		private bool readOnly;
	}
}
