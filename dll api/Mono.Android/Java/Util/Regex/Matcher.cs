using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Regex
{
	// Token: 0x0200032A RID: 810
	[Register("java/util/regex/Matcher", DoNotGenerateAcw = true)]
	public sealed class Matcher : Java.Lang.Object, IMatchResult, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060022A3 RID: 8867 RVA: 0x00061B4B File Offset: 0x0005FD4B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Matcher._members;
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x060022A4 RID: 8868 RVA: 0x00061B54 File Offset: 0x0005FD54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Matcher._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x060022A5 RID: 8869 RVA: 0x00061B78 File Offset: 0x0005FD78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Matcher._members.ManagedPeerType;
			}
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x000021E0 File Offset: 0x000003E0
		internal Matcher(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x00061B84 File Offset: 0x0005FD84
		public int End()
		{
			return Matcher._members.InstanceMethods.InvokeAbstractInt32Method("end.()I", this, null);
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x00061BA0 File Offset: 0x0005FDA0
		public unsafe int End(int group)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(group);
			return Matcher._members.InstanceMethods.InvokeAbstractInt32Method("end.(I)I", this, ptr);
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x00061BDB File Offset: 0x0005FDDB
		public bool Find()
		{
			return Matcher._members.InstanceMethods.InvokeAbstractBooleanMethod("find.()Z", this, null);
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x00061BF4 File Offset: 0x0005FDF4
		public string Group()
		{
			return JNIEnv.GetString(Matcher._members.InstanceMethods.InvokeAbstractObjectMethod("group.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x00061C28 File Offset: 0x0005FE28
		public unsafe string Group(int group)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(group);
			return JNIEnv.GetString(Matcher._members.InstanceMethods.InvokeAbstractObjectMethod("group.(I)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x00061C71 File Offset: 0x0005FE71
		public int GroupCount()
		{
			return Matcher._members.InstanceMethods.InvokeAbstractInt32Method("groupCount.()I", this, null);
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x00061C8A File Offset: 0x0005FE8A
		public int Start()
		{
			return Matcher._members.InstanceMethods.InvokeAbstractInt32Method("start.()I", this, null);
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x00061CA4 File Offset: 0x0005FEA4
		public unsafe int Start(int group)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(group);
			return Matcher._members.InstanceMethods.InvokeAbstractInt32Method("start.(I)I", this, ptr);
		}

		// Token: 0x04000E4B RID: 3659
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/regex/Matcher", typeof(Matcher));
	}
}
