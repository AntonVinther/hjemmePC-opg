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

int thousand = 1000, five = 5, three = 3, sum = 0;

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

-------------------------------------------------

euler opg 9

using System.Globalization;
using System.Net.Http.Headers;
long largestproduct = 0;
long product = 1;

string digits = "7136717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
int[] singleDigits = new int[1000];
for (int i = 0; i < 1000; i++)
{
    string sub1 = digits.Substring(i, 1);
    singleDigits[i] = Convert.ToInt32(sub1);
}

for (int j = 0; j < 988; j++)
{
    for (int k = 0; k < 13; k++)
    {
        product *= singleDigits[j + k];
    }
    largestproduct = product > largestproduct ? product : largestproduct;
    product = 1;
}
Console.WriteLine(largestproduct);

---------------------------------------------------

euler 10
using System;

public class PrimeChecker
{
    public static bool IsPrime(long number)
    {
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
        long sum = 0;
        for (long i = 2; i <= 2e6; i++)
        {
            if (IsPrime(i))
            {
                sum += i;
            }
        }
        Console.WriteLine(sum);
    }
}


-------------------------------------------
using Microsoft.VisualBasic;

int largestproduct = 0;
int product = 1;
for (int i = 0; i < 20; i++)
{
    var line01 = new int[08, 02, 22, 97, 38, 15, 00, 40, 00, 75, 04, 05, 07, 78, 52, 12, 50, 77, 91, 08];
    var line02 = new int[49, 49, 99, 40, 17, 81, 18, 57, 60, 87, 17, 40, 98, 43, 69, 48, 04, 56, 62, 00];
    var line03 = new int[81, 49, 31, 73, 55, 79, 14, 29, 93, 71, 40, 67, 53, 88, 30, 03, 49, 13, 36, 65];
    var line04 = new int[52, 70, 95, 23, 04, 60, 11, 42, 69, 24, 68, 56, 01, 32, 56, 71, 37, 02, 36, 91];
    var line05 = new int[22, 31, 16, 71, 51, 67, 63, 89, 41, 92, 36, 54, 22, 40, 40, 28, 66, 33, 13, 80];
    var line06 = new int[24, 47, 32, 60, 99, 03, 45, 02, 44, 75, 33, 53, 78, 36, 84, 20, 35, 17, 12, 50];
    var line07 = new int[32, 98, 81, 28, 64, 23, 67, 10, 26, 38, 40, 67, 59, 54, 70, 66, 18, 38, 64, 70];
    var line08 = new int[67, 26, 20, 68, 02, 62, 12, 20, 95, 63, 94, 39, 63, 08, 40, 91, 66, 49, 94, 21];
    var line09 = new int[24, 55, 58, 05, 66, 73, 99, 26, 97, 17, 78, 78, 96, 83, 14, 88, 34, 89, 63, 72];
    var line10 = new int[21, 36, 23, 09, 75, 00, 76, 44, 20, 45, 35, 14, 00, 61, 33, 97, 34, 31, 33, 95];
    var line11 = new int[78, 17, 53, 28, 22, 75, 31, 67, 15, 94, 03, 80, 04, 62, 16, 14, 09, 53, 56, 92];
    var line12 = new int[16, 39, 05, 42, 96, 35, 31, 47, 55, 58, 88, 24, 00, 17, 54, 24, 36, 29, 85, 57];
    var line13 = new int[86, 56, 00, 48, 35, 71, 89, 07, 05, 44, 44, 37, 44, 60, 21, 58, 51, 54, 17, 58];
    var line14 = new int[19, 80, 81, 68, 05, 94, 47, 69, 28, 73, 92, 13, 86, 52, 17, 77, 04, 89, 55, 40];
    var line15 = new int[04, 52, 08, 83, 97, 35, 99, 16, 07, 97, 57, 32, 16, 26, 26, 79, 33, 27, 98, 66];
    var line16 = new int[88, 36, 68, 87, 57, 62, 20, 72, 03, 46, 33, 67, 46, 55, 12, 32, 63, 93, 53, 69];
    var line17 = new int[04, 42, 16, 73, 38, 25, 39, 11, 24, 94, 72, 18, 08, 46, 29, 32, 40, 62, 76, 36];
    var line18 = new int[20, 69, 36, 41, 72, 30, 23, 88, 34, 62, 99, 69, 82, 67, 59, 85, 74, 04, 36, 16];
    var line19 = new int[20, 73, 35, 29, 78, 31, 90, 01, 74, 31, 49, 71, 48, 86, 81, 16, 23, 57, 05, 54];
    var line20 = new int[01, 70, 54, 71, 83, 51, 54, 69, 16, 92, 33, 48, 61, 43, 52, 01, 89, 19, 67, 48];

    for (int j = 0; j < 4; j++)
    {
        product *= 
    }
    largestproduct = product > largestproduct ? product : largestproduct;
}
Console.WriteLine(largestproduct);

long sum = 2;
for (int i = 0; i < 1000; i++)
{
    sum = sum * 2;
}
Console.WriteLine(sum);
----------------------------------------
euler 2 opløftet af 1000
ulong sum = 2;
ulong realsum = 0;
for (int i = 0; i < 1000; i++)
{
    sum *= 2;
    for (int j = 0; ; j++)
    {
        ulong[] ciffersum = new ulong[j];
        ciffersum[j] = sum;
    }
    realsum += ciffersum[i];
}

---------------------------------------------

