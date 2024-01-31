
<p align="center">
  <img src="XSSocket/XSSocket.png"
        style="display: block; margin: 0 auto"/>

</p>

## Features
XSSocket is an XSOverlay API connector for .Net. It allows you to connect to the XSOverlay API and send and receive data. 
* Send and receive data to the XSOverlay API
* Events for connection status and data received
* Enhanced object classes for ease-of-use
* Fully supports XSOverlay WebSocket API 

## Usage
```csharp    
public static async Task Main(string[] args)
{
    XSSocket connector = new XSSocket("Demo"); // create a new connector with the source app name "Demo"
    connector.ConnectAsync().ConfigureAwait(false);
    while (connector.State == WebSocketState.Connecting)
    {
        Console.WriteLine("Connecting...");
        await Task.Delay(1000); // wait 1 second
    }
    
    if (connector.State == WebSocketState.Open)
    {
        Console.WriteLine("Connected!");
    }
    else
    {
        Console.WriteLine($"Connection failed with state: {connector.State}");
    }

    Console.WriteLine("Sending Notification...");
    
    
    XSNotificationObject notificationObject =
        new XSNotificationObject()
        {
            title = "Hello World",
            content = "This is a test notificationObject",
            sourceApp = "Demo"
        };
    await connector.SendNotification(notificationObject);
    await Task.Delay(1000); // wait 1 second
    
    
    Console.WriteLine("Disconnecting...");

    connector.Disconnect();
}

```

## Demo
The demo project is a simple console application that connects to the XSOverlay API and demonstrates how to utilize various features of the connectors and the API.


## Discord
For questions on XSOverlay or the API, you may join the [Discord](https://discord.gg/WZm9H2BJU6) server for discussion or read the [documentation](https://xsoverlay.vercel.app/).
