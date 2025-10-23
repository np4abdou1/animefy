using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Dagger.Internal
{
	// Token: 0x020000EB RID: 235
	[Register("com/google/android/datatransport/runtime/dagger/internal/MapBuilder", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"K",
		"V"
	})]
	public sealed class MapBuilder : Java.Lang.Object
	{
		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x00017284 File Offset: 0x00015484
		internal static IntPtr class_ref
		{
			get
			{
				return MapBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x000172A8 File Offset: 0x000154A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MapBuilder._members;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x000172B0 File Offset: 0x000154B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MapBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x000172D4 File Offset: 0x000154D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MapBuilder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x000026C4 File Offset: 0x000008C4
		internal MapBuilder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x000172E0 File Offset: 0x000154E0
		[Register("build", "()Ljava/util/Map;", "")]
		public IDictionary Build()
		{
			return JavaDictionary.FromJniHandle(MapBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("build.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00017314 File Offset: 0x00015514
		[Register("newMapBuilder", "(I)Lcom/google/android/datatransport/runtime/dagger/internal/MapBuilder;", "")]
		[JavaTypeParameters(new string[]
		{
			"K",
			"V"
		})]
		public unsafe static MapBuilder NewMapBuilder(int size)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(size);
			return Java.Lang.Object.GetObject<MapBuilder>(MapBuilder._members.StaticMethods.InvokeObjectMethod("newMapBuilder.(I)Lcom/google/android/datatransport/runtime/dagger/internal/MapBuilder;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x0001735C File Offset: 0x0001555C
		[Register("put", "(Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/android/datatransport/runtime/dagger/internal/MapBuilder;", "")]
		public unsafe MapBuilder Put(Java.Lang.Object key, Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(key);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(value);
			MapBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<MapBuilder>(MapBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("put.(Ljava/lang/Object;Ljava/lang/Object;)Lcom/google/android/datatransport/runtime/dagger/internal/MapBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(key);
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x000173F8 File Offset: 0x000155F8
		[Register("putAll", "(Ljava/util/Map;)Lcom/google/android/datatransport/runtime/dagger/internal/MapBuilder;", "")]
		public unsafe MapBuilder PutAll(IDictionary map)
		{
			IntPtr intPtr = JavaDictionary.ToLocalJniHandle(map);
			MapBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<MapBuilder>(MapBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("putAll.(Ljava/util/Map;)Lcom/google/android/datatransport/runtime/dagger/internal/MapBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(map);
			}
			return @object;
		}

		// Token: 0x04000260 RID: 608
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/dagger/internal/MapBuilder", typeof(MapBuilder));
	}
}
