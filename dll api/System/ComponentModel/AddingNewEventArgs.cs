using System;

namespace System.ComponentModel
{
	/// <summary>Provides data for the <see cref="E:System.Windows.Forms.BindingSource.AddingNew" /> event.</summary>
	// Token: 0x02000246 RID: 582
	public class AddingNewEventArgs : EventArgs
	{
		/// <summary>Gets or sets the object to be added to the binding list. </summary>
		/// <returns>The <see cref="T:System.Object" /> to be added as a new item to the associated collection. </returns>
		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000FBF RID: 4031 RVA: 0x0004D81E File Offset: 0x0004BA1E
		public object NewObject { get; }
	}
}
