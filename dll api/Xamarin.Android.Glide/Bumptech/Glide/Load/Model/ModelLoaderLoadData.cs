using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Bumptech.Glide.Load.Data;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x0200013A RID: 314
	[Register("com/bumptech/glide/load/model/ModelLoader$LoadData", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"Data"
	})]
	public class ModelLoaderLoadData : Java.Lang.Object
	{
		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x00033070 File Offset: 0x00031270
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x000330A0 File Offset: 0x000312A0
		[Register("alternateKeys")]
		public IList AlternateKeys
		{
			get
			{
				return JavaList.FromJniHandle(ModelLoaderLoadData._members.InstanceFields.GetObjectValue("alternateKeys.Ljava/util/List;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JavaList.ToLocalJniHandle(value);
				try
				{
					ModelLoaderLoadData._members.InstanceFields.SetValue("alternateKeys.Ljava/util/List;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x000330EC File Offset: 0x000312EC
		// (set) Token: 0x06000FE1 RID: 4065 RVA: 0x0003311C File Offset: 0x0003131C
		[Register("fetcher")]
		public IDataFetcher Fetcher
		{
			get
			{
				return Java.Lang.Object.GetObject<IDataFetcher>(ModelLoaderLoadData._members.InstanceFields.GetObjectValue("fetcher.Lcom/bumptech/glide/load/data/DataFetcher;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					ModelLoaderLoadData._members.InstanceFields.SetValue("fetcher.Lcom/bumptech/glide/load/data/DataFetcher;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x00033168 File Offset: 0x00031368
		// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x00033198 File Offset: 0x00031398
		[Register("sourceKey")]
		public IKey SourceKey
		{
			get
			{
				return Java.Lang.Object.GetObject<IKey>(ModelLoaderLoadData._members.InstanceFields.GetObjectValue("sourceKey.Lcom/bumptech/glide/load/Key;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					ModelLoaderLoadData._members.InstanceFields.SetValue("sourceKey.Lcom/bumptech/glide/load/Key;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x000331E4 File Offset: 0x000313E4
		internal static IntPtr class_ref
		{
			get
			{
				return ModelLoaderLoadData._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x00033208 File Offset: 0x00031408
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ModelLoaderLoadData._members;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x00033210 File Offset: 0x00031410
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ModelLoaderLoadData._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x00033234 File Offset: 0x00031434
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ModelLoaderLoadData._members.ManagedPeerType;
			}
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00033240 File Offset: 0x00031440
		protected ModelLoaderLoadData(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x0003324C File Offset: 0x0003144C
		[Register(".ctor", "(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/data/DataFetcher;)V", "")]
		public unsafe ModelLoaderLoadData(IKey sourceKey, IDataFetcher fetcher) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((sourceKey == null) ? IntPtr.Zero : ((Java.Lang.Object)sourceKey).Handle);
				ptr[1] = new JniArgumentValue((fetcher == null) ? IntPtr.Zero : ((Java.Lang.Object)fetcher).Handle);
				base.SetHandle(ModelLoaderLoadData._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/data/DataFetcher;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ModelLoaderLoadData._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/Key;Lcom/bumptech/glide/load/data/DataFetcher;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(sourceKey);
				GC.KeepAlive(fetcher);
			}
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x0003332C File Offset: 0x0003152C
		[Register(".ctor", "(Lcom/bumptech/glide/load/Key;Ljava/util/List;Lcom/bumptech/glide/load/data/DataFetcher;)V", "")]
		public unsafe ModelLoaderLoadData(IKey sourceKey, IList<IKey> alternateKeys, IDataFetcher fetcher) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JavaList<IKey>.ToLocalJniHandle(alternateKeys);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((sourceKey == null) ? IntPtr.Zero : ((Java.Lang.Object)sourceKey).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((fetcher == null) ? IntPtr.Zero : ((Java.Lang.Object)fetcher).Handle);
				base.SetHandle(ModelLoaderLoadData._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/load/Key;Ljava/util/List;Lcom/bumptech/glide/load/data/DataFetcher;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ModelLoaderLoadData._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/load/Key;Ljava/util/List;Lcom/bumptech/glide/load/data/DataFetcher;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(sourceKey);
				GC.KeepAlive(alternateKeys);
				GC.KeepAlive(fetcher);
			}
		}

		// Token: 0x040003AA RID: 938
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/ModelLoader$LoadData", typeof(ModelLoaderLoadData));
	}
}
