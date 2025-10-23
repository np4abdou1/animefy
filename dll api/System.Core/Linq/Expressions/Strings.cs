using System;

namespace System.Linq.Expressions
{
	// Token: 0x020000CA RID: 202
	internal static class Strings
	{
		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x00013C31 File Offset: 0x00011E31
		internal static string ReducibleMustOverrideReduce
		{
			get
			{
				return "reducible nodes must override Expression.Reduce()";
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x00013C38 File Offset: 0x00011E38
		internal static string MustReduceToDifferent
		{
			get
			{
				return "node cannot reduce to itself or null";
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x00013C3F File Offset: 0x00011E3F
		internal static string ReducedNotCompatible
		{
			get
			{
				return "cannot assign from the reduced node type to the original node type";
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x00013C46 File Offset: 0x00011E46
		internal static string SetterHasNoParams
		{
			get
			{
				return "Setter must have parameters.";
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x00013C4D File Offset: 0x00011E4D
		internal static string PropertyCannotHaveRefType
		{
			get
			{
				return "Property cannot have a managed pointer type.";
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x00013C54 File Offset: 0x00011E54
		internal static string IndexesOfSetGetMustMatch
		{
			get
			{
				return "Indexing parameters of getter and setter must match.";
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x00013C5B File Offset: 0x00011E5B
		internal static string AccessorsCannotHaveVarArgs
		{
			get
			{
				return "Accessor method should not have VarArgs.";
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x00013C62 File Offset: 0x00011E62
		internal static string AccessorsCannotHaveByRefArgs
		{
			get
			{
				return "Accessor indexes cannot be passed ByRef.";
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x00013C69 File Offset: 0x00011E69
		internal static string BoundsCannotBeLessThanOne
		{
			get
			{
				return "Bounds count cannot be less than 1";
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00013C70 File Offset: 0x00011E70
		internal static string TypeMustNotBeByRef
		{
			get
			{
				return "Type must not be ByRef";
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x00013C77 File Offset: 0x00011E77
		internal static string TypeMustNotBePointer
		{
			get
			{
				return "Type must not be a pointer type";
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x00013C7E File Offset: 0x00011E7E
		internal static string SetterMustBeVoid
		{
			get
			{
				return "Setter should have void type.";
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x00013C85 File Offset: 0x00011E85
		internal static string PropertyTypeMustMatchGetter
		{
			get
			{
				return "Property type must match the value type of getter";
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x00013C8C File Offset: 0x00011E8C
		internal static string PropertyTypeMustMatchSetter
		{
			get
			{
				return "Property type must match the value type of setter";
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00013C93 File Offset: 0x00011E93
		internal static string BothAccessorsMustBeStatic
		{
			get
			{
				return "Both accessors must be static.";
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x00013C9A File Offset: 0x00011E9A
		internal static string OnlyStaticFieldsHaveNullInstance
		{
			get
			{
				return "Static field requires null instance, non-static field requires non-null instance.";
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x00013CA1 File Offset: 0x00011EA1
		internal static string OnlyStaticPropertiesHaveNullInstance
		{
			get
			{
				return "Static property requires null instance, non-static property requires non-null instance.";
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x00013CA8 File Offset: 0x00011EA8
		internal static string OnlyStaticMethodsHaveNullInstance
		{
			get
			{
				return "Static method requires null instance, non-static method requires non-null instance.";
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x00013CAF File Offset: 0x00011EAF
		internal static string PropertyTypeCannotBeVoid
		{
			get
			{
				return "Property cannot have a void type.";
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x00013CB6 File Offset: 0x00011EB6
		internal static string InvalidUnboxType
		{
			get
			{
				return "Can only unbox from an object or interface type to a value type.";
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x00013CBD File Offset: 0x00011EBD
		internal static string ExpressionMustBeWriteable
		{
			get
			{
				return "Expression must be writeable";
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x00013CC4 File Offset: 0x00011EC4
		internal static string ArgumentMustNotHaveValueType
		{
			get
			{
				return "Argument must not have a value type.";
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x00013CCB File Offset: 0x00011ECB
		internal static string MustBeReducible
		{
			get
			{
				return "must be reducible node";
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x00013CD2 File Offset: 0x00011ED2
		internal static string AllTestValuesMustHaveSameType
		{
			get
			{
				return "All test values must have the same type.";
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x00013CD9 File Offset: 0x00011ED9
		internal static string AllCaseBodiesMustHaveSameType
		{
			get
			{
				return "All case bodies and the default body must have the same type.";
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x00013CE0 File Offset: 0x00011EE0
		internal static string DefaultBodyMustBeSupplied
		{
			get
			{
				return "Default body must be supplied if case bodies are not System.Void.";
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x00013CE7 File Offset: 0x00011EE7
		internal static string LabelMustBeVoidOrHaveExpression
		{
			get
			{
				return "Label type must be System.Void if an expression is not supplied";
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x00013CEE File Offset: 0x00011EEE
		internal static string LabelTypeMustBeVoid
		{
			get
			{
				return "Type must be System.Void for this label argument";
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x00013CF5 File Offset: 0x00011EF5
		internal static string QuotedExpressionMustBeLambda
		{
			get
			{
				return "Quoted expression must be a lambda";
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x00013CFC File Offset: 0x00011EFC
		internal static string CollectionModifiedWhileEnumerating
		{
			get
			{
				return "Collection was modified; enumeration operation may not execute.";
			}
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00013D03 File Offset: 0x00011F03
		internal static string VariableMustNotBeByRef(object p0, object p1)
		{
			return SR.Format("Variable '{0}' uses unsupported type '{1}'. Reference types are not supported for variables.", p0, p1);
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x00013D11 File Offset: 0x00011F11
		internal static string CollectionReadOnly
		{
			get
			{
				return "Collection is read-only.";
			}
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00013D18 File Offset: 0x00011F18
		internal static string AmbiguousMatchInExpandoObject(object p0)
		{
			return SR.Format("More than one key matching '{0}' was found in the ExpandoObject.", p0);
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00013D25 File Offset: 0x00011F25
		internal static string SameKeyExistsInExpando(object p0)
		{
			return SR.Format("An element with the same key '{0}' already exists in the ExpandoObject.", p0);
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00013D32 File Offset: 0x00011F32
		internal static string KeyDoesNotExistInExpando(object p0)
		{
			return SR.Format("The specified key '{0}' does not exist in the ExpandoObject.", p0);
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00013D3F File Offset: 0x00011F3F
		internal static string InvalidMetaObjectCreated(object p0)
		{
			return SR.Format("An IDynamicMetaObjectProvider {0} created an invalid DynamicMetaObject instance.", p0);
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00013D4C File Offset: 0x00011F4C
		internal static string BinderNotCompatibleWithCallSite(object p0, object p1, object p2)
		{
			return SR.Format("The result type '{0}' of the binder '{1}' is not compatible with the result type '{2}' expected by the call site.", p0, p1, p2);
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00013D5B File Offset: 0x00011F5B
		internal static string DynamicBindingNeedsRestrictions(object p0, object p1)
		{
			return SR.Format("The result of the dynamic binding produced by the object with type '{0}' for the binder '{1}' needs at least one restriction.", p0, p1);
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00013D69 File Offset: 0x00011F69
		internal static string DynamicObjectResultNotAssignable(object p0, object p1, object p2, object p3)
		{
			return SR.Format("The result type '{0}' of the dynamic binding produced by the object with type '{1}' for the binder '{2}' is not compatible with the result type '{3}' expected by the call site.", new object[]
			{
				p0,
				p1,
				p2,
				p3
			});
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00013D8B File Offset: 0x00011F8B
		internal static string DynamicBinderResultNotAssignable(object p0, object p1, object p2)
		{
			return SR.Format("The result type '{0}' of the dynamic binding produced by binder '{1}' is not compatible with the result type '{2}' expected by the call site.", p0, p1, p2);
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x00013D9A File Offset: 0x00011F9A
		internal static string BindingCannotBeNull
		{
			get
			{
				return "Bind cannot return null.";
			}
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00013DA1 File Offset: 0x00011FA1
		internal static string DuplicateVariable(object p0)
		{
			return SR.Format("Found duplicate parameter '{0}'. Each ParameterExpression in the list must be a unique object.", p0);
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00013DAE File Offset: 0x00011FAE
		internal static string TypeParameterIsNotDelegate(object p0)
		{
			return SR.Format("Type parameter is {0}. Expected a delegate.", p0);
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x00013DBB File Offset: 0x00011FBB
		internal static string NoOrInvalidRuleProduced
		{
			get
			{
				return "No or Invalid rule produced";
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x00013DC2 File Offset: 0x00011FC2
		internal static string TypeMustBeDerivedFromSystemDelegate
		{
			get
			{
				return "Type must be derived from System.Delegate";
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x00013DC9 File Offset: 0x00011FC9
		internal static string FirstArgumentMustBeCallSite
		{
			get
			{
				return "First argument of delegate must be CallSite";
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x00013DD0 File Offset: 0x00011FD0
		internal static string FaultCannotHaveCatchOrFinally
		{
			get
			{
				return "fault cannot be used with catch or finally clauses";
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x00013DD7 File Offset: 0x00011FD7
		internal static string TryMustHaveCatchFinallyOrFault
		{
			get
			{
				return "try must have at least one catch, finally, or fault clause";
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x00013DDE File Offset: 0x00011FDE
		internal static string BodyOfCatchMustHaveSameTypeAsBodyOfTry
		{
			get
			{
				return "Body of catch must have the same type as body of try.";
			}
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00013DE5 File Offset: 0x00011FE5
		internal static string ExtensionNodeMustOverrideProperty(object p0)
		{
			return SR.Format("Extension node must override the property {0}.", p0);
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00013DF2 File Offset: 0x00011FF2
		internal static string UserDefinedOperatorMustBeStatic(object p0)
		{
			return SR.Format("User-defined operator method '{0}' must be static.", p0);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00013DFF File Offset: 0x00011FFF
		internal static string UserDefinedOperatorMustNotBeVoid(object p0)
		{
			return SR.Format("User-defined operator method '{0}' must not be void.", p0);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00013E0C File Offset: 0x0001200C
		internal static string CoercionOperatorNotDefined(object p0, object p1)
		{
			return SR.Format("No coercion operator is defined between types '{0}' and '{1}'.", p0, p1);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00013E1A File Offset: 0x0001201A
		internal static string UnaryOperatorNotDefined(object p0, object p1)
		{
			return SR.Format("The unary operator {0} is not defined for the type '{1}'.", p0, p1);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00013E28 File Offset: 0x00012028
		internal static string BinaryOperatorNotDefined(object p0, object p1, object p2)
		{
			return SR.Format("The binary operator {0} is not defined for the types '{1}' and '{2}'.", p0, p1, p2);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00013E37 File Offset: 0x00012037
		internal static string ReferenceEqualityNotDefined(object p0, object p1)
		{
			return SR.Format("Reference equality is not defined for the types '{0}' and '{1}'.", p0, p1);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00013E45 File Offset: 0x00012045
		internal static string OperandTypesDoNotMatchParameters(object p0, object p1)
		{
			return SR.Format("The operands for operator '{0}' do not match the parameters of method '{1}'.", p0, p1);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00013E53 File Offset: 0x00012053
		internal static string OverloadOperatorTypeDoesNotMatchConversionType(object p0, object p1)
		{
			return SR.Format("The return type of overload method for operator '{0}' does not match the parameter type of conversion method '{1}'.", p0, p1);
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x00013E61 File Offset: 0x00012061
		internal static string ConversionIsNotSupportedForArithmeticTypes
		{
			get
			{
				return "Conversion is not supported for arithmetic types without operator overloading.";
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x00013E68 File Offset: 0x00012068
		internal static string ArgumentMustBeArray
		{
			get
			{
				return "Argument must be array";
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x00013E6F File Offset: 0x0001206F
		internal static string ArgumentMustBeBoolean
		{
			get
			{
				return "Argument must be boolean";
			}
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00013E76 File Offset: 0x00012076
		internal static string EqualityMustReturnBoolean(object p0)
		{
			return SR.Format("The user-defined equality method '{0}' must return a boolean value.", p0);
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x00013E83 File Offset: 0x00012083
		internal static string ArgumentMustBeFieldInfoOrPropertyInfo
		{
			get
			{
				return "Argument must be either a FieldInfo or PropertyInfo";
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x00013E8A File Offset: 0x0001208A
		internal static string ArgumentMustBeFieldInfoOrPropertyInfoOrMethod
		{
			get
			{
				return "Argument must be either a FieldInfo, PropertyInfo or MethodInfo";
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x00013E91 File Offset: 0x00012091
		internal static string ArgumentMustBeInstanceMember
		{
			get
			{
				return "Argument must be an instance member";
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x00013E98 File Offset: 0x00012098
		internal static string ArgumentMustBeInteger
		{
			get
			{
				return "Argument must be of an integer type";
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x00013E9F File Offset: 0x0001209F
		internal static string ArgumentMustBeArrayIndexType
		{
			get
			{
				return "Argument for array index must be of type Int32";
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x00013EA6 File Offset: 0x000120A6
		internal static string ArgumentMustBeSingleDimensionalArrayType
		{
			get
			{
				return "Argument must be single-dimensional, zero-based array type";
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x00013EAD File Offset: 0x000120AD
		internal static string ArgumentTypesMustMatch
		{
			get
			{
				return "Argument types do not match";
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00013EB4 File Offset: 0x000120B4
		internal static string CannotAutoInitializeValueTypeElementThroughProperty(object p0)
		{
			return SR.Format("Cannot auto initialize elements of value type through property '{0}', use assignment instead", p0);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00013EC1 File Offset: 0x000120C1
		internal static string CannotAutoInitializeValueTypeMemberThroughProperty(object p0)
		{
			return SR.Format("Cannot auto initialize members of value type through property '{0}', use assignment instead", p0);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00013ECE File Offset: 0x000120CE
		internal static string IncorrectTypeForTypeAs(object p0)
		{
			return SR.Format("The type used in TypeAs Expression must be of reference or nullable type, {0} is neither", p0);
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x00013EDB File Offset: 0x000120DB
		internal static string CoalesceUsedOnNonNullType
		{
			get
			{
				return "Coalesce used with type that cannot be null";
			}
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00013EE2 File Offset: 0x000120E2
		internal static string ExpressionTypeCannotInitializeArrayType(object p0, object p1)
		{
			return SR.Format("An expression of type '{0}' cannot be used to initialize an array of type '{1}'", p0, p1);
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00013EF0 File Offset: 0x000120F0
		internal static string ArgumentTypeDoesNotMatchMember(object p0, object p1)
		{
			return SR.Format(" Argument type '{0}' does not match the corresponding member type '{1}'", p0, p1);
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00013EFE File Offset: 0x000120FE
		internal static string ArgumentMemberNotDeclOnType(object p0, object p1)
		{
			return SR.Format(" The member '{0}' is not declared on type '{1}' being created", p0, p1);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00013F0C File Offset: 0x0001210C
		internal static string ExpressionTypeDoesNotMatchReturn(object p0, object p1)
		{
			return SR.Format("Expression of type '{0}' cannot be used for return type '{1}'", p0, p1);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00013F1A File Offset: 0x0001211A
		internal static string ExpressionTypeDoesNotMatchAssignment(object p0, object p1)
		{
			return SR.Format("Expression of type '{0}' cannot be used for assignment to type '{1}'", p0, p1);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00013F28 File Offset: 0x00012128
		internal static string ExpressionTypeDoesNotMatchLabel(object p0, object p1)
		{
			return SR.Format("Expression of type '{0}' cannot be used for label of type '{1}'", p0, p1);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00013F36 File Offset: 0x00012136
		internal static string ExpressionTypeNotInvocable(object p0)
		{
			return SR.Format("Expression of type '{0}' cannot be invoked", p0);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00013F43 File Offset: 0x00012143
		internal static string InstanceFieldNotDefinedForType(object p0, object p1)
		{
			return SR.Format("Instance field '{0}' is not defined for type '{1}'", p0, p1);
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00013F51 File Offset: 0x00012151
		internal static string FieldInfoNotDefinedForType(object p0, object p1, object p2)
		{
			return SR.Format("Field '{0}.{1}' is not defined for type '{2}'", p0, p1, p2);
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x00013F60 File Offset: 0x00012160
		internal static string IncorrectNumberOfIndexes
		{
			get
			{
				return "Incorrect number of indexes";
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x00013F67 File Offset: 0x00012167
		internal static string IncorrectNumberOfLambdaDeclarationParameters
		{
			get
			{
				return "Incorrect number of parameters supplied for lambda declaration";
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x00013F6E File Offset: 0x0001216E
		internal static string IncorrectNumberOfMembersForGivenConstructor
		{
			get
			{
				return " Incorrect number of members for constructor";
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x00013F75 File Offset: 0x00012175
		internal static string IncorrectNumberOfArgumentsForMembers
		{
			get
			{
				return "Incorrect number of arguments for the given members ";
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x00013F7C File Offset: 0x0001217C
		internal static string LambdaTypeMustBeDerivedFromSystemDelegate
		{
			get
			{
				return "Lambda type parameter must be derived from System.MulticastDelegate";
			}
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00013F83 File Offset: 0x00012183
		internal static string MemberNotFieldOrProperty(object p0)
		{
			return SR.Format("Member '{0}' not field or property", p0);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00013F90 File Offset: 0x00012190
		internal static string MethodContainsGenericParameters(object p0)
		{
			return SR.Format("Method {0} contains generic parameters", p0);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00013F9D File Offset: 0x0001219D
		internal static string MethodIsGeneric(object p0)
		{
			return SR.Format("Method {0} is a generic method definition", p0);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00013FAA File Offset: 0x000121AA
		internal static string MethodNotPropertyAccessor(object p0, object p1)
		{
			return SR.Format("The method '{0}.{1}' is not a property accessor", p0, p1);
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00013FB8 File Offset: 0x000121B8
		internal static string PropertyDoesNotHaveGetter(object p0)
		{
			return SR.Format("The property '{0}' has no 'get' accessor", p0);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00013FC5 File Offset: 0x000121C5
		internal static string PropertyDoesNotHaveSetter(object p0)
		{
			return SR.Format("The property '{0}' has no 'set' accessor", p0);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00013FD2 File Offset: 0x000121D2
		internal static string PropertyDoesNotHaveAccessor(object p0)
		{
			return SR.Format("The property '{0}' has no 'get' or 'set' accessors", p0);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00013FDF File Offset: 0x000121DF
		internal static string NotAMemberOfType(object p0, object p1)
		{
			return SR.Format("'{0}' is not a member of type '{1}'", p0, p1);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00013FED File Offset: 0x000121ED
		internal static string NotAMemberOfAnyType(object p0)
		{
			return SR.Format("'{0}' is not a member of any type", p0);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00013FFA File Offset: 0x000121FA
		internal static string ParameterExpressionNotValidAsDelegate(object p0, object p1)
		{
			return SR.Format("ParameterExpression of type '{0}' cannot be used for delegate parameter of type '{1}'", p0, p1);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00014008 File Offset: 0x00012208
		internal static string PropertyNotDefinedForType(object p0, object p1)
		{
			return SR.Format("Property '{0}' is not defined for type '{1}'", p0, p1);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00014016 File Offset: 0x00012216
		internal static string InstancePropertyNotDefinedForType(object p0, object p1)
		{
			return SR.Format("Instance property '{0}' is not defined for type '{1}'", p0, p1);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00014024 File Offset: 0x00012224
		internal static string InstanceAndMethodTypeMismatch(object p0, object p1, object p2)
		{
			return SR.Format("Method '{0}' declared on type '{1}' cannot be called with instance of type '{2}'", p0, p1, p2);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00014033 File Offset: 0x00012233
		internal static string TypeMissingDefaultConstructor(object p0)
		{
			return SR.Format("Type '{0}' does not have a default constructor", p0);
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x00014040 File Offset: 0x00012240
		internal static string ElementInitializerMethodNotAdd
		{
			get
			{
				return "Element initializer method must be named 'Add'";
			}
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00014047 File Offset: 0x00012247
		internal static string ElementInitializerMethodNoRefOutParam(object p0, object p1)
		{
			return SR.Format("Parameter '{0}' of element initializer method '{1}' must not be a pass by reference parameter", p0, p1);
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x00014055 File Offset: 0x00012255
		internal static string ElementInitializerMethodWithZeroArgs
		{
			get
			{
				return "Element initializer method must have at least 1 parameter";
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x0001405C File Offset: 0x0001225C
		internal static string ElementInitializerMethodStatic
		{
			get
			{
				return "Element initializer method must be an instance method";
			}
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00014063 File Offset: 0x00012263
		internal static string TypeNotIEnumerable(object p0)
		{
			return SR.Format("Type '{0}' is not IEnumerable", p0);
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00014070 File Offset: 0x00012270
		internal static string UnhandledBinary(object p0)
		{
			return SR.Format("Unhandled binary: {0}", p0);
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x0001407D File Offset: 0x0001227D
		internal static string UnhandledBinding
		{
			get
			{
				return "Unhandled binding ";
			}
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00014084 File Offset: 0x00012284
		internal static string UnhandledBindingType(object p0)
		{
			return SR.Format("Unhandled Binding Type: {0}", p0);
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00014091 File Offset: 0x00012291
		internal static string UnhandledUnary(object p0)
		{
			return SR.Format("Unhandled unary: {0}", p0);
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x0001409E File Offset: 0x0001229E
		internal static string UnknownBindingType
		{
			get
			{
				return "Unknown binding type";
			}
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x000140A5 File Offset: 0x000122A5
		internal static string UserDefinedOpMustHaveConsistentTypes(object p0, object p1)
		{
			return SR.Format("The user-defined operator method '{1}' for operator '{0}' must have identical parameter and return types.", p0, p1);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x000140B3 File Offset: 0x000122B3
		internal static string UserDefinedOpMustHaveValidReturnType(object p0, object p1)
		{
			return SR.Format("The user-defined operator method '{1}' for operator '{0}' must return the same type as its parameter or a derived type.", p0, p1);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x000140C1 File Offset: 0x000122C1
		internal static string LogicalOperatorMustHaveBooleanOperators(object p0, object p1)
		{
			return SR.Format("The user-defined operator method '{1}' for operator '{0}' must have associated boolean True and False operators.", p0, p1);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x000140CF File Offset: 0x000122CF
		internal static string MethodWithArgsDoesNotExistOnType(object p0, object p1)
		{
			return SR.Format("No method '{0}' on type '{1}' is compatible with the supplied arguments.", p0, p1);
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x000140DD File Offset: 0x000122DD
		internal static string GenericMethodWithArgsDoesNotExistOnType(object p0, object p1)
		{
			return SR.Format("No generic method '{0}' on type '{1}' is compatible with the supplied type arguments and arguments. No type arguments should be provided if the method is non-generic. ", p0, p1);
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x000140EB File Offset: 0x000122EB
		internal static string MethodWithMoreThanOneMatch(object p0, object p1)
		{
			return SR.Format("More than one method '{0}' on type '{1}' is compatible with the supplied arguments.", p0, p1);
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x000140F9 File Offset: 0x000122F9
		internal static string ArgumentCannotBeOfTypeVoid
		{
			get
			{
				return "Argument type cannot be System.Void.";
			}
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00014100 File Offset: 0x00012300
		internal static string OutOfRange(object p0, object p1)
		{
			return SR.Format("{0} must be greater than or equal to {1}", p0, p1);
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0001410E File Offset: 0x0001230E
		internal static string LabelTargetAlreadyDefined(object p0)
		{
			return SR.Format("Cannot redefine label '{0}' in an inner block.", p0);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0001411B File Offset: 0x0001231B
		internal static string LabelTargetUndefined(object p0)
		{
			return SR.Format("Cannot jump to undefined label '{0}'.", p0);
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x00014128 File Offset: 0x00012328
		internal static string ControlCannotLeaveFinally
		{
			get
			{
				return "Control cannot leave a finally block.";
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x0001412F File Offset: 0x0001232F
		internal static string ControlCannotLeaveFilterTest
		{
			get
			{
				return "Control cannot leave a filter test.";
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00014136 File Offset: 0x00012336
		internal static string AmbiguousJump(object p0)
		{
			return SR.Format("Cannot jump to ambiguous label '{0}'.", p0);
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x00014143 File Offset: 0x00012343
		internal static string ControlCannotEnterTry
		{
			get
			{
				return "Control cannot enter a try block.";
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x0001414A File Offset: 0x0001234A
		internal static string ControlCannotEnterExpression
		{
			get
			{
				return "Control cannot enter an expression--only statements can be jumped into.";
			}
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00014151 File Offset: 0x00012351
		internal static string NonLocalJumpWithValue(object p0)
		{
			return SR.Format("Cannot jump to non-local label '{0}' with a value. Only jumps to labels defined in outer blocks can pass values.", p0);
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0001415E File Offset: 0x0001235E
		internal static string CannotCompileConstant(object p0)
		{
			return SR.Format("CompileToMethod cannot compile constant '{0}' because it is a non-trivial value, such as a live object. Instead, create an expression tree that can construct this value.", p0);
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x0001416B File Offset: 0x0001236B
		internal static string CannotCompileDynamic
		{
			get
			{
				return "Dynamic expressions are not supported by CompileToMethod. Instead, create an expression tree that uses System.Runtime.CompilerServices.CallSite.";
			}
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00014172 File Offset: 0x00012372
		internal static string InvalidLvalue(object p0)
		{
			return SR.Format("Invalid lvalue for assignment: {0}.", p0);
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0001417F File Offset: 0x0001237F
		internal static string UndefinedVariable(object p0, object p1, object p2)
		{
			return SR.Format("variable '{0}' of type '{1}' referenced from scope '{2}', but it is not defined", p0, p1, p2);
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0001418E File Offset: 0x0001238E
		internal static string CannotCloseOverByRef(object p0, object p1)
		{
			return SR.Format("Cannot close over byref parameter '{0}' referenced in lambda '{1}'", p0, p1);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0001419C File Offset: 0x0001239C
		internal static string UnexpectedVarArgsCall(object p0)
		{
			return SR.Format("Unexpected VarArgs call to method '{0}'", p0);
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x000141A9 File Offset: 0x000123A9
		internal static string RethrowRequiresCatch
		{
			get
			{
				return "Rethrow statement is valid only inside a Catch block.";
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x000141B0 File Offset: 0x000123B0
		internal static string TryNotAllowedInFilter
		{
			get
			{
				return "Try expression is not allowed inside a filter body.";
			}
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x000141B7 File Offset: 0x000123B7
		internal static string MustRewriteToSameNode(object p0, object p1, object p2)
		{
			return SR.Format("When called from '{0}', rewriting a node of type '{1}' must return a non-null value of the same type. Alternatively, override '{2}' and change it to not visit children of this type.", p0, p1, p2);
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x000141C6 File Offset: 0x000123C6
		internal static string MustRewriteChildToSameType(object p0, object p1, object p2)
		{
			return SR.Format("Rewriting child expression from type '{0}' to type '{1}' is not allowed, because it would change the meaning of the operation. If this is intentional, override '{2}' and change it to allow this rewrite.", p0, p1, p2);
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x000141D5 File Offset: 0x000123D5
		internal static string MustRewriteWithoutMethod(object p0, object p1)
		{
			return SR.Format("Rewritten expression calls operator method '{0}', but the original node had no operator method. If this is intentional, override '{1}' and change it to allow this rewrite.", p0, p1);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x000141E3 File Offset: 0x000123E3
		internal static string TryNotSupportedForMethodsWithRefArgs(object p0)
		{
			return SR.Format("TryExpression is not supported as an argument to method '{0}' because it has an argument with by-ref type. Construct the tree so the TryExpression is not nested inside of this expression.", p0);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x000141F0 File Offset: 0x000123F0
		internal static string TryNotSupportedForValueTypeInstances(object p0)
		{
			return SR.Format("TryExpression is not supported as a child expression when accessing a member on type '{0}' because it is a value type. Construct the tree so the TryExpression is not nested inside of this expression.", p0);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x000141FD File Offset: 0x000123FD
		internal static string TestValueTypeDoesNotMatchComparisonMethodParameter(object p0, object p1)
		{
			return SR.Format("Test value of type '{0}' cannot be used for the comparison method parameter of type '{1}'", p0, p1);
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0001420B File Offset: 0x0001240B
		internal static string SwitchValueTypeDoesNotMatchComparisonMethodParameter(object p0, object p1)
		{
			return SR.Format("Switch value of type '{0}' cannot be used for the comparison method parameter of type '{1}'", p0, p1);
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x00014219 File Offset: 0x00012419
		internal static string NonStaticConstructorRequired
		{
			get
			{
				return "The constructor should not be static";
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x00014220 File Offset: 0x00012420
		internal static string NonAbstractConstructorRequired
		{
			get
			{
				return "Can't compile a NewExpression with a constructor declared on an abstract class";
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x00014227 File Offset: 0x00012427
		internal static string ExpressionMustBeReadable
		{
			get
			{
				return "Expression must be readable";
			}
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0001422E File Offset: 0x0001242E
		internal static string ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1)
		{
			return SR.Format("Expression of type '{0}' cannot be used for constructor parameter of type '{1}'", p0, p1);
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x0001423C File Offset: 0x0001243C
		internal static string EnumerationIsDone
		{
			get
			{
				return "Enumeration has either not started or has already finished.";
			}
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00014243 File Offset: 0x00012443
		internal static string TypeContainsGenericParameters(object p0)
		{
			return SR.Format("Type {0} contains generic parameters", p0);
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00014250 File Offset: 0x00012450
		internal static string TypeIsGeneric(object p0)
		{
			return SR.Format("Type {0} is a generic type definition", p0);
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x0001425D File Offset: 0x0001245D
		internal static string InvalidArgumentValue
		{
			get
			{
				return "Invalid argument value";
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x00014264 File Offset: 0x00012464
		internal static string NonEmptyCollectionRequired
		{
			get
			{
				return "Non-empty collection required";
			}
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0001426B File Offset: 0x0001246B
		internal static string InvalidNullValue(object p0)
		{
			return SR.Format("The value null is not of type '{0}' and cannot be used in this collection.", p0);
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00014278 File Offset: 0x00012478
		internal static string InvalidObjectType(object p0, object p1)
		{
			return SR.Format("The value '{0}' is not of type '{1}' and cannot be used in this collection.", p0, p1);
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00014286 File Offset: 0x00012486
		internal static string ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2)
		{
			return SR.Format("Expression of type '{0}' cannot be used for parameter of type '{1}' of method '{2}'", p0, p1, p2);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00014295 File Offset: 0x00012495
		internal static string ExpressionTypeDoesNotMatchParameter(object p0, object p1)
		{
			return SR.Format("Expression of type '{0}' cannot be used for parameter of type '{1}'", p0, p1);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x000142A3 File Offset: 0x000124A3
		internal static string IncorrectNumberOfMethodCallArguments(object p0)
		{
			return SR.Format("Incorrect number of arguments supplied for call to method '{0}'", p0);
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x000142B0 File Offset: 0x000124B0
		internal static string IncorrectNumberOfLambdaArguments
		{
			get
			{
				return "Incorrect number of arguments supplied for lambda invocation";
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x000142B7 File Offset: 0x000124B7
		internal static string IncorrectNumberOfConstructorArguments
		{
			get
			{
				return "Incorrect number of arguments for constructor";
			}
		}
	}
}
