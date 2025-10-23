using System;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang.Reflect
{
	// Token: 0x02000407 RID: 1031
	[Register("java/lang/reflect/Type", "", "Java.Lang.Reflect.ITypeInvoker")]
	public interface IType : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002D64 RID: 11620 RVA: 0x0007CEB8 File Offset: 0x0007B0B8
		private static Delegate GetGetTypeNameHandler()
		{
			if (IType.cb_getTypeName == null)
			{
				IType.cb_getTypeName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IType.n_GetTypeName));
			}
			return IType.cb_getTypeName;
		}

		// Token: 0x06002D65 RID: 11621 RVA: 0x0007CEDC File Offset: 0x0007B0DC
		private static IntPtr n_GetTypeName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Object.GetObject<IType>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TypeName);
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06002D66 RID: 11622 RVA: 0x0007CEF0 File Offset: 0x0007B0F0
		string TypeName
		{
			get
			{
				return JNIEnv.GetString(IType._members.InstanceMethods.InvokeVirtualObjectMethod("getTypeName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040011E8 RID: 4584
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/reflect/Type", typeof(IType), true);

		// Token: 0x040011E9 RID: 4585
		private static Delegate cb_getTypeName;
	}
}
