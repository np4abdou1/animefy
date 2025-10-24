using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x0200002A RID: 42
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/DebugKt", DoNotGenerateAcw = true)]
	public sealed class DebugKt : Java.Lang.Object
	{
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00004668 File Offset: 0x00002868
		internal static IntPtr class_ref
		{
			get
			{
				return DebugKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000468C File Offset: 0x0000288C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DebugKt._members;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00004694 File Offset: 0x00002894
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DebugKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000FA RID: 250 RVA: 0x000046B8 File Offset: 0x000028B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DebugKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000046C4 File Offset: 0x000028C4
		internal DebugKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400001C RID: 28
		[Register("DEBUG_PROPERTY_NAME")]
		public const string DebugPropertyName = "kotlinx.coroutines.debug";

		// Token: 0x0400001D RID: 29
		[Register("DEBUG_PROPERTY_VALUE_AUTO")]
		public const string DebugPropertyValueAuto = "auto";

		// Token: 0x0400001E RID: 30
		[Register("DEBUG_PROPERTY_VALUE_OFF")]
		public const string DebugPropertyValueOff = "off";

		// Token: 0x0400001F RID: 31
		[Register("DEBUG_PROPERTY_VALUE_ON")]
		public const string DebugPropertyValueOn = "on";

		// Token: 0x04000020 RID: 32
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/DebugKt", typeof(DebugKt));
	}
}
