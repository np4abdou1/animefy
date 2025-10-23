using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace System.Xml
{
	/// <summary>Represents an ordered collection of nodes.</summary>
	// Token: 0x0200014F RID: 335
	public abstract class XmlNodeList : IEnumerable, IDisposable
	{
		/// <summary>Retrieves a node at the given index.</summary>
		/// <param name="index">The zero-based index into the list of nodes.</param>
		/// <returns>The <see cref="T:System.Xml.XmlNode" /> with the specified index in the collection. If <paramref name="index" /> is greater than or equal to the number of nodes in the list, this returns <see langword="null" />.</returns>
		// Token: 0x06000C35 RID: 3125
		public abstract XmlNode Item(int index);

		/// <summary>Gets the number of nodes in the <see langword="XmlNodeList" />.</summary>
		/// <returns>The number of nodes in the <see langword="XmlNodeList" />.</returns>
		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000C36 RID: 3126
		public abstract int Count { get; }

		/// <summary>Gets an enumerator that iterates through the collection of nodes.</summary>
		/// <returns>An enumerator used to iterate through the collection of nodes.</returns>
		// Token: 0x06000C37 RID: 3127
		public abstract IEnumerator GetEnumerator();

		/// <summary>Gets a node at the given index.</summary>
		/// <param name="i">The zero-based index into the list of nodes.</param>
		/// <returns>The <see cref="T:System.Xml.XmlNode" /> with the specified index in the collection. If index is greater than or equal to the number of nodes in the list, this returns <see langword="null" />.</returns>
		// Token: 0x1700026F RID: 623
		[IndexerName("ItemOf")]
		public virtual XmlNode this[int i]
		{
			get
			{
				return this.Item(i);
			}
		}

		/// <summary>Releases all resources used by the <see cref="T:System.Xml.XmlNodeList" /> class.</summary>
		// Token: 0x06000C39 RID: 3129 RVA: 0x0004C728 File Offset: 0x0004A928
		void IDisposable.Dispose()
		{
			this.PrivateDisposeNodeList();
		}

		/// <summary>Disposes resources in the node list privately.</summary>
		// Token: 0x06000C3A RID: 3130 RVA: 0x00008574 File Offset: 0x00006774
		protected virtual void PrivateDisposeNodeList()
		{
		}
	}
}
