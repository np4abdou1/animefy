using System;

namespace Xamarin.Google.UserMesssagingPlatform
{
	// Token: 0x02000027 RID: 39
	public class ConsentInformationOnConsentInfoUpdateFailureEventArgs : EventArgs
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x000039F6 File Offset: 0x00001BF6
		public ConsentInformationOnConsentInfoUpdateFailureEventArgs(FormError p0)
		{
			this.p0 = p0;
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00003A05 File Offset: 0x00001C05
		public FormError P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x04000048 RID: 72
		private FormError p0;
	}
}
