﻿using System;

namespace Task4
{
    internal class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument() 
        {
            Console.WriteLine("Документ сохранен в других форматах");
        }
    }
}