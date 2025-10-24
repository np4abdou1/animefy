using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content.Res
{
	// Token: 0x020002AC RID: 684
	[Register("android/content/res/TypedArray", DoNotGenerateAcw = true)]
	public class TypedArray : Java.Lang.Object, IAutoCloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001A59 RID: 6745 RVA: 0x000445C7 File Offset: 0x000427C7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TypedArray._members;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001A5A RID: 6746 RVA: 0x000445D0 File Offset: 0x000427D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TypedArray._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001A5B RID: 6747 RVA: 0x000445F4 File Offset: 0x000427F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TypedArray._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x000021E0 File Offset: 0x000003E0
		protected TypedArray(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x00044600 File Offset: 0x00042800
		private static Delegate GetCloseHandler()
		{
			if (TypedArray.cb_close == null)
			{
				TypedArray.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(TypedArray.n_Close));
			}
			return TypedArray.cb_close;
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x00044624 File Offset: 0x00042824
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<TypedArray>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x00044633 File Offset: 0x00042833
		public virtual void Close()
		{
			TypedArray._members.InstanceMethods.InvokeVirtualVoidMethod("close.()V", this, null);
		}

		// Token: 0x04000B2E RID: 2862
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/res/TypedArray", typeof(TypedArray));

		// Token: 0x04000B2F RID: 2863
		private static Delegate cb_close;
	}
}
