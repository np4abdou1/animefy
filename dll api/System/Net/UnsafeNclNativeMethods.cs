using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Net
{
	// Token: 0x02000194 RID: 404
	internal static class UnsafeNclNativeMethods
	{
		// Token: 0x02000195 RID: 405
		internal static class HttpApi
		{
			// Token: 0x02000196 RID: 406
			internal static class HTTP_REQUEST_HEADER_ID
			{
				// Token: 0x06000B13 RID: 2835 RVA: 0x0003A56F File Offset: 0x0003876F
				internal static string ToString(int position)
				{
					return UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID.m_Strings[position];
				}

				// Token: 0x04000801 RID: 2049
				private static string[] m_Strings = new string[]
				{
					"Cache-Control",
					"Connection",
					"Date",
					"Keep-Alive",
					"Pragma",
					"Trailer",
					"Transfer-Encoding",
					"Upgrade",
					"Via",
					"Warning",
					"Allow",
					"Content-Length",
					"Content-Type",
					"Content-Encoding",
					"Content-Language",
					"Content-Location",
					"Content-MD5",
					"Content-Range",
					"Expires",
					"Last-Modified",
					"Accept",
					"Accept-Charset",
					"Accept-Encoding",
					"Accept-Language",
					"Authorization",
					"Cookie",
					"Expect",
					"From",
					"Host",
					"If-Match",
					"If-Modified-Since",
					"If-None-Match",
					"If-Range",
					"If-Unmodified-Since",
					"Max-Forwards",
					"Proxy-Authorization",
					"Referer",
					"Range",
					"Te",
					"Translate",
					"User-Agent"
				};
			}
		}

		// Token: 0x02000197 RID: 407
		internal static class SecureStringHelper
		{
			// Token: 0x06000B15 RID: 2837 RVA: 0x0003A6FC File Offset: 0x000388FC
			internal static string CreateString(SecureString secureString)
			{
				IntPtr intPtr = IntPtr.Zero;
				if (secureString == null || secureString.Length == 0)
				{
					return string.Empty;
				}
				string result;
				try
				{
					intPtr = Marshal.SecureStringToGlobalAllocUnicode(secureString);
					result = Marshal.PtrToStringUni(intPtr);
				}
				finally
				{
					if (intPtr != IntPtr.Zero)
					{
						Marshal.ZeroFreeGlobalAllocUnicode(intPtr);
					}
				}
				return result;
			}

			// Token: 0x06000B16 RID: 2838 RVA: 0x0003A758 File Offset: 0x00038958
			internal unsafe static SecureString CreateSecureString(string plainString)
			{
				if (plainString == null || plainString.Length == 0)
				{
					return new SecureString();
				}
				SecureString result;
				fixed (string text = plainString)
				{
					char* ptr = text;
					if (ptr != null)
					{
						ptr += RuntimeHelpers.OffsetToStringData / 2;
					}
					result = new SecureString(ptr, plainString.Length);
				}
				return result;
			}
		}
	}
}
