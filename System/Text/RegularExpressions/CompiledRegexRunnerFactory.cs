using System;
using System.Reflection.Emit;

namespace System.Text.RegularExpressions
{
	// Token: 0x0200009B RID: 155
	internal sealed class CompiledRegexRunnerFactory : RegexRunnerFactory
	{
		// Token: 0x060003DD RID: 989 RVA: 0x00015F57 File Offset: 0x00014157
		public CompiledRegexRunnerFactory(DynamicMethod go, DynamicMethod firstChar, DynamicMethod trackCount)
		{
			this._goMethod = go;
			this._findFirstCharMethod = firstChar;
			this._initTrackCountMethod = trackCount;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00015F74 File Offset: 0x00014174
		protected internal override RegexRunner CreateInstance()
		{
			CompiledRegexRunner compiledRegexRunner = new CompiledRegexRunner();
			compiledRegexRunner.SetDelegates((Action<RegexRunner>)this._goMethod.CreateDelegate(typeof(Action<RegexRunner>)), (Func<RegexRunner, bool>)this._findFirstCharMethod.CreateDelegate(typeof(Func<RegexRunner, bool>)), (Action<RegexRunner>)this._initTrackCountMethod.CreateDelegate(typeof(Action<RegexRunner>)));
			return compiledRegexRunner;
		}

		// Token: 0x04000296 RID: 662
		private readonly DynamicMethod _goMethod;

		// Token: 0x04000297 RID: 663
		private readonly DynamicMethod _findFirstCharMethod;

		// Token: 0x04000298 RID: 664
		private readonly DynamicMethod _initTrackCountMethod;
	}
}
