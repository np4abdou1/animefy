using System;
using Android.Runtime;
using Java.Interop;
using Java.IO;

namespace Android.OS
{
	// Token: 0x020001E6 RID: 486
	[Register("android/os/IBinder", "", "Android.OS.IBinderInvoker")]
	public interface IBinder : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700038B RID: 907
		// (get) Token: 0x060011AF RID: 4527
		string InterfaceDescriptor { get; }

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x060011B0 RID: 4528
		bool IsBinderAlive { get; }

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x060011B1 RID: 4529 RVA: 0x0002ED0A File Offset: 0x0002CF0A
		int SuggestedMaxIpcSizeBytes
		{
			get
			{
				return IBinder._members.StaticMethods.InvokeInt32Method("getSuggestedMaxIpcSizeBytes.()I", null);
			}
		}

		// Token: 0x060011B2 RID: 4530
		void Dump(FileDescriptor fd, string[] args);

		// Token: 0x060011B3 RID: 4531
		void DumpAsync(FileDescriptor fd, string[] args);

		// Token: 0x060011B4 RID: 4532
		void LinkToDeath(IBinderDeathRecipient recipient, int flags);

		// Token: 0x060011B5 RID: 4533
		bool PingBinder();

		// Token: 0x060011B6 RID: 4534
		IInterface QueryLocalInterface(string descriptor);

		// Token: 0x060011B7 RID: 4535
		bool Transact(int code, Parcel data, Parcel reply, [GeneratedEnum] TransactionFlags flags);

		// Token: 0x060011B8 RID: 4536
		bool UnlinkToDeath(IBinderDeathRecipient recipient, int flags);

		// Token: 0x040007E2 RID: 2018
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/os/IBinder", typeof(IBinder), true);
	}
}
