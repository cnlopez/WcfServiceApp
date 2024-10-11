// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
string result = await client.GetDataAsync(5);
Console.WriteLine(result);
client.Close();
