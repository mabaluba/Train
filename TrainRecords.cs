using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace itvdnTrain
{
    public static class TrainRecords
    {
        private static int amount;
        public static int Amount => amount;

        public static void TypeTrainsAmount()
        {
            Console.WriteLine("Type amount of trains you want to add:");
            var trainAmount = Console.ReadLine();
            var i = 1;
            while (!int.TryParse(trainAmount, out amount))
            {
                Console.WriteLine("Yuo should type only digits, try again... ");
                Console.WriteLine("Type amount of trains you want to add:");
                trainAmount = Console.ReadLine();
                i++;
                if (i == 5) System.Environment.Exit(555);
            }
        }
        public static void AddTrainInfo(Train[] trainsRecords)
        {
            for (int i = 0; i < trainsRecords.Length; i++)
            {
                Console.Write("Введите пункт назначения поезда:");
                var dest = Console.ReadLine();
                dest = string.IsNullOrEmpty(dest) ? "Не указан" : dest;

                Console.Write("Введите номер поезда:");
                int numN;
                if(!int.TryParse(Console.ReadLine(), out numN)) numN=0 ;

                Console.Write("Введите дату отправления:");
                DateTime date;
                if (!DateTime.TryParse(Console.ReadLine(), out date)) date = DateTime.Now;

                trainsRecords[i] = new Train(dest, numN, date);
            }
        }
        public static void SortByNN(Train[] trainsRecords)
        {
            var sortedRecords = trainsRecords.OrderBy(x => x.TrainNN);
        }
        public static void SearchTrain(Train[] trainsRecords)
        {
            Console.Write("Введите номер поезда для поиска:");
            int numN;
            if (!int.TryParse(Console.ReadLine(), out numN)) numN = 0;

            var findTrain = from train in trainsRecords where train.TrainNN==numN select train;

            if (findTrain.Count()==0) Console.WriteLine("Такого поезда нет");
            else
            {
                foreach (var train in findTrain)
                {
                    Console.WriteLine($"Вы искали: номер поезда {train.TrainNN}, пункт назначения {train.Destination}, дата отправления {train.DepartureTime}");
                }
            }
        }
    }
}
