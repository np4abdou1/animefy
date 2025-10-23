using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000079 RID: 121
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/JobSupportKt", DoNotGenerateAcw = true)]
	public sealed class JobSupportKt : Java.Lang.Object
	{
		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x00012D24 File Offset: 0x00010F24
		internal static IntPtr class_ref
		{
			get
			{
				return JobSupportKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00012D48 File Offset: 0x00010F48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return JobSupportKt._members;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x00012D50 File Offset: 0x00010F50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return JobSupportKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x00012D74 File Offset: 0x00010F74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return JobSupportKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00012D80 File Offset: 0x00010F80
		internal JobSupportKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000202 RID: 514
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/JobSupportKt", typeof(JobSupportKt));
	}
}
