using System;
using System.Collections;

namespace System.Xml.Schema
{
	/// <summary>Supports a simple iteration over a collection. This class cannot be inherited. </summary>
	// Token: 0x020002DC RID: 732
	public sealed class XmlSchemaCollectionEnumerator : IEnumerator
	{
		// Token: 0x06001883 RID: 6275 RVA: 0x00096788 File Offset: 0x00094988
		internal XmlSchemaCollectionEnumerator(Hashtable collection)
		{
			this.enumerator = collection.GetEnumerator();
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.Schema.XmlSchemaCollectionEnumerator.System#Collections#IEnumerator#Reset" />.</summary>
		// Token: 0x06001884 RID: 6276 RVA: 0x0009679C File Offset: 0x0009499C
		void IEnumerator.Reset()
		{
			this.enumerator.Reset();
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.Schema.XmlSchemaCollectionEnumerator.MoveNext" />.</summary>
		/// <returns>Returns the next node.</returns>
		// Token: 0x06001885 RID: 6277 RVA: 0x000967A9 File Offset: 0x000949A9
		bool IEnumerator.MoveNext()
		{
			return this.enumerator.MoveNext();
		}

		/// <summary>Advances the enumerator to the next schema in the collection.</summary>
		/// <returns>
		///     <see langword="true" /> if the move was successful; <see langword="false" /> if the enumerator has passed the end of the collection.</returns>
		// Token: 0x06001886 RID: 6278 RVA: 0x000967A9 File Offset: 0x000949A9
		public bool MoveNext()
		{
			return this.enumerator.MoveNext();
		}

		/// <summary>For a description of this member, see <see cref="P:System.Xml.Schema.XmlSchemaCollectionEnumerator.Current" />.</summary>
		/// <returns>Returns the current node.</returns>
		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001887 RID: 6279 RVA: 0x000967B6 File Offset: 0x000949B6
		object IEnumerator.Current
		{
			get
			{
				return this.Current;
			}
		}

		/// <summary>Gets the current <see cref="T:System.Xml.Schema.XmlSchema" /> in the collection.</summary>
		/// <returns>The current <see langword="XmlSchema" /> in the collection.</returns>
		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001888 RID: 6280 RVA: 0x000967C0 File Offset: 0x000949C0
		public XmlSchema Current
		{
			get
			{
				XmlSchemaCollectionNode xmlSchemaCollectionNode = (XmlSchemaCollectionNode)this.enumerator.Value;
				if (xmlSchemaCollectionNode != null)
				{
					return xmlSchemaCollectionNode.Schema;
				}
				return null;
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001889 RID: 6281 RVA: 0x000967E9 File Offset: 0x000949E9
		internal XmlSchemaCollectionNode CurrentNode
		{
			get
			{
				return (XmlSchemaCollectionNode)this.enumerator.Value;
			}
		}

		// Token: 0x0400105E RID: 4190
		private IDictionaryEnumerator enumerator;
	}
}
