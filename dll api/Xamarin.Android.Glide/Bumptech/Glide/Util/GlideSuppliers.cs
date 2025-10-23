using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Util
{
	// Token: 0x0200004B RID: 75
	[Register("com/bumptech/glide/util/GlideSuppliers", DoNotGenerateAcw = true)]
	public sealed class GlideSuppliers : Java.Lang.Object
	{
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600034B RID: 843 RVA: 0x0000B3C8 File Offset: 0x000095C8
		internal static IntPtr class_ref
		{
			get
			{
				return GlideSuppliers._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600034C RID: 844 RVA: 0x0000B3EC File Offset: 0x000095EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GlideSuppliers._members;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600034D RID: 845 RVA: 0x0000B3F4 File Offset: 0x000095F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GlideSuppliers._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0000B418 File Offset: 0x00009618
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GlideSuppliers._members.ManagedPeerType;
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000B424 File Offset: 0x00009624
		internal GlideSuppliers(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000B430 File Offset: 0x00009630
		[Register("memorize", "(Lcom/bumptech/glide/util/GlideSuppliers$GlideSupplier;)Lcom/bumptech/glide/util/GlideSuppliers$GlideSupplier;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe static GlideSuppliers.IGlideSupplier Memorize(GlideSuppliers.IGlideSupplier supplier)
		{
			GlideSuppliers.IGlideSupplier @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((supplier == null) ? IntPtr.Zero : ((Java.Lang.Object)supplier).Handle);
				@object = Java.Lang.Object.GetObject<GlideSuppliers.IGlideSupplier>(GlideSuppliers._members.StaticMethods.InvokeObjectMethod("memorize.(Lcom/bumptech/glide/util/GlideSuppliers$GlideSupplier;)Lcom/bumptech/glide/util/GlideSuppliers$GlideSupplier;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(supplier);
			}
			return @object;
		}

		// Token: 0x040000AF RID: 175
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/util/GlideSuppliers", typeof(GlideSuppliers));

		// Token: 0x020001AF RID: 431
		[Register("com/bumptech/glide/util/GlideSuppliers$GlideSupplier", "", "Bumptech.Glide.Util.GlideSuppliers/IGlideSupplierInvoker")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public interface IGlideSupplier : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x0600156A RID: 5482
			[Register("get", "()Ljava/lang/Object;", "GetGetHandler:Bumptech.Glide.Util.GlideSuppliers/IGlideSupplierInvoker, Xamarin.Android.Glide")]
			Java.Lang.Object Get();
		}

		// Token: 0x020001B0 RID: 432
		[Register("com/bumptech/glide/util/GlideSuppliers$GlideSupplier", DoNotGenerateAcw = true)]
		internal class IGlideSupplierInvoker : Java.Lang.Object, GlideSuppliers.IGlideSupplier, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170005BD RID: 1469
			// (get) Token: 0x0600156B RID: 5483 RVA: 0x000439AC File Offset: 0x00041BAC
			private static IntPtr java_class_ref
			{
				get
				{
					return GlideSuppliers.IGlideSupplierInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005BE RID: 1470
			// (get) Token: 0x0600156C RID: 5484 RVA: 0x000439D0 File Offset: 0x00041BD0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return GlideSuppliers.IGlideSupplierInvoker._members;
				}
			}

			// Token: 0x170005BF RID: 1471
			// (get) Token: 0x0600156D RID: 5485 RVA: 0x000439D7 File Offset: 0x00041BD7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170005C0 RID: 1472
			// (get) Token: 0x0600156E RID: 5486 RVA: 0x000439DF File Offset: 0x00041BDF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return GlideSuppliers.IGlideSupplierInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600156F RID: 5487 RVA: 0x000439EB File Offset: 0x00041BEB
			public static GlideSuppliers.IGlideSupplier GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<GlideSuppliers.IGlideSupplier>(handle, transfer);
			}

			// Token: 0x06001570 RID: 5488 RVA: 0x000439F4 File Offset: 0x00041BF4
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, GlideSuppliers.IGlideSupplierInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.util.GlideSuppliers.GlideSupplier'.");
				}
				return handle;
			}

			// Token: 0x06001571 RID: 5489 RVA: 0x00043A1F File Offset: 0x00041C1F
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06001572 RID: 5490 RVA: 0x00043A50 File Offset: 0x00041C50
			public IGlideSupplierInvoker(IntPtr handle, JniHandleOwnership transfer) : base(GlideSuppliers.IGlideSupplierInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06001573 RID: 5491 RVA: 0x00043A88 File Offset: 0x00041C88
			private static Delegate GetGetHandler()
			{
				if (GlideSuppliers.IGlideSupplierInvoker.cb_get == null)
				{
					GlideSuppliers.IGlideSupplierInvoker.cb_get = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GlideSuppliers.IGlideSupplierInvoker.n_Get));
				}
				return GlideSuppliers.IGlideSupplierInvoker.cb_get;
			}

			// Token: 0x06001574 RID: 5492 RVA: 0x00043AAC File Offset: 0x00041CAC
			private static IntPtr n_Get(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GlideSuppliers.IGlideSupplier>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Get());
			}

			// Token: 0x06001575 RID: 5493 RVA: 0x00043AC0 File Offset: 0x00041CC0
			public Java.Lang.Object Get()
			{
				if (this.id_get == IntPtr.Zero)
				{
					this.id_get = JNIEnv.GetMethodID(this.class_ref, "get", "()Ljava/lang/Object;");
				}
				return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_get), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000514 RID: 1300
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/util/GlideSuppliers$GlideSupplier", typeof(GlideSuppliers.IGlideSupplierInvoker));

			// Token: 0x04000515 RID: 1301
			private IntPtr class_ref;

			// Token: 0x04000516 RID: 1302
			private static Delegate cb_get;

			// Token: 0x04000517 RID: 1303
			private IntPtr id_get;
		}
	}
}
