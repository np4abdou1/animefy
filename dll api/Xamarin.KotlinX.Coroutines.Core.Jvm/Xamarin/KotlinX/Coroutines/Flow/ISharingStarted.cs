using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Flow
{
	// Token: 0x020000B6 RID: 182
	[NullableContext(1)]
	[Register("kotlinx/coroutines/flow/SharingStarted", "", "Xamarin.KotlinX.Coroutines.Flow.ISharingStartedInvoker")]
	public interface ISharingStarted : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x0001E7EC File Offset: 0x0001C9EC
		[Register("Companion")]
		SharingStartedCompanion Companion
		{
			get
			{
				return Java.Lang.Object.GetObject<SharingStartedCompanion>(ISharingStarted._members.StaticFields.GetObjectValue("Companion.Lkotlinx/coroutines/flow/SharingStarted$Companion;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000855 RID: 2133
		[Register("command", "(Lkotlinx/coroutines/flow/StateFlow;)Lkotlinx/coroutines/flow/Flow;", "GetCommand_Lkotlinx_coroutines_flow_StateFlow_Handler:Xamarin.KotlinX.Coroutines.Flow.ISharingStartedInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		IFlow Command(IStateFlow subscriptionCount);

		// Token: 0x040002AB RID: 683
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/flow/SharingStarted", typeof(ISharingStarted), true);
	}
}
