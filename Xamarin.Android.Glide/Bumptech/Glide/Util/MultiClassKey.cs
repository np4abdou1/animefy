using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Util
{
	// Token: 0x02000051 RID: 81
	[Register("com/bumptech/glide/util/MultiClassKey", DoNotGenerateAcw = true)]
	public class MultiClassKey : Java.Lang.Object
	{
		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x0000C1C4 File Offset: 0x0000A3C4
		internal static IntPtr class_ref
		{
			get
			{
				return MultiClassKey._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x0000C1E8 File Offset: 0x0000A3E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MultiClassKey._members;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x0000C1F0 File Offset: 0x0000A3F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MultiClassKey._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x0000C214 File Offset: 0x0000A414
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MultiClassKey._members.ManagedPeerType;
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000C220 File Offset: 0x0000A420
		protected MultiClassKey(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000C22C File Offset: 0x0000A42C
		[Register(".ctor", "()V", "")]
		public MultiClassKey() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(MultiClassKey._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			MultiClassKey._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000C29C File Offset: 0x0000A49C
		[Register(".ctor", "(Ljava/lang/Class;Ljava/lang/Class;)V", "")]
		public unsafe MultiClassKey(Class first, Class second) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((first == null) ? IntPtr.Zero : first.Handle);
				ptr[1] = new JniArgumentValue((second == null) ? IntPtr.Zero : second.Handle);
				base.SetHandle(MultiClassKey._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Class;Ljava/lang/Class;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MultiClassKey._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Class;Ljava/lang/Class;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(first);
				GC.KeepAlive(second);
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000C374 File Offset: 0x0000A574
		[Register(".ctor", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;)V", "")]
		public unsafe MultiClassKey(Class first, Class second, Class third) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((first == null) ? IntPtr.Zero : first.Handle);
				ptr[1] = new JniArgumentValue((second == null) ? IntPtr.Zero : second.Handle);
				ptr[2] = new JniArgumentValue((third == null) ? IntPtr.Zero : third.Handle);
				base.SetHandle(MultiClassKey._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MultiClassKey._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(first);
				GC.KeepAlive(second);
				GC.KeepAlive(third);
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000C474 File Offset: 0x0000A674
		private static Delegate GetSet_Ljava_lang_Class_Ljava_lang_Class_Handler()
		{
			if (MultiClassKey.cb_set_Ljava_lang_Class_Ljava_lang_Class_ == null)
			{
				MultiClassKey.cb_set_Ljava_lang_Class_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MultiClassKey.n_Set_Ljava_lang_Class_Ljava_lang_Class_));
			}
			return MultiClassKey.cb_set_Ljava_lang_Class_Ljava_lang_Class_;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000C498 File Offset: 0x0000A698
		private static void n_Set_Ljava_lang_Class_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_first, IntPtr native_second)
		{
			MultiClassKey @object = Java.Lang.Object.GetObject<MultiClassKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_first, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_second, JniHandleOwnership.DoNotTransfer);
			@object.Set(object2, object3);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000C4C4 File Offset: 0x0000A6C4
		[Register("set", "(Ljava/lang/Class;Ljava/lang/Class;)V", "GetSet_Ljava_lang_Class_Ljava_lang_Class_Handler")]
		public unsafe virtual void Set(Class first, Class second)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((first == null) ? IntPtr.Zero : first.Handle);
				ptr[1] = new JniArgumentValue((second == null) ? IntPtr.Zero : second.Handle);
				MultiClassKey._members.InstanceMethods.InvokeVirtualVoidMethod("set.(Ljava/lang/Class;Ljava/lang/Class;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(first);
				GC.KeepAlive(second);
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000C550 File Offset: 0x0000A750
		private static Delegate GetSet_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_Handler()
		{
			if (MultiClassKey.cb_set_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_ == null)
			{
				MultiClassKey.cb_set_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(MultiClassKey.n_Set_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_));
			}
			return MultiClassKey.cb_set_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000C574 File Offset: 0x0000A774
		private static void n_Set_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_first, IntPtr native_second, IntPtr native_third)
		{
			MultiClassKey @object = Java.Lang.Object.GetObject<MultiClassKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_first, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_second, JniHandleOwnership.DoNotTransfer);
			Class object4 = Java.Lang.Object.GetObject<Class>(native_third, JniHandleOwnership.DoNotTransfer);
			@object.Set(object2, object3, object4);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000C5AC File Offset: 0x0000A7AC
		[Register("set", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;)V", "GetSet_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_Handler")]
		public unsafe virtual void Set(Class first, Class second, Class third)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((first == null) ? IntPtr.Zero : first.Handle);
				ptr[1] = new JniArgumentValue((second == null) ? IntPtr.Zero : second.Handle);
				ptr[2] = new JniArgumentValue((third == null) ? IntPtr.Zero : third.Handle);
				MultiClassKey._members.InstanceMethods.InvokeVirtualVoidMethod("set.(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(first);
				GC.KeepAlive(second);
				GC.KeepAlive(third);
			}
		}

		// Token: 0x040000C9 RID: 201
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/util/MultiClassKey", typeof(MultiClassKey));

		// Token: 0x040000CA RID: 202
		private static Delegate cb_set_Ljava_lang_Class_Ljava_lang_Class_;

		// Token: 0x040000CB RID: 203
		private static Delegate cb_set_Ljava_lang_Class_Ljava_lang_Class_Ljava_lang_Class_;
	}
}
