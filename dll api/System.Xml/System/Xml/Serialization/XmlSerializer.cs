using System;
using System.Collections;
using System.IO;
using System.Reflection;

namespace System.Xml.Serialization
{
	/// <summary>Serializes and deserializes objects into and from XML documents. The <see cref="T:System.Xml.Serialization.XmlSerializer" /> enables you to control how objects are encoded into XML.</summary>
	// Token: 0x02000207 RID: 519
	public class XmlSerializer
	{
		// Token: 0x06001137 RID: 4407 RVA: 0x0006D260 File Offset: 0x0006B460
		static XmlSerializer()
		{
			string text = null;
			XmlSerializer.generationThreshold = -1;
			XmlSerializer.backgroundGeneration = false;
			XmlSerializer.deleteTempFiles = (text == null || text == "no");
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class that can serialize objects of the specified type into XML documents, and deserialize XML documents into objects of the specified type.</summary>
		/// <param name="type">The type of the object that this <see cref="T:System.Xml.Serialization.XmlSerializer" /> can serialize. </param>
		// Token: 0x06001138 RID: 4408 RVA: 0x0006D2AD File Offset: 0x0006B4AD
		public XmlSerializer(Type type) : this(type, null, null, null, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class that can serialize objects of type <see cref="T:System.Object" /> into XML document instances, and deserialize XML document instances into objects of type <see cref="T:System.Object" />. Each object to be serialized can itself contain instances of classes, which this overload overrides with other classes. This overload also specifies the default namespace for all the XML elements and the class to use as the XML root element.</summary>
		/// <param name="type">The type of the object that this <see cref="T:System.Xml.Serialization.XmlSerializer" /> can serialize. </param>
		/// <param name="overrides">An <see cref="T:System.Xml.Serialization.XmlAttributeOverrides" /> that extends or overrides the behavior of the class specified in the <paramref name="type" /> parameter. </param>
		/// <param name="extraTypes">A <see cref="T:System.Type" /> array of additional object types to serialize. </param>
		/// <param name="root">An <see cref="T:System.Xml.Serialization.XmlRootAttribute" /> that defines the XML root element properties. </param>
		/// <param name="defaultNamespace">The default namespace of all XML elements in the XML document. </param>
		// Token: 0x06001139 RID: 4409 RVA: 0x0006D2BC File Offset: 0x0006B4BC
		public XmlSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			XmlReflectionImporter xmlReflectionImporter = new XmlReflectionImporter(overrides, defaultNamespace);
			if (extraTypes != null)
			{
				foreach (Type type2 in extraTypes)
				{
					xmlReflectionImporter.IncludeType(type2);
				}
			}
			this.typeMapping = xmlReflectionImporter.ImportTypeMapping(type, root, defaultNamespace);
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x0600113A RID: 4410 RVA: 0x0006D31B File Offset: 0x0006B51B
		internal XmlMapping Mapping
		{
			get
			{
				return this.typeMapping;
			}
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x0006D323 File Offset: 0x0006B523
		internal virtual void OnUnknownAttribute(XmlAttributeEventArgs e)
		{
			if (this.onUnknownAttribute != null)
			{
				this.onUnknownAttribute(this, e);
			}
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x0006D33A File Offset: 0x0006B53A
		internal virtual void OnUnknownElement(XmlElementEventArgs e)
		{
			if (this.onUnknownElement != null)
			{
				this.onUnknownElement(this, e);
			}
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x0006D351 File Offset: 0x0006B551
		internal virtual void OnUnknownNode(XmlNodeEventArgs e)
		{
			if (this.onUnknownNode != null)
			{
				this.onUnknownNode(this, e);
			}
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x0006D368 File Offset: 0x0006B568
		internal virtual void OnUnreferencedObject(UnreferencedObjectEventArgs e)
		{
			if (this.onUnreferencedObject != null)
			{
				this.onUnreferencedObject(this, e);
			}
		}

		/// <summary>Returns an object used to read the XML document to be serialized.</summary>
		/// <returns>An <see cref="T:System.Xml.Serialization.XmlSerializationReader" /> used to read the XML document.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method when the method is not overridden in a descendant class. </exception>
		// Token: 0x0600113F RID: 4415 RVA: 0x00002B48 File Offset: 0x00000D48
		protected virtual XmlSerializationReader CreateReader()
		{
			throw new NotImplementedException();
		}

		/// <summary>When overridden in a derived class, returns a writer used to serialize the object.</summary>
		/// <returns>An instance that implements the <see cref="T:System.Xml.Serialization.XmlSerializationWriter" /> class.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method when the method is not overridden in a descendant class. </exception>
		// Token: 0x06001140 RID: 4416 RVA: 0x00002B48 File Offset: 0x00000D48
		protected virtual XmlSerializationWriter CreateWriter()
		{
			throw new NotImplementedException();
		}

		/// <summary>Deserializes the XML document contained by the specified <see cref="T:System.IO.TextReader" />.</summary>
		/// <param name="textReader">The <see cref="T:System.IO.TextReader" /> that contains the XML document to deserialize. </param>
		/// <returns>The <see cref="T:System.Object" /> being deserialized.</returns>
		/// <exception cref="T:System.InvalidOperationException">An error occurred during deserialization. The original exception is available using the <see cref="P:System.Exception.InnerException" /> property. </exception>
		// Token: 0x06001141 RID: 4417 RVA: 0x0006D380 File Offset: 0x0006B580
		public object Deserialize(TextReader textReader)
		{
			return this.Deserialize(new XmlTextReader(textReader)
			{
				Normalization = true,
				WhitespaceHandling = WhitespaceHandling.Significant
			});
		}

		/// <summary>Deserializes the XML document contained by the specified <see cref="T:System.Xml.XmlReader" />.</summary>
		/// <param name="xmlReader">The <see cref="T:System.Xml.XmlReader" /> that contains the XML document to deserialize. </param>
		/// <returns>The <see cref="T:System.Object" /> being deserialized.</returns>
		/// <exception cref="T:System.InvalidOperationException">An error occurred during deserialization. The original exception is available using the <see cref="P:System.Exception.InnerException" /> property. </exception>
		// Token: 0x06001142 RID: 4418 RVA: 0x0006D3AC File Offset: 0x0006B5AC
		public object Deserialize(XmlReader xmlReader)
		{
			XmlSerializationReader xmlSerializationReader;
			if (this.customSerializer)
			{
				xmlSerializationReader = this.CreateReader();
			}
			else
			{
				xmlSerializationReader = this.CreateReader(this.typeMapping);
			}
			xmlSerializationReader.Initialize(xmlReader, this);
			return this.Deserialize(xmlSerializationReader);
		}

		/// <summary>Deserializes the XML document contained by the specified <see cref="T:System.Xml.Serialization.XmlSerializationReader" />.</summary>
		/// <param name="reader">The <see cref="T:System.Xml.Serialization.XmlSerializationReader" /> that contains the XML document to deserialize. </param>
		/// <returns>The deserialized object.</returns>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method when the method is not overridden in a descendant class. </exception>
		// Token: 0x06001143 RID: 4419 RVA: 0x0006D3E8 File Offset: 0x0006B5E8
		protected virtual object Deserialize(XmlSerializationReader reader)
		{
			if (this.customSerializer)
			{
				throw new NotImplementedException();
			}
			object result;
			try
			{
				if (reader is XmlSerializationReaderInterpreter)
				{
					result = ((XmlSerializationReaderInterpreter)reader).ReadRoot();
				}
				else
				{
					try
					{
						result = this.serializerData.ReaderMethod.Invoke(reader, null);
					}
					catch (TargetInvocationException ex)
					{
						throw ex.InnerException;
					}
				}
			}
			catch (Exception ex2)
			{
				if (ex2 is InvalidOperationException || ex2 is InvalidCastException)
				{
					throw new InvalidOperationException("There is an error in XML document.", ex2);
				}
				throw;
			}
			return result;
		}

		/// <summary>Serializes the specified <see cref="T:System.Object" /> and writes the XML document to a file using the specified <see cref="T:System.Xml.Serialization.XmlSerializationWriter" />.</summary>
		/// <param name="o">The <see cref="T:System.Object" /> to serialize. </param>
		/// <param name="writer">The <see cref="T:System.Xml.Serialization.XmlSerializationWriter" /> used to write the XML document. </param>
		/// <exception cref="T:System.NotImplementedException">Any attempt is made to access the method when the method is not overridden in a descendant class. </exception>
		// Token: 0x06001144 RID: 4420 RVA: 0x0006D474 File Offset: 0x0006B674
		protected virtual void Serialize(object o, XmlSerializationWriter writer)
		{
			if (this.customSerializer)
			{
				throw new NotImplementedException();
			}
			if (writer is XmlSerializationWriterInterpreter)
			{
				((XmlSerializationWriterInterpreter)writer).WriteRoot(o);
				return;
			}
			try
			{
				this.serializerData.WriterMethod.Invoke(writer, new object[]
				{
					o
				});
			}
			catch (TargetInvocationException ex)
			{
				throw ex.InnerException;
			}
		}

		/// <summary>Serializes the specified <see cref="T:System.Object" /> and writes the XML document to a file using the specified <see cref="T:System.IO.TextWriter" />.</summary>
		/// <param name="textWriter">The <see cref="T:System.IO.TextWriter" /> used to write the XML document. </param>
		/// <param name="o">The <see cref="T:System.Object" /> to serialize. </param>
		// Token: 0x06001145 RID: 4421 RVA: 0x0006D4DC File Offset: 0x0006B6DC
		public void Serialize(TextWriter textWriter, object o)
		{
			this.Serialize(new XmlTextWriter(textWriter)
			{
				Formatting = Formatting.Indented
			}, o, null);
		}

		/// <summary>Serializes the specified <see cref="T:System.Object" /> and writes the XML document to a file using the specified <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="xmlWriter">The <see cref="T:System.Xml.XmlWriter" /> used to write the XML document. </param>
		/// <param name="o">The <see cref="T:System.Object" /> to serialize. </param>
		/// <exception cref="T:System.InvalidOperationException">An error occurred during serialization. The original exception is available using the <see cref="P:System.Exception.InnerException" /> property. </exception>
		// Token: 0x06001146 RID: 4422 RVA: 0x0006D500 File Offset: 0x0006B700
		public void Serialize(XmlWriter xmlWriter, object o)
		{
			this.Serialize(xmlWriter, o, null);
		}

		/// <summary>Serializes the specified <see cref="T:System.Object" /> and writes the XML document to a file using the specified <see cref="T:System.Xml.XmlWriter" /> and references the specified namespaces.</summary>
		/// <param name="xmlWriter">The <see cref="T:System.Xml.XmlWriter" /> used to write the XML document. </param>
		/// <param name="o">The <see cref="T:System.Object" /> to serialize. </param>
		/// <param name="namespaces">The <see cref="T:System.Xml.Serialization.XmlSerializerNamespaces" /> referenced by the object. </param>
		/// <exception cref="T:System.InvalidOperationException">An error occurred during serialization. The original exception is available using the <see cref="P:System.Exception.InnerException" /> property. </exception>
		// Token: 0x06001147 RID: 4423 RVA: 0x0006D50C File Offset: 0x0006B70C
		public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces)
		{
			try
			{
				XmlSerializationWriter xmlSerializationWriter;
				if (this.customSerializer)
				{
					xmlSerializationWriter = this.CreateWriter();
				}
				else
				{
					xmlSerializationWriter = this.CreateWriter(this.typeMapping);
				}
				if (namespaces == null || namespaces.Count == 0)
				{
					namespaces = new XmlSerializerNamespaces();
					namespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
					namespaces.Add("xsd", "http://www.w3.org/2001/XMLSchema");
				}
				xmlSerializationWriter.Initialize(xmlWriter, namespaces);
				this.Serialize(o, xmlSerializationWriter);
				xmlWriter.Flush();
			}
			catch (Exception innerException)
			{
				if (innerException is TargetInvocationException)
				{
					innerException = innerException.InnerException;
				}
				if (innerException is InvalidOperationException || innerException is InvalidCastException)
				{
					throw new InvalidOperationException("There was an error generating the XML document.", innerException);
				}
				throw;
			}
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x0006D5C0 File Offset: 0x0006B7C0
		private XmlSerializationWriter CreateWriter(XmlMapping typeMapping)
		{
			lock (this)
			{
				if (this.serializerData != null)
				{
					XmlSerializer.SerializerData obj = this.serializerData;
					XmlSerializationWriter xmlSerializationWriter;
					lock (obj)
					{
						xmlSerializationWriter = this.serializerData.CreateWriter();
					}
					if (xmlSerializationWriter != null)
					{
						return xmlSerializationWriter;
					}
				}
			}
			return new XmlSerializationWriterInterpreter(typeMapping);
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x0006D648 File Offset: 0x0006B848
		private XmlSerializationReader CreateReader(XmlMapping typeMapping)
		{
			return new XmlSerializationReaderInterpreter(typeMapping);
		}

		// Token: 0x04000BD7 RID: 3031
		private static int generationThreshold;

		// Token: 0x04000BD8 RID: 3032
		private static bool backgroundGeneration = true;

		// Token: 0x04000BD9 RID: 3033
		private static bool deleteTempFiles = true;

		// Token: 0x04000BDA RID: 3034
		private static bool generatorFallback = true;

		// Token: 0x04000BDB RID: 3035
		private bool customSerializer;

		// Token: 0x04000BDC RID: 3036
		private XmlMapping typeMapping;

		// Token: 0x04000BDD RID: 3037
		private XmlSerializer.SerializerData serializerData;

		// Token: 0x04000BDE RID: 3038
		private static Hashtable serializerTypes = new Hashtable();

		// Token: 0x04000BDF RID: 3039
		private UnreferencedObjectEventHandler onUnreferencedObject;

		// Token: 0x04000BE0 RID: 3040
		private XmlAttributeEventHandler onUnknownAttribute;

		// Token: 0x04000BE1 RID: 3041
		private XmlElementEventHandler onUnknownElement;

		// Token: 0x04000BE2 RID: 3042
		private XmlNodeEventHandler onUnknownNode;

		// Token: 0x02000208 RID: 520
		internal class SerializerData
		{
			// Token: 0x0600114A RID: 4426 RVA: 0x0006D650 File Offset: 0x0006B850
			public XmlSerializationWriter CreateWriter()
			{
				if (this.WriterType != null)
				{
					return (XmlSerializationWriter)Activator.CreateInstance(this.WriterType);
				}
				if (this.Implementation != null)
				{
					return this.Implementation.Writer;
				}
				return null;
			}

			// Token: 0x04000BE3 RID: 3043
			public MethodInfo ReaderMethod;

			// Token: 0x04000BE4 RID: 3044
			public Type WriterType;

			// Token: 0x04000BE5 RID: 3045
			public MethodInfo WriterMethod;

			// Token: 0x04000BE6 RID: 3046
			public XmlSerializerImplementation Implementation;
		}
	}
}
