using System;

class Program {
  public static void Main (string[] args) 
  {
      Console.WriteLine("Podaj wagę");
      double waga = double.Parse(Console.ReadLine());
      Console.WriteLine("Podaj wzrost");
      double wzrost = double.Parse(Console.ReadLine());
      double bmi = waga / (wzrost*wzrost);
      switch (bmi)
    
    {
    case < 16:
      Console.WriteLine($"{bmi} wygłodzenie");
      break;
    case > 16 and <16.99:
      Console.WriteLine($"{bmi} wychudzenie");
      break;
    case > 17 and < 18.49:
      Console.WriteLine($"{bmi} niedowaga ");
      break;
    case > 18.5 and < 24.99:
      Console.WriteLine($"{bmi} prawidłowa waga");
      break;
    case > 25 and < 29.99:
      Console.WriteLine($"{bmi} nadwaga");
      break;
    case > 30 and < 34.99:
      Console.WriteLine($"{bmi} I stopień otyłości");
      break;
    case > 35 and < 39.99:
      Console.WriteLine($"{bmi} II stopień otyłości ");
      break;
    case > 40:
      Console.WriteLine($"{bmi} otyłość skrajna ");
      break;
    }
  }
}