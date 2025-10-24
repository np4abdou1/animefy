using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x0200030A RID: 778
	[Register("java/util/Enumeration", "", "Java.Util.IEnumerationInvoker")]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public interface IEnumeration : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001F80 RID: 8064
		bool HasMoreElements { get; }

		// Token: 0x06001F81 RID: 8065
		Java.Lang.Object NextElement();

		// Token: 0x06001F82 RID: 8066 RVA: 0x00056176 File Offset: 0x00054376
		private static Delegate GetAsIteratorHandler()
		{
			if (IEnumeration.cb_asIterator == null)
			{
				IEnumeration.cb_asIterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IEnumeration.n_AsIterator));
			}
			return IEnumeration.cb_asIterator;
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x0005619A File Offset: 0x0005439A
		private static IntPtr n_AsIterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IEnumeration>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AsIterator());
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x000561B0 File Offset: 0x000543B0
		IIterator AsIterator()
		{
			return Java.Lang.Object.GetObject<IIterator>(IEnumeration._members.InstanceMethods.InvokeVirtualObjectMethod("asIterator.()Ljava/util/Iterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000CE5 RID: 3301
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/Enumeration", typeof(IEnumeration), true);

		// Token: 0x04000CE6 RID: 3302
		private static Delegate cb_asIterator;
	}
}
