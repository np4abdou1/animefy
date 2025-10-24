using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;

namespace Java.Lang
{
	// Token: 0x020003F8 RID: 1016
	[Register("java/lang/Throwable", DoNotGenerateAcw = true)]
	public class Throwable : Exception, ISerializable, IJavaObject, IDisposable, IJavaPeerable, IJavaObjectEx
	{
		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06002C94 RID: 11412 RVA: 0x0007AE78 File Offset: 0x00079078
		internal static IntPtr class_ref
		{
			get
			{
				return Throwable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x06002C95 RID: 11413 RVA: 0x0007AE9C File Offset: 0x0007909C
		public unsafe Throwable(string message) : this(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (this.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				this.SetHandle(Throwable._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Throwable._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06002C96 RID: 11414 RVA: 0x0007AF40 File Offset: 0x00079140
		private static Delegate GetGetMessageHandler()
		{
			if (Throwable.cb_getMessage == null)
			{
				Throwable.cb_getMessage = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Throwable.n_GetMessage));
			}
			return Throwable.cb_getMessage;
		}

		// Token: 0x06002C97 RID: 11415 RVA: 0x0007AF64 File Offset: 0x00079164
		private static IntPtr n_GetMessage(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Object.GetObject<Throwable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Message);
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06002C98 RID: 11416 RVA: 0x0007AF78 File Offset: 0x00079178
		public new virtual string Message
		{
			get
			{
				return JNIEnv.GetString(Throwable._members.InstanceMethods.InvokeVirtualObjectMethod("getMessage.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06002C99 RID: 11417 RVA: 0x0007AFAA File Offset: 0x000791AA
		private static Delegate GetPrintStackTrace_Ljava_io_PrintWriter_Handler()
		{
			if (Throwable.cb_printStackTrace_Ljava_io_PrintWriter_ == null)
			{
				Throwable.cb_printStackTrace_Ljava_io_PrintWriter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Throwable.n_PrintStackTrace_Ljava_io_PrintWriter_));
			}
			return Throwable.cb_printStackTrace_Ljava_io_PrintWriter_;
		}

		// Token: 0x06002C9A RID: 11418 RVA: 0x0007AFD0 File Offset: 0x000791D0
		private static void n_PrintStackTrace_Ljava_io_PrintWriter_(IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			Throwable @object = Object.GetObject<Throwable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PrintWriter object2 = Object.GetObject<PrintWriter>(native_s, JniHandleOwnership.DoNotTransfer);
			@object.PrintStackTrace(object2);
		}

		// Token: 0x06002C9B RID: 11419 RVA: 0x0007AFF4 File Offset: 0x000791F4
		public unsafe virtual void PrintStackTrace(PrintWriter s)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((s == null) ? IntPtr.Zero : s.Handle);
				Throwable._members.InstanceMethods.InvokeVirtualVoidMethod("printStackTrace.(Ljava/io/PrintWriter;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(s);
			}
		}

		// Token: 0x06002C9C RID: 11420 RVA: 0x0007B058 File Offset: 0x00079258
		public Throwable(IntPtr handle, JniHandleOwnership transfer) : base(Throwable._GetMessage(handle), Throwable._GetInnerException(handle))
		{
			if (base.GetType() == typeof(Throwable))
			{
				this.is_generated = true;
			}
			if (this.handle != IntPtr.Zero)
			{
				this.needsActivation = true;
				handle = this.handle;
				if (this.handle_type != JObjectRefType.Invalid)
				{
					return;
				}
				transfer = JniHandleOwnership.DoNotTransfer;
			}
			this.SetHandle(handle, transfer);
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x0007B0CC File Offset: 0x000792CC
		private static string _GetMessage(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
			if (Throwable.Throwable_getMessage == null)
			{
				Throwable.Throwable_getMessage = Throwable._members.InstanceMethods.GetMethodInfo("getMessage.()Ljava/lang/String;");
			}
			return JNIEnv.GetString(JniEnvironment.InstanceMethods.CallObjectMethod(new JniObjectReference(handle, JniObjectReferenceType.Invalid), Throwable.Throwable_getMessage).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06002C9E RID: 11422 RVA: 0x0007B128 File Offset: 0x00079328
		private static Exception _GetInnerException(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
			if (Throwable.Throwable_getCause == null)
			{
				Throwable.Throwable_getCause = Throwable._members.InstanceMethods.GetMethodInfo("getCause.()Ljava/lang/Throwable;");
			}
			Throwable @object = Object.GetObject<Throwable>(JniEnvironment.InstanceMethods.CallObjectMethod(new JniObjectReference(handle, JniObjectReferenceType.Invalid), Throwable.Throwable_getCause).Handle, JniHandleOwnership.TransferLocalRef);
			JavaProxyThrowable javaProxyThrowable = @object as JavaProxyThrowable;
			if (javaProxyThrowable != null)
			{
				return javaProxyThrowable.InnerException;
			}
			return @object;
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06002C9F RID: 11423 RVA: 0x0007B196 File Offset: 0x00079396
		// (set) Token: 0x06002CA0 RID: 11424 RVA: 0x0007B19E File Offset: 0x0007939E
		IntPtr IJavaObjectEx.KeyHandle
		{
			get
			{
				return this.key_handle;
			}
			set
			{
				this.key_handle = value;
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06002CA1 RID: 11425 RVA: 0x0007B1A7 File Offset: 0x000793A7
		// (set) Token: 0x06002CA2 RID: 11426 RVA: 0x0007B1AF File Offset: 0x000793AF
		bool IJavaObjectEx.IsProxy
		{
			get
			{
				return this.isProxy;
			}
			set
			{
				this.isProxy = value;
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06002CA3 RID: 11427 RVA: 0x0007B1B8 File Offset: 0x000793B8
		// (set) Token: 0x06002CA4 RID: 11428 RVA: 0x0007B1C0 File Offset: 0x000793C0
		bool IJavaObjectEx.NeedsActivation
		{
			get
			{
				return this.needsActivation;
			}
			set
			{
				this.needsActivation = true;
			}
		}

		// Token: 0x06002CA5 RID: 11429 RVA: 0x0007B1CC File Offset: 0x000793CC
		IntPtr IJavaObjectEx.ToLocalJniHandle()
		{
			IntPtr result;
			lock (this)
			{
				if (this.handle == IntPtr.Zero)
				{
					result = this.handle;
				}
				else
				{
					result = JNIEnv.NewLocalRef(this.handle);
				}
			}
			return result;
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06002CA6 RID: 11430 RVA: 0x0007B22C File Offset: 0x0007942C
		public override string StackTrace
		{
			get
			{
				return base.StackTrace + this.ManagedStackTraceAddendum;
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06002CA7 RID: 11431 RVA: 0x0007B240 File Offset: 0x00079440
		private string ManagedStackTraceAddendum
		{
			get
			{
				string javaStackTrace = this.JavaStackTrace;
				if (string.IsNullOrEmpty(javaStackTrace))
				{
					return "";
				}
				return string.Concat(new string[]
				{
					Environment.NewLine,
					"  --- End of managed ",
					base.GetType().FullName,
					" stack trace ---",
					Environment.NewLine,
					javaStackTrace
				});
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06002CA8 RID: 11432 RVA: 0x0007B2A0 File Offset: 0x000794A0
		private string JavaStackTrace
		{
			get
			{
				if (!string.IsNullOrEmpty(this.nativeStack))
				{
					return this.nativeStack;
				}
				if (this.handle == IntPtr.Zero)
				{
					return null;
				}
				using (StringWriter stringWriter = new StringWriter())
				{
					using (PrintWriter printWriter = new PrintWriter(stringWriter))
					{
						this.PrintStackTrace(printWriter);
						this.nativeStack = stringWriter.ToString();
					}
				}
				return this.nativeStack;
			}
		}

		// Token: 0x06002CA9 RID: 11433 RVA: 0x0007B330 File Offset: 0x00079530
		public override string ToString()
		{
			return base.ToString() + this.ManagedStackTraceAddendum;
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06002CAA RID: 11434 RVA: 0x0007B343 File Offset: 0x00079543
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int JniIdentityHashCode
		{
			get
			{
				return (int)this.key_handle;
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06002CAB RID: 11435 RVA: 0x0007B350 File Offset: 0x00079550
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public JniObjectReference PeerReference
		{
			get
			{
				return new JniObjectReference(this.handle, (JniObjectReferenceType)this.handle_type);
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06002CAC RID: 11436 RVA: 0x0007B363 File Offset: 0x00079563
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual JniPeerMembers JniPeerMembers
		{
			get
			{
				return Throwable._members;
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06002CAD RID: 11437 RVA: 0x0007B36A File Offset: 0x0007956A
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IntPtr Handle
		{
			get
			{
				return this.handle;
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06002CAE RID: 11438 RVA: 0x0007B372 File Offset: 0x00079572
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected virtual IntPtr ThresholdClass
		{
			get
			{
				return Throwable.class_ref;
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06002CAF RID: 11439 RVA: 0x0007B379 File Offset: 0x00079579
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected virtual Type ThresholdType
		{
			get
			{
				return typeof(Throwable);
			}
		}

		// Token: 0x06002CB0 RID: 11440 RVA: 0x0007B385 File Offset: 0x00079585
		internal IntPtr GetThresholdClass()
		{
			return this.ThresholdClass;
		}

		// Token: 0x06002CB1 RID: 11441 RVA: 0x0007B38D File Offset: 0x0007958D
		internal Type GetThresholdType()
		{
			return this.ThresholdType;
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x0007B395 File Offset: 0x00079595
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected void SetHandle(IntPtr value, JniHandleOwnership transfer)
		{
			AndroidValueManager androidValueManager = JNIEnvInit.AndroidValueManager;
			if (androidValueManager != null)
			{
				androidValueManager.AddPeer(this, value, transfer, out this.handle);
			}
			this.handle_type = JObjectRefType.Global;
		}

		// Token: 0x06002CB3 RID: 11443 RVA: 0x0007B3B7 File Offset: 0x000795B7
		public static Throwable FromException(Exception e)
		{
			if (e == null)
			{
				throw new ArgumentNullException("e");
			}
			if (e is Throwable)
			{
				return (Throwable)e;
			}
			return new JavaProxyThrowable(e);
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x0007B3DC File Offset: 0x000795DC
		~Throwable()
		{
			this.refs_added = 0;
			if (!Environment.HasShutdownStarted)
			{
				JniEnvironment.Runtime.ValueManager.FinalizePeer(this);
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06002CB5 RID: 11445 RVA: 0x0007B424 File Offset: 0x00079624
		JniManagedPeerStates IJavaPeerable.JniManagedPeerState
		{
			get
			{
				JniManagedPeerStates jniManagedPeerStates = JniManagedPeerStates.None;
				if (((IJavaObjectEx)this).IsProxy)
				{
					jniManagedPeerStates |= JniManagedPeerStates.Replaceable;
				}
				if (((IJavaObjectEx)this).NeedsActivation)
				{
					jniManagedPeerStates |= JniManagedPeerStates.Activatable;
				}
				return jniManagedPeerStates;
			}
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x0007B44C File Offset: 0x0007964C
		void IJavaPeerable.DisposeUnlessReferenced()
		{
			if (Object.PeekObject(this.handle, null) == null)
			{
				this.Dispose();
			}
		}

		// Token: 0x06002CB7 RID: 11447 RVA: 0x0007B462 File Offset: 0x00079662
		void IJavaPeerable.Disposed()
		{
			this.Dispose(true);
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x0007B46B File Offset: 0x0007966B
		void IJavaPeerable.Finalized()
		{
			this.Dispose(false);
		}

		// Token: 0x06002CB9 RID: 11449 RVA: 0x0007B474 File Offset: 0x00079674
		void IJavaPeerable.SetJniIdentityHashCode(int value)
		{
			this.key_handle = (IntPtr)value;
		}

		// Token: 0x06002CBA RID: 11450 RVA: 0x0007B484 File Offset: 0x00079684
		void IJavaPeerable.SetJniManagedPeerState(JniManagedPeerStates value)
		{
			if ((value & JniManagedPeerStates.Replaceable) == JniManagedPeerStates.Replaceable)
			{
				((IJavaObjectEx)this).IsProxy = true;
			}
			if ((value & JniManagedPeerStates.Activatable) == JniManagedPeerStates.Activatable)
			{
				((IJavaObjectEx)this).NeedsActivation = true;
			}
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x0007B4AD File Offset: 0x000796AD
		void IJavaPeerable.SetPeerReference(JniObjectReference reference)
		{
			this.handle = reference.Handle;
			this.handle_type = (JObjectRefType)reference.Type;
		}

		// Token: 0x06002CBC RID: 11452 RVA: 0x00079EB5 File Offset: 0x000780B5
		public void Dispose()
		{
			AndroidValueManager androidValueManager = JNIEnvInit.AndroidValueManager;
			if (androidValueManager == null)
			{
				return;
			}
			androidValueManager.DisposePeer(this);
		}

		// Token: 0x06002CBD RID: 11453 RVA: 0x00025BC2 File Offset: 0x00023DC2
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x040011A3 RID: 4515
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Throwable", typeof(Throwable));

		// Token: 0x040011A4 RID: 4516
		private static Delegate cb_getMessage;

		// Token: 0x040011A5 RID: 4517
		private static Delegate cb_printStackTrace_Ljava_io_PrintWriter_;

		// Token: 0x040011A6 RID: 4518
		protected bool is_generated;

		// Token: 0x040011A7 RID: 4519
		internal IntPtr handle;

		// Token: 0x040011A8 RID: 4520
		private IntPtr key_handle;

		// Token: 0x040011A9 RID: 4521
		private JObjectRefType handle_type;

		// Token: 0x040011AA RID: 4522
		private IntPtr weak_handle;

		// Token: 0x040011AB RID: 4523
		private int refs_added;

		// Token: 0x040011AC RID: 4524
		private bool isProxy;

		// Token: 0x040011AD RID: 4525
		private bool needsActivation;

		// Token: 0x040011AE RID: 4526
		private string nativeStack;

		// Token: 0x040011AF RID: 4527
		private static JniMethodInfo Throwable_getMessage;

		// Token: 0x040011B0 RID: 4528
		private static JniMethodInfo Throwable_getCause;
	}
}
