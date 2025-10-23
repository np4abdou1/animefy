using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.View
{
	// Token: 0x0200008D RID: 141
	[Register("androidx/appcompat/view/CollapsibleActionView", DoNotGenerateAcw = true)]
	internal class ICollapsibleActionViewInvoker : Java.Lang.Object, ICollapsibleActionView, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x0001973C File Offset: 0x0001793C
		private static IntPtr java_class_ref
		{
			get
			{
				return ICollapsibleActionViewInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x00019760 File Offset: 0x00017960
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICollapsibleActionViewInvoker._members;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x00019767 File Offset: 0x00017967
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x0001976F File Offset: 0x0001796F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICollapsibleActionViewInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x0001977B File Offset: 0x0001797B
		public static ICollapsibleActionView GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ICollapsibleActionView>(handle, transfer);
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00019784 File Offset: 0x00017984
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICollapsibleActionViewInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.appcompat.view.CollapsibleActionView'.");
			}
			return handle;
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x000197AF File Offset: 0x000179AF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x000197E0 File Offset: 0x000179E0
		public ICollapsibleActionViewInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICollapsibleActionViewInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00019818 File Offset: 0x00017A18
		private static Delegate GetOnActionViewCollapsedHandler()
		{
			if (ICollapsibleActionViewInvoker.cb_onActionViewCollapsed == null)
			{
				ICollapsibleActionViewInvoker.cb_onActionViewCollapsed = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ICollapsibleActionViewInvoker.n_OnActionViewCollapsed));
			}
			return ICollapsibleActionViewInvoker.cb_onActionViewCollapsed;
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0001983C File Offset: 0x00017A3C
		private static void n_OnActionViewCollapsed(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ICollapsibleActionView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnActionViewCollapsed();
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0001984B File Offset: 0x00017A4B
		public void OnActionViewCollapsed()
		{
			if (this.id_onActionViewCollapsed == IntPtr.Zero)
			{
				this.id_onActionViewCollapsed = JNIEnv.GetMethodID(this.class_ref, "onActionViewCollapsed", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onActionViewCollapsed);
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0001988B File Offset: 0x00017A8B
		private static Delegate GetOnActionViewExpandedHandler()
		{
			if (ICollapsibleActionViewInvoker.cb_onActionViewExpanded == null)
			{
				ICollapsibleActionViewInvoker.cb_onActionViewExpanded = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ICollapsibleActionViewInvoker.n_OnActionViewExpanded));
			}
			return ICollapsibleActionViewInvoker.cb_onActionViewExpanded;
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x000198AF File Offset: 0x00017AAF
		private static void n_OnActionViewExpanded(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ICollapsibleActionView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnActionViewExpanded();
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x000198BE File Offset: 0x00017ABE
		public void OnActionViewExpanded()
		{
			if (this.id_onActionViewExpanded == IntPtr.Zero)
			{
				this.id_onActionViewExpanded = JNIEnv.GetMethodID(this.class_ref, "onActionViewExpanded", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onActionViewExpanded);
		}

		// Token: 0x040002E5 RID: 741
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/view/CollapsibleActionView", typeof(ICollapsibleActionViewInvoker));

		// Token: 0x040002E6 RID: 742
		private IntPtr class_ref;

		// Token: 0x040002E7 RID: 743
		private static Delegate cb_onActionViewCollapsed;

		// Token: 0x040002E8 RID: 744
		private IntPtr id_onActionViewCollapsed;

		// Token: 0x040002E9 RID: 745
		private static Delegate cb_onActionViewExpanded;

		// Token: 0x040002EA RID: 746
		private IntPtr id_onActionViewExpanded;
	}
}
