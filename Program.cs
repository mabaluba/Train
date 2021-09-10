using System;

namespace itvdnTrain
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TrainRecords.TypeTrainsAmount();

            var trainsRecord = new Train[TrainRecords.Amount];
            
            TrainRecords.AddTrainInfo(trainsRecord);

            TrainRecords.SortByNN(trainsRecord);

            TrainRecords.SearchTrain(trainsRecord);
        }
    }
}
