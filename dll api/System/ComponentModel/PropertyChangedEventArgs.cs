using System;

namespace System.ComponentModel
{
	/// <summary>Provides data for the <see cref="E:System.ComponentModel.INotifyPropertyChanged.PropertyChanged" /> event.</summary>
	// Token: 0x02000292 RID: 658
	public class PropertyChangedEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyChangedEventArgs" /> class.</summary>
		/// <param name="propertyName">The name of the property that changed. </param>
		// Token: 0x06001173 RID: 4467 RVA: 0x00052029 File Offset: 0x00050229
		public PropertyChangedEventArgs(string propertyName)
		{
			this._propertyName = propertyName;
		}

		// Token: 0x04000C9A RID: 3226
		private readonly string _propertyName;
	}
}
