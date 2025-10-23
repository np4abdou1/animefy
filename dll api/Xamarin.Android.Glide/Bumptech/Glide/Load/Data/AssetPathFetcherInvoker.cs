using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content.Res;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Data
{
	// Token: 0x0200018C RID: 396
	[Register("com/bumptech/glide/load/data/AssetPathFetcher", DoNotGenerateAcw = true)]
	internal class AssetPathFetcherInvoker : AssetPathFetcher, IDataFetcher, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001417 RID: 5143 RVA: 0x000404B8 File Offset: 0x0003E6B8
		public AssetPathFetcherInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x000404C2 File Offset: 0x0003E6C2
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AssetPathFetcherInvoker._members;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x000404C9 File Offset: 0x0003E6C9
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AssetPathFetcherInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x000404D8 File Offset: 0x0003E6D8
		[Register("close", "(Ljava/lang/Object;)V", "GetClose_Ljava_lang_Object_Handler")]
		protected unsafe override void Close(Java.Lang.Object p0)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				AssetPathFetcherInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("close.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x0004053C File Offset: 0x0003E73C
		[Register("loadResource", "(Landroid/content/res/AssetManager;Ljava/lang/String;)Ljava/lang/Object;", "GetLoadResource_Landroid_content_res_AssetManager_Ljava_lang_String_Handler")]
		protected unsafe override Java.Lang.Object LoadResource(AssetManager p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p1);
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(AssetPathFetcherInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("loadResource.(Landroid/content/res/AssetManager;Ljava/lang/String;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x000405D0 File Offset: 0x0003E7D0
		public override Class DataClass
		{
			[Register("getDataClass", "()Ljava/lang/Class;", "GetGetDataClassHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(AssetPathFetcherInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getDataClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040004BF RID: 1215
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/data/AssetPathFetcher", typeof(AssetPathFetcherInvoker));
	}
}
