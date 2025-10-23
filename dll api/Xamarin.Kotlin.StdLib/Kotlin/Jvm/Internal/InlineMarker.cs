using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001A5 RID: 421
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/InlineMarker", DoNotGenerateAcw = true)]
	public class InlineMarker : Java.Lang.Object
	{
		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x060014A8 RID: 5288 RVA: 0x00042938 File Offset: 0x00040B38
		internal static IntPtr class_ref
		{
			get
			{
				return InlineMarker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x0004295C File Offset: 0x00040B5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return InlineMarker._members;
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x060014AA RID: 5290 RVA: 0x00042964 File Offset: 0x00040B64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return InlineMarker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x00042988 File Offset: 0x00040B88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InlineMarker._members.ManagedPeerType;
			}
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x00042994 File Offset: 0x00040B94
		protected InlineMarker(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x000429A0 File Offset: 0x00040BA0
		[Register(".ctor", "()V", "")]
		public InlineMarker() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(InlineMarker._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			InlineMarker._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x00042A0E File Offset: 0x00040C0E
		[Register("afterInlineCall", "()V", "")]
		public static void AfterInlineCall()
		{
			InlineMarker._members.StaticMethods.InvokeVoidMethod("afterInlineCall.()V", null);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x00042A26 File Offset: 0x00040C26
		[Register("beforeInlineCall", "()V", "")]
		public static void BeforeInlineCall()
		{
			InlineMarker._members.StaticMethods.InvokeVoidMethod("beforeInlineCall.()V", null);
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x00042A40 File Offset: 0x00040C40
		[Register("finallyEnd", "(I)V", "")]
		public unsafe static void FinallyEnd(int finallyDepth)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(finallyDepth);
			InlineMarker._members.StaticMethods.InvokeVoidMethod("finallyEnd.(I)V", ptr);
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x00042A7C File Offset: 0x00040C7C
		[Register("finallyStart", "(I)V", "")]
		public unsafe static void FinallyStart(int finallyDepth)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(finallyDepth);
			InlineMarker._members.StaticMethods.InvokeVoidMethod("finallyStart.(I)V", ptr);
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x00042AB8 File Offset: 0x00040CB8
		[Register("mark", "(I)V", "")]
		public unsafe static void Mark(int i)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(i);
			InlineMarker._members.StaticMethods.InvokeVoidMethod("mark.(I)V", ptr);
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x00042AF4 File Offset: 0x00040CF4
		[NullableContext(2)]
		[Register("mark", "(Ljava/lang/String;)V", "")]
		public unsafe static void Mark(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				InlineMarker._members.StaticMethods.InvokeVoidMethod("mark.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x040006BA RID: 1722
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/InlineMarker", typeof(InlineMarker));
	}
}
