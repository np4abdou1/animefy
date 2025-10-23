using System;

namespace Xamarin.Google.UserMesssagingPlatform
{
	// Token: 0x0200001D RID: 29
	public class ConsentFormOnConsentFormDismissedEventArgs : EventArgs
	{
		// Token: 0x060000AD RID: 173 RVA: 0x00003296 File Offset: 0x00001496
		public ConsentFormOnConsentFormDismissedEventArgs(FormError p0)
		{
			this.p0 = p0;
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000AE RID: 174 RVA: 0x000032A5 File Offset: 0x000014A5
		public FormError P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x0400002F RID: 47
		private FormError p0;
	}
}
