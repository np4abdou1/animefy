using System;
using System.Collections;

namespace System.Xml.Schema
{
	/// <summary>Represents the enumerator for the <see cref="T:System.Xml.Schema.XmlSchemaObjectCollection" />.</summary>
	// Token: 0x0200030A RID: 778
	public class XmlSchemaObjectEnumerator : IEnumerator
	{
		// Token: 0x060019DF RID: 6623 RVA: 0x00098419 File Offset: 0x00096619
		internal XmlSchemaObjectEnumerator(IEnumerator enumerator)
		{
			this.enumerator = enumerator;
		}

		/// <summary>Moves to the next item in the collection.</summary>
		/// <returns>
		///     <see langword="false" /> at the end of the collection.</returns>
		// Token: 0x060019E0 RID: 6624 RVA: 0x00098428 File Offset: 0x00096628
		public bool MoveNext()
		{
			return this.enumerator.MoveNext();
		}

		/// <summary>Gets the current <see cref="T:System.Xml.Schema.XmlSchemaObject" /> in the collection.</summary>
		/// <returns>The current <see cref="T:System.Xml.Schema.XmlSchemaObject" />.</returns>
		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x060019E1 RID: 6625 RVA: 0x00098435 File Offset: 0x00096635
		public XmlSchemaObject Current
		{
			get
			{
				return (XmlSchemaObject)this.enumerator.Current;
			}
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.Schema.XmlSchemaObjectEnumerator.Reset" />.</summary>
		// Token: 0x060019E2 RID: 6626 RVA: 0x00098447 File Offset: 0x00096647
		void IEnumerator.Reset()
		{
			this.enumerator.Reset();
		}

		/// <summary>For a description of this member, see <see cref="M:System.Xml.Schema.XmlSchemaObjectEnumerator.MoveNext" />.</summary>
		/// <returns>The next <see cref="T:System.Xml.Schema.XmlSchemaObject" />.</returns>
		// Token: 0x060019E3 RID: 6627 RVA: 0x00098428 File Offset: 0x00096628
		bool IEnumerator.MoveNext()
		{
			return this.enumerator.MoveNext();
		}

		/// <summary>For a description of this member, see <see cref="P:System.Xml.Schema.XmlSchemaObjectEnumerator.Current" />.</summary>
		/// <returns>The current <see cref="T:System.Xml.Schema.XmlSchemaObject" />.</returns>
		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x060019E4 RID: 6628 RVA: 0x00098454 File Offset: 0x00096654
		object IEnumerator.Current
		{
			get
			{
				return this.enumerator.Current;
			}
		}

		// Token: 0x040010ED RID: 4333
		private IEnumerator enumerator;
	}
}
