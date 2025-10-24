using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x0200002F RID: 47
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/DispatchedTaskKt", DoNotGenerateAcw = true)]
	public sealed class DispatchedTaskKt : Java.Lang.Object
	{
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00004AE4 File Offset: 0x00002CE4
		internal static IntPtr class_ref
		{
			get
			{
				return DispatchedTaskKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00004B08 File Offset: 0x00002D08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DispatchedTaskKt._members;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00004B10 File Offset: 0x00002D10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DispatchedTaskKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00004B34 File Offset: 0x00002D34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DispatchedTaskKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00004B40 File Offset: 0x00002D40
		internal DispatchedTaskKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00004B4C File Offset: 0x00002D4C
		[Register("isCancellableMode", "(I)Z", "")]
		public unsafe static bool IsCancellableMode(int obj)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(obj);
			return DispatchedTaskKt._members.StaticMethods.InvokeBooleanMethod("isCancellableMode.(I)Z", ptr);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00004B88 File Offset: 0x00002D88
		[Register("isReusableMode", "(I)Z", "")]
		public unsafe static bool IsReusableMode(int obj)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(obj);
			return DispatchedTaskKt._members.StaticMethods.InvokeBooleanMethod("isReusableMode.(I)Z", ptr);
		}

		// Token: 0x04000024 RID: 36
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/DispatchedTaskKt", typeof(DispatchedTaskKt));
	}
}
