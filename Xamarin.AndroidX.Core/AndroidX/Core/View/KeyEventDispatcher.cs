using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.View
{
	// Token: 0x020000B9 RID: 185
	[Register("androidx/core/view/KeyEventDispatcher", DoNotGenerateAcw = true)]
	public class KeyEventDispatcher : Java.Lang.Object
	{
		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x0001FDCC File Offset: 0x0001DFCC
		internal static IntPtr class_ref
		{
			get
			{
				return KeyEventDispatcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x0001FDF0 File Offset: 0x0001DFF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return KeyEventDispatcher._members;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x0001FDF8 File Offset: 0x0001DFF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return KeyEventDispatcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x0001FE1C File Offset: 0x0001E01C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return KeyEventDispatcher._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00002384 File Offset: 0x00000584
		protected KeyEventDispatcher(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x0001FE28 File Offset: 0x0001E028
		[Register("dispatchBeforeHierarchy", "(Landroid/view/View;Landroid/view/KeyEvent;)Z", "")]
		public unsafe static bool DispatchBeforeHierarchy(View root, KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((root == null) ? IntPtr.Zero : root.Handle);
				ptr[1] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = KeyEventDispatcher._members.StaticMethods.InvokeBooleanMethod("dispatchBeforeHierarchy.(Landroid/view/View;Landroid/view/KeyEvent;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(root);
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x0001FEB4 File Offset: 0x0001E0B4
		[Register("dispatchKeyEvent", "(Landroidx/core/view/KeyEventDispatcher$Component;Landroid/view/View;Landroid/view/Window$Callback;Landroid/view/KeyEvent;)Z", "")]
		public unsafe static bool DispatchKeyEvent(KeyEventDispatcher.IComponent component, View root, Window.ICallback callback, KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((component == null) ? IntPtr.Zero : ((Java.Lang.Object)component).Handle);
				ptr[1] = new JniArgumentValue((root == null) ? IntPtr.Zero : root.Handle);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				ptr[3] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = KeyEventDispatcher._members.StaticMethods.InvokeBooleanMethod("dispatchKeyEvent.(Landroidx/core/view/KeyEventDispatcher$Component;Landroid/view/View;Landroid/view/Window$Callback;Landroid/view/KeyEvent;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(component);
				GC.KeepAlive(root);
				GC.KeepAlive(callback);
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x04000323 RID: 803
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/KeyEventDispatcher", typeof(KeyEventDispatcher));

		// Token: 0x020000BA RID: 186
		[Register("androidx/core/view/KeyEventDispatcher$Component", "", "AndroidX.Core.View.KeyEventDispatcher/IComponentInvoker")]
		public interface IComponent : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000A66 RID: 2662
			[Register("superDispatchKeyEvent", "(Landroid/view/KeyEvent;)Z", "GetSuperDispatchKeyEvent_Landroid_view_KeyEvent_Handler:AndroidX.Core.View.KeyEventDispatcher/IComponentInvoker, Xamarin.AndroidX.Core")]
			bool SuperDispatchKeyEvent(KeyEvent e);
		}

		// Token: 0x020000BB RID: 187
		[Register("androidx/core/view/KeyEventDispatcher$Component", DoNotGenerateAcw = true)]
		internal class IComponentInvoker : Java.Lang.Object, KeyEventDispatcher.IComponent, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170001E7 RID: 487
			// (get) Token: 0x06000A67 RID: 2663 RVA: 0x0001FFBC File Offset: 0x0001E1BC
			private static IntPtr java_class_ref
			{
				get
				{
					return KeyEventDispatcher.IComponentInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170001E8 RID: 488
			// (get) Token: 0x06000A68 RID: 2664 RVA: 0x0001FFE0 File Offset: 0x0001E1E0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return KeyEventDispatcher.IComponentInvoker._members;
				}
			}

			// Token: 0x170001E9 RID: 489
			// (get) Token: 0x06000A69 RID: 2665 RVA: 0x0001FFE7 File Offset: 0x0001E1E7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170001EA RID: 490
			// (get) Token: 0x06000A6A RID: 2666 RVA: 0x0001FFEF File Offset: 0x0001E1EF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return KeyEventDispatcher.IComponentInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000A6B RID: 2667 RVA: 0x0001FFFB File Offset: 0x0001E1FB
			public static KeyEventDispatcher.IComponent GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<KeyEventDispatcher.IComponent>(handle, transfer);
			}

			// Token: 0x06000A6C RID: 2668 RVA: 0x00020004 File Offset: 0x0001E204
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, KeyEventDispatcher.IComponentInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.view.KeyEventDispatcher.Component'.");
				}
				return handle;
			}

			// Token: 0x06000A6D RID: 2669 RVA: 0x0002002F File Offset: 0x0001E22F
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000A6E RID: 2670 RVA: 0x00020060 File Offset: 0x0001E260
			public IComponentInvoker(IntPtr handle, JniHandleOwnership transfer) : base(KeyEventDispatcher.IComponentInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000A6F RID: 2671 RVA: 0x00020098 File Offset: 0x0001E298
			private static Delegate GetSuperDispatchKeyEvent_Landroid_view_KeyEvent_Handler()
			{
				if (KeyEventDispatcher.IComponentInvoker.cb_superDispatchKeyEvent_Landroid_view_KeyEvent_ == null)
				{
					KeyEventDispatcher.IComponentInvoker.cb_superDispatchKeyEvent_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(KeyEventDispatcher.IComponentInvoker.n_SuperDispatchKeyEvent_Landroid_view_KeyEvent_));
				}
				return KeyEventDispatcher.IComponentInvoker.cb_superDispatchKeyEvent_Landroid_view_KeyEvent_;
			}

			// Token: 0x06000A70 RID: 2672 RVA: 0x000200BC File Offset: 0x0001E2BC
			private static bool n_SuperDispatchKeyEvent_Landroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
			{
				KeyEventDispatcher.IComponent @object = Java.Lang.Object.GetObject<KeyEventDispatcher.IComponent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
				return @object.SuperDispatchKeyEvent(object2);
			}

			// Token: 0x06000A71 RID: 2673 RVA: 0x000200E0 File Offset: 0x0001E2E0
			public unsafe bool SuperDispatchKeyEvent(KeyEvent e)
			{
				if (this.id_superDispatchKeyEvent_Landroid_view_KeyEvent_ == IntPtr.Zero)
				{
					this.id_superDispatchKeyEvent_Landroid_view_KeyEvent_ = JNIEnv.GetMethodID(this.class_ref, "superDispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((e == null) ? IntPtr.Zero : e.Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_superDispatchKeyEvent_Landroid_view_KeyEvent_, ptr);
			}

			// Token: 0x04000324 RID: 804
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/KeyEventDispatcher$Component", typeof(KeyEventDispatcher.IComponentInvoker));

			// Token: 0x04000325 RID: 805
			private IntPtr class_ref;

			// Token: 0x04000326 RID: 806
			private static Delegate cb_superDispatchKeyEvent_Landroid_view_KeyEvent_;

			// Token: 0x04000327 RID: 807
			private IntPtr id_superDispatchKeyEvent_Landroid_view_KeyEvent_;
		}
	}
}
