/* Opg 1 arrays
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
*/



