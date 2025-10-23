using System;

namespace Android.Text
{
	// Token: 0x020001BE RID: 446
	public class AfterTextChangedEventArgs : EventArgs
	{
		// Token: 0x06001025 RID: 4133 RVA: 0x0002A32B File Offset: 0x0002852B
		public AfterTextChangedEventArgs(IEditable editable)
		{
			this.editable = editable;
		}

		// Token: 0x0400076D RID: 1901
		private IEditable editable;
	}
}
