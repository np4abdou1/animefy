using System;

namespace System.Text.RegularExpressions
{
	/// <summary>Represents the results from a single capturing group. </summary>
	// Token: 0x0200009C RID: 156
	[Serializable]
	public class Group : Capture
	{
		// Token: 0x060003DF RID: 991 RVA: 0x00015FDA File Offset: 0x000141DA
		internal Group(string text, int[] caps, int capcount, string name) : base(text, (capcount == 0) ? 0 : caps[(capcount - 1) * 2], (capcount == 0) ? 0 : caps[capcount * 2 - 1])
		{
			this._caps = caps;
			this._capcount = capcount;
			this.<Name>k__BackingField = name;
		}

		/// <summary>Gets a value indicating whether the match is successful.</summary>
		/// <returns>
		///     <see langword="true" /> if the match is successful; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x00016013 File Offset: 0x00014213
		public bool Success
		{
			get
			{
				return this._capcount != 0;
			}
		}

		// Token: 0x04000299 RID: 665
		internal static readonly Group s_emptyGroup = new Group(string.Empty, Array.Empty<int>(), 0, string.Empty);

		// Token: 0x0400029A RID: 666
		internal readonly int[] _caps;

		// Token: 0x0400029B RID: 667
		internal int _capcount;
	}
}
