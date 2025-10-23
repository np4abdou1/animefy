using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Defines and creates generic type parameters for dynamically defined generic types and methods. This class cannot be inherited. </summary>
	// Token: 0x02000500 RID: 1280
	[ComVisible(true)]
	[StructLayout(0)]
	public sealed class GenericTypeParameterBuilder : TypeInfo
	{
		// Token: 0x06002518 RID: 9496 RVA: 0x0000B18D File Offset: 0x0000938D
		protected override TypeAttributes GetAttributeFlagsImpl()
		{
			return TypeAttributes.Public;
		}

		// Token: 0x06002519 RID: 9497 RVA: 0x00090A35 File Offset: 0x0008EC35
		protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw this.not_supported();
		}

		/// <summary>Not supported for incomplete generic type parameters.</summary>
		/// <param name="bindingAttr">Not supported.</param>
		/// <returns>Not supported for incomplete generic type parameters.</returns>
		/// <exception cref="T:System.NotSupportedException">In all cases. </exception>
		// Token: 0x0600251A RID: 9498 RVA: 0x00090A35 File Offset: 0x0008EC35
		[ComVisible(true)]
		public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			throw this.not_supported();
		}

		/// <summary>Not supported for incomplete generic type parameters.</summary>
		/// <param name="name">Not supported.</param>
		/// <param name="bindingAttr">Not supported. </param>
		/// <returns>Not supported for incomplete generic type parameters.</returns>
		/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
		// Token: 0x0600251B RID: 9499 RVA: 0x00090A35 File Offset: 0x0008EC35
		public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			throw this.not_supported();
		}

		/// <summary>Not supported for incomplete generic type parameters.</summary>
		/// <param name="bindingAttr">Not supported.</param>
		/// <returns>Not supported for incomplete generic type parameters.</returns>
		/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
		// Token: 0x0600251C RID: 9500 RVA: 0x00090A35 File Offset: 0x0008EC35
		public override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			throw this.not_supported();
		}

		/// <summary>Not supported for incomplete generic type parameters.</summary>
		/// <param name="name">Not supported.</param>
		/// <param name="bindingAttr">Not supported.</param>
		/// <returns>Not supported for incomplete generic type parameters.</returns>
		/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
		// Token: 0x0600251D RID: 9501 RVA: 0x00090A35 File Offset: 0x0008EC35
		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			throw this.not_supported();
		}

		/// <summary>Not supported for incomplete generic type parameters.</summary>
		/// <param name="bindingAttr">Not supported.</param>
		/// <returns>Not supported for incomplete generic type parameters.</returns>
		/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
		// Token: 0x0600251E RID: 9502 RVA: 0x00090A35 File Offset: 0x0008EC35
		public override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			throw this.not_supported();
		}

		/// <summary>Not supported for incomplete generic type parameters.</summary>
		/// <returns>Not supported for incomplete generic type parameters.</returns>
		/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
		// Token: 0x0600251F RID: 9503 RVA: 0x00090A35 File Offset: 0x0008EC35
		public override Type[] GetInterfaces()
		{
			throw this.not_supported();
		}

		/// <summary>Not supported for incomplete generic type parameters.</summary>
		/// <param name="bindingAttr">Not supported.</param>
		/// <returns>Not supported for incomplete generic type parameters.</returns>
		/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
		// Token: 0x06002520 RID: 9504 RVA: 0x00090A35 File Offset: 0x0008EC35
		public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			throw this.not_supported();
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x00090A35 File Offset: 0x0008EC35
		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw this.not_supported();
		}

		/// <summary>Not supported for incomplete generic type parameters.</summary>
		/// <param name="name">Not supported.</param>
		/// <param name="bindingAttr">Not supported.</param>
		/// <returns>Not supported for incomplete generic type parameters.</returns>
		/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
		// Token: 0x06002522 RID: 9506 RVA: 0x00090A35 File Offset: 0x0008EC35
		public override Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			throw this.not_supported();
		}

		/// <summary>Not supported for incomplete generic type parameters.</summary>
		/// <param name="bindingAttr">Not supported.</param>
		/// <returns>Not supported for incomplete generic type parameters.</returns>
		/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
		// Token: 0x06002523 RID: 9507 RVA: 0x00090A35 File Offset: 0x0008EC35
		public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			throw this.not_supported();
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x00090A35 File Offset: 0x0008EC35
		protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			throw this.not_supported();
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool HasElementTypeImpl()
		{
			return false;
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool IsArrayImpl()
		{
			return false;
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool IsByRefImpl()
		{
			return false;
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool IsCOMObjectImpl()
		{
			return false;
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool IsPointerImpl()
		{
			return false;
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected override bool IsPrimitiveImpl()
		{
			return false;
		}

		/// <summary>Not supported for incomplete generic type parameters.</summary>
		/// <param name="name">Not supported. </param>
		/// <param name="invokeAttr">Not supported.</param>
		/// <param name="binder">Not supported.</param>
		/// <param name="target">Not supported.</param>
		/// <param name="args">Not supported.</param>
		/// <param name="modifiers">Not supported.</param>
		/// <param name="culture">Not supported.</param>
		/// <param name="namedParameters">Not supported.</param>
		/// <returns>Not supported for incomplete generic type parameters.</returns>
		/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
		// Token: 0x0600252B RID: 9515 RVA: 0x00090A35 File Offset: 0x0008EC35
		public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
		{
			throw this.not_supported();
		}

		/// <summary>Throws a <see cref="T:System.NotSupportedException" /> in all cases. </summary>
		/// <returns>The type referred to by the current array type, pointer type, or <see langword="ByRef" /> type; or <see langword="null" /> if the current type is not an array type, is not a pointer type, and is not passed by reference.</returns>
		/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
		// Token: 0x0600252C RID: 9516 RVA: 0x00090A35 File Offset: 0x0008EC35
		public override Type GetElementType()
		{
			throw this.not_supported();
		}

		/// <summary>Gets the current generic type parameter.</summary>
		/// <returns>The current <see cref="T:System.Reflection.Emit.GenericTypeParameterBuilder" /> object.</returns>
		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x0600252D RID: 9517 RVA: 0x0000245A File Offset: 0x0000065A
		public override Type UnderlyingSystemType
		{
			get
			{
				return this;
			}
		}

		/// <summary>Gets an <see cref="T:System.Reflection.Assembly" /> object representing the dynamic assembly that contains the generic type definition the current type parameter belongs to.</summary>
		/// <returns>An <see cref="T:System.Reflection.Assembly" /> object representing the dynamic assembly that contains the generic type definition the current type parameter belongs to.</returns>
		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x00090A3D File Offset: 0x0008EC3D
		public override Assembly Assembly
		{
			get
			{
				return this.tbuilder.Assembly;
			}
		}

		/// <summary>Gets <see langword="null" /> in all cases.</summary>
		/// <returns>A null reference (<see langword="Nothing" /> in Visual Basic) in all cases.</returns>
		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x0600252F RID: 9519 RVA: 0x0002AC82 File Offset: 0x00028E82
		public override string AssemblyQualifiedName
		{
			get
			{
				return null;
			}
		}

		/// <summary>Gets the base type constraint of the current generic type parameter.</summary>
		/// <returns>A <see cref="T:System.Type" /> object that represents the base type constraint of the generic type parameter, or <see langword="null" /> if the type parameter has no base type constraint.</returns>
		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06002530 RID: 9520 RVA: 0x00090A4A File Offset: 0x0008EC4A
		public override Type BaseType
		{
			get
			{
				return this.base_type;
			}
		}

		/// <summary>Gets <see langword="null" /> in all cases.</summary>
		/// <returns>A null reference (<see langword="Nothing" /> in Visual Basic) in all cases.</returns>
		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06002531 RID: 9521 RVA: 0x0002AC82 File Offset: 0x00028E82
		public override string FullName
		{
			get
			{
				return null;
			}
		}

		/// <summary>Not supported for incomplete generic type parameters.</summary>
		/// <returns>Not supported for incomplete generic type parameters.</returns>
		/// <exception cref="T:System.NotSupportedException">In all cases. </exception>
		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06002532 RID: 9522 RVA: 0x00090A35 File Offset: 0x0008EC35
		public override Guid GUID
		{
			get
			{
				throw this.not_supported();
			}
		}

		/// <summary>Not supported for incomplete generic type parameters.</summary>
		/// <param name="attributeType">Not supported.</param>
		/// <param name="inherit">Not supported.</param>
		/// <returns>Not supported for incomplete generic type parameters.</returns>
		/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
		// Token: 0x06002533 RID: 9523 RVA: 0x00090A35 File Offset: 0x0008EC35
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw this.not_supported();
		}

		/// <summary>Not supported for incomplete generic type parameters.</summary>
		/// <param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes.</param>
		/// <returns>Not supported for incomplete generic type parameters.</returns>
		/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
		// Token: 0x06002534 RID: 9524 RVA: 0x00090A35 File Offset: 0x0008EC35
		public override object[] GetCustomAttributes(bool inherit)
		{
			throw this.not_supported();
		}

		/// <summary>Not supported for incomplete generic type parameters.</summary>
		/// <param name="attributeType">The type of attribute to search for. Only attributes that are assignable to this type are returned.</param>
		/// <param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes.</param>
		/// <returns>Not supported for incomplete generic type parameters.</returns>
		/// <exception cref="T:System.NotSupportedException">In all cases.</exception>
		// Token: 0x06002535 RID: 9525 RVA: 0x00090A35 File Offset: 0x0008EC35
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw this.not_supported();
		}

		/// <summary>Gets the name of the generic type parameter.</summary>
		/// <returns>The name of the generic type parameter.</returns>
		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06002536 RID: 9526 RVA: 0x00090A52 File Offset: 0x0008EC52
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>Gets <see langword="null" /> in all cases.</summary>
		/// <returns>A null reference (<see langword="Nothing" /> in Visual Basic) in all cases.</returns>
		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06002537 RID: 9527 RVA: 0x0002AC82 File Offset: 0x00028E82
		public override string Namespace
		{
			get
			{
				return null;
			}
		}

		/// <summary>Gets the dynamic module that contains the generic type parameter.</summary>
		/// <returns>A <see cref="T:System.Reflection.Module" /> object that represents the dynamic module that contains the generic type parameter.</returns>
		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06002538 RID: 9528 RVA: 0x00090A5A File Offset: 0x0008EC5A
		public override Module Module
		{
			get
			{
				return this.tbuilder.Module;
			}
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x0002F5C5 File Offset: 0x0002D7C5
		private Exception not_supported()
		{
			return new NotSupportedException();
		}

		// Token: 0x04001227 RID: 4647
		private TypeBuilder tbuilder;

		// Token: 0x04001228 RID: 4648
		private MethodBuilder mbuilder;

		// Token: 0x04001229 RID: 4649
		private string name;

		// Token: 0x0400122A RID: 4650
		private int index;

		// Token: 0x0400122B RID: 4651
		private Type base_type;

		// Token: 0x0400122C RID: 4652
		private Type[] iface_constraints;

		// Token: 0x0400122D RID: 4653
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x0400122E RID: 4654
		private GenericParameterAttributes attrs;
	}
}
