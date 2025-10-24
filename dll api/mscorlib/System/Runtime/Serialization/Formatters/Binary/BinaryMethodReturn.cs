using System;
using System.Runtime.Remoting.Messaging;
using System.Security;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003D0 RID: 976
	internal sealed class BinaryMethodReturn
	{
		// Token: 0x06001DA4 RID: 7588 RVA: 0x0007D34E File Offset: 0x0007B54E
		internal BinaryMethodReturn()
		{
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x0007D360 File Offset: 0x0007B560
		internal object[] WriteArray(object returnValue, object[] args, Exception exception, object callContext, object[] properties)
		{
			this.returnValue = returnValue;
			this.args = args;
			this.exception = exception;
			this.callContext = callContext;
			this.properties = properties;
			int num = 0;
			if (args == null || args.Length == 0)
			{
				this.messageEnum = MessageEnum.NoArgs;
			}
			else
			{
				this.argTypes = new Type[args.Length];
				this.bArgsPrimitive = true;
				for (int i = 0; i < args.Length; i++)
				{
					if (args[i] != null)
					{
						this.argTypes[i] = args[i].GetType();
						if (Converter.ToCode(this.argTypes[i]) <= InternalPrimitiveTypeE.Invalid && this.argTypes[i] != Converter.typeofString)
						{
							this.bArgsPrimitive = false;
							break;
						}
					}
				}
				if (this.bArgsPrimitive)
				{
					this.messageEnum = MessageEnum.ArgsInline;
				}
				else
				{
					num++;
					this.messageEnum = MessageEnum.ArgsInArray;
				}
			}
			if (returnValue == null)
			{
				this.messageEnum |= MessageEnum.NoReturnValue;
			}
			else if (returnValue.GetType() == typeof(void))
			{
				this.messageEnum |= MessageEnum.ReturnValueVoid;
			}
			else
			{
				this.returnType = returnValue.GetType();
				if (Converter.ToCode(this.returnType) > InternalPrimitiveTypeE.Invalid || this.returnType == Converter.typeofString)
				{
					this.messageEnum |= MessageEnum.ReturnValueInline;
				}
				else
				{
					num++;
					this.messageEnum |= MessageEnum.ReturnValueInArray;
				}
			}
			if (exception != null)
			{
				num++;
				this.messageEnum |= MessageEnum.ExceptionInArray;
			}
			if (callContext == null)
			{
				this.messageEnum |= MessageEnum.NoContext;
			}
			else if (callContext is string)
			{
				this.messageEnum |= MessageEnum.ContextInline;
			}
			else
			{
				num++;
				this.messageEnum |= MessageEnum.ContextInArray;
			}
			if (properties != null)
			{
				num++;
				this.messageEnum |= MessageEnum.PropertyInArray;
			}
			if (IOUtil.FlagTest(this.messageEnum, MessageEnum.ArgsInArray) && num == 1)
			{
				this.messageEnum ^= MessageEnum.ArgsInArray;
				this.messageEnum |= MessageEnum.ArgsIsArray;
				return args;
			}
			if (num > 0)
			{
				int num2 = 0;
				this.callA = new object[num];
				if (IOUtil.FlagTest(this.messageEnum, MessageEnum.ArgsInArray))
				{
					this.callA[num2++] = args;
				}
				if (IOUtil.FlagTest(this.messageEnum, MessageEnum.ReturnValueInArray))
				{
					this.callA[num2++] = returnValue;
				}
				if (IOUtil.FlagTest(this.messageEnum, MessageEnum.ExceptionInArray))
				{
					this.callA[num2++] = exception;
				}
				if (IOUtil.FlagTest(this.messageEnum, MessageEnum.ContextInArray))
				{
					this.callA[num2++] = callContext;
				}
				if (IOUtil.FlagTest(this.messageEnum, MessageEnum.PropertyInArray))
				{
					this.callA[num2] = properties;
				}
				return this.callA;
			}
			return null;
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x0007D60C File Offset: 0x0007B80C
		public void Write(__BinaryWriter sout)
		{
			sout.WriteByte(22);
			sout.WriteInt32((int)this.messageEnum);
			if (IOUtil.FlagTest(this.messageEnum, MessageEnum.ReturnValueInline))
			{
				IOUtil.WriteWithCode(this.returnType, this.returnValue, sout);
			}
			if (IOUtil.FlagTest(this.messageEnum, MessageEnum.ContextInline))
			{
				IOUtil.WriteStringWithCode((string)this.callContext, sout);
			}
			if (IOUtil.FlagTest(this.messageEnum, MessageEnum.ArgsInline))
			{
				sout.WriteInt32(this.args.Length);
				for (int i = 0; i < this.args.Length; i++)
				{
					IOUtil.WriteWithCode(this.argTypes[i], this.args[i], sout);
				}
			}
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x0007D6B8 File Offset: 0x0007B8B8
		[SecurityCritical]
		public void Read(__BinaryParser input)
		{
			this.messageEnum = (MessageEnum)input.ReadInt32();
			if (IOUtil.FlagTest(this.messageEnum, MessageEnum.NoReturnValue))
			{
				this.returnValue = null;
			}
			else if (IOUtil.FlagTest(this.messageEnum, MessageEnum.ReturnValueVoid))
			{
				this.returnValue = BinaryMethodReturn.instanceOfVoid;
			}
			else if (IOUtil.FlagTest(this.messageEnum, MessageEnum.ReturnValueInline))
			{
				this.returnValue = IOUtil.ReadWithCode(input);
			}
			if (IOUtil.FlagTest(this.messageEnum, MessageEnum.ContextInline))
			{
				this.scallContext = (string)IOUtil.ReadWithCode(input);
				this.callContext = new LogicalCallContext
				{
					RemotingData = 
					{
						LogicalCallID = this.scallContext
					}
				};
			}
			if (IOUtil.FlagTest(this.messageEnum, MessageEnum.ArgsInline))
			{
				this.args = IOUtil.ReadArgs(input);
			}
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x0007D784 File Offset: 0x0007B984
		[SecurityCritical]
		internal IMethodReturnMessage ReadArray(object[] returnA, IMethodCallMessage methodCallMessage, object handlerObject)
		{
			if (IOUtil.FlagTest(this.messageEnum, MessageEnum.ArgsIsArray))
			{
				this.args = returnA;
			}
			else
			{
				int num = 0;
				if (IOUtil.FlagTest(this.messageEnum, MessageEnum.ArgsInArray))
				{
					if (returnA.Length < num)
					{
						throw new SerializationException(Environment.GetResourceString("Invalid MethodCall or MethodReturn stream format."));
					}
					this.args = (object[])returnA[num++];
				}
				if (IOUtil.FlagTest(this.messageEnum, MessageEnum.ReturnValueInArray))
				{
					if (returnA.Length < num)
					{
						throw new SerializationException(Environment.GetResourceString("Invalid MethodCall or MethodReturn stream format."));
					}
					this.returnValue = returnA[num++];
				}
				if (IOUtil.FlagTest(this.messageEnum, MessageEnum.ExceptionInArray))
				{
					if (returnA.Length < num)
					{
						throw new SerializationException(Environment.GetResourceString("Invalid MethodCall or MethodReturn stream format."));
					}
					this.exception = (Exception)returnA[num++];
				}
				if (IOUtil.FlagTest(this.messageEnum, MessageEnum.ContextInArray))
				{
					if (returnA.Length < num)
					{
						throw new SerializationException(Environment.GetResourceString("Invalid MethodCall or MethodReturn stream format."));
					}
					this.callContext = returnA[num++];
				}
				if (IOUtil.FlagTest(this.messageEnum, MessageEnum.PropertyInArray))
				{
					if (returnA.Length < num)
					{
						throw new SerializationException(Environment.GetResourceString("Invalid MethodCall or MethodReturn stream format."));
					}
					this.properties = returnA[num++];
				}
			}
			return new MethodResponse(methodCallMessage, handlerObject, new BinaryMethodReturnMessage(this.returnValue, this.args, this.exception, (LogicalCallContext)this.callContext, (object[])this.properties));
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x00002A7D File Offset: 0x00000C7D
		public void Dump()
		{
		}

		// Token: 0x04000CED RID: 3309
		private object returnValue;

		// Token: 0x04000CEE RID: 3310
		private object[] args;

		// Token: 0x04000CEF RID: 3311
		private Exception exception;

		// Token: 0x04000CF0 RID: 3312
		private object callContext;

		// Token: 0x04000CF1 RID: 3313
		private string scallContext;

		// Token: 0x04000CF2 RID: 3314
		private object properties;

		// Token: 0x04000CF3 RID: 3315
		private Type[] argTypes;

		// Token: 0x04000CF4 RID: 3316
		private bool bArgsPrimitive = true;

		// Token: 0x04000CF5 RID: 3317
		private MessageEnum messageEnum;

		// Token: 0x04000CF6 RID: 3318
		private object[] callA;

		// Token: 0x04000CF7 RID: 3319
		private Type returnType;

		// Token: 0x04000CF8 RID: 3320
		private static object instanceOfVoid = FormatterServices.GetUninitializedObject(Converter.typeofSystemVoid);
	}
}
