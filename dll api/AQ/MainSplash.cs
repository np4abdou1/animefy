using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Android.App;
using Android.OS;
using AndroidX.AppCompat.App;
using AQ.ViewModels;

namespace AQ
{
	// Token: 0x02000007 RID: 7
	[Activity(Theme = "@style/SplashTheme.Splash", MainLauncher = true, NoHistory = true)]
	public class MainSplash : AppCompatActivity
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00003FEA File Offset: 0x000021EA
		public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
		{
			base.OnCreate(savedInstanceState, persistentState);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003FF4 File Offset: 0x000021F4
		protected override void OnResume()
		{
			base.OnResume();
			Task task = new Task(delegate()
			{
				this.SimulateStartup();
			});
			task.Start();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004020 File Offset: 0x00002220
		private void SimulateStartup()
		{
			MainSplash.<SimulateStartup>d__3 <SimulateStartup>d__;
			<SimulateStartup>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SimulateStartup>d__.<>4__this = this;
			<SimulateStartup>d__.<>1__state = -1;
			<SimulateStartup>d__.<>t__builder.Start<MainSplash.<SimulateStartup>d__3>(ref <SimulateStartup>d__);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004057 File Offset: 0x00002257
		private void PrepareSqliteTables()
		{
			NotificationsViewModel.NotifPrepareTable();
			UsersViewModel.ProfilePrepareTable();
			WatchHistoryViewModel.localeHistoryPrepareTable();
		}

		// Token: 0x0400006C RID: 108
		private static readonly string TAG = "X:" + typeof(MainSplash).Name;
	}
}
