using System;
using System.Collections.Generic;
using System.IO;
using AQ.Models;
using SQLite;

namespace AQ.ViewModels
{
	// Token: 0x0200000E RID: 14
	public class UsersViewModel
	{
		// Token: 0x06000056 RID: 86 RVA: 0x00004F27 File Offset: 0x00003127
		public static void ProfilePrepareTable()
		{
			UsersViewModel.userDb.CreateTable<UsersModel>(CreateFlags.None);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004F38 File Offset: 0x00003138
		public static void SaveUser(UsersModel usr)
		{
			if (!UsersViewModel.IsUserExists(usr.UserID))
			{
				UsersModel usersModel = new UsersModel();
				usersModel.UserID = usr.UserID;
				usersModel.GoogleUserID = usr.GoogleUserID;
				usersModel.UserName = usr.UserName;
				usersModel.FullName = usr.FullName;
				usersModel.Password = usr.Password;
				usersModel.Email = usr.Email;
				usersModel.Bio = usr.Bio;
				usersModel.Gender = usr.Gender;
				usersModel.ProfileImage = usr.ProfileImage;
				usersModel.ProfileCover = usr.ProfileCover;
				usersModel.CommunicationStatus = usr.CommunicationStatus;
				usersModel.FeedbackStatus = usr.FeedbackStatus;
				usersModel.Membership = usr.Membership;
				usersModel.AllowLibraryView = usr.AllowLibraryView;
				usersModel.GoogleProfilePhotoUrl = usr.GoogleProfilePhotoUrl;
				usersModel.IsActivated = usr.IsActivated;
				UsersViewModel.userDb.Insert(usersModel);
				return;
			}
			UsersModel usersModel2 = UsersViewModel.userDb.FindWithQuery<UsersModel>("SELECT * FROM UserProfile WHERE UserID = ?", new object[]
			{
				usr.UserID
			});
			usersModel2.UserID = usr.UserID;
			usersModel2.GoogleUserID = usr.GoogleUserID;
			usersModel2.UserName = usr.UserName;
			usersModel2.FullName = usr.FullName;
			usersModel2.Password = usr.Password;
			usersModel2.Email = usr.Email;
			usersModel2.Bio = usr.Bio;
			usersModel2.Gender = usr.Gender;
			usersModel2.ProfileImage = usr.ProfileImage;
			usersModel2.ProfileCover = usr.ProfileCover;
			usersModel2.CommunicationStatus = usr.CommunicationStatus;
			usersModel2.FeedbackStatus = usr.FeedbackStatus;
			usersModel2.Membership = usr.Membership;
			usersModel2.AllowLibraryView = usr.AllowLibraryView;
			usersModel2.GoogleProfilePhotoUrl = usr.GoogleProfilePhotoUrl;
			usersModel2.IsActivated = usr.IsActivated;
			UsersViewModel.userDb.Update(usersModel2);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00005118 File Offset: 0x00003318
		public static UsersModel GetUserProfile()
		{
			UsersModel usersModel = UsersViewModel.userDb.FindWithQuery<UsersModel>("SELECT * FROM UserProfile LIMIT 1", Array.Empty<object>());
			if (usersModel != null)
			{
				return usersModel;
			}
			return null;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00005140 File Offset: 0x00003340
		public static int GetUserId()
		{
			UsersModel usersModel = UsersViewModel.userDb.FindWithQuery<UsersModel>("SELECT * FROM UserProfile LIMIT 1", Array.Empty<object>());
			if (usersModel != null)
			{
				return usersModel.UserID;
			}
			return 0;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00005170 File Offset: 0x00003370
		public static bool IsUserExists(int userID)
		{
			List<UsersModel> list = UsersViewModel.userDb.Query<UsersModel>("SELECT * FROM UserProfile WHERE UserID = ?", new object[]
			{
				userID
			});
			return list.Count > 0;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000051A8 File Offset: 0x000033A8
		public static void ClearUsers()
		{
			UsersViewModel.userDb.Query<UsersModel>("DELETE FROM UserProfile", Array.Empty<object>());
		}

		// Token: 0x0400007E RID: 126
		public static string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "AnimeifySchema.db3");

		// Token: 0x0400007F RID: 127
		public static SQLiteConnection userDb = new SQLiteConnection(UsersViewModel.dbPath, true);
	}
}
