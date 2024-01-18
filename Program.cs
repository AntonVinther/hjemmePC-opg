﻿/* Opg 1 arrays
int[] outputs = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
for (int i = 0; i < outputs.Length; i++){
    Console.WriteLine(outputs[i]);
}
*/



/*
3. Write a program in C# Sharp to find the sum of all array elements.
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 2
element - 1 : 5
element - 2 : 8
Expected Output :
Sum of all elements stored in the array is : 15

Console.WriteLine("How many elements do you wish to add up?");
int Length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[Length];

Console.WriteLine("Enter " + Length + " elements");
for (int j = 0; j < numbers.Length; j++)
{
    int number = Convert.ToInt32(Console.ReadLine());
    numbers[j] = number;
}

int sum = 0;

for (int booty = 0; booty < numbers.Length;  booty++)
{
sum += numbers[booty];
}
Console.WriteLine("The sum of the elements are " + sum);
*/


/*
4. Write a C# Sharp program to copy the elements of one array into another array.
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 15
element - 1 : 10
element - 2 : 12
Expected Output:
The elements stored in the first array are :
15 10 12
The elements copied into the second array are :
15 10 12
Console.WriteLine("How many elements do you want the array to hold?");
int Length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[Length];
int[] copies = new int [Length];

Console.WriteLine("Enter " + Length + " elements");
for (int j = 0; j < numbers.Length; j++)
{
    int number = Convert.ToInt32(Console.ReadLine());
    numbers[j] = number;

    
for (int i = 0; i < numbers.Length; i++)
{
    copies[i] = numbers[i];
}
}

Console.Write("\nThe numbers in the first array is ");

for (int k = 0; k < Length; k++)
{
    Console.Write(numbers[k] + " ");
}
    Console.Write("\nThe numbers in the COPIED array is ");

for (int l = 0; l < Length; l++)
{
    Console.Write(copies[l] + " ");
}


5. Write a C# Sharp program in to count duplicate elements in an array.
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 5
element - 1 : 1
element - 2 : 1
Expected Output :
Total number of duplicate elements found in the array is : 1
Console.WriteLine("Please enter the amount of inputs you want the array to contain");

int length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[length];
int[] copy = new int[length];
int[] dupes = new int[length];
int dupeCount = 1;
int dupeOutput = 0;

Console.WriteLine("Please enter " + length + " inputs");
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    copy[i] = numbers[i];
}

for (int i = 0; i < length; i++){
    for (int j = 0; j < length; j++){
        if (numbers[i] == copy[j]){
            dupes[j] = dupeCount;
            dupeCount++;
        }
    }
    dupeCount = 1;
}
for (int l = 0; l < length; l++){
    if (dupes[l] == 2){
        dupeOutput++;
    }
}
Console.WriteLine("The array of numbers are");
for (int k = 0; k < length; k++){
Console.WriteLine(numbers[k]);
}
Console.WriteLine("The amount of dupes in the array is " + dupeOutput);

Like, it works but if there are 3 or more of the same numbers, it will stil only see it as one duplicate...
*/ 
