using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Net;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.Core.Content;
using AndroidX.Core.View;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.App
{
	// Token: 0x0200005E RID: 94
	[Register("androidx/core/app/ActivityCompat", DoNotGenerateAcw = true)]
	public class ActivityCompat : ContextCompat
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00009EC4 File Offset: 0x000080C4
		internal new static IntPtr class_ref
		{
			get
			{
				return ActivityCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00009EE8 File Offset: 0x000080E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ActivityCompat._members;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000393 RID: 915 RVA: 0x00009EF0 File Offset: 0x000080F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ActivityCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00009F14 File Offset: 0x00008114
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ActivityCompat._members.ManagedPeerType;
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00009F20 File Offset: 0x00008120
		protected ActivityCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00009F2C File Offset: 0x0000812C
		[Register(".ctor", "()V", "")]
		protected ActivityCompat() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ActivityCompat._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ActivityCompat._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000397 RID: 919 RVA: 0x00009F9C File Offset: 0x0000819C
		// (set) Token: 0x06000398 RID: 920 RVA: 0x00009FD0 File Offset: 0x000081D0
		public unsafe static ActivityCompat.IPermissionCompatDelegate PermissionCompatDelegate
		{
			[Register("getPermissionCompatDelegate", "()Landroidx/core/app/ActivityCompat$PermissionCompatDelegate;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ActivityCompat.IPermissionCompatDelegate>(ActivityCompat._members.StaticMethods.InvokeObjectMethod("getPermissionCompatDelegate.()Landroidx/core/app/ActivityCompat$PermissionCompatDelegate;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setPermissionCompatDelegate", "(Landroidx/core/app/ActivityCompat$PermissionCompatDelegate;)V", "")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : ((Java.Lang.Object)value).Handle);
					ActivityCompat._members.StaticMethods.InvokeVoidMethod("setPermissionCompatDelegate.(Landroidx/core/app/ActivityCompat$PermissionCompatDelegate;)V", ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000A038 File Offset: 0x00008238
		[Register("finishAffinity", "(Landroid/app/Activity;)V", "")]
		public unsafe static void FinishAffinity(Activity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ActivityCompat._members.StaticMethods.InvokeVoidMethod("finishAffinity.(Landroid/app/Activity;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000A09C File Offset: 0x0000829C
		[Register("finishAfterTransition", "(Landroid/app/Activity;)V", "")]
		public unsafe static void FinishAfterTransition(Activity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ActivityCompat._members.StaticMethods.InvokeVoidMethod("finishAfterTransition.(Landroid/app/Activity;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000A100 File Offset: 0x00008300
		[Register("getReferrer", "(Landroid/app/Activity;)Landroid/net/Uri;", "")]
		public unsafe static Android.Net.Uri GetReferrer(Activity activity)
		{
			Android.Net.Uri @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				@object = Java.Lang.Object.GetObject<Android.Net.Uri>(ActivityCompat._members.StaticMethods.InvokeObjectMethod("getReferrer.(Landroid/app/Activity;)Landroid/net/Uri;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
			return @object;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000A174 File Offset: 0x00008374
		[Register("invalidateOptionsMenu", "(Landroid/app/Activity;)Z", "")]
		public unsafe static bool InvalidateOptionsMenu(Activity activity)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				result = ActivityCompat._members.StaticMethods.InvokeBooleanMethod("invalidateOptionsMenu.(Landroid/app/Activity;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
			return result;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000A1D8 File Offset: 0x000083D8
		[Register("isLaunchedFromBubble", "(Landroid/app/Activity;)Z", "")]
		public unsafe static bool IsLaunchedFromBubble(Activity activity)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				result = ActivityCompat._members.StaticMethods.InvokeBooleanMethod("isLaunchedFromBubble.(Landroid/app/Activity;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
			return result;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000A23C File Offset: 0x0000843C
		[Register("postponeEnterTransition", "(Landroid/app/Activity;)V", "")]
		public unsafe static void PostponeEnterTransition(Activity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ActivityCompat._members.StaticMethods.InvokeVoidMethod("postponeEnterTransition.(Landroid/app/Activity;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000A2A0 File Offset: 0x000084A0
		[Register("recreate", "(Landroid/app/Activity;)V", "")]
		public unsafe static void Recreate(Activity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ActivityCompat._members.StaticMethods.InvokeVoidMethod("recreate.(Landroid/app/Activity;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000A304 File Offset: 0x00008504
		[Register("requestDragAndDropPermissions", "(Landroid/app/Activity;Landroid/view/DragEvent;)Landroidx/core/view/DragAndDropPermissionsCompat;", "")]
		public unsafe static DragAndDropPermissionsCompat RequestDragAndDropPermissions(Activity activity, DragEvent dragEvent)
		{
			DragAndDropPermissionsCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue((dragEvent == null) ? IntPtr.Zero : dragEvent.Handle);
				@object = Java.Lang.Object.GetObject<DragAndDropPermissionsCompat>(ActivityCompat._members.StaticMethods.InvokeObjectMethod("requestDragAndDropPermissions.(Landroid/app/Activity;Landroid/view/DragEvent;)Landroidx/core/view/DragAndDropPermissionsCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(activity);
				GC.KeepAlive(dragEvent);
			}
			return @object;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000A3A0 File Offset: 0x000085A0
		[Register("requestPermissions", "(Landroid/app/Activity;[Ljava/lang/String;I)V", "")]
		public unsafe static void RequestPermissions(Activity activity, string[] permissions, int requestCode)
		{
			IntPtr intPtr = JNIEnv.NewArray(permissions);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(requestCode);
				ActivityCompat._members.StaticMethods.InvokeVoidMethod("requestPermissions.(Landroid/app/Activity;[Ljava/lang/String;I)V", ptr);
			}
			finally
			{
				if (permissions != null)
				{
					JNIEnv.CopyArray(intPtr, permissions);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(activity);
				GC.KeepAlive(permissions);
			}
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000A448 File Offset: 0x00008648
		[Register("requireViewById", "(Landroid/app/Activity;I)Landroid/view/View;", "")]
		[JavaTypeParameters(new string[]
		{
			"T extends android.view.View"
		})]
		public unsafe static Java.Lang.Object RequireViewById(Activity activity, int id)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue(id);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ActivityCompat._members.StaticMethods.InvokeObjectMethod("requireViewById.(Landroid/app/Activity;I)Landroid/view/View;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
			return @object;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000A4D0 File Offset: 0x000086D0
		[Register("setEnterSharedElementCallback", "(Landroid/app/Activity;Landroidx/core/app/SharedElementCallback;)V", "")]
		public unsafe static void SetEnterSharedElementCallback(Activity activity, SharedElementCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				ActivityCompat._members.StaticMethods.InvokeVoidMethod("setEnterSharedElementCallback.(Landroid/app/Activity;Landroidx/core/app/SharedElementCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000A55C File Offset: 0x0000875C
		[Register("setExitSharedElementCallback", "(Landroid/app/Activity;Landroidx/core/app/SharedElementCallback;)V", "")]
		public unsafe static void SetExitSharedElementCallback(Activity activity, SharedElementCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				ActivityCompat._members.StaticMethods.InvokeVoidMethod("setExitSharedElementCallback.(Landroid/app/Activity;Landroidx/core/app/SharedElementCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000A5E8 File Offset: 0x000087E8
		[Register("setLocusContext", "(Landroid/app/Activity;Landroidx/core/content/LocusIdCompat;Landroid/os/Bundle;)V", "")]
		public unsafe static void SetLocusContext(Activity activity, LocusIdCompat locusId, Bundle bundle)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue((locusId == null) ? IntPtr.Zero : locusId.Handle);
				ptr[2] = new JniArgumentValue((bundle == null) ? IntPtr.Zero : bundle.Handle);
				ActivityCompat._members.StaticMethods.InvokeVoidMethod("setLocusContext.(Landroid/app/Activity;Landroidx/core/content/LocusIdCompat;Landroid/os/Bundle;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
				GC.KeepAlive(locusId);
				GC.KeepAlive(bundle);
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000A6A0 File Offset: 0x000088A0
		[Register("shouldShowRequestPermissionRationale", "(Landroid/app/Activity;Ljava/lang/String;)Z", "")]
		public unsafe static bool ShouldShowRequestPermissionRationale(Activity activity, string permission)
		{
			IntPtr intPtr = JNIEnv.NewString(permission);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = ActivityCompat._members.StaticMethods.InvokeBooleanMethod("shouldShowRequestPermissionRationale.(Landroid/app/Activity;Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(activity);
			}
			return result;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000A724 File Offset: 0x00008924
		[Register("startActivityForResult", "(Landroid/app/Activity;Landroid/content/Intent;ILandroid/os/Bundle;)V", "")]
		public unsafe static void StartActivityForResult(Activity activity, Intent intent, int requestCode, Bundle options)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				ptr[2] = new JniArgumentValue(requestCode);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				ActivityCompat._members.StaticMethods.InvokeVoidMethod("startActivityForResult.(Landroid/app/Activity;Landroid/content/Intent;ILandroid/os/Bundle;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
				GC.KeepAlive(intent);
				GC.KeepAlive(options);
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000A7F0 File Offset: 0x000089F0
		[Register("startIntentSenderForResult", "(Landroid/app/Activity;Landroid/content/IntentSender;ILandroid/content/Intent;IIILandroid/os/Bundle;)V", "")]
		public unsafe static void StartIntentSenderForResult(Activity activity, IntentSender intent, int requestCode, Intent fillInIntent, int flagsMask, int flagsValues, int extraFlags, Bundle options)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				ptr[2] = new JniArgumentValue(requestCode);
				ptr[3] = new JniArgumentValue((fillInIntent == null) ? IntPtr.Zero : fillInIntent.Handle);
				ptr[4] = new JniArgumentValue(flagsMask);
				ptr[5] = new JniArgumentValue(flagsValues);
				ptr[6] = new JniArgumentValue(extraFlags);
				ptr[7] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				ActivityCompat._members.StaticMethods.InvokeVoidMethod("startIntentSenderForResult.(Landroid/app/Activity;Landroid/content/IntentSender;ILandroid/content/Intent;IIILandroid/os/Bundle;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
				GC.KeepAlive(intent);
				GC.KeepAlive(fillInIntent);
				GC.KeepAlive(options);
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000A93C File Offset: 0x00008B3C
		[Register("startPostponedEnterTransition", "(Landroid/app/Activity;)V", "")]
		public unsafe static void StartPostponedEnterTransition(Activity activity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ActivityCompat._members.StaticMethods.InvokeVoidMethod("startPostponedEnterTransition.(Landroid/app/Activity;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(activity);
			}
		}

		// Token: 0x040000F5 RID: 245
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/ActivityCompat", typeof(ActivityCompat));

		// Token: 0x0200005F RID: 95
		[Register("androidx/core/app/ActivityCompat$OnRequestPermissionsResultCallback", "", "AndroidX.Core.App.ActivityCompat/IOnRequestPermissionsResultCallbackInvoker")]
		public interface IOnRequestPermissionsResultCallback : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060003AB RID: 939
			[Register("onRequestPermissionsResult", "(I[Ljava/lang/String;[I)V", "GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler:AndroidX.Core.App.ActivityCompat/IOnRequestPermissionsResultCallbackInvoker, Xamarin.AndroidX.Core")]
			void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults);
		}

		// Token: 0x02000060 RID: 96
		[Register("androidx/core/app/ActivityCompat$OnRequestPermissionsResultCallback", DoNotGenerateAcw = true)]
		internal class IOnRequestPermissionsResultCallbackInvoker : Java.Lang.Object, ActivityCompat.IOnRequestPermissionsResultCallback, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000096 RID: 150
			// (get) Token: 0x060003AC RID: 940 RVA: 0x0000A9BC File Offset: 0x00008BBC
			private static IntPtr java_class_ref
			{
				get
				{
					return ActivityCompat.IOnRequestPermissionsResultCallbackInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x060003AD RID: 941 RVA: 0x0000A9E0 File Offset: 0x00008BE0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ActivityCompat.IOnRequestPermissionsResultCallbackInvoker._members;
				}
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x060003AE RID: 942 RVA: 0x0000A9E7 File Offset: 0x00008BE7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x060003AF RID: 943 RVA: 0x0000A9EF File Offset: 0x00008BEF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ActivityCompat.IOnRequestPermissionsResultCallbackInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060003B0 RID: 944 RVA: 0x0000A9FB File Offset: 0x00008BFB
			public static ActivityCompat.IOnRequestPermissionsResultCallback GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ActivityCompat.IOnRequestPermissionsResultCallback>(handle, transfer);
			}

			// Token: 0x060003B1 RID: 945 RVA: 0x0000AA04 File Offset: 0x00008C04
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ActivityCompat.IOnRequestPermissionsResultCallbackInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.app.ActivityCompat.OnRequestPermissionsResultCallback'.");
				}
				return handle;
			}

			// Token: 0x060003B2 RID: 946 RVA: 0x0000AA2F File Offset: 0x00008C2F
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060003B3 RID: 947 RVA: 0x0000AA60 File Offset: 0x00008C60
			public IOnRequestPermissionsResultCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ActivityCompat.IOnRequestPermissionsResultCallbackInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060003B4 RID: 948 RVA: 0x0000AA98 File Offset: 0x00008C98
			private static Delegate GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler()
			{
				if (ActivityCompat.IOnRequestPermissionsResultCallbackInvoker.cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI == null)
				{
					ActivityCompat.IOnRequestPermissionsResultCallbackInvoker.cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILL_V(ActivityCompat.IOnRequestPermissionsResultCallbackInvoker.n_OnRequestPermissionsResult_IarrayLjava_lang_String_arrayI));
				}
				return ActivityCompat.IOnRequestPermissionsResultCallbackInvoker.cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;
			}

			// Token: 0x060003B5 RID: 949 RVA: 0x0000AABC File Offset: 0x00008CBC
			private static void n_OnRequestPermissionsResult_IarrayLjava_lang_String_arrayI(IntPtr jnienv, IntPtr native__this, int requestCode, IntPtr native_permissions, IntPtr native_grantResults)
			{
				ActivityCompat.IOnRequestPermissionsResultCallback @object = Java.Lang.Object.GetObject<ActivityCompat.IOnRequestPermissionsResultCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string[] array = (string[])JNIEnv.GetArray(native_permissions, JniHandleOwnership.DoNotTransfer, typeof(string));
				Permission[] array2 = (Permission[])JNIEnv.GetArray(native_grantResults, JniHandleOwnership.DoNotTransfer, typeof(Permission));
				@object.OnRequestPermissionsResult(requestCode, array, array2);
				if (array != null)
				{
					JNIEnv.CopyArray(array, native_permissions);
				}
				if (array2 != null)
				{
					JNIEnv.CopyArray<Permission>(array2, native_grantResults);
				}
			}

			// Token: 0x060003B6 RID: 950 RVA: 0x0000AB20 File Offset: 0x00008D20
			public unsafe void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
			{
				if (this.id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI == IntPtr.Zero)
				{
					this.id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI = JNIEnv.GetMethodID(this.class_ref, "onRequestPermissionsResult", "(I[Ljava/lang/String;[I)V");
				}
				IntPtr intPtr = JNIEnv.NewArray(permissions);
				IntPtr intPtr2 = JNIEnv.NewArray<Permission>(grantResults);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(requestCode);
				ptr[1] = new JValue(intPtr);
				ptr[2] = new JValue(intPtr2);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI, ptr);
				if (permissions != null)
				{
					JNIEnv.CopyArray(intPtr, permissions);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				if (grantResults != null)
				{
					JNIEnv.CopyArray<Permission>(intPtr2, grantResults);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
			}

			// Token: 0x040000F6 RID: 246
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/ActivityCompat$OnRequestPermissionsResultCallback", typeof(ActivityCompat.IOnRequestPermissionsResultCallbackInvoker));

			// Token: 0x040000F7 RID: 247
			private IntPtr class_ref;

			// Token: 0x040000F8 RID: 248
			private static Delegate cb_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;

			// Token: 0x040000F9 RID: 249
			private IntPtr id_onRequestPermissionsResult_IarrayLjava_lang_String_arrayI;
		}

		// Token: 0x02000061 RID: 97
		[Register("androidx/core/app/ActivityCompat$PermissionCompatDelegate", "", "AndroidX.Core.App.ActivityCompat/IPermissionCompatDelegateInvoker")]
		public interface IPermissionCompatDelegate : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060003B8 RID: 952
			[Register("onActivityResult", "(Landroid/app/Activity;IILandroid/content/Intent;)Z", "GetOnActivityResult_Landroid_app_Activity_IILandroid_content_Intent_Handler:AndroidX.Core.App.ActivityCompat/IPermissionCompatDelegateInvoker, Xamarin.AndroidX.Core")]
			bool OnActivityResult(Activity activity, int requestCode, int resultCode, Intent data);

			// Token: 0x060003B9 RID: 953
			[Register("requestPermissions", "(Landroid/app/Activity;[Ljava/lang/String;I)Z", "GetRequestPermissions_Landroid_app_Activity_arrayLjava_lang_String_IHandler:AndroidX.Core.App.ActivityCompat/IPermissionCompatDelegateInvoker, Xamarin.AndroidX.Core")]
			bool RequestPermissions(Activity activity, string[] permissions, int requestCode);
		}

		// Token: 0x02000062 RID: 98
		[Register("androidx/core/app/ActivityCompat$PermissionCompatDelegate", DoNotGenerateAcw = true)]
		internal class IPermissionCompatDelegateInvoker : Java.Lang.Object, ActivityCompat.IPermissionCompatDelegate, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700009A RID: 154
			// (get) Token: 0x060003BA RID: 954 RVA: 0x0000ABF8 File Offset: 0x00008DF8
			private static IntPtr java_class_ref
			{
				get
				{
					return ActivityCompat.IPermissionCompatDelegateInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x060003BB RID: 955 RVA: 0x0000AC1C File Offset: 0x00008E1C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ActivityCompat.IPermissionCompatDelegateInvoker._members;
				}
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x060003BC RID: 956 RVA: 0x0000AC23 File Offset: 0x00008E23
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x060003BD RID: 957 RVA: 0x0000AC2B File Offset: 0x00008E2B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ActivityCompat.IPermissionCompatDelegateInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060003BE RID: 958 RVA: 0x0000AC37 File Offset: 0x00008E37
			public static ActivityCompat.IPermissionCompatDelegate GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ActivityCompat.IPermissionCompatDelegate>(handle, transfer);
			}

			// Token: 0x060003BF RID: 959 RVA: 0x0000AC40 File Offset: 0x00008E40
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ActivityCompat.IPermissionCompatDelegateInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.app.ActivityCompat.PermissionCompatDelegate'.");
				}
				return handle;
			}

			// Token: 0x060003C0 RID: 960 RVA: 0x0000AC6B File Offset: 0x00008E6B
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060003C1 RID: 961 RVA: 0x0000AC9C File Offset: 0x00008E9C
			public IPermissionCompatDelegateInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ActivityCompat.IPermissionCompatDelegateInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060003C2 RID: 962 RVA: 0x0000ACD4 File Offset: 0x00008ED4
			private static Delegate GetOnActivityResult_Landroid_app_Activity_IILandroid_content_Intent_Handler()
			{
				if (ActivityCompat.IPermissionCompatDelegateInvoker.cb_onActivityResult_Landroid_app_Activity_IILandroid_content_Intent_ == null)
				{
					ActivityCompat.IPermissionCompatDelegateInvoker.cb_onActivityResult_Landroid_app_Activity_IILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_Z(ActivityCompat.IPermissionCompatDelegateInvoker.n_OnActivityResult_Landroid_app_Activity_IILandroid_content_Intent_));
				}
				return ActivityCompat.IPermissionCompatDelegateInvoker.cb_onActivityResult_Landroid_app_Activity_IILandroid_content_Intent_;
			}

			// Token: 0x060003C3 RID: 963 RVA: 0x0000ACF8 File Offset: 0x00008EF8
			private static bool n_OnActivityResult_Landroid_app_Activity_IILandroid_content_Intent_(IntPtr jnienv, IntPtr native__this, IntPtr native_activity, int requestCode, int resultCode, IntPtr native_data)
			{
				ActivityCompat.IPermissionCompatDelegate @object = Java.Lang.Object.GetObject<ActivityCompat.IPermissionCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
				Intent object3 = Java.Lang.Object.GetObject<Intent>(native_data, JniHandleOwnership.DoNotTransfer);
				return @object.OnActivityResult(object2, requestCode, resultCode, object3);
			}

			// Token: 0x060003C4 RID: 964 RVA: 0x0000AD28 File Offset: 0x00008F28
			public unsafe bool OnActivityResult(Activity activity, int requestCode, int resultCode, Intent data)
			{
				if (this.id_onActivityResult_Landroid_app_Activity_IILandroid_content_Intent_ == IntPtr.Zero)
				{
					this.id_onActivityResult_Landroid_app_Activity_IILandroid_content_Intent_ = JNIEnv.GetMethodID(this.class_ref, "onActivityResult", "(Landroid/app/Activity;IILandroid/content/Intent;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JValue(requestCode);
				ptr[2] = new JValue(resultCode);
				ptr[3] = new JValue((data == null) ? IntPtr.Zero : data.Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onActivityResult_Landroid_app_Activity_IILandroid_content_Intent_, ptr);
			}

			// Token: 0x060003C5 RID: 965 RVA: 0x0000ADEB File Offset: 0x00008FEB
			private static Delegate GetRequestPermissions_Landroid_app_Activity_arrayLjava_lang_String_IHandler()
			{
				if (ActivityCompat.IPermissionCompatDelegateInvoker.cb_requestPermissions_Landroid_app_Activity_arrayLjava_lang_String_I == null)
				{
					ActivityCompat.IPermissionCompatDelegateInvoker.cb_requestPermissions_Landroid_app_Activity_arrayLjava_lang_String_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_Z(ActivityCompat.IPermissionCompatDelegateInvoker.n_RequestPermissions_Landroid_app_Activity_arrayLjava_lang_String_I));
				}
				return ActivityCompat.IPermissionCompatDelegateInvoker.cb_requestPermissions_Landroid_app_Activity_arrayLjava_lang_String_I;
			}

			// Token: 0x060003C6 RID: 966 RVA: 0x0000AE10 File Offset: 0x00009010
			private static bool n_RequestPermissions_Landroid_app_Activity_arrayLjava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native_activity, IntPtr native_permissions, int requestCode)
			{
				ActivityCompat.IPermissionCompatDelegate @object = Java.Lang.Object.GetObject<ActivityCompat.IPermissionCompatDelegate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Activity object2 = Java.Lang.Object.GetObject<Activity>(native_activity, JniHandleOwnership.DoNotTransfer);
				string[] array = (string[])JNIEnv.GetArray(native_permissions, JniHandleOwnership.DoNotTransfer, typeof(string));
				bool result = @object.RequestPermissions(object2, array, requestCode);
				if (array != null)
				{
					JNIEnv.CopyArray(array, native_permissions);
				}
				return result;
			}

			// Token: 0x060003C7 RID: 967 RVA: 0x0000AE58 File Offset: 0x00009058
			public unsafe bool RequestPermissions(Activity activity, string[] permissions, int requestCode)
			{
				if (this.id_requestPermissions_Landroid_app_Activity_arrayLjava_lang_String_I == IntPtr.Zero)
				{
					this.id_requestPermissions_Landroid_app_Activity_arrayLjava_lang_String_I = JNIEnv.GetMethodID(this.class_ref, "requestPermissions", "(Landroid/app/Activity;[Ljava/lang/String;I)Z");
				}
				IntPtr intPtr = JNIEnv.NewArray(permissions);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JValue(intPtr);
				ptr[2] = new JValue(requestCode);
				bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_requestPermissions_Landroid_app_Activity_arrayLjava_lang_String_I, ptr);
				if (permissions != null)
				{
					JNIEnv.CopyArray(intPtr, permissions);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return result;
			}

			// Token: 0x040000FA RID: 250
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/ActivityCompat$PermissionCompatDelegate", typeof(ActivityCompat.IPermissionCompatDelegateInvoker));

			// Token: 0x040000FB RID: 251
			private IntPtr class_ref;

			// Token: 0x040000FC RID: 252
			private static Delegate cb_onActivityResult_Landroid_app_Activity_IILandroid_content_Intent_;

			// Token: 0x040000FD RID: 253
			private IntPtr id_onActivityResult_Landroid_app_Activity_IILandroid_content_Intent_;

			// Token: 0x040000FE RID: 254
			private static Delegate cb_requestPermissions_Landroid_app_Activity_arrayLjava_lang_String_I;

			// Token: 0x040000FF RID: 255
			private IntPtr id_requestPermissions_Landroid_app_Activity_arrayLjava_lang_String_I;
		}

		// Token: 0x02000063 RID: 99
		[Register("androidx/core/app/ActivityCompat$RequestPermissionsRequestCodeValidator", "", "AndroidX.Core.App.ActivityCompat/IRequestPermissionsRequestCodeValidatorInvoker")]
		public interface IRequestPermissionsRequestCodeValidator : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060003C9 RID: 969
			[Register("validateRequestPermissionsRequestCode", "(I)V", "GetValidateRequestPermissionsRequestCode_IHandler:AndroidX.Core.App.ActivityCompat/IRequestPermissionsRequestCodeValidatorInvoker, Xamarin.AndroidX.Core")]
			void ValidateRequestPermissionsRequestCode(int requestCode);
		}

		// Token: 0x02000064 RID: 100
		[Register("androidx/core/app/ActivityCompat$RequestPermissionsRequestCodeValidator", DoNotGenerateAcw = true)]
		internal class IRequestPermissionsRequestCodeValidatorInvoker : Java.Lang.Object, ActivityCompat.IRequestPermissionsRequestCodeValidator, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700009E RID: 158
			// (get) Token: 0x060003CA RID: 970 RVA: 0x0000AF28 File Offset: 0x00009128
			private static IntPtr java_class_ref
			{
				get
				{
					return ActivityCompat.IRequestPermissionsRequestCodeValidatorInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x060003CB RID: 971 RVA: 0x0000AF4C File Offset: 0x0000914C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ActivityCompat.IRequestPermissionsRequestCodeValidatorInvoker._members;
				}
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x060003CC RID: 972 RVA: 0x0000AF53 File Offset: 0x00009153
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x060003CD RID: 973 RVA: 0x0000AF5B File Offset: 0x0000915B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ActivityCompat.IRequestPermissionsRequestCodeValidatorInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060003CE RID: 974 RVA: 0x0000AF67 File Offset: 0x00009167
			public static ActivityCompat.IRequestPermissionsRequestCodeValidator GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ActivityCompat.IRequestPermissionsRequestCodeValidator>(handle, transfer);
			}

			// Token: 0x060003CF RID: 975 RVA: 0x0000AF70 File Offset: 0x00009170
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ActivityCompat.IRequestPermissionsRequestCodeValidatorInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.app.ActivityCompat.RequestPermissionsRequestCodeValidator'.");
				}
				return handle;
			}

			// Token: 0x060003D0 RID: 976 RVA: 0x0000AF9B File Offset: 0x0000919B
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060003D1 RID: 977 RVA: 0x0000AFCC File Offset: 0x000091CC
			public IRequestPermissionsRequestCodeValidatorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ActivityCompat.IRequestPermissionsRequestCodeValidatorInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060003D2 RID: 978 RVA: 0x0000B004 File Offset: 0x00009204
			private static Delegate GetValidateRequestPermissionsRequestCode_IHandler()
			{
				if (ActivityCompat.IRequestPermissionsRequestCodeValidatorInvoker.cb_validateRequestPermissionsRequestCode_I == null)
				{
					ActivityCompat.IRequestPermissionsRequestCodeValidatorInvoker.cb_validateRequestPermissionsRequestCode_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ActivityCompat.IRequestPermissionsRequestCodeValidatorInvoker.n_ValidateRequestPermissionsRequestCode_I));
				}
				return ActivityCompat.IRequestPermissionsRequestCodeValidatorInvoker.cb_validateRequestPermissionsRequestCode_I;
			}

			// Token: 0x060003D3 RID: 979 RVA: 0x0000B028 File Offset: 0x00009228
			private static void n_ValidateRequestPermissionsRequestCode_I(IntPtr jnienv, IntPtr native__this, int requestCode)
			{
				Java.Lang.Object.GetObject<ActivityCompat.IRequestPermissionsRequestCodeValidator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ValidateRequestPermissionsRequestCode(requestCode);
			}

			// Token: 0x060003D4 RID: 980 RVA: 0x0000B038 File Offset: 0x00009238
			public unsafe void ValidateRequestPermissionsRequestCode(int requestCode)
			{
				if (this.id_validateRequestPermissionsRequestCode_I == IntPtr.Zero)
				{
					this.id_validateRequestPermissionsRequestCode_I = JNIEnv.GetMethodID(this.class_ref, "validateRequestPermissionsRequestCode", "(I)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(requestCode);
				JNIEnv.CallVoidMethod(base.Handle, this.id_validateRequestPermissionsRequestCode_I, ptr);
			}

			// Token: 0x04000100 RID: 256
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/ActivityCompat$RequestPermissionsRequestCodeValidator", typeof(ActivityCompat.IRequestPermissionsRequestCodeValidatorInvoker));

			// Token: 0x04000101 RID: 257
			private IntPtr class_ref;

			// Token: 0x04000102 RID: 258
			private static Delegate cb_validateRequestPermissionsRequestCode_I;

			// Token: 0x04000103 RID: 259
			private IntPtr id_validateRequestPermissionsRequestCode_I;
		}
	}
}
