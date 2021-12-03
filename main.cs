using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("What's the first number");
    int NumOne = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("What's the sign");
    string sign = Console.ReadLine();
    Console.WriteLine("What's the second number");
    int NumTwo = Convert.ToInt32(Console.ReadLine());
    switch(sign){
      case "+":
        Console.WriteLine(NumOne + NumTwo);
        break;
      case "-":
        Console.WriteLine(NumOne - NumTwo);
        break;
      case "/":
        Console.WriteLine(NumOne / NumTwo);
        break;
      case "*":
        Console.WriteLine(NumOne * NumTwo);
        break;
      case "%":
        Console.WriteLine(NumOne % NumTwo);
        break;
      default: 
        Console.WriteLine("not found");
        break;
    }
  }
}