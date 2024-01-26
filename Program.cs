/*
Opg 1 arrays
int[] outputs = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
for (int i = 0; i < outputs.Length; i++){
    Console.WriteLine(outputs[i]);
}


---------------------------------------------------------------------------------


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

------------------------------------------------------------------------------------------

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

-------------------------------------------------------------------------------

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

-------------------------------------------------------------

euler opg 1

int thousand = 1000;
int three = 3;
int five = 5;
int sum = 0;
for (int i = 0; i < thousand; i++){
    if (i % three == 0 || i % five == 0){
        sum += i;
    }
}
Console.WriteLine(sum);


--------------------------------------


euler opg 2

int one = 1;
int two = 2;
int sum = 0;

int[] fibo = new int[100];

fibo[1] = one;
fibo[2] = two;

for (int i = 2; i < fibo.Length; i++)
{
    fibo[i] = fibo[i - 1] + fibo[i - 2];
    if (fibo[i] % two == 0)
    {
        sum += fibo[i];
    }

    if (sum >= 4000000)
    {
        break;
    }
}

Console.WriteLine(sum);
--------------------------------------
euler opg 3
---------------------------------------
euler opg 4

int palin;
int largest = 0;
for (int i = 100; i < 1000; i++)
{
    for (int j = 100; j < 1000; j++)
    {
        int maybe = i * j, reverse = 0;
        while (maybe > 0)
        {
            int rem = maybe % 10;
            reverse = (reverse * 10) + rem;
            maybe = maybe / 10;
        }
        maybe = i * j;
        if (reverse == maybe)
        {
            palin = maybe;
            if (largest < palin)
            {
                largest = palin;
            }
        }
    }
}
Console.WriteLine(largest);

------------------------------------------------

euler opg 5

for (int i = 2; i < 1000000000; i++)
{
    bool found = true;
    for (int j = 1; j <= 20; j++)
    {
        if (i % j != 0)
        {
            found = false;
            break;
        }
    }
    if (found)
    {
        Console.WriteLine(i);
        return;
    }
}

-----------------------------------------
euler opg 6

int squares = 0;
int sumsqrd = 0;

for (int i = 1; i <= 100; i++)
{
    squares += i*i;
    sumsqrd += i;
}
sumsqrd = sumsqrd * sumsqrd;
int diff = sumsqrd - squares;
Console.WriteLine(diff);

-----------------------------------------------
euler opg 7

using System.Globalization;

using System;

public class PrimeChecker
{
    {
    public static bool IsPrime(int number)
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    public static void Main()
    {
        int count = 0;
        for (int i = 2; i < 1e9; i++)
        {
        if (IsPrime(i))
        {
            count++;
        }
                if (count == 10001)
        {
            Console.WriteLine(i);
            return;
        }
        }


    }
}

------------------------------------------------
euler opg 8

using System;

public class pythagoreanTriple
{
    public static void Main()
    {
    for (int a = 1; a < 1000; a++)
    {
        for (int b = 1; b < 1000; b++)
        {
            for (int c = 1; c < 1000; c++)
            {
                if (a * a + b * b == c * c)
                {
                    if (a + b + c == 1000)
                    {
                        Console.WriteLine(a * b * c);
                        return;
                    }
                }
            }
        }
    }
}
}

euler opg 9
*/

string digits = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
int big = 0;
int maybeBig = 0;


for (int i = 0; i <= 1000; i++)
{
    for (int j = 0; j < 13; j++)
    {
        for (int k = 0; k < 13; k++)
        {
            string sub1 = digits.Substring(i, i + 1);
            Console.WriteLine(sub1);
        }
    }
    break;
}
