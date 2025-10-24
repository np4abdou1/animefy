using System;

namespace System.Reflection
{
	// Token: 0x020004CB RID: 1227
	[Serializable]
	internal enum CorElementType : byte
	{
		// Token: 0x04001090 RID: 4240
		End,
		// Token: 0x04001091 RID: 4241
		Void,
		// Token: 0x04001092 RID: 4242
		Boolean,
		// Token: 0x04001093 RID: 4243
		Char,
		// Token: 0x04001094 RID: 4244
		I1,
		// Token: 0x04001095 RID: 4245
		U1,
		// Token: 0x04001096 RID: 4246
		I2,
		// Token: 0x04001097 RID: 4247
		U2,
		// Token: 0x04001098 RID: 4248
		I4,
		// Token: 0x04001099 RID: 4249
		U4,
		// Token: 0x0400109A RID: 4250
		I8,
		// Token: 0x0400109B RID: 4251
		U8,
		// Token: 0x0400109C RID: 4252
		R4,
		// Token: 0x0400109D RID: 4253
		R8,
		// Token: 0x0400109E RID: 4254
		String,
		// Token: 0x0400109F RID: 4255
		Ptr,
		// Token: 0x040010A0 RID: 4256
		ByRef,
		// Token: 0x040010A1 RID: 4257
		ValueType,
		// Token: 0x040010A2 RID: 4258
		Class,
		// Token: 0x040010A3 RID: 4259
		Var,
		// Token: 0x040010A4 RID: 4260
		Array,
		// Token: 0x040010A5 RID: 4261
		GenericInst,
		// Token: 0x040010A6 RID: 4262
		TypedByRef,
		// Token: 0x040010A7 RID: 4263
		I = 24,
		// Token: 0x040010A8 RID: 4264
		U,
		// Token: 0x040010A9 RID: 4265
		FnPtr = 27,
		// Token: 0x040010AA RID: 4266
		Object,
		// Token: 0x040010AB RID: 4267
		SzArray,
		// Token: 0x040010AC RID: 4268
		MVar,
		// Token: 0x040010AD RID: 4269
		CModReqd,
		// Token: 0x040010AE RID: 4270
		CModOpt,
		// Token: 0x040010AF RID: 4271
		Internal,
		// Token: 0x040010B0 RID: 4272
		Max,
		// Token: 0x040010B1 RID: 4273
		Modifier = 64,
		// Token: 0x040010B2 RID: 4274
		Sentinel,
		// Token: 0x040010B3 RID: 4275
		Pinned = 69,
		// Token: 0x040010B4 RID: 4276
		ELEMENT_TYPE_END = 0,
		// Token: 0x040010B5 RID: 4277
		ELEMENT_TYPE_VOID,
		// Token: 0x040010B6 RID: 4278
		ELEMENT_TYPE_BOOLEAN,
		// Token: 0x040010B7 RID: 4279
		ELEMENT_TYPE_CHAR,
		// Token: 0x040010B8 RID: 4280
		ELEMENT_TYPE_I1,
		// Token: 0x040010B9 RID: 4281
		ELEMENT_TYPE_U1,
		// Token: 0x040010BA RID: 4282
		ELEMENT_TYPE_I2,
		// Token: 0x040010BB RID: 4283
		ELEMENT_TYPE_U2,
		// Token: 0x040010BC RID: 4284
		ELEMENT_TYPE_I4,
		// Token: 0x040010BD RID: 4285
		ELEMENT_TYPE_U4,
		// Token: 0x040010BE RID: 4286
		ELEMENT_TYPE_I8,
		// Token: 0x040010BF RID: 4287
		ELEMENT_TYPE_U8,
		// Token: 0x040010C0 RID: 4288
		ELEMENT_TYPE_R4,
		// Token: 0x040010C1 RID: 4289
		ELEMENT_TYPE_R8,
		// Token: 0x040010C2 RID: 4290
		ELEMENT_TYPE_STRING,
		// Token: 0x040010C3 RID: 4291
		ELEMENT_TYPE_PTR,
		// Token: 0x040010C4 RID: 4292
		ELEMENT_TYPE_BYREF,
		// Token: 0x040010C5 RID: 4293
		ELEMENT_TYPE_VALUETYPE,
		// Token: 0x040010C6 RID: 4294
		ELEMENT_TYPE_CLASS,
		// Token: 0x040010C7 RID: 4295
		ELEMENT_TYPE_VAR,
		// Token: 0x040010C8 RID: 4296
		ELEMENT_TYPE_ARRAY,
		// Token: 0x040010C9 RID: 4297
		ELEMENT_TYPE_GENERICINST,
		// Token: 0x040010CA RID: 4298
		ELEMENT_TYPE_TYPEDBYREF,
		// Token: 0x040010CB RID: 4299
		ELEMENT_TYPE_I = 24,
		// Token: 0x040010CC RID: 4300
		ELEMENT_TYPE_U,
		// Token: 0x040010CD RID: 4301
		ELEMENT_TYPE_FNPTR = 27,
		// Token: 0x040010CE RID: 4302
		ELEMENT_TYPE_OBJECT,
		// Token: 0x040010CF RID: 4303
		ELEMENT_TYPE_SZARRAY,
		// Token: 0x040010D0 RID: 4304
		ELEMENT_TYPE_MVAR,
		// Token: 0x040010D1 RID: 4305
		ELEMENT_TYPE_CMOD_REQD,
		// Token: 0x040010D2 RID: 4306
		ELEMENT_TYPE_CMOD_OPT,
		// Token: 0x040010D3 RID: 4307
		ELEMENT_TYPE_INTERNAL,
		// Token: 0x040010D4 RID: 4308
		ELEMENT_TYPE_MAX,
		// Token: 0x040010D5 RID: 4309
		ELEMENT_TYPE_MODIFIER = 64,
		// Token: 0x040010D6 RID: 4310
		ELEMENT_TYPE_SENTINEL,
		// Token: 0x040010D7 RID: 4311
		ELEMENT_TYPE_PINNED = 69
	}
}
