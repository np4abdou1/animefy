using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Adcolony.Walking
{
	// Token: 0x0200001C RID: 28
	[Register("com/iab/omid/library/adcolony/walking/TreeWalker", DoNotGenerateAcw = true)]
	public class TreeWalker : Java.Lang.Object
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002304 File Offset: 0x00000504
		internal static IntPtr class_ref
		{
			get
			{
				return TreeWalker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00002328 File Offset: 0x00000528
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TreeWalker._members;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00002330 File Offset: 0x00000530
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TreeWalker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002354 File Offset: 0x00000554
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TreeWalker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002128 File Offset: 0x00000328
		protected TreeWalker(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00002360 File Offset: 0x00000560
		public static TreeWalker Instance
		{
			[Register("getInstance", "()Lcom/iab/omid/library/adcolony/walking/TreeWalker;", "")]
			get
			{
				return Java.Lang.Object.GetObject<TreeWalker>(TreeWalker._members.StaticMethods.InvokeObjectMethod("getInstance.()Lcom/iab/omid/library/adcolony/walking/TreeWalker;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002391 File Offset: 0x00000591
		private static Delegate GetAHandler()
		{
			if (TreeWalker.cb_a == null)
			{
				TreeWalker.cb_a = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(TreeWalker.n_A));
			}
			return TreeWalker.cb_a;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000023B5 File Offset: 0x000005B5
		private static void n_A(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<TreeWalker>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).A();
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000023C4 File Offset: 0x000005C4
		[Register("a", "()V", "GetAHandler")]
		public virtual void A()
		{
			TreeWalker._members.InstanceMethods.InvokeVirtualVoidMethod("a.()V", this, null);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000023DD File Offset: 0x000005DD
		private static Delegate GetAddTimeLogger_Lcom_iab_omid_library_adcolony_walking_TreeWalker_TreeWalkerTimeLogger_Handler()
		{
			if (TreeWalker.cb_addTimeLogger_Lcom_iab_omid_library_adcolony_walking_TreeWalker_TreeWalkerTimeLogger_ == null)
			{
				TreeWalker.cb_addTimeLogger_Lcom_iab_omid_library_adcolony_walking_TreeWalker_TreeWalkerTimeLogger_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TreeWalker.n_AddTimeLogger_Lcom_iab_omid_library_adcolony_walking_TreeWalker_TreeWalkerTimeLogger_));
			}
			return TreeWalker.cb_addTimeLogger_Lcom_iab_omid_library_adcolony_walking_TreeWalker_TreeWalkerTimeLogger_;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002404 File Offset: 0x00000604
		private static void n_AddTimeLogger_Lcom_iab_omid_library_adcolony_walking_TreeWalker_TreeWalkerTimeLogger_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			TreeWalker @object = Java.Lang.Object.GetObject<TreeWalker>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TreeWalker.ITreeWalkerTimeLogger object2 = Java.Lang.Object.GetObject<TreeWalker.ITreeWalkerTimeLogger>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.AddTimeLogger(object2);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002428 File Offset: 0x00000628
		[Register("addTimeLogger", "(Lcom/iab/omid/library/adcolony/walking/TreeWalker$TreeWalkerTimeLogger;)V", "GetAddTimeLogger_Lcom_iab_omid_library_adcolony_walking_TreeWalker_TreeWalkerTimeLogger_Handler")]
		public unsafe virtual void AddTimeLogger(TreeWalker.ITreeWalkerTimeLogger p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				TreeWalker._members.InstanceMethods.InvokeVirtualVoidMethod("addTimeLogger.(Lcom/iab/omid/library/adcolony/walking/TreeWalker$TreeWalkerTimeLogger;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002490 File Offset: 0x00000690
		private static Delegate GetBHandler()
		{
			if (TreeWalker.cb_b == null)
			{
				TreeWalker.cb_b = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(TreeWalker.n_B));
			}
			return TreeWalker.cb_b;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000024B4 File Offset: 0x000006B4
		private static void n_B(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<TreeWalker>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).B();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000024C3 File Offset: 0x000006C3
		[Register("b", "()V", "GetBHandler")]
		public virtual void B()
		{
			TreeWalker._members.InstanceMethods.InvokeVirtualVoidMethod("b.()V", this, null);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000024DC File Offset: 0x000006DC
		private static Delegate GetCHandler()
		{
			if (TreeWalker.cb_c == null)
			{
				TreeWalker.cb_c = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(TreeWalker.n_C));
			}
			return TreeWalker.cb_c;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002500 File Offset: 0x00000700
		private static void n_C(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<TreeWalker>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).C();
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000250F File Offset: 0x0000070F
		[Register("c", "()V", "GetCHandler")]
		public virtual void C()
		{
			TreeWalker._members.InstanceMethods.InvokeVirtualVoidMethod("c.()V", this, null);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002528 File Offset: 0x00000728
		private static Delegate GetRemoveTimeLogger_Lcom_iab_omid_library_adcolony_walking_TreeWalker_TreeWalkerTimeLogger_Handler()
		{
			if (TreeWalker.cb_removeTimeLogger_Lcom_iab_omid_library_adcolony_walking_TreeWalker_TreeWalkerTimeLogger_ == null)
			{
				TreeWalker.cb_removeTimeLogger_Lcom_iab_omid_library_adcolony_walking_TreeWalker_TreeWalkerTimeLogger_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TreeWalker.n_RemoveTimeLogger_Lcom_iab_omid_library_adcolony_walking_TreeWalker_TreeWalkerTimeLogger_));
			}
			return TreeWalker.cb_removeTimeLogger_Lcom_iab_omid_library_adcolony_walking_TreeWalker_TreeWalkerTimeLogger_;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000254C File Offset: 0x0000074C
		private static void n_RemoveTimeLogger_Lcom_iab_omid_library_adcolony_walking_TreeWalker_TreeWalkerTimeLogger_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			TreeWalker @object = Java.Lang.Object.GetObject<TreeWalker>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TreeWalker.ITreeWalkerTimeLogger object2 = Java.Lang.Object.GetObject<TreeWalker.ITreeWalkerTimeLogger>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RemoveTimeLogger(object2);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002570 File Offset: 0x00000770
		[Register("removeTimeLogger", "(Lcom/iab/omid/library/adcolony/walking/TreeWalker$TreeWalkerTimeLogger;)V", "GetRemoveTimeLogger_Lcom_iab_omid_library_adcolony_walking_TreeWalker_TreeWalkerTimeLogger_Handler")]
		public unsafe virtual void RemoveTimeLogger(TreeWalker.ITreeWalkerTimeLogger p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				TreeWalker._members.InstanceMethods.InvokeVirtualVoidMethod("removeTimeLogger.(Lcom/iab/omid/library/adcolony/walking/TreeWalker$TreeWalkerTimeLogger;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x04000005 RID: 5
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/adcolony/walking/TreeWalker", typeof(TreeWalker));

		// Token: 0x04000006 RID: 6
		private static Delegate cb_a;

		// Token: 0x04000007 RID: 7
		private static Delegate cb_addTimeLogger_Lcom_iab_omid_library_adcolony_walking_TreeWalker_TreeWalkerTimeLogger_;

		// Token: 0x04000008 RID: 8
		private static Delegate cb_b;

		// Token: 0x04000009 RID: 9
		private static Delegate cb_c;

		// Token: 0x0400000A RID: 10
		private static Delegate cb_removeTimeLogger_Lcom_iab_omid_library_adcolony_walking_TreeWalker_TreeWalkerTimeLogger_;

		// Token: 0x0200001D RID: 29
		[Register("com/iab/omid/library/adcolony/walking/TreeWalker$TreeWalkerNanoTimeLogger", "", "Com.Iab.Omid.Library.Adcolony.Walking.TreeWalker/ITreeWalkerNanoTimeLoggerInvoker")]
		public interface ITreeWalkerNanoTimeLogger : TreeWalker.ITreeWalkerTimeLogger, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x0600007B RID: 123
			[Register("onTreeProcessedNano", "(IJ)V", "GetOnTreeProcessedNano_IJHandler:Com.Iab.Omid.Library.Adcolony.Walking.TreeWalker/ITreeWalkerNanoTimeLoggerInvoker, AdColony")]
			void OnTreeProcessedNano(int p0, long p1);
		}

		// Token: 0x0200001E RID: 30
		[Register("com/iab/omid/library/adcolony/walking/TreeWalker$TreeWalkerNanoTimeLogger", DoNotGenerateAcw = true)]
		internal class ITreeWalkerNanoTimeLoggerInvoker : Java.Lang.Object, TreeWalker.ITreeWalkerNanoTimeLogger, TreeWalker.ITreeWalkerTimeLogger, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000010 RID: 16
			// (get) Token: 0x0600007C RID: 124 RVA: 0x000025F4 File Offset: 0x000007F4
			private static IntPtr java_class_ref
			{
				get
				{
					return TreeWalker.ITreeWalkerNanoTimeLoggerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x0600007D RID: 125 RVA: 0x00002618 File Offset: 0x00000818
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return TreeWalker.ITreeWalkerNanoTimeLoggerInvoker._members;
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x0600007E RID: 126 RVA: 0x0000261F File Offset: 0x0000081F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x0600007F RID: 127 RVA: 0x00002627 File Offset: 0x00000827
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return TreeWalker.ITreeWalkerNanoTimeLoggerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000080 RID: 128 RVA: 0x00002633 File Offset: 0x00000833
			public static TreeWalker.ITreeWalkerNanoTimeLogger GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<TreeWalker.ITreeWalkerNanoTimeLogger>(handle, transfer);
			}

			// Token: 0x06000081 RID: 129 RVA: 0x0000263C File Offset: 0x0000083C
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, TreeWalker.ITreeWalkerNanoTimeLoggerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.iab.omid.library.adcolony.walking.TreeWalker.TreeWalkerNanoTimeLogger'.");
				}
				return handle;
			}

			// Token: 0x06000082 RID: 130 RVA: 0x00002667 File Offset: 0x00000867
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000083 RID: 131 RVA: 0x00002698 File Offset: 0x00000898
			public ITreeWalkerNanoTimeLoggerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(TreeWalker.ITreeWalkerNanoTimeLoggerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000084 RID: 132 RVA: 0x000026D0 File Offset: 0x000008D0
			private static Delegate GetOnTreeProcessedNano_IJHandler()
			{
				if (TreeWalker.ITreeWalkerNanoTimeLoggerInvoker.cb_onTreeProcessedNano_IJ == null)
				{
					TreeWalker.ITreeWalkerNanoTimeLoggerInvoker.cb_onTreeProcessedNano_IJ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIJ_V(TreeWalker.ITreeWalkerNanoTimeLoggerInvoker.n_OnTreeProcessedNano_IJ));
				}
				return TreeWalker.ITreeWalkerNanoTimeLoggerInvoker.cb_onTreeProcessedNano_IJ;
			}

			// Token: 0x06000085 RID: 133 RVA: 0x000026F4 File Offset: 0x000008F4
			private static void n_OnTreeProcessedNano_IJ(IntPtr jnienv, IntPtr native__this, int p0, long p1)
			{
				Java.Lang.Object.GetObject<TreeWalker.ITreeWalkerNanoTimeLogger>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnTreeProcessedNano(p0, p1);
			}

			// Token: 0x06000086 RID: 134 RVA: 0x00002708 File Offset: 0x00000908
			public unsafe void OnTreeProcessedNano(int p0, long p1)
			{
				if (this.id_onTreeProcessedNano_IJ == IntPtr.Zero)
				{
					this.id_onTreeProcessedNano_IJ = JNIEnv.GetMethodID(this.class_ref, "onTreeProcessedNano", "(IJ)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(p0);
				ptr[1] = new JValue(p1);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onTreeProcessedNano_IJ, ptr);
			}

			// Token: 0x06000087 RID: 135 RVA: 0x0000277F File Offset: 0x0000097F
			private static Delegate GetOnTreeProcessed_IJHandler()
			{
				if (TreeWalker.ITreeWalkerNanoTimeLoggerInvoker.cb_onTreeProcessed_IJ == null)
				{
					TreeWalker.ITreeWalkerNanoTimeLoggerInvoker.cb_onTreeProcessed_IJ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIJ_V(TreeWalker.ITreeWalkerNanoTimeLoggerInvoker.n_OnTreeProcessed_IJ));
				}
				return TreeWalker.ITreeWalkerNanoTimeLoggerInvoker.cb_onTreeProcessed_IJ;
			}

			// Token: 0x06000088 RID: 136 RVA: 0x000027A3 File Offset: 0x000009A3
			private static void n_OnTreeProcessed_IJ(IntPtr jnienv, IntPtr native__this, int p0, long p1)
			{
				Java.Lang.Object.GetObject<TreeWalker.ITreeWalkerNanoTimeLogger>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnTreeProcessed(p0, p1);
			}

			// Token: 0x06000089 RID: 137 RVA: 0x000027B4 File Offset: 0x000009B4
			public unsafe void OnTreeProcessed(int p0, long p1)
			{
				if (this.id_onTreeProcessed_IJ == IntPtr.Zero)
				{
					this.id_onTreeProcessed_IJ = JNIEnv.GetMethodID(this.class_ref, "onTreeProcessed", "(IJ)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(p0);
				ptr[1] = new JValue(p1);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onTreeProcessed_IJ, ptr);
			}

			// Token: 0x0400000B RID: 11
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/adcolony/walking/TreeWalker$TreeWalkerNanoTimeLogger", typeof(TreeWalker.ITreeWalkerNanoTimeLoggerInvoker));

			// Token: 0x0400000C RID: 12
			private IntPtr class_ref;

			// Token: 0x0400000D RID: 13
			private static Delegate cb_onTreeProcessedNano_IJ;

			// Token: 0x0400000E RID: 14
			private IntPtr id_onTreeProcessedNano_IJ;

			// Token: 0x0400000F RID: 15
			private static Delegate cb_onTreeProcessed_IJ;

			// Token: 0x04000010 RID: 16
			private IntPtr id_onTreeProcessed_IJ;
		}

		// Token: 0x0200001F RID: 31
		[Register("com/iab/omid/library/adcolony/walking/TreeWalker$TreeWalkerTimeLogger", "", "Com.Iab.Omid.Library.Adcolony.Walking.TreeWalker/ITreeWalkerTimeLoggerInvoker")]
		public interface ITreeWalkerTimeLogger : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x0600008B RID: 139
			[Register("onTreeProcessed", "(IJ)V", "GetOnTreeProcessed_IJHandler:Com.Iab.Omid.Library.Adcolony.Walking.TreeWalker/ITreeWalkerTimeLoggerInvoker, AdColony")]
			void OnTreeProcessed(int p0, long p1);
		}

		// Token: 0x02000020 RID: 32
		[Register("com/iab/omid/library/adcolony/walking/TreeWalker$TreeWalkerTimeLogger", DoNotGenerateAcw = true)]
		internal class ITreeWalkerTimeLoggerInvoker : Java.Lang.Object, TreeWalker.ITreeWalkerTimeLogger, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000014 RID: 20
			// (get) Token: 0x0600008C RID: 140 RVA: 0x00002848 File Offset: 0x00000A48
			private static IntPtr java_class_ref
			{
				get
				{
					return TreeWalker.ITreeWalkerTimeLoggerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x0600008D RID: 141 RVA: 0x0000286C File Offset: 0x00000A6C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return TreeWalker.ITreeWalkerTimeLoggerInvoker._members;
				}
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x0600008E RID: 142 RVA: 0x00002873 File Offset: 0x00000A73
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x0600008F RID: 143 RVA: 0x0000287B File Offset: 0x00000A7B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return TreeWalker.ITreeWalkerTimeLoggerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000090 RID: 144 RVA: 0x00002887 File Offset: 0x00000A87
			public static TreeWalker.ITreeWalkerTimeLogger GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<TreeWalker.ITreeWalkerTimeLogger>(handle, transfer);
			}

			// Token: 0x06000091 RID: 145 RVA: 0x00002890 File Offset: 0x00000A90
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, TreeWalker.ITreeWalkerTimeLoggerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.iab.omid.library.adcolony.walking.TreeWalker.TreeWalkerTimeLogger'.");
				}
				return handle;
			}

			// Token: 0x06000092 RID: 146 RVA: 0x000028BB File Offset: 0x00000ABB
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000093 RID: 147 RVA: 0x000028EC File Offset: 0x00000AEC
			public ITreeWalkerTimeLoggerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(TreeWalker.ITreeWalkerTimeLoggerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000094 RID: 148 RVA: 0x00002924 File Offset: 0x00000B24
			private static Delegate GetOnTreeProcessed_IJHandler()
			{
				if (TreeWalker.ITreeWalkerTimeLoggerInvoker.cb_onTreeProcessed_IJ == null)
				{
					TreeWalker.ITreeWalkerTimeLoggerInvoker.cb_onTreeProcessed_IJ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIJ_V(TreeWalker.ITreeWalkerTimeLoggerInvoker.n_OnTreeProcessed_IJ));
				}
				return TreeWalker.ITreeWalkerTimeLoggerInvoker.cb_onTreeProcessed_IJ;
			}

			// Token: 0x06000095 RID: 149 RVA: 0x00002948 File Offset: 0x00000B48
			private static void n_OnTreeProcessed_IJ(IntPtr jnienv, IntPtr native__this, int p0, long p1)
			{
				Java.Lang.Object.GetObject<TreeWalker.ITreeWalkerTimeLogger>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnTreeProcessed(p0, p1);
			}

			// Token: 0x06000096 RID: 150 RVA: 0x0000295C File Offset: 0x00000B5C
			public unsafe void OnTreeProcessed(int p0, long p1)
			{
				if (this.id_onTreeProcessed_IJ == IntPtr.Zero)
				{
					this.id_onTreeProcessed_IJ = JNIEnv.GetMethodID(this.class_ref, "onTreeProcessed", "(IJ)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(p0);
				ptr[1] = new JValue(p1);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onTreeProcessed_IJ, ptr);
			}

			// Token: 0x04000011 RID: 17
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/adcolony/walking/TreeWalker$TreeWalkerTimeLogger", typeof(TreeWalker.ITreeWalkerTimeLoggerInvoker));

			// Token: 0x04000012 RID: 18
			private IntPtr class_ref;

			// Token: 0x04000013 RID: 19
			private static Delegate cb_onTreeProcessed_IJ;

			// Token: 0x04000014 RID: 20
			private IntPtr id_onTreeProcessed_IJ;
		}
	}
}
