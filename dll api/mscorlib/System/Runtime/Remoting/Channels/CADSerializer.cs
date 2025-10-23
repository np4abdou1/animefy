using System;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x02000343 RID: 835
	internal class CADSerializer
	{
		// Token: 0x06001AE3 RID: 6883 RVA: 0x00074D88 File Offset: 0x00072F88
		internal static IMessage DeserializeMessage(MemoryStream mem, IMethodCallMessage msg)
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			binaryFormatter.SurrogateSelector = null;
			mem.Position = 0L;
			if (msg == null)
			{
				return (IMessage)binaryFormatter.Deserialize(mem, null);
			}
			return (IMessage)binaryFormatter.DeserializeMethodResponse(mem, null, msg);
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x00074DCC File Offset: 0x00072FCC
		internal static MemoryStream SerializeMessage(IMessage msg)
		{
			MemoryStream memoryStream = new MemoryStream();
			new BinaryFormatter
			{
				SurrogateSelector = new RemotingSurrogateSelector()
			}.Serialize(memoryStream, msg);
			memoryStream.Position = 0L;
			return memoryStream;
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x00074E00 File Offset: 0x00073000
		internal static object DeserializeObjectSafe(byte[] mem)
		{
			byte[] array = new byte[mem.Length];
			Array.Copy(mem, array, mem.Length);
			return CADSerializer.DeserializeObject(new MemoryStream(array));
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x00074E2C File Offset: 0x0007302C
		internal static MemoryStream SerializeObject(object obj)
		{
			MemoryStream memoryStream = new MemoryStream();
			new BinaryFormatter
			{
				SurrogateSelector = new RemotingSurrogateSelector()
			}.Serialize(memoryStream, obj);
			memoryStream.Position = 0L;
			return memoryStream;
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x00074E5F File Offset: 0x0007305F
		internal static object DeserializeObject(MemoryStream mem)
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			binaryFormatter.SurrogateSelector = null;
			mem.Position = 0L;
			return binaryFormatter.Deserialize(mem);
		}
	}
}
