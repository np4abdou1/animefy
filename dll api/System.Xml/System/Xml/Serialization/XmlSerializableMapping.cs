using System;
using System.Reflection;
using System.Xml.Schema;

namespace System.Xml.Serialization
{
	// Token: 0x02000219 RID: 537
	internal class XmlSerializableMapping : XmlTypeMapping
	{
		// Token: 0x060011C2 RID: 4546 RVA: 0x0006E404 File Offset: 0x0006C604
		internal XmlSerializableMapping(XmlRootAttribute root, string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) : base(elementName, ns, typeData, xmlType, xmlTypeNamespace)
		{
			XmlSchemaProviderAttribute xmlSchemaProviderAttribute = (XmlSchemaProviderAttribute)Attribute.GetCustomAttribute(typeData.Type, typeof(XmlSchemaProviderAttribute));
			if (xmlSchemaProviderAttribute != null)
			{
				this._schemaTypeName = XmlQualifiedName.Empty;
				if (xmlSchemaProviderAttribute.IsAny)
				{
					base.IsAny = true;
					return;
				}
				string methodName = xmlSchemaProviderAttribute.MethodName;
				MethodInfo method = typeData.Type.GetMethod(methodName, BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);
				if (method == null)
				{
					throw new InvalidOperationException(string.Format("Type '{0}' must implement public static method '{1}'", typeData.Type, methodName));
				}
				if (!typeof(XmlQualifiedName).IsAssignableFrom(method.ReturnType) && !typeof(XmlSchemaComplexType).IsAssignableFrom(method.ReturnType))
				{
					throw new InvalidOperationException(string.Format("Method '{0}' indicated by XmlSchemaProviderAttribute must have its return type as XmlQualifiedName", methodName));
				}
				XmlSchemaSet xmlSchemaSet = new XmlSchemaSet();
				object obj = method.Invoke(null, new object[]
				{
					xmlSchemaSet
				});
				if (obj == null)
				{
					return;
				}
				if (obj is XmlSchemaComplexType)
				{
					this._schemaType = (XmlSchemaComplexType)obj;
					if (!this._schemaType.QualifiedName.IsEmpty)
					{
						this._schemaTypeName = this._schemaType.QualifiedName;
					}
					else
					{
						this._schemaTypeName = new XmlQualifiedName(xmlType, xmlTypeNamespace);
					}
				}
				else
				{
					if (!(obj is XmlQualifiedName))
					{
						throw new InvalidOperationException(string.Format("Method {0}.{1}() specified by XmlSchemaProviderAttribute has invalid signature: return type must be compatible with System.Xml.XmlQualifiedName.", typeData.Type.Name, methodName));
					}
					this._schemaTypeName = (XmlQualifiedName)obj;
				}
				base.UpdateRoot(new XmlQualifiedName((root != null) ? root.ElementName : this._schemaTypeName.Name, (root != null) ? root.Namespace : (base.Namespace ?? this._schemaTypeName.Namespace)));
				base.XmlTypeNamespace = this._schemaTypeName.Namespace;
				base.XmlType = this._schemaTypeName.Name;
				if (!this._schemaTypeName.IsEmpty && xmlSchemaSet.Count > 0)
				{
					XmlSchema[] array = new XmlSchema[xmlSchemaSet.Count];
					xmlSchemaSet.CopyTo(array, 0);
					this._schema = array[0];
				}
				return;
			}
			else
			{
				IXmlSerializable xmlSerializable = (IXmlSerializable)Activator.CreateInstance(typeData.Type, true);
				try
				{
					this._schema = xmlSerializable.GetSchema();
				}
				catch (Exception)
				{
				}
				if (this._schema != null && (this._schema.Id == null || this._schema.Id.Length == 0))
				{
					throw new InvalidOperationException("Schema Id is missing. The schema returned from " + typeData.Type.FullName + ".GetSchema() must have an Id.");
				}
				return;
			}
		}

		// Token: 0x04000C15 RID: 3093
		private XmlSchema _schema;

		// Token: 0x04000C16 RID: 3094
		private XmlSchemaComplexType _schemaType;

		// Token: 0x04000C17 RID: 3095
		private XmlQualifiedName _schemaTypeName;
	}
}
