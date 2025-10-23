using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Lifecycle.ViewModels
{
	// Token: 0x02000015 RID: 21
	[Register("androidx/lifecycle/viewmodel/CreationExtras", DoNotGenerateAcw = true)]
	public abstract class CreationExtras : Java.Lang.Object
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0000330C File Offset: 0x0000150C
		internal static IntPtr class_ref
		{
			get
			{
				return CreationExtras._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00003330 File Offset: 0x00001530
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CreationExtras._members;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00003338 File Offset: 0x00001538
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CreationExtras._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0000335C File Offset: 0x0000155C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CreationExtras._members.ManagedPeerType;
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002464 File Offset: 0x00000664
		protected CreationExtras(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003368 File Offset: 0x00001568
		private static Delegate GetGet_Landroidx_lifecycle_viewmodel_CreationExtras_Key_Handler()
		{
			if (CreationExtras.cb_get_Landroidx_lifecycle_viewmodel_CreationExtras_Key_ == null)
			{
				CreationExtras.cb_get_Landroidx_lifecycle_viewmodel_CreationExtras_Key_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CreationExtras.n_Get_Landroidx_lifecycle_viewmodel_CreationExtras_Key_));
			}
			return CreationExtras.cb_get_Landroidx_lifecycle_viewmodel_CreationExtras_Key_;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000338C File Offset: 0x0000158C
		private static IntPtr n_Get_Landroidx_lifecycle_viewmodel_CreationExtras_Key_(IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			CreationExtras @object = Java.Lang.Object.GetObject<CreationExtras>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CreationExtras.IKey object2 = Java.Lang.Object.GetObject<CreationExtras.IKey>(native_key, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Get(object2));
		}

		// Token: 0x06000083 RID: 131
		[Register("get", "(Landroidx/lifecycle/viewmodel/CreationExtras$Key;)Ljava/lang/Object;", "GetGet_Landroidx_lifecycle_viewmodel_CreationExtras_Key_Handler")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public abstract Java.Lang.Object Get(CreationExtras.IKey key);

		// Token: 0x0400001B RID: 27
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/lifecycle/viewmodel/CreationExtras", typeof(CreationExtras));

		// Token: 0x0400001C RID: 28
		private static Delegate cb_get_Landroidx_lifecycle_viewmodel_CreationExtras_Key_;

		// Token: 0x02000016 RID: 22
		[Register("androidx/lifecycle/viewmodel/CreationExtras$Key", "", "AndroidX.Lifecycle.ViewModels.CreationExtras/IKeyInvoker")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public interface IKey : IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x02000017 RID: 23
		[Register("androidx/lifecycle/viewmodel/CreationExtras$Key", DoNotGenerateAcw = true)]
		internal class IKeyInvoker : Java.Lang.Object, CreationExtras.IKey, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000029 RID: 41
			// (get) Token: 0x06000085 RID: 133 RVA: 0x000033D0 File Offset: 0x000015D0
			private static IntPtr java_class_ref
			{
				get
				{
					return CreationExtras.IKeyInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x06000086 RID: 134 RVA: 0x000033F4 File Offset: 0x000015F4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return CreationExtras.IKeyInvoker._members;
				}
			}

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x06000087 RID: 135 RVA: 0x000033FB File Offset: 0x000015FB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x06000088 RID: 136 RVA: 0x00003403 File Offset: 0x00001603
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return CreationExtras.IKeyInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000089 RID: 137 RVA: 0x0000340F File Offset: 0x0000160F
			public static CreationExtras.IKey GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<CreationExtras.IKey>(handle, transfer);
			}

			// Token: 0x0600008A RID: 138 RVA: 0x00003418 File Offset: 0x00001618
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, CreationExtras.IKeyInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.lifecycle.viewmodel.CreationExtras.Key'.");
				}
				return handle;
			}

			// Token: 0x0600008B RID: 139 RVA: 0x00003443 File Offset: 0x00001643
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600008C RID: 140 RVA: 0x00003474 File Offset: 0x00001674
			public IKeyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(CreationExtras.IKeyInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0400001D RID: 29
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/lifecycle/viewmodel/CreationExtras$Key", typeof(CreationExtras.IKeyInvoker));

			// Token: 0x0400001E RID: 30
			private IntPtr class_ref;
		}
	}
}
