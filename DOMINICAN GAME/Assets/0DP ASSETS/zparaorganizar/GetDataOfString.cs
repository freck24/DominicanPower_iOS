using System;

// Token: 0x02000192 RID: 402
public static class GetDataOfString
{
	// Token: 0x0600088E RID: 2190 RVA: 0x000385B8 File Offset: 0x000367B8
	public static string GetData(string data, string index, string eliminador)
	{
		string text = data.Substring(data.IndexOf(index) + index.Length);
		if (text.Contains(eliminador))
		{
			text = text.Remove(text.IndexOf(eliminador));
		}
		return text;
	}
}
