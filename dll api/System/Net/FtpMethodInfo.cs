using System;
using System.Globalization;

namespace System.Net
{
	// Token: 0x02000125 RID: 293
	internal class FtpMethodInfo
	{
		// Token: 0x06000864 RID: 2148 RVA: 0x0002F5B0 File Offset: 0x0002D7B0
		internal FtpMethodInfo(string method, FtpOperation operation, FtpMethodFlags flags, string httpCommand)
		{
			this.Method = method;
			this.Operation = operation;
			this.Flags = flags;
			this.HttpCommand = httpCommand;
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x0002F5D5 File Offset: 0x0002D7D5
		internal bool HasFlag(FtpMethodFlags flags)
		{
			return (this.Flags & flags) > FtpMethodFlags.None;
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x0002F5E2 File Offset: 0x0002D7E2
		internal bool IsCommandOnly
		{
			get
			{
				return (this.Flags & (FtpMethodFlags.IsDownload | FtpMethodFlags.IsUpload)) == FtpMethodFlags.None;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x0002F5EF File Offset: 0x0002D7EF
		internal bool IsUpload
		{
			get
			{
				return (this.Flags & FtpMethodFlags.IsUpload) > FtpMethodFlags.None;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x0002F5FC File Offset: 0x0002D7FC
		internal bool IsDownload
		{
			get
			{
				return (this.Flags & FtpMethodFlags.IsDownload) > FtpMethodFlags.None;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x0002F609 File Offset: 0x0002D809
		internal bool ShouldParseForResponseUri
		{
			get
			{
				return (this.Flags & FtpMethodFlags.ShouldParseForResponseUri) > FtpMethodFlags.None;
			}
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x0002F618 File Offset: 0x0002D818
		internal static FtpMethodInfo GetMethodInfo(string method)
		{
			method = method.ToUpper(CultureInfo.InvariantCulture);
			foreach (FtpMethodInfo ftpMethodInfo in FtpMethodInfo.s_knownMethodInfo)
			{
				if (method == ftpMethodInfo.Method)
				{
					return ftpMethodInfo;
				}
			}
			throw new ArgumentException("This method is not supported.", "method");
		}

		// Token: 0x040005E1 RID: 1505
		internal string Method;

		// Token: 0x040005E2 RID: 1506
		internal FtpOperation Operation;

		// Token: 0x040005E3 RID: 1507
		internal FtpMethodFlags Flags;

		// Token: 0x040005E4 RID: 1508
		internal string HttpCommand;

		// Token: 0x040005E5 RID: 1509
		private static readonly FtpMethodInfo[] s_knownMethodInfo = new FtpMethodInfo[]
		{
			new FtpMethodInfo("RETR", FtpOperation.DownloadFile, FtpMethodFlags.IsDownload | FtpMethodFlags.TakesParameter | FtpMethodFlags.HasHttpCommand, "GET"),
			new FtpMethodInfo("NLST", FtpOperation.ListDirectory, FtpMethodFlags.IsDownload | FtpMethodFlags.MayTakeParameter | FtpMethodFlags.HasHttpCommand | FtpMethodFlags.MustChangeWorkingDirectoryToPath, "GET"),
			new FtpMethodInfo("LIST", FtpOperation.ListDirectoryDetails, FtpMethodFlags.IsDownload | FtpMethodFlags.MayTakeParameter | FtpMethodFlags.HasHttpCommand | FtpMethodFlags.MustChangeWorkingDirectoryToPath, "GET"),
			new FtpMethodInfo("STOR", FtpOperation.UploadFile, FtpMethodFlags.IsUpload | FtpMethodFlags.TakesParameter, null),
			new FtpMethodInfo("STOU", FtpOperation.UploadFileUnique, FtpMethodFlags.IsUpload | FtpMethodFlags.DoesNotTakeParameter | FtpMethodFlags.ShouldParseForResponseUri | FtpMethodFlags.MustChangeWorkingDirectoryToPath, null),
			new FtpMethodInfo("APPE", FtpOperation.AppendFile, FtpMethodFlags.IsUpload | FtpMethodFlags.TakesParameter, null),
			new FtpMethodInfo("DELE", FtpOperation.DeleteFile, FtpMethodFlags.TakesParameter, null),
			new FtpMethodInfo("MDTM", FtpOperation.GetDateTimestamp, FtpMethodFlags.TakesParameter, null),
			new FtpMethodInfo("SIZE", FtpOperation.GetFileSize, FtpMethodFlags.TakesParameter, null),
			new FtpMethodInfo("RENAME", FtpOperation.Rename, FtpMethodFlags.TakesParameter, null),
			new FtpMethodInfo("MKD", FtpOperation.MakeDirectory, FtpMethodFlags.TakesParameter | FtpMethodFlags.ParameterIsDirectory, null),
			new FtpMethodInfo("RMD", FtpOperation.RemoveDirectory, FtpMethodFlags.TakesParameter | FtpMethodFlags.ParameterIsDirectory, null),
			new FtpMethodInfo("PWD", FtpOperation.PrintWorkingDirectory, FtpMethodFlags.DoesNotTakeParameter, null)
		};
	}
}
