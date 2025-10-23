using System;
using System.Dynamic.Utils;
using System.Reflection;
using System.Reflection.Emit;

namespace System.Linq.Expressions.Compiler
{
	// Token: 0x020000E1 RID: 225
	internal static class ILGen
	{
		// Token: 0x0600070C RID: 1804 RVA: 0x000165BC File Offset: 0x000147BC
		internal static void Emit(this ILGenerator il, OpCode opcode, MethodBase methodBase)
		{
			ConstructorInfo constructorInfo = methodBase as ConstructorInfo;
			if (constructorInfo != null)
			{
				il.Emit(opcode, constructorInfo);
				return;
			}
			il.Emit(opcode, (MethodInfo)methodBase);
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x000165EC File Offset: 0x000147EC
		internal static void EmitLoadArg(this ILGenerator il, int index)
		{
			switch (index)
			{
			case 0:
				il.Emit(OpCodes.Ldarg_0);
				return;
			case 1:
				il.Emit(OpCodes.Ldarg_1);
				return;
			case 2:
				il.Emit(OpCodes.Ldarg_2);
				return;
			case 3:
				il.Emit(OpCodes.Ldarg_3);
				return;
			default:
				if (index <= 255)
				{
					il.Emit(OpCodes.Ldarg_S, (byte)index);
					return;
				}
				il.Emit(OpCodes.Ldarg, (short)index);
				return;
			}
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00016664 File Offset: 0x00014864
		internal static void EmitLoadArgAddress(this ILGenerator il, int index)
		{
			if (index <= 255)
			{
				il.Emit(OpCodes.Ldarga_S, (byte)index);
				return;
			}
			il.Emit(OpCodes.Ldarga, (short)index);
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00016689 File Offset: 0x00014889
		internal static void EmitStoreArg(this ILGenerator il, int index)
		{
			if (index <= 255)
			{
				il.Emit(OpCodes.Starg_S, (byte)index);
				return;
			}
			il.Emit(OpCodes.Starg, (short)index);
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x000166B0 File Offset: 0x000148B0
		internal static void EmitLoadValueIndirect(this ILGenerator il, Type type)
		{
			switch (type.GetTypeCode())
			{
			case TypeCode.Boolean:
			case TypeCode.SByte:
				il.Emit(OpCodes.Ldind_U1);
				return;
			case TypeCode.Char:
			case TypeCode.UInt16:
				il.Emit(OpCodes.Ldind_U2);
				return;
			case TypeCode.Byte:
				il.Emit(OpCodes.Ldind_I1);
				return;
			case TypeCode.Int16:
				il.Emit(OpCodes.Ldind_I2);
				return;
			case TypeCode.Int32:
				il.Emit(OpCodes.Ldind_I4);
				return;
			case TypeCode.UInt32:
				il.Emit(OpCodes.Ldind_U4);
				return;
			case TypeCode.Int64:
			case TypeCode.UInt64:
				il.Emit(OpCodes.Ldind_I8);
				return;
			case TypeCode.Single:
				il.Emit(OpCodes.Ldind_R4);
				return;
			case TypeCode.Double:
				il.Emit(OpCodes.Ldind_R8);
				return;
			default:
				if (type.IsValueType)
				{
					il.Emit(OpCodes.Ldobj, type);
					return;
				}
				il.Emit(OpCodes.Ldind_Ref);
				return;
			}
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x0001678C File Offset: 0x0001498C
		internal static void EmitStoreValueIndirect(this ILGenerator il, Type type)
		{
			switch (type.GetTypeCode())
			{
			case TypeCode.Boolean:
			case TypeCode.SByte:
			case TypeCode.Byte:
				il.Emit(OpCodes.Stind_I1);
				return;
			case TypeCode.Char:
			case TypeCode.Int16:
			case TypeCode.UInt16:
				il.Emit(OpCodes.Stind_I2);
				return;
			case TypeCode.Int32:
			case TypeCode.UInt32:
				il.Emit(OpCodes.Stind_I4);
				return;
			case TypeCode.Int64:
			case TypeCode.UInt64:
				il.Emit(OpCodes.Stind_I8);
				return;
			case TypeCode.Single:
				il.Emit(OpCodes.Stind_R4);
				return;
			case TypeCode.Double:
				il.Emit(OpCodes.Stind_R8);
				return;
			default:
				if (type.IsValueType)
				{
					il.Emit(OpCodes.Stobj, type);
					return;
				}
				il.Emit(OpCodes.Stind_Ref);
				return;
			}
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00016844 File Offset: 0x00014A44
		internal static void EmitLoadElement(this ILGenerator il, Type type)
		{
			if (!type.IsValueType)
			{
				il.Emit(OpCodes.Ldelem_Ref);
				return;
			}
			switch (type.GetTypeCode())
			{
			case TypeCode.Boolean:
			case TypeCode.SByte:
				il.Emit(OpCodes.Ldelem_I1);
				return;
			case TypeCode.Char:
			case TypeCode.UInt16:
				il.Emit(OpCodes.Ldelem_U2);
				return;
			case TypeCode.Byte:
				il.Emit(OpCodes.Ldelem_U1);
				return;
			case TypeCode.Int16:
				il.Emit(OpCodes.Ldelem_I2);
				return;
			case TypeCode.Int32:
				il.Emit(OpCodes.Ldelem_I4);
				return;
			case TypeCode.UInt32:
				il.Emit(OpCodes.Ldelem_U4);
				return;
			case TypeCode.Int64:
			case TypeCode.UInt64:
				il.Emit(OpCodes.Ldelem_I8);
				return;
			case TypeCode.Single:
				il.Emit(OpCodes.Ldelem_R4);
				return;
			case TypeCode.Double:
				il.Emit(OpCodes.Ldelem_R8);
				return;
			default:
				il.Emit(OpCodes.Ldelem, type);
				return;
			}
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00016920 File Offset: 0x00014B20
		internal static void EmitStoreElement(this ILGenerator il, Type type)
		{
			switch (type.GetTypeCode())
			{
			case TypeCode.Boolean:
			case TypeCode.SByte:
			case TypeCode.Byte:
				il.Emit(OpCodes.Stelem_I1);
				return;
			case TypeCode.Char:
			case TypeCode.Int16:
			case TypeCode.UInt16:
				il.Emit(OpCodes.Stelem_I2);
				return;
			case TypeCode.Int32:
			case TypeCode.UInt32:
				il.Emit(OpCodes.Stelem_I4);
				return;
			case TypeCode.Int64:
			case TypeCode.UInt64:
				il.Emit(OpCodes.Stelem_I8);
				return;
			case TypeCode.Single:
				il.Emit(OpCodes.Stelem_R4);
				return;
			case TypeCode.Double:
				il.Emit(OpCodes.Stelem_R8);
				return;
			default:
				if (type.IsValueType)
				{
					il.Emit(OpCodes.Stelem, type);
					return;
				}
				il.Emit(OpCodes.Stelem_Ref);
				return;
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x000169D6 File Offset: 0x00014BD6
		internal static void EmitType(this ILGenerator il, Type type)
		{
			il.Emit(OpCodes.Ldtoken, type);
			il.Emit(OpCodes.Call, CachedReflectionInfo.Type_GetTypeFromHandle);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x000169F4 File Offset: 0x00014BF4
		internal static void EmitFieldAddress(this ILGenerator il, FieldInfo fi)
		{
			il.Emit(fi.IsStatic ? OpCodes.Ldsflda : OpCodes.Ldflda, fi);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00016A11 File Offset: 0x00014C11
		internal static void EmitFieldGet(this ILGenerator il, FieldInfo fi)
		{
			il.Emit(fi.IsStatic ? OpCodes.Ldsfld : OpCodes.Ldfld, fi);
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00016A2E File Offset: 0x00014C2E
		internal static void EmitFieldSet(this ILGenerator il, FieldInfo fi)
		{
			il.Emit(fi.IsStatic ? OpCodes.Stsfld : OpCodes.Stfld, fi);
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00016A4B File Offset: 0x00014C4B
		internal static void EmitNew(this ILGenerator il, ConstructorInfo ci)
		{
			il.Emit(OpCodes.Newobj, ci);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00016A59 File Offset: 0x00014C59
		internal static void EmitNull(this ILGenerator il)
		{
			il.Emit(OpCodes.Ldnull);
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00016A66 File Offset: 0x00014C66
		internal static void EmitString(this ILGenerator il, string value)
		{
			il.Emit(OpCodes.Ldstr, value);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00016A74 File Offset: 0x00014C74
		internal static void EmitPrimitive(this ILGenerator il, bool value)
		{
			il.Emit(value ? OpCodes.Ldc_I4_1 : OpCodes.Ldc_I4_0);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00016A8C File Offset: 0x00014C8C
		internal static void EmitPrimitive(this ILGenerator il, int value)
		{
			OpCode opcode;
			switch (value)
			{
			case -1:
				opcode = OpCodes.Ldc_I4_M1;
				break;
			case 0:
				opcode = OpCodes.Ldc_I4_0;
				break;
			case 1:
				opcode = OpCodes.Ldc_I4_1;
				break;
			case 2:
				opcode = OpCodes.Ldc_I4_2;
				break;
			case 3:
				opcode = OpCodes.Ldc_I4_3;
				break;
			case 4:
				opcode = OpCodes.Ldc_I4_4;
				break;
			case 5:
				opcode = OpCodes.Ldc_I4_5;
				break;
			case 6:
				opcode = OpCodes.Ldc_I4_6;
				break;
			case 7:
				opcode = OpCodes.Ldc_I4_7;
				break;
			case 8:
				opcode = OpCodes.Ldc_I4_8;
				break;
			default:
				if (value >= -128 && value <= 127)
				{
					il.Emit(OpCodes.Ldc_I4_S, (sbyte)value);
					return;
				}
				il.Emit(OpCodes.Ldc_I4, value);
				return;
			}
			il.Emit(opcode);
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00016B47 File Offset: 0x00014D47
		private static void EmitPrimitive(this ILGenerator il, uint value)
		{
			il.EmitPrimitive((int)value);
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00016B50 File Offset: 0x00014D50
		private static void EmitPrimitive(this ILGenerator il, long value)
		{
			if (-2147483648L <= value & value <= (long)((ulong)-1))
			{
				il.EmitPrimitive((int)value);
				il.Emit((value > 0L) ? OpCodes.Conv_U8 : OpCodes.Conv_I8);
				return;
			}
			il.Emit(OpCodes.Ldc_I8, value);
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00016BA0 File Offset: 0x00014DA0
		private static void EmitPrimitive(this ILGenerator il, ulong value)
		{
			il.EmitPrimitive((long)value);
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00016BA9 File Offset: 0x00014DA9
		private static void EmitPrimitive(this ILGenerator il, double value)
		{
			il.Emit(OpCodes.Ldc_R8, value);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00016BB7 File Offset: 0x00014DB7
		private static void EmitPrimitive(this ILGenerator il, float value)
		{
			il.Emit(OpCodes.Ldc_R4, value);
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00016BC8 File Offset: 0x00014DC8
		internal static bool CanEmitConstant(object value, Type type)
		{
			if (value == null || ILGen.CanEmitILConstant(type))
			{
				return true;
			}
			Type type2 = value as Type;
			if (type2 != null)
			{
				return ILGen.ShouldLdtoken(type2);
			}
			MethodBase methodBase = value as MethodBase;
			return methodBase != null && ILGen.ShouldLdtoken(methodBase);
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00016C14 File Offset: 0x00014E14
		private static bool CanEmitILConstant(Type type)
		{
			TypeCode typeCode = type.GetNonNullableType().GetTypeCode();
			return typeCode - TypeCode.Boolean <= 12 || typeCode == TypeCode.String;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00016C3C File Offset: 0x00014E3C
		internal static bool TryEmitConstant(this ILGenerator il, object value, Type type, ILocalCache locals)
		{
			if (value == null)
			{
				il.EmitDefault(type, locals);
				return true;
			}
			if (il.TryEmitILConstant(value, type))
			{
				return true;
			}
			Type type2 = value as Type;
			if (type2 != null)
			{
				if (ILGen.ShouldLdtoken(type2))
				{
					il.EmitType(type2);
					if (type != typeof(Type))
					{
						il.Emit(OpCodes.Castclass, type);
					}
					return true;
				}
				return false;
			}
			else
			{
				MethodBase methodBase = value as MethodBase;
				if (methodBase != null && ILGen.ShouldLdtoken(methodBase))
				{
					il.Emit(OpCodes.Ldtoken, methodBase);
					Type declaringType = methodBase.DeclaringType;
					if (declaringType != null && declaringType.IsGenericType)
					{
						il.Emit(OpCodes.Ldtoken, declaringType);
						il.Emit(OpCodes.Call, CachedReflectionInfo.MethodBase_GetMethodFromHandle_RuntimeMethodHandle_RuntimeTypeHandle);
					}
					else
					{
						il.Emit(OpCodes.Call, CachedReflectionInfo.MethodBase_GetMethodFromHandle_RuntimeMethodHandle);
					}
					if (type != typeof(MethodBase))
					{
						il.Emit(OpCodes.Castclass, type);
					}
					return true;
				}
				return false;
			}
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00016D2E File Offset: 0x00014F2E
		private static bool ShouldLdtoken(Type t)
		{
			return t.IsGenericParameter || t.IsVisible;
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00016D40 File Offset: 0x00014F40
		internal static bool ShouldLdtoken(MethodBase mb)
		{
			if (mb is DynamicMethod)
			{
				return false;
			}
			Type declaringType = mb.DeclaringType;
			return declaringType == null || ILGen.ShouldLdtoken(declaringType);
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00016D70 File Offset: 0x00014F70
		private static bool TryEmitILConstant(this ILGenerator il, object value, Type type)
		{
			if (!type.IsNullableType())
			{
				switch (type.GetTypeCode())
				{
				case TypeCode.Boolean:
					il.EmitPrimitive((bool)value);
					return true;
				case TypeCode.Char:
					il.EmitPrimitive((int)((char)value));
					return true;
				case TypeCode.SByte:
					il.EmitPrimitive((int)((sbyte)value));
					return true;
				case TypeCode.Byte:
					il.EmitPrimitive((int)((byte)value));
					return true;
				case TypeCode.Int16:
					il.EmitPrimitive((int)((short)value));
					return true;
				case TypeCode.UInt16:
					il.EmitPrimitive((int)((ushort)value));
					return true;
				case TypeCode.Int32:
					il.EmitPrimitive((int)value);
					return true;
				case TypeCode.UInt32:
					il.EmitPrimitive((uint)value);
					return true;
				case TypeCode.Int64:
					il.EmitPrimitive((long)value);
					return true;
				case TypeCode.UInt64:
					il.EmitPrimitive((ulong)value);
					return true;
				case TypeCode.Single:
					il.EmitPrimitive((float)value);
					return true;
				case TypeCode.Double:
					il.EmitPrimitive((double)value);
					return true;
				case TypeCode.Decimal:
					il.EmitDecimal((decimal)value);
					return true;
				case TypeCode.String:
					il.EmitString((string)value);
					return true;
				}
				return false;
			}
			Type nonNullableType = type.GetNonNullableType();
			if (il.TryEmitILConstant(value, nonNullableType))
			{
				il.Emit(OpCodes.Newobj, type.GetConstructor(new Type[]
				{
					nonNullableType
				}));
				return true;
			}
			return false;
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00016ED0 File Offset: 0x000150D0
		internal static void EmitConvertToType(this ILGenerator il, Type typeFrom, Type typeTo, bool isChecked, ILocalCache locals)
		{
			if (TypeUtils.AreEquivalent(typeFrom, typeTo))
			{
				return;
			}
			bool flag = typeFrom.IsNullableType();
			bool flag2 = typeTo.IsNullableType();
			Type nonNullableType = typeFrom.GetNonNullableType();
			Type nonNullableType2 = typeTo.GetNonNullableType();
			if (typeFrom.IsInterface || typeTo.IsInterface || typeFrom == typeof(object) || typeTo == typeof(object) || typeFrom == typeof(Enum) || typeFrom == typeof(ValueType) || TypeUtils.IsLegalExplicitVariantDelegateConversion(typeFrom, typeTo))
			{
				il.EmitCastToType(typeFrom, typeTo);
				return;
			}
			if (flag || flag2)
			{
				il.EmitNullableConversion(typeFrom, typeTo, isChecked, locals);
				return;
			}
			if ((!typeFrom.IsConvertible() || !typeTo.IsConvertible()) && (nonNullableType.IsAssignableFrom(nonNullableType2) || nonNullableType2.IsAssignableFrom(nonNullableType)))
			{
				il.EmitCastToType(typeFrom, typeTo);
				return;
			}
			if (typeFrom.IsArray && typeTo.IsArray)
			{
				il.EmitCastToType(typeFrom, typeTo);
				return;
			}
			il.EmitNumericConversion(typeFrom, typeTo, isChecked);
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00016FCC File Offset: 0x000151CC
		private static void EmitCastToType(this ILGenerator il, Type typeFrom, Type typeTo)
		{
			if (typeFrom.IsValueType)
			{
				il.Emit(OpCodes.Box, typeFrom);
				if (typeTo != typeof(object))
				{
					il.Emit(OpCodes.Castclass, typeTo);
					return;
				}
			}
			else
			{
				il.Emit(typeTo.IsValueType ? OpCodes.Unbox_Any : OpCodes.Castclass, typeTo);
			}
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00017028 File Offset: 0x00015228
		private static void EmitNumericConversion(this ILGenerator il, Type typeFrom, Type typeTo, bool isChecked)
		{
			TypeCode typeCode = typeTo.GetTypeCode();
			TypeCode typeCode2 = typeFrom.GetTypeCode();
			if (typeCode == typeCode2)
			{
				return;
			}
			bool flag = typeCode2.IsUnsigned();
			OpCode opcode;
			switch (typeCode)
			{
			case TypeCode.Char:
			case TypeCode.UInt16:
				switch (typeCode2)
				{
				case TypeCode.Char:
				case TypeCode.Byte:
				case TypeCode.UInt16:
					return;
				case TypeCode.SByte:
				case TypeCode.Int16:
					if (!isChecked)
					{
						return;
					}
					break;
				}
				opcode = (isChecked ? (flag ? OpCodes.Conv_Ovf_U2_Un : OpCodes.Conv_Ovf_U2) : OpCodes.Conv_U2);
				break;
			case TypeCode.SByte:
				if (isChecked)
				{
					opcode = (flag ? OpCodes.Conv_Ovf_I1_Un : OpCodes.Conv_Ovf_I1);
				}
				else
				{
					if (typeCode2 == TypeCode.Byte)
					{
						return;
					}
					opcode = OpCodes.Conv_I1;
				}
				break;
			case TypeCode.Byte:
				if (isChecked)
				{
					opcode = (flag ? OpCodes.Conv_Ovf_U1_Un : OpCodes.Conv_Ovf_U1);
				}
				else
				{
					if (typeCode2 == TypeCode.SByte)
					{
						return;
					}
					opcode = OpCodes.Conv_U1;
				}
				break;
			case TypeCode.Int16:
				switch (typeCode2)
				{
				case TypeCode.Char:
				case TypeCode.UInt16:
					if (!isChecked)
					{
						return;
					}
					break;
				case TypeCode.SByte:
				case TypeCode.Byte:
					return;
				}
				opcode = (isChecked ? (flag ? OpCodes.Conv_Ovf_I2_Un : OpCodes.Conv_Ovf_I2) : OpCodes.Conv_I2);
				break;
			case TypeCode.Int32:
				if (typeCode2 - TypeCode.SByte <= 3)
				{
					return;
				}
				if (typeCode2 == TypeCode.UInt32)
				{
					if (!isChecked)
					{
						return;
					}
				}
				opcode = (isChecked ? (flag ? OpCodes.Conv_Ovf_I4_Un : OpCodes.Conv_Ovf_I4) : OpCodes.Conv_I4);
				break;
			case TypeCode.UInt32:
				switch (typeCode2)
				{
				case TypeCode.Char:
				case TypeCode.Byte:
				case TypeCode.UInt16:
					return;
				case TypeCode.SByte:
				case TypeCode.Int16:
				case TypeCode.Int32:
					if (!isChecked)
					{
						return;
					}
					break;
				}
				opcode = (isChecked ? (flag ? OpCodes.Conv_Ovf_U4_Un : OpCodes.Conv_Ovf_U4) : OpCodes.Conv_U4);
				break;
			case TypeCode.Int64:
				if (!isChecked && typeCode2 == TypeCode.UInt64)
				{
					return;
				}
				opcode = (isChecked ? (flag ? OpCodes.Conv_Ovf_I8_Un : OpCodes.Conv_Ovf_I8) : (flag ? OpCodes.Conv_U8 : OpCodes.Conv_I8));
				break;
			case TypeCode.UInt64:
				if (!isChecked && typeCode2 == TypeCode.Int64)
				{
					return;
				}
				opcode = (isChecked ? ((flag || typeCode2.IsFloatingPoint()) ? OpCodes.Conv_Ovf_U8_Un : OpCodes.Conv_Ovf_U8) : ((flag || typeCode2.IsFloatingPoint()) ? OpCodes.Conv_U8 : OpCodes.Conv_I8));
				break;
			case TypeCode.Single:
				if (flag)
				{
					il.Emit(OpCodes.Conv_R_Un);
				}
				opcode = OpCodes.Conv_R4;
				break;
			case TypeCode.Double:
				if (flag)
				{
					il.Emit(OpCodes.Conv_R_Un);
				}
				opcode = OpCodes.Conv_R8;
				break;
			case TypeCode.Decimal:
			{
				MethodInfo meth;
				switch (typeCode2)
				{
				case TypeCode.Char:
					meth = CachedReflectionInfo.Decimal_op_Implicit_Char;
					break;
				case TypeCode.SByte:
					meth = CachedReflectionInfo.Decimal_op_Implicit_SByte;
					break;
				case TypeCode.Byte:
					meth = CachedReflectionInfo.Decimal_op_Implicit_Byte;
					break;
				case TypeCode.Int16:
					meth = CachedReflectionInfo.Decimal_op_Implicit_Int16;
					break;
				case TypeCode.UInt16:
					meth = CachedReflectionInfo.Decimal_op_Implicit_UInt16;
					break;
				case TypeCode.Int32:
					meth = CachedReflectionInfo.Decimal_op_Implicit_Int32;
					break;
				case TypeCode.UInt32:
					meth = CachedReflectionInfo.Decimal_op_Implicit_UInt32;
					break;
				case TypeCode.Int64:
					meth = CachedReflectionInfo.Decimal_op_Implicit_Int64;
					break;
				case TypeCode.UInt64:
					meth = CachedReflectionInfo.Decimal_op_Implicit_UInt64;
					break;
				default:
					throw ContractUtils.Unreachable;
				}
				il.Emit(OpCodes.Call, meth);
				return;
			}
			default:
				throw ContractUtils.Unreachable;
			}
			il.Emit(opcode);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00017314 File Offset: 0x00015514
		private static void EmitNullableToNullableConversion(this ILGenerator il, Type typeFrom, Type typeTo, bool isChecked, ILocalCache locals)
		{
			LocalBuilder local = locals.GetLocal(typeFrom);
			il.Emit(OpCodes.Stloc, local);
			il.Emit(OpCodes.Ldloca, local);
			il.EmitHasValue(typeFrom);
			Label label = il.DefineLabel();
			il.Emit(OpCodes.Brfalse_S, label);
			il.Emit(OpCodes.Ldloca, local);
			locals.FreeLocal(local);
			il.EmitGetValueOrDefault(typeFrom);
			Type nonNullableType = typeFrom.GetNonNullableType();
			Type nonNullableType2 = typeTo.GetNonNullableType();
			il.EmitConvertToType(nonNullableType, nonNullableType2, isChecked, locals);
			ConstructorInfo constructor = typeTo.GetConstructor(new Type[]
			{
				nonNullableType2
			});
			il.Emit(OpCodes.Newobj, constructor);
			Label label2 = il.DefineLabel();
			il.Emit(OpCodes.Br_S, label2);
			il.MarkLabel(label);
			LocalBuilder local2 = locals.GetLocal(typeTo);
			il.Emit(OpCodes.Ldloca, local2);
			il.Emit(OpCodes.Initobj, typeTo);
			il.Emit(OpCodes.Ldloc, local2);
			locals.FreeLocal(local2);
			il.MarkLabel(label2);
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x0001740C File Offset: 0x0001560C
		private static void EmitNonNullableToNullableConversion(this ILGenerator il, Type typeFrom, Type typeTo, bool isChecked, ILocalCache locals)
		{
			Type nonNullableType = typeTo.GetNonNullableType();
			il.EmitConvertToType(typeFrom, nonNullableType, isChecked, locals);
			ConstructorInfo constructor = typeTo.GetConstructor(new Type[]
			{
				nonNullableType
			});
			il.Emit(OpCodes.Newobj, constructor);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00017448 File Offset: 0x00015648
		private static void EmitNullableToNonNullableConversion(this ILGenerator il, Type typeFrom, Type typeTo, bool isChecked, ILocalCache locals)
		{
			if (typeTo.IsValueType)
			{
				il.EmitNullableToNonNullableStructConversion(typeFrom, typeTo, isChecked, locals);
				return;
			}
			il.EmitNullableToReferenceConversion(typeFrom);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00017468 File Offset: 0x00015668
		private static void EmitNullableToNonNullableStructConversion(this ILGenerator il, Type typeFrom, Type typeTo, bool isChecked, ILocalCache locals)
		{
			LocalBuilder local = locals.GetLocal(typeFrom);
			il.Emit(OpCodes.Stloc, local);
			il.Emit(OpCodes.Ldloca, local);
			locals.FreeLocal(local);
			il.EmitGetValue(typeFrom);
			Type nonNullableType = typeFrom.GetNonNullableType();
			il.EmitConvertToType(nonNullableType, typeTo, isChecked, locals);
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x000174B7 File Offset: 0x000156B7
		private static void EmitNullableToReferenceConversion(this ILGenerator il, Type typeFrom)
		{
			il.Emit(OpCodes.Box, typeFrom);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x000174C8 File Offset: 0x000156C8
		private static void EmitNullableConversion(this ILGenerator il, Type typeFrom, Type typeTo, bool isChecked, ILocalCache locals)
		{
			bool flag = typeFrom.IsNullableType();
			bool flag2 = typeTo.IsNullableType();
			if (flag && flag2)
			{
				il.EmitNullableToNullableConversion(typeFrom, typeTo, isChecked, locals);
				return;
			}
			if (flag)
			{
				il.EmitNullableToNonNullableConversion(typeFrom, typeTo, isChecked, locals);
				return;
			}
			il.EmitNonNullableToNullableConversion(typeFrom, typeTo, isChecked, locals);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00017510 File Offset: 0x00015710
		internal static void EmitHasValue(this ILGenerator il, Type nullableType)
		{
			MethodInfo method = nullableType.GetMethod("get_HasValue", BindingFlags.Instance | BindingFlags.Public);
			il.Emit(OpCodes.Call, method);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00017538 File Offset: 0x00015738
		internal static void EmitGetValue(this ILGenerator il, Type nullableType)
		{
			MethodInfo method = nullableType.GetMethod("get_Value", BindingFlags.Instance | BindingFlags.Public);
			il.Emit(OpCodes.Call, method);
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00017560 File Offset: 0x00015760
		internal static void EmitGetValueOrDefault(this ILGenerator il, Type nullableType)
		{
			MethodInfo method = nullableType.GetMethod("GetValueOrDefault", Type.EmptyTypes);
			il.Emit(OpCodes.Call, method);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0001758C File Offset: 0x0001578C
		internal static void EmitArray<T>(this ILGenerator il, T[] items, ILocalCache locals)
		{
			il.EmitPrimitive(items.Length);
			il.Emit(OpCodes.Newarr, typeof(T));
			for (int i = 0; i < items.Length; i++)
			{
				il.Emit(OpCodes.Dup);
				il.EmitPrimitive(i);
				il.TryEmitConstant(items[i], typeof(T), locals);
				il.EmitStoreElement(typeof(T));
			}
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00017605 File Offset: 0x00015805
		internal static void EmitArray(this ILGenerator il, Type elementType, int count)
		{
			il.EmitPrimitive(count);
			il.Emit(OpCodes.Newarr, elementType);
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x0001761C File Offset: 0x0001581C
		internal static void EmitArray(this ILGenerator il, Type arrayType)
		{
			if (arrayType.IsSZArray)
			{
				il.Emit(OpCodes.Newarr, arrayType.GetElementType());
				return;
			}
			Type[] array = new Type[arrayType.GetArrayRank()];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = typeof(int);
			}
			ConstructorInfo constructor = arrayType.GetConstructor(array);
			il.EmitNew(constructor);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0001767C File Offset: 0x0001587C
		private static void EmitDecimal(this ILGenerator il, decimal value)
		{
			int[] bits = decimal.GetBits(value);
			int num = (bits[3] & int.MaxValue) >> 16;
			if (num == 0)
			{
				if (-2147483648m <= value)
				{
					if (value <= 2147483647m)
					{
						int value2 = decimal.ToInt32(value);
						switch (value2)
						{
						case -1:
							il.Emit(OpCodes.Ldsfld, CachedReflectionInfo.Decimal_MinusOne);
							return;
						case 0:
							il.EmitDefault(typeof(decimal), null);
							return;
						case 1:
							il.Emit(OpCodes.Ldsfld, CachedReflectionInfo.Decimal_One);
							return;
						default:
							il.EmitPrimitive(value2);
							il.EmitNew(CachedReflectionInfo.Decimal_Ctor_Int32);
							return;
						}
					}
					else if (value <= 4294967295m)
					{
						il.EmitPrimitive(decimal.ToUInt32(value));
						il.EmitNew(CachedReflectionInfo.Decimal_Ctor_UInt32);
						return;
					}
				}
				if (-9223372036854775808m <= value)
				{
					if (value <= 9223372036854775807m)
					{
						il.EmitPrimitive(decimal.ToInt64(value));
						il.EmitNew(CachedReflectionInfo.Decimal_Ctor_Int64);
						return;
					}
					if (value <= 18446744073709551615m)
					{
						il.EmitPrimitive(decimal.ToUInt64(value));
						il.EmitNew(CachedReflectionInfo.Decimal_Ctor_UInt64);
						return;
					}
					if (value == 79228162514264337593543950335m)
					{
						il.Emit(OpCodes.Ldsfld, CachedReflectionInfo.Decimal_MaxValue);
						return;
					}
				}
				else if (value == -79228162514264337593543950335m)
				{
					il.Emit(OpCodes.Ldsfld, CachedReflectionInfo.Decimal_MinValue);
					return;
				}
			}
			il.EmitPrimitive(bits[0]);
			il.EmitPrimitive(bits[1]);
			il.EmitPrimitive(bits[2]);
			il.EmitPrimitive(((long)bits[3] & (long)((ulong)int.MinValue)) != 0L);
			il.EmitPrimitive((int)((byte)num));
			il.EmitNew(CachedReflectionInfo.Decimal_Ctor_Int32_Int32_Int32_Bool_Byte);
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00017848 File Offset: 0x00015A48
		internal static void EmitDefault(this ILGenerator il, Type type, ILocalCache locals)
		{
			switch (type.GetTypeCode())
			{
			case TypeCode.Empty:
			case TypeCode.DBNull:
			case TypeCode.String:
				break;
			case TypeCode.Object:
				if (type.IsValueType)
				{
					LocalBuilder local = locals.GetLocal(type);
					il.Emit(OpCodes.Ldloca, local);
					il.Emit(OpCodes.Initobj, type);
					il.Emit(OpCodes.Ldloc, local);
					locals.FreeLocal(local);
					return;
				}
				break;
			case TypeCode.Boolean:
			case TypeCode.Char:
			case TypeCode.SByte:
			case TypeCode.Byte:
			case TypeCode.Int16:
			case TypeCode.UInt16:
			case TypeCode.Int32:
			case TypeCode.UInt32:
				il.Emit(OpCodes.Ldc_I4_0);
				return;
			case TypeCode.Int64:
			case TypeCode.UInt64:
				il.Emit(OpCodes.Ldc_I4_0);
				il.Emit(OpCodes.Conv_I8);
				return;
			case TypeCode.Single:
				il.Emit(OpCodes.Ldc_R4, 0f);
				return;
			case TypeCode.Double:
				il.Emit(OpCodes.Ldc_R8, 0.0);
				return;
			case TypeCode.Decimal:
				il.Emit(OpCodes.Ldsfld, CachedReflectionInfo.Decimal_Zero);
				return;
			case TypeCode.DateTime:
				il.Emit(OpCodes.Ldsfld, CachedReflectionInfo.DateTime_MinValue);
				return;
			case (TypeCode)17:
				goto IL_111;
			default:
				goto IL_111;
			}
			il.Emit(OpCodes.Ldnull);
			return;
			IL_111:
			throw ContractUtils.Unreachable;
		}
	}
}
