using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class SocketListener
{
	static public void Main()
	{
		Console.WriteLine("Starting simple echo server");
		StartServer();
	}	

	public static void StartServer()
	{
		IPHostEntry host = Dns.GetHostEntry("localhost");
		IPAddress ipAddress = host.AddressList[0];
		IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

		try {
			//create a socket
			Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			//use bind to endpoint.
			listener.Bind(localEndPoint);
			//how many requests till give server busy
			listener.Listen(10);
			Console.WriteLine("Waiting for connection....");
			
			Socket handler = listener.Accept();

			//incoming data from client.
			string data = null;
			byte[] bytes = null;

			while(true) 
			{
				bytes = new byte[1024];
				int bytesRec = handler.Receive(bytes);
				data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
				if(data.IndexOf("<EOF>") > -1)
				{
					break;
				}
			}
			Console.WriteLine("Text received: {0}",data);
			byte[] msg = Encoding.ASCII.GetBytes(data);
			handler.Send(msg);
			handler.Shutdown(SocketShutdown.Both);
			handler.Close();
		} catch(Exception e) {
			Console.WriteLine(e.ToString());
		}
		Console.WriteLine("Finished operation");

	}
}
