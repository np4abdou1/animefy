using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.Tracing
{
	/// <summary>Provides the ability to create events for event tracing for Windows (ETW).</summary>
	// Token: 0x020005C9 RID: 1481
	public class EventSource : IDisposable
	{
		/// <summary>Creates a new instance of the <see cref="T:System.Diagnostics.Tracing.EventSource" /> class.</summary>
		// Token: 0x06002C59 RID: 11353 RVA: 0x000B7DE3 File Offset: 0x000B5FE3
		protected EventSource()
		{
			this.Name = base.GetType().Name;
		}

		/// <summary>Creates a new instance of the <see cref="T:System.Diagnostics.Tracing.EventSource" /> class with the specified name.</summary>
		/// <param name="eventSourceName">The name to apply to the event source. Must not be <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="eventSourceName" /> is <see langword="null" />.</exception>
		// Token: 0x06002C5A RID: 11354 RVA: 0x000B7DFC File Offset: 0x000B5FFC
		public EventSource(string eventSourceName)
		{
			this.Name = eventSourceName;
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x000B7E0B File Offset: 0x000B600B
		internal EventSource(Guid eventSourceGuid, string eventSourceName) : this(eventSourceName)
		{
		}

		/// <summary>Allows the <see cref="T:System.Diagnostics.Tracing.EventSource" /> object to attempt to free resources and perform other cleanup operations before the  object is reclaimed by garbage collection.</summary>
		// Token: 0x06002C5C RID: 11356 RVA: 0x000B7E14 File Offset: 0x000B6014
		~EventSource()
		{
			this.Dispose(false);
		}

		/// <summary>The friendly name of the class that is derived from the event source.</summary>
		/// <returns>The friendly name of the derived class.  The default is the simple name of the class.</returns>
		// Token: 0x170006BC RID: 1724
		// (set) Token: 0x06002C5D RID: 11357 RVA: 0x000B7E44 File Offset: 0x000B6044
		private string Name
		{
			[CompilerGenerated]
			set
			{
				this.<Name>k__BackingField = value;
			}
		}

		/// <summary>Determines whether the current event source is enabled.</summary>
		/// <returns>
		///     <see langword="true" /> if the current event source is enabled; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002C5E RID: 11358 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public bool IsEnabled()
		{
			return false;
		}

		/// <summary>Determines whether the current event source that has the specified level and keyword is enabled.</summary>
		/// <param name="level">The level of the event source.</param>
		/// <param name="keywords">The keyword of the event source.</param>
		/// <returns>
		///     <see langword="true" /> if the event source is enabled; otherwise, <see langword="false" />.</returns>
		// Token: 0x06002C5F RID: 11359 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public bool IsEnabled(EventLevel level, EventKeywords keywords)
		{
			return false;
		}

		/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Diagnostics.Tracing.EventSource" /> class.</summary>
		// Token: 0x06002C60 RID: 11360 RVA: 0x000B7E4D File Offset: 0x000B604D
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Diagnostics.Tracing.EventSource" /> class and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		// Token: 0x06002C61 RID: 11361 RVA: 0x00002A7D File Offset: 0x00000C7D
		protected virtual void Dispose(bool disposing)
		{
		}

		/// <summary>Writes an event by using the provided event identifier and 32-bit integer argument.</summary>
		/// <param name="eventId">The event identifier.  This value should be between 0 and 65535.</param>
		/// <param name="arg1">
		///       An integer argument.</param>
		// Token: 0x06002C62 RID: 11362 RVA: 0x000B7E5C File Offset: 0x000B605C
		protected void WriteEvent(int eventId, int arg1)
		{
			this.WriteEvent(eventId, new object[]
			{
				arg1
			});
		}

		/// <summary>Writes an event by using the provided event identifier and string argument.</summary>
		/// <param name="eventId">The event identifier.  This value should be between 0 and 65535.</param>
		/// <param name="arg1">A string argument.</param>
		// Token: 0x06002C63 RID: 11363 RVA: 0x000B7E74 File Offset: 0x000B6074
		protected void WriteEvent(int eventId, string arg1)
		{
			this.WriteEvent(eventId, new object[]
			{
				arg1
			});
		}

		/// <summary>Writes an event by using the provided event identifier and 32-bit integer arguments.</summary>
		/// <param name="eventId">The event identifier.  This value should be between 0 and 65535.</param>
		/// <param name="arg1">An integer argument.</param>
		/// <param name="arg2">An integer argument.</param>
		// Token: 0x06002C64 RID: 11364 RVA: 0x000B7E87 File Offset: 0x000B6087
		protected void WriteEvent(int eventId, int arg1, int arg2)
		{
			this.WriteEvent(eventId, new object[]
			{
				arg1,
				arg2
			});
		}

		/// <summary>Writes an event by using the provided event identifier and 32-bit integer arguments.</summary>
		/// <param name="eventId">The event identifier.  This value should be between 0 and 65535.</param>
		/// <param name="arg1">An integer argument.</param>
		/// <param name="arg2">An integer argument.</param>
		/// <param name="arg3">An integer argument.</param>
		// Token: 0x06002C65 RID: 11365 RVA: 0x000B7EA8 File Offset: 0x000B60A8
		protected void WriteEvent(int eventId, int arg1, int arg2, int arg3)
		{
			this.WriteEvent(eventId, new object[]
			{
				arg1,
				arg2,
				arg3
			});
		}

		/// <summary>Writes an event by using the provided event identifier and 64-bit integer argument.</summary>
		/// <param name="eventId">The event identifier.  This value should be between 0 and 65535.</param>
		/// <param name="arg1">A 64 bit integer argument.</param>
		// Token: 0x06002C66 RID: 11366 RVA: 0x000B7ED3 File Offset: 0x000B60D3
		protected void WriteEvent(int eventId, long arg1)
		{
			this.WriteEvent(eventId, new object[]
			{
				arg1
			});
		}

		/// <summary>Writes an event by using the provided event identifier and 64-bit integer, and string arguments.</summary>
		/// <param name="eventId">The event identifier.  This value should be between 0 and 65535.</param>
		/// <param name="arg1">A 64-bit integer argument.</param>
		/// <param name="arg2">A string argument.</param>
		// Token: 0x06002C67 RID: 11367 RVA: 0x000B7EEB File Offset: 0x000B60EB
		protected void WriteEvent(int eventId, long arg1, string arg2)
		{
			this.WriteEvent(eventId, new object[]
			{
				arg1,
				arg2
			});
		}

		/// <summary>Writes an event by using the provided event identifier and array of arguments.</summary>
		/// <param name="eventId">The event identifier.  This value should be between 0 and 65535.</param>
		/// <param name="args">An array of objects.</param>
		// Token: 0x06002C68 RID: 11368 RVA: 0x00002A7D File Offset: 0x00000C7D
		protected void WriteEvent(int eventId, params object[] args)
		{
		}

		/// <summary>Writes an event by using the provided event identifier and string arguments.</summary>
		/// <param name="eventId">The event identifier.  This value should be between 0 and 65535.</param>
		/// <param name="arg1">A string argument.</param>
		/// <param name="arg2">A string argument.</param>
		/// <param name="arg3">A string argument.</param>
		// Token: 0x06002C69 RID: 11369 RVA: 0x000B7F07 File Offset: 0x000B6107
		protected void WriteEvent(int eventId, string arg1, string arg2, string arg3)
		{
			this.WriteEvent(eventId, new object[]
			{
				arg1,
				arg2,
				arg3
			});
		}

		/// <summary>Creates a new <see cref="Overload:System.Diagnostics.Tracing.EventSource.WriteEvent" /> overload by using the provided event identifier and event data.</summary>
		/// <param name="eventId">The event identifier.</param>
		/// <param name="eventDataCount">The number of event data items.</param>
		/// <param name="data">The structure that contains the event data.</param>
		// Token: 0x06002C6A RID: 11370 RVA: 0x00002A7D File Offset: 0x00000C7D
		[CLSCompliant(false)]
		protected unsafe void WriteEventCore(int eventId, int eventDataCount, EventSource.EventData* data)
		{
		}

		/// <summary>Provides the event data for creating fast <see cref="Overload:System.Diagnostics.Tracing.EventSource.WriteEvent" /> overloads by using the <see cref="M:System.Diagnostics.Tracing.EventSource.WriteEventCore(System.Int32,System.Int32,System.Diagnostics.Tracing.EventSource.EventData*)" /> method.</summary>
		// Token: 0x020005CA RID: 1482
		protected internal struct EventData
		{
			/// <summary>Gets or sets the pointer to the data for the new <see cref="Overload:System.Diagnostics.Tracing.EventSource.WriteEvent" /> overload.</summary>
			/// <returns>The pointer to the data.</returns>
			// Token: 0x170006BD RID: 1725
			// (set) Token: 0x06002C6B RID: 11371 RVA: 0x000B7F23 File Offset: 0x000B6123
			public IntPtr DataPointer
			{
				[CompilerGenerated]
				set
				{
					this.<DataPointer>k__BackingField = value;
				}
			}

			/// <summary>Gets or sets the number of payload items in the new <see cref="Overload:System.Diagnostics.Tracing.EventSource.WriteEvent" /> overload.</summary>
			/// <returns>The number of payload items in the new overload.</returns>
			// Token: 0x170006BE RID: 1726
			// (set) Token: 0x06002C6C RID: 11372 RVA: 0x000B7F2C File Offset: 0x000B612C
			public int Size
			{
				[CompilerGenerated]
				set
				{
					this.<Size>k__BackingField = value;
				}
			}

			// Token: 0x170006BF RID: 1727
			// (set) Token: 0x06002C6D RID: 11373 RVA: 0x000B7F35 File Offset: 0x000B6135
			internal int Reserved
			{
				[CompilerGenerated]
				set
				{
					this.<Reserved>k__BackingField = value;
				}
			}
		}
	}
}
