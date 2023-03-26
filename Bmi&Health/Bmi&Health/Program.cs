// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome!");
Thread.Sleep(1000);
Console.WriteLine("Let's check your BMI and see how healty you are.");

Thread.Sleep(2000);

string name;
double height, totalbmi;
int age, weight;
Console.WriteLine();
Console.WriteLine("What is your name?: ");
name = Console.ReadLine();
Console.WriteLine("What is your height?(M): ");
height = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("What is your weight?(KG): ");
weight = int.Parse(Console.ReadLine());
Console.WriteLine("What is your age?: ");
age = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Hello "+ name + ", your height is  " +height + " cm and your age is " + age + " years"+ " and your weight is " + weight + " kg.");
Thread.Sleep(1000);
Console.WriteLine();
Console.WriteLine("Let's calculate");
Console.WriteLine("...");
Console.WriteLine();
totalbmi = weight / (height * height);
totalbmi = Math.Round(totalbmi, 2);
Thread.Sleep(3000);
Console.WriteLine("Your bmi is: " + totalbmi);
Console.ReadLine();



