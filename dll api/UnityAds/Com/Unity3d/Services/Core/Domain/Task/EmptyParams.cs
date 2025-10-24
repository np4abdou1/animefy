using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Domain.Task
{
	// Token: 0x02000102 RID: 258
	[Register("com/unity3d/services/core/domain/task/EmptyParams", DoNotGenerateAcw = true)]
	public sealed class EmptyParams : Java.Lang.Object, IBaseParams, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x0001D7D0 File Offset: 0x0001B9D0
		[Register("INSTANCE")]
		public static EmptyParams Instance
		{
			get
			{
				return Java.Lang.Object.GetObject<EmptyParams>(EmptyParams._members.StaticFields.GetObjectValue("INSTANCE.Lcom/unity3d/services/core/domain/task/EmptyParams;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x0001D800 File Offset: 0x0001BA00
		internal static IntPtr class_ref
		{
			get
			{
				return EmptyParams._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x0001D824 File Offset: 0x0001BA24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return EmptyParams._members;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x0001D82C File Offset: 0x0001BA2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return EmptyParams._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x0001D850 File Offset: 0x0001BA50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return EmptyParams._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x000021E8 File Offset: 0x000003E8
		internal EmptyParams(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000268 RID: 616
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/domain/task/EmptyParams", typeof(EmptyParams));
	}
}
