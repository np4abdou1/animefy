using System;
using System.Collections.Generic;
using System.Globalization;

namespace System.Reflection
{
	// Token: 0x020004BD RID: 1213
	internal abstract class SignatureType : Type
	{
		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x060021F3 RID: 8691 RVA: 0x0000B18D File Offset: 0x0000938D
		public sealed override bool IsSignatureType
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060021F4 RID: 8692
		protected abstract override bool HasElementTypeImpl();

		// Token: 0x060021F5 RID: 8693
		protected abstract override bool IsArrayImpl();

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x060021F6 RID: 8694
		public abstract override bool IsSZArray { get; }

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x060021F7 RID: 8695
		public abstract override bool IsVariableBoundArray { get; }

		// Token: 0x060021F8 RID: 8696
		protected abstract override bool IsByRefImpl();

		// Token: 0x060021F9 RID: 8697
		protected abstract override bool IsPointerImpl();

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x060021FA RID: 8698 RVA: 0x0008ABDB File Offset: 0x00088DDB
		public sealed override bool IsGenericType
		{
			get
			{
				return this.IsGenericTypeDefinition || this.IsConstructedGenericType;
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x060021FB RID: 8699
		public abstract override bool IsGenericTypeDefinition { get; }

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x060021FC RID: 8700
		public abstract override bool IsConstructedGenericType { get; }

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x060021FD RID: 8701
		public abstract override bool IsGenericParameter { get; }

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x060021FE RID: 8702
		public abstract override bool IsGenericMethodParameter { get; }

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x060021FF RID: 8703
		public abstract override bool ContainsGenericParameters { get; }

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06002200 RID: 8704 RVA: 0x0002AC68 File Offset: 0x00028E68
		public sealed override MemberTypes MemberType
		{
			get
			{
				return MemberTypes.TypeInfo;
			}
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x0008ABED File Offset: 0x00088DED
		public sealed override Type MakeArrayType()
		{
			return new SignatureArrayType(this, 1, false);
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x0008ABF7 File Offset: 0x00088DF7
		public sealed override Type MakeArrayType(int rank)
		{
			if (rank <= 0)
			{
				throw new IndexOutOfRangeException();
			}
			return new SignatureArrayType(this, rank, true);
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x0008AC0B File Offset: 0x00088E0B
		public sealed override Type MakeByRefType()
		{
			return new SignatureByRefType(this);
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x0008AC13 File Offset: 0x00088E13
		public sealed override Type MakePointerType()
		{
			return new SignaturePointerType(this);
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override Type MakeGenericType(params Type[] typeArguments)
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x0008AC27 File Offset: 0x00088E27
		public sealed override Type GetElementType()
		{
			return this.ElementType;
		}

		// Token: 0x06002207 RID: 8711
		public abstract override int GetArrayRank();

		// Token: 0x06002208 RID: 8712
		public abstract override Type GetGenericTypeDefinition();

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06002209 RID: 8713
		public abstract override Type[] GenericTypeArguments { get; }

		// Token: 0x0600220A RID: 8714
		public abstract override Type[] GetGenericArguments();

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x0600220B RID: 8715
		public abstract override int GenericParameterPosition { get; }

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x0600220C RID: 8716
		internal abstract SignatureType ElementType { get; }

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x0600220D RID: 8717 RVA: 0x0000245A File Offset: 0x0000065A
		public sealed override Type UnderlyingSystemType
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x0600220E RID: 8718
		public abstract override string Name { get; }

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x0600220F RID: 8719
		public abstract override string Namespace { get; }

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06002210 RID: 8720 RVA: 0x0002AC82 File Offset: 0x00028E82
		public sealed override string FullName
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06002211 RID: 8721 RVA: 0x0002AC82 File Offset: 0x00028E82
		public sealed override string AssemblyQualifiedName
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06002212 RID: 8722
		public abstract override string ToString();

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06002213 RID: 8723 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override Assembly Assembly
		{
			get
			{
				throw new NotSupportedException("This method is not supported on signature types.");
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06002214 RID: 8724 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override Module Module
		{
			get
			{
				throw new NotSupportedException("This method is not supported on signature types.");
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06002215 RID: 8725 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override Type ReflectedType
		{
			get
			{
				throw new NotSupportedException("This method is not supported on signature types.");
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06002216 RID: 8726 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override Type BaseType
		{
			get
			{
				throw new NotSupportedException("This method is not supported on signature types.");
			}
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override Type[] GetInterfaces()
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override bool IsAssignableFrom(Type c)
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06002219 RID: 8729 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override int MetadataToken
		{
			get
			{
				throw new NotSupportedException("This method is not supported on signature types.");
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x0600221A RID: 8730 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override Type DeclaringType
		{
			get
			{
				throw new NotSupportedException("This method is not supported on signature types.");
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x0600221B RID: 8731 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override MethodBase DeclaringMethod
		{
			get
			{
				throw new NotSupportedException("This method is not supported on signature types.");
			}
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override Type[] GetGenericParameterConstraints()
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x0600221D RID: 8733 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override GenericParameterAttributes GenericParameterAttributes
		{
			get
			{
				throw new NotSupportedException("This method is not supported on signature types.");
			}
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override bool IsEnumDefined(object value)
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override string GetEnumName(object value)
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x06002220 RID: 8736 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override string[] GetEnumNames()
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override Type GetEnumUnderlyingType()
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override Array GetEnumValues()
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06002223 RID: 8739 RVA: 0x0008AC30 File Offset: 0x00088E30
		public sealed override Guid GUID
		{
			get
			{
				throw new NotSupportedException("This method is not supported on signature types.");
			}
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x0008AC1B File Offset: 0x00088E1B
		protected sealed override TypeCode GetTypeCodeImpl()
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x0008AC1B File Offset: 0x00088E1B
		protected sealed override TypeAttributes GetAttributeFlagsImpl()
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x06002226 RID: 8742 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x06002227 RID: 8743 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x06002229 RID: 8745 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x0600222A RID: 8746 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x0600222D RID: 8749 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x0600222E RID: 8750 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x0008AC1B File Offset: 0x00088E1B
		protected sealed override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x0008AC1B File Offset: 0x00088E1B
		protected sealed override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override MemberInfo[] GetMember(string name, BindingFlags bindingAttr)
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x06002232 RID: 8754 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x06002233 RID: 8755 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override object[] GetCustomAttributes(bool inherit)
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x06002234 RID: 8756 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x06002235 RID: 8757 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override bool IsDefined(Type attributeType, bool inherit)
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x06002236 RID: 8758 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override IList<CustomAttributeData> GetCustomAttributesData()
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x0008AC1B File Offset: 0x00088E1B
		protected sealed override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x0008AC1B File Offset: 0x00088E1B
		protected sealed override bool IsCOMObjectImpl()
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x0008AC1B File Offset: 0x00088E1B
		protected sealed override bool IsPrimitiveImpl()
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x0600223A RID: 8762 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override IEnumerable<CustomAttributeData> CustomAttributes
		{
			get
			{
				throw new NotSupportedException("This method is not supported on signature types.");
			}
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x0008AC1B File Offset: 0x00088E1B
		protected sealed override bool IsContextfulImpl()
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x0600223C RID: 8764 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override bool IsEnum
		{
			get
			{
				throw new NotSupportedException("This method is not supported on signature types.");
			}
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override bool IsEquivalentTo(Type other)
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override bool IsInstanceOfType(object o)
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x0008AC1B File Offset: 0x00088E1B
		protected sealed override bool IsMarshalByRefImpl()
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06002240 RID: 8768 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override bool IsSerializable
		{
			get
			{
				throw new NotSupportedException("This method is not supported on signature types.");
			}
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x0008AC1B File Offset: 0x00088E1B
		public sealed override bool IsSubclassOf(Type c)
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x0008AC1B File Offset: 0x00088E1B
		protected sealed override bool IsValueTypeImpl()
		{
			throw new NotSupportedException("This method is not supported on signature types.");
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06002243 RID: 8771 RVA: 0x0008AC48 File Offset: 0x00088E48
		public sealed override RuntimeTypeHandle TypeHandle
		{
			get
			{
				throw new NotSupportedException("This method is not supported on signature types.");
			}
		}
	}
}
