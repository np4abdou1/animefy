using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport
{
	// Token: 0x0200000A RID: 10
	[Register("com/google/android/datatransport/Encoding", DoNotGenerateAcw = true)]
	public sealed class Encoding : Java.Lang.Object
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000021 RID: 33 RVA: 0x0000214C File Offset: 0x0000034C
		internal static IntPtr class_ref
		{
			get
			{
				return Encoding._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002170 File Offset: 0x00000370
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Encoding._members;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002178 File Offset: 0x00000378
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Encoding._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000024 RID: 36 RVA: 0x0000219C File Offset: 0x0000039C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Encoding._members.ManagedPeerType;
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000020B4 File Offset: 0x000002B4
		internal Encoding(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000021A8 File Offset: 0x000003A8
		public string Name
		{
			[Register("getName", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Encoding._members.InstanceMethods.InvokeAbstractObjectMethod("getName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000021DC File Offset: 0x000003DC
		[Register("of", "(Ljava/lang/String;)Lcom/google/android/datatransport/Encoding;", "")]
		public unsafe static Encoding Of(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			Encoding @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Encoding>(Encoding._members.StaticMethods.InvokeObjectMethod("of.(Ljava/lang/String;)Lcom/google/android/datatransport/Encoding;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x04000008 RID: 8
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/Encoding", typeof(Encoding));
	}
}
