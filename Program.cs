// See https://aka.ms/new-console-template for more information
// array - variable that can store multiple values. Fixed size
//Here we are displaying elements within an array
String[] cars = { "BMW","Mustang","Corvette"};
cars[0] = "Tesla"; //Changes the value of the first element
//                   computers refer to it as 0
//Console.WriteLine(cars[0]);
//Console.WriteLine(cars[1]);
//Console.WriteLine(cars[2]);
//-----------------------------------------
//We can also iterate over the array using a for loop
//for (int i=0; i < cars.Length;i++)
//{
//    Console.WriteLine(cars[i]);
//}
////How to place a size on an array
//String[] array = new string[cars.Length];
//for (int j = 0; j < array.Length; j++)
//{
//    array[j] = cars[j];
//    Console.WriteLine(array[j]);
//}
//for-each loop, a simpler way to iterate over an array but it is less flexible
//with a normal for loop you can iterate forwards backwards and even skip iterations
foreach (String car in cars)
{
    Console.WriteLine(car);
}
Console.ReadKey();