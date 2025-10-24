using System;
using System.Collections.Generic;
using System.Threading;

namespace System.Net
{
	// Token: 0x02000155 RID: 341
	internal static class NclUtilities
	{
		// Token: 0x0600095D RID: 2397 RVA: 0x0003344B File Offset: 0x0003164B
		internal static bool IsFatal(Exception exception)
		{
			return exception != null && (exception is OutOfMemoryException || exception is StackOverflowException || exception is ThreadAbortException);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00033470 File Offset: 0x00031670
		internal static bool IsAddressLocal(IPAddress ipAddress)
		{
			IPAddress[] localAddresses = NclUtilities.LocalAddresses;
			for (int i = 0; i < localAddresses.Length; i++)
			{
				if (ipAddress.Equals(localAddresses[i], false))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x000334A0 File Offset: 0x000316A0
		private static IPHostEntry GetLocalHost()
		{
			return Dns.GetHostByName(Dns.GetHostName());
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x000334AC File Offset: 0x000316AC
		internal static IPAddress[] LocalAddresses
		{
			get
			{
				IPAddress[] array = NclUtilities._LocalAddresses;
				if (array != null)
				{
					return array;
				}
				object localAddressesLock = NclUtilities.LocalAddressesLock;
				IPAddress[] result;
				lock (localAddressesLock)
				{
					array = NclUtilities._LocalAddresses;
					if (array != null)
					{
						result = array;
					}
					else
					{
						List<IPAddress> list = new List<IPAddress>();
						try
						{
							IPHostEntry localHost = NclUtilities.GetLocalHost();
							if (localHost != null)
							{
								if (localHost.HostName != null)
								{
									int num = localHost.HostName.IndexOf('.');
									if (num != -1)
									{
										NclUtilities._LocalDomainName = localHost.HostName.Substring(num);
									}
								}
								IPAddress[] addressList = localHost.AddressList;
								if (addressList != null)
								{
									foreach (IPAddress item in addressList)
									{
										list.Add(item);
									}
								}
							}
						}
						catch
						{
						}
						array = new IPAddress[list.Count];
						int num2 = 0;
						foreach (IPAddress ipaddress in list)
						{
							array[num2] = ipaddress;
							num2++;
						}
						NclUtilities._LocalAddresses = array;
						result = array;
					}
				}
				return result;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x000335EC File Offset: 0x000317EC
		private static object LocalAddressesLock
		{
			get
			{
				if (NclUtilities._LocalAddressesLock == null)
				{
					Interlocked.CompareExchange(ref NclUtilities._LocalAddressesLock, new object(), null);
				}
				return NclUtilities._LocalAddressesLock;
			}
		}

		// Token: 0x040006DE RID: 1758
		private static volatile IPAddress[] _LocalAddresses;

		// Token: 0x040006DF RID: 1759
		private static object _LocalAddressesLock;

		// Token: 0x040006E0 RID: 1760
		internal static string _LocalDomainName;
	}
}
