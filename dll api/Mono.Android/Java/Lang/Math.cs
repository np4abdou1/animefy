using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003E5 RID: 997
	[Register("java/lang/Math", DoNotGenerateAcw = true)]
	public sealed class Math : Object
	{
		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06002BCD RID: 11213 RVA: 0x0007958C File Offset: 0x0007778C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Math._members;
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06002BCE RID: 11214 RVA: 0x00079594 File Offset: 0x00077794
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Math._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06002BCF RID: 11215 RVA: 0x000795B8 File Offset: 0x000777B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Math._members.ManagedPeerType;
			}
		}

		// Token: 0x06002BD0 RID: 11216 RVA: 0x000021E0 File Offset: 0x000003E0
		internal Math(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002BD1 RID: 11217 RVA: 0x000795C4 File Offset: 0x000777C4
		public unsafe static float Abs(float a)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(a);
			return Math._members.StaticMethods.InvokeSingleMethod("abs.(F)F", ptr);
		}

		// Token: 0x04001175 RID: 4469
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Math", typeof(Math));
	}
}
