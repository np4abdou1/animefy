using System;
using System.Collections;

namespace System.Xml.Serialization
{
	// Token: 0x0200021B RID: 539
	internal class ListMap : ObjectMap
	{
		// Token: 0x170003A0 RID: 928
		// (set) Token: 0x060011D8 RID: 4568 RVA: 0x0006EDA3 File Offset: 0x0006CFA3
		public string ChoiceMember
		{
			set
			{
				this._choiceMember = value;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x060011D9 RID: 4569 RVA: 0x0006EDAC File Offset: 0x0006CFAC
		// (set) Token: 0x060011DA RID: 4570 RVA: 0x0006EDB4 File Offset: 0x0006CFB4
		public XmlTypeMapElementInfoList ItemInfo
		{
			get
			{
				return this._itemInfo;
			}
			set
			{
				this._itemInfo = value;
			}
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x0006EDC0 File Offset: 0x0006CFC0
		public XmlTypeMapElementInfo FindElement(object ob, int index, object memberValue)
		{
			if (this._itemInfo.Count == 1)
			{
				return (XmlTypeMapElementInfo)this._itemInfo[0];
			}
			if (this._choiceMember != null && index != -1)
			{
				Array array = (Array)XmlTypeMapMember.GetValue(ob, this._choiceMember);
				if (array == null || index >= array.Length)
				{
					throw new InvalidOperationException("Invalid or missing choice enum value in member '" + this._choiceMember + "'.");
				}
				object value = array.GetValue(index);
				using (IEnumerator enumerator = this._itemInfo.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						XmlTypeMapElementInfo xmlTypeMapElementInfo = (XmlTypeMapElementInfo)obj;
						if (xmlTypeMapElementInfo.ChoiceValue != null && xmlTypeMapElementInfo.ChoiceValue.Equals(value))
						{
							return xmlTypeMapElementInfo;
						}
					}
					goto IL_16F;
				}
				goto IL_CC;
				IL_16F:
				return null;
			}
			IL_CC:
			if (memberValue == null)
			{
				return null;
			}
			Type type = memberValue.GetType();
			XmlTypeMapElementInfo xmlTypeMapElementInfo2 = null;
			foreach (object obj2 in this._itemInfo)
			{
				XmlTypeMapElementInfo xmlTypeMapElementInfo3 = (XmlTypeMapElementInfo)obj2;
				if (xmlTypeMapElementInfo3.TypeData.Type == type)
				{
					return xmlTypeMapElementInfo3;
				}
				if (xmlTypeMapElementInfo3.TypeData.Type.IsAssignableFrom(type) && (xmlTypeMapElementInfo2 == null || xmlTypeMapElementInfo3.TypeData.Type.IsAssignableFrom(xmlTypeMapElementInfo2.TypeData.Type)))
				{
					xmlTypeMapElementInfo2 = xmlTypeMapElementInfo3;
				}
			}
			return xmlTypeMapElementInfo2;
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x0006EF5C File Offset: 0x0006D15C
		public XmlTypeMapElementInfo FindElement(string elementName, string ns)
		{
			foreach (object obj in this._itemInfo)
			{
				XmlTypeMapElementInfo xmlTypeMapElementInfo = (XmlTypeMapElementInfo)obj;
				if (xmlTypeMapElementInfo.ElementName == elementName && xmlTypeMapElementInfo.Namespace == ns)
				{
					return xmlTypeMapElementInfo;
				}
			}
			return null;
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x0006EFD4 File Offset: 0x0006D1D4
		public XmlTypeMapElementInfo FindTextElement()
		{
			foreach (object obj in this._itemInfo)
			{
				XmlTypeMapElementInfo xmlTypeMapElementInfo = (XmlTypeMapElementInfo)obj;
				if (xmlTypeMapElementInfo.IsTextElement)
				{
					return xmlTypeMapElementInfo;
				}
			}
			return null;
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x0006F038 File Offset: 0x0006D238
		public void GetArrayType(int itemCount, out string localName, out string ns)
		{
			string str;
			if (itemCount != -1)
			{
				str = "[" + itemCount.ToString() + "]";
			}
			else
			{
				str = "[]";
			}
			XmlTypeMapElementInfo xmlTypeMapElementInfo = (XmlTypeMapElementInfo)this._itemInfo[0];
			if (xmlTypeMapElementInfo.TypeData.SchemaType == SchemaTypes.Array)
			{
				string str2;
				((ListMap)xmlTypeMapElementInfo.MappedType.ObjectMap).GetArrayType(-1, out str2, out ns);
				localName = str2 + str;
				return;
			}
			if (xmlTypeMapElementInfo.MappedType != null)
			{
				localName = xmlTypeMapElementInfo.MappedType.XmlType + str;
				ns = xmlTypeMapElementInfo.MappedType.Namespace;
				return;
			}
			localName = xmlTypeMapElementInfo.TypeData.XmlType + str;
			ns = xmlTypeMapElementInfo.DataTypeNamespace;
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x0006F0F0 File Offset: 0x0006D2F0
		public override bool Equals(object other)
		{
			ListMap listMap = other as ListMap;
			if (listMap == null)
			{
				return false;
			}
			if (this._itemInfo.Count != listMap._itemInfo.Count)
			{
				return false;
			}
			for (int i = 0; i < this._itemInfo.Count; i++)
			{
				if (!this._itemInfo[i].Equals(listMap._itemInfo[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x0006DA5C File Offset: 0x0006BC5C
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x04000C28 RID: 3112
		private XmlTypeMapElementInfoList _itemInfo;

		// Token: 0x04000C29 RID: 3113
		private string _choiceMember;
	}
}
