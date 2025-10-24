using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x02000305 RID: 773
	[Register("java/util/HashSet", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public class HashSet : AbstractSet, ISerializable, IJavaObject, IDisposable, IJavaPeerable, Java.Lang.ICloneable, ISet, ICollection, IIterable
	{
		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001EF5 RID: 7925 RVA: 0x00054773 File Offset: 0x00052973
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return HashSet._members;
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001EF6 RID: 7926 RVA: 0x0005477C File Offset: 0x0005297C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return HashSet._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06001EF7 RID: 7927 RVA: 0x000547A0 File Offset: 0x000529A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return HashSet._members.ManagedPeerType;
			}
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x00053ADF File Offset: 0x00051CDF
		protected HashSet(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x000547AC File Offset: 0x000529AC
		private static Delegate GetIteratorHandler()
		{
			if (HashSet.cb_iterator == null)
			{
				HashSet.cb_iterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(HashSet.n_Iterator));
			}
			return HashSet.cb_iterator;
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x000547D0 File Offset: 0x000529D0
		private static IntPtr n_Iterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<HashSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Iterator());
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x000547E4 File Offset: 0x000529E4
		public override IIterator Iterator()
		{
			return Java.Lang.Object.GetObject<IIterator>(HashSet._members.InstanceMethods.InvokeVirtualObjectMethod("iterator.()Ljava/util/Iterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x00054816 File Offset: 0x00052A16
		private static Delegate GetSizeHandler()
		{
			if (HashSet.cb_size == null)
			{
				HashSet.cb_size = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(HashSet.n_Size));
			}
			return HashSet.cb_size;
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x0005483A File Offset: 0x00052A3A
		private static int n_Size(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<HashSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size();
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x00054849 File Offset: 0x00052A49
		public override int Size()
		{
			return HashSet._members.InstanceMethods.InvokeVirtualInt32Method("size.()I", this, null);
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x00054862 File Offset: 0x00052A62
		private static Delegate GetSpliteratorHandler()
		{
			if (HashSet.cb_spliterator == null)
			{
				HashSet.cb_spliterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(HashSet.n_Spliterator));
			}
			return HashSet.cb_spliterator;
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x00054886 File Offset: 0x00052A86
		private static IntPtr n_Spliterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<HashSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Spliterator());
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x0005489C File Offset: 0x00052A9C
		public virtual ISpliterator Spliterator()
		{
			return Java.Lang.Object.GetObject<ISpliterator>(HashSet._members.InstanceMethods.InvokeVirtualObjectMethod("spliterator.()Ljava/util/Spliterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000CAF RID: 3247
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/HashSet", typeof(HashSet));

		// Token: 0x04000CB0 RID: 3248
		private static Delegate cb_iterator;

		// Token: 0x04000CB1 RID: 3249
		private static Delegate cb_size;

		// Token: 0x04000CB2 RID: 3250
		private static Delegate cb_spliterator;
	}
}
