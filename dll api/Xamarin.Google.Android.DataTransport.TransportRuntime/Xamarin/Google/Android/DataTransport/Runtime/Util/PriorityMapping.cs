using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Util
{
	// Token: 0x02000030 RID: 48
	[Register("com/google/android/datatransport/runtime/util/PriorityMapping", DoNotGenerateAcw = true)]
	public sealed class PriorityMapping : Java.Lang.Object
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600017D RID: 381 RVA: 0x000050F8 File Offset: 0x000032F8
		internal static IntPtr class_ref
		{
			get
			{
				return PriorityMapping._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600017E RID: 382 RVA: 0x0000511C File Offset: 0x0000331C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PriorityMapping._members;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00005124 File Offset: 0x00003324
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PriorityMapping._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00005148 File Offset: 0x00003348
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PriorityMapping._members.ManagedPeerType;
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000026C4 File Offset: 0x000008C4
		internal PriorityMapping(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00005154 File Offset: 0x00003354
		[Register(".ctor", "()V", "")]
		public PriorityMapping() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(PriorityMapping._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			PriorityMapping._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000051C4 File Offset: 0x000033C4
		[Register("toInt", "(Lcom/google/android/datatransport/Priority;)I", "")]
		public unsafe static int ToInt(Priority priority)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((priority == null) ? IntPtr.Zero : priority.Handle);
				result = PriorityMapping._members.StaticMethods.InvokeInt32Method("toInt.(Lcom/google/android/datatransport/Priority;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(priority);
			}
			return result;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00005228 File Offset: 0x00003428
		[Register("valueOf", "(I)Lcom/google/android/datatransport/Priority;", "")]
		public unsafe static Priority ValueOf(int value)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(value);
			return Java.Lang.Object.GetObject<Priority>(PriorityMapping._members.StaticMethods.InvokeObjectMethod("valueOf.(I)Lcom/google/android/datatransport/Priority;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400004F RID: 79
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/util/PriorityMapping", typeof(PriorityMapping));
	}
}
