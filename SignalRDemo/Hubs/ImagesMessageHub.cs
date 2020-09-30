﻿using System.Threading.Tasks;

using Microsoft.AspNetCore.SignalR;

using SignalRDemo.Model;

namespace SignalRDemo.Hubs
{
    public class ImagesMessageHub : Hub
    {
        public Task ImageMessage(ImageMessage file)
        {
            return Clients.All.SendAsync("ImageMessage", file);
        }

        //public ChannelReader<ImageMessage> ImageMessage(ImageMessage file)
        //{
        //    var channel = Channel.CreateUnbounded<ImageMessage>();

        //    _ = WriteToChannel(channel.Writer, file);

        //    return channel.Reader;

        //    async Task WriteToChannel(ChannelWriter<ImageMessage> writer, ImageMessage fileItem)
        //    {
        //        await writer.WriteAsync(fileItem);
        //        writer.Complete();
        //    }
        //}
    }
}