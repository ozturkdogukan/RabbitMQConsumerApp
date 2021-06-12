using System;

namespace RabbitMQSample
{
    class Program
    {
        private static readonly string _queueName = "DOGUKANOZTURK";
        private static Consumer _consumer;

        static void Main(string[] args)
        {
            _consumer = new Consumer(_queueName);
        }
    }
}