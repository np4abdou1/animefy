using System;
using System.Collections;
using System.Text;

namespace System.Xml.Schema
{
	// Token: 0x020002A2 RID: 674
	internal class NamespaceList
	{
		// Token: 0x06001552 RID: 5458 RVA: 0x0000A20E File Offset: 0x0000840E
		public NamespaceList()
		{
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x0007DFD4 File Offset: 0x0007C1D4
		public NamespaceList(string namespaces, string targetNamespace)
		{
			this.targetNamespace = targetNamespace;
			namespaces = namespaces.Trim();
			if (namespaces == "##any" || namespaces.Length == 0)
			{
				this.type = NamespaceList.ListType.Any;
				return;
			}
			if (namespaces == "##other")
			{
				this.type = NamespaceList.ListType.Other;
				return;
			}
			this.type = NamespaceList.ListType.Set;
			this.set = new Hashtable();
			string[] array = XmlConvert.SplitString(namespaces);
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == "##local")
				{
					this.set[string.Empty] = string.Empty;
				}
				else if (array[i] == "##targetNamespace")
				{
					this.set[targetNamespace] = targetNamespace;
				}
				else
				{
					XmlConvert.ToUri(array[i]);
					this.set[array[i]] = array[i];
				}
			}
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x0007E0B0 File Offset: 0x0007C2B0
		public NamespaceList Clone()
		{
			NamespaceList namespaceList = (NamespaceList)base.MemberwiseClone();
			if (this.type == NamespaceList.ListType.Set)
			{
				namespaceList.set = (Hashtable)this.set.Clone();
			}
			return namespaceList;
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001555 RID: 5461 RVA: 0x0007E0E9 File Offset: 0x0007C2E9
		public NamespaceList.ListType Type
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001556 RID: 5462 RVA: 0x0007E0F1 File Offset: 0x0007C2F1
		public string Excluded
		{
			get
			{
				return this.targetNamespace;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06001557 RID: 5463 RVA: 0x0007E0FC File Offset: 0x0007C2FC
		public ICollection Enumerate
		{
			get
			{
				NamespaceList.ListType listType = this.type;
				if (listType > NamespaceList.ListType.Other && listType == NamespaceList.ListType.Set)
				{
					return this.set.Keys;
				}
				throw new InvalidOperationException();
			}
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x0007E12C File Offset: 0x0007C32C
		public virtual bool Allows(string ns)
		{
			switch (this.type)
			{
			case NamespaceList.ListType.Any:
				return true;
			case NamespaceList.ListType.Other:
				return ns != this.targetNamespace && ns.Length != 0;
			case NamespaceList.ListType.Set:
				return this.set[ns] != null;
			default:
				return false;
			}
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x0007E181 File Offset: 0x0007C381
		public bool Allows(XmlQualifiedName qname)
		{
			return this.Allows(qname.Namespace);
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x0007E190 File Offset: 0x0007C390
		public override string ToString()
		{
			switch (this.type)
			{
			case NamespaceList.ListType.Any:
				return "##any";
			case NamespaceList.ListType.Other:
				return "##other";
			case NamespaceList.ListType.Set:
			{
				StringBuilder stringBuilder = new StringBuilder();
				bool flag = true;
				foreach (object obj in this.set.Keys)
				{
					string text = (string)obj;
					if (flag)
					{
						flag = false;
					}
					else
					{
						stringBuilder.Append(" ");
					}
					if (text == this.targetNamespace)
					{
						stringBuilder.Append("##targetNamespace");
					}
					else if (text.Length == 0)
					{
						stringBuilder.Append("##local");
					}
					else
					{
						stringBuilder.Append(text);
					}
				}
				return stringBuilder.ToString();
			}
			default:
				return string.Empty;
			}
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x0007E27C File Offset: 0x0007C47C
		public static bool IsSubset(NamespaceList sub, NamespaceList super)
		{
			if (super.type == NamespaceList.ListType.Any)
			{
				return true;
			}
			if (sub.type == NamespaceList.ListType.Other && super.type == NamespaceList.ListType.Other)
			{
				return super.targetNamespace == sub.targetNamespace;
			}
			if (sub.type != NamespaceList.ListType.Set)
			{
				return false;
			}
			if (super.type == NamespaceList.ListType.Other)
			{
				return !sub.set.Contains(super.targetNamespace);
			}
			foreach (object obj in sub.set.Keys)
			{
				string key = (string)obj;
				if (!super.set.Contains(key))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x0007E340 File Offset: 0x0007C540
		public static NamespaceList Union(NamespaceList o1, NamespaceList o2, bool v1Compat)
		{
			NamespaceList namespaceList = null;
			if (o1.type == NamespaceList.ListType.Any)
			{
				namespaceList = new NamespaceList();
			}
			else if (o2.type == NamespaceList.ListType.Any)
			{
				namespaceList = new NamespaceList();
			}
			else
			{
				if (o1.type == NamespaceList.ListType.Set && o2.type == NamespaceList.ListType.Set)
				{
					namespaceList = o1.Clone();
					using (IEnumerator enumerator = o2.set.Keys.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							string text = (string)obj;
							namespaceList.set[text] = text;
						}
						return namespaceList;
					}
				}
				if (o1.type == NamespaceList.ListType.Other && o2.type == NamespaceList.ListType.Other)
				{
					if (o1.targetNamespace == o2.targetNamespace)
					{
						namespaceList = o1.Clone();
					}
					else
					{
						namespaceList = new NamespaceList("##other", string.Empty);
					}
				}
				else if (o1.type == NamespaceList.ListType.Set && o2.type == NamespaceList.ListType.Other)
				{
					if (v1Compat)
					{
						if (o1.set.Contains(o2.targetNamespace))
						{
							namespaceList = new NamespaceList();
						}
						else
						{
							namespaceList = o2.Clone();
						}
					}
					else if (o2.targetNamespace != string.Empty)
					{
						namespaceList = o1.CompareSetToOther(o2);
					}
					else if (o1.set.Contains(string.Empty))
					{
						namespaceList = new NamespaceList();
					}
					else
					{
						namespaceList = new NamespaceList("##other", string.Empty);
					}
				}
				else if (o2.type == NamespaceList.ListType.Set && o1.type == NamespaceList.ListType.Other)
				{
					if (v1Compat)
					{
						if (o2.set.Contains(o2.targetNamespace))
						{
							namespaceList = new NamespaceList();
						}
						else
						{
							namespaceList = o1.Clone();
						}
					}
					else if (o1.targetNamespace != string.Empty)
					{
						namespaceList = o2.CompareSetToOther(o1);
					}
					else if (o2.set.Contains(string.Empty))
					{
						namespaceList = new NamespaceList();
					}
					else
					{
						namespaceList = new NamespaceList("##other", string.Empty);
					}
				}
			}
			return namespaceList;
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x0007E540 File Offset: 0x0007C740
		private NamespaceList CompareSetToOther(NamespaceList other)
		{
			NamespaceList result;
			if (this.set.Contains(other.targetNamespace))
			{
				if (this.set.Contains(string.Empty))
				{
					result = new NamespaceList();
				}
				else
				{
					result = new NamespaceList("##other", string.Empty);
				}
			}
			else if (this.set.Contains(string.Empty))
			{
				result = null;
			}
			else
			{
				result = other.Clone();
			}
			return result;
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x0007E5AC File Offset: 0x0007C7AC
		public static NamespaceList Intersection(NamespaceList o1, NamespaceList o2, bool v1Compat)
		{
			NamespaceList namespaceList = null;
			if (o1.type == NamespaceList.ListType.Any)
			{
				namespaceList = o2.Clone();
			}
			else if (o2.type == NamespaceList.ListType.Any)
			{
				namespaceList = o1.Clone();
			}
			else if (o1.type == NamespaceList.ListType.Set && o2.type == NamespaceList.ListType.Other)
			{
				namespaceList = o1.Clone();
				namespaceList.RemoveNamespace(o2.targetNamespace);
				if (!v1Compat)
				{
					namespaceList.RemoveNamespace(string.Empty);
				}
			}
			else if (o1.type == NamespaceList.ListType.Other && o2.type == NamespaceList.ListType.Set)
			{
				namespaceList = o2.Clone();
				namespaceList.RemoveNamespace(o1.targetNamespace);
				if (!v1Compat)
				{
					namespaceList.RemoveNamespace(string.Empty);
				}
			}
			else
			{
				if (o1.type == NamespaceList.ListType.Set && o2.type == NamespaceList.ListType.Set)
				{
					namespaceList = o1.Clone();
					namespaceList = new NamespaceList();
					namespaceList.type = NamespaceList.ListType.Set;
					namespaceList.set = new Hashtable();
					using (IEnumerator enumerator = o1.set.Keys.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							string text = (string)obj;
							if (o2.set.Contains(text))
							{
								namespaceList.set.Add(text, text);
							}
						}
						return namespaceList;
					}
				}
				if (o1.type == NamespaceList.ListType.Other && o2.type == NamespaceList.ListType.Other)
				{
					if (o1.targetNamespace == o2.targetNamespace)
					{
						namespaceList = o1.Clone();
						return namespaceList;
					}
					if (!v1Compat)
					{
						if (o1.targetNamespace == string.Empty)
						{
							namespaceList = o2.Clone();
						}
						else if (o2.targetNamespace == string.Empty)
						{
							namespaceList = o1.Clone();
						}
					}
				}
			}
			return namespaceList;
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x0007E758 File Offset: 0x0007C958
		private void RemoveNamespace(string tns)
		{
			if (this.set[tns] != null)
			{
				this.set.Remove(tns);
			}
		}

		// Token: 0x04000DC7 RID: 3527
		private NamespaceList.ListType type;

		// Token: 0x04000DC8 RID: 3528
		private Hashtable set;

		// Token: 0x04000DC9 RID: 3529
		private string targetNamespace;

		// Token: 0x020002A3 RID: 675
		public enum ListType
		{
			// Token: 0x04000DCB RID: 3531
			Any,
			// Token: 0x04000DCC RID: 3532
			Other,
			// Token: 0x04000DCD RID: 3533
			Set
		}
	}
}
