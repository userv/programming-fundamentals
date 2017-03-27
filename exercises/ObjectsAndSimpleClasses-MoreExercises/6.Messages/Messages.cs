using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Messages
{
    public class Messages
    {
        public class User
        {
            public string Username { get; set; }
            public List<Message> ReceivedMessages = new List<Message>();

        }
        public class Message
        {
            public string Content { get; set; }
            public User Sender { get; set; }
        }

        public static void SendMessage(List<User> registredUsers, string senderUsername, string recipientUsername, string content)
        {
            Message newMessage = new Message()
            {
                Content = content,
                Sender = new User { Username = senderUsername }
            };

            var user = registredUsers.Where(r => r.Username == recipientUsername)
                .FirstOrDefault();
            if (user != null)
            {
                registredUsers.Where(r => r.Username == recipientUsername)
                    .FirstOrDefault()
                    .ReceivedMessages.Add(newMessage);
            }
        }
        public static void Main()
        {
            List<User> registredUsers = new List<User>();
            string inputLine = Console.ReadLine();
            while (inputLine != "exit")
            {
                string[] tokens = inputLine.Split(' ').ToArray();
                //   string command = tokens[0];
                if (tokens.Length < 4)
                {
                    if (tokens[0] == "register")
                    {
                        registredUsers.Add(new User() { Username = tokens[1] });
                    }
                }
                else if (tokens.Length == 4)
                {
                    string senderUsername = tokens[0];
                    string recipientUsername = tokens[2];
                    string content = tokens[3];
                    SendMessage(registredUsers, senderUsername, recipientUsername, content);
                }
                inputLine = Console.ReadLine();
            }
            string[] users = Console.ReadLine().Split(' ').ToArray();
            var user1Msg =
                registredUsers.Where(username => username.Username == users[0]).FirstOrDefault();
                    
            var user2Msg = registredUsers.Where(username => username.Username == users[1]).FirstOrDefault();
            
            var msg1 = user1Msg.ReceivedMessages.Where(sender => sender.Sender.Username == users[1]).ToArray();
            var msg2 = user2Msg.ReceivedMessages.Where(sender => sender.Sender.Username == users[0]).ToArray();
            if (msg1.Length < 1 && msg2.Length<1)
            {
                Console.WriteLine("No messages");
                return;
            }
            int numberOfMessages=0;
           if (msg1.Length> msg2.Length)
            {
                numberOfMessages = msg1.Length;
            }
            else
            {
                numberOfMessages = msg2.Length;
            }
            
            for (int i = 0; i <numberOfMessages; i++)
            {
                if (msg2.Length > i)
                {
                    Console.WriteLine($"{user1Msg.Username}: {msg2[i].Content}");
                   
                }
                if (msg1.Length > i)
                {
                    Console.WriteLine($"{msg1[i].Content} :{user2Msg.Username}");
                  
                }
                
               
            }
                
        }
    }
}
