using System;
using System.Collections.Generic;
using System.Reflection;

namespace System.Runtime.Serialization
{
	// Token: 0x0200039C RID: 924
	internal sealed class SerializationEvents
	{
		// Token: 0x06001C9B RID: 7323 RVA: 0x000793A8 File Offset: 0x000775A8
		internal SerializationEvents(Type t)
		{
			this._onSerializingMethods = this.GetMethodsWithAttribute(typeof(OnSerializingAttribute), t);
			this._onSerializedMethods = this.GetMethodsWithAttribute(typeof(OnSerializedAttribute), t);
			this._onDeserializingMethods = this.GetMethodsWithAttribute(typeof(OnDeserializingAttribute), t);
			this._onDeserializedMethods = this.GetMethodsWithAttribute(typeof(OnDeserializedAttribute), t);
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x00079418 File Offset: 0x00077618
		private List<MethodInfo> GetMethodsWithAttribute(Type attribute, Type t)
		{
			List<MethodInfo> list = null;
			Type type = t;
			while (type != null && type != typeof(object))
			{
				foreach (MethodInfo methodInfo in type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
				{
					if (methodInfo.IsDefined(attribute, false))
					{
						if (list == null)
						{
							list = new List<MethodInfo>();
						}
						list.Add(methodInfo);
					}
				}
				type = type.BaseType;
			}
			if (list != null)
			{
				list.Reverse();
			}
			return list;
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001C9D RID: 7325 RVA: 0x0007948F File Offset: 0x0007768F
		internal bool HasOnSerializingEvents
		{
			get
			{
				return this._onSerializingMethods != null || this._onSerializedMethods != null;
			}
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x000794A4 File Offset: 0x000776A4
		internal void InvokeOnSerializing(object obj, StreamingContext context)
		{
			SerializationEvents.InvokeOnDelegate(obj, context, this._onSerializingMethods);
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x000794B3 File Offset: 0x000776B3
		internal void InvokeOnDeserializing(object obj, StreamingContext context)
		{
			SerializationEvents.InvokeOnDelegate(obj, context, this._onDeserializingMethods);
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x000794C2 File Offset: 0x000776C2
		internal void InvokeOnDeserialized(object obj, StreamingContext context)
		{
			SerializationEvents.InvokeOnDelegate(obj, context, this._onDeserializedMethods);
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x000794D1 File Offset: 0x000776D1
		internal SerializationEventHandler AddOnSerialized(object obj, SerializationEventHandler handler)
		{
			return SerializationEvents.AddOnDelegate(obj, handler, this._onSerializedMethods);
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x000794E0 File Offset: 0x000776E0
		internal SerializationEventHandler AddOnDeserialized(object obj, SerializationEventHandler handler)
		{
			return SerializationEvents.AddOnDelegate(obj, handler, this._onDeserializedMethods);
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x000794EF File Offset: 0x000776EF
		private static void InvokeOnDelegate(object obj, StreamingContext context, List<MethodInfo> methods)
		{
			SerializationEventHandler serializationEventHandler = SerializationEvents.AddOnDelegate(obj, null, methods);
			if (serializationEventHandler == null)
			{
				return;
			}
			serializationEventHandler(context);
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x00079504 File Offset: 0x00077704
		private static SerializationEventHandler AddOnDelegate(object obj, SerializationEventHandler handler, List<MethodInfo> methods)
		{
			if (methods != null)
			{
				foreach (MethodInfo methodInfo in methods)
				{
					SerializationEventHandler b = (SerializationEventHandler)methodInfo.CreateDelegate(typeof(SerializationEventHandler), obj);
					handler = (SerializationEventHandler)Delegate.Combine(handler, b);
				}
			}
			return handler;
		}

		// Token: 0x04000BFB RID: 3067
		private readonly List<MethodInfo> _onSerializingMethods;

		// Token: 0x04000BFC RID: 3068
		private readonly List<MethodInfo> _onSerializedMethods;

		// Token: 0x04000BFD RID: 3069
		private readonly List<MethodInfo> _onDeserializingMethods;

		// Token: 0x04000BFE RID: 3070
		private readonly List<MethodInfo> _onDeserializedMethods;
	}
}
