using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x020002FF RID: 767
	[Register("java/util/AbstractQueue", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public abstract class AbstractQueue : AbstractCollection, IQueue, ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06001E9B RID: 7835 RVA: 0x00053755 File Offset: 0x00051955
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractQueue._members;
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001E9C RID: 7836 RVA: 0x0005375C File Offset: 0x0005195C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbstractQueue._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001E9D RID: 7837 RVA: 0x00053780 File Offset: 0x00051980
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractQueue._members.ManagedPeerType;
			}
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x0005284F File Offset: 0x00050A4F
		protected AbstractQueue(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x0005378C File Offset: 0x0005198C
		private static Delegate GetElementHandler()
		{
			if (AbstractQueue.cb_element == null)
			{
				AbstractQueue.cb_element = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractQueue.n_Element));
			}
			return AbstractQueue.cb_element;
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x000537B0 File Offset: 0x000519B0
		private static IntPtr n_Element(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Element());
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x000537C4 File Offset: 0x000519C4
		public virtual Java.Lang.Object Element()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(AbstractQueue._members.InstanceMethods.InvokeVirtualObjectMethod("element.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x000537F6 File Offset: 0x000519F6
		private static Delegate GetRemoveHandler()
		{
			if (AbstractQueue.cb_remove == null)
			{
				AbstractQueue.cb_remove = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractQueue.n_Remove));
			}
			return AbstractQueue.cb_remove;
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x0005381A File Offset: 0x00051A1A
		private static IntPtr n_Remove(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Remove());
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x00053830 File Offset: 0x00051A30
		public virtual Java.Lang.Object Remove()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(AbstractQueue._members.InstanceMethods.InvokeVirtualObjectMethod("remove.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x00053862 File Offset: 0x00051A62
		private static Delegate GetOffer_Ljava_lang_Object_Handler()
		{
			if (AbstractQueue.cb_offer_Ljava_lang_Object_ == null)
			{
				AbstractQueue.cb_offer_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(AbstractQueue.n_Offer_Ljava_lang_Object_));
			}
			return AbstractQueue.cb_offer_Ljava_lang_Object_;
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x00053888 File Offset: 0x00051A88
		private static bool n_Offer_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			AbstractQueue @object = Java.Lang.Object.GetObject<AbstractQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.Offer(object2);
		}

		// Token: 0x06001EA7 RID: 7847
		public abstract bool Offer(Java.Lang.Object e);

		// Token: 0x06001EA8 RID: 7848 RVA: 0x000538AB File Offset: 0x00051AAB
		private static Delegate GetPeekHandler()
		{
			if (AbstractQueue.cb_peek == null)
			{
				AbstractQueue.cb_peek = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractQueue.n_Peek));
			}
			return AbstractQueue.cb_peek;
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x000538CF File Offset: 0x00051ACF
		private static IntPtr n_Peek(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Peek());
		}

		// Token: 0x06001EAA RID: 7850
		public abstract Java.Lang.Object Peek();

		// Token: 0x06001EAB RID: 7851 RVA: 0x000538E3 File Offset: 0x00051AE3
		private static Delegate GetPollHandler()
		{
			if (AbstractQueue.cb_poll == null)
			{
				AbstractQueue.cb_poll = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AbstractQueue.n_Poll));
			}
			return AbstractQueue.cb_poll;
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x00053907 File Offset: 0x00051B07
		private static IntPtr n_Poll(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AbstractQueue>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Poll());
		}

		// Token: 0x06001EAD RID: 7853
		public abstract Java.Lang.Object Poll();

		// Token: 0x04000C97 RID: 3223
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/AbstractQueue", typeof(AbstractQueue));

		// Token: 0x04000C98 RID: 3224
		private static Delegate cb_element;

		// Token: 0x04000C99 RID: 3225
		private static Delegate cb_remove;

		// Token: 0x04000C9A RID: 3226
		private static Delegate cb_offer_Ljava_lang_Object_;

		// Token: 0x04000C9B RID: 3227
		private static Delegate cb_peek;

		// Token: 0x04000C9C RID: 3228
		private static Delegate cb_poll;
	}
}
