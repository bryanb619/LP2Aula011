using System;
using System.Threading;
using System.Collections.Concurrent;

namespace InputSystem
{
    public class Program
    {
        // Coleção thread-safe, usa internamente uma Queue (primeira tecla a
        // entrar é a primeira a sair)
        //--> Declarar coleção thread-safe aqui
        private static BlockingCollection<ConsoleKeyInfo> channel;

        private static void Main()
        {
            Thread producer = new Thread(ReadKeys);
            Thread consumer = new Thread(ShowKeyOnScreen);

            //--> Inicializar coleção thread-safe aqui
            channel = new BlockingCollection<ConsoleKeyInfo>();

            Console.WriteLine("Podes começar a carregar nas teclas");

            //--> Código para começar execução das threads aqui
            producer.Start();
            consumer.Start();

            //--> Código para esperar que as threads terminem aqui
            producer.Join();
            consumer.Join();

            Console.WriteLine("Obrigado!");
        }

        // Método produtor:
        // Lé as teclas do teclado e coloca-as na fila
        private static void ReadKeys()
        {
            //--> Completa este código
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey();

                channel.Add(key);
            } 
            while(key.Key != ConsoleKey.Escape);
        }

        // Método consumidor:
        // Obtém/retira as teclas da fila, e apresenta informação no ecrã
        private static void ShowKeyOnScreen()
        {
            //--> Completa este código

            ConsoleKeyInfo key;
            do
            {
                key = channel.Take();
                
                switch(key.Key)
                {
                    case ConsoleKey.W:
                        Console.WriteLine("Cima");
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine("Baixo");
                        break;
                    case ConsoleKey.A:
                        Console.WriteLine("Esquerda");
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("Direita");
                        break;
                    default:
                        break;
                }
            }
            while(key.Key != ConsoleKey.Escape);

        }
    }
}