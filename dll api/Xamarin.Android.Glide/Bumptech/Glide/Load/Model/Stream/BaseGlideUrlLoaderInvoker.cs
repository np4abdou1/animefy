using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model.Stream
{
	// Token: 0x02000149 RID: 329
	[Register("com/bumptech/glide/load/model/stream/BaseGlideUrlLoader", DoNotGenerateAcw = true)]
	internal class BaseGlideUrlLoaderInvoker : BaseGlideUrlLoader, IModelLoader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600109A RID: 4250 RVA: 0x00035A2E File Offset: 0x00033C2E
		public BaseGlideUrlLoaderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x00035A38 File Offset: 0x00033C38
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BaseGlideUrlLoaderInvoker._members;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x0600109C RID: 4252 RVA: 0x00035A3F File Offset: 0x00033C3F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BaseGlideUrlLoaderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x00035A4C File Offset: 0x00033C4C
		[Register("getUrl", "(Ljava/lang/Object;IILcom/bumptech/glide/load/Options;)Ljava/lang/String;", "GetGetUrl_Ljava_lang_Object_IILcom_bumptech_glide_load_Options_Handler")]
		protected unsafe override string GetUrl(Java.Lang.Object p0, int p1, int p2, Options p3)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(p1);
				ptr[2] = new JniArgumentValue(p2);
				ptr[3] = new JniArgumentValue((p3 == null) ? IntPtr.Zero : p3.Handle);
				@string = JNIEnv.GetString(BaseGlideUrlLoaderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getUrl.(Ljava/lang/Object;IILcom/bumptech/glide/load/Options;)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p3);
			}
			return @string;
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x00035B14 File Offset: 0x00033D14
		[Register("handles", "(Ljava/lang/Object;)Z", "GetHandles_Ljava_lang_Object_Handler")]
		public unsafe override bool Handles(Java.Lang.Object model)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(model);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = BaseGlideUrlLoaderInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("handles.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(model);
			}
			return result;
		}

		// Token: 0x040003D4 RID: 980
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/stream/BaseGlideUrlLoader", typeof(BaseGlideUrlLoaderInvoker));
	}
}
