using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.DI
{
	// Token: 0x02000115 RID: 277
	[Register("com/unity3d/services/core/di/ServiceKey", DoNotGenerateAcw = true)]
	public sealed class ServiceKey : Java.Lang.Object
	{
		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x0001EBBC File Offset: 0x0001CDBC
		internal static IntPtr class_ref
		{
			get
			{
				return ServiceKey._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x0001EBE0 File Offset: 0x0001CDE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ServiceKey._members;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x0001EBE8 File Offset: 0x0001CDE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ServiceKey._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x0001EC0C File Offset: 0x0001CE0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ServiceKey._members.ManagedPeerType;
			}
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x000021E8 File Offset: 0x000003E8
		internal ServiceKey(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x0001EC18 File Offset: 0x0001CE18
		public string Named
		{
			[Register("getNamed", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(ServiceKey._members.InstanceMethods.InvokeNonvirtualObjectMethod("getNamed.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0001EC4C File Offset: 0x0001CE4C
		[Register("component1", "()Ljava/lang/String;", "")]
		public string Component1()
		{
			return JNIEnv.GetString(ServiceKey._members.InstanceMethods.InvokeNonvirtualObjectMethod("component1.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000289 RID: 649
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/di/ServiceKey", typeof(ServiceKey));
	}
}
