using System;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200017E RID: 382
	public class JsonMergeSettings
	{
		// Token: 0x06000CA1 RID: 3233 RVA: 0x0003879E File Offset: 0x0003699E
		public JsonMergeSettings()
		{
			this._propertyNameComparison = StringComparison.Ordinal;
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x000387AD File Offset: 0x000369AD
		// (set) Token: 0x06000CA3 RID: 3235 RVA: 0x000387B5 File Offset: 0x000369B5
		public MergeArrayHandling MergeArrayHandling
		{
			get
			{
				return this._mergeArrayHandling;
			}
			set
			{
				if (value < MergeArrayHandling.Concat || value > MergeArrayHandling.Merge)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._mergeArrayHandling = value;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x000387D1 File Offset: 0x000369D1
		// (set) Token: 0x06000CA5 RID: 3237 RVA: 0x000387D9 File Offset: 0x000369D9
		public MergeNullValueHandling MergeNullValueHandling
		{
			get
			{
				return this._mergeNullValueHandling;
			}
			set
			{
				if (value < MergeNullValueHandling.Ignore || value > MergeNullValueHandling.Merge)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._mergeNullValueHandling = value;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x000387F5 File Offset: 0x000369F5
		// (set) Token: 0x06000CA7 RID: 3239 RVA: 0x000387FD File Offset: 0x000369FD
		public StringComparison PropertyNameComparison
		{
			get
			{
				return this._propertyNameComparison;
			}
			set
			{
				if (value < StringComparison.CurrentCulture || value > StringComparison.OrdinalIgnoreCase)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._propertyNameComparison = value;
			}
		}

		// Token: 0x04000700 RID: 1792
		private MergeArrayHandling _mergeArrayHandling;

		// Token: 0x04000701 RID: 1793
		private MergeNullValueHandling _mergeNullValueHandling;

		// Token: 0x04000702 RID: 1794
		private StringComparison _propertyNameComparison;
	}
}
