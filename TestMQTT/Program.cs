﻿using HiveMQtt.Client;
using HiveMQtt.Client.Options;
using HiveMQtt.MQTT5.ReasonCodes;
using HiveMQtt.MQTT5.Types;
using System.Text.Json;

var options = new HiveMQClientOptions
{
    Host = "6f22b3baab2b42cdbb9a22efb15eccbc.s2.eu.hivemq.cloud",
    Port = 8883,
    UseTLS = true,
    UserName = "Backend",
    Password = "Pa55w.rd",
};

var client = new HiveMQClient(options);

Console.WriteLine($"Connecting to {options.Host} on port {options.Port} ...");

// Connect
HiveMQtt.Client.Results.ConnectResult connectResult;
try
{
    connectResult = await client.ConnectAsync().ConfigureAwait(false);
    if (connectResult.ReasonCode == ConnAckReasonCode.Success)
    {
        Console.WriteLine($"Connect successful: {connectResult}");
    }
    else
    {
        // FIXME: Add ToString
        Console.WriteLine($"Connect failed: {connectResult}");
        Environment.Exit(-1);
    }
}
catch (System.Net.Sockets.SocketException e)
{
    Console.WriteLine($"Error connecting to the MQTT Broker with the following socket error: {e.Message}");
    Environment.Exit(-1);
}
catch (Exception e)
{
    Console.WriteLine($"Error connecting to the MQTT Broker with the following message: {e.Message}");
    Environment.Exit(-1);
}

// Message Handler
client.OnMessageReceived += (sender, args) =>
{
    string received_message = args.PublishMessage.PayloadAsString;
    Console.WriteLine(received_message);

};

// Subscribe
while (true) { await client.SubscribeAsync("#").ConfigureAwait(false); }

//await client.SubscribeAsync("Test").ConfigureAwait(false);

//while (true) { }