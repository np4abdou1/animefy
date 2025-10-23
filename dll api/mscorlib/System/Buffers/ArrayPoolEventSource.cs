using System;
using System.Diagnostics.Tracing;

namespace System.Buffers
{
	// Token: 0x0200064E RID: 1614
	[EventSource(Guid = "0866B2B8-5CEF-5DB9-2612-0C0FFD814A44", Name = "System.Buffers.ArrayPoolEventSource")]
	internal sealed class ArrayPoolEventSource : EventSource
	{
		// Token: 0x060030E2 RID: 12514 RVA: 0x000C4B54 File Offset: 0x000C2D54
		private ArrayPoolEventSource() : base(new Guid(140948152, 23791, 23993, 38, 18, 12, 15, 253, 129, 74, 68), "System.Buffers.ArrayPoolEventSource")
		{
		}

		// Token: 0x060030E3 RID: 12515 RVA: 0x000C4B98 File Offset: 0x000C2D98
		[Event(1, Level = EventLevel.Verbose)]
		internal unsafe void BufferRented(int bufferId, int bufferSize, int poolId, int bucketId)
		{
			EventSource.EventData* ptr = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(EventSource.EventData))];
			ptr->Size = 4;
			ptr->DataPointer = (IntPtr)((void*)(&bufferId));
			ptr->Reserved = 0;
			ptr[1].Size = 4;
			ptr[1].DataPointer = (IntPtr)((void*)(&bufferSize));
			ptr[1].Reserved = 0;
			ptr[2].Size = 4;
			ptr[2].DataPointer = (IntPtr)((void*)(&poolId));
			ptr[2].Reserved = 0;
			ptr[3].Size = 4;
			ptr[3].DataPointer = (IntPtr)((void*)(&bucketId));
			ptr[3].Reserved = 0;
			base.WriteEventCore(1, 4, ptr);
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x000C4C7C File Offset: 0x000C2E7C
		[Event(2, Level = EventLevel.Informational)]
		internal unsafe void BufferAllocated(int bufferId, int bufferSize, int poolId, int bucketId, ArrayPoolEventSource.BufferAllocatedReason reason)
		{
			EventSource.EventData* ptr = stackalloc EventSource.EventData[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(EventSource.EventData))];
			ptr->Size = 4;
			ptr->DataPointer = (IntPtr)((void*)(&bufferId));
			ptr->Reserved = 0;
			ptr[1].Size = 4;
			ptr[1].DataPointer = (IntPtr)((void*)(&bufferSize));
			ptr[1].Reserved = 0;
			ptr[2].Size = 4;
			ptr[2].DataPointer = (IntPtr)((void*)(&poolId));
			ptr[2].Reserved = 0;
			ptr[3].Size = 4;
			ptr[3].DataPointer = (IntPtr)((void*)(&bucketId));
			ptr[3].Reserved = 0;
			ptr[4].Size = 4;
			ptr[4].DataPointer = (IntPtr)((void*)(&reason));
			ptr[4].Reserved = 0;
			base.WriteEventCore(2, 5, ptr);
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x000C4D99 File Offset: 0x000C2F99
		[Event(3, Level = EventLevel.Verbose)]
		internal void BufferReturned(int bufferId, int bufferSize, int poolId)
		{
			base.WriteEvent(3, bufferId, bufferSize, poolId);
		}

		// Token: 0x060030E6 RID: 12518 RVA: 0x000C4DA5 File Offset: 0x000C2FA5
		[Event(4, Level = EventLevel.Informational)]
		internal void BufferTrimmed(int bufferId, int bufferSize, int poolId)
		{
			base.WriteEvent(4, bufferId, bufferSize, poolId);
		}

		// Token: 0x060030E7 RID: 12519 RVA: 0x000C4DB1 File Offset: 0x000C2FB1
		[Event(5, Level = EventLevel.Informational)]
		internal void BufferTrimPoll(int milliseconds, int pressure)
		{
			base.WriteEvent(5, milliseconds, pressure);
		}

		// Token: 0x0400194C RID: 6476
		internal static readonly ArrayPoolEventSource Log = new ArrayPoolEventSource();

		// Token: 0x0200064F RID: 1615
		internal enum BufferAllocatedReason
		{
			// Token: 0x0400194E RID: 6478
			Pooled,
			// Token: 0x0400194F RID: 6479
			OverMaximumSize,
			// Token: 0x04001950 RID: 6480
			PoolExhausted
		}
	}
}
