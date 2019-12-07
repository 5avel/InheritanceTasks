using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите ключ");
                string key = Console.ReadLine();
                DocumentWorker doc = null;
                switch (key)
                {
                    case "123":
                        doc = new ProDocumentWorker();
                        break;
                    case "321":
                        doc = new ExpertDocumentWorker();
                        break;
                    default:
                        Console.WriteLine("Ключ неверен");
                        doc = new DocumentWorker();
                        break;
                }

                doc.OpenDocument();
                doc.EditDocument();
                doc.SaveDocument();
            }
        }
    }
}
