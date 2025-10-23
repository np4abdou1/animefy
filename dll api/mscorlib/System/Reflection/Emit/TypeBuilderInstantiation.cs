using System;
using System.Collections;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Reflection.Emit
{
	// Token: 0x02000519 RID: 1305
	[StructLayout(0)]
	internal sealed class TypeBuilderInstantiation : TypeInfo
	{
		// Token: 0x06002661 RID: 9825 RVA: 0x00096A6D File Offset: 0x00094C6D
		internal TypeBuilderInstantiation(Type tb, Type[] args)
		{
			this.generic_type = tb;
			this.type_arguments = args;
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x00096A84 File Offset: 0x00094C84
		internal override Type InternalResolve()
		{
			Type type = this.generic_type.InternalResolve();
			Type[] array = new Type[this.type_arguments.Length];
			for (int i = 0; i < this.type_arguments.Length; i++)
			{
				array[i] = this.type_arguments[i].InternalResolve();
			}
			return type.MakeGenericType(array);
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x00096AD8 File Offset: 0x00094CD8
		internal override Type RuntimeResolve()
		{
			TypeBuilder typeBuilder = this.generic_type as TypeBuilder;
			if (typeBuilder != null && !typeBuilder.IsCreated())
			{
				AppDomain.CurrentDomain.DoTypeBuilderResolve(typeBuilder);
			}
			for (int i = 0; i < this.type_arguments.Length; i++)
			{
				TypeBuilder typeBuilder2 = this.type_arguments[i] as TypeBuilder;
				if (typeBuilder2 != null && !typeBuilder2.IsCreated())
				{
					AppDomain.CurrentDomain.DoTypeBuilderResolve(typeBuilder2);
				}
			}
			return this.InternalResolve();
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06002664 RID: 9828 RVA: 0x00096B48 File Offset: 0x00094D48
		internal bool IsCreated
		{
			get
			{
				TypeBuilder typeBuilder = this.generic_type as TypeBuilder;
				return !(typeBuilder != null) || typeBuilder.is_created;
			}
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x00096B72 File Offset: 0x00094D72
		internal Type InflateType(Type type)
		{
			return TypeBuilderInstantiation.InflateType(type, this.type_arguments, null);
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x00096B84 File Offset: 0x00094D84
		internal static Type InflateType(Type type, Type[] type_args, Type[] method_args)
		{
			if (type == null)
			{
				return null;
			}
			if (!type.IsGenericParameter && !type.ContainsGenericParameters)
			{
				return type;
			}
			if (type.IsGenericParameter)
			{
				if (type.DeclaringMethod == null)
				{
					if (type_args != null)
					{
						return type_args[type.GenericParameterPosition];
					}
					return type;
				}
				else
				{
					if (method_args != null)
					{
						return method_args[type.GenericParameterPosition];
					}
					return type;
				}
			}
			else
			{
				if (type.IsPointer)
				{
					return TypeBuilderInstantiation.InflateType(type.GetElementType(), type_args, method_args).MakePointerType();
				}
				if (type.IsByRef)
				{
					return TypeBuilderInstantiation.InflateType(type.GetElementType(), type_args, method_args).MakeByRefType();
				}
				if (!type.IsArray)
				{
					Type[] genericArguments = type.GetGenericArguments();
					for (int i = 0; i < genericArguments.Length; i++)
					{
						genericArguments[i] = TypeBuilderInstantiation.InflateType(genericArguments[i], type_args, method_args);
					}
					return (type.IsGenericTypeDefinition ? type : type.GetGenericTypeDefinition()).MakeGenericType(genericArguments);
				}
				if (type.GetArrayRank() > 1)
				{
					return TypeBuilderInstantiation.InflateType(type.GetElementType(), type_args, method_args).MakeArrayType(type.GetArrayRank());
				}
				if (type.ToString().EndsWith("[*]", StringComparison.Ordinal))
				{
					return TypeBuilderInstantiation.InflateType(type.GetElementType(), type_args, method_args).MakeArrayType(1);
				}
				return TypeBuilderInstantiation.InflateType(type.GetElementType(), type_args, method_args).MakeArrayType();
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06002667 RID: 9831 RVA: 0x00096CB3 File Offset: 0x00094EB3
		public override Type BaseType
		{
			get
			{
				return this.generic_type.BaseType;
			}
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override Type[] GetInterfaces()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x00096CC0 File Offset: 0x00094EC0
		protected override bool IsValueTypeImpl()
		{
			return this.generic_type.IsValueType;
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x00096CD0 File Offset: 0x00094ED0
		internal override MethodInfo GetMethod(MethodInfo fromNoninstanciated)
		{
			if (this.methods == null)
			{
				this.methods = new Hashtable();
			}
			if (!this.methods.ContainsKey(fromNoninstanciated))
			{
				this.methods[fromNoninstanciated] = new MethodOnTypeBuilderInst(this, fromNoninstanciated);
			}
			return (MethodInfo)this.methods[fromNoninstanciated];
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x00096D24 File Offset: 0x00094F24
		internal override ConstructorInfo GetConstructor(ConstructorInfo fromNoninstanciated)
		{
			if (this.ctors == null)
			{
				this.ctors = new Hashtable();
			}
			if (!this.ctors.ContainsKey(fromNoninstanciated))
			{
				this.ctors[fromNoninstanciated] = new ConstructorOnTypeBuilderInst(this, fromNoninstanciated);
			}
			return (ConstructorInfo)this.ctors[fromNoninstanciated];
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x00096D78 File Offset: 0x00094F78
		internal override FieldInfo GetField(FieldInfo fromNoninstanciated)
		{
			if (this.fields == null)
			{
				this.fields = new Hashtable();
			}
			if (!this.fields.ContainsKey(fromNoninstanciated))
			{
				this.fields[fromNoninstanciated] = new FieldOnTypeBuilderInst(this, fromNoninstanciated);
			}
			return (FieldInfo)this.fields[fromNoninstanciated];
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override MethodInfo[] GetMethods(BindingFlags bf)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600266E RID: 9838 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override ConstructorInfo[] GetConstructors(BindingFlags bf)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override FieldInfo[] GetFields(BindingFlags bf)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override PropertyInfo[] GetProperties(BindingFlags bf)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override EventInfo[] GetEvents(BindingFlags bf)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override bool IsAssignableFrom(Type c)
		{
			throw new NotSupportedException();
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06002673 RID: 9843 RVA: 0x0000245A File Offset: 0x0000065A
		public override Type UnderlyingSystemType
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06002674 RID: 9844 RVA: 0x00096DCA File Offset: 0x00094FCA
		public override Assembly Assembly
		{
			get
			{
				return this.generic_type.Assembly;
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06002675 RID: 9845 RVA: 0x00096DD7 File Offset: 0x00094FD7
		public override Module Module
		{
			get
			{
				return this.generic_type.Module;
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06002676 RID: 9846 RVA: 0x00096DE4 File Offset: 0x00094FE4
		public override string Name
		{
			get
			{
				return this.generic_type.Name;
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06002677 RID: 9847 RVA: 0x00096DF1 File Offset: 0x00094FF1
		public override string Namespace
		{
			get
			{
				return this.generic_type.Namespace;
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06002678 RID: 9848 RVA: 0x00096DFE File Offset: 0x00094FFE
		public override string FullName
		{
			get
			{
				return this.format_name(true, false);
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06002679 RID: 9849 RVA: 0x00096E08 File Offset: 0x00095008
		public override string AssemblyQualifiedName
		{
			get
			{
				return this.format_name(true, true);
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x0600267A RID: 9850 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override Guid GUID
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x00096E14 File Offset: 0x00095014
		private string format_name(bool full_name, bool assembly_qualified)
		{
			StringBuilder stringBuilder = new StringBuilder(this.generic_type.FullName);
			stringBuilder.Append("[");
			for (int i = 0; i < this.type_arguments.Length; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(",");
				}
				string text;
				if (full_name)
				{
					string fullName = this.type_arguments[i].Assembly.FullName;
					text = this.type_arguments[i].FullName;
					if (text != null && fullName != null)
					{
						text = text + ", " + fullName;
					}
				}
				else
				{
					text = this.type_arguments[i].ToString();
				}
				if (text == null)
				{
					return null;
				}
				if (full_name)
				{
					stringBuilder.Append("[");
				}
				stringBuilder.Append(text);
				if (full_name)
				{
					stringBuilder.Append("]");
				}
			}
			stringBuilder.Append("]");
			if (assembly_qualified)
			{
				stringBuilder.Append(", ");
				stringBuilder.Append(this.generic_type.Assembly.FullName);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x00096F11 File Offset: 0x00095111
		public override string ToString()
		{
			return this.format_name(false, false);
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x00096F1B File Offset: 0x0009511B
		public override Type GetGenericTypeDefinition()
		{
			return this.generic_type;
		}

		// Token: 0x0600267E RID: 9854 RVA: 0x00096F24 File Offset: 0x00095124
		public override Type[] GetGenericArguments()
		{
			Type[] array = new Type[this.type_arguments.Length];
			this.type_arguments.CopyTo(array, 0);
			return array;
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x0600267F RID: 9855 RVA: 0x00096F50 File Offset: 0x00095150
		public override bool ContainsGenericParameters
		{
			get
			{
				Type[] array = this.type_arguments;
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

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06002680 RID: 9856 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public override bool IsGenericTypeDefinition
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06002681 RID: 9857 RVA: 0x0000B18D File Offset: 0x0000938D
		public override bool IsGenericType
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06002682 RID: 9858 RVA: 0x00096F7F File Offset: 0x0009517F
		public override Type DeclaringType
		{
			get
			{
				return this.generic_type.DeclaringType;
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06002683 RID: 9859 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override RuntimeTypeHandle TypeHandle
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x0008EF9D File Offset: 0x0008D19D
		public override Type MakeArrayType()
		{
			return new ArrayType(this, 0);
		}

		// Token: 0x06002685 RID: 9861 RVA: 0x0008EFA6 File Offset: 0x0008D1A6
		public override Type MakeArrayType(int rank)
		{
			if (rank < 1)
			{
				throw new IndexOutOfRangeException();
			}
			return new ArrayType(this, rank);
		}

		// Token: 0x06002686 RID: 9862 RVA: 0x0008EFB9 File Offset: 0x0008D1B9
		public override Type MakeByRefType()
		{
			return new ByRefType(this);
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x0008EFC1 File Offset: 0x0008D1C1
		public override Type MakePointerType()
		{
			return new PointerType(this);
		}

		// Token: 0x06002688 RID: 9864 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override Type GetElementType()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool HasElementTypeImpl()
		{
			return false;
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool IsCOMObjectImpl()
		{
			return false;
		}

		// Token: 0x0600268B RID: 9867 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool IsPrimitiveImpl()
		{
			return false;
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool IsArrayImpl()
		{
			return false;
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool IsByRefImpl()
		{
			return false;
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool IsPointerImpl()
		{
			return false;
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x00096F8C File Offset: 0x0009518C
		protected override TypeAttributes GetAttributeFlagsImpl()
		{
			return this.generic_type.Attributes;
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x0002AD12 File Offset: 0x00028F12
		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x0002AD12 File Offset: 0x00028F12
		protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x0002AD12 File Offset: 0x00028F12
		protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x0002AD12 File Offset: 0x00028F12
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw new NotSupportedException();
		}

		// Token: 0x06002698 RID: 9880 RVA: 0x00096F99 File Offset: 0x00095199
		public override object[] GetCustomAttributes(bool inherit)
		{
			if (this.IsCreated)
			{
				return this.generic_type.GetCustomAttributes(inherit);
			}
			throw new NotSupportedException();
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x00096FB5 File Offset: 0x000951B5
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			if (this.IsCreated)
			{
				return this.generic_type.GetCustomAttributes(attributeType, inherit);
			}
			throw new NotSupportedException();
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x0600269A RID: 9882 RVA: 0x00096FD4 File Offset: 0x000951D4
		internal override bool IsUserType
		{
			get
			{
				Type[] array = this.type_arguments;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].IsUserType)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x00097003 File Offset: 0x00095203
		internal static Type MakeGenericType(Type type, Type[] typeArguments)
		{
			return new TypeBuilderInstantiation(type, typeArguments);
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x0600269C RID: 9884 RVA: 0x0000B18D File Offset: 0x0000938D
		public override bool IsConstructedGenericType
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040013D2 RID: 5074
		internal Type generic_type;

		// Token: 0x040013D3 RID: 5075
		private Type[] type_arguments;

		// Token: 0x040013D4 RID: 5076
		private Hashtable fields;

		// Token: 0x040013D5 RID: 5077
		private Hashtable ctors;

		// Token: 0x040013D6 RID: 5078
		private Hashtable methods;
	}
}
