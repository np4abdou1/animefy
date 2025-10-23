using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load.Engine;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource
{
	// Token: 0x020000E3 RID: 227
	[Register("com/bumptech/glide/load/resource/SimpleResource", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public class SimpleResource : Java.Lang.Object, IResource, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000B5A RID: 2906 RVA: 0x00023630 File Offset: 0x00021830
		// (set) Token: 0x06000B5B RID: 2907 RVA: 0x00023660 File Offset: 0x00021860
		[Register("data")]
		protected Java.Lang.Object Data
		{
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Object>(SimpleResource._members.InstanceFields.GetObjectValue("data.Ljava/lang/Object;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					SimpleResource._members.InstanceFields.SetValue("data.Ljava/lang/Object;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x000236AC File Offset: 0x000218AC
		internal static IntPtr class_ref
		{
			get
			{
				return SimpleResource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x000236D0 File Offset: 0x000218D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SimpleResource._members;
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x000236D8 File Offset: 0x000218D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SimpleResource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x000236FC File Offset: 0x000218FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SimpleResource._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00023708 File Offset: 0x00021908
		protected SimpleResource(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00023714 File Offset: 0x00021914
		[Register(".ctor", "(Ljava/lang/Object;)V", "")]
		public unsafe SimpleResource(Java.Lang.Object data) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(data);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(SimpleResource._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				SimpleResource._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(data);
			}
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x000237C0 File Offset: 0x000219C0
		private static Delegate GetGetResourceClassHandler()
		{
			if (SimpleResource.cb_getResourceClass == null)
			{
				SimpleResource.cb_getResourceClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SimpleResource.n_GetResourceClass));
			}
			return SimpleResource.cb_getResourceClass;
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x000237E4 File Offset: 0x000219E4
		private static IntPtr n_GetResourceClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SimpleResource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResourceClass);
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x000237F8 File Offset: 0x000219F8
		public virtual Class ResourceClass
		{
			[Register("getResourceClass", "()Ljava/lang/Class;", "GetGetResourceClassHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(SimpleResource._members.InstanceMethods.InvokeVirtualObjectMethod("getResourceClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x0002382A File Offset: 0x00021A2A
		public int Size
		{
			[Register("getSize", "()I", "")]
			get
			{
				return SimpleResource._members.InstanceMethods.InvokeNonvirtualInt32Method("getSize.()I", this, null);
			}
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x00023844 File Offset: 0x00021A44
		[Register("get", "()Ljava/lang/Object;", "")]
		public Java.Lang.Object Get()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(SimpleResource._members.InstanceMethods.InvokeNonvirtualObjectMethod("get.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00023876 File Offset: 0x00021A76
		private static Delegate GetRecycleHandler()
		{
			if (SimpleResource.cb_recycle == null)
			{
				SimpleResource.cb_recycle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(SimpleResource.n_Recycle));
			}
			return SimpleResource.cb_recycle;
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x0002389A File Offset: 0x00021A9A
		private static void n_Recycle(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<SimpleResource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Recycle();
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x000238A9 File Offset: 0x00021AA9
		[Register("recycle", "()V", "GetRecycleHandler")]
		public virtual void Recycle()
		{
			SimpleResource._members.InstanceMethods.InvokeVirtualVoidMethod("recycle.()V", this, null);
		}

		// Token: 0x040002CC RID: 716
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/SimpleResource", typeof(SimpleResource));

		// Token: 0x040002CD RID: 717
		private static Delegate cb_getResourceClass;

		// Token: 0x040002CE RID: 718
		private static Delegate cb_recycle;
	}
}
