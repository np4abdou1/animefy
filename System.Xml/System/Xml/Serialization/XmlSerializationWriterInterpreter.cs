using System;
using System.Collections;
using System.Reflection;
using System.Text;

namespace System.Xml.Serialization
{
	// Token: 0x02000205 RID: 517
	internal class XmlSerializationWriterInterpreter : XmlSerializationWriter
	{
		// Token: 0x0600111B RID: 4379 RVA: 0x0006C050 File Offset: 0x0006A250
		public XmlSerializationWriterInterpreter(XmlMapping typeMap)
		{
			this._typeMap = typeMap;
			this._format = typeMap.Format;
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x0006C06C File Offset: 0x0006A26C
		protected override void InitCallbacks()
		{
			ArrayList relatedMaps = this._typeMap.RelatedMaps;
			if (relatedMaps != null)
			{
				foreach (object obj in relatedMaps)
				{
					XmlTypeMapping xmlTypeMapping = (XmlTypeMapping)obj;
					XmlSerializationWriterInterpreter.CallbackInfo @object = new XmlSerializationWriterInterpreter.CallbackInfo(this, xmlTypeMapping);
					if (xmlTypeMapping.TypeData.SchemaType == SchemaTypes.Enum)
					{
						base.AddWriteCallback(xmlTypeMapping.TypeData.Type, xmlTypeMapping.XmlType, xmlTypeMapping.Namespace, new XmlSerializationWriteCallback(@object.WriteEnum));
					}
					else
					{
						base.AddWriteCallback(xmlTypeMapping.TypeData.Type, xmlTypeMapping.XmlType, xmlTypeMapping.Namespace, new XmlSerializationWriteCallback(@object.WriteObject));
					}
				}
			}
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x0006C138 File Offset: 0x0006A338
		public void WriteRoot(object ob)
		{
			base.WriteStartDocument();
			if (this._typeMap is XmlTypeMapping)
			{
				XmlTypeMapping xmlTypeMapping = (XmlTypeMapping)this._typeMap;
				if (xmlTypeMapping.TypeData.SchemaType == SchemaTypes.Class || xmlTypeMapping.TypeData.SchemaType == SchemaTypes.Array)
				{
					base.TopLevelElement();
				}
				if (this._format == SerializationFormat.Literal)
				{
					this.WriteObject(xmlTypeMapping, ob, xmlTypeMapping.ElementName, xmlTypeMapping.Namespace, true, false, true);
				}
				else
				{
					base.WritePotentiallyReferencingElement(xmlTypeMapping.ElementName, xmlTypeMapping.Namespace, ob, xmlTypeMapping.TypeData.Type, true, false);
				}
			}
			else
			{
				if (!(ob is object[]))
				{
					throw base.CreateUnknownTypeException(ob);
				}
				this.WriteMessage((XmlMembersMapping)this._typeMap, (object[])ob);
			}
			base.WriteReferencedElements();
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x0006C1FC File Offset: 0x0006A3FC
		protected virtual void WriteObject(XmlTypeMapping typeMap, object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem)
		{
			if (ob == null)
			{
				if (isNullable)
				{
					if (this._format == SerializationFormat.Literal)
					{
						base.WriteNullTagLiteral(element, namesp);
						return;
					}
					base.WriteNullTagEncoded(element, namesp);
				}
				return;
			}
			if (ob is XmlNode)
			{
				if (this._format == SerializationFormat.Literal)
				{
					base.WriteElementLiteral((XmlNode)ob, "", "", true, typeMap.IsAny);
					return;
				}
				base.WriteElementEncoded((XmlNode)ob, "", "", true, typeMap.IsAny);
				return;
			}
			else
			{
				if (typeMap.TypeData.SchemaType == SchemaTypes.XmlSerializable)
				{
					base.WriteSerializable((IXmlSerializable)ob, element, namesp, isNullable, !typeMap.IsAny);
					return;
				}
				Type type = typeMap.TypeData.Type;
				if (!ob.GetType().IsAssignableFrom(type))
				{
					ob = XmlSerializationWriterInterpreter.ImplicitConvert(ob, type);
				}
				XmlTypeMapping realTypeMap = typeMap.GetRealTypeMap(ob.GetType());
				if (realTypeMap != null)
				{
					if (writeWrappingElem)
					{
						if (realTypeMap != typeMap || this._format == SerializationFormat.Encoded)
						{
							needType = true;
						}
						base.WriteStartElement(element, namesp, ob);
					}
					if (needType)
					{
						base.WriteXsiType(realTypeMap.XmlType, realTypeMap.XmlTypeNamespace);
					}
					switch (realTypeMap.TypeData.SchemaType)
					{
					case SchemaTypes.Primitive:
						this.WritePrimitiveElement(realTypeMap, ob, element, namesp);
						break;
					case SchemaTypes.Enum:
						this.WriteEnumElement(realTypeMap, ob, element, namesp);
						break;
					case SchemaTypes.Array:
						this.WriteListElement(realTypeMap, ob, element, namesp);
						break;
					case SchemaTypes.Class:
						this.WriteObjectElement(realTypeMap, ob, element, namesp);
						break;
					}
					if (writeWrappingElem)
					{
						base.WriteEndElement(ob);
					}
					return;
				}
				if (ob.GetType().IsArray && typeof(XmlNode).IsAssignableFrom(ob.GetType().GetElementType()))
				{
					base.Writer.WriteStartElement(element, namesp);
					foreach (object obj in ((IEnumerable)ob))
					{
						((XmlNode)obj).WriteTo(base.Writer);
					}
					base.Writer.WriteEndElement();
					return;
				}
				base.WriteTypedPrimitive(element, namesp, ob, true);
				return;
			}
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x0006C410 File Offset: 0x0006A610
		protected virtual void WriteMessage(XmlMembersMapping membersMap, object[] parameters)
		{
			if (membersMap.HasWrapperElement)
			{
				base.TopLevelElement();
				base.WriteStartElement(membersMap.ElementName, membersMap.Namespace, this._format == SerializationFormat.Encoded);
				if (base.Writer.LookupPrefix("http://www.w3.org/2001/XMLSchema") == null)
				{
					base.WriteAttribute("xmlns", "xsd", "http://www.w3.org/2001/XMLSchema", "http://www.w3.org/2001/XMLSchema");
				}
				if (base.Writer.LookupPrefix("http://www.w3.org/2001/XMLSchema-instance") == null)
				{
					base.WriteAttribute("xmlns", "xsi", "http://www.w3.org/2001/XMLSchema-instance", "http://www.w3.org/2001/XMLSchema-instance");
				}
			}
			this.WriteMembers((ClassMap)membersMap.ObjectMap, parameters, true);
			if (membersMap.HasWrapperElement)
			{
				base.WriteEndElement();
			}
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x0006C4C0 File Offset: 0x0006A6C0
		protected virtual void WriteObjectElement(XmlTypeMapping typeMap, object ob, string element, string namesp)
		{
			ClassMap classMap = (ClassMap)typeMap.ObjectMap;
			if (classMap.NamespaceDeclarations != null)
			{
				base.WriteNamespaceDeclarations((XmlSerializerNamespaces)classMap.NamespaceDeclarations.GetValue(ob));
			}
			this.WriteObjectElementAttributes(typeMap, ob);
			this.WriteObjectElementElements(typeMap, ob);
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x0006C508 File Offset: 0x0006A708
		protected virtual void WriteObjectElementAttributes(XmlTypeMapping typeMap, object ob)
		{
			ClassMap map = (ClassMap)typeMap.ObjectMap;
			this.WriteAttributeMembers(map, ob, false);
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x0006C52C File Offset: 0x0006A72C
		protected virtual void WriteObjectElementElements(XmlTypeMapping typeMap, object ob)
		{
			ClassMap map = (ClassMap)typeMap.ObjectMap;
			this.WriteElementMembers(map, ob, false);
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x0006C54E File Offset: 0x0006A74E
		private void WriteMembers(ClassMap map, object ob, bool isValueList)
		{
			this.WriteAttributeMembers(map, ob, isValueList);
			this.WriteElementMembers(map, ob, isValueList);
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x0006C564 File Offset: 0x0006A764
		private void WriteAttributeMembers(ClassMap map, object ob, bool isValueList)
		{
			XmlTypeMapMember defaultAnyAttributeMember = map.DefaultAnyAttributeMember;
			if (defaultAnyAttributeMember != null && this.MemberHasValue(defaultAnyAttributeMember, ob, isValueList))
			{
				ICollection collection = (ICollection)this.GetMemberValue(defaultAnyAttributeMember, ob, isValueList);
				if (collection != null)
				{
					foreach (object obj in collection)
					{
						XmlAttribute xmlAttribute = (XmlAttribute)obj;
						if (xmlAttribute.NamespaceURI != "http://www.w3.org/2000/xmlns/")
						{
							base.WriteXmlAttribute(xmlAttribute, ob);
						}
					}
				}
			}
			ICollection attributeMembers = map.AttributeMembers;
			if (attributeMembers != null)
			{
				foreach (object obj2 in attributeMembers)
				{
					XmlTypeMapMemberAttribute xmlTypeMapMemberAttribute = (XmlTypeMapMemberAttribute)obj2;
					if (this.MemberHasValue(xmlTypeMapMemberAttribute, ob, isValueList))
					{
						base.WriteAttribute(xmlTypeMapMemberAttribute.AttributeName, xmlTypeMapMemberAttribute.Namespace, this.GetStringValue(xmlTypeMapMemberAttribute.MappedType, xmlTypeMapMemberAttribute.TypeData, this.GetMemberValue(xmlTypeMapMemberAttribute, ob, isValueList)));
					}
				}
			}
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x0006C680 File Offset: 0x0006A880
		private void WriteElementMembers(ClassMap map, object ob, bool isValueList)
		{
			ICollection elementMembers = map.ElementMembers;
			if (elementMembers != null)
			{
				foreach (object obj in elementMembers)
				{
					XmlTypeMapMemberElement xmlTypeMapMemberElement = (XmlTypeMapMemberElement)obj;
					if (this.MemberHasValue(xmlTypeMapMemberElement, ob, isValueList))
					{
						object memberValue = this.GetMemberValue(xmlTypeMapMemberElement, ob, isValueList);
						Type type = xmlTypeMapMemberElement.GetType();
						if (type == typeof(XmlTypeMapMemberList))
						{
							this.WriteMemberElement((XmlTypeMapElementInfo)xmlTypeMapMemberElement.ElementInfo[0], memberValue);
						}
						else if (type == typeof(XmlTypeMapMemberFlatList))
						{
							if (memberValue != null)
							{
								this.WriteListContent(ob, xmlTypeMapMemberElement.TypeData, ((XmlTypeMapMemberFlatList)xmlTypeMapMemberElement).ListMap, memberValue, null);
							}
						}
						else if (type == typeof(XmlTypeMapMemberAnyElement))
						{
							if (memberValue != null)
							{
								this.WriteAnyElementContent((XmlTypeMapMemberAnyElement)xmlTypeMapMemberElement, memberValue);
							}
						}
						else if (!(type == typeof(XmlTypeMapMemberAnyAttribute)))
						{
							if (!(type == typeof(XmlTypeMapMemberElement)))
							{
								throw new InvalidOperationException("Unknown member type");
							}
							XmlTypeMapElementInfo elem = xmlTypeMapMemberElement.FindElement(ob, memberValue);
							this.WriteMemberElement(elem, memberValue);
						}
					}
				}
			}
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x0006AAF5 File Offset: 0x00068CF5
		private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList)
		{
			if (isValueList)
			{
				return ((object[])ob)[member.GlobalIndex];
			}
			return member.GetValue(ob);
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x0006C7E0 File Offset: 0x0006A9E0
		private bool MemberHasValue(XmlTypeMapMember member, object ob, bool isValueList)
		{
			if (isValueList)
			{
				return (!member.IsOptionalValueType || member.GetValueSpecified(ob)) && member.GlobalIndex < ((object[])ob).Length;
			}
			if (member.DefaultValue != DBNull.Value)
			{
				object obj = this.GetMemberValue(member, ob, isValueList);
				if (obj == null && member.DefaultValue == null)
				{
					return false;
				}
				if (obj != null && obj.GetType().IsEnum)
				{
					if (obj.Equals(member.DefaultValue))
					{
						return false;
					}
					Type underlyingType = Enum.GetUnderlyingType(obj.GetType());
					obj = Convert.ChangeType(obj, underlyingType, null);
				}
				if (obj != null && obj.Equals(member.DefaultValue))
				{
					return false;
				}
			}
			else if (member.IsOptionalValueType)
			{
				return member.GetValueSpecified(ob);
			}
			return true;
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x0006C894 File Offset: 0x0006AA94
		private void WriteMemberElement(XmlTypeMapElementInfo elem, object memberValue)
		{
			switch (elem.TypeData.SchemaType)
			{
			case SchemaTypes.Primitive:
			case SchemaTypes.Enum:
				if (this._format == SerializationFormat.Literal)
				{
					this.WritePrimitiveValueLiteral(memberValue, elem.ElementName, elem.Namespace, elem.MappedType, elem.TypeData, elem.WrappedElement, elem.IsNullable);
					return;
				}
				this.WritePrimitiveValueEncoded(memberValue, elem.ElementName, elem.Namespace, new XmlQualifiedName(elem.DataTypeName, elem.DataTypeNamespace), elem.MappedType, elem.TypeData, elem.WrappedElement, elem.IsNullable);
				return;
			case SchemaTypes.Array:
				if (memberValue == null)
				{
					if (!elem.IsNullable)
					{
						return;
					}
					if (this._format == SerializationFormat.Literal)
					{
						base.WriteNullTagLiteral(elem.ElementName, elem.Namespace);
						return;
					}
					base.WriteNullTagEncoded(elem.ElementName, elem.Namespace);
					return;
				}
				else
				{
					if (elem.MappedType.MultiReferenceType)
					{
						base.WriteReferencingElement(elem.ElementName, elem.Namespace, memberValue, elem.IsNullable);
						return;
					}
					base.WriteStartElement(elem.ElementName, elem.Namespace, memberValue);
					this.WriteListContent(null, elem.TypeData, (ListMap)elem.MappedType.ObjectMap, memberValue, null);
					base.WriteEndElement(memberValue);
					return;
				}
				break;
			case SchemaTypes.Class:
				if (!elem.MappedType.MultiReferenceType)
				{
					this.WriteObject(elem.MappedType, memberValue, elem.ElementName, elem.Namespace, elem.IsNullable, false, true);
					return;
				}
				if (elem.MappedType.TypeData.Type == typeof(object))
				{
					base.WritePotentiallyReferencingElement(elem.ElementName, elem.Namespace, memberValue, null, false, elem.IsNullable);
					return;
				}
				base.WriteReferencingElement(elem.ElementName, elem.Namespace, memberValue, elem.IsNullable);
				return;
			case SchemaTypes.XmlSerializable:
				if (!elem.MappedType.TypeData.Type.IsInstanceOfType(memberValue))
				{
					memberValue = XmlSerializationWriterInterpreter.ImplicitConvert(memberValue, elem.MappedType.TypeData.Type);
				}
				base.WriteSerializable((IXmlSerializable)memberValue, elem.ElementName, elem.Namespace, elem.IsNullable);
				return;
			case SchemaTypes.XmlNode:
			{
				string name = elem.WrappedElement ? elem.ElementName : "";
				if (this._format == SerializationFormat.Literal)
				{
					base.WriteElementLiteral((XmlNode)memberValue, name, elem.Namespace, elem.IsNullable, false);
					return;
				}
				base.WriteElementEncoded((XmlNode)memberValue, name, elem.Namespace, elem.IsNullable, false);
				return;
			}
			default:
				throw new NotSupportedException("Invalid value type");
			}
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x0006CB14 File Offset: 0x0006AD14
		internal static object ImplicitConvert(object obj, Type type)
		{
			if (obj == null)
			{
				return null;
			}
			Type type2 = obj.GetType();
			while (type2 != typeof(object))
			{
				MethodInfo method = type2.GetMethod("op_Implicit", new Type[]
				{
					type2
				});
				if (method != null && method.ReturnType == type)
				{
					return method.Invoke(null, new object[]
					{
						obj
					});
				}
				method = type.GetMethod("op_Implicit", new Type[]
				{
					type2
				});
				if (method != null && method.ReturnType == type)
				{
					return method.Invoke(null, new object[]
					{
						obj
					});
				}
				type2 = type2.BaseType;
			}
			return obj;
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x0006CBD0 File Offset: 0x0006ADD0
		private void WritePrimitiveValueLiteral(object memberValue, string name, string ns, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable)
		{
			if (!wrapped)
			{
				base.WriteValue(this.GetStringValue(mappedType, typeData, memberValue));
				return;
			}
			if (isNullable)
			{
				if (typeData.Type == typeof(XmlQualifiedName))
				{
					base.WriteNullableQualifiedNameLiteral(name, ns, (XmlQualifiedName)memberValue);
					return;
				}
				base.WriteNullableStringLiteral(name, ns, this.GetStringValue(mappedType, typeData, memberValue));
				return;
			}
			else
			{
				if (typeData.Type == typeof(XmlQualifiedName))
				{
					base.WriteElementQualifiedName(name, ns, (XmlQualifiedName)memberValue);
					return;
				}
				base.WriteElementString(name, ns, this.GetStringValue(mappedType, typeData, memberValue));
				return;
			}
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x0006CC6C File Offset: 0x0006AE6C
		private void WritePrimitiveValueEncoded(object memberValue, string name, string ns, XmlQualifiedName xsiType, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable)
		{
			if (!wrapped)
			{
				base.WriteValue(this.GetStringValue(mappedType, typeData, memberValue));
				return;
			}
			if (isNullable)
			{
				if (typeData.Type == typeof(XmlQualifiedName))
				{
					base.WriteNullableQualifiedNameEncoded(name, ns, (XmlQualifiedName)memberValue, xsiType);
					return;
				}
				base.WriteNullableStringEncoded(name, ns, this.GetStringValue(mappedType, typeData, memberValue), xsiType);
				return;
			}
			else
			{
				if (typeData.Type == typeof(XmlQualifiedName))
				{
					base.WriteElementQualifiedName(name, ns, (XmlQualifiedName)memberValue, xsiType);
					return;
				}
				base.WriteElementString(name, ns, this.GetStringValue(mappedType, typeData, memberValue), xsiType);
				return;
			}
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x0006CD10 File Offset: 0x0006AF10
		protected virtual void WriteListElement(XmlTypeMapping typeMap, object ob, string element, string namesp)
		{
			if (this._format == SerializationFormat.Encoded)
			{
				int listCount = this.GetListCount(typeMap.TypeData, ob);
				string text;
				string text2;
				((ListMap)typeMap.ObjectMap).GetArrayType(listCount, out text, out text2);
				string value = (text2 != string.Empty) ? base.FromXmlQualifiedName(new XmlQualifiedName(text, text2)) : text;
				base.WriteAttribute("arrayType", "http://schemas.xmlsoap.org/soap/encoding/", value);
			}
			this.WriteListContent(null, typeMap.TypeData, (ListMap)typeMap.ObjectMap, ob, null);
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x0006CD94 File Offset: 0x0006AF94
		private void WriteListContent(object container, TypeData listType, ListMap map, object ob, StringBuilder targetString)
		{
			if (listType.Type.IsArray)
			{
				Array array = (Array)ob;
				for (int i = 0; i < array.Length; i++)
				{
					object value = array.GetValue(i);
					XmlTypeMapElementInfo xmlTypeMapElementInfo = map.FindElement(container, i, value);
					if (xmlTypeMapElementInfo != null && targetString == null)
					{
						this.WriteMemberElement(xmlTypeMapElementInfo, value);
					}
					else if (xmlTypeMapElementInfo != null && targetString != null)
					{
						targetString.Append(this.GetStringValue(xmlTypeMapElementInfo.MappedType, xmlTypeMapElementInfo.TypeData, value)).Append(" ");
					}
					else if (value != null)
					{
						throw base.CreateUnknownTypeException(value);
					}
				}
				return;
			}
			if (ob is ICollection)
			{
				int num = (int)ob.GetType().GetProperty("Count").GetValue(ob, null);
				PropertyInfo indexerProperty = TypeData.GetIndexerProperty(listType.Type);
				object[] array2 = new object[1];
				for (int j = 0; j < num; j++)
				{
					array2[0] = j;
					object value2 = indexerProperty.GetValue(ob, array2);
					XmlTypeMapElementInfo xmlTypeMapElementInfo2 = map.FindElement(container, j, value2);
					if (xmlTypeMapElementInfo2 != null && targetString == null)
					{
						this.WriteMemberElement(xmlTypeMapElementInfo2, value2);
					}
					else if (xmlTypeMapElementInfo2 != null && targetString != null)
					{
						targetString.Append(this.GetStringValue(xmlTypeMapElementInfo2.MappedType, xmlTypeMapElementInfo2.TypeData, value2)).Append(" ");
					}
					else if (value2 != null)
					{
						throw base.CreateUnknownTypeException(value2);
					}
				}
				return;
			}
			if (ob is IEnumerable)
			{
				using (IEnumerator enumerator = ((IEnumerable)ob).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						XmlTypeMapElementInfo xmlTypeMapElementInfo3 = map.FindElement(container, -1, obj);
						if (xmlTypeMapElementInfo3 != null && targetString == null)
						{
							this.WriteMemberElement(xmlTypeMapElementInfo3, obj);
						}
						else if (xmlTypeMapElementInfo3 != null && targetString != null)
						{
							targetString.Append(this.GetStringValue(xmlTypeMapElementInfo3.MappedType, xmlTypeMapElementInfo3.TypeData, obj)).Append(" ");
						}
						else if (obj != null)
						{
							throw base.CreateUnknownTypeException(obj);
						}
					}
					return;
				}
			}
			throw new Exception("Unsupported collection type");
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x0006CFB4 File Offset: 0x0006B1B4
		private int GetListCount(TypeData listType, object ob)
		{
			if (listType.Type.IsArray)
			{
				return ((Array)ob).Length;
			}
			return (int)listType.Type.GetProperty("Count").GetValue(ob, null);
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x0006CFEC File Offset: 0x0006B1EC
		private void WriteAnyElementContent(XmlTypeMapMemberAnyElement member, object memberValue)
		{
			if (member.TypeData.Type == typeof(XmlElement) || member.TypeData.Type == typeof(XmlNode))
			{
				memberValue = new object[]
				{
					memberValue
				};
			}
			foreach (object obj in ((Array)memberValue))
			{
				XmlNode xmlNode = obj as XmlNode;
				if (xmlNode == null)
				{
					throw new InvalidOperationException(string.Format("XmlAnyElementAttribute can only be applied to members of type XmlElement, XmlElement[] or XmlNode[]. The target object is {0}", (obj != null) ? obj.GetType() : null));
				}
				if (xmlNode is XmlElement)
				{
					if (!member.IsElementDefined(xmlNode.Name, xmlNode.NamespaceURI))
					{
						throw base.CreateUnknownAnyElementException(xmlNode.Name, xmlNode.NamespaceURI);
					}
					if (this._format == SerializationFormat.Literal)
					{
						base.WriteElementLiteral(xmlNode, "", "", false, true);
					}
					else
					{
						base.WriteElementEncoded(xmlNode, "", "", false, true);
					}
				}
				else
				{
					xmlNode.WriteTo(base.Writer);
				}
			}
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x0006D118 File Offset: 0x0006B318
		protected virtual void WritePrimitiveElement(XmlTypeMapping typeMap, object ob, string element, string namesp)
		{
			base.Writer.WriteString(this.GetStringValue(typeMap, typeMap.TypeData, ob));
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x0006D133 File Offset: 0x0006B333
		protected virtual void WriteEnumElement(XmlTypeMapping typeMap, object ob, string element, string namesp)
		{
			base.Writer.WriteString(this.GetEnumXmlValue(typeMap, ob));
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x0006D148 File Offset: 0x0006B348
		private string GetStringValue(XmlTypeMapping typeMap, TypeData type, object value)
		{
			if (type.SchemaType == SchemaTypes.Array)
			{
				if (value == null)
				{
					return null;
				}
				StringBuilder stringBuilder = new StringBuilder();
				this.WriteListContent(null, typeMap.TypeData, (ListMap)typeMap.ObjectMap, value, stringBuilder);
				return stringBuilder.ToString().Trim();
			}
			else
			{
				if (type.SchemaType == SchemaTypes.Enum)
				{
					return this.GetEnumXmlValue(typeMap, value);
				}
				if (type.Type == typeof(XmlQualifiedName))
				{
					return base.FromXmlQualifiedName((XmlQualifiedName)value);
				}
				if (value == null)
				{
					return null;
				}
				return XmlCustomFormatter.ToXmlString(type, value);
			}
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x0006D1D1 File Offset: 0x0006B3D1
		private string GetEnumXmlValue(XmlTypeMapping typeMap, object ob)
		{
			if (ob == null)
			{
				return null;
			}
			return ((EnumMap)typeMap.ObjectMap).GetXmlName(typeMap.TypeFullName, ob);
		}

		// Token: 0x04000BD3 RID: 3027
		private XmlMapping _typeMap;

		// Token: 0x04000BD4 RID: 3028
		private SerializationFormat _format;

		// Token: 0x02000206 RID: 518
		private class CallbackInfo
		{
			// Token: 0x06001134 RID: 4404 RVA: 0x0006D1EF File Offset: 0x0006B3EF
			public CallbackInfo(XmlSerializationWriterInterpreter swi, XmlTypeMapping typeMap)
			{
				this._swi = swi;
				this._typeMap = typeMap;
			}

			// Token: 0x06001135 RID: 4405 RVA: 0x0006D205 File Offset: 0x0006B405
			internal void WriteObject(object ob)
			{
				this._swi.WriteObject(this._typeMap, ob, this._typeMap.ElementName, this._typeMap.Namespace, false, false, false);
			}

			// Token: 0x06001136 RID: 4406 RVA: 0x0006D232 File Offset: 0x0006B432
			internal void WriteEnum(object ob)
			{
				this._swi.WriteObject(this._typeMap, ob, this._typeMap.ElementName, this._typeMap.Namespace, false, true, false);
			}

			// Token: 0x04000BD5 RID: 3029
			private XmlSerializationWriterInterpreter _swi;

			// Token: 0x04000BD6 RID: 3030
			private XmlTypeMapping _typeMap;
		}
	}
}
