using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine.BitmapRecycle
{
	// Token: 0x02000182 RID: 386
	[Register("com/bumptech/glide/load/engine/bitmap_recycle/LruArrayPool", DoNotGenerateAcw = true)]
	public sealed class LruArrayPool : Java.Lang.Object, IArrayPool, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001333 RID: 4915 RVA: 0x0003D508 File Offset: 0x0003B708
		internal static IntPtr class_ref
		{
			get
			{
				return LruArrayPool._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06001334 RID: 4916 RVA: 0x0003D52C File Offset: 0x0003B72C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LruArrayPool._members;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001335 RID: 4917 RVA: 0x0003D534 File Offset: 0x0003B734
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LruArrayPool._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x0003D558 File Offset: 0x0003B758
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LruArrayPool._members.ManagedPeerType;
			}
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x0003D564 File Offset: 0x0003B764
		internal LruArrayPool(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x0003D570 File Offset: 0x0003B770
		[Register(".ctor", "()V", "")]
		public LruArrayPool() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(LruArrayPool._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			LruArrayPool._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x0003D5E0 File Offset: 0x0003B7E0
		[Register(".ctor", "(I)V", "")]
		public unsafe LruArrayPool(int maxSize) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(maxSize);
			base.SetHandle(LruArrayPool._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			LruArrayPool._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x0003D664 File Offset: 0x0003B864
		[Register("clearMemory", "()V", "")]
		public void ClearMemory()
		{
			LruArrayPool._members.InstanceMethods.InvokeAbstractVoidMethod("clearMemory.()V", this, null);
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x0003D680 File Offset: 0x0003B880
		[Register("get", "(ILjava/lang/Class;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe Java.Lang.Object Get(int size, Class arrayClass)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(size);
				ptr[1] = new JniArgumentValue((arrayClass == null) ? IntPtr.Zero : arrayClass.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(LruArrayPool._members.InstanceMethods.InvokeAbstractObjectMethod("get.(ILjava/lang/Class;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(arrayClass);
			}
			return @object;
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x0003D708 File Offset: 0x0003B908
		[Register("getExact", "(ILjava/lang/Class;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe Java.Lang.Object GetExact(int size, Class arrayClass)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(size);
				ptr[1] = new JniArgumentValue((arrayClass == null) ? IntPtr.Zero : arrayClass.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(LruArrayPool._members.InstanceMethods.InvokeAbstractObjectMethod("getExact.(ILjava/lang/Class;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(arrayClass);
			}
			return @object;
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x0003D790 File Offset: 0x0003B990
		[Register("put", "(Ljava/lang/Object;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe void Put(Java.Lang.Object array)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(array);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				LruArrayPool._members.InstanceMethods.InvokeAbstractVoidMethod("put.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(array);
			}
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x0003D7F4 File Offset: 0x0003B9F4
		[Obsolete("deprecated")]
		[Register("put", "(Ljava/lang/Object;Ljava/lang/Class;)V", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe void Put(Java.Lang.Object array, Class arrayClass)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(array);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((arrayClass == null) ? IntPtr.Zero : arrayClass.Handle);
				LruArrayPool._members.InstanceMethods.InvokeAbstractVoidMethod("put.(Ljava/lang/Object;Ljava/lang/Class;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(array);
				GC.KeepAlive(arrayClass);
			}
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x0003D880 File Offset: 0x0003BA80
		[Register("trimMemory", "(I)V", "")]
		public unsafe void TrimMemory(int level)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(level);
			LruArrayPool._members.InstanceMethods.InvokeAbstractVoidMethod("trimMemory.(I)V", this, ptr);
		}

		// Token: 0x04000491 RID: 1169
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/bitmap_recycle/LruArrayPool", typeof(LruArrayPool));

		// Token: 0x02000200 RID: 512
		public static class InterfaceConsts
		{
			// Token: 0x040005BF RID: 1471
			[Register("STANDARD_BUFFER_SIZE_BYTES")]
			public const int StandardBufferSizeBytes = 65536;
		}
	}
}
