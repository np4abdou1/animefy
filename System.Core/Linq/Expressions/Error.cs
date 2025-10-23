using System;
using System.Collections.Generic;
using System.Reflection;

namespace System.Linq.Expressions
{
	// Token: 0x02000087 RID: 135
	internal static class Error
	{
		// Token: 0x06000391 RID: 913 RVA: 0x0000FF9D File Offset: 0x0000E19D
		internal static Exception ReducibleMustOverrideReduce()
		{
			return new ArgumentException(Strings.ReducibleMustOverrideReduce);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000FFA9 File Offset: 0x0000E1A9
		internal static Exception InvalidMetaObjectCreated(object p0)
		{
			return new InvalidOperationException(Strings.InvalidMetaObjectCreated(p0));
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000FFB6 File Offset: 0x0000E1B6
		internal static Exception AmbiguousMatchInExpandoObject(object p0)
		{
			return new AmbiguousMatchException(Strings.AmbiguousMatchInExpandoObject(p0));
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000FFC3 File Offset: 0x0000E1C3
		internal static Exception SameKeyExistsInExpando(object key)
		{
			return new ArgumentException(Strings.SameKeyExistsInExpando(key), "key");
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000FFD5 File Offset: 0x0000E1D5
		internal static Exception KeyDoesNotExistInExpando(object p0)
		{
			return new KeyNotFoundException(Strings.KeyDoesNotExistInExpando(p0));
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000FFE2 File Offset: 0x0000E1E2
		internal static Exception CollectionModifiedWhileEnumerating()
		{
			return new InvalidOperationException(Strings.CollectionModifiedWhileEnumerating);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000FFEE File Offset: 0x0000E1EE
		internal static Exception CollectionReadOnly()
		{
			return new NotSupportedException(Strings.CollectionReadOnly);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000FFFA File Offset: 0x0000E1FA
		internal static Exception MustReduceToDifferent()
		{
			return new ArgumentException(Strings.MustReduceToDifferent);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00010006 File Offset: 0x0000E206
		internal static Exception BinderNotCompatibleWithCallSite(object p0, object p1, object p2)
		{
			return new InvalidOperationException(Strings.BinderNotCompatibleWithCallSite(p0, p1, p2));
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00010015 File Offset: 0x0000E215
		internal static Exception DynamicBindingNeedsRestrictions(object p0, object p1)
		{
			return new InvalidOperationException(Strings.DynamicBindingNeedsRestrictions(p0, p1));
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00010023 File Offset: 0x0000E223
		internal static Exception DynamicObjectResultNotAssignable(object p0, object p1, object p2, object p3)
		{
			return new InvalidCastException(Strings.DynamicObjectResultNotAssignable(p0, p1, p2, p3));
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00010033 File Offset: 0x0000E233
		internal static Exception DynamicBinderResultNotAssignable(object p0, object p1, object p2)
		{
			return new InvalidCastException(Strings.DynamicBinderResultNotAssignable(p0, p1, p2));
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00010042 File Offset: 0x0000E242
		internal static Exception BindingCannotBeNull()
		{
			return new InvalidOperationException(Strings.BindingCannotBeNull);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0001004E File Offset: 0x0000E24E
		internal static Exception ReducedNotCompatible()
		{
			return new ArgumentException(Strings.ReducedNotCompatible);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0001005A File Offset: 0x0000E25A
		internal static Exception SetterHasNoParams(string paramName)
		{
			return new ArgumentException(Strings.SetterHasNoParams, paramName);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00010067 File Offset: 0x0000E267
		internal static Exception PropertyCannotHaveRefType(string paramName)
		{
			return new ArgumentException(Strings.PropertyCannotHaveRefType, paramName);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00010074 File Offset: 0x0000E274
		internal static Exception IndexesOfSetGetMustMatch(string paramName)
		{
			return new ArgumentException(Strings.IndexesOfSetGetMustMatch, paramName);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00010081 File Offset: 0x0000E281
		internal static Exception TypeParameterIsNotDelegate(object p0)
		{
			return new InvalidOperationException(Strings.TypeParameterIsNotDelegate(p0));
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0001008E File Offset: 0x0000E28E
		internal static Exception FirstArgumentMustBeCallSite()
		{
			return new ArgumentException(Strings.FirstArgumentMustBeCallSite);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0001009A File Offset: 0x0000E29A
		internal static Exception AccessorsCannotHaveVarArgs(string paramName)
		{
			return new ArgumentException(Strings.AccessorsCannotHaveVarArgs, paramName);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x000100A7 File Offset: 0x0000E2A7
		private static Exception AccessorsCannotHaveByRefArgs(string paramName)
		{
			return new ArgumentException(Strings.AccessorsCannotHaveByRefArgs, paramName);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x000100B4 File Offset: 0x0000E2B4
		internal static Exception AccessorsCannotHaveByRefArgs(string paramName, int index)
		{
			return Error.AccessorsCannotHaveByRefArgs(Error.GetParamName(paramName, index));
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x000100C2 File Offset: 0x0000E2C2
		internal static Exception TypeMustBeDerivedFromSystemDelegate()
		{
			return new ArgumentException(Strings.TypeMustBeDerivedFromSystemDelegate);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x000100CE File Offset: 0x0000E2CE
		internal static Exception NoOrInvalidRuleProduced()
		{
			return new InvalidOperationException(Strings.NoOrInvalidRuleProduced);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x000100DA File Offset: 0x0000E2DA
		internal static Exception BoundsCannotBeLessThanOne(string paramName)
		{
			return new ArgumentException(Strings.BoundsCannotBeLessThanOne, paramName);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x000100E7 File Offset: 0x0000E2E7
		internal static Exception TypeMustNotBeByRef(string paramName)
		{
			return new ArgumentException(Strings.TypeMustNotBeByRef, paramName);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x000100F4 File Offset: 0x0000E2F4
		internal static Exception TypeMustNotBePointer(string paramName)
		{
			return new ArgumentException(Strings.TypeMustNotBePointer, paramName);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00010101 File Offset: 0x0000E301
		internal static Exception SetterMustBeVoid(string paramName)
		{
			return new ArgumentException(Strings.SetterMustBeVoid, paramName);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0001010E File Offset: 0x0000E30E
		internal static Exception PropertyTypeMustMatchGetter(string paramName)
		{
			return new ArgumentException(Strings.PropertyTypeMustMatchGetter, paramName);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0001011B File Offset: 0x0000E31B
		internal static Exception PropertyTypeMustMatchSetter(string paramName)
		{
			return new ArgumentException(Strings.PropertyTypeMustMatchSetter, paramName);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00010128 File Offset: 0x0000E328
		internal static Exception BothAccessorsMustBeStatic(string paramName)
		{
			return new ArgumentException(Strings.BothAccessorsMustBeStatic, paramName);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00010135 File Offset: 0x0000E335
		internal static Exception OnlyStaticFieldsHaveNullInstance(string paramName)
		{
			return new ArgumentException(Strings.OnlyStaticFieldsHaveNullInstance, paramName);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00010142 File Offset: 0x0000E342
		internal static Exception OnlyStaticPropertiesHaveNullInstance(string paramName)
		{
			return new ArgumentException(Strings.OnlyStaticPropertiesHaveNullInstance, paramName);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0001014F File Offset: 0x0000E34F
		internal static Exception OnlyStaticMethodsHaveNullInstance()
		{
			return new ArgumentException(Strings.OnlyStaticMethodsHaveNullInstance);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0001015B File Offset: 0x0000E35B
		internal static Exception PropertyTypeCannotBeVoid(string paramName)
		{
			return new ArgumentException(Strings.PropertyTypeCannotBeVoid, paramName);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00010168 File Offset: 0x0000E368
		internal static Exception InvalidUnboxType(string paramName)
		{
			return new ArgumentException(Strings.InvalidUnboxType, paramName);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00010175 File Offset: 0x0000E375
		internal static Exception ExpressionMustBeWriteable(string paramName)
		{
			return new ArgumentException(Strings.ExpressionMustBeWriteable, paramName);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00010182 File Offset: 0x0000E382
		internal static Exception ArgumentMustNotHaveValueType(string paramName)
		{
			return new ArgumentException(Strings.ArgumentMustNotHaveValueType, paramName);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0001018F File Offset: 0x0000E38F
		internal static Exception MustBeReducible()
		{
			return new ArgumentException(Strings.MustBeReducible);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0001019B File Offset: 0x0000E39B
		internal static Exception AllTestValuesMustHaveSameType(string paramName)
		{
			return new ArgumentException(Strings.AllTestValuesMustHaveSameType, paramName);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x000101A8 File Offset: 0x0000E3A8
		internal static Exception AllCaseBodiesMustHaveSameType(string paramName)
		{
			return new ArgumentException(Strings.AllCaseBodiesMustHaveSameType, paramName);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x000101B5 File Offset: 0x0000E3B5
		internal static Exception DefaultBodyMustBeSupplied(string paramName)
		{
			return new ArgumentException(Strings.DefaultBodyMustBeSupplied, paramName);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x000101C2 File Offset: 0x0000E3C2
		internal static Exception LabelMustBeVoidOrHaveExpression(string paramName)
		{
			return new ArgumentException(Strings.LabelMustBeVoidOrHaveExpression, paramName);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x000101CF File Offset: 0x0000E3CF
		internal static Exception LabelTypeMustBeVoid(string paramName)
		{
			return new ArgumentException(Strings.LabelTypeMustBeVoid, paramName);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x000101DC File Offset: 0x0000E3DC
		internal static Exception QuotedExpressionMustBeLambda(string paramName)
		{
			return new ArgumentException(Strings.QuotedExpressionMustBeLambda, paramName);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000101E9 File Offset: 0x0000E3E9
		internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName)
		{
			return new ArgumentException(Strings.VariableMustNotBeByRef(p0, p1), paramName);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x000101F8 File Offset: 0x0000E3F8
		internal static Exception VariableMustNotBeByRef(object p0, object p1, string paramName, int index)
		{
			return Error.VariableMustNotBeByRef(p0, p1, Error.GetParamName(paramName, index));
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00010208 File Offset: 0x0000E408
		private static Exception DuplicateVariable(object p0, string paramName)
		{
			return new ArgumentException(Strings.DuplicateVariable(p0), paramName);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00010216 File Offset: 0x0000E416
		internal static Exception DuplicateVariable(object p0, string paramName, int index)
		{
			return Error.DuplicateVariable(p0, Error.GetParamName(paramName, index));
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00010225 File Offset: 0x0000E425
		internal static Exception FaultCannotHaveCatchOrFinally(string paramName)
		{
			return new ArgumentException(Strings.FaultCannotHaveCatchOrFinally, paramName);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00010232 File Offset: 0x0000E432
		internal static Exception TryMustHaveCatchFinallyOrFault()
		{
			return new ArgumentException(Strings.TryMustHaveCatchFinallyOrFault);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0001023E File Offset: 0x0000E43E
		internal static Exception BodyOfCatchMustHaveSameTypeAsBodyOfTry()
		{
			return new ArgumentException(Strings.BodyOfCatchMustHaveSameTypeAsBodyOfTry);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0001024A File Offset: 0x0000E44A
		internal static Exception ExtensionNodeMustOverrideProperty(object p0)
		{
			return new InvalidOperationException(Strings.ExtensionNodeMustOverrideProperty(p0));
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00010257 File Offset: 0x0000E457
		internal static Exception UserDefinedOperatorMustBeStatic(object p0, string paramName)
		{
			return new ArgumentException(Strings.UserDefinedOperatorMustBeStatic(p0), paramName);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00010265 File Offset: 0x0000E465
		internal static Exception UserDefinedOperatorMustNotBeVoid(object p0, string paramName)
		{
			return new ArgumentException(Strings.UserDefinedOperatorMustNotBeVoid(p0), paramName);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00010273 File Offset: 0x0000E473
		internal static Exception CoercionOperatorNotDefined(object p0, object p1)
		{
			return new InvalidOperationException(Strings.CoercionOperatorNotDefined(p0, p1));
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00010281 File Offset: 0x0000E481
		internal static Exception UnaryOperatorNotDefined(object p0, object p1)
		{
			return new InvalidOperationException(Strings.UnaryOperatorNotDefined(p0, p1));
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0001028F File Offset: 0x0000E48F
		internal static Exception BinaryOperatorNotDefined(object p0, object p1, object p2)
		{
			return new InvalidOperationException(Strings.BinaryOperatorNotDefined(p0, p1, p2));
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0001029E File Offset: 0x0000E49E
		internal static Exception ReferenceEqualityNotDefined(object p0, object p1)
		{
			return new InvalidOperationException(Strings.ReferenceEqualityNotDefined(p0, p1));
		}

		// Token: 0x060003CC RID: 972 RVA: 0x000102AC File Offset: 0x0000E4AC
		internal static Exception OperandTypesDoNotMatchParameters(object p0, object p1)
		{
			return new InvalidOperationException(Strings.OperandTypesDoNotMatchParameters(p0, p1));
		}

		// Token: 0x060003CD RID: 973 RVA: 0x000102BA File Offset: 0x0000E4BA
		internal static Exception OverloadOperatorTypeDoesNotMatchConversionType(object p0, object p1)
		{
			return new InvalidOperationException(Strings.OverloadOperatorTypeDoesNotMatchConversionType(p0, p1));
		}

		// Token: 0x060003CE RID: 974 RVA: 0x000102C8 File Offset: 0x0000E4C8
		internal static Exception ConversionIsNotSupportedForArithmeticTypes()
		{
			return new InvalidOperationException(Strings.ConversionIsNotSupportedForArithmeticTypes);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x000102D4 File Offset: 0x0000E4D4
		internal static Exception ArgumentMustBeArray(string paramName)
		{
			return new ArgumentException(Strings.ArgumentMustBeArray, paramName);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x000102E1 File Offset: 0x0000E4E1
		internal static Exception ArgumentMustBeBoolean(string paramName)
		{
			return new ArgumentException(Strings.ArgumentMustBeBoolean, paramName);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x000102EE File Offset: 0x0000E4EE
		internal static Exception EqualityMustReturnBoolean(object p0, string paramName)
		{
			return new ArgumentException(Strings.EqualityMustReturnBoolean(p0), paramName);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x000102FC File Offset: 0x0000E4FC
		internal static Exception ArgumentMustBeFieldInfoOrPropertyInfo(string paramName)
		{
			return new ArgumentException(Strings.ArgumentMustBeFieldInfoOrPropertyInfo, paramName);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00010309 File Offset: 0x0000E509
		private static Exception ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(string paramName)
		{
			return new ArgumentException(Strings.ArgumentMustBeFieldInfoOrPropertyInfoOrMethod, paramName);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00010316 File Offset: 0x0000E516
		internal static Exception ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(string paramName, int index)
		{
			return Error.ArgumentMustBeFieldInfoOrPropertyInfoOrMethod(Error.GetParamName(paramName, index));
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00010324 File Offset: 0x0000E524
		private static Exception ArgumentMustBeInstanceMember(string paramName)
		{
			return new ArgumentException(Strings.ArgumentMustBeInstanceMember, paramName);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00010331 File Offset: 0x0000E531
		internal static Exception ArgumentMustBeInstanceMember(string paramName, int index)
		{
			return Error.ArgumentMustBeInstanceMember(Error.GetParamName(paramName, index));
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0001033F File Offset: 0x0000E53F
		private static Exception ArgumentMustBeInteger(string paramName)
		{
			return new ArgumentException(Strings.ArgumentMustBeInteger, paramName);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0001034C File Offset: 0x0000E54C
		internal static Exception ArgumentMustBeInteger(string paramName, int index)
		{
			return Error.ArgumentMustBeInteger(Error.GetParamName(paramName, index));
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0001035A File Offset: 0x0000E55A
		internal static Exception ArgumentMustBeArrayIndexType(string paramName)
		{
			return new ArgumentException(Strings.ArgumentMustBeArrayIndexType, paramName);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00010367 File Offset: 0x0000E567
		internal static Exception ArgumentMustBeSingleDimensionalArrayType(string paramName)
		{
			return new ArgumentException(Strings.ArgumentMustBeSingleDimensionalArrayType, paramName);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00010374 File Offset: 0x0000E574
		internal static Exception ArgumentTypesMustMatch()
		{
			return new ArgumentException(Strings.ArgumentTypesMustMatch);
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00010380 File Offset: 0x0000E580
		internal static Exception ArgumentTypesMustMatch(string paramName)
		{
			return new ArgumentException(Strings.ArgumentTypesMustMatch, paramName);
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0001038D File Offset: 0x0000E58D
		internal static Exception CannotAutoInitializeValueTypeElementThroughProperty(object p0)
		{
			return new InvalidOperationException(Strings.CannotAutoInitializeValueTypeElementThroughProperty(p0));
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0001039A File Offset: 0x0000E59A
		internal static Exception CannotAutoInitializeValueTypeMemberThroughProperty(object p0)
		{
			return new InvalidOperationException(Strings.CannotAutoInitializeValueTypeMemberThroughProperty(p0));
		}

		// Token: 0x060003DF RID: 991 RVA: 0x000103A7 File Offset: 0x0000E5A7
		internal static Exception IncorrectTypeForTypeAs(object p0, string paramName)
		{
			return new ArgumentException(Strings.IncorrectTypeForTypeAs(p0), paramName);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x000103B5 File Offset: 0x0000E5B5
		internal static Exception CoalesceUsedOnNonNullType()
		{
			return new InvalidOperationException(Strings.CoalesceUsedOnNonNullType);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x000103C1 File Offset: 0x0000E5C1
		internal static Exception ExpressionTypeCannotInitializeArrayType(object p0, object p1)
		{
			return new InvalidOperationException(Strings.ExpressionTypeCannotInitializeArrayType(p0, p1));
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x000103CF File Offset: 0x0000E5CF
		private static Exception ArgumentTypeDoesNotMatchMember(object p0, object p1, string paramName)
		{
			return new ArgumentException(Strings.ArgumentTypeDoesNotMatchMember(p0, p1), paramName);
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x000103DE File Offset: 0x0000E5DE
		internal static Exception ArgumentTypeDoesNotMatchMember(object p0, object p1, string paramName, int index)
		{
			return Error.ArgumentTypeDoesNotMatchMember(p0, p1, Error.GetParamName(paramName, index));
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x000103EE File Offset: 0x0000E5EE
		private static Exception ArgumentMemberNotDeclOnType(object p0, object p1, string paramName)
		{
			return new ArgumentException(Strings.ArgumentMemberNotDeclOnType(p0, p1), paramName);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x000103FD File Offset: 0x0000E5FD
		internal static Exception ArgumentMemberNotDeclOnType(object p0, object p1, string paramName, int index)
		{
			return Error.ArgumentMemberNotDeclOnType(p0, p1, Error.GetParamName(paramName, index));
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0001040D File Offset: 0x0000E60D
		internal static Exception ExpressionTypeDoesNotMatchReturn(object p0, object p1)
		{
			return new ArgumentException(Strings.ExpressionTypeDoesNotMatchReturn(p0, p1));
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0001041B File Offset: 0x0000E61B
		internal static Exception ExpressionTypeDoesNotMatchAssignment(object p0, object p1)
		{
			return new ArgumentException(Strings.ExpressionTypeDoesNotMatchAssignment(p0, p1));
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00010429 File Offset: 0x0000E629
		internal static Exception ExpressionTypeDoesNotMatchLabel(object p0, object p1)
		{
			return new ArgumentException(Strings.ExpressionTypeDoesNotMatchLabel(p0, p1));
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00010437 File Offset: 0x0000E637
		internal static Exception ExpressionTypeNotInvocable(object p0, string paramName)
		{
			return new ArgumentException(Strings.ExpressionTypeNotInvocable(p0), paramName);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00010445 File Offset: 0x0000E645
		internal static Exception InstanceFieldNotDefinedForType(object p0, object p1)
		{
			return new ArgumentException(Strings.InstanceFieldNotDefinedForType(p0, p1));
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00010453 File Offset: 0x0000E653
		internal static Exception FieldInfoNotDefinedForType(object p0, object p1, object p2)
		{
			return new ArgumentException(Strings.FieldInfoNotDefinedForType(p0, p1, p2));
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00010462 File Offset: 0x0000E662
		internal static Exception IncorrectNumberOfIndexes()
		{
			return new ArgumentException(Strings.IncorrectNumberOfIndexes);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0001046E File Offset: 0x0000E66E
		internal static Exception IncorrectNumberOfLambdaDeclarationParameters()
		{
			return new ArgumentException(Strings.IncorrectNumberOfLambdaDeclarationParameters);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0001047A File Offset: 0x0000E67A
		internal static Exception IncorrectNumberOfMembersForGivenConstructor()
		{
			return new ArgumentException(Strings.IncorrectNumberOfMembersForGivenConstructor);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00010486 File Offset: 0x0000E686
		internal static Exception IncorrectNumberOfArgumentsForMembers()
		{
			return new ArgumentException(Strings.IncorrectNumberOfArgumentsForMembers);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00010492 File Offset: 0x0000E692
		internal static Exception LambdaTypeMustBeDerivedFromSystemDelegate(string paramName)
		{
			return new ArgumentException(Strings.LambdaTypeMustBeDerivedFromSystemDelegate, paramName);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0001049F File Offset: 0x0000E69F
		internal static Exception MemberNotFieldOrProperty(object p0, string paramName)
		{
			return new ArgumentException(Strings.MemberNotFieldOrProperty(p0), paramName);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x000104AD File Offset: 0x0000E6AD
		internal static Exception MethodContainsGenericParameters(object p0, string paramName)
		{
			return new ArgumentException(Strings.MethodContainsGenericParameters(p0), paramName);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000104BB File Offset: 0x0000E6BB
		internal static Exception MethodIsGeneric(object p0, string paramName)
		{
			return new ArgumentException(Strings.MethodIsGeneric(p0), paramName);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000104C9 File Offset: 0x0000E6C9
		private static Exception MethodNotPropertyAccessor(object p0, object p1, string paramName)
		{
			return new ArgumentException(Strings.MethodNotPropertyAccessor(p0, p1), paramName);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000104D8 File Offset: 0x0000E6D8
		internal static Exception MethodNotPropertyAccessor(object p0, object p1, string paramName, int index)
		{
			return Error.MethodNotPropertyAccessor(p0, p1, Error.GetParamName(paramName, index));
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000104E8 File Offset: 0x0000E6E8
		internal static Exception PropertyDoesNotHaveGetter(object p0, string paramName)
		{
			return new ArgumentException(Strings.PropertyDoesNotHaveGetter(p0), paramName);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x000104F6 File Offset: 0x0000E6F6
		internal static Exception PropertyDoesNotHaveGetter(object p0, string paramName, int index)
		{
			return Error.PropertyDoesNotHaveGetter(p0, Error.GetParamName(paramName, index));
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00010505 File Offset: 0x0000E705
		internal static Exception PropertyDoesNotHaveSetter(object p0, string paramName)
		{
			return new ArgumentException(Strings.PropertyDoesNotHaveSetter(p0), paramName);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00010513 File Offset: 0x0000E713
		internal static Exception PropertyDoesNotHaveAccessor(object p0, string paramName)
		{
			return new ArgumentException(Strings.PropertyDoesNotHaveAccessor(p0), paramName);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00010521 File Offset: 0x0000E721
		internal static Exception NotAMemberOfType(object p0, object p1, string paramName)
		{
			return new ArgumentException(Strings.NotAMemberOfType(p0, p1), paramName);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00010530 File Offset: 0x0000E730
		internal static Exception NotAMemberOfType(object p0, object p1, string paramName, int index)
		{
			return Error.NotAMemberOfType(p0, p1, Error.GetParamName(paramName, index));
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00010540 File Offset: 0x0000E740
		internal static Exception NotAMemberOfAnyType(object p0, string paramName)
		{
			return new ArgumentException(Strings.NotAMemberOfAnyType(p0), paramName);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0001054E File Offset: 0x0000E74E
		internal static Exception ParameterExpressionNotValidAsDelegate(object p0, object p1)
		{
			return new ArgumentException(Strings.ParameterExpressionNotValidAsDelegate(p0, p1));
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0001055C File Offset: 0x0000E75C
		internal static Exception PropertyNotDefinedForType(object p0, object p1, string paramName)
		{
			return new ArgumentException(Strings.PropertyNotDefinedForType(p0, p1), paramName);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0001056B File Offset: 0x0000E76B
		internal static Exception InstancePropertyNotDefinedForType(object p0, object p1, string paramName)
		{
			return new ArgumentException(Strings.InstancePropertyNotDefinedForType(p0, p1), paramName);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0001057A File Offset: 0x0000E77A
		internal static Exception InstanceAndMethodTypeMismatch(object p0, object p1, object p2)
		{
			return new ArgumentException(Strings.InstanceAndMethodTypeMismatch(p0, p1, p2));
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00010589 File Offset: 0x0000E789
		internal static Exception TypeMissingDefaultConstructor(object p0, string paramName)
		{
			return new ArgumentException(Strings.TypeMissingDefaultConstructor(p0), paramName);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00010597 File Offset: 0x0000E797
		internal static Exception ElementInitializerMethodNotAdd(string paramName)
		{
			return new ArgumentException(Strings.ElementInitializerMethodNotAdd, paramName);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x000105A4 File Offset: 0x0000E7A4
		internal static Exception ElementInitializerMethodNoRefOutParam(object p0, object p1, string paramName)
		{
			return new ArgumentException(Strings.ElementInitializerMethodNoRefOutParam(p0, p1), paramName);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x000105B3 File Offset: 0x0000E7B3
		internal static Exception ElementInitializerMethodWithZeroArgs(string paramName)
		{
			return new ArgumentException(Strings.ElementInitializerMethodWithZeroArgs, paramName);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x000105C0 File Offset: 0x0000E7C0
		internal static Exception ElementInitializerMethodStatic(string paramName)
		{
			return new ArgumentException(Strings.ElementInitializerMethodStatic, paramName);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x000105CD File Offset: 0x0000E7CD
		internal static Exception TypeNotIEnumerable(object p0, string paramName)
		{
			return new ArgumentException(Strings.TypeNotIEnumerable(p0), paramName);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x000105DB File Offset: 0x0000E7DB
		internal static Exception UnhandledBinary(object p0, string paramName)
		{
			return new ArgumentException(Strings.UnhandledBinary(p0), paramName);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x000105E9 File Offset: 0x0000E7E9
		internal static Exception UnhandledBinding()
		{
			return new ArgumentException(Strings.UnhandledBinding);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x000105F5 File Offset: 0x0000E7F5
		internal static Exception UnhandledBindingType(object p0)
		{
			return new ArgumentException(Strings.UnhandledBindingType(p0));
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00010602 File Offset: 0x0000E802
		internal static Exception UnhandledUnary(object p0, string paramName)
		{
			return new ArgumentException(Strings.UnhandledUnary(p0), paramName);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00010610 File Offset: 0x0000E810
		internal static Exception UnknownBindingType(int index)
		{
			return new ArgumentException(Strings.UnknownBindingType, string.Format("bindings[{0}]", index));
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0001062C File Offset: 0x0000E82C
		internal static Exception UserDefinedOpMustHaveConsistentTypes(object p0, object p1)
		{
			return new ArgumentException(Strings.UserDefinedOpMustHaveConsistentTypes(p0, p1));
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0001063A File Offset: 0x0000E83A
		internal static Exception UserDefinedOpMustHaveValidReturnType(object p0, object p1)
		{
			return new ArgumentException(Strings.UserDefinedOpMustHaveValidReturnType(p0, p1));
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00010648 File Offset: 0x0000E848
		internal static Exception LogicalOperatorMustHaveBooleanOperators(object p0, object p1)
		{
			return new ArgumentException(Strings.LogicalOperatorMustHaveBooleanOperators(p0, p1));
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00010656 File Offset: 0x0000E856
		internal static Exception MethodWithArgsDoesNotExistOnType(object p0, object p1)
		{
			return new InvalidOperationException(Strings.MethodWithArgsDoesNotExistOnType(p0, p1));
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00010664 File Offset: 0x0000E864
		internal static Exception GenericMethodWithArgsDoesNotExistOnType(object p0, object p1)
		{
			return new InvalidOperationException(Strings.GenericMethodWithArgsDoesNotExistOnType(p0, p1));
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00010672 File Offset: 0x0000E872
		internal static Exception MethodWithMoreThanOneMatch(object p0, object p1)
		{
			return new InvalidOperationException(Strings.MethodWithMoreThanOneMatch(p0, p1));
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00010680 File Offset: 0x0000E880
		internal static Exception ArgumentCannotBeOfTypeVoid(string paramName)
		{
			return new ArgumentException(Strings.ArgumentCannotBeOfTypeVoid, paramName);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0001068D File Offset: 0x0000E88D
		internal static Exception OutOfRange(string paramName, object p1)
		{
			return new ArgumentOutOfRangeException(paramName, Strings.OutOfRange(paramName, p1));
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0001069C File Offset: 0x0000E89C
		internal static Exception LabelTargetAlreadyDefined(object p0)
		{
			return new InvalidOperationException(Strings.LabelTargetAlreadyDefined(p0));
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x000106A9 File Offset: 0x0000E8A9
		internal static Exception LabelTargetUndefined(object p0)
		{
			return new InvalidOperationException(Strings.LabelTargetUndefined(p0));
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000106B6 File Offset: 0x0000E8B6
		internal static Exception ControlCannotLeaveFinally()
		{
			return new InvalidOperationException(Strings.ControlCannotLeaveFinally);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000106C2 File Offset: 0x0000E8C2
		internal static Exception ControlCannotLeaveFilterTest()
		{
			return new InvalidOperationException(Strings.ControlCannotLeaveFilterTest);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x000106CE File Offset: 0x0000E8CE
		internal static Exception AmbiguousJump(object p0)
		{
			return new InvalidOperationException(Strings.AmbiguousJump(p0));
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000106DB File Offset: 0x0000E8DB
		internal static Exception ControlCannotEnterTry()
		{
			return new InvalidOperationException(Strings.ControlCannotEnterTry);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000106E7 File Offset: 0x0000E8E7
		internal static Exception ControlCannotEnterExpression()
		{
			return new InvalidOperationException(Strings.ControlCannotEnterExpression);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x000106F3 File Offset: 0x0000E8F3
		internal static Exception NonLocalJumpWithValue(object p0)
		{
			return new InvalidOperationException(Strings.NonLocalJumpWithValue(p0));
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00010700 File Offset: 0x0000E900
		internal static Exception CannotCompileConstant(object p0)
		{
			return new InvalidOperationException(Strings.CannotCompileConstant(p0));
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0001070D File Offset: 0x0000E90D
		internal static Exception CannotCompileDynamic()
		{
			return new NotSupportedException(Strings.CannotCompileDynamic);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00010719 File Offset: 0x0000E919
		internal static Exception InvalidLvalue(ExpressionType p0)
		{
			return new InvalidOperationException(Strings.InvalidLvalue(p0));
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0001072B File Offset: 0x0000E92B
		internal static Exception UndefinedVariable(object p0, object p1, object p2)
		{
			return new InvalidOperationException(Strings.UndefinedVariable(p0, p1, p2));
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0001073A File Offset: 0x0000E93A
		internal static Exception CannotCloseOverByRef(object p0, object p1)
		{
			return new InvalidOperationException(Strings.CannotCloseOverByRef(p0, p1));
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00010748 File Offset: 0x0000E948
		internal static Exception UnexpectedVarArgsCall(object p0)
		{
			return new InvalidOperationException(Strings.UnexpectedVarArgsCall(p0));
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00010755 File Offset: 0x0000E955
		internal static Exception RethrowRequiresCatch()
		{
			return new InvalidOperationException(Strings.RethrowRequiresCatch);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00010761 File Offset: 0x0000E961
		internal static Exception TryNotAllowedInFilter()
		{
			return new InvalidOperationException(Strings.TryNotAllowedInFilter);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0001076D File Offset: 0x0000E96D
		internal static Exception MustRewriteToSameNode(object p0, object p1, object p2)
		{
			return new InvalidOperationException(Strings.MustRewriteToSameNode(p0, p1, p2));
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0001077C File Offset: 0x0000E97C
		internal static Exception MustRewriteChildToSameType(object p0, object p1, object p2)
		{
			return new InvalidOperationException(Strings.MustRewriteChildToSameType(p0, p1, p2));
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0001078B File Offset: 0x0000E98B
		internal static Exception MustRewriteWithoutMethod(object p0, object p1)
		{
			return new InvalidOperationException(Strings.MustRewriteWithoutMethod(p0, p1));
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00010799 File Offset: 0x0000E999
		internal static Exception TryNotSupportedForMethodsWithRefArgs(object p0)
		{
			return new NotSupportedException(Strings.TryNotSupportedForMethodsWithRefArgs(p0));
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x000107A6 File Offset: 0x0000E9A6
		internal static Exception TryNotSupportedForValueTypeInstances(object p0)
		{
			return new NotSupportedException(Strings.TryNotSupportedForValueTypeInstances(p0));
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x000107B3 File Offset: 0x0000E9B3
		internal static Exception TestValueTypeDoesNotMatchComparisonMethodParameter(object p0, object p1)
		{
			return new ArgumentException(Strings.TestValueTypeDoesNotMatchComparisonMethodParameter(p0, p1));
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x000107C1 File Offset: 0x0000E9C1
		internal static Exception SwitchValueTypeDoesNotMatchComparisonMethodParameter(object p0, object p1)
		{
			return new ArgumentException(Strings.SwitchValueTypeDoesNotMatchComparisonMethodParameter(p0, p1));
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00003EF8 File Offset: 0x000020F8
		internal static Exception ArgumentOutOfRange(string paramName)
		{
			return new ArgumentOutOfRangeException(paramName);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x000107CF File Offset: 0x0000E9CF
		internal static Exception NonStaticConstructorRequired(string paramName)
		{
			return new ArgumentException(Strings.NonStaticConstructorRequired, paramName);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x000107DC File Offset: 0x0000E9DC
		internal static Exception NonAbstractConstructorRequired()
		{
			return new InvalidOperationException(Strings.NonAbstractConstructorRequired);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x000107E8 File Offset: 0x0000E9E8
		internal static Exception InvalidProgram()
		{
			return new InvalidProgramException();
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x000107EF File Offset: 0x0000E9EF
		internal static Exception EnumerationIsDone()
		{
			return new InvalidOperationException(Strings.EnumerationIsDone);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x000107FB File Offset: 0x0000E9FB
		private static Exception TypeContainsGenericParameters(object p0, string paramName)
		{
			return new ArgumentException(Strings.TypeContainsGenericParameters(p0), paramName);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00010809 File Offset: 0x0000EA09
		internal static Exception TypeContainsGenericParameters(object p0, string paramName, int index)
		{
			return Error.TypeContainsGenericParameters(p0, Error.GetParamName(paramName, index));
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00010818 File Offset: 0x0000EA18
		internal static Exception TypeIsGeneric(object p0, string paramName)
		{
			return new ArgumentException(Strings.TypeIsGeneric(p0), paramName);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00010826 File Offset: 0x0000EA26
		internal static Exception TypeIsGeneric(object p0, string paramName, int index)
		{
			return Error.TypeIsGeneric(p0, Error.GetParamName(paramName, index));
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00010835 File Offset: 0x0000EA35
		internal static Exception IncorrectNumberOfConstructorArguments()
		{
			return new ArgumentException(Strings.IncorrectNumberOfConstructorArguments);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00010841 File Offset: 0x0000EA41
		internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName)
		{
			return new ArgumentException(Strings.ExpressionTypeDoesNotMatchMethodParameter(p0, p1, p2), paramName);
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00010851 File Offset: 0x0000EA51
		internal static Exception ExpressionTypeDoesNotMatchMethodParameter(object p0, object p1, object p2, string paramName, int index)
		{
			return Error.ExpressionTypeDoesNotMatchMethodParameter(p0, p1, p2, Error.GetParamName(paramName, index));
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00010863 File Offset: 0x0000EA63
		internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName)
		{
			return new ArgumentException(Strings.ExpressionTypeDoesNotMatchParameter(p0, p1), paramName);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00010872 File Offset: 0x0000EA72
		internal static Exception ExpressionTypeDoesNotMatchParameter(object p0, object p1, string paramName, int index)
		{
			return Error.ExpressionTypeDoesNotMatchParameter(p0, p1, Error.GetParamName(paramName, index));
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00010882 File Offset: 0x0000EA82
		internal static Exception IncorrectNumberOfLambdaArguments()
		{
			return new InvalidOperationException(Strings.IncorrectNumberOfLambdaArguments);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0001088E File Offset: 0x0000EA8E
		internal static Exception IncorrectNumberOfMethodCallArguments(object p0, string paramName)
		{
			return new ArgumentException(Strings.IncorrectNumberOfMethodCallArguments(p0), paramName);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0001089C File Offset: 0x0000EA9C
		internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName)
		{
			return new ArgumentException(Strings.ExpressionTypeDoesNotMatchConstructorParameter(p0, p1), paramName);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x000108AB File Offset: 0x0000EAAB
		internal static Exception ExpressionTypeDoesNotMatchConstructorParameter(object p0, object p1, string paramName, int index)
		{
			return Error.ExpressionTypeDoesNotMatchConstructorParameter(p0, p1, Error.GetParamName(paramName, index));
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000108BB File Offset: 0x0000EABB
		internal static Exception ExpressionMustBeReadable(string paramName)
		{
			return new ArgumentException(Strings.ExpressionMustBeReadable, paramName);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x000108C8 File Offset: 0x0000EAC8
		internal static Exception ExpressionMustBeReadable(string paramName, int index)
		{
			return Error.ExpressionMustBeReadable(Error.GetParamName(paramName, index));
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x000108D6 File Offset: 0x0000EAD6
		internal static Exception InvalidArgumentValue(string paramName)
		{
			return new ArgumentException(Strings.InvalidArgumentValue, paramName);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x000108E3 File Offset: 0x0000EAE3
		internal static Exception NonEmptyCollectionRequired(string paramName)
		{
			return new ArgumentException(Strings.NonEmptyCollectionRequired, paramName);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x000108F0 File Offset: 0x0000EAF0
		internal static Exception InvalidNullValue(Type type, string paramName)
		{
			return new ArgumentException(Strings.InvalidNullValue(type), paramName);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000108FE File Offset: 0x0000EAFE
		internal static Exception InvalidTypeException(object value, Type type, string paramName)
		{
			return new ArgumentException(Strings.InvalidObjectType(((value != null) ? value.GetType() : null) ?? "null", type), paramName);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00010921 File Offset: 0x0000EB21
		private static string GetParamName(string paramName, int index)
		{
			if (index >= 0)
			{
				return string.Format("{0}[{1}]", paramName, index);
			}
			return paramName;
		}
	}
}
