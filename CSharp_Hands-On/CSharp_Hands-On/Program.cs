using System;

namespace CSharp_Hands_On
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxMinElement maxmin = new MaxMinElement();
            maxmin.MaxMin();

            MaxOccuringElement maxOccurence = new MaxOccuringElement();
            maxOccurence.MaxOccuring();

            PositionOfWord findpos = new PositionOfWord();
            findpos.FindPosition();

        }
    }
}


