using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Database
{
	// Token: 0x02000242 RID: 578
	[Register("android/database/DataSetObserver", DoNotGenerateAcw = true)]
	public abstract class DataSetObserver : Java.Lang.Object
	{
		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x0600147C RID: 5244 RVA: 0x00034B97 File Offset: 0x00032D97
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DataSetObserver._members;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x0600147D RID: 5245 RVA: 0x00034BA0 File Offset: 0x00032DA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DataSetObserver._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x0600147E RID: 5246 RVA: 0x00034BC4 File Offset: 0x00032DC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DataSetObserver._members.ManagedPeerType;
			}
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x000021E0 File Offset: 0x000003E0
		protected DataSetObserver(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040008EC RID: 2284
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/database/DataSetObserver", typeof(DataSetObserver));
	}
}