Tes Stock Prices
int buy = 0, sell = 0;
int product = 0;
int largestproduct = 0;
int[] stockprices = { 7, 1, 5, 3, 6, 4 };
for (int i = 0; i < stockprices.Length; i++)
{
    for (int j = 0; j < stockprices.Length; j++)
    {
        if (j > i)
        {
            product += stockprices[j] - stockprices[i];
            if (product > largestproduct)
            {
                largestproduct = product;
                buy = i + 1;
                sell = j + 1;
            }
            product = 0;
        }
    }
}
Console.WriteLine("The largest profit possible is {0} if you buy on day {1}, and sell on day {2}", largestproduct, buy, sell);

-----------------------------------------------------------

Tes subsequence
int[] numbers = { 5, 4, 1, 8, 7, 12, 13, 9, 12, 20 };
int[] sequence = { };
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > numbers[i - 1])
    {
        sequence[i] = numbers[i];
    }
}
for (int i = 0; i < sequence.Length; i++)
{
    Console.WriteLine(sequence[i]);
}

-------------------------------------------

gambler


using System.Runtime.CompilerServices;

Console.WriteLine("Welcome to the Roulette!");
Console.WriteLine("You will start with 100$");
Console.WriteLine("Goodluck!");
int start = 100;
int money = 0;

string red = "red";
string black = "black";
string green = "green";

Console.WriteLine("To start the game, press ENTER");
if (Console.ReadKey().Key == ConsoleKey.Enter)
{
    Console.Clear();
    money = start;
    Console.WriteLine(money + "$");
    Console.WriteLine("Please input the amount you wish to bet");
    int bet = Convert.ToInt32(Console.ReadLine());
    if (bet < money)
    {
        money -= bet;
        Console.Clear();
        Console.WriteLine("money: " + money + "$");
        Console.WriteLine("bet: " + bet + "$");
        Console.WriteLine("Do you wish to bet RED, BLACK or GREEN");
    }
    else
    {
        Console.WriteLine("Bet too big, try again");
        return;
    }
}
USE WHILE LOOP mvh Post

----------------------------

euler 14

using System.ComponentModel.DataAnnotations.Schema;

long collatz;
int chain = 0;
int longestchain = 0;
long largestnumber = 0;
for (long i = 13; i < 1000000; i++)
{
    collatz = i;
    while (collatz != 1)
    {
        if (collatz % 2 == 0)
        {
            collatz /= 2;
            chain++;
        }
        else if (collatz % 2 != 0)
        {
            collatz *= 3;
            collatz += 1;
            chain++;
        }
    }
    if (chain > longestchain)
    {
        longestchain = chain;
        if (i > largestnumber)
        {
            largestnumber = i;
        }
    }
    chain = 0;
}
Console.WriteLine("The number below 1 million, with the largest chain is {0} and the length of its chain is {1}", largestnumber, longestchain);
-------------------------------


euler 19

int sundaycount = 0;
int monday = 1, tuesday = 2, wednesday = 3, thursday = 4, friday = 5, saturday = 6, sunday = 7;
int yearcount = 1900;
for (int i = 0; i < 100; i++)
{
    yearcount++;
    if (yearcount % 4 == 0)
    {
        for (int j = 0; j < 366; j++)
        {
            for (int l = 0; l < 7; l++)
            {
                if ()
            }
        }
    }
    else if (yearcount % 4 != 0)
    {
        for (int k = 0; k < 365; k++)
        {
            for (int m = 0; m < 7; m++)
            {

            }
        }
    }
}
Console.WriteLine(sundaycount);

euler 20
using System.Numerics;
Console.WriteLine("Input a number n!");
int input = Convert.ToInt32(Console.ReadLine());
int inputForLoop = input;
BigInteger multiplication = input;
for (int i = 1; i < inputForLoop; i++)
{
    input -= 1;
    multiplication *= input;
}
Console.WriteLine(multiplication);
int sum = 0;
string multi = multiplication.ToString();
char[] characters = multi.ToCharArray();
for (int i = 0; i < characters.Length; i++)
{
    sum += Convert.ToInt32(characters[i]);
}
Console.WriteLine(sum);

euler 25 1000 digit fibonacci number
using System.Numerics;
List<BigInteger> fibonacci = new List<BigInteger>();

int indexcount = 3;

fibonacci.Add(1);
fibonacci.Add(1);
fibonacci.Add(2);

for (int i = 3;; i++)
{
    fibonacci.Add(fibonacci[i - 2] + fibonacci[i - 1]);

    string characters = fibonacci[i].ToString();
    char[] digits = characters.ToCharArray();

    indexcount += 1;

    if (digits.Length >= 1000)
    {
        Console.WriteLine(indexcount);
        break; 
    }
}
2. Write a program in C# Sharp to create a user defined function with parameters.
Test Data :
Please input a name : John
Expected Output :
Welcome friend John !
Have a nice day!
public class program
{
    public static void Main()
    {
        Getname("What is your name?");
        PrintName(Console.ReadLine());
    }
    public static void Getname(string whatisname)
    {
        Console.WriteLine($"{whatisname}");
    }
    public static void PrintName(string NAME)
    {
        Console.WriteLine($"Well hi there {NAME}, nice to meet you!");
    }
}

Add 2 numbers user defined numbers together using functions
*/
public class Program {
public static void Main(){
whatNumbs("what numbers should be added together?");
PrintPlus(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));
}
public static void whatNumbs(string numbersss)
{
    Console.WriteLine($"{numbersss}");
}
public static void PrintPlus(int x, int y){
Console.WriteLine($"{x} + {y} = {Plus(x, y)}");
}
public static int Plus(int x, int y){
return x + y;
}
}

