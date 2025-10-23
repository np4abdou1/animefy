using System;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000B0 RID: 176
	internal sealed class RegexLWCGCompiler : RegexCompiler
	{
		// Token: 0x0600050E RID: 1294 RVA: 0x0001F4A4 File Offset: 0x0001D6A4
		public RegexRunnerFactory FactoryInstanceFromCode(RegexCode code, RegexOptions options)
		{
			this._code = code;
			this._codes = code.Codes;
			this._strings = code.Strings;
			this._fcPrefix = code.FCPrefix;
			this._bmPrefix = code.BMPrefix;
			this._anchors = code.Anchors;
			this._trackcount = code.TrackCount;
			this._options = options;
			string str = Interlocked.Increment(ref RegexLWCGCompiler.s_regexCount).ToString(CultureInfo.InvariantCulture);
			DynamicMethod go = this.DefineDynamicMethod("Go" + str, null, typeof(CompiledRegexRunner));
			base.GenerateGo();
			DynamicMethod firstChar = this.DefineDynamicMethod("FindFirstChar" + str, typeof(bool), typeof(CompiledRegexRunner));
			base.GenerateFindFirstChar();
			DynamicMethod trackCount = this.DefineDynamicMethod("InitTrackCount" + str, null, typeof(CompiledRegexRunner));
			base.GenerateInitTrackCount();
			return new CompiledRegexRunnerFactory(go, firstChar, trackCount);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0001F598 File Offset: 0x0001D798
		public DynamicMethod DefineDynamicMethod(string methname, Type returntype, Type hostType)
		{
			MethodAttributes attributes = MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static;
			CallingConventions callingConvention = CallingConventions.Standard;
			DynamicMethod dynamicMethod = new DynamicMethod(methname, attributes, callingConvention, returntype, RegexLWCGCompiler.s_paramTypes, hostType, false);
			this._ilg = dynamicMethod.GetILGenerator();
			return dynamicMethod;
		}

		// Token: 0x0400034B RID: 843
		private static int s_regexCount = 0;

		// Token: 0x0400034C RID: 844
		private static Type[] s_paramTypes = new Type[]
		{
			typeof(RegexRunner)
		};
	}
}
