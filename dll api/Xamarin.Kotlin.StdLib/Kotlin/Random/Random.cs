using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;
using Kotlin.Jvm.Internal;

namespace Kotlin.Random
{
	// Token: 0x0200013F RID: 319
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/random/Random", DoNotGenerateAcw = true)]
	public abstract class Random : Java.Lang.Object
	{
		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x060010C3 RID: 4291 RVA: 0x00038038 File Offset: 0x00036238
		[Register("Default")]
		public static Random.DefaultStatic Default
		{
			get
			{
				return Java.Lang.Object.GetObject<Random.DefaultStatic>(Random._members.StaticFields.GetObjectValue("Default.Lkotlin/random/Random$Default;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x060010C4 RID: 4292 RVA: 0x00038068 File Offset: 0x00036268
		internal static IntPtr class_ref
		{
			get
			{
				return Random._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x0003808C File Offset: 0x0003628C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Random._members;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x060010C6 RID: 4294 RVA: 0x00038094 File Offset: 0x00036294
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Random._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x060010C7 RID: 4295 RVA: 0x000380B8 File Offset: 0x000362B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Random._members.ManagedPeerType;
			}
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x000380C4 File Offset: 0x000362C4
		protected Random(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x000380D0 File Offset: 0x000362D0
		[Register(".ctor", "()V", "")]
		public Random() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Random._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Random._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x0003813E File Offset: 0x0003633E
		private static Delegate GetNextBits_IHandler()
		{
			if (Random.cb_nextBits_I == null)
			{
				Random.cb_nextBits_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_I(Random.n_NextBits_I));
			}
			return Random.cb_nextBits_I;
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x00038162 File Offset: 0x00036362
		private static int n_NextBits_I(IntPtr jnienv, IntPtr native__this, int bitCount)
		{
			return Java.Lang.Object.GetObject<Random>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextBits(bitCount);
		}

		// Token: 0x060010CC RID: 4300
		[Register("nextBits", "(I)I", "GetNextBits_IHandler")]
		public abstract int NextBits(int bitCount);

		// Token: 0x060010CD RID: 4301 RVA: 0x00038172 File Offset: 0x00036372
		private static Delegate GetNextBooleanHandler()
		{
			if (Random.cb_nextBoolean == null)
			{
				Random.cb_nextBoolean = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(Random.n_NextBoolean));
			}
			return Random.cb_nextBoolean;
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x00038196 File Offset: 0x00036396
		private static bool n_NextBoolean(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Random>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextBoolean();
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x000381A5 File Offset: 0x000363A5
		[Register("nextBoolean", "()Z", "GetNextBooleanHandler")]
		public virtual bool NextBoolean()
		{
			return Random._members.InstanceMethods.InvokeVirtualBooleanMethod("nextBoolean.()Z", this, null);
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x000381BE File Offset: 0x000363BE
		private static Delegate GetNextBytes_arrayBHandler()
		{
			if (Random.cb_nextBytes_arrayB == null)
			{
				Random.cb_nextBytes_arrayB = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(Random.n_NextBytes_arrayB));
			}
			return Random.cb_nextBytes_arrayB;
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x000381E4 File Offset: 0x000363E4
		private static IntPtr n_NextBytes_arrayB(IntPtr jnienv, IntPtr native__this, IntPtr native_array)
		{
			Random @object = Java.Lang.Object.GetObject<Random>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] array = (byte[])JNIEnv.GetArray(native_array, JniHandleOwnership.DoNotTransfer, typeof(byte));
			IntPtr result = JNIEnv.NewArray(@object.NextBytes(array));
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_array);
			}
			return result;
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x00038228 File Offset: 0x00036428
		[Register("nextBytes", "([B)[B", "GetNextBytes_arrayBHandler")]
		public unsafe virtual byte[] NextBytes(byte[] array)
		{
			IntPtr intPtr = JNIEnv.NewArray(array);
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = (byte[])JNIEnv.GetArray(Random._members.InstanceMethods.InvokeVirtualObjectMethod("nextBytes.([B)[B", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				if (array != null)
				{
					JNIEnv.CopyArray(intPtr, array);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(array);
			}
			return result;
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x000382B4 File Offset: 0x000364B4
		private static Delegate GetNextBytes_arrayBIIHandler()
		{
			if (Random.cb_nextBytes_arrayBII == null)
			{
				Random.cb_nextBytes_arrayBII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_L(Random.n_NextBytes_arrayBII));
			}
			return Random.cb_nextBytes_arrayBII;
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x000382D8 File Offset: 0x000364D8
		private static IntPtr n_NextBytes_arrayBII(IntPtr jnienv, IntPtr native__this, IntPtr native_array, int fromIndex, int toIndex)
		{
			Random @object = Java.Lang.Object.GetObject<Random>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] array = (byte[])JNIEnv.GetArray(native_array, JniHandleOwnership.DoNotTransfer, typeof(byte));
			IntPtr result = JNIEnv.NewArray(@object.NextBytes(array, fromIndex, toIndex));
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_array);
			}
			return result;
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x0003831C File Offset: 0x0003651C
		[Register("nextBytes", "([BII)[B", "GetNextBytes_arrayBIIHandler")]
		public unsafe virtual byte[] NextBytes(byte[] array, int fromIndex, int toIndex)
		{
			IntPtr intPtr = JNIEnv.NewArray(array);
			byte[] result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(fromIndex);
				ptr[2] = new JniArgumentValue(toIndex);
				result = (byte[])JNIEnv.GetArray(Random._members.InstanceMethods.InvokeVirtualObjectMethod("nextBytes.([BII)[B", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
			}
			finally
			{
				if (array != null)
				{
					JNIEnv.CopyArray(intPtr, array);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(array);
			}
			return result;
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x000383D0 File Offset: 0x000365D0
		private static Delegate GetNextBytes_IHandler()
		{
			if (Random.cb_nextBytes_I == null)
			{
				Random.cb_nextBytes_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(Random.n_NextBytes_I));
			}
			return Random.cb_nextBytes_I;
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x000383F4 File Offset: 0x000365F4
		private static IntPtr n_NextBytes_I(IntPtr jnienv, IntPtr native__this, int size)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<Random>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextBytes(size));
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x0003840C File Offset: 0x0003660C
		[Register("nextBytes", "(I)[B", "GetNextBytes_IHandler")]
		public unsafe virtual byte[] NextBytes(int size)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(size);
			return (byte[])JNIEnv.GetArray(Random._members.InstanceMethods.InvokeVirtualObjectMethod("nextBytes.(I)[B", this, ptr).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x00038464 File Offset: 0x00036664
		private static Delegate GetNextDoubleHandler()
		{
			if (Random.cb_nextDouble == null)
			{
				Random.cb_nextDouble = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_D(Random.n_NextDouble));
			}
			return Random.cb_nextDouble;
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x00038488 File Offset: 0x00036688
		private static double n_NextDouble(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Random>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextDouble();
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x00038497 File Offset: 0x00036697
		[Register("nextDouble", "()D", "GetNextDoubleHandler")]
		public virtual double NextDouble()
		{
			return Random._members.InstanceMethods.InvokeVirtualDoubleMethod("nextDouble.()D", this, null);
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x000384B0 File Offset: 0x000366B0
		private static Delegate GetNextDouble_DHandler()
		{
			if (Random.cb_nextDouble_D == null)
			{
				Random.cb_nextDouble_D = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPD_D(Random.n_NextDouble_D));
			}
			return Random.cb_nextDouble_D;
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x000384D4 File Offset: 0x000366D4
		private static double n_NextDouble_D(IntPtr jnienv, IntPtr native__this, double until)
		{
			return Java.Lang.Object.GetObject<Random>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextDouble(until);
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x000384E4 File Offset: 0x000366E4
		[Register("nextDouble", "(D)D", "GetNextDouble_DHandler")]
		public unsafe virtual double NextDouble(double until)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(until);
			return Random._members.InstanceMethods.InvokeVirtualDoubleMethod("nextDouble.(D)D", this, ptr);
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x0003851F File Offset: 0x0003671F
		private static Delegate GetNextDouble_DDHandler()
		{
			if (Random.cb_nextDouble_DD == null)
			{
				Random.cb_nextDouble_DD = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPDD_D(Random.n_NextDouble_DD));
			}
			return Random.cb_nextDouble_DD;
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x00038543 File Offset: 0x00036743
		private static double n_NextDouble_DD(IntPtr jnienv, IntPtr native__this, double from, double until)
		{
			return Java.Lang.Object.GetObject<Random>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextDouble(from, until);
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x00038554 File Offset: 0x00036754
		[Register("nextDouble", "(DD)D", "GetNextDouble_DDHandler")]
		public unsafe virtual double NextDouble(double from, double until)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(from);
			ptr[1] = new JniArgumentValue(until);
			return Random._members.InstanceMethods.InvokeVirtualDoubleMethod("nextDouble.(DD)D", this, ptr);
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x000385A2 File Offset: 0x000367A2
		private static Delegate GetNextFloatHandler()
		{
			if (Random.cb_nextFloat == null)
			{
				Random.cb_nextFloat = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(Random.n_NextFloat));
			}
			return Random.cb_nextFloat;
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x000385C6 File Offset: 0x000367C6
		private static float n_NextFloat(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Random>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextFloat();
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x000385D5 File Offset: 0x000367D5
		[Register("nextFloat", "()F", "GetNextFloatHandler")]
		public virtual float NextFloat()
		{
			return Random._members.InstanceMethods.InvokeVirtualSingleMethod("nextFloat.()F", this, null);
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x000385EE File Offset: 0x000367EE
		private static Delegate GetNextIntHandler()
		{
			if (Random.cb_nextInt == null)
			{
				Random.cb_nextInt = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Random.n_NextInt));
			}
			return Random.cb_nextInt;
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x00038612 File Offset: 0x00036812
		private static int n_NextInt(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Random>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextInt();
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x00038621 File Offset: 0x00036821
		[Register("nextInt", "()I", "GetNextIntHandler")]
		public virtual int NextInt()
		{
			return Random._members.InstanceMethods.InvokeVirtualInt32Method("nextInt.()I", this, null);
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x0003863A File Offset: 0x0003683A
		private static Delegate GetNextInt_IHandler()
		{
			if (Random.cb_nextInt_I == null)
			{
				Random.cb_nextInt_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_I(Random.n_NextInt_I));
			}
			return Random.cb_nextInt_I;
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x0003865E File Offset: 0x0003685E
		private static int n_NextInt_I(IntPtr jnienv, IntPtr native__this, int until)
		{
			return Java.Lang.Object.GetObject<Random>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextInt(until);
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x00038670 File Offset: 0x00036870
		[Register("nextInt", "(I)I", "GetNextInt_IHandler")]
		public unsafe virtual int NextInt(int until)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(until);
			return Random._members.InstanceMethods.InvokeVirtualInt32Method("nextInt.(I)I", this, ptr);
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x000386AB File Offset: 0x000368AB
		private static Delegate GetNextInt_IIHandler()
		{
			if (Random.cb_nextInt_II == null)
			{
				Random.cb_nextInt_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_I(Random.n_NextInt_II));
			}
			return Random.cb_nextInt_II;
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x000386CF File Offset: 0x000368CF
		private static int n_NextInt_II(IntPtr jnienv, IntPtr native__this, int from, int until)
		{
			return Java.Lang.Object.GetObject<Random>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextInt(from, until);
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x000386E0 File Offset: 0x000368E0
		[Register("nextInt", "(II)I", "GetNextInt_IIHandler")]
		public unsafe virtual int NextInt(int from, int until)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(from);
			ptr[1] = new JniArgumentValue(until);
			return Random._members.InstanceMethods.InvokeVirtualInt32Method("nextInt.(II)I", this, ptr);
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x0003872E File Offset: 0x0003692E
		private static Delegate GetNextLongHandler()
		{
			if (Random.cb_nextLong == null)
			{
				Random.cb_nextLong = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(Random.n_NextLong));
			}
			return Random.cb_nextLong;
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x00038752 File Offset: 0x00036952
		private static long n_NextLong(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Random>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextLong();
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x00038761 File Offset: 0x00036961
		[Register("nextLong", "()J", "GetNextLongHandler")]
		public virtual long NextLong()
		{
			return Random._members.InstanceMethods.InvokeVirtualInt64Method("nextLong.()J", this, null);
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x0003877A File Offset: 0x0003697A
		private static Delegate GetNextLong_JHandler()
		{
			if (Random.cb_nextLong_J == null)
			{
				Random.cb_nextLong_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_J(Random.n_NextLong_J));
			}
			return Random.cb_nextLong_J;
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x0003879E File Offset: 0x0003699E
		private static long n_NextLong_J(IntPtr jnienv, IntPtr native__this, long until)
		{
			return Java.Lang.Object.GetObject<Random>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextLong(until);
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x000387B0 File Offset: 0x000369B0
		[Register("nextLong", "(J)J", "GetNextLong_JHandler")]
		public unsafe virtual long NextLong(long until)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(until);
			return Random._members.InstanceMethods.InvokeVirtualInt64Method("nextLong.(J)J", this, ptr);
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x000387EB File Offset: 0x000369EB
		private static Delegate GetNextLong_JJHandler()
		{
			if (Random.cb_nextLong_JJ == null)
			{
				Random.cb_nextLong_JJ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJJ_J(Random.n_NextLong_JJ));
			}
			return Random.cb_nextLong_JJ;
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x0003880F File Offset: 0x00036A0F
		private static long n_NextLong_JJ(IntPtr jnienv, IntPtr native__this, long from, long until)
		{
			return Java.Lang.Object.GetObject<Random>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NextLong(from, until);
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x00038820 File Offset: 0x00036A20
		[Register("nextLong", "(JJ)J", "GetNextLong_JJHandler")]
		public unsafe virtual long NextLong(long from, long until)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(from);
			ptr[1] = new JniArgumentValue(until);
			return Random._members.InstanceMethods.InvokeVirtualInt64Method("nextLong.(JJ)J", this, ptr);
		}

		// Token: 0x04000573 RID: 1395
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/random/Random", typeof(Random));

		// Token: 0x04000574 RID: 1396
		[Nullable(2)]
		private static Delegate cb_nextBits_I;

		// Token: 0x04000575 RID: 1397
		[Nullable(2)]
		private static Delegate cb_nextBoolean;

		// Token: 0x04000576 RID: 1398
		[Nullable(2)]
		private static Delegate cb_nextBytes_arrayB;

		// Token: 0x04000577 RID: 1399
		[Nullable(2)]
		private static Delegate cb_nextBytes_arrayBII;

		// Token: 0x04000578 RID: 1400
		[Nullable(2)]
		private static Delegate cb_nextBytes_I;

		// Token: 0x04000579 RID: 1401
		[Nullable(2)]
		private static Delegate cb_nextDouble;

		// Token: 0x0400057A RID: 1402
		[Nullable(2)]
		private static Delegate cb_nextDouble_D;

		// Token: 0x0400057B RID: 1403
		[Nullable(2)]
		private static Delegate cb_nextDouble_DD;

		// Token: 0x0400057C RID: 1404
		[Nullable(2)]
		private static Delegate cb_nextFloat;

		// Token: 0x0400057D RID: 1405
		[Nullable(2)]
		private static Delegate cb_nextInt;

		// Token: 0x0400057E RID: 1406
		[Nullable(2)]
		private static Delegate cb_nextInt_I;

		// Token: 0x0400057F RID: 1407
		[Nullable(2)]
		private static Delegate cb_nextInt_II;

		// Token: 0x04000580 RID: 1408
		[Nullable(2)]
		private static Delegate cb_nextLong;

		// Token: 0x04000581 RID: 1409
		[Nullable(2)]
		private static Delegate cb_nextLong_J;

		// Token: 0x04000582 RID: 1410
		[Nullable(2)]
		private static Delegate cb_nextLong_JJ;

		// Token: 0x020002E9 RID: 745
		[NullableContext(0)]
		[Register("kotlin/random/Random$Default", DoNotGenerateAcw = true)]
		public sealed class DefaultStatic : Random, ISerializable, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000A3C RID: 2620
			// (get) Token: 0x060029B6 RID: 10678 RVA: 0x000B8CFC File Offset: 0x000B6EFC
			internal new static IntPtr class_ref
			{
				get
				{
					return Random.DefaultStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A3D RID: 2621
			// (get) Token: 0x060029B7 RID: 10679 RVA: 0x000B8D20 File Offset: 0x000B6F20
			[Nullable(1)]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				[NullableContext(1)]
				get
				{
					return Random.DefaultStatic._members;
				}
			}

			// Token: 0x17000A3E RID: 2622
			// (get) Token: 0x060029B8 RID: 10680 RVA: 0x000B8D28 File Offset: 0x000B6F28
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Random.DefaultStatic._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A3F RID: 2623
			// (get) Token: 0x060029B9 RID: 10681 RVA: 0x000B8D4C File Offset: 0x000B6F4C
			[Nullable(1)]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				[NullableContext(1)]
				get
				{
					return Random.DefaultStatic._members.ManagedPeerType;
				}
			}

			// Token: 0x060029BA RID: 10682 RVA: 0x000B8D58 File Offset: 0x000B6F58
			internal DefaultStatic(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060029BB RID: 10683 RVA: 0x000B8D64 File Offset: 0x000B6F64
			[NullableContext(2)]
			[Register(".ctor", "(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", "")]
			public unsafe DefaultStatic(DefaultConstructorMarker _constructor_marker) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((_constructor_marker == null) ? IntPtr.Zero : _constructor_marker.Handle);
					base.SetHandle(Random.DefaultStatic._members.InstanceMethods.StartCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					Random.DefaultStatic._members.InstanceMethods.FinishCreateInstance("(Lkotlin/jvm/internal/DefaultConstructorMarker;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(_constructor_marker);
				}
			}

			// Token: 0x060029BC RID: 10684 RVA: 0x000B8E14 File Offset: 0x000B7014
			[Register("nextBits", "(I)I", "")]
			public unsafe override int NextBits(int bitCount)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(bitCount);
				return Random.DefaultStatic._members.InstanceMethods.InvokeAbstractInt32Method("nextBits.(I)I", this, ptr);
			}

			// Token: 0x040009E0 RID: 2528
			[Nullable(1)]
			private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/random/Random$Default", typeof(Random.DefaultStatic));
		}
	}
}
