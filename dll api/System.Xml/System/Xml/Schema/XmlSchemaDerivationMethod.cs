using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>Provides different methods for preventing derivation.</summary>
	// Token: 0x020002E7 RID: 743
	[Flags]
	public enum XmlSchemaDerivationMethod
	{
		/// <summary>Override default derivation method to allow any derivation.</summary>
		// Token: 0x04001084 RID: 4228
		[XmlEnum("")]
		Empty = 0,
		/// <summary>Refers to derivations by <see langword="Substitution" />.</summary>
		// Token: 0x04001085 RID: 4229
		[XmlEnum("substitution")]
		Substitution = 1,
		/// <summary>Refers to derivations by <see langword="Extension" />.</summary>
		// Token: 0x04001086 RID: 4230
		[XmlEnum("extension")]
		Extension = 2,
		/// <summary>Refers to derivations by <see langword="Restriction" />.</summary>
		// Token: 0x04001087 RID: 4231
		[XmlEnum("restriction")]
		Restriction = 4,
		/// <summary>Refers to derivations by <see langword="List" />.</summary>
		// Token: 0x04001088 RID: 4232
		[XmlEnum("list")]
		List = 8,
		/// <summary>Refers to derivations by <see langword="Union" />.</summary>
		// Token: 0x04001089 RID: 4233
		[XmlEnum("union")]
		Union = 16,
		/// <summary>
		///     <see langword="#all" />. Refers to all derivation methods.</summary>
		// Token: 0x0400108A RID: 4234
		[XmlEnum("#all")]
		All = 255,
		/// <summary>Accepts the default derivation method.</summary>
		// Token: 0x0400108B RID: 4235
		[XmlIgnore]
		None = 256
	}
}
