using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x020000B3 RID: 179
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/Unit", DoNotGenerateAcw = true)]
	public sealed class Unit : Java.Lang.Object
	{
		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x0000C91C File Offset: 0x0000AB1C
		[Register("INSTANCE")]
		public static Unit Instance
		{
			get
			{
				return Java.Lang.Object.GetObject<Unit>(Unit._members.StaticFields.GetObjectValue("INSTANCE.Lkotlin/Unit;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x0000C94C File Offset: 0x0000AB4C
		internal static IntPtr class_ref
		{
			get
			{
				return Unit._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x0000C970 File Offset: 0x0000AB70
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Unit._members;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x0000C978 File Offset: 0x0000AB78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Unit._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x0000C99C File Offset: 0x0000AB9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Unit._members.ManagedPeerType;
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
		internal Unit(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000174 RID: 372
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/Unit", typeof(Unit));
	}
}
