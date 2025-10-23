using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Database.Sqlite
{
	// Token: 0x02000247 RID: 583
	[Register("android/database/sqlite/SQLiteOpenHelper", DoNotGenerateAcw = true)]
	public abstract class SQLiteOpenHelper : Java.Lang.Object, IAutoCloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001531 RID: 5425 RVA: 0x000364F6 File Offset: 0x000346F6
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SQLiteOpenHelper._members;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001532 RID: 5426 RVA: 0x00036500 File Offset: 0x00034700
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SQLiteOpenHelper._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06001533 RID: 5427 RVA: 0x00036524 File Offset: 0x00034724
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SQLiteOpenHelper._members.ManagedPeerType;
			}
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x000021E0 File Offset: 0x000003E0
		protected SQLiteOpenHelper(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x00036530 File Offset: 0x00034730
		private static Delegate GetCloseHandler()
		{
			if (SQLiteOpenHelper.cb_close == null)
			{
				SQLiteOpenHelper.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(SQLiteOpenHelper.n_Close));
			}
			return SQLiteOpenHelper.cb_close;
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x00036554 File Offset: 0x00034754
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<SQLiteOpenHelper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x00036563 File Offset: 0x00034763
		public virtual void Close()
		{
			SQLiteOpenHelper._members.InstanceMethods.InvokeVirtualVoidMethod("close.()V", this, null);
		}

		// Token: 0x04000948 RID: 2376
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/database/sqlite/SQLiteOpenHelper", typeof(SQLiteOpenHelper));

		// Token: 0x04000949 RID: 2377
		private static Delegate cb_close;
	}
}
