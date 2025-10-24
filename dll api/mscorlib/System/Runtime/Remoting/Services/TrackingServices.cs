using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Services
{
	/// <summary>Provides a way to register, unregister, and obtain a list of tracking handlers.</summary>
	// Token: 0x0200031F RID: 799
	[ComVisible(true)]
	public class TrackingServices
	{
		// Token: 0x06001A2D RID: 6701 RVA: 0x0007233C File Offset: 0x0007053C
		internal static void NotifyMarshaledObject(object obj, ObjRef or)
		{
			object syncRoot = TrackingServices._handlers.SyncRoot;
			ITrackingHandler[] array;
			lock (syncRoot)
			{
				if (TrackingServices._handlers.Count == 0)
				{
					return;
				}
				array = (ITrackingHandler[])TrackingServices._handlers.ToArray(typeof(ITrackingHandler));
			}
			for (int i = 0; i < array.Length; i++)
			{
				array[i].MarshaledObject(obj, or);
			}
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x000723BC File Offset: 0x000705BC
		internal static void NotifyUnmarshaledObject(object obj, ObjRef or)
		{
			object syncRoot = TrackingServices._handlers.SyncRoot;
			ITrackingHandler[] array;
			lock (syncRoot)
			{
				if (TrackingServices._handlers.Count == 0)
				{
					return;
				}
				array = (ITrackingHandler[])TrackingServices._handlers.ToArray(typeof(ITrackingHandler));
			}
			for (int i = 0; i < array.Length; i++)
			{
				array[i].UnmarshaledObject(obj, or);
			}
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x0007243C File Offset: 0x0007063C
		internal static void NotifyDisconnectedObject(object obj)
		{
			object syncRoot = TrackingServices._handlers.SyncRoot;
			ITrackingHandler[] array;
			lock (syncRoot)
			{
				if (TrackingServices._handlers.Count == 0)
				{
					return;
				}
				array = (ITrackingHandler[])TrackingServices._handlers.ToArray(typeof(ITrackingHandler));
			}
			for (int i = 0; i < array.Length; i++)
			{
				array[i].DisconnectedObject(obj);
			}
		}

		// Token: 0x04000AED RID: 2797
		private static ArrayList _handlers = new ArrayList();
	}
}
