using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.OS
{
	// Token: 0x020001DA RID: 474
	[Register("android/os/AsyncTask", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"Params",
		"Progress",
		"Result"
	})]
	public abstract class AsyncTask : Java.Lang.Object
	{
		// Token: 0x1700036A RID: 874
		// (get) Token: 0x0600113F RID: 4415 RVA: 0x0002D857 File Offset: 0x0002BA57
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AsyncTask._members;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x0002D860 File Offset: 0x0002BA60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AsyncTask._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06001141 RID: 4417 RVA: 0x0002D884 File Offset: 0x0002BA84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AsyncTask._members.ManagedPeerType;
			}
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x000021E0 File Offset: 0x000003E0
		protected AsyncTask(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x0002D890 File Offset: 0x0002BA90
		private static Delegate GetDoInBackground_arrayLjava_lang_Object_Handler()
		{
			if (AsyncTask.cb_doInBackground_arrayLjava_lang_Object_ == null)
			{
				AsyncTask.cb_doInBackground_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AsyncTask.n_DoInBackground_arrayLjava_lang_Object_));
			}
			return AsyncTask.cb_doInBackground_arrayLjava_lang_Object_;
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x0002D8B4 File Offset: 0x0002BAB4
		private static IntPtr n_DoInBackground_arrayLjava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native__params)
		{
			AsyncTask @object = Java.Lang.Object.GetObject<AsyncTask>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object[] array = (Java.Lang.Object[])JNIEnv.GetArray(native__params, JniHandleOwnership.DoNotTransfer, typeof(Java.Lang.Object));
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.DoInBackground(array));
			if (array != null)
			{
				JNIEnv.CopyArray<Java.Lang.Object>(array, native__params);
			}
			return result;
		}

		// Token: 0x06001145 RID: 4421
		protected abstract Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params);

		// Token: 0x040007C9 RID: 1993
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/os/AsyncTask", typeof(AsyncTask));

		// Token: 0x040007CA RID: 1994
		private static Delegate cb_doInBackground_arrayLjava_lang_Object_;
	}
}
