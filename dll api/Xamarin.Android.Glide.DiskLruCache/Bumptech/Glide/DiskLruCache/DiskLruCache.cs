using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Bumptech.Glide.DiskLruCache
{
	// Token: 0x02000004 RID: 4
	[Register("com/bumptech/glide/disklrucache/DiskLruCache", DoNotGenerateAcw = true)]
	public sealed class DiskLruCache : Java.Lang.Object, ICloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000020E4 File Offset: 0x000002E4
		internal static IntPtr class_ref
		{
			get
			{
				return DiskLruCache._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002108 File Offset: 0x00000308
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DiskLruCache._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002110 File Offset: 0x00000310
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DiskLruCache._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002134 File Offset: 0x00000334
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DiskLruCache._members.ManagedPeerType;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002140 File Offset: 0x00000340
		internal DiskLruCache(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11 RVA: 0x0000214C File Offset: 0x0000034C
		public File Directory
		{
			[Register("getDirectory", "()Ljava/io/File;", "")]
			get
			{
				return Java.Lang.Object.GetObject<File>(DiskLruCache._members.InstanceMethods.InvokeAbstractObjectMethod("getDirectory.()Ljava/io/File;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x0000217E File Offset: 0x0000037E
		public bool IsClosed
		{
			[Register("isClosed", "()Z", "")]
			get
			{
				return DiskLruCache._members.InstanceMethods.InvokeAbstractBooleanMethod("isClosed.()Z", this, null);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002197 File Offset: 0x00000397
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000021B0 File Offset: 0x000003B0
		public unsafe long MaxSize
		{
			[Register("getMaxSize", "()J", "")]
			get
			{
				return DiskLruCache._members.InstanceMethods.InvokeAbstractInt64Method("getMaxSize.()J", this, null);
			}
			[Register("setMaxSize", "(J)V", "")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				DiskLruCache._members.InstanceMethods.InvokeAbstractVoidMethod("setMaxSize.(J)V", this, ptr);
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000021EB File Offset: 0x000003EB
		[Register("close", "()V", "")]
		public void Close()
		{
			DiskLruCache._members.InstanceMethods.InvokeAbstractVoidMethod("close.()V", this, null);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002204 File Offset: 0x00000404
		[Register("delete", "()V", "")]
		public void Delete()
		{
			DiskLruCache._members.InstanceMethods.InvokeAbstractVoidMethod("delete.()V", this, null);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002220 File Offset: 0x00000420
		[Register("edit", "(Ljava/lang/String;)Lcom/bumptech/glide/disklrucache/DiskLruCache$Editor;", "")]
		public unsafe DiskLruCache.Editor Edit(string key)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			DiskLruCache.Editor @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<DiskLruCache.Editor>(DiskLruCache._members.InstanceMethods.InvokeAbstractObjectMethod("edit.(Ljava/lang/String;)Lcom/bumptech/glide/disklrucache/DiskLruCache$Editor;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000228C File Offset: 0x0000048C
		[Register("flush", "()V", "")]
		public void Flush()
		{
			DiskLruCache._members.InstanceMethods.InvokeAbstractVoidMethod("flush.()V", this, null);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000022A8 File Offset: 0x000004A8
		[Register("get", "(Ljava/lang/String;)Lcom/bumptech/glide/disklrucache/DiskLruCache$Value;", "")]
		public unsafe DiskLruCache.Value Get(string key)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			DiskLruCache.Value @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<DiskLruCache.Value>(DiskLruCache._members.InstanceMethods.InvokeAbstractObjectMethod("get.(Ljava/lang/String;)Lcom/bumptech/glide/disklrucache/DiskLruCache$Value;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002314 File Offset: 0x00000514
		[Register("open", "(Ljava/io/File;IIJ)Lcom/bumptech/glide/disklrucache/DiskLruCache;", "")]
		public unsafe static DiskLruCache Open(File directory, int appVersion, int valueCount, long maxSize)
		{
			DiskLruCache @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((directory == null) ? IntPtr.Zero : directory.Handle);
				ptr[1] = new JniArgumentValue(appVersion);
				ptr[2] = new JniArgumentValue(valueCount);
				ptr[3] = new JniArgumentValue(maxSize);
				@object = Java.Lang.Object.GetObject<DiskLruCache>(DiskLruCache._members.StaticMethods.InvokeObjectMethod("open.(Ljava/io/File;IIJ)Lcom/bumptech/glide/disklrucache/DiskLruCache;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(directory);
			}
			return @object;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000023C8 File Offset: 0x000005C8
		[Register("remove", "(Ljava/lang/String;)Z", "")]
		public unsafe bool Remove(string key)
		{
			IntPtr intPtr = JNIEnv.NewString(key);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = DiskLruCache._members.InstanceMethods.InvokeAbstractBooleanMethod("remove.(Ljava/lang/String;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002428 File Offset: 0x00000628
		[Register("size", "()J", "")]
		public long Size()
		{
			return DiskLruCache._members.InstanceMethods.InvokeAbstractInt64Method("size.()J", this, null);
		}

		// Token: 0x04000002 RID: 2
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/disklrucache/DiskLruCache", typeof(DiskLruCache));

		// Token: 0x02000005 RID: 5
		[Register("com/bumptech/glide/disklrucache/DiskLruCache$Editor", DoNotGenerateAcw = true)]
		public sealed class Editor : Java.Lang.Object
		{
			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000018 RID: 24 RVA: 0x0000245C File Offset: 0x0000065C
			internal static IntPtr class_ref
			{
				get
				{
					return DiskLruCache.Editor._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000019 RID: 25 RVA: 0x00002480 File Offset: 0x00000680
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return DiskLruCache.Editor._members;
				}
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x0600001A RID: 26 RVA: 0x00002488 File Offset: 0x00000688
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return DiskLruCache.Editor._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x0600001B RID: 27 RVA: 0x000024AC File Offset: 0x000006AC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return DiskLruCache.Editor._members.ManagedPeerType;
				}
			}

			// Token: 0x0600001C RID: 28 RVA: 0x000024B8 File Offset: 0x000006B8
			internal Editor(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600001D RID: 29 RVA: 0x000024C2 File Offset: 0x000006C2
			[Register("abort", "()V", "")]
			public void Abort()
			{
				DiskLruCache.Editor._members.InstanceMethods.InvokeAbstractVoidMethod("abort.()V", this, null);
			}

			// Token: 0x0600001E RID: 30 RVA: 0x000024DB File Offset: 0x000006DB
			[Register("abortUnlessCommitted", "()V", "")]
			public void AbortUnlessCommitted()
			{
				DiskLruCache.Editor._members.InstanceMethods.InvokeAbstractVoidMethod("abortUnlessCommitted.()V", this, null);
			}

			// Token: 0x0600001F RID: 31 RVA: 0x000024F4 File Offset: 0x000006F4
			[Register("commit", "()V", "")]
			public void Commit()
			{
				DiskLruCache.Editor._members.InstanceMethods.InvokeAbstractVoidMethod("commit.()V", this, null);
			}

			// Token: 0x06000020 RID: 32 RVA: 0x00002510 File Offset: 0x00000710
			[Register("getFile", "(I)Ljava/io/File;", "")]
			public unsafe File GetFile(int index)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(index);
				return Java.Lang.Object.GetObject<File>(DiskLruCache.Editor._members.InstanceMethods.InvokeAbstractObjectMethod("getFile.(I)Ljava/io/File;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000021 RID: 33 RVA: 0x0000255C File Offset: 0x0000075C
			[Register("getString", "(I)Ljava/lang/String;", "")]
			public unsafe string GetString(int index)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(index);
				return JNIEnv.GetString(DiskLruCache.Editor._members.InstanceMethods.InvokeAbstractObjectMethod("getString.(I)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000022 RID: 34 RVA: 0x000025A8 File Offset: 0x000007A8
			[Register("set", "(ILjava/lang/String;)V", "")]
			public unsafe void Set(int index, string value)
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(index);
					ptr[1] = new JniArgumentValue(intPtr);
					DiskLruCache.Editor._members.InstanceMethods.InvokeAbstractVoidMethod("set.(ILjava/lang/String;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}

			// Token: 0x04000003 RID: 3
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/disklrucache/DiskLruCache$Editor", typeof(DiskLruCache.Editor));
		}

		// Token: 0x02000006 RID: 6
		[Register("com/bumptech/glide/disklrucache/DiskLruCache$Value", DoNotGenerateAcw = true)]
		public sealed class Value : Java.Lang.Object
		{
			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000024 RID: 36 RVA: 0x00002634 File Offset: 0x00000834
			internal static IntPtr class_ref
			{
				get
				{
					return DiskLruCache.Value._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000025 RID: 37 RVA: 0x00002658 File Offset: 0x00000858
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return DiskLruCache.Value._members;
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000026 RID: 38 RVA: 0x00002660 File Offset: 0x00000860
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return DiskLruCache.Value._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000027 RID: 39 RVA: 0x00002684 File Offset: 0x00000884
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return DiskLruCache.Value._members.ManagedPeerType;
				}
			}

			// Token: 0x06000028 RID: 40 RVA: 0x00002690 File Offset: 0x00000890
			internal Value(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000029 RID: 41 RVA: 0x0000269C File Offset: 0x0000089C
			[Register("edit", "()Lcom/bumptech/glide/disklrucache/DiskLruCache$Editor;", "")]
			public DiskLruCache.Editor Edit()
			{
				return Java.Lang.Object.GetObject<DiskLruCache.Editor>(DiskLruCache.Value._members.InstanceMethods.InvokeAbstractObjectMethod("edit.()Lcom/bumptech/glide/disklrucache/DiskLruCache$Editor;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600002A RID: 42 RVA: 0x000026D0 File Offset: 0x000008D0
			[Register("getFile", "(I)Ljava/io/File;", "")]
			public unsafe File GetFile(int index)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(index);
				return Java.Lang.Object.GetObject<File>(DiskLruCache.Value._members.InstanceMethods.InvokeAbstractObjectMethod("getFile.(I)Ljava/io/File;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600002B RID: 43 RVA: 0x0000271C File Offset: 0x0000091C
			[Register("getLength", "(I)J", "")]
			public unsafe long GetLength(int index)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(index);
				return DiskLruCache.Value._members.InstanceMethods.InvokeAbstractInt64Method("getLength.(I)J", this, ptr);
			}

			// Token: 0x0600002C RID: 44 RVA: 0x00002758 File Offset: 0x00000958
			[Register("getString", "(I)Ljava/lang/String;", "")]
			public unsafe string GetString(int index)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(index);
				return JNIEnv.GetString(DiskLruCache.Value._members.InstanceMethods.InvokeAbstractObjectMethod("getString.(I)Ljava/lang/String;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000004 RID: 4
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/disklrucache/DiskLruCache$Value", typeof(DiskLruCache.Value));
		}
	}
}
