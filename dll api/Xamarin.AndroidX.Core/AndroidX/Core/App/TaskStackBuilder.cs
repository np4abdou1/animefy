using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;

namespace AndroidX.Core.App
{
	// Token: 0x02000086 RID: 134
	[Register("androidx/core/app/TaskStackBuilder", DoNotGenerateAcw = true)]
	public sealed class TaskStackBuilder : Java.Lang.Object, IIterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x0001726C File Offset: 0x0001546C
		internal static IntPtr class_ref
		{
			get
			{
				return TaskStackBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x00017290 File Offset: 0x00015490
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TaskStackBuilder._members;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x00017298 File Offset: 0x00015498
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TaskStackBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x000172BC File Offset: 0x000154BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TaskStackBuilder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00002384 File Offset: 0x00000584
		internal TaskStackBuilder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x000172C8 File Offset: 0x000154C8
		public int IntentCount
		{
			[Register("getIntentCount", "()I", "")]
			get
			{
				return TaskStackBuilder._members.InstanceMethods.InvokeAbstractInt32Method("getIntentCount.()I", this, null);
			}
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x000172E4 File Offset: 0x000154E4
		[Register("addNextIntent", "(Landroid/content/Intent;)Landroidx/core/app/TaskStackBuilder;", "")]
		public unsafe TaskStackBuilder AddNextIntent(Intent nextIntent)
		{
			TaskStackBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((nextIntent == null) ? IntPtr.Zero : nextIntent.Handle);
				@object = Java.Lang.Object.GetObject<TaskStackBuilder>(TaskStackBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("addNextIntent.(Landroid/content/Intent;)Landroidx/core/app/TaskStackBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(nextIntent);
			}
			return @object;
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00017358 File Offset: 0x00015558
		[Register("addNextIntentWithParentStack", "(Landroid/content/Intent;)Landroidx/core/app/TaskStackBuilder;", "")]
		public unsafe TaskStackBuilder AddNextIntentWithParentStack(Intent nextIntent)
		{
			TaskStackBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((nextIntent == null) ? IntPtr.Zero : nextIntent.Handle);
				@object = Java.Lang.Object.GetObject<TaskStackBuilder>(TaskStackBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("addNextIntentWithParentStack.(Landroid/content/Intent;)Landroidx/core/app/TaskStackBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(nextIntent);
			}
			return @object;
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x000173CC File Offset: 0x000155CC
		[Register("addParentStack", "(Landroid/app/Activity;)Landroidx/core/app/TaskStackBuilder;", "")]
		public unsafe TaskStackBuilder AddParentStack(Activity sourceActivity)
		{
			TaskStackBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((sourceActivity == null) ? IntPtr.Zero : sourceActivity.Handle);
				@object = Java.Lang.Object.GetObject<TaskStackBuilder>(TaskStackBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("addParentStack.(Landroid/app/Activity;)Landroidx/core/app/TaskStackBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(sourceActivity);
			}
			return @object;
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00017440 File Offset: 0x00015640
		[Register("addParentStack", "(Landroid/content/ComponentName;)Landroidx/core/app/TaskStackBuilder;", "")]
		public unsafe TaskStackBuilder AddParentStack(ComponentName sourceActivityName)
		{
			TaskStackBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((sourceActivityName == null) ? IntPtr.Zero : sourceActivityName.Handle);
				@object = Java.Lang.Object.GetObject<TaskStackBuilder>(TaskStackBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("addParentStack.(Landroid/content/ComponentName;)Landroidx/core/app/TaskStackBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(sourceActivityName);
			}
			return @object;
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x000174B4 File Offset: 0x000156B4
		[Register("addParentStack", "(Ljava/lang/Class;)Landroidx/core/app/TaskStackBuilder;", "")]
		public unsafe TaskStackBuilder AddParentStack(Class sourceActivityClass)
		{
			TaskStackBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((sourceActivityClass == null) ? IntPtr.Zero : sourceActivityClass.Handle);
				@object = Java.Lang.Object.GetObject<TaskStackBuilder>(TaskStackBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("addParentStack.(Ljava/lang/Class;)Landroidx/core/app/TaskStackBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(sourceActivityClass);
			}
			return @object;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00017528 File Offset: 0x00015728
		[Register("create", "(Landroid/content/Context;)Landroidx/core/app/TaskStackBuilder;", "")]
		public unsafe static TaskStackBuilder Create(Context context)
		{
			TaskStackBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<TaskStackBuilder>(TaskStackBuilder._members.StaticMethods.InvokeObjectMethod("create.(Landroid/content/Context;)Landroidx/core/app/TaskStackBuilder;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0001759C File Offset: 0x0001579C
		[Register("editIntentAt", "(I)Landroid/content/Intent;", "")]
		public unsafe Intent EditIntentAt(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<Intent>(TaskStackBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("editIntentAt.(I)Landroid/content/Intent;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x000175E8 File Offset: 0x000157E8
		[Register("from", "(Landroid/content/Context;)Landroidx/core/app/TaskStackBuilder;", "")]
		public unsafe static TaskStackBuilder From(Context context)
		{
			TaskStackBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<TaskStackBuilder>(TaskStackBuilder._members.StaticMethods.InvokeObjectMethod("from.(Landroid/content/Context;)Landroidx/core/app/TaskStackBuilder;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0001765C File Offset: 0x0001585C
		[Register("getIntent", "(I)Landroid/content/Intent;", "")]
		public unsafe Intent GetIntent(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<Intent>(TaskStackBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("getIntent.(I)Landroid/content/Intent;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x000176A8 File Offset: 0x000158A8
		[Register("getIntents", "()[Landroid/content/Intent;", "")]
		public Intent[] GetIntents()
		{
			return (Intent[])JNIEnv.GetArray(TaskStackBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("getIntents.()[Landroid/content/Intent;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Intent));
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x000176EC File Offset: 0x000158EC
		[Register("getPendingIntent", "(II)Landroid/app/PendingIntent;", "")]
		public unsafe PendingIntent GetPendingIntent(int requestCode, int flags)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(requestCode);
			ptr[1] = new JniArgumentValue(flags);
			return Java.Lang.Object.GetObject<PendingIntent>(TaskStackBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("getPendingIntent.(II)Landroid/app/PendingIntent;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00017748 File Offset: 0x00015948
		[Register("getPendingIntent", "(IILandroid/os/Bundle;)Landroid/app/PendingIntent;", "")]
		public unsafe PendingIntent GetPendingIntent(int requestCode, int flags, Bundle options)
		{
			PendingIntent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(requestCode);
				ptr[1] = new JniArgumentValue(flags);
				ptr[2] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				@object = Java.Lang.Object.GetObject<PendingIntent>(TaskStackBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("getPendingIntent.(IILandroid/os/Bundle;)Landroid/app/PendingIntent;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(options);
			}
			return @object;
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x000177E4 File Offset: 0x000159E4
		[Register("iterator", "()Ljava/util/Iterator;", "")]
		public IIterator Iterator()
		{
			return Java.Lang.Object.GetObject<IIterator>(TaskStackBuilder._members.InstanceMethods.InvokeAbstractObjectMethod("iterator.()Ljava/util/Iterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00017816 File Offset: 0x00015A16
		[Register("startActivities", "()V", "")]
		public void StartActivities()
		{
			TaskStackBuilder._members.InstanceMethods.InvokeAbstractVoidMethod("startActivities.()V", this, null);
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00017830 File Offset: 0x00015A30
		[Register("startActivities", "(Landroid/os/Bundle;)V", "")]
		public unsafe void StartActivities(Bundle options)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				TaskStackBuilder._members.InstanceMethods.InvokeAbstractVoidMethod("startActivities.(Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(options);
			}
		}

		// Token: 0x040001F6 RID: 502
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/TaskStackBuilder", typeof(TaskStackBuilder));

		// Token: 0x02000087 RID: 135
		[Register("androidx/core/app/TaskStackBuilder$SupportParentable", "", "AndroidX.Core.App.TaskStackBuilder/ISupportParentableInvoker")]
		public interface ISupportParentable : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000162 RID: 354
			// (get) Token: 0x060007A7 RID: 1959
			Intent SupportParentActivityIntent { [Register("getSupportParentActivityIntent", "()Landroid/content/Intent;", "GetGetSupportParentActivityIntentHandler:AndroidX.Core.App.TaskStackBuilder/ISupportParentableInvoker, Xamarin.AndroidX.Core")] get; }
		}

		// Token: 0x02000088 RID: 136
		[Register("androidx/core/app/TaskStackBuilder$SupportParentable", DoNotGenerateAcw = true)]
		internal class ISupportParentableInvoker : Java.Lang.Object, TaskStackBuilder.ISupportParentable, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000163 RID: 355
			// (get) Token: 0x060007A8 RID: 1960 RVA: 0x000178B0 File Offset: 0x00015AB0
			private static IntPtr java_class_ref
			{
				get
				{
					return TaskStackBuilder.ISupportParentableInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000164 RID: 356
			// (get) Token: 0x060007A9 RID: 1961 RVA: 0x000178D4 File Offset: 0x00015AD4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return TaskStackBuilder.ISupportParentableInvoker._members;
				}
			}

			// Token: 0x17000165 RID: 357
			// (get) Token: 0x060007AA RID: 1962 RVA: 0x000178DB File Offset: 0x00015ADB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000166 RID: 358
			// (get) Token: 0x060007AB RID: 1963 RVA: 0x000178E3 File Offset: 0x00015AE3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return TaskStackBuilder.ISupportParentableInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060007AC RID: 1964 RVA: 0x000178EF File Offset: 0x00015AEF
			public static TaskStackBuilder.ISupportParentable GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<TaskStackBuilder.ISupportParentable>(handle, transfer);
			}

			// Token: 0x060007AD RID: 1965 RVA: 0x000178F8 File Offset: 0x00015AF8
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, TaskStackBuilder.ISupportParentableInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.app.TaskStackBuilder.SupportParentable'.");
				}
				return handle;
			}

			// Token: 0x060007AE RID: 1966 RVA: 0x00017923 File Offset: 0x00015B23
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060007AF RID: 1967 RVA: 0x00017954 File Offset: 0x00015B54
			public ISupportParentableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(TaskStackBuilder.ISupportParentableInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060007B0 RID: 1968 RVA: 0x0001798C File Offset: 0x00015B8C
			private static Delegate GetGetSupportParentActivityIntentHandler()
			{
				if (TaskStackBuilder.ISupportParentableInvoker.cb_getSupportParentActivityIntent == null)
				{
					TaskStackBuilder.ISupportParentableInvoker.cb_getSupportParentActivityIntent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TaskStackBuilder.ISupportParentableInvoker.n_GetSupportParentActivityIntent));
				}
				return TaskStackBuilder.ISupportParentableInvoker.cb_getSupportParentActivityIntent;
			}

			// Token: 0x060007B1 RID: 1969 RVA: 0x000179B0 File Offset: 0x00015BB0
			private static IntPtr n_GetSupportParentActivityIntent(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TaskStackBuilder.ISupportParentable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportParentActivityIntent);
			}

			// Token: 0x17000167 RID: 359
			// (get) Token: 0x060007B2 RID: 1970 RVA: 0x000179C4 File Offset: 0x00015BC4
			public Intent SupportParentActivityIntent
			{
				get
				{
					if (this.id_getSupportParentActivityIntent == IntPtr.Zero)
					{
						this.id_getSupportParentActivityIntent = JNIEnv.GetMethodID(this.class_ref, "getSupportParentActivityIntent", "()Landroid/content/Intent;");
					}
					return Java.Lang.Object.GetObject<Intent>(JNIEnv.CallObjectMethod(base.Handle, this.id_getSupportParentActivityIntent), JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x040001F7 RID: 503
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/TaskStackBuilder$SupportParentable", typeof(TaskStackBuilder.ISupportParentableInvoker));

			// Token: 0x040001F8 RID: 504
			private IntPtr class_ref;

			// Token: 0x040001F9 RID: 505
			private static Delegate cb_getSupportParentActivityIntent;

			// Token: 0x040001FA RID: 506
			private IntPtr id_getSupportParentActivityIntent;
		}
	}
}
