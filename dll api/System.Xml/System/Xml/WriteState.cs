using System;

namespace System.Xml
{
	/// <summary>Specifies the state of the <see cref="T:System.Xml.XmlWriter" />.</summary>
	// Token: 0x02000120 RID: 288
	public enum WriteState
	{
		/// <summary>Indicates that a Write method has not yet been called.</summary>
		// Token: 0x040007BE RID: 1982
		Start,
		/// <summary>Indicates that the prolog is being written.</summary>
		// Token: 0x040007BF RID: 1983
		Prolog,
		/// <summary>Indicates that an element start tag is being written.</summary>
		// Token: 0x040007C0 RID: 1984
		Element,
		/// <summary>Indicates that an attribute value is being written.</summary>
		// Token: 0x040007C1 RID: 1985
		Attribute,
		/// <summary>Indicates that element content is being written.</summary>
		// Token: 0x040007C2 RID: 1986
		Content,
		/// <summary>Indicates that the <see cref="M:System.Xml.XmlWriter.Close" /> method has been called.</summary>
		// Token: 0x040007C3 RID: 1987
		Closed,
		/// <summary>An exception has been thrown, which has left the <see cref="T:System.Xml.XmlWriter" /> in an invalid state. You can call the <see cref="M:System.Xml.XmlWriter.Close" /> method to put the <see cref="T:System.Xml.XmlWriter" /> in the <see cref="F:System.Xml.WriteState.Closed" /> state. Any other <see cref="T:System.Xml.XmlWriter" /> method calls results in an <see cref="T:System.InvalidOperationException" />.</summary>
		// Token: 0x040007C4 RID: 1988
		Error
	}
}
