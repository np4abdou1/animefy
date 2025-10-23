using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x0200003E RID: 62
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/ChildHandle$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class ChildHandleDefaultImpls : Java.Lang.Object
	{
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x000061F4 File Offset: 0x000043F4
		internal static IntPtr class_ref
		{
			get
			{
				return ChildHandleDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00006218 File Offset: 0x00004418
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ChildHandleDefaultImpls._members;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00006220 File Offset: 0x00004420
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ChildHandleDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00006244 File Offset: 0x00004444
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ChildHandleDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00006250 File Offset: 0x00004450
		internal ChildHandleDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000052 RID: 82
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/ChildHandle$DefaultImpls", typeof(ChildHandleDefaultImpls));
	}
}
