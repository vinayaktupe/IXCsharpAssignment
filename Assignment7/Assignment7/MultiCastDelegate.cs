using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7
{
    public class MultiCastDelegate
    {
        public delegate void ConversationDel(string Msg);

        public MultiCastDelegate()
        {
            ConversationDel del1,del2,del3;
            del1 = new ConversationDel(Hello);
            del2 = new ConversationDel(Bye);
            del3 = new ConversationDel(Hello);
            del1 += del2;
            del1 += del3;

            del1("John");

            del1 -= del3;
            del1("John");
            
        }

        public static void Hello(string Message)
        {
            Console.WriteLine($"Hello! {Message}");
        }
        public static void Bye(string Message)
        {
            Console.WriteLine($"Bye! {Message}");
        }

    }
}
