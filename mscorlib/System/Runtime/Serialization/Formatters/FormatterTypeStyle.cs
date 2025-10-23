using System;

namespace System.Runtime.Serialization.Formatters
{
	/// <summary>Indicates the format in which type descriptions are laid out in the serialized stream.</summary>
	// Token: 0x020003B9 RID: 953
	public enum FormatterTypeStyle
	{
		/// <summary>Indicates that types can be stated only for arrays of objects, object members of type <see cref="T:System.Object" />, and <see cref="T:System.Runtime.Serialization.ISerializable" /> non-primitive value types.</summary>
		// Token: 0x04000C5C RID: 3164
		TypesWhenNeeded,
		/// <summary>Indicates that types can be given to all object members and <see cref="T:System.Runtime.Serialization.ISerializable" /> object members.</summary>
		// Token: 0x04000C5D RID: 3165
		TypesAlways,
		/// <summary>Indicates that strings can be given in the XSD format rather than SOAP. No string IDs are transmitted. </summary>
		// Token: 0x04000C5E RID: 3166
		XsdString
	}
}
