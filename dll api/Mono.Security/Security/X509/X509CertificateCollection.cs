using System;
using System.Collections;

namespace Mono.Security.X509
{
	// Token: 0x02000012 RID: 18
	[Serializable]
	public class X509CertificateCollection : CollectionBase, IEnumerable
	{
		// Token: 0x1700003A RID: 58
		public X509Certificate this[int index]
		{
			get
			{
				return (X509Certificate)base.InnerList[index];
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000073D2 File Offset: 0x000055D2
		public int Add(X509Certificate value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			return base.InnerList.Add(value);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000073F0 File Offset: 0x000055F0
		public void AddRange(X509CertificateCollection value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			for (int i = 0; i < value.InnerList.Count; i++)
			{
				base.InnerList.Add(value[i]);
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00007434 File Offset: 0x00005634
		public bool Contains(X509Certificate value)
		{
			return this.IndexOf(value) != -1;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00007443 File Offset: 0x00005643
		public new X509CertificateCollection.X509CertificateEnumerator GetEnumerator()
		{
			return new X509CertificateCollection.X509CertificateEnumerator(this);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000744B File Offset: 0x0000564B
		IEnumerator IEnumerable.GetEnumerator()
		{
			return base.InnerList.GetEnumerator();
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00007458 File Offset: 0x00005658
		public override int GetHashCode()
		{
			return base.InnerList.GetHashCode();
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00007468 File Offset: 0x00005668
		public int IndexOf(X509Certificate value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			byte[] hash = value.Hash;
			for (int i = 0; i < base.InnerList.Count; i++)
			{
				X509Certificate x509Certificate = (X509Certificate)base.InnerList[i];
				if (this.Compare(x509Certificate.Hash, hash))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000074C4 File Offset: 0x000056C4
		private bool Compare(byte[] array1, byte[] array2)
		{
			if (array1 == null && array2 == null)
			{
				return true;
			}
			if (array1 == null || array2 == null)
			{
				return false;
			}
			if (array1.Length != array2.Length)
			{
				return false;
			}
			for (int i = 0; i < array1.Length; i++)
			{
				if (array1[i] != array2[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x02000013 RID: 19
		public class X509CertificateEnumerator : IEnumerator
		{
			// Token: 0x060000B5 RID: 181 RVA: 0x00007504 File Offset: 0x00005704
			public X509CertificateEnumerator(X509CertificateCollection mappings)
			{
				this.enumerator = ((IEnumerable)mappings).GetEnumerator();
			}

			// Token: 0x1700003B RID: 59
			// (get) Token: 0x060000B6 RID: 182 RVA: 0x00007518 File Offset: 0x00005718
			public X509Certificate Current
			{
				get
				{
					return (X509Certificate)this.enumerator.Current;
				}
			}

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000752A File Offset: 0x0000572A
			object IEnumerator.Current
			{
				get
				{
					return this.enumerator.Current;
				}
			}

			// Token: 0x060000B8 RID: 184 RVA: 0x00007537 File Offset: 0x00005737
			bool IEnumerator.MoveNext()
			{
				return this.enumerator.MoveNext();
			}

			// Token: 0x060000B9 RID: 185 RVA: 0x00007544 File Offset: 0x00005744
			void IEnumerator.Reset()
			{
				this.enumerator.Reset();
			}

			// Token: 0x060000BA RID: 186 RVA: 0x00007537 File Offset: 0x00005737
			public bool MoveNext()
			{
				return this.enumerator.MoveNext();
			}

			// Token: 0x04000061 RID: 97
			private IEnumerator enumerator;
		}
	}
}
