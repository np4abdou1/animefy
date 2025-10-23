using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Iab.Omid.Library.Adcolony
{
	// Token: 0x0200001B RID: 27
	[Register("com/iab/omid/library/adcolony/ScriptInjector", DoNotGenerateAcw = true)]
	public sealed class ScriptInjector : Java.Lang.Object
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002200 File Offset: 0x00000400
		internal static IntPtr class_ref
		{
			get
			{
				return ScriptInjector._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00002224 File Offset: 0x00000424
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
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0000222C File Offset: 0x0000042C
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
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002250 File Offset: 0x00000450
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScriptInjector._members.ManagedPeerType;
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002128 File Offset: 0x00000328
		internal ScriptInjector(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000225C File Offset: 0x0000045C
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

		// Token: 0x04000004 RID: 4
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/iab/omid/library/adcolony/ScriptInjector", typeof(ScriptInjector));
	}
}
