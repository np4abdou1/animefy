using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.OS
{
	// Token: 0x020001DD RID: 477
	[Register("android/os/Build", DoNotGenerateAcw = true)]
	public class Build : Java.Lang.Object
	{
		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x0002E00F File Offset: 0x0002C20F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Build._members;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x0600116A RID: 4458 RVA: 0x0002E018 File Offset: 0x0002C218
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Build._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x0002E03C File Offset: 0x0002C23C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Build._members.ManagedPeerType;
			}
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Build(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040007D5 RID: 2005
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/os/Build", typeof(Build));

		// Token: 0x020001DE RID: 478
		[Register("android/os/Build$VERSION", DoNotGenerateAcw = true)]
		public class VERSION : Java.Lang.Object
		{
			// Token: 0x17000375 RID: 885
			// (get) Token: 0x0600116E RID: 4462 RVA: 0x0002E063 File Offset: 0x0002C263
			[Register("SDK_INT")]
			public static BuildVersionCodes SdkInt
			{
				get
				{
					return (BuildVersionCodes)Build.VERSION._members.StaticFields.GetInt32Value("SDK_INT.I");
				}
			}

			// Token: 0x17000376 RID: 886
			// (get) Token: 0x0600116F RID: 4463 RVA: 0x0002E079 File Offset: 0x0002C279
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Build.VERSION._members;
				}
			}

			// Token: 0x17000377 RID: 887
			// (get) Token: 0x06001170 RID: 4464 RVA: 0x0002E080 File Offset: 0x0002C280
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Build.VERSION._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000378 RID: 888
			// (get) Token: 0x06001171 RID: 4465 RVA: 0x0002E0A4 File Offset: 0x0002C2A4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Build.VERSION._members.ManagedPeerType;
				}
			}

			// Token: 0x06001172 RID: 4466 RVA: 0x000021E0 File Offset: 0x000003E0
			protected VERSION(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040007D6 RID: 2006
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/os/Build$VERSION", typeof(Build.VERSION));
		}
	}
}
