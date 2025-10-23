using System;
using System.Collections;
using System.Reflection;
using System.Runtime.Remoting.Channels;
using System.Threading;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x02000367 RID: 871
	internal class CADMessageBase
	{
		// Token: 0x06001B62 RID: 7010 RVA: 0x00076098 File Offset: 0x00074298
		public CADMessageBase(IMethodMessage msg)
		{
			CADMethodRef obj = new CADMethodRef(msg);
			this.serializedMethod = CADSerializer.SerializeObject(obj).GetBuffer();
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x000760C3 File Offset: 0x000742C3
		internal MethodBase GetMethod()
		{
			return ((CADMethodRef)CADSerializer.DeserializeObjectSafe(this.serializedMethod)).Resolve();
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x000760DC File Offset: 0x000742DC
		protected static Type[] GetSignature(MethodBase methodBase, bool load)
		{
			ParameterInfo[] parameters = methodBase.GetParameters();
			Type[] array = new Type[parameters.Length];
			for (int i = 0; i < parameters.Length; i++)
			{
				if (load)
				{
					array[i] = Type.GetType(parameters[i].ParameterType.AssemblyQualifiedName, true);
				}
				else
				{
					array[i] = parameters[i].ParameterType;
				}
			}
			return array;
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x00076130 File Offset: 0x00074330
		internal static int MarshalProperties(IDictionary dict, ref ArrayList args)
		{
			int num = 0;
			MessageDictionary messageDictionary = dict as MessageDictionary;
			if (messageDictionary != null)
			{
				if (!messageDictionary.HasUserData())
				{
					return num;
				}
				IDictionary internalDictionary = messageDictionary.InternalDictionary;
				if (internalDictionary == null)
				{
					return num;
				}
				using (IDictionaryEnumerator enumerator = internalDictionary.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
						if (args == null)
						{
							args = new ArrayList();
						}
						args.Add(dictionaryEntry);
						num++;
					}
					return num;
				}
			}
			if (dict != null)
			{
				foreach (object obj2 in dict)
				{
					DictionaryEntry dictionaryEntry2 = (DictionaryEntry)obj2;
					if (args == null)
					{
						args = new ArrayList();
					}
					args.Add(dictionaryEntry2);
					num++;
				}
			}
			return num;
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x00076228 File Offset: 0x00074428
		internal static void UnmarshalProperties(IDictionary dict, int count, ArrayList args)
		{
			for (int i = 0; i < count; i++)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)args[i];
				dict[dictionaryEntry.Key] = dictionaryEntry.Value;
			}
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x00076264 File Offset: 0x00074464
		private static bool IsPossibleToIgnoreMarshal(object obj)
		{
			Type type = obj.GetType();
			return type.IsPrimitive || type == typeof(void) || (type.IsArray && type.GetElementType().IsPrimitive && ((Array)obj).Rank == 1) || (obj is string || obj is DateTime || obj is TimeSpan);
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x000762D4 File Offset: 0x000744D4
		protected object MarshalArgument(object arg, ref ArrayList args)
		{
			if (arg == null)
			{
				return null;
			}
			if (CADMessageBase.IsPossibleToIgnoreMarshal(arg))
			{
				return arg;
			}
			MarshalByRefObject marshalByRefObject = arg as MarshalByRefObject;
			if (marshalByRefObject != null && !RemotingServices.IsTransparentProxy(marshalByRefObject))
			{
				return new CADObjRef(RemotingServices.Marshal(marshalByRefObject), Thread.GetDomainID());
			}
			if (args == null)
			{
				args = new ArrayList();
			}
			args.Add(arg);
			return new CADArgHolder(args.Count - 1);
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x00076338 File Offset: 0x00074538
		protected object UnmarshalArgument(object arg, ArrayList args)
		{
			if (arg == null)
			{
				return null;
			}
			CADArgHolder cadargHolder = arg as CADArgHolder;
			if (cadargHolder != null)
			{
				return args[cadargHolder.index];
			}
			CADObjRef cadobjRef = arg as CADObjRef;
			if (cadobjRef != null)
			{
				return RemotingServices.Unmarshal(cadobjRef.objref.DeserializeInTheCurrentDomain(cadobjRef.SourceDomain, cadobjRef.TypeInfo));
			}
			if (arg is Array)
			{
				Array array = (Array)arg;
				Array array2;
				switch (Type.GetTypeCode(arg.GetType().GetElementType()))
				{
				case TypeCode.Boolean:
					array2 = new bool[array.Length];
					break;
				case TypeCode.Char:
					array2 = new char[array.Length];
					break;
				case TypeCode.SByte:
					array2 = new sbyte[array.Length];
					break;
				case TypeCode.Byte:
					array2 = new byte[array.Length];
					break;
				case TypeCode.Int16:
					array2 = new short[array.Length];
					break;
				case TypeCode.UInt16:
					array2 = new ushort[array.Length];
					break;
				case TypeCode.Int32:
					array2 = new int[array.Length];
					break;
				case TypeCode.UInt32:
					array2 = new uint[array.Length];
					break;
				case TypeCode.Int64:
					array2 = new long[array.Length];
					break;
				case TypeCode.UInt64:
					array2 = new ulong[array.Length];
					break;
				case TypeCode.Single:
					array2 = new float[array.Length];
					break;
				case TypeCode.Double:
					array2 = new double[array.Length];
					break;
				case TypeCode.Decimal:
					array2 = new decimal[array.Length];
					break;
				default:
					throw new NotSupportedException();
				}
				array.CopyTo(array2, 0);
				return array2;
			}
			switch (Type.GetTypeCode(arg.GetType()))
			{
			case TypeCode.Boolean:
				return (bool)arg;
			case TypeCode.Char:
				return (char)arg;
			case TypeCode.SByte:
				return (sbyte)arg;
			case TypeCode.Byte:
				return (byte)arg;
			case TypeCode.Int16:
				return (short)arg;
			case TypeCode.UInt16:
				return (ushort)arg;
			case TypeCode.Int32:
				return (int)arg;
			case TypeCode.UInt32:
				return (uint)arg;
			case TypeCode.Int64:
				return (long)arg;
			case TypeCode.UInt64:
				return (ulong)arg;
			case TypeCode.Single:
				return (float)arg;
			case TypeCode.Double:
				return (double)arg;
			case TypeCode.Decimal:
				return (decimal)arg;
			case TypeCode.DateTime:
				return new DateTime(((DateTime)arg).Ticks);
			case TypeCode.String:
				return string.Copy((string)arg);
			}
			if (arg is TimeSpan)
			{
				return new TimeSpan(((TimeSpan)arg).Ticks);
			}
			if (arg is IntPtr)
			{
				return (IntPtr)arg;
			}
			string str = "Parameter of type ";
			Type type = arg.GetType();
			throw new NotSupportedException(str + ((type != null) ? type.ToString() : null) + " cannot be unmarshalled");
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x0007663C File Offset: 0x0007483C
		internal object[] MarshalArguments(object[] arguments, ref ArrayList args)
		{
			object[] array = new object[arguments.Length];
			int num = arguments.Length;
			for (int i = 0; i < num; i++)
			{
				array[i] = this.MarshalArgument(arguments[i], ref args);
			}
			return array;
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x00076670 File Offset: 0x00074870
		internal object[] UnmarshalArguments(object[] arguments, ArrayList args)
		{
			object[] array = new object[arguments.Length];
			int num = arguments.Length;
			for (int i = 0; i < num; i++)
			{
				array[i] = this.UnmarshalArgument(arguments[i], args);
			}
			return array;
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x000766A4 File Offset: 0x000748A4
		protected void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList)
		{
			if (msg.LogicalCallContext != null && msg.LogicalCallContext.HasInfo)
			{
				if (serializeList == null)
				{
					serializeList = new ArrayList();
				}
				this._callContext = new CADArgHolder(serializeList.Count);
				serializeList.Add(msg.LogicalCallContext);
			}
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x000766F1 File Offset: 0x000748F1
		internal LogicalCallContext GetLogicalCallContext(ArrayList args)
		{
			if (this._callContext == null)
			{
				return null;
			}
			return (LogicalCallContext)args[this._callContext.index];
		}

		// Token: 0x04000B89 RID: 2953
		protected object[] _args;

		// Token: 0x04000B8A RID: 2954
		protected byte[] _serializedArgs;

		// Token: 0x04000B8B RID: 2955
		protected int _propertyCount;

		// Token: 0x04000B8C RID: 2956
		protected CADArgHolder _callContext;

		// Token: 0x04000B8D RID: 2957
		internal byte[] serializedMethod;
	}
}
