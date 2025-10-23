using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Net;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Data
{
	// Token: 0x0200019B RID: 411
	[Register("com/bumptech/glide/load/data/LocalUriFetcher", DoNotGenerateAcw = true)]
	internal class LocalUriFetcherInvoker : LocalUriFetcher, IDataFetcher, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060014C5 RID: 5317 RVA: 0x00041F18 File Offset: 0x00040118
		public LocalUriFetcherInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x00041F22 File Offset: 0x00040122
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LocalUriFetcherInvoker._members;
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x060014C7 RID: 5319 RVA: 0x00041F29 File Offset: 0x00040129
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LocalUriFetcherInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x00041F38 File Offset: 0x00040138
		[Register("close", "(Ljava/lang/Object;)V", "GetClose_Ljava_lang_Object_Handler")]
		protected unsafe override void Close(Java.Lang.Object p0)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				LocalUriFetcherInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("close.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x00041F9C File Offset: 0x0004019C
		[Register("loadResource", "(Landroid/net/Uri;Landroid/content/ContentResolver;)Ljava/lang/Object;", "GetLoadResource_Landroid_net_Uri_Landroid_content_ContentResolver_Handler")]
		protected unsafe override Java.Lang.Object LoadResource(Android.Net.Uri p0, ContentResolver p1)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(LocalUriFetcherInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("loadResource.(Landroid/net/Uri;Landroid/content/ContentResolver;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x060014CA RID: 5322 RVA: 0x00042038 File Offset: 0x00040238
		public override Class DataClass
		{
			[Register("getDataClass", "()Ljava/lang/Class;", "GetGetDataClassHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(LocalUriFetcherInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getDataClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040004F1 RID: 1265
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/data/LocalUriFetcher", typeof(LocalUriFetcherInvoker));
	}
}
