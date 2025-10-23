using System;
using System.Collections;

namespace System.Xml.Serialization
{
	// Token: 0x0200021A RID: 538
	internal class ClassMap : ObjectMap
	{
		// Token: 0x060011C3 RID: 4547 RVA: 0x0006E690 File Offset: 0x0006C890
		public void AddMember(XmlTypeMapMember member)
		{
			if (member.GlobalIndex == -1)
			{
				member.GlobalIndex = this._allMembers.Count;
			}
			this._allMembers.Add(member);
			if (!(member.DefaultValue is DBNull) && member.DefaultValue != null)
			{
				if (this._membersWithDefault == null)
				{
					this._membersWithDefault = new ArrayList();
				}
				this._membersWithDefault.Add(member);
			}
			if (member.IsReturnValue)
			{
				this._returnMember = member;
			}
			if (!(member is XmlTypeMapMemberAttribute))
			{
				if (member is XmlTypeMapMemberFlatList)
				{
					this.RegisterFlatList((XmlTypeMapMemberFlatList)member);
				}
				else if (member is XmlTypeMapMemberAnyElement)
				{
					XmlTypeMapMemberAnyElement xmlTypeMapMemberAnyElement = (XmlTypeMapMemberAnyElement)member;
					if (xmlTypeMapMemberAnyElement.IsDefaultAny)
					{
						this._defaultAnyElement = xmlTypeMapMemberAnyElement;
					}
					if (xmlTypeMapMemberAnyElement.TypeData.IsListType)
					{
						this.RegisterFlatList(xmlTypeMapMemberAnyElement);
					}
				}
				else
				{
					if (member is XmlTypeMapMemberAnyAttribute)
					{
						this._defaultAnyAttribute = (XmlTypeMapMemberAnyAttribute)member;
						return;
					}
					if (member is XmlTypeMapMemberNamespaces)
					{
						this._namespaceDeclarations = (XmlTypeMapMemberNamespaces)member;
						return;
					}
				}
				if (member is XmlTypeMapMemberElement && ((XmlTypeMapMemberElement)member).IsXmlTextCollector)
				{
					if (this._xmlTextCollector != null)
					{
						throw new InvalidOperationException("XmlTextAttribute can only be applied once in a class");
					}
					this._xmlTextCollector = member;
				}
				if (this._elementMembers == null)
				{
					this._elementMembers = new ArrayList();
					this._elements = new Hashtable();
				}
				member.Index = this._elementMembers.Count;
				this._elementMembers.Add(member);
				foreach (object obj in ((IEnumerable)((XmlTypeMapMemberElement)member).ElementInfo))
				{
					XmlTypeMapElementInfo xmlTypeMapElementInfo = (XmlTypeMapElementInfo)obj;
					string key = this.BuildKey(xmlTypeMapElementInfo.ElementName, xmlTypeMapElementInfo.Namespace, xmlTypeMapElementInfo.ExplicitOrder);
					if (this._elements.ContainsKey(key))
					{
						throw new InvalidOperationException(string.Concat(new string[]
						{
							"The XML element named '",
							xmlTypeMapElementInfo.ElementName,
							"' from namespace '",
							xmlTypeMapElementInfo.Namespace,
							"' is already present in the current scope. Use XML attributes to specify another XML name or namespace for the element."
						}));
					}
					this._elements.Add(key, xmlTypeMapElementInfo);
				}
				if (member.TypeData.IsListType && member.TypeData.Type != null && !member.TypeData.Type.IsArray)
				{
					if (this._listMembers == null)
					{
						this._listMembers = new ArrayList();
					}
					this._listMembers.Add(member);
				}
				return;
			}
			XmlTypeMapMemberAttribute xmlTypeMapMemberAttribute = (XmlTypeMapMemberAttribute)member;
			if (this._attributeMembers == null)
			{
				this._attributeMembers = new Hashtable();
			}
			string key2 = this.BuildKey(xmlTypeMapMemberAttribute.AttributeName, xmlTypeMapMemberAttribute.Namespace, -1);
			if (this._attributeMembers.ContainsKey(key2))
			{
				throw new InvalidOperationException(string.Concat(new string[]
				{
					"The XML attribute named '",
					xmlTypeMapMemberAttribute.AttributeName,
					"' from namespace '",
					xmlTypeMapMemberAttribute.Namespace,
					"' is already present in the current scope. Use XML attributes to specify another XML name or namespace for the attribute."
				}));
			}
			member.Index = this._attributeMembers.Count;
			this._attributeMembers.Add(key2, member);
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x0006E9A8 File Offset: 0x0006CBA8
		private void RegisterFlatList(XmlTypeMapMemberExpandable member)
		{
			if (this._flatLists == null)
			{
				this._flatLists = new ArrayList();
			}
			member.FlatArrayIndex = this._flatLists.Count;
			this._flatLists.Add(member);
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x0006E9DB File Offset: 0x0006CBDB
		public XmlTypeMapMemberAttribute GetAttribute(string name, string ns)
		{
			if (this._attributeMembers == null)
			{
				return null;
			}
			return (XmlTypeMapMemberAttribute)this._attributeMembers[this.BuildKey(name, ns, -1)];
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x0006EA00 File Offset: 0x0006CC00
		public XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder)
		{
			if (this._elements == null)
			{
				return null;
			}
			XmlTypeMapElementInfo xmlTypeMapElementInfo = null;
			foreach (object obj in this._elements.Values)
			{
				XmlTypeMapElementInfo xmlTypeMapElementInfo2 = (XmlTypeMapElementInfo)obj;
				if (xmlTypeMapElementInfo2.ElementName == name && xmlTypeMapElementInfo2.Namespace == ns && xmlTypeMapElementInfo2.ExplicitOrder >= minimalOrder && (xmlTypeMapElementInfo == null || xmlTypeMapElementInfo.ExplicitOrder > xmlTypeMapElementInfo2.ExplicitOrder))
				{
					xmlTypeMapElementInfo = xmlTypeMapElementInfo2;
				}
			}
			return xmlTypeMapElementInfo;
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x0006EA9C File Offset: 0x0006CC9C
		public XmlTypeMapElementInfo GetElement(string name, string ns)
		{
			if (this._elements == null)
			{
				return null;
			}
			foreach (object obj in this._elements.Values)
			{
				XmlTypeMapElementInfo xmlTypeMapElementInfo = (XmlTypeMapElementInfo)obj;
				if (xmlTypeMapElementInfo.ElementName == name && xmlTypeMapElementInfo.Namespace == ns)
				{
					return xmlTypeMapElementInfo;
				}
			}
			return null;
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x0006EB20 File Offset: 0x0006CD20
		private string BuildKey(string name, string ns, int explicitOrder)
		{
			if (this._ignoreMemberNamespace)
			{
				return name;
			}
			return name + " / " + ns + ((explicitOrder < 0) ? "" : ("/" + explicitOrder.ToString()));
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x060011C9 RID: 4553 RVA: 0x0006EB54 File Offset: 0x0006CD54
		public bool IsOrderDependentMap
		{
			get
			{
				if (this._isOrderDependentMap == null)
				{
					this._isOrderDependentMap = new bool?(false);
					using (IEnumerator enumerator = this._elements.Values.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (((XmlTypeMapElementInfo)enumerator.Current).ExplicitOrder >= 0)
							{
								this._isOrderDependentMap = new bool?(true);
								break;
							}
						}
					}
				}
				return this._isOrderDependentMap.Value;
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x060011CA RID: 4554 RVA: 0x0006EBE4 File Offset: 0x0006CDE4
		public XmlTypeMapMemberAnyElement DefaultAnyElementMember
		{
			get
			{
				return this._defaultAnyElement;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x060011CB RID: 4555 RVA: 0x0006EBEC File Offset: 0x0006CDEC
		public XmlTypeMapMemberAnyAttribute DefaultAnyAttributeMember
		{
			get
			{
				return this._defaultAnyAttribute;
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x060011CC RID: 4556 RVA: 0x0006EBF4 File Offset: 0x0006CDF4
		public XmlTypeMapMemberNamespaces NamespaceDeclarations
		{
			get
			{
				return this._namespaceDeclarations;
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x060011CD RID: 4557 RVA: 0x0006EBFC File Offset: 0x0006CDFC
		public ICollection AttributeMembers
		{
			get
			{
				if (this._attributeMembers == null)
				{
					return null;
				}
				if (this._attributeMembersArray != null)
				{
					return this._attributeMembersArray;
				}
				this._attributeMembersArray = new XmlTypeMapMemberAttribute[this._attributeMembers.Count];
				foreach (object obj in this._attributeMembers.Values)
				{
					XmlTypeMapMemberAttribute xmlTypeMapMemberAttribute = (XmlTypeMapMemberAttribute)obj;
					this._attributeMembersArray[xmlTypeMapMemberAttribute.Index] = xmlTypeMapMemberAttribute;
				}
				return this._attributeMembersArray;
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x0006EC98 File Offset: 0x0006CE98
		public ICollection ElementMembers
		{
			get
			{
				return this._elementMembers;
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x060011CF RID: 4559 RVA: 0x0006ECA0 File Offset: 0x0006CEA0
		public ArrayList AllMembers
		{
			get
			{
				return this._allMembers;
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x0006ECA8 File Offset: 0x0006CEA8
		public ArrayList FlatLists
		{
			get
			{
				return this._flatLists;
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x060011D1 RID: 4561 RVA: 0x0006ECB0 File Offset: 0x0006CEB0
		public ArrayList ListMembers
		{
			get
			{
				return this._listMembers;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x060011D2 RID: 4562 RVA: 0x0006ECB8 File Offset: 0x0006CEB8
		public XmlTypeMapMember XmlTextCollector
		{
			get
			{
				return this._xmlTextCollector;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x0006ECC0 File Offset: 0x0006CEC0
		public XmlTypeMapMember ReturnMember
		{
			get
			{
				return this._returnMember;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x0006ECC8 File Offset: 0x0006CEC8
		public XmlQualifiedName SimpleContentBaseType
		{
			get
			{
				if (!this._canBeSimpleType || this._elementMembers == null || this._elementMembers.Count != 1)
				{
					return null;
				}
				XmlTypeMapMemberElement xmlTypeMapMemberElement = (XmlTypeMapMemberElement)this._elementMembers[0];
				if (xmlTypeMapMemberElement.ElementInfo.Count != 1)
				{
					return null;
				}
				XmlTypeMapElementInfo xmlTypeMapElementInfo = (XmlTypeMapElementInfo)xmlTypeMapMemberElement.ElementInfo[0];
				if (!xmlTypeMapElementInfo.IsTextElement)
				{
					return null;
				}
				if (xmlTypeMapMemberElement.TypeData.SchemaType == SchemaTypes.Primitive || xmlTypeMapMemberElement.TypeData.SchemaType == SchemaTypes.Enum)
				{
					return new XmlQualifiedName(xmlTypeMapElementInfo.TypeData.XmlType, xmlTypeMapElementInfo.DataTypeNamespace);
				}
				return null;
			}
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x0006ED67 File Offset: 0x0006CF67
		public void SetCanBeSimpleType(bool can)
		{
			this._canBeSimpleType = can;
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x0006ED70 File Offset: 0x0006CF70
		public bool HasSimpleContent
		{
			get
			{
				return this.SimpleContentBaseType != null;
			}
		}

		// Token: 0x04000C18 RID: 3096
		private Hashtable _elements = new Hashtable();

		// Token: 0x04000C19 RID: 3097
		private ArrayList _elementMembers;

		// Token: 0x04000C1A RID: 3098
		private Hashtable _attributeMembers;

		// Token: 0x04000C1B RID: 3099
		private XmlTypeMapMemberAttribute[] _attributeMembersArray;

		// Token: 0x04000C1C RID: 3100
		private ArrayList _flatLists;

		// Token: 0x04000C1D RID: 3101
		private ArrayList _allMembers = new ArrayList();

		// Token: 0x04000C1E RID: 3102
		private ArrayList _membersWithDefault;

		// Token: 0x04000C1F RID: 3103
		private ArrayList _listMembers;

		// Token: 0x04000C20 RID: 3104
		private XmlTypeMapMemberAnyElement _defaultAnyElement;

		// Token: 0x04000C21 RID: 3105
		private XmlTypeMapMemberAnyAttribute _defaultAnyAttribute;

		// Token: 0x04000C22 RID: 3106
		private XmlTypeMapMemberNamespaces _namespaceDeclarations;

		// Token: 0x04000C23 RID: 3107
		private XmlTypeMapMember _xmlTextCollector;

		// Token: 0x04000C24 RID: 3108
		private XmlTypeMapMember _returnMember;

		// Token: 0x04000C25 RID: 3109
		private bool _ignoreMemberNamespace;

		// Token: 0x04000C26 RID: 3110
		private bool _canBeSimpleType = true;

		// Token: 0x04000C27 RID: 3111
		private bool? _isOrderDependentMap;
	}
}
