using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Flow
{
	// Token: 0x020000B7 RID: 183
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/flow/SharingStarted", DoNotGenerateAcw = true)]
	internal class ISharingStartedInvoker : Java.Lang.Object, ISharingStarted, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x0001E838 File Offset: 0x0001CA38
		private static IntPtr java_class_ref
		{
			get
			{
				return ISharingStartedInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x0001E85C File Offset: 0x0001CA5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISharingStartedInvoker._members;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x0001E863 File Offset: 0x0001CA63
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x0001E86B File Offset: 0x0001CA6B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISharingStartedInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x0001E877 File Offset: 0x0001CA77
		[NullableContext(2)]
		public static ISharingStarted GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISharingStarted>(handle, transfer);
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x0001E880 File Offset: 0x0001CA80
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISharingStartedInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlinx.coroutines.flow.SharingStarted'.");
			}
			return handle;
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x0001E8AB File Offset: 0x0001CAAB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x0001E8DC File Offset: 0x0001CADC
		public ISharingStartedInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISharingStartedInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x0001E914 File Offset: 0x0001CB14
		private static Delegate GetCommand_Lkotlinx_coroutines_flow_StateFlow_Handler()
		{
			if (ISharingStartedInvoker.cb_command_Lkotlinx_coroutines_flow_StateFlow_ == null)
			{
				ISharingStartedInvoker.cb_command_Lkotlinx_coroutines_flow_StateFlow_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ISharingStartedInvoker.n_Command_Lkotlinx_coroutines_flow_StateFlow_));
			}
			return ISharingStartedInvoker.cb_command_Lkotlinx_coroutines_flow_StateFlow_;
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x0001E938 File Offset: 0x0001CB38
		private static IntPtr n_Command_Lkotlinx_coroutines_flow_StateFlow_(IntPtr jnienv, IntPtr native__this, IntPtr native_subscriptionCount)
		{
			ISharingStarted @object = Java.Lang.Object.GetObject<ISharingStarted>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IStateFlow object2 = Java.Lang.Object.GetObject<IStateFlow>(native_subscriptionCount, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Command(object2));
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x0001E960 File Offset: 0x0001CB60
		public unsafe IFlow Command(IStateFlow subscriptionCount)
		{
			if (this.id_command_Lkotlinx_coroutines_flow_StateFlow_ == IntPtr.Zero)
			{
				this.id_command_Lkotlinx_coroutines_flow_StateFlow_ = JNIEnv.GetMethodID(this.class_ref, "command", "(Lkotlinx/coroutines/flow/StateFlow;)Lkotlinx/coroutines/flow/Flow;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((subscriptionCount == null) ? IntPtr.Zero : ((Java.Lang.Object)subscriptionCount).Handle);
			return Java.Lang.Object.GetObject<IFlow>(JNIEnv.CallObjectMethod(base.Handle, this.id_command_Lkotlinx_coroutines_flow_StateFlow_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040002AC RID: 684
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/flow/SharingStarted", typeof(ISharingStartedInvoker));

		// Token: 0x040002AD RID: 685
		private IntPtr class_ref;

		// Token: 0x040002AE RID: 686
		[Nullable(2)]
		private static Delegate cb_command_Lkotlinx_coroutines_flow_StateFlow_;

		// Token: 0x040002AF RID: 687
		private IntPtr id_command_Lkotlinx_coroutines_flow_StateFlow_;
	}
}
