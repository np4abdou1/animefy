using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Resource.Bytes
{
	// Token: 0x020000F8 RID: 248
	[Register("com/bumptech/glide/load/resource/bytes/BytesResource", DoNotGenerateAcw = true)]
	public class BytesResource : Java.Lang.Object
	{
		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000C51 RID: 3153 RVA: 0x000267B4 File Offset: 0x000249B4
		internal static IntPtr class_ref
		{
			get
			{
				return BytesResource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x000267D8 File Offset: 0x000249D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BytesResource._members;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x000267E0 File Offset: 0x000249E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BytesResource._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x00026804 File Offset: 0x00024A04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BytesResource._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x00026810 File Offset: 0x00024A10
		protected BytesResource(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x0002681C File Offset: 0x00024A1C
		[Register(".ctor", "([B)V", "")]
		public unsafe BytesResource(byte[] bytes) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewArray(bytes);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(BytesResource._members.InstanceMethods.StartCreateInstance("([B)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BytesResource._members.InstanceMethods.FinishCreateInstance("([B)V", this, ptr);
			}
			finally
			{
				if (bytes != null)
				{
					JNIEnv.CopyArray(intPtr, bytes);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(bytes);
			}
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x000268D0 File Offset: 0x00024AD0
		private static Delegate GetGetResourceClassHandler()
		{
			if (BytesResource.cb_getResourceClass == null)
			{
				BytesResource.cb_getResourceClass = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BytesResource.n_GetResourceClass));
			}
			return BytesResource.cb_getResourceClass;
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x000268F4 File Offset: 0x00024AF4
		private static IntPtr n_GetResourceClass(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BytesResource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ResourceClass);
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x00026908 File Offset: 0x00024B08
		public virtual Class ResourceClass
		{
			[Register("getResourceClass", "()Ljava/lang/Class;", "GetGetResourceClassHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(BytesResource._members.InstanceMethods.InvokeVirtualObjectMethod("getResourceClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x0002693A File Offset: 0x00024B3A
		private static Delegate GetGetSizeHandler()
		{
			if (BytesResource.cb_getSize == null)
			{
				BytesResource.cb_getSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BytesResource.n_GetSize));
			}
			return BytesResource.cb_getSize;
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x0002695E File Offset: 0x00024B5E
		private static int n_GetSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BytesResource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size;
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x0002696D File Offset: 0x00024B6D
		public virtual int Size
		{
			[Register("getSize", "()I", "GetGetSizeHandler")]
			get
			{
				return BytesResource._members.InstanceMethods.InvokeVirtualInt32Method("getSize.()I", this, null);
			}
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x00026986 File Offset: 0x00024B86
		private static Delegate GetGetHandler()
		{
			if (BytesResource.cb_get == null)
			{
				BytesResource.cb_get = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BytesResource.n_Get));
			}
			return BytesResource.cb_get;
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x000269AA File Offset: 0x00024BAA
		private static IntPtr n_Get(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<BytesResource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Get());
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x000269C0 File Offset: 0x00024BC0
		[Register("get", "()[B", "GetGetHandler")]
		public virtual byte[] Get()
		{
			return (byte[])JNIEnv.GetArray(BytesResource._members.InstanceMethods.InvokeVirtualObjectMethod("get.()[B", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00026A01 File Offset: 0x00024C01
		private static Delegate GetRecycleHandler()
		{
			if (BytesResource.cb_recycle == null)
			{
				BytesResource.cb_recycle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(BytesResource.n_Recycle));
			}
			return BytesResource.cb_recycle;
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x00026A25 File Offset: 0x00024C25
		private static void n_Recycle(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<BytesResource>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Recycle();
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x00026A34 File Offset: 0x00024C34
		[Register("recycle", "()V", "GetRecycleHandler")]
		public virtual void Recycle()
		{
			BytesResource._members.InstanceMethods.InvokeVirtualVoidMethod("recycle.()V", this, null);
		}

		// Token: 0x040002F8 RID: 760
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/resource/bytes/BytesResource", typeof(BytesResource));

		// Token: 0x040002F9 RID: 761
		private static Delegate cb_getResourceClass;

		// Token: 0x040002FA RID: 762
		private static Delegate cb_getSize;

		// Token: 0x040002FB RID: 763
		private static Delegate cb_get;

		// Token: 0x040002FC RID: 764
		private static Delegate cb_recycle;
	}
}
