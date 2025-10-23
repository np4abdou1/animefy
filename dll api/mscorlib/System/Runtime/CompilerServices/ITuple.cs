using System;
using System.Reflection;

namespace System.Runtime.CompilerServices
{
	/// <summary>Defines a general-purpose Tuple implementation that allows acccess to Tuple instance members without knowing the underlying Tuple type. </summary>
	// Token: 0x02000449 RID: 1097
	[DefaultMember("Item")]
	public interface ITuple
	{
		/// <summary>Gets the number of elements in this <see langword="Tuple" /> instance. </summary>
		/// <returns>The number of elements in this <see langword="Tuple" /> instance. </returns>
		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06002010 RID: 8208
		int Length { get; }
	}
}
