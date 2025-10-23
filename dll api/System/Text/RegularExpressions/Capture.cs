using System;

namespace System.Text.RegularExpressions
{
	/// <summary>Represents the results from a single successful subexpression capture. </summary>
	// Token: 0x02000098 RID: 152
	public class Capture
	{
		// Token: 0x060003CD RID: 973 RVA: 0x00015E56 File Offset: 0x00014056
		internal Capture(string text, int index, int length)
		{
			this.Text = text;
			this.Index = index;
			this.Length = length;
		}

		/// <summary>The position in the original string where the first character of the captured substring is found.</summary>
		/// <returns>The zero-based starting position in the original string where the captured substring is found.</returns>
		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00015E73 File Offset: 0x00014073
		// (set) Token: 0x060003CF RID: 975 RVA: 0x00015E7B File Offset: 0x0001407B
		public int Index { get; private protected set; }

		/// <summary>Gets the length of the captured substring.</summary>
		/// <returns>The length of the captured substring.</returns>
		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00015E84 File Offset: 0x00014084
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x00015E8C File Offset: 0x0001408C
		public int Length { get; private protected set; }

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00015E95 File Offset: 0x00014095
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x00015E9D File Offset: 0x0001409D
		protected internal string Text { internal get; private protected set; }

		/// <summary>Gets the captured substring from the input string.</summary>
		/// <returns>The substring that is captured by the match.</returns>
		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00015EA6 File Offset: 0x000140A6
		public string Value
		{
			get
			{
				return this.Text.Substring(this.Index, this.Length);
			}
		}

		/// <summary>Retrieves the captured substring from the input string by calling the <see cref="P:System.Text.RegularExpressions.Capture.Value" /> property. </summary>
		/// <returns>The substring that was captured by the match.</returns>
		// Token: 0x060003D5 RID: 981 RVA: 0x00015EBF File Offset: 0x000140BF
		public override string ToString()
		{
			return this.Value;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00015EC7 File Offset: 0x000140C7
		internal ReadOnlySpan<char> GetLeftSubstring()
		{
			return this.Text.AsSpan(0, this.Index);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00015EDB File Offset: 0x000140DB
		internal ReadOnlySpan<char> GetRightSubstring()
		{
			return this.Text.AsSpan(this.Index + this.Length, this.Text.Length - this.Index - this.Length);
		}
	}
}
