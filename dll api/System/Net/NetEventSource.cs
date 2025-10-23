using System;
using System.Collections;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Net
{
	// Token: 0x0200010E RID: 270
	internal sealed class NetEventSource : EventSource
	{
		// Token: 0x060007AA RID: 1962 RVA: 0x0002BBAE File Offset: 0x00029DAE
		[NonEvent]
		public static void Enter(object thisOrContextObject, FormattableString formattableString = null, [CallerMemberName] string memberName = null)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Log.Enter(NetEventSource.IdOf(thisOrContextObject), memberName, (formattableString != null) ? NetEventSource.Format(formattableString) : "");
			}
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0002BBD8 File Offset: 0x00029DD8
		[NonEvent]
		public static void Enter(object thisOrContextObject, object arg0, [CallerMemberName] string memberName = null)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Log.Enter(NetEventSource.IdOf(thisOrContextObject), memberName, string.Format("({0})", NetEventSource.Format(arg0)));
			}
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0002BC02 File Offset: 0x00029E02
		[NonEvent]
		public static void Enter(object thisOrContextObject, object arg0, object arg1, object arg2, [CallerMemberName] string memberName = null)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Log.Enter(NetEventSource.IdOf(thisOrContextObject), memberName, string.Format("({0}, {1}, {2})", NetEventSource.Format(arg0), NetEventSource.Format(arg1), NetEventSource.Format(arg2)));
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0002BC39 File Offset: 0x00029E39
		[Event(1, Level = EventLevel.Informational, Keywords = (EventKeywords)4L)]
		private void Enter(string thisOrContextObject, string memberName, string parameters)
		{
			base.WriteEvent(1, thisOrContextObject, memberName ?? "(?)", parameters);
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0002BC4E File Offset: 0x00029E4E
		[NonEvent]
		public static void Exit(object thisOrContextObject, FormattableString formattableString = null, [CallerMemberName] string memberName = null)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Log.Exit(NetEventSource.IdOf(thisOrContextObject), memberName, (formattableString != null) ? NetEventSource.Format(formattableString) : "");
			}
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0002BC78 File Offset: 0x00029E78
		[NonEvent]
		public static void Exit(object thisOrContextObject, object arg0, [CallerMemberName] string memberName = null)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Log.Exit(NetEventSource.IdOf(thisOrContextObject), memberName, NetEventSource.Format(arg0).ToString());
			}
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x0002BC9D File Offset: 0x00029E9D
		[Event(2, Level = EventLevel.Informational, Keywords = (EventKeywords)4L)]
		private void Exit(string thisOrContextObject, string memberName, string result)
		{
			base.WriteEvent(2, thisOrContextObject, memberName ?? "(?)", result);
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0002BCB2 File Offset: 0x00029EB2
		[NonEvent]
		public static void Info(object thisOrContextObject, FormattableString formattableString = null, [CallerMemberName] string memberName = null)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Log.Info(NetEventSource.IdOf(thisOrContextObject), memberName, (formattableString != null) ? NetEventSource.Format(formattableString) : "");
			}
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x0002BCDC File Offset: 0x00029EDC
		[NonEvent]
		public static void Info(object thisOrContextObject, object message, [CallerMemberName] string memberName = null)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Log.Info(NetEventSource.IdOf(thisOrContextObject), memberName, NetEventSource.Format(message).ToString());
			}
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0002BD01 File Offset: 0x00029F01
		[Event(4, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		private void Info(string thisOrContextObject, string memberName, string message)
		{
			base.WriteEvent(4, thisOrContextObject, memberName ?? "(?)", message);
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x0002BD16 File Offset: 0x00029F16
		[NonEvent]
		public static void Error(object thisOrContextObject, object message, [CallerMemberName] string memberName = null)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Log.ErrorMessage(NetEventSource.IdOf(thisOrContextObject), memberName, NetEventSource.Format(message).ToString());
			}
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x0002BD3B File Offset: 0x00029F3B
		[Event(5, Level = EventLevel.Warning, Keywords = (EventKeywords)1L)]
		private void ErrorMessage(string thisOrContextObject, string memberName, string message)
		{
			base.WriteEvent(5, thisOrContextObject, memberName ?? "(?)", message);
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x0002BD50 File Offset: 0x00029F50
		[NonEvent]
		public static void Fail(object thisOrContextObject, object message, [CallerMemberName] string memberName = null)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Log.CriticalFailure(NetEventSource.IdOf(thisOrContextObject), memberName, NetEventSource.Format(message).ToString());
			}
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0002BD75 File Offset: 0x00029F75
		[Event(6, Level = EventLevel.Critical, Keywords = (EventKeywords)2L)]
		private void CriticalFailure(string thisOrContextObject, string memberName, string message)
		{
			base.WriteEvent(6, thisOrContextObject, memberName ?? "(?)", message);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0002BD8A File Offset: 0x00029F8A
		[NonEvent]
		public static void Associate(object first, object second, [CallerMemberName] string memberName = null)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Log.Associate(NetEventSource.IdOf(first), memberName, NetEventSource.IdOf(first), NetEventSource.IdOf(second));
			}
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x0002BDB0 File Offset: 0x00029FB0
		[Event(3, Level = EventLevel.Informational, Keywords = (EventKeywords)1L, Message = "[{2}]<-->[{3}]")]
		private void Associate(string thisOrContextObject, string memberName, string first, string second)
		{
			this.WriteEvent(3, thisOrContextObject, memberName ?? "(?)", first, second);
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x0002BDC7 File Offset: 0x00029FC7
		public new static bool IsEnabled
		{
			get
			{
				return NetEventSource.Log.IsEnabled();
			}
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0002BDD4 File Offset: 0x00029FD4
		[NonEvent]
		public static string IdOf(object value)
		{
			if (value == null)
			{
				return "(null)";
			}
			return value.GetType().Name + "#" + NetEventSource.GetHashCode(value).ToString();
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0002BE0D File Offset: 0x0002A00D
		[NonEvent]
		public static int GetHashCode(object value)
		{
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x0002BE1C File Offset: 0x0002A01C
		[NonEvent]
		public static object Format(object value)
		{
			if (value == null)
			{
				return "(null)";
			}
			string text = null;
			if (text != null)
			{
				return text;
			}
			Array array = value as Array;
			if (array != null)
			{
				return string.Format("{0}[{1}]", array.GetType().GetElementType(), ((Array)value).Length);
			}
			ICollection collection = value as ICollection;
			if (collection != null)
			{
				return string.Format("{0}({1})", collection.GetType().Name, collection.Count);
			}
			SafeHandle safeHandle = value as SafeHandle;
			if (safeHandle != null)
			{
				return string.Format("{0}:{1}(0x{2:X})", safeHandle.GetType().Name, safeHandle.GetHashCode(), safeHandle.DangerousGetHandle());
			}
			if (value is IntPtr)
			{
				return string.Format("0x{0:X}", value);
			}
			string text2 = value.ToString();
			if (text2 == null || text2 == value.GetType().FullName)
			{
				return NetEventSource.IdOf(value);
			}
			return value;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x0002BF08 File Offset: 0x0002A108
		[NonEvent]
		private static string Format(FormattableString s)
		{
			switch (s.ArgumentCount)
			{
			case 0:
				return s.Format;
			case 1:
				return string.Format(s.Format, NetEventSource.Format(s.GetArgument(0)));
			case 2:
				return string.Format(s.Format, NetEventSource.Format(s.GetArgument(0)), NetEventSource.Format(s.GetArgument(1)));
			case 3:
				return string.Format(s.Format, NetEventSource.Format(s.GetArgument(0)), NetEventSource.Format(s.GetArgument(1)), NetEventSource.Format(s.GetArgument(2)));
			default:
			{
				object[] arguments = s.GetArguments();
				object[] array = new object[arguments.Length];
				for (int i = 0; i < arguments.Length; i++)
				{
					array[i] = NetEventSource.Format(arguments[i]);
				}
				return string.Format(s.Format, array);
			}
			}
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x0002BFDC File Offset: 0x0002A1DC
		[NonEvent]
		private unsafe void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4)
		{
			if (base.IsEnabled())
			{
				if (arg1 == null)
				{
					arg1 = "";
				}
				if (arg2 == null)
				{
					arg2 = "";
				}
				if (arg3 == null)
				{
					arg3 = "";
				}
				if (arg4 == null)
				{
					arg4 = "";
				}
				fixed (string text = arg1)
				{
					char* ptr = text;
					if (ptr != null)
					{
						ptr += RuntimeHelpers.OffsetToStringData / 2;
					}
					fixed (string text2 = arg2)
					{
						char* ptr2 = text2;
						if (ptr2 != null)
						{
							ptr2 += RuntimeHelpers.OffsetToStringData / 2;
						}
						fixed (string text3 = arg3)
						{
							char* ptr3 = text3;
							if (ptr3 != null)
							{
								ptr3 += RuntimeHelpers.OffsetToStringData / 2;
							}
							fixed (string text4 = arg4)
							{
								char* ptr4 = text4;
								if (ptr4 != null)
								{
									ptr4 += RuntimeHelpers.OffsetToStringData / 2;
								}
								EventSource.EventData* ptr5 = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(EventSource.EventData))];
								*ptr5 = new EventSource.EventData
								{
									DataPointer = (IntPtr)((void*)ptr),
									Size = (arg1.Length + 1) * 2
								};
								ptr5[1] = new EventSource.EventData
								{
									DataPointer = (IntPtr)((void*)ptr2),
									Size = (arg2.Length + 1) * 2
								};
								ptr5[2] = new EventSource.EventData
								{
									DataPointer = (IntPtr)((void*)ptr3),
									Size = (arg3.Length + 1) * 2
								};
								ptr5[3] = new EventSource.EventData
								{
									DataPointer = (IntPtr)((void*)ptr4),
									Size = (arg4.Length + 1) * 2
								};
								base.WriteEventCore(eventId, 4, ptr5);
							}
						}
					}
				}
			}
		}

		// Token: 0x0400051F RID: 1311
		public static readonly NetEventSource Log = new NetEventSource();

		// Token: 0x0200010F RID: 271
		public class Keywords
		{
			// Token: 0x04000520 RID: 1312
			public const EventKeywords Default = (EventKeywords)1L;

			// Token: 0x04000521 RID: 1313
			public const EventKeywords Debug = (EventKeywords)2L;

			// Token: 0x04000522 RID: 1314
			public const EventKeywords EnterExit = (EventKeywords)4L;
		}
	}
}
