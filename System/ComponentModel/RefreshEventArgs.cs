using System;

namespace System.ComponentModel
{
	/// <summary>Provides data for the <see cref="E:System.ComponentModel.TypeDescriptor.Refreshed" /> event.</summary>
	// Token: 0x02000281 RID: 641
	public class RefreshEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.RefreshEventArgs" /> class with the type of component that has changed.</summary>
		/// <param name="typeChanged">The <see cref="T:System.Type" /> that changed. </param>
		// Token: 0x06001136 RID: 4406 RVA: 0x00051BA2 File Offset: 0x0004FDA2
		public RefreshEventArgs(Type typeChanged)
		{
			this.<TypeChanged>k__BackingField = typeChanged;
		}
	}
}
