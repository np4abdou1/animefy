using System;
using Android.Content;
using Android.Net;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.IO;

namespace Android.Database
{
	// Token: 0x02000244 RID: 580
	[Register("android/database/Cursor", "", "Android.Database.ICursorInvoker")]
	public interface ICursor : ICloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06001485 RID: 5253
		int ColumnCount { get; }

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06001486 RID: 5254
		int Count { get; }

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06001487 RID: 5255
		// (set) Token: 0x06001488 RID: 5256
		Bundle Extras { get; set; }

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06001489 RID: 5257
		bool IsAfterLast { get; }

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x0600148A RID: 5258
		bool IsBeforeFirst { get; }

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x0600148B RID: 5259
		bool IsClosed { get; }

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x0600148C RID: 5260
		bool IsFirst { get; }

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x0600148D RID: 5261
		bool IsLast { get; }

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x0600148E RID: 5262
		Android.Net.Uri NotificationUri { get; }

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x0600148F RID: 5263
		int Position { get; }

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06001490 RID: 5264
		bool WantsAllOnMoveCalls { get; }

		// Token: 0x06001491 RID: 5265
		void Close();

		// Token: 0x06001492 RID: 5266
		void CopyStringToBuffer(int columnIndex, CharArrayBuffer buffer);

		// Token: 0x06001493 RID: 5267
		void Deactivate();

		// Token: 0x06001494 RID: 5268
		byte[] GetBlob(int columnIndex);

		// Token: 0x06001495 RID: 5269
		int GetColumnIndex(string columnName);

		// Token: 0x06001496 RID: 5270
		int GetColumnIndexOrThrow(string columnName);

		// Token: 0x06001497 RID: 5271
		string GetColumnName(int columnIndex);

		// Token: 0x06001498 RID: 5272
		string[] GetColumnNames();

		// Token: 0x06001499 RID: 5273
		double GetDouble(int columnIndex);

		// Token: 0x0600149A RID: 5274
		float GetFloat(int columnIndex);

		// Token: 0x0600149B RID: 5275
		int GetInt(int columnIndex);

		// Token: 0x0600149C RID: 5276
		long GetLong(int columnIndex);

		// Token: 0x0600149D RID: 5277
		short GetShort(int columnIndex);

		// Token: 0x0600149E RID: 5278
		string GetString(int columnIndex);

		// Token: 0x0600149F RID: 5279
		[return: GeneratedEnum]
		FieldType GetType(int columnIndex);

		// Token: 0x060014A0 RID: 5280
		bool IsNull(int columnIndex);

		// Token: 0x060014A1 RID: 5281
		bool Move(int offset);

		// Token: 0x060014A2 RID: 5282
		bool MoveToFirst();

		// Token: 0x060014A3 RID: 5283
		bool MoveToLast();

		// Token: 0x060014A4 RID: 5284
		bool MoveToNext();

		// Token: 0x060014A5 RID: 5285
		bool MoveToPosition(int position);

		// Token: 0x060014A6 RID: 5286
		bool MoveToPrevious();

		// Token: 0x060014A7 RID: 5287
		void RegisterContentObserver(ContentObserver observer);

		// Token: 0x060014A8 RID: 5288
		void RegisterDataSetObserver(DataSetObserver observer);

		// Token: 0x060014A9 RID: 5289
		bool Requery();

		// Token: 0x060014AA RID: 5290
		Bundle Respond(Bundle extras);

		// Token: 0x060014AB RID: 5291
		void SetNotificationUri(ContentResolver cr, Android.Net.Uri uri);

		// Token: 0x060014AC RID: 5292
		void UnregisterContentObserver(ContentObserver observer);

		// Token: 0x060014AD RID: 5293
		void UnregisterDataSetObserver(DataSetObserver observer);
	}
}
