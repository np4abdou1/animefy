using System;
using System.Collections;

namespace System.Xml.Schema
{
	// Token: 0x02000235 RID: 565
	internal class SymbolsDictionary
	{
		// Token: 0x06001295 RID: 4757 RVA: 0x00071ACE File Offset: 0x0006FCCE
		public SymbolsDictionary()
		{
			this.names = new Hashtable();
			this.particles = new ArrayList();
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001296 RID: 4758 RVA: 0x00071AF3 File Offset: 0x0006FCF3
		public int Count
		{
			get
			{
				return this.last + 1;
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001297 RID: 4759 RVA: 0x00071AFD File Offset: 0x0006FCFD
		// (set) Token: 0x06001298 RID: 4760 RVA: 0x00071B05 File Offset: 0x0006FD05
		public bool IsUpaEnforced
		{
			get
			{
				return this.isUpaEnforced;
			}
			set
			{
				this.isUpaEnforced = value;
			}
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00071B10 File Offset: 0x0006FD10
		public int AddName(XmlQualifiedName name, object particle)
		{
			object obj = this.names[name];
			if (obj != null)
			{
				int num = (int)obj;
				if (this.particles[num] != particle)
				{
					this.isUpaEnforced = false;
				}
				return num;
			}
			this.names.Add(name, this.last);
			this.particles.Add(particle);
			int num2 = this.last;
			this.last = num2 + 1;
			return num2;
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x00071B84 File Offset: 0x0006FD84
		public void AddNamespaceList(NamespaceList list, object particle, bool allowLocal)
		{
			switch (list.Type)
			{
			case NamespaceList.ListType.Any:
				this.particleLast = particle;
				return;
			case NamespaceList.ListType.Other:
				this.AddWildcard(list.Excluded, null);
				if (!allowLocal)
				{
					this.AddWildcard(string.Empty, null);
					return;
				}
				break;
			case NamespaceList.ListType.Set:
				foreach (object obj in list.Enumerate)
				{
					string wildcard = (string)obj;
					this.AddWildcard(wildcard, particle);
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x00071C20 File Offset: 0x0006FE20
		private void AddWildcard(string wildcard, object particle)
		{
			if (this.wildcards == null)
			{
				this.wildcards = new Hashtable();
			}
			object obj = this.wildcards[wildcard];
			if (obj == null)
			{
				this.wildcards.Add(wildcard, this.last);
				this.particles.Add(particle);
				this.last++;
				return;
			}
			if (particle != null)
			{
				this.particles[(int)obj] = particle;
			}
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x00071C98 File Offset: 0x0006FE98
		public ICollection GetNamespaceListSymbols(NamespaceList list)
		{
			ArrayList arrayList = new ArrayList();
			foreach (object obj in this.names.Keys)
			{
				XmlQualifiedName xmlQualifiedName = (XmlQualifiedName)obj;
				if (xmlQualifiedName != XmlQualifiedName.Empty && list.Allows(xmlQualifiedName))
				{
					arrayList.Add(this.names[xmlQualifiedName]);
				}
			}
			if (this.wildcards != null)
			{
				foreach (object obj2 in this.wildcards.Keys)
				{
					string text = (string)obj2;
					if (list.Allows(text))
					{
						arrayList.Add(this.wildcards[text]);
					}
				}
			}
			if (list.Type == NamespaceList.ListType.Any || list.Type == NamespaceList.ListType.Other)
			{
				arrayList.Add(this.last);
			}
			return arrayList;
		}

		// Token: 0x170003E0 RID: 992
		public int this[XmlQualifiedName name]
		{
			get
			{
				object obj = this.names[name];
				if (obj != null)
				{
					return (int)obj;
				}
				if (this.wildcards != null)
				{
					obj = this.wildcards[name.Namespace];
					if (obj != null)
					{
						return (int)obj;
					}
				}
				return this.last;
			}
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x00071DFE File Offset: 0x0006FFFE
		public bool Exists(XmlQualifiedName name)
		{
			return this.names[name] != null;
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x00071E11 File Offset: 0x00070011
		public object GetParticle(int symbol)
		{
			if (symbol != this.last)
			{
				return this.particles[symbol];
			}
			return this.particleLast;
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x00071E30 File Offset: 0x00070030
		public string NameOf(int symbol)
		{
			foreach (object obj in this.names)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				if ((int)dictionaryEntry.Value == symbol)
				{
					return ((XmlQualifiedName)dictionaryEntry.Key).ToString();
				}
			}
			if (this.wildcards != null)
			{
				foreach (object obj2 in this.wildcards)
				{
					DictionaryEntry dictionaryEntry2 = (DictionaryEntry)obj2;
					if ((int)dictionaryEntry2.Value == symbol)
					{
						return (string)dictionaryEntry2.Key + ":*";
					}
				}
			}
			return "##other:*";
		}

		// Token: 0x04000C91 RID: 3217
		private int last;

		// Token: 0x04000C92 RID: 3218
		private Hashtable names;

		// Token: 0x04000C93 RID: 3219
		private Hashtable wildcards;

		// Token: 0x04000C94 RID: 3220
		private ArrayList particles;

		// Token: 0x04000C95 RID: 3221
		private object particleLast;

		// Token: 0x04000C96 RID: 3222
		private bool isUpaEnforced = true;
	}
}
