using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.BitmapRecycle
{
	// Token: 0x02000173 RID: 371
	[Register("com/bumptech/glide/load/engine/bitmap_recycle/BaseKeyPool", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T extends com.bumptech.glide.load.engine.bitmap_recycle.Poolable"
	})]
	public abstract class BaseKeyPool : Java.Lang.Object
	{
		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x0600127E RID: 4734 RVA: 0x0003B86C File Offset: 0x00039A6C
		internal static IntPtr class_ref
		{
			get
			{
				return BaseKeyPool._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x0600127F RID: 4735 RVA: 0x0003B890 File Offset: 0x00039A90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BaseKeyPool._members;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06001280 RID: 4736 RVA: 0x0003B898 File Offset: 0x00039A98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BaseKeyPool._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001281 RID: 4737 RVA: 0x0003B8BC File Offset: 0x00039ABC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BaseKeyPool._members.ManagedPeerType;
			}
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x0003B8C8 File Offset: 0x00039AC8
		protected BaseKeyPool(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x0003B8D2 File Offset: 0x00039AD2
		private static Delegate GetOffer_Lcom_bumptech_glide_load_engine_bitmap_recycle_Poolable_Handler()
		{
			if (BaseKeyPool.cb_offer_Lcom_bumptech_glide_load_engine_bitmap_recycle_Poolable_ == null)
			{
				BaseKeyPool.cb_offer_Lcom_bumptech_glide_load_engine_bitmap_recycle_Poolable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BaseKeyPool.n_Offer_Lcom_bumptech_glide_load_engine_bitmap_recycle_Poolable_));
			}
			return BaseKeyPool.cb_offer_Lcom_bumptech_glide_load_engine_bitmap_recycle_Poolable_;
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x0003B8F8 File Offset: 0x00039AF8
		private static void n_Offer_Lcom_bumptech_glide_load_engine_bitmap_recycle_Poolable_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			BaseKeyPool @object = Java.Lang.Object.GetObject<BaseKeyPool>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_key, JniHandleOwnership.DoNotTransfer);
			@object.Offer(object2);
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x0003B91C File Offset: 0x00039B1C
		[Register("offer", "(Lcom/bumptech/glide/load/engine/bitmap_recycle/Poolable;)V", "GetOffer_Lcom_bumptech_glide_load_engine_bitmap_recycle_Poolable_Handler")]
		public unsafe virtual void Offer(Java.Lang.Object key)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				BaseKeyPool._members.InstanceMethods.InvokeVirtualVoidMethod("offer.(Lcom/bumptech/glide/load/engine/bitmap_recycle/Poolable;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(key);
			}
		}

		// Token: 0x04000453 RID: 1107
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/bitmap_recycle/BaseKeyPool", typeof(BaseKeyPool));

		// Token: 0x04000454 RID: 1108
		private static Delegate cb_offer_Lcom_bumptech_glide_load_engine_bitmap_recycle_Poolable_;
	}
}
