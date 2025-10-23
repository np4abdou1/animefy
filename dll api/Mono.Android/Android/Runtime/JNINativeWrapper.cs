using System;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Android.Runtime
{
	// Token: 0x020002E8 RID: 744
	public static class JNINativeWrapper
	{
		// Token: 0x06001D7F RID: 7551 RVA: 0x000500C8 File Offset: 0x0004E2C8
		private static void get_runtime_types()
		{
			if (JNINativeWrapper.exception_handler_method != null)
			{
				return;
			}
			JNINativeWrapper.exception_handler_method = typeof(AndroidEnvironment).GetMethod("UnhandledException", BindingFlags.Static | BindingFlags.NonPublic);
			if (JNINativeWrapper.exception_handler_method == null)
			{
				AndroidEnvironment.FailFast("Cannot find AndroidEnvironment.UnhandledException");
			}
			JNINativeWrapper.wait_for_bridge_processing_method = typeof(AndroidRuntimeInternal).GetMethod("WaitForBridgeProcessing", BindingFlags.Static | BindingFlags.Public);
			if (JNINativeWrapper.wait_for_bridge_processing_method == null)
			{
				AndroidEnvironment.FailFast("Cannot find AndroidRuntimeInternal.WaitForBridgeProcessing");
			}
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x00050148 File Offset: 0x0004E348
		public static Delegate CreateDelegate(Delegate dlg)
		{
			if (dlg == null)
			{
				throw new ArgumentNullException();
			}
			if (dlg.Target != null)
			{
				throw new ArgumentException();
			}
			if (dlg.Method == null)
			{
				throw new ArgumentException();
			}
			JNINativeWrapper.get_runtime_types();
			Type type = dlg.GetType();
			Delegate @delegate = JNINativeWrapper.CreateBuiltInDelegate(dlg, type);
			if (@delegate != null)
			{
				return @delegate;
			}
			if (JNIEnvInit.LogAssemblyCategory)
			{
				RuntimeNativeMethods.monodroid_log(LogLevel.Debug, LogCategories.Assembly, string.Format("Falling back to System.Reflection.Emit for delegate type '{0}': {1}", type, dlg.Method));
			}
			Type returnType = dlg.Method.ReturnType;
			ParameterInfo[] parameters = dlg.Method.GetParameters();
			Type[] array = new Type[parameters.Length];
			for (int i = 0; i < parameters.Length; i++)
			{
				array[i] = parameters[i].ParameterType;
			}
			DynamicMethod dynamicMethod = new DynamicMethod(DynamicMethodNameCounter.GetUniqueName(), returnType, array, typeof(DynamicMethodNameCounter), true);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			LocalBuilder localBuilder = null;
			if (returnType != typeof(void))
			{
				localBuilder = ilgenerator.DeclareLocal(returnType);
			}
			ilgenerator.Emit(OpCodes.Call, JNINativeWrapper.wait_for_bridge_processing_method);
			Label label = ilgenerator.BeginExceptionBlock();
			for (int j = 0; j < array.Length; j++)
			{
				ilgenerator.Emit(OpCodes.Ldarg, j);
			}
			ilgenerator.Emit(OpCodes.Call, dlg.Method);
			if (localBuilder != null)
			{
				ilgenerator.Emit(OpCodes.Stloc, localBuilder);
			}
			ilgenerator.Emit(OpCodes.Leave, label);
			bool flag = Debugger.IsAttached || !JNIEnvInit.PropagateExceptions;
			if (flag && AndroidRuntimeInternal.mono_unhandled_exception_method != null)
			{
				ilgenerator.BeginExceptFilterBlock();
				ilgenerator.Emit(OpCodes.Call, AndroidRuntimeInternal.mono_unhandled_exception_method);
				ilgenerator.Emit(OpCodes.Ldc_I4_1);
				ilgenerator.BeginCatchBlock(null);
			}
			else
			{
				ilgenerator.BeginCatchBlock(typeof(Exception));
			}
			ilgenerator.Emit(OpCodes.Dup);
			ilgenerator.Emit(OpCodes.Call, JNINativeWrapper.exception_handler_method);
			if (flag)
			{
				ilgenerator.Emit(OpCodes.Throw);
			}
			ilgenerator.EndExceptionBlock();
			if (localBuilder != null)
			{
				ilgenerator.Emit(OpCodes.Ldloc, localBuilder);
			}
			ilgenerator.Emit(OpCodes.Ret);
			return dynamicMethod.CreateDelegate(dlg.GetType());
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x00050367 File Offset: 0x0004E567
		private static bool _unhandled_exception(Exception e)
		{
			if (Debugger.IsAttached || !JNIEnvInit.PropagateExceptions)
			{
				Action<Exception> mono_unhandled_exception = AndroidRuntimeInternal.mono_unhandled_exception;
				if (mono_unhandled_exception != null)
				{
					mono_unhandled_exception(e);
				}
				return false;
			}
			return true;
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x0005038C File Offset: 0x0004E58C
		internal static void Wrap_JniMarshal_PP_V(this _JniMarshal_PP_V callback, IntPtr jnienv, IntPtr klazz)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			try
			{
				callback(jnienv, klazz);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
			}
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x000503DC File Offset: 0x0004E5DC
		internal static int Wrap_JniMarshal_PP_I(this _JniMarshal_PP_I callback, IntPtr jnienv, IntPtr klazz)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			int result;
			try
			{
				result = callback(jnienv, klazz);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
				result = 0;
			}
			return result;
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x00050430 File Offset: 0x0004E630
		internal static bool Wrap_JniMarshal_PP_Z(this _JniMarshal_PP_Z callback, IntPtr jnienv, IntPtr klazz)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			bool result;
			try
			{
				result = callback(jnienv, klazz);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
				result = false;
			}
			return result;
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x00050484 File Offset: 0x0004E684
		internal static void Wrap_JniMarshal_PPI_V(this _JniMarshal_PPI_V callback, IntPtr jnienv, IntPtr klazz, int p0)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			try
			{
				callback(jnienv, klazz, p0);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
			}
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x000504D4 File Offset: 0x0004E6D4
		internal static IntPtr Wrap_JniMarshal_PPI_L(this _JniMarshal_PPI_L callback, IntPtr jnienv, IntPtr klazz, int p0)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			IntPtr result;
			try
			{
				result = callback(jnienv, klazz, p0);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
				result = (IntPtr)0;
			}
			return result;
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x00050528 File Offset: 0x0004E728
		internal static int Wrap_JniMarshal_PPI_I(this _JniMarshal_PPI_I callback, IntPtr jnienv, IntPtr klazz, int p0)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			int result;
			try
			{
				result = callback(jnienv, klazz, p0);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
				result = 0;
			}
			return result;
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x0005057C File Offset: 0x0004E77C
		internal static long Wrap_JniMarshal_PPI_J(this _JniMarshal_PPI_J callback, IntPtr jnienv, IntPtr klazz, int p0)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			long result;
			try
			{
				result = callback(jnienv, klazz, p0);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
				result = 0L;
			}
			return result;
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x000505D0 File Offset: 0x0004E7D0
		internal static int Wrap_JniMarshal_PPL_I(this _JniMarshal_PPL_I callback, IntPtr jnienv, IntPtr klazz, IntPtr p0)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			int result;
			try
			{
				result = callback(jnienv, klazz, p0);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
				result = 0;
			}
			return result;
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x00050624 File Offset: 0x0004E824
		internal static IntPtr Wrap_JniMarshal_PPL_L(this _JniMarshal_PPL_L callback, IntPtr jnienv, IntPtr klazz, IntPtr p0)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			IntPtr result;
			try
			{
				result = callback(jnienv, klazz, p0);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
				result = (IntPtr)0;
			}
			return result;
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x00050678 File Offset: 0x0004E878
		internal static void Wrap_JniMarshal_PPL_V(this _JniMarshal_PPL_V callback, IntPtr jnienv, IntPtr klazz, IntPtr p0)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			try
			{
				callback(jnienv, klazz, p0);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
			}
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x000506C8 File Offset: 0x0004E8C8
		internal static bool Wrap_JniMarshal_PPL_Z(this _JniMarshal_PPL_Z callback, IntPtr jnienv, IntPtr klazz, IntPtr p0)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			bool result;
			try
			{
				result = callback(jnienv, klazz, p0);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
				result = false;
			}
			return result;
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x0005071C File Offset: 0x0004E91C
		internal static bool Wrap_JniMarshal_PPJ_Z(this _JniMarshal_PPJ_Z callback, IntPtr jnienv, IntPtr klazz, long p0)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			bool result;
			try
			{
				result = callback(jnienv, klazz, p0);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
				result = false;
			}
			return result;
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x00050770 File Offset: 0x0004E970
		internal static void Wrap_JniMarshal_PPII_V(this _JniMarshal_PPII_V callback, IntPtr jnienv, IntPtr klazz, int p0, int p1)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			try
			{
				callback(jnienv, klazz, p0, p1);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
			}
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x000507C0 File Offset: 0x0004E9C0
		internal static void Wrap_JniMarshal_PPLI_V(this _JniMarshal_PPLI_V callback, IntPtr jnienv, IntPtr klazz, IntPtr p0, int p1)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			try
			{
				callback(jnienv, klazz, p0, p1);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
			}
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x00050810 File Offset: 0x0004EA10
		internal static void Wrap_JniMarshal_PPLZ_V(this _JniMarshal_PPLZ_V callback, IntPtr jnienv, IntPtr klazz, IntPtr p0, bool p1)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			try
			{
				callback(jnienv, klazz, p0, p1);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
			}
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x00050860 File Offset: 0x0004EA60
		internal static void Wrap_JniMarshal_PPLL_V(this _JniMarshal_PPLL_V callback, IntPtr jnienv, IntPtr klazz, IntPtr p0, IntPtr p1)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			try
			{
				callback(jnienv, klazz, p0, p1);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
			}
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x000508B0 File Offset: 0x0004EAB0
		internal static void Wrap_JniMarshal_PPLF_V(this _JniMarshal_PPLF_V callback, IntPtr jnienv, IntPtr klazz, IntPtr p0, float p1)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			try
			{
				callback(jnienv, klazz, p0, p1);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
			}
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x00050900 File Offset: 0x0004EB00
		internal static IntPtr Wrap_JniMarshal_PPLI_L(this _JniMarshal_PPLI_L callback, IntPtr jnienv, IntPtr klazz, IntPtr p0, int p1)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			IntPtr result;
			try
			{
				result = callback(jnienv, klazz, p0, p1);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
				result = (IntPtr)0;
			}
			return result;
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x00050958 File Offset: 0x0004EB58
		internal static IntPtr Wrap_JniMarshal_PPLL_L(this _JniMarshal_PPLL_L callback, IntPtr jnienv, IntPtr klazz, IntPtr p0, IntPtr p1)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			IntPtr result;
			try
			{
				result = callback(jnienv, klazz, p0, p1);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
				result = (IntPtr)0;
			}
			return result;
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x000509B0 File Offset: 0x0004EBB0
		internal static bool Wrap_JniMarshal_PPLL_Z(this _JniMarshal_PPLL_Z callback, IntPtr jnienv, IntPtr klazz, IntPtr p0, IntPtr p1)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			bool result;
			try
			{
				result = callback(jnienv, klazz, p0, p1);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
				result = false;
			}
			return result;
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x00050A04 File Offset: 0x0004EC04
		internal static bool Wrap_JniMarshal_PPIL_Z(this _JniMarshal_PPIL_Z callback, IntPtr jnienv, IntPtr klazz, int p0, IntPtr p1)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			bool result;
			try
			{
				result = callback(jnienv, klazz, p0, p1);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
				result = false;
			}
			return result;
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x00050A58 File Offset: 0x0004EC58
		internal static void Wrap_JniMarshal_PPIIL_V(this _JniMarshal_PPIIL_V callback, IntPtr jnienv, IntPtr klazz, int p0, int p1, IntPtr p2)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			try
			{
				callback(jnienv, klazz, p0, p1, p2);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
			}
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x00050AAC File Offset: 0x0004ECAC
		internal static int Wrap_JniMarshal_PPLII_I(this _JniMarshal_PPLII_I callback, IntPtr jnienv, IntPtr klazz, IntPtr p0, int p1, int p2)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			int result;
			try
			{
				result = callback(jnienv, klazz, p0, p1, p2);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
				result = 0;
			}
			return result;
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x00050B04 File Offset: 0x0004ED04
		internal static bool Wrap_JniMarshal_PPLII_Z(this _JniMarshal_PPLII_Z callback, IntPtr jnienv, IntPtr klazz, IntPtr p0, int p1, int p2)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			bool result;
			try
			{
				result = callback(jnienv, klazz, p0, p1, p2);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
				result = false;
			}
			return result;
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x00050B5C File Offset: 0x0004ED5C
		internal static void Wrap_JniMarshal_PPLII_V(this _JniMarshal_PPLII_V callback, IntPtr jnienv, IntPtr klazz, IntPtr p0, int p1, int p2)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			try
			{
				callback(jnienv, klazz, p0, p1, p2);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
			}
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x00050BB0 File Offset: 0x0004EDB0
		internal static void Wrap_JniMarshal_PPIII_V(this _JniMarshal_PPIII_V callback, IntPtr jnienv, IntPtr klazz, int p0, int p1, int p2)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			try
			{
				callback(jnienv, klazz, p0, p1, p2);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
			}
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x00050C04 File Offset: 0x0004EE04
		internal static bool Wrap_JniMarshal_PPLLJ_Z(this _JniMarshal_PPLLJ_Z callback, IntPtr jnienv, IntPtr klazz, IntPtr p0, IntPtr p1, long p2)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			bool result;
			try
			{
				result = callback(jnienv, klazz, p0, p1, p2);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
				result = false;
			}
			return result;
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x00050C5C File Offset: 0x0004EE5C
		internal static void Wrap_JniMarshal_PPILL_V(this _JniMarshal_PPILL_V callback, IntPtr jnienv, IntPtr klazz, int p0, IntPtr p1, IntPtr p2)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			try
			{
				callback(jnienv, klazz, p0, p1, p2);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
			}
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x00050CB0 File Offset: 0x0004EEB0
		internal static bool Wrap_JniMarshal_PPLIL_Z(this _JniMarshal_PPLIL_Z callback, IntPtr jnienv, IntPtr klazz, IntPtr p0, int p1, IntPtr p2)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			bool result;
			try
			{
				result = callback(jnienv, klazz, p0, p1, p2);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
				result = false;
			}
			return result;
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x00050D08 File Offset: 0x0004EF08
		internal static void Wrap_JniMarshal_PPLLL_V(this _JniMarshal_PPLLL_V callback, IntPtr jnienv, IntPtr klazz, IntPtr p0, IntPtr p1, IntPtr p2)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			try
			{
				callback(jnienv, klazz, p0, p1, p2);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
			}
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x00050D5C File Offset: 0x0004EF5C
		internal static IntPtr Wrap_JniMarshal_PPLLL_L(this _JniMarshal_PPLLL_L callback, IntPtr jnienv, IntPtr klazz, IntPtr p0, IntPtr p1, IntPtr p2)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			IntPtr result;
			try
			{
				result = callback(jnienv, klazz, p0, p1, p2);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
				result = (IntPtr)0;
			}
			return result;
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x00050DB4 File Offset: 0x0004EFB4
		internal static bool Wrap_JniMarshal_PPLLL_Z(this _JniMarshal_PPLLL_Z callback, IntPtr jnienv, IntPtr klazz, IntPtr p0, IntPtr p1, IntPtr p2)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			bool result;
			try
			{
				result = callback(jnienv, klazz, p0, p1, p2);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
				result = false;
			}
			return result;
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x00050E0C File Offset: 0x0004F00C
		internal static IntPtr Wrap_JniMarshal_PPIZI_L(this _JniMarshal_PPIZI_L callback, IntPtr jnienv, IntPtr klazz, int p0, bool p1, int p2)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			IntPtr result;
			try
			{
				result = callback(jnienv, klazz, p0, p1, p2);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
				result = (IntPtr)0;
			}
			return result;
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x00050E64 File Offset: 0x0004F064
		internal static void Wrap_JniMarshal_PPIIII_V(this _JniMarshal_PPIIII_V callback, IntPtr jnienv, IntPtr klazz, int p0, int p1, int p2, int p3)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			try
			{
				callback(jnienv, klazz, p0, p1, p2, p3);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
			}
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x00050EB8 File Offset: 0x0004F0B8
		internal static void Wrap_JniMarshal_PPLLLL_V(this _JniMarshal_PPLLLL_V callback, IntPtr jnienv, IntPtr klazz, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			try
			{
				callback(jnienv, klazz, p0, p1, p2, p3);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
			}
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x00050F0C File Offset: 0x0004F10C
		internal static bool Wrap_JniMarshal_PPLZZL_Z(this _JniMarshal_PPLZZL_Z callback, IntPtr jnienv, IntPtr klazz, IntPtr p0, bool p1, bool p2, IntPtr p3)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			bool result;
			try
			{
				result = callback(jnienv, klazz, p0, p1, p2, p3);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
				result = false;
			}
			return result;
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x00050F64 File Offset: 0x0004F164
		internal static void Wrap_JniMarshal_PPLIIII_V(this _JniMarshal_PPLIIII_V callback, IntPtr jnienv, IntPtr klazz, IntPtr p0, int p1, int p2, int p3, int p4)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			try
			{
				callback(jnienv, klazz, p0, p1, p2, p3, p4);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
			}
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x00050FBC File Offset: 0x0004F1BC
		internal static void Wrap_JniMarshal_PPZIIII_V(this _JniMarshal_PPZIIII_V callback, IntPtr jnienv, IntPtr klazz, bool p0, int p1, int p2, int p3, int p4)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			try
			{
				callback(jnienv, klazz, p0, p1, p2, p3, p4);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
			}
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x00051014 File Offset: 0x0004F214
		internal static void Wrap_JniMarshal_PPLIIIIIIII_V(this _JniMarshal_PPLIIIIIIII_V callback, IntPtr jnienv, IntPtr klazz, IntPtr p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8)
		{
			AndroidRuntimeInternal.WaitForBridgeProcessing();
			try
			{
				callback(jnienv, klazz, p0, p1, p2, p3, p4, p5, p6, p7, p8);
			}
			catch (Exception e) when (JNINativeWrapper._unhandled_exception(e))
			{
				AndroidEnvironment.UnhandledException(e);
			}
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x00051074 File Offset: 0x0004F274
		private static Delegate CreateBuiltInDelegate(Delegate dlg, Type delegateType)
		{
			string name = delegateType.Name;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(name);
			if (num <= 1759166709U)
			{
				if (num <= 1377385079U)
				{
					if (num <= 533268969U)
					{
						if (num <= 171985081U)
						{
							if (num != 84601511U)
							{
								if (num == 171985081U)
								{
									if (name == "_JniMarshal_PPJ_Z")
									{
										return new _JniMarshal_PPJ_Z(Unsafe.As<_JniMarshal_PPJ_Z>(dlg).Wrap_JniMarshal_PPJ_Z);
									}
								}
							}
							else if (name == "_JniMarshal_PPLZZL_Z")
							{
								return new _JniMarshal_PPLZZL_Z(Unsafe.As<_JniMarshal_PPLZZL_Z>(dlg).Wrap_JniMarshal_PPLZZL_Z);
							}
						}
						else if (num != 515524482U)
						{
							if (num == 533268969U)
							{
								if (name == "_JniMarshal_PPLLJ_Z")
								{
									return new _JniMarshal_PPLLJ_Z(Unsafe.As<_JniMarshal_PPLLJ_Z>(dlg).Wrap_JniMarshal_PPLLJ_Z);
								}
							}
						}
						else if (name == "_JniMarshal_PPIL_Z")
						{
							return new _JniMarshal_PPIL_Z(Unsafe.As<_JniMarshal_PPIL_Z>(dlg).Wrap_JniMarshal_PPIL_Z);
						}
					}
					else if (num <= 718119823U)
					{
						if (num != 553656731U)
						{
							if (num == 718119823U)
							{
								if (name == "_JniMarshal_PPLIIIIIIII_V")
								{
									return new _JniMarshal_PPLIIIIIIII_V(Unsafe.As<_JniMarshal_PPLIIIIIIII_V>(dlg).Wrap_JniMarshal_PPLIIIIIIII_V);
								}
							}
						}
						else if (name == "_JniMarshal_PPIIII_V")
						{
							return new _JniMarshal_PPIIII_V(Unsafe.As<_JniMarshal_PPIIII_V>(dlg).Wrap_JniMarshal_PPIIII_V);
						}
					}
					else if (num != 783697434U)
					{
						if (num != 1176053651U)
						{
							if (num == 1377385079U)
							{
								if (name == "_JniMarshal_PPLLL_V")
								{
									return new _JniMarshal_PPLLL_V(Unsafe.As<_JniMarshal_PPLLL_V>(dlg).Wrap_JniMarshal_PPLLL_V);
								}
							}
						}
						else if (name == "_JniMarshal_PPLLL_Z")
						{
							return new _JniMarshal_PPLLL_Z(Unsafe.As<_JniMarshal_PPLLL_Z>(dlg).Wrap_JniMarshal_PPLLL_Z);
						}
					}
					else if (name == "_JniMarshal_PPLIL_Z")
					{
						return new _JniMarshal_PPLIL_Z(Unsafe.As<_JniMarshal_PPLIL_Z>(dlg).Wrap_JniMarshal_PPLIL_Z);
					}
				}
				else if (num <= 1573574816U)
				{
					if (num <= 1507502424U)
					{
						if (num != 1389332729U)
						{
							if (num == 1507502424U)
							{
								if (name == "_JniMarshal_PPI_V")
								{
									return new _JniMarshal_PPI_V(Unsafe.As<_JniMarshal_PPI_V>(dlg).Wrap_JniMarshal_PPI_V);
								}
							}
						}
						else if (name == "_JniMarshal_PPZIIII_V")
						{
							return new _JniMarshal_PPZIIII_V(Unsafe.As<_JniMarshal_PPZIIII_V>(dlg).Wrap_JniMarshal_PPZIIII_V);
						}
					}
					else if (num != 1515489445U)
					{
						if (num != 1545161269U)
						{
							if (num == 1573574816U)
							{
								if (name == "_JniMarshal_PPLII_I")
								{
									return new _JniMarshal_PPLII_I(Unsafe.As<_JniMarshal_PPLII_I>(dlg).Wrap_JniMarshal_PPLII_I);
								}
							}
						}
						else if (name == "_JniMarshal_PPLLL_L")
						{
							return new _JniMarshal_PPLLL_L(Unsafe.As<_JniMarshal_PPLLL_L>(dlg).Wrap_JniMarshal_PPLLL_L);
						}
					}
					else if (name == "_JniMarshal_PPII_V")
					{
						return new _JniMarshal_PPII_V(Unsafe.As<_JniMarshal_PPII_V>(dlg).Wrap_JniMarshal_PPII_V);
					}
				}
				else if (num <= 1675278614U)
				{
					if (num != 1636873094U)
					{
						if (num == 1675278614U)
						{
							if (name == "_JniMarshal_PPI_L")
							{
								return new _JniMarshal_PPI_L(Unsafe.As<_JniMarshal_PPI_L>(dlg).Wrap_JniMarshal_PPI_L);
							}
						}
					}
					else if (name == "_JniMarshal_PPL_I")
					{
						return new _JniMarshal_PPL_I(Unsafe.As<_JniMarshal_PPL_I>(dlg).Wrap_JniMarshal_PPL_I);
					}
				}
				else if (num != 1708833852U)
				{
					if (num != 1720761189U)
					{
						if (num == 1759166709U)
						{
							if (name == "_JniMarshal_PPI_I")
							{
								return new _JniMarshal_PPI_I(Unsafe.As<_JniMarshal_PPI_I>(dlg).Wrap_JniMarshal_PPI_I);
							}
						}
					}
					else if (name == "_JniMarshal_PPL_L")
					{
						return new _JniMarshal_PPL_L(Unsafe.As<_JniMarshal_PPL_L>(dlg).Wrap_JniMarshal_PPL_L);
					}
				}
				else if (name == "_JniMarshal_PPI_J")
				{
					return new _JniMarshal_PPI_J(Unsafe.As<_JniMarshal_PPI_J>(dlg).Wrap_JniMarshal_PPI_J);
				}
			}
			else if (num <= 3006059825U)
			{
				if (num <= 2093681005U)
				{
					if (num <= 1888537379U)
					{
						if (num != 1845995961U)
						{
							if (num == 1888537379U)
							{
								if (name == "_JniMarshal_PPL_Z")
								{
									return new _JniMarshal_PPL_Z(Unsafe.As<_JniMarshal_PPL_Z>(dlg).Wrap_JniMarshal_PPL_Z);
								}
							}
						}
						else if (name == "_JniMarshal_PPIIL_V")
						{
							return new _JniMarshal_PPIIL_V(Unsafe.As<_JniMarshal_PPIIL_V>(dlg).Wrap_JniMarshal_PPIIL_V);
						}
					}
					else if (num != 1892349577U)
					{
						if (num != 2089868807U)
						{
							if (num == 2093681005U)
							{
								if (name == "_JniMarshal_PPLII_V")
								{
									return new _JniMarshal_PPLII_V(Unsafe.As<_JniMarshal_PPLII_V>(dlg).Wrap_JniMarshal_PPLII_V);
								}
							}
						}
						else if (name == "_JniMarshal_PPL_V")
						{
							return new _JniMarshal_PPL_V(Unsafe.As<_JniMarshal_PPL_V>(dlg).Wrap_JniMarshal_PPL_V);
						}
					}
					else if (name == "_JniMarshal_PPLII_Z")
					{
						return new _JniMarshal_PPLII_Z(Unsafe.As<_JniMarshal_PPLII_Z>(dlg).Wrap_JniMarshal_PPLII_Z);
					}
				}
				else if (num <= 2626627450U)
				{
					if (num != 2552895416U)
					{
						if (num == 2626627450U)
						{
							if (name == "_JniMarshal_PPIII_V")
							{
								return new _JniMarshal_PPIII_V(Unsafe.As<_JniMarshal_PPIII_V>(dlg).Wrap_JniMarshal_PPIII_V);
							}
						}
					}
					else if (name == "_JniMarshal_PPILL_V")
					{
						return new _JniMarshal_PPILL_V(Unsafe.As<_JniMarshal_PPILL_V>(dlg).Wrap_JniMarshal_PPILL_V);
					}
				}
				else if (num != 2663997023U)
				{
					if (num != 2731107499U)
					{
						if (num == 3006059825U)
						{
							if (name == "_JniMarshal_PPLF_V")
							{
								return new _JniMarshal_PPLF_V(Unsafe.As<_JniMarshal_PPLF_V>(dlg).Wrap_JniMarshal_PPLF_V);
							}
						}
					}
					else if (name == "_JniMarshal_PP_Z")
					{
						return new _JniMarshal_PP_Z(Unsafe.As<_JniMarshal_PP_Z>(dlg).Wrap_JniMarshal_PP_Z);
					}
				}
				else if (name == "_JniMarshal_PP_V")
				{
					return new _JniMarshal_PP_V(Unsafe.As<_JniMarshal_PP_V>(dlg).Wrap_JniMarshal_PP_V);
				}
			}
			else if (num <= 3749127037U)
			{
				if (num <= 3288214720U)
				{
					if (num != 3016327022U)
					{
						if (num == 3288214720U)
						{
							if (name == "_JniMarshal_PPLI_V")
							{
								return new _JniMarshal_PPLI_V(Unsafe.As<_JniMarshal_PPLI_V>(dlg).Wrap_JniMarshal_PPLI_V);
							}
						}
					}
					else if (name == "_JniMarshal_PP_I")
					{
						return new _JniMarshal_PP_I(Unsafe.As<_JniMarshal_PP_I>(dlg).Wrap_JniMarshal_PP_I);
					}
				}
				else if (num != 3329353135U)
				{
					if (num != 3724432814U)
					{
						if (num == 3749127037U)
						{
							if (name == "_JniMarshal_PPLL_L")
							{
								return new _JniMarshal_PPLL_L(Unsafe.As<_JniMarshal_PPLL_L>(dlg).Wrap_JniMarshal_PPLL_L);
							}
						}
					}
					else if (name == "_JniMarshal_PPLI_L")
					{
						return new _JniMarshal_PPLI_L(Unsafe.As<_JniMarshal_PPLI_L>(dlg).Wrap_JniMarshal_PPLI_L);
					}
				}
				else if (name == "_JniMarshal_PPIZI_L")
				{
					return new _JniMarshal_PPIZI_L(Unsafe.As<_JniMarshal_PPIZI_L>(dlg).Wrap_JniMarshal_PPIZI_L);
				}
			}
			else if (num <= 3916903227U)
			{
				if (num != 3849792751U)
				{
					if (num == 3916903227U)
					{
						if (name == "_JniMarshal_PPLL_Z")
						{
							return new _JniMarshal_PPLL_Z(Unsafe.As<_JniMarshal_PPLL_Z>(dlg).Wrap_JniMarshal_PPLL_Z);
						}
					}
				}
				else if (name == "_JniMarshal_PPLL_V")
				{
					return new _JniMarshal_PPLL_V(Unsafe.As<_JniMarshal_PPLL_V>(dlg).Wrap_JniMarshal_PPLL_V);
				}
			}
			else if (num != 4044078805U)
			{
				if (num != 4259867139U)
				{
					if (num == 4266319615U)
					{
						if (name == "_JniMarshal_PPLLLL_V")
						{
							return new _JniMarshal_PPLLLL_V(Unsafe.As<_JniMarshal_PPLLLL_V>(dlg).Wrap_JniMarshal_PPLLLL_V);
						}
					}
				}
				else if (name == "_JniMarshal_PPLIIII_V")
				{
					return new _JniMarshal_PPLIIII_V(Unsafe.As<_JniMarshal_PPLIIII_V>(dlg).Wrap_JniMarshal_PPLIIII_V);
				}
			}
			else if (name == "_JniMarshal_PPLZ_V")
			{
				return new _JniMarshal_PPLZ_V(Unsafe.As<_JniMarshal_PPLZ_V>(dlg).Wrap_JniMarshal_PPLZ_V);
			}
			return null;
		}

		// Token: 0x04000C36 RID: 3126
		private static MethodInfo exception_handler_method;

		// Token: 0x04000C37 RID: 3127
		private static MethodInfo wait_for_bridge_processing_method;
	}
}
