using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Xamarin.Google.Android.DataTransport.Runtime;

namespace Xamarin.Google.Android.DataTransport.Cct
{
	// Token: 0x02000009 RID: 9
	[Register("com/google/android/datatransport/cct/CCTDestination", DoNotGenerateAcw = true)]
	public sealed class CCTDestination : Java.Lang.Object, IEncodedDestination, IDestination, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000020 RID: 32 RVA: 0x0000220C File Offset: 0x0000040C
		[Register("INSTANCE")]
		public static CCTDestination Instance
		{
			get
			{
				return Java.Lang.Object.GetObject<CCTDestination>(CCTDestination._members.StaticFields.GetObjectValue("INSTANCE.Lcom/google/android/datatransport/cct/CCTDestination;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000021 RID: 33 RVA: 0x0000223C File Offset: 0x0000043C
		[Register("LEGACY_INSTANCE")]
		public static CCTDestination LegacyInstance
		{
			get
			{
				return Java.Lang.Object.GetObject<CCTDestination>(CCTDestination._members.StaticFields.GetObjectValue("LEGACY_INSTANCE.Lcom/google/android/datatransport/cct/CCTDestination;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000022 RID: 34 RVA: 0x0000226C File Offset: 0x0000046C
		internal static IntPtr class_ref
		{
			get
			{
				return CCTDestination._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002290 File Offset: 0x00000490
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CCTDestination._members;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002298 File Offset: 0x00000498
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CCTDestination._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000022BC File Offset: 0x000004BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CCTDestination._members.ManagedPeerType;
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000020B4 File Offset: 0x000002B4
		internal CCTDestination(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000022C8 File Offset: 0x000004C8
		[Register(".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe CCTDestination(string endPoint, string apiKey) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(endPoint);
			IntPtr intPtr2 = JNIEnv.NewString(apiKey);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				base.SetHandle(CCTDestination._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CCTDestination._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000028 RID: 40 RVA: 0x0000238C File Offset: 0x0000058C
		public string APIKey
		{
			[Register("getAPIKey", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(CCTDestination._members.InstanceMethods.InvokeAbstractObjectMethod("getAPIKey.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000023C0 File Offset: 0x000005C0
		public string EndPoint
		{
			[Register("getEndPoint", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(CCTDestination._members.InstanceMethods.InvokeAbstractObjectMethod("getEndPoint.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000023F4 File Offset: 0x000005F4
		public string Name
		{
			[Register("getName", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(CCTDestination._members.InstanceMethods.InvokeAbstractObjectMethod("getName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002428 File Offset: 0x00000628
		public ICollection<Encoding> SupportedEncodings
		{
			[Register("getSupportedEncodings", "()Ljava/util/Set;", "")]
			get
			{
				return JavaSet<Encoding>.FromJniHandle(CCTDestination._members.InstanceMethods.InvokeAbstractObjectMethod("getSupportedEncodings.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000245C File Offset: 0x0000065C
		[Register("asByteArray", "()[B", "")]
		public byte[] AsByteArray()
		{
			return (byte[])JNIEnv.GetArray(CCTDestination._members.InstanceMethods.InvokeAbstractObjectMethod("asByteArray.()[B", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000024A0 File Offset: 0x000006A0
		[Register("fromByteArray", "([B)Lcom/google/android/datatransport/cct/CCTDestination;", "")]
		public unsafe static CCTDestination FromByteArray(byte[] a)
		{
			IntPtr intPtr = JNIEnv.NewArray(a);
			CCTDestination @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<CCTDestination>(CCTDestination._members.StaticMethods.InvokeObjectMethod("fromByteArray.([B)Lcom/google/android/datatransport/cct/CCTDestination;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (a != null)
				{
					JNIEnv.CopyArray(intPtr, a);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(a);
			}
			return @object;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000251C File Offset: 0x0000071C
		[Register("getExtras", "()[B", "")]
		public byte[] GetExtras()
		{
			return (byte[])JNIEnv.GetArray(CCTDestination._members.InstanceMethods.InvokeAbstractObjectMethod("getExtras.()[B", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		// Token: 0x04000003 RID: 3
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/CCTDestination", typeof(CCTDestination));
	}
}
