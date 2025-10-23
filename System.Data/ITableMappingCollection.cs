using System;
using System.Collections;
using System.Reflection;

namespace System.Data
{
	/// <summary>Contains a collection of TableMapping objects, and is implemented by the <see cref="T:System.Data.Common.DataTableMappingCollection" />, which is used in common by .NET Framework data providers.</summary>
	// Token: 0x02000072 RID: 114
	[DefaultMember("Item")]
	public interface ITableMappingCollection : IList, ICollection, IEnumerable
	{
	}
}
