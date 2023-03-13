using HttpClient client = new();
var json = await client.GetStringAsync(
         "http://online-live1.services.u-blox.com/GetOnlineData.ashx?token=WthGYmMETUOJEt1tQmnNZg;gnss=gps,glo;datatype=eph;");
Console.WriteLine(json);
Console.WriteLine("Length=" + json.Length);
