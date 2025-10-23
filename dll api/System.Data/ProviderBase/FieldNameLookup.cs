using System;

namespace System.Data.ProviderBase
{
	// Token: 0x020000CA RID: 202
	internal sealed class FieldNameLookup : BasicFieldNameLookup
	{
		// Token: 0x06000DFB RID: 3579 RVA: 0x00046E1A File Offset: 0x0004501A
		public FieldNameLookup(IDataReader reader, int defaultLocaleID) : base(reader)
		{
			this._defaultLocaleID = defaultLocaleID;
		}

		// Token: 0x0400046B RID: 1131
		private readonly int _defaultLocaleID;
	}
}
