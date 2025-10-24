using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Drawable
{
	// Token: 0x020000F2 RID: 242
	[Register("com/bumptech/glide/load/resource/drawable/DrawableResource", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T extends android.graphics.drawable.Drawable"
	})]
	public abstract class DrawableResource : Java.Lang.Object, IInitializable, IJavaObject, IDisposable, IJavaPeerable, IResource
	{
		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x00025768 File Offset: 0x00023968
		// (set) Token: 0x06000BF8 RID: 3064 RVA: 0x00025798 File Offset: 0x00023998
		[Register("drawable")]
		protected Drawable Drawable
		{
			get
			{
				return Java.Lang.Object.GetObject<Drawable>(DrawableResource._members.InstanceFields.GetObjectValue("drawable.Landroid/graphics/drawable/Drawable;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					DrawableResource._members.InstanceFields.SetValue("drawable.Landroid/graphics/drawable/Drawable;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x000257E4 File Offset: 0x000239E4
		internal static IntPtr class_ref
		{
			get
			{
				return DrawableResource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x00025808 File Offset: 0x00023A08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DrawableResource._members;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000BFB RID: 3067 RVA: 0x00025810 File Offset: 0x00023A10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DrawableResource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000BFC RID: 3068 RVA: 0x00025834 File Offset: 0x00023A34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DrawableResource._members.ManagedPeerType;
			}
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00025840 File Offset: 0x00023A40
		protected DrawableResource(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x0002584C File Offset: 0x00023A4C
		[Register(".ctor", "(Landroid/graphics/drawable/Drawable;)V", "")]
		public unsafe DrawableResource(Java.Lang.Object drawable) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(drawable);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(DrawableResource._members.InstanceMethods.StartCreateInstance("(Landroid/graphics/drawable/Drawable;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DrawableResource._members.InstanceMethods.FinishCreateInstance("(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(drawable);
			}
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x000258F8 File Offset: 0x00023AF8
		[Register("get", "()Landroid/graphics/drawable/Drawable;", "")]
		public Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(DrawableResource._members.InstanceMethods.InvokeNonvirtualObjectMethod("get.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x0002592A File Offset: 0x00023B2A
		private static Delegate GetInitializeHandler()
		{
			if (DrawableResource.cb_initialize == null)
			{
				DrawableResource.cb_initialize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(DrawableResource.n_Initialize));
			}
			return DrawableResource.cb_initialize;
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x0002594E File Offset: 0x00023B4E
		private static void n_Initialize(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<DrawableResource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Initialize();
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x0002595D File Offset: 0x00023B5D
		[Register("initialize", "()V", "GetInitializeHandler")]
		public virtual void Initialize()
		{
			DrawableResource._members.InstanceMethods.InvokeVirtualVoidMethod("initialize.()V", this, null);
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00025976 File Offset: 0x00023B76
		private static Delegate GetRecycleHandler()
		{
			if (DrawableResource.cb_recycle == null)
			{
				DrawableResource.cb_recycle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(DrawableResource.n_Recycle));
			}
			return DrawableResource.cb_recycle;
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x0002599A File Offset: 0x00023B9A
		private static void n_Recycle(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<DrawableResource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Recycle();
		}

		// Token: 0x06000C05 RID: 3077
		[Register("recycle", "()V", "GetRecycleHandler")]
		public abstract void Recycle();

		// Token: 0x06000C06 RID: 3078 RVA: 0x000259A9 File Offset: 0x00023BA9
		private static Delegate GetGetResourceClassHandler()
		{
			if (DrawableResource.cb_getResourceClass == null)
			{
				DrawableResource.cb_getResourceClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(DrawableResource.n_GetResourceClass));
			}
			return DrawableResource.cb_getResourceClass;
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x000259CD File Offset: 0x00023BCD
		private static IntPtr n_GetResourceClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<DrawableResource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResourceClass);
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000C08 RID: 3080
		public abstract Class ResourceClass { [Register("getResourceClass", "()Ljava/lang/Class;", "GetGetResourceClassHandler")] get; }

		// Token: 0x06000C09 RID: 3081 RVA: 0x000259E1 File Offset: 0x00023BE1
		private static Delegate GetGetSizeHandler()
		{
			if (DrawableResource.cb_getSize == null)
			{
				DrawableResource.cb_getSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(DrawableResource.n_GetSize));
			}
			return DrawableResource.cb_getSize;
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x00025A05 File Offset: 0x00023C05
		private static int n_GetSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<DrawableResource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size;
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000C0B RID: 3083
		public abstract int Size { [Register("getSize", "()I", "GetGetSizeHandler")] get; }

		// Token: 0x040002E8 RID: 744
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/drawable/DrawableResource", typeof(DrawableResource));

		// Token: 0x040002E9 RID: 745
		private static Delegate cb_initialize;

		// Token: 0x040002EA RID: 746
		private static Delegate cb_recycle;

		// Token: 0x040002EB RID: 747
		private static Delegate cb_getResourceClass;

		// Token: 0x040002EC RID: 748
		private static Delegate cb_getSize;
	}
}
