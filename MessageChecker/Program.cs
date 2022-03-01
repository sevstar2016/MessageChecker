
using TLSchema;
using TLSchema.Messages;
using TLSharp;

var session = new FileSessionStore();
var client = new TelegramClient(7104260, "5168d523b6957d158b6b6928221b10c6", session, "79126837010");
await client.ConnectAsync();

var dialogs = (TLDialogsSlice)await client.GetUserDialogsAsync();
var chat = dialogs.Chats
    .Where(c => c.GetType() == typeof(TLChat))
    .Cast<TLChat>();

foreach (var channel in chat)
{
    Console.WriteLine(channel.Id + "\t" + channel.Title);
}

    