using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Activity.ContextAware
{
	// Token: 0x0200001C RID: 28
	[Register("androidx/activity/contextaware/ContextAware", DoNotGenerateAcw = true)]
	internal class IContextAwareInvoker : Java.Lang.Object, IContextAware, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00003F04 File Offset: 0x00002104
		private static IntPtr java_class_ref
		{
			get
			{
				return IContextAwareInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00003F28 File Offset: 0x00002128
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IContextAwareInvoker._members;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00003F2F File Offset: 0x0000212F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00003F37 File Offset: 0x00002137
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IContextAwareInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00003F43 File Offset: 0x00002143
		public static IContextAware GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IContextAware>(handle, transfer);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00003F4C File Offset: 0x0000214C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IContextAwareInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.activity.contextaware.ContextAware'.");
			}
			return handle;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00003F77 File Offset: 0x00002177
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00003FA8 File Offset: 0x000021A8
		public IContextAwareInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IContextAwareInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00003FE0 File Offset: 0x000021E0
		private static Delegate GetAddOnContextAvailableListener_Landroidx_activity_contextaware_OnContextAvailableListener_Handler()
		{
			if (IContextAwareInvoker.cb_addOnContextAvailableListener_Landroidx_activity_contextaware_OnContextAvailableListener_ == null)
			{
				IContextAwareInvoker.cb_addOnContextAvailableListener_Landroidx_activity_contextaware_OnContextAvailableListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IContextAwareInvoker.n_AddOnContextAvailableListener_Landroidx_activity_contextaware_OnContextAvailableListener_));
			}
			return IContextAwareInvoker.cb_addOnContextAvailableListener_Landroidx_activity_contextaware_OnContextAvailableListener_;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00004004 File Offset: 0x00002204
		private static void n_AddOnContextAvailableListener_Landroidx_activity_contextaware_OnContextAvailableListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			IContextAware @object = Java.Lang.Object.GetObject<IContextAware>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IOnContextAvailableListener object2 = Java.Lang.Object.GetObject<IOnContextAvailableListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.AddOnContextAvailableListener(object2);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00004028 File Offset: 0x00002228
		public unsafe void AddOnContextAvailableListener(IOnContextAvailableListener listener)
		{
			if (this.id_addOnContextAvailableListener_Landroidx_activity_contextaware_OnContextAvailableListener_ == IntPtr.Zero)
			{
				this.id_addOnContextAvailableListener_Landroidx_activity_contextaware_OnContextAvailableListener_ = JNIEnv.GetMethodID(this.class_ref, "addOnContextAvailableListener", "(Landroidx/activity/contextaware/OnContextAvailableListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_addOnContextAvailableListener_Landroidx_activity_contextaware_OnContextAvailableListener_, ptr);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000040A0 File Offset: 0x000022A0
		private static Delegate GetPeekAvailableContextHandler()
		{
			if (IContextAwareInvoker.cb_peekAvailableContext == null)
			{
				IContextAwareInvoker.cb_peekAvailableContext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IContextAwareInvoker.n_PeekAvailableContext));
			}
			return IContextAwareInvoker.cb_peekAvailableContext;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000040C4 File Offset: 0x000022C4
		private static IntPtr n_PeekAvailableContext(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IContextAware>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PeekAvailableContext());
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000040D8 File Offset: 0x000022D8
		public Context PeekAvailableContext()
		{
			if (this.id_peekAvailableContext == IntPtr.Zero)
			{
				this.id_peekAvailableContext = JNIEnv.GetMethodID(this.class_ref, "peekAvailableContext", "()Landroid/content/Context;");
			}
			return Java.Lang.Object.GetObject<Context>(JNIEnv.CallObjectMethod(base.Handle, this.id_peekAvailableContext), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00004129 File Offset: 0x00002329
		private static Delegate GetRemoveOnContextAvailableListener_Landroidx_activity_contextaware_OnContextAvailableListener_Handler()
		{
			if (IContextAwareInvoker.cb_removeOnContextAvailableListener_Landroidx_activity_contextaware_OnContextAvailableListener_ == null)
			{
				IContextAwareInvoker.cb_removeOnContextAvailableListener_Landroidx_activity_contextaware_OnContextAvailableListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IContextAwareInvoker.n_RemoveOnContextAvailableListener_Landroidx_activity_contextaware_OnContextAvailableListener_));
			}
			return IContextAwareInvoker.cb_removeOnContextAvailableListener_Landroidx_activity_contextaware_OnContextAvailableListener_;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00004150 File Offset: 0x00002350
		private static void n_RemoveOnContextAvailableListener_Landroidx_activity_contextaware_OnContextAvailableListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			IContextAware @object = Java.Lang.Object.GetObject<IContextAware>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IOnContextAvailableListener object2 = Java.Lang.Object.GetObject<IOnContextAvailableListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RemoveOnContextAvailableListener(object2);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00004174 File Offset: 0x00002374
		public unsafe void RemoveOnContextAvailableListener(IOnContextAvailableListener listener)
		{
			if (this.id_removeOnContextAvailableListener_Landroidx_activity_contextaware_OnContextAvailableListener_ == IntPtr.Zero)
			{
				this.id_removeOnContextAvailableListener_Landroidx_activity_contextaware_OnContextAvailableListener_ = JNIEnv.GetMethodID(this.class_ref, "removeOnContextAvailableListener", "(Landroidx/activity/contextaware/OnContextAvailableListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_removeOnContextAvailableListener_Landroidx_activity_contextaware_OnContextAvailableListener_, ptr);
		}

		// Token: 0x04000028 RID: 40
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/activity/contextaware/ContextAware", typeof(IContextAwareInvoker));

		// Token: 0x04000029 RID: 41
		private IntPtr class_ref;

		// Token: 0x0400002A RID: 42
		private static Delegate cb_addOnContextAvailableListener_Landroidx_activity_contextaware_OnContextAvailableListener_;

		// Token: 0x0400002B RID: 43
		private IntPtr id_addOnContextAvailableListener_Landroidx_activity_contextaware_OnContextAvailableListener_;

		// Token: 0x0400002C RID: 44
		private static Delegate cb_peekAvailableContext;

		// Token: 0x0400002D RID: 45
		private IntPtr id_peekAvailableContext;

		// Token: 0x0400002E RID: 46
		private static Delegate cb_removeOnContextAvailableListener_Landroidx_activity_contextaware_OnContextAvailableListener_;

		// Token: 0x0400002F RID: 47
		private IntPtr id_removeOnContextAvailableListener_Landroidx_activity_contextaware_OnContextAvailableListener_;
	}
}
