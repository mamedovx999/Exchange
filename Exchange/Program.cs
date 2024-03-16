using Exchange;
using System;
using System.Net.Http.Headers;
#region Task 1
//public enum Currency
//{
//    Usd,    
//    Eur,    
//    Try     
//}

//public class Program
//{
//    public static double Exchange(Currency currency, double amountInAzn)
//    {
//        double exchangeRate = 0;


//        switch (currency)
//        {
//            case Currency.Usd:
//                exchangeRate = 0.59;  
//                break;
//            case Currency.Eur:
//                exchangeRate = 0.49; 
//                break;
//            case Currency.Try:
//                exchangeRate = 0.62; 
//                break;
//            default:
//                throw new ArgumentException("Desteklemir");
//        }


//        return amountInAzn * exchangeRate;
//    }

//    public static void Main(string[] args)
//    {

//        double amountInAzn = 2;
//        Currency currency = Currency.Usd;

//        double convertedAmount = Exchange(currency, amountInAzn);
//        Console.WriteLine($"Converted amount: {convertedAmount} {currency}");
//    }
//}
#endregion

#region Task2
Student student1 = new Student("Memmedeli", "Memmedov");
Student student2 = new Student("Taghyev", "Murad");
Student student3 = new Student("Kamal", "Isgenderli");

Student[] studens= new Student[] { student1, student2,student3 };

Group group = new Group(1,"A",studens);

Console.WriteLine($"GroupName:{group.Name}");
Console.WriteLine("Studens In Group");
for (int i = 0; i < studens.Length; i++)
{
    Console.WriteLine($"{ i + 1},{ group[i].Name},{ group[i].Surname}");

}


#endregion