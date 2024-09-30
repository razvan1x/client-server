# Description

This is a Windows Forms-based TCP Client-Server application built in C#. The client and server communicate over a TCP connection using the SuperSimpleTcp library. The application allows multiple clients to connect to the server and send/receive messages in real-time.

The server listens for client connections and displays incoming messages, while clients can connect to the server and exchange messages. Both sides update their respective interfaces with information about connections and message exchanges.

# Technologies Used

- C# (Windows Forms)
- SuperSimpleTcp library for TCP communication
- .NET 8.0

# How it works

### Server:
- Start Server: The server begins listening for client connections when the "Start" button is clicked.
- Client Connection: Once a client connects, the server updates the UI to show the connected client’s IP and port.
- Data Reception: Incoming messages from connected clients are displayed in the server’s text box.
- Send Message: The server can send messages to any connected client by selecting the client's IP from the list.

### Client:
- Connect to Server: The client can connect to the server by specifying the server’s IP and clicking the "Connect" button.
- Send Message: Once connected, the client can send messages to the server.
- Receive Message: The client can also receive and display messages from the server in real-time.

# IP Address and Port Usage

- IP Address: Specifies the address of the server you want to connect to. For local testing, you can use the IP address assigned to your machine by the router (e.g., 192.168.1.x).

- Port: A specific port number is used to identify the service on the server. For example, 192.168.1.x:1234 means the server is listening on IP 192.168.1.x (your machine's local IP) and port 1234.

# How it looks

![Screenshot 2024-09-30 175039](https://github.com/user-attachments/assets/cd57db73-48ef-4948-8d91-62a6d11d579c)
