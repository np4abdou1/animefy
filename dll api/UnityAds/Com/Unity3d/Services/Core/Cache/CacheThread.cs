using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Cache
{
	// Token: 0x0200017F RID: 383
	[Register("com/unity3d/services/core/cache/CacheThread", DoNotGenerateAcw = true)]
	public class CacheThread : Thread
	{
		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x0002E4C8 File Offset: 0x0002C6C8
		internal static IntPtr class_ref
		{
			get
			{
				return CacheThread._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x0600113D RID: 4413 RVA: 0x0002E4EC File Offset: 0x0002C6EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CacheThread._members;
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x0600113E RID: 4414 RVA: 0x0002E4F4 File Offset: 0x0002C6F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CacheThread._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x0600113F RID: 4415 RVA: 0x0002E518 File Offset: 0x0002C718
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CacheThread._members.ManagedPeerType;
			}
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x0002C910 File Offset: 0x0002AB10
		protected CacheThread(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x0002E524 File Offset: 0x0002C724
		[Register(".ctor", "()V", "")]
		public CacheThread() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(CacheThread._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			CacheThread._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001142 RID: 4418 RVA: 0x0002E592 File Offset: 0x0002C792
		// (set) Token: 0x06001143 RID: 4419 RVA: 0x0002E5AC File Offset: 0x0002C7AC
		public unsafe static int ConnectTimeout
		{
			[Register("getConnectTimeout", "()I", "")]
			get
			{
				return CacheThread._members.StaticMethods.InvokeInt32Method("getConnectTimeout.()I", null);
			}
			[Register("setConnectTimeout", "(I)V", "")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CacheThread._members.StaticMethods.InvokeVoidMethod("setConnectTimeout.(I)V", ptr);
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001144 RID: 4420 RVA: 0x0002E5E6 File Offset: 0x0002C7E6
		public static bool IsActive
		{
			[Register("isActive", "()Z", "")]
			get
			{
				return CacheThread._members.StaticMethods.InvokeBooleanMethod("isActive.()Z", null);
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x0002E5FE File Offset: 0x0002C7FE
		// (set) Token: 0x06001146 RID: 4422 RVA: 0x0002E618 File Offset: 0x0002C818
		public unsafe static int ProgressInterval
		{
			[Register("getProgressInterval", "()I", "")]
			get
			{
				return CacheThread._members.StaticMethods.InvokeInt32Method("getProgressInterval.()I", null);
			}
			[Register("setProgressInterval", "(I)V", "")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CacheThread._members.StaticMethods.InvokeVoidMethod("setProgressInterval.(I)V", ptr);
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001147 RID: 4423 RVA: 0x0002E652 File Offset: 0x0002C852
		// (set) Token: 0x06001148 RID: 4424 RVA: 0x0002E66C File Offset: 0x0002C86C
		public unsafe static int ReadTimeout
		{
			[Register("getReadTimeout", "()I", "")]
			get
			{
				return CacheThread._members.StaticMethods.InvokeInt32Method("getReadTimeout.()I", null);
			}
			[Register("setReadTimeout", "(I)V", "")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				CacheThread._members.StaticMethods.InvokeVoidMethod("setReadTimeout.(I)V", ptr);
			}
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x0002E6A6 File Offset: 0x0002C8A6
		[Register("cancel", "()V", "")]
		public static void Cancel()
		{
			CacheThread._members.StaticMethods.InvokeVoidMethod("cancel.()V", null);
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x0002E6C0 File Offset: 0x0002C8C0
		[Register("download", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/HashMap;Z)V", "")]
		public unsafe static void Download(string source, string target, IDictionary<string, IList<string>> headers, bool append)
		{
			IntPtr intPtr = JNIEnv.NewString(source);
			IntPtr intPtr2 = JNIEnv.NewString(target);
			IntPtr intPtr3 = JavaDictionary<string, IList<string>>.ToLocalJniHandle(headers);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(append);
				CacheThread._members.StaticMethods.InvokeVoidMethod("download.(Ljava/lang/String;Ljava/lang/String;Ljava/util/HashMap;Z)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(headers);
			}
		}

		// Token: 0x04000440 RID: 1088
		[Register("MSG_DOWNLOAD")]
		public const int MsgDownload = 1;

		// Token: 0x04000441 RID: 1089
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/cache/CacheThread", typeof(CacheThread));
	}
}
