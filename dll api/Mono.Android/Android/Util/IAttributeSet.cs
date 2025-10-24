using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Util
{
	// Token: 0x02000192 RID: 402
	[Register("android/util/AttributeSet", "", "Android.Util.IAttributeSetInvoker")]
	public interface IAttributeSet : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000DDA RID: 3546
		int AttributeCount { get; }

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000DDB RID: 3547
		string ClassAttribute { get; }

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000DDC RID: 3548
		string IdAttribute { get; }

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000DDD RID: 3549
		string PositionDescription { get; }

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000DDE RID: 3550
		int StyleAttribute { get; }

		// Token: 0x06000DDF RID: 3551
		bool GetAttributeBooleanValue(int index, bool defaultValue);

		// Token: 0x06000DE0 RID: 3552
		bool GetAttributeBooleanValue(string @namespace, string attribute, bool defaultValue);

		// Token: 0x06000DE1 RID: 3553
		float GetAttributeFloatValue(int index, float defaultValue);

		// Token: 0x06000DE2 RID: 3554
		float GetAttributeFloatValue(string @namespace, string attribute, float defaultValue);

		// Token: 0x06000DE3 RID: 3555
		int GetAttributeIntValue(int index, int defaultValue);

		// Token: 0x06000DE4 RID: 3556
		int GetAttributeIntValue(string @namespace, string attribute, int defaultValue);

		// Token: 0x06000DE5 RID: 3557
		int GetAttributeListValue(int index, string[] options, int defaultValue);

		// Token: 0x06000DE6 RID: 3558
		int GetAttributeListValue(string @namespace, string attribute, string[] options, int defaultValue);

		// Token: 0x06000DE7 RID: 3559
		string GetAttributeName(int index);

		// Token: 0x06000DE8 RID: 3560
		int GetAttributeNameResource(int index);

		// Token: 0x06000DE9 RID: 3561
		int GetAttributeResourceValue(int index, int defaultValue);

		// Token: 0x06000DEA RID: 3562
		int GetAttributeResourceValue(string @namespace, string attribute, int defaultValue);

		// Token: 0x06000DEB RID: 3563
		int GetAttributeUnsignedIntValue(int index, int defaultValue);

		// Token: 0x06000DEC RID: 3564
		int GetAttributeUnsignedIntValue(string @namespace, string attribute, int defaultValue);

		// Token: 0x06000DED RID: 3565
		string GetAttributeValue(int index);

		// Token: 0x06000DEE RID: 3566
		string GetAttributeValue(string @namespace, string name);

		// Token: 0x06000DEF RID: 3567
		int GetIdAttributeResourceValue(int defaultValue);

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00023751 File Offset: 0x00021951
		private static Delegate GetGetAttributeNamespace_IHandler()
		{
			if (IAttributeSet.cb_getAttributeNamespace_I == null)
			{
				IAttributeSet.cb_getAttributeNamespace_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IAttributeSet.n_GetAttributeNamespace_I));
			}
			return IAttributeSet.cb_getAttributeNamespace_I;
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00023775 File Offset: 0x00021975
		private static IntPtr n_GetAttributeNamespace_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IAttributeSet>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetAttributeNamespace(index));
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x0002378C File Offset: 0x0002198C
		unsafe string GetAttributeNamespace(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return JNIEnv.GetString(IAttributeSet._members.InstanceMethods.InvokeVirtualObjectMethod("getAttributeNamespace.(I)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000673 RID: 1651
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/util/AttributeSet", typeof(IAttributeSet), true);

		// Token: 0x04000674 RID: 1652
		private static Delegate cb_getAttributeNamespace_I;
	}
}
