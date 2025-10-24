using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	// Token: 0x020004EA RID: 1258
	[StructLayout(0)]
	internal abstract class SymbolType : TypeInfo
	{
		// Token: 0x06002417 RID: 9239 RVA: 0x00036AFD File Offset: 0x00034CFD
		public override bool IsAssignableFrom(TypeInfo typeInfo)
		{
			return !(typeInfo == null) && this.IsAssignableFrom(typeInfo.AsType());
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06002418 RID: 9240 RVA: 0x0008EEBB File Offset: 0x0008D0BB
		public override Guid GUID
		{
			get
			{
				throw new NotSupportedException(Environment.GetResourceString("Not supported in a non-reflected type."));
			}
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x0008EEBB File Offset: 0x0008D0BB
		public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
		{
			throw new NotSupportedException(Environment.GetResourceString("Not supported in a non-reflected type."));
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x0600241A RID: 9242 RVA: 0x0008EECC File Offset: 0x0008D0CC
		public override Module Module
		{
			get
			{
				Type baseType = this.m_baseType;
				while (baseType is SymbolType)
				{
					baseType = ((SymbolType)baseType).m_baseType;
				}
				return baseType.Module;
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x0600241B RID: 9243 RVA: 0x0008EEFC File Offset: 0x0008D0FC
		public override Assembly Assembly
		{
			get
			{
				Type baseType = this.m_baseType;
				while (baseType is SymbolType)
				{
					baseType = ((SymbolType)baseType).m_baseType;
				}
				return baseType.Assembly;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x0600241C RID: 9244 RVA: 0x0008EEBB File Offset: 0x0008D0BB
		public override RuntimeTypeHandle TypeHandle
		{
			get
			{
				throw new NotSupportedException(Environment.GetResourceString("Not supported in a non-reflected type."));
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x0600241D RID: 9245 RVA: 0x0008EF2C File Offset: 0x0008D12C
		public override string Namespace
		{
			get
			{
				return this.m_baseType.Namespace;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x0600241E RID: 9246 RVA: 0x0008EF39 File Offset: 0x0008D139
		public override Type BaseType
		{
			get
			{
				return typeof(Array);
			}
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x0008EEBB File Offset: 0x0008D0BB
		protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw new NotSupportedException(Environment.GetResourceString("Not supported in a non-reflected type."));
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x0008EEBB File Offset: 0x0008D0BB
		[ComVisible(true)]
		public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			throw new NotSupportedException(Environment.GetResourceString("Not supported in a non-reflected type."));
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x0008EEBB File Offset: 0x0008D0BB
		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw new NotSupportedException(Environment.GetResourceString("Not supported in a non-reflected type."));
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x0008EEBB File Offset: 0x0008D0BB
		public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			throw new NotSupportedException(Environment.GetResourceString("Not supported in a non-reflected type."));
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x0008EEBB File Offset: 0x0008D0BB
		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			throw new NotSupportedException(Environment.GetResourceString("Not supported in a non-reflected type."));
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x0008EEBB File Offset: 0x0008D0BB
		public override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			throw new NotSupportedException(Environment.GetResourceString("Not supported in a non-reflected type."));
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x0008EEBB File Offset: 0x0008D0BB
		public override Type[] GetInterfaces()
		{
			throw new NotSupportedException(Environment.GetResourceString("Not supported in a non-reflected type."));
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x0008EEBB File Offset: 0x0008D0BB
		public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			throw new NotSupportedException(Environment.GetResourceString("Not supported in a non-reflected type."));
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x0008EEBB File Offset: 0x0008D0BB
		protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			throw new NotSupportedException(Environment.GetResourceString("Not supported in a non-reflected type."));
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x0008EEBB File Offset: 0x0008D0BB
		public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			throw new NotSupportedException(Environment.GetResourceString("Not supported in a non-reflected type."));
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x0008EEBB File Offset: 0x0008D0BB
		public override Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			throw new NotSupportedException(Environment.GetResourceString("Not supported in a non-reflected type."));
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x0008EEBB File Offset: 0x0008D0BB
		public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr)
		{
			throw new NotSupportedException(Environment.GetResourceString("Not supported in a non-reflected type."));
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x0008EEBB File Offset: 0x0008D0BB
		public override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			throw new NotSupportedException(Environment.GetResourceString("Not supported in a non-reflected type."));
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x0008EF48 File Offset: 0x0008D148
		protected override TypeAttributes GetAttributeFlagsImpl()
		{
			Type baseType = this.m_baseType;
			while (baseType is SymbolType)
			{
				baseType = ((SymbolType)baseType).m_baseType;
			}
			return baseType.Attributes;
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool IsPrimitiveImpl()
		{
			return false;
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool IsValueTypeImpl()
		{
			return false;
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool IsCOMObjectImpl()
		{
			return false;
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06002430 RID: 9264 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public override bool IsConstructedGenericType
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x0008EF78 File Offset: 0x0008D178
		public override Type GetElementType()
		{
			return this.m_baseType;
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x0008EF80 File Offset: 0x0008D180
		protected override bool HasElementTypeImpl()
		{
			return this.m_baseType != null;
		}

		// Token: 0x06002433 RID: 9267 RVA: 0x0008EEBB File Offset: 0x0008D0BB
		public override object[] GetCustomAttributes(bool inherit)
		{
			throw new NotSupportedException(Environment.GetResourceString("Not supported in a non-reflected type."));
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x0008EEBB File Offset: 0x0008D0BB
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw new NotSupportedException(Environment.GetResourceString("Not supported in a non-reflected type."));
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x0008EEBB File Offset: 0x0008D0BB
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw new NotSupportedException(Environment.GetResourceString("Not supported in a non-reflected type."));
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x0008EF8E File Offset: 0x0008D18E
		internal SymbolType(Type elementType)
		{
			this.m_baseType = elementType;
		}

		// Token: 0x06002437 RID: 9271
		internal abstract string FormatName(string elementName);

		// Token: 0x06002438 RID: 9272 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool IsArrayImpl()
		{
			return false;
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool IsByRefImpl()
		{
			return false;
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool IsPointerImpl()
		{
			return false;
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x0008EF9D File Offset: 0x0008D19D
		public override Type MakeArrayType()
		{
			return new ArrayType(this, 0);
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x0008EFA6 File Offset: 0x0008D1A6
		public override Type MakeArrayType(int rank)
		{
			if (rank < 1)
			{
				throw new IndexOutOfRangeException();
			}
			return new ArrayType(this, rank);
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x0008EFB9 File Offset: 0x0008D1B9
		public override Type MakeByRefType()
		{
			return new ByRefType(this);
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x0008EFC1 File Offset: 0x0008D1C1
		public override Type MakePointerType()
		{
			return new PointerType(this);
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x0008EFC9 File Offset: 0x0008D1C9
		public override string ToString()
		{
			return this.FormatName(this.m_baseType.ToString());
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06002440 RID: 9280 RVA: 0x0008EFDC File Offset: 0x0008D1DC
		public override string AssemblyQualifiedName
		{
			get
			{
				string text = this.FormatName(this.m_baseType.FullName);
				if (text == null)
				{
					return null;
				}
				return text + ", " + this.m_baseType.Assembly.FullName;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06002441 RID: 9281 RVA: 0x0008F01B File Offset: 0x0008D21B
		public override string FullName
		{
			get
			{
				return this.FormatName(this.m_baseType.FullName);
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06002442 RID: 9282 RVA: 0x0008F02E File Offset: 0x0008D22E
		public override string Name
		{
			get
			{
				return this.FormatName(this.m_baseType.Name);
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06002443 RID: 9283 RVA: 0x0000245A File Offset: 0x0000065A
		public override Type UnderlyingSystemType
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06002444 RID: 9284 RVA: 0x0008F041 File Offset: 0x0008D241
		internal override bool IsUserType
		{
			get
			{
				return this.m_baseType.IsUserType;
			}
		}

		// Token: 0x06002445 RID: 9285 RVA: 0x0008F04E File Offset: 0x0008D24E
		internal override Type RuntimeResolve()
		{
			return this.InternalResolve();
		}

		// Token: 0x04001198 RID: 4504
		internal Type m_baseType;
	}
}
