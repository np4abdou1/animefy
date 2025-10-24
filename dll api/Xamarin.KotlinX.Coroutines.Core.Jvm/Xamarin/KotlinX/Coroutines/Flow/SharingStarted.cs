using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Flow
{
	// Token: 0x020000B4 RID: 180
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/flow/SharingStarted", DoNotGenerateAcw = true)]
	public abstract class SharingStarted : Java.Lang.Object
	{
		// Token: 0x06000850 RID: 2128 RVA: 0x0001E78F File Offset: 0x0001C98F
		internal SharingStarted()
		{
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x0001E798 File Offset: 0x0001C998
		[Register("Companion")]
		public static SharingStartedCompanion Companion
		{
			get
			{
				return Java.Lang.Object.GetObject<SharingStartedCompanion>(SharingStarted._members.StaticFields.GetObjectValue("Companion.Lkotlinx/coroutines/flow/SharingStarted$Companion;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040002AA RID: 682
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/flow/SharingStarted", typeof(SharingStarted));
	}
}
