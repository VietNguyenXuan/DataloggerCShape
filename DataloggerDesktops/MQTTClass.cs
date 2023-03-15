using MQTTnet.Client;
using MQTTnet.Protocol;
using MQTTnet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MQTTChanel
{
  public delegate Task MqttPayloadReceive(string data);
  public partial class MQTTClass //: MetroFramework.Forms.MetroForm
  {
    //MQTT Inital
    private string topic = "/vule/projects/datalogger/stations/shiratechPoE/monitor";
    private IMqttClient client;
    private MqttClientOptions clientOptions;

    public event MqttPayloadReceive OnMqttPayloadReceive;
    // Settinh dress & port
    //string BrokerAddress = "ismaillowkey.my.id";
    string BrokerAddress = "113.161.93.162";
    int BrokerPort = 1883;
    public MQTTClass()
    {
      //topic=Properties
    }


    //MQTT
    public async void Connect()
    {
      //use a unique id as client id, each time we start the application
      var clientId = Guid.NewGuid().ToString();

      var factory = new MqttFactory();
      client = factory.CreateMqttClient();
      clientOptions = new MqttClientOptionsBuilder()
          .WithTcpServer(BrokerAddress, BrokerPort) // Port is optional
          .WithClientId(clientId)
          .Build();

      client.ConnectedAsync += Client_ConnectedAsync;
      client.ConnectingAsync += Client_ConnectingAsync;
      client.DisconnectedAsync += Client_DisconnectedAsync;
      client.ApplicationMessageReceivedAsync += Client_ApplicationMessageReceivedAsync;

      await client.ConnectAsync(clientOptions, CancellationToken.None);

      //MessageBox.Show("Connect Sucsess");
    }
    private Task Client_ApplicationMessageReceivedAsync(MqttApplicationMessageReceivedEventArgs arg)
    {
      //get payload
      string ReceivedMessage = Encoding.UTF8.GetString(arg.ApplicationMessage.Payload);

      //get topic name
      string TopicReceived = arg.ApplicationMessage.Topic;

      //Show message
      //ShowMessageRT(ReceivedMessage, TopicReceived);

      OnMqttPayloadReceive?.Invoke(ReceivedMessage);
      return Task.CompletedTask;
    }

    //Disconnect
    private async Task Client_DisconnectedAsync(MqttClientDisconnectedEventArgs arg)
    {
      await Task.Delay(TimeSpan.FromSeconds(3));
      await client.ConnectAsync(clientOptions, CancellationToken.None);
      await Task.CompletedTask;
    }

    //Connecting
    private async Task Client_ConnectingAsync(MqttClientConnectingEventArgs arg)
    {
      await Task.CompletedTask;
    }

    //Connected
    private async Task Client_ConnectedAsync(MqttClientConnectedEventArgs arg)
    {
      // khi đã connect => đăng kí đến topic để nhận payload
      subcribe(topic);
    }


    public async void publish(string topic, string payload)
    {
      try
      {
        var message = new MqttApplicationMessageBuilder()
            .WithTopic(topic.Trim())
            .WithPayload(payload)
            .WithQualityOfServiceLevel(MqttQualityOfServiceLevel.AtLeastOnce)
            .WithRetainFlag()
            .Build();
        await client.PublishAsync(message, CancellationToken.None);
      }
      catch (Exception ex)
      {
        //MessageBox.Show(ex.Message);
        MessageBox.Show("Err public");
      }
    }

    public async void subcribe(string topic)
    {
      try
      {
        var topic_sub = new MqttTopicFilterBuilder()
            .WithTopic(topic)
            .WithAtMostOnceQoS()
            .Build();

        await client.SubscribeAsync(topic_sub);
      }
      catch (Exception ex)
      {
        //MessageBox.Show(ex.Message);
        MessageBox.Show("Err sub");
      }
    }
  }
}