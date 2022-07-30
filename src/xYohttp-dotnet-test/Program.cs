

using xYohttp_dotnet.Http;

var http = new XyoHttpApi("http://127.0.0.1:10086", "08da5d97-da10-498f-881f-4eb6f415f76a");
string dynamic = await http.StartWeChatAsync();
Console.WriteLine(dynamic);
