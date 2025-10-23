using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.Serialization
{
	// Token: 0x020003AF RID: 943
	[Serializable]
	internal sealed class SafeSerializationManager : IObjectReference, ISerializable
	{
		// Token: 0x06001D34 RID: 7476 RVA: 0x00003ACD File Offset: 0x00001CCD
		internal SafeSerializationManager()
		{
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x0007BBE8 File Offset: 0x00079DE8
		[SecurityCritical]
		private SafeSerializationManager(SerializationInfo info, StreamingContext context)
		{
			RuntimeType runtimeType = info.GetValueNoThrow("CLR_SafeSerializationManager_RealType", typeof(RuntimeType)) as RuntimeType;
			if (runtimeType == null)
			{
				this.m_serializedStates = (info.GetValue("m_serializedStates", typeof(List<object>)) as List<object>);
				return;
			}
			this.m_realType = runtimeType;
			this.m_savedSerializationInfo = info;
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001D36 RID: 7478 RVA: 0x0007BC4E File Offset: 0x00079E4E
		internal bool IsActive
		{
			get
			{
				return this.SerializeObjectState != null;
			}
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x0007BC5C File Offset: 0x00079E5C
		[SecurityCritical]
		internal void CompleteSerialization(object serializedObject, SerializationInfo info, StreamingContext context)
		{
			this.m_serializedStates = null;
			EventHandler<SafeSerializationEventArgs> serializeObjectState = this.SerializeObjectState;
			if (serializeObjectState != null)
			{
				SafeSerializationEventArgs safeSerializationEventArgs = new SafeSerializationEventArgs(context);
				serializeObjectState(serializedObject, safeSerializationEventArgs);
				this.m_serializedStates = safeSerializationEventArgs.SerializedStates;
				info.AddValue("CLR_SafeSerializationManager_RealType", serializedObject.GetType(), typeof(RuntimeType));
				info.SetType(typeof(SafeSerializationManager));
			}
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x0007BCC0 File Offset: 0x00079EC0
		internal void CompleteDeserialization(object deserializedObject)
		{
			if (this.m_serializedStates != null)
			{
				foreach (object obj in this.m_serializedStates)
				{
					((ISafeSerializationData)obj).CompleteDeserialization(deserializedObject);
				}
			}
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x0007BD18 File Offset: 0x00079F18
		[SecurityCritical]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("m_serializedStates", this.m_serializedStates, typeof(List<IDeserializationCallback>));
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x0007BD38 File Offset: 0x00079F38
		[SecurityCritical]
		object IObjectReference.GetRealObject(StreamingContext context)
		{
			if (this.m_realObject != null)
			{
				return this.m_realObject;
			}
			if (this.m_realType == null)
			{
				return this;
			}
			Stack stack = new Stack();
			RuntimeType runtimeType = this.m_realType;
			do
			{
				stack.Push(runtimeType);
				runtimeType = (runtimeType.BaseType as RuntimeType);
			}
			while (runtimeType != typeof(object));
			RuntimeType t;
			RuntimeConstructorInfo runtimeConstructorInfo;
			do
			{
				t = runtimeType;
				runtimeType = (stack.Pop() as RuntimeType);
				runtimeConstructorInfo = runtimeType.GetSerializationCtor();
			}
			while (runtimeConstructorInfo != null && runtimeConstructorInfo.IsSecurityCritical);
			runtimeConstructorInfo = ObjectManager.GetConstructor(t);
			object uninitializedObject = FormatterServices.GetUninitializedObject(this.m_realType);
			runtimeConstructorInfo.SerializationInvoke(uninitializedObject, this.m_savedSerializationInfo, context);
			this.m_savedSerializationInfo = null;
			this.m_realType = null;
			this.m_realObject = uninitializedObject;
			return uninitializedObject;
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x0007BDFB File Offset: 0x00079FFB
		[OnDeserialized]
		private void OnDeserialized(StreamingContext context)
		{
			if (this.m_realObject != null)
			{
				SerializationEventsCache.GetSerializationEventsForType(this.m_realObject.GetType()).InvokeOnDeserialized(this.m_realObject, context);
				this.m_realObject = null;
			}
		}

		// Token: 0x04000C3B RID: 3131
		private IList<object> m_serializedStates;

		// Token: 0x04000C3C RID: 3132
		private SerializationInfo m_savedSerializationInfo;

		// Token: 0x04000C3D RID: 3133
		private object m_realObject;

		// Token: 0x04000C3E RID: 3134
		private RuntimeType m_realType;

		// Token: 0x04000C3F RID: 3135
		[CompilerGenerated]
		private EventHandler<SafeSerializationEventArgs> SerializeObjectState;
	}
}
