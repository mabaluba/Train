using System;
using System.Collections.Generic;
using System.Text;

namespace itvdnTrain
{
    public struct Train
    {
        public string Destination { get; }
        public int TrainNN { get; }
        public DateTime DepartureTime { get; }

        public Train(string destination, int trainNN, DateTime departureTime)
        {
            Destination = destination;
            TrainNN = trainNN;
            DepartureTime = departureTime;
        }
    }
}
