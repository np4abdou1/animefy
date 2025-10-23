using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x0200015F RID: 351
	[Register("android/view/ViewTreeObserver", DoNotGenerateAcw = true)]
	public sealed class ViewTreeObserver : Java.Lang.Object
	{
		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x00020CFC File Offset: 0x0001EEFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ViewTreeObserver._members;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x00020D04 File Offset: 0x0001EF04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ViewTreeObserver._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x00020D28 File Offset: 0x0001EF28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ViewTreeObserver._members.ManagedPeerType;
			}
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x000021E0 File Offset: 0x000003E0
		internal ViewTreeObserver(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000425 RID: 1061
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/ViewTreeObserver", typeof(ViewTreeObserver));

		// Token: 0x02000160 RID: 352
		[Register("android/view/ViewTreeObserver$OnGlobalFocusChangeListener", "", "Android.Views.ViewTreeObserver/IOnGlobalFocusChangeListenerInvoker")]
		public interface IOnGlobalFocusChangeListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000CB7 RID: 3255
			[Register("onGlobalFocusChanged", "(Landroid/view/View;Landroid/view/View;)V", "GetOnGlobalFocusChanged_Landroid_view_View_Landroid_view_View_Handler:Android.Views.ViewTreeObserver/IOnGlobalFocusChangeListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnGlobalFocusChanged(View oldFocus, View newFocus);
		}

		// Token: 0x02000161 RID: 353
		[Register("android/view/ViewTreeObserver$OnGlobalFocusChangeListener", DoNotGenerateAcw = true)]
		internal class IOnGlobalFocusChangeListenerInvoker : Java.Lang.Object, ViewTreeObserver.IOnGlobalFocusChangeListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000265 RID: 613
			// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x00020D50 File Offset: 0x0001EF50
			private static IntPtr java_class_ref
			{
				get
				{
					return ViewTreeObserver.IOnGlobalFocusChangeListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000266 RID: 614
			// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x00020D74 File Offset: 0x0001EF74
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ViewTreeObserver.IOnGlobalFocusChangeListenerInvoker._members;
				}
			}

			// Token: 0x17000267 RID: 615
			// (get) Token: 0x06000CBA RID: 3258 RVA: 0x00020D7B File Offset: 0x0001EF7B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000268 RID: 616
			// (get) Token: 0x06000CBB RID: 3259 RVA: 0x00020D83 File Offset: 0x0001EF83
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ViewTreeObserver.IOnGlobalFocusChangeListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000CBC RID: 3260 RVA: 0x00020D8F File Offset: 0x0001EF8F
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ViewTreeObserver.IOnGlobalFocusChangeListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.ViewTreeObserver.OnGlobalFocusChangeListener'.");
				}
				return handle;
			}

			// Token: 0x06000CBD RID: 3261 RVA: 0x00020DBA File Offset: 0x0001EFBA
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000CBE RID: 3262 RVA: 0x00020DEC File Offset: 0x0001EFEC
			public IOnGlobalFocusChangeListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ViewTreeObserver.IOnGlobalFocusChangeListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000CBF RID: 3263 RVA: 0x00020E24 File Offset: 0x0001F024
			private static Delegate GetOnGlobalFocusChanged_Landroid_view_View_Landroid_view_View_Handler()
			{
				if (ViewTreeObserver.IOnGlobalFocusChangeListenerInvoker.cb_onGlobalFocusChanged_Landroid_view_View_Landroid_view_View_ == null)
				{
					ViewTreeObserver.IOnGlobalFocusChangeListenerInvoker.cb_onGlobalFocusChanged_Landroid_view_View_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ViewTreeObserver.IOnGlobalFocusChangeListenerInvoker.n_OnGlobalFocusChanged_Landroid_view_View_Landroid_view_View_));
				}
				return ViewTreeObserver.IOnGlobalFocusChangeListenerInvoker.cb_onGlobalFocusChanged_Landroid_view_View_Landroid_view_View_;
			}

			// Token: 0x06000CC0 RID: 3264 RVA: 0x00020E48 File Offset: 0x0001F048
			private static void n_OnGlobalFocusChanged_Landroid_view_View_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_oldFocus, IntPtr native_newFocus)
			{
				ViewTreeObserver.IOnGlobalFocusChangeListener @object = Java.Lang.Object.GetObject<ViewTreeObserver.IOnGlobalFocusChangeListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_oldFocus, JniHandleOwnership.DoNotTransfer);
				View object3 = Java.Lang.Object.GetObject<View>(native_newFocus, JniHandleOwnership.DoNotTransfer);
				@object.OnGlobalFocusChanged(object2, object3);
			}

			// Token: 0x06000CC1 RID: 3265 RVA: 0x00020E74 File Offset: 0x0001F074
			public unsafe void OnGlobalFocusChanged(View oldFocus, View newFocus)
			{
				if (this.id_onGlobalFocusChanged_Landroid_view_View_Landroid_view_View_ == IntPtr.Zero)
				{
					this.id_onGlobalFocusChanged_Landroid_view_View_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "onGlobalFocusChanged", "(Landroid/view/View;Landroid/view/View;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((oldFocus == null) ? IntPtr.Zero : oldFocus.Handle);
				ptr[1] = new JValue((newFocus == null) ? IntPtr.Zero : newFocus.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onGlobalFocusChanged_Landroid_view_View_Landroid_view_View_, ptr);
			}

			// Token: 0x04000426 RID: 1062
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/ViewTreeObserver$OnGlobalFocusChangeListener", typeof(ViewTreeObserver.IOnGlobalFocusChangeListenerInvoker));

			// Token: 0x04000427 RID: 1063
			private IntPtr class_ref;

			// Token: 0x04000428 RID: 1064
			private static Delegate cb_onGlobalFocusChanged_Landroid_view_View_Landroid_view_View_;

			// Token: 0x04000429 RID: 1065
			private IntPtr id_onGlobalFocusChanged_Landroid_view_View_Landroid_view_View_;
		}

		// Token: 0x02000162 RID: 354
		[Register("android/view/ViewTreeObserver$OnGlobalLayoutListener", "", "Android.Views.ViewTreeObserver/IOnGlobalLayoutListenerInvoker")]
		public interface IOnGlobalLayoutListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000CC3 RID: 3267
			[Register("onGlobalLayout", "()V", "GetOnGlobalLayoutHandler:Android.Views.ViewTreeObserver/IOnGlobalLayoutListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnGlobalLayout();
		}

		// Token: 0x02000163 RID: 355
		[Register("android/view/ViewTreeObserver$OnGlobalLayoutListener", DoNotGenerateAcw = true)]
		internal class IOnGlobalLayoutListenerInvoker : Java.Lang.Object, ViewTreeObserver.IOnGlobalLayoutListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000269 RID: 617
			// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x00020F24 File Offset: 0x0001F124
			private static IntPtr java_class_ref
			{
				get
				{
					return ViewTreeObserver.IOnGlobalLayoutListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700026A RID: 618
			// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x00020F48 File Offset: 0x0001F148
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ViewTreeObserver.IOnGlobalLayoutListenerInvoker._members;
				}
			}

			// Token: 0x1700026B RID: 619
			// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x00020F4F File Offset: 0x0001F14F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700026C RID: 620
			// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x00020F57 File Offset: 0x0001F157
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ViewTreeObserver.IOnGlobalLayoutListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000CC8 RID: 3272 RVA: 0x00020F63 File Offset: 0x0001F163
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ViewTreeObserver.IOnGlobalLayoutListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.ViewTreeObserver.OnGlobalLayoutListener'.");
				}
				return handle;
			}

			// Token: 0x06000CC9 RID: 3273 RVA: 0x00020F8E File Offset: 0x0001F18E
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000CCA RID: 3274 RVA: 0x00020FC0 File Offset: 0x0001F1C0
			public IOnGlobalLayoutListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ViewTreeObserver.IOnGlobalLayoutListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000CCB RID: 3275 RVA: 0x00020FF8 File Offset: 0x0001F1F8
			private static Delegate GetOnGlobalLayoutHandler()
			{
				if (ViewTreeObserver.IOnGlobalLayoutListenerInvoker.cb_onGlobalLayout == null)
				{
					ViewTreeObserver.IOnGlobalLayoutListenerInvoker.cb_onGlobalLayout = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ViewTreeObserver.IOnGlobalLayoutListenerInvoker.n_OnGlobalLayout));
				}
				return ViewTreeObserver.IOnGlobalLayoutListenerInvoker.cb_onGlobalLayout;
			}

			// Token: 0x06000CCC RID: 3276 RVA: 0x0002101C File Offset: 0x0001F21C
			private static void n_OnGlobalLayout(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<ViewTreeObserver.IOnGlobalLayoutListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnGlobalLayout();
			}

			// Token: 0x06000CCD RID: 3277 RVA: 0x0002102B File Offset: 0x0001F22B
			public void OnGlobalLayout()
			{
				if (this.id_onGlobalLayout == IntPtr.Zero)
				{
					this.id_onGlobalLayout = JNIEnv.GetMethodID(this.class_ref, "onGlobalLayout", "()V");
				}
				JNIEnv.CallVoidMethod(base.Handle, this.id_onGlobalLayout);
			}

			// Token: 0x0400042A RID: 1066
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/ViewTreeObserver$OnGlobalLayoutListener", typeof(ViewTreeObserver.IOnGlobalLayoutListenerInvoker));

			// Token: 0x0400042B RID: 1067
			private IntPtr class_ref;

			// Token: 0x0400042C RID: 1068
			private static Delegate cb_onGlobalLayout;

			// Token: 0x0400042D RID: 1069
			private IntPtr id_onGlobalLayout;
		}

		// Token: 0x02000164 RID: 356
		[Register("android/view/ViewTreeObserver$OnPreDrawListener", "", "Android.Views.ViewTreeObserver/IOnPreDrawListenerInvoker")]
		public interface IOnPreDrawListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000CCF RID: 3279
			[Register("onPreDraw", "()Z", "GetOnPreDrawHandler:Android.Views.ViewTreeObserver/IOnPreDrawListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			bool OnPreDraw();
		}

		// Token: 0x02000165 RID: 357
		[Register("android/view/ViewTreeObserver$OnPreDrawListener", DoNotGenerateAcw = true)]
		internal class IOnPreDrawListenerInvoker : Java.Lang.Object, ViewTreeObserver.IOnPreDrawListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700026D RID: 621
			// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x00021088 File Offset: 0x0001F288
			private static IntPtr java_class_ref
			{
				get
				{
					return ViewTreeObserver.IOnPreDrawListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700026E RID: 622
			// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x000210AC File Offset: 0x0001F2AC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ViewTreeObserver.IOnPreDrawListenerInvoker._members;
				}
			}

			// Token: 0x1700026F RID: 623
			// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x000210B3 File Offset: 0x0001F2B3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000270 RID: 624
			// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x000210BB File Offset: 0x0001F2BB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ViewTreeObserver.IOnPreDrawListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000CD4 RID: 3284 RVA: 0x000210C7 File Offset: 0x0001F2C7
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ViewTreeObserver.IOnPreDrawListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.ViewTreeObserver.OnPreDrawListener'.");
				}
				return handle;
			}

			// Token: 0x06000CD5 RID: 3285 RVA: 0x000210F2 File Offset: 0x0001F2F2
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000CD6 RID: 3286 RVA: 0x00021124 File Offset: 0x0001F324
			public IOnPreDrawListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ViewTreeObserver.IOnPreDrawListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000CD7 RID: 3287 RVA: 0x0002115C File Offset: 0x0001F35C
			private static Delegate GetOnPreDrawHandler()
			{
				if (ViewTreeObserver.IOnPreDrawListenerInvoker.cb_onPreDraw == null)
				{
					ViewTreeObserver.IOnPreDrawListenerInvoker.cb_onPreDraw = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ViewTreeObserver.IOnPreDrawListenerInvoker.n_OnPreDraw));
				}
				return ViewTreeObserver.IOnPreDrawListenerInvoker.cb_onPreDraw;
			}

			// Token: 0x06000CD8 RID: 3288 RVA: 0x00021180 File Offset: 0x0001F380
			private static bool n_OnPreDraw(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<ViewTreeObserver.IOnPreDrawListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnPreDraw();
			}

			// Token: 0x06000CD9 RID: 3289 RVA: 0x0002118F File Offset: 0x0001F38F
			public bool OnPreDraw()
			{
				if (this.id_onPreDraw == IntPtr.Zero)
				{
					this.id_onPreDraw = JNIEnv.GetMethodID(this.class_ref, "onPreDraw", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onPreDraw);
			}

			// Token: 0x0400042E RID: 1070
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/ViewTreeObserver$OnPreDrawListener", typeof(ViewTreeObserver.IOnPreDrawListenerInvoker));

			// Token: 0x0400042F RID: 1071
			private IntPtr class_ref;

			// Token: 0x04000430 RID: 1072
			private static Delegate cb_onPreDraw;

			// Token: 0x04000431 RID: 1073
			private IntPtr id_onPreDraw;
		}

		// Token: 0x02000166 RID: 358
		[Register("android/view/ViewTreeObserver$OnTouchModeChangeListener", "", "Android.Views.ViewTreeObserver/IOnTouchModeChangeListenerInvoker")]
		public interface IOnTouchModeChangeListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000CDB RID: 3291
			[Register("onTouchModeChanged", "(Z)V", "GetOnTouchModeChanged_ZHandler:Android.Views.ViewTreeObserver/IOnTouchModeChangeListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnTouchModeChanged(bool isInTouchMode);
		}

		// Token: 0x02000167 RID: 359
		[Register("android/view/ViewTreeObserver$OnTouchModeChangeListener", DoNotGenerateAcw = true)]
		internal class IOnTouchModeChangeListenerInvoker : Java.Lang.Object, ViewTreeObserver.IOnTouchModeChangeListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000271 RID: 625
			// (get) Token: 0x06000CDC RID: 3292 RVA: 0x000211EC File Offset: 0x0001F3EC
			private static IntPtr java_class_ref
			{
				get
				{
					return ViewTreeObserver.IOnTouchModeChangeListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000272 RID: 626
			// (get) Token: 0x06000CDD RID: 3293 RVA: 0x00021210 File Offset: 0x0001F410
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ViewTreeObserver.IOnTouchModeChangeListenerInvoker._members;
				}
			}

			// Token: 0x17000273 RID: 627
			// (get) Token: 0x06000CDE RID: 3294 RVA: 0x00021217 File Offset: 0x0001F417
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000274 RID: 628
			// (get) Token: 0x06000CDF RID: 3295 RVA: 0x0002121F File Offset: 0x0001F41F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ViewTreeObserver.IOnTouchModeChangeListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000CE0 RID: 3296 RVA: 0x0002122B File Offset: 0x0001F42B
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ViewTreeObserver.IOnTouchModeChangeListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.ViewTreeObserver.OnTouchModeChangeListener'.");
				}
				return handle;
			}

			// Token: 0x06000CE1 RID: 3297 RVA: 0x00021256 File Offset: 0x0001F456
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000CE2 RID: 3298 RVA: 0x00021288 File Offset: 0x0001F488
			public IOnTouchModeChangeListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ViewTreeObserver.IOnTouchModeChangeListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000CE3 RID: 3299 RVA: 0x000212C0 File Offset: 0x0001F4C0
			private static Delegate GetOnTouchModeChanged_ZHandler()
			{
				if (ViewTreeObserver.IOnTouchModeChangeListenerInvoker.cb_onTouchModeChanged_Z == null)
				{
					ViewTreeObserver.IOnTouchModeChangeListenerInvoker.cb_onTouchModeChanged_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ViewTreeObserver.IOnTouchModeChangeListenerInvoker.n_OnTouchModeChanged_Z));
				}
				return ViewTreeObserver.IOnTouchModeChangeListenerInvoker.cb_onTouchModeChanged_Z;
			}

			// Token: 0x06000CE4 RID: 3300 RVA: 0x000212E4 File Offset: 0x0001F4E4
			private static void n_OnTouchModeChanged_Z(IntPtr jnienv, IntPtr native__this, bool isInTouchMode)
			{
				Java.Lang.Object.GetObject<ViewTreeObserver.IOnTouchModeChangeListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnTouchModeChanged(isInTouchMode);
			}

			// Token: 0x06000CE5 RID: 3301 RVA: 0x000212F4 File Offset: 0x0001F4F4
			public unsafe void OnTouchModeChanged(bool isInTouchMode)
			{
				if (this.id_onTouchModeChanged_Z == IntPtr.Zero)
				{
					this.id_onTouchModeChanged_Z = JNIEnv.GetMethodID(this.class_ref, "onTouchModeChanged", "(Z)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(isInTouchMode);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onTouchModeChanged_Z, ptr);
			}

			// Token: 0x04000432 RID: 1074
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/ViewTreeObserver$OnTouchModeChangeListener", typeof(ViewTreeObserver.IOnTouchModeChangeListenerInvoker));

			// Token: 0x04000433 RID: 1075
			private IntPtr class_ref;

			// Token: 0x04000434 RID: 1076
			private static Delegate cb_onTouchModeChanged_Z;

			// Token: 0x04000435 RID: 1077
			private IntPtr id_onTouchModeChanged_Z;
		}
	}
}
