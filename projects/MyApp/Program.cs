﻿using System;
using System.Diagnostics;
using System.IO.Pipelines;
namespace TourOfCsharp;

using System;

public class GalacticTravelAgency
{
    public static void Main(string[] args)
    {
        // Your code goes here
        string passengerName = "Zara";
        int passengerAge = 28;
        string ticketType = "First Class";
        string preferredPlanet = "Mars";
        Console.WriteLine(passengerName);
        Console.WriteLine(passengerAge);
        Console.WriteLine(ticketType);
        Console.WriteLine(preferredPlanet);
        passengerAge++;
        Console.WriteLine(passengerAge);
        double passengerAgeDouble = (double)passengerAge;
        Console.WriteLine(passengerAgeDouble);
        double passengerAgeDouble2 = passengerAge;
        Console.WriteLine(passengerAgeDouble2);
        string passengerAgeString = Convert.ToString(passengerAge);
        Console.WriteLine(passengerAgeString);
    }
}
