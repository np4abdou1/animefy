using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Diagnostics
{
	/// <summary>Provides access to local and remote processes and enables you to start and stop local system processes.To browse the .NET Framework source code for this type, see the Reference Source.</summary>
	// Token: 0x020000CB RID: 203
	[MonitoringDescription("Provides access to local and remote processes, enabling starting and stopping of local processes.")]
	[DefaultEvent("Exited")]
	[DefaultProperty("StartInfo")]
	public class Process : Component
	{
		// Token: 0x060005F3 RID: 1523 RVA: 0x00024909 File Offset: 0x00022B09
		private Process(string machineName, bool isRemoteMachine, int processId, ProcessInfo processInfo)
		{
			this.machineName = machineName;
			this.isRemoteMachine = isRemoteMachine;
			this.processId = processId;
			this.haveProcessId = true;
			this.outputStreamReadMode = Process.StreamReadMode.undefined;
			this.errorStreamReadMode = Process.StreamReadMode.undefined;
			this.m_processAccess = 2035711;
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x00024946 File Offset: 0x00022B46
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("Indicates if the process component is associated with a real process.")]
		private bool Associated
		{
			get
			{
				return this.haveProcessId || this.haveProcessHandle;
			}
		}

		/// <summary>Gets a value indicating whether the associated process has been terminated.</summary>
		/// <returns>
		///     <see langword="true" /> if the operating system process referenced by the <see cref="T:System.Diagnostics.Process" /> component has terminated; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">There is no process associated with the object. </exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The exit code for the process could not be retrieved. </exception>
		/// <exception cref="T:System.NotSupportedException">You are trying to access the <see cref="P:System.Diagnostics.Process.HasExited" /> property for a process that is running on a remote computer. This property is available only for processes that are running on the local computer.</exception>
		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x00024958 File Offset: 0x00022B58
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("Indicates if the associated process has been terminated.")]
		public bool HasExited
		{
			get
			{
				if (!this.exited)
				{
					this.EnsureState(Process.State.Associated);
					SafeProcessHandle safeProcessHandle = null;
					try
					{
						safeProcessHandle = this.GetProcessHandle(1049600, false);
						int num;
						if (safeProcessHandle.IsInvalid)
						{
							this.exited = true;
						}
						else if (NativeMethods.GetExitCodeProcess(safeProcessHandle, out num) && num != 259)
						{
							this.exited = true;
							this.exitCode = num;
						}
						else
						{
							if (!this.signaled)
							{
								ProcessWaitHandle processWaitHandle = null;
								try
								{
									processWaitHandle = new ProcessWaitHandle(safeProcessHandle);
									this.signaled = processWaitHandle.WaitOne(0, false);
								}
								finally
								{
									if (processWaitHandle != null)
									{
										processWaitHandle.Close();
									}
								}
							}
							if (this.signaled)
							{
								if (!NativeMethods.GetExitCodeProcess(safeProcessHandle, out num))
								{
									throw new Win32Exception();
								}
								this.exited = true;
								this.exitCode = num;
							}
						}
					}
					finally
					{
						this.ReleaseProcessHandle(safeProcessHandle);
					}
					if (this.exited)
					{
						this.RaiseOnExited();
					}
				}
				return this.exited;
			}
		}

		/// <summary>Gets the unique identifier for the associated process.</summary>
		/// <returns>The system-generated unique identifier of the process that is referenced by this <see cref="T:System.Diagnostics.Process" /> instance.</returns>
		/// <exception cref="T:System.InvalidOperationException">The process's <see cref="P:System.Diagnostics.Process.Id" /> property has not been set.-or- There is no process associated with this <see cref="T:System.Diagnostics.Process" /> object. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me); set the <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> property to <see langword="false" /> to access this property on Windows 98 and Windows Me.</exception>
		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x00024A48 File Offset: 0x00022C48
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The unique identifier for the process.")]
		public int Id
		{
			get
			{
				this.EnsureState(Process.State.HaveId);
				return this.processId;
			}
		}

		/// <summary>Gets or sets the object used to marshal the event handler calls that are issued as a result of a process exit event.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.ISynchronizeInvoke" /> used to marshal event handler calls that are issued as a result of an <see cref="E:System.Diagnostics.Process.Exited" /> event on the process.</returns>
		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x00024A58 File Offset: 0x00022C58
		[Browsable(false)]
		[DefaultValue(null)]
		[MonitoringDescription("The object used to marshal the event handler calls issued as a result of a Process exit.")]
		public ISynchronizeInvoke SynchronizingObject
		{
			get
			{
				if (this.synchronizingObject == null && base.DesignMode)
				{
					IDesignerHost designerHost = (IDesignerHost)this.GetService(typeof(IDesignerHost));
					if (designerHost != null)
					{
						object rootComponent = designerHost.RootComponent;
						if (rootComponent != null && rootComponent is ISynchronizeInvoke)
						{
							this.synchronizingObject = (ISynchronizeInvoke)rootComponent;
						}
					}
				}
				return this.synchronizingObject;
			}
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00024AB2 File Offset: 0x00022CB2
		private void ReleaseProcessHandle(SafeProcessHandle handle)
		{
			if (handle == null)
			{
				return;
			}
			if (this.haveProcessHandle && handle == this.m_processHandle)
			{
				return;
			}
			handle.Close();
		}

		/// <summary>Release all resources used by this process.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		// Token: 0x060005F9 RID: 1529 RVA: 0x00024AD0 File Offset: 0x00022CD0
		protected override void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					this.Close();
				}
				this.disposed = true;
				base.Dispose(disposing);
			}
		}

		/// <summary>Frees all the resources that are associated with this component.</summary>
		// Token: 0x060005FA RID: 1530 RVA: 0x00024AF4 File Offset: 0x00022CF4
		public void Close()
		{
			if (this.Associated)
			{
				if (this.haveProcessHandle)
				{
					this.StopWatchingForExit();
					this.m_processHandle.Close();
					this.m_processHandle = null;
					this.haveProcessHandle = false;
				}
				this.haveProcessId = false;
				this.isRemoteMachine = false;
				this.machineName = ".";
				this.raisedOnExited = false;
				StreamWriter streamWriter = this.standardInput;
				this.standardInput = null;
				if (this.inputStreamReadMode == Process.StreamReadMode.undefined && streamWriter != null)
				{
					streamWriter.Close();
				}
				StreamReader streamReader = this.standardOutput;
				this.standardOutput = null;
				if (this.outputStreamReadMode == Process.StreamReadMode.undefined && streamReader != null)
				{
					streamReader.Close();
				}
				streamReader = this.standardError;
				this.standardError = null;
				if (this.errorStreamReadMode == Process.StreamReadMode.undefined && streamReader != null)
				{
					streamReader.Close();
				}
				AsyncStreamReader asyncStreamReader = this.output;
				this.output = null;
				if (this.outputStreamReadMode == Process.StreamReadMode.asyncMode && asyncStreamReader != null)
				{
					asyncStreamReader.CancelOperation();
					asyncStreamReader.Close();
				}
				asyncStreamReader = this.error;
				this.error = null;
				if (this.errorStreamReadMode == Process.StreamReadMode.asyncMode && asyncStreamReader != null)
				{
					asyncStreamReader.CancelOperation();
					asyncStreamReader.Close();
				}
				this.Refresh();
			}
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00024C04 File Offset: 0x00022E04
		private void EnsureState(Process.State state)
		{
			if ((state & Process.State.Associated) != (Process.State)0 && !this.Associated)
			{
				throw new InvalidOperationException(SR.GetString("No process is associated with this object."));
			}
			if ((state & Process.State.HaveId) != (Process.State)0 && !this.haveProcessId)
			{
				this.EnsureState(Process.State.Associated);
				throw new InvalidOperationException(SR.GetString("Feature requires a process identifier."));
			}
			if ((state & Process.State.IsLocal) != (Process.State)0 && this.isRemoteMachine)
			{
				throw new NotSupportedException(SR.GetString("Feature is not supported for remote machines."));
			}
			if ((state & Process.State.HaveProcessInfo) != (Process.State)0)
			{
				throw new InvalidOperationException(SR.GetString("Process has exited, so the requested information is not available."));
			}
			if ((state & Process.State.Exited) != (Process.State)0)
			{
				if (!this.HasExited)
				{
					throw new InvalidOperationException(SR.GetString("Process must exit before requested information can be determined."));
				}
				if (!this.haveProcessHandle)
				{
					throw new InvalidOperationException(SR.GetString("Process was not started by this object, so requested information cannot be determined."));
				}
			}
		}

		/// <summary>Gets a new <see cref="T:System.Diagnostics.Process" /> component and associates it with the currently active process.</summary>
		/// <returns>A new <see cref="T:System.Diagnostics.Process" /> component associated with the process resource that is running the calling application.</returns>
		// Token: 0x060005FC RID: 1532 RVA: 0x00024CBC File Offset: 0x00022EBC
		public static Process GetCurrentProcess()
		{
			return new Process(".", false, NativeMethods.GetCurrentProcessId(), null);
		}

		/// <summary>Raises the <see cref="E:System.Diagnostics.Process.Exited" /> event.</summary>
		// Token: 0x060005FD RID: 1533 RVA: 0x00024CD0 File Offset: 0x00022ED0
		protected void OnExited()
		{
			EventHandler eventHandler = this.onExited;
			if (eventHandler != null)
			{
				if (this.SynchronizingObject != null && this.SynchronizingObject.InvokeRequired)
				{
					this.SynchronizingObject.BeginInvoke(eventHandler, new object[]
					{
						this,
						EventArgs.Empty
					});
					return;
				}
				eventHandler(this, EventArgs.Empty);
			}
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00024D28 File Offset: 0x00022F28
		private SafeProcessHandle GetProcessHandle(int access, bool throwIfExited)
		{
			if (this.haveProcessHandle)
			{
				if (throwIfExited)
				{
					ProcessWaitHandle processWaitHandle = null;
					try
					{
						processWaitHandle = new ProcessWaitHandle(this.m_processHandle);
						if (processWaitHandle.WaitOne(0, false))
						{
							if (this.haveProcessId)
							{
								throw new InvalidOperationException(SR.GetString("Cannot process request because the process ({0}) has exited.", new object[]
								{
									this.processId.ToString(CultureInfo.CurrentCulture)
								}));
							}
							throw new InvalidOperationException(SR.GetString("Cannot process request because the process has exited."));
						}
					}
					finally
					{
						if (processWaitHandle != null)
						{
							processWaitHandle.Close();
						}
					}
				}
				return this.m_processHandle;
			}
			this.EnsureState((Process.State)3);
			SafeProcessHandle invalidHandle = SafeProcessHandle.InvalidHandle;
			IntPtr currentProcess = NativeMethods.GetCurrentProcess();
			if (!NativeMethods.DuplicateHandle(new HandleRef(this, currentProcess), new HandleRef(this, currentProcess), new HandleRef(this, currentProcess), out invalidHandle, 0, false, 3))
			{
				throw new Win32Exception();
			}
			if (throwIfExited && (access & 1024) != 0 && NativeMethods.GetExitCodeProcess(invalidHandle, out this.exitCode) && this.exitCode != 259)
			{
				throw new InvalidOperationException(SR.GetString("Cannot process request because the process ({0}) has exited.", new object[]
				{
					this.processId.ToString(CultureInfo.CurrentCulture)
				}));
			}
			return invalidHandle;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00024E48 File Offset: 0x00023048
		private SafeProcessHandle GetProcessHandle(int access)
		{
			return this.GetProcessHandle(access, true);
		}

		/// <summary>Discards any information about the associated process that has been cached inside the process component.</summary>
		// Token: 0x06000600 RID: 1536 RVA: 0x00024E52 File Offset: 0x00023052
		public void Refresh()
		{
			this.threads = null;
			this.modules = null;
			this.exited = false;
			this.signaled = false;
			this.haveWorkingSetLimits = false;
			this.havePriorityClass = false;
			this.haveExitTime = false;
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00024E88 File Offset: 0x00023088
		private void StopWatchingForExit()
		{
			if (this.watchingForExit)
			{
				lock (this)
				{
					if (this.watchingForExit)
					{
						this.watchingForExit = false;
						this.registeredWaitHandle.Unregister(null);
						this.waitHandle.Close();
						this.waitHandle = null;
						this.registeredWaitHandle = null;
					}
				}
			}
		}

		/// <summary>Formats the process's name as a string, combined with the parent component type, if applicable.</summary>
		/// <returns>The <see cref="P:System.Diagnostics.Process.ProcessName" />, combined with the base component's <see cref="M:System.Object.ToString" /> return value.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">
		///         <see cref="M:System.Diagnostics.Process.ToString" /> is not supported on Windows 98.</exception>
		// Token: 0x06000602 RID: 1538 RVA: 0x00024EFC File Offset: 0x000230FC
		public override string ToString()
		{
			if (!this.Associated)
			{
				return base.ToString();
			}
			string text = string.Empty;
			try
			{
				text = this.ProcessName;
			}
			catch (PlatformNotSupportedException)
			{
			}
			if (text.Length != 0)
			{
				return string.Format(CultureInfo.CurrentCulture, "{0} ({1})", base.ToString(), text);
			}
			return base.ToString();
		}

		// Token: 0x06000603 RID: 1539
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string ProcessName_icall(IntPtr handle);

		// Token: 0x06000604 RID: 1540 RVA: 0x00024F60 File Offset: 0x00023160
		private static string ProcessName_internal(SafeProcessHandle handle)
		{
			bool flag = false;
			string result;
			try
			{
				handle.DangerousAddRef(ref flag);
				result = Process.ProcessName_icall(handle.DangerousGetHandle());
			}
			finally
			{
				if (flag)
				{
					handle.DangerousRelease();
				}
			}
			return result;
		}

		/// <summary>Gets the name of the process.</summary>
		/// <returns>The name that the system uses to identify the process to the user.</returns>
		/// <exception cref="T:System.InvalidOperationException">The process does not have an identifier, or no process is associated with the <see cref="T:System.Diagnostics.Process" />.-or- The associated process has exited. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Windows Me); set <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> to <see langword="false" /> to access this property on Windows 98 and Windows Me.</exception>
		/// <exception cref="T:System.NotSupportedException">The process is not on this computer.</exception>
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x00024FA0 File Offset: 0x000231A0
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The name of this process.")]
		public string ProcessName
		{
			get
			{
				if (this.process_name == null)
				{
					SafeProcessHandle handle = null;
					try
					{
						handle = this.GetProcessHandle(1024);
						this.process_name = Process.ProcessName_internal(handle);
						if (this.process_name == null)
						{
							throw new InvalidOperationException("Process has exited or is inaccessible, so the requested information is not available.");
						}
						if (this.process_name.EndsWith(".exe") || this.process_name.EndsWith(".bat") || this.process_name.EndsWith(".com"))
						{
							this.process_name = this.process_name.Substring(0, this.process_name.Length - 4);
						}
					}
					finally
					{
						this.ReleaseProcessHandle(handle);
					}
				}
				return this.process_name;
			}
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x0002505C File Offset: 0x0002325C
		private void RaiseOnExited()
		{
			if (!this.watchForExit)
			{
				return;
			}
			if (!this.raisedOnExited)
			{
				lock (this)
				{
					if (!this.raisedOnExited)
					{
						this.raisedOnExited = true;
						this.OnExited();
					}
				}
			}
		}

		// Token: 0x040003DA RID: 986
		private bool haveProcessId;

		// Token: 0x040003DB RID: 987
		private int processId;

		// Token: 0x040003DC RID: 988
		private bool haveProcessHandle;

		// Token: 0x040003DD RID: 989
		private SafeProcessHandle m_processHandle;

		// Token: 0x040003DE RID: 990
		private bool isRemoteMachine;

		// Token: 0x040003DF RID: 991
		private string machineName;

		// Token: 0x040003E0 RID: 992
		private int m_processAccess;

		// Token: 0x040003E1 RID: 993
		private ProcessThreadCollection threads;

		// Token: 0x040003E2 RID: 994
		private ProcessModuleCollection modules;

		// Token: 0x040003E3 RID: 995
		private bool haveWorkingSetLimits;

		// Token: 0x040003E4 RID: 996
		private bool havePriorityClass;

		// Token: 0x040003E5 RID: 997
		private bool watchForExit;

		// Token: 0x040003E6 RID: 998
		private bool watchingForExit;

		// Token: 0x040003E7 RID: 999
		private EventHandler onExited;

		// Token: 0x040003E8 RID: 1000
		private bool exited;

		// Token: 0x040003E9 RID: 1001
		private int exitCode;

		// Token: 0x040003EA RID: 1002
		private bool signaled;

		// Token: 0x040003EB RID: 1003
		private bool haveExitTime;

		// Token: 0x040003EC RID: 1004
		private bool raisedOnExited;

		// Token: 0x040003ED RID: 1005
		private RegisteredWaitHandle registeredWaitHandle;

		// Token: 0x040003EE RID: 1006
		private WaitHandle waitHandle;

		// Token: 0x040003EF RID: 1007
		private ISynchronizeInvoke synchronizingObject;

		// Token: 0x040003F0 RID: 1008
		private StreamReader standardOutput;

		// Token: 0x040003F1 RID: 1009
		private StreamWriter standardInput;

		// Token: 0x040003F2 RID: 1010
		private StreamReader standardError;

		// Token: 0x040003F3 RID: 1011
		private bool disposed;

		// Token: 0x040003F4 RID: 1012
		private Process.StreamReadMode outputStreamReadMode;

		// Token: 0x040003F5 RID: 1013
		private Process.StreamReadMode errorStreamReadMode;

		// Token: 0x040003F6 RID: 1014
		private Process.StreamReadMode inputStreamReadMode;

		// Token: 0x040003F7 RID: 1015
		internal AsyncStreamReader output;

		// Token: 0x040003F8 RID: 1016
		internal AsyncStreamReader error;

		// Token: 0x040003F9 RID: 1017
		private string process_name;

		// Token: 0x020000CC RID: 204
		private enum StreamReadMode
		{
			// Token: 0x040003FB RID: 1019
			undefined,
			// Token: 0x040003FC RID: 1020
			syncMode,
			// Token: 0x040003FD RID: 1021
			asyncMode
		}

		// Token: 0x020000CD RID: 205
		private enum State
		{
			// Token: 0x040003FF RID: 1023
			HaveId = 1,
			// Token: 0x04000400 RID: 1024
			IsLocal,
			// Token: 0x04000401 RID: 1025
			IsNt = 4,
			// Token: 0x04000402 RID: 1026
			HaveProcessInfo = 8,
			// Token: 0x04000403 RID: 1027
			Exited = 16,
			// Token: 0x04000404 RID: 1028
			Associated = 32,
			// Token: 0x04000405 RID: 1029
			IsWin2k = 64,
			// Token: 0x04000406 RID: 1030
			HaveNtProcessInfo = 12
		}
	}
}
