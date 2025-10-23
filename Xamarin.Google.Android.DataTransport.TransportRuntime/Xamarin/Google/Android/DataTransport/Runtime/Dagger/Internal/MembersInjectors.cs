using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal
{
	// Token: 0x020000EE RID: 238
	[Register("com/google/android/datatransport/runtime/dagger/internal/MembersInjectors", DoNotGenerateAcw = true)]
	public sealed class MembersInjectors : Java.Lang.Object
	{
		// Token: 0x17000283 RID: 643
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x000175E0 File Offset: 0x000157E0
		internal static IntPtr class_ref
		{
			get
			{
				return MembersInjectors._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x00017604 File Offset: 0x00015804
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MembersInjectors._members;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x0001760C File Offset: 0x0001580C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MembersInjectors._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x00017630 File Offset: 0x00015830
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MembersInjectors._members.ManagedPeerType;
			}
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x000026C4 File Offset: 0x000008C4
		internal MembersInjectors(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x0001763C File Offset: 0x0001583C
		[Register("noOp", "()Lcom/google/android/datatransport/runtime/dagger/MembersInjector;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public static IMembersInjector NoOp()
		{
			return Java.Lang.Object.GetObject<IMembersInjector>(MembersInjectors._members.StaticMethods.InvokeObjectMethod("noOp.()Lcom/google/android/datatransport/runtime/dagger/MembersInjector;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000263 RID: 611
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/internal/MembersInjectors", typeof(MembersInjectors));
	}
}
