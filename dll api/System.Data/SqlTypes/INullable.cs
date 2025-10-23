using System;

namespace System.Data.SqlTypes
{
	/// <summary>All the <see cref="N:System.Data.SqlTypes" /> objects and structures implement the <see langword="INullable" /> interface. </summary>
	// Token: 0x020000AD RID: 173
	public interface INullable
	{
		/// <summary>Indicates whether a structure is null. This property is read-only.</summary>
		/// <returns>
		///     <see cref="T:System.Data.SqlTypes.SqlBoolean" />
		///     <see langword="true" /> if the value of this object is null. Otherwise, <see langword="false" />.</returns>
		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000A25 RID: 2597
		bool IsNull { get; }
	}
}
