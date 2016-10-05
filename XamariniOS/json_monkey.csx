using System.Net;
using Newtonsoft.Json;

public class Monkey
{
  public string Name { get; set; }
  public string Location { get; set; }
  public string Details { get; set; }
  public string Image { get; set; }
  public int Population { get; set; }
}

WebClient client = new WebClient();
var response = client.DownloadData ("https://raw.githubusercontent.com/jamesmontemagno/MonkeysApp-AppIndexing/master/MonkeysApp/monkeydata.json"); // GET
var json = System.Text.Encoding.UTF8.GetString(response);
var monkeys = JsonConvert.DeserializeObject<List<Monkey>>(json);
