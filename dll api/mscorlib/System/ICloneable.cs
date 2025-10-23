using System;

namespace System
{
	/// <summary>Supports cloning, which creates a new instance of a class with the same value as an existing instance.</summary>
	// Token: 0x020000B8 RID: 184
	public interface ICloneable
	{
		/// <summary>Creates a new object that is a copy of the current instance.</summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		// Token: 0x06000622 RID: 1570
		object Clone();
	}
}
