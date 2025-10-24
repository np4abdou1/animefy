using System;

namespace System.ComponentModel
{
	/// <summary>Provides data for the <see cref="E:System.ComponentModel.INotifyPropertyChanging.PropertyChanging" /> event. </summary>
	// Token: 0x02000294 RID: 660
	public class PropertyChangingEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyChangingEventArgs" /> class. </summary>
		/// <param name="propertyName">The name of the property whose value is changing.</param>
		// Token: 0x06001178 RID: 4472 RVA: 0x00052038 File Offset: 0x00050238
		public PropertyChangingEventArgs(string propertyName)
		{
			this._propertyName = propertyName;
		}

		// Token: 0x04000C9B RID: 3227
		private readonly string _propertyName;
	}
}
