using System;

namespace System.Net
{
	/// <summary>Specifies the status codes returned for a File Transfer Protocol (FTP) operation.</summary>
	// Token: 0x0200014D RID: 333
	public enum FtpStatusCode
	{
		/// <summary>Included for completeness, this value is never returned by servers.</summary>
		// Token: 0x0400068B RID: 1675
		Undefined,
		/// <summary>Specifies that the response contains a restart marker reply. The text of the description that accompanies this status contains the user data stream marker and the server marker.</summary>
		// Token: 0x0400068C RID: 1676
		RestartMarker = 110,
		/// <summary>Specifies that the service is not available now; try your request later.</summary>
		// Token: 0x0400068D RID: 1677
		ServiceTemporarilyNotAvailable = 120,
		/// <summary>Specifies that the data connection is already open and the requested transfer is starting.</summary>
		// Token: 0x0400068E RID: 1678
		DataAlreadyOpen = 125,
		/// <summary>Specifies that the server is opening the data connection.</summary>
		// Token: 0x0400068F RID: 1679
		OpeningData = 150,
		/// <summary>Specifies that the command completed successfully.</summary>
		// Token: 0x04000690 RID: 1680
		CommandOK = 200,
		/// <summary>Specifies that the command is not implemented by the server because it is not needed.</summary>
		// Token: 0x04000691 RID: 1681
		CommandExtraneous = 202,
		/// <summary>Specifies the status of a directory.</summary>
		// Token: 0x04000692 RID: 1682
		DirectoryStatus = 212,
		/// <summary>Specifies the status of a file.</summary>
		// Token: 0x04000693 RID: 1683
		FileStatus,
		/// <summary>Specifies the system type name using the system names published in the Assigned Numbers document published by the Internet Assigned Numbers Authority.</summary>
		// Token: 0x04000694 RID: 1684
		SystemType = 215,
		/// <summary>Specifies that the server is ready for a user login operation.</summary>
		// Token: 0x04000695 RID: 1685
		SendUserCommand = 220,
		/// <summary>Specifies that the server is closing the control connection.</summary>
		// Token: 0x04000696 RID: 1686
		ClosingControl,
		/// <summary>Specifies that the server is closing the data connection and that the requested file action was successful.</summary>
		// Token: 0x04000697 RID: 1687
		ClosingData = 226,
		/// <summary>Specifies that the server is entering passive mode.</summary>
		// Token: 0x04000698 RID: 1688
		EnteringPassive,
		/// <summary>Specifies that the user is logged in and can send commands.</summary>
		// Token: 0x04000699 RID: 1689
		LoggedInProceed = 230,
		/// <summary>Specifies that the server accepts the authentication mechanism specified by the client, and the exchange of security data is complete.</summary>
		// Token: 0x0400069A RID: 1690
		ServerWantsSecureSession = 234,
		/// <summary>Specifies that the requested file action completed successfully.</summary>
		// Token: 0x0400069B RID: 1691
		FileActionOK = 250,
		/// <summary>Specifies that the requested path name was created.</summary>
		// Token: 0x0400069C RID: 1692
		PathnameCreated = 257,
		/// <summary>Specifies that the server expects a password to be supplied.</summary>
		// Token: 0x0400069D RID: 1693
		SendPasswordCommand = 331,
		/// <summary>Specifies that the server requires a login account to be supplied.</summary>
		// Token: 0x0400069E RID: 1694
		NeedLoginAccount,
		/// <summary>Specifies that the requested file action requires additional information.</summary>
		// Token: 0x0400069F RID: 1695
		FileCommandPending = 350,
		/// <summary>Specifies that the service is not available.</summary>
		// Token: 0x040006A0 RID: 1696
		ServiceNotAvailable = 421,
		/// <summary>Specifies that the data connection cannot be opened.</summary>
		// Token: 0x040006A1 RID: 1697
		CantOpenData = 425,
		/// <summary>Specifies that the connection has been closed.</summary>
		// Token: 0x040006A2 RID: 1698
		ConnectionClosed,
		/// <summary>Specifies that the requested action cannot be performed on the specified file because the file is not available or is being used.</summary>
		// Token: 0x040006A3 RID: 1699
		ActionNotTakenFileUnavailableOrBusy = 450,
		/// <summary>Specifies that an error occurred that prevented the request action from completing.</summary>
		// Token: 0x040006A4 RID: 1700
		ActionAbortedLocalProcessingError,
		/// <summary>Specifies that the requested action cannot be performed because there is not enough space on the server.</summary>
		// Token: 0x040006A5 RID: 1701
		ActionNotTakenInsufficientSpace,
		/// <summary>Specifies that the command has a syntax error or is not a command recognized by the server.</summary>
		// Token: 0x040006A6 RID: 1702
		CommandSyntaxError = 500,
		/// <summary>Specifies that one or more command arguments has a syntax error.</summary>
		// Token: 0x040006A7 RID: 1703
		ArgumentSyntaxError,
		/// <summary>Specifies that the command is not implemented by the FTP server.</summary>
		// Token: 0x040006A8 RID: 1704
		CommandNotImplemented,
		/// <summary>Specifies that the sequence of commands is not in the correct order.</summary>
		// Token: 0x040006A9 RID: 1705
		BadCommandSequence,
		/// <summary>Specifies that login information must be sent to the server.</summary>
		// Token: 0x040006AA RID: 1706
		NotLoggedIn = 530,
		/// <summary>Specifies that a user account on the server is required.</summary>
		// Token: 0x040006AB RID: 1707
		AccountNeeded = 532,
		/// <summary>Specifies that the requested action cannot be performed on the specified file because the file is not available.</summary>
		// Token: 0x040006AC RID: 1708
		ActionNotTakenFileUnavailable = 550,
		/// <summary>Specifies that the requested action cannot be taken because the specified page type is unknown. Page types are described in RFC 959 Section 3.1.2.3</summary>
		// Token: 0x040006AD RID: 1709
		ActionAbortedUnknownPageType,
		/// <summary>Specifies that the requested action cannot be performed.</summary>
		// Token: 0x040006AE RID: 1710
		FileActionAborted,
		/// <summary>Specifies that the requested action cannot be performed on the specified file.</summary>
		// Token: 0x040006AF RID: 1711
		ActionNotTakenFilenameNotAllowed
	}
}
