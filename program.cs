using System;
using System.Collections.Generic;
using System.Threading;


static void print (string txt)
{
    Console.WriteLine(txt);
}

static void printInt (int txt)
{
    Console.WriteLine(txt);
}

static void lag()
    {
        // A list to hold large objects to cause significant memory usage
        List<byte[]> memoryHog = new List<byte[]>();

        // Infinite loop to continuously allocate memory and stress the CPU
        long iteration = 0;
        while (true)
        {
            // Increase memory usage drastically
            // Allocating 500MB each iteration for more intensive memory use
            byte[] data = new byte[500 * 1024 * 1024]; // 500 MB
            memoryHog.Add(data);

            // Run a CPU-heavy operation like calculating a large prime number (heavy computation)
            long number = 1000000000 + iteration * 1000; // Increase the number each time
            bool isPrime = IsPrime(number);

            // Optionally, log memory usage and prime check (Can be commented out for better performance)
            //Console.WriteLine($"Iteration: {iteration}, Allocated {memoryHog.Count * 500} MB, Prime check result: {isPrime}");

            // Increment iteration for new prime numbers
            iteration++;
        }
    }

    // Pure CPU stress (Prime number check with larger numbers or other complex calculations)
    static void CreateLag()
    {
        long iteration = 0;
        while (true)
        {
            // Run CPU-heavy operations like factorials or prime number checks with large inputs
            long number = 1000000000 + iteration * 1000; // Increasing number for larger calculations
            bool isPrime = IsPrime(number);

            // Optionally, display results (can be commented out for performance)
            //Console.WriteLine($"Iteration: {iteration}, Prime check for {number}: {isPrime}");

            iteration++;
        }
    }

    // Optimized method to check if a number is prime (CPU-heavy operation)
    static bool IsPrime(long number)
    {
        if (number <= 1)
            return false;

        // Optimized primality check (checking up to the square root)
        for (long i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }






//calculator kterej je sigma jak neco
static void sigmaCalculator()
{


string operation = "";

List<int> numbers = new List<int>();
List<string> oper = new List<string>();

oper.Add("+");

while (operation != "=")
{
    Console.WriteLine("enter number");
    int x = int.Parse(Console.ReadLine());
    numbers.Add(x);

    Console.WriteLine("enter the operation (+, -, *, /, or = (if u want to start the calculation process))");
    operation = Console.ReadLine();
    oper.Add(operation); 
}

int count = 0;
int temp = 0;
while (count <= oper.Count)
{
    if  (oper[count] == "=")
    {
        Console.WriteLine("vysledek je");
        Console.WriteLine(temp);
    }
    else if (oper[count] == "+")
    {
        temp += numbers[count];
    }
    else if (oper[count] == "-")
    {
        temp -= numbers[count];
    }
    else if (oper[count] == "*")
    {
        temp *= numbers[count];
    }
    else if (oper[count] == "/")
    {
        temp /= numbers[count];
    }
    //else if (oper[count] == "^")                     bro this is actualy xor.... 
    //{
        //temp = temp^numbers[count];
    //}
    else
    {
        Console.WriteLine("Like are you stoopid??????????  [said in angry asian voice]");
        string isUserStupid = Console.ReadLine();
    }

    count++;
}


}

//ruleta
static void ruleta()
{
    Console.WriteLine("Wekcome th the ruleta game. Woud you like to play with frend, against ai or by yourself? (frend/ai/myself)");
    string mode = Console.ReadLine();

    Random rnd = new Random();
    int bullet = (rnd.Next(1, 7));

    if (mode == "myself")
    {
        bool isAlive = true;
        int count = 1;

        while (isAlive == true)
        {
            Console.ReadLine();
            if (count == bullet)
            {
                isAlive = false;
                Console.WriteLine("Ur dead");
            }
            else if (count == 5) 
            {
                Console.WriteLine("bro +999999999999999999999999999999999 aura but like u know its over");
            }
            else
            {
                Console.WriteLine("+10000 aura");
                count++;
            }
        }
    }

    else if (mode == "ai")
    {
        bool isAlive = true;
        int count = 1;
        string playerOrAi = "player";
        bool antiPassSpam = true;

        while (isAlive == true)
        {
            if (playerOrAi == "player")
            {
                Console.WriteLine("What is your action? (pass/shoot)");
                string action = Console.ReadLine();
                if (action == "shoot" && playerOrAi == "player")
                {
                    antiPassSpam = false;
                    if (count == bullet)
                    {
                        isAlive = false;
                        Console.WriteLine("Ur dead");
                    }
                    else
                    {
                        Console.WriteLine("+10000 aura");
                        count++;
                    }
                }
                if (antiPassSpam == true)
                {
                    print("no, u shoot");
                    antiPassSpam = false;
                    if (count == bullet)
                    {
                        isAlive = false;
                        Console.WriteLine("Ur dead");
                    }
                    else
                    {
                        Console.WriteLine("+10000 aura");
                        count++;
                    }
                }
                else if (action == "pass" && playerOrAi == "player" && antiPassSpam == false)
                {
                    playerOrAi = "ai";
                    Console.WriteLine("Ai turn");
                    antiPassSpam = true;
                }
            }
            
            else if (playerOrAi == "ai")
            {
                int action = rnd.Next(2);
                //Console.WriteLine(action);
                if (action == 1 && playerOrAi == "ai")
                {
                    Console.WriteLine("ai is shooting itself");
                    antiPassSpam = false;
                    if (count == bullet)
                    {
                        isAlive = false;
                        Console.WriteLine("AI is deed (rip bozo)");
                    }
                    else
                    {
                        Console.WriteLine("ai didnt got obliderated");
                        count++;
                    }
                }
                else if (antiPassSpam == true)
                {
                    Console.WriteLine("ai is shooting itself");
                    antiPassSpam = false;
                    if (count == bullet)
                    {
                        isAlive = false;
                        Console.WriteLine("AI is deed (rip bozo)");
                    }
                    else
                    {
                        Console.WriteLine("ai didnt got obliderated");
                        count++;
                    }
                }
                else if (action == 0 && playerOrAi == "ai" && antiPassSpam == false)
                {
                    Console.WriteLine("ai passes");
                    playerOrAi = "player";
                    Console.WriteLine("Player turn");
                    antiPassSpam = true;
                }
            }
        }

    }

    else if (mode == "frend")
    {
        bool isAlive = true;
        int count = 1;
        string playerOrAi = "player";
        bool antiPassSpam = true;

        while (isAlive == true)
        {
            if (playerOrAi == "player")
            {
                Console.WriteLine("What is your action? (pass/shoot)");
                string action = Console.ReadLine();
                if (action == "shoot" && playerOrAi == "player")
                {
                    antiPassSpam = false;
                    if (count == bullet)
                    {
                        isAlive = false;
                        Console.WriteLine("Ur dead");
                    }
                    else
                    {
                        Console.WriteLine("+10000 aura");
                        count++;
                    }
                }
                if (antiPassSpam == true)
                {
                    print("no, u shoot");
                    antiPassSpam = false;
                    if (count == bullet)
                    {
                        isAlive = false;
                        Console.WriteLine("Ur dead");
                    }
                    else
                    {
                        Console.WriteLine("+10000 aura");
                        count++;
                    }
                }
                else if (action == "pass" && playerOrAi == "player" && antiPassSpam == false)
                {
                    playerOrAi = "ai";
                    Console.WriteLine("Player 2 turn");
                    antiPassSpam = true;
                }
            }
            
            else if (playerOrAi == "ai")
            {
                Console.WriteLine("What is your action? (pass/shoot)");
                string action = Console.ReadLine();
                if (action == "shoot" && playerOrAi == "ai")
                {
                    antiPassSpam = false;
                    if (count == bullet)
                    {
                        isAlive = false;
                        Console.WriteLine("Ur dead");
                    }
                    else
                    {
                        Console.WriteLine("+10000 aura");
                        count++;
                    }
                }
                if (antiPassSpam == true)
                {
                    print("no, u shoot");
                    antiPassSpam = false;
                    if (count == bullet)
                    {
                        isAlive = false;
                        Console.WriteLine("Ur dead");
                    }
                    else
                    {
                        Console.WriteLine("+10000 aura");
                        count++;
                    }
                }
                else if (action == "pass" && playerOrAi == "ai" && antiPassSpam == false)
                {
                    playerOrAi = "player";
                    Console.WriteLine("player 1 turn");
                    antiPassSpam = true;
                }
            }
        }

    }

    else
    {
        Console.WriteLine("bro common, u stupid");
    }
}

//what do u like to eat?
static void weLoveFood()
{
    Console.WriteLine("Whats your name?");
    string name = Console.ReadLine();
    Console.WriteLine("What do you like to eat "  + name + "?");
    string food = Console.ReadLine();

    Console.WriteLine("Ohhh. U like to eat " + food + " huh? Thats sooooooo cute u litle " + name);
}

//sude ci liche
static void modulo()
{
    Console.WriteLine("give me number");
    int num = int.Parse(Console.ReadLine());
    if (num % 2 > 0)
    {
        Console.WriteLine("the number is not dividible by 2");
    }
    else
    {
        Console.WriteLine("the number is dividible by 0");
    }
}

//login2.0 check veku
static void checkAge() 
{
    print("whats your age? (dont lie or ill find ur family. you dont want me to find ur family)");
    int age;
    bool sucsess = int.TryParse(Console.ReadLine(), out age);
    if (sucsess == true)
    {
        
    if (age <= 13) 
    {
        print("Brou ur so kinder");
    }
    else if (age >= 18 && age < 100) 
    {
        print("You want some vodka");
    }
    else if (age >= 100)
    {
        print("Your old af +1000000 aura for not doing alt + f4 20 years earlier. also u cannot play with legos now.");
    }
    else 
    {
        print("Your teenager");
    }

    }

    else
    {
        print("tak ses uplnej retard. pripada ti to jako cislo????? ses snat mentalne retardovanej?????????");
    }

}

//this is also a comment
static void welcomeBitch() //greed
{
    Console.WriteLine("Hi whats ur name");
    string name = Console.ReadLine();
    Console.WriteLine($"Oh welcome {name}. U have autism");
}

//score
static void score()
{
    int score = 0;
    Console.WriteLine(score);
    score += 10;
    Console.WriteLine(score);
    score *= 2;
    Console.WriteLine(score);
    score -= 5;
    Console.WriteLine(score);
}

//delani blbosi s binarnim kodem
static void bitBlbost() // bit bitch
{
    int a = 12; //1100
    int b = 5;  //0101

    printInt(a & b);  //and         0100
    printInt(a | b);  //or          1101
    printInt(a ^ b);  //xor         1001
    printInt(a << 1); //shift left  1010 //jako krat
    printInt(a >> 1); //shift right 0010 //jako deleno
}

static void porovnavat ()
{
    int a = 10;
    int b = 7;
    bool bool1 = (a > b);
    bool bool2 = (a <= b);
    bool bool3 = (a == b);
    Console.WriteLine(bool1);
    Console.WriteLine(bool2);
    Console.WriteLine(bool3);
}

static void greedAndAge () 
{
    print("what is your name?");
    string name = Console.ReadLine();
    print("what is your age?");
    string age = Console.ReadLine();
    print($"Even at this small age of {age}, {name} alredy had autism combined with ADHD and OCD");
}

static void moons ()
{
    string[] months = {"enero", "febrero", "marzo", "abril", "mayo", "juneo", "julio", "agusto", "septiembre", "octobre", "novembre", "deciembre"};
    int[] lengths = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
    
    print(months[5]);
    printInt(lengths[5]);
    print(months[11]);
    printInt(lengths[11]);
}

static void ls ()
{
    List<int> numeros = new List<int> {100, 200, 300};
    
    numeros.Add(400);
    numeros.Remove(200);
    printInt(numeros.Count);
    printInt(numeros[0]);
}

static void infinity ()
{
    long count = 1;
    for (int i = 0; i < Environment.ProcessorCount; i++)
    {
        new Thread(() =>
        {
        
        while (true)
        {
        //Console.WriteLine(count);
        count ++;

        Random rnd = new Random();
        long one = (rnd.Next(-999999999999999, 999999999999999));
        long two = (rnd.Next(-999999999999999, 999999999999999));
        long three = (rnd.Next(-999999999999999, 999999999999999));
        long four = (rnd.Next(-999999999999999, 999999999999999));
        long five = (rnd.Next(-999999999999999, 999999999999999));
        long six = (rnd.Next(-999999999999999, 999999999999999));
        long seven = (rnd.Next(-999999999999999, 999999999999999));
        long eight = (rnd.Next(-999999999999999, 999999999999999));
        long x = one + two - three * four / five % six ^ seven & eight * count;
        long y = one + two - three * four / five % six ^ seven & eight * x * count;
        long z = one + two - three * four / five % six ^ seven & eight * x / y * count;
        //lag();
        }
        }).Start();
    }
}

static void zvirata ()
{
    string[] animals = {"ptakopysk", "prase", "ptak"};

    for (int i = 0; i <= 2; i++)
    {
        Console.WriteLine(animals[i]);
    }
}

static void askForNums()
{
    
}





//the run function, u chuse what des run
static void run ()
{
    print("What would you like to do? (calculator/ruleta/greed/agecheck/modulo/food/score/bitblbost/porovnavat/list/greedage/infnity/zvirata)");
    string activeProgram = Console.ReadLine();

    if (activeProgram == "calculator")
    {
        sigmaCalculator();
    }
    else if (activeProgram == "ruleta")
    {
        ruleta();
    }
    else if (activeProgram == "greed")
    {
        welcomeBitch();
    }
    else if (activeProgram == "agecheck")
    {
        checkAge();
    }
    else if (activeProgram == "modulo")
    {
        modulo();
    }
    else if (activeProgram == "food")
    {
        weLoveFood();
    }
    else if (activeProgram == "score")
    {
        score();
    }
    else if (activeProgram == "bitblbost")
    {
        bitBlbost();
    }
    else if (activeProgram == "porovnavat")
    {
        porovnavat();
    }
    else if (activeProgram == "list")
    {
        ls();
    }
    else if (activeProgram == "greedage")
    {
        greedAndAge();
    }
    else if (activeProgram == "infinity")
    {
        infinity();
    }
    else if (activeProgram == "zvirata")
    {
        zvirata();
    }
    else
    {
        print("u stoopid");
    }
}

run();