using System;
using System.Collections.Generic;

namespace System.Runtime.Serialization
{
	/// <summary>Manages serialization processes at run time. This class cannot be inherited.</summary>
	// Token: 0x0200039F RID: 927
	public sealed class SerializationObjectManager
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.SerializationObjectManager" /> class. </summary>
		/// <param name="context">An instance of the <see cref="T:System.Runtime.Serialization.StreamingContext" /> class that contains information about the current serialization operation.</param>
		// Token: 0x06001CAA RID: 7338 RVA: 0x000795C0 File Offset: 0x000777C0
		public SerializationObjectManager(StreamingContext context)
		{
			this._context = context;
			this._objectSeenTable = new Dictionary<object, object>();
		}

		/// <summary>Registers the object upon which events will be raised.</summary>
		/// <param name="obj">The object to register.</param>
		// Token: 0x06001CAB RID: 7339 RVA: 0x000795DC File Offset: 0x000777DC
		public void RegisterObject(object obj)
		{
			SerializationEvents serializationEventsForType = SerializationEventsCache.GetSerializationEventsForType(obj.GetType());
			if (serializationEventsForType.HasOnSerializingEvents && this._objectSeenTable.TryAdd(obj, true))
			{
				serializationEventsForType.InvokeOnSerializing(obj, this._context);
				this.AddOnSerialized(obj);
			}
		}

		/// <summary>Invokes the OnSerializing callback event if the type of the object has one; and registers the object for raising the OnSerialized event if the type of the object has one.</summary>
		// Token: 0x06001CAC RID: 7340 RVA: 0x00079625 File Offset: 0x00077825
		public void RaiseOnSerializedEvent()
		{
			SerializationEventHandler onSerializedHandler = this._onSerializedHandler;
			if (onSerializedHandler == null)
			{
				return;
			}
			onSerializedHandler(this._context);
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x00079640 File Offset: 0x00077840
		private void AddOnSerialized(object obj)
		{
			SerializationEvents serializationEventsForType = SerializationEventsCache.GetSerializationEventsForType(obj.GetType());
			this._onSerializedHandler = serializationEventsForType.AddOnSerialized(obj, this._onSerializedHandler);
		}

		// Token: 0x04000C02 RID: 3074
		private readonly Dictionary<object, object> _objectSeenTable;

		// Token: 0x04000C03 RID: 3075
		private readonly StreamingContext _context;

		// Token: 0x04000C04 RID: 3076
		private SerializationEventHandler _onSerializedHandler;
	}
}
