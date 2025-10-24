using System;

namespace Mono.Net.Security
{
	// Token: 0x02000011 RID: 17
	internal class AsyncReadRequest : AsyncReadOrWriteRequest
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00002E02 File Offset: 0x00001002
		public AsyncReadRequest(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) : base(parent, sync, buffer, offset, size)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002E14 File Offset: 0x00001014
		protected override AsyncOperationStatus Run(AsyncOperationStatus status)
		{
			ValueTuple<int, bool> valueTuple = base.Parent.ProcessRead(base.UserBuffer);
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
			if (item2 && base.CurrentSize == 0)
			{
				return AsyncOperationStatus.Continue;
			}
			base.UserResult = base.CurrentSize;
			return AsyncOperationStatus.Complete;
		}
	}
}
