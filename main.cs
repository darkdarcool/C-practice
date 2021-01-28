using System;
using System.Threading;
using System.Collections.Generic;

class MainClass {
	public static Dictionary<int, float> options = new Dictionary<int, float> {
		{1, 1/15f},
		{2, 1/25f},
		{3, 1/35f}
	};

  public static void Main (string[] args) {
    int choice = 3;
    Console.ForegroundColor = ConsoleColor.Blue;
		sp("Hello, what is your name?", options[choice]);
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("> ");
    string name = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.Blue;
    sp("Hello " + name + "!", options[choice]);
		Thread.Sleep(2000);
		sp("This is a text adventure that will be compiled in the github GCC and c sharp. This may take a long to time to load so when a prompt that says loading comes up please do not dismiss it.", options[choice]);
		Thread.Sleep(2000);
		Console.Clear();
		Console.ResetColor();
		Console.ForegroundColor = ConsoleColor.Green;
		sp("Feeding into compiler...", options[choice]);
		Console.ResetColor();
		Console.ForegroundColor = ConsoleColor.Blue;
		sp("Put text here.", options[choice]);
	  
  }

	public static void sp(string text, float waitTime) {
		foreach (char c in text.ToCharArray()) {
			Console.Write(c);
			Thread.Sleep((int)(waitTime * 1000));
		}
		Console.WriteLine();
	}
}
