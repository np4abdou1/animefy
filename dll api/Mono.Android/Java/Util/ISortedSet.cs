using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x0200031C RID: 796
	[Register("java/util/SortedSet", "", "Java.Util.ISortedSetInvoker")]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public interface ISortedSet : ISet, ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060021C4 RID: 8644
		IComparator Comparator();

		// Token: 0x060021C5 RID: 8645
		Java.Lang.Object First();

		// Token: 0x060021C6 RID: 8646
		ISortedSet HeadSet(Java.Lang.Object toElement);

		// Token: 0x060021C7 RID: 8647
		Java.Lang.Object Last();

		// Token: 0x060021C8 RID: 8648
		ISortedSet SubSet(Java.Lang.Object fromElement, Java.Lang.Object toElement);

		// Token: 0x060021C9 RID: 8649
		ISortedSet TailSet(Java.Lang.Object fromElement);

		// Token: 0x060021CA RID: 8650 RVA: 0x0005F57B File Offset: 0x0005D77B
		private static Delegate GetSpliteratorHandler()
		{
			if (ISortedSet.cb_spliterator == null)
			{
				ISortedSet.cb_spliterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISortedSet.n_Spliterator));
			}
			return ISortedSet.cb_spliterator;
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x0005F59F File Offset: 0x0005D79F
		private static IntPtr n_Spliterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISortedSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Spliterator());
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x0005F5B4 File Offset: 0x0005D7B4
		ISpliterator Spliterator()
		{
			return Java.Lang.Object.GetObject<ISpliterator>(ISortedSet._members.InstanceMethods.InvokeVirtualObjectMethod("spliterator.()Ljava/util/Spliterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000DE9 RID: 3561
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/SortedSet", typeof(ISortedSet), true);

		// Token: 0x04000DEA RID: 3562
		private static Delegate cb_spliterator;
	}
}
