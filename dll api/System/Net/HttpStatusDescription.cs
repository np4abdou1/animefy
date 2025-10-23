﻿using System;

namespace System.Net
{
	// Token: 0x0200010C RID: 268
	internal static class HttpStatusDescription
	{
		// Token: 0x060007A5 RID: 1957 RVA: 0x0002B6A6 File Offset: 0x000298A6
		internal static string Get(HttpStatusCode code)
		{
			return HttpStatusDescription.Get((int)code);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0002B6B0 File Offset: 0x000298B0
		internal static string Get(int code)
		{
			if (code <= 226)
			{
				switch (code)
				{
				case 100:
					return "Continue";
				case 101:
					return "Switching Protocols";
				case 102:
					return "Processing";
				case 103:
					return "Early Hints";
				default:
					switch (code)
					{
					case 200:
						return "OK";
					case 201:
						return "Created";
					case 202:
						return "Accepted";
					case 203:
						return "Non-Authoritative Information";
					case 204:
						return "No Content";
					case 205:
						return "Reset Content";
					case 206:
						return "Partial Content";
					case 207:
						return "Multi-Status";
					case 208:
						return "Already Reported";
					default:
						if (code == 226)
						{
							return "IM Used";
						}
						break;
					}
					break;
				}
			}
			else
			{
				switch (code)
				{
				case 300:
					return "Multiple Choices";
				case 301:
					return "Moved Permanently";
				case 302:
					return "Found";
				case 303:
					return "See Other";
				case 304:
					return "Not Modified";
				case 305:
					return "Use Proxy";
				case 306:
					break;
				case 307:
					return "Temporary Redirect";
				case 308:
					return "Permanent Redirect";
				default:
					switch (code)
					{
					case 400:
						return "Bad Request";
					case 401:
						return "Unauthorized";
					case 402:
						return "Payment Required";
					case 403:
						return "Forbidden";
					case 404:
						return "Not Found";
					case 405:
						return "Method Not Allowed";
					case 406:
						return "Not Acceptable";
					case 407:
						return "Proxy Authentication Required";
					case 408:
						return "Request Timeout";
					case 409:
						return "Conflict";
					case 410:
						return "Gone";
					case 411:
						return "Length Required";
					case 412:
						return "Precondition Failed";
					case 413:
						return "Request Entity Too Large";
					case 414:
						return "Request-Uri Too Long";
					case 415:
						return "Unsupported Media Type";
					case 416:
						return "Requested Range Not Satisfiable";
					case 417:
						return "Expectation Failed";
					case 418:
					case 419:
					case 420:
					case 425:
					case 427:
					case 430:
					case 432:
					case 433:
					case 434:
					case 435:
					case 436:
					case 437:
					case 438:
					case 439:
					case 440:
					case 441:
					case 442:
					case 443:
					case 444:
					case 445:
					case 446:
					case 447:
					case 448:
					case 449:
					case 450:
						break;
					case 421:
						return "Misdirected Request";
					case 422:
						return "Unprocessable Entity";
					case 423:
						return "Locked";
					case 424:
						return "Failed Dependency";
					case 426:
						return "Upgrade Required";
					case 428:
						return "Precondition Required";
					case 429:
						return "Too Many Requests";
					case 431:
						return "Request Header Fields Too Large";
					case 451:
						return "Unavailable For Legal Reasons";
					default:
						switch (code)
						{
						case 500:
							return "Internal Server Error";
						case 501:
							return "Not Implemented";
						case 502:
							return "Bad Gateway";
						case 503:
							return "Service Unavailable";
						case 504:
							return "Gateway Timeout";
						case 505:
							return "Http Version Not Supported";
						case 506:
							return "Variant Also Negotiates";
						case 507:
							return "Insufficient Storage";
						case 508:
							return "Loop Detected";
						case 510:
							return "Not Extended";
						case 511:
							return "Network Authentication Required";
						}
						break;
					}
					break;
				}
			}
			return null;
		}
	}
}
