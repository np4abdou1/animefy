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
	// Token: 0x0200003A RID: 58
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/GlobalScope", DoNotGenerateAcw = true)]
	public sealed class GlobalScope : Java.Lang.Object, ICoroutineScope, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000162 RID: 354 RVA: 0x000054AC File Offset: 0x000036AC
		[Register("INSTANCE")]
		public static GlobalScope Instance
		{
			get
			{
				return Java.Lang.Object.GetObject<GlobalScope>(GlobalScope._members.StaticFields.GetObjectValue("INSTANCE.Lkotlinx/coroutines/GlobalScope;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000163 RID: 355 RVA: 0x000054DC File Offset: 0x000036DC
		internal static IntPtr class_ref
		{
			get
			{
				return GlobalScope._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00005500 File Offset: 0x00003700
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GlobalScope._members;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00005508 File Offset: 0x00003708
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GlobalScope._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0000552C File Offset: 0x0000372C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GlobalScope._members.ManagedPeerType;
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00005538 File Offset: 0x00003738
		internal GlobalScope(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00005544 File Offset: 0x00003744
		public ICoroutineContext CoroutineContext
		{
			[Register("getCoroutineContext", "()Lkotlin/coroutines/CoroutineContext;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ICoroutineContext>(GlobalScope._members.InstanceMethods.InvokeAbstractObjectMethod("getCoroutineContext.()Lkotlin/coroutines/CoroutineContext;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000030 RID: 48
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/GlobalScope", typeof(GlobalScope));
	}
}
