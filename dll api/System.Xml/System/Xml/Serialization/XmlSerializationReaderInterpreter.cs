using System;
using System.Collections;
using System.Reflection;

namespace System.Xml.Serialization
{
	// Token: 0x020001FF RID: 511
	internal class XmlSerializationReaderInterpreter : XmlSerializationReader
	{
		// Token: 0x060010B9 RID: 4281 RVA: 0x00069672 File Offset: 0x00067872
		public XmlSerializationReaderInterpreter(XmlMapping typeMap)
		{
			this._typeMap = typeMap;
			this._format = typeMap.Format;
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x00069690 File Offset: 0x00067890
		protected override void InitCallbacks()
		{
			ArrayList relatedMaps = this._typeMap.RelatedMaps;
			if (relatedMaps != null)
			{
				foreach (object obj in relatedMaps)
				{
					XmlTypeMapping xmlTypeMapping = (XmlTypeMapping)obj;
					if (xmlTypeMapping.TypeData.SchemaType == SchemaTypes.Class || xmlTypeMapping.TypeData.SchemaType == SchemaTypes.Enum)
					{
						XmlSerializationReaderInterpreter.ReaderCallbackInfo @object = new XmlSerializationReaderInterpreter.ReaderCallbackInfo(this, xmlTypeMapping);
						base.AddReadCallback(xmlTypeMapping.XmlType, xmlTypeMapping.Namespace, xmlTypeMapping.TypeData.Type, new XmlSerializationReadCallback(@object.ReadObject));
					}
				}
			}
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x00008574 File Offset: 0x00006774
		protected override void InitIDs()
		{
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x00069740 File Offset: 0x00067940
		public object ReadRoot()
		{
			base.Reader.MoveToContent();
			if (!(this._typeMap is XmlTypeMapping))
			{
				return this.ReadMessage((XmlMembersMapping)this._typeMap);
			}
			if (this._format == SerializationFormat.Literal)
			{
				return this.ReadRoot((XmlTypeMapping)this._typeMap);
			}
			return this.ReadEncodedObject((XmlTypeMapping)this._typeMap);
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x000697A4 File Offset: 0x000679A4
		private object ReadEncodedObject(XmlTypeMapping typeMap)
		{
			object result = null;
			base.Reader.MoveToContent();
			if (base.Reader.NodeType == XmlNodeType.Element)
			{
				if (!(base.Reader.LocalName == typeMap.ElementName) || !(base.Reader.NamespaceURI == typeMap.Namespace))
				{
					throw base.CreateUnknownNodeException();
				}
				result = base.ReadReferencedElement();
			}
			else
			{
				base.UnknownNode(null);
			}
			base.ReadReferencedElements();
			return result;
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x0006981C File Offset: 0x00067A1C
		protected virtual object ReadMessage(XmlMembersMapping typeMap)
		{
			object[] array = new object[typeMap.Count];
			if (typeMap.HasWrapperElement)
			{
				ArrayList allMembers = ((ClassMap)typeMap.ObjectMap).AllMembers;
				for (int i = 0; i < allMembers.Count; i++)
				{
					XmlTypeMapMember xmlTypeMapMember = (XmlTypeMapMember)allMembers[i];
					if (!xmlTypeMapMember.IsReturnValue && xmlTypeMapMember.TypeData.IsValueType)
					{
						this.SetMemberValueFromAttr(xmlTypeMapMember, array, this.CreateInstance(xmlTypeMapMember.TypeData.Type), true);
					}
				}
				if (this._format == SerializationFormat.Encoded)
				{
					while (base.Reader.NodeType == XmlNodeType.Element)
					{
						string attribute = base.Reader.GetAttribute("root", "http://schemas.xmlsoap.org/soap/encoding/");
						if (attribute == null || XmlConvert.ToBoolean(attribute))
						{
							break;
						}
						base.ReadReferencedElement();
						base.Reader.MoveToContent();
					}
				}
				while (base.Reader.NodeType != XmlNodeType.EndElement)
				{
					if (base.Reader.ReadState != ReadState.Interactive)
					{
						break;
					}
					if (base.Reader.IsStartElement(typeMap.ElementName, typeMap.Namespace) || this._format == SerializationFormat.Encoded)
					{
						this.ReadAttributeMembers((ClassMap)typeMap.ObjectMap, array, true);
						if (!base.Reader.IsEmptyElement)
						{
							base.Reader.ReadStartElement();
							this.ReadMembers((ClassMap)typeMap.ObjectMap, array, true, false);
							base.ReadEndElement();
							break;
						}
						base.Reader.Skip();
						base.Reader.MoveToContent();
					}
					else
					{
						base.UnknownNode(null);
						base.Reader.MoveToContent();
					}
				}
			}
			else
			{
				this.ReadMembers((ClassMap)typeMap.ObjectMap, array, true, this._format == SerializationFormat.Encoded);
			}
			if (this._format == SerializationFormat.Encoded)
			{
				base.ReadReferencedElements();
			}
			return array;
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x000699DC File Offset: 0x00067BDC
		private object ReadRoot(XmlTypeMapping rootMap)
		{
			if (rootMap.TypeData.SchemaType == SchemaTypes.XmlNode)
			{
				return this.ReadXmlNodeElement(rootMap, true);
			}
			if (!rootMap.IsAny && (base.Reader.LocalName != rootMap.ElementName || base.Reader.NamespaceURI != rootMap.Namespace))
			{
				throw base.CreateUnknownNodeException();
			}
			return this.ReadObject(rootMap, rootMap.IsNullable, true);
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x00069A50 File Offset: 0x00067C50
		protected virtual object ReadObject(XmlTypeMapping typeMap, bool isNullable, bool checkType)
		{
			switch (typeMap.TypeData.SchemaType)
			{
			case SchemaTypes.Primitive:
				return this.ReadPrimitiveElement(typeMap, isNullable);
			case SchemaTypes.Enum:
				return this.ReadEnumElement(typeMap, isNullable);
			case SchemaTypes.Array:
				return this.ReadListElement(typeMap, isNullable, null, true);
			case SchemaTypes.Class:
				return this.ReadClassInstance(typeMap, isNullable, checkType);
			case SchemaTypes.XmlSerializable:
				return this.ReadXmlSerializableElement(typeMap, isNullable);
			case SchemaTypes.XmlNode:
				return this.ReadXmlNodeElement(typeMap, isNullable);
			default:
				throw new Exception("Unsupported map type");
			}
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x00069AD0 File Offset: 0x00067CD0
		protected virtual object ReadClassInstance(XmlTypeMapping typeMap, bool isNullable, bool checkType)
		{
			if (isNullable && base.ReadNull())
			{
				return null;
			}
			if (checkType)
			{
				XmlQualifiedName xsiType = base.GetXsiType();
				if (xsiType != null)
				{
					XmlTypeMapping realElementMap = typeMap.GetRealElementMap(xsiType.Name, xsiType.Namespace);
					if (realElementMap == null)
					{
						if (typeMap.TypeData.Type == typeof(object))
						{
							return base.ReadTypedPrimitive(xsiType);
						}
						throw base.CreateUnknownTypeException(xsiType);
					}
					else if (realElementMap != typeMap)
					{
						return this.ReadObject(realElementMap, false, false);
					}
				}
				else if (typeMap.TypeData.Type == typeof(object))
				{
					return base.ReadTypedPrimitive(XmlSerializationReaderInterpreter.AnyType);
				}
			}
			object obj = XmlSerializationReaderInterpreter.CreateInstance(typeMap.TypeData.Type, true);
			base.Reader.MoveToElement();
			bool isEmptyElement = base.Reader.IsEmptyElement;
			this.ReadClassInstanceMembers(typeMap, obj);
			if (isEmptyElement)
			{
				base.Reader.Skip();
			}
			else
			{
				base.ReadEndElement();
			}
			return obj;
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x00069BBF File Offset: 0x00067DBF
		protected virtual void ReadClassInstanceMembers(XmlTypeMapping typeMap, object ob)
		{
			this.ReadMembers((ClassMap)typeMap.ObjectMap, ob, false, false);
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x00069BD8 File Offset: 0x00067DD8
		private void ReadAttributeMembers(ClassMap map, object ob, bool isValueList)
		{
			XmlTypeMapMember defaultAnyAttributeMember = map.DefaultAnyAttributeMember;
			int length = 0;
			object obj = null;
			while (base.Reader.MoveToNextAttribute())
			{
				XmlTypeMapMemberAttribute attribute = map.GetAttribute(base.Reader.LocalName, base.Reader.NamespaceURI);
				if (attribute != null)
				{
					this.SetMemberValue(attribute, ob, this.GetValueFromXmlString(base.Reader.Value, attribute.TypeData, attribute.MappedType), isValueList);
				}
				else if (base.IsXmlnsAttribute(base.Reader.Name))
				{
					if (map.NamespaceDeclarations != null)
					{
						XmlSerializerNamespaces xmlSerializerNamespaces = this.GetMemberValue(map.NamespaceDeclarations, ob, isValueList) as XmlSerializerNamespaces;
						if (xmlSerializerNamespaces == null)
						{
							xmlSerializerNamespaces = new XmlSerializerNamespaces();
							this.SetMemberValue(map.NamespaceDeclarations, ob, xmlSerializerNamespaces, isValueList);
						}
						if (base.Reader.Prefix == "xmlns")
						{
							xmlSerializerNamespaces.Add(base.Reader.LocalName, base.Reader.Value);
						}
						else
						{
							xmlSerializerNamespaces.Add("", base.Reader.Value);
						}
					}
				}
				else if (defaultAnyAttributeMember != null)
				{
					XmlAttribute xmlAttribute = (XmlAttribute)base.Document.ReadNode(base.Reader);
					base.ParseWsdlArrayType(xmlAttribute);
					this.AddListValue(defaultAnyAttributeMember.TypeData, ref obj, length++, xmlAttribute, true);
				}
				else
				{
					this.ProcessUnknownAttribute(ob);
				}
			}
			if (defaultAnyAttributeMember != null)
			{
				obj = base.ShrinkArray((Array)obj, length, defaultAnyAttributeMember.TypeData.Type.GetElementType(), true);
				this.SetMemberValue(defaultAnyAttributeMember, ob, obj, isValueList);
			}
			base.Reader.MoveToElement();
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x00069D6C File Offset: 0x00067F6C
		private void ReadMembers(ClassMap map, object ob, bool isValueList, bool readBySoapOrder)
		{
			this.ReadAttributeMembers(map, ob, isValueList);
			if (!isValueList)
			{
				base.Reader.MoveToElement();
				if (base.Reader.IsEmptyElement)
				{
					this.SetListMembersDefaults(map, ob, isValueList);
					return;
				}
				base.Reader.ReadStartElement();
			}
			bool[] array = new bool[(map.ElementMembers != null) ? map.ElementMembers.Count : 0];
			bool flag = isValueList && this._format == SerializationFormat.Encoded && map.ReturnMember != null;
			base.Reader.MoveToContent();
			int[] array2 = null;
			object[] array3 = null;
			object[] array4 = null;
			XmlSerializationReader.Fixup fixup = null;
			int num = -1;
			int num2;
			if (readBySoapOrder)
			{
				if (map.ElementMembers != null)
				{
					num2 = map.ElementMembers.Count;
				}
				else
				{
					num2 = -1;
				}
			}
			else
			{
				num2 = int.MaxValue;
			}
			if (map.FlatLists != null)
			{
				array2 = new int[map.FlatLists.Count];
				array3 = new object[map.FlatLists.Count];
				foreach (object obj in map.FlatLists)
				{
					XmlTypeMapMemberExpandable xmlTypeMapMemberExpandable = (XmlTypeMapMemberExpandable)obj;
					if (this.IsReadOnly(xmlTypeMapMemberExpandable, xmlTypeMapMemberExpandable.TypeData, ob, isValueList))
					{
						array3[xmlTypeMapMemberExpandable.FlatArrayIndex] = xmlTypeMapMemberExpandable.GetValue(ob);
					}
					else if (xmlTypeMapMemberExpandable.TypeData.Type.IsArray)
					{
						array3[xmlTypeMapMemberExpandable.FlatArrayIndex] = this.InitializeList(xmlTypeMapMemberExpandable.TypeData);
					}
					else
					{
						object obj2 = xmlTypeMapMemberExpandable.GetValue(ob);
						if (obj2 == null)
						{
							obj2 = this.InitializeList(xmlTypeMapMemberExpandable.TypeData);
							this.SetMemberValue(xmlTypeMapMemberExpandable, ob, obj2, isValueList);
						}
						array3[xmlTypeMapMemberExpandable.FlatArrayIndex] = obj2;
					}
					if (xmlTypeMapMemberExpandable.ChoiceMember != null)
					{
						if (array4 == null)
						{
							array4 = new object[map.FlatLists.Count];
						}
						array4[xmlTypeMapMemberExpandable.FlatArrayIndex] = this.InitializeList(xmlTypeMapMemberExpandable.ChoiceTypeData);
					}
				}
			}
			if (this._format == SerializationFormat.Encoded && map.ElementMembers != null)
			{
				XmlSerializationReaderInterpreter.FixupCallbackInfo @object = new XmlSerializationReaderInterpreter.FixupCallbackInfo(this, map, isValueList);
				fixup = new XmlSerializationReader.Fixup(ob, new XmlSerializationFixupCallback(@object.FixupMembers), map.ElementMembers.Count);
				base.AddFixup(fixup);
			}
			XmlTypeMapMember xmlTypeMapMember = null;
			while (base.Reader.NodeType != XmlNodeType.EndElement && num < num2 - 1)
			{
				if (base.Reader.NodeType == XmlNodeType.Element)
				{
					XmlTypeMapElementInfo xmlTypeMapElementInfo;
					if (readBySoapOrder)
					{
						xmlTypeMapElementInfo = map.GetElement(base.Reader.LocalName, base.Reader.NamespaceURI, num);
					}
					else if (flag)
					{
						xmlTypeMapElementInfo = (XmlTypeMapElementInfo)((XmlTypeMapMemberElement)map.ReturnMember).ElementInfo[0];
						flag = false;
					}
					else if (map.IsOrderDependentMap)
					{
						xmlTypeMapElementInfo = map.GetElement(base.Reader.LocalName, base.Reader.NamespaceURI, num);
					}
					else
					{
						xmlTypeMapElementInfo = map.GetElement(base.Reader.LocalName, base.Reader.NamespaceURI);
					}
					if (xmlTypeMapElementInfo != null && !array[xmlTypeMapElementInfo.Member.Index])
					{
						if (xmlTypeMapElementInfo.Member != xmlTypeMapMember)
						{
							num = xmlTypeMapElementInfo.ExplicitOrder + 1;
							if (xmlTypeMapElementInfo.Member is XmlTypeMapMemberFlatList)
							{
								num--;
							}
							xmlTypeMapMember = xmlTypeMapElementInfo.Member;
						}
						if (xmlTypeMapElementInfo.Member.GetType() == typeof(XmlTypeMapMemberList))
						{
							if (this._format == SerializationFormat.Encoded && xmlTypeMapElementInfo.MultiReferenceType)
							{
								object obj3 = base.ReadReferencingElement(out fixup.Ids[xmlTypeMapElementInfo.Member.Index]);
								if (fixup.Ids[xmlTypeMapElementInfo.Member.Index] == null)
								{
									if (this.IsReadOnly(xmlTypeMapElementInfo.Member, xmlTypeMapElementInfo.TypeData, ob, isValueList))
									{
										throw base.CreateReadOnlyCollectionException(xmlTypeMapElementInfo.TypeData.FullTypeName);
									}
									this.SetMemberValue(xmlTypeMapElementInfo.Member, ob, obj3, isValueList);
								}
								else if (!xmlTypeMapElementInfo.MappedType.TypeData.Type.IsArray)
								{
									if (this.IsReadOnly(xmlTypeMapElementInfo.Member, xmlTypeMapElementInfo.TypeData, ob, isValueList))
									{
										obj3 = this.GetMemberValue(xmlTypeMapElementInfo.Member, ob, isValueList);
									}
									else
									{
										obj3 = this.CreateList(xmlTypeMapElementInfo.MappedType.TypeData.Type);
										this.SetMemberValue(xmlTypeMapElementInfo.Member, ob, obj3, isValueList);
									}
									base.AddFixup(new XmlSerializationReader.CollectionFixup(obj3, new XmlSerializationCollectionFixupCallback(this.FillList), fixup.Ids[xmlTypeMapElementInfo.Member.Index]));
									fixup.Ids[xmlTypeMapElementInfo.Member.Index] = null;
								}
							}
							else if (this.IsReadOnly(xmlTypeMapElementInfo.Member, xmlTypeMapElementInfo.TypeData, ob, isValueList))
							{
								this.ReadListElement(xmlTypeMapElementInfo.MappedType, xmlTypeMapElementInfo.IsNullable, this.GetMemberValue(xmlTypeMapElementInfo.Member, ob, isValueList), false);
							}
							else if (xmlTypeMapElementInfo.MappedType.TypeData.Type.IsArray)
							{
								object obj4 = this.ReadListElement(xmlTypeMapElementInfo.MappedType, xmlTypeMapElementInfo.IsNullable, null, true);
								if (obj4 != null || xmlTypeMapElementInfo.IsNullable)
								{
									this.SetMemberValue(xmlTypeMapElementInfo.Member, ob, obj4, isValueList);
								}
							}
							else
							{
								object obj5 = this.GetMemberValue(xmlTypeMapElementInfo.Member, ob, isValueList);
								if (obj5 == null)
								{
									obj5 = this.CreateList(xmlTypeMapElementInfo.MappedType.TypeData.Type);
									this.SetMemberValue(xmlTypeMapElementInfo.Member, ob, obj5, isValueList);
								}
								this.ReadListElement(xmlTypeMapElementInfo.MappedType, xmlTypeMapElementInfo.IsNullable, obj5, true);
							}
							array[xmlTypeMapElementInfo.Member.Index] = true;
						}
						else if (xmlTypeMapElementInfo.Member.GetType() == typeof(XmlTypeMapMemberFlatList))
						{
							XmlTypeMapMemberFlatList xmlTypeMapMemberFlatList = (XmlTypeMapMemberFlatList)xmlTypeMapElementInfo.Member;
							TypeData typeData = xmlTypeMapMemberFlatList.TypeData;
							object[] array5 = array3;
							int flatArrayIndex = xmlTypeMapMemberFlatList.FlatArrayIndex;
							int[] array6 = array2;
							int flatArrayIndex2 = xmlTypeMapMemberFlatList.FlatArrayIndex;
							int num3 = array6[flatArrayIndex2];
							array6[flatArrayIndex2] = num3 + 1;
							this.AddListValue(typeData, ref array5[flatArrayIndex], num3, this.ReadObjectElement(xmlTypeMapElementInfo), !this.IsReadOnly(xmlTypeMapElementInfo.Member, xmlTypeMapElementInfo.TypeData, ob, isValueList));
							if (xmlTypeMapMemberFlatList.ChoiceMember != null)
							{
								this.AddListValue(xmlTypeMapMemberFlatList.ChoiceTypeData, ref array4[xmlTypeMapMemberFlatList.FlatArrayIndex], array2[xmlTypeMapMemberFlatList.FlatArrayIndex] - 1, xmlTypeMapElementInfo.ChoiceValue, true);
							}
						}
						else if (xmlTypeMapElementInfo.Member.GetType() == typeof(XmlTypeMapMemberAnyElement))
						{
							XmlTypeMapMemberAnyElement xmlTypeMapMemberAnyElement = (XmlTypeMapMemberAnyElement)xmlTypeMapElementInfo.Member;
							if (xmlTypeMapMemberAnyElement.TypeData.IsListType)
							{
								TypeData typeData2 = xmlTypeMapMemberAnyElement.TypeData;
								object[] array7 = array3;
								int flatArrayIndex3 = xmlTypeMapMemberAnyElement.FlatArrayIndex;
								int[] array8 = array2;
								int flatArrayIndex4 = xmlTypeMapMemberAnyElement.FlatArrayIndex;
								int num3 = array8[flatArrayIndex4];
								array8[flatArrayIndex4] = num3 + 1;
								this.AddListValue(typeData2, ref array7[flatArrayIndex3], num3, this.ReadXmlNode(xmlTypeMapMemberAnyElement.TypeData.ListItemTypeData, false), true);
							}
							else
							{
								this.SetMemberValue(xmlTypeMapMemberAnyElement, ob, this.ReadXmlNode(xmlTypeMapMemberAnyElement.TypeData, false), isValueList);
							}
						}
						else
						{
							if (!(xmlTypeMapElementInfo.Member.GetType() == typeof(XmlTypeMapMemberElement)))
							{
								throw new InvalidOperationException("Unknown member type");
							}
							array[xmlTypeMapElementInfo.Member.Index] = true;
							if (this._format == SerializationFormat.Encoded)
							{
								object obj6;
								if (xmlTypeMapElementInfo.Member.TypeData.SchemaType != SchemaTypes.Primitive)
								{
									obj6 = base.ReadReferencingElement(out fixup.Ids[xmlTypeMapElementInfo.Member.Index]);
								}
								else
								{
									obj6 = base.ReadReferencingElement(xmlTypeMapElementInfo.Member.TypeData.XmlType, "http://www.w3.org/2001/XMLSchema", out fixup.Ids[xmlTypeMapElementInfo.Member.Index]);
								}
								if (xmlTypeMapElementInfo.MultiReferenceType)
								{
									if (fixup.Ids[xmlTypeMapElementInfo.Member.Index] == null)
									{
										this.SetMemberValue(xmlTypeMapElementInfo.Member, ob, obj6, isValueList);
									}
								}
								else if (obj6 != null)
								{
									this.SetMemberValue(xmlTypeMapElementInfo.Member, ob, obj6, isValueList);
								}
							}
							else
							{
								this.SetMemberValue(xmlTypeMapElementInfo.Member, ob, this.ReadObjectElement(xmlTypeMapElementInfo), isValueList);
								if (xmlTypeMapElementInfo.ChoiceValue != null)
								{
									((XmlTypeMapMemberElement)xmlTypeMapElementInfo.Member).SetChoice(ob, xmlTypeMapElementInfo.ChoiceValue);
								}
							}
						}
					}
					else if (map.DefaultAnyElementMember != null)
					{
						XmlTypeMapMemberAnyElement defaultAnyElementMember = map.DefaultAnyElementMember;
						if (defaultAnyElementMember.TypeData.IsListType)
						{
							TypeData typeData3 = defaultAnyElementMember.TypeData;
							object[] array9 = array3;
							int flatArrayIndex5 = defaultAnyElementMember.FlatArrayIndex;
							int[] array10 = array2;
							int flatArrayIndex6 = defaultAnyElementMember.FlatArrayIndex;
							int num3 = array10[flatArrayIndex6];
							array10[flatArrayIndex6] = num3 + 1;
							this.AddListValue(typeData3, ref array9[flatArrayIndex5], num3, this.ReadXmlNode(defaultAnyElementMember.TypeData.ListItemTypeData, false), true);
						}
						else
						{
							this.SetMemberValue(defaultAnyElementMember, ob, this.ReadXmlNode(defaultAnyElementMember.TypeData, false), isValueList);
						}
					}
					else
					{
						this.ProcessUnknownElement(ob);
					}
				}
				else if ((base.Reader.NodeType == XmlNodeType.Text || base.Reader.NodeType == XmlNodeType.CDATA) && map.XmlTextCollector != null)
				{
					if (map.XmlTextCollector is XmlTypeMapMemberExpandable)
					{
						XmlTypeMapMemberExpandable xmlTypeMapMemberExpandable2 = (XmlTypeMapMemberExpandable)map.XmlTextCollector;
						XmlTypeMapMemberFlatList xmlTypeMapMemberFlatList2 = xmlTypeMapMemberExpandable2 as XmlTypeMapMemberFlatList;
						TypeData typeData4 = (xmlTypeMapMemberFlatList2 == null) ? xmlTypeMapMemberExpandable2.TypeData.ListItemTypeData : xmlTypeMapMemberFlatList2.ListMap.FindTextElement().TypeData;
						object value = (typeData4.Type == typeof(string)) ? base.Reader.ReadString() : this.ReadXmlNode(typeData4, false);
						TypeData typeData5 = xmlTypeMapMemberExpandable2.TypeData;
						object[] array11 = array3;
						int flatArrayIndex7 = xmlTypeMapMemberExpandable2.FlatArrayIndex;
						int[] array12 = array2;
						int flatArrayIndex8 = xmlTypeMapMemberExpandable2.FlatArrayIndex;
						int num3 = array12[flatArrayIndex8];
						array12[flatArrayIndex8] = num3 + 1;
						this.AddListValue(typeData5, ref array11[flatArrayIndex7], num3, value, true);
					}
					else
					{
						XmlTypeMapMemberElement xmlTypeMapMemberElement = (XmlTypeMapMemberElement)map.XmlTextCollector;
						XmlTypeMapElementInfo xmlTypeMapElementInfo2 = (XmlTypeMapElementInfo)xmlTypeMapMemberElement.ElementInfo[0];
						if (xmlTypeMapElementInfo2.TypeData.Type == typeof(string))
						{
							this.SetMemberValue(xmlTypeMapMemberElement, ob, base.Reader.ReadString(), isValueList);
						}
						else
						{
							this.SetMemberValue(xmlTypeMapMemberElement, ob, this.GetValueFromXmlString(base.Reader.ReadString(), xmlTypeMapElementInfo2.TypeData, xmlTypeMapElementInfo2.MappedType), isValueList);
						}
					}
				}
				else
				{
					base.UnknownNode(ob);
				}
				base.Reader.MoveToContent();
			}
			if (array3 != null)
			{
				foreach (object obj7 in map.FlatLists)
				{
					XmlTypeMapMemberExpandable xmlTypeMapMemberExpandable3 = (XmlTypeMapMemberExpandable)obj7;
					object obj8 = array3[xmlTypeMapMemberExpandable3.FlatArrayIndex];
					if (xmlTypeMapMemberExpandable3.TypeData.Type.IsArray)
					{
						obj8 = base.ShrinkArray((Array)obj8, array2[xmlTypeMapMemberExpandable3.FlatArrayIndex], xmlTypeMapMemberExpandable3.TypeData.Type.GetElementType(), true);
					}
					if (!this.IsReadOnly(xmlTypeMapMemberExpandable3, xmlTypeMapMemberExpandable3.TypeData, ob, isValueList) && xmlTypeMapMemberExpandable3.TypeData.Type.IsArray)
					{
						this.SetMemberValue(xmlTypeMapMemberExpandable3, ob, obj8, isValueList);
					}
				}
			}
			if (array4 != null)
			{
				foreach (object obj9 in map.FlatLists)
				{
					XmlTypeMapMemberExpandable xmlTypeMapMemberExpandable4 = (XmlTypeMapMemberExpandable)obj9;
					object obj10 = array4[xmlTypeMapMemberExpandable4.FlatArrayIndex];
					if (obj10 != null)
					{
						obj10 = base.ShrinkArray((Array)obj10, array2[xmlTypeMapMemberExpandable4.FlatArrayIndex], xmlTypeMapMemberExpandable4.ChoiceTypeData.Type.GetElementType(), true);
						XmlTypeMapMember.SetValue(ob, xmlTypeMapMemberExpandable4.ChoiceMember, obj10);
					}
				}
			}
			this.SetListMembersDefaults(map, ob, isValueList);
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x0006A938 File Offset: 0x00068B38
		private void SetListMembersDefaults(ClassMap map, object ob, bool isValueList)
		{
			if (map.ListMembers != null)
			{
				ArrayList listMembers = map.ListMembers;
				for (int i = 0; i < listMembers.Count; i++)
				{
					XmlTypeMapMember xmlTypeMapMember = (XmlTypeMapMember)listMembers[i];
					if (!this.IsReadOnly(xmlTypeMapMember, xmlTypeMapMember.TypeData, ob, isValueList) && this.GetMemberValue(xmlTypeMapMember, ob, isValueList) == null)
					{
						this.SetMemberValue(xmlTypeMapMember, ob, this.InitializeList(xmlTypeMapMember.TypeData), isValueList);
					}
				}
			}
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x0006A9A4 File Offset: 0x00068BA4
		internal void FixupMembers(ClassMap map, object obfixup, bool isValueList)
		{
			XmlSerializationReader.Fixup fixup = (XmlSerializationReader.Fixup)obfixup;
			IEnumerable elementMembers = map.ElementMembers;
			string[] ids = fixup.Ids;
			foreach (object obj in elementMembers)
			{
				XmlTypeMapMember xmlTypeMapMember = (XmlTypeMapMember)obj;
				if (ids[xmlTypeMapMember.Index] != null)
				{
					this.SetMemberValue(xmlTypeMapMember, fixup.Source, base.GetTarget(ids[xmlTypeMapMember.Index]), isValueList);
				}
			}
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x0006AA30 File Offset: 0x00068C30
		protected virtual void ProcessUnknownAttribute(object target)
		{
			base.UnknownNode(target);
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x0006AA30 File Offset: 0x00068C30
		protected virtual void ProcessUnknownElement(object target)
		{
			base.UnknownNode(target);
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x0006AA39 File Offset: 0x00068C39
		private bool IsReadOnly(XmlTypeMapMember member, TypeData memType, object ob, bool isValueList)
		{
			if (isValueList)
			{
				return !memType.HasPublicConstructor;
			}
			return member.IsReadOnly(ob.GetType()) || !memType.HasPublicConstructor;
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x0006AA64 File Offset: 0x00068C64
		private void SetMemberValue(XmlTypeMapMember member, object ob, object value, bool isValueList)
		{
			Type type = member.TypeData.Type;
			if (value != null && !value.GetType().IsAssignableFrom(type))
			{
				value = XmlSerializationWriterInterpreter.ImplicitConvert(value, type);
			}
			if (isValueList)
			{
				((object[])ob)[member.GlobalIndex] = value;
			}
			else
			{
				member.SetValue(ob, value);
			}
			if (member.IsOptionalValueType)
			{
				member.SetValueSpecified(ob, true);
			}
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x0006AAC3 File Offset: 0x00068CC3
		private void SetMemberValueFromAttr(XmlTypeMapMember member, object ob, object value, bool isValueList)
		{
			if (member.TypeData.Type.IsEnum)
			{
				value = Enum.ToObject(member.TypeData.Type, value);
			}
			this.SetMemberValue(member, ob, value, isValueList);
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x0006AAF5 File Offset: 0x00068CF5
		private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList)
		{
			if (isValueList)
			{
				return ((object[])ob)[member.GlobalIndex];
			}
			return member.GetValue(ob);
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x0006AB10 File Offset: 0x00068D10
		private object ReadObjectElement(XmlTypeMapElementInfo elem)
		{
			switch (elem.TypeData.SchemaType)
			{
			case SchemaTypes.Primitive:
			case SchemaTypes.Enum:
				return this.ReadPrimitiveValue(elem);
			case SchemaTypes.Array:
				return this.ReadListElement(elem.MappedType, elem.IsNullable, null, true);
			case SchemaTypes.Class:
				return this.ReadObject(elem.MappedType, elem.IsNullable, true);
			case SchemaTypes.XmlSerializable:
			{
				object obj = XmlSerializationReaderInterpreter.CreateInstance(elem.TypeData.Type, true);
				return base.ReadSerializable((IXmlSerializable)obj);
			}
			case SchemaTypes.XmlNode:
				return this.ReadXmlNode(elem.TypeData, true);
			default:
				throw new NotSupportedException("Invalid value type");
			}
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x0006ABB4 File Offset: 0x00068DB4
		private object ReadPrimitiveValue(XmlTypeMapElementInfo elem)
		{
			if (elem.TypeData.Type == typeof(XmlQualifiedName))
			{
				if (elem.IsNullable)
				{
					return base.ReadNullableQualifiedName();
				}
				return base.ReadElementQualifiedName();
			}
			else
			{
				if (elem.IsNullable)
				{
					return this.GetValueFromXmlString(base.ReadNullableString(), elem.TypeData, elem.MappedType);
				}
				return this.GetValueFromXmlString(base.Reader.ReadElementString(), elem.TypeData, elem.MappedType);
			}
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x0006AC34 File Offset: 0x00068E34
		private object GetValueFromXmlString(string value, TypeData typeData, XmlTypeMapping typeMap)
		{
			if (typeData.SchemaType == SchemaTypes.Array)
			{
				return this.ReadListString(typeMap, value);
			}
			if (typeData.SchemaType == SchemaTypes.Enum)
			{
				return this.GetEnumValue(typeMap, value);
			}
			if (typeData.Type == typeof(XmlQualifiedName))
			{
				return base.ToXmlQualifiedName(value);
			}
			return XmlCustomFormatter.FromXmlString(typeData, value);
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x0006AC8C File Offset: 0x00068E8C
		private object ReadListElement(XmlTypeMapping typeMap, bool isNullable, object list, bool canCreateInstance)
		{
			Type type = typeMap.TypeData.Type;
			ListMap listMap = (ListMap)typeMap.ObjectMap;
			if (type.IsArray && base.ReadNull())
			{
				return null;
			}
			if (list == null)
			{
				if (!canCreateInstance || !typeMap.TypeData.HasPublicConstructor)
				{
					throw base.CreateReadOnlyCollectionException(typeMap.TypeFullName);
				}
				list = this.CreateList(type);
			}
			if (base.Reader.IsEmptyElement)
			{
				base.Reader.Skip();
				if (type.IsArray)
				{
					list = base.ShrinkArray((Array)list, 0, type.GetElementType(), false);
				}
				return list;
			}
			int length = 0;
			base.Reader.ReadStartElement();
			base.Reader.MoveToContent();
			while (base.Reader.NodeType != XmlNodeType.EndElement)
			{
				if (base.Reader.NodeType == XmlNodeType.Element)
				{
					XmlTypeMapElementInfo xmlTypeMapElementInfo = listMap.FindElement(base.Reader.LocalName, base.Reader.NamespaceURI);
					if (xmlTypeMapElementInfo != null)
					{
						this.AddListValue(typeMap.TypeData, ref list, length++, this.ReadObjectElement(xmlTypeMapElementInfo), false);
					}
					else
					{
						base.UnknownNode(null);
					}
				}
				else
				{
					base.UnknownNode(null);
				}
				base.Reader.MoveToContent();
			}
			base.ReadEndElement();
			if (type.IsArray)
			{
				list = base.ShrinkArray((Array)list, length, type.GetElementType(), false);
			}
			return list;
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x0006ADE0 File Offset: 0x00068FE0
		private object ReadListString(XmlTypeMapping typeMap, string values)
		{
			Type type = typeMap.TypeData.Type;
			ListMap listMap = (ListMap)typeMap.ObjectMap;
			values = values.Trim();
			if (values == string.Empty)
			{
				return Array.CreateInstance(type.GetElementType(), 0);
			}
			string[] array = values.Split(' ', StringSplitOptions.None);
			Array array2 = Array.CreateInstance(type.GetElementType(), array.Length);
			XmlTypeMapElementInfo xmlTypeMapElementInfo = (XmlTypeMapElementInfo)listMap.ItemInfo[0];
			for (int i = 0; i < array.Length; i++)
			{
				array2.SetValue(this.GetValueFromXmlString(array[i], xmlTypeMapElementInfo.TypeData, xmlTypeMapElementInfo.MappedType), i);
			}
			return array2;
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x0006AE88 File Offset: 0x00069088
		private void AddListValue(TypeData listType, ref object list, int index, object value, bool canCreateInstance)
		{
			Type type = listType.Type;
			if (type.IsArray)
			{
				list = base.EnsureArrayIndex((Array)list, index, type.GetElementType());
				listType.ConvertForAssignment(ref value);
				((Array)list).SetValue(value, index);
				return;
			}
			if (list == null)
			{
				if (!canCreateInstance)
				{
					throw base.CreateReadOnlyCollectionException(type.FullName);
				}
				list = XmlSerializationReaderInterpreter.CreateInstance(type, true);
			}
			type.GetMethod("Add", new Type[]
			{
				listType.ListItemType
			}).Invoke(list, new object[]
			{
				value
			});
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x0006AF1F File Offset: 0x0006911F
		private static object CreateInstance(Type type, bool nonPublic)
		{
			return Activator.CreateInstance(type, nonPublic);
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x0006AF28 File Offset: 0x00069128
		private object CreateInstance(Type type)
		{
			return Activator.CreateInstance(type, XmlSerializationReaderInterpreter.empty_array);
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x0006AF35 File Offset: 0x00069135
		private object CreateList(Type listType)
		{
			if (listType.IsArray)
			{
				return base.EnsureArrayIndex(null, 0, listType.GetElementType());
			}
			return XmlSerializationReaderInterpreter.CreateInstance(listType, true);
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x0006AF55 File Offset: 0x00069155
		private object InitializeList(TypeData listType)
		{
			if (listType.Type.IsArray)
			{
				return null;
			}
			return XmlSerializationReaderInterpreter.CreateInstance(listType.Type, true);
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x0006AF72 File Offset: 0x00069172
		private void FillList(object list, object items)
		{
			this.CopyEnumerableList(items, list);
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x0006AF7C File Offset: 0x0006917C
		private void CopyEnumerableList(object source, object dest)
		{
			if (dest == null)
			{
				throw base.CreateReadOnlyCollectionException(source.GetType().FullName);
			}
			object[] array = new object[1];
			MethodInfo method = dest.GetType().GetMethod("Add");
			foreach (object obj in ((IEnumerable)source))
			{
				array[0] = obj;
				method.Invoke(dest, array);
			}
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x0006B008 File Offset: 0x00069208
		private object ReadXmlNodeElement(XmlTypeMapping typeMap, bool isNullable)
		{
			return this.ReadXmlNode(typeMap.TypeData, false);
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x0006B017 File Offset: 0x00069217
		private object ReadXmlNode(TypeData type, bool wrapped)
		{
			if (type.Type == typeof(XmlDocument))
			{
				return base.ReadXmlDocument(wrapped);
			}
			return base.ReadXmlNode(wrapped);
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x0006B040 File Offset: 0x00069240
		private object ReadPrimitiveElement(XmlTypeMapping typeMap, bool isNullable)
		{
			XmlQualifiedName xmlQualifiedName = base.GetXsiType();
			if (xmlQualifiedName == null)
			{
				xmlQualifiedName = new XmlQualifiedName(typeMap.XmlType, typeMap.Namespace);
			}
			return base.ReadTypedPrimitive(xmlQualifiedName);
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x0006B076 File Offset: 0x00069276
		private object ReadEnumElement(XmlTypeMapping typeMap, bool isNullable)
		{
			base.Reader.ReadStartElement();
			object enumValue = this.GetEnumValue(typeMap, base.Reader.ReadString());
			base.ReadEndElement();
			return enumValue;
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0006B09C File Offset: 0x0006929C
		private object GetEnumValue(XmlTypeMapping typeMap, string val)
		{
			if (val == null)
			{
				return null;
			}
			string enumName = ((EnumMap)typeMap.ObjectMap).GetEnumName(typeMap.TypeFullName, val);
			if (enumName == null)
			{
				throw base.CreateUnknownConstantException(val, typeMap.TypeData.Type);
			}
			return Enum.Parse(typeMap.TypeData.Type, enumName, false);
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x0006B0F0 File Offset: 0x000692F0
		private object ReadXmlSerializableElement(XmlTypeMapping typeMap, bool isNullable)
		{
			base.Reader.MoveToContent();
			if (base.Reader.NodeType != XmlNodeType.Element)
			{
				base.UnknownNode(null);
				return null;
			}
			if (typeMap.IsAny || (base.Reader.LocalName == typeMap.ElementName && base.Reader.NamespaceURI == typeMap.Namespace))
			{
				object obj = XmlSerializationReaderInterpreter.CreateInstance(typeMap.TypeData.Type, true);
				return base.ReadSerializable((IXmlSerializable)obj);
			}
			throw base.CreateUnknownNodeException();
		}

		// Token: 0x04000BBE RID: 3006
		private XmlMapping _typeMap;

		// Token: 0x04000BBF RID: 3007
		private SerializationFormat _format;

		// Token: 0x04000BC0 RID: 3008
		private static readonly XmlQualifiedName AnyType = new XmlQualifiedName("anyType", "http://www.w3.org/2001/XMLSchema");

		// Token: 0x04000BC1 RID: 3009
		private static readonly object[] empty_array = new object[0];

		// Token: 0x02000200 RID: 512
		private class FixupCallbackInfo
		{
			// Token: 0x060010E0 RID: 4320 RVA: 0x0006B19E File Offset: 0x0006939E
			public FixupCallbackInfo(XmlSerializationReaderInterpreter sri, ClassMap map, bool isValueList)
			{
				this._sri = sri;
				this._map = map;
				this._isValueList = isValueList;
			}

			// Token: 0x060010E1 RID: 4321 RVA: 0x0006B1BB File Offset: 0x000693BB
			public void FixupMembers(object fixup)
			{
				this._sri.FixupMembers(this._map, fixup, this._isValueList);
			}

			// Token: 0x04000BC2 RID: 3010
			private XmlSerializationReaderInterpreter _sri;

			// Token: 0x04000BC3 RID: 3011
			private ClassMap _map;

			// Token: 0x04000BC4 RID: 3012
			private bool _isValueList;
		}

		// Token: 0x02000201 RID: 513
		private class ReaderCallbackInfo
		{
			// Token: 0x060010E2 RID: 4322 RVA: 0x0006B1D5 File Offset: 0x000693D5
			public ReaderCallbackInfo(XmlSerializationReaderInterpreter sri, XmlTypeMapping typeMap)
			{
				this._sri = sri;
				this._typeMap = typeMap;
			}

			// Token: 0x060010E3 RID: 4323 RVA: 0x0006B1EB File Offset: 0x000693EB
			internal object ReadObject()
			{
				return this._sri.ReadObject(this._typeMap, true, true);
			}

			// Token: 0x04000BC5 RID: 3013
			private XmlSerializationReaderInterpreter _sri;

			// Token: 0x04000BC6 RID: 3014
			private XmlTypeMapping _typeMap;
		}
	}
}
