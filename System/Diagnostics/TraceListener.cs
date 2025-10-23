using System;
using System.Collections;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	/// <summary>Provides the <see langword="abstract" /> base class for the listeners who monitor trace and debug output.</summary>
	// Token: 0x020000C6 RID: 198
	public abstract class TraceListener : MarshalByRefObject, IDisposable
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.TraceListener" /> class using the specified name as the listener.</summary>
		/// <param name="name">The name of the <see cref="T:System.Diagnostics.TraceListener" />. </param>
		// Token: 0x060005CA RID: 1482 RVA: 0x00024263 File Offset: 0x00022463
		protected TraceListener(string name)
		{
			this.listenerName = name;
		}

		/// <summary>Gets a value indicating whether the trace listener is thread safe. </summary>
		/// <returns>
		///     <see langword="true" /> if the trace listener is thread safe; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x000023F6 File Offset: 0x000005F6
		public virtual bool IsThreadSafe
		{
			get
			{
				return false;
			}
		}

		/// <summary>Releases all resources used by the <see cref="T:System.Diagnostics.TraceListener" />.</summary>
		// Token: 0x060005CC RID: 1484 RVA: 0x00024280 File Offset: 0x00022480
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Diagnostics.TraceListener" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		// Token: 0x060005CD RID: 1485 RVA: 0x00004D67 File Offset: 0x00002F67
		protected virtual void Dispose(bool disposing)
		{
		}

		/// <summary>When overridden in a derived class, flushes the output buffer.</summary>
		// Token: 0x060005CE RID: 1486 RVA: 0x00004D67 File Offset: 0x00002F67
		public virtual void Flush()
		{
		}

		/// <summary>Gets or sets the indent level.</summary>
		/// <returns>The indent level. The default is zero.</returns>
		// Token: 0x170000CB RID: 203
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x0002428F File Offset: 0x0002248F
		public int IndentLevel
		{
			set
			{
				this.indentLevel = ((value < 0) ? 0 : value);
			}
		}

		/// <summary>Gets or sets the number of spaces in an indent.</summary>
		/// <returns>The number of spaces in an indent. The default is four spaces.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Set operation failed because the value is less than zero.</exception>
		// Token: 0x170000CC RID: 204
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x0002429F File Offset: 0x0002249F
		public int IndentSize
		{
			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("IndentSize", value, SR.GetString("The IndentSize property must be non-negative."));
				}
				this.indentSize = value;
			}
		}

		/// <summary>Gets and sets the trace filter for the trace listener.</summary>
		/// <returns>An object derived from the <see cref="T:System.Diagnostics.TraceFilter" /> base class.</returns>
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x000242C7 File Offset: 0x000224C7
		[ComVisible(false)]
		public TraceFilter Filter
		{
			get
			{
				return this.filter;
			}
		}

		/// <summary>Gets or sets a value indicating whether to indent the output.</summary>
		/// <returns>
		///     <see langword="true" /> if the output should be indented; otherwise, <see langword="false" />.</returns>
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x000242CF File Offset: 0x000224CF
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x000242D7 File Offset: 0x000224D7
		protected bool NeedIndent
		{
			get
			{
				return this.needIndent;
			}
			set
			{
				this.needIndent = value;
			}
		}

		/// <summary>Gets or sets the trace output options.</summary>
		/// <returns>A bitwise combination of the enumeration values. The default is <see cref="F:System.Diagnostics.TraceOptions.None" />. </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Set operation failed because the value is invalid.</exception>
		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x000242E0 File Offset: 0x000224E0
		[ComVisible(false)]
		public TraceOptions TraceOutputOptions
		{
			get
			{
				return this.traceOptions;
			}
		}

		/// <summary>When overridden in a derived class, writes the specified message to the listener you create in the derived class.</summary>
		/// <param name="message">A message to write. </param>
		// Token: 0x060005D5 RID: 1493
		public abstract void Write(string message);

		/// <summary>Writes the indent to the listener you create when you implement this class, and resets the <see cref="P:System.Diagnostics.TraceListener.NeedIndent" /> property to <see langword="false" />.</summary>
		// Token: 0x060005D6 RID: 1494 RVA: 0x000242E8 File Offset: 0x000224E8
		protected virtual void WriteIndent()
		{
			this.NeedIndent = false;
			for (int i = 0; i < this.indentLevel; i++)
			{
				if (this.indentSize == 4)
				{
					this.Write("    ");
				}
				else
				{
					for (int j = 0; j < this.indentSize; j++)
					{
						this.Write(" ");
					}
				}
			}
		}

		/// <summary>When overridden in a derived class, writes a message to the listener you create in the derived class, followed by a line terminator.</summary>
		/// <param name="message">A message to write. </param>
		// Token: 0x060005D7 RID: 1495
		public abstract void WriteLine(string message);

		/// <summary>Writes trace information, a message, and event information to the listener specific output.</summary>
		/// <param name="eventCache">A <see cref="T:System.Diagnostics.TraceEventCache" /> object that contains the current process ID, thread ID, and stack trace information.</param>
		/// <param name="source">A name used to identify the output, typically the name of the application that generated the trace event.</param>
		/// <param name="eventType">One of the <see cref="T:System.Diagnostics.TraceEventType" /> values specifying the type of event that has caused the trace.</param>
		/// <param name="id">A numeric identifier for the event.</param>
		/// <param name="message">A message to write.</param>
		// Token: 0x060005D8 RID: 1496 RVA: 0x0002433F File Offset: 0x0002253F
		[ComVisible(false)]
		public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message)
		{
			if (this.Filter != null && !this.Filter.ShouldTrace(eventCache, source, eventType, id, message))
			{
				return;
			}
			this.WriteHeader(source, eventType, id);
			this.WriteLine(message);
			this.WriteFooter(eventCache);
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00024377 File Offset: 0x00022577
		private void WriteHeader(string source, TraceEventType eventType, int id)
		{
			this.Write(string.Format(CultureInfo.InvariantCulture, "{0} {1}: {2} : ", source, eventType.ToString(), id.ToString(CultureInfo.InvariantCulture)));
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x000243A8 File Offset: 0x000225A8
		private void WriteFooter(TraceEventCache eventCache)
		{
			if (eventCache == null)
			{
				return;
			}
			this.indentLevel++;
			if (this.IsEnabled(TraceOptions.ProcessId))
			{
				this.WriteLine("ProcessId=" + eventCache.ProcessId.ToString());
			}
			if (this.IsEnabled(TraceOptions.LogicalOperationStack))
			{
				this.Write("LogicalOperationStack=");
				Stack logicalOperationStack = eventCache.LogicalOperationStack;
				bool flag = true;
				foreach (object obj in logicalOperationStack)
				{
					if (!flag)
					{
						this.Write(", ");
					}
					else
					{
						flag = false;
					}
					this.Write(obj.ToString());
				}
				this.WriteLine(string.Empty);
			}
			if (this.IsEnabled(TraceOptions.ThreadId))
			{
				this.WriteLine("ThreadId=" + eventCache.ThreadId);
			}
			if (this.IsEnabled(TraceOptions.DateTime))
			{
				this.WriteLine("DateTime=" + eventCache.DateTime.ToString("o", CultureInfo.InvariantCulture));
			}
			if (this.IsEnabled(TraceOptions.Timestamp))
			{
				this.WriteLine("Timestamp=" + eventCache.Timestamp.ToString());
			}
			if (this.IsEnabled(TraceOptions.Callstack))
			{
				this.WriteLine("Callstack=" + eventCache.Callstack);
			}
			this.indentLevel--;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00024518 File Offset: 0x00022718
		internal bool IsEnabled(TraceOptions opts)
		{
			return (opts & this.TraceOutputOptions) > TraceOptions.None;
		}

		// Token: 0x040003C2 RID: 962
		private int indentLevel;

		// Token: 0x040003C3 RID: 963
		private int indentSize = 4;

		// Token: 0x040003C4 RID: 964
		private TraceOptions traceOptions;

		// Token: 0x040003C5 RID: 965
		private bool needIndent = true;

		// Token: 0x040003C6 RID: 966
		private string listenerName;

		// Token: 0x040003C7 RID: 967
		private TraceFilter filter;
	}
}
