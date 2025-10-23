﻿using System;
using System.Reflection;
using System.Runtime.Remoting;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x0200016E RID: 366
	[Serializable]
	internal class DelegateSerializationHolder : ISerializable, IObjectReference
	{
		// Token: 0x06000EA7 RID: 3751 RVA: 0x0003DCF4 File Offset: 0x0003BEF4
		private DelegateSerializationHolder(SerializationInfo info, StreamingContext ctx)
		{
			DelegateSerializationHolder.DelegateEntry delegateEntry = (DelegateSerializationHolder.DelegateEntry)info.GetValue("Delegate", typeof(DelegateSerializationHolder.DelegateEntry));
			int num = 0;
			DelegateSerializationHolder.DelegateEntry delegateEntry2 = delegateEntry;
			while (delegateEntry2 != null)
			{
				delegateEntry2 = delegateEntry2.delegateEntry;
				num++;
			}
			if (num == 1)
			{
				this._delegate = delegateEntry.DeserializeDelegate(info, 0);
				return;
			}
			Delegate[] array = new Delegate[num];
			delegateEntry2 = delegateEntry;
			for (int i = 0; i < num; i++)
			{
				array[i] = delegateEntry2.DeserializeDelegate(info, i);
				delegateEntry2 = delegateEntry2.delegateEntry;
			}
			this._delegate = Delegate.Combine(array);
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x0003DD84 File Offset: 0x0003BF84
		public static void GetDelegateData(Delegate instance, SerializationInfo info, StreamingContext ctx)
		{
			Delegate[] invocationList = instance.GetInvocationList();
			DelegateSerializationHolder.DelegateEntry delegateEntry = null;
			for (int i = 0; i < invocationList.Length; i++)
			{
				Delegate @delegate = invocationList[i];
				string text = (@delegate.Target != null) ? ("target" + i.ToString()) : null;
				DelegateSerializationHolder.DelegateEntry delegateEntry2 = new DelegateSerializationHolder.DelegateEntry(@delegate, text);
				if (delegateEntry == null)
				{
					info.AddValue("Delegate", delegateEntry2);
				}
				else
				{
					delegateEntry.delegateEntry = delegateEntry2;
				}
				delegateEntry = delegateEntry2;
				if (@delegate.Target != null)
				{
					info.AddValue(text, @delegate.Target);
				}
				info.AddValue("method" + i.ToString(), @delegate.Method);
			}
			info.SetType(typeof(DelegateSerializationHolder));
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x0002AD12 File Offset: 0x00028F12
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x0003DE3A File Offset: 0x0003C03A
		public object GetRealObject(StreamingContext context)
		{
			return this._delegate;
		}

		// Token: 0x0400058D RID: 1421
		private Delegate _delegate;

		// Token: 0x0200016F RID: 367
		[Serializable]
		private class DelegateEntry
		{
			// Token: 0x06000EAB RID: 3755 RVA: 0x0003DE44 File Offset: 0x0003C044
			public DelegateEntry(Delegate del, string targetLabel)
			{
				this.type = del.GetType().FullName;
				this.assembly = del.GetType().Assembly.FullName;
				this.target = targetLabel;
				this.targetTypeAssembly = del.Method.DeclaringType.Assembly.FullName;
				this.targetTypeName = del.Method.DeclaringType.FullName;
				this.methodName = del.Method.Name;
			}

			// Token: 0x06000EAC RID: 3756 RVA: 0x0003DEC8 File Offset: 0x0003C0C8
			public Delegate DeserializeDelegate(SerializationInfo info, int index)
			{
				object obj = null;
				if (this.target != null)
				{
					obj = info.GetValue(this.target.ToString(), typeof(object));
				}
				string name = "method" + index.ToString();
				MethodInfo methodInfo = (MethodInfo)info.GetValueNoThrow(name, typeof(MethodInfo));
				Type type = Assembly.Load(this.assembly).GetType(this.type);
				if (obj != null)
				{
					if (RemotingServices.IsTransparentProxy(obj) && !Assembly.Load(this.targetTypeAssembly).GetType(this.targetTypeName).IsInstanceOfType(obj))
					{
						throw new RemotingException("Unexpected proxy type.");
					}
					if (!(methodInfo == null))
					{
						return Delegate.CreateDelegate(type, obj, methodInfo);
					}
					return Delegate.CreateDelegate(type, obj, this.methodName);
				}
				else
				{
					if (methodInfo != null)
					{
						return Delegate.CreateDelegate(type, obj, methodInfo);
					}
					Type type2 = Assembly.Load(this.targetTypeAssembly).GetType(this.targetTypeName);
					return Delegate.CreateDelegate(type, type2, this.methodName);
				}
			}

			// Token: 0x0400058E RID: 1422
			private string type;

			// Token: 0x0400058F RID: 1423
			private string assembly;

			// Token: 0x04000590 RID: 1424
			private object target;

			// Token: 0x04000591 RID: 1425
			private string targetTypeAssembly;

			// Token: 0x04000592 RID: 1426
			private string targetTypeName;

			// Token: 0x04000593 RID: 1427
			private string methodName;

			// Token: 0x04000594 RID: 1428
			public DelegateSerializationHolder.DelegateEntry delegateEntry;
		}
	}
}
