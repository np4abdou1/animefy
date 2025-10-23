using System;
using System.ComponentModel;

namespace System.Net
{
	/// <summary>Provides data for the <see cref="E:System.Net.WebClient.DownloadProgressChanged" /> event of a <see cref="T:System.Net.WebClient" />.</summary>
	// Token: 0x02000147 RID: 327
	public class DownloadProgressChangedEventArgs : ProgressChangedEventArgs
	{
		// Token: 0x06000942 RID: 2370 RVA: 0x00033349 File Offset: 0x00031549
		internal DownloadProgressChangedEventArgs(int progressPercentage, object userToken, long bytesReceived, long totalBytesToReceive) : base(progressPercentage, userToken)
		{
			this.<BytesReceived>k__BackingField = bytesReceived;
			this.<TotalBytesToReceive>k__BackingField = totalBytesToReceive;
		}
	}
}
