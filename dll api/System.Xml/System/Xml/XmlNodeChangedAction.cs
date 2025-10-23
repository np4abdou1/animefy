using System;

namespace System.Xml
{
	/// <summary>Specifies the type of node change.</summary>
	// Token: 0x02000143 RID: 323
	public enum XmlNodeChangedAction
	{
		/// <summary>A node is being inserted in the tree.</summary>
		// Token: 0x040008AF RID: 2223
		Insert,
		/// <summary>A node is being removed from the tree.</summary>
		// Token: 0x040008B0 RID: 2224
		Remove,
		/// <summary>A node value is being changed.</summary>
		// Token: 0x040008B1 RID: 2225
		Change
	}
}
