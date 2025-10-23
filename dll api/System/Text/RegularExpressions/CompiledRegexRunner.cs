using System;

namespace System.Text.RegularExpressions
{
	// Token: 0x0200009A RID: 154
	internal sealed class CompiledRegexRunner : RegexRunner
	{
		// Token: 0x060003D9 RID: 985 RVA: 0x00015F16 File Offset: 0x00014116
		public void SetDelegates(Action<RegexRunner> go, Func<RegexRunner, bool> firstChar, Action<RegexRunner> trackCount)
		{
			this._goMethod = go;
			this._findFirstCharMethod = firstChar;
			this._initTrackCountMethod = trackCount;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00015F2D File Offset: 0x0001412D
		protected override void Go()
		{
			this._goMethod(this);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00015F3B File Offset: 0x0001413B
		protected override bool FindFirstChar()
		{
			return this._findFirstCharMethod(this);
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00015F49 File Offset: 0x00014149
		protected override void InitTrackCount()
		{
			this._initTrackCountMethod(this);
		}

		// Token: 0x04000293 RID: 659
		private Action<RegexRunner> _goMethod;

		// Token: 0x04000294 RID: 660
		private Func<RegexRunner, bool> _findFirstCharMethod;

		// Token: 0x04000295 RID: 661
		private Action<RegexRunner> _initTrackCountMethod;
	}
}
