using System;

namespace System.Net
{
	/// <summary>Defines status codes for the <see cref="T:System.Net.WebException" /> class.</summary>
	// Token: 0x02000161 RID: 353
	public enum WebExceptionStatus
	{
		/// <summary>No error was encountered.</summary>
		// Token: 0x04000707 RID: 1799
		Success,
		/// <summary>The name resolver service could not resolve the host name.</summary>
		// Token: 0x04000708 RID: 1800
		NameResolutionFailure,
		/// <summary>The remote service point could not be contacted at the transport level.</summary>
		// Token: 0x04000709 RID: 1801
		ConnectFailure,
		/// <summary>A complete response was not received from the remote server.</summary>
		// Token: 0x0400070A RID: 1802
		ReceiveFailure,
		/// <summary>A complete request could not be sent to the remote server.</summary>
		// Token: 0x0400070B RID: 1803
		SendFailure,
		/// <summary>The request was a piplined request and the connection was closed before the response was received.</summary>
		// Token: 0x0400070C RID: 1804
		PipelineFailure,
		/// <summary>The request was canceled, the <see cref="M:System.Net.WebRequest.Abort" /> method was called, or an unclassifiable error occurred. This is the default value for <see cref="P:System.Net.WebException.Status" />.</summary>
		// Token: 0x0400070D RID: 1805
		RequestCanceled,
		/// <summary>The response received from the server was complete but indicated a protocol-level error. For example, an HTTP protocol error such as 401 Access Denied would use this status.</summary>
		// Token: 0x0400070E RID: 1806
		ProtocolError,
		/// <summary>The connection was prematurely closed.</summary>
		// Token: 0x0400070F RID: 1807
		ConnectionClosed,
		/// <summary>A server certificate could not be validated.</summary>
		// Token: 0x04000710 RID: 1808
		TrustFailure,
		/// <summary>An error occurred while establishing a connection using SSL.</summary>
		// Token: 0x04000711 RID: 1809
		SecureChannelFailure,
		/// <summary>The server response was not a valid HTTP response.</summary>
		// Token: 0x04000712 RID: 1810
		ServerProtocolViolation,
		/// <summary>The connection for a request that specifies the Keep-alive header was closed unexpectedly.</summary>
		// Token: 0x04000713 RID: 1811
		KeepAliveFailure,
		/// <summary>An internal asynchronous request is pending.</summary>
		// Token: 0x04000714 RID: 1812
		Pending,
		/// <summary>No response was received during the time-out period for a request.</summary>
		// Token: 0x04000715 RID: 1813
		Timeout,
		/// <summary>The name resolver service could not resolve the proxy host name.</summary>
		// Token: 0x04000716 RID: 1814
		ProxyNameResolutionFailure,
		/// <summary>An exception of unknown type has occurred.</summary>
		// Token: 0x04000717 RID: 1815
		UnknownError,
		/// <summary>A message was received that exceeded the specified limit when sending a request or receiving a response from the server.</summary>
		// Token: 0x04000718 RID: 1816
		MessageLengthLimitExceeded,
		/// <summary>The specified cache entry was not found.</summary>
		// Token: 0x04000719 RID: 1817
		CacheEntryNotFound,
		/// <summary>The request was not permitted by the cache policy. In general, this occurs when a request is not cacheable and the effective policy prohibits sending the request to the server. You might receive this status if a request method implies the presence of a request body, a request method requires direct interaction with the server, or a request contains a conditional header.</summary>
		// Token: 0x0400071A RID: 1818
		RequestProhibitedByCachePolicy,
		/// <summary>This request was not permitted by the proxy.</summary>
		// Token: 0x0400071B RID: 1819
		RequestProhibitedByProxy
	}
}
