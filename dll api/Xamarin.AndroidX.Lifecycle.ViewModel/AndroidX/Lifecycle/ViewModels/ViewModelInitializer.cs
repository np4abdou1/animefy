using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Jvm.Functions;

namespace AndroidX.Lifecycle.ViewModels
{
	// Token: 0x02000019 RID: 25
	[Register("androidx/lifecycle/viewmodel/ViewModelInitializer", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T extends androidx.lifecycle.ViewModel"
	})]
	public sealed class ViewModelInitializer : Java.Lang.Object
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00003578 File Offset: 0x00001778
		internal static IntPtr class_ref
		{
			get
			{
				return ViewModelInitializer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000359C File Offset: 0x0000179C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ViewModelInitializer._members;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000035A4 File Offset: 0x000017A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ViewModelInitializer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000096 RID: 150 RVA: 0x000035C8 File Offset: 0x000017C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ViewModelInitializer._members.ManagedPeerType;
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002464 File Offset: 0x00000664
		internal ViewModelInitializer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000035D4 File Offset: 0x000017D4
		[Register(".ctor", "(Ljava/lang/Class;Lkotlin/jvm/functions/Function1;)V", "")]
		public unsafe ViewModelInitializer(Class clazz, IFunction1 initializer) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((clazz == null) ? IntPtr.Zero : clazz.Handle);
				ptr[1] = new JniArgumentValue((initializer == null) ? IntPtr.Zero : ((Java.Lang.Object)initializer).Handle);
				base.SetHandle(ViewModelInitializer._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Class;Lkotlin/jvm/functions/Function1;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ViewModelInitializer._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Class;Lkotlin/jvm/functions/Function1;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(clazz);
				GC.KeepAlive(initializer);
			}
		}

		// Token: 0x04000020 RID: 32
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/lifecycle/viewmodel/ViewModelInitializer", typeof(ViewModelInitializer));
	}
}
