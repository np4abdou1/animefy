using System;
using Android.Runtime;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal
{
	// Token: 0x020000E9 RID: 233
	[Annotation("com.google.android.datatransport.runtime.dagger.internal.InjectedFieldSignature")]
	public class InjectedFieldSignatureAttribute : Attribute
	{
		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x000170E4 File Offset: 0x000152E4
		// (set) Token: 0x0600084A RID: 2122 RVA: 0x000170EC File Offset: 0x000152EC
		[Register("value")]
		public string Value { get; set; }
	}
}
