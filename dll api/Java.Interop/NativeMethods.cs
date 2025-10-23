using System;
using System.Runtime.InteropServices;

namespace Java.Interop
{
	// Token: 0x02000091 RID: 145
	internal static class NativeMethods
	{
		// Token: 0x060004A9 RID: 1193
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_find_class(IntPtr jnienv, out IntPtr thrown, string classname);

		// Token: 0x060004AA RID: 1194
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_get_superclass(IntPtr jnienv, IntPtr type);

		// Token: 0x060004AB RID: 1195
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern byte java_interop_jnienv_is_assignable_from(IntPtr jnienv, IntPtr class1, IntPtr class2);

		// Token: 0x060004AC RID: 1196
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern int java_interop_jnienv_throw(IntPtr jnienv, IntPtr toThrow);

		// Token: 0x060004AD RID: 1197
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern int java_interop_jnienv_throw_new(IntPtr jnienv, IntPtr type, string message);

		// Token: 0x060004AE RID: 1198
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_exception_occurred(IntPtr jnienv);

		// Token: 0x060004AF RID: 1199
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_exception_describe(IntPtr jnienv);

		// Token: 0x060004B0 RID: 1200
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_exception_clear(IntPtr jnienv);

		// Token: 0x060004B1 RID: 1201
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern int java_interop_jnienv_push_local_frame(IntPtr jnienv, int capacity);

		// Token: 0x060004B2 RID: 1202
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_pop_local_frame(IntPtr jnienv, IntPtr result);

		// Token: 0x060004B3 RID: 1203
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_new_global_ref(IntPtr jnienv, IntPtr instance);

		// Token: 0x060004B4 RID: 1204
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_delete_global_ref(IntPtr jnienv, IntPtr instance);

		// Token: 0x060004B5 RID: 1205
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_delete_local_ref(IntPtr jnienv, IntPtr instance);

		// Token: 0x060004B6 RID: 1206
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern byte java_interop_jnienv_is_same_object(IntPtr jnienv, IntPtr object1, IntPtr object2);

		// Token: 0x060004B7 RID: 1207
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_new_local_ref(IntPtr jnienv, IntPtr instance);

		// Token: 0x060004B8 RID: 1208
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern int java_interop_jnienv_ensure_local_capacity(IntPtr jnienv, int capacity);

		// Token: 0x060004B9 RID: 1209
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_alloc_object(IntPtr jnienv, out IntPtr thrown, IntPtr type);

		// Token: 0x060004BA RID: 1210
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_new_object(IntPtr jnienv, out IntPtr thrown, IntPtr type, IntPtr method);

		// Token: 0x060004BB RID: 1211
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_new_object_a(IntPtr jnienv, out IntPtr thrown, IntPtr type, IntPtr method, IntPtr args);

		// Token: 0x060004BC RID: 1212
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_get_object_class(IntPtr jnienv, IntPtr instance);

		// Token: 0x060004BD RID: 1213
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern byte java_interop_jnienv_is_instance_of(IntPtr jnienv, IntPtr instance, IntPtr type);

		// Token: 0x060004BE RID: 1214
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_get_method_id(IntPtr jnienv, out IntPtr thrown, IntPtr type, string name, string signature);

		// Token: 0x060004BF RID: 1215
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_call_object_method(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr method);

		// Token: 0x060004C0 RID: 1216
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_call_object_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr method, IntPtr args);

		// Token: 0x060004C1 RID: 1217
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern byte java_interop_jnienv_call_boolean_method(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr method);

