

using xYohttp_dotnet.Http;

var http = new XyoHttpApi("http://127.0.0.1:10086", "99999999999999999");
dynamic dynamic = await http.SendTextMsgAsync("wxid_eu05e13ld28822", "wxid_eu05e13ld28822", "hahahh");
Console.WriteLine(dynamic);
