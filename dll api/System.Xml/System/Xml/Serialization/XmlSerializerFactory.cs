using System;
using System.Collections;

namespace System.Xml.Serialization
{
	/// <summary>Creates typed versions of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> for more efficient serialization.</summary>
	// Token: 0x02000209 RID: 521
	public class XmlSerializerFactory
	{
		/// <summary>Returns a derivation of the <see cref="T:System.Xml.Serialization.XmlSerializerFactory" /> class that is used to serialize the specified type.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> to serialize.</param>
		/// <returns>A derivation of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class that is specifically created to serialize the specified type.</returns>
		// Token: 0x0600114C RID: 4428 RVA: 0x0006D686 File Offset: 0x0006B886
		public XmlSerializer CreateSerializer(Type type)
		{
			return this.CreateSerializer(type, null, null, null, null);
		}

		/// <summary>Returns a derivation of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class that can serialize objects of the specified type into XML documents, and vice versa. Specifies the object that represents the XML root element.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> to serialize.</param>
		/// <param name="root">An <see cref="T:System.Xml.Serialization.XmlRootAttribute" /> that represents the XML root element.</param>
		/// <returns>A derivation of the <see cref="T:System.Xml.Serialization.XmlSerializer" />.</returns>
		// Token: 0x0600114D RID: 4429 RVA: 0x0006D693 File Offset: 0x0006B893
		public XmlSerializer CreateSerializer(Type type, XmlRootAttribute root)
		{
			return this.CreateSerializer(type, null, null, root, null);
		}

		/// <summary>Returns a derivation of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class that can serialize objects of the specified type into XML document instances, and vice versa. Each object to be serialized can itself contain instances of classes, which this overload can override with other classes. This overload also specifies the default namespace for all the XML elements, and the class to use as the XML root element.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> to serialize.</param>
		/// <param name="overrides">An <see cref="T:System.Xml.Serialization.XmlAttributeOverrides" /> that contains fields that override the default serialization behavior.</param>
		/// <param name="extraTypes">A <see cref="T:System.Type" /> array of additional object types to serialize.</param>
		/// <param name="root">An <see cref="T:System.Xml.Serialization.XmlRootAttribute" /> that represents the XML root element.</param>
		/// <param name="defaultNamespace">The default namespace of all XML elements in the XML document. </param>
		/// <returns>A derivation of the <see cref="T:System.Xml.Serialization.XmlSerializer" />.</returns>
		// Token: 0x0600114E RID: 4430 RVA: 0x0006D6A0 File Offset: 0x0006B8A0
		public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace)
		{
			XmlTypeSerializationSource key = new XmlTypeSerializationSource(type, root, overrides, defaultNamespace, extraTypes);
			Hashtable obj = XmlSerializerFactory.serializersBySource;
			XmlSerializer result;
			lock (obj)
			{
				XmlSerializer xmlSerializer = (XmlSerializer)XmlSerializerFactory.serializersBySource[key];
				if (xmlSerializer == null)
				{
					xmlSerializer = new XmlSerializer(type, overrides, extraTypes, root, defaultNamespace);
					XmlSerializerFactory.serializersBySource[xmlSerializer.Mapping.Source] = xmlSerializer;
				}
				result = xmlSerializer;
			}
			return result;
		}

		// Token: 0x04000BE7 RID: 3047
		private static Hashtable serializersBySource = new Hashtable();
	}
}
