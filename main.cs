using System;

class Program {
  public static void Main (string[] args) {
    int print;
    Console.WriteLine("Dice rolling");
    string[] dash = {"1", "2", "3", "4", "5", "6"};
    Random rd = new Random();
    print = rd.Next(0,5);
    Console.WriteLine(dash[print]);}}
    