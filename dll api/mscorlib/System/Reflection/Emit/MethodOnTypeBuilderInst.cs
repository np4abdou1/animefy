using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Reflection.Emit
{
	// Token: 0x0200050C RID: 1292
	[StructLayout(0)]
	internal class MethodOnTypeBuilderInst : MethodInfo
	{
		// Token: 0x0600259D RID: 9629 RVA: 0x00092C7E File Offset: 0x00090E7E
		public MethodOnTypeBuilderInst(TypeBuilderInstantiation instantiation, MethodInfo base_method)
		{
			this.instantiation = instantiation;
			this.base_method = base_method;
		}

		// Token: 0x0600259E RID: 9630 RVA: 0x00092C94 File Offset: 0x00090E94
		internal MethodOnTypeBuilderInst(MethodOnTypeBuilderInst gmd, Type[] typeArguments)
		{
			this.instantiation = gmd.instantiation;
			this.base_method = gmd.base_method;
			this.method_arguments = new Type[typeArguments.Length];
			typeArguments.CopyTo(this.method_arguments, 0);
			this.generic_method_definition = gmd;
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x00092CE4 File Offset: 0x00090EE4
		internal MethodOnTypeBuilderInst(MethodInfo method, Type[] typeArguments)
		{
			this.instantiation = method.DeclaringType;
			this.base_method = MethodOnTypeBuilderInst.ExtractBaseMethod(method);
			this.method_arguments = new Type[typeArguments.Length];
			typeArguments.CopyTo(this.method_arguments, 0);
			if (this.base_method != method)
			{
				this.generic_method_definition = method;
			}
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x00092D40 File Offset: 0x00090F40
		private static MethodInfo ExtractBaseMethod(MethodInfo info)
		{
			if (info is MethodBuilder)
			{
				return info;
			}
			if (info is MethodOnTypeBuilderInst)
			{
				return ((MethodOnTypeBuilderInst)info).base_method;
			}
			if (info.IsGenericMethod)
			{
				info = info.GetGenericMethodDefinition();
			}
			Type declaringType = info.DeclaringType;
			if (!declaringType.IsGenericType || declaringType.IsGenericTypeDefinition)
			{
				return info;
			}
			return (MethodInfo)declaringType.Module.ResolveMethod(info.MetadataToken);
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x00092DAC File Offset: 0x00090FAC
		internal MethodInfo RuntimeResolve()
		{
			MethodInfo methodInfo = this.instantiation.InternalResolve().GetMethod(this.base_method);
			if (this.method_arguments != null)
			{
				Type[] array = new Type[this.method_arguments.Length];
				for (int i = 0; i < this.method_arguments.Length; i++)
				{
					array[i] = this.method_arguments[i].InternalResolve();
				}
				methodInfo = methodInfo.MakeGenericMethod(array);
			}
			return methodInfo;
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060025A2 RID: 9634 RVA: 0x00092E12 File Offset: 0x00091012
		public override Type DeclaringType
		{
			get
			{
				return this.instantiation;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x060025A3 RID: 9635 RVA: 0x00092E1A File Offset: 0x0009101A
		public override string Name
		{
			get
			{
				return this.base_method.Name;
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060025A4 RID: 9636 RVA: 0x00092E12 File Offset: 0x00091012
		public override Type ReflectedType
		{
			get
			{
				return this.instantiation;
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x060025A5 RID: 9637 RVA: 0x00092E27 File Offset: 0x00091027
		public override Type ReturnType
		{
			get
			{
				return this.base_method.ReturnType;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x060025A6 RID: 9638 RVA: 0x00092E34 File Offset: 0x00091034
		public override Module Module
		{
			get
			{
				return this.base_method.Module;
			}
		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override object[] GetCustomAttributes(bool inherit)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw new NotSupportedException();
		}

		// Token: 0x060025AA RID: 9642 RVA: 0x00092E44 File Offset: 0x00091044
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder(this.ReturnType.ToString());
			stringBuilder.Append(" ");
			stringBuilder.Append(this.base_method.Name);
			stringBuilder.Append("(");
			stringBuilder.Append(")");
			return stringBuilder.ToString();
		}

		// Token: 0x060025AB RID: 9643 RVA: 0x00092E9C File Offset: 0x0009109C
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			return this.base_method.GetMethodImplementationFlags();
		}

		// Token: 0x060025AC RID: 9644 RVA: 0x00090369 File Offset: 0x0008E569
		public override ParameterInfo[] GetParameters()
		{
			return this.GetParametersInternal();
		}

		// Token: 0x060025AD RID: 9645 RVA: 0x0002AD12 File Offset: 0x00028F12
		internal override ParameterInfo[] GetParametersInternal()
		{
			throw new NotSupportedException();
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x060025AE RID: 9646 RVA: 0x0008FD7A File Offset: 0x0008DF7A
		public override int MetadataToken
		{
			get
			{
				return base.MetadataToken;
			}
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x00092EA9 File Offset: 0x000910A9
		internal override int GetParametersCount()
		{
			return this.base_method.GetParametersCount();
		}

		// Token: 0x060025B0 RID: 9648 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x060025B1 RID: 9649 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override RuntimeMethodHandle MethodHandle
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x060025B2 RID: 9650 RVA: 0x00092EB6 File Offset: 0x000910B6
		public override MethodAttributes Attributes
		{
			get
			{
				return this.base_method.Attributes;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x060025B3 RID: 9651 RVA: 0x00092EC3 File Offset: 0x000910C3
		public override CallingConventions CallingConvention
		{
			get
			{
				return this.base_method.CallingConvention;
			}
		}

		// Token: 0x060025B4 RID: 9652 RVA: 0x00092ED0 File Offset: 0x000910D0
		public override MethodInfo MakeGenericMethod(params Type[] methodInstantiation)
		{
			if (!this.base_method.IsGenericMethodDefinition || this.method_arguments != null)
			{
				throw new InvalidOperationException("Method is not a generic method definition");
			}
			if (methodInstantiation == null)
			{
				throw new ArgumentNullException("methodInstantiation");
			}
			if (this.base_method.GetGenericArguments().Length != methodInstantiation.Length)
			{
				throw new ArgumentException("Incorrect length", "methodInstantiation");
			}
			for (int i = 0; i < methodInstantiation.Length; i++)
			{
				if (methodInstantiation[i] == null)
				{
					throw new ArgumentNullException("methodInstantiation");
				}
			}
			return new MethodOnTypeBuilderInst(this, methodInstantiation);
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x00092F5C File Offset: 0x0009115C
		public override Type[] GetGenericArguments()
		{
			if (!this.base_method.IsGenericMethodDefinition)
			{
				return null;
			}
			Type[] array = this.method_arguments ?? this.base_method.GetGenericArguments();
			Type[] array2 = new Type[array.Length];
			array.CopyTo(array2, 0);
			return array2;
		}

		// Token: 0x060025B6 RID: 9654 RVA: 0x00092F9E File Offset: 0x0009119E
		public override MethodInfo GetGenericMethodDefinition()
		{
			return this.generic_method_definition ?? this.base_method;
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x060025B7 RID: 9655 RVA: 0x00092FB0 File Offset: 0x000911B0
		public override bool ContainsGenericParameters
		{
			get
			{
				if (this.base_method.ContainsGenericParameters)
				{
					return true;
				}
				if (!this.base_method.IsGenericMethodDefinition)
				{
					throw new NotSupportedException();
				}
				if (this.method_arguments == null)
				{
					return true;
				}
				Type[] array = this.method_arguments;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].ContainsGenericParameters)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x060025B8 RID: 9656 RVA: 0x0009300B File Offset: 0x0009120B
		public override bool IsGenericMethodDefinition
		{
			get
			{
				return this.base_method.IsGenericMethodDefinition && this.method_arguments == null;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x060025B9 RID: 9657 RVA: 0x00093025 File Offset: 0x00091225
		public override bool IsGenericMethod
		{
			get
			{
				return this.base_method.IsGenericMethodDefinition;
			}
		}

		// Token: 0x060025BA RID: 9658 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override MethodInfo GetBaseDefinition()
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x060025BB RID: 9659 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override ParameterInfo ReturnParameter
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x04001279 RID: 4729
		private Type instantiation;

		// Token: 0x0400127A RID: 4730
		private MethodInfo base_method;

		// Token: 0x0400127B RID: 4731
		private Type[] method_arguments;

		// Token: 0x0400127C RID: 4732
		private MethodInfo generic_method_definition;
	}
}
