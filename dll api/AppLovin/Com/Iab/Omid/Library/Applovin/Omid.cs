using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Applovin
{
	// Token: 0x0200002F RID: 47
	[Register("com/iab/omid/library/applovin/Omid", DoNotGenerateAcw = true)]
	public sealed class Omid : Java.Lang.Object
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00002194 File Offset: 0x00000394
		internal static IntPtr class_ref
		{
			get
			{
				return Omid._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x060000AD RID: 173 RVA: 0x000021B8 File Offset: 0x000003B8
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
		// (get) Token: 0x060000AE RID: 174 RVA: 0x000021C0 File Offset: 0x000003C0
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
		// (get) Token: 0x060000AF RID: 175 RVA: 0x000021E4 File Offset: 0x000003E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Omid._members.ManagedPeerType;
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000021F0 File Offset: 0x000003F0
		internal Omid(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x000021FA File Offset: 0x000003FA
		public static bool IsActive
		{
			[Register("isActive", "()Z", "")]
			get
			{
				return Omid._members.StaticMethods.InvokeBooleanMethod("isActive.()Z", null);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00002214 File Offset: 0x00000414
		public static string Version
		{
			[Register("getVersion", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(Omid._members.StaticMethods.InvokeObjectMethod("getVersion.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002248 File Offset: 0x00000448
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

		// Token: 0x04000006 RID: 6
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/applovin/Omid", typeof(Omid));
	}
}
