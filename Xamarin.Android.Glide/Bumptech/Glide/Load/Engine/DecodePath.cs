using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using AndroidX.Core.Util;
using Bumptech.Glide.Load.Resource.Transcode;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine
{
	// Token: 0x0200014F RID: 335
	[Register("com/bumptech/glide/load/engine/DecodePath", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"DataType",
		"ResourceType",
		"Transcode"
	})]
	public class DecodePath : Java.Lang.Object
	{
		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x060010E5 RID: 4325 RVA: 0x00036A30 File Offset: 0x00034C30
		internal static IntPtr class_ref
		{
			get
			{
				return DecodePath._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x00036A54 File Offset: 0x00034C54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DecodePath._members;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x00036A5C File Offset: 0x00034C5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DecodePath._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x00036A80 File Offset: 0x00034C80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DecodePath._members.ManagedPeerType;
			}
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x00036A8C File Offset: 0x00034C8C
		protected DecodePath(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x00036A98 File Offset: 0x00034C98
		[Register(".ctor", "(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;Ljava/util/List;Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;Landroidx/core/util/Pools$Pool;)V", "")]
		public unsafe DecodePath(Class dataClass, Class resourceClass, Class transcodeClass, IList decoders, IResourceTranscoder transcoder, Pools.IPool listPool) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JavaList.ToLocalJniHandle(decoders);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				ptr[1] = new JniArgumentValue((resourceClass == null) ? IntPtr.Zero : resourceClass.Handle);
				ptr[2] = new JniArgumentValue((transcodeClass == null) ? IntPtr.Zero : transcodeClass.Handle);
				ptr[3] = new JniArgumentValue(intPtr);
				ptr[4] = new JniArgumentValue((transcoder == null) ? IntPtr.Zero : ((Java.Lang.Object)transcoder).Handle);
				ptr[5] = new JniArgumentValue((listPool == null) ? IntPtr.Zero : ((Java.Lang.Object)listPool).Handle);
				base.SetHandle(DecodePath._members.InstanceMethods.StartCreateInstance("(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;Ljava/util/List;Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;Landroidx/core/util/Pools$Pool;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DecodePath._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/Class;Ljava/lang/Class;Ljava/lang/Class;Ljava/util/List;Lcom/bumptech/glide/load/resource/transcode/ResourceTranscoder;Landroidx/core/util/Pools$Pool;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(dataClass);
				GC.KeepAlive(resourceClass);
				GC.KeepAlive(transcodeClass);
				GC.KeepAlive(decoders);
				GC.KeepAlive(transcoder);
				GC.KeepAlive(listPool);
			}
		}

		// Token: 0x040003E2 RID: 994
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/DecodePath", typeof(DecodePath));
	}
}
