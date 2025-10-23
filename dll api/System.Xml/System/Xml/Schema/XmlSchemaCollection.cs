using System;
using System.Collections;
using System.Threading;
using System.Xml.XmlConfiguration;

namespace System.Xml.Schema
{
	/// <summary>Contains a cache of XML Schema definition language (XSD) and XML-Data Reduced (XDR) schemas. The <see cref="T:System.Xml.Schema.XmlSchemaCollection" /> class class is obsolete. Use <see cref="T:System.Xml.Schema.XmlSchemaSet" /> instead.</summary>
	// Token: 0x020002DA RID: 730
	public sealed class XmlSchemaCollection : ICollection, IEnumerable
	{
		/// <summary>Initializes a new instance of the <see langword="XmlSchemaCollection" /> class with the specified <see cref="T:System.Xml.XmlNameTable" />. The <see langword="XmlNameTable" /> is used when loading schemas.</summary>
		/// <param name="nametable">The <see langword="XmlNameTable" /> to use. </param>
		// Token: 0x0600186B RID: 6251 RVA: 0x00096484 File Offset: 0x00094684
		public XmlSchemaCollection(XmlNameTable nametable)
		{
			if (nametable == null)
			{
				throw new ArgumentNullException("nametable");
			}
			this.nameTable = nametable;
			this.collection = Hashtable.Synchronized(new Hashtable());
			this.xmlResolver = XmlReaderSection.CreateDefaultResolver();
			this.isThreadSafe = true;
			if (this.isThreadSafe)
			{
				this.wLock = new ReaderWriterLock();
			}
		}

		/// <summary>Gets the number of namespaces defined in this collection.</summary>
		/// <returns>The number of namespaces defined in this collection.</returns>
		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x0600186C RID: 6252 RVA: 0x000964EF File Offset: 0x000946EF
		public int Count
		{
			get
			{
				return this.collection.Count;
			}
		}

		/// <summary>Gets the default <see langword="XmlNameTable" /> used by the <see langword="XmlSchemaCollection" /> when loading new schemas.</summary>
		/// <returns>An <see langword="XmlNameTable" />.</returns>
		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x0600186D RID: 6253 RVA: 0x000964FC File Offset: 0x000946FC
		public XmlNameTable NameTable
		{
			get
			{
				return this.nameTable;
			}
		}

		// Token: 0x1700058F RID: 1423
		// (set) Token: 0x0600186E RID: 6254 RVA: 0x00096504 File Offset: 0x00094704
		internal XmlResolver XmlResolver
		{
			set
			{
				this.xmlResolver = value;
			}
		}

		/// <summary>Gets the <see cref="T:System.Xml.Schema.XmlSchema" /> associated with the given namespace URI.</summary>
		/// <param name="ns">The namespace URI associated with the schema you want to return. This will typically be the <see langword="targetNamespace" /> of the schema. </param>
		/// <returns>The <see langword="XmlSchema" /> associated with the namespace URI; <see langword="null" /> if there is no loaded schema associated with the given namespace or if the namespace is associated with an XDR schema.</returns>
		// Token: 0x17000590 RID: 1424
		public XmlSchema this[string ns]
		{
			get
			{
				XmlSchemaCollectionNode xmlSchemaCollectionNode = (XmlSchemaCollectionNode)this.collection[(ns != null) ? ns : string.Empty];
				if (xmlSchemaCollectionNode == null)
				{
					return null;
				}
				return xmlSchemaCollectionNode.Schema;
			}
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.Schema.XmlSchemaCollection.GetEnumerator" />.</summary>
		/// <returns>Returns the <see cref="T:System.Collections.IEnumerator" /> for the collection.</returns>
		// Token: 0x06001870 RID: 6256 RVA: 0x00096544 File Offset: 0x00094744
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new XmlSchemaCollectionEnumerator(this.collection);
		}

