using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace AndroidX.Lifecycle
{
	// Token: 0x0200000E RID: 14
	[Register("androidx/lifecycle/ViewModel", DoNotGenerateAcw = true)]
	public abstract class ViewModel : Java.Lang.Object
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002408 File Offset: 0x00000608
		internal static IntPtr class_ref
		{
			get
			{
				return ViewModel._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000037 RID: 55 RVA: 0x0000242C File Offset: 0x0000062C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ViewModel._members;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002434 File Offset: 0x00000634
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ViewModel._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002458 File Offset: 0x00000658
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ViewModel._members.ManagedPeerType;
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002464 File Offset: 0x00000664
		protected ViewModel(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002470 File Offset: 0x00000670
		[Register(".ctor", "()V", "")]
		public ViewModel() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ViewModel._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ViewModel._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000024E0 File Offset: 0x000006E0
		[Register(".ctor", "([Ljava/io/Closeable;)V", "")]
		public unsafe ViewModel(params ICloseable[] closeables) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewArray<ICloseable>(closeables);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(ViewModel._members.InstanceMethods.StartCreateInstance("([Ljava/io/Closeable;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ViewModel._members.InstanceMethods.FinishCreateInstance("([Ljava/io/Closeable;)V", this, ptr);
			}
			finally
			{
				if (closeables != null)
				{
					JNIEnv.CopyArray<ICloseable>(intPtr, closeables);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(closeables);
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002594 File Offset: 0x00000794
		private static Delegate GetAddCloseable_Ljava_io_Closeable_Handler()
		{
			if (ViewModel.cb_addCloseable_Ljava_io_Closeable_ == null)
			{
				ViewModel.cb_addCloseable_Ljava_io_Closeable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ViewModel.n_AddCloseable_Ljava_io_Closeable_));
			}
			return ViewModel.cb_addCloseable_Ljava_io_Closeable_;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000025B8 File Offset: 0x000007B8
		private static void n_AddCloseable_Ljava_io_Closeable_(IntPtr jnienv, IntPtr native__this, IntPtr native_closeable)
		{
			ViewModel @object = Java.Lang.Object.GetObject<ViewModel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICloseable object2 = Java.Lang.Object.GetObject<ICloseable>(native_closeable, JniHandleOwnership.DoNotTransfer);
			@object.AddCloseable(object2);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000025DC File Offset: 0x000007DC
		[Register("addCloseable", "(Ljava/io/Closeable;)V", "GetAddCloseable_Ljava_io_Closeable_Handler")]
		public unsafe virtual void AddCloseable(ICloseable closeable)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((closeable == null) ? IntPtr.Zero : ((Java.Lang.Object)closeable).Handle);
				ViewModel._members.InstanceMethods.InvokeVirtualVoidMethod("addCloseable.(Ljava/io/Closeable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(closeable);
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002644 File Offset: 0x00000844
		private static Delegate GetOnClearedHandler()
		{
			if (ViewModel.cb_onCleared == null)
			{
				ViewModel.cb_onCleared = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ViewModel.n_OnCleared));
			}
			return ViewModel.cb_onCleared;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002668 File Offset: 0x00000868
		private static void n_OnCleared(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ViewModel>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnCleared();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002677 File Offset: 0x00000877
		[Register("onCleared", "()V", "GetOnClearedHandler")]
		protected virtual void OnCleared()
		{
			ViewModel._members.InstanceMethods.InvokeVirtualVoidMethod("onCleared.()V", this, null);
		}

		// Token: 0x0400000D RID: 13
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/lifecycle/ViewModel", typeof(ViewModel));

		// Token: 0x0400000E RID: 14
		private static Delegate cb_addCloseable_Ljava_io_Closeable_;

		// Token: 0x0400000F RID: 15
		private static Delegate cb_onCleared;
	}
}
