using System;
using Android.Database;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000C9 RID: 201
	[Register("android/widget/Adapter", "", "Android.Widget.IAdapterInvoker")]
	public interface IAdapter : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060003F1 RID: 1009
		int Count { get; }

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060003F2 RID: 1010
		bool HasStableIds { get; }

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060003F3 RID: 1011
		bool IsEmpty { get; }

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060003F4 RID: 1012
		int ViewTypeCount { get; }

		// Token: 0x060003F5 RID: 1013
		Java.Lang.Object GetItem(int position);

		// Token: 0x060003F6 RID: 1014
		long GetItemId(int position);

		// Token: 0x060003F7 RID: 1015
		int GetItemViewType(int position);

		// Token: 0x060003F8 RID: 1016
		View GetView(int position, View convertView, ViewGroup parent);

		// Token: 0x060003F9 RID: 1017
		void RegisterDataSetObserver(DataSetObserver observer);

		// Token: 0x060003FA RID: 1018
		void UnregisterDataSetObserver(DataSetObserver observer);

		// Token: 0x060003FB RID: 1019 RVA: 0x000072FF File Offset: 0x000054FF
		private static Delegate GetGetAutofillOptionsHandler()
		{
			if (IAdapter.cb_getAutofillOptions == null)
			{
				IAdapter.cb_getAutofillOptions = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IAdapter.n_GetAutofillOptions));
			}
			return IAdapter.cb_getAutofillOptions;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00007323 File Offset: 0x00005523
		private static IntPtr n_GetAutofillOptions(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray<ICharSequence>(Java.Lang.Object.GetObject<IAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetAutofillOptionsFormatted());
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00007338 File Offset: 0x00005538
		ICharSequence[] GetAutofillOptionsFormatted()
		{
			return (ICharSequence[])JNIEnv.GetArray(IAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("getAutofillOptions.()[Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(ICharSequence));
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00007379 File Offset: 0x00005579
		string[] GetAutofillOptions()
		{
			return CharSequence.ArrayToStringArray(this.GetAutofillOptionsFormatted());
		}

		// Token: 0x040000AA RID: 170
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/Adapter", typeof(IAdapter), true);

		// Token: 0x040000AB RID: 171
		private static Delegate cb_getAutofillOptions;
	}
}
