using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport
{
	// Token: 0x02000015 RID: 21
	[Register("com/google/android/datatransport/Priority", DoNotGenerateAcw = true)]
	public sealed class Priority : Java.Lang.Enum
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00003128 File Offset: 0x00001328
		[Register("DEFAULT")]
		public static Priority Default
		{
			get
			{
				return Java.Lang.Object.GetObject<Priority>(Priority._members.StaticFields.GetObjectValue("DEFAULT.Lcom/google/android/datatransport/Priority;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00003158 File Offset: 0x00001358
		[Register("HIGHEST")]
		public static Priority Highest
		{
			get
			{
				return Java.Lang.Object.GetObject<Priority>(Priority._members.StaticFields.GetObjectValue("HIGHEST.Lcom/google/android/datatransport/Priority;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00003188 File Offset: 0x00001388
		[Register("VERY_LOW")]
		public static Priority VeryLow
		{
			get
			{
				return Java.Lang.Object.GetObject<Priority>(Priority._members.StaticFields.GetObjectValue("VERY_LOW.Lcom/google/android/datatransport/Priority;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000085 RID: 133 RVA: 0x000031B8 File Offset: 0x000013B8
		internal static IntPtr class_ref
		{
			get
			{
				return Priority._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000086 RID: 134 RVA: 0x000031DC File Offset: 0x000013DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Priority._members;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000087 RID: 135 RVA: 0x000031E4 File Offset: 0x000013E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Priority._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00003208 File Offset: 0x00001408
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Priority._members.ManagedPeerType;
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00003214 File Offset: 0x00001414
		internal Priority(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00003220 File Offset: 0x00001420
		[Register("valueOf", "(Ljava/lang/String;)Lcom/google/android/datatransport/Priority;", "")]
		public unsafe static Priority ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			Priority @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Priority>(Priority._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/google/android/datatransport/Priority;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000328C File Offset: 0x0000148C
		[Register("values", "()[Lcom/google/android/datatransport/Priority;", "")]
		public static Priority[] Values()
		{
			return (Priority[])JNIEnv.GetArray(Priority._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/google/android/datatransport/Priority;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Priority));
		}

		// Token: 0x04000022 RID: 34
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/Priority", typeof(Priority));
	}
}
