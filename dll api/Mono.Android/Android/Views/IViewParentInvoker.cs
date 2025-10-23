using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views.Accessibility;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x0200012A RID: 298
	[Register("android/view/ViewParent", DoNotGenerateAcw = true)]
	internal class IViewParentInvoker : Java.Lang.Object, IViewParent, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x000169D0 File Offset: 0x00014BD0
		private static IntPtr java_class_ref
		{
			get
			{
				return IViewParentInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x000169F4 File Offset: 0x00014BF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IViewParentInvoker._members;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x000169FB File Offset: 0x00014BFB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x00016A03 File Offset: 0x00014C03
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IViewParentInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00016A0F File Offset: 0x00014C0F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IViewParentInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.ViewParent'.");
			}
			return handle;
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00016A3A File Offset: 0x00014C3A
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00016A6C File Offset: 0x00014C6C
		public IViewParentInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IViewParentInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00016AA4 File Offset: 0x00014CA4
		private static Delegate GetIsLayoutDirectionResolvedHandler()
		{
			if (IViewParentInvoker.cb_isLayoutDirectionResolved == null)
			{
				IViewParentInvoker.cb_isLayoutDirectionResolved = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IViewParentInvoker.n_IsLayoutDirectionResolved));
			}
			return IViewParentInvoker.cb_isLayoutDirectionResolved;
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00016AC8 File Offset: 0x00014CC8
		private static bool n_IsLayoutDirectionResolved(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsLayoutDirectionResolved;
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x00016AD7 File Offset: 0x00014CD7
		public bool IsLayoutDirectionResolved
		{
			get
			{
				if (this.id_isLayoutDirectionResolved == IntPtr.Zero)
				{
					this.id_isLayoutDirectionResolved = JNIEnv.GetMethodID(this.class_ref, "isLayoutDirectionResolved", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isLayoutDirectionResolved);
			}
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00016B17 File Offset: 0x00014D17
		private static Delegate GetIsLayoutRequestedHandler()
		{
			if (IViewParentInvoker.cb_isLayoutRequested == null)
			{
				IViewParentInvoker.cb_isLayoutRequested = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IViewParentInvoker.n_IsLayoutRequested));
			}
			return IViewParentInvoker.cb_isLayoutRequested;
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00016B3B File Offset: 0x00014D3B
		private static bool n_IsLayoutRequested(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsLayoutRequested;
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x00016B4A File Offset: 0x00014D4A
		public bool IsLayoutRequested
		{
			get
			{
				if (this.id_isLayoutRequested == IntPtr.Zero)
				{
					this.id_isLayoutRequested = JNIEnv.GetMethodID(this.class_ref, "isLayoutRequested", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isLayoutRequested);
			}
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00016B8A File Offset: 0x00014D8A
		private static Delegate GetIsTextAlignmentResolvedHandler()
		{
			if (IViewParentInvoker.cb_isTextAlignmentResolved == null)
			{
				IViewParentInvoker.cb_isTextAlignmentResolved = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IViewParentInvoker.n_IsTextAlignmentResolved));
			}
			return IViewParentInvoker.cb_isTextAlignmentResolved;
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00016BAE File Offset: 0x00014DAE
		private static bool n_IsTextAlignmentResolved(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsTextAlignmentResolved;
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x00016BBD File Offset: 0x00014DBD
		public bool IsTextAlignmentResolved
		{
			get
			{
				if (this.id_isTextAlignmentResolved == IntPtr.Zero)
				{
					this.id_isTextAlignmentResolved = JNIEnv.GetMethodID(this.class_ref, "isTextAlignmentResolved", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isTextAlignmentResolved);
			}
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00016BFD File Offset: 0x00014DFD
		private static Delegate GetIsTextDirectionResolvedHandler()
		{
			if (IViewParentInvoker.cb_isTextDirectionResolved == null)
			{
				IViewParentInvoker.cb_isTextDirectionResolved = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IViewParentInvoker.n_IsTextDirectionResolved));
			}
			return IViewParentInvoker.cb_isTextDirectionResolved;
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00016C21 File Offset: 0x00014E21
		private static bool n_IsTextDirectionResolved(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsTextDirectionResolved;
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x00016C30 File Offset: 0x00014E30
		public bool IsTextDirectionResolved
		{
			get
			{
				if (this.id_isTextDirectionResolved == IntPtr.Zero)
				{
					this.id_isTextDirectionResolved = JNIEnv.GetMethodID(this.class_ref, "isTextDirectionResolved", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isTextDirectionResolved);
			}
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00016C70 File Offset: 0x00014E70
		private static Delegate GetGetLayoutDirectionHandler()
		{
			if (IViewParentInvoker.cb_getLayoutDirection == null)
			{
				IViewParentInvoker.cb_getLayoutDirection = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IViewParentInvoker.n_GetLayoutDirection));
			}
			return IViewParentInvoker.cb_getLayoutDirection;
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00016C94 File Offset: 0x00014E94
		private static int n_GetLayoutDirection(IntPtr jnienv, IntPtr native__this)
		{
			return (int)Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LayoutDirection;
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x00016CA3 File Offset: 0x00014EA3
		public LayoutDirection LayoutDirection
		{
			get
			{
				if (this.id_getLayoutDirection == IntPtr.Zero)
				{
					this.id_getLayoutDirection = JNIEnv.GetMethodID(this.class_ref, "getLayoutDirection", "()I");
				}
				return (LayoutDirection)JNIEnv.CallIntMethod(base.Handle, this.id_getLayoutDirection);
			}
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00016CE3 File Offset: 0x00014EE3
		private static Delegate GetGetParentHandler()
		{
			if (IViewParentInvoker.cb_getParent == null)
			{
				IViewParentInvoker.cb_getParent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IViewParentInvoker.n_GetParent));
			}
			return IViewParentInvoker.cb_getParent;
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00016D07 File Offset: 0x00014F07
		private static IntPtr n_GetParent(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parent);
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x00016D1C File Offset: 0x00014F1C
		public IViewParent Parent
		{
			get
			{
				if (this.id_getParent == IntPtr.Zero)
				{
					this.id_getParent = JNIEnv.GetMethodID(this.class_ref, "getParent", "()Landroid/view/ViewParent;");
				}
				return Java.Lang.Object.GetObject<IViewParent>(JNIEnv.CallObjectMethod(base.Handle, this.id_getParent), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00016D6D File Offset: 0x00014F6D
		private static Delegate GetGetParentForAccessibilityHandler()
		{
			if (IViewParentInvoker.cb_getParentForAccessibility == null)
			{
				IViewParentInvoker.cb_getParentForAccessibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IViewParentInvoker.n_GetParentForAccessibility));
			}
			return IViewParentInvoker.cb_getParentForAccessibility;
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00016D91 File Offset: 0x00014F91
		private static IntPtr n_GetParentForAccessibility(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ParentForAccessibility);
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x00016DA8 File Offset: 0x00014FA8
		public IViewParent ParentForAccessibility
		{
			get
			{
				if (this.id_getParentForAccessibility == IntPtr.Zero)
				{
					this.id_getParentForAccessibility = JNIEnv.GetMethodID(this.class_ref, "getParentForAccessibility", "()Landroid/view/ViewParent;");
				}
				return Java.Lang.Object.GetObject<IViewParent>(JNIEnv.CallObjectMethod(base.Handle, this.id_getParentForAccessibility), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00016DF9 File Offset: 0x00014FF9
		private static Delegate GetGetTextAlignmentHandler()
		{
			if (IViewParentInvoker.cb_getTextAlignment == null)
			{
				IViewParentInvoker.cb_getTextAlignment = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IViewParentInvoker.n_GetTextAlignment));
			}
			return IViewParentInvoker.cb_getTextAlignment;
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00016E1D File Offset: 0x0001501D
		private static int n_GetTextAlignment(IntPtr jnienv, IntPtr native__this)
		{
			return (int)Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TextAlignment;
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x00016E2C File Offset: 0x0001502C
		public TextAlignment TextAlignment
		{
			get
			{
				if (this.id_getTextAlignment == IntPtr.Zero)
				{
					this.id_getTextAlignment = JNIEnv.GetMethodID(this.class_ref, "getTextAlignment", "()I");
				}
				return (TextAlignment)JNIEnv.CallIntMethod(base.Handle, this.id_getTextAlignment);
			}
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00016E6C File Offset: 0x0001506C
		private static Delegate GetGetTextDirectionHandler()
		{
			if (IViewParentInvoker.cb_getTextDirection == null)
			{
				IViewParentInvoker.cb_getTextDirection = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IViewParentInvoker.n_GetTextDirection));
			}
			return IViewParentInvoker.cb_getTextDirection;
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00016E90 File Offset: 0x00015090
		private static int n_GetTextDirection(IntPtr jnienv, IntPtr native__this)
		{
			return (int)Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TextDirection;
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x00016E9F File Offset: 0x0001509F
		public TextDirection TextDirection
		{
			get
			{
				if (this.id_getTextDirection == IntPtr.Zero)
				{
					this.id_getTextDirection = JNIEnv.GetMethodID(this.class_ref, "getTextDirection", "()I");
				}
				return (TextDirection)JNIEnv.CallIntMethod(base.Handle, this.id_getTextDirection);
			}
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00016EDF File Offset: 0x000150DF
		private static Delegate GetBringChildToFront_Landroid_view_View_Handler()
		{
			if (IViewParentInvoker.cb_bringChildToFront_Landroid_view_View_ == null)
			{
				IViewParentInvoker.cb_bringChildToFront_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IViewParentInvoker.n_BringChildToFront_Landroid_view_View_));
			}
			return IViewParentInvoker.cb_bringChildToFront_Landroid_view_View_;
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00016F04 File Offset: 0x00015104
		private static void n_BringChildToFront_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			@object.BringChildToFront(object2);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00016F28 File Offset: 0x00015128
		public unsafe void BringChildToFront(View child)
		{
			if (this.id_bringChildToFront_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_bringChildToFront_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "bringChildToFront", "(Landroid/view/View;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((child == null) ? IntPtr.Zero : child.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_bringChildToFront_Landroid_view_View_, ptr);
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00016F9B File Offset: 0x0001519B
		private static Delegate GetCanResolveLayoutDirectionHandler()
		{
			if (IViewParentInvoker.cb_canResolveLayoutDirection == null)
			{
				IViewParentInvoker.cb_canResolveLayoutDirection = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IViewParentInvoker.n_CanResolveLayoutDirection));
			}
			return IViewParentInvoker.cb_canResolveLayoutDirection;
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00016FBF File Offset: 0x000151BF
		private static bool n_CanResolveLayoutDirection(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CanResolveLayoutDirection();
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00016FCE File Offset: 0x000151CE
		public bool CanResolveLayoutDirection()
		{
			if (this.id_canResolveLayoutDirection == IntPtr.Zero)
			{
				this.id_canResolveLayoutDirection = JNIEnv.GetMethodID(this.class_ref, "canResolveLayoutDirection", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_canResolveLayoutDirection);
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x0001700E File Offset: 0x0001520E
		private static Delegate GetCanResolveTextAlignmentHandler()
		{
			if (IViewParentInvoker.cb_canResolveTextAlignment == null)
			{
				IViewParentInvoker.cb_canResolveTextAlignment = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IViewParentInvoker.n_CanResolveTextAlignment));
			}
			return IViewParentInvoker.cb_canResolveTextAlignment;
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x00017032 File Offset: 0x00015232
		private static bool n_CanResolveTextAlignment(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CanResolveTextAlignment();
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00017041 File Offset: 0x00015241
		public bool CanResolveTextAlignment()
		{
			if (this.id_canResolveTextAlignment == IntPtr.Zero)
			{
				this.id_canResolveTextAlignment = JNIEnv.GetMethodID(this.class_ref, "canResolveTextAlignment", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_canResolveTextAlignment);
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00017081 File Offset: 0x00015281
		private static Delegate GetCanResolveTextDirectionHandler()
		{
			if (IViewParentInvoker.cb_canResolveTextDirection == null)
			{
				IViewParentInvoker.cb_canResolveTextDirection = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IViewParentInvoker.n_CanResolveTextDirection));
			}
			return IViewParentInvoker.cb_canResolveTextDirection;
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x000170A5 File Offset: 0x000152A5
		private static bool n_CanResolveTextDirection(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CanResolveTextDirection();
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x000170B4 File Offset: 0x000152B4
		public bool CanResolveTextDirection()
		{
			if (this.id_canResolveTextDirection == IntPtr.Zero)
			{
				this.id_canResolveTextDirection = JNIEnv.GetMethodID(this.class_ref, "canResolveTextDirection", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_canResolveTextDirection);
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x000170F4 File Offset: 0x000152F4
		private static Delegate GetChildDrawableStateChanged_Landroid_view_View_Handler()
		{
			if (IViewParentInvoker.cb_childDrawableStateChanged_Landroid_view_View_ == null)
			{
				IViewParentInvoker.cb_childDrawableStateChanged_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IViewParentInvoker.n_ChildDrawableStateChanged_Landroid_view_View_));
			}
			return IViewParentInvoker.cb_childDrawableStateChanged_Landroid_view_View_;
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00017118 File Offset: 0x00015318
		private static void n_ChildDrawableStateChanged_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			@object.ChildDrawableStateChanged(object2);
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0001713C File Offset: 0x0001533C
		public unsafe void ChildDrawableStateChanged(View child)
		{
			if (this.id_childDrawableStateChanged_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_childDrawableStateChanged_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "childDrawableStateChanged", "(Landroid/view/View;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((child == null) ? IntPtr.Zero : child.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_childDrawableStateChanged_Landroid_view_View_, ptr);
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x000171AF File Offset: 0x000153AF
		private static Delegate GetChildHasTransientStateChanged_Landroid_view_View_ZHandler()
		{
			if (IViewParentInvoker.cb_childHasTransientStateChanged_Landroid_view_View_Z == null)
			{
				IViewParentInvoker.cb_childHasTransientStateChanged_Landroid_view_View_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_V(IViewParentInvoker.n_ChildHasTransientStateChanged_Landroid_view_View_Z));
			}
			return IViewParentInvoker.cb_childHasTransientStateChanged_Landroid_view_View_Z;
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x000171D4 File Offset: 0x000153D4
		private static void n_ChildHasTransientStateChanged_Landroid_view_View_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_child, bool hasTransientState)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			@object.ChildHasTransientStateChanged(object2, hasTransientState);
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x000171F8 File Offset: 0x000153F8
		public unsafe void ChildHasTransientStateChanged(View child, bool hasTransientState)
		{
			if (this.id_childHasTransientStateChanged_Landroid_view_View_Z == IntPtr.Zero)
			{
				this.id_childHasTransientStateChanged_Landroid_view_View_Z = JNIEnv.GetMethodID(this.class_ref, "childHasTransientStateChanged", "(Landroid/view/View;Z)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((child == null) ? IntPtr.Zero : child.Handle);
			ptr[1] = new JValue(hasTransientState);
			JNIEnv.CallVoidMethod(base.Handle, this.id_childHasTransientStateChanged_Landroid_view_View_Z, ptr);
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0001727E File Offset: 0x0001547E
		private static Delegate GetClearChildFocus_Landroid_view_View_Handler()
		{
			if (IViewParentInvoker.cb_clearChildFocus_Landroid_view_View_ == null)
			{
				IViewParentInvoker.cb_clearChildFocus_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IViewParentInvoker.n_ClearChildFocus_Landroid_view_View_));
			}
			return IViewParentInvoker.cb_clearChildFocus_Landroid_view_View_;
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x000172A4 File Offset: 0x000154A4
		private static void n_ClearChildFocus_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			@object.ClearChildFocus(object2);
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x000172C8 File Offset: 0x000154C8
		public unsafe void ClearChildFocus(View child)
		{
			if (this.id_clearChildFocus_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_clearChildFocus_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "clearChildFocus", "(Landroid/view/View;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((child == null) ? IntPtr.Zero : child.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_clearChildFocus_Landroid_view_View_, ptr);
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0001733B File Offset: 0x0001553B
		private static Delegate GetCreateContextMenu_Landroid_view_ContextMenu_Handler()
		{
			if (IViewParentInvoker.cb_createContextMenu_Landroid_view_ContextMenu_ == null)
			{
				IViewParentInvoker.cb_createContextMenu_Landroid_view_ContextMenu_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IViewParentInvoker.n_CreateContextMenu_Landroid_view_ContextMenu_));
			}
			return IViewParentInvoker.cb_createContextMenu_Landroid_view_ContextMenu_;
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x00017360 File Offset: 0x00015560
		private static void n_CreateContextMenu_Landroid_view_ContextMenu_(IntPtr jnienv, IntPtr native__this, IntPtr native_menu)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContextMenu object2 = Java.Lang.Object.GetObject<IContextMenu>(native_menu, JniHandleOwnership.DoNotTransfer);
			@object.CreateContextMenu(object2);
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x00017384 File Offset: 0x00015584
		public unsafe void CreateContextMenu(IContextMenu menu)
		{
			if (this.id_createContextMenu_Landroid_view_ContextMenu_ == IntPtr.Zero)
			{
				this.id_createContextMenu_Landroid_view_ContextMenu_ = JNIEnv.GetMethodID(this.class_ref, "createContextMenu", "(Landroid/view/ContextMenu;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((menu == null) ? IntPtr.Zero : ((Java.Lang.Object)menu).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_createContextMenu_Landroid_view_ContextMenu_, ptr);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x000173FC File Offset: 0x000155FC
		private static Delegate GetFocusableViewAvailable_Landroid_view_View_Handler()
		{
			if (IViewParentInvoker.cb_focusableViewAvailable_Landroid_view_View_ == null)
			{
				IViewParentInvoker.cb_focusableViewAvailable_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IViewParentInvoker.n_FocusableViewAvailable_Landroid_view_View_));
			}
			return IViewParentInvoker.cb_focusableViewAvailable_Landroid_view_View_;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00017420 File Offset: 0x00015620
		private static void n_FocusableViewAvailable_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_v)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_v, JniHandleOwnership.DoNotTransfer);
			@object.FocusableViewAvailable(object2);
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00017444 File Offset: 0x00015644
		public unsafe void FocusableViewAvailable(View v)
		{
			if (this.id_focusableViewAvailable_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_focusableViewAvailable_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "focusableViewAvailable", "(Landroid/view/View;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((v == null) ? IntPtr.Zero : v.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_focusableViewAvailable_Landroid_view_View_, ptr);
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x000174B7 File Offset: 0x000156B7
		private static Delegate GetFocusSearch_Landroid_view_View_IHandler()
		{
			if (IViewParentInvoker.cb_focusSearch_Landroid_view_View_I == null)
			{
				IViewParentInvoker.cb_focusSearch_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_L(IViewParentInvoker.n_FocusSearch_Landroid_view_View_I));
			}
			return IViewParentInvoker.cb_focusSearch_Landroid_view_View_I;
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x000174DC File Offset: 0x000156DC
		private static IntPtr n_FocusSearch_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_v, int native_direction)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_v, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.FocusSearch(object2, (FocusSearchDirection)native_direction));
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00017508 File Offset: 0x00015708
		public unsafe View FocusSearch(View v, [GeneratedEnum] FocusSearchDirection direction)
		{
			if (this.id_focusSearch_Landroid_view_View_I == IntPtr.Zero)
			{
				this.id_focusSearch_Landroid_view_View_I = JNIEnv.GetMethodID(this.class_ref, "focusSearch", "(Landroid/view/View;I)Landroid/view/View;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((v == null) ? IntPtr.Zero : v.Handle);
			ptr[1] = new JValue((int)direction);
			return Java.Lang.Object.GetObject<View>(JNIEnv.CallObjectMethod(base.Handle, this.id_focusSearch_Landroid_view_View_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x00017594 File Offset: 0x00015794
		private static Delegate GetGetChildVisibleRect_Landroid_view_View_Landroid_graphics_Rect_Landroid_graphics_Point_Handler()
		{
			if (IViewParentInvoker.cb_getChildVisibleRect_Landroid_view_View_Landroid_graphics_Rect_Landroid_graphics_Point_ == null)
			{
				IViewParentInvoker.cb_getChildVisibleRect_Landroid_view_View_Landroid_graphics_Rect_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(IViewParentInvoker.n_GetChildVisibleRect_Landroid_view_View_Landroid_graphics_Rect_Landroid_graphics_Point_));
			}
			return IViewParentInvoker.cb_getChildVisibleRect_Landroid_view_View_Landroid_graphics_Rect_Landroid_graphics_Point_;
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x000175B8 File Offset: 0x000157B8
		private static bool n_GetChildVisibleRect_Landroid_view_View_Landroid_graphics_Rect_Landroid_graphics_Point_(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_r, IntPtr native_offset)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			Rect object3 = Java.Lang.Object.GetObject<Rect>(native_r, JniHandleOwnership.DoNotTransfer);
			Point object4 = Java.Lang.Object.GetObject<Point>(native_offset, JniHandleOwnership.DoNotTransfer);
			return @object.GetChildVisibleRect(object2, object3, object4);
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x000175F0 File Offset: 0x000157F0
		public unsafe bool GetChildVisibleRect(View child, Rect r, Point offset)
		{
			if (this.id_getChildVisibleRect_Landroid_view_View_Landroid_graphics_Rect_Landroid_graphics_Point_ == IntPtr.Zero)
			{
				this.id_getChildVisibleRect_Landroid_view_View_Landroid_graphics_Rect_Landroid_graphics_Point_ = JNIEnv.GetMethodID(this.class_ref, "getChildVisibleRect", "(Landroid/view/View;Landroid/graphics/Rect;Landroid/graphics/Point;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((child == null) ? IntPtr.Zero : child.Handle);
			ptr[1] = new JValue((r == null) ? IntPtr.Zero : r.Handle);
			ptr[2] = new JValue((offset == null) ? IntPtr.Zero : offset.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_getChildVisibleRect_Landroid_view_View_Landroid_graphics_Rect_Landroid_graphics_Point_, ptr);
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x000176AA File Offset: 0x000158AA
		private static Delegate GetInvalidateChild_Landroid_view_View_Landroid_graphics_Rect_Handler()
		{
			if (IViewParentInvoker.cb_invalidateChild_Landroid_view_View_Landroid_graphics_Rect_ == null)
			{
				IViewParentInvoker.cb_invalidateChild_Landroid_view_View_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IViewParentInvoker.n_InvalidateChild_Landroid_view_View_Landroid_graphics_Rect_));
			}
			return IViewParentInvoker.cb_invalidateChild_Landroid_view_View_Landroid_graphics_Rect_;
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x000176D0 File Offset: 0x000158D0
		private static void n_InvalidateChild_Landroid_view_View_Landroid_graphics_Rect_(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_r)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			Rect object3 = Java.Lang.Object.GetObject<Rect>(native_r, JniHandleOwnership.DoNotTransfer);
			@object.InvalidateChild(object2, object3);
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x000176FC File Offset: 0x000158FC
		public unsafe void InvalidateChild(View child, Rect r)
		{
			if (this.id_invalidateChild_Landroid_view_View_Landroid_graphics_Rect_ == IntPtr.Zero)
			{
				this.id_invalidateChild_Landroid_view_View_Landroid_graphics_Rect_ = JNIEnv.GetMethodID(this.class_ref, "invalidateChild", "(Landroid/view/View;Landroid/graphics/Rect;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((child == null) ? IntPtr.Zero : child.Handle);
			ptr[1] = new JValue((r == null) ? IntPtr.Zero : r.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_invalidateChild_Landroid_view_View_Landroid_graphics_Rect_, ptr);
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00017791 File Offset: 0x00015991
		private static Delegate GetInvalidateChildInParent_arrayILandroid_graphics_Rect_Handler()
		{
			if (IViewParentInvoker.cb_invalidateChildInParent_arrayILandroid_graphics_Rect_ == null)
			{
				IViewParentInvoker.cb_invalidateChildInParent_arrayILandroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IViewParentInvoker.n_InvalidateChildInParent_arrayILandroid_graphics_Rect_));
			}
			return IViewParentInvoker.cb_invalidateChildInParent_arrayILandroid_graphics_Rect_;
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x000177B8 File Offset: 0x000159B8
		private static IntPtr n_InvalidateChildInParent_arrayILandroid_graphics_Rect_(IntPtr jnienv, IntPtr native__this, IntPtr native_location, IntPtr native_r)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_location, JniHandleOwnership.DoNotTransfer, typeof(int));
			Rect object2 = Java.Lang.Object.GetObject<Rect>(native_r, JniHandleOwnership.DoNotTransfer);
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.InvalidateChildInParent(array, object2));
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_location);
			}
			return result;
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x00017804 File Offset: 0x00015A04
		public unsafe IViewParent InvalidateChildInParent(int[] location, Rect r)
		{
			if (this.id_invalidateChildInParent_arrayILandroid_graphics_Rect_ == IntPtr.Zero)
			{
				this.id_invalidateChildInParent_arrayILandroid_graphics_Rect_ = JNIEnv.GetMethodID(this.class_ref, "invalidateChildInParent", "([ILandroid/graphics/Rect;)Landroid/view/ViewParent;");
			}
			IntPtr intPtr = JNIEnv.NewArray(location);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((r == null) ? IntPtr.Zero : r.Handle);
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(JNIEnv.CallObjectMethod(base.Handle, this.id_invalidateChildInParent_arrayILandroid_graphics_Rect_, ptr), JniHandleOwnership.TransferLocalRef);
			if (location != null)
			{
				JNIEnv.CopyArray(intPtr, location);
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x000178A7 File Offset: 0x00015AA7
		private static Delegate GetKeyboardNavigationClusterSearch_Landroid_view_View_IHandler()
		{
			if (IViewParentInvoker.cb_keyboardNavigationClusterSearch_Landroid_view_View_I == null)
			{
				IViewParentInvoker.cb_keyboardNavigationClusterSearch_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_L(IViewParentInvoker.n_KeyboardNavigationClusterSearch_Landroid_view_View_I));
			}
			return IViewParentInvoker.cb_keyboardNavigationClusterSearch_Landroid_view_View_I;
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x000178CC File Offset: 0x00015ACC
		private static IntPtr n_KeyboardNavigationClusterSearch_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_currentCluster, int native_direction)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_currentCluster, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.KeyboardNavigationClusterSearch(object2, (FocusSearchDirection)native_direction));
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x000178F8 File Offset: 0x00015AF8
		public unsafe View KeyboardNavigationClusterSearch(View currentCluster, [GeneratedEnum] FocusSearchDirection direction)
		{
			if (this.id_keyboardNavigationClusterSearch_Landroid_view_View_I == IntPtr.Zero)
			{
				this.id_keyboardNavigationClusterSearch_Landroid_view_View_I = JNIEnv.GetMethodID(this.class_ref, "keyboardNavigationClusterSearch", "(Landroid/view/View;I)Landroid/view/View;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((currentCluster == null) ? IntPtr.Zero : currentCluster.Handle);
			ptr[1] = new JValue((int)direction);
			return Java.Lang.Object.GetObject<View>(JNIEnv.CallObjectMethod(base.Handle, this.id_keyboardNavigationClusterSearch_Landroid_view_View_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00017984 File Offset: 0x00015B84
		private static Delegate GetNotifySubtreeAccessibilityStateChanged_Landroid_view_View_Landroid_view_View_IHandler()
		{
			if (IViewParentInvoker.cb_notifySubtreeAccessibilityStateChanged_Landroid_view_View_Landroid_view_View_I == null)
			{
				IViewParentInvoker.cb_notifySubtreeAccessibilityStateChanged_Landroid_view_View_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_V(IViewParentInvoker.n_NotifySubtreeAccessibilityStateChanged_Landroid_view_View_Landroid_view_View_I));
			}
			return IViewParentInvoker.cb_notifySubtreeAccessibilityStateChanged_Landroid_view_View_Landroid_view_View_I;
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x000179A8 File Offset: 0x00015BA8
		private static void n_NotifySubtreeAccessibilityStateChanged_Landroid_view_View_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_source, int native_changeType)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_source, JniHandleOwnership.DoNotTransfer);
			@object.NotifySubtreeAccessibilityStateChanged(object2, object3, (ContentChangeTypes)native_changeType);
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x000179D8 File Offset: 0x00015BD8
		public unsafe void NotifySubtreeAccessibilityStateChanged(View child, View source, [GeneratedEnum] ContentChangeTypes changeType)
		{
			if (this.id_notifySubtreeAccessibilityStateChanged_Landroid_view_View_Landroid_view_View_I == IntPtr.Zero)
			{
				this.id_notifySubtreeAccessibilityStateChanged_Landroid_view_View_Landroid_view_View_I = JNIEnv.GetMethodID(this.class_ref, "notifySubtreeAccessibilityStateChanged", "(Landroid/view/View;Landroid/view/View;I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((child == null) ? IntPtr.Zero : child.Handle);
			ptr[1] = new JValue((source == null) ? IntPtr.Zero : source.Handle);
			ptr[2] = new JValue((int)changeType);
			JNIEnv.CallVoidMethod(base.Handle, this.id_notifySubtreeAccessibilityStateChanged_Landroid_view_View_Landroid_view_View_I, ptr);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00017A83 File Offset: 0x00015C83
		private static Delegate GetOnNestedFling_Landroid_view_View_FFZHandler()
		{
			if (IViewParentInvoker.cb_onNestedFling_Landroid_view_View_FFZ == null)
			{
				IViewParentInvoker.cb_onNestedFling_Landroid_view_View_FFZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLFFZ_Z(IViewParentInvoker.n_OnNestedFling_Landroid_view_View_FFZ));
			}
			return IViewParentInvoker.cb_onNestedFling_Landroid_view_View_FFZ;
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00017AA8 File Offset: 0x00015CA8
		private static bool n_OnNestedFling_Landroid_view_View_FFZ(IntPtr jnienv, IntPtr native__this, IntPtr native_target, float velocityX, float velocityY, bool consumed)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			return @object.OnNestedFling(object2, velocityX, velocityY, consumed);
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00017AD0 File Offset: 0x00015CD0
		public unsafe bool OnNestedFling(View target, float velocityX, float velocityY, bool consumed)
		{
			if (this.id_onNestedFling_Landroid_view_View_FFZ == IntPtr.Zero)
			{
				this.id_onNestedFling_Landroid_view_View_FFZ = JNIEnv.GetMethodID(this.class_ref, "onNestedFling", "(Landroid/view/View;FFZ)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((target == null) ? IntPtr.Zero : target.Handle);
			ptr[1] = new JValue(velocityX);
			ptr[2] = new JValue(velocityY);
			ptr[3] = new JValue(consumed);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_onNestedFling_Landroid_view_View_FFZ, ptr);
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00017B83 File Offset: 0x00015D83
		private static Delegate GetOnNestedPreFling_Landroid_view_View_FFHandler()
		{
			if (IViewParentInvoker.cb_onNestedPreFling_Landroid_view_View_FF == null)
			{
				IViewParentInvoker.cb_onNestedPreFling_Landroid_view_View_FF = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLFF_Z(IViewParentInvoker.n_OnNestedPreFling_Landroid_view_View_FF));
			}
			return IViewParentInvoker.cb_onNestedPreFling_Landroid_view_View_FF;
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00017BA8 File Offset: 0x00015DA8
		private static bool n_OnNestedPreFling_Landroid_view_View_FF(IntPtr jnienv, IntPtr native__this, IntPtr native_target, float velocityX, float velocityY)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			return @object.OnNestedPreFling(object2, velocityX, velocityY);
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00017BD0 File Offset: 0x00015DD0
		public unsafe bool OnNestedPreFling(View target, float velocityX, float velocityY)
		{
			if (this.id_onNestedPreFling_Landroid_view_View_FF == IntPtr.Zero)
			{
				this.id_onNestedPreFling_Landroid_view_View_FF = JNIEnv.GetMethodID(this.class_ref, "onNestedPreFling", "(Landroid/view/View;FF)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((target == null) ? IntPtr.Zero : target.Handle);
			ptr[1] = new JValue(velocityX);
			ptr[2] = new JValue(velocityY);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_onNestedPreFling_Landroid_view_View_FF, ptr);
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00017C6C File Offset: 0x00015E6C
		private static Delegate GetOnNestedPrePerformAccessibilityAction_Landroid_view_View_ILandroid_os_Bundle_Handler()
		{
			if (IViewParentInvoker.cb_onNestedPrePerformAccessibilityAction_Landroid_view_View_ILandroid_os_Bundle_ == null)
			{
				IViewParentInvoker.cb_onNestedPrePerformAccessibilityAction_Landroid_view_View_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIL_Z(IViewParentInvoker.n_OnNestedPrePerformAccessibilityAction_Landroid_view_View_ILandroid_os_Bundle_));
			}
			return IViewParentInvoker.cb_onNestedPrePerformAccessibilityAction_Landroid_view_View_ILandroid_os_Bundle_;
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00017C90 File Offset: 0x00015E90
		private static bool n_OnNestedPrePerformAccessibilityAction_Landroid_view_View_ILandroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int native_action, IntPtr native_arguments)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_arguments, JniHandleOwnership.DoNotTransfer);
			return @object.OnNestedPrePerformAccessibilityAction(object2, (Android.Views.Accessibility.Action)native_action, object3);
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00017CC0 File Offset: 0x00015EC0
		public unsafe bool OnNestedPrePerformAccessibilityAction(View target, [GeneratedEnum] Android.Views.Accessibility.Action action, Bundle arguments)
		{
			if (this.id_onNestedPrePerformAccessibilityAction_Landroid_view_View_ILandroid_os_Bundle_ == IntPtr.Zero)
			{
				this.id_onNestedPrePerformAccessibilityAction_Landroid_view_View_ILandroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onNestedPrePerformAccessibilityAction", "(Landroid/view/View;ILandroid/os/Bundle;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((target == null) ? IntPtr.Zero : target.Handle);
			ptr[1] = new JValue((int)action);
			ptr[2] = new JValue((arguments == null) ? IntPtr.Zero : arguments.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_onNestedPrePerformAccessibilityAction_Landroid_view_View_ILandroid_os_Bundle_, ptr);
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00017D6B File Offset: 0x00015F6B
		private static Delegate GetOnNestedPreScroll_Landroid_view_View_IIarrayIHandler()
		{
			if (IViewParentInvoker.cb_onNestedPreScroll_Landroid_view_View_IIarrayI == null)
			{
				IViewParentInvoker.cb_onNestedPreScroll_Landroid_view_View_IIarrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_V(IViewParentInvoker.n_OnNestedPreScroll_Landroid_view_View_IIarrayI));
			}
			return IViewParentInvoker.cb_onNestedPreScroll_Landroid_view_View_IIarrayI;
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00017D90 File Offset: 0x00015F90
		private static void n_OnNestedPreScroll_Landroid_view_View_IIarrayI(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int dx, int dy, IntPtr native_consumed)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_consumed, JniHandleOwnership.DoNotTransfer, typeof(int));
			@object.OnNestedPreScroll(object2, dx, dy, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_consumed);
			}
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00017DDC File Offset: 0x00015FDC
		public unsafe void OnNestedPreScroll(View target, int dx, int dy, int[] consumed)
		{
			if (this.id_onNestedPreScroll_Landroid_view_View_IIarrayI == IntPtr.Zero)
			{
				this.id_onNestedPreScroll_Landroid_view_View_IIarrayI = JNIEnv.GetMethodID(this.class_ref, "onNestedPreScroll", "(Landroid/view/View;II[I)V");
			}
			IntPtr intPtr = JNIEnv.NewArray(consumed);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((target == null) ? IntPtr.Zero : target.Handle);
			ptr[1] = new JValue(dx);
			ptr[2] = new JValue(dy);
			ptr[3] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onNestedPreScroll_Landroid_view_View_IIarrayI, ptr);
			if (consumed != null)
			{
				JNIEnv.CopyArray(intPtr, consumed);
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00017EA8 File Offset: 0x000160A8
		private static Delegate GetOnNestedScroll_Landroid_view_View_IIIIHandler()
		{
			if (IViewParentInvoker.cb_onNestedScroll_Landroid_view_View_IIII == null)
			{
				IViewParentInvoker.cb_onNestedScroll_Landroid_view_View_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIII_V(IViewParentInvoker.n_OnNestedScroll_Landroid_view_View_IIII));
			}
			return IViewParentInvoker.cb_onNestedScroll_Landroid_view_View_IIII;
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00017ECC File Offset: 0x000160CC
		private static void n_OnNestedScroll_Landroid_view_View_IIII(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnNestedScroll(object2, dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed);
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00017EF8 File Offset: 0x000160F8
		public unsafe void OnNestedScroll(View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed)
		{
			if (this.id_onNestedScroll_Landroid_view_View_IIII == IntPtr.Zero)
			{
				this.id_onNestedScroll_Landroid_view_View_IIII = JNIEnv.GetMethodID(this.class_ref, "onNestedScroll", "(Landroid/view/View;IIII)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((target == null) ? IntPtr.Zero : target.Handle);
			ptr[1] = new JValue(dxConsumed);
			ptr[2] = new JValue(dyConsumed);
			ptr[3] = new JValue(dxUnconsumed);
			ptr[4] = new JValue(dyUnconsumed);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onNestedScroll_Landroid_view_View_IIII, ptr);
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00017FC2 File Offset: 0x000161C2
		private static Delegate GetOnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_IHandler()
		{
			if (IViewParentInvoker.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I == null)
			{
				IViewParentInvoker.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_V(IViewParentInvoker.n_OnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I));
			}
			return IViewParentInvoker.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I;
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00017FE8 File Offset: 0x000161E8
		private static void n_OnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_target, int native_nestedScrollAxes)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnNestedScrollAccepted(object2, object3, (ScrollAxis)native_nestedScrollAxes);
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00018018 File Offset: 0x00016218
		public unsafe void OnNestedScrollAccepted(View child, View target, [GeneratedEnum] ScrollAxis nestedScrollAxes)
		{
			if (this.id_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I == IntPtr.Zero)
			{
				this.id_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I = JNIEnv.GetMethodID(this.class_ref, "onNestedScrollAccepted", "(Landroid/view/View;Landroid/view/View;I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((child == null) ? IntPtr.Zero : child.Handle);
			ptr[1] = new JValue((target == null) ? IntPtr.Zero : target.Handle);
			ptr[2] = new JValue((int)nestedScrollAxes);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I, ptr);
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x000180C3 File Offset: 0x000162C3
		private static Delegate GetOnStartNestedScroll_Landroid_view_View_Landroid_view_View_IHandler()
		{
			if (IViewParentInvoker.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I == null)
			{
				IViewParentInvoker.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_Z(IViewParentInvoker.n_OnStartNestedScroll_Landroid_view_View_Landroid_view_View_I));
			}
			return IViewParentInvoker.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I;
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x000180E8 File Offset: 0x000162E8
		private static bool n_OnStartNestedScroll_Landroid_view_View_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_target, int native_nestedScrollAxes)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			return @object.OnStartNestedScroll(object2, object3, (ScrollAxis)native_nestedScrollAxes);
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00018118 File Offset: 0x00016318
		public unsafe bool OnStartNestedScroll(View child, View target, [GeneratedEnum] ScrollAxis nestedScrollAxes)
		{
			if (this.id_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I == IntPtr.Zero)
			{
				this.id_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I = JNIEnv.GetMethodID(this.class_ref, "onStartNestedScroll", "(Landroid/view/View;Landroid/view/View;I)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((child == null) ? IntPtr.Zero : child.Handle);
			ptr[1] = new JValue((target == null) ? IntPtr.Zero : target.Handle);
			ptr[2] = new JValue((int)nestedScrollAxes);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I, ptr);
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x000181C3 File Offset: 0x000163C3
		private static Delegate GetOnStopNestedScroll_Landroid_view_View_Handler()
		{
			if (IViewParentInvoker.cb_onStopNestedScroll_Landroid_view_View_ == null)
			{
				IViewParentInvoker.cb_onStopNestedScroll_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IViewParentInvoker.n_OnStopNestedScroll_Landroid_view_View_));
			}
			return IViewParentInvoker.cb_onStopNestedScroll_Landroid_view_View_;
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x000181E8 File Offset: 0x000163E8
		private static void n_OnStopNestedScroll_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_target)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnStopNestedScroll(object2);
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x0001820C File Offset: 0x0001640C
		public unsafe void OnStopNestedScroll(View target)
		{
			if (this.id_onStopNestedScroll_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_onStopNestedScroll_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "onStopNestedScroll", "(Landroid/view/View;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((target == null) ? IntPtr.Zero : target.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onStopNestedScroll_Landroid_view_View_, ptr);
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x0001827F File Offset: 0x0001647F
		private static Delegate GetRecomputeViewAttributes_Landroid_view_View_Handler()
		{
			if (IViewParentInvoker.cb_recomputeViewAttributes_Landroid_view_View_ == null)
			{
				IViewParentInvoker.cb_recomputeViewAttributes_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IViewParentInvoker.n_RecomputeViewAttributes_Landroid_view_View_));
			}
			return IViewParentInvoker.cb_recomputeViewAttributes_Landroid_view_View_;
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x000182A4 File Offset: 0x000164A4
		private static void n_RecomputeViewAttributes_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			@object.RecomputeViewAttributes(object2);
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x000182C8 File Offset: 0x000164C8
		public unsafe void RecomputeViewAttributes(View child)
		{
			if (this.id_recomputeViewAttributes_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_recomputeViewAttributes_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "recomputeViewAttributes", "(Landroid/view/View;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((child == null) ? IntPtr.Zero : child.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_recomputeViewAttributes_Landroid_view_View_, ptr);
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x0001833B File Offset: 0x0001653B
		private static Delegate GetRequestChildFocus_Landroid_view_View_Landroid_view_View_Handler()
		{
			if (IViewParentInvoker.cb_requestChildFocus_Landroid_view_View_Landroid_view_View_ == null)
			{
				IViewParentInvoker.cb_requestChildFocus_Landroid_view_View_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IViewParentInvoker.n_RequestChildFocus_Landroid_view_View_Landroid_view_View_));
			}
			return IViewParentInvoker.cb_requestChildFocus_Landroid_view_View_Landroid_view_View_;
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00018360 File Offset: 0x00016560
		private static void n_RequestChildFocus_Landroid_view_View_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_focused)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_focused, JniHandleOwnership.DoNotTransfer);
			@object.RequestChildFocus(object2, object3);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x0001838C File Offset: 0x0001658C
		public unsafe void RequestChildFocus(View child, View focused)
		{
			if (this.id_requestChildFocus_Landroid_view_View_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_requestChildFocus_Landroid_view_View_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "requestChildFocus", "(Landroid/view/View;Landroid/view/View;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((child == null) ? IntPtr.Zero : child.Handle);
			ptr[1] = new JValue((focused == null) ? IntPtr.Zero : focused.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_requestChildFocus_Landroid_view_View_Landroid_view_View_, ptr);
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00018421 File Offset: 0x00016621
		private static Delegate GetRequestChildRectangleOnScreen_Landroid_view_View_Landroid_graphics_Rect_ZHandler()
		{
			if (IViewParentInvoker.cb_requestChildRectangleOnScreen_Landroid_view_View_Landroid_graphics_Rect_Z == null)
			{
				IViewParentInvoker.cb_requestChildRectangleOnScreen_Landroid_view_View_Landroid_graphics_Rect_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLZ_Z(IViewParentInvoker.n_RequestChildRectangleOnScreen_Landroid_view_View_Landroid_graphics_Rect_Z));
			}
			return IViewParentInvoker.cb_requestChildRectangleOnScreen_Landroid_view_View_Landroid_graphics_Rect_Z;
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00018448 File Offset: 0x00016648
		private static bool n_RequestChildRectangleOnScreen_Landroid_view_View_Landroid_graphics_Rect_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_rectangle, bool immediate)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			Rect object3 = Java.Lang.Object.GetObject<Rect>(native_rectangle, JniHandleOwnership.DoNotTransfer);
			return @object.RequestChildRectangleOnScreen(object2, object3, immediate);
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00018478 File Offset: 0x00016678
		public unsafe bool RequestChildRectangleOnScreen(View child, Rect rectangle, bool immediate)
		{
			if (this.id_requestChildRectangleOnScreen_Landroid_view_View_Landroid_graphics_Rect_Z == IntPtr.Zero)
			{
				this.id_requestChildRectangleOnScreen_Landroid_view_View_Landroid_graphics_Rect_Z = JNIEnv.GetMethodID(this.class_ref, "requestChildRectangleOnScreen", "(Landroid/view/View;Landroid/graphics/Rect;Z)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((child == null) ? IntPtr.Zero : child.Handle);
			ptr[1] = new JValue((rectangle == null) ? IntPtr.Zero : rectangle.Handle);
			ptr[2] = new JValue(immediate);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_requestChildRectangleOnScreen_Landroid_view_View_Landroid_graphics_Rect_Z, ptr);
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00018523 File Offset: 0x00016723
		private static Delegate GetRequestDisallowInterceptTouchEvent_ZHandler()
		{
			if (IViewParentInvoker.cb_requestDisallowInterceptTouchEvent_Z == null)
			{
				IViewParentInvoker.cb_requestDisallowInterceptTouchEvent_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(IViewParentInvoker.n_RequestDisallowInterceptTouchEvent_Z));
			}
			return IViewParentInvoker.cb_requestDisallowInterceptTouchEvent_Z;
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00018547 File Offset: 0x00016747
		private static void n_RequestDisallowInterceptTouchEvent_Z(IntPtr jnienv, IntPtr native__this, bool disallowIntercept)
		{
			Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequestDisallowInterceptTouchEvent(disallowIntercept);
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00018558 File Offset: 0x00016758
		public unsafe void RequestDisallowInterceptTouchEvent(bool disallowIntercept)
		{
			if (this.id_requestDisallowInterceptTouchEvent_Z == IntPtr.Zero)
			{
				this.id_requestDisallowInterceptTouchEvent_Z = JNIEnv.GetMethodID(this.class_ref, "requestDisallowInterceptTouchEvent", "(Z)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(disallowIntercept);
			JNIEnv.CallVoidMethod(base.Handle, this.id_requestDisallowInterceptTouchEvent_Z, ptr);
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x000185BC File Offset: 0x000167BC
		private static Delegate GetRequestFitSystemWindowsHandler()
		{
			if (IViewParentInvoker.cb_requestFitSystemWindows == null)
			{
				IViewParentInvoker.cb_requestFitSystemWindows = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IViewParentInvoker.n_RequestFitSystemWindows));
			}
			return IViewParentInvoker.cb_requestFitSystemWindows;
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x000185E0 File Offset: 0x000167E0
		private static void n_RequestFitSystemWindows(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequestFitSystemWindows();
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x000185EF File Offset: 0x000167EF
		public void RequestFitSystemWindows()
		{
			if (this.id_requestFitSystemWindows == IntPtr.Zero)
			{
				this.id_requestFitSystemWindows = JNIEnv.GetMethodID(this.class_ref, "requestFitSystemWindows", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_requestFitSystemWindows);
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x0001862F File Offset: 0x0001682F
		private static Delegate GetRequestLayoutHandler()
		{
			if (IViewParentInvoker.cb_requestLayout == null)
			{
				IViewParentInvoker.cb_requestLayout = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IViewParentInvoker.n_RequestLayout));
			}
			return IViewParentInvoker.cb_requestLayout;
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00018653 File Offset: 0x00016853
		private static void n_RequestLayout(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequestLayout();
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00018662 File Offset: 0x00016862
		public void RequestLayout()
		{
			if (this.id_requestLayout == IntPtr.Zero)
			{
				this.id_requestLayout = JNIEnv.GetMethodID(this.class_ref, "requestLayout", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_requestLayout);
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x000186A2 File Offset: 0x000168A2
		private static Delegate GetRequestSendAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_Handler()
		{
			if (IViewParentInvoker.cb_requestSendAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_ == null)
			{
				IViewParentInvoker.cb_requestSendAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(IViewParentInvoker.n_RequestSendAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_));
			}
			return IViewParentInvoker.cb_requestSendAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_;
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x000186C8 File Offset: 0x000168C8
		private static bool n_RequestSendAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_e)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			AccessibilityEvent object3 = Java.Lang.Object.GetObject<AccessibilityEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.RequestSendAccessibilityEvent(object2, object3);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x000186F4 File Offset: 0x000168F4
		public unsafe bool RequestSendAccessibilityEvent(View child, AccessibilityEvent e)
		{
			if (this.id_requestSendAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_ == IntPtr.Zero)
			{
				this.id_requestSendAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_ = JNIEnv.GetMethodID(this.class_ref, "requestSendAccessibilityEvent", "(Landroid/view/View;Landroid/view/accessibility/AccessibilityEvent;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((child == null) ? IntPtr.Zero : child.Handle);
			ptr[1] = new JValue((e == null) ? IntPtr.Zero : e.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_requestSendAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_, ptr);
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00018789 File Offset: 0x00016989
		private static Delegate GetRequestTransparentRegion_Landroid_view_View_Handler()
		{
			if (IViewParentInvoker.cb_requestTransparentRegion_Landroid_view_View_ == null)
			{
				IViewParentInvoker.cb_requestTransparentRegion_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IViewParentInvoker.n_RequestTransparentRegion_Landroid_view_View_));
			}
			return IViewParentInvoker.cb_requestTransparentRegion_Landroid_view_View_;
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x000187B0 File Offset: 0x000169B0
		private static void n_RequestTransparentRegion_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			@object.RequestTransparentRegion(object2);
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x000187D4 File Offset: 0x000169D4
		public unsafe void RequestTransparentRegion(View child)
		{
			if (this.id_requestTransparentRegion_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_requestTransparentRegion_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "requestTransparentRegion", "(Landroid/view/View;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((child == null) ? IntPtr.Zero : child.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_requestTransparentRegion_Landroid_view_View_, ptr);
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00018847 File Offset: 0x00016A47
		private static Delegate GetShowContextMenuForChild_Landroid_view_View_Handler()
		{
			if (IViewParentInvoker.cb_showContextMenuForChild_Landroid_view_View_ == null)
			{
				IViewParentInvoker.cb_showContextMenuForChild_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IViewParentInvoker.n_ShowContextMenuForChild_Landroid_view_View_));
			}
			return IViewParentInvoker.cb_showContextMenuForChild_Landroid_view_View_;
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x0001886C File Offset: 0x00016A6C
		private static bool n_ShowContextMenuForChild_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_originalView)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_originalView, JniHandleOwnership.DoNotTransfer);
			return @object.ShowContextMenuForChild(object2);
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00018890 File Offset: 0x00016A90
		public unsafe bool ShowContextMenuForChild(View originalView)
		{
			if (this.id_showContextMenuForChild_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_showContextMenuForChild_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "showContextMenuForChild", "(Landroid/view/View;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((originalView == null) ? IntPtr.Zero : originalView.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_showContextMenuForChild_Landroid_view_View_, ptr);
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00018903 File Offset: 0x00016B03
		private static Delegate GetShowContextMenuForChild_Landroid_view_View_FFHandler()
		{
			if (IViewParentInvoker.cb_showContextMenuForChild_Landroid_view_View_FF == null)
			{
				IViewParentInvoker.cb_showContextMenuForChild_Landroid_view_View_FF = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLFF_Z(IViewParentInvoker.n_ShowContextMenuForChild_Landroid_view_View_FF));
			}
			return IViewParentInvoker.cb_showContextMenuForChild_Landroid_view_View_FF;
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00018928 File Offset: 0x00016B28
		private static bool n_ShowContextMenuForChild_Landroid_view_View_FF(IntPtr jnienv, IntPtr native__this, IntPtr native_originalView, float x, float y)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_originalView, JniHandleOwnership.DoNotTransfer);
			return @object.ShowContextMenuForChild(object2, x, y);
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00018950 File Offset: 0x00016B50
		public unsafe bool ShowContextMenuForChild(View originalView, float x, float y)
		{
			if (this.id_showContextMenuForChild_Landroid_view_View_FF == IntPtr.Zero)
			{
				this.id_showContextMenuForChild_Landroid_view_View_FF = JNIEnv.GetMethodID(this.class_ref, "showContextMenuForChild", "(Landroid/view/View;FF)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((originalView == null) ? IntPtr.Zero : originalView.Handle);
			ptr[1] = new JValue(x);
			ptr[2] = new JValue(y);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_showContextMenuForChild_Landroid_view_View_FF, ptr);
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x000189EC File Offset: 0x00016BEC
		private static Delegate GetStartActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_Handler()
		{
			if (IViewParentInvoker.cb_startActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_ == null)
			{
				IViewParentInvoker.cb_startActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IViewParentInvoker.n_StartActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_));
			}
			return IViewParentInvoker.cb_startActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_;
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00018A10 File Offset: 0x00016C10
		private static IntPtr n_StartActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_(IntPtr jnienv, IntPtr native__this, IntPtr native_originalView, IntPtr native__callback)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_originalView, JniHandleOwnership.DoNotTransfer);
			ActionMode.ICallback object3 = Java.Lang.Object.GetObject<ActionMode.ICallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.StartActionModeForChild(object2, object3));
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00018A44 File Offset: 0x00016C44
		public unsafe ActionMode StartActionModeForChild(View originalView, ActionMode.ICallback callback)
		{
			if (this.id_startActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_ == IntPtr.Zero)
			{
				this.id_startActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_ = JNIEnv.GetMethodID(this.class_ref, "startActionModeForChild", "(Landroid/view/View;Landroid/view/ActionMode$Callback;)Landroid/view/ActionMode;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((originalView == null) ? IntPtr.Zero : originalView.Handle);
			ptr[1] = new JValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
			return Java.Lang.Object.GetObject<ActionMode>(JNIEnv.CallObjectMethod(base.Handle, this.id_startActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00018AE4 File Offset: 0x00016CE4
		private static Delegate GetStartActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_IHandler()
		{
			if (IViewParentInvoker.cb_startActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_I == null)
			{
				IViewParentInvoker.cb_startActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_L(IViewParentInvoker.n_StartActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_I));
			}
			return IViewParentInvoker.cb_startActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_I;
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00018B08 File Offset: 0x00016D08
		private static IntPtr n_StartActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_I(IntPtr jnienv, IntPtr native__this, IntPtr native_originalView, IntPtr native__callback, int native_type)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_originalView, JniHandleOwnership.DoNotTransfer);
			ActionMode.ICallback object3 = Java.Lang.Object.GetObject<ActionMode.ICallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.StartActionModeForChild(object2, object3, (ActionModeType)native_type));
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00018B40 File Offset: 0x00016D40
		public unsafe ActionMode StartActionModeForChild(View originalView, ActionMode.ICallback callback, [GeneratedEnum] ActionModeType type)
		{
			if (this.id_startActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_I == IntPtr.Zero)
			{
				this.id_startActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_I = JNIEnv.GetMethodID(this.class_ref, "startActionModeForChild", "(Landroid/view/View;Landroid/view/ActionMode$Callback;I)Landroid/view/ActionMode;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((originalView == null) ? IntPtr.Zero : originalView.Handle);
			ptr[1] = new JValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
			ptr[2] = new JValue((int)type);
			return Java.Lang.Object.GetObject<ActionMode>(JNIEnv.CallObjectMethod(base.Handle, this.id_startActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040002DF RID: 735
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/ViewParent", typeof(IViewParentInvoker));

		// Token: 0x040002E0 RID: 736
		private IntPtr class_ref;

		// Token: 0x040002E1 RID: 737
		private static Delegate cb_isLayoutDirectionResolved;

		// Token: 0x040002E2 RID: 738
		private IntPtr id_isLayoutDirectionResolved;

		// Token: 0x040002E3 RID: 739
		private static Delegate cb_isLayoutRequested;

		// Token: 0x040002E4 RID: 740
		private IntPtr id_isLayoutRequested;

		// Token: 0x040002E5 RID: 741
		private static Delegate cb_isTextAlignmentResolved;

		// Token: 0x040002E6 RID: 742
		private IntPtr id_isTextAlignmentResolved;

		// Token: 0x040002E7 RID: 743
		private static Delegate cb_isTextDirectionResolved;

		// Token: 0x040002E8 RID: 744
		private IntPtr id_isTextDirectionResolved;

		// Token: 0x040002E9 RID: 745
		private static Delegate cb_getLayoutDirection;

		// Token: 0x040002EA RID: 746
		private IntPtr id_getLayoutDirection;

		// Token: 0x040002EB RID: 747
		private static Delegate cb_getParent;

		// Token: 0x040002EC RID: 748
		private IntPtr id_getParent;

		// Token: 0x040002ED RID: 749
		private static Delegate cb_getParentForAccessibility;

		// Token: 0x040002EE RID: 750
		private IntPtr id_getParentForAccessibility;

		// Token: 0x040002EF RID: 751
		private static Delegate cb_getTextAlignment;

		// Token: 0x040002F0 RID: 752
		private IntPtr id_getTextAlignment;

		// Token: 0x040002F1 RID: 753
		private static Delegate cb_getTextDirection;

		// Token: 0x040002F2 RID: 754
		private IntPtr id_getTextDirection;

		// Token: 0x040002F3 RID: 755
		private static Delegate cb_bringChildToFront_Landroid_view_View_;

		// Token: 0x040002F4 RID: 756
		private IntPtr id_bringChildToFront_Landroid_view_View_;

		// Token: 0x040002F5 RID: 757
		private static Delegate cb_canResolveLayoutDirection;

		// Token: 0x040002F6 RID: 758
		private IntPtr id_canResolveLayoutDirection;

		// Token: 0x040002F7 RID: 759
		private static Delegate cb_canResolveTextAlignment;

		// Token: 0x040002F8 RID: 760
		private IntPtr id_canResolveTextAlignment;

		// Token: 0x040002F9 RID: 761
		private static Delegate cb_canResolveTextDirection;

		// Token: 0x040002FA RID: 762
		private IntPtr id_canResolveTextDirection;

		// Token: 0x040002FB RID: 763
		private static Delegate cb_childDrawableStateChanged_Landroid_view_View_;

		// Token: 0x040002FC RID: 764
		private IntPtr id_childDrawableStateChanged_Landroid_view_View_;

		// Token: 0x040002FD RID: 765
		private static Delegate cb_childHasTransientStateChanged_Landroid_view_View_Z;

		// Token: 0x040002FE RID: 766
		private IntPtr id_childHasTransientStateChanged_Landroid_view_View_Z;

		// Token: 0x040002FF RID: 767
		private static Delegate cb_clearChildFocus_Landroid_view_View_;

		// Token: 0x04000300 RID: 768
		private IntPtr id_clearChildFocus_Landroid_view_View_;

		// Token: 0x04000301 RID: 769
		private static Delegate cb_createContextMenu_Landroid_view_ContextMenu_;

		// Token: 0x04000302 RID: 770
		private IntPtr id_createContextMenu_Landroid_view_ContextMenu_;

		// Token: 0x04000303 RID: 771
		private static Delegate cb_focusableViewAvailable_Landroid_view_View_;

		// Token: 0x04000304 RID: 772
		private IntPtr id_focusableViewAvailable_Landroid_view_View_;

		// Token: 0x04000305 RID: 773
		private static Delegate cb_focusSearch_Landroid_view_View_I;

		// Token: 0x04000306 RID: 774
		private IntPtr id_focusSearch_Landroid_view_View_I;

		// Token: 0x04000307 RID: 775
		private static Delegate cb_getChildVisibleRect_Landroid_view_View_Landroid_graphics_Rect_Landroid_graphics_Point_;

		// Token: 0x04000308 RID: 776
		private IntPtr id_getChildVisibleRect_Landroid_view_View_Landroid_graphics_Rect_Landroid_graphics_Point_;

		// Token: 0x04000309 RID: 777
		private static Delegate cb_invalidateChild_Landroid_view_View_Landroid_graphics_Rect_;

		// Token: 0x0400030A RID: 778
		private IntPtr id_invalidateChild_Landroid_view_View_Landroid_graphics_Rect_;

		// Token: 0x0400030B RID: 779
		private static Delegate cb_invalidateChildInParent_arrayILandroid_graphics_Rect_;

		// Token: 0x0400030C RID: 780
		private IntPtr id_invalidateChildInParent_arrayILandroid_graphics_Rect_;

		// Token: 0x0400030D RID: 781
		private static Delegate cb_keyboardNavigationClusterSearch_Landroid_view_View_I;

		// Token: 0x0400030E RID: 782
		private IntPtr id_keyboardNavigationClusterSearch_Landroid_view_View_I;

		// Token: 0x0400030F RID: 783
		private static Delegate cb_notifySubtreeAccessibilityStateChanged_Landroid_view_View_Landroid_view_View_I;

		// Token: 0x04000310 RID: 784
		private IntPtr id_notifySubtreeAccessibilityStateChanged_Landroid_view_View_Landroid_view_View_I;

		// Token: 0x04000311 RID: 785
		private static Delegate cb_onNestedFling_Landroid_view_View_FFZ;

		// Token: 0x04000312 RID: 786
		private IntPtr id_onNestedFling_Landroid_view_View_FFZ;

		// Token: 0x04000313 RID: 787
		private static Delegate cb_onNestedPreFling_Landroid_view_View_FF;

		// Token: 0x04000314 RID: 788
		private IntPtr id_onNestedPreFling_Landroid_view_View_FF;

		// Token: 0x04000315 RID: 789
		private static Delegate cb_onNestedPrePerformAccessibilityAction_Landroid_view_View_ILandroid_os_Bundle_;

		// Token: 0x04000316 RID: 790
		private IntPtr id_onNestedPrePerformAccessibilityAction_Landroid_view_View_ILandroid_os_Bundle_;

		// Token: 0x04000317 RID: 791
		private static Delegate cb_onNestedPreScroll_Landroid_view_View_IIarrayI;

		// Token: 0x04000318 RID: 792
		private IntPtr id_onNestedPreScroll_Landroid_view_View_IIarrayI;

		// Token: 0x04000319 RID: 793
		private static Delegate cb_onNestedScroll_Landroid_view_View_IIII;

		// Token: 0x0400031A RID: 794
		private IntPtr id_onNestedScroll_Landroid_view_View_IIII;

		// Token: 0x0400031B RID: 795
		private static Delegate cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I;

		// Token: 0x0400031C RID: 796
		private IntPtr id_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I;

		// Token: 0x0400031D RID: 797
		private static Delegate cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I;

		// Token: 0x0400031E RID: 798
		private IntPtr id_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I;

		// Token: 0x0400031F RID: 799
		private static Delegate cb_onStopNestedScroll_Landroid_view_View_;

		// Token: 0x04000320 RID: 800
		private IntPtr id_onStopNestedScroll_Landroid_view_View_;

		// Token: 0x04000321 RID: 801
		private static Delegate cb_recomputeViewAttributes_Landroid_view_View_;

		// Token: 0x04000322 RID: 802
		private IntPtr id_recomputeViewAttributes_Landroid_view_View_;

		// Token: 0x04000323 RID: 803
		private static Delegate cb_requestChildFocus_Landroid_view_View_Landroid_view_View_;

		// Token: 0x04000324 RID: 804
		private IntPtr id_requestChildFocus_Landroid_view_View_Landroid_view_View_;

		// Token: 0x04000325 RID: 805
		private static Delegate cb_requestChildRectangleOnScreen_Landroid_view_View_Landroid_graphics_Rect_Z;

		// Token: 0x04000326 RID: 806
		private IntPtr id_requestChildRectangleOnScreen_Landroid_view_View_Landroid_graphics_Rect_Z;

		// Token: 0x04000327 RID: 807
		private static Delegate cb_requestDisallowInterceptTouchEvent_Z;

		// Token: 0x04000328 RID: 808
		private IntPtr id_requestDisallowInterceptTouchEvent_Z;

		// Token: 0x04000329 RID: 809
		private static Delegate cb_requestFitSystemWindows;

		// Token: 0x0400032A RID: 810
		private IntPtr id_requestFitSystemWindows;

		// Token: 0x0400032B RID: 811
		private static Delegate cb_requestLayout;

		// Token: 0x0400032C RID: 812
		private IntPtr id_requestLayout;

		// Token: 0x0400032D RID: 813
		private static Delegate cb_requestSendAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_;

		// Token: 0x0400032E RID: 814
		private IntPtr id_requestSendAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_;

		// Token: 0x0400032F RID: 815
		private static Delegate cb_requestTransparentRegion_Landroid_view_View_;

		// Token: 0x04000330 RID: 816
		private IntPtr id_requestTransparentRegion_Landroid_view_View_;

		// Token: 0x04000331 RID: 817
		private static Delegate cb_showContextMenuForChild_Landroid_view_View_;

		// Token: 0x04000332 RID: 818
		private IntPtr id_showContextMenuForChild_Landroid_view_View_;

		// Token: 0x04000333 RID: 819
		private static Delegate cb_showContextMenuForChild_Landroid_view_View_FF;

		// Token: 0x04000334 RID: 820
		private IntPtr id_showContextMenuForChild_Landroid_view_View_FF;

		// Token: 0x04000335 RID: 821
		private static Delegate cb_startActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_;

		// Token: 0x04000336 RID: 822
		private IntPtr id_startActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_;

		// Token: 0x04000337 RID: 823
		private static Delegate cb_startActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_I;

		// Token: 0x04000338 RID: 824
		private IntPtr id_startActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_I;
	}
}
