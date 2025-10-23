using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace AndroidX.Loader.Content
{
	// Token: 0x02000012 RID: 18
	[Register("androidx/loader/content/Loader", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"D"
	})]
	public class Loader : Java.Lang.Object
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002080 File Offset: 0x00000280
		internal static IntPtr class_ref
		{
			get
			{
				return Loader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000020A4 File Offset: 0x000002A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Loader._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000020AC File Offset: 0x000002AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Loader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600003B RID: 59 RVA: 0x000020D0 File Offset: 0x000002D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Loader._members.ManagedPeerType;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000020DC File Offset: 0x000002DC
		protected Loader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000020E8 File Offset: 0x000002E8
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe Loader(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(Loader._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Loader._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002198 File Offset: 0x00000398
		private static Delegate GetGetContextHandler()
		{
			if (Loader.cb_getContext == null)
			{
				Loader.cb_getContext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Loader.n_GetContext));
			}
			return Loader.cb_getContext;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000021BC File Offset: 0x000003BC
		private static IntPtr n_GetContext(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Context);
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000021D0 File Offset: 0x000003D0
		public virtual Context Context
		{
			[Register("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Context>(Loader._members.InstanceMethods.InvokeVirtualObjectMethod("getContext.()Landroid/content/Context;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002202 File Offset: 0x00000402
		private static Delegate GetGetIdHandler()
		{
			if (Loader.cb_getId == null)
			{
				Loader.cb_getId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Loader.n_GetId));
			}
			return Loader.cb_getId;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002226 File Offset: 0x00000426
		private static int n_GetId(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Id;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002235 File Offset: 0x00000435
		public virtual int Id
		{
			[Register("getId", "()I", "GetGetIdHandler")]
			get
			{
				return Loader._members.InstanceMethods.InvokeVirtualInt32Method("getId.()I", this, null);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000224E File Offset: 0x0000044E
		private static Delegate GetIsAbandonedHandler()
		{
			if (Loader.cb_isAbandoned == null)
			{
				Loader.cb_isAbandoned = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Loader.n_IsAbandoned));
			}
			return Loader.cb_isAbandoned;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002272 File Offset: 0x00000472
		private static bool n_IsAbandoned(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAbandoned;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00002281 File Offset: 0x00000481
		public virtual bool IsAbandoned
		{
			[Register("isAbandoned", "()Z", "GetIsAbandonedHandler")]
			get
			{
				return Loader._members.InstanceMethods.InvokeVirtualBooleanMethod("isAbandoned.()Z", this, null);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000229A File Offset: 0x0000049A
		private static Delegate GetIsResetHandler()
		{
			if (Loader.cb_isReset == null)
			{
				Loader.cb_isReset = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Loader.n_IsReset));
			}
			return Loader.cb_isReset;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000022BE File Offset: 0x000004BE
		private static bool n_IsReset(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsReset;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000022CD File Offset: 0x000004CD
		public virtual bool IsReset
		{
			[Register("isReset", "()Z", "GetIsResetHandler")]
			get
			{
				return Loader._members.InstanceMethods.InvokeVirtualBooleanMethod("isReset.()Z", this, null);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000022E6 File Offset: 0x000004E6
		private static Delegate GetIsStartedHandler()
		{
			if (Loader.cb_isStarted == null)
			{
				Loader.cb_isStarted = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Loader.n_IsStarted));
			}
			return Loader.cb_isStarted;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000230A File Offset: 0x0000050A
		private static bool n_IsStarted(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsStarted;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002319 File Offset: 0x00000519
		public virtual bool IsStarted
		{
			[Register("isStarted", "()Z", "GetIsStartedHandler")]
			get
			{
				return Loader._members.InstanceMethods.InvokeVirtualBooleanMethod("isStarted.()Z", this, null);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002332 File Offset: 0x00000532
		private static Delegate GetAbandonHandler()
		{
			if (Loader.cb_abandon == null)
			{
				Loader.cb_abandon = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Loader.n_Abandon));
			}
			return Loader.cb_abandon;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002356 File Offset: 0x00000556
		private static void n_Abandon(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Abandon();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002365 File Offset: 0x00000565
		[Register("abandon", "()V", "GetAbandonHandler")]
		public virtual void Abandon()
		{
			Loader._members.InstanceMethods.InvokeVirtualVoidMethod("abandon.()V", this, null);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000237E File Offset: 0x0000057E
		private static Delegate GetCancelLoadHandler()
		{
			if (Loader.cb_cancelLoad == null)
			{
				Loader.cb_cancelLoad = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Loader.n_CancelLoad));
			}
			return Loader.cb_cancelLoad;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000023A2 File Offset: 0x000005A2
		private static bool n_CancelLoad(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CancelLoad();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000023B1 File Offset: 0x000005B1
		[Register("cancelLoad", "()Z", "GetCancelLoadHandler")]
		public virtual bool CancelLoad()
		{
			return Loader._members.InstanceMethods.InvokeVirtualBooleanMethod("cancelLoad.()Z", this, null);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000023CA File Offset: 0x000005CA
		private static Delegate GetCommitContentChangedHandler()
		{
			if (Loader.cb_commitContentChanged == null)
			{
				Loader.cb_commitContentChanged = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Loader.n_CommitContentChanged));
			}
			return Loader.cb_commitContentChanged;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000023EE File Offset: 0x000005EE
		private static void n_CommitContentChanged(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CommitContentChanged();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000023FD File Offset: 0x000005FD
		[Register("commitContentChanged", "()V", "GetCommitContentChangedHandler")]
		public virtual void CommitContentChanged()
		{
			Loader._members.InstanceMethods.InvokeVirtualVoidMethod("commitContentChanged.()V", this, null);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002416 File Offset: 0x00000616
		private static Delegate GetDataToString_Ljava_lang_Object_Handler()
		{
			if (Loader.cb_dataToString_Ljava_lang_Object_ == null)
			{
				Loader.cb_dataToString_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Loader.n_DataToString_Ljava_lang_Object_));
			}
			return Loader.cb_dataToString_Ljava_lang_Object_;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000243C File Offset: 0x0000063C
		private static IntPtr n_DataToString_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			Loader @object = Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_data, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.DataToString(object2));
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002464 File Offset: 0x00000664
		[Register("dataToString", "(Ljava/lang/Object;)Ljava/lang/String;", "GetDataToString_Ljava_lang_Object_Handler")]
		public unsafe virtual string DataToString(Java.Lang.Object data)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(data);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@string = JNIEnv.GetString(Loader._members.InstanceMethods.InvokeVirtualObjectMethod("dataToString.(Ljava/lang/Object;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(data);
			}
			return @string;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000024D8 File Offset: 0x000006D8
		private static Delegate GetDeliverCancellationHandler()
		{
			if (Loader.cb_deliverCancellation == null)
			{
				Loader.cb_deliverCancellation = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Loader.n_DeliverCancellation));
			}
			return Loader.cb_deliverCancellation;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000024FC File Offset: 0x000006FC
		private static void n_DeliverCancellation(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DeliverCancellation();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000250B File Offset: 0x0000070B
		[Register("deliverCancellation", "()V", "GetDeliverCancellationHandler")]
		public virtual void DeliverCancellation()
		{
			Loader._members.InstanceMethods.InvokeVirtualVoidMethod("deliverCancellation.()V", this, null);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002524 File Offset: 0x00000724
		private static Delegate GetDeliverResult_Ljava_lang_Object_Handler()
		{
			if (Loader.cb_deliverResult_Ljava_lang_Object_ == null)
			{
				Loader.cb_deliverResult_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Loader.n_DeliverResult_Ljava_lang_Object_));
			}
			return Loader.cb_deliverResult_Ljava_lang_Object_;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002548 File Offset: 0x00000748
		private static void n_DeliverResult_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			Loader @object = Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_data, JniHandleOwnership.DoNotTransfer);
			@object.DeliverResult(object2);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000256C File Offset: 0x0000076C
		[Register("deliverResult", "(Ljava/lang/Object;)V", "GetDeliverResult_Ljava_lang_Object_Handler")]
		public unsafe virtual void DeliverResult(Java.Lang.Object data)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(data);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				Loader._members.InstanceMethods.InvokeVirtualVoidMethod("deliverResult.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(data);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000025D0 File Offset: 0x000007D0
		private static Delegate GetDump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_Handler()
		{
			if (Loader.cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_ == null)
			{
				Loader.cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_V(Loader.n_Dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_));
			}
			return Loader.cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000025F4 File Offset: 0x000007F4
		private static void n_Dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_prefix, IntPtr native_fd, IntPtr native_writer, IntPtr native_args)
		{
			Loader @object = Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_prefix, JniHandleOwnership.DoNotTransfer);
			FileDescriptor object2 = Java.Lang.Object.GetObject<FileDescriptor>(native_fd, JniHandleOwnership.DoNotTransfer);
			PrintWriter object3 = Java.Lang.Object.GetObject<PrintWriter>(native_writer, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_args, JniHandleOwnership.DoNotTransfer, typeof(string));
			@object.Dump(@string, object2, object3, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_args);
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002650 File Offset: 0x00000850
		[Register("dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", "GetDump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_Handler")]
		public unsafe virtual void Dump(string prefix, FileDescriptor fd, PrintWriter writer, string[] args)
		{
			IntPtr intPtr = JNIEnv.NewString(prefix);
			IntPtr intPtr2 = JNIEnv.NewArray(args);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((fd == null) ? IntPtr.Zero : fd.Handle);
				ptr[2] = new JniArgumentValue((writer == null) ? IntPtr.Zero : writer.Handle);
				ptr[3] = new JniArgumentValue(intPtr2);
				Loader._members.InstanceMethods.InvokeVirtualVoidMethod("dump.(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (args != null)
				{
					JNIEnv.CopyArray(intPtr2, args);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(fd);
				GC.KeepAlive(writer);
				GC.KeepAlive(args);
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002738 File Offset: 0x00000938
		private static Delegate GetForceLoadHandler()
		{
			if (Loader.cb_forceLoad == null)
			{
				Loader.cb_forceLoad = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Loader.n_ForceLoad));
			}
			return Loader.cb_forceLoad;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000275C File Offset: 0x0000095C
		private static void n_ForceLoad(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ForceLoad();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000276B File Offset: 0x0000096B
		[Register("forceLoad", "()V", "GetForceLoadHandler")]
		public virtual void ForceLoad()
		{
			Loader._members.InstanceMethods.InvokeVirtualVoidMethod("forceLoad.()V", this, null);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002784 File Offset: 0x00000984
		private static Delegate GetOnAbandonHandler()
		{
			if (Loader.cb_onAbandon == null)
			{
				Loader.cb_onAbandon = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Loader.n_OnAbandon));
			}
			return Loader.cb_onAbandon;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000027A8 File Offset: 0x000009A8
		private static void n_OnAbandon(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAbandon();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000027B7 File Offset: 0x000009B7
		[Register("onAbandon", "()V", "GetOnAbandonHandler")]
		protected virtual void OnAbandon()
		{
			Loader._members.InstanceMethods.InvokeVirtualVoidMethod("onAbandon.()V", this, null);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000027D0 File Offset: 0x000009D0
		private static Delegate GetOnCancelLoadHandler()
		{
			if (Loader.cb_onCancelLoad == null)
			{
				Loader.cb_onCancelLoad = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Loader.n_OnCancelLoad));
			}
			return Loader.cb_onCancelLoad;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000027F4 File Offset: 0x000009F4
		private static bool n_OnCancelLoad(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnCancelLoad();
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002803 File Offset: 0x00000A03
		[Register("onCancelLoad", "()Z", "GetOnCancelLoadHandler")]
		protected virtual bool OnCancelLoad()
		{
			return Loader._members.InstanceMethods.InvokeVirtualBooleanMethod("onCancelLoad.()Z", this, null);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000281C File Offset: 0x00000A1C
		private static Delegate GetOnContentChangedHandler()
		{
			if (Loader.cb_onContentChanged == null)
			{
				Loader.cb_onContentChanged = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Loader.n_OnContentChanged));
			}
			return Loader.cb_onContentChanged;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002840 File Offset: 0x00000A40
		private static void n_OnContentChanged(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnContentChanged();
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000284F File Offset: 0x00000A4F
		[Register("onContentChanged", "()V", "GetOnContentChangedHandler")]
		public virtual void OnContentChanged()
		{
			Loader._members.InstanceMethods.InvokeVirtualVoidMethod("onContentChanged.()V", this, null);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002868 File Offset: 0x00000A68
		private static Delegate GetOnForceLoadHandler()
		{
			if (Loader.cb_onForceLoad == null)
			{
				Loader.cb_onForceLoad = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Loader.n_OnForceLoad));
			}
			return Loader.cb_onForceLoad;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000288C File Offset: 0x00000A8C
		private static void n_OnForceLoad(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnForceLoad();
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000289B File Offset: 0x00000A9B
		[Register("onForceLoad", "()V", "GetOnForceLoadHandler")]
		protected virtual void OnForceLoad()
		{
			Loader._members.InstanceMethods.InvokeVirtualVoidMethod("onForceLoad.()V", this, null);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000028B4 File Offset: 0x00000AB4
		private static Delegate GetOnResetHandler()
		{
			if (Loader.cb_onReset == null)
			{
				Loader.cb_onReset = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Loader.n_OnReset));
			}
			return Loader.cb_onReset;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000028D8 File Offset: 0x00000AD8
		private static void n_OnReset(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnReset();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000028E7 File Offset: 0x00000AE7
		[Register("onReset", "()V", "GetOnResetHandler")]
		protected virtual void OnReset()
		{
			Loader._members.InstanceMethods.InvokeVirtualVoidMethod("onReset.()V", this, null);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002900 File Offset: 0x00000B00
		private static Delegate GetOnStartLoadingHandler()
		{
			if (Loader.cb_onStartLoading == null)
			{
				Loader.cb_onStartLoading = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Loader.n_OnStartLoading));
			}
			return Loader.cb_onStartLoading;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002924 File Offset: 0x00000B24
		private static void n_OnStartLoading(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStartLoading();
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002933 File Offset: 0x00000B33
		[Register("onStartLoading", "()V", "GetOnStartLoadingHandler")]
		protected virtual void OnStartLoading()
		{
			Loader._members.InstanceMethods.InvokeVirtualVoidMethod("onStartLoading.()V", this, null);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000294C File Offset: 0x00000B4C
		private static Delegate GetOnStopLoadingHandler()
		{
			if (Loader.cb_onStopLoading == null)
			{
				Loader.cb_onStopLoading = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Loader.n_OnStopLoading));
			}
			return Loader.cb_onStopLoading;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002970 File Offset: 0x00000B70
		private static void n_OnStopLoading(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStopLoading();
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000297F File Offset: 0x00000B7F
		[Register("onStopLoading", "()V", "GetOnStopLoadingHandler")]
		protected virtual void OnStopLoading()
		{
			Loader._members.InstanceMethods.InvokeVirtualVoidMethod("onStopLoading.()V", this, null);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002998 File Offset: 0x00000B98
		private static Delegate GetRegisterListener_ILandroidx_loader_content_Loader_OnLoadCompleteListener_Handler()
		{
			if (Loader.cb_registerListener_ILandroidx_loader_content_Loader_OnLoadCompleteListener_ == null)
			{
				Loader.cb_registerListener_ILandroidx_loader_content_Loader_OnLoadCompleteListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(Loader.n_RegisterListener_ILandroidx_loader_content_Loader_OnLoadCompleteListener_));
			}
			return Loader.cb_registerListener_ILandroidx_loader_content_Loader_OnLoadCompleteListener_;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000029BC File Offset: 0x00000BBC
		private static void n_RegisterListener_ILandroidx_loader_content_Loader_OnLoadCompleteListener_(IntPtr jnienv, IntPtr native__this, int id, IntPtr native_listener)
		{
			Loader @object = Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Loader.IOnLoadCompleteListener object2 = Java.Lang.Object.GetObject<Loader.IOnLoadCompleteListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RegisterListener(id, object2);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000029E0 File Offset: 0x00000BE0
		[Register("registerListener", "(ILandroidx/loader/content/Loader$OnLoadCompleteListener;)V", "GetRegisterListener_ILandroidx_loader_content_Loader_OnLoadCompleteListener_Handler")]
		public unsafe virtual void RegisterListener(int id, Loader.IOnLoadCompleteListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(id);
				ptr[1] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				Loader._members.InstanceMethods.InvokeVirtualVoidMethod("registerListener.(ILandroidx/loader/content/Loader$OnLoadCompleteListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002A5C File Offset: 0x00000C5C
		private static Delegate GetRegisterOnLoadCanceledListener_Landroidx_loader_content_Loader_OnLoadCanceledListener_Handler()
		{
			if (Loader.cb_registerOnLoadCanceledListener_Landroidx_loader_content_Loader_OnLoadCanceledListener_ == null)
			{
				Loader.cb_registerOnLoadCanceledListener_Landroidx_loader_content_Loader_OnLoadCanceledListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Loader.n_RegisterOnLoadCanceledListener_Landroidx_loader_content_Loader_OnLoadCanceledListener_));
			}
			return Loader.cb_registerOnLoadCanceledListener_Landroidx_loader_content_Loader_OnLoadCanceledListener_;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002A80 File Offset: 0x00000C80
		private static void n_RegisterOnLoadCanceledListener_Landroidx_loader_content_Loader_OnLoadCanceledListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			Loader @object = Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Loader.IOnLoadCanceledListener object2 = Java.Lang.Object.GetObject<Loader.IOnLoadCanceledListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RegisterOnLoadCanceledListener(object2);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002AA4 File Offset: 0x00000CA4
		[Register("registerOnLoadCanceledListener", "(Landroidx/loader/content/Loader$OnLoadCanceledListener;)V", "GetRegisterOnLoadCanceledListener_Landroidx_loader_content_Loader_OnLoadCanceledListener_Handler")]
		public unsafe virtual void RegisterOnLoadCanceledListener(Loader.IOnLoadCanceledListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				Loader._members.InstanceMethods.InvokeVirtualVoidMethod("registerOnLoadCanceledListener.(Landroidx/loader/content/Loader$OnLoadCanceledListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002B0C File Offset: 0x00000D0C
		private static Delegate GetResetHandler()
		{
			if (Loader.cb_reset == null)
			{
				Loader.cb_reset = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Loader.n_Reset));
			}
			return Loader.cb_reset;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002B30 File Offset: 0x00000D30
		private static void n_Reset(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Reset();
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002B3F File Offset: 0x00000D3F
		[Register("reset", "()V", "GetResetHandler")]
		public virtual void Reset()
		{
			Loader._members.InstanceMethods.InvokeVirtualVoidMethod("reset.()V", this, null);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002B58 File Offset: 0x00000D58
		private static Delegate GetRollbackContentChangedHandler()
		{
			if (Loader.cb_rollbackContentChanged == null)
			{
				Loader.cb_rollbackContentChanged = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Loader.n_RollbackContentChanged));
			}
			return Loader.cb_rollbackContentChanged;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002B7C File Offset: 0x00000D7C
		private static void n_RollbackContentChanged(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RollbackContentChanged();
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002B8B File Offset: 0x00000D8B
		[Register("rollbackContentChanged", "()V", "GetRollbackContentChangedHandler")]
		public virtual void RollbackContentChanged()
		{
			Loader._members.InstanceMethods.InvokeVirtualVoidMethod("rollbackContentChanged.()V", this, null);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002BA4 File Offset: 0x00000DA4
		[Register("startLoading", "()V", "")]
		public void StartLoading()
		{
			Loader._members.InstanceMethods.InvokeNonvirtualVoidMethod("startLoading.()V", this, null);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002BBD File Offset: 0x00000DBD
		private static Delegate GetStopLoadingHandler()
		{
			if (Loader.cb_stopLoading == null)
			{
				Loader.cb_stopLoading = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Loader.n_StopLoading));
			}
			return Loader.cb_stopLoading;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002BE1 File Offset: 0x00000DE1
		private static void n_StopLoading(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StopLoading();
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002BF0 File Offset: 0x00000DF0
		[Register("stopLoading", "()V", "GetStopLoadingHandler")]
		public virtual void StopLoading()
		{
			Loader._members.InstanceMethods.InvokeVirtualVoidMethod("stopLoading.()V", this, null);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002C09 File Offset: 0x00000E09
		private static Delegate GetTakeContentChangedHandler()
		{
			if (Loader.cb_takeContentChanged == null)
			{
				Loader.cb_takeContentChanged = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Loader.n_TakeContentChanged));
			}
			return Loader.cb_takeContentChanged;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002C2D File Offset: 0x00000E2D
		private static bool n_TakeContentChanged(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TakeContentChanged();
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002C3C File Offset: 0x00000E3C
		[Register("takeContentChanged", "()Z", "GetTakeContentChangedHandler")]
		public virtual bool TakeContentChanged()
		{
			return Loader._members.InstanceMethods.InvokeVirtualBooleanMethod("takeContentChanged.()Z", this, null);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002C55 File Offset: 0x00000E55
		private static Delegate GetUnregisterListener_Landroidx_loader_content_Loader_OnLoadCompleteListener_Handler()
		{
			if (Loader.cb_unregisterListener_Landroidx_loader_content_Loader_OnLoadCompleteListener_ == null)
			{
				Loader.cb_unregisterListener_Landroidx_loader_content_Loader_OnLoadCompleteListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Loader.n_UnregisterListener_Landroidx_loader_content_Loader_OnLoadCompleteListener_));
			}
			return Loader.cb_unregisterListener_Landroidx_loader_content_Loader_OnLoadCompleteListener_;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002C7C File Offset: 0x00000E7C
		private static void n_UnregisterListener_Landroidx_loader_content_Loader_OnLoadCompleteListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			Loader @object = Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Loader.IOnLoadCompleteListener object2 = Java.Lang.Object.GetObject<Loader.IOnLoadCompleteListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.UnregisterListener(object2);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[Register("unregisterListener", "(Landroidx/loader/content/Loader$OnLoadCompleteListener;)V", "GetUnregisterListener_Landroidx_loader_content_Loader_OnLoadCompleteListener_Handler")]
		public unsafe virtual void UnregisterListener(Loader.IOnLoadCompleteListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				Loader._members.InstanceMethods.InvokeVirtualVoidMethod("unregisterListener.(Landroidx/loader/content/Loader$OnLoadCompleteListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002D08 File Offset: 0x00000F08
		private static Delegate GetUnregisterOnLoadCanceledListener_Landroidx_loader_content_Loader_OnLoadCanceledListener_Handler()
		{
			if (Loader.cb_unregisterOnLoadCanceledListener_Landroidx_loader_content_Loader_OnLoadCanceledListener_ == null)
			{
				Loader.cb_unregisterOnLoadCanceledListener_Landroidx_loader_content_Loader_OnLoadCanceledListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Loader.n_UnregisterOnLoadCanceledListener_Landroidx_loader_content_Loader_OnLoadCanceledListener_));
			}
			return Loader.cb_unregisterOnLoadCanceledListener_Landroidx_loader_content_Loader_OnLoadCanceledListener_;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002D2C File Offset: 0x00000F2C
		private static void n_UnregisterOnLoadCanceledListener_Landroidx_loader_content_Loader_OnLoadCanceledListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			Loader @object = Java.Lang.Object.GetObject<Loader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Loader.IOnLoadCanceledListener object2 = Java.Lang.Object.GetObject<Loader.IOnLoadCanceledListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.UnregisterOnLoadCanceledListener(object2);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002D50 File Offset: 0x00000F50
		[Register("unregisterOnLoadCanceledListener", "(Landroidx/loader/content/Loader$OnLoadCanceledListener;)V", "GetUnregisterOnLoadCanceledListener_Landroidx_loader_content_Loader_OnLoadCanceledListener_Handler")]
		public unsafe virtual void UnregisterOnLoadCanceledListener(Loader.IOnLoadCanceledListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				Loader._members.InstanceMethods.InvokeVirtualVoidMethod("unregisterOnLoadCanceledListener.(Landroidx/loader/content/Loader$OnLoadCanceledListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x04000003 RID: 3
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/loader/content/Loader", typeof(Loader));

		// Token: 0x04000004 RID: 4
		private static Delegate cb_getContext;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_getId;

		// Token: 0x04000006 RID: 6
		private static Delegate cb_isAbandoned;

		// Token: 0x04000007 RID: 7
		private static Delegate cb_isReset;

		// Token: 0x04000008 RID: 8
		private static Delegate cb_isStarted;

		// Token: 0x04000009 RID: 9
		private static Delegate cb_abandon;

		// Token: 0x0400000A RID: 10
		private static Delegate cb_cancelLoad;

		// Token: 0x0400000B RID: 11
		private static Delegate cb_commitContentChanged;

		// Token: 0x0400000C RID: 12
		private static Delegate cb_dataToString_Ljava_lang_Object_;

		// Token: 0x0400000D RID: 13
		private static Delegate cb_deliverCancellation;

		// Token: 0x0400000E RID: 14
		private static Delegate cb_deliverResult_Ljava_lang_Object_;

		// Token: 0x0400000F RID: 15
		private static Delegate cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_;

		// Token: 0x04000010 RID: 16
		private static Delegate cb_forceLoad;

		// Token: 0x04000011 RID: 17
		private static Delegate cb_onAbandon;

		// Token: 0x04000012 RID: 18
		private static Delegate cb_onCancelLoad;

		// Token: 0x04000013 RID: 19
		private static Delegate cb_onContentChanged;

		// Token: 0x04000014 RID: 20
		private static Delegate cb_onForceLoad;

		// Token: 0x04000015 RID: 21
		private static Delegate cb_onReset;

		// Token: 0x04000016 RID: 22
		private static Delegate cb_onStartLoading;

		// Token: 0x04000017 RID: 23
		private static Delegate cb_onStopLoading;

		// Token: 0x04000018 RID: 24
		private static Delegate cb_registerListener_ILandroidx_loader_content_Loader_OnLoadCompleteListener_;

		// Token: 0x04000019 RID: 25
		private static Delegate cb_registerOnLoadCanceledListener_Landroidx_loader_content_Loader_OnLoadCanceledListener_;

		// Token: 0x0400001A RID: 26
		private static Delegate cb_reset;

		// Token: 0x0400001B RID: 27
		private static Delegate cb_rollbackContentChanged;

		// Token: 0x0400001C RID: 28
		private static Delegate cb_stopLoading;

		// Token: 0x0400001D RID: 29
		private static Delegate cb_takeContentChanged;

		// Token: 0x0400001E RID: 30
		private static Delegate cb_unregisterListener_Landroidx_loader_content_Loader_OnLoadCompleteListener_;

		// Token: 0x0400001F RID: 31
		private static Delegate cb_unregisterOnLoadCanceledListener_Landroidx_loader_content_Loader_OnLoadCanceledListener_;

		// Token: 0x02000013 RID: 19
		[Register("androidx/loader/content/Loader$OnLoadCanceledListener", "", "AndroidX.Loader.Content.Loader/IOnLoadCanceledListenerInvoker")]
		[JavaTypeParameters(new string[]
		{
			"D"
		})]
		public interface IOnLoadCanceledListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000094 RID: 148
			[Register("onLoadCanceled", "(Landroidx/loader/content/Loader;)V", "GetOnLoadCanceled_Landroidx_loader_content_Loader_Handler:AndroidX.Loader.Content.Loader/IOnLoadCanceledListenerInvoker, Xamarin.AndroidX.Loader")]
			void OnLoadCanceled(Loader loader);
		}

		// Token: 0x02000014 RID: 20
		[Register("androidx/loader/content/Loader$OnLoadCanceledListener", DoNotGenerateAcw = true)]
		internal class IOnLoadCanceledListenerInvoker : Java.Lang.Object, Loader.IOnLoadCanceledListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000095 RID: 149 RVA: 0x00002DD4 File Offset: 0x00000FD4
			private static IntPtr java_class_ref
			{
				get
				{
					return Loader.IOnLoadCanceledListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000096 RID: 150 RVA: 0x00002DF8 File Offset: 0x00000FF8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Loader.IOnLoadCanceledListenerInvoker._members;
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000097 RID: 151 RVA: 0x00002DFF File Offset: 0x00000FFF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000098 RID: 152 RVA: 0x00002E07 File Offset: 0x00001007
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Loader.IOnLoadCanceledListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000099 RID: 153 RVA: 0x00002E13 File Offset: 0x00001013
			public static Loader.IOnLoadCanceledListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<Loader.IOnLoadCanceledListener>(handle, transfer);
			}

			// Token: 0x0600009A RID: 154 RVA: 0x00002E1C File Offset: 0x0000101C
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, Loader.IOnLoadCanceledListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.loader.content.Loader.OnLoadCanceledListener'.");
				}
				return handle;
			}

			// Token: 0x0600009B RID: 155 RVA: 0x00002E47 File Offset: 0x00001047
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600009C RID: 156 RVA: 0x00002E78 File Offset: 0x00001078
			public IOnLoadCanceledListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Loader.IOnLoadCanceledListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600009D RID: 157 RVA: 0x00002EB0 File Offset: 0x000010B0
			private static Delegate GetOnLoadCanceled_Landroidx_loader_content_Loader_Handler()
			{
				if (Loader.IOnLoadCanceledListenerInvoker.cb_onLoadCanceled_Landroidx_loader_content_Loader_ == null)
				{
					Loader.IOnLoadCanceledListenerInvoker.cb_onLoadCanceled_Landroidx_loader_content_Loader_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Loader.IOnLoadCanceledListenerInvoker.n_OnLoadCanceled_Landroidx_loader_content_Loader_));
				}
				return Loader.IOnLoadCanceledListenerInvoker.cb_onLoadCanceled_Landroidx_loader_content_Loader_;
			}

			// Token: 0x0600009E RID: 158 RVA: 0x00002ED4 File Offset: 0x000010D4
			private static void n_OnLoadCanceled_Landroidx_loader_content_Loader_(IntPtr jnienv, IntPtr native__this, IntPtr native_loader)
			{
				Loader.IOnLoadCanceledListener @object = Java.Lang.Object.GetObject<Loader.IOnLoadCanceledListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Loader object2 = Java.Lang.Object.GetObject<Loader>(native_loader, JniHandleOwnership.DoNotTransfer);
				@object.OnLoadCanceled(object2);
			}

			// Token: 0x0600009F RID: 159 RVA: 0x00002EF8 File Offset: 0x000010F8
			public unsafe void OnLoadCanceled(Loader loader)
			{
				if (this.id_onLoadCanceled_Landroidx_loader_content_Loader_ == IntPtr.Zero)
				{
					this.id_onLoadCanceled_Landroidx_loader_content_Loader_ = JNIEnv.GetMethodID(this.class_ref, "onLoadCanceled", "(Landroidx/loader/content/Loader;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((loader == null) ? IntPtr.Zero : loader.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onLoadCanceled_Landroidx_loader_content_Loader_, ptr);
			}

			// Token: 0x04000020 RID: 32
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/loader/content/Loader$OnLoadCanceledListener", typeof(Loader.IOnLoadCanceledListenerInvoker));

			// Token: 0x04000021 RID: 33
			private IntPtr class_ref;

			// Token: 0x04000022 RID: 34
			private static Delegate cb_onLoadCanceled_Landroidx_loader_content_Loader_;

			// Token: 0x04000023 RID: 35
			private IntPtr id_onLoadCanceled_Landroidx_loader_content_Loader_;
		}

		// Token: 0x02000015 RID: 21
		[Register("androidx/loader/content/Loader$OnLoadCompleteListener", "", "AndroidX.Loader.Content.Loader/IOnLoadCompleteListenerInvoker")]
		[JavaTypeParameters(new string[]
		{
			"D"
		})]
		public interface IOnLoadCompleteListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060000A1 RID: 161
			[Register("onLoadComplete", "(Landroidx/loader/content/Loader;Ljava/lang/Object;)V", "GetOnLoadComplete_Landroidx_loader_content_Loader_Ljava_lang_Object_Handler:AndroidX.Loader.Content.Loader/IOnLoadCompleteListenerInvoker, Xamarin.AndroidX.Loader")]
			void OnLoadComplete(Loader loader, Java.Lang.Object data);
		}

		// Token: 0x02000016 RID: 22
		[Register("androidx/loader/content/Loader$OnLoadCompleteListener", DoNotGenerateAcw = true)]
		internal class IOnLoadCompleteListenerInvoker : Java.Lang.Object, Loader.IOnLoadCompleteListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700000E RID: 14
			// (get) Token: 0x060000A2 RID: 162 RVA: 0x00002F88 File Offset: 0x00001188
			private static IntPtr java_class_ref
			{
				get
				{
					return Loader.IOnLoadCompleteListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x060000A3 RID: 163 RVA: 0x00002FAC File Offset: 0x000011AC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Loader.IOnLoadCompleteListenerInvoker._members;
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x060000A4 RID: 164 RVA: 0x00002FB3 File Offset: 0x000011B3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x060000A5 RID: 165 RVA: 0x00002FBB File Offset: 0x000011BB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Loader.IOnLoadCompleteListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060000A6 RID: 166 RVA: 0x00002FC7 File Offset: 0x000011C7
			public static Loader.IOnLoadCompleteListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<Loader.IOnLoadCompleteListener>(handle, transfer);
			}

			// Token: 0x060000A7 RID: 167 RVA: 0x00002FD0 File Offset: 0x000011D0
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, Loader.IOnLoadCompleteListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.loader.content.Loader.OnLoadCompleteListener'.");
				}
				return handle;
			}

			// Token: 0x060000A8 RID: 168 RVA: 0x00002FFB File Offset: 0x000011FB
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060000A9 RID: 169 RVA: 0x0000302C File Offset: 0x0000122C
			public IOnLoadCompleteListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Loader.IOnLoadCompleteListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060000AA RID: 170 RVA: 0x00003064 File Offset: 0x00001264
			private static Delegate GetOnLoadComplete_Landroidx_loader_content_Loader_Ljava_lang_Object_Handler()
			{
				if (Loader.IOnLoadCompleteListenerInvoker.cb_onLoadComplete_Landroidx_loader_content_Loader_Ljava_lang_Object_ == null)
				{
					Loader.IOnLoadCompleteListenerInvoker.cb_onLoadComplete_Landroidx_loader_content_Loader_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(Loader.IOnLoadCompleteListenerInvoker.n_OnLoadComplete_Landroidx_loader_content_Loader_Ljava_lang_Object_));
				}
				return Loader.IOnLoadCompleteListenerInvoker.cb_onLoadComplete_Landroidx_loader_content_Loader_Ljava_lang_Object_;
			}

			// Token: 0x060000AB RID: 171 RVA: 0x00003088 File Offset: 0x00001288
			private static void n_OnLoadComplete_Landroidx_loader_content_Loader_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_loader, IntPtr native_data)
			{
				Loader.IOnLoadCompleteListener @object = Java.Lang.Object.GetObject<Loader.IOnLoadCompleteListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Loader object2 = Java.Lang.Object.GetObject<Loader>(native_loader, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_data, JniHandleOwnership.DoNotTransfer);
				@object.OnLoadComplete(object2, object3);
			}

			// Token: 0x060000AC RID: 172 RVA: 0x000030B4 File Offset: 0x000012B4
			public unsafe void OnLoadComplete(Loader loader, Java.Lang.Object data)
			{
				if (this.id_onLoadComplete_Landroidx_loader_content_Loader_Ljava_lang_Object_ == IntPtr.Zero)
				{
					this.id_onLoadComplete_Landroidx_loader_content_Loader_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "onLoadComplete", "(Landroidx/loader/content/Loader;Ljava/lang/Object;)V");
				}
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(data);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((loader == null) ? IntPtr.Zero : loader.Handle);
				ptr[1] = new JValue(intPtr);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onLoadComplete_Landroidx_loader_content_Loader_Ljava_lang_Object_, ptr);
				JNIEnv.DeleteLocalRef(intPtr);
			}

			// Token: 0x04000024 RID: 36
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/loader/content/Loader$OnLoadCompleteListener", typeof(Loader.IOnLoadCompleteListenerInvoker));

			// Token: 0x04000025 RID: 37
			private IntPtr class_ref;

			// Token: 0x04000026 RID: 38
			private static Delegate cb_onLoadComplete_Landroidx_loader_content_Loader_Ljava_lang_Object_;

			// Token: 0x04000027 RID: 39
			private IntPtr id_onLoadComplete_Landroidx_loader_content_Loader_Ljava_lang_Object_;
		}
	}
}
