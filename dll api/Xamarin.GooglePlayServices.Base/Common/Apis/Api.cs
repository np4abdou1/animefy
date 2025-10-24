using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Gms.Common.Internal;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Android.Gms.Common.Apis
{
	// Token: 0x0200004B RID: 75
	[Register("com/google/android/gms/common/api/Api", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"O extends com.google.android.gms.common.api.Api.ApiOptions"
	})]
	public sealed class Api : Java.Lang.Object
	{
		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600033D RID: 829 RVA: 0x0000A378 File Offset: 0x00008578
		internal static IntPtr class_ref
		{
			get
			{
				return Api._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0000A39C File Offset: 0x0000859C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Api._members;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600033F RID: 831 RVA: 0x0000A3A4 File Offset: 0x000085A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Api._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0000A3C8 File Offset: 0x000085C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Api._members.ManagedPeerType;
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00003280 File Offset: 0x00001480
		internal Api(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000A3D4 File Offset: 0x000085D4
		[Register(".ctor", "(Ljava/lang/String;Lcom/google/android/gms/common/api/Api$AbstractClientBuilder;Lcom/google/android/gms/common/api/Api$ClientKey;)V", "")]
		public unsafe Api(string name, Api.AbstractClientBuilder clientBuilder, Api.ClientKey clientKey) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(name);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((clientBuilder == null) ? IntPtr.Zero : clientBuilder.Handle);
				ptr[2] = new JniArgumentValue((clientKey == null) ? IntPtr.Zero : clientKey.Handle);
				base.SetHandle(Api._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Lcom/google/android/gms/common/api/Api$AbstractClientBuilder;Lcom/google/android/gms/common/api/Api$ClientKey;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				Api._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Lcom/google/android/gms/common/api/Api$AbstractClientBuilder;Lcom/google/android/gms/common/api/Api$ClientKey;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(clientBuilder);
				GC.KeepAlive(clientKey);
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000A4CC File Offset: 0x000086CC
		[Register("zaa", "()Lcom/google/android/gms/common/api/Api$AbstractClientBuilder;", "")]
		public Api.AbstractClientBuilder Zaa()
		{
			return Java.Lang.Object.GetObject<Api.AbstractClientBuilder>(Api._members.InstanceMethods.InvokeNonvirtualObjectMethod("zaa.()Lcom/google/android/gms/common/api/Api$AbstractClientBuilder;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000A500 File Offset: 0x00008700
		[Register("zab", "()Lcom/google/android/gms/common/api/Api$AnyClientKey;", "")]
		public Api.AnyClientKey Zab()
		{
			return Java.Lang.Object.GetObject<Api.AnyClientKey>(Api._members.InstanceMethods.InvokeNonvirtualObjectMethod("zab.()Lcom/google/android/gms/common/api/Api$AnyClientKey;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000A534 File Offset: 0x00008734
		[Register("zac", "()Lcom/google/android/gms/common/api/Api$BaseClientBuilder;", "")]
		public Api.BaseClientBuilder Zac()
		{
			return Java.Lang.Object.GetObject<Api.BaseClientBuilder>(Api._members.InstanceMethods.InvokeNonvirtualObjectMethod("zac.()Lcom/google/android/gms/common/api/Api$BaseClientBuilder;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0000A568 File Offset: 0x00008768
		[Register("zad", "()Ljava/lang/String;", "")]
		public string Zad()
		{
			return JNIEnv.GetString(Api._members.InstanceMethods.InvokeNonvirtualObjectMethod("zad.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040000B4 RID: 180
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/Api", typeof(Api));

		// Token: 0x0200004C RID: 76
		[Register("com/google/android/gms/common/api/Api$AbstractClientBuilder", DoNotGenerateAcw = true)]
		[JavaTypeParameters(new string[]
		{
			"T extends com.google.android.gms.common.api.Api.Client",
			"O"
		})]
		public abstract class AbstractClientBuilder : Api.BaseClientBuilder
		{
			// Token: 0x170000D0 RID: 208
			// (get) Token: 0x06000348 RID: 840 RVA: 0x0000A5B8 File Offset: 0x000087B8
			internal new static IntPtr class_ref
			{
				get
				{
					return Api.AbstractClientBuilder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000D1 RID: 209
			// (get) Token: 0x06000349 RID: 841 RVA: 0x0000A5DC File Offset: 0x000087DC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Api.AbstractClientBuilder._members;
				}
			}

			// Token: 0x170000D2 RID: 210
			// (get) Token: 0x0600034A RID: 842 RVA: 0x0000A5E4 File Offset: 0x000087E4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Api.AbstractClientBuilder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000D3 RID: 211
			// (get) Token: 0x0600034B RID: 843 RVA: 0x0000A608 File Offset: 0x00008808
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Api.AbstractClientBuilder._members.ManagedPeerType;
				}
			}

			// Token: 0x0600034C RID: 844 RVA: 0x0000A614 File Offset: 0x00008814
			protected AbstractClientBuilder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600034D RID: 845 RVA: 0x0000A620 File Offset: 0x00008820
			[Register(".ctor", "()V", "")]
			public AbstractClientBuilder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(Api.AbstractClientBuilder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				Api.AbstractClientBuilder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x040000B5 RID: 181
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/Api$AbstractClientBuilder", typeof(Api.AbstractClientBuilder));
		}

		// Token: 0x0200004D RID: 77
		[Register("com/google/android/gms/common/api/Api$AbstractClientBuilder", DoNotGenerateAcw = true)]
		internal class AbstractClientBuilderInvoker : Api.AbstractClientBuilder
		{
			// Token: 0x0600034F RID: 847 RVA: 0x0000A6A9 File Offset: 0x000088A9
			public AbstractClientBuilderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x170000D4 RID: 212
			// (get) Token: 0x06000350 RID: 848 RVA: 0x0000A6B3 File Offset: 0x000088B3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Api.AbstractClientBuilderInvoker._members;
				}
			}

			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x06000351 RID: 849 RVA: 0x0000A6BA File Offset: 0x000088BA
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Api.AbstractClientBuilderInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x040000B6 RID: 182
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/Api$AbstractClientBuilder", typeof(Api.AbstractClientBuilderInvoker));
		}

		// Token: 0x0200004E RID: 78
		[Register("com/google/android/gms/common/api/Api$AnyClient", "", "Android.Gms.Common.Apis.Api/IAnyClientInvoker")]
		public interface IAnyClient : IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x0200004F RID: 79
		[Register("com/google/android/gms/common/api/Api$AnyClient", DoNotGenerateAcw = true)]
		internal class IAnyClientInvoker : Java.Lang.Object, Api.IAnyClient, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x06000353 RID: 851 RVA: 0x0000A6E4 File Offset: 0x000088E4
			private static IntPtr java_class_ref
			{
				get
				{
					return Api.IAnyClientInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000D7 RID: 215
			// (get) Token: 0x06000354 RID: 852 RVA: 0x0000A708 File Offset: 0x00008908
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Api.IAnyClientInvoker._members;
				}
			}

			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x06000355 RID: 853 RVA: 0x0000A70F File Offset: 0x0000890F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000D9 RID: 217
			// (get) Token: 0x06000356 RID: 854 RVA: 0x0000A717 File Offset: 0x00008917
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Api.IAnyClientInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000357 RID: 855 RVA: 0x0000A723 File Offset: 0x00008923
			public static Api.IAnyClient GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<Api.IAnyClient>(handle, transfer);
			}

			// Token: 0x06000358 RID: 856 RVA: 0x0000A72C File Offset: 0x0000892C
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, Api.IAnyClientInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.common.api.Api.AnyClient'.");
				}
				return handle;
			}

			// Token: 0x06000359 RID: 857 RVA: 0x0000A757 File Offset: 0x00008957
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600035A RID: 858 RVA: 0x0000A788 File Offset: 0x00008988
			public IAnyClientInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Api.IAnyClientInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x040000B7 RID: 183
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/Api$AnyClient", typeof(Api.IAnyClientInvoker));

			// Token: 0x040000B8 RID: 184
			private IntPtr class_ref;
		}

		// Token: 0x02000050 RID: 80
		[Register("com/google/android/gms/common/api/Api$AnyClientKey", DoNotGenerateAcw = true)]
		[JavaTypeParameters(new string[]
		{
			"C extends com.google.android.gms.common.api.Api.AnyClient"
		})]
		public class AnyClientKey : Java.Lang.Object
		{
			// Token: 0x170000DA RID: 218
			// (get) Token: 0x0600035C RID: 860 RVA: 0x0000A7DC File Offset: 0x000089DC
			internal static IntPtr class_ref
			{
				get
				{
					return Api.AnyClientKey._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000DB RID: 219
			// (get) Token: 0x0600035D RID: 861 RVA: 0x0000A800 File Offset: 0x00008A00
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Api.AnyClientKey._members;
				}
			}

			// Token: 0x170000DC RID: 220
			// (get) Token: 0x0600035E RID: 862 RVA: 0x0000A808 File Offset: 0x00008A08
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Api.AnyClientKey._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000DD RID: 221
			// (get) Token: 0x0600035F RID: 863 RVA: 0x0000A82C File Offset: 0x00008A2C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Api.AnyClientKey._members.ManagedPeerType;
				}
			}

			// Token: 0x06000360 RID: 864 RVA: 0x00003280 File Offset: 0x00001480
			protected AnyClientKey(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000361 RID: 865 RVA: 0x0000A838 File Offset: 0x00008A38
			[Register(".ctor", "()V", "")]
			public AnyClientKey() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(Api.AnyClientKey._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				Api.AnyClientKey._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x040000B9 RID: 185
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/Api$AnyClientKey", typeof(Api.AnyClientKey));
		}

		// Token: 0x02000051 RID: 81
		[Register("com/google/android/gms/common/api/Api$ApiOptions$HasOptions", "", "Android.Gms.Common.Apis.Api/IApiOptionsHasOptionsInvoker")]
		public interface IApiOptionsHasOptions : Api.IApiOptions, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x02000052 RID: 82
		[Register("com/google/android/gms/common/api/Api$ApiOptions$HasOptions", DoNotGenerateAcw = true)]
		internal class IApiOptionsHasOptionsInvoker : Java.Lang.Object, Api.IApiOptionsHasOptions, Api.IApiOptions, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000DE RID: 222
			// (get) Token: 0x06000363 RID: 867 RVA: 0x0000A8C4 File Offset: 0x00008AC4
			private static IntPtr java_class_ref
			{
				get
				{
					return Api.IApiOptionsHasOptionsInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000DF RID: 223
			// (get) Token: 0x06000364 RID: 868 RVA: 0x0000A8E8 File Offset: 0x00008AE8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Api.IApiOptionsHasOptionsInvoker._members;
				}
			}

			// Token: 0x170000E0 RID: 224
			// (get) Token: 0x06000365 RID: 869 RVA: 0x0000A8EF File Offset: 0x00008AEF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x06000366 RID: 870 RVA: 0x0000A8F7 File Offset: 0x00008AF7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Api.IApiOptionsHasOptionsInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000367 RID: 871 RVA: 0x0000A903 File Offset: 0x00008B03
			public static Api.IApiOptionsHasOptions GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<Api.IApiOptionsHasOptions>(handle, transfer);
			}

			// Token: 0x06000368 RID: 872 RVA: 0x0000A90C File Offset: 0x00008B0C
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, Api.IApiOptionsHasOptionsInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.common.api.Api.ApiOptions.HasOptions'.");
				}
				return handle;
			}

			// Token: 0x06000369 RID: 873 RVA: 0x0000A937 File Offset: 0x00008B37
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600036A RID: 874 RVA: 0x0000A968 File Offset: 0x00008B68
			public IApiOptionsHasOptionsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Api.IApiOptionsHasOptionsInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x040000BA RID: 186
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/Api$ApiOptions$HasOptions", typeof(Api.IApiOptionsHasOptionsInvoker));

			// Token: 0x040000BB RID: 187
			private IntPtr class_ref;
		}

		// Token: 0x02000053 RID: 83
		[Register("com/google/android/gms/common/api/Api$ApiOptions$NotRequiredOptions", "", "Android.Gms.Common.Apis.Api/IApiOptionsNotRequiredOptionsInvoker")]
		public interface IApiOptionsNotRequiredOptions : Api.IApiOptions, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x02000054 RID: 84
		[Register("com/google/android/gms/common/api/Api$ApiOptions$NotRequiredOptions", DoNotGenerateAcw = true)]
		internal class IApiOptionsNotRequiredOptionsInvoker : Java.Lang.Object, Api.IApiOptionsNotRequiredOptions, Api.IApiOptions, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x0600036C RID: 876 RVA: 0x0000A9BC File Offset: 0x00008BBC
			private static IntPtr java_class_ref
			{
				get
				{
					return Api.IApiOptionsNotRequiredOptionsInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x0600036D RID: 877 RVA: 0x0000A9E0 File Offset: 0x00008BE0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Api.IApiOptionsNotRequiredOptionsInvoker._members;
				}
			}

			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x0600036E RID: 878 RVA: 0x0000A9E7 File Offset: 0x00008BE7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000E5 RID: 229
			// (get) Token: 0x0600036F RID: 879 RVA: 0x0000A9EF File Offset: 0x00008BEF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Api.IApiOptionsNotRequiredOptionsInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000370 RID: 880 RVA: 0x0000A9FB File Offset: 0x00008BFB
			public static Api.IApiOptionsNotRequiredOptions GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<Api.IApiOptionsNotRequiredOptions>(handle, transfer);
			}

			// Token: 0x06000371 RID: 881 RVA: 0x0000AA04 File Offset: 0x00008C04
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, Api.IApiOptionsNotRequiredOptionsInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.common.api.Api.ApiOptions.NotRequiredOptions'.");
				}
				return handle;
			}

			// Token: 0x06000372 RID: 882 RVA: 0x0000AA2F File Offset: 0x00008C2F
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000373 RID: 883 RVA: 0x0000AA60 File Offset: 0x00008C60
			public IApiOptionsNotRequiredOptionsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Api.IApiOptionsNotRequiredOptionsInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x040000BC RID: 188
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/Api$ApiOptions$NotRequiredOptions", typeof(Api.IApiOptionsNotRequiredOptionsInvoker));

			// Token: 0x040000BD RID: 189
			private IntPtr class_ref;
		}

		// Token: 0x02000055 RID: 85
		[Register("com/google/android/gms/common/api/Api$ApiOptions$Optional", "", "Android.Gms.Common.Apis.Api/IApiOptionsOptionalInvoker")]
		public interface IApiOptionsOptional : Api.IApiOptionsHasOptions, Api.IApiOptions, IJavaObject, IDisposable, IJavaPeerable, Api.IApiOptionsNotRequiredOptions
		{
		}

		// Token: 0x02000056 RID: 86
		[Register("com/google/android/gms/common/api/Api$ApiOptions$Optional", DoNotGenerateAcw = true)]
		internal class IApiOptionsOptionalInvoker : Java.Lang.Object, Api.IApiOptionsOptional, Api.IApiOptionsHasOptions, Api.IApiOptions, IJavaObject, IDisposable, IJavaPeerable, Api.IApiOptionsNotRequiredOptions
		{
			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x06000375 RID: 885 RVA: 0x0000AAB4 File Offset: 0x00008CB4
			private static IntPtr java_class_ref
			{
				get
				{
					return Api.IApiOptionsOptionalInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x06000376 RID: 886 RVA: 0x0000AAD8 File Offset: 0x00008CD8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Api.IApiOptionsOptionalInvoker._members;
				}
			}

			// Token: 0x170000E8 RID: 232
			// (get) Token: 0x06000377 RID: 887 RVA: 0x0000AADF File Offset: 0x00008CDF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000E9 RID: 233
			// (get) Token: 0x06000378 RID: 888 RVA: 0x0000AAE7 File Offset: 0x00008CE7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Api.IApiOptionsOptionalInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000379 RID: 889 RVA: 0x0000AAF3 File Offset: 0x00008CF3
			public static Api.IApiOptionsOptional GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<Api.IApiOptionsOptional>(handle, transfer);
			}

			// Token: 0x0600037A RID: 890 RVA: 0x0000AAFC File Offset: 0x00008CFC
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, Api.IApiOptionsOptionalInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.common.api.Api.ApiOptions.Optional'.");
				}
				return handle;
			}

			// Token: 0x0600037B RID: 891 RVA: 0x0000AB27 File Offset: 0x00008D27
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600037C RID: 892 RVA: 0x0000AB58 File Offset: 0x00008D58
			public IApiOptionsOptionalInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Api.IApiOptionsOptionalInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x040000BE RID: 190
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/Api$ApiOptions$Optional", typeof(Api.IApiOptionsOptionalInvoker));

			// Token: 0x040000BF RID: 191
			private IntPtr class_ref;
		}

		// Token: 0x02000057 RID: 87
		[Register("com/google/android/gms/common/api/Api$ApiOptions", "", "Android.Gms.Common.Apis.Api/IApiOptionsInvoker")]
		public interface IApiOptions : IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x02000058 RID: 88
		[Register("com/google/android/gms/common/api/Api$ApiOptions", DoNotGenerateAcw = true)]
		internal class IApiOptionsInvoker : Java.Lang.Object, Api.IApiOptions, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000EA RID: 234
			// (get) Token: 0x0600037E RID: 894 RVA: 0x0000ABAC File Offset: 0x00008DAC
			private static IntPtr java_class_ref
			{
				get
				{
					return Api.IApiOptionsInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000EB RID: 235
			// (get) Token: 0x0600037F RID: 895 RVA: 0x0000ABD0 File Offset: 0x00008DD0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Api.IApiOptionsInvoker._members;
				}
			}

			// Token: 0x170000EC RID: 236
			// (get) Token: 0x06000380 RID: 896 RVA: 0x0000ABD7 File Offset: 0x00008DD7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000ED RID: 237
			// (get) Token: 0x06000381 RID: 897 RVA: 0x0000ABDF File Offset: 0x00008DDF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Api.IApiOptionsInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000382 RID: 898 RVA: 0x0000ABEB File Offset: 0x00008DEB
			public static Api.IApiOptions GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<Api.IApiOptions>(handle, transfer);
			}

			// Token: 0x06000383 RID: 899 RVA: 0x0000ABF4 File Offset: 0x00008DF4
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, Api.IApiOptionsInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.common.api.Api.ApiOptions'.");
				}
				return handle;
			}

			// Token: 0x06000384 RID: 900 RVA: 0x0000AC1F File Offset: 0x00008E1F
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000385 RID: 901 RVA: 0x0000AC50 File Offset: 0x00008E50
			public IApiOptionsInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Api.IApiOptionsInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x040000C0 RID: 192
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/Api$ApiOptions", typeof(Api.IApiOptionsInvoker));

			// Token: 0x040000C1 RID: 193
			private IntPtr class_ref;
		}

		// Token: 0x02000059 RID: 89
		[Register("com/google/android/gms/common/api/Api$BaseClientBuilder", DoNotGenerateAcw = true)]
		[JavaTypeParameters(new string[]
		{
			"T extends com.google.android.gms.common.api.Api.AnyClient",
			"O"
		})]
		public abstract class BaseClientBuilder : Java.Lang.Object
		{
			// Token: 0x170000EE RID: 238
			// (get) Token: 0x06000387 RID: 903 RVA: 0x0000ACA4 File Offset: 0x00008EA4
			internal static IntPtr class_ref
			{
				get
				{
					return Api.BaseClientBuilder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x06000388 RID: 904 RVA: 0x0000ACC8 File Offset: 0x00008EC8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Api.BaseClientBuilder._members;
				}
			}

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x06000389 RID: 905 RVA: 0x0000ACD0 File Offset: 0x00008ED0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Api.BaseClientBuilder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x0600038A RID: 906 RVA: 0x0000ACF4 File Offset: 0x00008EF4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Api.BaseClientBuilder._members.ManagedPeerType;
				}
			}

			// Token: 0x0600038B RID: 907 RVA: 0x00003280 File Offset: 0x00001480
			protected BaseClientBuilder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600038C RID: 908 RVA: 0x0000AD00 File Offset: 0x00008F00
			[Register(".ctor", "()V", "")]
			public BaseClientBuilder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(Api.BaseClientBuilder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				Api.BaseClientBuilder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x0600038D RID: 909 RVA: 0x0000AD6E File Offset: 0x00008F6E
			private static Delegate GetGetPriorityHandler()
			{
				if (Api.BaseClientBuilder.cb_getPriority == null)
				{
					Api.BaseClientBuilder.cb_getPriority = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Api.BaseClientBuilder.n_GetPriority));
				}
				return Api.BaseClientBuilder.cb_getPriority;
			}

			// Token: 0x0600038E RID: 910 RVA: 0x0000AD92 File Offset: 0x00008F92
			private static int n_GetPriority(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<Api.BaseClientBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Priority;
			}

			// Token: 0x170000F2 RID: 242
			// (get) Token: 0x0600038F RID: 911 RVA: 0x0000ADA1 File Offset: 0x00008FA1
			public virtual int Priority
			{
				[Register("getPriority", "()I", "GetGetPriorityHandler")]
				get
				{
					return Api.BaseClientBuilder._members.InstanceMethods.InvokeVirtualInt32Method("getPriority.()I", this, null);
				}
			}

			// Token: 0x06000390 RID: 912 RVA: 0x0000ADBA File Offset: 0x00008FBA
			private static Delegate GetGetImpliedScopes_Ljava_lang_Object_Handler()
			{
				if (Api.BaseClientBuilder.cb_getImpliedScopes_Ljava_lang_Object_ == null)
				{
					Api.BaseClientBuilder.cb_getImpliedScopes_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Api.BaseClientBuilder.n_GetImpliedScopes_Ljava_lang_Object_));
				}
				return Api.BaseClientBuilder.cb_getImpliedScopes_Ljava_lang_Object_;
			}

			// Token: 0x06000391 RID: 913 RVA: 0x0000ADE0 File Offset: 0x00008FE0
			private static IntPtr n_GetImpliedScopes_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				Api.BaseClientBuilder @object = Java.Lang.Object.GetObject<Api.BaseClientBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JavaList<Scope>.ToLocalJniHandle(@object.GetImpliedScopes(object2));
			}

			// Token: 0x06000392 RID: 914 RVA: 0x0000AE08 File Offset: 0x00009008
			[Register("getImpliedScopes", "(Ljava/lang/Object;)Ljava/util/List;", "GetGetImpliedScopes_Ljava_lang_Object_Handler")]
			public unsafe virtual IList<Scope> GetImpliedScopes(Java.Lang.Object p0)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
				IList<Scope> result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					result = JavaList<Scope>.FromJniHandle(Api.BaseClientBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("getImpliedScopes.(Ljava/lang/Object;)Ljava/util/List;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(p0);
				}
				return result;
			}

			// Token: 0x040000C2 RID: 194
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/Api$BaseClientBuilder", typeof(Api.BaseClientBuilder));

			// Token: 0x040000C3 RID: 195
			private static Delegate cb_getPriority;

			// Token: 0x040000C4 RID: 196
			private static Delegate cb_getImpliedScopes_Ljava_lang_Object_;
		}

		// Token: 0x0200005A RID: 90
		[Register("com/google/android/gms/common/api/Api$BaseClientBuilder", DoNotGenerateAcw = true)]
		internal class BaseClientBuilderInvoker : Api.BaseClientBuilder
		{
			// Token: 0x06000394 RID: 916 RVA: 0x0000A614 File Offset: 0x00008814
			public BaseClientBuilderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x170000F3 RID: 243
			// (get) Token: 0x06000395 RID: 917 RVA: 0x0000AE97 File Offset: 0x00009097
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Api.BaseClientBuilderInvoker._members;
				}
			}

			// Token: 0x170000F4 RID: 244
			// (get) Token: 0x06000396 RID: 918 RVA: 0x0000AE9E File Offset: 0x0000909E
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Api.BaseClientBuilderInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x040000C5 RID: 197
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/Api$BaseClientBuilder", typeof(Api.BaseClientBuilderInvoker));
		}

		// Token: 0x0200005B RID: 91
		[Register("com/google/android/gms/common/api/Api$Client", "", "Android.Gms.Common.Apis.Api/IClientInvoker")]
		public interface IClient : Api.IAnyClient, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000F5 RID: 245
			// (get) Token: 0x06000398 RID: 920
			string EndpointPackageName { [Register("getEndpointPackageName", "()Ljava/lang/String;", "GetGetEndpointPackageNameHandler:Android.Gms.Common.Apis.Api/IClientInvoker, Xamarin.GooglePlayServices.Base")] get; }

			// Token: 0x170000F6 RID: 246
			// (get) Token: 0x06000399 RID: 921
			bool IsConnected { [Register("isConnected", "()Z", "GetIsConnectedHandler:Android.Gms.Common.Apis.Api/IClientInvoker, Xamarin.GooglePlayServices.Base")] get; }

			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x0600039A RID: 922
			bool IsConnecting { [Register("isConnecting", "()Z", "GetIsConnectingHandler:Android.Gms.Common.Apis.Api/IClientInvoker, Xamarin.GooglePlayServices.Base")] get; }

			// Token: 0x170000F8 RID: 248
			// (get) Token: 0x0600039B RID: 923
			string LastDisconnectMessage { [Register("getLastDisconnectMessage", "()Ljava/lang/String;", "GetGetLastDisconnectMessageHandler:Android.Gms.Common.Apis.Api/IClientInvoker, Xamarin.GooglePlayServices.Base")] get; }

			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x0600039C RID: 924
			int MinApkVersion { [Register("getMinApkVersion", "()I", "GetGetMinApkVersionHandler:Android.Gms.Common.Apis.Api/IClientInvoker, Xamarin.GooglePlayServices.Base")] get; }

			// Token: 0x170000FA RID: 250
			// (get) Token: 0x0600039D RID: 925
			ICollection<Scope> ScopesForConnectionlessNonSignIn { [Register("getScopesForConnectionlessNonSignIn", "()Ljava/util/Set;", "GetGetScopesForConnectionlessNonSignInHandler:Android.Gms.Common.Apis.Api/IClientInvoker, Xamarin.GooglePlayServices.Base")] get; }

			// Token: 0x170000FB RID: 251
			// (get) Token: 0x0600039E RID: 926
			IBinder ServiceBrokerBinder { [Register("getServiceBrokerBinder", "()Landroid/os/IBinder;", "GetGetServiceBrokerBinderHandler:Android.Gms.Common.Apis.Api/IClientInvoker, Xamarin.GooglePlayServices.Base")] get; }

			// Token: 0x170000FC RID: 252
			// (get) Token: 0x0600039F RID: 927
			Intent SignInIntent { [Register("getSignInIntent", "()Landroid/content/Intent;", "GetGetSignInIntentHandler:Android.Gms.Common.Apis.Api/IClientInvoker, Xamarin.GooglePlayServices.Base")] get; }

			// Token: 0x060003A0 RID: 928
			[Register("disconnect", "()V", "GetDisconnectHandler:Android.Gms.Common.Apis.Api/IClientInvoker, Xamarin.GooglePlayServices.Base")]
			void Disconnect();

			// Token: 0x060003A1 RID: 929
			[Register("disconnect", "(Ljava/lang/String;)V", "GetDisconnect_Ljava_lang_String_Handler:Android.Gms.Common.Apis.Api/IClientInvoker, Xamarin.GooglePlayServices.Base")]
			void Disconnect(string p0);

			// Token: 0x060003A2 RID: 930
			[Register("dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", "GetDump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_Handler:Android.Gms.Common.Apis.Api/IClientInvoker, Xamarin.GooglePlayServices.Base")]
			void Dump(string p0, FileDescriptor p1, PrintWriter p2, string[] p3);

			// Token: 0x060003A3 RID: 931
			[Register("getAvailableFeatures", "()[Lcom/google/android/gms/common/Feature;", "GetGetAvailableFeaturesHandler:Android.Gms.Common.Apis.Api/IClientInvoker, Xamarin.GooglePlayServices.Base")]
			Feature[] GetAvailableFeatures();

			// Token: 0x060003A4 RID: 932
			[Register("getRemoteService", "(Lcom/google/android/gms/common/internal/IAccountAccessor;Ljava/util/Set;)V", "GetGetRemoteService_Lcom_google_android_gms_common_internal_IAccountAccessor_Ljava_util_Set_Handler:Android.Gms.Common.Apis.Api/IClientInvoker, Xamarin.GooglePlayServices.Base")]
			void GetRemoteService(IAccountAccessor p0, ICollection<Scope> p1);

			// Token: 0x060003A5 RID: 933
			[Register("getRequiredFeatures", "()[Lcom/google/android/gms/common/Feature;", "GetGetRequiredFeaturesHandler:Android.Gms.Common.Apis.Api/IClientInvoker, Xamarin.GooglePlayServices.Base")]
			Feature[] GetRequiredFeatures();

			// Token: 0x060003A6 RID: 934
			[Register("providesSignIn", "()Z", "GetProvidesSignInHandler:Android.Gms.Common.Apis.Api/IClientInvoker, Xamarin.GooglePlayServices.Base")]
			bool ProvidesSignIn();

			// Token: 0x060003A7 RID: 935
			[Register("requiresAccount", "()Z", "GetRequiresAccountHandler:Android.Gms.Common.Apis.Api/IClientInvoker, Xamarin.GooglePlayServices.Base")]
			bool RequiresAccount();

			// Token: 0x060003A8 RID: 936
			[Register("requiresGooglePlayServices", "()Z", "GetRequiresGooglePlayServicesHandler:Android.Gms.Common.Apis.Api/IClientInvoker, Xamarin.GooglePlayServices.Base")]
			bool RequiresGooglePlayServices();

			// Token: 0x060003A9 RID: 937
			[Register("requiresSignIn", "()Z", "GetRequiresSignInHandler:Android.Gms.Common.Apis.Api/IClientInvoker, Xamarin.GooglePlayServices.Base")]
			bool RequiresSignIn();
		}

		// Token: 0x0200005C RID: 92
		[Register("com/google/android/gms/common/api/Api$Client", DoNotGenerateAcw = true)]
		internal class IClientInvoker : Java.Lang.Object, Api.IClient, Api.IAnyClient, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000FD RID: 253
			// (get) Token: 0x060003AA RID: 938 RVA: 0x0000AEC8 File Offset: 0x000090C8
			private static IntPtr java_class_ref
			{
				get
				{
					return Api.IClientInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000FE RID: 254
			// (get) Token: 0x060003AB RID: 939 RVA: 0x0000AEEC File Offset: 0x000090EC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Api.IClientInvoker._members;
				}
			}

			// Token: 0x170000FF RID: 255
			// (get) Token: 0x060003AC RID: 940 RVA: 0x0000AEF3 File Offset: 0x000090F3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000100 RID: 256
			// (get) Token: 0x060003AD RID: 941 RVA: 0x0000AEFB File Offset: 0x000090FB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Api.IClientInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060003AE RID: 942 RVA: 0x0000AF07 File Offset: 0x00009107
			public static Api.IClient GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<Api.IClient>(handle, transfer);
			}

			// Token: 0x060003AF RID: 943 RVA: 0x0000AF10 File Offset: 0x00009110
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, Api.IClientInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.common.api.Api.Client'.");
				}
				return handle;
			}

			// Token: 0x060003B0 RID: 944 RVA: 0x0000AF3B File Offset: 0x0000913B
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060003B1 RID: 945 RVA: 0x0000AF6C File Offset: 0x0000916C
			public IClientInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Api.IClientInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060003B2 RID: 946 RVA: 0x0000AFA4 File Offset: 0x000091A4
			private static Delegate GetGetEndpointPackageNameHandler()
			{
				if (Api.IClientInvoker.cb_getEndpointPackageName == null)
				{
					Api.IClientInvoker.cb_getEndpointPackageName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Api.IClientInvoker.n_GetEndpointPackageName));
				}
				return Api.IClientInvoker.cb_getEndpointPackageName;
			}

			// Token: 0x060003B3 RID: 947 RVA: 0x0000AFC8 File Offset: 0x000091C8
			private static IntPtr n_GetEndpointPackageName(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<Api.IClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EndpointPackageName);
			}

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x060003B4 RID: 948 RVA: 0x0000AFDC File Offset: 0x000091DC
			public string EndpointPackageName
			{
				get
				{
					if (this.id_getEndpointPackageName == IntPtr.Zero)
					{
						this.id_getEndpointPackageName = JNIEnv.GetMethodID(this.class_ref, "getEndpointPackageName", "()Ljava/lang/String;");
					}
					return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getEndpointPackageName), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x060003B5 RID: 949 RVA: 0x0000B02D File Offset: 0x0000922D
			private static Delegate GetIsConnectedHandler()
			{
				if (Api.IClientInvoker.cb_isConnected == null)
				{
					Api.IClientInvoker.cb_isConnected = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Api.IClientInvoker.n_IsConnected));
				}
				return Api.IClientInvoker.cb_isConnected;
			}

			// Token: 0x060003B6 RID: 950 RVA: 0x0000B051 File Offset: 0x00009251
			private static bool n_IsConnected(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<Api.IClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsConnected;
			}

			// Token: 0x17000102 RID: 258
			// (get) Token: 0x060003B7 RID: 951 RVA: 0x0000B060 File Offset: 0x00009260
			public bool IsConnected
			{
				get
				{
					if (this.id_isConnected == IntPtr.Zero)
					{
						this.id_isConnected = JNIEnv.GetMethodID(this.class_ref, "isConnected", "()Z");
					}
					return JNIEnv.CallBooleanMethod(base.Handle, this.id_isConnected);
				}
			}

			// Token: 0x060003B8 RID: 952 RVA: 0x0000B0A0 File Offset: 0x000092A0
			private static Delegate GetIsConnectingHandler()
			{
				if (Api.IClientInvoker.cb_isConnecting == null)
				{
					Api.IClientInvoker.cb_isConnecting = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Api.IClientInvoker.n_IsConnecting));
				}
				return Api.IClientInvoker.cb_isConnecting;
			}

			// Token: 0x060003B9 RID: 953 RVA: 0x0000B0C4 File Offset: 0x000092C4
			private static bool n_IsConnecting(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<Api.IClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsConnecting;
			}

			// Token: 0x17000103 RID: 259
			// (get) Token: 0x060003BA RID: 954 RVA: 0x0000B0D3 File Offset: 0x000092D3
			public bool IsConnecting
			{
				get
				{
					if (this.id_isConnecting == IntPtr.Zero)
					{
						this.id_isConnecting = JNIEnv.GetMethodID(this.class_ref, "isConnecting", "()Z");
					}
					return JNIEnv.CallBooleanMethod(base.Handle, this.id_isConnecting);
				}
			}

			// Token: 0x060003BB RID: 955 RVA: 0x0000B113 File Offset: 0x00009313
			private static Delegate GetGetLastDisconnectMessageHandler()
			{
				if (Api.IClientInvoker.cb_getLastDisconnectMessage == null)
				{
					Api.IClientInvoker.cb_getLastDisconnectMessage = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Api.IClientInvoker.n_GetLastDisconnectMessage));
				}
				return Api.IClientInvoker.cb_getLastDisconnectMessage;
			}

			// Token: 0x060003BC RID: 956 RVA: 0x0000B137 File Offset: 0x00009337
			private static IntPtr n_GetLastDisconnectMessage(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<Api.IClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LastDisconnectMessage);
			}

			// Token: 0x17000104 RID: 260
			// (get) Token: 0x060003BD RID: 957 RVA: 0x0000B14C File Offset: 0x0000934C
			public string LastDisconnectMessage
			{
				get
				{
					if (this.id_getLastDisconnectMessage == IntPtr.Zero)
					{
						this.id_getLastDisconnectMessage = JNIEnv.GetMethodID(this.class_ref, "getLastDisconnectMessage", "()Ljava/lang/String;");
					}
					return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getLastDisconnectMessage), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x060003BE RID: 958 RVA: 0x0000B19D File Offset: 0x0000939D
			private static Delegate GetGetMinApkVersionHandler()
			{
				if (Api.IClientInvoker.cb_getMinApkVersion == null)
				{
					Api.IClientInvoker.cb_getMinApkVersion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Api.IClientInvoker.n_GetMinApkVersion));
				}
				return Api.IClientInvoker.cb_getMinApkVersion;
			}

			// Token: 0x060003BF RID: 959 RVA: 0x0000B1C1 File Offset: 0x000093C1
			private static int n_GetMinApkVersion(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<Api.IClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MinApkVersion;
			}

			// Token: 0x17000105 RID: 261
			// (get) Token: 0x060003C0 RID: 960 RVA: 0x0000B1D0 File Offset: 0x000093D0
			public int MinApkVersion
			{
				get
				{
					if (this.id_getMinApkVersion == IntPtr.Zero)
					{
						this.id_getMinApkVersion = JNIEnv.GetMethodID(this.class_ref, "getMinApkVersion", "()I");
					}
					return JNIEnv.CallIntMethod(base.Handle, this.id_getMinApkVersion);
				}
			}

			// Token: 0x060003C1 RID: 961 RVA: 0x0000B210 File Offset: 0x00009410
			private static Delegate GetGetScopesForConnectionlessNonSignInHandler()
			{
				if (Api.IClientInvoker.cb_getScopesForConnectionlessNonSignIn == null)
				{
					Api.IClientInvoker.cb_getScopesForConnectionlessNonSignIn = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Api.IClientInvoker.n_GetScopesForConnectionlessNonSignIn));
				}
				return Api.IClientInvoker.cb_getScopesForConnectionlessNonSignIn;
			}

			// Token: 0x060003C2 RID: 962 RVA: 0x0000B234 File Offset: 0x00009434
			private static IntPtr n_GetScopesForConnectionlessNonSignIn(IntPtr jnienv, IntPtr native__this)
			{
				return JavaSet<Scope>.ToLocalJniHandle(Java.Lang.Object.GetObject<Api.IClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ScopesForConnectionlessNonSignIn);
			}

			// Token: 0x17000106 RID: 262
			// (get) Token: 0x060003C3 RID: 963 RVA: 0x0000B248 File Offset: 0x00009448
			public ICollection<Scope> ScopesForConnectionlessNonSignIn
			{
				get
				{
					if (this.id_getScopesForConnectionlessNonSignIn == IntPtr.Zero)
					{
						this.id_getScopesForConnectionlessNonSignIn = JNIEnv.GetMethodID(this.class_ref, "getScopesForConnectionlessNonSignIn", "()Ljava/util/Set;");
					}
					return JavaSet<Scope>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getScopesForConnectionlessNonSignIn), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x060003C4 RID: 964 RVA: 0x0000B299 File Offset: 0x00009499
			private static Delegate GetGetServiceBrokerBinderHandler()
			{
				if (Api.IClientInvoker.cb_getServiceBrokerBinder == null)
				{
					Api.IClientInvoker.cb_getServiceBrokerBinder = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Api.IClientInvoker.n_GetServiceBrokerBinder));
				}
				return Api.IClientInvoker.cb_getServiceBrokerBinder;
			}

			// Token: 0x060003C5 RID: 965 RVA: 0x0000B2BD File Offset: 0x000094BD
			private static IntPtr n_GetServiceBrokerBinder(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Api.IClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ServiceBrokerBinder);
			}

			// Token: 0x17000107 RID: 263
			// (get) Token: 0x060003C6 RID: 966 RVA: 0x0000B2D4 File Offset: 0x000094D4
			public IBinder ServiceBrokerBinder
			{
				get
				{
					if (this.id_getServiceBrokerBinder == IntPtr.Zero)
					{
						this.id_getServiceBrokerBinder = JNIEnv.GetMethodID(this.class_ref, "getServiceBrokerBinder", "()Landroid/os/IBinder;");
					}
					return Java.Lang.Object.GetObject<IBinder>(JNIEnv.CallObjectMethod(base.Handle, this.id_getServiceBrokerBinder), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x060003C7 RID: 967 RVA: 0x0000B325 File Offset: 0x00009525
			private static Delegate GetGetSignInIntentHandler()
			{
				if (Api.IClientInvoker.cb_getSignInIntent == null)
				{
					Api.IClientInvoker.cb_getSignInIntent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Api.IClientInvoker.n_GetSignInIntent));
				}
				return Api.IClientInvoker.cb_getSignInIntent;
			}

			// Token: 0x060003C8 RID: 968 RVA: 0x0000B349 File Offset: 0x00009549
			private static IntPtr n_GetSignInIntent(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Api.IClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SignInIntent);
			}

			// Token: 0x17000108 RID: 264
			// (get) Token: 0x060003C9 RID: 969 RVA: 0x0000B360 File Offset: 0x00009560
			public Intent SignInIntent
			{
				get
				{
					if (this.id_getSignInIntent == IntPtr.Zero)
					{
						this.id_getSignInIntent = JNIEnv.GetMethodID(this.class_ref, "getSignInIntent", "()Landroid/content/Intent;");
					}
					return Java.Lang.Object.GetObject<Intent>(JNIEnv.CallObjectMethod(base.Handle, this.id_getSignInIntent), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x060003CA RID: 970 RVA: 0x0000B3B1 File Offset: 0x000095B1
			private static Delegate GetDisconnectHandler()
			{
				if (Api.IClientInvoker.cb_disconnect == null)
				{
					Api.IClientInvoker.cb_disconnect = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(Api.IClientInvoker.n_Disconnect));
				}
				return Api.IClientInvoker.cb_disconnect;
			}

			// Token: 0x060003CB RID: 971 RVA: 0x0000B3D5 File Offset: 0x000095D5
			private static void n_Disconnect(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<Api.IClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Disconnect();
			}

			// Token: 0x060003CC RID: 972 RVA: 0x0000B3E4 File Offset: 0x000095E4
			public void Disconnect()
			{
				if (this.id_disconnect == IntPtr.Zero)
				{
					this.id_disconnect = JNIEnv.GetMethodID(this.class_ref, "disconnect", "()V");
				}
				JNIEnv.CallVoidMethod(base.Handle, this.id_disconnect);
			}

			// Token: 0x060003CD RID: 973 RVA: 0x0000B424 File Offset: 0x00009624
			private static Delegate GetDisconnect_Ljava_lang_String_Handler()
			{
				if (Api.IClientInvoker.cb_disconnect_Ljava_lang_String_ == null)
				{
					Api.IClientInvoker.cb_disconnect_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Api.IClientInvoker.n_Disconnect_Ljava_lang_String_));
				}
				return Api.IClientInvoker.cb_disconnect_Ljava_lang_String_;
			}

			// Token: 0x060003CE RID: 974 RVA: 0x0000B448 File Offset: 0x00009648
			private static void n_Disconnect_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				Api.IClient @object = Java.Lang.Object.GetObject<Api.IClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.Disconnect(@string);
			}

			// Token: 0x060003CF RID: 975 RVA: 0x0000B46C File Offset: 0x0000966C
			public unsafe void Disconnect(string p0)
			{
				if (this.id_disconnect_Ljava_lang_String_ == IntPtr.Zero)
				{
					this.id_disconnect_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "disconnect", "(Ljava/lang/String;)V");
				}
				IntPtr intPtr = JNIEnv.NewString(p0);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				JNIEnv.CallVoidMethod(base.Handle, this.id_disconnect_Ljava_lang_String_, ptr);
				JNIEnv.DeleteLocalRef(intPtr);
			}

			// Token: 0x060003D0 RID: 976 RVA: 0x0000B4DD File Offset: 0x000096DD
			private static Delegate GetDump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_Handler()
			{
				if (Api.IClientInvoker.cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_ == null)
				{
					Api.IClientInvoker.cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_V(Api.IClientInvoker.n_Dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_));
				}
				return Api.IClientInvoker.cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_;
			}

			// Token: 0x060003D1 RID: 977 RVA: 0x0000B504 File Offset: 0x00009704
			private static void n_Dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				Api.IClient @object = Java.Lang.Object.GetObject<Api.IClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				FileDescriptor object2 = Java.Lang.Object.GetObject<FileDescriptor>(native_p1, JniHandleOwnership.DoNotTransfer);
				PrintWriter object3 = Java.Lang.Object.GetObject<PrintWriter>(native_p2, JniHandleOwnership.DoNotTransfer);
				string[] array = (string[])JNIEnv.GetArray(native_p3, JniHandleOwnership.DoNotTransfer, typeof(string));
				@object.Dump(@string, object2, object3, array);
				if (array != null)
				{
					JNIEnv.CopyArray(array, native_p3);
				}
			}

			// Token: 0x060003D2 RID: 978 RVA: 0x0000B560 File Offset: 0x00009760
			public unsafe void Dump(string p0, FileDescriptor p1, PrintWriter p2, string[] p3)
			{
				if (this.id_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_ == IntPtr.Zero)
				{
					this.id_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "dump", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V");
				}
				IntPtr intPtr = JNIEnv.NewString(p0);
				IntPtr intPtr2 = JNIEnv.NewArray(p3);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				ptr[3] = new JValue(intPtr2);
				JNIEnv.CallVoidMethod(base.Handle, this.id_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_, ptr);
				JNIEnv.DeleteLocalRef(intPtr);
				if (p3 != null)
				{
					JNIEnv.CopyArray(intPtr2, p3);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
			}

			// Token: 0x060003D3 RID: 979 RVA: 0x0000B648 File Offset: 0x00009848
			private static Delegate GetGetAvailableFeaturesHandler()
			{
				if (Api.IClientInvoker.cb_getAvailableFeatures == null)
				{
					Api.IClientInvoker.cb_getAvailableFeatures = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Api.IClientInvoker.n_GetAvailableFeatures));
				}
				return Api.IClientInvoker.cb_getAvailableFeatures;
			}

			// Token: 0x060003D4 RID: 980 RVA: 0x0000B66C File Offset: 0x0000986C
			private static IntPtr n_GetAvailableFeatures(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewArray<Feature>(Java.Lang.Object.GetObject<Api.IClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetAvailableFeatures());
			}

			// Token: 0x060003D5 RID: 981 RVA: 0x0000B680 File Offset: 0x00009880
			public Feature[] GetAvailableFeatures()
			{
				if (this.id_getAvailableFeatures == IntPtr.Zero)
				{
					this.id_getAvailableFeatures = JNIEnv.GetMethodID(this.class_ref, "getAvailableFeatures", "()[Lcom/google/android/gms/common/Feature;");
				}
				return (Feature[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_getAvailableFeatures), JniHandleOwnership.TransferLocalRef, typeof(Feature));
			}

			// Token: 0x060003D6 RID: 982 RVA: 0x0000B6E0 File Offset: 0x000098E0
			private static Delegate GetGetRemoteService_Lcom_google_android_gms_common_internal_IAccountAccessor_Ljava_util_Set_Handler()
			{
				if (Api.IClientInvoker.cb_getRemoteService_Lcom_google_android_gms_common_internal_IAccountAccessor_Ljava_util_Set_ == null)
				{
					Api.IClientInvoker.cb_getRemoteService_Lcom_google_android_gms_common_internal_IAccountAccessor_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(Api.IClientInvoker.n_GetRemoteService_Lcom_google_android_gms_common_internal_IAccountAccessor_Ljava_util_Set_));
				}
				return Api.IClientInvoker.cb_getRemoteService_Lcom_google_android_gms_common_internal_IAccountAccessor_Ljava_util_Set_;
			}

			// Token: 0x060003D7 RID: 983 RVA: 0x0000B704 File Offset: 0x00009904
			private static void n_GetRemoteService_Lcom_google_android_gms_common_internal_IAccountAccessor_Ljava_util_Set_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				Api.IClient @object = Java.Lang.Object.GetObject<Api.IClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IAccountAccessor object2 = Java.Lang.Object.GetObject<IAccountAccessor>(native_p0, JniHandleOwnership.DoNotTransfer);
				ICollection<Scope> p = JavaSet<Scope>.FromJniHandle(native_p1, JniHandleOwnership.DoNotTransfer);
				@object.GetRemoteService(object2, p);
			}

			// Token: 0x060003D8 RID: 984 RVA: 0x0000B730 File Offset: 0x00009930
			public unsafe void GetRemoteService(IAccountAccessor p0, ICollection<Scope> p1)
			{
				if (this.id_getRemoteService_Lcom_google_android_gms_common_internal_IAccountAccessor_Ljava_util_Set_ == IntPtr.Zero)
				{
					this.id_getRemoteService_Lcom_google_android_gms_common_internal_IAccountAccessor_Ljava_util_Set_ = JNIEnv.GetMethodID(this.class_ref, "getRemoteService", "(Lcom/google/android/gms/common/internal/IAccountAccessor;Ljava/util/Set;)V");
				}
				IntPtr intPtr = JavaSet<Scope>.ToLocalJniHandle(p1);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				ptr[1] = new JValue(intPtr);
				JNIEnv.CallVoidMethod(base.Handle, this.id_getRemoteService_Lcom_google_android_gms_common_internal_IAccountAccessor_Ljava_util_Set_, ptr);
				JNIEnv.DeleteLocalRef(intPtr);
			}

			// Token: 0x060003D9 RID: 985 RVA: 0x0000B7C8 File Offset: 0x000099C8
			private static Delegate GetGetRequiredFeaturesHandler()
			{
				if (Api.IClientInvoker.cb_getRequiredFeatures == null)
				{
					Api.IClientInvoker.cb_getRequiredFeatures = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Api.IClientInvoker.n_GetRequiredFeatures));
				}
				return Api.IClientInvoker.cb_getRequiredFeatures;
			}

			// Token: 0x060003DA RID: 986 RVA: 0x0000B7EC File Offset: 0x000099EC
			private static IntPtr n_GetRequiredFeatures(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewArray<Feature>(Java.Lang.Object.GetObject<Api.IClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetRequiredFeatures());
			}

			// Token: 0x060003DB RID: 987 RVA: 0x0000B800 File Offset: 0x00009A00
			public Feature[] GetRequiredFeatures()
			{
				if (this.id_getRequiredFeatures == IntPtr.Zero)
				{
					this.id_getRequiredFeatures = JNIEnv.GetMethodID(this.class_ref, "getRequiredFeatures", "()[Lcom/google/android/gms/common/Feature;");
				}
				return (Feature[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_getRequiredFeatures), JniHandleOwnership.TransferLocalRef, typeof(Feature));
			}

			// Token: 0x060003DC RID: 988 RVA: 0x0000B860 File Offset: 0x00009A60
			private static Delegate GetProvidesSignInHandler()
			{
				if (Api.IClientInvoker.cb_providesSignIn == null)
				{
					Api.IClientInvoker.cb_providesSignIn = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Api.IClientInvoker.n_ProvidesSignIn));
				}
				return Api.IClientInvoker.cb_providesSignIn;
			}

			// Token: 0x060003DD RID: 989 RVA: 0x0000B884 File Offset: 0x00009A84
			private static bool n_ProvidesSignIn(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<Api.IClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ProvidesSignIn();
			}

			// Token: 0x060003DE RID: 990 RVA: 0x0000B893 File Offset: 0x00009A93
			public bool ProvidesSignIn()
			{
				if (this.id_providesSignIn == IntPtr.Zero)
				{
					this.id_providesSignIn = JNIEnv.GetMethodID(this.class_ref, "providesSignIn", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_providesSignIn);
			}

			// Token: 0x060003DF RID: 991 RVA: 0x0000B8D3 File Offset: 0x00009AD3
			private static Delegate GetRequiresAccountHandler()
			{
				if (Api.IClientInvoker.cb_requiresAccount == null)
				{
					Api.IClientInvoker.cb_requiresAccount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Api.IClientInvoker.n_RequiresAccount));
				}
				return Api.IClientInvoker.cb_requiresAccount;
			}

			// Token: 0x060003E0 RID: 992 RVA: 0x0000B8F7 File Offset: 0x00009AF7
			private static bool n_RequiresAccount(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<Api.IClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequiresAccount();
			}

			// Token: 0x060003E1 RID: 993 RVA: 0x0000B906 File Offset: 0x00009B06
			public bool RequiresAccount()
			{
				if (this.id_requiresAccount == IntPtr.Zero)
				{
					this.id_requiresAccount = JNIEnv.GetMethodID(this.class_ref, "requiresAccount", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_requiresAccount);
			}

			// Token: 0x060003E2 RID: 994 RVA: 0x0000B946 File Offset: 0x00009B46
			private static Delegate GetRequiresGooglePlayServicesHandler()
			{
				if (Api.IClientInvoker.cb_requiresGooglePlayServices == null)
				{
					Api.IClientInvoker.cb_requiresGooglePlayServices = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Api.IClientInvoker.n_RequiresGooglePlayServices));
				}
				return Api.IClientInvoker.cb_requiresGooglePlayServices;
			}

			// Token: 0x060003E3 RID: 995 RVA: 0x0000B96A File Offset: 0x00009B6A
			private static bool n_RequiresGooglePlayServices(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<Api.IClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequiresGooglePlayServices();
			}

			// Token: 0x060003E4 RID: 996 RVA: 0x0000B979 File Offset: 0x00009B79
			public bool RequiresGooglePlayServices()
			{
				if (this.id_requiresGooglePlayServices == IntPtr.Zero)
				{
					this.id_requiresGooglePlayServices = JNIEnv.GetMethodID(this.class_ref, "requiresGooglePlayServices", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_requiresGooglePlayServices);
			}

			// Token: 0x060003E5 RID: 997 RVA: 0x0000B9B9 File Offset: 0x00009BB9
			private static Delegate GetRequiresSignInHandler()
			{
				if (Api.IClientInvoker.cb_requiresSignIn == null)
				{
					Api.IClientInvoker.cb_requiresSignIn = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Api.IClientInvoker.n_RequiresSignIn));
				}
				return Api.IClientInvoker.cb_requiresSignIn;
			}

			// Token: 0x060003E6 RID: 998 RVA: 0x0000B9DD File Offset: 0x00009BDD
			private static bool n_RequiresSignIn(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<Api.IClient>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequiresSignIn();
			}

			// Token: 0x060003E7 RID: 999 RVA: 0x0000B9EC File Offset: 0x00009BEC
			public bool RequiresSignIn()
			{
				if (this.id_requiresSignIn == IntPtr.Zero)
				{
					this.id_requiresSignIn = JNIEnv.GetMethodID(this.class_ref, "requiresSignIn", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_requiresSignIn);
			}

			// Token: 0x040000C6 RID: 198
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/Api$Client", typeof(Api.IClientInvoker));

			// Token: 0x040000C7 RID: 199
			private IntPtr class_ref;

			// Token: 0x040000C8 RID: 200
			private static Delegate cb_getEndpointPackageName;

			// Token: 0x040000C9 RID: 201
			private IntPtr id_getEndpointPackageName;

			// Token: 0x040000CA RID: 202
			private static Delegate cb_isConnected;

			// Token: 0x040000CB RID: 203
			private IntPtr id_isConnected;

			// Token: 0x040000CC RID: 204
			private static Delegate cb_isConnecting;

			// Token: 0x040000CD RID: 205
			private IntPtr id_isConnecting;

			// Token: 0x040000CE RID: 206
			private static Delegate cb_getLastDisconnectMessage;

			// Token: 0x040000CF RID: 207
			private IntPtr id_getLastDisconnectMessage;

			// Token: 0x040000D0 RID: 208
			private static Delegate cb_getMinApkVersion;

			// Token: 0x040000D1 RID: 209
			private IntPtr id_getMinApkVersion;

			// Token: 0x040000D2 RID: 210
			private static Delegate cb_getScopesForConnectionlessNonSignIn;

			// Token: 0x040000D3 RID: 211
			private IntPtr id_getScopesForConnectionlessNonSignIn;

			// Token: 0x040000D4 RID: 212
			private static Delegate cb_getServiceBrokerBinder;

			// Token: 0x040000D5 RID: 213
			private IntPtr id_getServiceBrokerBinder;

			// Token: 0x040000D6 RID: 214
			private static Delegate cb_getSignInIntent;

			// Token: 0x040000D7 RID: 215
			private IntPtr id_getSignInIntent;

			// Token: 0x040000D8 RID: 216
			private static Delegate cb_disconnect;

			// Token: 0x040000D9 RID: 217
			private IntPtr id_disconnect;

			// Token: 0x040000DA RID: 218
			private static Delegate cb_disconnect_Ljava_lang_String_;

			// Token: 0x040000DB RID: 219
			private IntPtr id_disconnect_Ljava_lang_String_;

			// Token: 0x040000DC RID: 220
			private static Delegate cb_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_;

			// Token: 0x040000DD RID: 221
			private IntPtr id_dump_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_;

			// Token: 0x040000DE RID: 222
			private static Delegate cb_getAvailableFeatures;

			// Token: 0x040000DF RID: 223
			private IntPtr id_getAvailableFeatures;

			// Token: 0x040000E0 RID: 224
			private static Delegate cb_getRemoteService_Lcom_google_android_gms_common_internal_IAccountAccessor_Ljava_util_Set_;

			// Token: 0x040000E1 RID: 225
			private IntPtr id_getRemoteService_Lcom_google_android_gms_common_internal_IAccountAccessor_Ljava_util_Set_;

			// Token: 0x040000E2 RID: 226
			private static Delegate cb_getRequiredFeatures;

			// Token: 0x040000E3 RID: 227
			private IntPtr id_getRequiredFeatures;

			// Token: 0x040000E4 RID: 228
			private static Delegate cb_providesSignIn;

			// Token: 0x040000E5 RID: 229
			private IntPtr id_providesSignIn;

			// Token: 0x040000E6 RID: 230
			private static Delegate cb_requiresAccount;

			// Token: 0x040000E7 RID: 231
			private IntPtr id_requiresAccount;

			// Token: 0x040000E8 RID: 232
			private static Delegate cb_requiresGooglePlayServices;

			// Token: 0x040000E9 RID: 233
			private IntPtr id_requiresGooglePlayServices;

			// Token: 0x040000EA RID: 234
			private static Delegate cb_requiresSignIn;

			// Token: 0x040000EB RID: 235
			private IntPtr id_requiresSignIn;
		}

		// Token: 0x0200005D RID: 93
		[Register("com/google/android/gms/common/api/Api$ClientKey", DoNotGenerateAcw = true)]
		[JavaTypeParameters(new string[]
		{
			"C extends com.google.android.gms.common.api.Api.Client"
		})]
		public sealed class ClientKey : Api.AnyClientKey
		{
			// Token: 0x17000109 RID: 265
			// (get) Token: 0x060003E9 RID: 1001 RVA: 0x0000BA48 File Offset: 0x00009C48
			internal new static IntPtr class_ref
			{
				get
				{
					return Api.ClientKey._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x060003EA RID: 1002 RVA: 0x0000BA6C File Offset: 0x00009C6C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Api.ClientKey._members;
				}
			}

			// Token: 0x1700010B RID: 267
			// (get) Token: 0x060003EB RID: 1003 RVA: 0x0000BA74 File Offset: 0x00009C74
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Api.ClientKey._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700010C RID: 268
			// (get) Token: 0x060003EC RID: 1004 RVA: 0x0000BA98 File Offset: 0x00009C98
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Api.ClientKey._members.ManagedPeerType;
				}
			}

			// Token: 0x060003ED RID: 1005 RVA: 0x0000BAA4 File Offset: 0x00009CA4
			internal ClientKey(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060003EE RID: 1006 RVA: 0x0000BAB0 File Offset: 0x00009CB0
			[Register(".ctor", "()V", "")]
			public ClientKey() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(Api.ClientKey._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				Api.ClientKey._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x040000EC RID: 236
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/Api$ClientKey", typeof(Api.ClientKey));
		}
	}
}
