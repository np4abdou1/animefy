using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Util
{
	// Token: 0x0200004A RID: 74
	[Register("com/bumptech/glide/util/FixedPreloadSizeProvider", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public class FixedPreloadSizeProvider : Java.Lang.Object, ListPreloader.IPreloadSizeProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000341 RID: 833 RVA: 0x0000B1B0 File Offset: 0x000093B0
		internal static IntPtr class_ref
		{
			get
			{
				return FixedPreloadSizeProvider._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000342 RID: 834 RVA: 0x0000B1D4 File Offset: 0x000093D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FixedPreloadSizeProvider._members;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000343 RID: 835 RVA: 0x0000B1DC File Offset: 0x000093DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FixedPreloadSizeProvider._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000344 RID: 836 RVA: 0x0000B200 File Offset: 0x00009400
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FixedPreloadSizeProvider._members.ManagedPeerType;
			}
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000B20C File Offset: 0x0000940C
		protected FixedPreloadSizeProvider(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0000B218 File Offset: 0x00009418
		[Register(".ctor", "(II)V", "")]
		public unsafe FixedPreloadSizeProvider(int width, int height) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(width);
			ptr[1] = new JniArgumentValue(height);
			base.SetHandle(FixedPreloadSizeProvider._members.InstanceMethods.StartCreateInstance("(II)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			FixedPreloadSizeProvider._members.InstanceMethods.FinishCreateInstance("(II)V", this, ptr);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000B2AF File Offset: 0x000094AF
		private static Delegate GetGetPreloadSize_Ljava_lang_Object_IIHandler()
		{
			if (FixedPreloadSizeProvider.cb_getPreloadSize_Ljava_lang_Object_II == null)
			{
				FixedPreloadSizeProvider.cb_getPreloadSize_Ljava_lang_Object_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_L(FixedPreloadSizeProvider.n_GetPreloadSize_Ljava_lang_Object_II));
			}
			return FixedPreloadSizeProvider.cb_getPreloadSize_Ljava_lang_Object_II;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000B2D4 File Offset: 0x000094D4
		private static IntPtr n_GetPreloadSize_Ljava_lang_Object_II(IntPtr jnienv, IntPtr native__this, IntPtr native_item, int adapterPosition, int itemPosition)
		{
			FixedPreloadSizeProvider @object = Java.Lang.Object.GetObject<FixedPreloadSizeProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_item, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray(@object.GetPreloadSize(object2, adapterPosition, itemPosition));
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000B300 File Offset: 0x00009500
		[Register("getPreloadSize", "(Ljava/lang/Object;II)[I", "GetGetPreloadSize_Ljava_lang_Object_IIHandler")]
		public unsafe virtual int[] GetPreloadSize(Java.Lang.Object item, int adapterPosition, int itemPosition)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(item);
			int[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(adapterPosition);
				ptr[2] = new JniArgumentValue(itemPosition);
				result = (int[])JNIEnv.GetArray(FixedPreloadSizeProvider._members.InstanceMethods.InvokeVirtualObjectMethod("getPreloadSize.(Ljava/lang/Object;II)[I", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(int));
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(item);
			}
			return result;
		}

		// Token: 0x040000AD RID: 173
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/util/FixedPreloadSizeProvider", typeof(FixedPreloadSizeProvider));

		// Token: 0x040000AE RID: 174
		private static Delegate cb_getPreloadSize_Ljava_lang_Object_II;
	}
}
