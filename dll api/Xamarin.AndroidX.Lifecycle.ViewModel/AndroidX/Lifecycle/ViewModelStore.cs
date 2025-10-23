using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Lifecycle
{
	// Token: 0x02000014 RID: 20
	[Register("androidx/lifecycle/ViewModelStore", DoNotGenerateAcw = true)]
	public class ViewModelStore : Java.Lang.Object
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000030E8 File Offset: 0x000012E8
		internal static IntPtr class_ref
		{
			get
			{
				return ViewModelStore._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0000310C File Offset: 0x0000130C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ViewModelStore._members;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00003114 File Offset: 0x00001314
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ViewModelStore._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00003138 File Offset: 0x00001338
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ViewModelStore._members.ManagedPeerType;
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002464 File Offset: 0x00000664
		protected ViewModelStore(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00003144 File Offset: 0x00001344
		[Register(".ctor", "()V", "")]
		public ViewModelStore() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ViewModelStore._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ViewModelStore._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000031B2 File Offset: 0x000013B2
		[Register("clear", "()V", "")]
		public void Clear()
		{
			ViewModelStore._members.InstanceMethods.InvokeNonvirtualVoidMethod("clear.()V", this, null);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000031CC File Offset: 0x000013CC
		[Register("get", "(Ljava/lang/String;)Landroidx/lifecycle/ViewModel;", "")]
		public unsafe ViewModel Get(string key)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			ViewModel @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ViewModel>(ViewModelStore._members.InstanceMethods.InvokeNonvirtualObjectMethod("get.(Ljava/lang/String;)Landroidx/lifecycle/ViewModel;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003238 File Offset: 0x00001438
		[Register("keys", "()Ljava/util/Set;", "")]
		public ICollection<string> Keys()
		{
			return JavaSet<string>.FromJniHandle(ViewModelStore._members.InstanceMethods.InvokeNonvirtualObjectMethod("keys.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000326C File Offset: 0x0000146C
		[Register("put", "(Ljava/lang/String;Landroidx/lifecycle/ViewModel;)V", "")]
		public unsafe void Put(string key, ViewModel viewModel)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((viewModel == null) ? IntPtr.Zero : viewModel.Handle);
				ViewModelStore._members.InstanceMethods.InvokeNonvirtualVoidMethod("put.(Ljava/lang/String;Landroidx/lifecycle/ViewModel;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(viewModel);
			}
		}

		// Token: 0x0400001A RID: 26
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/lifecycle/ViewModelStore", typeof(ViewModelStore));
	}
}
