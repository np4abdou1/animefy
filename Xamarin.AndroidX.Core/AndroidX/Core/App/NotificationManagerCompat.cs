using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Service.Notification;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.App
{
	// Token: 0x0200007D RID: 125
	[Register("androidx/core/app/NotificationManagerCompat", DoNotGenerateAcw = true)]
	public sealed class NotificationManagerCompat : Java.Lang.Object
	{
		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x000149C4 File Offset: 0x00012BC4
		internal static IntPtr class_ref
		{
			get
			{
				return NotificationManagerCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x000149E8 File Offset: 0x00012BE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return NotificationManagerCompat._members;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x000149F0 File Offset: 0x00012BF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return NotificationManagerCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x00014A14 File Offset: 0x00012C14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return NotificationManagerCompat._members.ManagedPeerType;
			}
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00002384 File Offset: 0x00000584
		internal NotificationManagerCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x00014A20 File Offset: 0x00012C20
		public IList<StatusBarNotification> ActiveNotifications
		{
			[Register("getActiveNotifications", "()Ljava/util/List;", "")]
			get
			{
				return JavaList<StatusBarNotification>.FromJniHandle(NotificationManagerCompat._members.InstanceMethods.InvokeAbstractObjectMethod("getActiveNotifications.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x00014A52 File Offset: 0x00012C52
		public int CurrentInterruptionFilter
		{
			[Register("getCurrentInterruptionFilter", "()I", "")]
			get
			{
				return NotificationManagerCompat._members.InstanceMethods.InvokeAbstractInt32Method("getCurrentInterruptionFilter.()I", this, null);
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x00014A6B File Offset: 0x00012C6B
		public int Importance
		{
			[Register("getImportance", "()I", "")]
			get
			{
				return NotificationManagerCompat._members.InstanceMethods.InvokeAbstractInt32Method("getImportance.()I", this, null);
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x00014A84 File Offset: 0x00012C84
		public IList<NotificationChannelGroup> NotificationChannelGroups
		{
			[Register("getNotificationChannelGroups", "()Ljava/util/List;", "")]
			get
			{
				return JavaList<NotificationChannelGroup>.FromJniHandle(NotificationManagerCompat._members.InstanceMethods.InvokeAbstractObjectMethod("getNotificationChannelGroups.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x00014AB8 File Offset: 0x00012CB8
		public IList<NotificationChannelGroupCompat> NotificationChannelGroupsCompat
		{
			[Register("getNotificationChannelGroupsCompat", "()Ljava/util/List;", "")]
			get
			{
				return JavaList<NotificationChannelGroupCompat>.FromJniHandle(NotificationManagerCompat._members.InstanceMethods.InvokeAbstractObjectMethod("getNotificationChannelGroupsCompat.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x00014AEC File Offset: 0x00012CEC
		public IList<NotificationChannel> NotificationChannels
		{
			[Register("getNotificationChannels", "()Ljava/util/List;", "")]
			get
			{
				return JavaList<NotificationChannel>.FromJniHandle(NotificationManagerCompat._members.InstanceMethods.InvokeAbstractObjectMethod("getNotificationChannels.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x00014B20 File Offset: 0x00012D20
		public IList<NotificationChannelCompat> NotificationChannelsCompat
		{
			[Register("getNotificationChannelsCompat", "()Ljava/util/List;", "")]
			get
			{
				return JavaList<NotificationChannelCompat>.FromJniHandle(NotificationManagerCompat._members.InstanceMethods.InvokeAbstractObjectMethod("getNotificationChannelsCompat.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00014B52 File Offset: 0x00012D52
		[Register("areNotificationsEnabled", "()Z", "")]
		public bool AreNotificationsEnabled()
		{
			return NotificationManagerCompat._members.InstanceMethods.InvokeAbstractBooleanMethod("areNotificationsEnabled.()Z", this, null);
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00014B6B File Offset: 0x00012D6B
		[Register("canUseFullScreenIntent", "()Z", "")]
		public bool CanUseFullScreenIntent()
		{
			return NotificationManagerCompat._members.InstanceMethods.InvokeAbstractBooleanMethod("canUseFullScreenIntent.()Z", this, null);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00014B84 File Offset: 0x00012D84
		[Register("cancel", "(I)V", "")]
		public unsafe void Cancel(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			NotificationManagerCompat._members.InstanceMethods.InvokeAbstractVoidMethod("cancel.(I)V", this, ptr);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00014BC0 File Offset: 0x00012DC0
		[Register("cancel", "(Ljava/lang/String;I)V", "")]
		public unsafe void Cancel(string tag, int id)
		{
			IntPtr intPtr = JNIEnv.NewString(tag);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(id);
				NotificationManagerCompat._members.InstanceMethods.InvokeAbstractVoidMethod("cancel.(Ljava/lang/String;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00014C30 File Offset: 0x00012E30
		[Register("cancelAll", "()V", "")]
		public void CancelAll()
		{
			NotificationManagerCompat._members.InstanceMethods.InvokeAbstractVoidMethod("cancelAll.()V", this, null);
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00014C4C File Offset: 0x00012E4C
		[Register("createNotificationChannel", "(Landroid/app/NotificationChannel;)V", "")]
		public unsafe void CreateNotificationChannel(NotificationChannel channel)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((channel == null) ? IntPtr.Zero : channel.Handle);
				NotificationManagerCompat._members.InstanceMethods.InvokeAbstractVoidMethod("createNotificationChannel.(Landroid/app/NotificationChannel;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(channel);
			}
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00014CB0 File Offset: 0x00012EB0
		[Register("createNotificationChannel", "(Landroidx/core/app/NotificationChannelCompat;)V", "")]
		public unsafe void CreateNotificationChannel(NotificationChannelCompat channel)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((channel == null) ? IntPtr.Zero : channel.Handle);
				NotificationManagerCompat._members.InstanceMethods.InvokeAbstractVoidMethod("createNotificationChannel.(Landroidx/core/app/NotificationChannelCompat;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(channel);
			}
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00014D14 File Offset: 0x00012F14
		[Register("createNotificationChannelGroup", "(Landroid/app/NotificationChannelGroup;)V", "")]
		public unsafe void CreateNotificationChannelGroup(NotificationChannelGroup group)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((group == null) ? IntPtr.Zero : group.Handle);
				NotificationManagerCompat._members.InstanceMethods.InvokeAbstractVoidMethod("createNotificationChannelGroup.(Landroid/app/NotificationChannelGroup;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(group);
			}
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00014D78 File Offset: 0x00012F78
		[Register("createNotificationChannelGroup", "(Landroidx/core/app/NotificationChannelGroupCompat;)V", "")]
		public unsafe void CreateNotificationChannelGroup(NotificationChannelGroupCompat group)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((group == null) ? IntPtr.Zero : group.Handle);
				NotificationManagerCompat._members.InstanceMethods.InvokeAbstractVoidMethod("createNotificationChannelGroup.(Landroidx/core/app/NotificationChannelGroupCompat;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(group);
			}
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00014DDC File Offset: 0x00012FDC
		[Register("createNotificationChannelGroups", "(Ljava/util/List;)V", "")]
		public unsafe void CreateNotificationChannelGroups(IList<NotificationChannelGroup> groups)
		{
			IntPtr intPtr = JavaList<NotificationChannelGroup>.ToLocalJniHandle(groups);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				NotificationManagerCompat._members.InstanceMethods.InvokeAbstractVoidMethod("createNotificationChannelGroups.(Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(groups);
			}
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00014E40 File Offset: 0x00013040
		[Register("createNotificationChannelGroupsCompat", "(Ljava/util/List;)V", "")]
		public unsafe void CreateNotificationChannelGroupsCompat(IList<NotificationChannelGroupCompat> groups)
		{
			IntPtr intPtr = JavaList<NotificationChannelGroupCompat>.ToLocalJniHandle(groups);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				NotificationManagerCompat._members.InstanceMethods.InvokeAbstractVoidMethod("createNotificationChannelGroupsCompat.(Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(groups);
			}
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00014EA4 File Offset: 0x000130A4
		[Register("createNotificationChannels", "(Ljava/util/List;)V", "")]
		public unsafe void CreateNotificationChannels(IList<NotificationChannel> channels)
		{
			IntPtr intPtr = JavaList<NotificationChannel>.ToLocalJniHandle(channels);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				NotificationManagerCompat._members.InstanceMethods.InvokeAbstractVoidMethod("createNotificationChannels.(Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(channels);
			}
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00014F08 File Offset: 0x00013108
		[Register("createNotificationChannelsCompat", "(Ljava/util/List;)V", "")]
		public unsafe void CreateNotificationChannelsCompat(IList<NotificationChannelCompat> channels)
		{
			IntPtr intPtr = JavaList<NotificationChannelCompat>.ToLocalJniHandle(channels);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				NotificationManagerCompat._members.InstanceMethods.InvokeAbstractVoidMethod("createNotificationChannelsCompat.(Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(channels);
			}
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00014F6C File Offset: 0x0001316C
		[Register("deleteNotificationChannel", "(Ljava/lang/String;)V", "")]
		public unsafe void DeleteNotificationChannel(string channelId)
		{
			IntPtr intPtr = JNIEnv.NewString(channelId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				NotificationManagerCompat._members.InstanceMethods.InvokeAbstractVoidMethod("deleteNotificationChannel.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00014FC8 File Offset: 0x000131C8
		[Register("deleteNotificationChannelGroup", "(Ljava/lang/String;)V", "")]
		public unsafe void DeleteNotificationChannelGroup(string groupId)
		{
			IntPtr intPtr = JNIEnv.NewString(groupId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				NotificationManagerCompat._members.InstanceMethods.InvokeAbstractVoidMethod("deleteNotificationChannelGroup.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00015024 File Offset: 0x00013224
		[Register("deleteUnlistedNotificationChannels", "(Ljava/util/Collection;)V", "")]
		public unsafe void DeleteUnlistedNotificationChannels(ICollection<string> channelIds)
		{
			IntPtr intPtr = JavaCollection<string>.ToLocalJniHandle(channelIds);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				NotificationManagerCompat._members.InstanceMethods.InvokeAbstractVoidMethod("deleteUnlistedNotificationChannels.(Ljava/util/Collection;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(channelIds);
			}
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00015088 File Offset: 0x00013288
		[Register("from", "(Landroid/content/Context;)Landroidx/core/app/NotificationManagerCompat;", "")]
		public unsafe static NotificationManagerCompat From(Context context)
		{
			NotificationManagerCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<NotificationManagerCompat>(NotificationManagerCompat._members.StaticMethods.InvokeObjectMethod("from.(Landroid/content/Context;)Landroidx/core/app/NotificationManagerCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x000150FC File Offset: 0x000132FC
		[Register("getEnabledListenerPackages", "(Landroid/content/Context;)Ljava/util/Set;", "")]
		public unsafe static ICollection<string> GetEnabledListenerPackages(Context context)
		{
			ICollection<string> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				result = JavaSet<string>.FromJniHandle(NotificationManagerCompat._members.StaticMethods.InvokeObjectMethod("getEnabledListenerPackages.(Landroid/content/Context;)Ljava/util/Set;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return result;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00015170 File Offset: 0x00013370
		[Register("getNotificationChannel", "(Ljava/lang/String;)Landroid/app/NotificationChannel;", "")]
		public unsafe NotificationChannel GetNotificationChannel(string channelId)
		{
			IntPtr intPtr = JNIEnv.NewString(channelId);
			NotificationChannel @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<NotificationChannel>(NotificationManagerCompat._members.InstanceMethods.InvokeAbstractObjectMethod("getNotificationChannel.(Ljava/lang/String;)Landroid/app/NotificationChannel;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x000151DC File Offset: 0x000133DC
		[Register("getNotificationChannel", "(Ljava/lang/String;Ljava/lang/String;)Landroid/app/NotificationChannel;", "")]
		public unsafe NotificationChannel GetNotificationChannel(string channelId, string conversationId)
		{
			IntPtr intPtr = JNIEnv.NewString(channelId);
			IntPtr intPtr2 = JNIEnv.NewString(conversationId);
			NotificationChannel @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<NotificationChannel>(NotificationManagerCompat._members.InstanceMethods.InvokeAbstractObjectMethod("getNotificationChannel.(Ljava/lang/String;Ljava/lang/String;)Landroid/app/NotificationChannel;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @object;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0001526C File Offset: 0x0001346C
		[Register("getNotificationChannelCompat", "(Ljava/lang/String;)Landroidx/core/app/NotificationChannelCompat;", "")]
		public unsafe NotificationChannelCompat GetNotificationChannelCompat(string channelId)
		{
			IntPtr intPtr = JNIEnv.NewString(channelId);
			NotificationChannelCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<NotificationChannelCompat>(NotificationManagerCompat._members.InstanceMethods.InvokeAbstractObjectMethod("getNotificationChannelCompat.(Ljava/lang/String;)Landroidx/core/app/NotificationChannelCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x000152D8 File Offset: 0x000134D8
		[Register("getNotificationChannelCompat", "(Ljava/lang/String;Ljava/lang/String;)Landroidx/core/app/NotificationChannelCompat;", "")]
		public unsafe NotificationChannelCompat GetNotificationChannelCompat(string channelId, string conversationId)
		{
			IntPtr intPtr = JNIEnv.NewString(channelId);
			IntPtr intPtr2 = JNIEnv.NewString(conversationId);
			NotificationChannelCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<NotificationChannelCompat>(NotificationManagerCompat._members.InstanceMethods.InvokeAbstractObjectMethod("getNotificationChannelCompat.(Ljava/lang/String;Ljava/lang/String;)Landroidx/core/app/NotificationChannelCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return @object;
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00015368 File Offset: 0x00013568
		[Register("getNotificationChannelGroup", "(Ljava/lang/String;)Landroid/app/NotificationChannelGroup;", "")]
		public unsafe NotificationChannelGroup GetNotificationChannelGroup(string channelGroupId)
		{
			IntPtr intPtr = JNIEnv.NewString(channelGroupId);
			NotificationChannelGroup @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<NotificationChannelGroup>(NotificationManagerCompat._members.InstanceMethods.InvokeAbstractObjectMethod("getNotificationChannelGroup.(Ljava/lang/String;)Landroid/app/NotificationChannelGroup;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x000153D4 File Offset: 0x000135D4
		[Register("getNotificationChannelGroupCompat", "(Ljava/lang/String;)Landroidx/core/app/NotificationChannelGroupCompat;", "")]
		public unsafe NotificationChannelGroupCompat GetNotificationChannelGroupCompat(string channelGroupId)
		{
			IntPtr intPtr = JNIEnv.NewString(channelGroupId);
			NotificationChannelGroupCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<NotificationChannelGroupCompat>(NotificationManagerCompat._members.InstanceMethods.InvokeAbstractObjectMethod("getNotificationChannelGroupCompat.(Ljava/lang/String;)Landroidx/core/app/NotificationChannelGroupCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00015440 File Offset: 0x00013640
		[Register("notify", "(ILandroid/app/Notification;)V", "")]
		public unsafe void Notify(int id, Notification notification)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(id);
				ptr[1] = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				NotificationManagerCompat._members.InstanceMethods.InvokeAbstractVoidMethod("notify.(ILandroid/app/Notification;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(notification);
			}
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x000154B8 File Offset: 0x000136B8
		[Register("notify", "(Ljava/lang/String;ILandroid/app/Notification;)V", "")]
		public unsafe void Notify(string tag, int id, Notification notification)
		{
			IntPtr intPtr = JNIEnv.NewString(tag);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(id);
				ptr[2] = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
				NotificationManagerCompat._members.InstanceMethods.InvokeAbstractVoidMethod("notify.(Ljava/lang/String;ILandroid/app/Notification;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(notification);
			}
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00015554 File Offset: 0x00013754
		[Register("notify", "(Ljava/util/List;)V", "")]
		public unsafe void Notify(IList<NotificationManagerCompat.NotificationWithIdAndTag> notificationWithIdAndTags)
		{
			IntPtr intPtr = JavaList<NotificationManagerCompat.NotificationWithIdAndTag>.ToLocalJniHandle(notificationWithIdAndTags);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				NotificationManagerCompat._members.InstanceMethods.InvokeAbstractVoidMethod("notify.(Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(notificationWithIdAndTags);
			}
		}

		// Token: 0x040001D2 RID: 466
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/NotificationManagerCompat", typeof(NotificationManagerCompat));

		// Token: 0x0200007E RID: 126
		[Register("androidx/core/app/NotificationManagerCompat$NotificationWithIdAndTag", DoNotGenerateAcw = true)]
		public class NotificationWithIdAndTag : Java.Lang.Object
		{
			// Token: 0x17000134 RID: 308
			// (get) Token: 0x060006FE RID: 1790 RVA: 0x000155D4 File Offset: 0x000137D4
			internal static IntPtr class_ref
			{
				get
				{
					return NotificationManagerCompat.NotificationWithIdAndTag._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x060006FF RID: 1791 RVA: 0x000155F8 File Offset: 0x000137F8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return NotificationManagerCompat.NotificationWithIdAndTag._members;
				}
			}

			// Token: 0x17000136 RID: 310
			// (get) Token: 0x06000700 RID: 1792 RVA: 0x00015600 File Offset: 0x00013800
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return NotificationManagerCompat.NotificationWithIdAndTag._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000137 RID: 311
			// (get) Token: 0x06000701 RID: 1793 RVA: 0x00015624 File Offset: 0x00013824
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return NotificationManagerCompat.NotificationWithIdAndTag._members.ManagedPeerType;
				}
			}

			// Token: 0x06000702 RID: 1794 RVA: 0x00002384 File Offset: 0x00000584
			protected NotificationWithIdAndTag(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000703 RID: 1795 RVA: 0x00015630 File Offset: 0x00013830
			[Register(".ctor", "(ILandroid/app/Notification;)V", "")]
			public unsafe NotificationWithIdAndTag(int id, Notification notification) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(id);
					ptr[1] = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
					base.SetHandle(NotificationManagerCompat.NotificationWithIdAndTag._members.InstanceMethods.StartCreateInstance("(ILandroid/app/Notification;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					NotificationManagerCompat.NotificationWithIdAndTag._members.InstanceMethods.FinishCreateInstance("(ILandroid/app/Notification;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(notification);
				}
			}

			// Token: 0x06000704 RID: 1796 RVA: 0x000156F0 File Offset: 0x000138F0
			[Register(".ctor", "(Ljava/lang/String;ILandroid/app/Notification;)V", "")]
			public unsafe NotificationWithIdAndTag(string tag, int id, Notification notification) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				IntPtr intPtr = JNIEnv.NewString(tag);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ptr[1] = new JniArgumentValue(id);
					ptr[2] = new JniArgumentValue((notification == null) ? IntPtr.Zero : notification.Handle);
					base.SetHandle(NotificationManagerCompat.NotificationWithIdAndTag._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;ILandroid/app/Notification;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					NotificationManagerCompat.NotificationWithIdAndTag._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;ILandroid/app/Notification;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(notification);
				}
			}

			// Token: 0x040001D3 RID: 467
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/NotificationManagerCompat$NotificationWithIdAndTag", typeof(NotificationManagerCompat.NotificationWithIdAndTag));
		}
	}
}
