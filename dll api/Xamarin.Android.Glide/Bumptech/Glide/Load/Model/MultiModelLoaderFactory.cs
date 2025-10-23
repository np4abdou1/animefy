using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using AndroidX.Core.Util;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Model
{
	// Token: 0x02000143 RID: 323
	[Register("com/bumptech/glide/load/model/MultiModelLoaderFactory", DoNotGenerateAcw = true)]
	public class MultiModelLoaderFactory : Java.Lang.Object
	{
		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x0600104D RID: 4173 RVA: 0x00034824 File Offset: 0x00032A24
		internal static IntPtr class_ref
		{
			get
			{
				return MultiModelLoaderFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x0600104E RID: 4174 RVA: 0x00034848 File Offset: 0x00032A48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MultiModelLoaderFactory._members;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x0600104F RID: 4175 RVA: 0x00034850 File Offset: 0x00032A50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MultiModelLoaderFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x00034874 File Offset: 0x00032A74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MultiModelLoaderFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00034880 File Offset: 0x00032A80
		protected MultiModelLoaderFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x0003488C File Offset: 0x00032A8C
		[Register(".ctor", "(Landroidx/core/util/Pools$Pool;)V", "")]
		public unsafe MultiModelLoaderFactory(Pools.IPool throwableListPool) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((throwableListPool == null) ? IntPtr.Zero : ((Java.Lang.Object)throwableListPool).Handle);
				base.SetHandle(MultiModelLoaderFactory._members.InstanceMethods.StartCreateInstance("(Landroidx/core/util/Pools$Pool;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MultiModelLoaderFactory._members.InstanceMethods.FinishCreateInstance("(Landroidx/core/util/Pools$Pool;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(throwableListPool);
			}
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x00034940 File Offset: 0x00032B40
		private static Delegate GetBuild_Ljava_lang_Class_Ljava_lang_Class_Handler()
		{
			if (MultiModelLoaderFactory.cb_build_Ljava_lang_Class_Ljava_lang_Class_ == null)
			{
				MultiModelLoaderFactory.cb_build_Ljava_lang_Class_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(MultiModelLoaderFactory.n_Build_Ljava_lang_Class_Ljava_lang_Class_));
			}
			return MultiModelLoaderFactory.cb_build_Ljava_lang_Class_Ljava_lang_Class_;
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x00034964 File Offset: 0x00032B64
		private static IntPtr n_Build_Ljava_lang_Class_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_modelClass, IntPtr native_dataClass)
		{
			MultiModelLoaderFactory @object = Java.Lang.Object.GetObject<MultiModelLoaderFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_modelClass, JniHandleOwnership.DoNotTransfer);
			Class object3 = Java.Lang.Object.GetObject<Class>(native_dataClass, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Build(object2, object3));
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x00034998 File Offset: 0x00032B98
		[Register("build", "(Ljava/lang/Class;Ljava/lang/Class;)Lcom/bumptech/glide/load/model/ModelLoader;", "GetBuild_Ljava_lang_Class_Ljava_lang_Class_Handler")]
		[JavaTypeParameters(new string[]
		{
			"Model",
			"Data"
		})]
		public unsafe virtual IModelLoader Build(Class modelClass, Class dataClass)
		{
			IModelLoader @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((modelClass == null) ? IntPtr.Zero : modelClass.Handle);
				ptr[1] = new JniArgumentValue((dataClass == null) ? IntPtr.Zero : dataClass.Handle);
				@object = Java.Lang.Object.GetObject<IModelLoader>(MultiModelLoaderFactory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Ljava/lang/Class;Ljava/lang/Class;)Lcom/bumptech/glide/load/model/ModelLoader;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(modelClass);
				GC.KeepAlive(dataClass);
			}
			return @object;
		}

		// Token: 0x040003C5 RID: 965
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/model/MultiModelLoaderFactory", typeof(MultiModelLoaderFactory));

		// Token: 0x040003C6 RID: 966
		private static Delegate cb_build_Ljava_lang_Class_Ljava_lang_Class_;
	}
}
