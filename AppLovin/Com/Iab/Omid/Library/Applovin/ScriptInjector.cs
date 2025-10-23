using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Applovin
{
	// Token: 0x02000030 RID: 48
	[Register("com/iab/omid/library/applovin/ScriptInjector", DoNotGenerateAcw = true)]
	public sealed class ScriptInjector : Java.Lang.Object
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x000022C8 File Offset: 0x000004C8
		internal static IntPtr class_ref
		{
			get
			{
				return ScriptInjector._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x000022EC File Offset: 0x000004EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScriptInjector._members;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000022F4 File Offset: 0x000004F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScriptInjector._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00002318 File Offset: 0x00000518
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScriptInjector._members.ManagedPeerType;
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000021F0 File Offset: 0x000003F0
		internal ScriptInjector(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002324 File Offset: 0x00000524
		[Register("injectScriptContentIntoHtml", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe static string InjectScriptContentIntoHtml(string p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@string = JNIEnv.GetString(ScriptInjector._members.StaticMethods.InvokeObjectMethod("injectScriptContentIntoHtml.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @string;
		}

		// Token: 0x04000007 RID: 7
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/applovin/ScriptInjector", typeof(ScriptInjector));
	}
}
