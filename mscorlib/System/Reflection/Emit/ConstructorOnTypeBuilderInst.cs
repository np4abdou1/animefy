using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	// Token: 0x020004F2 RID: 1266
	[StructLayout(0)]
	internal class ConstructorOnTypeBuilderInst : ConstructorInfo
	{
		// Token: 0x0600247E RID: 9342 RVA: 0x0008FBAA File Offset: 0x0008DDAA
		public ConstructorOnTypeBuilderInst(TypeBuilderInstantiation instantiation, ConstructorInfo cb)
		{
			this.instantiation = instantiation;
			this.cb = cb;
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x0600247F RID: 9343 RVA: 0x0008FBC0 File Offset: 0x0008DDC0
		public override Type DeclaringType
		{
			get
			{
				return this.instantiation;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06002480 RID: 9344 RVA: 0x0008FBC8 File Offset: 0x0008DDC8
		public override string Name
		{
			get
			{
				return this.cb.Name;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06002481 RID: 9345 RVA: 0x0008FBC0 File Offset: 0x0008DDC0
		public override Type ReflectedType
		{
			get
			{
				return this.instantiation;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06002482 RID: 9346 RVA: 0x0008FBD5 File Offset: 0x0008DDD5
		public override Module Module
		{
			get
			{
				return this.cb.Module;
			}
		}

		// Token: 0x06002483 RID: 9347 RVA: 0x0008FBE2 File Offset: 0x0008DDE2
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return this.cb.IsDefined(attributeType, inherit);
		}

		// Token: 0x06002484 RID: 9348 RVA: 0x0008FBF1 File Offset: 0x0008DDF1
		public override object[] GetCustomAttributes(bool inherit)
		{
			return this.cb.GetCustomAttributes(inherit);
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x0008FBFF File Offset: 0x0008DDFF
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return this.cb.GetCustomAttributes(attributeType, inherit);
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x0008FC0E File Offset: 0x0008DE0E
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return this.cb.GetMethodImplementationFlags();
		}

		// Token: 0x06002487 RID: 9351 RVA: 0x0008FC1B File Offset: 0x0008DE1B
		public override ParameterInfo[] GetParameters()
		{
			if (!this.instantiation.IsCreated)
			{
				throw new NotSupportedException();
			}
			return this.GetParametersInternal();
		}

		// Token: 0x06002488 RID: 9352 RVA: 0x0008FC38 File Offset: 0x0008DE38
		internal override ParameterInfo[] GetParametersInternal()
		{
			ParameterInfo[] array;
			if (this.cb is ConstructorBuilder)
			{
				ConstructorBuilder constructorBuilder = (ConstructorBuilder)this.cb;
				array = new ParameterInfo[constructorBuilder.parameters.Length];
				for (int i = 0; i < constructorBuilder.parameters.Length; i++)
				{
					Type type = this.instantiation.InflateType(constructorBuilder.parameters[i]);
					ParameterInfo[] array2 = array;
					int num = i;
					ParameterBuilder[] pinfo = constructorBuilder.pinfo;
					array2[num] = RuntimeParameterInfo.New((pinfo != null) ? pinfo[i] : null, type, this, i + 1);
				}
			}
			else
			{
				ParameterInfo[] parameters = this.cb.GetParameters();
				array = new ParameterInfo[parameters.Length];
				for (int j = 0; j < parameters.Length; j++)
				{
					Type type2 = this.instantiation.InflateType(parameters[j].ParameterType);
					array[j] = RuntimeParameterInfo.New(parameters[j], type2, this, j + 1);
				}
			}
			return array;
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x0008FD08 File Offset: 0x0008DF08
		internal override Type[] GetParameterTypes()
		{
			if (this.cb is ConstructorBuilder)
			{
				return (this.cb as ConstructorBuilder).parameters;
			}
			ParameterInfo[] parameters = this.cb.GetParameters();
			Type[] array = new Type[parameters.Length];
			for (int i = 0; i < parameters.Length; i++)
			{
				array[i] = parameters[i].ParameterType;
			}
			return array;
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x0008FD62 File Offset: 0x0008DF62
		internal ConstructorInfo RuntimeResolve()
		{
			return this.instantiation.InternalResolve().GetConstructor(this.cb);
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x0600248B RID: 9355 RVA: 0x0008FD7A File Offset: 0x0008DF7A
		public override int MetadataToken
		{
			get
			{
				return base.MetadataToken;
			}
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x0008FD82 File Offset: 0x0008DF82
		internal override int GetParametersCount()
		{
			return this.cb.GetParametersCount();
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x0008FD8F File Offset: 0x0008DF8F
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			return this.cb.Invoke(obj, invokeAttr, binder, parameters, culture);
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x0600248E RID: 9358 RVA: 0x0008FDA3 File Offset: 0x0008DFA3
		public override RuntimeMethodHandle MethodHandle
		{
			get
			{
				return this.cb.MethodHandle;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x0600248F RID: 9359 RVA: 0x0008FDB0 File Offset: 0x0008DFB0
		public override MethodAttributes Attributes
		{
			get
			{
				return this.cb.Attributes;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06002490 RID: 9360 RVA: 0x0008FDBD File Offset: 0x0008DFBD
		public override CallingConventions CallingConvention
		{
			get
			{
				return this.cb.CallingConvention;
			}
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x0008FDCA File Offset: 0x0008DFCA
		public override Type[] GetGenericArguments()
		{
			return this.cb.GetGenericArguments();
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06002492 RID: 9362 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public override bool ContainsGenericParameters
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06002493 RID: 9363 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public override bool IsGenericMethodDefinition
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06002494 RID: 9364 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public override bool IsGenericMethod
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x0008A04D File Offset: 0x0008824D
		public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x040011EC RID: 4588
		internal TypeBuilderInstantiation instantiation;

		// Token: 0x040011ED RID: 4589
		internal ConstructorInfo cb;
	}
}
