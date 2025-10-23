using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace System
{
	// Token: 0x02000184 RID: 388
	internal sealed class AndroidTzData : IAndroidTimeZoneDB
	{
		// Token: 0x06000F34 RID: 3892 RVA: 0x0003F9FC File Offset: 0x0003DBFC
		public AndroidTzData(params string[] paths)
		{
			foreach (string path in paths)
			{
				if (this.LoadData(path))
				{
					this.tzdataPath = path;
					return;
				}
			}
			Console.Error.WriteLine("Couldn't find any tzdata!");
			this.tzdataPath = "/";
			this.version = "missing";
			this.zoneTab = "# Emergency fallback data.\n";
			this.ids = new string[]
			{
				"GMT"
			};
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x0003FA78 File Offset: 0x0003DC78
		private static string GetApexTimeDataRoot()
		{
			string environmentVariable = Environment.GetEnvironmentVariable("ANDROID_TZDATA_ROOT");
			if (!string.IsNullOrEmpty(environmentVariable))
			{
				return environmentVariable;
			}
			return "/apex/com.android.tzdata";
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x0003FAA0 File Offset: 0x0003DCA0
		private static string GetApexRuntimeRoot()
		{
			string environmentVariable = Environment.GetEnvironmentVariable("ANDROID_RUNTIME_ROOT");
			if (!string.IsNullOrEmpty(environmentVariable))
			{
				return environmentVariable;
			}
			return "/apex/com.android.runtime";
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x0003FAC8 File Offset: 0x0003DCC8
		private bool LoadData(string path)
		{
			if (!File.Exists(path))
			{
				return false;
			}
			try
			{
				this.data = File.OpenRead(path);
			}
			catch (IOException)
			{
				return false;
			}
			catch (UnauthorizedAccessException)
			{
				return false;
			}
			try
			{
				this.ReadHeader();
				return true;
			}
			catch (Exception arg)
			{
				Console.Error.WriteLine("tzdata file \"{0}\" was present but invalid: {1}", path, arg);
			}
			return false;
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x0003FB44 File Offset: 0x0003DD44
		private unsafe void ReadHeader()
		{
			byte[] buffer = new byte[Math.Max(Marshal.SizeOf(typeof(AndroidTzDataHeader)), Marshal.SizeOf(typeof(AndroidTzDataEntry)))];
			AndroidTzDataHeader androidTzDataHeader = this.ReadAt<AndroidTzDataHeader>(0L, buffer);
			androidTzDataHeader.indexOffset = AndroidTzData.NetworkToHostOrder(androidTzDataHeader.indexOffset);
			androidTzDataHeader.dataOffset = AndroidTzData.NetworkToHostOrder(androidTzDataHeader.dataOffset);
			androidTzDataHeader.zoneTabOffset = AndroidTzData.NetworkToHostOrder(androidTzDataHeader.zoneTabOffset);
			sbyte* ptr = (sbyte*)(&androidTzDataHeader.signature.FixedElementField);
			if (new string(ptr, 0, 6, Encoding.ASCII) != "tzdata" || *(ref androidTzDataHeader.signature.FixedElementField + 11) != 0)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("bad tzdata magic:");
				for (int i = 0; i < 12; i++)
				{
					stringBuilder.Append(" ").Append(((byte)ptr[i]).ToString("x2"));
				}
				throw new InvalidOperationException("bad tzdata magic: " + stringBuilder.ToString());
			}
			this.version = new string(ptr, 6, 5, Encoding.ASCII);
			this.ReadIndex(androidTzDataHeader.indexOffset, androidTzDataHeader.dataOffset, buffer);
			this.ReadZoneTab(androidTzDataHeader.zoneTabOffset, checked((int)this.data.Length) - androidTzDataHeader.zoneTabOffset);
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x0003FC98 File Offset: 0x0003DE98
		private unsafe T ReadAt<T>(long position, byte[] buffer) where T : struct
		{
			int num = Marshal.SizeOf(typeof(T));
			if (buffer.Length < num)
			{
				throw new InvalidOperationException("Internal error: buffer too small");
			}
			this.data.Position = position;
			int num2;
			if ((num2 = this.data.Read(buffer, 0, num)) < num)
			{
				throw new InvalidOperationException(string.Format("Error reading '{0}': read {1} bytes, expected {2}", this.tzdataPath, num2, num));
			}
			byte* value;
			if (buffer == null || buffer.Length == 0)
			{
				value = null;
			}
			else
			{
				value = &buffer[0];
			}
			return (T)((object)Marshal.PtrToStructure((IntPtr)((void*)value), typeof(T)));
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x0003FD39 File Offset: 0x0003DF39
		private static int NetworkToHostOrder(int value)
		{
			if (!BitConverter.IsLittleEndian)
			{
				return value;
			}
			return (value >> 24 & 255) | (value >> 8 & 65280) | (value << 8 & 16711680) | value << 24;
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x0003FD68 File Offset: 0x0003DF68
		private unsafe void ReadIndex(int indexOffset, int dataOffset, byte[] buffer)
		{
			int num = (dataOffset - indexOffset) / Marshal.SizeOf(typeof(AndroidTzDataEntry));
			int num2 = Marshal.SizeOf(typeof(AndroidTzDataEntry));
			this.byteOffsets = new int[num];
			this.ids = new string[num];
			this.lengths = new int[num];
			for (int i = 0; i < num; i++)
			{
				AndroidTzDataEntry androidTzDataEntry = this.ReadAt<AndroidTzDataEntry>((long)(indexOffset + num2 * i), buffer);
				sbyte* ptr = (sbyte*)(&androidTzDataEntry.id.FixedElementField);
				this.byteOffsets[i] = AndroidTzData.NetworkToHostOrder(androidTzDataEntry.byteOffset) + dataOffset;
				this.ids[i] = new string(ptr, 0, AndroidTzData.GetStringLength(ptr, 40), Encoding.ASCII);
				this.lengths[i] = AndroidTzData.NetworkToHostOrder(androidTzDataEntry.length);
				if (this.lengths[i] < Marshal.SizeOf(typeof(AndroidTzDataHeader)))
				{
					throw new InvalidOperationException("Length in index file < sizeof(tzhead)");
				}
			}
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x0003FE58 File Offset: 0x0003E058
		private unsafe static int GetStringLength(sbyte* s, int maxLength)
		{
			int num = 0;
			while (num < maxLength && *s != 0)
			{
				num++;
				s++;
			}
			return num;
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x0003FE7C File Offset: 0x0003E07C
		private void ReadZoneTab(int zoneTabOffset, int zoneTabSize)
		{
			byte[] array = new byte[zoneTabSize];
			this.data.Position = (long)zoneTabOffset;
			int num;
			if ((num = this.data.Read(array, 0, array.Length)) < array.Length)
			{
				throw new InvalidOperationException(string.Format("Error reading zonetab: read {0} bytes, expected {1}", num, zoneTabSize));
			}
			this.zoneTab = Encoding.ASCII.GetString(array, 0, array.Length);
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x0003FEE8 File Offset: 0x0003E0E8
		public byte[] GetTimeZoneData(string id)
		{
			int num = Array.BinarySearch<string>(this.ids, id, StringComparer.Ordinal);
			if (num < 0)
			{
				return null;
			}
			int num2 = this.byteOffsets[num];
			int num3 = this.lengths[num];
			byte[] array = new byte[num3];
			Stream obj = this.data;
			lock (obj)
			{
				this.data.Position = (long)num2;
				int num4;
				if ((num4 = this.data.Read(array, 0, array.Length)) < array.Length)
				{
					throw new InvalidOperationException(string.Format("Unable to fully read from file '{0}' at offset {1} length {2}; read {3} bytes expected {4}.", new object[]
					{
						this.tzdataPath,
						num2,
						num3,
						num4,
						array.Length
					}));
				}
			}
			TimeZoneInfo.DumpTimeZoneDataToFile(id, array);
			return array;
		}

		// Token: 0x040005BD RID: 1469
		internal static readonly string[] Paths = new string[]
		{
			AndroidTzData.GetApexTimeDataRoot() + "/etc/tz/tzdata",
			AndroidTzData.GetApexRuntimeRoot() + "/etc/tz/tzdata",
			Environment.GetEnvironmentVariable("ANDROID_DATA") + "/misc/zoneinfo/tzdata",
			Environment.GetEnvironmentVariable("ANDROID_ROOT") + "/usr/share/zoneinfo/tzdata"
		};

		// Token: 0x040005BE RID: 1470
		private string tzdataPath;

		// Token: 0x040005BF RID: 1471
		private Stream data;

		// Token: 0x040005C0 RID: 1472
		private string version;

		// Token: 0x040005C1 RID: 1473
		private string zoneTab;

		// Token: 0x040005C2 RID: 1474
		private string[] ids;

		// Token: 0x040005C3 RID: 1475
		private int[] byteOffsets;

		// Token: 0x040005C4 RID: 1476
		private int[] lengths;
	}
}
