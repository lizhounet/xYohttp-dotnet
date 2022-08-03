

using xYohttp_dotnet.Http;

var http = new XyoHttpApi("http://120.24.193.212:10089/", "08da5d97-da10-498f-881f-4eb6f415f76a");
var dynamic = await http.GetFriendlistAsync("wxid_tqwjgv8ux9ka22");
Console.WriteLine(dynamic);
