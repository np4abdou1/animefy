using System;

namespace Mono.Net.Security
{
	// Token: 0x02000012 RID: 18
	internal class AsyncWriteRequest : AsyncReadOrWriteRequest
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00002E02 File Offset: 0x00001002
		public AsyncWriteRequest(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) : base(parent, sync, buffer, offset, size)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002E9C File Offset: 0x0000109C
		protected override AsyncOperationStatus Run(AsyncOperationStatus status)
		{
			if (base.UserBuffer.Size == 0)
			{
				base.UserResult = base.CurrentSize;
				return AsyncOperationStatus.Complete;
			}
			ValueTuple<int, bool> valueTuple = base.Parent.ProcessWrite(base.UserBuffer);
			int item = valueTuple.Item1;
			bool item2 = valueTuple.Item2;
			if (item < 0)
			{
				base.UserResult = -1;
				return AsyncOperationStatus.Complete;
			}
			base.CurrentSize += item;
			base.UserBuffer.Offset += item;
			base.UserBuffer.Size -= item;
			if (item2)
			{
				return AsyncOperationStatus.Continue;
			}
			base.UserResult = base.CurrentSize;
			return AsyncOperationStatus.Complete;
		}
	}
}
