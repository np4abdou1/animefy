using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000133 RID: 307
	[NullableContext(1)]
	[Nullable(0)]
	public class MemoryTraceWriter : ITraceWriter
	{
		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x0002EFB1 File Offset: 0x0002D1B1
		// (set) Token: 0x0600097A RID: 2426 RVA: 0x0002EFB9 File Offset: 0x0002D1B9
		public TraceLevel LevelFilter { get; set; }

		// Token: 0x0600097B RID: 2427 RVA: 0x0002EFC2 File Offset: 0x0002D1C2
		public MemoryTraceWriter()
		{
			this.LevelFilter = TraceLevel.Verbose;
			this._traceMessages = new Queue<string>();
			this._lock = new object();
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0002EFE8 File Offset: 0x0002D1E8
		public void Trace(TraceLevel level, string message, [Nullable(2)] Exception ex)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff", CultureInfo.InvariantCulture));
			stringBuilder.Append(" ");
			stringBuilder.Append(level.ToString("g"));
			stringBuilder.Append(" ");
			stringBuilder.Append(message);
			string item = stringBuilder.ToString();
			object @lock = this._lock;
			lock (@lock)
			{
				if (this._traceMessages.Count >= 1000)
				{
					this._traceMessages.Dequeue();
				}
				this._traceMessages.Enqueue(item);
			}
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0002F0AC File Offset: 0x0002D2AC
		public IEnumerable<string> GetTraceMessages()
		{
			return this._traceMessages;
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0002F0B4 File Offset: 0x0002D2B4
		public override string ToString()
		{
			object @lock = this._lock;
			string result;
			lock (@lock)
			{
				StringBuilder stringBuilder = new StringBuilder();
				foreach (string value in this._traceMessages)
				{
					if (stringBuilder.Length > 0)
					{
						stringBuilder.AppendLine();
					}
					stringBuilder.Append(value);
				}
				result = stringBuilder.ToString();
			}
			return result;
		}

		// Token: 0x040005B7 RID: 1463
		private readonly Queue<string> _traceMessages;

		// Token: 0x040005B8 RID: 1464
		private readonly object _lock;
	}
}
