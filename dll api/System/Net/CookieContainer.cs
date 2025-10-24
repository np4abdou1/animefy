using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Threading;

namespace System.Net
{
	/// <summary>Provides a container for a collection of <see cref="T:System.Net.CookieCollection" /> objects.</summary>
	// Token: 0x02000189 RID: 393
	[Serializable]
	public class CookieContainer
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Net.CookieContainer" /> class.</summary>
		// Token: 0x06000AA3 RID: 2723 RVA: 0x00038190 File Offset: 0x00036390
		public CookieContainer()
		{
			string domainName = IPGlobalProperties.InternalGetIPGlobalProperties().DomainName;
			if (domainName != null && domainName.Length > 1)
			{
				this.m_fqdnMyDomain = "." + domainName;
			}
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00038200 File Offset: 0x00036400
		private void AddRemoveDomain(string key, PathList value)
		{
			object syncRoot = this.m_domainTable.SyncRoot;
			lock (syncRoot)
			{
				if (value == null)
				{
					this.m_domainTable.Remove(key);
				}
				else
				{
					this.m_domainTable[key] = value;
				}
			}
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00038260 File Offset: 0x00036460
		internal void Add(Cookie cookie, bool throwOnError)
		{
			if (cookie.Value.Length <= this.m_maxCookieSize)
			{
				try
				{
					object syncRoot = this.m_domainTable.SyncRoot;
					PathList pathList;
					lock (syncRoot)
					{
						pathList = (PathList)this.m_domainTable[cookie.DomainKey];
						if (pathList == null)
						{
							pathList = new PathList();
							this.AddRemoveDomain(cookie.DomainKey, pathList);
						}
					}
					int cookiesCount = pathList.GetCookiesCount();
					syncRoot = pathList.SyncRoot;
					CookieCollection cookieCollection;
					lock (syncRoot)
					{
						cookieCollection = (CookieCollection)pathList[cookie.Path];
						if (cookieCollection == null)
						{
							cookieCollection = new CookieCollection();
							pathList[cookie.Path] = cookieCollection;
						}
					}
					if (cookie.Expired)
					{
						CookieCollection obj = cookieCollection;
						lock (obj)
						{
							int num = cookieCollection.IndexOf(cookie);
							if (num != -1)
							{
								cookieCollection.RemoveAt(num);
								this.m_count--;
							}
							goto IL_194;
						}
					}
					if (cookiesCount < this.m_maxCookiesPerDomain || this.AgeCookies(cookie.DomainKey))
					{
						if (this.m_count < this.m_maxCookies || this.AgeCookies(null))
						{
							CookieCollection obj = cookieCollection;
							lock (obj)
							{
								this.m_count += cookieCollection.InternalAdd(cookie, true);
							}
						}
					}
					IL_194:;
				}
				catch (Exception ex)
				{
					if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
					{
						throw;
					}
					if (throwOnError)
					{
						throw new CookieException(SR.GetString("An error occurred when adding a cookie to the container."), ex);
					}
				}
				return;
			}
			if (throwOnError)
			{
				throw new CookieException(SR.GetString("The value size of the cookie is '{0}'. This exceeds the configured maximum size, which is '{1}'.", new object[]
				{
					cookie.ToString(),
					this.m_maxCookieSize
				}));
			}
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x000384B8 File Offset: 0x000366B8
		private bool AgeCookies(string domain)
		{
			if (this.m_maxCookies == 0 || this.m_maxCookiesPerDomain == 0)
			{
				this.m_domainTable = new Hashtable();
				this.m_count = 0;
				return false;
			}
			int num = 0;
			DateTime dateTime = DateTime.MaxValue;
			CookieCollection cookieCollection = null;
			int num2 = 0;
			int num3 = 0;
			float num4 = 1f;
			if (this.m_count > this.m_maxCookies)
			{
				num4 = (float)this.m_maxCookies / (float)this.m_count;
			}
			object syncRoot = this.m_domainTable.SyncRoot;
			CookieCollection obj4;
			lock (syncRoot)
			{
				foreach (object obj in this.m_domainTable)
				{
					DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
					PathList pathList;
					if (domain == null)
					{
						string text = (string)dictionaryEntry.Key;
						pathList = (PathList)dictionaryEntry.Value;
					}
					else
					{
						pathList = (PathList)this.m_domainTable[domain];
					}
					num2 = 0;
					object syncRoot2 = pathList.SyncRoot;
					lock (syncRoot2)
					{
						foreach (object obj2 in pathList.Values)
						{
							CookieCollection cookieCollection2 = (CookieCollection)obj2;
							num3 = this.ExpireCollection(cookieCollection2);
							num += num3;
							this.m_count -= num3;
							num2 += cookieCollection2.Count;
							DateTime dateTime2;
							if (cookieCollection2.Count > 0 && (dateTime2 = cookieCollection2.TimeStamp(CookieCollection.Stamp.Check)) < dateTime)
							{
								cookieCollection = cookieCollection2;
								dateTime = dateTime2;
							}
						}
					}
					int num5 = Math.Min((int)((float)num2 * num4), Math.Min(this.m_maxCookiesPerDomain, this.m_maxCookies) - 1);
					if (num2 > num5)
					{
						syncRoot2 = pathList.SyncRoot;
						Array array;
						Array array2;
						lock (syncRoot2)
						{
							array = Array.CreateInstance(typeof(CookieCollection), pathList.Count);
							array2 = Array.CreateInstance(typeof(DateTime), pathList.Count);
							foreach (object obj3 in pathList.Values)
							{
								CookieCollection cookieCollection3 = (CookieCollection)obj3;
								array2.SetValue(cookieCollection3.TimeStamp(CookieCollection.Stamp.Check), num3);
								array.SetValue(cookieCollection3, num3);
								num3++;
							}
						}
						Array.Sort(array2, array);
						num3 = 0;
						for (int i = 0; i < array.Length; i++)
						{
							CookieCollection cookieCollection4 = (CookieCollection)array.GetValue(i);
							obj4 = cookieCollection4;
							lock (obj4)
							{
								while (num2 > num5 && cookieCollection4.Count > 0)
								{
									cookieCollection4.RemoveAt(0);
									num2--;
									this.m_count--;
									num++;
								}
							}
							if (num2 <= num5)
							{
								break;
							}
						}
						if (num2 > num5 && domain != null)
						{
							return false;
						}
					}
				}
			}
			if (domain != null)
			{
				return true;
			}
			if (num != 0)
			{
				return true;
			}
			if (dateTime == DateTime.MaxValue)
			{
				return false;
			}
			obj4 = cookieCollection;
			lock (obj4)
			{
				while (this.m_count >= this.m_maxCookies && cookieCollection.Count > 0)
				{
					cookieCollection.RemoveAt(0);
					this.m_count--;
				}
			}
			return true;
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x0003890C File Offset: 0x00036B0C
		private int ExpireCollection(CookieCollection cc)
		{
			int result;
			lock (cc)
			{
				int count = cc.Count;
				for (int i = count - 1; i >= 0; i--)
				{
					if (cc[i].Expired)
					{
						cc.RemoveAt(i);
					}
				}
				result = count - cc.Count;
			}
			return result;
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00038978 File Offset: 0x00036B78
		internal bool IsLocalDomain(string host)
		{
			int num = host.IndexOf('.');
			if (num == -1)
			{
				return true;
			}
			if (host == "127.0.0.1" || host == "::1" || host == "0:0:0:0:0:0:0:1")
			{
				return true;
			}
			if (string.Compare(this.m_fqdnMyDomain, 0, host, num, this.m_fqdnMyDomain.Length, StringComparison.OrdinalIgnoreCase) == 0)
			{
				return true;
			}
			string[] array = host.Split('.', StringSplitOptions.None);
			if (array != null && array.Length == 4 && array[0] == "127")
			{
				int i = 1;
				while (i < 4)
				{
					switch (array[i].Length)
					{
					case 1:
						break;
					case 2:
						goto IL_BB;
					case 3:
						if (array[i][2] >= '0' && array[i][2] <= '9')
						{
							goto IL_BB;
						}
						goto IL_F7;
					default:
						goto IL_F7;
					}
					IL_D5:
					if (array[i][0] >= '0' && array[i][0] <= '9')
					{
						i++;
						continue;
					}
					break;
					IL_BB:
					if (array[i][1] >= '0' && array[i][1] <= '9')
					{
						goto IL_D5;
					}
					break;
				}
				IL_F7:
				if (i == 4)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00038A84 File Offset: 0x00036C84
		internal CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow)
		{
			CookieCollection cookieCollection = new CookieCollection();
			CookieVariant variant = CookieVariant.Unknown;
			if (headerName == null)
			{
				variant = CookieVariant.Rfc2109;
			}
			else
			{
				for (int i = 0; i < CookieContainer.HeaderInfo.Length; i++)
				{
					if (string.Compare(headerName, CookieContainer.HeaderInfo[i].Name, StringComparison.OrdinalIgnoreCase) == 0)
					{
						variant = CookieContainer.HeaderInfo[i].Variant;
					}
				}
			}
			bool isLocalDomain = this.IsLocalDomain(uri.Host);
			try
			{
				CookieParser cookieParser = new CookieParser(setCookieHeader);
				for (;;)
				{
					Cookie cookie = cookieParser.Get();
					if (cookie == null)
					{
						goto IL_B0;
					}
					if (ValidationHelper.IsBlankString(cookie.Name))
					{
						if (isThrow)
						{
							break;
						}
					}
					else if (cookie.VerifySetDefaults(variant, uri, isLocalDomain, this.m_fqdnMyDomain, true, isThrow))
					{
						cookieCollection.InternalAdd(cookie, true);
					}
				}
				throw new CookieException(SR.GetString("Cookie format error."));
				IL_B0:;
			}
			catch (Exception ex)
			{
				if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
				{
					throw;
				}
				if (isThrow)
				{
					throw new CookieException(SR.GetString("An error occurred when parsing the Cookie header for Uri '{0}'.", new object[]
					{
						uri.AbsoluteUri
					}), ex);
				}
			}
			foreach (object obj in cookieCollection)
			{
				Cookie cookie2 = (Cookie)obj;
				this.Add(cookie2, isThrow);
			}
			return cookieCollection;
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00038BE8 File Offset: 0x00036DE8
		internal CookieCollection InternalGetCookies(Uri uri)
		{
			bool isSecure = uri.Scheme == Uri.UriSchemeHttps;
			int port = uri.Port;
			CookieCollection cookieCollection = new CookieCollection();
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			string host = uri.Host;
			list.Add(host);
			list.Add("." + host);
			int num = host.IndexOf('.');
			if (num == -1)
			{
				if (this.m_fqdnMyDomain != null && this.m_fqdnMyDomain.Length != 0)
				{
					list.Add(host + this.m_fqdnMyDomain);
					list.Add(this.m_fqdnMyDomain);
				}
			}
			else
			{
				list.Add(host.Substring(num));
				if (host.Length > 2)
				{
					int num2 = host.LastIndexOf('.', host.Length - 2);
					if (num2 > 0)
					{
						num2 = host.LastIndexOf('.', num2 - 1);
					}
					if (num2 != -1)
					{
						while (num < num2 && (num = host.IndexOf('.', num + 1)) != -1)
						{
							list2.Add(host.Substring(num));
						}
					}
				}
			}
			this.BuildCookieCollectionFromDomainMatches(uri, isSecure, port, cookieCollection, list, false);
			this.BuildCookieCollectionFromDomainMatches(uri, isSecure, port, cookieCollection, list2, true);
			return cookieCollection;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00038D1C File Offset: 0x00036F1C
		private void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, List<string> domainAttribute, bool matchOnlyPlainCookie)
		{
			for (int i = 0; i < domainAttribute.Count; i++)
			{
				bool flag = false;
				bool flag2 = false;
				object syncRoot = this.m_domainTable.SyncRoot;
				PathList pathList;
				lock (syncRoot)
				{
					pathList = (PathList)this.m_domainTable[domainAttribute[i]];
				}
				if (pathList != null)
				{
					syncRoot = pathList.SyncRoot;
					lock (syncRoot)
					{
						foreach (object obj in pathList)
						{
							DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
							string text = (string)dictionaryEntry.Key;
							if (uri.AbsolutePath.StartsWith(CookieParser.CheckQuoted(text)))
							{
								flag = true;
								CookieCollection cookieCollection = (CookieCollection)dictionaryEntry.Value;
								cookieCollection.TimeStamp(CookieCollection.Stamp.Set);
								this.MergeUpdateCollections(cookies, cookieCollection, port, isSecure, matchOnlyPlainCookie);
								if (text == "/")
								{
									flag2 = true;
								}
							}
							else if (flag)
							{
								break;
							}
						}
					}
					if (!flag2)
					{
						CookieCollection cookieCollection2 = (CookieCollection)pathList["/"];
						if (cookieCollection2 != null)
						{
							cookieCollection2.TimeStamp(CookieCollection.Stamp.Set);
							this.MergeUpdateCollections(cookies, cookieCollection2, port, isSecure, matchOnlyPlainCookie);
						}
					}
					if (pathList.Count == 0)
					{
						this.AddRemoveDomain(domainAttribute[i], null);
					}
				}
			}
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00038EB4 File Offset: 0x000370B4
		private void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly)
		{
			lock (source)
			{
				for (int i = 0; i < source.Count; i++)
				{
					bool flag2 = false;
					Cookie cookie = source[i];
					if (cookie.Expired)
					{
						source.RemoveAt(i);
						this.m_count--;
						i--;
					}
					else
					{
						if (!isPlainOnly || cookie.Variant == CookieVariant.Plain)
						{
							if (cookie.PortList != null)
							{
								int[] portList = cookie.PortList;
								for (int j = 0; j < portList.Length; j++)
								{
									if (portList[j] == port)
									{
										flag2 = true;
										break;
									}
								}
							}
							else
							{
								flag2 = true;
							}
						}
						if (cookie.Secure && !isSecure)
						{
							flag2 = false;
						}
						if (flag2)
						{
							destination.InternalAdd(cookie, false);
						}
					}
				}
			}
		}

		/// <summary>Gets the HTTP cookie header that contains the HTTP cookies that represent the <see cref="T:System.Net.Cookie" /> instances that are associated with a specific URI.</summary>
		/// <param name="uri">The URI of the <see cref="T:System.Net.Cookie" /> instances desired. </param>
		/// <returns>An HTTP cookie header, with strings representing <see cref="T:System.Net.Cookie" /> instances delimited by semicolons.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="uri" /> is <see langword="null" />. </exception>
		// Token: 0x06000AAD RID: 2733 RVA: 0x00038F90 File Offset: 0x00037190
		public string GetCookieHeader(Uri uri)
		{
			if (uri == null)
			{
				throw new ArgumentNullException("uri");
			}
			string text;
			return this.GetCookieHeader(uri, out text);
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00038FBC File Offset: 0x000371BC
		internal string GetCookieHeader(Uri uri, out string optCookie2)
		{
			CookieCollection cookieCollection = this.InternalGetCookies(uri);
			string text = string.Empty;
			string str = string.Empty;
			foreach (object obj in cookieCollection)
			{
				Cookie cookie = (Cookie)obj;
				text = text + str + cookie.ToString();
				str = "; ";
			}
			optCookie2 = (cookieCollection.IsOtherVersionSeen ? ("$Version=" + 1.ToString(NumberFormatInfo.InvariantInfo)) : string.Empty);
			return text;
		}

		// Token: 0x040007D3 RID: 2003
		private static readonly HeaderVariantInfo[] HeaderInfo = new HeaderVariantInfo[]
		{
			new HeaderVariantInfo("Set-Cookie", CookieVariant.Rfc2109),
			new HeaderVariantInfo("Set-Cookie2", CookieVariant.Rfc2965)
		};

		// Token: 0x040007D4 RID: 2004
		private Hashtable m_domainTable = new Hashtable();

		// Token: 0x040007D5 RID: 2005
		private int m_maxCookieSize = 4096;

		// Token: 0x040007D6 RID: 2006
		private int m_maxCookies = 300;

		// Token: 0x040007D7 RID: 2007
		private int m_maxCookiesPerDomain = 20;

		// Token: 0x040007D8 RID: 2008
		private int m_count;

		// Token: 0x040007D9 RID: 2009
		private string m_fqdnMyDomain = string.Empty;
	}
}
