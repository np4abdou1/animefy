using System;

namespace System.ComponentModel
{
	/// <summary>Defines the mechanism for querying the object for changes and resetting of the changed status.</summary>
	// Token: 0x0200028E RID: 654
	public interface IChangeTracking
	{
		/// <summary>Gets the object's changed status.</summary>
		/// <returns>
		///     <see langword="true" /> if the object’s content has changed since the last call to <see cref="M:System.ComponentModel.IChangeTracking.AcceptChanges" />; otherwise, <see langword="false" />.</returns>
		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001170 RID: 4464
		bool IsChanged { get; }

		/// <summary>Resets the object’s state to unchanged by accepting the modifications.</summary>
		// Token: 0x06001171 RID: 4465
		void AcceptChanges();
	}
}
