using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using Java.Interop;

namespace Android.Runtime
{
	// Token: 0x020002BB RID: 699
	internal class AndroidObjectReferenceManager : JniRuntime.JniObjectReferenceManager
	{
		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001AA9 RID: 6825 RVA: 0x000451FB File Offset: 0x000433FB
		public override int GlobalReferenceCount
		{
			get
			{
				return RuntimeNativeMethods._monodroid_gref_get();
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001AAA RID: 6826 RVA: 0x00045202 File Offset: 0x00043402
		public override int WeakGlobalReferenceCount
		{
			get
			{
				return RuntimeNativeMethods._monodroid_weak_gref_get();
			}
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x0004520C File Offset: 0x0004340C
		public override JniObjectReference CreateLocalReference(JniObjectReference value, ref int localReferenceCount)
		{
			JniObjectReference result = base.CreateLocalReference(value, ref localReferenceCount);
			if (Logger.LogLocalRef)
			{
				string name = Thread.CurrentThread.Name;
				int managedThreadId = Thread.CurrentThread.ManagedThreadId;
				StringBuilder from = new StringBuilder(new StackTrace(true).ToString());
				RuntimeNativeMethods._monodroid_lref_log_new(localReferenceCount, result.Handle, 76, name, managedThreadId, from, 1);
			}
			return result;
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x00045268 File Offset: 0x00043468
		public override void DeleteLocalReference(ref JniObjectReference value, ref int localReferenceCount)
		{
			if (Logger.LogLocalRef)
			{
				string name = Thread.CurrentThread.Name;
				int managedThreadId = Thread.CurrentThread.ManagedThreadId;
				StringBuilder from = new StringBuilder(new StackTrace(true).ToString());
				RuntimeNativeMethods._monodroid_lref_log_delete(localReferenceCount - 1, value.Handle, 76, name, managedThreadId, from, 1);
			}
			base.DeleteLocalReference(ref value, ref localReferenceCount);
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x000452C0 File Offset: 0x000434C0
		public override void CreatedLocalReference(JniObjectReference value, ref int localReferenceCount)
		{
			base.CreatedLocalReference(value, ref localReferenceCount);
			if (Logger.LogLocalRef)
			{
				string name = Thread.CurrentThread.Name;
				int managedThreadId = Thread.CurrentThread.ManagedThreadId;
				StringBuilder from = new StringBuilder(new StackTrace(true).ToString());
				RuntimeNativeMethods._monodroid_lref_log_new(localReferenceCount, value.Handle, 76, name, managedThreadId, from, 1);
			}
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x00045318 File Offset: 0x00043518
		public override void WriteGlobalReferenceLine(string format, params object[] args)
		{
			RuntimeNativeMethods._monodroid_gref_log(string.Format(format, args));
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x00045328 File Offset: 0x00043528
		public override JniObjectReference CreateGlobalReference(JniObjectReference value)
		{
			JniObjectReference result = base.CreateGlobalReference(value);
			bool logGlobalRef = Logger.LogGlobalRef;
			byte curType = logGlobalRef ? AndroidObjectReferenceManager.GetObjectRefType(value.Type) : 42;
			byte newType = logGlobalRef ? AndroidObjectReferenceManager.GetObjectRefType(result.Type) : 42;
			string threadName = logGlobalRef ? Thread.CurrentThread.Name : null;
			int threadId = logGlobalRef ? Thread.CurrentThread.ManagedThreadId : 0;
			StringBuilder from = logGlobalRef ? new StringBuilder(new StackTrace(true).ToString()) : null;
			int num = RuntimeNativeMethods._monodroid_gref_log_new(value.Handle, curType, result.Handle, newType, threadName, threadId, from, 1);
			if (num >= JNIEnvInit.gref_gc_threshold)
			{
				Logger.Log(LogLevel.Info, "monodroid-gc", num.ToString() + " outstanding GREFs. Performing a full GC!");
				GC.Collect();
			}
			return result;
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x000453EC File Offset: 0x000435EC
		private static byte GetObjectRefType(JniObjectReferenceType type)
		{
			switch (type)
			{
			case JniObjectReferenceType.Invalid:
				return 73;
			case JniObjectReferenceType.Local:
				return 76;
			case JniObjectReferenceType.Global:
				return 71;
			case JniObjectReferenceType.WeakGlobal:
				return 87;
			default:
				return 42;
			}
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x00045414 File Offset: 0x00043614
		public override void DeleteGlobalReference(ref JniObjectReference value)
		{
			bool logGlobalRef = Logger.LogGlobalRef;
			byte type = logGlobalRef ? AndroidObjectReferenceManager.GetObjectRefType(value.Type) : 42;
			string threadName = logGlobalRef ? Thread.CurrentThread.Name : null;
			int threadId = logGlobalRef ? Thread.CurrentThread.ManagedThreadId : 0;
			StringBuilder from = logGlobalRef ? new StringBuilder(new StackTrace(true).ToString()) : null;
			RuntimeNativeMethods._monodroid_gref_log_delete(value.Handle, type, threadName, threadId, from, 1);
			base.DeleteGlobalReference(ref value);
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x00045488 File Offset: 0x00043688
		public override void DeleteWeakGlobalReference(ref JniObjectReference value)
		{
			bool logGlobalRef = Logger.LogGlobalRef;
			byte type = logGlobalRef ? AndroidObjectReferenceManager.GetObjectRefType(value.Type) : 42;
			string threadName = logGlobalRef ? Thread.CurrentThread.Name : null;
			int threadId = logGlobalRef ? Thread.CurrentThread.ManagedThreadId : 0;
			StringBuilder from = logGlobalRef ? new StringBuilder(new StackTrace(true).ToString()) : null;
			RuntimeNativeMethods._monodroid_weak_gref_delete(value.Handle, type, threadName, threadId, from, 1);
			base.DeleteWeakGlobalReference(ref value);
		}
	}
}
