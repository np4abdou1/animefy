using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device
{
	// Token: 0x02000124 RID: 292
	[Register("com/unity3d/services/core/device/StorageManager", DoNotGenerateAcw = true)]
	public class StorageManager : Java.Lang.Object
	{
		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x00020E78 File Offset: 0x0001F078
		internal static IntPtr class_ref
		{
			get
			{
				return StorageManager._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x00020E9C File Offset: 0x0001F09C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StorageManager._members;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x00020EA4 File Offset: 0x0001F0A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StorageManager._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x00020EC8 File Offset: 0x0001F0C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StorageManager._members.ManagedPeerType;
			}
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x000021E8 File Offset: 0x000003E8
		protected StorageManager(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00020ED4 File Offset: 0x0001F0D4
		[Register(".ctor", "()V", "")]
		public StorageManager() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(StorageManager._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			StorageManager._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00020F44 File Offset: 0x0001F144
		[Register("addStorageLocation", "(Lcom/unity3d/services/core/device/StorageManager$StorageType;Ljava/lang/String;)V", "")]
		public unsafe static void AddStorageLocation(StorageManager.StorageType type, string filename)
		{
			IntPtr intPtr = JNIEnv.NewString(filename);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((type == null) ? IntPtr.Zero : type.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				StorageManager._members.StaticMethods.InvokeVoidMethod("addStorageLocation.(Lcom/unity3d/services/core/device/StorageManager$StorageType;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(type);
			}
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00020FC8 File Offset: 0x0001F1C8
		[Register("getStorage", "(Lcom/unity3d/services/core/device/StorageManager$StorageType;)Lcom/unity3d/services/core/device/Storage;", "")]
		public unsafe static Storage GetStorage(StorageManager.StorageType type)
		{
			Storage @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((type == null) ? IntPtr.Zero : type.Handle);
				@object = Java.Lang.Object.GetObject<Storage>(StorageManager._members.StaticMethods.InvokeObjectMethod("getStorage.(Lcom/unity3d/services/core/device/StorageManager$StorageType;)Lcom/unity3d/services/core/device/Storage;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(type);
			}
			return @object;
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x0002103C File Offset: 0x0001F23C
		[Register("hasStorage", "(Lcom/unity3d/services/core/device/StorageManager$StorageType;)Z", "")]
		public unsafe static bool HasStorage(StorageManager.StorageType type)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((type == null) ? IntPtr.Zero : type.Handle);
				result = StorageManager._members.StaticMethods.InvokeBooleanMethod("hasStorage.(Lcom/unity3d/services/core/device/StorageManager$StorageType;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(type);
			}
			return result;
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x000210A0 File Offset: 0x0001F2A0
		[Register("init", "(Landroid/content/Context;)Z", "")]
		public unsafe static bool Init(Context context)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				result = StorageManager._members.StaticMethods.InvokeBooleanMethod("init.(Landroid/content/Context;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return result;
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00021104 File Offset: 0x0001F304
		[Register("initStorage", "(Lcom/unity3d/services/core/device/StorageManager$StorageType;)V", "")]
		public unsafe static void InitStorage(StorageManager.StorageType type)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((type == null) ? IntPtr.Zero : type.Handle);
				StorageManager._members.StaticMethods.InvokeVoidMethod("initStorage.(Lcom/unity3d/services/core/device/StorageManager$StorageType;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(type);
			}
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00021168 File Offset: 0x0001F368
		[Register("removeStorage", "(Lcom/unity3d/services/core/device/StorageManager$StorageType;)V", "")]
		public unsafe static void RemoveStorage(StorageManager.StorageType type)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((type == null) ? IntPtr.Zero : type.Handle);
				StorageManager._members.StaticMethods.InvokeVoidMethod("removeStorage.(Lcom/unity3d/services/core/device/StorageManager$StorageType;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(type);
			}
		}

		// Token: 0x040002A9 RID: 681
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/StorageManager", typeof(StorageManager));

		// Token: 0x02000125 RID: 293
		[Register("com/unity3d/services/core/device/StorageManager$StorageType", DoNotGenerateAcw = true)]
		public sealed class StorageType : Java.Lang.Enum
		{
			// Token: 0x17000413 RID: 1043
			// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x000211E8 File Offset: 0x0001F3E8
			[Register("PRIVATE")]
			public static StorageManager.StorageType Private
			{
				get
				{
					return Java.Lang.Object.GetObject<StorageManager.StorageType>(StorageManager.StorageType._members.StaticFields.GetObjectValue("PRIVATE.Lcom/unity3d/services/core/device/StorageManager$StorageType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000414 RID: 1044
			// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x00021218 File Offset: 0x0001F418
			[Register("PUBLIC")]
			public static StorageManager.StorageType Public
			{
				get
				{
					return Java.Lang.Object.GetObject<StorageManager.StorageType>(StorageManager.StorageType._members.StaticFields.GetObjectValue("PUBLIC.Lcom/unity3d/services/core/device/StorageManager$StorageType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000415 RID: 1045
			// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x00021248 File Offset: 0x0001F448
			internal static IntPtr class_ref
			{
				get
				{
					return StorageManager.StorageType._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000416 RID: 1046
			// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x0002126C File Offset: 0x0001F46C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return StorageManager.StorageType._members;
				}
			}

			// Token: 0x17000417 RID: 1047
			// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x00021274 File Offset: 0x0001F474
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return StorageManager.StorageType._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000418 RID: 1048
			// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x00021298 File Offset: 0x0001F498
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return StorageManager.StorageType._members.ManagedPeerType;
				}
			}

			// Token: 0x06000BB6 RID: 2998 RVA: 0x0000256C File Offset: 0x0000076C
			internal StorageType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000BB7 RID: 2999 RVA: 0x000212A4 File Offset: 0x0001F4A4
			[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/device/StorageManager$StorageType;", "")]
			public unsafe static StorageManager.StorageType ValueOf(string name)
			{
				IntPtr intPtr = JNIEnv.NewString(name);
				StorageManager.StorageType @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<StorageManager.StorageType>(StorageManager.StorageType._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/device/StorageManager$StorageType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06000BB8 RID: 3000 RVA: 0x00021310 File Offset: 0x0001F510
			[Register("values", "()[Lcom/unity3d/services/core/device/StorageManager$StorageType;", "")]
			public static StorageManager.StorageType[] Values()
			{
				return (StorageManager.StorageType[])JNIEnv.GetArray(StorageManager.StorageType._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/device/StorageManager$StorageType;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(StorageManager.StorageType));
			}

			// Token: 0x040002AA RID: 682
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/StorageManager$StorageType", typeof(StorageManager.StorageType));
		}
	}
}
