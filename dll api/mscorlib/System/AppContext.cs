using System;
using System.Collections.Generic;

namespace System
{
	/// <summary>Provides members for setting and retrieving data about an application's context. </summary>
	// Token: 0x02000134 RID: 308
	public static class AppContext
	{
		// Token: 0x06000C20 RID: 3104 RVA: 0x00031EF4 File Offset: 0x000300F4
		private static void InitializeDefaultSwitchValues()
		{
			Dictionary<string, AppContext.SwitchValueState> obj = AppContext.s_switchMap;
			lock (obj)
			{
				if (!AppContext.s_defaultsInitialized)
				{
					AppContextDefaultValues.PopulateDefaultValues();
					AppContext.s_defaultsInitialized = true;
				}
			}
		}

		/// <summary>Tries to get the value of a switch. </summary>
		/// <param name="switchName">The name of the switch. </param>
		/// <param name="isEnabled">When this method returns, contains the value of <paramref name="switchName" /> if <paramref name="switchName" /> was found, or <see langword="false" /> if <paramref name="switchName" /> was not found. This parameter is passed uninitialized. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="switchName" /> was set and the <paramref name="isEnabled" /> argument contains the value of the switch; otherwise, <see langword="false" />. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="switchName" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="switchName" /> is <see cref="F:System.String.Empty" />. </exception>
		// Token: 0x06000C21 RID: 3105 RVA: 0x00031F44 File Offset: 0x00030144
		public static bool TryGetSwitch(string switchName, out bool isEnabled)
		{
			if (switchName == null)
			{
				throw new ArgumentNullException("switchName");
			}
			if (switchName.Length == 0)
			{
				throw new ArgumentException(Environment.GetResourceString("Empty name is not legal."), "switchName");
			}
			if (!AppContext.s_defaultsInitialized)
			{
				AppContext.InitializeDefaultSwitchValues();
			}
			isEnabled = false;
			Dictionary<string, AppContext.SwitchValueState> obj = AppContext.s_switchMap;
			lock (obj)
			{
				AppContext.SwitchValueState switchValueState;
				if (AppContext.s_switchMap.TryGetValue(switchName, out switchValueState))
				{
					if (switchValueState == AppContext.SwitchValueState.UnknownValue)
					{
						isEnabled = false;
						return false;
					}
					isEnabled = ((switchValueState & AppContext.SwitchValueState.HasTrueValue) == AppContext.SwitchValueState.HasTrueValue);
					if ((switchValueState & AppContext.SwitchValueState.HasLookedForOverride) == AppContext.SwitchValueState.HasLookedForOverride)
					{
						return true;
					}
					bool flag2;
					if (AppContextDefaultValues.TryGetSwitchOverride(switchName, out flag2))
					{
						isEnabled = flag2;
					}
					AppContext.s_switchMap[switchName] = ((isEnabled ? AppContext.SwitchValueState.HasTrueValue : AppContext.SwitchValueState.HasFalseValue) | AppContext.SwitchValueState.HasLookedForOverride);
					return true;
				}
				else
				{
					bool flag3;
					if (AppContextDefaultValues.TryGetSwitchOverride(switchName, out flag3))
					{
						isEnabled = flag3;
						AppContext.s_switchMap[switchName] = ((isEnabled ? AppContext.SwitchValueState.HasTrueValue : AppContext.SwitchValueState.HasFalseValue) | AppContext.SwitchValueState.HasLookedForOverride);
						return true;
					}
					AppContext.s_switchMap[switchName] = AppContext.SwitchValueState.UnknownValue;
				}
			}
			return false;
		}

		// Token: 0x040003EE RID: 1006
		private static readonly Dictionary<string, AppContext.SwitchValueState> s_switchMap = new Dictionary<string, AppContext.SwitchValueState>();

		// Token: 0x040003EF RID: 1007
		private static volatile bool s_defaultsInitialized = false;

		// Token: 0x02000135 RID: 309
		[Flags]
		private enum SwitchValueState
		{
			// Token: 0x040003F1 RID: 1009
			HasFalseValue = 1,
			// Token: 0x040003F2 RID: 1010
			HasTrueValue = 2,
			// Token: 0x040003F3 RID: 1011
			HasLookedForOverride = 4,
			// Token: 0x040003F4 RID: 1012
			UnknownValue = 8
		}
	}
}