		// Token: 0x060004C2 RID: 1218
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern byte java_interop_jnienv_call_boolean_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr method, IntPtr args);

		// Token: 0x060004C3 RID: 1219
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern sbyte java_interop_jnienv_call_byte_method(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr method);

		// Token: 0x060004C4 RID: 1220
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern sbyte java_interop_jnienv_call_byte_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr method, IntPtr args);

		// Token: 0x060004C5 RID: 1221
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern char java_interop_jnienv_call_char_method(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr method);

		// Token: 0x060004C6 RID: 1222
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern char java_interop_jnienv_call_char_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr method, IntPtr args);

		// Token: 0x060004C7 RID: 1223
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern short java_interop_jnienv_call_short_method(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr method);

		// Token: 0x060004C8 RID: 1224
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern short java_interop_jnienv_call_short_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr method, IntPtr args);

		// Token: 0x060004C9 RID: 1225
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern int java_interop_jnienv_call_int_method(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr method);

		// Token: 0x060004CA RID: 1226
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern int java_interop_jnienv_call_int_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr method, IntPtr args);

		// Token: 0x060004CB RID: 1227
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern long java_interop_jnienv_call_long_method(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr method);

		// Token: 0x060004CC RID: 1228
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern long java_interop_jnienv_call_long_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr method, IntPtr args);

		// Token: 0x060004CD RID: 1229
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern float java_interop_jnienv_call_float_method(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr method);

		// Token: 0x060004CE RID: 1230
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern float java_interop_jnienv_call_float_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr method, IntPtr args);

		// Token: 0x060004CF RID: 1231
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern double java_interop_jnienv_call_double_method(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr method);

		// Token: 0x060004D0 RID: 1232
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern double java_interop_jnienv_call_double_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr method, IntPtr args);

		// Token: 0x060004D1 RID: 1233
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_call_void_method(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr method);

		// Token: 0x060004D2 RID: 1234
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_call_void_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr method, IntPtr args);

		// Token: 0x060004D3 RID: 1235
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_call_nonvirtual_object_method(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr type, IntPtr method);

		// Token: 0x060004D4 RID: 1236
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_call_nonvirtual_object_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr type, IntPtr method, IntPtr args);

		// Token: 0x060004D5 RID: 1237
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern byte java_interop_jnienv_call_nonvirtual_boolean_method(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr type, IntPtr method);

		// Token: 0x060004D6 RID: 1238
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern byte java_interop_jnienv_call_nonvirtual_boolean_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr type, IntPtr method, IntPtr args);

		// Token: 0x060004D7 RID: 1239
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern sbyte java_interop_jnienv_call_nonvirtual_byte_method(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr type, IntPtr method);

		// Token: 0x060004D8 RID: 1240
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern sbyte java_interop_jnienv_call_nonvirtual_byte_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr type, IntPtr method, IntPtr args);

		// Token: 0x060004D9 RID: 1241
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern char java_interop_jnienv_call_nonvirtual_char_method(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr type, IntPtr method);

		// Token: 0x060004DA RID: 1242
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern char java_interop_jnienv_call_nonvirtual_char_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr type, IntPtr method, IntPtr args);

		// Token: 0x060004DB RID: 1243
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern short java_interop_jnienv_call_nonvirtual_short_method(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr type, IntPtr method);

		// Token: 0x060004DC RID: 1244
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern short java_interop_jnienv_call_nonvirtual_short_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr type, IntPtr method, IntPtr args);

		// Token: 0x060004DD RID: 1245
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern int java_interop_jnienv_call_nonvirtual_int_method(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr type, IntPtr method);

		// Token: 0x060004DE RID: 1246
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern int java_interop_jnienv_call_nonvirtual_int_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr type, IntPtr method, IntPtr args);

		// Token: 0x060004DF RID: 1247
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern long java_interop_jnienv_call_nonvirtual_long_method(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr type, IntPtr method);

		// Token: 0x060004E0 RID: 1248
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern long java_interop_jnienv_call_nonvirtual_long_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr type, IntPtr method, IntPtr args);

		// Token: 0x060004E1 RID: 1249
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern float java_interop_jnienv_call_nonvirtual_float_method(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr type, IntPtr method);

		// Token: 0x060004E2 RID: 1250
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern float java_interop_jnienv_call_nonvirtual_float_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr type, IntPtr method, IntPtr args);

		// Token: 0x060004E3 RID: 1251
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern double java_interop_jnienv_call_nonvirtual_double_method(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr type, IntPtr method);

		// Token: 0x060004E4 RID: 1252
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern double java_interop_jnienv_call_nonvirtual_double_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr type, IntPtr method, IntPtr args);

		// Token: 0x060004E5 RID: 1253
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_call_nonvirtual_void_method(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr type, IntPtr method);

		// Token: 0x060004E6 RID: 1254
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_call_nonvirtual_void_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr instance, IntPtr type, IntPtr method, IntPtr args);

		// Token: 0x060004E7 RID: 1255
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_get_field_id(IntPtr jnienv, out IntPtr thrown, IntPtr type, string name, string signature);

		// Token: 0x060004E8 RID: 1256
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_get_object_field(IntPtr jnienv, IntPtr instance, IntPtr field);

		// Token: 0x060004E9 RID: 1257
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern byte java_interop_jnienv_get_boolean_field(IntPtr jnienv, IntPtr instance, IntPtr field);

		// Token: 0x060004EA RID: 1258
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern sbyte java_interop_jnienv_get_byte_field(IntPtr jnienv, IntPtr instance, IntPtr field);

		// Token: 0x060004EB RID: 1259
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern char java_interop_jnienv_get_char_field(IntPtr jnienv, IntPtr instance, IntPtr field);

		// Token: 0x060004EC RID: 1260
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern short java_interop_jnienv_get_short_field(IntPtr jnienv, IntPtr instance, IntPtr field);

		// Token: 0x060004ED RID: 1261
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern int java_interop_jnienv_get_int_field(IntPtr jnienv, IntPtr instance, IntPtr field);

		// Token: 0x060004EE RID: 1262
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern long java_interop_jnienv_get_long_field(IntPtr jnienv, IntPtr instance, IntPtr field);

		// Token: 0x060004EF RID: 1263
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern float java_interop_jnienv_get_float_field(IntPtr jnienv, IntPtr instance, IntPtr field);

		// Token: 0x060004F0 RID: 1264
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern double java_interop_jnienv_get_double_field(IntPtr jnienv, IntPtr instance, IntPtr field);

		// Token: 0x060004F1 RID: 1265
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_set_object_field(IntPtr jnienv, IntPtr instance, IntPtr field, IntPtr value);

		// Token: 0x060004F2 RID: 1266
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_set_boolean_field(IntPtr jnienv, IntPtr instance, IntPtr field, byte value);

		// Token: 0x060004F3 RID: 1267
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_set_byte_field(IntPtr jnienv, IntPtr instance, IntPtr field, sbyte value);

		// Token: 0x060004F4 RID: 1268
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_set_char_field(IntPtr jnienv, IntPtr instance, IntPtr field, char value);

		// Token: 0x060004F5 RID: 1269
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_set_short_field(IntPtr jnienv, IntPtr instance, IntPtr field, short value);

		// Token: 0x060004F6 RID: 1270
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_set_int_field(IntPtr jnienv, IntPtr instance, IntPtr field, int value);

		// Token: 0x060004F7 RID: 1271
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_set_long_field(IntPtr jnienv, IntPtr instance, IntPtr field, long value);

		// Token: 0x060004F8 RID: 1272
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_set_float_field(IntPtr jnienv, IntPtr instance, IntPtr field, float value);

		// Token: 0x060004F9 RID: 1273
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_set_double_field(IntPtr jnienv, IntPtr instance, IntPtr field, double value);

		// Token: 0x060004FA RID: 1274
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_get_static_method_id(IntPtr jnienv, out IntPtr thrown, IntPtr type, string name, string signature);

		// Token: 0x060004FB RID: 1275
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_call_static_object_method(IntPtr jnienv, out IntPtr thrown, IntPtr type, IntPtr method);

		// Token: 0x060004FC RID: 1276
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_call_static_object_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr type, IntPtr method, IntPtr args);

		// Token: 0x060004FD RID: 1277
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern byte java_interop_jnienv_call_static_boolean_method(IntPtr jnienv, out IntPtr thrown, IntPtr type, IntPtr method);

		// Token: 0x060004FE RID: 1278
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern byte java_interop_jnienv_call_static_boolean_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr type, IntPtr method, IntPtr args);

		// Token: 0x060004FF RID: 1279
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern sbyte java_interop_jnienv_call_static_byte_method(IntPtr jnienv, out IntPtr thrown, IntPtr type, IntPtr method);

		// Token: 0x06000500 RID: 1280
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern sbyte java_interop_jnienv_call_static_byte_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr type, IntPtr method, IntPtr args);

		// Token: 0x06000501 RID: 1281
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern char java_interop_jnienv_call_static_char_method(IntPtr jnienv, out IntPtr thrown, IntPtr type, IntPtr method);

		// Token: 0x06000502 RID: 1282
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern char java_interop_jnienv_call_static_char_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr type, IntPtr method, IntPtr args);

		// Token: 0x06000503 RID: 1283
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern short java_interop_jnienv_call_static_short_method(IntPtr jnienv, out IntPtr thrown, IntPtr type, IntPtr method);

		// Token: 0x06000504 RID: 1284
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern short java_interop_jnienv_call_static_short_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr type, IntPtr method, IntPtr args);

		// Token: 0x06000505 RID: 1285
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern int java_interop_jnienv_call_static_int_method(IntPtr jnienv, out IntPtr thrown, IntPtr type, IntPtr method);

		// Token: 0x06000506 RID: 1286
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern int java_interop_jnienv_call_static_int_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr type, IntPtr method, IntPtr args);

		// Token: 0x06000507 RID: 1287
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern long java_interop_jnienv_call_static_long_method(IntPtr jnienv, out IntPtr thrown, IntPtr type, IntPtr method);

		// Token: 0x06000508 RID: 1288
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern long java_interop_jnienv_call_static_long_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr type, IntPtr method, IntPtr args);

		// Token: 0x06000509 RID: 1289
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern float java_interop_jnienv_call_static_float_method(IntPtr jnienv, out IntPtr thrown, IntPtr type, IntPtr method);

		// Token: 0x0600050A RID: 1290
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern float java_interop_jnienv_call_static_float_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr type, IntPtr method, IntPtr args);

		// Token: 0x0600050B RID: 1291
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern double java_interop_jnienv_call_static_double_method(IntPtr jnienv, out IntPtr thrown, IntPtr type, IntPtr method);

		// Token: 0x0600050C RID: 1292
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern double java_interop_jnienv_call_static_double_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr type, IntPtr method, IntPtr args);

		// Token: 0x0600050D RID: 1293
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_call_static_void_method(IntPtr jnienv, out IntPtr thrown, IntPtr type, IntPtr method);

		// Token: 0x0600050E RID: 1294
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_call_static_void_method_a(IntPtr jnienv, out IntPtr thrown, IntPtr type, IntPtr method, IntPtr args);

		// Token: 0x0600050F RID: 1295
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_get_static_field_id(IntPtr jnienv, out IntPtr thrown, IntPtr type, string name, string signature);

		// Token: 0x06000510 RID: 1296
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_get_static_object_field(IntPtr jnienv, IntPtr type, IntPtr field);

		// Token: 0x06000511 RID: 1297
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern byte java_interop_jnienv_get_static_boolean_field(IntPtr jnienv, IntPtr type, IntPtr field);

		// Token: 0x06000512 RID: 1298
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern sbyte java_interop_jnienv_get_static_byte_field(IntPtr jnienv, IntPtr type, IntPtr field);

		// Token: 0x06000513 RID: 1299
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern char java_interop_jnienv_get_static_char_field(IntPtr jnienv, IntPtr type, IntPtr field);

		// Token: 0x06000514 RID: 1300
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern short java_interop_jnienv_get_static_short_field(IntPtr jnienv, IntPtr type, IntPtr field);

		// Token: 0x06000515 RID: 1301
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern int java_interop_jnienv_get_static_int_field(IntPtr jnienv, IntPtr type, IntPtr field);

		// Token: 0x06000516 RID: 1302
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern long java_interop_jnienv_get_static_long_field(IntPtr jnienv, IntPtr type, IntPtr field);

		// Token: 0x06000517 RID: 1303
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern float java_interop_jnienv_get_static_float_field(IntPtr jnienv, IntPtr type, IntPtr field);

		// Token: 0x06000518 RID: 1304
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern double java_interop_jnienv_get_static_double_field(IntPtr jnienv, IntPtr type, IntPtr field);

		// Token: 0x06000519 RID: 1305
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_set_static_object_field(IntPtr jnienv, IntPtr type, IntPtr field, IntPtr value);

		// Token: 0x0600051A RID: 1306
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_set_static_boolean_field(IntPtr jnienv, IntPtr type, IntPtr field, byte value);

		// Token: 0x0600051B RID: 1307
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_set_static_byte_field(IntPtr jnienv, IntPtr type, IntPtr field, sbyte value);

		// Token: 0x0600051C RID: 1308
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_set_static_char_field(IntPtr jnienv, IntPtr type, IntPtr field, char value);

		// Token: 0x0600051D RID: 1309
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_set_static_short_field(IntPtr jnienv, IntPtr type, IntPtr field, short value);

		// Token: 0x0600051E RID: 1310
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_set_static_int_field(IntPtr jnienv, IntPtr type, IntPtr field, int value);

		// Token: 0x0600051F RID: 1311
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_set_static_long_field(IntPtr jnienv, IntPtr type, IntPtr field, long value);

		// Token: 0x06000520 RID: 1312
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_set_static_float_field(IntPtr jnienv, IntPtr type, IntPtr field, float value);

		// Token: 0x06000521 RID: 1313
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_set_static_double_field(IntPtr jnienv, IntPtr type, IntPtr field, double value);

		// Token: 0x06000522 RID: 1314
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern IntPtr java_interop_jnienv_new_string(IntPtr jnienv, out IntPtr thrown, char* unicodeChars, int length);

		// Token: 0x06000523 RID: 1315
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern int java_interop_jnienv_get_string_length(IntPtr jnienv, IntPtr stringInstance);

		// Token: 0x06000524 RID: 1316
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern char* java_interop_jnienv_get_string_chars(IntPtr jnienv, IntPtr stringInstance, bool* isCopy);

		// Token: 0x06000525 RID: 1317
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern void java_interop_jnienv_release_string_chars(IntPtr jnienv, IntPtr stringInstance, char* chars);

		// Token: 0x06000526 RID: 1318
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern int java_interop_jnienv_get_array_length(IntPtr jnienv, IntPtr array);

		// Token: 0x06000527 RID: 1319
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_new_object_array(IntPtr jnienv, out IntPtr thrown, int length, IntPtr elementClass, IntPtr initialElement);

		// Token: 0x06000528 RID: 1320
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_get_object_array_element(IntPtr jnienv, out IntPtr thrown, IntPtr array, int index);

		// Token: 0x06000529 RID: 1321
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_set_object_array_element(IntPtr jnienv, out IntPtr thrown, IntPtr array, int index, IntPtr value);

		// Token: 0x0600052A RID: 1322
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_new_boolean_array(IntPtr jnienv, int length);

		// Token: 0x0600052B RID: 1323
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_new_byte_array(IntPtr jnienv, int length);

		// Token: 0x0600052C RID: 1324
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_new_char_array(IntPtr jnienv, int length);

		// Token: 0x0600052D RID: 1325
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_new_short_array(IntPtr jnienv, int length);

		// Token: 0x0600052E RID: 1326
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_new_int_array(IntPtr jnienv, int length);

		// Token: 0x0600052F RID: 1327
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_new_long_array(IntPtr jnienv, int length);

		// Token: 0x06000530 RID: 1328
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_new_float_array(IntPtr jnienv, int length);

		// Token: 0x06000531 RID: 1329
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_new_double_array(IntPtr jnienv, int length);

		// Token: 0x06000532 RID: 1330
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern bool* java_interop_jnienv_get_boolean_array_elements(IntPtr jnienv, IntPtr array, bool* isCopy);

		// Token: 0x06000533 RID: 1331
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern sbyte* java_interop_jnienv_get_byte_array_elements(IntPtr jnienv, IntPtr array, bool* isCopy);

		// Token: 0x06000534 RID: 1332
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern char* java_interop_jnienv_get_char_array_elements(IntPtr jnienv, IntPtr array, bool* isCopy);

		// Token: 0x06000535 RID: 1333
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern short* java_interop_jnienv_get_short_array_elements(IntPtr jnienv, IntPtr array, bool* isCopy);

		// Token: 0x06000536 RID: 1334
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern int* java_interop_jnienv_get_int_array_elements(IntPtr jnienv, IntPtr array, bool* isCopy);

		// Token: 0x06000537 RID: 1335
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern long* java_interop_jnienv_get_long_array_elements(IntPtr jnienv, IntPtr array, bool* isCopy);

		// Token: 0x06000538 RID: 1336
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern float* java_interop_jnienv_get_float_array_elements(IntPtr jnienv, IntPtr array, bool* isCopy);

		// Token: 0x06000539 RID: 1337
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern double* java_interop_jnienv_get_double_array_elements(IntPtr jnienv, IntPtr array, bool* isCopy);

		// Token: 0x0600053A RID: 1338
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern void java_interop_jnienv_release_boolean_array_elements(IntPtr jnienv, IntPtr array, bool* elements, int mode);

		// Token: 0x0600053B RID: 1339
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern void java_interop_jnienv_release_byte_array_elements(IntPtr jnienv, IntPtr array, sbyte* elements, int mode);

		// Token: 0x0600053C RID: 1340
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern void java_interop_jnienv_release_char_array_elements(IntPtr jnienv, IntPtr array, char* elements, int mode);

		// Token: 0x0600053D RID: 1341
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern void java_interop_jnienv_release_short_array_elements(IntPtr jnienv, IntPtr array, short* elements, int mode);

		// Token: 0x0600053E RID: 1342
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern void java_interop_jnienv_release_int_array_elements(IntPtr jnienv, IntPtr array, int* elements, int mode);

		// Token: 0x0600053F RID: 1343
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern void java_interop_jnienv_release_long_array_elements(IntPtr jnienv, IntPtr array, long* elements, int mode);

		// Token: 0x06000540 RID: 1344
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern void java_interop_jnienv_release_float_array_elements(IntPtr jnienv, IntPtr array, float* elements, int mode);

		// Token: 0x06000541 RID: 1345
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern void java_interop_jnienv_release_double_array_elements(IntPtr jnienv, IntPtr array, double* elements, int mode);

		// Token: 0x06000542 RID: 1346
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern void java_interop_jnienv_get_boolean_array_region(IntPtr jnienv, out IntPtr thrown, IntPtr array, int start, int length, bool* buffer);

		// Token: 0x06000543 RID: 1347
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern void java_interop_jnienv_get_byte_array_region(IntPtr jnienv, out IntPtr thrown, IntPtr array, int start, int length, sbyte* buffer);

		// Token: 0x06000544 RID: 1348
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern void java_interop_jnienv_get_char_array_region(IntPtr jnienv, out IntPtr thrown, IntPtr array, int start, int length, char* buffer);

		// Token: 0x06000545 RID: 1349
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern void java_interop_jnienv_get_short_array_region(IntPtr jnienv, out IntPtr thrown, IntPtr array, int start, int length, short* buffer);

		// Token: 0x06000546 RID: 1350
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern void java_interop_jnienv_get_int_array_region(IntPtr jnienv, out IntPtr thrown, IntPtr array, int start, int length, int* buffer);

		// Token: 0x06000547 RID: 1351
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern void java_interop_jnienv_get_long_array_region(IntPtr jnienv, out IntPtr thrown, IntPtr array, int start, int length, long* buffer);

		// Token: 0x06000548 RID: 1352
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern void java_interop_jnienv_get_float_array_region(IntPtr jnienv, out IntPtr thrown, IntPtr array, int start, int length, float* buffer);

		// Token: 0x06000549 RID: 1353
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern void java_interop_jnienv_get_double_array_region(IntPtr jnienv, out IntPtr thrown, IntPtr array, int start, int length, double* buffer);

		// Token: 0x0600054A RID: 1354
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern void java_interop_jnienv_set_boolean_array_region(IntPtr jnienv, out IntPtr thrown, IntPtr array, int start, int length, bool* buffer);

		// Token: 0x0600054B RID: 1355
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern void java_interop_jnienv_set_byte_array_region(IntPtr jnienv, out IntPtr thrown, IntPtr array, int start, int length, sbyte* buffer);

		// Token: 0x0600054C RID: 1356
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern void java_interop_jnienv_set_char_array_region(IntPtr jnienv, out IntPtr thrown, IntPtr array, int start, int length, char* buffer);

		// Token: 0x0600054D RID: 1357
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern void java_interop_jnienv_set_short_array_region(IntPtr jnienv, out IntPtr thrown, IntPtr array, int start, int length, short* buffer);

		// Token: 0x0600054E RID: 1358
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern void java_interop_jnienv_set_int_array_region(IntPtr jnienv, out IntPtr thrown, IntPtr array, int start, int length, int* buffer);

		// Token: 0x0600054F RID: 1359
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern void java_interop_jnienv_set_long_array_region(IntPtr jnienv, out IntPtr thrown, IntPtr array, int start, int length, long* buffer);

		// Token: 0x06000550 RID: 1360
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern void java_interop_jnienv_set_float_array_region(IntPtr jnienv, out IntPtr thrown, IntPtr array, int start, int length, float* buffer);

		// Token: 0x06000551 RID: 1361
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal unsafe static extern void java_interop_jnienv_set_double_array_region(IntPtr jnienv, out IntPtr thrown, IntPtr array, int start, int length, double* buffer);

		// Token: 0x06000552 RID: 1362
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern int java_interop_jnienv_register_natives(IntPtr jnienv, out IntPtr thrown, IntPtr type, JniNativeMethodRegistration[] methods, int numMethods);

		// Token: 0x06000553 RID: 1363
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern int java_interop_jnienv_unregister_natives(IntPtr jnienv, IntPtr type);

		// Token: 0x06000554 RID: 1364
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern int java_interop_jnienv_get_java_vm(IntPtr jnienv, out IntPtr vm);

		// Token: 0x06000555 RID: 1365
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern void java_interop_jnienv_delete_weak_global_ref(IntPtr jnienv, IntPtr instance);

		// Token: 0x06000556 RID: 1366
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_new_direct_byte_buffer(IntPtr jnienv, out IntPtr thrown, IntPtr address, long capacity);

		// Token: 0x06000557 RID: 1367
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern IntPtr java_interop_jnienv_get_direct_buffer_address(IntPtr jnienv, IntPtr buffer);

		// Token: 0x06000558 RID: 1368
		[DllImport("java-interop", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		internal static extern long java_interop_jnienv_get_direct_buffer_capacity(IntPtr jnienv, IntPtr buffer);
	}
}
