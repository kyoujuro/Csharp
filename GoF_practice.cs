using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using TestForm.Properties;

namespace TestForm
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ClassDelived cd = new ClassDelived(10, 20);
            Console.WriteLine(cd.x1);
            Console.WriteLine(cd.y1);
            Console.WriteLine(cd.x2);
            Console.WriteLine(cd.y2);
            var messages = new List<IMessage>
            {
                new NormalDecorator(new SimpleMessage("First")),
                new NormalDecorator(new AlertMessage("Second")),
                new ErrorDecorator(new AlertMessage("red")),
                new SimpleMessage("Not")
            };
            foreach (var message in messages)
            {
                message.PrintMessage();
            }
            Console.Read();
          
        }

        interface IMessage
        {
            void PrintMessage();
        }

        class SimpleMessage : Message
        {
            public SimpleMessage(string text) : base(text) { }

            public override void PrintMessage()
            {
                Console.WriteLine(_text);
            }
        }

        class AlertMessage : Message
        {
            public AlertMessage(string text) : base(text) { }
            public override void PrintMessage()
            {
                Console.Beep();
                Console.WriteLine(_text);
            }
        }
        abstract class Message : IMessage
        {
            protected string _text;
            public Message(string text)
            {
                _text = text;
            }
            abstract public void PrintMessage();
        }
        abstract class MessageDecorator : IMessage
        {
            protected Message _message;
            public MessageDecorator(Message message)
            {
                _message = message;
            }

            public abstract void PrintMessage();
        }

        class NormalDecorator : MessageDecorator
        {
            public NormalDecorator(Message message) : base(message) { }
            public override void PrintMessage()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                _message.PrintMessage();
                Console.ForegroundColor = ConsoleColor.White;

            }

        }

        class ErrorDecorator : MessageDecorator
        {
            public ErrorDecorator(Message message) : base(message) { }
            public override void PrintMessage()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                _message.PrintMessage();
                Console.ForegroundColor = ConsoleColor.White;

            }
        }
        class ClassBase
        { 
        public int x1, y1;
     public ClassBase(int x, int y)
      {
       x1 = x;
       y1 = y;
     }
   }
   class ClassDelived : ClassBase
   {
     public int x2, y2;
     public ClassDelived(int x, int y) : base(x, y)
     {
           x2 = x+1;
           y2 = y+1;
         }
   }
    }

    [Flags]
    enum ServiceRequirements
    {
        None = 0,
        WheelAlignment = 1,
        Dirty = 2,
        EngineTune = 4,
        TestDrive = 8
    }


   

}
