using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000D9 RID: 217
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/ProducerScope$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class ProducerScopeDefaultImpls : Java.Lang.Object
	{
		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x00024100 File Offset: 0x00022300
		internal static IntPtr class_ref
		{
			get
			{
				return ProducerScopeDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x00024124 File Offset: 0x00022324
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ProducerScopeDefaultImpls._members;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x0002412C File Offset: 0x0002232C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ProducerScopeDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x00024150 File Offset: 0x00022350
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ProducerScopeDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0002415C File Offset: 0x0002235C
		internal ProducerScopeDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00024168 File Offset: 0x00022368
		[Obsolete("deprecated")]
		[Register("offer", "(Lkotlinx/coroutines/channels/ProducerScope;Ljava/lang/Object;)Z", "")]
		[JavaTypeParameters(new string[]
		{
			"E"
		})]
		public unsafe static bool Offer(IProducerScope _this, [Nullable(2)] Java.Lang.Object element)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(element);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = ProducerScopeDefaultImpls._members.StaticMethods.InvokeBooleanMethod("offer.(Lkotlinx/coroutines/channels/ProducerScope;Ljava/lang/Object;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(_this);
				GC.KeepAlive(element);
			}
			return result;
		}

		// Token: 0x0400033B RID: 827
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/ProducerScope$DefaultImpls", typeof(ProducerScopeDefaultImpls));
	}
}
