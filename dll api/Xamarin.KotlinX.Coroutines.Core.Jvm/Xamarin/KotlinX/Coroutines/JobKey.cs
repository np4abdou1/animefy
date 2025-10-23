using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000068 RID: 104
	[Register("kotlinx/coroutines/Job$Key", DoNotGenerateAcw = true)]
	public sealed class JobKey : Java.Lang.Object, ICoroutineContextKey, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x0000E41C File Offset: 0x0000C61C
		internal static IntPtr class_ref
		{
			get
			{
				return JobKey._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x0000E440 File Offset: 0x0000C640
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return JobKey._members;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x0000E448 File Offset: 0x0000C648
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return JobKey._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x0000E46C File Offset: 0x0000C66C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return JobKey._members.ManagedPeerType;
			}
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0000E478 File Offset: 0x0000C678
		internal JobKey(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400017D RID: 381
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/Job$Key", typeof(JobKey));
	}
}
