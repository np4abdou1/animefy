using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Applovin.Walking
{
	// Token: 0x02000031 RID: 49
	[Register("com/iab/omid/library/applovin/walking/TreeWalker", DoNotGenerateAcw = true)]
	public class TreeWalker : Java.Lang.Object
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000BC RID: 188 RVA: 0x000023CC File Offset: 0x000005CC
		internal static IntPtr class_ref
		{
			get
			{
				return TreeWalker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000BD RID: 189 RVA: 0x000023F0 File Offset: 0x000005F0
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
		// (get) Token: 0x060000BE RID: 190 RVA: 0x000023F8 File Offset: 0x000005F8
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
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0000241C File Offset: 0x0000061C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TreeWalker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000021F0 File Offset: 0x000003F0
		protected TreeWalker(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00002428 File Offset: 0x00000628
		public static TreeWalker Instance
		{
			[Register("getInstance", "()Lcom/iab/omid/library/applovin/walking/TreeWalker;", "")]
			get
			{
				return Java.Lang.Object.GetObject<TreeWalker>(TreeWalker._members.StaticMethods.InvokeObjectMethod("getInstance.()Lcom/iab/omid/library/applovin/walking/TreeWalker;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002459 File Offset: 0x00000659
		private static Delegate GetAHandler()
		{
			if (TreeWalker.cb_a == null)
			{
				TreeWalker.cb_a = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(TreeWalker.n_A));
			}
			return TreeWalker.cb_a;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000247D File Offset: 0x0000067D
		private static void n_A(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<TreeWalker>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).A();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000248C File Offset: 0x0000068C
		[Register("a", "()V", "GetAHandler")]
		public virtual void A()
		{
			TreeWalker._members.InstanceMethods.InvokeVirtualVoidMethod("a.()V", this, null);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000024A5 File Offset: 0x000006A5
		private static Delegate GetAddTimeLogger_Lcom_iab_omid_library_applovin_walking_TreeWalker_TreeWalkerTimeLogger_Handler()
		{
			if (TreeWalker.cb_addTimeLogger_Lcom_iab_omid_library_applovin_walking_TreeWalker_TreeWalkerTimeLogger_ == null)
			{
				TreeWalker.cb_addTimeLogger_Lcom_iab_omid_library_applovin_walking_TreeWalker_TreeWalkerTimeLogger_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TreeWalker.n_AddTimeLogger_Lcom_iab_omid_library_applovin_walking_TreeWalker_TreeWalkerTimeLogger_));
			}
			return TreeWalker.cb_addTimeLogger_Lcom_iab_omid_library_applovin_walking_TreeWalker_TreeWalkerTimeLogger_;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000024CC File Offset: 0x000006CC
		private static void n_AddTimeLogger_Lcom_iab_omid_library_applovin_walking_TreeWalker_TreeWalkerTimeLogger_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			TreeWalker @object = Java.Lang.Object.GetObject<TreeWalker>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TreeWalker.ITreeWalkerTimeLogger object2 = Java.Lang.Object.GetObject<TreeWalker.ITreeWalkerTimeLogger>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.AddTimeLogger(object2);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000024F0 File Offset: 0x000006F0
		[Register("addTimeLogger", "(Lcom/iab/omid/library/applovin/walking/TreeWalker$TreeWalkerTimeLogger;)V", "GetAddTimeLogger_Lcom_iab_omid_library_applovin_walking_TreeWalker_TreeWalkerTimeLogger_Handler")]
		public unsafe virtual void AddTimeLogger(TreeWalker.ITreeWalkerTimeLogger p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				TreeWalker._members.InstanceMethods.InvokeVirtualVoidMethod("addTimeLogger.(Lcom/iab/omid/library/applovin/walking/TreeWalker$TreeWalkerTimeLogger;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002558 File Offset: 0x00000758
		private static Delegate GetBHandler()
		{
			if (TreeWalker.cb_b == null)
			{
				TreeWalker.cb_b = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(TreeWalker.n_B));
			}
			return TreeWalker.cb_b;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000257C File Offset: 0x0000077C
		private static void n_B(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<TreeWalker>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).B();
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000258B File Offset: 0x0000078B
		[Register("b", "()V", "GetBHandler")]
		public virtual void B()
		{
			TreeWalker._members.InstanceMethods.InvokeVirtualVoidMethod("b.()V", this, null);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000025A4 File Offset: 0x000007A4
		private static Delegate GetCHandler()
		{
			if (TreeWalker.cb_c == null)
			{
				TreeWalker.cb_c = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(TreeWalker.n_C));
			}
			return TreeWalker.cb_c;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000025C8 File Offset: 0x000007C8
		private static void n_C(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<TreeWalker>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).C();
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000025D7 File Offset: 0x000007D7
		[Register("c", "()V", "GetCHandler")]
		public virtual void C()
		{
			TreeWalker._members.InstanceMethods.InvokeVirtualVoidMethod("c.()V", this, null);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000025F0 File Offset: 0x000007F0
		private static Delegate GetRemoveTimeLogger_Lcom_iab_omid_library_applovin_walking_TreeWalker_TreeWalkerTimeLogger_Handler()
		{
			if (TreeWalker.cb_removeTimeLogger_Lcom_iab_omid_library_applovin_walking_TreeWalker_TreeWalkerTimeLogger_ == null)
			{
				TreeWalker.cb_removeTimeLogger_Lcom_iab_omid_library_applovin_walking_TreeWalker_TreeWalkerTimeLogger_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TreeWalker.n_RemoveTimeLogger_Lcom_iab_omid_library_applovin_walking_TreeWalker_TreeWalkerTimeLogger_));
			}
			return TreeWalker.cb_removeTimeLogger_Lcom_iab_omid_library_applovin_walking_TreeWalker_TreeWalkerTimeLogger_;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002614 File Offset: 0x00000814
		private static void n_RemoveTimeLogger_Lcom_iab_omid_library_applovin_walking_TreeWalker_TreeWalkerTimeLogger_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			TreeWalker @object = Java.Lang.Object.GetObject<TreeWalker>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TreeWalker.ITreeWalkerTimeLogger object2 = Java.Lang.Object.GetObject<TreeWalker.ITreeWalkerTimeLogger>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RemoveTimeLogger(object2);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002638 File Offset: 0x00000838
		[Register("removeTimeLogger", "(Lcom/iab/omid/library/applovin/walking/TreeWalker$TreeWalkerTimeLogger;)V", "GetRemoveTimeLogger_Lcom_iab_omid_library_applovin_walking_TreeWalker_TreeWalkerTimeLogger_Handler")]
		public unsafe virtual void RemoveTimeLogger(TreeWalker.ITreeWalkerTimeLogger p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				TreeWalker._members.InstanceMethods.InvokeVirtualVoidMethod("removeTimeLogger.(Lcom/iab/omid/library/applovin/walking/TreeWalker$TreeWalkerTimeLogger;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x04000008 RID: 8
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/applovin/walking/TreeWalker", typeof(TreeWalker));

		// Token: 0x04000009 RID: 9
		private static Delegate cb_a;

		// Token: 0x0400000A RID: 10
		private static Delegate cb_addTimeLogger_Lcom_iab_omid_library_applovin_walking_TreeWalker_TreeWalkerTimeLogger_;

		// Token: 0x0400000B RID: 11
		private static Delegate cb_b;

		// Token: 0x0400000C RID: 12
		private static Delegate cb_c;

		// Token: 0x0400000D RID: 13
		private static Delegate cb_removeTimeLogger_Lcom_iab_omid_library_applovin_walking_TreeWalker_TreeWalkerTimeLogger_;

		// Token: 0x02000032 RID: 50
		[Register("com/iab/omid/library/applovin/walking/TreeWalker$TreeWalkerNanoTimeLogger", "", "Com.Iab.Omid.Library.Applovin.Walking.TreeWalker/ITreeWalkerNanoTimeLoggerInvoker")]
		public interface ITreeWalkerNanoTimeLogger : TreeWalker.ITreeWalkerTimeLogger, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060000D2 RID: 210
			[Register("onTreeProcessedNano", "(IJ)V", "GetOnTreeProcessedNano_IJHandler:Com.Iab.Omid.Library.Applovin.Walking.TreeWalker/ITreeWalkerNanoTimeLoggerInvoker, AppLovin")]
			void OnTreeProcessedNano(int p0, long p1);
		}

		// Token: 0x02000033 RID: 51
		[Register("com/iab/omid/library/applovin/walking/TreeWalker$TreeWalkerNanoTimeLogger", DoNotGenerateAcw = true)]
		internal class ITreeWalkerNanoTimeLoggerInvoker : Java.Lang.Object, TreeWalker.ITreeWalkerNanoTimeLogger, TreeWalker.ITreeWalkerTimeLogger, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000010 RID: 16
			// (get) Token: 0x060000D3 RID: 211 RVA: 0x000026BC File Offset: 0x000008BC
			private static IntPtr java_class_ref
			{
				get
				{
					return TreeWalker.ITreeWalkerNanoTimeLoggerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x060000D4 RID: 212 RVA: 0x000026E0 File Offset: 0x000008E0
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
			// (get) Token: 0x060000D5 RID: 213 RVA: 0x000026E7 File Offset: 0x000008E7
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
			// (get) Token: 0x060000D6 RID: 214 RVA: 0x000026EF File Offset: 0x000008EF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return TreeWalker.ITreeWalkerNanoTimeLoggerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060000D7 RID: 215 RVA: 0x000026FB File Offset: 0x000008FB
			public static TreeWalker.ITreeWalkerNanoTimeLogger GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<TreeWalker.ITreeWalkerNanoTimeLogger>(handle, transfer);
			}

			// Token: 0x060000D8 RID: 216 RVA: 0x00002704 File Offset: 0x00000904
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, TreeWalker.ITreeWalkerNanoTimeLoggerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.iab.omid.library.applovin.walking.TreeWalker.TreeWalkerNanoTimeLogger'.");
				}
				return handle;
			}

			// Token: 0x060000D9 RID: 217 RVA: 0x0000272F File Offset: 0x0000092F
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060000DA RID: 218 RVA: 0x00002760 File Offset: 0x00000960
			public ITreeWalkerNanoTimeLoggerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(TreeWalker.ITreeWalkerNanoTimeLoggerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060000DB RID: 219 RVA: 0x00002798 File Offset: 0x00000998
			private static Delegate GetOnTreeProcessedNano_IJHandler()
			{
				if (TreeWalker.ITreeWalkerNanoTimeLoggerInvoker.cb_onTreeProcessedNano_IJ == null)
				{
					TreeWalker.ITreeWalkerNanoTimeLoggerInvoker.cb_onTreeProcessedNano_IJ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIJ_V(TreeWalker.ITreeWalkerNanoTimeLoggerInvoker.n_OnTreeProcessedNano_IJ));
				}
				return TreeWalker.ITreeWalkerNanoTimeLoggerInvoker.cb_onTreeProcessedNano_IJ;
			}

			// Token: 0x060000DC RID: 220 RVA: 0x000027BC File Offset: 0x000009BC
			private static void n_OnTreeProcessedNano_IJ(IntPtr jnienv, IntPtr native__this, int p0, long p1)
			{
				Java.Lang.Object.GetObject<TreeWalker.ITreeWalkerNanoTimeLogger>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnTreeProcessedNano(p0, p1);
			}

			// Token: 0x060000DD RID: 221 RVA: 0x000027D0 File Offset: 0x000009D0
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

			// Token: 0x060000DE RID: 222 RVA: 0x00002847 File Offset: 0x00000A47
			private static Delegate GetOnTreeProcessed_IJHandler()
			{
				if (TreeWalker.ITreeWalkerNanoTimeLoggerInvoker.cb_onTreeProcessed_IJ == null)
				{
					TreeWalker.ITreeWalkerNanoTimeLoggerInvoker.cb_onTreeProcessed_IJ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIJ_V(TreeWalker.ITreeWalkerNanoTimeLoggerInvoker.n_OnTreeProcessed_IJ));
				}
				return TreeWalker.ITreeWalkerNanoTimeLoggerInvoker.cb_onTreeProcessed_IJ;
			}

			// Token: 0x060000DF RID: 223 RVA: 0x0000286B File Offset: 0x00000A6B
			private static void n_OnTreeProcessed_IJ(IntPtr jnienv, IntPtr native__this, int p0, long p1)
			{
				Java.Lang.Object.GetObject<TreeWalker.ITreeWalkerNanoTimeLogger>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnTreeProcessed(p0, p1);
			}

			// Token: 0x060000E0 RID: 224 RVA: 0x0000287C File Offset: 0x00000A7C
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

			// Token: 0x0400000E RID: 14
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/applovin/walking/TreeWalker$TreeWalkerNanoTimeLogger", typeof(TreeWalker.ITreeWalkerNanoTimeLoggerInvoker));

			// Token: 0x0400000F RID: 15
			private IntPtr class_ref;

			// Token: 0x04000010 RID: 16
			private static Delegate cb_onTreeProcessedNano_IJ;

			// Token: 0x04000011 RID: 17
			private IntPtr id_onTreeProcessedNano_IJ;

			// Token: 0x04000012 RID: 18
			private static Delegate cb_onTreeProcessed_IJ;

			// Token: 0x04000013 RID: 19
			private IntPtr id_onTreeProcessed_IJ;
		}

		// Token: 0x02000034 RID: 52
		[Register("com/iab/omid/library/applovin/walking/TreeWalker$TreeWalkerTimeLogger", "", "Com.Iab.Omid.Library.Applovin.Walking.TreeWalker/ITreeWalkerTimeLoggerInvoker")]
		public interface ITreeWalkerTimeLogger : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060000E2 RID: 226
			[Register("onTreeProcessed", "(IJ)V", "GetOnTreeProcessed_IJHandler:Com.Iab.Omid.Library.Applovin.Walking.TreeWalker/ITreeWalkerTimeLoggerInvoker, AppLovin")]
			void OnTreeProcessed(int p0, long p1);
		}

		// Token: 0x02000035 RID: 53
		[Register("com/iab/omid/library/applovin/walking/TreeWalker$TreeWalkerTimeLogger", DoNotGenerateAcw = true)]
		internal class ITreeWalkerTimeLoggerInvoker : Java.Lang.Object, TreeWalker.ITreeWalkerTimeLogger, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000014 RID: 20
			// (get) Token: 0x060000E3 RID: 227 RVA: 0x00002910 File Offset: 0x00000B10
			private static IntPtr java_class_ref
			{
				get
				{
					return TreeWalker.ITreeWalkerTimeLoggerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x060000E4 RID: 228 RVA: 0x00002934 File Offset: 0x00000B34
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
			// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000293B File Offset: 0x00000B3B
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
			// (get) Token: 0x060000E6 RID: 230 RVA: 0x00002943 File Offset: 0x00000B43
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return TreeWalker.ITreeWalkerTimeLoggerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060000E7 RID: 231 RVA: 0x0000294F File Offset: 0x00000B4F
			public static TreeWalker.ITreeWalkerTimeLogger GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<TreeWalker.ITreeWalkerTimeLogger>(handle, transfer);
			}

			// Token: 0x060000E8 RID: 232 RVA: 0x00002958 File Offset: 0x00000B58
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, TreeWalker.ITreeWalkerTimeLoggerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.iab.omid.library.applovin.walking.TreeWalker.TreeWalkerTimeLogger'.");
				}
				return handle;
			}

			// Token: 0x060000E9 RID: 233 RVA: 0x00002983 File Offset: 0x00000B83
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060000EA RID: 234 RVA: 0x000029B4 File Offset: 0x00000BB4
			public ITreeWalkerTimeLoggerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(TreeWalker.ITreeWalkerTimeLoggerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060000EB RID: 235 RVA: 0x000029EC File Offset: 0x00000BEC
			private static Delegate GetOnTreeProcessed_IJHandler()
			{
				if (TreeWalker.ITreeWalkerTimeLoggerInvoker.cb_onTreeProcessed_IJ == null)
				{
					TreeWalker.ITreeWalkerTimeLoggerInvoker.cb_onTreeProcessed_IJ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIJ_V(TreeWalker.ITreeWalkerTimeLoggerInvoker.n_OnTreeProcessed_IJ));
				}
				return TreeWalker.ITreeWalkerTimeLoggerInvoker.cb_onTreeProcessed_IJ;
			}

			// Token: 0x060000EC RID: 236 RVA: 0x00002A10 File Offset: 0x00000C10
			private static void n_OnTreeProcessed_IJ(IntPtr jnienv, IntPtr native__this, int p0, long p1)
			{
				Java.Lang.Object.GetObject<TreeWalker.ITreeWalkerTimeLogger>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnTreeProcessed(p0, p1);
			}

			// Token: 0x060000ED RID: 237 RVA: 0x00002A24 File Offset: 0x00000C24
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

			// Token: 0x04000014 RID: 20
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/applovin/walking/TreeWalker$TreeWalkerTimeLogger", typeof(TreeWalker.ITreeWalkerTimeLoggerInvoker));

			// Token: 0x04000015 RID: 21
			private IntPtr class_ref;

			// Token: 0x04000016 RID: 22
			private static Delegate cb_onTreeProcessed_IJ;

			// Token: 0x04000017 RID: 23
			private IntPtr id_onTreeProcessed_IJ;
		}
	}
}
