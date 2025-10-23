using System;
using System.ComponentModel;

namespace System.Net
{
	/// <summary>Provides data for the <see cref="E:System.Net.WebClient.UploadProgressChanged" /> event of a <see cref="T:System.Net.WebClient" />.</summary>
	// Token: 0x02000148 RID: 328
	public class UploadProgressChangedEventArgs : ProgressChangedEventArgs
	{
		// Token: 0x06000943 RID: 2371 RVA: 0x00033362 File Offset: 0x00031562
		internal UploadProgressChangedEventArgs(int progressPercentage, object userToken, long bytesSent, long totalBytesToSend, long bytesReceived, long totalBytesToReceive) : base(progressPercentage, userToken)
		{
			this.<BytesReceived>k__BackingField = bytesReceived;
			this.<TotalBytesToReceive>k__BackingField = totalBytesToReceive;
			this.<BytesSent>k__BackingField = bytesSent;
			this.<TotalBytesToSend>k__BackingField = totalBytesToSend;
		}
	}
}
