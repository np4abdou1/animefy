using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000021 RID: 33
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/CompletionHandler_commonKt", DoNotGenerateAcw = true)]
	public sealed class CompletionHandler_commonKt : Java.Lang.Object
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00003018 File Offset: 0x00001218
		internal static IntPtr class_ref
		{
			get
			{
				return CompletionHandler_commonKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000303C File Offset: 0x0000123C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CompletionHandler_commonKt._members;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00003044 File Offset: 0x00001244
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CompletionHandler_commonKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00003068 File Offset: 0x00001268
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CompletionHandler_commonKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003074 File Offset: 0x00001274
		internal CompletionHandler_commonKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400000D RID: 13
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CompletionHandler_commonKt", typeof(CompletionHandler_commonKt));
	}
}
