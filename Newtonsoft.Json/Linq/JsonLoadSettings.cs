using System;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200017D RID: 381
	public class JsonLoadSettings
	{
		// Token: 0x06000C9A RID: 3226 RVA: 0x00038715 File Offset: 0x00036915
		public JsonLoadSettings()
		{
			this._lineInfoHandling = LineInfoHandling.Load;
			this._commentHandling = CommentHandling.Ignore;
			this._duplicatePropertyNameHandling = DuplicatePropertyNameHandling.Replace;
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x00038732 File Offset: 0x00036932
		// (set) Token: 0x06000C9C RID: 3228 RVA: 0x0003873A File Offset: 0x0003693A
		public CommentHandling CommentHandling
		{
			get
			{
				return this._commentHandling;
			}
			set
			{
				if (value < CommentHandling.Ignore || value > CommentHandling.Load)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._commentHandling = value;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x00038756 File Offset: 0x00036956
		// (set) Token: 0x06000C9E RID: 3230 RVA: 0x0003875E File Offset: 0x0003695E
		public LineInfoHandling LineInfoHandling
		{
			get
			{
				return this._lineInfoHandling;
			}
			set
			{
				if (value < LineInfoHandling.Ignore || value > LineInfoHandling.Load)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._lineInfoHandling = value;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x0003877A File Offset: 0x0003697A
		// (set) Token: 0x06000CA0 RID: 3232 RVA: 0x00038782 File Offset: 0x00036982
		public DuplicatePropertyNameHandling DuplicatePropertyNameHandling
		{
			get
			{
				return this._duplicatePropertyNameHandling;
			}
			set
			{
				if (value < DuplicatePropertyNameHandling.Replace || value > DuplicatePropertyNameHandling.Error)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._duplicatePropertyNameHandling = value;
			}
		}

		// Token: 0x040006FD RID: 1789
		private CommentHandling _commentHandling;

		// Token: 0x040006FE RID: 1790
		private LineInfoHandling _lineInfoHandling;

		// Token: 0x040006FF RID: 1791
		private DuplicatePropertyNameHandling _duplicatePropertyNameHandling;
	}
}
