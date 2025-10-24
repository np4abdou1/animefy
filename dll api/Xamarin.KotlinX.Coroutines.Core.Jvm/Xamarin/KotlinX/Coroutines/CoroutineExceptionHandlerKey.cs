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
	// Token: 0x02000050 RID: 80
	[Register("kotlinx/coroutines/CoroutineExceptionHandler$Key", DoNotGenerateAcw = true)]
	public sealed class CoroutineExceptionHandlerKey : Java.Lang.Object, ICoroutineContextKey, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600031B RID: 795 RVA: 0x0000AFDC File Offset: 0x000091DC
		internal static IntPtr class_ref
		{
			get
			{
				return CoroutineExceptionHandlerKey._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600031C RID: 796 RVA: 0x0000B000 File Offset: 0x00009200
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return CoroutineExceptionHandlerKey._members;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600031D RID: 797 RVA: 0x0000B008 File Offset: 0x00009208
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CoroutineExceptionHandlerKey._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0000B02C File Offset: 0x0000922C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return CoroutineExceptionHandlerKey._members.ManagedPeerType;
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000B038 File Offset: 0x00009238
		internal CoroutineExceptionHandlerKey(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000102 RID: 258
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CoroutineExceptionHandler$Key", typeof(CoroutineExceptionHandlerKey));
	}
}
