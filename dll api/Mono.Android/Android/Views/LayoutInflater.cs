using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x02000132 RID: 306
	[Register("android/view/LayoutInflater", DoNotGenerateAcw = true)]
	public abstract class LayoutInflater : Java.Lang.Object
	{
		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000A4C RID: 2636 RVA: 0x00019B7D File Offset: 0x00017D7D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LayoutInflater._members;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x00019B84 File Offset: 0x00017D84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LayoutInflater._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000A4E RID: 2638 RVA: 0x00019BA8 File Offset: 0x00017DA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LayoutInflater._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x000021E0 File Offset: 0x000003E0
		protected LayoutInflater(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00019BB4 File Offset: 0x00017DB4
		public unsafe static LayoutInflater From(Context context)
		{
			LayoutInflater @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<LayoutInflater>(LayoutInflater._members.StaticMethods.InvokeObjectMethod("from.(Landroid/content/Context;)Landroid/view/LayoutInflater;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00019C28 File Offset: 0x00017E28
		private static Delegate GetInflate_ILandroid_view_ViewGroup_Handler()
		{
			if (LayoutInflater.cb_inflate_ILandroid_view_ViewGroup_ == null)
			{
				LayoutInflater.cb_inflate_ILandroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_L(LayoutInflater.n_Inflate_ILandroid_view_ViewGroup_));
			}
			return LayoutInflater.cb_inflate_ILandroid_view_ViewGroup_;
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00019C4C File Offset: 0x00017E4C
		private static IntPtr n_Inflate_ILandroid_view_ViewGroup_(IntPtr jnienv, IntPtr native__this, int resource, IntPtr native_root)
		{
			LayoutInflater @object = Java.Lang.Object.GetObject<LayoutInflater>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ViewGroup object2 = Java.Lang.Object.GetObject<ViewGroup>(native_root, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Inflate(resource, object2));
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00019C78 File Offset: 0x00017E78
		public unsafe virtual View Inflate(int resource, ViewGroup root)
		{
			View @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(resource);
				ptr[1] = new JniArgumentValue((root == null) ? IntPtr.Zero : root.Handle);
				@object = Java.Lang.Object.GetObject<View>(LayoutInflater._members.InstanceMethods.InvokeVirtualObjectMethod("inflate.(ILandroid/view/ViewGroup;)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(root);
			}
			return @object;
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00019D00 File Offset: 0x00017F00
		private static Delegate GetInflate_ILandroid_view_ViewGroup_ZHandler()
		{
			if (LayoutInflater.cb_inflate_ILandroid_view_ViewGroup_Z == null)
			{
				LayoutInflater.cb_inflate_ILandroid_view_ViewGroup_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILZ_L(LayoutInflater.n_Inflate_ILandroid_view_ViewGroup_Z));
			}
			return LayoutInflater.cb_inflate_ILandroid_view_ViewGroup_Z;
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00019D24 File Offset: 0x00017F24
		private static IntPtr n_Inflate_ILandroid_view_ViewGroup_Z(IntPtr jnienv, IntPtr native__this, int resource, IntPtr native_root, bool attachToRoot)
		{
			LayoutInflater @object = Java.Lang.Object.GetObject<LayoutInflater>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ViewGroup object2 = Java.Lang.Object.GetObject<ViewGroup>(native_root, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Inflate(resource, object2, attachToRoot));
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00019D50 File Offset: 0x00017F50
		public unsafe virtual View Inflate(int resource, ViewGroup root, bool attachToRoot)
		{
			View @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(resource);
				ptr[1] = new JniArgumentValue((root == null) ? IntPtr.Zero : root.Handle);
				ptr[2] = new JniArgumentValue(attachToRoot);
				@object = Java.Lang.Object.GetObject<View>(LayoutInflater._members.InstanceMethods.InvokeVirtualObjectMethod("inflate.(ILandroid/view/ViewGroup;Z)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(root);
			}
			return @object;
		}

		// Token: 0x04000359 RID: 857
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/LayoutInflater", typeof(LayoutInflater));

		// Token: 0x0400035A RID: 858
		private static Delegate cb_inflate_ILandroid_view_ViewGroup_;

		// Token: 0x0400035B RID: 859
		private static Delegate cb_inflate_ILandroid_view_ViewGroup_Z;

		// Token: 0x02000133 RID: 307
		[Register("android/view/LayoutInflater$Factory", "", "Android.Views.LayoutInflater/IFactoryInvoker")]
		public interface IFactory : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000A58 RID: 2648
			[Register("onCreateView", "(Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;", "GetOnCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_Handler:Android.Views.LayoutInflater/IFactoryInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			View OnCreateView(string name, Context context, IAttributeSet attrs);
		}

		// Token: 0x02000134 RID: 308
		[Register("android/view/LayoutInflater$Factory", DoNotGenerateAcw = true)]
		internal class IFactoryInvoker : Java.Lang.Object, LayoutInflater.IFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170001F8 RID: 504
			// (get) Token: 0x06000A59 RID: 2649 RVA: 0x00019E08 File Offset: 0x00018008
			private static IntPtr java_class_ref
			{
				get
				{
					return LayoutInflater.IFactoryInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170001F9 RID: 505
			// (get) Token: 0x06000A5A RID: 2650 RVA: 0x00019E2C File Offset: 0x0001802C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return LayoutInflater.IFactoryInvoker._members;
				}
			}

			// Token: 0x170001FA RID: 506
			// (get) Token: 0x06000A5B RID: 2651 RVA: 0x00019E33 File Offset: 0x00018033
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170001FB RID: 507
			// (get) Token: 0x06000A5C RID: 2652 RVA: 0x00019E3B File Offset: 0x0001803B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return LayoutInflater.IFactoryInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000A5D RID: 2653 RVA: 0x00019E47 File Offset: 0x00018047
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, LayoutInflater.IFactoryInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.LayoutInflater.Factory'.");
				}
				return handle;
			}

			// Token: 0x06000A5E RID: 2654 RVA: 0x00019E72 File Offset: 0x00018072
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000A5F RID: 2655 RVA: 0x00019EA4 File Offset: 0x000180A4
			public IFactoryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(LayoutInflater.IFactoryInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000A60 RID: 2656 RVA: 0x00019EDC File Offset: 0x000180DC
			private static Delegate GetOnCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_Handler()
			{
				if (LayoutInflater.IFactoryInvoker.cb_onCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_ == null)
				{
					LayoutInflater.IFactoryInvoker.cb_onCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(LayoutInflater.IFactoryInvoker.n_OnCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_));
				}
				return LayoutInflater.IFactoryInvoker.cb_onCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_;
			}

			// Token: 0x06000A61 RID: 2657 RVA: 0x00019F00 File Offset: 0x00018100
			private static IntPtr n_OnCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_(IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_context, IntPtr native_attrs)
			{
				LayoutInflater.IFactory @object = Java.Lang.Object.GetObject<LayoutInflater.IFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
				Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
				IAttributeSet object3 = Java.Lang.Object.GetObject<IAttributeSet>(native_attrs, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.OnCreateView(@string, object2, object3));
			}

			// Token: 0x06000A62 RID: 2658 RVA: 0x00019F3C File Offset: 0x0001813C
			public unsafe View OnCreateView(string name, Context context, IAttributeSet attrs)
			{
				if (this.id_onCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				{
					this.id_onCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID(this.class_ref, "onCreateView", "(Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;");
				}
				IntPtr intPtr = JNIEnv.NewString(name);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				ptr[1] = new JValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[2] = new JValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				View @object = Java.Lang.Object.GetObject<View>(JNIEnv.CallObjectMethod(base.Handle, this.id_onCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_, ptr), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef(intPtr);
				return @object;
			}

			// Token: 0x0400035C RID: 860
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/LayoutInflater$Factory", typeof(LayoutInflater.IFactoryInvoker));

			// Token: 0x0400035D RID: 861
			private IntPtr class_ref;

			// Token: 0x0400035E RID: 862
			private static Delegate cb_onCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_;

			// Token: 0x0400035F RID: 863
			private IntPtr id_onCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_;
		}

		// Token: 0x02000135 RID: 309
		[Register("android/view/LayoutInflater$Factory2", "", "Android.Views.LayoutInflater/IFactory2Invoker")]
		public interface IFactory2 : LayoutInflater.IFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000A64 RID: 2660
			[Register("onCreateView", "(Landroid/view/View;Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;", "GetOnCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_Handler:Android.Views.LayoutInflater/IFactory2Invoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			View OnCreateView(View parent, string name, Context context, IAttributeSet attrs);
		}

		// Token: 0x02000136 RID: 310
		[Register("android/view/LayoutInflater$Factory2", DoNotGenerateAcw = true)]
		internal class IFactory2Invoker : Java.Lang.Object, LayoutInflater.IFactory2, LayoutInflater.IFactory, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170001FC RID: 508
			// (get) Token: 0x06000A65 RID: 2661 RVA: 0x0001A01C File Offset: 0x0001821C
			private static IntPtr java_class_ref
			{
				get
				{
					return LayoutInflater.IFactory2Invoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170001FD RID: 509
			// (get) Token: 0x06000A66 RID: 2662 RVA: 0x0001A040 File Offset: 0x00018240
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return LayoutInflater.IFactory2Invoker._members;
				}
			}

			// Token: 0x170001FE RID: 510
			// (get) Token: 0x06000A67 RID: 2663 RVA: 0x0001A047 File Offset: 0x00018247
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170001FF RID: 511
			// (get) Token: 0x06000A68 RID: 2664 RVA: 0x0001A04F File Offset: 0x0001824F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return LayoutInflater.IFactory2Invoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000A69 RID: 2665 RVA: 0x0001A05B File Offset: 0x0001825B
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, LayoutInflater.IFactory2Invoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.LayoutInflater.Factory2'.");
				}
				return handle;
			}

			// Token: 0x06000A6A RID: 2666 RVA: 0x0001A086 File Offset: 0x00018286
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000A6B RID: 2667 RVA: 0x0001A0B8 File Offset: 0x000182B8
			public IFactory2Invoker(IntPtr handle, JniHandleOwnership transfer) : base(LayoutInflater.IFactory2Invoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000A6C RID: 2668 RVA: 0x0001A0F0 File Offset: 0x000182F0
			private static Delegate GetOnCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_Handler()
			{
				if (LayoutInflater.IFactory2Invoker.cb_onCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_ == null)
				{
					LayoutInflater.IFactory2Invoker.cb_onCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_L(LayoutInflater.IFactory2Invoker.n_OnCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_));
				}
				return LayoutInflater.IFactory2Invoker.cb_onCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_;
			}

			// Token: 0x06000A6D RID: 2669 RVA: 0x0001A114 File Offset: 0x00018314
			private static IntPtr n_OnCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_name, IntPtr native_context, IntPtr native_attrs)
			{
				LayoutInflater.IFactory2 @object = Java.Lang.Object.GetObject<LayoutInflater.IFactory2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_parent, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_name, JniHandleOwnership.DoNotTransfer);
				Context object3 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
				IAttributeSet object4 = Java.Lang.Object.GetObject<IAttributeSet>(native_attrs, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.OnCreateView(object2, @string, object3, object4));
			}

			// Token: 0x06000A6E RID: 2670 RVA: 0x0001A15C File Offset: 0x0001835C
			public unsafe View OnCreateView(View parent, string name, Context context, IAttributeSet attrs)
			{
				if (this.id_onCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				{
					this.id_onCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID(this.class_ref, "onCreateView", "(Landroid/view/View;Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;");
				}
				IntPtr intPtr = JNIEnv.NewString(name);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((parent == null) ? IntPtr.Zero : parent.Handle);
				ptr[1] = new JValue(intPtr);
				ptr[2] = new JValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[3] = new JValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				View @object = Java.Lang.Object.GetObject<View>(JNIEnv.CallObjectMethod(base.Handle, this.id_onCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_, ptr), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef(intPtr);
				return @object;
			}

			// Token: 0x06000A6F RID: 2671 RVA: 0x0001A248 File Offset: 0x00018448
			public unsafe View OnCreateView(string name, Context context, IAttributeSet attrs)
			{
				if (this.id_onCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				{
					this.id_onCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID(this.class_ref, "onCreateView", "(Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;");
				}
				IntPtr intPtr = JNIEnv.NewString(name);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				ptr[1] = new JValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[2] = new JValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				View @object = Java.Lang.Object.GetObject<View>(JNIEnv.CallObjectMethod(base.Handle, this.id_onCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_, ptr), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef(intPtr);
				return @object;
			}

			// Token: 0x04000360 RID: 864
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/LayoutInflater$Factory2", typeof(LayoutInflater.IFactory2Invoker));

			// Token: 0x04000361 RID: 865
			private IntPtr class_ref;

			// Token: 0x04000362 RID: 866
			private static Delegate cb_onCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_;

			// Token: 0x04000363 RID: 867
			private IntPtr id_onCreateView_Landroid_view_View_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_;

			// Token: 0x04000364 RID: 868
			private IntPtr id_onCreateView_Ljava_lang_String_Landroid_content_Context_Landroid_util_AttributeSet_;
		}

		// Token: 0x02000137 RID: 311
		[Register("android/view/LayoutInflater$Filter", "", "Android.Views.LayoutInflater/IFilterInvoker")]
		public interface IFilter : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000A71 RID: 2673
			[Register("onLoadClass", "(Ljava/lang/Class;)Z", "GetOnLoadClass_Ljava_lang_Class_Handler:Android.Views.LayoutInflater/IFilterInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool OnLoadClass(Class clazz);
		}

		// Token: 0x02000138 RID: 312
		[Register("android/view/LayoutInflater$Filter", DoNotGenerateAcw = true)]
		internal class IFilterInvoker : Java.Lang.Object, LayoutInflater.IFilter, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000200 RID: 512
			// (get) Token: 0x06000A72 RID: 2674 RVA: 0x0001A328 File Offset: 0x00018528
			private static IntPtr java_class_ref
			{
				get
				{
					return LayoutInflater.IFilterInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000201 RID: 513
			// (get) Token: 0x06000A73 RID: 2675 RVA: 0x0001A34C File Offset: 0x0001854C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return LayoutInflater.IFilterInvoker._members;
				}
			}

			// Token: 0x17000202 RID: 514
			// (get) Token: 0x06000A74 RID: 2676 RVA: 0x0001A353 File Offset: 0x00018553
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000203 RID: 515
			// (get) Token: 0x06000A75 RID: 2677 RVA: 0x0001A35B File Offset: 0x0001855B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return LayoutInflater.IFilterInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000A76 RID: 2678 RVA: 0x0001A367 File Offset: 0x00018567
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, LayoutInflater.IFilterInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.LayoutInflater.Filter'.");
				}
				return handle;
			}

			// Token: 0x06000A77 RID: 2679 RVA: 0x0001A392 File Offset: 0x00018592
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000A78 RID: 2680 RVA: 0x0001A3C4 File Offset: 0x000185C4
			public IFilterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(LayoutInflater.IFilterInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000A79 RID: 2681 RVA: 0x0001A3FC File Offset: 0x000185FC
			private static Delegate GetOnLoadClass_Ljava_lang_Class_Handler()
			{
				if (LayoutInflater.IFilterInvoker.cb_onLoadClass_Ljava_lang_Class_ == null)
				{
					LayoutInflater.IFilterInvoker.cb_onLoadClass_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(LayoutInflater.IFilterInvoker.n_OnLoadClass_Ljava_lang_Class_));
				}
				return LayoutInflater.IFilterInvoker.cb_onLoadClass_Ljava_lang_Class_;
			}

			// Token: 0x06000A7A RID: 2682 RVA: 0x0001A420 File Offset: 0x00018620
			private static bool n_OnLoadClass_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_clazz)
			{
				LayoutInflater.IFilter @object = Java.Lang.Object.GetObject<LayoutInflater.IFilter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Class object2 = Java.Lang.Object.GetObject<Class>(native_clazz, JniHandleOwnership.DoNotTransfer);
				return @object.OnLoadClass(object2);
			}

			// Token: 0x06000A7B RID: 2683 RVA: 0x0001A444 File Offset: 0x00018644
			public unsafe bool OnLoadClass(Class clazz)
			{
				if (this.id_onLoadClass_Ljava_lang_Class_ == IntPtr.Zero)
				{
					this.id_onLoadClass_Ljava_lang_Class_ = JNIEnv.GetMethodID(this.class_ref, "onLoadClass", "(Ljava/lang/Class;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((clazz == null) ? IntPtr.Zero : clazz.Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onLoadClass_Ljava_lang_Class_, ptr);
			}

			// Token: 0x04000365 RID: 869
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/LayoutInflater$Filter", typeof(LayoutInflater.IFilterInvoker));

			// Token: 0x04000366 RID: 870
			private IntPtr class_ref;

			// Token: 0x04000367 RID: 871
			private static Delegate cb_onLoadClass_Ljava_lang_Class_;

			// Token: 0x04000368 RID: 872
			private IntPtr id_onLoadClass_Ljava_lang_Class_;
		}
	}
}
