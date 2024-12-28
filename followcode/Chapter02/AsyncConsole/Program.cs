//#error version



HttpClient client = new();

HttpResponseMessage response = await client.GetAsync("https://www.apple.com");

Console.WriteLine($"Status code: {response.StatusCode}");
Console.WriteLine("Apple page has {0:N0} bytes", response.Content.Headers.ContentLength);


//throw new Exception();