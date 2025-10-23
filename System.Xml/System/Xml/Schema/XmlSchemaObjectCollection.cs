using System;
using System.Collections;

namespace System.Xml.Schema
{
	/// <summary>A collection of <see cref="T:System.Xml.Schema.XmlSchemaObject" />s.</summary>
	// Token: 0x02000309 RID: 777
	public class XmlSchemaObjectCollection : CollectionBase
	{
		/// <summary>Gets the <see cref="T:System.Xml.Schema.XmlSchemaObject" /> at the specified index.</summary>
		/// <param name="index">The index of the <see cref="T:System.Xml.Schema.XmlSchemaObject" />. </param>
		/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaObject" /> at the specified index.</returns>
		// Token: 0x1700061E RID: 1566
		public virtual XmlSchemaObject this[int index]
		{
			get
			{
				return (XmlSchemaObject)base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		/// <summary>Returns an enumerator for iterating through the <see langword="XmlSchemaObjects" /> contained in the <see langword="XmlSchemaObjectCollection" />.</summary>
		/// <returns>The iterator returns <see cref="T:System.Xml.Schema.XmlSchemaObjectEnumerator" />.</returns>
		// Token: 0x060019D5 RID: 6613 RVA: 0x00098365 File Offset: 0x00096565
		public new XmlSchemaObjectEnumerator GetEnumerator()
		{
			return new XmlSchemaObjectEnumerator(base.InnerList.GetEnumerator());
		}

		/// <summary>Adds an <see cref="T:System.Xml.Schema.XmlSchemaObject" /> to the <see langword="XmlSchemaObjectCollection" />.</summary>
		/// <param name="item">The <see cref="T:System.Xml.Schema.XmlSchemaObject" />. </param>
		/// <returns>The index at which the item has been added.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or- 
		///         <paramref name="index" /> is greater than <see langword="Count" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The <see cref="T:System.Xml.Schema.XmlSchemaObject" /> parameter specified is not of type <see cref="T:System.Xml.Schema.XmlSchemaExternal" /> or its derived types <see cref="T:System.Xml.Schema.XmlSchemaImport" />, <see cref="T:System.Xml.Schema.XmlSchemaInclude" />, and <see cref="T:System.Xml.Schema.XmlSchemaRedefine" />.</exception>
		// Token: 0x060019D6 RID: 6614 RVA: 0x000647F6 File Offset: 0x000629F6
		public int Add(XmlSchemaObject item)
		{
			return base.List.Add(item);
		}

		/// <summary>Inserts an <see cref="T:System.Xml.Schema.XmlSchemaObject" /> to the <see langword="XmlSchemaObjectCollection" />.</summary>
		/// <param name="index">The zero-based index at which an item should be inserted. </param>
		/// <param name="item">The <see cref="T:System.Xml.Schema.XmlSchemaObject" /> to insert. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///         <paramref name="index" /> is less than zero.-or- 
		///         <paramref name="index" /> is greater than <see langword="Count" />. </exception>
		// Token: 0x060019D7 RID: 6615 RVA: 0x00098377 File Offset: 0x00096577
		public void Insert(int index, XmlSchemaObject item)
		{
			base.List.Insert(index, item);
		}

		/// <summary>Removes an <see cref="T:System.Xml.Schema.XmlSchemaObject" /> from the <see langword="XmlSchemaObjectCollection" />.</summary>
		/// <param name="item">The <see cref="T:System.Xml.Schema.XmlSchemaObject" /> to remove. </param>
		// Token: 0x060019D8 RID: 6616 RVA: 0x00098386 File Offset: 0x00096586
		public void Remove(XmlSchemaObject item)
		{
			base.List.Remove(item);
		}

		/// <summary>
		///     <see langword="OnInsert" /> is invoked before the standard <see langword="Insert" /> behavior. For more information, see <see langword="OnInsert" /> method <see cref="T:System.Collections.CollectionBase" />.</summary>
		/// <param name="index">The index of <see cref="T:System.Xml.Schema.XmlSchemaObject" />. </param>
		/// <param name="item">The item. </param>
		// Token: 0x060019D9 RID: 6617 RVA: 0x00098394 File Offset: 0x00096594
		protected override void OnInsert(int index, object item)
		{
			if (this.parent != null)
			{
				this.parent.OnAdd(this, item);
			}
		}

		/// <summary>
		///     <see langword="OnSet" /> is invoked before the standard <see langword="Set" /> behavior. For more information, see the OnSet method for <see cref="T:System.Collections.CollectionBase" />.</summary>
		/// <param name="index">The index of <see cref="T:System.Xml.Schema.XmlSchemaObject" />. </param>
		/// <param name="oldValue">The old value. </param>
		/// <param name="newValue">The new value. </param>
		// Token: 0x060019DA RID: 6618 RVA: 0x000983AB File Offset: 0x000965AB
		protected override void OnSet(int index, object oldValue, object newValue)
		{
			if (this.parent != null)
			{
				this.parent.OnRemove(this, oldValue);
				this.parent.OnAdd(this, newValue);
			}
		}

		/// <summary>
		///     <see langword="OnClear" /> is invoked before the standard <see langword="Clear" /> behavior. For more information, see OnClear method for <see cref="T:System.Collections.CollectionBase" />.</summary>
		// Token: 0x060019DB RID: 6619 RVA: 0x000983CF File Offset: 0x000965CF
		protected override void OnClear()
		{
			if (this.parent != null)
			{
				this.parent.OnClear(this);
			}
		}

		/// <summary>
		///     <see langword="OnRemove" /> is invoked before the standard <see langword="Remove" /> behavior. For more information, see the <see langword="OnRemove" /> method for <see cref="T:System.Collections.CollectionBase" />.</summary>
		/// <param name="index">The index of <see cref="T:System.Xml.Schema.XmlSchemaObject" />. </param>
		/// <param name="item">The item. </param>
		// Token: 0x060019DC RID: 6620 RVA: 0x000983E5 File Offset: 0x000965E5
		protected override void OnRemove(int index, object item)
		{
			if (this.parent != null)
			{
				this.parent.OnRemove(this, item);
			}
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x000983FC File Offset: 0x000965FC
		internal XmlSchemaObjectCollection Clone()
		{
			return new XmlSchemaObjectCollection
			{
				this
			};
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x0009840A File Offset: 0x0009660A
		private void Add(XmlSchemaObjectCollection collToAdd)
		{
			base.InnerList.InsertRange(0, collToAdd);
		}

		// Token: 0x040010EC RID: 4332
		private XmlSchemaObject parent;
	}
}
