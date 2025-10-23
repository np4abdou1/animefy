using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Nio
{
	// Token: 0x02000377 RID: 887
	[Register("java/nio/CharBuffer", DoNotGenerateAcw = true)]
	internal class CharBufferInvoker : CharBuffer, Java.Lang.IComparable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600272A RID: 10026 RVA: 0x0006F92A File Offset: 0x0006DB2A
		public CharBufferInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x0600272B RID: 10027 RVA: 0x0006F934 File Offset: 0x0006DB34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CharBufferInvoker._members;
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x0600272C RID: 10028 RVA: 0x0006F93B File Offset: 0x0006DB3B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CharBufferInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x0006F948 File Offset: 0x0006DB48
		[return: GeneratedEnum]
		public unsafe override ICharSequence SubSequenceFormatted(int start, int end)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(start);
			ptr[1] = new JniArgumentValue(end);
			return Java.Lang.Object.GetObject<ICharSequence>(CharBufferInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("subSequence.(II)Ljava/lang/CharSequence;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04001019 RID: 4121
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/CharBuffer", typeof(CharBufferInvoker));
	}
}
