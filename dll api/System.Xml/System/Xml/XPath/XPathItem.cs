using System;
using System.Xml.Schema;

namespace System.Xml.XPath
{
	/// <summary>Represents an item in the XQuery 1.0 and XPath 2.0 Data Model.</summary>
	// Token: 0x020001C2 RID: 450
	public abstract class XPathItem
	{
		/// <summary>When overridden in a derived class, gets the <see cref="T:System.Xml.Schema.XmlSchemaType" /> for the item.</summary>
		/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaType" /> for the item.</returns>
		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000F52 RID: 3922
		public abstract XmlSchemaType XmlType { get; }

		/// <summary>When overridden in a derived class, gets the <see langword="string" /> value of the item.</summary>
		/// <returns>The <see langword="string" /> value of the item.</returns>
		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000F53 RID: 3923
		public abstract string Value { get; }

		/// <summary>When overridden in a derived class, gets the current item as a boxed object of the most appropriate .NET Framework 2.0 type according to its schema type.</summary>
		/// <returns>The current item as a boxed object of the most appropriate .NET Framework type.</returns>
		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000F54 RID: 3924
		public abstract object TypedValue { get; }

		/// <summary>When overridden in a derived class, gets the .NET Framework 2.0 type of the item.</summary>
		/// <returns>The .NET Framework type of the item. The default value is <see cref="T:System.String" />.</returns>
		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000F55 RID: 3925
		public abstract Type ValueType { get; }

		/// <summary>When overridden in a derived class, gets the item's value as a <see cref="T:System.Boolean" />.</summary>
		/// <returns>The item's value as a <see cref="T:System.Boolean" />.</returns>
		/// <exception cref="T:System.FormatException">The item's value is not in the correct format for the <see cref="T:System.Boolean" /> type.</exception>
		/// <exception cref="T:System.InvalidCastException">The attempted cast to <see cref="T:System.Boolean" /> is not valid.</exception>
		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000F56 RID: 3926
		public abstract bool ValueAsBoolean { get; }

		/// <summary>When overridden in a derived class, gets the item's value as a <see cref="T:System.DateTime" />.</summary>
		/// <returns>The item's value as a <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.FormatException">The item's value is not in the correct format for the <see cref="T:System.DateTime" /> type.</exception>
		/// <exception cref="T:System.InvalidCastException">The attempted cast to <see cref="T:System.DateTime" /> is not valid.</exception>
		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000F57 RID: 3927
		public abstract DateTime ValueAsDateTime { get; }

		/// <summary>When overridden in a derived class, gets the item's value as a <see cref="T:System.Double" />.</summary>
		/// <returns>The item's value as a <see cref="T:System.Double" />.</returns>
		/// <exception cref="T:System.FormatException">The item's value is not in the correct format for the <see cref="T:System.Double" /> type.</exception>
		/// <exception cref="T:System.InvalidCastException">The attempted cast to <see cref="T:System.Double" /> is not valid.</exception>
		/// <exception cref="T:System.OverflowException">The attempted cast resulted in an overflow.</exception>
		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000F58 RID: 3928
		public abstract double ValueAsDouble { get; }

		/// <summary>When overridden in a derived class, gets the item's value as an <see cref="T:System.Int32" />.</summary>
		/// <returns>The item's value as an <see cref="T:System.Int32" />.</returns>
		/// <exception cref="T:System.FormatException">The item's value is not in the correct format for the <see cref="T:System.Int32" /> type.</exception>
		/// <exception cref="T:System.InvalidCastException">The attempted cast to <see cref="T:System.Int32" /> is not valid.</exception>
		/// <exception cref="T:System.OverflowException">The attempted cast resulted in an overflow.</exception>
		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000F59 RID: 3929
		public abstract int ValueAsInt { get; }

		/// <summary>When overridden in a derived class, gets the item's value as an <see cref="T:System.Int64" />.</summary>
		/// <returns>The item's value as an <see cref="T:System.Int64" />.</returns>
		/// <exception cref="T:System.FormatException">The item's value is not in the correct format for the <see cref="T:System.Int64" /> type.</exception>
		/// <exception cref="T:System.InvalidCastException">The attempted cast to <see cref="T:System.Int64" /> is not valid.</exception>
		/// <exception cref="T:System.OverflowException">The attempted cast resulted in an overflow.</exception>
		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000F5A RID: 3930
		public abstract long ValueAsLong { get; }

		/// <summary>Returns the item's value as the specified type.</summary>
		/// <param name="returnType">The type to return the item value as.</param>
		/// <returns>The value of the item as the type requested.</returns>
		/// <exception cref="T:System.FormatException">The item's value is not in the correct format for the target type.</exception>
		/// <exception cref="T:System.InvalidCastException">The attempted cast is not valid.</exception>
		/// <exception cref="T:System.OverflowException">The attempted cast resulted in an overflow.</exception>
		// Token: 0x06000F5B RID: 3931 RVA: 0x0006229B File Offset: 0x0006049B
		public virtual object ValueAs(Type returnType)
		{
			return this.ValueAs(returnType, null);
		}

		/// <summary>When overridden in a derived class, returns the item's value as the type specified using the <see cref="T:System.Xml.IXmlNamespaceResolver" /> object specified to resolve namespace prefixes.</summary>
		/// <param name="returnType">The type to return the item's value as.</param>
		/// <param name="nsResolver">The <see cref="T:System.Xml.IXmlNamespaceResolver" /> object used to resolve namespace prefixes.</param>
		/// <returns>The value of the item as the type requested.</returns>
		/// <exception cref="T:System.FormatException">The item's value is not in the correct format for the target type.</exception>
		/// <exception cref="T:System.InvalidCastException">The attempted cast is not valid.</exception>
		/// <exception cref="T:System.OverflowException">The attempted cast resulted in an overflow.</exception>
		// Token: 0x06000F5C RID: 3932
		public abstract object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver);
	}
}
