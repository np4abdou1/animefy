using System;
using Android.Runtime;
using Java.Interop;

namespace Java.Util.Regex
{
	// Token: 0x02000328 RID: 808
	[Register("java/util/regex/MatchResult", "", "Java.Util.Regex.IMatchResultInvoker")]
	public interface IMatchResult : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600227F RID: 8831
		int End();

		// Token: 0x06002280 RID: 8832
		int End(int group);

		// Token: 0x06002281 RID: 8833
		string Group();

		// Token: 0x06002282 RID: 8834
		string Group(int group);

		// Token: 0x06002283 RID: 8835
		int GroupCount();

		// Token: 0x06002284 RID: 8836
		int Start();

		// Token: 0x06002285 RID: 8837
		int Start(int group);
	}
}
