using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common.Scarads;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common
{
	// Token: 0x02000297 RID: 663
	[Register("com/unity3d/scar/adapter/common/GMAAdsError", DoNotGenerateAcw = true)]
	public class GMAAdsError : WebViewAdsError
	{
		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x060025DF RID: 9695 RVA: 0x00061590 File Offset: 0x0005F790
		internal new static IntPtr class_ref
		{
			get
			{
				return GMAAdsError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x060025E0 RID: 9696 RVA: 0x000615B4 File Offset: 0x0005F7B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GMAAdsError._members;
			}
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x060025E1 RID: 9697 RVA: 0x000615BC File Offset: 0x0005F7BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GMAAdsError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x060025E2 RID: 9698 RVA: 0x000615E0 File Offset: 0x0005F7E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GMAAdsError._members.ManagedPeerType;
			}
		}

		// Token: 0x060025E3 RID: 9699 RVA: 0x00009230 File Offset: 0x00007430
		protected GMAAdsError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060025E4 RID: 9700 RVA: 0x000615EC File Offset: 0x0005F7EC
		[Register(".ctor", "(Lcom/unity3d/scar/adapter/common/GMAEvent;[Ljava/lang/Object;)V", "")]
		public unsafe GMAAdsError(GMAEvent errorCategory, params Java.Lang.Object[] errorArguments) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewArray<Java.Lang.Object>(errorArguments);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((errorCategory == null) ? IntPtr.Zero : errorCategory.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				base.SetHandle(GMAAdsError._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/scar/adapter/common/GMAEvent;[Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GMAAdsError._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/scar/adapter/common/GMAEvent;[Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				if (errorArguments != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr, errorArguments);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(errorCategory);
				GC.KeepAlive(errorArguments);
			}
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x000616C8 File Offset: 0x0005F8C8
		[Register(".ctor", "(Lcom/unity3d/scar/adapter/common/GMAEvent;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public unsafe GMAAdsError(GMAEvent errorCategory, string description, params Java.Lang.Object[] errorArguments) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(description);
			IntPtr intPtr2 = JNIEnv.NewArray<Java.Lang.Object>(errorArguments);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((errorCategory == null) ? IntPtr.Zero : errorCategory.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				base.SetHandle(GMAAdsError._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/scar/adapter/common/GMAEvent;Ljava/lang/String;[Ljava/lang/Object;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				GMAAdsError._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/scar/adapter/common/GMAEvent;Ljava/lang/String;[Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (errorArguments != null)
				{
					JNIEnv.CopyArray<Java.Lang.Object>(intPtr2, errorArguments);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(errorCategory);
				GC.KeepAlive(errorArguments);
			}
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x000617C8 File Offset: 0x0005F9C8
		[Register("AdNotLoadedError", "(Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;)Lcom/unity3d/scar/adapter/common/GMAAdsError;", "")]
		public unsafe static GMAAdsError AdNotLoadedError(ScarAdMetadata scarAdMetadata)
		{
			GMAAdsError @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((scarAdMetadata == null) ? IntPtr.Zero : scarAdMetadata.Handle);
				@object = Java.Lang.Object.GetObject<GMAAdsError>(GMAAdsError._members.StaticMethods.InvokeObjectMethod("AdNotLoadedError.(Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;)Lcom/unity3d/scar/adapter/common/GMAAdsError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(scarAdMetadata);
			}
			return @object;
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x0006183C File Offset: 0x0005FA3C
		[Register("AdapterCreationError", "(Ljava/lang/String;)Lcom/unity3d/scar/adapter/common/GMAAdsError;", "")]
		public unsafe static GMAAdsError AdapterCreationError(string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			GMAAdsError @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<GMAAdsError>(GMAAdsError._members.StaticMethods.InvokeObjectMethod("AdapterCreationError.(Ljava/lang/String;)Lcom/unity3d/scar/adapter/common/GMAAdsError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x000618A8 File Offset: 0x0005FAA8
		[Register("InternalLoadError", "(Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Ljava/lang/String;)Lcom/unity3d/scar/adapter/common/GMAAdsError;", "")]
		public unsafe static GMAAdsError InternalLoadError(ScarAdMetadata scarAdMetadata, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			GMAAdsError @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((scarAdMetadata == null) ? IntPtr.Zero : scarAdMetadata.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<GMAAdsError>(GMAAdsError._members.StaticMethods.InvokeObjectMethod("InternalLoadError.(Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Ljava/lang/String;)Lcom/unity3d/scar/adapter/common/GMAAdsError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(scarAdMetadata);
			}
			return @object;
		}

		// Token: 0x060025E9 RID: 9705 RVA: 0x0006193C File Offset: 0x0005FB3C
		[Register("InternalShowError", "(Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Ljava/lang/String;)Lcom/unity3d/scar/adapter/common/GMAAdsError;", "")]
		public unsafe static GMAAdsError InternalShowError(ScarAdMetadata scarAdMetadata, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			GMAAdsError @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((scarAdMetadata == null) ? IntPtr.Zero : scarAdMetadata.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<GMAAdsError>(GMAAdsError._members.StaticMethods.InvokeObjectMethod("InternalShowError.(Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;Ljava/lang/String;)Lcom/unity3d/scar/adapter/common/GMAAdsError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(scarAdMetadata);
			}
			return @object;
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x000619D0 File Offset: 0x0005FBD0
		[Register("InternalSignalsError", "(Ljava/lang/String;)Lcom/unity3d/scar/adapter/common/GMAAdsError;", "")]
		public unsafe static GMAAdsError InternalSignalsError(string message)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			GMAAdsError @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<GMAAdsError>(GMAAdsError._members.StaticMethods.InvokeObjectMethod("InternalSignalsError.(Ljava/lang/String;)Lcom/unity3d/scar/adapter/common/GMAAdsError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x00061A3C File Offset: 0x0005FC3C
		[Register("NoAdsError", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/unity3d/scar/adapter/common/GMAAdsError;", "")]
		public unsafe static GMAAdsError NoAdsError(string placementId, string queryId, string message)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			IntPtr intPtr2 = JNIEnv.NewString(queryId);
			IntPtr intPtr3 = JNIEnv.NewString(message);
			GMAAdsError @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				@object = Java.Lang.Object.GetObject<GMAAdsError>(GMAAdsError._members.StaticMethods.InvokeObjectMethod("NoAdsError.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/unity3d/scar/adapter/common/GMAAdsError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
			}
			return @object;
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x00061AEC File Offset: 0x0005FCEC
		[Register("QueryNotFoundError", "(Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;)Lcom/unity3d/scar/adapter/common/GMAAdsError;", "")]
		public unsafe static GMAAdsError QueryNotFoundError(ScarAdMetadata scarAdMetadata)
		{
			GMAAdsError @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((scarAdMetadata == null) ? IntPtr.Zero : scarAdMetadata.Handle);
				@object = Java.Lang.Object.GetObject<GMAAdsError>(GMAAdsError._members.StaticMethods.InvokeObjectMethod("QueryNotFoundError.(Lcom/unity3d/scar/adapter/common/scarads/ScarAdMetadata;)Lcom/unity3d/scar/adapter/common/GMAAdsError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(scarAdMetadata);
			}
			return @object;
		}

		// Token: 0x0400075E RID: 1886
		[Register("AD_NOT_LOADED_MESSAGE")]
		public const string AdNotLoadedMessage = "Cannot show ad that is not loaded for placement %s";

		// Token: 0x0400075F RID: 1887
		[Register("MISSING_QUERYINFO_MESSAGE")]
		public const string MissingQueryinfoMessage = "Missing queryInfoMetadata for ad %s";

		// Token: 0x04000760 RID: 1888
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/GMAAdsError", typeof(GMAAdsError));
	}
}
