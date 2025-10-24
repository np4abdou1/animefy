using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Net;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.Core.Content;
using AndroidX.Core.Content.PM;
using AndroidX.Core.Graphics.Drawable;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.App
{
	// Token: 0x02000074 RID: 116
	[Register("androidx/core/app/NotificationCompat", DoNotGenerateAcw = true)]
	public class NotificationCompat : Java.Lang.Object
	{
		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x0000DE08 File Offset: 0x0000C008
		internal static IntPtr class_ref
		{
			get
			{
				return NotificationCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x0000DE2C File Offset: 0x0000C02C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return NotificationCompat._members;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x0000DE34 File Offset: 0x0000C034
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return NotificationCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x0000DE58 File Offset: 0x0000C058
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return NotificationCompat._members.ManagedPeerType;
			}
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00002384 File Offset: 0x00000584
		protected NotificationCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0000DE64 File Offset: 0x0000C064
		[Register(".ctor", "()V", "")]
		public NotificationCompat() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(NotificationCompat._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			NotificationCompat._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0000DED4 File Offset: 0x0000C0D4
		[Register("getAction", "(Landroid/app/Notification;I)Landroidx/core/app/NotificationCompat$Action;", "")]
		public unsafe static NotificationCompat.Action GetAction(Notification notification, int actionIndex)
		{
			NotificationCompat.Action @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				ptr[1] = new JniArgumentValue(actionIndex);
				@object = Java.Lang.Object.GetObject<NotificationCompat.Action>(NotificationCompat._members.StaticMethods.InvokeObjectMethod("getAction.(Landroid/app/Notification;I)Landroidx/core/app/NotificationCompat$Action;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return @object;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0000DF5C File Offset: 0x0000C15C
		[Register("getActionCount", "(Landroid/app/Notification;)I", "")]
		public unsafe static int GetActionCount(Notification notification)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				result = NotificationCompat._members.StaticMethods.InvokeInt32Method("getActionCount.(Landroid/app/Notification;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return result;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0000DFC0 File Offset: 0x0000C1C0
		[Register("getAllowSystemGeneratedContextualActions", "(Landroid/app/Notification;)Z", "")]
		public unsafe static bool GetAllowSystemGeneratedContextualActions(Notification notification)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				result = NotificationCompat._members.StaticMethods.InvokeBooleanMethod("getAllowSystemGeneratedContextualActions.(Landroid/app/Notification;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return result;
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0000E024 File Offset: 0x0000C224
		[Register("getAutoCancel", "(Landroid/app/Notification;)Z", "")]
		public unsafe static bool GetAutoCancel(Notification notification)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				result = NotificationCompat._members.StaticMethods.InvokeBooleanMethod("getAutoCancel.(Landroid/app/Notification;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return result;
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0000E088 File Offset: 0x0000C288
		[Register("getBadgeIconType", "(Landroid/app/Notification;)I", "")]
		public unsafe static int GetBadgeIconType(Notification notification)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				result = NotificationCompat._members.StaticMethods.InvokeInt32Method("getBadgeIconType.(Landroid/app/Notification;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return result;
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0000E0EC File Offset: 0x0000C2EC
		[Register("getBubbleMetadata", "(Landroid/app/Notification;)Landroidx/core/app/NotificationCompat$BubbleMetadata;", "")]
		public unsafe static NotificationCompat.BubbleMetadata GetBubbleMetadata(Notification notification)
		{
			NotificationCompat.BubbleMetadata @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				@object = Java.Lang.Object.GetObject<NotificationCompat.BubbleMetadata>(NotificationCompat._members.StaticMethods.InvokeObjectMethod("getBubbleMetadata.(Landroid/app/Notification;)Landroidx/core/app/NotificationCompat$BubbleMetadata;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return @object;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0000E160 File Offset: 0x0000C360
		[Register("getCategory", "(Landroid/app/Notification;)Ljava/lang/String;", "")]
		public unsafe static string GetCategory(Notification notification)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				@string = JNIEnv.GetString(NotificationCompat._members.StaticMethods.InvokeObjectMethod("getCategory.(Landroid/app/Notification;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return @string;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0000E1D4 File Offset: 0x0000C3D4
		[Register("getChannelId", "(Landroid/app/Notification;)Ljava/lang/String;", "")]
		public unsafe static string GetChannelId(Notification notification)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				@string = JNIEnv.GetString(NotificationCompat._members.StaticMethods.InvokeObjectMethod("getChannelId.(Landroid/app/Notification;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return @string;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0000E248 File Offset: 0x0000C448
		[Register("getColor", "(Landroid/app/Notification;)I", "")]
		public unsafe static int GetColor(Notification notification)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				result = NotificationCompat._members.StaticMethods.InvokeInt32Method("getColor.(Landroid/app/Notification;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return result;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0000E2AC File Offset: 0x0000C4AC
		[Register("getContentInfo", "(Landroid/app/Notification;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence GetContentInfoFormatted(Notification notification)
		{
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				@object = Java.Lang.Object.GetObject<ICharSequence>(NotificationCompat._members.StaticMethods.InvokeObjectMethod("getContentInfo.(Landroid/app/Notification;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return @object;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0000E320 File Offset: 0x0000C520
		public static string GetContentInfo(Notification notification)
		{
			ICharSequence contentInfoFormatted = NotificationCompat.GetContentInfoFormatted(notification);
			if (contentInfoFormatted == null)
			{
				return null;
			}
			return contentInfoFormatted.ToString();
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0000E334 File Offset: 0x0000C534
		[Register("getContentText", "(Landroid/app/Notification;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence GetContentTextFormatted(Notification notification)
		{
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				@object = Java.Lang.Object.GetObject<ICharSequence>(NotificationCompat._members.StaticMethods.InvokeObjectMethod("getContentText.(Landroid/app/Notification;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return @object;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0000E3A8 File Offset: 0x0000C5A8
		public static string GetContentText(Notification notification)
		{
			ICharSequence contentTextFormatted = NotificationCompat.GetContentTextFormatted(notification);
			if (contentTextFormatted == null)
			{
				return null;
			}
			return contentTextFormatted.ToString();
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0000E3BC File Offset: 0x0000C5BC
		[Register("getContentTitle", "(Landroid/app/Notification;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence GetContentTitleFormatted(Notification notification)
		{
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				@object = Java.Lang.Object.GetObject<ICharSequence>(NotificationCompat._members.StaticMethods.InvokeObjectMethod("getContentTitle.(Landroid/app/Notification;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return @object;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0000E430 File Offset: 0x0000C630
		public static string GetContentTitle(Notification notification)
		{
			ICharSequence contentTitleFormatted = NotificationCompat.GetContentTitleFormatted(notification);
			if (contentTitleFormatted == null)
			{
				return null;
			}
			return contentTitleFormatted.ToString();
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0000E444 File Offset: 0x0000C644
		[Register("getExtras", "(Landroid/app/Notification;)Landroid/os/Bundle;", "")]
		public unsafe static Bundle GetExtras(Notification notification)
		{
			Bundle @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				@object = Java.Lang.Object.GetObject<Bundle>(NotificationCompat._members.StaticMethods.InvokeObjectMethod("getExtras.(Landroid/app/Notification;)Landroid/os/Bundle;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return @object;
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0000E4B8 File Offset: 0x0000C6B8
		[Register("getGroup", "(Landroid/app/Notification;)Ljava/lang/String;", "")]
		public unsafe static string GetGroup(Notification notification)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				@string = JNIEnv.GetString(NotificationCompat._members.StaticMethods.InvokeObjectMethod("getGroup.(Landroid/app/Notification;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return @string;
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0000E52C File Offset: 0x0000C72C
		[Register("getGroupAlertBehavior", "(Landroid/app/Notification;)I", "")]
		public unsafe static int GetGroupAlertBehavior(Notification notification)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				result = NotificationCompat._members.StaticMethods.InvokeInt32Method("getGroupAlertBehavior.(Landroid/app/Notification;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return result;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0000E590 File Offset: 0x0000C790
		[Register("getInvisibleActions", "(Landroid/app/Notification;)Ljava/util/List;", "")]
		public unsafe static IList<NotificationCompat.Action> GetInvisibleActions(Notification notification)
		{
			IList<NotificationCompat.Action> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				result = JavaList<NotificationCompat.Action>.FromJniHandle(NotificationCompat._members.StaticMethods.InvokeObjectMethod("getInvisibleActions.(Landroid/app/Notification;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return result;
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0000E604 File Offset: 0x0000C804
		[Register("getLocalOnly", "(Landroid/app/Notification;)Z", "")]
		public unsafe static bool GetLocalOnly(Notification notification)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				result = NotificationCompat._members.StaticMethods.InvokeBooleanMethod("getLocalOnly.(Landroid/app/Notification;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return result;
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0000E668 File Offset: 0x0000C868
		[Register("getLocusId", "(Landroid/app/Notification;)Landroidx/core/content/LocusIdCompat;", "")]
		public unsafe static LocusIdCompat GetLocusId(Notification notification)
		{
			LocusIdCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				@object = Java.Lang.Object.GetObject<LocusIdCompat>(NotificationCompat._members.StaticMethods.InvokeObjectMethod("getLocusId.(Landroid/app/Notification;)Landroidx/core/content/LocusIdCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return @object;
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0000E6DC File Offset: 0x0000C8DC
		[Register("getOngoing", "(Landroid/app/Notification;)Z", "")]
		public unsafe static bool GetOngoing(Notification notification)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				result = NotificationCompat._members.StaticMethods.InvokeBooleanMethod("getOngoing.(Landroid/app/Notification;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return result;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0000E740 File Offset: 0x0000C940
		[Register("getOnlyAlertOnce", "(Landroid/app/Notification;)Z", "")]
		public unsafe static bool GetOnlyAlertOnce(Notification notification)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				result = NotificationCompat._members.StaticMethods.InvokeBooleanMethod("getOnlyAlertOnce.(Landroid/app/Notification;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return result;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0000E7A4 File Offset: 0x0000C9A4
		[Register("getPeople", "(Landroid/app/Notification;)Ljava/util/List;", "")]
		public unsafe static IList<Person> GetPeople(Notification notification)
		{
			IList<Person> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				result = JavaList<Person>.FromJniHandle(NotificationCompat._members.StaticMethods.InvokeObjectMethod("getPeople.(Landroid/app/Notification;)Ljava/util/List;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return result;
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0000E818 File Offset: 0x0000CA18
		[Register("getPublicVersion", "(Landroid/app/Notification;)Landroid/app/Notification;", "")]
		public unsafe static Notification GetPublicVersion(Notification notification)
		{
			Notification @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				@object = Java.Lang.Object.GetObject<Notification>(NotificationCompat._members.StaticMethods.InvokeObjectMethod("getPublicVersion.(Landroid/app/Notification;)Landroid/app/Notification;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return @object;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0000E88C File Offset: 0x0000CA8C
		[Register("getSettingsText", "(Landroid/app/Notification;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence GetSettingsTextFormatted(Notification notification)
		{
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				@object = Java.Lang.Object.GetObject<ICharSequence>(NotificationCompat._members.StaticMethods.InvokeObjectMethod("getSettingsText.(Landroid/app/Notification;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return @object;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0000E900 File Offset: 0x0000CB00
		public static string GetSettingsText(Notification notification)
		{
			ICharSequence settingsTextFormatted = NotificationCompat.GetSettingsTextFormatted(notification);
			if (settingsTextFormatted == null)
			{
				return null;
			}
			return settingsTextFormatted.ToString();
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0000E914 File Offset: 0x0000CB14
		[Register("getShortcutId", "(Landroid/app/Notification;)Ljava/lang/String;", "")]
		public unsafe static string GetShortcutId(Notification notification)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				@string = JNIEnv.GetString(NotificationCompat._members.StaticMethods.InvokeObjectMethod("getShortcutId.(Landroid/app/Notification;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return @string;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0000E988 File Offset: 0x0000CB88
		[Register("getShowWhen", "(Landroid/app/Notification;)Z", "")]
		public unsafe static bool GetShowWhen(Notification notification)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				result = NotificationCompat._members.StaticMethods.InvokeBooleanMethod("getShowWhen.(Landroid/app/Notification;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return result;
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0000E9EC File Offset: 0x0000CBEC
		[Register("getSortKey", "(Landroid/app/Notification;)Ljava/lang/String;", "")]
		public unsafe static string GetSortKey(Notification notification)
		{
			string @string;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				@string = JNIEnv.GetString(NotificationCompat._members.StaticMethods.InvokeObjectMethod("getSortKey.(Landroid/app/Notification;)Ljava/lang/String;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return @string;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0000EA60 File Offset: 0x0000CC60
		[Register("getSubText", "(Landroid/app/Notification;)Ljava/lang/CharSequence;", "")]
		public unsafe static ICharSequence GetSubTextFormatted(Notification notification)
		{
			ICharSequence @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				@object = Java.Lang.Object.GetObject<ICharSequence>(NotificationCompat._members.StaticMethods.InvokeObjectMethod("getSubText.(Landroid/app/Notification;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return @object;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0000EAD4 File Offset: 0x0000CCD4
		public static string GetSubText(Notification notification)
		{
			ICharSequence subTextFormatted = NotificationCompat.GetSubTextFormatted(notification);
			if (subTextFormatted == null)
			{
				return null;
			}
			return subTextFormatted.ToString();
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0000EAE8 File Offset: 0x0000CCE8
		[Register("getTimeoutAfter", "(Landroid/app/Notification;)J", "")]
		public unsafe static long GetTimeoutAfter(Notification notification)
		{
			long result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				result = NotificationCompat._members.StaticMethods.InvokeInt64Method("getTimeoutAfter.(Landroid/app/Notification;)J", ptr);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return result;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0000EB4C File Offset: 0x0000CD4C
		[Register("getUsesChronometer", "(Landroid/app/Notification;)Z", "")]
		public unsafe static bool GetUsesChronometer(Notification notification)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				result = NotificationCompat._members.StaticMethods.InvokeBooleanMethod("getUsesChronometer.(Landroid/app/Notification;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return result;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0000EBB0 File Offset: 0x0000CDB0
		[Register("getVisibility", "(Landroid/app/Notification;)I", "")]
		public unsafe static int GetVisibility(Notification notification)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				result = NotificationCompat._members.StaticMethods.InvokeInt32Method("getVisibility.(Landroid/app/Notification;)I", ptr);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return result;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0000EC14 File Offset: 0x0000CE14
		[Register("isGroupSummary", "(Landroid/app/Notification;)Z", "")]
		public unsafe static bool IsGroupSummary(Notification notification)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				result = NotificationCompat._members.StaticMethods.InvokeBooleanMethod("isGroupSummary.(Landroid/app/Notification;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
			return result;
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0000EC78 File Offset: 0x0000CE78
		[Register("reduceLargeIconSize", "(Landroid/content/Context;Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;", "")]
		public unsafe static Bitmap ReduceLargeIconSize(Context context, Bitmap icon)
		{
			Bitmap @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((icon == null) ? IntPtr.Zero : icon.Handle);
				@object = Java.Lang.Object.GetObject<Bitmap>(NotificationCompat._members.StaticMethods.InvokeObjectMethod("reduceLargeIconSize.(Landroid/content/Context;Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(icon);
			}
			return @object;
		}

		// Token: 0x04000152 RID: 338
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/NotificationCompat", typeof(NotificationCompat));

		// Token: 0x02000075 RID: 117
		[Register("androidx/core/app/NotificationCompat$Action", DoNotGenerateAcw = true)]
		public class Action : Java.Lang.Object
		{
			// Token: 0x170000E9 RID: 233
			// (get) Token: 0x06000511 RID: 1297 RVA: 0x0000ED30 File Offset: 0x0000CF30
			// (set) Token: 0x06000512 RID: 1298 RVA: 0x0000ED60 File Offset: 0x0000CF60
			[Register("actionIntent")]
			public PendingIntent ActionIntentData
			{
				get
				{
					return Java.Lang.Object.GetObject<PendingIntent>(NotificationCompat.Action._members.InstanceFields.GetObjectValue("actionIntent.Landroid/app/PendingIntent;", this).Handle, JniHandleOwnership.TransferLocalRef);
				}
				set
				{
					IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
					try
					{
						NotificationCompat.Action._members.InstanceFields.SetValue("actionIntent.Landroid/app/PendingIntent;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
					}
					finally
					{
						JNIEnv.DeleteLocalRef(intPtr);
					}
				}
			}

			// Token: 0x170000EA RID: 234
			// (get) Token: 0x06000513 RID: 1299 RVA: 0x0000EDAC File Offset: 0x0000CFAC
			// (set) Token: 0x06000514 RID: 1300 RVA: 0x0000EDC3 File Offset: 0x0000CFC3
			[Register("icon")]
			public int IconData
			{
				get
				{
					return NotificationCompat.Action._members.InstanceFields.GetInt32Value("icon.I", this);
				}
				set
				{
					NotificationCompat.Action._members.InstanceFields.SetValue("icon.I", this, value);
				}
			}

			// Token: 0x170000EB RID: 235
			// (get) Token: 0x06000515 RID: 1301 RVA: 0x0000EDDC File Offset: 0x0000CFDC
			// (set) Token: 0x06000516 RID: 1302 RVA: 0x0000EE0C File Offset: 0x0000D00C
			[Register("title")]
			public ICharSequence TitleData
			{
				get
				{
					return Java.Lang.Object.GetObject<ICharSequence>(NotificationCompat.Action._members.InstanceFields.GetObjectValue("title.Ljava/lang/CharSequence;", this).Handle, JniHandleOwnership.TransferLocalRef);
				}
				set
				{
					IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
					try
					{
						NotificationCompat.Action._members.InstanceFields.SetValue("title.Ljava/lang/CharSequence;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
					}
					finally
					{
						JNIEnv.DeleteLocalRef(intPtr);
					}
				}
			}

			// Token: 0x170000EC RID: 236
			// (get) Token: 0x06000517 RID: 1303 RVA: 0x0000EE58 File Offset: 0x0000D058
			internal static IntPtr class_ref
			{
				get
				{
					return NotificationCompat.Action._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000ED RID: 237
			// (get) Token: 0x06000518 RID: 1304 RVA: 0x0000EE7C File Offset: 0x0000D07C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return NotificationCompat.Action._members;
				}
			}

			// Token: 0x170000EE RID: 238
			// (get) Token: 0x06000519 RID: 1305 RVA: 0x0000EE84 File Offset: 0x0000D084
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return NotificationCompat.Action._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x0600051A RID: 1306 RVA: 0x0000EEA8 File Offset: 0x0000D0A8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return NotificationCompat.Action._members.ManagedPeerType;
				}
			}

			// Token: 0x0600051B RID: 1307 RVA: 0x00002384 File Offset: 0x00000584
			protected Action(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600051C RID: 1308 RVA: 0x0000EEB4 File Offset: 0x0000D0B4
			[Register(".ctor", "(Landroidx/core/graphics/drawable/IconCompat;Ljava/lang/CharSequence;Landroid/app/PendingIntent;)V", "")]
			public unsafe Action(IconCompat icon, ICharSequence title, PendingIntent intent) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((icon == null) ? IntPtr.Zero : icon.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
					base.SetHandle(NotificationCompat.Action._members.InstanceMethods.StartCreateInstance("(Landroidx/core/graphics/drawable/IconCompat;Ljava/lang/CharSequence;Landroid/app/PendingIntent;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					NotificationCompat.Action._members.InstanceMethods.FinishCreateInstance("(Landroidx/core/graphics/drawable/IconCompat;Ljava/lang/CharSequence;Landroid/app/PendingIntent;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(icon);
					GC.KeepAlive(title);
					GC.KeepAlive(intent);
				}
			}

			// Token: 0x0600051D RID: 1309 RVA: 0x0000EFB4 File Offset: 0x0000D1B4
			[Register(".ctor", "(Landroidx/core/graphics/drawable/IconCompat;Ljava/lang/CharSequence;Landroid/app/PendingIntent;)V", "")]
			public unsafe Action(IconCompat icon, string title, PendingIntent intent) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((icon == null) ? IntPtr.Zero : icon.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
					base.SetHandle(NotificationCompat.Action._members.InstanceMethods.StartCreateInstance("(Landroidx/core/graphics/drawable/IconCompat;Ljava/lang/CharSequence;Landroid/app/PendingIntent;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					NotificationCompat.Action._members.InstanceMethods.FinishCreateInstance("(Landroidx/core/graphics/drawable/IconCompat;Ljava/lang/CharSequence;Landroid/app/PendingIntent;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(icon);
					GC.KeepAlive(title);
					GC.KeepAlive(intent);
				}
			}

			// Token: 0x0600051E RID: 1310 RVA: 0x0000F0B4 File Offset: 0x0000D2B4
			[Register(".ctor", "(ILjava/lang/CharSequence;Landroid/app/PendingIntent;)V", "")]
			public unsafe Action(int icon, ICharSequence title, PendingIntent intent) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(icon);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
					base.SetHandle(NotificationCompat.Action._members.InstanceMethods.StartCreateInstance("(ILjava/lang/CharSequence;Landroid/app/PendingIntent;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					NotificationCompat.Action._members.InstanceMethods.FinishCreateInstance("(ILjava/lang/CharSequence;Landroid/app/PendingIntent;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(title);
					GC.KeepAlive(intent);
				}
			}

			// Token: 0x0600051F RID: 1311 RVA: 0x0000F19C File Offset: 0x0000D39C
			[Register(".ctor", "(ILjava/lang/CharSequence;Landroid/app/PendingIntent;)V", "")]
			public unsafe Action(int icon, string title, PendingIntent intent) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(icon);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
					base.SetHandle(NotificationCompat.Action._members.InstanceMethods.StartCreateInstance("(ILjava/lang/CharSequence;Landroid/app/PendingIntent;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					NotificationCompat.Action._members.InstanceMethods.FinishCreateInstance("(ILjava/lang/CharSequence;Landroid/app/PendingIntent;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(title);
					GC.KeepAlive(intent);
				}
			}

			// Token: 0x06000520 RID: 1312 RVA: 0x0000F284 File Offset: 0x0000D484
			private static Delegate GetGetActionIntentHandler()
			{
				if (NotificationCompat.Action.cb_getActionIntent == null)
				{
					NotificationCompat.Action.cb_getActionIntent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationCompat.Action.n_GetActionIntent));
				}
				return NotificationCompat.Action.cb_getActionIntent;
			}

			// Token: 0x06000521 RID: 1313 RVA: 0x0000F2A8 File Offset: 0x0000D4A8
			private static IntPtr n_GetActionIntent(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Action>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ActionIntent);
			}

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x06000522 RID: 1314 RVA: 0x0000F2BC File Offset: 0x0000D4BC
			public virtual PendingIntent ActionIntent
			{
				[Register("getActionIntent", "()Landroid/app/PendingIntent;", "GetGetActionIntentHandler")]
				get
				{
					return Java.Lang.Object.GetObject<PendingIntent>(NotificationCompat.Action._members.InstanceMethods.InvokeVirtualObjectMethod("getActionIntent.()Landroid/app/PendingIntent;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06000523 RID: 1315 RVA: 0x0000F2EE File Offset: 0x0000D4EE
			private static Delegate GetGetAllowGeneratedRepliesHandler()
			{
				if (NotificationCompat.Action.cb_getAllowGeneratedReplies == null)
				{
					NotificationCompat.Action.cb_getAllowGeneratedReplies = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(NotificationCompat.Action.n_GetAllowGeneratedReplies));
				}
				return NotificationCompat.Action.cb_getAllowGeneratedReplies;
			}

			// Token: 0x06000524 RID: 1316 RVA: 0x0000F312 File Offset: 0x0000D512
			private static bool n_GetAllowGeneratedReplies(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<NotificationCompat.Action>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AllowGeneratedReplies;
			}

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x06000525 RID: 1317 RVA: 0x0000F321 File Offset: 0x0000D521
			public virtual bool AllowGeneratedReplies
			{
				[Register("getAllowGeneratedReplies", "()Z", "GetGetAllowGeneratedRepliesHandler")]
				get
				{
					return NotificationCompat.Action._members.InstanceMethods.InvokeVirtualBooleanMethod("getAllowGeneratedReplies.()Z", this, null);
				}
			}

			// Token: 0x06000526 RID: 1318 RVA: 0x0000F33A File Offset: 0x0000D53A
			private static Delegate GetGetExtrasHandler()
			{
				if (NotificationCompat.Action.cb_getExtras == null)
				{
					NotificationCompat.Action.cb_getExtras = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationCompat.Action.n_GetExtras));
				}
				return NotificationCompat.Action.cb_getExtras;
			}

			// Token: 0x06000527 RID: 1319 RVA: 0x0000F35E File Offset: 0x0000D55E
			private static IntPtr n_GetExtras(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Action>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Extras);
			}

			// Token: 0x170000F2 RID: 242
			// (get) Token: 0x06000528 RID: 1320 RVA: 0x0000F374 File Offset: 0x0000D574
			public virtual Bundle Extras
			{
				[Register("getExtras", "()Landroid/os/Bundle;", "GetGetExtrasHandler")]
				get
				{
					return Java.Lang.Object.GetObject<Bundle>(NotificationCompat.Action._members.InstanceMethods.InvokeVirtualObjectMethod("getExtras.()Landroid/os/Bundle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06000529 RID: 1321 RVA: 0x0000F3A6 File Offset: 0x0000D5A6
			private static Delegate GetGetIconHandler()
			{
				if (NotificationCompat.Action.cb_getIcon == null)
				{
					NotificationCompat.Action.cb_getIcon = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(NotificationCompat.Action.n_GetIcon));
				}
				return NotificationCompat.Action.cb_getIcon;
			}

			// Token: 0x0600052A RID: 1322 RVA: 0x0000F3CA File Offset: 0x0000D5CA
			private static int n_GetIcon(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<NotificationCompat.Action>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Icon;
			}

			// Token: 0x170000F3 RID: 243
			// (get) Token: 0x0600052B RID: 1323 RVA: 0x0000F3D9 File Offset: 0x0000D5D9
			public virtual int Icon
			{
				[Register("getIcon", "()I", "GetGetIconHandler")]
				get
				{
					return NotificationCompat.Action._members.InstanceMethods.InvokeVirtualInt32Method("getIcon.()I", this, null);
				}
			}

			// Token: 0x0600052C RID: 1324 RVA: 0x0000F3F2 File Offset: 0x0000D5F2
			private static Delegate GetGetIconCompatHandler()
			{
				if (NotificationCompat.Action.cb_getIconCompat == null)
				{
					NotificationCompat.Action.cb_getIconCompat = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationCompat.Action.n_GetIconCompat));
				}
				return NotificationCompat.Action.cb_getIconCompat;
			}

			// Token: 0x0600052D RID: 1325 RVA: 0x0000F416 File Offset: 0x0000D616
			private static IntPtr n_GetIconCompat(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Action>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IconCompat);
			}

			// Token: 0x170000F4 RID: 244
			// (get) Token: 0x0600052E RID: 1326 RVA: 0x0000F42C File Offset: 0x0000D62C
			public virtual IconCompat IconCompat
			{
				[Register("getIconCompat", "()Landroidx/core/graphics/drawable/IconCompat;", "GetGetIconCompatHandler")]
				get
				{
					return Java.Lang.Object.GetObject<IconCompat>(NotificationCompat.Action._members.InstanceMethods.InvokeVirtualObjectMethod("getIconCompat.()Landroidx/core/graphics/drawable/IconCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x0600052F RID: 1327 RVA: 0x0000F45E File Offset: 0x0000D65E
			private static Delegate GetIsAuthenticationRequiredHandler()
			{
				if (NotificationCompat.Action.cb_isAuthenticationRequired == null)
				{
					NotificationCompat.Action.cb_isAuthenticationRequired = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(NotificationCompat.Action.n_IsAuthenticationRequired));
				}
				return NotificationCompat.Action.cb_isAuthenticationRequired;
			}

			// Token: 0x06000530 RID: 1328 RVA: 0x0000F482 File Offset: 0x0000D682
			private static bool n_IsAuthenticationRequired(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<NotificationCompat.Action>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAuthenticationRequired;
			}

			// Token: 0x170000F5 RID: 245
			// (get) Token: 0x06000531 RID: 1329 RVA: 0x0000F491 File Offset: 0x0000D691
			public virtual bool IsAuthenticationRequired
			{
				[Register("isAuthenticationRequired", "()Z", "GetIsAuthenticationRequiredHandler")]
				get
				{
					return NotificationCompat.Action._members.InstanceMethods.InvokeVirtualBooleanMethod("isAuthenticationRequired.()Z", this, null);
				}
			}

			// Token: 0x06000532 RID: 1330 RVA: 0x0000F4AA File Offset: 0x0000D6AA
			private static Delegate GetIsContextualHandler()
			{
				if (NotificationCompat.Action.cb_isContextual == null)
				{
					NotificationCompat.Action.cb_isContextual = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(NotificationCompat.Action.n_IsContextual));
				}
				return NotificationCompat.Action.cb_isContextual;
			}

			// Token: 0x06000533 RID: 1331 RVA: 0x0000F4CE File Offset: 0x0000D6CE
			private static bool n_IsContextual(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<NotificationCompat.Action>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsContextual;
			}

			// Token: 0x170000F6 RID: 246
			// (get) Token: 0x06000534 RID: 1332 RVA: 0x0000F4DD File Offset: 0x0000D6DD
			public virtual bool IsContextual
			{
				[Register("isContextual", "()Z", "GetIsContextualHandler")]
				get
				{
					return NotificationCompat.Action._members.InstanceMethods.InvokeVirtualBooleanMethod("isContextual.()Z", this, null);
				}
			}

			// Token: 0x06000535 RID: 1333 RVA: 0x0000F4F6 File Offset: 0x0000D6F6
			private static Delegate GetGetSemanticActionHandler()
			{
				if (NotificationCompat.Action.cb_getSemanticAction == null)
				{
					NotificationCompat.Action.cb_getSemanticAction = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(NotificationCompat.Action.n_GetSemanticAction));
				}
				return NotificationCompat.Action.cb_getSemanticAction;
			}

			// Token: 0x06000536 RID: 1334 RVA: 0x0000F51A File Offset: 0x0000D71A
			private static int n_GetSemanticAction(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<NotificationCompat.Action>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SemanticAction;
			}

			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x06000537 RID: 1335 RVA: 0x0000F529 File Offset: 0x0000D729
			public virtual int SemanticAction
			{
				[Register("getSemanticAction", "()I", "GetGetSemanticActionHandler")]
				get
				{
					return NotificationCompat.Action._members.InstanceMethods.InvokeVirtualInt32Method("getSemanticAction.()I", this, null);
				}
			}

			// Token: 0x06000538 RID: 1336 RVA: 0x0000F542 File Offset: 0x0000D742
			private static Delegate GetGetShowsUserInterfaceHandler()
			{
				if (NotificationCompat.Action.cb_getShowsUserInterface == null)
				{
					NotificationCompat.Action.cb_getShowsUserInterface = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(NotificationCompat.Action.n_GetShowsUserInterface));
				}
				return NotificationCompat.Action.cb_getShowsUserInterface;
			}

			// Token: 0x06000539 RID: 1337 RVA: 0x0000F566 File Offset: 0x0000D766
			private static bool n_GetShowsUserInterface(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<NotificationCompat.Action>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShowsUserInterface;
			}

			// Token: 0x170000F8 RID: 248
			// (get) Token: 0x0600053A RID: 1338 RVA: 0x0000F575 File Offset: 0x0000D775
			public virtual bool ShowsUserInterface
			{
				[Register("getShowsUserInterface", "()Z", "GetGetShowsUserInterfaceHandler")]
				get
				{
					return NotificationCompat.Action._members.InstanceMethods.InvokeVirtualBooleanMethod("getShowsUserInterface.()Z", this, null);
				}
			}

			// Token: 0x0600053B RID: 1339 RVA: 0x0000F58E File Offset: 0x0000D78E
			private static Delegate GetGetTitleHandler()
			{
				if (NotificationCompat.Action.cb_getTitle == null)
				{
					NotificationCompat.Action.cb_getTitle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationCompat.Action.n_GetTitle));
				}
				return NotificationCompat.Action.cb_getTitle;
			}

			// Token: 0x0600053C RID: 1340 RVA: 0x0000F5B2 File Offset: 0x0000D7B2
			private static IntPtr n_GetTitle(IntPtr jnienv, IntPtr native__this)
			{
				return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Action>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleFormatted);
			}

			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x0600053D RID: 1341 RVA: 0x0000F5C8 File Offset: 0x0000D7C8
			public virtual ICharSequence TitleFormatted
			{
				[Register("getTitle", "()Ljava/lang/CharSequence;", "GetGetTitleHandler")]
				get
				{
					return Java.Lang.Object.GetObject<ICharSequence>(NotificationCompat.Action._members.InstanceMethods.InvokeVirtualObjectMethod("getTitle.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000FA RID: 250
			// (get) Token: 0x0600053E RID: 1342 RVA: 0x0000F5FA File Offset: 0x0000D7FA
			public string Title
			{
				get
				{
					if (this.TitleFormatted != null)
					{
						return this.TitleFormatted.ToString();
					}
					return null;
				}
			}

			// Token: 0x0600053F RID: 1343 RVA: 0x0000F611 File Offset: 0x0000D811
			private static Delegate Get_GetDataOnlyRemoteInputsHandler()
			{
				if (NotificationCompat.Action.cb_getDataOnlyRemoteInputs == null)
				{
					NotificationCompat.Action.cb_getDataOnlyRemoteInputs = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationCompat.Action.n__GetDataOnlyRemoteInputs));
				}
				return NotificationCompat.Action.cb_getDataOnlyRemoteInputs;
			}

			// Token: 0x06000540 RID: 1344 RVA: 0x0000F635 File Offset: 0x0000D835
			private static IntPtr n__GetDataOnlyRemoteInputs(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewArray<RemoteInput>(Java.Lang.Object.GetObject<NotificationCompat.Action>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)._GetDataOnlyRemoteInputs());
			}

			// Token: 0x06000541 RID: 1345 RVA: 0x0000F64C File Offset: 0x0000D84C
			[Register("getDataOnlyRemoteInputs", "()[Landroidx/core/app/RemoteInput;", "Get_GetDataOnlyRemoteInputsHandler")]
			public virtual RemoteInput[] _GetDataOnlyRemoteInputs()
			{
				return (RemoteInput[])JNIEnv.GetArray(NotificationCompat.Action._members.InstanceMethods.InvokeVirtualObjectMethod("getDataOnlyRemoteInputs.()[Landroidx/core/app/RemoteInput;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(RemoteInput));
			}

			// Token: 0x06000542 RID: 1346 RVA: 0x0000F68D File Offset: 0x0000D88D
			private static Delegate Get_GetRemoteInputsHandler()
			{
				if (NotificationCompat.Action.cb_getRemoteInputs == null)
				{
					NotificationCompat.Action.cb_getRemoteInputs = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationCompat.Action.n__GetRemoteInputs));
				}
				return NotificationCompat.Action.cb_getRemoteInputs;
			}

			// Token: 0x06000543 RID: 1347 RVA: 0x0000F6B1 File Offset: 0x0000D8B1
			private static IntPtr n__GetRemoteInputs(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewArray<RemoteInput>(Java.Lang.Object.GetObject<NotificationCompat.Action>(jnienv, native__this, JniHandleOwnership.DoNotTransfer)._GetRemoteInputs());
			}

			// Token: 0x06000544 RID: 1348 RVA: 0x0000F6C8 File Offset: 0x0000D8C8
			[Register("getRemoteInputs", "()[Landroidx/core/app/RemoteInput;", "Get_GetRemoteInputsHandler")]
			protected virtual RemoteInput[] _GetRemoteInputs()
			{
				return (RemoteInput[])JNIEnv.GetArray(NotificationCompat.Action._members.InstanceMethods.InvokeVirtualObjectMethod("getRemoteInputs.()[Landroidx/core/app/RemoteInput;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(RemoteInput));
			}

			// Token: 0x04000153 RID: 339
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/NotificationCompat$Action", typeof(NotificationCompat.Action));

			// Token: 0x04000154 RID: 340
			private static Delegate cb_getActionIntent;

			// Token: 0x04000155 RID: 341
			private static Delegate cb_getAllowGeneratedReplies;

			// Token: 0x04000156 RID: 342
			private static Delegate cb_getExtras;

			// Token: 0x04000157 RID: 343
			private static Delegate cb_getIcon;

			// Token: 0x04000158 RID: 344
			private static Delegate cb_getIconCompat;

			// Token: 0x04000159 RID: 345
			private static Delegate cb_isAuthenticationRequired;

			// Token: 0x0400015A RID: 346
			private static Delegate cb_isContextual;

			// Token: 0x0400015B RID: 347
			private static Delegate cb_getSemanticAction;

			// Token: 0x0400015C RID: 348
			private static Delegate cb_getShowsUserInterface;

			// Token: 0x0400015D RID: 349
			private static Delegate cb_getTitle;

			// Token: 0x0400015E RID: 350
			private static Delegate cb_getDataOnlyRemoteInputs;

			// Token: 0x0400015F RID: 351
			private static Delegate cb_getRemoteInputs;
		}

		// Token: 0x02000076 RID: 118
		[Register("androidx/core/app/NotificationCompat$BigPictureStyle", DoNotGenerateAcw = true)]
		public class BigPictureStyle : NotificationCompat.Style
		{
			// Token: 0x170000FB RID: 251
			// (get) Token: 0x06000546 RID: 1350 RVA: 0x0000F724 File Offset: 0x0000D924
			internal new static IntPtr class_ref
			{
				get
				{
					return NotificationCompat.BigPictureStyle._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000FC RID: 252
			// (get) Token: 0x06000547 RID: 1351 RVA: 0x0000F748 File Offset: 0x0000D948
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return NotificationCompat.BigPictureStyle._members;
				}
			}

			// Token: 0x170000FD RID: 253
			// (get) Token: 0x06000548 RID: 1352 RVA: 0x0000F750 File Offset: 0x0000D950
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return NotificationCompat.BigPictureStyle._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000FE RID: 254
			// (get) Token: 0x06000549 RID: 1353 RVA: 0x0000F774 File Offset: 0x0000D974
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return NotificationCompat.BigPictureStyle._members.ManagedPeerType;
				}
			}

			// Token: 0x0600054A RID: 1354 RVA: 0x0000F780 File Offset: 0x0000D980
			protected BigPictureStyle(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600054B RID: 1355 RVA: 0x0000F78C File Offset: 0x0000D98C
			[Register(".ctor", "()V", "")]
			public BigPictureStyle() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(NotificationCompat.BigPictureStyle._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				NotificationCompat.BigPictureStyle._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x0600054C RID: 1356 RVA: 0x0000F7FC File Offset: 0x0000D9FC
			[Register(".ctor", "(Landroidx/core/app/NotificationCompat$Builder;)V", "")]
			public unsafe BigPictureStyle(NotificationCompat.Builder builder) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((builder == null) ? IntPtr.Zero : builder.Handle);
					base.SetHandle(NotificationCompat.BigPictureStyle._members.InstanceMethods.StartCreateInstance("(Landroidx/core/app/NotificationCompat$Builder;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					NotificationCompat.BigPictureStyle._members.InstanceMethods.FinishCreateInstance("(Landroidx/core/app/NotificationCompat$Builder;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(builder);
				}
			}

			// Token: 0x0600054D RID: 1357 RVA: 0x0000F8AC File Offset: 0x0000DAAC
			private static Delegate GetBigLargeIcon_Landroid_graphics_Bitmap_Handler()
			{
				if (NotificationCompat.BigPictureStyle.cb_bigLargeIcon_Landroid_graphics_Bitmap_ == null)
				{
					NotificationCompat.BigPictureStyle.cb_bigLargeIcon_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.BigPictureStyle.n_BigLargeIcon_Landroid_graphics_Bitmap_));
				}
				return NotificationCompat.BigPictureStyle.cb_bigLargeIcon_Landroid_graphics_Bitmap_;
			}

			// Token: 0x0600054E RID: 1358 RVA: 0x0000F8D0 File Offset: 0x0000DAD0
			private static IntPtr n_BigLargeIcon_Landroid_graphics_Bitmap_(IntPtr jnienv, IntPtr native__this, IntPtr native_b)
			{
				NotificationCompat.BigPictureStyle @object = Java.Lang.Object.GetObject<NotificationCompat.BigPictureStyle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Bitmap object2 = Java.Lang.Object.GetObject<Bitmap>(native_b, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.BigLargeIcon(object2));
			}

			// Token: 0x0600054F RID: 1359 RVA: 0x0000F8F8 File Offset: 0x0000DAF8
			[Register("bigLargeIcon", "(Landroid/graphics/Bitmap;)Landroidx/core/app/NotificationCompat$BigPictureStyle;", "GetBigLargeIcon_Landroid_graphics_Bitmap_Handler")]
			public unsafe virtual NotificationCompat.BigPictureStyle BigLargeIcon(Bitmap b)
			{
				NotificationCompat.BigPictureStyle @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((b == null) ? IntPtr.Zero : b.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.BigPictureStyle>(NotificationCompat.BigPictureStyle._members.InstanceMethods.InvokeVirtualObjectMethod("bigLargeIcon.(Landroid/graphics/Bitmap;)Landroidx/core/app/NotificationCompat$BigPictureStyle;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(b);
				}
				return @object;
			}

			// Token: 0x06000550 RID: 1360 RVA: 0x0000F96C File Offset: 0x0000DB6C
			private static Delegate GetBigLargeIcon_Landroid_graphics_drawable_Icon_Handler()
			{
				if (NotificationCompat.BigPictureStyle.cb_bigLargeIcon_Landroid_graphics_drawable_Icon_ == null)
				{
					NotificationCompat.BigPictureStyle.cb_bigLargeIcon_Landroid_graphics_drawable_Icon_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.BigPictureStyle.n_BigLargeIcon_Landroid_graphics_drawable_Icon_));
				}
				return NotificationCompat.BigPictureStyle.cb_bigLargeIcon_Landroid_graphics_drawable_Icon_;
			}

			// Token: 0x06000551 RID: 1361 RVA: 0x0000F990 File Offset: 0x0000DB90
			private static IntPtr n_BigLargeIcon_Landroid_graphics_drawable_Icon_(IntPtr jnienv, IntPtr native__this, IntPtr native_i)
			{
				NotificationCompat.BigPictureStyle @object = Java.Lang.Object.GetObject<NotificationCompat.BigPictureStyle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Icon object2 = Java.Lang.Object.GetObject<Icon>(native_i, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.BigLargeIcon(object2));
			}

			// Token: 0x06000552 RID: 1362 RVA: 0x0000F9B8 File Offset: 0x0000DBB8
			[Register("bigLargeIcon", "(Landroid/graphics/drawable/Icon;)Landroidx/core/app/NotificationCompat$BigPictureStyle;", "GetBigLargeIcon_Landroid_graphics_drawable_Icon_Handler")]
			public unsafe virtual NotificationCompat.BigPictureStyle BigLargeIcon(Icon i)
			{
				NotificationCompat.BigPictureStyle @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((i == null) ? IntPtr.Zero : i.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.BigPictureStyle>(NotificationCompat.BigPictureStyle._members.InstanceMethods.InvokeVirtualObjectMethod("bigLargeIcon.(Landroid/graphics/drawable/Icon;)Landroidx/core/app/NotificationCompat$BigPictureStyle;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(i);
				}
				return @object;
			}

			// Token: 0x06000553 RID: 1363 RVA: 0x0000FA2C File Offset: 0x0000DC2C
			private static Delegate GetBigPicture_Landroid_graphics_Bitmap_Handler()
			{
				if (NotificationCompat.BigPictureStyle.cb_bigPicture_Landroid_graphics_Bitmap_ == null)
				{
					NotificationCompat.BigPictureStyle.cb_bigPicture_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.BigPictureStyle.n_BigPicture_Landroid_graphics_Bitmap_));
				}
				return NotificationCompat.BigPictureStyle.cb_bigPicture_Landroid_graphics_Bitmap_;
			}

			// Token: 0x06000554 RID: 1364 RVA: 0x0000FA50 File Offset: 0x0000DC50
			private static IntPtr n_BigPicture_Landroid_graphics_Bitmap_(IntPtr jnienv, IntPtr native__this, IntPtr native_b)
			{
				NotificationCompat.BigPictureStyle @object = Java.Lang.Object.GetObject<NotificationCompat.BigPictureStyle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Bitmap object2 = Java.Lang.Object.GetObject<Bitmap>(native_b, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.BigPicture(object2));
			}

			// Token: 0x06000555 RID: 1365 RVA: 0x0000FA78 File Offset: 0x0000DC78
			[Register("bigPicture", "(Landroid/graphics/Bitmap;)Landroidx/core/app/NotificationCompat$BigPictureStyle;", "GetBigPicture_Landroid_graphics_Bitmap_Handler")]
			public unsafe virtual NotificationCompat.BigPictureStyle BigPicture(Bitmap b)
			{
				NotificationCompat.BigPictureStyle @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((b == null) ? IntPtr.Zero : b.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.BigPictureStyle>(NotificationCompat.BigPictureStyle._members.InstanceMethods.InvokeVirtualObjectMethod("bigPicture.(Landroid/graphics/Bitmap;)Landroidx/core/app/NotificationCompat$BigPictureStyle;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(b);
				}
				return @object;
			}

			// Token: 0x06000556 RID: 1366 RVA: 0x0000FAEC File Offset: 0x0000DCEC
			private static Delegate GetBigPicture_Landroid_graphics_drawable_Icon_Handler()
			{
				if (NotificationCompat.BigPictureStyle.cb_bigPicture_Landroid_graphics_drawable_Icon_ == null)
				{
					NotificationCompat.BigPictureStyle.cb_bigPicture_Landroid_graphics_drawable_Icon_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.BigPictureStyle.n_BigPicture_Landroid_graphics_drawable_Icon_));
				}
				return NotificationCompat.BigPictureStyle.cb_bigPicture_Landroid_graphics_drawable_Icon_;
			}

			// Token: 0x06000557 RID: 1367 RVA: 0x0000FB10 File Offset: 0x0000DD10
			private static IntPtr n_BigPicture_Landroid_graphics_drawable_Icon_(IntPtr jnienv, IntPtr native__this, IntPtr native_i)
			{
				NotificationCompat.BigPictureStyle @object = Java.Lang.Object.GetObject<NotificationCompat.BigPictureStyle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Icon object2 = Java.Lang.Object.GetObject<Icon>(native_i, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.BigPicture(object2));
			}

			// Token: 0x06000558 RID: 1368 RVA: 0x0000FB38 File Offset: 0x0000DD38
			[Register("bigPicture", "(Landroid/graphics/drawable/Icon;)Landroidx/core/app/NotificationCompat$BigPictureStyle;", "GetBigPicture_Landroid_graphics_drawable_Icon_Handler")]
			public unsafe virtual NotificationCompat.BigPictureStyle BigPicture(Icon i)
			{
				NotificationCompat.BigPictureStyle @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((i == null) ? IntPtr.Zero : i.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.BigPictureStyle>(NotificationCompat.BigPictureStyle._members.InstanceMethods.InvokeVirtualObjectMethod("bigPicture.(Landroid/graphics/drawable/Icon;)Landroidx/core/app/NotificationCompat$BigPictureStyle;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(i);
				}
				return @object;
			}

			// Token: 0x06000559 RID: 1369 RVA: 0x0000FBAC File Offset: 0x0000DDAC
			[Register("getPictureIcon", "(Landroid/os/Bundle;)Landroidx/core/graphics/drawable/IconCompat;", "")]
			public unsafe static IconCompat GetPictureIcon(Bundle extras)
			{
				IconCompat @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((extras == null) ? IntPtr.Zero : extras.Handle);
					@object = Java.Lang.Object.GetObject<IconCompat>(NotificationCompat.BigPictureStyle._members.StaticMethods.InvokeObjectMethod("getPictureIcon.(Landroid/os/Bundle;)Landroidx/core/graphics/drawable/IconCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(extras);
				}
				return @object;
			}

			// Token: 0x0600055A RID: 1370 RVA: 0x0000FC20 File Offset: 0x0000DE20
			private static Delegate GetSetBigContentTitle_Ljava_lang_CharSequence_Handler()
			{
				if (NotificationCompat.BigPictureStyle.cb_setBigContentTitle_Ljava_lang_CharSequence_ == null)
				{
					NotificationCompat.BigPictureStyle.cb_setBigContentTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.BigPictureStyle.n_SetBigContentTitle_Ljava_lang_CharSequence_));
				}
				return NotificationCompat.BigPictureStyle.cb_setBigContentTitle_Ljava_lang_CharSequence_;
			}

			// Token: 0x0600055B RID: 1371 RVA: 0x0000FC44 File Offset: 0x0000DE44
			private static IntPtr n_SetBigContentTitle_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_title)
			{
				NotificationCompat.BigPictureStyle @object = Java.Lang.Object.GetObject<NotificationCompat.BigPictureStyle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetBigContentTitle(object2));
			}

			// Token: 0x0600055C RID: 1372 RVA: 0x0000FC6C File Offset: 0x0000DE6C
			[Register("setBigContentTitle", "(Ljava/lang/CharSequence;)Landroidx/core/app/NotificationCompat$BigPictureStyle;", "GetSetBigContentTitle_Ljava_lang_CharSequence_Handler")]
			public unsafe virtual NotificationCompat.BigPictureStyle SetBigContentTitle(ICharSequence title)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
				NotificationCompat.BigPictureStyle @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<NotificationCompat.BigPictureStyle>(NotificationCompat.BigPictureStyle._members.InstanceMethods.InvokeVirtualObjectMethod("setBigContentTitle.(Ljava/lang/CharSequence;)Landroidx/core/app/NotificationCompat$BigPictureStyle;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(title);
				}
				return @object;
			}

			// Token: 0x0600055D RID: 1373 RVA: 0x0000FCE0 File Offset: 0x0000DEE0
			public NotificationCompat.BigPictureStyle SetBigContentTitle(string title)
			{
				Java.Lang.String @string = (title == null) ? null : new Java.Lang.String(title);
				NotificationCompat.BigPictureStyle result = this.SetBigContentTitle(@string);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x0600055E RID: 1374 RVA: 0x0000FD0A File Offset: 0x0000DF0A
			private static Delegate GetSetContentDescription_Ljava_lang_CharSequence_Handler()
			{
				if (NotificationCompat.BigPictureStyle.cb_setContentDescription_Ljava_lang_CharSequence_ == null)
				{
					NotificationCompat.BigPictureStyle.cb_setContentDescription_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.BigPictureStyle.n_SetContentDescription_Ljava_lang_CharSequence_));
				}
				return NotificationCompat.BigPictureStyle.cb_setContentDescription_Ljava_lang_CharSequence_;
			}

			// Token: 0x0600055F RID: 1375 RVA: 0x0000FD30 File Offset: 0x0000DF30
			private static IntPtr n_SetContentDescription_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_contentDescription)
			{
				NotificationCompat.BigPictureStyle @object = Java.Lang.Object.GetObject<NotificationCompat.BigPictureStyle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_contentDescription, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetContentDescription(object2));
			}

			// Token: 0x06000560 RID: 1376 RVA: 0x0000FD58 File Offset: 0x0000DF58
			[Register("setContentDescription", "(Ljava/lang/CharSequence;)Landroidx/core/app/NotificationCompat$BigPictureStyle;", "GetSetContentDescription_Ljava_lang_CharSequence_Handler")]
			public unsafe virtual NotificationCompat.BigPictureStyle SetContentDescription(ICharSequence contentDescription)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(contentDescription);
				NotificationCompat.BigPictureStyle @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<NotificationCompat.BigPictureStyle>(NotificationCompat.BigPictureStyle._members.InstanceMethods.InvokeVirtualObjectMethod("setContentDescription.(Ljava/lang/CharSequence;)Landroidx/core/app/NotificationCompat$BigPictureStyle;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(contentDescription);
				}
				return @object;
			}

			// Token: 0x06000561 RID: 1377 RVA: 0x0000FDCC File Offset: 0x0000DFCC
			public NotificationCompat.BigPictureStyle SetContentDescription(string contentDescription)
			{
				Java.Lang.String @string = (contentDescription == null) ? null : new Java.Lang.String(contentDescription);
				NotificationCompat.BigPictureStyle result = this.SetContentDescription(@string);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x06000562 RID: 1378 RVA: 0x0000FDF6 File Offset: 0x0000DFF6
			private static Delegate GetSetSummaryText_Ljava_lang_CharSequence_Handler()
			{
				if (NotificationCompat.BigPictureStyle.cb_setSummaryText_Ljava_lang_CharSequence_ == null)
				{
					NotificationCompat.BigPictureStyle.cb_setSummaryText_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.BigPictureStyle.n_SetSummaryText_Ljava_lang_CharSequence_));
				}
				return NotificationCompat.BigPictureStyle.cb_setSummaryText_Ljava_lang_CharSequence_;
			}

			// Token: 0x06000563 RID: 1379 RVA: 0x0000FE1C File Offset: 0x0000E01C
			private static IntPtr n_SetSummaryText_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_cs)
			{
				NotificationCompat.BigPictureStyle @object = Java.Lang.Object.GetObject<NotificationCompat.BigPictureStyle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_cs, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetSummaryText(object2));
			}

			// Token: 0x06000564 RID: 1380 RVA: 0x0000FE44 File Offset: 0x0000E044
			[Register("setSummaryText", "(Ljava/lang/CharSequence;)Landroidx/core/app/NotificationCompat$BigPictureStyle;", "GetSetSummaryText_Ljava_lang_CharSequence_Handler")]
			public unsafe virtual NotificationCompat.BigPictureStyle SetSummaryText(ICharSequence cs)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(cs);
				NotificationCompat.BigPictureStyle @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<NotificationCompat.BigPictureStyle>(NotificationCompat.BigPictureStyle._members.InstanceMethods.InvokeVirtualObjectMethod("setSummaryText.(Ljava/lang/CharSequence;)Landroidx/core/app/NotificationCompat$BigPictureStyle;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(cs);
				}
				return @object;
			}

			// Token: 0x06000565 RID: 1381 RVA: 0x0000FEB8 File Offset: 0x0000E0B8
			public NotificationCompat.BigPictureStyle SetSummaryText(string cs)
			{
				Java.Lang.String @string = (cs == null) ? null : new Java.Lang.String(cs);
				NotificationCompat.BigPictureStyle result = this.SetSummaryText(@string);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x06000566 RID: 1382 RVA: 0x0000FEE2 File Offset: 0x0000E0E2
			private static Delegate GetShowBigPictureWhenCollapsed_ZHandler()
			{
				if (NotificationCompat.BigPictureStyle.cb_showBigPictureWhenCollapsed_Z == null)
				{
					NotificationCompat.BigPictureStyle.cb_showBigPictureWhenCollapsed_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(NotificationCompat.BigPictureStyle.n_ShowBigPictureWhenCollapsed_Z));
				}
				return NotificationCompat.BigPictureStyle.cb_showBigPictureWhenCollapsed_Z;
			}

			// Token: 0x06000567 RID: 1383 RVA: 0x0000FF06 File Offset: 0x0000E106
			private static IntPtr n_ShowBigPictureWhenCollapsed_Z(IntPtr jnienv, IntPtr native__this, bool show)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.BigPictureStyle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShowBigPictureWhenCollapsed(show));
			}

			// Token: 0x06000568 RID: 1384 RVA: 0x0000FF1C File Offset: 0x0000E11C
			[Register("showBigPictureWhenCollapsed", "(Z)Landroidx/core/app/NotificationCompat$BigPictureStyle;", "GetShowBigPictureWhenCollapsed_ZHandler")]
			public unsafe virtual NotificationCompat.BigPictureStyle ShowBigPictureWhenCollapsed(bool show)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(show);
				return Java.Lang.Object.GetObject<NotificationCompat.BigPictureStyle>(NotificationCompat.BigPictureStyle._members.InstanceMethods.InvokeVirtualObjectMethod("showBigPictureWhenCollapsed.(Z)Landroidx/core/app/NotificationCompat$BigPictureStyle;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000160 RID: 352
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/NotificationCompat$BigPictureStyle", typeof(NotificationCompat.BigPictureStyle));

			// Token: 0x04000161 RID: 353
			private static Delegate cb_bigLargeIcon_Landroid_graphics_Bitmap_;

			// Token: 0x04000162 RID: 354
			private static Delegate cb_bigLargeIcon_Landroid_graphics_drawable_Icon_;

			// Token: 0x04000163 RID: 355
			private static Delegate cb_bigPicture_Landroid_graphics_Bitmap_;

			// Token: 0x04000164 RID: 356
			private static Delegate cb_bigPicture_Landroid_graphics_drawable_Icon_;

			// Token: 0x04000165 RID: 357
			private static Delegate cb_setBigContentTitle_Ljava_lang_CharSequence_;

			// Token: 0x04000166 RID: 358
			private static Delegate cb_setContentDescription_Ljava_lang_CharSequence_;

			// Token: 0x04000167 RID: 359
			private static Delegate cb_setSummaryText_Ljava_lang_CharSequence_;

			// Token: 0x04000168 RID: 360
			private static Delegate cb_showBigPictureWhenCollapsed_Z;
		}

		// Token: 0x02000077 RID: 119
		[Register("androidx/core/app/NotificationCompat$BubbleMetadata", DoNotGenerateAcw = true)]
		public sealed class BubbleMetadata : Java.Lang.Object
		{
			// Token: 0x170000FF RID: 255
			// (get) Token: 0x0600056A RID: 1386 RVA: 0x0000FF80 File Offset: 0x0000E180
			internal static IntPtr class_ref
			{
				get
				{
					return NotificationCompat.BubbleMetadata._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000100 RID: 256
			// (get) Token: 0x0600056B RID: 1387 RVA: 0x0000FFA4 File Offset: 0x0000E1A4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return NotificationCompat.BubbleMetadata._members;
				}
			}

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x0600056C RID: 1388 RVA: 0x0000FFAC File Offset: 0x0000E1AC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return NotificationCompat.BubbleMetadata._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000102 RID: 258
			// (get) Token: 0x0600056D RID: 1389 RVA: 0x0000FFD0 File Offset: 0x0000E1D0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return NotificationCompat.BubbleMetadata._members.ManagedPeerType;
				}
			}

			// Token: 0x0600056E RID: 1390 RVA: 0x00002384 File Offset: 0x00000584
			internal BubbleMetadata(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x17000103 RID: 259
			// (get) Token: 0x0600056F RID: 1391 RVA: 0x0000FFDC File Offset: 0x0000E1DC
			public bool AutoExpandBubble
			{
				[Register("getAutoExpandBubble", "()Z", "")]
				get
				{
					return NotificationCompat.BubbleMetadata._members.InstanceMethods.InvokeAbstractBooleanMethod("getAutoExpandBubble.()Z", this, null);
				}
			}

			// Token: 0x17000104 RID: 260
			// (get) Token: 0x06000570 RID: 1392 RVA: 0x0000FFF8 File Offset: 0x0000E1F8
			public PendingIntent DeleteIntent
			{
				[Register("getDeleteIntent", "()Landroid/app/PendingIntent;", "")]
				get
				{
					return Java.Lang.Object.GetObject<PendingIntent>(NotificationCompat.BubbleMetadata._members.InstanceMethods.InvokeAbstractObjectMethod("getDeleteIntent.()Landroid/app/PendingIntent;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000105 RID: 261
			// (get) Token: 0x06000571 RID: 1393 RVA: 0x0001002A File Offset: 0x0000E22A
			public int DesiredHeight
			{
				[Register("getDesiredHeight", "()I", "")]
				get
				{
					return NotificationCompat.BubbleMetadata._members.InstanceMethods.InvokeAbstractInt32Method("getDesiredHeight.()I", this, null);
				}
			}

			// Token: 0x17000106 RID: 262
			// (get) Token: 0x06000572 RID: 1394 RVA: 0x00010043 File Offset: 0x0000E243
			public int DesiredHeightResId
			{
				[Register("getDesiredHeightResId", "()I", "")]
				get
				{
					return NotificationCompat.BubbleMetadata._members.InstanceMethods.InvokeAbstractInt32Method("getDesiredHeightResId.()I", this, null);
				}
			}

			// Token: 0x17000107 RID: 263
			// (get) Token: 0x06000573 RID: 1395 RVA: 0x0001005C File Offset: 0x0000E25C
			public IconCompat Icon
			{
				[Register("getIcon", "()Landroidx/core/graphics/drawable/IconCompat;", "")]
				get
				{
					return Java.Lang.Object.GetObject<IconCompat>(NotificationCompat.BubbleMetadata._members.InstanceMethods.InvokeAbstractObjectMethod("getIcon.()Landroidx/core/graphics/drawable/IconCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000108 RID: 264
			// (get) Token: 0x06000574 RID: 1396 RVA: 0x00010090 File Offset: 0x0000E290
			public PendingIntent Intent
			{
				[Register("getIntent", "()Landroid/app/PendingIntent;", "")]
				get
				{
					return Java.Lang.Object.GetObject<PendingIntent>(NotificationCompat.BubbleMetadata._members.InstanceMethods.InvokeAbstractObjectMethod("getIntent.()Landroid/app/PendingIntent;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000109 RID: 265
			// (get) Token: 0x06000575 RID: 1397 RVA: 0x000100C2 File Offset: 0x0000E2C2
			public bool IsNotificationSuppressed
			{
				[Register("isNotificationSuppressed", "()Z", "")]
				get
				{
					return NotificationCompat.BubbleMetadata._members.InstanceMethods.InvokeAbstractBooleanMethod("isNotificationSuppressed.()Z", this, null);
				}
			}

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x06000576 RID: 1398 RVA: 0x000100DC File Offset: 0x0000E2DC
			public string ShortcutId
			{
				[Register("getShortcutId", "()Ljava/lang/String;", "")]
				get
				{
					return JNIEnv.GetString(NotificationCompat.BubbleMetadata._members.InstanceMethods.InvokeAbstractObjectMethod("getShortcutId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06000577 RID: 1399 RVA: 0x00010110 File Offset: 0x0000E310
			[Register("fromPlatform", "(Landroid/app/Notification$BubbleMetadata;)Landroidx/core/app/NotificationCompat$BubbleMetadata;", "")]
			public unsafe static NotificationCompat.BubbleMetadata FromPlatform(Notification.BubbleMetadata platformMetadata)
			{
				NotificationCompat.BubbleMetadata @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((platformMetadata == null) ? IntPtr.Zero : platformMetadata.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.BubbleMetadata>(NotificationCompat.BubbleMetadata._members.StaticMethods.InvokeObjectMethod("fromPlatform.(Landroid/app/Notification$BubbleMetadata;)Landroidx/core/app/NotificationCompat$BubbleMetadata;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(platformMetadata);
				}
				return @object;
			}

			// Token: 0x06000578 RID: 1400 RVA: 0x00010184 File Offset: 0x0000E384
			[Register("setFlags", "(I)V", "")]
			public unsafe void SetFlags(int flags)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(flags);
				NotificationCompat.BubbleMetadata._members.InstanceMethods.InvokeAbstractVoidMethod("setFlags.(I)V", this, ptr);
			}

			// Token: 0x06000579 RID: 1401 RVA: 0x000101C0 File Offset: 0x0000E3C0
			[Register("toPlatform", "(Landroidx/core/app/NotificationCompat$BubbleMetadata;)Landroid/app/Notification$BubbleMetadata;", "")]
			public unsafe static Notification.BubbleMetadata ToPlatform(NotificationCompat.BubbleMetadata compatMetadata)
			{
				Notification.BubbleMetadata @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((compatMetadata == null) ? IntPtr.Zero : compatMetadata.Handle);
					@object = Java.Lang.Object.GetObject<Notification.BubbleMetadata>(NotificationCompat.BubbleMetadata._members.StaticMethods.InvokeObjectMethod("toPlatform.(Landroidx/core/app/NotificationCompat$BubbleMetadata;)Landroid/app/Notification$BubbleMetadata;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(compatMetadata);
				}
				return @object;
			}

			// Token: 0x04000169 RID: 361
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/NotificationCompat$BubbleMetadata", typeof(NotificationCompat.BubbleMetadata));
		}

		// Token: 0x02000078 RID: 120
		[Register("androidx/core/app/NotificationCompat$Builder", DoNotGenerateAcw = true)]
		public class Builder : Java.Lang.Object
		{
			// Token: 0x1700010B RID: 267
			// (get) Token: 0x0600057B RID: 1403 RVA: 0x00010250 File Offset: 0x0000E450
			// (set) Token: 0x0600057C RID: 1404 RVA: 0x00010280 File Offset: 0x0000E480
			[Register("mActions")]
			public IList MActions
			{
				get
				{
					return JavaList.FromJniHandle(NotificationCompat.Builder._members.InstanceFields.GetObjectValue("mActions.Ljava/util/ArrayList;", this).Handle, JniHandleOwnership.TransferLocalRef);
				}
				set
				{
					IntPtr intPtr = JavaList.ToLocalJniHandle(value);
					try
					{
						NotificationCompat.Builder._members.InstanceFields.SetValue("mActions.Ljava/util/ArrayList;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
					}
					finally
					{
						JNIEnv.DeleteLocalRef(intPtr);
					}
				}
			}

			// Token: 0x1700010C RID: 268
			// (get) Token: 0x0600057D RID: 1405 RVA: 0x000102CC File Offset: 0x0000E4CC
			// (set) Token: 0x0600057E RID: 1406 RVA: 0x000102FC File Offset: 0x0000E4FC
			[Register("mContext")]
			public Context MContext
			{
				get
				{
					return Java.Lang.Object.GetObject<Context>(NotificationCompat.Builder._members.InstanceFields.GetObjectValue("mContext.Landroid/content/Context;", this).Handle, JniHandleOwnership.TransferLocalRef);
				}
				set
				{
					IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
					try
					{
						NotificationCompat.Builder._members.InstanceFields.SetValue("mContext.Landroid/content/Context;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
					}
					finally
					{
						JNIEnv.DeleteLocalRef(intPtr);
					}
				}
			}

			// Token: 0x1700010D RID: 269
			// (get) Token: 0x0600057F RID: 1407 RVA: 0x00010348 File Offset: 0x0000E548
			// (set) Token: 0x06000580 RID: 1408 RVA: 0x00010378 File Offset: 0x0000E578
			[Register("mPeople")]
			public IList MPeople
			{
				get
				{
					return JavaList.FromJniHandle(NotificationCompat.Builder._members.InstanceFields.GetObjectValue("mPeople.Ljava/util/ArrayList;", this).Handle, JniHandleOwnership.TransferLocalRef);
				}
				set
				{
					IntPtr intPtr = JavaList.ToLocalJniHandle(value);
					try
					{
						NotificationCompat.Builder._members.InstanceFields.SetValue("mPeople.Ljava/util/ArrayList;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
					}
					finally
					{
						JNIEnv.DeleteLocalRef(intPtr);
					}
				}
			}

			// Token: 0x1700010E RID: 270
			// (get) Token: 0x06000581 RID: 1409 RVA: 0x000103C4 File Offset: 0x0000E5C4
			// (set) Token: 0x06000582 RID: 1410 RVA: 0x000103F4 File Offset: 0x0000E5F4
			[Register("mPersonList")]
			public IList MPersonList
			{
				get
				{
					return JavaList.FromJniHandle(NotificationCompat.Builder._members.InstanceFields.GetObjectValue("mPersonList.Ljava/util/ArrayList;", this).Handle, JniHandleOwnership.TransferLocalRef);
				}
				set
				{
					IntPtr intPtr = JavaList.ToLocalJniHandle(value);
					try
					{
						NotificationCompat.Builder._members.InstanceFields.SetValue("mPersonList.Ljava/util/ArrayList;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
					}
					finally
					{
						JNIEnv.DeleteLocalRef(intPtr);
					}
				}
			}

			// Token: 0x1700010F RID: 271
			// (get) Token: 0x06000583 RID: 1411 RVA: 0x00010440 File Offset: 0x0000E640
			internal static IntPtr class_ref
			{
				get
				{
					return NotificationCompat.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000110 RID: 272
			// (get) Token: 0x06000584 RID: 1412 RVA: 0x00010464 File Offset: 0x0000E664
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return NotificationCompat.Builder._members;
				}
			}

			// Token: 0x17000111 RID: 273
			// (get) Token: 0x06000585 RID: 1413 RVA: 0x0001046C File Offset: 0x0000E66C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return NotificationCompat.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000112 RID: 274
			// (get) Token: 0x06000586 RID: 1414 RVA: 0x00010490 File Offset: 0x0000E690
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return NotificationCompat.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x06000587 RID: 1415 RVA: 0x00002384 File Offset: 0x00000584
			protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000588 RID: 1416 RVA: 0x0001049C File Offset: 0x0000E69C
			[Register(".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe Builder(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
					base.SetHandle(NotificationCompat.Builder._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					NotificationCompat.Builder._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(context);
				}
			}

			// Token: 0x06000589 RID: 1417 RVA: 0x0001054C File Offset: 0x0000E74C
			[Register(".ctor", "(Landroid/content/Context;Landroid/app/Notification;)V", "")]
			public unsafe Builder(Context context, Notification notification) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
					ptr[1] = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
					base.SetHandle(NotificationCompat.Builder._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/app/Notification;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					NotificationCompat.Builder._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/app/Notification;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(context);
					GC.KeepAlive(notification);
				}
			}

			// Token: 0x0600058A RID: 1418 RVA: 0x00010624 File Offset: 0x0000E824
			[Register(".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
			public unsafe Builder(Context context, string channelId) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				IntPtr intPtr = JNIEnv.NewString(channelId);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					base.SetHandle(NotificationCompat.Builder._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					NotificationCompat.Builder._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Ljava/lang/String;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(context);
				}
			}

			// Token: 0x0600058B RID: 1419 RVA: 0x000106F0 File Offset: 0x0000E8F0
			private static Delegate GetGetBigContentViewHandler()
			{
				if (NotificationCompat.Builder.cb_getBigContentView == null)
				{
					NotificationCompat.Builder.cb_getBigContentView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationCompat.Builder.n_GetBigContentView));
				}
				return NotificationCompat.Builder.cb_getBigContentView;
			}

			// Token: 0x0600058C RID: 1420 RVA: 0x00010714 File Offset: 0x0000E914
			private static IntPtr n_GetBigContentView(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BigContentView);
			}

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x0600058D RID: 1421 RVA: 0x00010728 File Offset: 0x0000E928
			public virtual RemoteViews BigContentView
			{
				[Register("getBigContentView", "()Landroid/widget/RemoteViews;", "GetGetBigContentViewHandler")]
				get
				{
					return Java.Lang.Object.GetObject<RemoteViews>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("getBigContentView.()Landroid/widget/RemoteViews;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x0600058E RID: 1422 RVA: 0x0001075A File Offset: 0x0000E95A
			private static Delegate GetGetBubbleMetadataHandler()
			{
				if (NotificationCompat.Builder.cb_getBubbleMetadata == null)
				{
					NotificationCompat.Builder.cb_getBubbleMetadata = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationCompat.Builder.n_GetBubbleMetadata));
				}
				return NotificationCompat.Builder.cb_getBubbleMetadata;
			}

			// Token: 0x0600058F RID: 1423 RVA: 0x0001077E File Offset: 0x0000E97E
			private static IntPtr n_GetBubbleMetadata(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BubbleMetadata);
			}

			// Token: 0x17000114 RID: 276
			// (get) Token: 0x06000590 RID: 1424 RVA: 0x00010794 File Offset: 0x0000E994
			public virtual NotificationCompat.BubbleMetadata BubbleMetadata
			{
				[Register("getBubbleMetadata", "()Landroidx/core/app/NotificationCompat$BubbleMetadata;", "GetGetBubbleMetadataHandler")]
				get
				{
					return Java.Lang.Object.GetObject<NotificationCompat.BubbleMetadata>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("getBubbleMetadata.()Landroidx/core/app/NotificationCompat$BubbleMetadata;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06000591 RID: 1425 RVA: 0x000107C6 File Offset: 0x0000E9C6
			private static Delegate GetGetColorHandler()
			{
				if (NotificationCompat.Builder.cb_getColor == null)
				{
					NotificationCompat.Builder.cb_getColor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(NotificationCompat.Builder.n_GetColor));
				}
				return NotificationCompat.Builder.cb_getColor;
			}

			// Token: 0x06000592 RID: 1426 RVA: 0x000107EA File Offset: 0x0000E9EA
			private static int n_GetColor(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Color;
			}

			// Token: 0x17000115 RID: 277
			// (get) Token: 0x06000593 RID: 1427 RVA: 0x000107F9 File Offset: 0x0000E9F9
			public virtual int Color
			{
				[Register("getColor", "()I", "GetGetColorHandler")]
				get
				{
					return NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualInt32Method("getColor.()I", this, null);
				}
			}

			// Token: 0x06000594 RID: 1428 RVA: 0x00010812 File Offset: 0x0000EA12
			private static Delegate GetGetContentViewHandler()
			{
				if (NotificationCompat.Builder.cb_getContentView == null)
				{
					NotificationCompat.Builder.cb_getContentView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationCompat.Builder.n_GetContentView));
				}
				return NotificationCompat.Builder.cb_getContentView;
			}

			// Token: 0x06000595 RID: 1429 RVA: 0x00010836 File Offset: 0x0000EA36
			private static IntPtr n_GetContentView(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentView);
			}

			// Token: 0x17000116 RID: 278
			// (get) Token: 0x06000596 RID: 1430 RVA: 0x0001084C File Offset: 0x0000EA4C
			public virtual RemoteViews ContentView
			{
				[Register("getContentView", "()Landroid/widget/RemoteViews;", "GetGetContentViewHandler")]
				get
				{
					return Java.Lang.Object.GetObject<RemoteViews>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("getContentView.()Landroid/widget/RemoteViews;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06000597 RID: 1431 RVA: 0x0001087E File Offset: 0x0000EA7E
			private static Delegate GetGetExtrasHandler()
			{
				if (NotificationCompat.Builder.cb_getExtras == null)
				{
					NotificationCompat.Builder.cb_getExtras = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationCompat.Builder.n_GetExtras));
				}
				return NotificationCompat.Builder.cb_getExtras;
			}

			// Token: 0x06000598 RID: 1432 RVA: 0x000108A2 File Offset: 0x0000EAA2
			private static IntPtr n_GetExtras(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Extras);
			}

			// Token: 0x17000117 RID: 279
			// (get) Token: 0x06000599 RID: 1433 RVA: 0x000108B8 File Offset: 0x0000EAB8
			public virtual Bundle Extras
			{
				[Register("getExtras", "()Landroid/os/Bundle;", "GetGetExtrasHandler")]
				get
				{
					return Java.Lang.Object.GetObject<Bundle>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("getExtras.()Landroid/os/Bundle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x0600059A RID: 1434 RVA: 0x000108EA File Offset: 0x0000EAEA
			private static Delegate GetGetForegroundServiceBehaviorHandler()
			{
				if (NotificationCompat.Builder.cb_getForegroundServiceBehavior == null)
				{
					NotificationCompat.Builder.cb_getForegroundServiceBehavior = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(NotificationCompat.Builder.n_GetForegroundServiceBehavior));
				}
				return NotificationCompat.Builder.cb_getForegroundServiceBehavior;
			}

			// Token: 0x0600059B RID: 1435 RVA: 0x0001090E File Offset: 0x0000EB0E
			private static int n_GetForegroundServiceBehavior(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ForegroundServiceBehavior;
			}

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x0600059C RID: 1436 RVA: 0x0001091D File Offset: 0x0000EB1D
			public virtual int ForegroundServiceBehavior
			{
				[Register("getForegroundServiceBehavior", "()I", "GetGetForegroundServiceBehaviorHandler")]
				get
				{
					return NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualInt32Method("getForegroundServiceBehavior.()I", this, null);
				}
			}

			// Token: 0x0600059D RID: 1437 RVA: 0x00010936 File Offset: 0x0000EB36
			private static Delegate GetGetHeadsUpContentViewHandler()
			{
				if (NotificationCompat.Builder.cb_getHeadsUpContentView == null)
				{
					NotificationCompat.Builder.cb_getHeadsUpContentView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationCompat.Builder.n_GetHeadsUpContentView));
				}
				return NotificationCompat.Builder.cb_getHeadsUpContentView;
			}

			// Token: 0x0600059E RID: 1438 RVA: 0x0001095A File Offset: 0x0000EB5A
			private static IntPtr n_GetHeadsUpContentView(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HeadsUpContentView);
			}

			// Token: 0x17000119 RID: 281
			// (get) Token: 0x0600059F RID: 1439 RVA: 0x00010970 File Offset: 0x0000EB70
			public virtual RemoteViews HeadsUpContentView
			{
				[Register("getHeadsUpContentView", "()Landroid/widget/RemoteViews;", "GetGetHeadsUpContentViewHandler")]
				get
				{
					return Java.Lang.Object.GetObject<RemoteViews>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("getHeadsUpContentView.()Landroid/widget/RemoteViews;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x060005A0 RID: 1440 RVA: 0x000109A2 File Offset: 0x0000EBA2
			private static Delegate GetGetNotificationHandler()
			{
				if (NotificationCompat.Builder.cb_getNotification == null)
				{
					NotificationCompat.Builder.cb_getNotification = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationCompat.Builder.n_GetNotification));
				}
				return NotificationCompat.Builder.cb_getNotification;
			}

			// Token: 0x060005A1 RID: 1441 RVA: 0x000109C6 File Offset: 0x0000EBC6
			private static IntPtr n_GetNotification(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Notification);
			}

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x060005A2 RID: 1442 RVA: 0x000109DC File Offset: 0x0000EBDC
			public virtual Notification Notification
			{
				[Register("getNotification", "()Landroid/app/Notification;", "GetGetNotificationHandler")]
				get
				{
					return Java.Lang.Object.GetObject<Notification>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("getNotification.()Landroid/app/Notification;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x060005A3 RID: 1443 RVA: 0x00010A0E File Offset: 0x0000EC0E
			private static Delegate GetGetPriorityHandler()
			{
				if (NotificationCompat.Builder.cb_getPriority == null)
				{
					NotificationCompat.Builder.cb_getPriority = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(NotificationCompat.Builder.n_GetPriority));
				}
				return NotificationCompat.Builder.cb_getPriority;
			}

			// Token: 0x060005A4 RID: 1444 RVA: 0x00010A32 File Offset: 0x0000EC32
			private static int n_GetPriority(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Priority;
			}

			// Token: 0x1700011B RID: 283
			// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00010A41 File Offset: 0x0000EC41
			public virtual int Priority
			{
				[Register("getPriority", "()I", "GetGetPriorityHandler")]
				get
				{
					return NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualInt32Method("getPriority.()I", this, null);
				}
			}

			// Token: 0x060005A6 RID: 1446 RVA: 0x00010A5A File Offset: 0x0000EC5A
			private static Delegate GetGetWhenIfShowingHandler()
			{
				if (NotificationCompat.Builder.cb_getWhenIfShowing == null)
				{
					NotificationCompat.Builder.cb_getWhenIfShowing = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(NotificationCompat.Builder.n_GetWhenIfShowing));
				}
				return NotificationCompat.Builder.cb_getWhenIfShowing;
			}

			// Token: 0x060005A7 RID: 1447 RVA: 0x00010A7E File Offset: 0x0000EC7E
			private static long n_GetWhenIfShowing(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WhenIfShowing;
			}

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x060005A8 RID: 1448 RVA: 0x00010A8D File Offset: 0x0000EC8D
			public virtual long WhenIfShowing
			{
				[Register("getWhenIfShowing", "()J", "GetGetWhenIfShowingHandler")]
				get
				{
					return NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualInt64Method("getWhenIfShowing.()J", this, null);
				}
			}

			// Token: 0x060005A9 RID: 1449 RVA: 0x00010AA6 File Offset: 0x0000ECA6
			private static Delegate GetAddAction_Landroidx_core_app_NotificationCompat_Action_Handler()
			{
				if (NotificationCompat.Builder.cb_addAction_Landroidx_core_app_NotificationCompat_Action_ == null)
				{
					NotificationCompat.Builder.cb_addAction_Landroidx_core_app_NotificationCompat_Action_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_AddAction_Landroidx_core_app_NotificationCompat_Action_));
				}
				return NotificationCompat.Builder.cb_addAction_Landroidx_core_app_NotificationCompat_Action_;
			}

			// Token: 0x060005AA RID: 1450 RVA: 0x00010ACC File Offset: 0x0000ECCC
			private static IntPtr n_AddAction_Landroidx_core_app_NotificationCompat_Action_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				NotificationCompat.Action object2 = Java.Lang.Object.GetObject<NotificationCompat.Action>(native_action, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.AddAction(object2));
			}

			// Token: 0x060005AB RID: 1451 RVA: 0x00010AF4 File Offset: 0x0000ECF4
			[Register("addAction", "(Landroidx/core/app/NotificationCompat$Action;)Landroidx/core/app/NotificationCompat$Builder;", "GetAddAction_Landroidx_core_app_NotificationCompat_Action_Handler")]
			public unsafe virtual NotificationCompat.Builder AddAction(NotificationCompat.Action action)
			{
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((action == null) ? IntPtr.Zero : action.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("addAction.(Landroidx/core/app/NotificationCompat$Action;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(action);
				}
				return @object;
			}

			// Token: 0x060005AC RID: 1452 RVA: 0x00010B68 File Offset: 0x0000ED68
			private static Delegate GetAddAction_ILjava_lang_CharSequence_Landroid_app_PendingIntent_Handler()
			{
				if (NotificationCompat.Builder.cb_addAction_ILjava_lang_CharSequence_Landroid_app_PendingIntent_ == null)
				{
					NotificationCompat.Builder.cb_addAction_ILjava_lang_CharSequence_Landroid_app_PendingIntent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILL_L(NotificationCompat.Builder.n_AddAction_ILjava_lang_CharSequence_Landroid_app_PendingIntent_));
				}
				return NotificationCompat.Builder.cb_addAction_ILjava_lang_CharSequence_Landroid_app_PendingIntent_;
			}

			// Token: 0x060005AD RID: 1453 RVA: 0x00010B8C File Offset: 0x0000ED8C
			private static IntPtr n_AddAction_ILjava_lang_CharSequence_Landroid_app_PendingIntent_(IntPtr jnienv, IntPtr native__this, int icon, IntPtr native_title, IntPtr native_intent)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
				PendingIntent object3 = Java.Lang.Object.GetObject<PendingIntent>(native_intent, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.AddAction(icon, object2, object3));
			}

			// Token: 0x060005AE RID: 1454 RVA: 0x00010BC0 File Offset: 0x0000EDC0
			[Register("addAction", "(ILjava/lang/CharSequence;Landroid/app/PendingIntent;)Landroidx/core/app/NotificationCompat$Builder;", "GetAddAction_ILjava_lang_CharSequence_Landroid_app_PendingIntent_Handler")]
			public unsafe virtual NotificationCompat.Builder AddAction(int icon, ICharSequence title, PendingIntent intent)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(icon);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("addAction.(ILjava/lang/CharSequence;Landroid/app/PendingIntent;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(title);
					GC.KeepAlive(intent);
				}
				return @object;
			}

			// Token: 0x060005AF RID: 1455 RVA: 0x00010C70 File Offset: 0x0000EE70
			public NotificationCompat.Builder AddAction(int icon, string title, PendingIntent intent)
			{
				Java.Lang.String @string = (title == null) ? null : new Java.Lang.String(title);
				NotificationCompat.Builder result = this.AddAction(icon, @string, intent);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x060005B0 RID: 1456 RVA: 0x00010C9C File Offset: 0x0000EE9C
			private static Delegate GetAddExtras_Landroid_os_Bundle_Handler()
			{
				if (NotificationCompat.Builder.cb_addExtras_Landroid_os_Bundle_ == null)
				{
					NotificationCompat.Builder.cb_addExtras_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_AddExtras_Landroid_os_Bundle_));
				}
				return NotificationCompat.Builder.cb_addExtras_Landroid_os_Bundle_;
			}

			// Token: 0x060005B1 RID: 1457 RVA: 0x00010CC0 File Offset: 0x0000EEC0
			private static IntPtr n_AddExtras_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_extras)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_extras, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.AddExtras(object2));
			}

			// Token: 0x060005B2 RID: 1458 RVA: 0x00010CE8 File Offset: 0x0000EEE8
			[Register("addExtras", "(Landroid/os/Bundle;)Landroidx/core/app/NotificationCompat$Builder;", "GetAddExtras_Landroid_os_Bundle_Handler")]
			public unsafe virtual NotificationCompat.Builder AddExtras(Bundle extras)
			{
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((extras == null) ? IntPtr.Zero : extras.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("addExtras.(Landroid/os/Bundle;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(extras);
				}
				return @object;
			}

			// Token: 0x060005B3 RID: 1459 RVA: 0x00010D5C File Offset: 0x0000EF5C
			private static Delegate GetAddInvisibleAction_Landroidx_core_app_NotificationCompat_Action_Handler()
			{
				if (NotificationCompat.Builder.cb_addInvisibleAction_Landroidx_core_app_NotificationCompat_Action_ == null)
				{
					NotificationCompat.Builder.cb_addInvisibleAction_Landroidx_core_app_NotificationCompat_Action_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_AddInvisibleAction_Landroidx_core_app_NotificationCompat_Action_));
				}
				return NotificationCompat.Builder.cb_addInvisibleAction_Landroidx_core_app_NotificationCompat_Action_;
			}

			// Token: 0x060005B4 RID: 1460 RVA: 0x00010D80 File Offset: 0x0000EF80
			private static IntPtr n_AddInvisibleAction_Landroidx_core_app_NotificationCompat_Action_(IntPtr jnienv, IntPtr native__this, IntPtr native_action)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				NotificationCompat.Action object2 = Java.Lang.Object.GetObject<NotificationCompat.Action>(native_action, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.AddInvisibleAction(object2));
			}

			// Token: 0x060005B5 RID: 1461 RVA: 0x00010DA8 File Offset: 0x0000EFA8
			[Register("addInvisibleAction", "(Landroidx/core/app/NotificationCompat$Action;)Landroidx/core/app/NotificationCompat$Builder;", "GetAddInvisibleAction_Landroidx_core_app_NotificationCompat_Action_Handler")]
			public unsafe virtual NotificationCompat.Builder AddInvisibleAction(NotificationCompat.Action action)
			{
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((action == null) ? IntPtr.Zero : action.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("addInvisibleAction.(Landroidx/core/app/NotificationCompat$Action;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(action);
				}
				return @object;
			}

			// Token: 0x060005B6 RID: 1462 RVA: 0x00010E1C File Offset: 0x0000F01C
			private static Delegate GetAddInvisibleAction_ILjava_lang_CharSequence_Landroid_app_PendingIntent_Handler()
			{
				if (NotificationCompat.Builder.cb_addInvisibleAction_ILjava_lang_CharSequence_Landroid_app_PendingIntent_ == null)
				{
					NotificationCompat.Builder.cb_addInvisibleAction_ILjava_lang_CharSequence_Landroid_app_PendingIntent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILL_L(NotificationCompat.Builder.n_AddInvisibleAction_ILjava_lang_CharSequence_Landroid_app_PendingIntent_));
				}
				return NotificationCompat.Builder.cb_addInvisibleAction_ILjava_lang_CharSequence_Landroid_app_PendingIntent_;
			}

			// Token: 0x060005B7 RID: 1463 RVA: 0x00010E40 File Offset: 0x0000F040
			private static IntPtr n_AddInvisibleAction_ILjava_lang_CharSequence_Landroid_app_PendingIntent_(IntPtr jnienv, IntPtr native__this, int icon, IntPtr native_title, IntPtr native_intent)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
				PendingIntent object3 = Java.Lang.Object.GetObject<PendingIntent>(native_intent, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.AddInvisibleAction(icon, object2, object3));
			}

			// Token: 0x060005B8 RID: 1464 RVA: 0x00010E74 File Offset: 0x0000F074
			[Register("addInvisibleAction", "(ILjava/lang/CharSequence;Landroid/app/PendingIntent;)Landroidx/core/app/NotificationCompat$Builder;", "GetAddInvisibleAction_ILjava_lang_CharSequence_Landroid_app_PendingIntent_Handler")]
			public unsafe virtual NotificationCompat.Builder AddInvisibleAction(int icon, ICharSequence title, PendingIntent intent)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(icon);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("addInvisibleAction.(ILjava/lang/CharSequence;Landroid/app/PendingIntent;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(title);
					GC.KeepAlive(intent);
				}
				return @object;
			}

			// Token: 0x060005B9 RID: 1465 RVA: 0x00010F24 File Offset: 0x0000F124
			public NotificationCompat.Builder AddInvisibleAction(int icon, string title, PendingIntent intent)
			{
				Java.Lang.String @string = (title == null) ? null : new Java.Lang.String(title);
				NotificationCompat.Builder result = this.AddInvisibleAction(icon, @string, intent);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x060005BA RID: 1466 RVA: 0x00010F50 File Offset: 0x0000F150
			private static Delegate GetAddPerson_Landroidx_core_app_Person_Handler()
			{
				if (NotificationCompat.Builder.cb_addPerson_Landroidx_core_app_Person_ == null)
				{
					NotificationCompat.Builder.cb_addPerson_Landroidx_core_app_Person_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_AddPerson_Landroidx_core_app_Person_));
				}
				return NotificationCompat.Builder.cb_addPerson_Landroidx_core_app_Person_;
			}

			// Token: 0x060005BB RID: 1467 RVA: 0x00010F74 File Offset: 0x0000F174
			private static IntPtr n_AddPerson_Landroidx_core_app_Person_(IntPtr jnienv, IntPtr native__this, IntPtr native_person)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Person object2 = Java.Lang.Object.GetObject<Person>(native_person, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.AddPerson(object2));
			}

			// Token: 0x060005BC RID: 1468 RVA: 0x00010F9C File Offset: 0x0000F19C
			[Register("addPerson", "(Landroidx/core/app/Person;)Landroidx/core/app/NotificationCompat$Builder;", "GetAddPerson_Landroidx_core_app_Person_Handler")]
			public unsafe virtual NotificationCompat.Builder AddPerson(Person person)
			{
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((person == null) ? IntPtr.Zero : person.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("addPerson.(Landroidx/core/app/Person;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(person);
				}
				return @object;
			}

			// Token: 0x060005BD RID: 1469 RVA: 0x00011010 File Offset: 0x0000F210
			private static Delegate GetAddPerson_Ljava_lang_String_Handler()
			{
				if (NotificationCompat.Builder.cb_addPerson_Ljava_lang_String_ == null)
				{
					NotificationCompat.Builder.cb_addPerson_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_AddPerson_Ljava_lang_String_));
				}
				return NotificationCompat.Builder.cb_addPerson_Ljava_lang_String_;
			}

			// Token: 0x060005BE RID: 1470 RVA: 0x00011034 File Offset: 0x0000F234
			private static IntPtr n_AddPerson_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_uri, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.AddPerson(@string));
			}

			// Token: 0x060005BF RID: 1471 RVA: 0x0001105C File Offset: 0x0000F25C
			[Register("addPerson", "(Ljava/lang/String;)Landroidx/core/app/NotificationCompat$Builder;", "GetAddPerson_Ljava_lang_String_Handler")]
			public unsafe virtual NotificationCompat.Builder AddPerson(string uri)
			{
				IntPtr intPtr = JNIEnv.NewString(uri);
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("addPerson.(Ljava/lang/String;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x060005C0 RID: 1472 RVA: 0x000110C8 File Offset: 0x0000F2C8
			private static Delegate GetBuildHandler()
			{
				if (NotificationCompat.Builder.cb_build == null)
				{
					NotificationCompat.Builder.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationCompat.Builder.n_Build));
				}
				return NotificationCompat.Builder.cb_build;
			}

			// Token: 0x060005C1 RID: 1473 RVA: 0x000110EC File Offset: 0x0000F2EC
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
			}

			// Token: 0x060005C2 RID: 1474 RVA: 0x00011100 File Offset: 0x0000F300
			[Register("build", "()Landroid/app/Notification;", "GetBuildHandler")]
			public virtual Notification Build()
			{
				return Java.Lang.Object.GetObject<Notification>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("build.()Landroid/app/Notification;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060005C3 RID: 1475 RVA: 0x00011132 File Offset: 0x0000F332
			private static Delegate GetClearActionsHandler()
			{
				if (NotificationCompat.Builder.cb_clearActions == null)
				{
					NotificationCompat.Builder.cb_clearActions = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationCompat.Builder.n_ClearActions));
				}
				return NotificationCompat.Builder.cb_clearActions;
			}

			// Token: 0x060005C4 RID: 1476 RVA: 0x00011156 File Offset: 0x0000F356
			private static IntPtr n_ClearActions(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearActions());
			}

			// Token: 0x060005C5 RID: 1477 RVA: 0x0001116C File Offset: 0x0000F36C
			[Register("clearActions", "()Landroidx/core/app/NotificationCompat$Builder;", "GetClearActionsHandler")]
			public virtual NotificationCompat.Builder ClearActions()
			{
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("clearActions.()Landroidx/core/app/NotificationCompat$Builder;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060005C6 RID: 1478 RVA: 0x0001119E File Offset: 0x0000F39E
			private static Delegate GetClearInvisibleActionsHandler()
			{
				if (NotificationCompat.Builder.cb_clearInvisibleActions == null)
				{
					NotificationCompat.Builder.cb_clearInvisibleActions = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationCompat.Builder.n_ClearInvisibleActions));
				}
				return NotificationCompat.Builder.cb_clearInvisibleActions;
			}

			// Token: 0x060005C7 RID: 1479 RVA: 0x000111C2 File Offset: 0x0000F3C2
			private static IntPtr n_ClearInvisibleActions(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearInvisibleActions());
			}

			// Token: 0x060005C8 RID: 1480 RVA: 0x000111D8 File Offset: 0x0000F3D8
			[Register("clearInvisibleActions", "()Landroidx/core/app/NotificationCompat$Builder;", "GetClearInvisibleActionsHandler")]
			public virtual NotificationCompat.Builder ClearInvisibleActions()
			{
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("clearInvisibleActions.()Landroidx/core/app/NotificationCompat$Builder;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060005C9 RID: 1481 RVA: 0x0001120A File Offset: 0x0000F40A
			private static Delegate GetClearPeopleHandler()
			{
				if (NotificationCompat.Builder.cb_clearPeople == null)
				{
					NotificationCompat.Builder.cb_clearPeople = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationCompat.Builder.n_ClearPeople));
				}
				return NotificationCompat.Builder.cb_clearPeople;
			}

			// Token: 0x060005CA RID: 1482 RVA: 0x0001122E File Offset: 0x0000F42E
			private static IntPtr n_ClearPeople(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearPeople());
			}

			// Token: 0x060005CB RID: 1483 RVA: 0x00011244 File Offset: 0x0000F444
			[Register("clearPeople", "()Landroidx/core/app/NotificationCompat$Builder;", "GetClearPeopleHandler")]
			public virtual NotificationCompat.Builder ClearPeople()
			{
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("clearPeople.()Landroidx/core/app/NotificationCompat$Builder;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060005CC RID: 1484 RVA: 0x00011276 File Offset: 0x0000F476
			private static Delegate GetCreateBigContentViewHandler()
			{
				if (NotificationCompat.Builder.cb_createBigContentView == null)
				{
					NotificationCompat.Builder.cb_createBigContentView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationCompat.Builder.n_CreateBigContentView));
				}
				return NotificationCompat.Builder.cb_createBigContentView;
			}

			// Token: 0x060005CD RID: 1485 RVA: 0x0001129A File Offset: 0x0000F49A
			private static IntPtr n_CreateBigContentView(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CreateBigContentView());
			}

			// Token: 0x060005CE RID: 1486 RVA: 0x000112B0 File Offset: 0x0000F4B0
			[Register("createBigContentView", "()Landroid/widget/RemoteViews;", "GetCreateBigContentViewHandler")]
			public virtual RemoteViews CreateBigContentView()
			{
				return Java.Lang.Object.GetObject<RemoteViews>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("createBigContentView.()Landroid/widget/RemoteViews;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060005CF RID: 1487 RVA: 0x000112E2 File Offset: 0x0000F4E2
			private static Delegate GetCreateContentViewHandler()
			{
				if (NotificationCompat.Builder.cb_createContentView == null)
				{
					NotificationCompat.Builder.cb_createContentView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationCompat.Builder.n_CreateContentView));
				}
				return NotificationCompat.Builder.cb_createContentView;
			}

			// Token: 0x060005D0 RID: 1488 RVA: 0x00011306 File Offset: 0x0000F506
			private static IntPtr n_CreateContentView(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CreateContentView());
			}

			// Token: 0x060005D1 RID: 1489 RVA: 0x0001131C File Offset: 0x0000F51C
			[Register("createContentView", "()Landroid/widget/RemoteViews;", "GetCreateContentViewHandler")]
			public virtual RemoteViews CreateContentView()
			{
				return Java.Lang.Object.GetObject<RemoteViews>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("createContentView.()Landroid/widget/RemoteViews;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060005D2 RID: 1490 RVA: 0x0001134E File Offset: 0x0000F54E
			private static Delegate GetCreateHeadsUpContentViewHandler()
			{
				if (NotificationCompat.Builder.cb_createHeadsUpContentView == null)
				{
					NotificationCompat.Builder.cb_createHeadsUpContentView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationCompat.Builder.n_CreateHeadsUpContentView));
				}
				return NotificationCompat.Builder.cb_createHeadsUpContentView;
			}

			// Token: 0x060005D3 RID: 1491 RVA: 0x00011372 File Offset: 0x0000F572
			private static IntPtr n_CreateHeadsUpContentView(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CreateHeadsUpContentView());
			}

			// Token: 0x060005D4 RID: 1492 RVA: 0x00011388 File Offset: 0x0000F588
			[Register("createHeadsUpContentView", "()Landroid/widget/RemoteViews;", "GetCreateHeadsUpContentViewHandler")]
			public virtual RemoteViews CreateHeadsUpContentView()
			{
				return Java.Lang.Object.GetObject<RemoteViews>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("createHeadsUpContentView.()Landroid/widget/RemoteViews;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060005D5 RID: 1493 RVA: 0x000113BA File Offset: 0x0000F5BA
			private static Delegate GetExtend_Landroidx_core_app_NotificationCompat_Extender_Handler()
			{
				if (NotificationCompat.Builder.cb_extend_Landroidx_core_app_NotificationCompat_Extender_ == null)
				{
					NotificationCompat.Builder.cb_extend_Landroidx_core_app_NotificationCompat_Extender_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_Extend_Landroidx_core_app_NotificationCompat_Extender_));
				}
				return NotificationCompat.Builder.cb_extend_Landroidx_core_app_NotificationCompat_Extender_;
			}

			// Token: 0x060005D6 RID: 1494 RVA: 0x000113E0 File Offset: 0x0000F5E0
			private static IntPtr n_Extend_Landroidx_core_app_NotificationCompat_Extender_(IntPtr jnienv, IntPtr native__this, IntPtr native_extender)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				NotificationCompat.IExtender object2 = Java.Lang.Object.GetObject<NotificationCompat.IExtender>(native_extender, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Extend(object2));
			}

			// Token: 0x060005D7 RID: 1495 RVA: 0x00011408 File Offset: 0x0000F608
			[Register("extend", "(Landroidx/core/app/NotificationCompat$Extender;)Landroidx/core/app/NotificationCompat$Builder;", "GetExtend_Landroidx_core_app_NotificationCompat_Extender_Handler")]
			public unsafe virtual NotificationCompat.Builder Extend(NotificationCompat.IExtender extender)
			{
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((extender == null) ? IntPtr.Zero : ((Java.Lang.Object)extender).Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("extend.(Landroidx/core/app/NotificationCompat$Extender;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(extender);
				}
				return @object;
			}

			// Token: 0x060005D8 RID: 1496 RVA: 0x00011480 File Offset: 0x0000F680
			[Register("limitCharSequenceLength", "(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", "")]
			protected unsafe static ICharSequence LimitCharSequenceLengthFormatted(ICharSequence cs)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(cs);
				ICharSequence @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<ICharSequence>(NotificationCompat.Builder._members.StaticMethods.InvokeObjectMethod("limitCharSequenceLength.(Ljava/lang/CharSequence;)Ljava/lang/CharSequence;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(cs);
				}
				return @object;
			}

			// Token: 0x060005D9 RID: 1497 RVA: 0x000114F0 File Offset: 0x0000F6F0
			protected static string LimitCharSequenceLength(string cs)
			{
				Java.Lang.String @string = (cs == null) ? null : new Java.Lang.String(cs);
				ICharSequence charSequence = NotificationCompat.Builder.LimitCharSequenceLengthFormatted(@string);
				string result = (charSequence != null) ? charSequence.ToString() : null;
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x060005DA RID: 1498 RVA: 0x00011525 File Offset: 0x0000F725
			private static Delegate GetSetAllowSystemGeneratedContextualActions_ZHandler()
			{
				if (NotificationCompat.Builder.cb_setAllowSystemGeneratedContextualActions_Z == null)
				{
					NotificationCompat.Builder.cb_setAllowSystemGeneratedContextualActions_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(NotificationCompat.Builder.n_SetAllowSystemGeneratedContextualActions_Z));
				}
				return NotificationCompat.Builder.cb_setAllowSystemGeneratedContextualActions_Z;
			}

			// Token: 0x060005DB RID: 1499 RVA: 0x00011549 File Offset: 0x0000F749
			private static IntPtr n_SetAllowSystemGeneratedContextualActions_Z(IntPtr jnienv, IntPtr native__this, bool allowed)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetAllowSystemGeneratedContextualActions(allowed));
			}

			// Token: 0x060005DC RID: 1500 RVA: 0x00011560 File Offset: 0x0000F760
			[Register("setAllowSystemGeneratedContextualActions", "(Z)Landroidx/core/app/NotificationCompat$Builder;", "GetSetAllowSystemGeneratedContextualActions_ZHandler")]
			public unsafe virtual NotificationCompat.Builder SetAllowSystemGeneratedContextualActions(bool allowed)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(allowed);
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setAllowSystemGeneratedContextualActions.(Z)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060005DD RID: 1501 RVA: 0x000115A9 File Offset: 0x0000F7A9
			private static Delegate GetSetAutoCancel_ZHandler()
			{
				if (NotificationCompat.Builder.cb_setAutoCancel_Z == null)
				{
					NotificationCompat.Builder.cb_setAutoCancel_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(NotificationCompat.Builder.n_SetAutoCancel_Z));
				}
				return NotificationCompat.Builder.cb_setAutoCancel_Z;
			}

			// Token: 0x060005DE RID: 1502 RVA: 0x000115CD File Offset: 0x0000F7CD
			private static IntPtr n_SetAutoCancel_Z(IntPtr jnienv, IntPtr native__this, bool autoCancel)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetAutoCancel(autoCancel));
			}

			// Token: 0x060005DF RID: 1503 RVA: 0x000115E4 File Offset: 0x0000F7E4
			[Register("setAutoCancel", "(Z)Landroidx/core/app/NotificationCompat$Builder;", "GetSetAutoCancel_ZHandler")]
			public unsafe virtual NotificationCompat.Builder SetAutoCancel(bool autoCancel)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(autoCancel);
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setAutoCancel.(Z)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060005E0 RID: 1504 RVA: 0x0001162D File Offset: 0x0000F82D
			private static Delegate GetSetBadgeIconType_IHandler()
			{
				if (NotificationCompat.Builder.cb_setBadgeIconType_I == null)
				{
					NotificationCompat.Builder.cb_setBadgeIconType_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(NotificationCompat.Builder.n_SetBadgeIconType_I));
				}
				return NotificationCompat.Builder.cb_setBadgeIconType_I;
			}

			// Token: 0x060005E1 RID: 1505 RVA: 0x00011651 File Offset: 0x0000F851
			private static IntPtr n_SetBadgeIconType_I(IntPtr jnienv, IntPtr native__this, int icon)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetBadgeIconType(icon));
			}

			// Token: 0x060005E2 RID: 1506 RVA: 0x00011668 File Offset: 0x0000F868
			[Register("setBadgeIconType", "(I)Landroidx/core/app/NotificationCompat$Builder;", "GetSetBadgeIconType_IHandler")]
			public unsafe virtual NotificationCompat.Builder SetBadgeIconType(int icon)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(icon);
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setBadgeIconType.(I)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060005E3 RID: 1507 RVA: 0x000116B1 File Offset: 0x0000F8B1
			private static Delegate GetSetBubbleMetadata_Landroidx_core_app_NotificationCompat_BubbleMetadata_Handler()
			{
				if (NotificationCompat.Builder.cb_setBubbleMetadata_Landroidx_core_app_NotificationCompat_BubbleMetadata_ == null)
				{
					NotificationCompat.Builder.cb_setBubbleMetadata_Landroidx_core_app_NotificationCompat_BubbleMetadata_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetBubbleMetadata_Landroidx_core_app_NotificationCompat_BubbleMetadata_));
				}
				return NotificationCompat.Builder.cb_setBubbleMetadata_Landroidx_core_app_NotificationCompat_BubbleMetadata_;
			}

			// Token: 0x060005E4 RID: 1508 RVA: 0x000116D8 File Offset: 0x0000F8D8
			private static IntPtr n_SetBubbleMetadata_Landroidx_core_app_NotificationCompat_BubbleMetadata_(IntPtr jnienv, IntPtr native__this, IntPtr native_data)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				NotificationCompat.BubbleMetadata object2 = Java.Lang.Object.GetObject<NotificationCompat.BubbleMetadata>(native_data, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetBubbleMetadata(object2));
			}

			// Token: 0x060005E5 RID: 1509 RVA: 0x00011700 File Offset: 0x0000F900
			[Register("setBubbleMetadata", "(Landroidx/core/app/NotificationCompat$BubbleMetadata;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetBubbleMetadata_Landroidx_core_app_NotificationCompat_BubbleMetadata_Handler")]
			public unsafe virtual NotificationCompat.Builder SetBubbleMetadata(NotificationCompat.BubbleMetadata data)
			{
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((data == null) ? IntPtr.Zero : data.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setBubbleMetadata.(Landroidx/core/app/NotificationCompat$BubbleMetadata;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(data);
				}
				return @object;
			}

			// Token: 0x060005E6 RID: 1510 RVA: 0x00011774 File Offset: 0x0000F974
			private static Delegate GetSetCategory_Ljava_lang_String_Handler()
			{
				if (NotificationCompat.Builder.cb_setCategory_Ljava_lang_String_ == null)
				{
					NotificationCompat.Builder.cb_setCategory_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetCategory_Ljava_lang_String_));
				}
				return NotificationCompat.Builder.cb_setCategory_Ljava_lang_String_;
			}

			// Token: 0x060005E7 RID: 1511 RVA: 0x00011798 File Offset: 0x0000F998
			private static IntPtr n_SetCategory_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_category)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_category, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetCategory(@string));
			}

			// Token: 0x060005E8 RID: 1512 RVA: 0x000117C0 File Offset: 0x0000F9C0
			[Register("setCategory", "(Ljava/lang/String;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetCategory_Ljava_lang_String_Handler")]
			public unsafe virtual NotificationCompat.Builder SetCategory(string category)
			{
				IntPtr intPtr = JNIEnv.NewString(category);
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setCategory.(Ljava/lang/String;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x060005E9 RID: 1513 RVA: 0x0001182C File Offset: 0x0000FA2C
			private static Delegate GetSetChannelId_Ljava_lang_String_Handler()
			{
				if (NotificationCompat.Builder.cb_setChannelId_Ljava_lang_String_ == null)
				{
					NotificationCompat.Builder.cb_setChannelId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetChannelId_Ljava_lang_String_));
				}
				return NotificationCompat.Builder.cb_setChannelId_Ljava_lang_String_;
			}

			// Token: 0x060005EA RID: 1514 RVA: 0x00011850 File Offset: 0x0000FA50
			private static IntPtr n_SetChannelId_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_channelId)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_channelId, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetChannelId(@string));
			}

			// Token: 0x060005EB RID: 1515 RVA: 0x00011878 File Offset: 0x0000FA78
			[Register("setChannelId", "(Ljava/lang/String;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetChannelId_Ljava_lang_String_Handler")]
			public unsafe virtual NotificationCompat.Builder SetChannelId(string channelId)
			{
				IntPtr intPtr = JNIEnv.NewString(channelId);
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setChannelId.(Ljava/lang/String;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x060005EC RID: 1516 RVA: 0x000118E4 File Offset: 0x0000FAE4
			private static Delegate GetSetChronometerCountDown_ZHandler()
			{
				if (NotificationCompat.Builder.cb_setChronometerCountDown_Z == null)
				{
					NotificationCompat.Builder.cb_setChronometerCountDown_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(NotificationCompat.Builder.n_SetChronometerCountDown_Z));
				}
				return NotificationCompat.Builder.cb_setChronometerCountDown_Z;
			}

			// Token: 0x060005ED RID: 1517 RVA: 0x00011908 File Offset: 0x0000FB08
			private static IntPtr n_SetChronometerCountDown_Z(IntPtr jnienv, IntPtr native__this, bool countsDown)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetChronometerCountDown(countsDown));
			}

			// Token: 0x060005EE RID: 1518 RVA: 0x00011920 File Offset: 0x0000FB20
			[Register("setChronometerCountDown", "(Z)Landroidx/core/app/NotificationCompat$Builder;", "GetSetChronometerCountDown_ZHandler")]
			public unsafe virtual NotificationCompat.Builder SetChronometerCountDown(bool countsDown)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(countsDown);
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setChronometerCountDown.(Z)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060005EF RID: 1519 RVA: 0x00011969 File Offset: 0x0000FB69
			private static Delegate GetSetColor_IHandler()
			{
				if (NotificationCompat.Builder.cb_setColor_I == null)
				{
					NotificationCompat.Builder.cb_setColor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(NotificationCompat.Builder.n_SetColor_I));
				}
				return NotificationCompat.Builder.cb_setColor_I;
			}

			// Token: 0x060005F0 RID: 1520 RVA: 0x0001198D File Offset: 0x0000FB8D
			private static IntPtr n_SetColor_I(IntPtr jnienv, IntPtr native__this, int argb)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetColor(argb));
			}

			// Token: 0x060005F1 RID: 1521 RVA: 0x000119A4 File Offset: 0x0000FBA4
			[Register("setColor", "(I)Landroidx/core/app/NotificationCompat$Builder;", "GetSetColor_IHandler")]
			public unsafe virtual NotificationCompat.Builder SetColor(int argb)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(argb);
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setColor.(I)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060005F2 RID: 1522 RVA: 0x000119ED File Offset: 0x0000FBED
			private static Delegate GetSetColorized_ZHandler()
			{
				if (NotificationCompat.Builder.cb_setColorized_Z == null)
				{
					NotificationCompat.Builder.cb_setColorized_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(NotificationCompat.Builder.n_SetColorized_Z));
				}
				return NotificationCompat.Builder.cb_setColorized_Z;
			}

			// Token: 0x060005F3 RID: 1523 RVA: 0x00011A11 File Offset: 0x0000FC11
			private static IntPtr n_SetColorized_Z(IntPtr jnienv, IntPtr native__this, bool colorize)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetColorized(colorize));
			}

			// Token: 0x060005F4 RID: 1524 RVA: 0x00011A28 File Offset: 0x0000FC28
			[Register("setColorized", "(Z)Landroidx/core/app/NotificationCompat$Builder;", "GetSetColorized_ZHandler")]
			public unsafe virtual NotificationCompat.Builder SetColorized(bool colorize)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(colorize);
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setColorized.(Z)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060005F5 RID: 1525 RVA: 0x00011A71 File Offset: 0x0000FC71
			private static Delegate GetSetContent_Landroid_widget_RemoteViews_Handler()
			{
				if (NotificationCompat.Builder.cb_setContent_Landroid_widget_RemoteViews_ == null)
				{
					NotificationCompat.Builder.cb_setContent_Landroid_widget_RemoteViews_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetContent_Landroid_widget_RemoteViews_));
				}
				return NotificationCompat.Builder.cb_setContent_Landroid_widget_RemoteViews_;
			}

			// Token: 0x060005F6 RID: 1526 RVA: 0x00011A98 File Offset: 0x0000FC98
			private static IntPtr n_SetContent_Landroid_widget_RemoteViews_(IntPtr jnienv, IntPtr native__this, IntPtr native_views)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RemoteViews object2 = Java.Lang.Object.GetObject<RemoteViews>(native_views, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetContent(object2));
			}

			// Token: 0x060005F7 RID: 1527 RVA: 0x00011AC0 File Offset: 0x0000FCC0
			[Register("setContent", "(Landroid/widget/RemoteViews;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetContent_Landroid_widget_RemoteViews_Handler")]
			public unsafe virtual NotificationCompat.Builder SetContent(RemoteViews views)
			{
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((views == null) ? IntPtr.Zero : views.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setContent.(Landroid/widget/RemoteViews;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(views);
				}
				return @object;
			}

			// Token: 0x060005F8 RID: 1528 RVA: 0x00011B34 File Offset: 0x0000FD34
			private static Delegate GetSetContentInfo_Ljava_lang_CharSequence_Handler()
			{
				if (NotificationCompat.Builder.cb_setContentInfo_Ljava_lang_CharSequence_ == null)
				{
					NotificationCompat.Builder.cb_setContentInfo_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetContentInfo_Ljava_lang_CharSequence_));
				}
				return NotificationCompat.Builder.cb_setContentInfo_Ljava_lang_CharSequence_;
			}

			// Token: 0x060005F9 RID: 1529 RVA: 0x00011B58 File Offset: 0x0000FD58
			private static IntPtr n_SetContentInfo_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_info)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_info, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetContentInfo(object2));
			}

			// Token: 0x060005FA RID: 1530 RVA: 0x00011B80 File Offset: 0x0000FD80
			[Register("setContentInfo", "(Ljava/lang/CharSequence;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetContentInfo_Ljava_lang_CharSequence_Handler")]
			public unsafe virtual NotificationCompat.Builder SetContentInfo(ICharSequence info)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(info);
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setContentInfo.(Ljava/lang/CharSequence;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(info);
				}
				return @object;
			}

			// Token: 0x060005FB RID: 1531 RVA: 0x00011BF4 File Offset: 0x0000FDF4
			public NotificationCompat.Builder SetContentInfo(string info)
			{
				Java.Lang.String @string = (info == null) ? null : new Java.Lang.String(info);
				NotificationCompat.Builder result = this.SetContentInfo(@string);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x060005FC RID: 1532 RVA: 0x00011C1E File Offset: 0x0000FE1E
			private static Delegate GetSetContentIntent_Landroid_app_PendingIntent_Handler()
			{
				if (NotificationCompat.Builder.cb_setContentIntent_Landroid_app_PendingIntent_ == null)
				{
					NotificationCompat.Builder.cb_setContentIntent_Landroid_app_PendingIntent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetContentIntent_Landroid_app_PendingIntent_));
				}
				return NotificationCompat.Builder.cb_setContentIntent_Landroid_app_PendingIntent_;
			}

			// Token: 0x060005FD RID: 1533 RVA: 0x00011C44 File Offset: 0x0000FE44
			private static IntPtr n_SetContentIntent_Landroid_app_PendingIntent_(IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				PendingIntent object2 = Java.Lang.Object.GetObject<PendingIntent>(native_intent, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetContentIntent(object2));
			}

			// Token: 0x060005FE RID: 1534 RVA: 0x00011C6C File Offset: 0x0000FE6C
			[Register("setContentIntent", "(Landroid/app/PendingIntent;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetContentIntent_Landroid_app_PendingIntent_Handler")]
			public unsafe virtual NotificationCompat.Builder SetContentIntent(PendingIntent intent)
			{
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setContentIntent.(Landroid/app/PendingIntent;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(intent);
				}
				return @object;
			}

			// Token: 0x060005FF RID: 1535 RVA: 0x00011CE0 File Offset: 0x0000FEE0
			private static Delegate GetSetContentText_Ljava_lang_CharSequence_Handler()
			{
				if (NotificationCompat.Builder.cb_setContentText_Ljava_lang_CharSequence_ == null)
				{
					NotificationCompat.Builder.cb_setContentText_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetContentText_Ljava_lang_CharSequence_));
				}
				return NotificationCompat.Builder.cb_setContentText_Ljava_lang_CharSequence_;
			}

			// Token: 0x06000600 RID: 1536 RVA: 0x00011D04 File Offset: 0x0000FF04
			private static IntPtr n_SetContentText_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_text)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_text, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetContentText(object2));
			}

			// Token: 0x06000601 RID: 1537 RVA: 0x00011D2C File Offset: 0x0000FF2C
			[Register("setContentText", "(Ljava/lang/CharSequence;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetContentText_Ljava_lang_CharSequence_Handler")]
			public unsafe virtual NotificationCompat.Builder SetContentText(ICharSequence text)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setContentText.(Ljava/lang/CharSequence;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(text);
				}
				return @object;
			}

			// Token: 0x06000602 RID: 1538 RVA: 0x00011DA0 File Offset: 0x0000FFA0
			public NotificationCompat.Builder SetContentText(string text)
			{
				Java.Lang.String @string = (text == null) ? null : new Java.Lang.String(text);
				NotificationCompat.Builder result = this.SetContentText(@string);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x06000603 RID: 1539 RVA: 0x00011DCA File Offset: 0x0000FFCA
			private static Delegate GetSetContentTitle_Ljava_lang_CharSequence_Handler()
			{
				if (NotificationCompat.Builder.cb_setContentTitle_Ljava_lang_CharSequence_ == null)
				{
					NotificationCompat.Builder.cb_setContentTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetContentTitle_Ljava_lang_CharSequence_));
				}
				return NotificationCompat.Builder.cb_setContentTitle_Ljava_lang_CharSequence_;
			}

			// Token: 0x06000604 RID: 1540 RVA: 0x00011DF0 File Offset: 0x0000FFF0
			private static IntPtr n_SetContentTitle_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_title)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetContentTitle(object2));
			}

			// Token: 0x06000605 RID: 1541 RVA: 0x00011E18 File Offset: 0x00010018
			[Register("setContentTitle", "(Ljava/lang/CharSequence;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetContentTitle_Ljava_lang_CharSequence_Handler")]
			public unsafe virtual NotificationCompat.Builder SetContentTitle(ICharSequence title)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setContentTitle.(Ljava/lang/CharSequence;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(title);
				}
				return @object;
			}

			// Token: 0x06000606 RID: 1542 RVA: 0x00011E8C File Offset: 0x0001008C
			public NotificationCompat.Builder SetContentTitle(string title)
			{
				Java.Lang.String @string = (title == null) ? null : new Java.Lang.String(title);
				NotificationCompat.Builder result = this.SetContentTitle(@string);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x06000607 RID: 1543 RVA: 0x00011EB6 File Offset: 0x000100B6
			private static Delegate GetSetCustomBigContentView_Landroid_widget_RemoteViews_Handler()
			{
				if (NotificationCompat.Builder.cb_setCustomBigContentView_Landroid_widget_RemoteViews_ == null)
				{
					NotificationCompat.Builder.cb_setCustomBigContentView_Landroid_widget_RemoteViews_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetCustomBigContentView_Landroid_widget_RemoteViews_));
				}
				return NotificationCompat.Builder.cb_setCustomBigContentView_Landroid_widget_RemoteViews_;
			}

			// Token: 0x06000608 RID: 1544 RVA: 0x00011EDC File Offset: 0x000100DC
			private static IntPtr n_SetCustomBigContentView_Landroid_widget_RemoteViews_(IntPtr jnienv, IntPtr native__this, IntPtr native_contentView)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RemoteViews object2 = Java.Lang.Object.GetObject<RemoteViews>(native_contentView, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetCustomBigContentView(object2));
			}

			// Token: 0x06000609 RID: 1545 RVA: 0x00011F04 File Offset: 0x00010104
			[Register("setCustomBigContentView", "(Landroid/widget/RemoteViews;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetCustomBigContentView_Landroid_widget_RemoteViews_Handler")]
			public unsafe virtual NotificationCompat.Builder SetCustomBigContentView(RemoteViews contentView)
			{
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((contentView == null) ? IntPtr.Zero : contentView.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setCustomBigContentView.(Landroid/widget/RemoteViews;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(contentView);
				}
				return @object;
			}

			// Token: 0x0600060A RID: 1546 RVA: 0x00011F78 File Offset: 0x00010178
			private static Delegate GetSetCustomContentView_Landroid_widget_RemoteViews_Handler()
			{
				if (NotificationCompat.Builder.cb_setCustomContentView_Landroid_widget_RemoteViews_ == null)
				{
					NotificationCompat.Builder.cb_setCustomContentView_Landroid_widget_RemoteViews_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetCustomContentView_Landroid_widget_RemoteViews_));
				}
				return NotificationCompat.Builder.cb_setCustomContentView_Landroid_widget_RemoteViews_;
			}

			// Token: 0x0600060B RID: 1547 RVA: 0x00011F9C File Offset: 0x0001019C
			private static IntPtr n_SetCustomContentView_Landroid_widget_RemoteViews_(IntPtr jnienv, IntPtr native__this, IntPtr native_contentView)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RemoteViews object2 = Java.Lang.Object.GetObject<RemoteViews>(native_contentView, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetCustomContentView(object2));
			}

			// Token: 0x0600060C RID: 1548 RVA: 0x00011FC4 File Offset: 0x000101C4
			[Register("setCustomContentView", "(Landroid/widget/RemoteViews;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetCustomContentView_Landroid_widget_RemoteViews_Handler")]
			public unsafe virtual NotificationCompat.Builder SetCustomContentView(RemoteViews contentView)
			{
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((contentView == null) ? IntPtr.Zero : contentView.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setCustomContentView.(Landroid/widget/RemoteViews;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(contentView);
				}
				return @object;
			}

			// Token: 0x0600060D RID: 1549 RVA: 0x00012038 File Offset: 0x00010238
			private static Delegate GetSetCustomHeadsUpContentView_Landroid_widget_RemoteViews_Handler()
			{
				if (NotificationCompat.Builder.cb_setCustomHeadsUpContentView_Landroid_widget_RemoteViews_ == null)
				{
					NotificationCompat.Builder.cb_setCustomHeadsUpContentView_Landroid_widget_RemoteViews_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetCustomHeadsUpContentView_Landroid_widget_RemoteViews_));
				}
				return NotificationCompat.Builder.cb_setCustomHeadsUpContentView_Landroid_widget_RemoteViews_;
			}

			// Token: 0x0600060E RID: 1550 RVA: 0x0001205C File Offset: 0x0001025C
			private static IntPtr n_SetCustomHeadsUpContentView_Landroid_widget_RemoteViews_(IntPtr jnienv, IntPtr native__this, IntPtr native_contentView)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RemoteViews object2 = Java.Lang.Object.GetObject<RemoteViews>(native_contentView, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetCustomHeadsUpContentView(object2));
			}

			// Token: 0x0600060F RID: 1551 RVA: 0x00012084 File Offset: 0x00010284
			[Register("setCustomHeadsUpContentView", "(Landroid/widget/RemoteViews;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetCustomHeadsUpContentView_Landroid_widget_RemoteViews_Handler")]
			public unsafe virtual NotificationCompat.Builder SetCustomHeadsUpContentView(RemoteViews contentView)
			{
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((contentView == null) ? IntPtr.Zero : contentView.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setCustomHeadsUpContentView.(Landroid/widget/RemoteViews;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(contentView);
				}
				return @object;
			}

			// Token: 0x06000610 RID: 1552 RVA: 0x000120F8 File Offset: 0x000102F8
			private static Delegate GetSetDefaults_IHandler()
			{
				if (NotificationCompat.Builder.cb_setDefaults_I == null)
				{
					NotificationCompat.Builder.cb_setDefaults_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(NotificationCompat.Builder.n_SetDefaults_I));
				}
				return NotificationCompat.Builder.cb_setDefaults_I;
			}

			// Token: 0x06000611 RID: 1553 RVA: 0x0001211C File Offset: 0x0001031C
			private static IntPtr n_SetDefaults_I(IntPtr jnienv, IntPtr native__this, int defaults)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetDefaults(defaults));
			}

			// Token: 0x06000612 RID: 1554 RVA: 0x00012134 File Offset: 0x00010334
			[Register("setDefaults", "(I)Landroidx/core/app/NotificationCompat$Builder;", "GetSetDefaults_IHandler")]
			public unsafe virtual NotificationCompat.Builder SetDefaults(int defaults)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(defaults);
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setDefaults.(I)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000613 RID: 1555 RVA: 0x0001217D File Offset: 0x0001037D
			private static Delegate GetSetDeleteIntent_Landroid_app_PendingIntent_Handler()
			{
				if (NotificationCompat.Builder.cb_setDeleteIntent_Landroid_app_PendingIntent_ == null)
				{
					NotificationCompat.Builder.cb_setDeleteIntent_Landroid_app_PendingIntent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetDeleteIntent_Landroid_app_PendingIntent_));
				}
				return NotificationCompat.Builder.cb_setDeleteIntent_Landroid_app_PendingIntent_;
			}

			// Token: 0x06000614 RID: 1556 RVA: 0x000121A4 File Offset: 0x000103A4
			private static IntPtr n_SetDeleteIntent_Landroid_app_PendingIntent_(IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				PendingIntent object2 = Java.Lang.Object.GetObject<PendingIntent>(native_intent, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetDeleteIntent(object2));
			}

			// Token: 0x06000615 RID: 1557 RVA: 0x000121CC File Offset: 0x000103CC
			[Register("setDeleteIntent", "(Landroid/app/PendingIntent;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetDeleteIntent_Landroid_app_PendingIntent_Handler")]
			public unsafe virtual NotificationCompat.Builder SetDeleteIntent(PendingIntent intent)
			{
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setDeleteIntent.(Landroid/app/PendingIntent;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(intent);
				}
				return @object;
			}

			// Token: 0x06000616 RID: 1558 RVA: 0x00012240 File Offset: 0x00010440
			private static Delegate GetSetExtras_Landroid_os_Bundle_Handler()
			{
				if (NotificationCompat.Builder.cb_setExtras_Landroid_os_Bundle_ == null)
				{
					NotificationCompat.Builder.cb_setExtras_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetExtras_Landroid_os_Bundle_));
				}
				return NotificationCompat.Builder.cb_setExtras_Landroid_os_Bundle_;
			}

			// Token: 0x06000617 RID: 1559 RVA: 0x00012264 File Offset: 0x00010464
			private static IntPtr n_SetExtras_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_extras)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_extras, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetExtras(object2));
			}

			// Token: 0x06000618 RID: 1560 RVA: 0x0001228C File Offset: 0x0001048C
			[Register("setExtras", "(Landroid/os/Bundle;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetExtras_Landroid_os_Bundle_Handler")]
			public unsafe virtual NotificationCompat.Builder SetExtras(Bundle extras)
			{
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((extras == null) ? IntPtr.Zero : extras.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setExtras.(Landroid/os/Bundle;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(extras);
				}
				return @object;
			}

			// Token: 0x06000619 RID: 1561 RVA: 0x00012300 File Offset: 0x00010500
			private static Delegate GetSetForegroundServiceBehavior_IHandler()
			{
				if (NotificationCompat.Builder.cb_setForegroundServiceBehavior_I == null)
				{
					NotificationCompat.Builder.cb_setForegroundServiceBehavior_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(NotificationCompat.Builder.n_SetForegroundServiceBehavior_I));
				}
				return NotificationCompat.Builder.cb_setForegroundServiceBehavior_I;
			}

			// Token: 0x0600061A RID: 1562 RVA: 0x00012324 File Offset: 0x00010524
			private static IntPtr n_SetForegroundServiceBehavior_I(IntPtr jnienv, IntPtr native__this, int behavior)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetForegroundServiceBehavior(behavior));
			}

			// Token: 0x0600061B RID: 1563 RVA: 0x0001233C File Offset: 0x0001053C
			[Register("setForegroundServiceBehavior", "(I)Landroidx/core/app/NotificationCompat$Builder;", "GetSetForegroundServiceBehavior_IHandler")]
			public unsafe virtual NotificationCompat.Builder SetForegroundServiceBehavior(int behavior)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(behavior);
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setForegroundServiceBehavior.(I)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600061C RID: 1564 RVA: 0x00012385 File Offset: 0x00010585
			private static Delegate GetSetFullScreenIntent_Landroid_app_PendingIntent_ZHandler()
			{
				if (NotificationCompat.Builder.cb_setFullScreenIntent_Landroid_app_PendingIntent_Z == null)
				{
					NotificationCompat.Builder.cb_setFullScreenIntent_Landroid_app_PendingIntent_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_L(NotificationCompat.Builder.n_SetFullScreenIntent_Landroid_app_PendingIntent_Z));
				}
				return NotificationCompat.Builder.cb_setFullScreenIntent_Landroid_app_PendingIntent_Z;
			}

			// Token: 0x0600061D RID: 1565 RVA: 0x000123AC File Offset: 0x000105AC
			private static IntPtr n_SetFullScreenIntent_Landroid_app_PendingIntent_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_intent, bool highPriority)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				PendingIntent object2 = Java.Lang.Object.GetObject<PendingIntent>(native_intent, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetFullScreenIntent(object2, highPriority));
			}

			// Token: 0x0600061E RID: 1566 RVA: 0x000123D8 File Offset: 0x000105D8
			[Register("setFullScreenIntent", "(Landroid/app/PendingIntent;Z)Landroidx/core/app/NotificationCompat$Builder;", "GetSetFullScreenIntent_Landroid_app_PendingIntent_ZHandler")]
			public unsafe virtual NotificationCompat.Builder SetFullScreenIntent(PendingIntent intent, bool highPriority)
			{
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
					ptr[1] = new JniArgumentValue(highPriority);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setFullScreenIntent.(Landroid/app/PendingIntent;Z)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(intent);
				}
				return @object;
			}

			// Token: 0x0600061F RID: 1567 RVA: 0x00012460 File Offset: 0x00010660
			private static Delegate GetSetGroup_Ljava_lang_String_Handler()
			{
				if (NotificationCompat.Builder.cb_setGroup_Ljava_lang_String_ == null)
				{
					NotificationCompat.Builder.cb_setGroup_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetGroup_Ljava_lang_String_));
				}
				return NotificationCompat.Builder.cb_setGroup_Ljava_lang_String_;
			}

			// Token: 0x06000620 RID: 1568 RVA: 0x00012484 File Offset: 0x00010684
			private static IntPtr n_SetGroup_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_groupKey)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_groupKey, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetGroup(@string));
			}

			// Token: 0x06000621 RID: 1569 RVA: 0x000124AC File Offset: 0x000106AC
			[Register("setGroup", "(Ljava/lang/String;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetGroup_Ljava_lang_String_Handler")]
			public unsafe virtual NotificationCompat.Builder SetGroup(string groupKey)
			{
				IntPtr intPtr = JNIEnv.NewString(groupKey);
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setGroup.(Ljava/lang/String;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06000622 RID: 1570 RVA: 0x00012518 File Offset: 0x00010718
			private static Delegate GetSetGroupAlertBehavior_IHandler()
			{
				if (NotificationCompat.Builder.cb_setGroupAlertBehavior_I == null)
				{
					NotificationCompat.Builder.cb_setGroupAlertBehavior_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(NotificationCompat.Builder.n_SetGroupAlertBehavior_I));
				}
				return NotificationCompat.Builder.cb_setGroupAlertBehavior_I;
			}

			// Token: 0x06000623 RID: 1571 RVA: 0x0001253C File Offset: 0x0001073C
			private static IntPtr n_SetGroupAlertBehavior_I(IntPtr jnienv, IntPtr native__this, int groupAlertBehavior)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetGroupAlertBehavior(groupAlertBehavior));
			}

			// Token: 0x06000624 RID: 1572 RVA: 0x00012554 File Offset: 0x00010754
			[Register("setGroupAlertBehavior", "(I)Landroidx/core/app/NotificationCompat$Builder;", "GetSetGroupAlertBehavior_IHandler")]
			public unsafe virtual NotificationCompat.Builder SetGroupAlertBehavior(int groupAlertBehavior)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(groupAlertBehavior);
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setGroupAlertBehavior.(I)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000625 RID: 1573 RVA: 0x0001259D File Offset: 0x0001079D
			private static Delegate GetSetGroupSummary_ZHandler()
			{
				if (NotificationCompat.Builder.cb_setGroupSummary_Z == null)
				{
					NotificationCompat.Builder.cb_setGroupSummary_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(NotificationCompat.Builder.n_SetGroupSummary_Z));
				}
				return NotificationCompat.Builder.cb_setGroupSummary_Z;
			}

			// Token: 0x06000626 RID: 1574 RVA: 0x000125C1 File Offset: 0x000107C1
			private static IntPtr n_SetGroupSummary_Z(IntPtr jnienv, IntPtr native__this, bool isGroupSummary)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetGroupSummary(isGroupSummary));
			}

			// Token: 0x06000627 RID: 1575 RVA: 0x000125D8 File Offset: 0x000107D8
			[Register("setGroupSummary", "(Z)Landroidx/core/app/NotificationCompat$Builder;", "GetSetGroupSummary_ZHandler")]
			public unsafe virtual NotificationCompat.Builder SetGroupSummary(bool isGroupSummary)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(isGroupSummary);
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setGroupSummary.(Z)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000628 RID: 1576 RVA: 0x00012621 File Offset: 0x00010821
			private static Delegate GetSetLargeIcon_Landroid_graphics_Bitmap_Handler()
			{
				if (NotificationCompat.Builder.cb_setLargeIcon_Landroid_graphics_Bitmap_ == null)
				{
					NotificationCompat.Builder.cb_setLargeIcon_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetLargeIcon_Landroid_graphics_Bitmap_));
				}
				return NotificationCompat.Builder.cb_setLargeIcon_Landroid_graphics_Bitmap_;
			}

			// Token: 0x06000629 RID: 1577 RVA: 0x00012648 File Offset: 0x00010848
			private static IntPtr n_SetLargeIcon_Landroid_graphics_Bitmap_(IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Bitmap object2 = Java.Lang.Object.GetObject<Bitmap>(native_icon, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetLargeIcon(object2));
			}

			// Token: 0x0600062A RID: 1578 RVA: 0x00012670 File Offset: 0x00010870
			[Register("setLargeIcon", "(Landroid/graphics/Bitmap;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetLargeIcon_Landroid_graphics_Bitmap_Handler")]
			public unsafe virtual NotificationCompat.Builder SetLargeIcon(Bitmap icon)
			{
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((icon == null) ? IntPtr.Zero : icon.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setLargeIcon.(Landroid/graphics/Bitmap;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(icon);
				}
				return @object;
			}

			// Token: 0x0600062B RID: 1579 RVA: 0x000126E4 File Offset: 0x000108E4
			private static Delegate GetSetLargeIcon_Landroid_graphics_drawable_Icon_Handler()
			{
				if (NotificationCompat.Builder.cb_setLargeIcon_Landroid_graphics_drawable_Icon_ == null)
				{
					NotificationCompat.Builder.cb_setLargeIcon_Landroid_graphics_drawable_Icon_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetLargeIcon_Landroid_graphics_drawable_Icon_));
				}
				return NotificationCompat.Builder.cb_setLargeIcon_Landroid_graphics_drawable_Icon_;
			}

			// Token: 0x0600062C RID: 1580 RVA: 0x00012708 File Offset: 0x00010908
			private static IntPtr n_SetLargeIcon_Landroid_graphics_drawable_Icon_(IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Icon object2 = Java.Lang.Object.GetObject<Icon>(native_icon, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetLargeIcon(object2));
			}

			// Token: 0x0600062D RID: 1581 RVA: 0x00012730 File Offset: 0x00010930
			[Register("setLargeIcon", "(Landroid/graphics/drawable/Icon;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetLargeIcon_Landroid_graphics_drawable_Icon_Handler")]
			public unsafe virtual NotificationCompat.Builder SetLargeIcon(Icon icon)
			{
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((icon == null) ? IntPtr.Zero : icon.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setLargeIcon.(Landroid/graphics/drawable/Icon;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(icon);
				}
				return @object;
			}

			// Token: 0x0600062E RID: 1582 RVA: 0x000127A4 File Offset: 0x000109A4
			private static Delegate GetSetLights_IIIHandler()
			{
				if (NotificationCompat.Builder.cb_setLights_III == null)
				{
					NotificationCompat.Builder.cb_setLights_III = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIII_L(NotificationCompat.Builder.n_SetLights_III));
				}
				return NotificationCompat.Builder.cb_setLights_III;
			}

			// Token: 0x0600062F RID: 1583 RVA: 0x000127C8 File Offset: 0x000109C8
			private static IntPtr n_SetLights_III(IntPtr jnienv, IntPtr native__this, int argb, int onMs, int offMs)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetLights(argb, onMs, offMs));
			}

			// Token: 0x06000630 RID: 1584 RVA: 0x000127E0 File Offset: 0x000109E0
			[Register("setLights", "(III)Landroidx/core/app/NotificationCompat$Builder;", "GetSetLights_IIIHandler")]
			public unsafe virtual NotificationCompat.Builder SetLights(int argb, int onMs, int offMs)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(argb);
				ptr[1] = new JniArgumentValue(onMs);
				ptr[2] = new JniArgumentValue(offMs);
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setLights.(III)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000631 RID: 1585 RVA: 0x00012852 File Offset: 0x00010A52
			private static Delegate GetSetLocalOnly_ZHandler()
			{
				if (NotificationCompat.Builder.cb_setLocalOnly_Z == null)
				{
					NotificationCompat.Builder.cb_setLocalOnly_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(NotificationCompat.Builder.n_SetLocalOnly_Z));
				}
				return NotificationCompat.Builder.cb_setLocalOnly_Z;
			}

			// Token: 0x06000632 RID: 1586 RVA: 0x00012876 File Offset: 0x00010A76
			private static IntPtr n_SetLocalOnly_Z(IntPtr jnienv, IntPtr native__this, bool b)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetLocalOnly(b));
			}

			// Token: 0x06000633 RID: 1587 RVA: 0x0001288C File Offset: 0x00010A8C
			[Register("setLocalOnly", "(Z)Landroidx/core/app/NotificationCompat$Builder;", "GetSetLocalOnly_ZHandler")]
			public unsafe virtual NotificationCompat.Builder SetLocalOnly(bool b)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(b);
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setLocalOnly.(Z)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000634 RID: 1588 RVA: 0x000128D5 File Offset: 0x00010AD5
			private static Delegate GetSetLocusId_Landroidx_core_content_LocusIdCompat_Handler()
			{
				if (NotificationCompat.Builder.cb_setLocusId_Landroidx_core_content_LocusIdCompat_ == null)
				{
					NotificationCompat.Builder.cb_setLocusId_Landroidx_core_content_LocusIdCompat_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetLocusId_Landroidx_core_content_LocusIdCompat_));
				}
				return NotificationCompat.Builder.cb_setLocusId_Landroidx_core_content_LocusIdCompat_;
			}

			// Token: 0x06000635 RID: 1589 RVA: 0x000128FC File Offset: 0x00010AFC
			private static IntPtr n_SetLocusId_Landroidx_core_content_LocusIdCompat_(IntPtr jnienv, IntPtr native__this, IntPtr native_locusId)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				LocusIdCompat object2 = Java.Lang.Object.GetObject<LocusIdCompat>(native_locusId, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetLocusId(object2));
			}

			// Token: 0x06000636 RID: 1590 RVA: 0x00012924 File Offset: 0x00010B24
			[Register("setLocusId", "(Landroidx/core/content/LocusIdCompat;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetLocusId_Landroidx_core_content_LocusIdCompat_Handler")]
			public unsafe virtual NotificationCompat.Builder SetLocusId(LocusIdCompat locusId)
			{
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((locusId == null) ? IntPtr.Zero : locusId.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setLocusId.(Landroidx/core/content/LocusIdCompat;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(locusId);
				}
				return @object;
			}

			// Token: 0x06000637 RID: 1591 RVA: 0x00012998 File Offset: 0x00010B98
			private static Delegate GetSetNotificationSilentHandler()
			{
				if (NotificationCompat.Builder.cb_setNotificationSilent == null)
				{
					NotificationCompat.Builder.cb_setNotificationSilent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationCompat.Builder.n_SetNotificationSilent));
				}
				return NotificationCompat.Builder.cb_setNotificationSilent;
			}

			// Token: 0x06000638 RID: 1592 RVA: 0x000129BC File Offset: 0x00010BBC
			private static IntPtr n_SetNotificationSilent(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetNotificationSilent());
			}

			// Token: 0x06000639 RID: 1593 RVA: 0x000129D0 File Offset: 0x00010BD0
			[Register("setNotificationSilent", "()Landroidx/core/app/NotificationCompat$Builder;", "GetSetNotificationSilentHandler")]
			public virtual NotificationCompat.Builder SetNotificationSilent()
			{
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setNotificationSilent.()Landroidx/core/app/NotificationCompat$Builder;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600063A RID: 1594 RVA: 0x00012A02 File Offset: 0x00010C02
			private static Delegate GetSetNumber_IHandler()
			{
				if (NotificationCompat.Builder.cb_setNumber_I == null)
				{
					NotificationCompat.Builder.cb_setNumber_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(NotificationCompat.Builder.n_SetNumber_I));
				}
				return NotificationCompat.Builder.cb_setNumber_I;
			}

			// Token: 0x0600063B RID: 1595 RVA: 0x00012A26 File Offset: 0x00010C26
			private static IntPtr n_SetNumber_I(IntPtr jnienv, IntPtr native__this, int number)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetNumber(number));
			}

			// Token: 0x0600063C RID: 1596 RVA: 0x00012A3C File Offset: 0x00010C3C
			[Register("setNumber", "(I)Landroidx/core/app/NotificationCompat$Builder;", "GetSetNumber_IHandler")]
			public unsafe virtual NotificationCompat.Builder SetNumber(int number)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(number);
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setNumber.(I)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600063D RID: 1597 RVA: 0x00012A85 File Offset: 0x00010C85
			private static Delegate GetSetOngoing_ZHandler()
			{
				if (NotificationCompat.Builder.cb_setOngoing_Z == null)
				{
					NotificationCompat.Builder.cb_setOngoing_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(NotificationCompat.Builder.n_SetOngoing_Z));
				}
				return NotificationCompat.Builder.cb_setOngoing_Z;
			}

			// Token: 0x0600063E RID: 1598 RVA: 0x00012AA9 File Offset: 0x00010CA9
			private static IntPtr n_SetOngoing_Z(IntPtr jnienv, IntPtr native__this, bool ongoing)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetOngoing(ongoing));
			}

			// Token: 0x0600063F RID: 1599 RVA: 0x00012AC0 File Offset: 0x00010CC0
			[Register("setOngoing", "(Z)Landroidx/core/app/NotificationCompat$Builder;", "GetSetOngoing_ZHandler")]
			public unsafe virtual NotificationCompat.Builder SetOngoing(bool ongoing)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(ongoing);
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setOngoing.(Z)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000640 RID: 1600 RVA: 0x00012B09 File Offset: 0x00010D09
			private static Delegate GetSetOnlyAlertOnce_ZHandler()
			{
				if (NotificationCompat.Builder.cb_setOnlyAlertOnce_Z == null)
				{
					NotificationCompat.Builder.cb_setOnlyAlertOnce_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(NotificationCompat.Builder.n_SetOnlyAlertOnce_Z));
				}
				return NotificationCompat.Builder.cb_setOnlyAlertOnce_Z;
			}

			// Token: 0x06000641 RID: 1601 RVA: 0x00012B2D File Offset: 0x00010D2D
			private static IntPtr n_SetOnlyAlertOnce_Z(IntPtr jnienv, IntPtr native__this, bool onlyAlertOnce)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetOnlyAlertOnce(onlyAlertOnce));
			}

			// Token: 0x06000642 RID: 1602 RVA: 0x00012B44 File Offset: 0x00010D44
			[Register("setOnlyAlertOnce", "(Z)Landroidx/core/app/NotificationCompat$Builder;", "GetSetOnlyAlertOnce_ZHandler")]
			public unsafe virtual NotificationCompat.Builder SetOnlyAlertOnce(bool onlyAlertOnce)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(onlyAlertOnce);
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setOnlyAlertOnce.(Z)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000643 RID: 1603 RVA: 0x00012B8D File Offset: 0x00010D8D
			private static Delegate GetSetPriority_IHandler()
			{
				if (NotificationCompat.Builder.cb_setPriority_I == null)
				{
					NotificationCompat.Builder.cb_setPriority_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(NotificationCompat.Builder.n_SetPriority_I));
				}
				return NotificationCompat.Builder.cb_setPriority_I;
			}

			// Token: 0x06000644 RID: 1604 RVA: 0x00012BB1 File Offset: 0x00010DB1
			private static IntPtr n_SetPriority_I(IntPtr jnienv, IntPtr native__this, int pri)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetPriority(pri));
			}

			// Token: 0x06000645 RID: 1605 RVA: 0x00012BC8 File Offset: 0x00010DC8
			[Register("setPriority", "(I)Landroidx/core/app/NotificationCompat$Builder;", "GetSetPriority_IHandler")]
			public unsafe virtual NotificationCompat.Builder SetPriority(int pri)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(pri);
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setPriority.(I)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000646 RID: 1606 RVA: 0x00012C11 File Offset: 0x00010E11
			private static Delegate GetSetProgress_IIZHandler()
			{
				if (NotificationCompat.Builder.cb_setProgress_IIZ == null)
				{
					NotificationCompat.Builder.cb_setProgress_IIZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIZ_L(NotificationCompat.Builder.n_SetProgress_IIZ));
				}
				return NotificationCompat.Builder.cb_setProgress_IIZ;
			}

			// Token: 0x06000647 RID: 1607 RVA: 0x00012C35 File Offset: 0x00010E35
			private static IntPtr n_SetProgress_IIZ(IntPtr jnienv, IntPtr native__this, int max, int progress, bool indeterminate)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetProgress(max, progress, indeterminate));
			}

			// Token: 0x06000648 RID: 1608 RVA: 0x00012C50 File Offset: 0x00010E50
			[Register("setProgress", "(IIZ)Landroidx/core/app/NotificationCompat$Builder;", "GetSetProgress_IIZHandler")]
			public unsafe virtual NotificationCompat.Builder SetProgress(int max, int progress, bool indeterminate)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(max);
				ptr[1] = new JniArgumentValue(progress);
				ptr[2] = new JniArgumentValue(indeterminate);
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setProgress.(IIZ)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000649 RID: 1609 RVA: 0x00012CC2 File Offset: 0x00010EC2
			private static Delegate GetSetPublicVersion_Landroid_app_Notification_Handler()
			{
				if (NotificationCompat.Builder.cb_setPublicVersion_Landroid_app_Notification_ == null)
				{
					NotificationCompat.Builder.cb_setPublicVersion_Landroid_app_Notification_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetPublicVersion_Landroid_app_Notification_));
				}
				return NotificationCompat.Builder.cb_setPublicVersion_Landroid_app_Notification_;
			}

			// Token: 0x0600064A RID: 1610 RVA: 0x00012CE8 File Offset: 0x00010EE8
			private static IntPtr n_SetPublicVersion_Landroid_app_Notification_(IntPtr jnienv, IntPtr native__this, IntPtr native_n)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Notification object2 = Java.Lang.Object.GetObject<Notification>(native_n, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetPublicVersion(object2));
			}

			// Token: 0x0600064B RID: 1611 RVA: 0x00012D10 File Offset: 0x00010F10
			[Register("setPublicVersion", "(Landroid/app/Notification;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetPublicVersion_Landroid_app_Notification_Handler")]
			public unsafe virtual NotificationCompat.Builder SetPublicVersion(Notification n)
			{
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((n == null) ? IntPtr.Zero : n.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setPublicVersion.(Landroid/app/Notification;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(n);
				}
				return @object;
			}

			// Token: 0x0600064C RID: 1612 RVA: 0x00012D84 File Offset: 0x00010F84
			private static Delegate GetSetRemoteInputHistory_arrayLjava_lang_CharSequence_Handler()
			{
				if (NotificationCompat.Builder.cb_setRemoteInputHistory_arrayLjava_lang_CharSequence_ == null)
				{
					NotificationCompat.Builder.cb_setRemoteInputHistory_arrayLjava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetRemoteInputHistory_arrayLjava_lang_CharSequence_));
				}
				return NotificationCompat.Builder.cb_setRemoteInputHistory_arrayLjava_lang_CharSequence_;
			}

			// Token: 0x0600064D RID: 1613 RVA: 0x00012DA8 File Offset: 0x00010FA8
			private static IntPtr n_SetRemoteInputHistory_arrayLjava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_text)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence[] array = (ICharSequence[])JNIEnv.GetArray(native_text, JniHandleOwnership.DoNotTransfer, typeof(ICharSequence));
				IntPtr result = JNIEnv.ToLocalJniHandle(@object.SetRemoteInputHistory(array));
				if (array != null)
				{
					JNIEnv.CopyArray<ICharSequence>(array, native_text);
				}
				return result;
			}

			// Token: 0x0600064E RID: 1614 RVA: 0x00012DEC File Offset: 0x00010FEC
			[Register("setRemoteInputHistory", "([Ljava/lang/CharSequence;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetRemoteInputHistory_arrayLjava_lang_CharSequence_Handler")]
			public unsafe virtual NotificationCompat.Builder SetRemoteInputHistory(ICharSequence[] text)
			{
				IntPtr intPtr = JNIEnv.NewArray<ICharSequence>(text);
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setRemoteInputHistory.([Ljava/lang/CharSequence;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					if (text != null)
					{
						JNIEnv.CopyArray<ICharSequence>(intPtr, text);
						JNIEnv.DeleteLocalRef(intPtr);
					}
					GC.KeepAlive(text);
				}
				return @object;
			}

			// Token: 0x0600064F RID: 1615 RVA: 0x00012E68 File Offset: 0x00011068
			public NotificationCompat.Builder SetRemoteInputHistory(string[] text)
			{
				ICharSequence[] array = CharSequence.ArrayFromStringArray(text);
				NotificationCompat.Builder result = this.SetRemoteInputHistory(array);
				if (array != null)
				{
					foreach (ICharSequence charSequence in array)
					{
						if (charSequence != null)
						{
							charSequence.Dispose();
						}
					}
				}
				return result;
			}

			// Token: 0x06000650 RID: 1616 RVA: 0x00012EA6 File Offset: 0x000110A6
			private static Delegate GetSetSettingsText_Ljava_lang_CharSequence_Handler()
			{
				if (NotificationCompat.Builder.cb_setSettingsText_Ljava_lang_CharSequence_ == null)
				{
					NotificationCompat.Builder.cb_setSettingsText_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetSettingsText_Ljava_lang_CharSequence_));
				}
				return NotificationCompat.Builder.cb_setSettingsText_Ljava_lang_CharSequence_;
			}

			// Token: 0x06000651 RID: 1617 RVA: 0x00012ECC File Offset: 0x000110CC
			private static IntPtr n_SetSettingsText_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_text)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_text, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetSettingsText(object2));
			}

			// Token: 0x06000652 RID: 1618 RVA: 0x00012EF4 File Offset: 0x000110F4
			[Register("setSettingsText", "(Ljava/lang/CharSequence;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetSettingsText_Ljava_lang_CharSequence_Handler")]
			public unsafe virtual NotificationCompat.Builder SetSettingsText(ICharSequence text)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setSettingsText.(Ljava/lang/CharSequence;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(text);
				}
				return @object;
			}

			// Token: 0x06000653 RID: 1619 RVA: 0x00012F68 File Offset: 0x00011168
			public NotificationCompat.Builder SetSettingsText(string text)
			{
				Java.Lang.String @string = (text == null) ? null : new Java.Lang.String(text);
				NotificationCompat.Builder result = this.SetSettingsText(@string);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x06000654 RID: 1620 RVA: 0x00012F92 File Offset: 0x00011192
			private static Delegate GetSetShortcutId_Ljava_lang_String_Handler()
			{
				if (NotificationCompat.Builder.cb_setShortcutId_Ljava_lang_String_ == null)
				{
					NotificationCompat.Builder.cb_setShortcutId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetShortcutId_Ljava_lang_String_));
				}
				return NotificationCompat.Builder.cb_setShortcutId_Ljava_lang_String_;
			}

			// Token: 0x06000655 RID: 1621 RVA: 0x00012FB8 File Offset: 0x000111B8
			private static IntPtr n_SetShortcutId_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_shortcutId)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_shortcutId, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetShortcutId(@string));
			}

			// Token: 0x06000656 RID: 1622 RVA: 0x00012FE0 File Offset: 0x000111E0
			[Register("setShortcutId", "(Ljava/lang/String;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetShortcutId_Ljava_lang_String_Handler")]
			public unsafe virtual NotificationCompat.Builder SetShortcutId(string shortcutId)
			{
				IntPtr intPtr = JNIEnv.NewString(shortcutId);
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setShortcutId.(Ljava/lang/String;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06000657 RID: 1623 RVA: 0x0001304C File Offset: 0x0001124C
			private static Delegate GetSetShortcutInfo_Landroidx_core_content_pm_ShortcutInfoCompat_Handler()
			{
				if (NotificationCompat.Builder.cb_setShortcutInfo_Landroidx_core_content_pm_ShortcutInfoCompat_ == null)
				{
					NotificationCompat.Builder.cb_setShortcutInfo_Landroidx_core_content_pm_ShortcutInfoCompat_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetShortcutInfo_Landroidx_core_content_pm_ShortcutInfoCompat_));
				}
				return NotificationCompat.Builder.cb_setShortcutInfo_Landroidx_core_content_pm_ShortcutInfoCompat_;
			}

			// Token: 0x06000658 RID: 1624 RVA: 0x00013070 File Offset: 0x00011270
			private static IntPtr n_SetShortcutInfo_Landroidx_core_content_pm_ShortcutInfoCompat_(IntPtr jnienv, IntPtr native__this, IntPtr native_shortcutInfo)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ShortcutInfoCompat object2 = Java.Lang.Object.GetObject<ShortcutInfoCompat>(native_shortcutInfo, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetShortcutInfo(object2));
			}

			// Token: 0x06000659 RID: 1625 RVA: 0x00013098 File Offset: 0x00011298
			[Register("setShortcutInfo", "(Landroidx/core/content/pm/ShortcutInfoCompat;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetShortcutInfo_Landroidx_core_content_pm_ShortcutInfoCompat_Handler")]
			public unsafe virtual NotificationCompat.Builder SetShortcutInfo(ShortcutInfoCompat shortcutInfo)
			{
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((shortcutInfo == null) ? IntPtr.Zero : shortcutInfo.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setShortcutInfo.(Landroidx/core/content/pm/ShortcutInfoCompat;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(shortcutInfo);
				}
				return @object;
			}

			// Token: 0x0600065A RID: 1626 RVA: 0x0001310C File Offset: 0x0001130C
			private static Delegate GetSetShowWhen_ZHandler()
			{
				if (NotificationCompat.Builder.cb_setShowWhen_Z == null)
				{
					NotificationCompat.Builder.cb_setShowWhen_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(NotificationCompat.Builder.n_SetShowWhen_Z));
				}
				return NotificationCompat.Builder.cb_setShowWhen_Z;
			}

			// Token: 0x0600065B RID: 1627 RVA: 0x00013130 File Offset: 0x00011330
			private static IntPtr n_SetShowWhen_Z(IntPtr jnienv, IntPtr native__this, bool show)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetShowWhen(show));
			}

			// Token: 0x0600065C RID: 1628 RVA: 0x00013148 File Offset: 0x00011348
			[Register("setShowWhen", "(Z)Landroidx/core/app/NotificationCompat$Builder;", "GetSetShowWhen_ZHandler")]
			public unsafe virtual NotificationCompat.Builder SetShowWhen(bool show)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(show);
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setShowWhen.(Z)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600065D RID: 1629 RVA: 0x00013191 File Offset: 0x00011391
			private static Delegate GetSetSilent_ZHandler()
			{
				if (NotificationCompat.Builder.cb_setSilent_Z == null)
				{
					NotificationCompat.Builder.cb_setSilent_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(NotificationCompat.Builder.n_SetSilent_Z));
				}
				return NotificationCompat.Builder.cb_setSilent_Z;
			}

			// Token: 0x0600065E RID: 1630 RVA: 0x000131B5 File Offset: 0x000113B5
			private static IntPtr n_SetSilent_Z(IntPtr jnienv, IntPtr native__this, bool silent)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSilent(silent));
			}

			// Token: 0x0600065F RID: 1631 RVA: 0x000131CC File Offset: 0x000113CC
			[Register("setSilent", "(Z)Landroidx/core/app/NotificationCompat$Builder;", "GetSetSilent_ZHandler")]
			public unsafe virtual NotificationCompat.Builder SetSilent(bool silent)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(silent);
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setSilent.(Z)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000660 RID: 1632 RVA: 0x00013215 File Offset: 0x00011415
			private static Delegate GetSetSmallIcon_Landroidx_core_graphics_drawable_IconCompat_Handler()
			{
				if (NotificationCompat.Builder.cb_setSmallIcon_Landroidx_core_graphics_drawable_IconCompat_ == null)
				{
					NotificationCompat.Builder.cb_setSmallIcon_Landroidx_core_graphics_drawable_IconCompat_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetSmallIcon_Landroidx_core_graphics_drawable_IconCompat_));
				}
				return NotificationCompat.Builder.cb_setSmallIcon_Landroidx_core_graphics_drawable_IconCompat_;
			}

			// Token: 0x06000661 RID: 1633 RVA: 0x0001323C File Offset: 0x0001143C
			private static IntPtr n_SetSmallIcon_Landroidx_core_graphics_drawable_IconCompat_(IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IconCompat object2 = Java.Lang.Object.GetObject<IconCompat>(native_icon, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetSmallIcon(object2));
			}

			// Token: 0x06000662 RID: 1634 RVA: 0x00013264 File Offset: 0x00011464
			[Register("setSmallIcon", "(Landroidx/core/graphics/drawable/IconCompat;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetSmallIcon_Landroidx_core_graphics_drawable_IconCompat_Handler")]
			public unsafe virtual NotificationCompat.Builder SetSmallIcon(IconCompat icon)
			{
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((icon == null) ? IntPtr.Zero : icon.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setSmallIcon.(Landroidx/core/graphics/drawable/IconCompat;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(icon);
				}
				return @object;
			}

			// Token: 0x06000663 RID: 1635 RVA: 0x000132D8 File Offset: 0x000114D8
			private static Delegate GetSetSmallIcon_IHandler()
			{
				if (NotificationCompat.Builder.cb_setSmallIcon_I == null)
				{
					NotificationCompat.Builder.cb_setSmallIcon_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(NotificationCompat.Builder.n_SetSmallIcon_I));
				}
				return NotificationCompat.Builder.cb_setSmallIcon_I;
			}

			// Token: 0x06000664 RID: 1636 RVA: 0x000132FC File Offset: 0x000114FC
			private static IntPtr n_SetSmallIcon_I(IntPtr jnienv, IntPtr native__this, int icon)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSmallIcon(icon));
			}

			// Token: 0x06000665 RID: 1637 RVA: 0x00013314 File Offset: 0x00011514
			[Register("setSmallIcon", "(I)Landroidx/core/app/NotificationCompat$Builder;", "GetSetSmallIcon_IHandler")]
			public unsafe virtual NotificationCompat.Builder SetSmallIcon(int icon)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(icon);
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setSmallIcon.(I)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000666 RID: 1638 RVA: 0x0001335D File Offset: 0x0001155D
			private static Delegate GetSetSmallIcon_IIHandler()
			{
				if (NotificationCompat.Builder.cb_setSmallIcon_II == null)
				{
					NotificationCompat.Builder.cb_setSmallIcon_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_L(NotificationCompat.Builder.n_SetSmallIcon_II));
				}
				return NotificationCompat.Builder.cb_setSmallIcon_II;
			}

			// Token: 0x06000667 RID: 1639 RVA: 0x00013381 File Offset: 0x00011581
			private static IntPtr n_SetSmallIcon_II(IntPtr jnienv, IntPtr native__this, int icon, int level)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSmallIcon(icon, level));
			}

			// Token: 0x06000668 RID: 1640 RVA: 0x00013398 File Offset: 0x00011598
			[Register("setSmallIcon", "(II)Landroidx/core/app/NotificationCompat$Builder;", "GetSetSmallIcon_IIHandler")]
			public unsafe virtual NotificationCompat.Builder SetSmallIcon(int icon, int level)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(icon);
				ptr[1] = new JniArgumentValue(level);
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setSmallIcon.(II)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000669 RID: 1641 RVA: 0x000133F4 File Offset: 0x000115F4
			private static Delegate GetSetSortKey_Ljava_lang_String_Handler()
			{
				if (NotificationCompat.Builder.cb_setSortKey_Ljava_lang_String_ == null)
				{
					NotificationCompat.Builder.cb_setSortKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetSortKey_Ljava_lang_String_));
				}
				return NotificationCompat.Builder.cb_setSortKey_Ljava_lang_String_;
			}

			// Token: 0x0600066A RID: 1642 RVA: 0x00013418 File Offset: 0x00011618
			private static IntPtr n_SetSortKey_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_sortKey)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_sortKey, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetSortKey(@string));
			}

			// Token: 0x0600066B RID: 1643 RVA: 0x00013440 File Offset: 0x00011640
			[Register("setSortKey", "(Ljava/lang/String;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetSortKey_Ljava_lang_String_Handler")]
			public unsafe virtual NotificationCompat.Builder SetSortKey(string sortKey)
			{
				IntPtr intPtr = JNIEnv.NewString(sortKey);
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setSortKey.(Ljava/lang/String;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x0600066C RID: 1644 RVA: 0x000134AC File Offset: 0x000116AC
			private static Delegate GetSetSound_Landroid_net_Uri_Handler()
			{
				if (NotificationCompat.Builder.cb_setSound_Landroid_net_Uri_ == null)
				{
					NotificationCompat.Builder.cb_setSound_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetSound_Landroid_net_Uri_));
				}
				return NotificationCompat.Builder.cb_setSound_Landroid_net_Uri_;
			}

			// Token: 0x0600066D RID: 1645 RVA: 0x000134D0 File Offset: 0x000116D0
			private static IntPtr n_SetSound_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_sound)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_sound, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetSound(object2));
			}

			// Token: 0x0600066E RID: 1646 RVA: 0x000134F8 File Offset: 0x000116F8
			[Register("setSound", "(Landroid/net/Uri;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetSound_Landroid_net_Uri_Handler")]
			public unsafe virtual NotificationCompat.Builder SetSound(Android.Net.Uri sound)
			{
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((sound == null) ? IntPtr.Zero : sound.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setSound.(Landroid/net/Uri;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(sound);
				}
				return @object;
			}

			// Token: 0x0600066F RID: 1647 RVA: 0x0001356C File Offset: 0x0001176C
			private static Delegate GetSetSound_Landroid_net_Uri_IHandler()
			{
				if (NotificationCompat.Builder.cb_setSound_Landroid_net_Uri_I == null)
				{
					NotificationCompat.Builder.cb_setSound_Landroid_net_Uri_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_L(NotificationCompat.Builder.n_SetSound_Landroid_net_Uri_I));
				}
				return NotificationCompat.Builder.cb_setSound_Landroid_net_Uri_I;
			}

			// Token: 0x06000670 RID: 1648 RVA: 0x00013590 File Offset: 0x00011790
			private static IntPtr n_SetSound_Landroid_net_Uri_I(IntPtr jnienv, IntPtr native__this, IntPtr native_sound, int streamType)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_sound, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetSound(object2, streamType));
			}

			// Token: 0x06000671 RID: 1649 RVA: 0x000135BC File Offset: 0x000117BC
			[Register("setSound", "(Landroid/net/Uri;I)Landroidx/core/app/NotificationCompat$Builder;", "GetSetSound_Landroid_net_Uri_IHandler")]
			public unsafe virtual NotificationCompat.Builder SetSound(Android.Net.Uri sound, int streamType)
			{
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((sound == null) ? IntPtr.Zero : sound.Handle);
					ptr[1] = new JniArgumentValue(streamType);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setSound.(Landroid/net/Uri;I)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(sound);
				}
				return @object;
			}

			// Token: 0x06000672 RID: 1650 RVA: 0x00013644 File Offset: 0x00011844
			private static Delegate GetSetStyle_Landroidx_core_app_NotificationCompat_Style_Handler()
			{
				if (NotificationCompat.Builder.cb_setStyle_Landroidx_core_app_NotificationCompat_Style_ == null)
				{
					NotificationCompat.Builder.cb_setStyle_Landroidx_core_app_NotificationCompat_Style_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetStyle_Landroidx_core_app_NotificationCompat_Style_));
				}
				return NotificationCompat.Builder.cb_setStyle_Landroidx_core_app_NotificationCompat_Style_;
			}

			// Token: 0x06000673 RID: 1651 RVA: 0x00013668 File Offset: 0x00011868
			private static IntPtr n_SetStyle_Landroidx_core_app_NotificationCompat_Style_(IntPtr jnienv, IntPtr native__this, IntPtr native_style)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				NotificationCompat.Style object2 = Java.Lang.Object.GetObject<NotificationCompat.Style>(native_style, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetStyle(object2));
			}

			// Token: 0x06000674 RID: 1652 RVA: 0x00013690 File Offset: 0x00011890
			[Register("setStyle", "(Landroidx/core/app/NotificationCompat$Style;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetStyle_Landroidx_core_app_NotificationCompat_Style_Handler")]
			public unsafe virtual NotificationCompat.Builder SetStyle(NotificationCompat.Style style)
			{
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((style == null) ? IntPtr.Zero : style.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setStyle.(Landroidx/core/app/NotificationCompat$Style;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(style);
				}
				return @object;
			}

			// Token: 0x06000675 RID: 1653 RVA: 0x00013704 File Offset: 0x00011904
			private static Delegate GetSetSubText_Ljava_lang_CharSequence_Handler()
			{
				if (NotificationCompat.Builder.cb_setSubText_Ljava_lang_CharSequence_ == null)
				{
					NotificationCompat.Builder.cb_setSubText_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetSubText_Ljava_lang_CharSequence_));
				}
				return NotificationCompat.Builder.cb_setSubText_Ljava_lang_CharSequence_;
			}

			// Token: 0x06000676 RID: 1654 RVA: 0x00013728 File Offset: 0x00011928
			private static IntPtr n_SetSubText_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_text)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_text, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetSubText(object2));
			}

			// Token: 0x06000677 RID: 1655 RVA: 0x00013750 File Offset: 0x00011950
			[Register("setSubText", "(Ljava/lang/CharSequence;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetSubText_Ljava_lang_CharSequence_Handler")]
			public unsafe virtual NotificationCompat.Builder SetSubText(ICharSequence text)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setSubText.(Ljava/lang/CharSequence;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(text);
				}
				return @object;
			}

			// Token: 0x06000678 RID: 1656 RVA: 0x000137C4 File Offset: 0x000119C4
			public NotificationCompat.Builder SetSubText(string text)
			{
				Java.Lang.String @string = (text == null) ? null : new Java.Lang.String(text);
				NotificationCompat.Builder result = this.SetSubText(@string);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x06000679 RID: 1657 RVA: 0x000137EE File Offset: 0x000119EE
			private static Delegate GetSetTicker_Ljava_lang_CharSequence_Handler()
			{
				if (NotificationCompat.Builder.cb_setTicker_Ljava_lang_CharSequence_ == null)
				{
					NotificationCompat.Builder.cb_setTicker_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetTicker_Ljava_lang_CharSequence_));
				}
				return NotificationCompat.Builder.cb_setTicker_Ljava_lang_CharSequence_;
			}

			// Token: 0x0600067A RID: 1658 RVA: 0x00013814 File Offset: 0x00011A14
			private static IntPtr n_SetTicker_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_tickerText)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_tickerText, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetTicker(object2));
			}

			// Token: 0x0600067B RID: 1659 RVA: 0x0001383C File Offset: 0x00011A3C
			[Register("setTicker", "(Ljava/lang/CharSequence;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetTicker_Ljava_lang_CharSequence_Handler")]
			public unsafe virtual NotificationCompat.Builder SetTicker(ICharSequence tickerText)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(tickerText);
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setTicker.(Ljava/lang/CharSequence;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(tickerText);
				}
				return @object;
			}

			// Token: 0x0600067C RID: 1660 RVA: 0x000138B0 File Offset: 0x00011AB0
			public NotificationCompat.Builder SetTicker(string tickerText)
			{
				Java.Lang.String @string = (tickerText == null) ? null : new Java.Lang.String(tickerText);
				NotificationCompat.Builder result = this.SetTicker(@string);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x0600067D RID: 1661 RVA: 0x000138DA File Offset: 0x00011ADA
			private static Delegate GetSetTicker_Ljava_lang_CharSequence_Landroid_widget_RemoteViews_Handler()
			{
				if (NotificationCompat.Builder.cb_setTicker_Ljava_lang_CharSequence_Landroid_widget_RemoteViews_ == null)
				{
					NotificationCompat.Builder.cb_setTicker_Ljava_lang_CharSequence_Landroid_widget_RemoteViews_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(NotificationCompat.Builder.n_SetTicker_Ljava_lang_CharSequence_Landroid_widget_RemoteViews_));
				}
				return NotificationCompat.Builder.cb_setTicker_Ljava_lang_CharSequence_Landroid_widget_RemoteViews_;
			}

			// Token: 0x0600067E RID: 1662 RVA: 0x00013900 File Offset: 0x00011B00
			private static IntPtr n_SetTicker_Ljava_lang_CharSequence_Landroid_widget_RemoteViews_(IntPtr jnienv, IntPtr native__this, IntPtr native_tickerText, IntPtr native_views)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_tickerText, JniHandleOwnership.DoNotTransfer);
				RemoteViews object3 = Java.Lang.Object.GetObject<RemoteViews>(native_views, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetTicker(object2, object3));
			}

			// Token: 0x0600067F RID: 1663 RVA: 0x00013934 File Offset: 0x00011B34
			[Register("setTicker", "(Ljava/lang/CharSequence;Landroid/widget/RemoteViews;)Landroidx/core/app/NotificationCompat$Builder;", "GetSetTicker_Ljava_lang_CharSequence_Landroid_widget_RemoteViews_Handler")]
			public unsafe virtual NotificationCompat.Builder SetTicker(ICharSequence tickerText, RemoteViews views)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(tickerText);
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ptr[1] = new JniArgumentValue((views == null) ? IntPtr.Zero : views.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setTicker.(Ljava/lang/CharSequence;Landroid/widget/RemoteViews;)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(tickerText);
					GC.KeepAlive(views);
				}
				return @object;
			}

			// Token: 0x06000680 RID: 1664 RVA: 0x000139D0 File Offset: 0x00011BD0
			public NotificationCompat.Builder SetTicker(string tickerText, RemoteViews views)
			{
				Java.Lang.String @string = (tickerText == null) ? null : new Java.Lang.String(tickerText);
				NotificationCompat.Builder result = this.SetTicker(@string, views);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x06000681 RID: 1665 RVA: 0x000139FB File Offset: 0x00011BFB
			private static Delegate GetSetTimeoutAfter_JHandler()
			{
				if (NotificationCompat.Builder.cb_setTimeoutAfter_J == null)
				{
					NotificationCompat.Builder.cb_setTimeoutAfter_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_L(NotificationCompat.Builder.n_SetTimeoutAfter_J));
				}
				return NotificationCompat.Builder.cb_setTimeoutAfter_J;
			}

			// Token: 0x06000682 RID: 1666 RVA: 0x00013A1F File Offset: 0x00011C1F
			private static IntPtr n_SetTimeoutAfter_J(IntPtr jnienv, IntPtr native__this, long durationMs)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTimeoutAfter(durationMs));
			}

			// Token: 0x06000683 RID: 1667 RVA: 0x00013A34 File Offset: 0x00011C34
			[Register("setTimeoutAfter", "(J)Landroidx/core/app/NotificationCompat$Builder;", "GetSetTimeoutAfter_JHandler")]
			public unsafe virtual NotificationCompat.Builder SetTimeoutAfter(long durationMs)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(durationMs);
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setTimeoutAfter.(J)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000684 RID: 1668 RVA: 0x00013A7D File Offset: 0x00011C7D
			private static Delegate GetSetUsesChronometer_ZHandler()
			{
				if (NotificationCompat.Builder.cb_setUsesChronometer_Z == null)
				{
					NotificationCompat.Builder.cb_setUsesChronometer_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(NotificationCompat.Builder.n_SetUsesChronometer_Z));
				}
				return NotificationCompat.Builder.cb_setUsesChronometer_Z;
			}

			// Token: 0x06000685 RID: 1669 RVA: 0x00013AA1 File Offset: 0x00011CA1
			private static IntPtr n_SetUsesChronometer_Z(IntPtr jnienv, IntPtr native__this, bool b)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetUsesChronometer(b));
			}

			// Token: 0x06000686 RID: 1670 RVA: 0x00013AB8 File Offset: 0x00011CB8
			[Register("setUsesChronometer", "(Z)Landroidx/core/app/NotificationCompat$Builder;", "GetSetUsesChronometer_ZHandler")]
			public unsafe virtual NotificationCompat.Builder SetUsesChronometer(bool b)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(b);
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setUsesChronometer.(Z)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000687 RID: 1671 RVA: 0x00013B01 File Offset: 0x00011D01
			private static Delegate GetSetVibrate_arrayJHandler()
			{
				if (NotificationCompat.Builder.cb_setVibrate_arrayJ == null)
				{
					NotificationCompat.Builder.cb_setVibrate_arrayJ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Builder.n_SetVibrate_arrayJ));
				}
				return NotificationCompat.Builder.cb_setVibrate_arrayJ;
			}

			// Token: 0x06000688 RID: 1672 RVA: 0x00013B28 File Offset: 0x00011D28
			private static IntPtr n_SetVibrate_arrayJ(IntPtr jnienv, IntPtr native__this, IntPtr native_pattern)
			{
				NotificationCompat.Builder @object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				long[] array = (long[])JNIEnv.GetArray(native_pattern, JniHandleOwnership.DoNotTransfer, typeof(long));
				IntPtr result = JNIEnv.ToLocalJniHandle(@object.SetVibrate(array));
				if (array != null)
				{
					JNIEnv.CopyArray(array, native_pattern);
				}
				return result;
			}

			// Token: 0x06000689 RID: 1673 RVA: 0x00013B6C File Offset: 0x00011D6C
			[Register("setVibrate", "([J)Landroidx/core/app/NotificationCompat$Builder;", "GetSetVibrate_arrayJHandler")]
			public unsafe virtual NotificationCompat.Builder SetVibrate(long[] pattern)
			{
				IntPtr intPtr = JNIEnv.NewArray(pattern);
				NotificationCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setVibrate.([J)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					if (pattern != null)
					{
						JNIEnv.CopyArray(intPtr, pattern);
						JNIEnv.DeleteLocalRef(intPtr);
					}
					GC.KeepAlive(pattern);
				}
				return @object;
			}

			// Token: 0x0600068A RID: 1674 RVA: 0x00013BE8 File Offset: 0x00011DE8
			private static Delegate GetSetVisibility_IHandler()
			{
				if (NotificationCompat.Builder.cb_setVisibility_I == null)
				{
					NotificationCompat.Builder.cb_setVisibility_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(NotificationCompat.Builder.n_SetVisibility_I));
				}
				return NotificationCompat.Builder.cb_setVisibility_I;
			}

			// Token: 0x0600068B RID: 1675 RVA: 0x00013C0C File Offset: 0x00011E0C
			private static IntPtr n_SetVisibility_I(IntPtr jnienv, IntPtr native__this, int visibility)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetVisibility(visibility));
			}

			// Token: 0x0600068C RID: 1676 RVA: 0x00013C24 File Offset: 0x00011E24
			[Register("setVisibility", "(I)Landroidx/core/app/NotificationCompat$Builder;", "GetSetVisibility_IHandler")]
			public unsafe virtual NotificationCompat.Builder SetVisibility(int visibility)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(visibility);
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setVisibility.(I)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600068D RID: 1677 RVA: 0x00013C6D File Offset: 0x00011E6D
			private static Delegate GetSetWhen_JHandler()
			{
				if (NotificationCompat.Builder.cb_setWhen_J == null)
				{
					NotificationCompat.Builder.cb_setWhen_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_L(NotificationCompat.Builder.n_SetWhen_J));
				}
				return NotificationCompat.Builder.cb_setWhen_J;
			}

			// Token: 0x0600068E RID: 1678 RVA: 0x00013C91 File Offset: 0x00011E91
			private static IntPtr n_SetWhen_J(IntPtr jnienv, IntPtr native__this, long when)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetWhen(when));
			}

			// Token: 0x0600068F RID: 1679 RVA: 0x00013CA8 File Offset: 0x00011EA8
			[Register("setWhen", "(J)Landroidx/core/app/NotificationCompat$Builder;", "GetSetWhen_JHandler")]
			public unsafe virtual NotificationCompat.Builder SetWhen(long when)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(when);
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setWhen.(J)Landroidx/core/app/NotificationCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0400016A RID: 362
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/NotificationCompat$Builder", typeof(NotificationCompat.Builder));

			// Token: 0x0400016B RID: 363
			private static Delegate cb_getBigContentView;

			// Token: 0x0400016C RID: 364
			private static Delegate cb_getBubbleMetadata;

			// Token: 0x0400016D RID: 365
			private static Delegate cb_getColor;

			// Token: 0x0400016E RID: 366
			private static Delegate cb_getContentView;

			// Token: 0x0400016F RID: 367
			private static Delegate cb_getExtras;

			// Token: 0x04000170 RID: 368
			private static Delegate cb_getForegroundServiceBehavior;

			// Token: 0x04000171 RID: 369
			private static Delegate cb_getHeadsUpContentView;

			// Token: 0x04000172 RID: 370
			private static Delegate cb_getNotification;

			// Token: 0x04000173 RID: 371
			private static Delegate cb_getPriority;

			// Token: 0x04000174 RID: 372
			private static Delegate cb_getWhenIfShowing;

			// Token: 0x04000175 RID: 373
			private static Delegate cb_addAction_Landroidx_core_app_NotificationCompat_Action_;

			// Token: 0x04000176 RID: 374
			private static Delegate cb_addAction_ILjava_lang_CharSequence_Landroid_app_PendingIntent_;

			// Token: 0x04000177 RID: 375
			private static Delegate cb_addExtras_Landroid_os_Bundle_;

			// Token: 0x04000178 RID: 376
			private static Delegate cb_addInvisibleAction_Landroidx_core_app_NotificationCompat_Action_;

			// Token: 0x04000179 RID: 377
			private static Delegate cb_addInvisibleAction_ILjava_lang_CharSequence_Landroid_app_PendingIntent_;

			// Token: 0x0400017A RID: 378
			private static Delegate cb_addPerson_Landroidx_core_app_Person_;

			// Token: 0x0400017B RID: 379
			private static Delegate cb_addPerson_Ljava_lang_String_;

			// Token: 0x0400017C RID: 380
			private static Delegate cb_build;

			// Token: 0x0400017D RID: 381
			private static Delegate cb_clearActions;

			// Token: 0x0400017E RID: 382
			private static Delegate cb_clearInvisibleActions;

			// Token: 0x0400017F RID: 383
			private static Delegate cb_clearPeople;

			// Token: 0x04000180 RID: 384
			private static Delegate cb_createBigContentView;

			// Token: 0x04000181 RID: 385
			private static Delegate cb_createContentView;

			// Token: 0x04000182 RID: 386
			private static Delegate cb_createHeadsUpContentView;

			// Token: 0x04000183 RID: 387
			private static Delegate cb_extend_Landroidx_core_app_NotificationCompat_Extender_;

			// Token: 0x04000184 RID: 388
			private static Delegate cb_setAllowSystemGeneratedContextualActions_Z;

			// Token: 0x04000185 RID: 389
			private static Delegate cb_setAutoCancel_Z;

			// Token: 0x04000186 RID: 390
			private static Delegate cb_setBadgeIconType_I;

			// Token: 0x04000187 RID: 391
			private static Delegate cb_setBubbleMetadata_Landroidx_core_app_NotificationCompat_BubbleMetadata_;

			// Token: 0x04000188 RID: 392
			private static Delegate cb_setCategory_Ljava_lang_String_;

			// Token: 0x04000189 RID: 393
			private static Delegate cb_setChannelId_Ljava_lang_String_;

			// Token: 0x0400018A RID: 394
			private static Delegate cb_setChronometerCountDown_Z;

			// Token: 0x0400018B RID: 395
			private static Delegate cb_setColor_I;

			// Token: 0x0400018C RID: 396
			private static Delegate cb_setColorized_Z;

			// Token: 0x0400018D RID: 397
			private static Delegate cb_setContent_Landroid_widget_RemoteViews_;

			// Token: 0x0400018E RID: 398
			private static Delegate cb_setContentInfo_Ljava_lang_CharSequence_;

			// Token: 0x0400018F RID: 399
			private static Delegate cb_setContentIntent_Landroid_app_PendingIntent_;

			// Token: 0x04000190 RID: 400
			private static Delegate cb_setContentText_Ljava_lang_CharSequence_;

			// Token: 0x04000191 RID: 401
			private static Delegate cb_setContentTitle_Ljava_lang_CharSequence_;

			// Token: 0x04000192 RID: 402
			private static Delegate cb_setCustomBigContentView_Landroid_widget_RemoteViews_;

			// Token: 0x04000193 RID: 403
			private static Delegate cb_setCustomContentView_Landroid_widget_RemoteViews_;

			// Token: 0x04000194 RID: 404
			private static Delegate cb_setCustomHeadsUpContentView_Landroid_widget_RemoteViews_;

			// Token: 0x04000195 RID: 405
			private static Delegate cb_setDefaults_I;

			// Token: 0x04000196 RID: 406
			private static Delegate cb_setDeleteIntent_Landroid_app_PendingIntent_;

			// Token: 0x04000197 RID: 407
			private static Delegate cb_setExtras_Landroid_os_Bundle_;

			// Token: 0x04000198 RID: 408
			private static Delegate cb_setForegroundServiceBehavior_I;

			// Token: 0x04000199 RID: 409
			private static Delegate cb_setFullScreenIntent_Landroid_app_PendingIntent_Z;

			// Token: 0x0400019A RID: 410
			private static Delegate cb_setGroup_Ljava_lang_String_;

			// Token: 0x0400019B RID: 411
			private static Delegate cb_setGroupAlertBehavior_I;

			// Token: 0x0400019C RID: 412
			private static Delegate cb_setGroupSummary_Z;

			// Token: 0x0400019D RID: 413
			private static Delegate cb_setLargeIcon_Landroid_graphics_Bitmap_;

			// Token: 0x0400019E RID: 414
			private static Delegate cb_setLargeIcon_Landroid_graphics_drawable_Icon_;

			// Token: 0x0400019F RID: 415
			private static Delegate cb_setLights_III;

			// Token: 0x040001A0 RID: 416
			private static Delegate cb_setLocalOnly_Z;

			// Token: 0x040001A1 RID: 417
			private static Delegate cb_setLocusId_Landroidx_core_content_LocusIdCompat_;

			// Token: 0x040001A2 RID: 418
			private static Delegate cb_setNotificationSilent;

			// Token: 0x040001A3 RID: 419
			private static Delegate cb_setNumber_I;

			// Token: 0x040001A4 RID: 420
			private static Delegate cb_setOngoing_Z;

			// Token: 0x040001A5 RID: 421
			private static Delegate cb_setOnlyAlertOnce_Z;

			// Token: 0x040001A6 RID: 422
			private static Delegate cb_setPriority_I;

			// Token: 0x040001A7 RID: 423
			private static Delegate cb_setProgress_IIZ;

			// Token: 0x040001A8 RID: 424
			private static Delegate cb_setPublicVersion_Landroid_app_Notification_;

			// Token: 0x040001A9 RID: 425
			private static Delegate cb_setRemoteInputHistory_arrayLjava_lang_CharSequence_;

			// Token: 0x040001AA RID: 426
			private static Delegate cb_setSettingsText_Ljava_lang_CharSequence_;

			// Token: 0x040001AB RID: 427
			private static Delegate cb_setShortcutId_Ljava_lang_String_;

			// Token: 0x040001AC RID: 428
			private static Delegate cb_setShortcutInfo_Landroidx_core_content_pm_ShortcutInfoCompat_;

			// Token: 0x040001AD RID: 429
			private static Delegate cb_setShowWhen_Z;

			// Token: 0x040001AE RID: 430
			private static Delegate cb_setSilent_Z;

			// Token: 0x040001AF RID: 431
			private static Delegate cb_setSmallIcon_Landroidx_core_graphics_drawable_IconCompat_;

			// Token: 0x040001B0 RID: 432
			private static Delegate cb_setSmallIcon_I;

			// Token: 0x040001B1 RID: 433
			private static Delegate cb_setSmallIcon_II;

			// Token: 0x040001B2 RID: 434
			private static Delegate cb_setSortKey_Ljava_lang_String_;

			// Token: 0x040001B3 RID: 435
			private static Delegate cb_setSound_Landroid_net_Uri_;

			// Token: 0x040001B4 RID: 436
			private static Delegate cb_setSound_Landroid_net_Uri_I;

			// Token: 0x040001B5 RID: 437
			private static Delegate cb_setStyle_Landroidx_core_app_NotificationCompat_Style_;

			// Token: 0x040001B6 RID: 438
			private static Delegate cb_setSubText_Ljava_lang_CharSequence_;

			// Token: 0x040001B7 RID: 439
			private static Delegate cb_setTicker_Ljava_lang_CharSequence_;

			// Token: 0x040001B8 RID: 440
			private static Delegate cb_setTicker_Ljava_lang_CharSequence_Landroid_widget_RemoteViews_;

			// Token: 0x040001B9 RID: 441
			private static Delegate cb_setTimeoutAfter_J;

			// Token: 0x040001BA RID: 442
			private static Delegate cb_setUsesChronometer_Z;

			// Token: 0x040001BB RID: 443
			private static Delegate cb_setVibrate_arrayJ;

			// Token: 0x040001BC RID: 444
			private static Delegate cb_setVisibility_I;

			// Token: 0x040001BD RID: 445
			private static Delegate cb_setWhen_J;
		}

		// Token: 0x02000079 RID: 121
		[Register("androidx/core/app/NotificationCompat$Extender", "", "AndroidX.Core.App.NotificationCompat/IExtenderInvoker")]
		public interface IExtender : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000691 RID: 1681
			[Register("extend", "(Landroidx/core/app/NotificationCompat$Builder;)Landroidx/core/app/NotificationCompat$Builder;", "GetExtend_Landroidx_core_app_NotificationCompat_Builder_Handler:AndroidX.Core.App.NotificationCompat/IExtenderInvoker, Xamarin.AndroidX.Core")]
			NotificationCompat.Builder Extend(NotificationCompat.Builder builder);
		}

		// Token: 0x0200007A RID: 122
		[Register("androidx/core/app/NotificationCompat$Extender", DoNotGenerateAcw = true)]
		internal class IExtenderInvoker : Java.Lang.Object, NotificationCompat.IExtender, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700011D RID: 285
			// (get) Token: 0x06000692 RID: 1682 RVA: 0x00013D0C File Offset: 0x00011F0C
			private static IntPtr java_class_ref
			{
				get
				{
					return NotificationCompat.IExtenderInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x06000693 RID: 1683 RVA: 0x00013D30 File Offset: 0x00011F30
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return NotificationCompat.IExtenderInvoker._members;
				}
			}

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x06000694 RID: 1684 RVA: 0x00013D37 File Offset: 0x00011F37
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x06000695 RID: 1685 RVA: 0x00013D3F File Offset: 0x00011F3F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return NotificationCompat.IExtenderInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000696 RID: 1686 RVA: 0x00013D4B File Offset: 0x00011F4B
			public static NotificationCompat.IExtender GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<NotificationCompat.IExtender>(handle, transfer);
			}

			// Token: 0x06000697 RID: 1687 RVA: 0x00013D54 File Offset: 0x00011F54
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, NotificationCompat.IExtenderInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.app.NotificationCompat.Extender'.");
				}
				return handle;
			}

			// Token: 0x06000698 RID: 1688 RVA: 0x00013D7F File Offset: 0x00011F7F
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000699 RID: 1689 RVA: 0x00013DB0 File Offset: 0x00011FB0
			public IExtenderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(NotificationCompat.IExtenderInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600069A RID: 1690 RVA: 0x00013DE8 File Offset: 0x00011FE8
			private static Delegate GetExtend_Landroidx_core_app_NotificationCompat_Builder_Handler()
			{
				if (NotificationCompat.IExtenderInvoker.cb_extend_Landroidx_core_app_NotificationCompat_Builder_ == null)
				{
					NotificationCompat.IExtenderInvoker.cb_extend_Landroidx_core_app_NotificationCompat_Builder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.IExtenderInvoker.n_Extend_Landroidx_core_app_NotificationCompat_Builder_));
				}
				return NotificationCompat.IExtenderInvoker.cb_extend_Landroidx_core_app_NotificationCompat_Builder_;
			}

			// Token: 0x0600069B RID: 1691 RVA: 0x00013E0C File Offset: 0x0001200C
			private static IntPtr n_Extend_Landroidx_core_app_NotificationCompat_Builder_(IntPtr jnienv, IntPtr native__this, IntPtr native_builder)
			{
				NotificationCompat.IExtender @object = Java.Lang.Object.GetObject<NotificationCompat.IExtender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				NotificationCompat.Builder object2 = Java.Lang.Object.GetObject<NotificationCompat.Builder>(native_builder, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Extend(object2));
			}

			// Token: 0x0600069C RID: 1692 RVA: 0x00013E34 File Offset: 0x00012034
			public unsafe NotificationCompat.Builder Extend(NotificationCompat.Builder builder)
			{
				if (this.id_extend_Landroidx_core_app_NotificationCompat_Builder_ == IntPtr.Zero)
				{
					this.id_extend_Landroidx_core_app_NotificationCompat_Builder_ = JNIEnv.GetMethodID(this.class_ref, "extend", "(Landroidx/core/app/NotificationCompat$Builder;)Landroidx/core/app/NotificationCompat$Builder;");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((builder == null) ? IntPtr.Zero : builder.Handle);
				return Java.Lang.Object.GetObject<NotificationCompat.Builder>(JNIEnv.CallObjectMethod(base.Handle, this.id_extend_Landroidx_core_app_NotificationCompat_Builder_, ptr), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x040001BE RID: 446
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/NotificationCompat$Extender", typeof(NotificationCompat.IExtenderInvoker));

			// Token: 0x040001BF RID: 447
			private IntPtr class_ref;

			// Token: 0x040001C0 RID: 448
			private static Delegate cb_extend_Landroidx_core_app_NotificationCompat_Builder_;

			// Token: 0x040001C1 RID: 449
			private IntPtr id_extend_Landroidx_core_app_NotificationCompat_Builder_;
		}

		// Token: 0x0200007B RID: 123
		[Register("androidx/core/app/NotificationCompat$Style", DoNotGenerateAcw = true)]
		public abstract class Style : Java.Lang.Object
		{
			// Token: 0x17000121 RID: 289
			// (get) Token: 0x0600069E RID: 1694 RVA: 0x00013EC8 File Offset: 0x000120C8
			// (set) Token: 0x0600069F RID: 1695 RVA: 0x00013EF8 File Offset: 0x000120F8
			[Register("mBuilder")]
			protected NotificationCompat.Builder MBuilder
			{
				get
				{
					return Java.Lang.Object.GetObject<NotificationCompat.Builder>(NotificationCompat.Style._members.InstanceFields.GetObjectValue("mBuilder.Landroidx/core/app/NotificationCompat$Builder;", this).Handle, JniHandleOwnership.TransferLocalRef);
				}
				set
				{
					IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
					try
					{
						NotificationCompat.Style._members.InstanceFields.SetValue("mBuilder.Landroidx/core/app/NotificationCompat$Builder;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
					}
					finally
					{
						JNIEnv.DeleteLocalRef(intPtr);
					}
				}
			}

			// Token: 0x17000122 RID: 290
			// (get) Token: 0x060006A0 RID: 1696 RVA: 0x00013F44 File Offset: 0x00012144
			internal static IntPtr class_ref
			{
				get
				{
					return NotificationCompat.Style._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000123 RID: 291
			// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00013F68 File Offset: 0x00012168
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return NotificationCompat.Style._members;
				}
			}

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x060006A2 RID: 1698 RVA: 0x00013F70 File Offset: 0x00012170
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return NotificationCompat.Style._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x060006A3 RID: 1699 RVA: 0x00013F94 File Offset: 0x00012194
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return NotificationCompat.Style._members.ManagedPeerType;
				}
			}

			// Token: 0x060006A4 RID: 1700 RVA: 0x00002384 File Offset: 0x00000584
			protected Style(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060006A5 RID: 1701 RVA: 0x00013FA0 File Offset: 0x000121A0
			[Register(".ctor", "()V", "")]
			public Style() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(NotificationCompat.Style._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				NotificationCompat.Style._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x060006A6 RID: 1702 RVA: 0x0001400E File Offset: 0x0001220E
			private static Delegate GetGetClassNameHandler()
			{
				if (NotificationCompat.Style.cb_getClassName == null)
				{
					NotificationCompat.Style.cb_getClassName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationCompat.Style.n_GetClassName));
				}
				return NotificationCompat.Style.cb_getClassName;
			}

			// Token: 0x060006A7 RID: 1703 RVA: 0x00014032 File Offset: 0x00012232
			private static IntPtr n_GetClassName(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<NotificationCompat.Style>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClassName);
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x060006A8 RID: 1704 RVA: 0x00014048 File Offset: 0x00012248
			protected virtual string ClassName
			{
				[Register("getClassName", "()Ljava/lang/String;", "GetGetClassNameHandler")]
				get
				{
					return JNIEnv.GetString(NotificationCompat.Style._members.InstanceMethods.InvokeVirtualObjectMethod("getClassName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x060006A9 RID: 1705 RVA: 0x0001407A File Offset: 0x0001227A
			private static Delegate GetAddCompatExtras_Landroid_os_Bundle_Handler()
			{
				if (NotificationCompat.Style.cb_addCompatExtras_Landroid_os_Bundle_ == null)
				{
					NotificationCompat.Style.cb_addCompatExtras_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(NotificationCompat.Style.n_AddCompatExtras_Landroid_os_Bundle_));
				}
				return NotificationCompat.Style.cb_addCompatExtras_Landroid_os_Bundle_;
			}

			// Token: 0x060006AA RID: 1706 RVA: 0x000140A0 File Offset: 0x000122A0
			private static void n_AddCompatExtras_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_extras)
			{
				NotificationCompat.Style @object = Java.Lang.Object.GetObject<NotificationCompat.Style>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_extras, JniHandleOwnership.DoNotTransfer);
				@object.AddCompatExtras(object2);
			}

			// Token: 0x060006AB RID: 1707 RVA: 0x000140C4 File Offset: 0x000122C4
			[Register("addCompatExtras", "(Landroid/os/Bundle;)V", "GetAddCompatExtras_Landroid_os_Bundle_Handler")]
			public unsafe virtual void AddCompatExtras(Bundle extras)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((extras == null) ? IntPtr.Zero : extras.Handle);
					NotificationCompat.Style._members.InstanceMethods.InvokeVirtualVoidMethod("addCompatExtras.(Landroid/os/Bundle;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(extras);
				}
			}

			// Token: 0x060006AC RID: 1708 RVA: 0x00014128 File Offset: 0x00012328
			private static Delegate GetApply_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_Handler()
			{
				if (NotificationCompat.Style.cb_apply_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_ == null)
				{
					NotificationCompat.Style.cb_apply_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(NotificationCompat.Style.n_Apply_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_));
				}
				return NotificationCompat.Style.cb_apply_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_;
			}

			// Token: 0x060006AD RID: 1709 RVA: 0x0001414C File Offset: 0x0001234C
			private static void n_Apply_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_(IntPtr jnienv, IntPtr native__this, IntPtr native_builder)
			{
				NotificationCompat.Style @object = Java.Lang.Object.GetObject<NotificationCompat.Style>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				INotificationBuilderWithBuilderAccessor object2 = Java.Lang.Object.GetObject<INotificationBuilderWithBuilderAccessor>(native_builder, JniHandleOwnership.DoNotTransfer);
				@object.Apply(object2);
			}

			// Token: 0x060006AE RID: 1710 RVA: 0x00014170 File Offset: 0x00012370
			[Register("apply", "(Landroidx/core/app/NotificationBuilderWithBuilderAccessor;)V", "GetApply_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_Handler")]
			public unsafe virtual void Apply(INotificationBuilderWithBuilderAccessor builder)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((builder == null) ? IntPtr.Zero : ((Java.Lang.Object)builder).Handle);
					NotificationCompat.Style._members.InstanceMethods.InvokeVirtualVoidMethod("apply.(Landroidx/core/app/NotificationBuilderWithBuilderAccessor;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(builder);
				}
			}

			// Token: 0x060006AF RID: 1711 RVA: 0x000141D8 File Offset: 0x000123D8
			private static Delegate GetApplyStandardTemplate_ZIZHandler()
			{
				if (NotificationCompat.Style.cb_applyStandardTemplate_ZIZ == null)
				{
					NotificationCompat.Style.cb_applyStandardTemplate_ZIZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZIZ_L(NotificationCompat.Style.n_ApplyStandardTemplate_ZIZ));
				}
				return NotificationCompat.Style.cb_applyStandardTemplate_ZIZ;
			}

			// Token: 0x060006B0 RID: 1712 RVA: 0x000141FC File Offset: 0x000123FC
			private static IntPtr n_ApplyStandardTemplate_ZIZ(IntPtr jnienv, IntPtr native__this, bool showSmallIcon, int resId, bool fitIn1U)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Style>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ApplyStandardTemplate(showSmallIcon, resId, fitIn1U));
			}

			// Token: 0x060006B1 RID: 1713 RVA: 0x00014214 File Offset: 0x00012414
			[Register("applyStandardTemplate", "(ZIZ)Landroid/widget/RemoteViews;", "GetApplyStandardTemplate_ZIZHandler")]
			public unsafe virtual RemoteViews ApplyStandardTemplate(bool showSmallIcon, int resId, bool fitIn1U)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(showSmallIcon);
				ptr[1] = new JniArgumentValue(resId);
				ptr[2] = new JniArgumentValue(fitIn1U);
				return Java.Lang.Object.GetObject<RemoteViews>(NotificationCompat.Style._members.InstanceMethods.InvokeVirtualObjectMethod("applyStandardTemplate.(ZIZ)Landroid/widget/RemoteViews;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060006B2 RID: 1714 RVA: 0x00014286 File Offset: 0x00012486
			private static Delegate GetBuildHandler()
			{
				if (NotificationCompat.Style.cb_build == null)
				{
					NotificationCompat.Style.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationCompat.Style.n_Build));
				}
				return NotificationCompat.Style.cb_build;
			}

			// Token: 0x060006B3 RID: 1715 RVA: 0x000142AA File Offset: 0x000124AA
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Style>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
			}

			// Token: 0x060006B4 RID: 1716 RVA: 0x000142C0 File Offset: 0x000124C0
			[Register("build", "()Landroid/app/Notification;", "GetBuildHandler")]
			public virtual Notification Build()
			{
				return Java.Lang.Object.GetObject<Notification>(NotificationCompat.Style._members.InstanceMethods.InvokeVirtualObjectMethod("build.()Landroid/app/Notification;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060006B5 RID: 1717 RVA: 0x000142F2 File Offset: 0x000124F2
			private static Delegate GetBuildIntoRemoteViews_Landroid_widget_RemoteViews_Landroid_widget_RemoteViews_Handler()
			{
				if (NotificationCompat.Style.cb_buildIntoRemoteViews_Landroid_widget_RemoteViews_Landroid_widget_RemoteViews_ == null)
				{
					NotificationCompat.Style.cb_buildIntoRemoteViews_Landroid_widget_RemoteViews_Landroid_widget_RemoteViews_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(NotificationCompat.Style.n_BuildIntoRemoteViews_Landroid_widget_RemoteViews_Landroid_widget_RemoteViews_));
				}
				return NotificationCompat.Style.cb_buildIntoRemoteViews_Landroid_widget_RemoteViews_Landroid_widget_RemoteViews_;
			}

			// Token: 0x060006B6 RID: 1718 RVA: 0x00014318 File Offset: 0x00012518
			private static void n_BuildIntoRemoteViews_Landroid_widget_RemoteViews_Landroid_widget_RemoteViews_(IntPtr jnienv, IntPtr native__this, IntPtr native_outerView, IntPtr native_innerView)
			{
				NotificationCompat.Style @object = Java.Lang.Object.GetObject<NotificationCompat.Style>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RemoteViews object2 = Java.Lang.Object.GetObject<RemoteViews>(native_outerView, JniHandleOwnership.DoNotTransfer);
				RemoteViews object3 = Java.Lang.Object.GetObject<RemoteViews>(native_innerView, JniHandleOwnership.DoNotTransfer);
				@object.BuildIntoRemoteViews(object2, object3);
			}

			// Token: 0x060006B7 RID: 1719 RVA: 0x00014344 File Offset: 0x00012544
			[Register("buildIntoRemoteViews", "(Landroid/widget/RemoteViews;Landroid/widget/RemoteViews;)V", "GetBuildIntoRemoteViews_Landroid_widget_RemoteViews_Landroid_widget_RemoteViews_Handler")]
			public unsafe virtual void BuildIntoRemoteViews(RemoteViews outerView, RemoteViews innerView)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((outerView == null) ? IntPtr.Zero : outerView.Handle);
					ptr[1] = new JniArgumentValue((innerView == null) ? IntPtr.Zero : innerView.Handle);
					NotificationCompat.Style._members.InstanceMethods.InvokeVirtualVoidMethod("buildIntoRemoteViews.(Landroid/widget/RemoteViews;Landroid/widget/RemoteViews;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(outerView);
					GC.KeepAlive(innerView);
				}
			}

			// Token: 0x060006B8 RID: 1720 RVA: 0x000143D0 File Offset: 0x000125D0
			private static Delegate GetClearCompatExtraKeys_Landroid_os_Bundle_Handler()
			{
				if (NotificationCompat.Style.cb_clearCompatExtraKeys_Landroid_os_Bundle_ == null)
				{
					NotificationCompat.Style.cb_clearCompatExtraKeys_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(NotificationCompat.Style.n_ClearCompatExtraKeys_Landroid_os_Bundle_));
				}
				return NotificationCompat.Style.cb_clearCompatExtraKeys_Landroid_os_Bundle_;
			}

			// Token: 0x060006B9 RID: 1721 RVA: 0x000143F4 File Offset: 0x000125F4
			private static void n_ClearCompatExtraKeys_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_extras)
			{
				NotificationCompat.Style @object = Java.Lang.Object.GetObject<NotificationCompat.Style>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_extras, JniHandleOwnership.DoNotTransfer);
				@object.ClearCompatExtraKeys(object2);
			}

			// Token: 0x060006BA RID: 1722 RVA: 0x00014418 File Offset: 0x00012618
			[Register("clearCompatExtraKeys", "(Landroid/os/Bundle;)V", "GetClearCompatExtraKeys_Landroid_os_Bundle_Handler")]
			protected unsafe virtual void ClearCompatExtraKeys(Bundle extras)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((extras == null) ? IntPtr.Zero : extras.Handle);
					NotificationCompat.Style._members.InstanceMethods.InvokeVirtualVoidMethod("clearCompatExtraKeys.(Landroid/os/Bundle;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(extras);
				}
			}

			// Token: 0x060006BB RID: 1723 RVA: 0x0001447C File Offset: 0x0001267C
			private static Delegate GetCreateColoredBitmap_IIHandler()
			{
				if (NotificationCompat.Style.cb_createColoredBitmap_II == null)
				{
					NotificationCompat.Style.cb_createColoredBitmap_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_L(NotificationCompat.Style.n_CreateColoredBitmap_II));
				}
				return NotificationCompat.Style.cb_createColoredBitmap_II;
			}

			// Token: 0x060006BC RID: 1724 RVA: 0x000144A0 File Offset: 0x000126A0
			private static IntPtr n_CreateColoredBitmap_II(IntPtr jnienv, IntPtr native__this, int iconId, int color)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationCompat.Style>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CreateColoredBitmap(iconId, color));
			}

			// Token: 0x060006BD RID: 1725 RVA: 0x000144B8 File Offset: 0x000126B8
			[Register("createColoredBitmap", "(II)Landroid/graphics/Bitmap;", "GetCreateColoredBitmap_IIHandler")]
			public unsafe virtual Bitmap CreateColoredBitmap(int iconId, int color)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(iconId);
				ptr[1] = new JniArgumentValue(color);
				return Java.Lang.Object.GetObject<Bitmap>(NotificationCompat.Style._members.InstanceMethods.InvokeVirtualObjectMethod("createColoredBitmap.(II)Landroid/graphics/Bitmap;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060006BE RID: 1726 RVA: 0x00014514 File Offset: 0x00012714
			private static Delegate GetDisplayCustomViewInlineHandler()
			{
				if (NotificationCompat.Style.cb_displayCustomViewInline == null)
				{
					NotificationCompat.Style.cb_displayCustomViewInline = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(NotificationCompat.Style.n_DisplayCustomViewInline));
				}
				return NotificationCompat.Style.cb_displayCustomViewInline;
			}

			// Token: 0x060006BF RID: 1727 RVA: 0x00014538 File Offset: 0x00012738
			private static bool n_DisplayCustomViewInline(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<NotificationCompat.Style>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DisplayCustomViewInline();
			}

			// Token: 0x060006C0 RID: 1728 RVA: 0x00014547 File Offset: 0x00012747
			[Register("displayCustomViewInline", "()Z", "GetDisplayCustomViewInlineHandler")]
			public virtual bool DisplayCustomViewInline()
			{
				return NotificationCompat.Style._members.InstanceMethods.InvokeVirtualBooleanMethod("displayCustomViewInline.()Z", this, null);
			}

			// Token: 0x060006C1 RID: 1729 RVA: 0x00014560 File Offset: 0x00012760
			[Register("extractStyleFromNotification", "(Landroid/app/Notification;)Landroidx/core/app/NotificationCompat$Style;", "")]
			public unsafe static NotificationCompat.Style ExtractStyleFromNotification(Notification notification)
			{
				NotificationCompat.Style @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
					@object = Java.Lang.Object.GetObject<NotificationCompat.Style>(NotificationCompat.Style._members.StaticMethods.InvokeObjectMethod("extractStyleFromNotification.(Landroid/app/Notification;)Landroidx/core/app/NotificationCompat$Style;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(notification);
				}
				return @object;
			}

			// Token: 0x060006C2 RID: 1730 RVA: 0x000145D4 File Offset: 0x000127D4
			private static Delegate GetMakeBigContentView_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_Handler()
			{
				if (NotificationCompat.Style.cb_makeBigContentView_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_ == null)
				{
					NotificationCompat.Style.cb_makeBigContentView_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Style.n_MakeBigContentView_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_));
				}
				return NotificationCompat.Style.cb_makeBigContentView_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_;
			}

			// Token: 0x060006C3 RID: 1731 RVA: 0x000145F8 File Offset: 0x000127F8
			private static IntPtr n_MakeBigContentView_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_(IntPtr jnienv, IntPtr native__this, IntPtr native_builder)
			{
				NotificationCompat.Style @object = Java.Lang.Object.GetObject<NotificationCompat.Style>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				INotificationBuilderWithBuilderAccessor object2 = Java.Lang.Object.GetObject<INotificationBuilderWithBuilderAccessor>(native_builder, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.MakeBigContentView(object2));
			}

			// Token: 0x060006C4 RID: 1732 RVA: 0x00014620 File Offset: 0x00012820
			[Register("makeBigContentView", "(Landroidx/core/app/NotificationBuilderWithBuilderAccessor;)Landroid/widget/RemoteViews;", "GetMakeBigContentView_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_Handler")]
			public unsafe virtual RemoteViews MakeBigContentView(INotificationBuilderWithBuilderAccessor builder)
			{
				RemoteViews @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((builder == null) ? IntPtr.Zero : ((Java.Lang.Object)builder).Handle);
					@object = Java.Lang.Object.GetObject<RemoteViews>(NotificationCompat.Style._members.InstanceMethods.InvokeVirtualObjectMethod("makeBigContentView.(Landroidx/core/app/NotificationBuilderWithBuilderAccessor;)Landroid/widget/RemoteViews;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(builder);
				}
				return @object;
			}

			// Token: 0x060006C5 RID: 1733 RVA: 0x00014698 File Offset: 0x00012898
			private static Delegate GetMakeContentView_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_Handler()
			{
				if (NotificationCompat.Style.cb_makeContentView_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_ == null)
				{
					NotificationCompat.Style.cb_makeContentView_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Style.n_MakeContentView_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_));
				}
				return NotificationCompat.Style.cb_makeContentView_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_;
			}

			// Token: 0x060006C6 RID: 1734 RVA: 0x000146BC File Offset: 0x000128BC
			private static IntPtr n_MakeContentView_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_(IntPtr jnienv, IntPtr native__this, IntPtr native_builder)
			{
				NotificationCompat.Style @object = Java.Lang.Object.GetObject<NotificationCompat.Style>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				INotificationBuilderWithBuilderAccessor object2 = Java.Lang.Object.GetObject<INotificationBuilderWithBuilderAccessor>(native_builder, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.MakeContentView(object2));
			}

			// Token: 0x060006C7 RID: 1735 RVA: 0x000146E4 File Offset: 0x000128E4
			[Register("makeContentView", "(Landroidx/core/app/NotificationBuilderWithBuilderAccessor;)Landroid/widget/RemoteViews;", "GetMakeContentView_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_Handler")]
			public unsafe virtual RemoteViews MakeContentView(INotificationBuilderWithBuilderAccessor builder)
			{
				RemoteViews @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((builder == null) ? IntPtr.Zero : ((Java.Lang.Object)builder).Handle);
					@object = Java.Lang.Object.GetObject<RemoteViews>(NotificationCompat.Style._members.InstanceMethods.InvokeVirtualObjectMethod("makeContentView.(Landroidx/core/app/NotificationBuilderWithBuilderAccessor;)Landroid/widget/RemoteViews;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(builder);
				}
				return @object;
			}

			// Token: 0x060006C8 RID: 1736 RVA: 0x0001475C File Offset: 0x0001295C
			private static Delegate GetMakeHeadsUpContentView_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_Handler()
			{
				if (NotificationCompat.Style.cb_makeHeadsUpContentView_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_ == null)
				{
					NotificationCompat.Style.cb_makeHeadsUpContentView_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationCompat.Style.n_MakeHeadsUpContentView_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_));
				}
				return NotificationCompat.Style.cb_makeHeadsUpContentView_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_;
			}

			// Token: 0x060006C9 RID: 1737 RVA: 0x00014780 File Offset: 0x00012980
			private static IntPtr n_MakeHeadsUpContentView_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_(IntPtr jnienv, IntPtr native__this, IntPtr native_builder)
			{
				NotificationCompat.Style @object = Java.Lang.Object.GetObject<NotificationCompat.Style>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				INotificationBuilderWithBuilderAccessor object2 = Java.Lang.Object.GetObject<INotificationBuilderWithBuilderAccessor>(native_builder, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.MakeHeadsUpContentView(object2));
			}

			// Token: 0x060006CA RID: 1738 RVA: 0x000147A8 File Offset: 0x000129A8
			[Register("makeHeadsUpContentView", "(Landroidx/core/app/NotificationBuilderWithBuilderAccessor;)Landroid/widget/RemoteViews;", "GetMakeHeadsUpContentView_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_Handler")]
			public unsafe virtual RemoteViews MakeHeadsUpContentView(INotificationBuilderWithBuilderAccessor builder)
			{
				RemoteViews @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((builder == null) ? IntPtr.Zero : ((Java.Lang.Object)builder).Handle);
					@object = Java.Lang.Object.GetObject<RemoteViews>(NotificationCompat.Style._members.InstanceMethods.InvokeVirtualObjectMethod("makeHeadsUpContentView.(Landroidx/core/app/NotificationBuilderWithBuilderAccessor;)Landroid/widget/RemoteViews;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(builder);
				}
				return @object;
			}

			// Token: 0x060006CB RID: 1739 RVA: 0x00014820 File Offset: 0x00012A20
			private static Delegate GetRestoreFromCompatExtras_Landroid_os_Bundle_Handler()
			{
				if (NotificationCompat.Style.cb_restoreFromCompatExtras_Landroid_os_Bundle_ == null)
				{
					NotificationCompat.Style.cb_restoreFromCompatExtras_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(NotificationCompat.Style.n_RestoreFromCompatExtras_Landroid_os_Bundle_));
				}
				return NotificationCompat.Style.cb_restoreFromCompatExtras_Landroid_os_Bundle_;
			}

			// Token: 0x060006CC RID: 1740 RVA: 0x00014844 File Offset: 0x00012A44
			private static void n_RestoreFromCompatExtras_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_extras)
			{
				NotificationCompat.Style @object = Java.Lang.Object.GetObject<NotificationCompat.Style>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_extras, JniHandleOwnership.DoNotTransfer);
				@object.RestoreFromCompatExtras(object2);
			}

			// Token: 0x060006CD RID: 1741 RVA: 0x00014868 File Offset: 0x00012A68
			[Register("restoreFromCompatExtras", "(Landroid/os/Bundle;)V", "GetRestoreFromCompatExtras_Landroid_os_Bundle_Handler")]
			protected unsafe virtual void RestoreFromCompatExtras(Bundle extras)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((extras == null) ? IntPtr.Zero : extras.Handle);
					NotificationCompat.Style._members.InstanceMethods.InvokeVirtualVoidMethod("restoreFromCompatExtras.(Landroid/os/Bundle;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(extras);
				}
			}

			// Token: 0x060006CE RID: 1742 RVA: 0x000148CC File Offset: 0x00012ACC
			private static Delegate GetSetBuilder_Landroidx_core_app_NotificationCompat_Builder_Handler()
			{
				if (NotificationCompat.Style.cb_setBuilder_Landroidx_core_app_NotificationCompat_Builder_ == null)
				{
					NotificationCompat.Style.cb_setBuilder_Landroidx_core_app_NotificationCompat_Builder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(NotificationCompat.Style.n_SetBuilder_Landroidx_core_app_NotificationCompat_Builder_));
				}
				return NotificationCompat.Style.cb_setBuilder_Landroidx_core_app_NotificationCompat_Builder_;
			}

			// Token: 0x060006CF RID: 1743 RVA: 0x000148F0 File Offset: 0x00012AF0
			private static void n_SetBuilder_Landroidx_core_app_NotificationCompat_Builder_(IntPtr jnienv, IntPtr native__this, IntPtr native_builder)
			{
				NotificationCompat.Style @object = Java.Lang.Object.GetObject<NotificationCompat.Style>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				NotificationCompat.Builder object2 = Java.Lang.Object.GetObject<NotificationCompat.Builder>(native_builder, JniHandleOwnership.DoNotTransfer);
				@object.SetBuilder(object2);
			}

			// Token: 0x060006D0 RID: 1744 RVA: 0x00014914 File Offset: 0x00012B14
			[Register("setBuilder", "(Landroidx/core/app/NotificationCompat$Builder;)V", "GetSetBuilder_Landroidx_core_app_NotificationCompat_Builder_Handler")]
			public unsafe virtual void SetBuilder(NotificationCompat.Builder builder)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((builder == null) ? IntPtr.Zero : builder.Handle);
					NotificationCompat.Style._members.InstanceMethods.InvokeVirtualVoidMethod("setBuilder.(Landroidx/core/app/NotificationCompat$Builder;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(builder);
				}
			}

			// Token: 0x040001C2 RID: 450
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/NotificationCompat$Style", typeof(NotificationCompat.Style));

			// Token: 0x040001C3 RID: 451
			private static Delegate cb_getClassName;

			// Token: 0x040001C4 RID: 452
			private static Delegate cb_addCompatExtras_Landroid_os_Bundle_;

			// Token: 0x040001C5 RID: 453
			private static Delegate cb_apply_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_;

			// Token: 0x040001C6 RID: 454
			private static Delegate cb_applyStandardTemplate_ZIZ;

			// Token: 0x040001C7 RID: 455
			private static Delegate cb_build;

			// Token: 0x040001C8 RID: 456
			private static Delegate cb_buildIntoRemoteViews_Landroid_widget_RemoteViews_Landroid_widget_RemoteViews_;

			// Token: 0x040001C9 RID: 457
			private static Delegate cb_clearCompatExtraKeys_Landroid_os_Bundle_;

			// Token: 0x040001CA RID: 458
			private static Delegate cb_createColoredBitmap_II;

			// Token: 0x040001CB RID: 459
			private static Delegate cb_displayCustomViewInline;

			// Token: 0x040001CC RID: 460
			private static Delegate cb_makeBigContentView_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_;

			// Token: 0x040001CD RID: 461
			private static Delegate cb_makeContentView_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_;

			// Token: 0x040001CE RID: 462
			private static Delegate cb_makeHeadsUpContentView_Landroidx_core_app_NotificationBuilderWithBuilderAccessor_;

			// Token: 0x040001CF RID: 463
			private static Delegate cb_restoreFromCompatExtras_Landroid_os_Bundle_;

			// Token: 0x040001D0 RID: 464
			private static Delegate cb_setBuilder_Landroidx_core_app_NotificationCompat_Builder_;
		}

		// Token: 0x0200007C RID: 124
		[Register("androidx/core/app/NotificationCompat$Style", DoNotGenerateAcw = true)]
		internal class StyleInvoker : NotificationCompat.Style
		{
			// Token: 0x060006D2 RID: 1746 RVA: 0x0000F780 File Offset: 0x0000D980
			public StyleInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x060006D3 RID: 1747 RVA: 0x00014993 File Offset: 0x00012B93
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return NotificationCompat.StyleInvoker._members;
				}
			}

			// Token: 0x17000128 RID: 296
			// (get) Token: 0x060006D4 RID: 1748 RVA: 0x0001499A File Offset: 0x00012B9A
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return NotificationCompat.StyleInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x040001D1 RID: 465
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/NotificationCompat$Style", typeof(NotificationCompat.StyleInvoker));
		}
	}
}
