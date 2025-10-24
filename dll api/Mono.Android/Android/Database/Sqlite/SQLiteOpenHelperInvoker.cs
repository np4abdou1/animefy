using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Database.Sqlite
{
	// Token: 0x02000248 RID: 584
	[Register("android/database/sqlite/SQLiteOpenHelper", DoNotGenerateAcw = true)]
	internal class SQLiteOpenHelperInvoker : SQLiteOpenHelper
	{
		// Token: 0x06001539 RID: 5433 RVA: 0x00036597 File Offset: 0x00034797
		public SQLiteOpenHelperInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x0600153A RID: 5434 RVA: 0x000365A1 File Offset: 0x000347A1
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SQLiteOpenHelperInvoker._members;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x0600153B RID: 5435 RVA: 0x000365A8 File Offset: 0x000347A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SQLiteOpenHelperInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0400094A RID: 2378
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/database/sqlite/SQLiteOpenHelper", typeof(SQLiteOpenHelperInvoker));
	}
}
