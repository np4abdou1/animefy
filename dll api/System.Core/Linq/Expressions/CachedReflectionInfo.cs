using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions
{
	// Token: 0x02000049 RID: 73
	internal static class CachedReflectionInfo
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00008489 File Offset: 0x00006689
		public static MethodInfo CallSiteOps_SetNotMatched
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_CallSiteOps_SetNotMatched) == null)
				{
					result = (CachedReflectionInfo.s_CallSiteOps_SetNotMatched = typeof(CallSiteOps).GetMethod("SetNotMatched"));
				}
				return result;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060001CD RID: 461 RVA: 0x000084AE File Offset: 0x000066AE
		public static MethodInfo CallSiteOps_CreateMatchmaker
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_CallSiteOps_CreateMatchmaker) == null)
				{
					result = (CachedReflectionInfo.s_CallSiteOps_CreateMatchmaker = typeof(CallSiteOps).GetMethod("CreateMatchmaker"));
				}
				return result;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060001CE RID: 462 RVA: 0x000084D3 File Offset: 0x000066D3
		public static MethodInfo CallSiteOps_GetMatch
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_CallSiteOps_GetMatch) == null)
				{
					result = (CachedReflectionInfo.s_CallSiteOps_GetMatch = typeof(CallSiteOps).GetMethod("GetMatch"));
				}
				return result;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060001CF RID: 463 RVA: 0x000084F8 File Offset: 0x000066F8
		public static MethodInfo CallSiteOps_ClearMatch
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_CallSiteOps_ClearMatch) == null)
				{
					result = (CachedReflectionInfo.s_CallSiteOps_ClearMatch = typeof(CallSiteOps).GetMethod("ClearMatch"));
				}
				return result;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0000851D File Offset: 0x0000671D
		public static MethodInfo CallSiteOps_UpdateRules
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_CallSiteOps_UpdateRules) == null)
				{
					result = (CachedReflectionInfo.s_CallSiteOps_UpdateRules = typeof(CallSiteOps).GetMethod("UpdateRules"));
				}
				return result;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00008542 File Offset: 0x00006742
		public static MethodInfo CallSiteOps_GetRules
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_CallSiteOps_GetRules) == null)
				{
					result = (CachedReflectionInfo.s_CallSiteOps_GetRules = typeof(CallSiteOps).GetMethod("GetRules"));
				}
				return result;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00008567 File Offset: 0x00006767
		public static MethodInfo CallSiteOps_GetRuleCache
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_CallSiteOps_GetRuleCache) == null)
				{
					result = (CachedReflectionInfo.s_CallSiteOps_GetRuleCache = typeof(CallSiteOps).GetMethod("GetRuleCache"));
				}
				return result;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0000858C File Offset: 0x0000678C
		public static MethodInfo CallSiteOps_GetCachedRules
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_CallSiteOps_GetCachedRules) == null)
				{
					result = (CachedReflectionInfo.s_CallSiteOps_GetCachedRules = typeof(CallSiteOps).GetMethod("GetCachedRules"));
				}
				return result;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x000085B1 File Offset: 0x000067B1
		public static MethodInfo CallSiteOps_AddRule
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_CallSiteOps_AddRule) == null)
				{
					result = (CachedReflectionInfo.s_CallSiteOps_AddRule = typeof(CallSiteOps).GetMethod("AddRule"));
				}
				return result;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x000085D6 File Offset: 0x000067D6
		public static MethodInfo CallSiteOps_MoveRule
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_CallSiteOps_MoveRule) == null)
				{
					result = (CachedReflectionInfo.s_CallSiteOps_MoveRule = typeof(CallSiteOps).GetMethod("MoveRule"));
				}
				return result;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x000085FB File Offset: 0x000067FB
		public static MethodInfo CallSiteOps_Bind
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_CallSiteOps_Bind) == null)
				{
					result = (CachedReflectionInfo.s_CallSiteOps_Bind = typeof(CallSiteOps).GetMethod("Bind"));
				}
				return result;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00008620 File Offset: 0x00006820
		public static ConstructorInfo Nullable_Boolean_Ctor
		{
			get
			{
				ConstructorInfo result;
				if ((result = CachedReflectionInfo.s_Nullable_Boolean_Ctor) == null)
				{
					result = (CachedReflectionInfo.s_Nullable_Boolean_Ctor = typeof(bool?).GetConstructor(new Type[]
					{
						typeof(bool)
					}));
				}
				return result;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00008653 File Offset: 0x00006853
		public static ConstructorInfo Decimal_Ctor_Int32
		{
			get
			{
				ConstructorInfo result;
				if ((result = CachedReflectionInfo.s_Decimal_Ctor_Int32) == null)
				{
					result = (CachedReflectionInfo.s_Decimal_Ctor_Int32 = typeof(decimal).GetConstructor(new Type[]
					{
						typeof(int)
					}));
				}
				return result;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00008686 File Offset: 0x00006886
		public static ConstructorInfo Decimal_Ctor_UInt32
		{
			get
			{
				ConstructorInfo result;
				if ((result = CachedReflectionInfo.s_Decimal_Ctor_UInt32) == null)
				{
					result = (CachedReflectionInfo.s_Decimal_Ctor_UInt32 = typeof(decimal).GetConstructor(new Type[]
					{
						typeof(uint)
					}));
				}
				return result;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001DA RID: 474 RVA: 0x000086B9 File Offset: 0x000068B9
		public static ConstructorInfo Decimal_Ctor_Int64
		{
			get
			{
				ConstructorInfo result;
				if ((result = CachedReflectionInfo.s_Decimal_Ctor_Int64) == null)
				{
					result = (CachedReflectionInfo.s_Decimal_Ctor_Int64 = typeof(decimal).GetConstructor(new Type[]
					{
						typeof(long)
					}));
				}
				return result;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001DB RID: 475 RVA: 0x000086EC File Offset: 0x000068EC
		public static ConstructorInfo Decimal_Ctor_UInt64
		{
			get
			{
				ConstructorInfo result;
				if ((result = CachedReflectionInfo.s_Decimal_Ctor_UInt64) == null)
				{
					result = (CachedReflectionInfo.s_Decimal_Ctor_UInt64 = typeof(decimal).GetConstructor(new Type[]
					{
						typeof(ulong)
					}));
				}
				return result;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00008720 File Offset: 0x00006920
		public static ConstructorInfo Decimal_Ctor_Int32_Int32_Int32_Bool_Byte
		{
			get
			{
				ConstructorInfo result;
				if ((result = CachedReflectionInfo.s_Decimal_Ctor_Int32_Int32_Int32_Bool_Byte) == null)
				{
					result = (CachedReflectionInfo.s_Decimal_Ctor_Int32_Int32_Int32_Bool_Byte = typeof(decimal).GetConstructor(new Type[]
					{
						typeof(int),
						typeof(int),
						typeof(int),
						typeof(bool),
						typeof(byte)
					}));
				}
				return result;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00008792 File Offset: 0x00006992
		public static FieldInfo Decimal_One
		{
			get
			{
				FieldInfo result;
				if ((result = CachedReflectionInfo.s_Decimal_One) == null)
				{
					result = (CachedReflectionInfo.s_Decimal_One = typeof(decimal).GetField("One"));
				}
				return result;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001DE RID: 478 RVA: 0x000087B7 File Offset: 0x000069B7
		public static FieldInfo Decimal_MinusOne
		{
			get
			{
				FieldInfo result;
				if ((result = CachedReflectionInfo.s_Decimal_MinusOne) == null)
				{
					result = (CachedReflectionInfo.s_Decimal_MinusOne = typeof(decimal).GetField("MinusOne"));
				}
				return result;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060001DF RID: 479 RVA: 0x000087DC File Offset: 0x000069DC
		public static FieldInfo Decimal_MinValue
		{
			get
			{
				FieldInfo result;
				if ((result = CachedReflectionInfo.s_Decimal_MinValue) == null)
				{
					result = (CachedReflectionInfo.s_Decimal_MinValue = typeof(decimal).GetField("MinValue"));
				}
				return result;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00008801 File Offset: 0x00006A01
		public static FieldInfo Decimal_MaxValue
		{
			get
			{
				FieldInfo result;
				if ((result = CachedReflectionInfo.s_Decimal_MaxValue) == null)
				{
					result = (CachedReflectionInfo.s_Decimal_MaxValue = typeof(decimal).GetField("MaxValue"));
				}
				return result;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00008826 File Offset: 0x00006A26
		public static FieldInfo Decimal_Zero
		{
			get
			{
				FieldInfo result;
				if ((result = CachedReflectionInfo.s_Decimal_Zero) == null)
				{
					result = (CachedReflectionInfo.s_Decimal_Zero = typeof(decimal).GetField("Zero"));
				}
				return result;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0000884B File Offset: 0x00006A4B
		public static FieldInfo DateTime_MinValue
		{
			get
			{
				FieldInfo result;
				if ((result = CachedReflectionInfo.s_DateTime_MinValue) == null)
				{
					result = (CachedReflectionInfo.s_DateTime_MinValue = typeof(DateTime).GetField("MinValue"));
				}
				return result;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00008870 File Offset: 0x00006A70
		public static MethodInfo MethodBase_GetMethodFromHandle_RuntimeMethodHandle
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_MethodBase_GetMethodFromHandle_RuntimeMethodHandle) == null)
				{
					result = (CachedReflectionInfo.s_MethodBase_GetMethodFromHandle_RuntimeMethodHandle = typeof(MethodBase).GetMethod("GetMethodFromHandle", new Type[]
					{
						typeof(RuntimeMethodHandle)
					}));
				}
				return result;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x000088A8 File Offset: 0x00006AA8
		public static MethodInfo MethodBase_GetMethodFromHandle_RuntimeMethodHandle_RuntimeTypeHandle
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_MethodBase_GetMethodFromHandle_RuntimeMethodHandle_RuntimeTypeHandle) == null)
				{
					result = (CachedReflectionInfo.s_MethodBase_GetMethodFromHandle_RuntimeMethodHandle_RuntimeTypeHandle = typeof(MethodBase).GetMethod("GetMethodFromHandle", new Type[]
					{
						typeof(RuntimeMethodHandle),
						typeof(RuntimeTypeHandle)
					}));
				}
				return result;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x000088F8 File Offset: 0x00006AF8
		public static MethodInfo MethodInfo_CreateDelegate_Type_Object
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_MethodInfo_CreateDelegate_Type_Object) == null)
				{
					result = (CachedReflectionInfo.s_MethodInfo_CreateDelegate_Type_Object = typeof(MethodInfo).GetMethod("CreateDelegate", new Type[]
					{
						typeof(Type),
						typeof(object)
					}));
				}
				return result;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00008948 File Offset: 0x00006B48
		public static MethodInfo String_op_Equality_String_String
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_String_op_Equality_String_String) == null)
				{
					result = (CachedReflectionInfo.s_String_op_Equality_String_String = typeof(string).GetMethod("op_Equality", new Type[]
					{
						typeof(string),
						typeof(string)
					}));
				}
				return result;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00008998 File Offset: 0x00006B98
		public static MethodInfo String_Equals_String_String
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_String_Equals_String_String) == null)
				{
					result = (CachedReflectionInfo.s_String_Equals_String_String = typeof(string).GetMethod("Equals", new Type[]
					{
						typeof(string),
						typeof(string)
					}));
				}
				return result;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x000089E8 File Offset: 0x00006BE8
		public static MethodInfo DictionaryOfStringInt32_Add_String_Int32
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_DictionaryOfStringInt32_Add_String_Int32) == null)
				{
					result = (CachedReflectionInfo.s_DictionaryOfStringInt32_Add_String_Int32 = typeof(Dictionary<string, int>).GetMethod("Add", new Type[]
					{
						typeof(string),
						typeof(int)
					}));
				}
				return result;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00008A38 File Offset: 0x00006C38
		public static ConstructorInfo DictionaryOfStringInt32_Ctor_Int32
		{
			get
			{
				ConstructorInfo result;
				if ((result = CachedReflectionInfo.s_DictionaryOfStringInt32_Ctor_Int32) == null)
				{
					result = (CachedReflectionInfo.s_DictionaryOfStringInt32_Ctor_Int32 = typeof(Dictionary<string, int>).GetConstructor(new Type[]
					{
						typeof(int)
					}));
				}
				return result;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00008A6B File Offset: 0x00006C6B
		public static MethodInfo Type_GetTypeFromHandle
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_Type_GetTypeFromHandle) == null)
				{
					result = (CachedReflectionInfo.s_Type_GetTypeFromHandle = typeof(Type).GetMethod("GetTypeFromHandle"));
				}
				return result;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00008A90 File Offset: 0x00006C90
		public static MethodInfo Object_GetType
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_Object_GetType) == null)
				{
					result = (CachedReflectionInfo.s_Object_GetType = typeof(object).GetMethod("GetType"));
				}
				return result;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00008AB5 File Offset: 0x00006CB5
		public static MethodInfo Decimal_op_Implicit_Byte
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_Decimal_op_Implicit_Byte) == null)
				{
					result = (CachedReflectionInfo.s_Decimal_op_Implicit_Byte = typeof(decimal).GetMethod("op_Implicit", new Type[]
					{
						typeof(byte)
					}));
				}
				return result;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00008AED File Offset: 0x00006CED
		public static MethodInfo Decimal_op_Implicit_SByte
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_Decimal_op_Implicit_SByte) == null)
				{
					result = (CachedReflectionInfo.s_Decimal_op_Implicit_SByte = typeof(decimal).GetMethod("op_Implicit", new Type[]
					{
						typeof(sbyte)
					}));
				}
				return result;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001EE RID: 494 RVA: 0x00008B25 File Offset: 0x00006D25
		public static MethodInfo Decimal_op_Implicit_Int16
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_Decimal_op_Implicit_Int16) == null)
				{
					result = (CachedReflectionInfo.s_Decimal_op_Implicit_Int16 = typeof(decimal).GetMethod("op_Implicit", new Type[]
					{
						typeof(short)
					}));
				}
				return result;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00008B5D File Offset: 0x00006D5D
		public static MethodInfo Decimal_op_Implicit_UInt16
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_Decimal_op_Implicit_UInt16) == null)
				{
					result = (CachedReflectionInfo.s_Decimal_op_Implicit_UInt16 = typeof(decimal).GetMethod("op_Implicit", new Type[]
					{
						typeof(ushort)
					}));
				}
				return result;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00008B95 File Offset: 0x00006D95
		public static MethodInfo Decimal_op_Implicit_Int32
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_Decimal_op_Implicit_Int32) == null)
				{
					result = (CachedReflectionInfo.s_Decimal_op_Implicit_Int32 = typeof(decimal).GetMethod("op_Implicit", new Type[]
					{
						typeof(int)
					}));
				}
				return result;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00008BCD File Offset: 0x00006DCD
		public static MethodInfo Decimal_op_Implicit_UInt32
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_Decimal_op_Implicit_UInt32) == null)
				{
					result = (CachedReflectionInfo.s_Decimal_op_Implicit_UInt32 = typeof(decimal).GetMethod("op_Implicit", new Type[]
					{
						typeof(uint)
					}));
				}
				return result;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00008C05 File Offset: 0x00006E05
		public static MethodInfo Decimal_op_Implicit_Int64
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_Decimal_op_Implicit_Int64) == null)
				{
					result = (CachedReflectionInfo.s_Decimal_op_Implicit_Int64 = typeof(decimal).GetMethod("op_Implicit", new Type[]
					{
						typeof(long)
					}));
				}
				return result;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00008C3D File Offset: 0x00006E3D
		public static MethodInfo Decimal_op_Implicit_UInt64
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_Decimal_op_Implicit_UInt64) == null)
				{
					result = (CachedReflectionInfo.s_Decimal_op_Implicit_UInt64 = typeof(decimal).GetMethod("op_Implicit", new Type[]
					{
						typeof(ulong)
					}));
				}
				return result;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00008C75 File Offset: 0x00006E75
		public static MethodInfo Decimal_op_Implicit_Char
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_Decimal_op_Implicit_Char) == null)
				{
					result = (CachedReflectionInfo.s_Decimal_op_Implicit_Char = typeof(decimal).GetMethod("op_Implicit", new Type[]
					{
						typeof(char)
					}));
				}
				return result;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00008CB0 File Offset: 0x00006EB0
		public static MethodInfo Math_Pow_Double_Double
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_Math_Pow_Double_Double) == null)
				{
					result = (CachedReflectionInfo.s_Math_Pow_Double_Double = typeof(Math).GetMethod("Pow", new Type[]
					{
						typeof(double),
						typeof(double)
					}));
				}
				return result;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00008D00 File Offset: 0x00006F00
		public static ConstructorInfo Closure_ObjectArray_ObjectArray
		{
			get
			{
				ConstructorInfo result;
				if ((result = CachedReflectionInfo.s_Closure_ObjectArray_ObjectArray) == null)
				{
					result = (CachedReflectionInfo.s_Closure_ObjectArray_ObjectArray = typeof(Closure).GetConstructor(new Type[]
					{
						typeof(object[]),
						typeof(object[])
					}));
				}
				return result;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00008D40 File Offset: 0x00006F40
		public static FieldInfo Closure_Constants
		{
			get
			{
				FieldInfo result;
				if ((result = CachedReflectionInfo.s_Closure_Constants) == null)
				{
					result = (CachedReflectionInfo.s_Closure_Constants = typeof(Closure).GetField("Constants"));
				}
				return result;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00008D65 File Offset: 0x00006F65
		public static FieldInfo Closure_Locals
		{
			get
			{
				FieldInfo result;
				if ((result = CachedReflectionInfo.s_Closure_Locals) == null)
				{
					result = (CachedReflectionInfo.s_Closure_Locals = typeof(Closure).GetField("Locals"));
				}
				return result;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00008D8C File Offset: 0x00006F8C
		public static MethodInfo RuntimeOps_CreateRuntimeVariables_ObjectArray_Int64Array
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_RuntimeOps_CreateRuntimeVariables_ObjectArray_Int64Array) == null)
				{
					result = (CachedReflectionInfo.s_RuntimeOps_CreateRuntimeVariables_ObjectArray_Int64Array = typeof(RuntimeOps).GetMethod("CreateRuntimeVariables", new Type[]
					{
						typeof(object[]),
						typeof(long[])
					}));
				}
				return result;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00008DDC File Offset: 0x00006FDC
		public static MethodInfo RuntimeOps_CreateRuntimeVariables
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_RuntimeOps_CreateRuntimeVariables) == null)
				{
					result = (CachedReflectionInfo.s_RuntimeOps_CreateRuntimeVariables = typeof(RuntimeOps).GetMethod("CreateRuntimeVariables", Type.EmptyTypes));
				}
				return result;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00008E06 File Offset: 0x00007006
		public static MethodInfo RuntimeOps_Quote
		{
			get
			{
				MethodInfo result;
				if ((result = CachedReflectionInfo.s_RuntimeOps_Quote) == null)
				{
					result = (CachedReflectionInfo.s_RuntimeOps_Quote = typeof(RuntimeOps).GetMethod("Quote"));
				}
				return result;
			}
		}

		// Token: 0x0400008F RID: 143
		private static MethodInfo s_CallSiteOps_SetNotMatched;

		// Token: 0x04000090 RID: 144
		private static MethodInfo s_CallSiteOps_CreateMatchmaker;

		// Token: 0x04000091 RID: 145
		private static MethodInfo s_CallSiteOps_GetMatch;

		// Token: 0x04000092 RID: 146
		private static MethodInfo s_CallSiteOps_ClearMatch;

		// Token: 0x04000093 RID: 147
		private static MethodInfo s_CallSiteOps_UpdateRules;

		// Token: 0x04000094 RID: 148
		private static MethodInfo s_CallSiteOps_GetRules;

		// Token: 0x04000095 RID: 149
		private static MethodInfo s_CallSiteOps_GetRuleCache;

		// Token: 0x04000096 RID: 150
		private static MethodInfo s_CallSiteOps_GetCachedRules;

		// Token: 0x04000097 RID: 151
		private static MethodInfo s_CallSiteOps_AddRule;

		// Token: 0x04000098 RID: 152
		private static MethodInfo s_CallSiteOps_MoveRule;

		// Token: 0x04000099 RID: 153
		private static MethodInfo s_CallSiteOps_Bind;

		// Token: 0x0400009A RID: 154
		private static ConstructorInfo s_Nullable_Boolean_Ctor;

		// Token: 0x0400009B RID: 155
		private static ConstructorInfo s_Decimal_Ctor_Int32;

		// Token: 0x0400009C RID: 156
		private static ConstructorInfo s_Decimal_Ctor_UInt32;

		// Token: 0x0400009D RID: 157
		private static ConstructorInfo s_Decimal_Ctor_Int64;

		// Token: 0x0400009E RID: 158
		private static ConstructorInfo s_Decimal_Ctor_UInt64;

		// Token: 0x0400009F RID: 159
		private static ConstructorInfo s_Decimal_Ctor_Int32_Int32_Int32_Bool_Byte;

		// Token: 0x040000A0 RID: 160
		private static FieldInfo s_Decimal_One;

		// Token: 0x040000A1 RID: 161
		private static FieldInfo s_Decimal_MinusOne;

		// Token: 0x040000A2 RID: 162
		private static FieldInfo s_Decimal_MinValue;

		// Token: 0x040000A3 RID: 163
		private static FieldInfo s_Decimal_MaxValue;

		// Token: 0x040000A4 RID: 164
		private static FieldInfo s_Decimal_Zero;

		// Token: 0x040000A5 RID: 165
		private static FieldInfo s_DateTime_MinValue;

		// Token: 0x040000A6 RID: 166
		private static MethodInfo s_MethodBase_GetMethodFromHandle_RuntimeMethodHandle;

		// Token: 0x040000A7 RID: 167
		private static MethodInfo s_MethodBase_GetMethodFromHandle_RuntimeMethodHandle_RuntimeTypeHandle;

		// Token: 0x040000A8 RID: 168
		private static MethodInfo s_MethodInfo_CreateDelegate_Type_Object;

		// Token: 0x040000A9 RID: 169
		private static MethodInfo s_String_op_Equality_String_String;

		// Token: 0x040000AA RID: 170
		private static MethodInfo s_String_Equals_String_String;

		// Token: 0x040000AB RID: 171
		private static MethodInfo s_DictionaryOfStringInt32_Add_String_Int32;

		// Token: 0x040000AC RID: 172
		private static ConstructorInfo s_DictionaryOfStringInt32_Ctor_Int32;

		// Token: 0x040000AD RID: 173
		private static MethodInfo s_Type_GetTypeFromHandle;

		// Token: 0x040000AE RID: 174
		private static MethodInfo s_Object_GetType;

		// Token: 0x040000AF RID: 175
		private static MethodInfo s_Decimal_op_Implicit_Byte;

		// Token: 0x040000B0 RID: 176
		private static MethodInfo s_Decimal_op_Implicit_SByte;

		// Token: 0x040000B1 RID: 177
		private static MethodInfo s_Decimal_op_Implicit_Int16;

		// Token: 0x040000B2 RID: 178
		private static MethodInfo s_Decimal_op_Implicit_UInt16;

		// Token: 0x040000B3 RID: 179
		private static MethodInfo s_Decimal_op_Implicit_Int32;

		// Token: 0x040000B4 RID: 180
		private static MethodInfo s_Decimal_op_Implicit_UInt32;

		// Token: 0x040000B5 RID: 181
		private static MethodInfo s_Decimal_op_Implicit_Int64;

		// Token: 0x040000B6 RID: 182
		private static MethodInfo s_Decimal_op_Implicit_UInt64;

		// Token: 0x040000B7 RID: 183
		private static MethodInfo s_Decimal_op_Implicit_Char;

		// Token: 0x040000B8 RID: 184
		private static MethodInfo s_Math_Pow_Double_Double;

		// Token: 0x040000B9 RID: 185
		private static ConstructorInfo s_Closure_ObjectArray_ObjectArray;

		// Token: 0x040000BA RID: 186
		private static FieldInfo s_Closure_Constants;

		// Token: 0x040000BB RID: 187
		private static FieldInfo s_Closure_Locals;

		// Token: 0x040000BC RID: 188
		private static MethodInfo s_RuntimeOps_CreateRuntimeVariables_ObjectArray_Int64Array;

		// Token: 0x040000BD RID: 189
		private static MethodInfo s_RuntimeOps_CreateRuntimeVariables;

		// Token: 0x040000BE RID: 190
		private static MethodInfo s_RuntimeOps_Quote;
	}
}
