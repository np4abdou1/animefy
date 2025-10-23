using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x0200002C RID: 44
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/DefaultExecutorKt", DoNotGenerateAcw = true)]
	public sealed class DefaultExecutorKt : Java.Lang.Object
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00004858 File Offset: 0x00002A58
		internal static IntPtr class_ref
		{
			get
			{
				return DefaultExecutorKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000106 RID: 262 RVA: 0x0000487C File Offset: 0x00002A7C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DefaultExecutorKt._members;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00004884 File Offset: 0x00002A84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DefaultExecutorKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000048A8 File Offset: 0x00002AA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DefaultExecutorKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000048B4 File Offset: 0x00002AB4
		internal DefaultExecutorKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000022 RID: 34
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/DefaultExecutorKt", typeof(DefaultExecutorKt));
	}
}
