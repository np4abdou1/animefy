using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x02000303 RID: 771
	[Register("java/util/Date", DoNotGenerateAcw = true)]
	public class Date : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable, Java.Lang.ICloneable, Java.Lang.IComparable
	{
		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001EC3 RID: 7875 RVA: 0x00053B62 File Offset: 0x00051D62
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Date._members;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x00053B6C File Offset: 0x00051D6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Date._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001EC5 RID: 7877 RVA: 0x00053B90 File Offset: 0x00051D90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Date._members.ManagedPeerType;
			}
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Date(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x00053B9C File Offset: 0x00051D9C
		private static Delegate GetCompareTo_Ljava_util_Date_Handler()
		{
			if (Date.cb_compareTo_Ljava_util_Date_ == null)
			{
				Date.cb_compareTo_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(Date.n_CompareTo_Ljava_util_Date_));
			}
			return Date.cb_compareTo_Ljava_util_Date_;
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x00053BC0 File Offset: 0x00051DC0
		private static int n_CompareTo_Ljava_util_Date_(IntPtr jnienv, IntPtr native__this, IntPtr native_anotherDate)
		{
			Date @object = Java.Lang.Object.GetObject<Date>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Date object2 = Java.Lang.Object.GetObject<Date>(native_anotherDate, JniHandleOwnership.DoNotTransfer);
			return @object.CompareTo(object2);
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x00053BE4 File Offset: 0x00051DE4
		public unsafe virtual int CompareTo(Date anotherDate)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((anotherDate == null) ? IntPtr.Zero : anotherDate.Handle);
				result = Date._members.InstanceMethods.InvokeVirtualInt32Method("compareTo.(Ljava/util/Date;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(anotherDate);
			}
			return result;
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x00053C4C File Offset: 0x00051E4C
		int Java.Lang.IComparable.CompareTo(Java.Lang.Object o)
		{
			return this.CompareTo(o.JavaCast<Date>());
		}

		// Token: 0x04000CA0 RID: 3232
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/Date", typeof(Date));

		// Token: 0x04000CA1 RID: 3233
		private static Delegate cb_compareTo_Ljava_util_Date_;
	}
}
