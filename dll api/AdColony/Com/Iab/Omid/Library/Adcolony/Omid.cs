using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Adcolony
{
	// Token: 0x0200001A RID: 26
	[Register("com/iab/omid/library/adcolony/Omid", DoNotGenerateAcw = true)]
	public sealed class Omid : Java.Lang.Object
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000020CC File Offset: 0x000002CC
		internal static IntPtr class_ref
		{
			get
			{
				return Omid._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000020F0 File Offset: 0x000002F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Omid._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000020F8 File Offset: 0x000002F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Omid._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000211C File Offset: 0x0000031C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Omid._members.ManagedPeerType;
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002128 File Offset: 0x00000328
		internal Omid(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00002132 File Offset: 0x00000332
		public static bool IsActive
		{
			[Register("isActive", "()Z", "")]
			get
			{
				return Omid._members.StaticMethods.InvokeBooleanMethod("isActive.()Z", null);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600005B RID: 91 RVA: 0x0000214C File Offset: 0x0000034C
		public static string Version
		{
			[Register("getVersion", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Omid._members.StaticMethods.InvokeObjectMethod("getVersion.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002180 File Offset: 0x00000380
		[Register("activate", "(Landroid/content/Context;)V", "")]
		public unsafe static void Activate(Context p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				Omid._members.StaticMethods.InvokeVoidMethod("activate.(Landroid/content/Context;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x04000003 RID: 3
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/adcolony/Omid", typeof(Omid));
	}
}