		/// <summary>Provides support for the "for each" style iteration over the collection of schemas.</summary>
		/// <returns>An enumerator for iterating over all schemas in the current collection.</returns>
		// Token: 0x06001871 RID: 6257 RVA: 0x00096544 File Offset: 0x00094744
		public XmlSchemaCollectionEnumerator GetEnumerator()
		{
			return new XmlSchemaCollectionEnumerator(this.collection);
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.Schema.XmlSchemaCollection.CopyTo(System.Xml.Schema.XmlSchema[],System.Int32)" />.</summary>
		/// <param name="array">The array to copy the objects to. </param>
		/// <param name="index">The index in <paramref name="array" /> where copying will begin. </param>
		// Token: 0x06001872 RID: 6258 RVA: 0x00096554 File Offset: 0x00094754
		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			XmlSchemaCollectionEnumerator enumerator = this.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (index == array.Length && array.IsFixedSize)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				array.SetValue(enumerator.Current, index++);
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.Xml.Schema.XmlSchemaCollection.System#Collections#ICollection#IsSynchronized" />.</summary>
		/// <returns>Returns <see langword="true" /> if the collection is synchronized, otherwise <see langword="false" />.</returns>
		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x0000C89B File Offset: 0x0000AA9B
		bool ICollection.IsSynchronized
		{
			get
			{
				return true;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.Xml.Schema.XmlSchemaCollection.System#Collections#ICollection#SyncRoot" />.</summary>
		/// <returns>Returns a <see cref="P:System.Collections.ICollection.SyncRoot" /> object that can be used to synchronize access to the collection.</returns>
		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001874 RID: 6260 RVA: 0x00044153 File Offset: 0x00042353
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		/// <summary>For a description of this member, see <see cref="P:System.Xml.Schema.XmlSchemaCollection.Count" />.</summary>
		/// <returns>Returns the count of the items in the collection.</returns>
		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001875 RID: 6261 RVA: 0x000964EF File Offset: 0x000946EF
		int ICollection.Count
		{
			get
			{
				return this.collection.Count;
			}
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x000965C0 File Offset: 0x000947C0
		internal SchemaInfo GetSchemaInfo(string ns)
		{
			XmlSchemaCollectionNode xmlSchemaCollectionNode = (XmlSchemaCollectionNode)this.collection[(ns != null) ? ns : string.Empty];
			if (xmlSchemaCollectionNode == null)
			{
				return null;
			}
			return xmlSchemaCollectionNode.SchemaInfo;
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x000965F4 File Offset: 0x000947F4
		internal SchemaNames GetSchemaNames(XmlNameTable nt)
		{
			if (this.nameTable != nt)
			{
				return new SchemaNames(nt);
			}
			if (this.schemaNames == null)
			{
				this.schemaNames = new SchemaNames(this.nameTable);
			}
			return this.schemaNames;
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x00096625 File Offset: 0x00094825
		internal XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile)
		{
			return this.Add(ns, schemaInfo, schema, compile, this.xmlResolver);
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x00096638 File Offset: 0x00094838
		private XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile, XmlResolver resolver)
		{
			int num = 0;
			if (schema != null)
			{
				if (schema.ErrorCount == 0 && compile)
				{
					if (!schema.CompileSchema(this, resolver, schemaInfo, ns, this.validationEventHandler, this.nameTable, true))
					{
						num = 1;
					}
					ns = ((schema.TargetNamespace == null) ? string.Empty : schema.TargetNamespace);
				}
				num += schema.ErrorCount;
			}
			else
			{
				num += schemaInfo.ErrorCount;
				ns = this.NameTable.Add(ns);
			}
			if (num == 0)
			{
				this.Add(ns, new XmlSchemaCollectionNode
				{
					NamespaceURI = ns,
					SchemaInfo = schemaInfo,
					Schema = schema
				});
				return schema;
			}
			return null;
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x000966D8 File Offset: 0x000948D8
		private void Add(string ns, XmlSchemaCollectionNode node)
		{
			if (this.isThreadSafe)
			{
				this.wLock.AcquireWriterLock(this.timeout);
			}
			try
			{
				if (this.collection[ns] != null)
				{
					this.collection.Remove(ns);
				}
				this.collection.Add(ns, node);
			}
			finally
			{
				if (this.isThreadSafe)
				{
					this.wLock.ReleaseWriterLock();
				}
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x0600187B RID: 6267 RVA: 0x0009674C File Offset: 0x0009494C
		// (set) Token: 0x0600187C RID: 6268 RVA: 0x00096754 File Offset: 0x00094954
		internal ValidationEventHandler EventHandler
		{
			get
			{
				return this.validationEventHandler;
			}
			set
			{
				this.validationEventHandler = value;
			}
		}

		// Token: 0x04001053 RID: 4179
		private Hashtable collection;

		// Token: 0x04001054 RID: 4180
		private XmlNameTable nameTable;

		// Token: 0x04001055 RID: 4181
		private SchemaNames schemaNames;

		// Token: 0x04001056 RID: 4182
		private ReaderWriterLock wLock;

		// Token: 0x04001057 RID: 4183
		private int timeout = -1;

		// Token: 0x04001058 RID: 4184
		private bool isThreadSafe = true;

		// Token: 0x04001059 RID: 4185
		private ValidationEventHandler validationEventHandler;

		// Token: 0x0400105A RID: 4186
		private XmlResolver xmlResolver;
	}
}
