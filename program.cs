using System;
using System.Collections.Generic;
using System.Threading;
//using Math;

static void print (string txt)
{
    Console.WriteLine(txt);
}

static void printInt (int txt)
{
    Console.WriteLine(txt);
}

//calculator kterej je sigma jak neco
static void sigmaCalculator()
{

List<string> history = new List<string>();

while (true)
{
print("what woud you like to do (calculate/history)");
string mode = Console.ReadLine();

if (mode == "calculate")
{
string operation = "";
string formula = "";

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
int priority;
while (count < oper.Count)
{

while (priority > 0)
{
    if  (oper[count] == "=")
    {
        Console.WriteLine("vysledek je");
        Console.WriteLine(temp);
        formula += (temp);
        history.Add(formula);
    }
    else if (oper[count] == "+")
    {
        temp += numbers[count+1];
        formula += numbers[count] + " " + oper[count+1];
    }
    else if (oper[count] == "-")
    {
        temp -= numbers[count];
        formula += numbers[count] + " " + oper[count+1];
    }
    else if (oper[count] == "*")
    {
        temp *= numbers[count];
        formula += numbers[count] + " " + oper[count+1];
    }
    else if (oper[count] == "/")
    {
        temp /= numbers[count];
        formula += numbers[count] + " " + oper[count+1];
    }
    else
    {
        Console.WriteLine("Like are you stoopid??????????  [said in angry asian voice]");
        string isUserStupid = Console.ReadLine();
    }

    count++;
}
}
}
else if (mode == "history")
{
    foreach (string kkt in history)
    {
        Console.WriteLine(kkt);
    }
}

else
{
    print("this calculator doesnt work with people with autism");
}


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
        //long one = (rnd.Next(-999999999999999, 999999999999999));
        //long two = (rnd.Next(-999999999999999, 999999999999999));
        //long three = (rnd.Next(-999999999999999, 999999999999999));
        //long four = (rnd.Next(-999999999999999, 999999999999999));
        //long five = (rnd.Next(-999999999999999, 999999999999999));
        //long six = (rnd.Next(-999999999999999, 999999999999999));
        //long seven = (rnd.Next(-999999999999999, 999999999999999));
        //long eight = (rnd.Next(-999999999999999, 999999999999999));
        //long x = one + two - three * four / five % six ^ seven & eight * count;
        //long y = one + two - three * four / five % six ^ seven & eight * x * count;
        //long z = one + two - three * four / five % six ^ seven & eight * x / y * count;
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

static void nintendoSwitch()
{
    print("enter num 1 - 3 or 69");
    int num;
    bool sucsess = int.TryParse(Console.ReadLine(), out num);
    if (sucsess == false)
    {
        print("tak ti si kokot");
    }

    switch(num)
    {
        case 1:
            print("u have typr 1 diabities");
            break;

        case 2:
            print("u have typr 2 diabities");
            break;

        case 3:
            print("u have typr 3 diabities (does tat even exists?)");
            break;
        case 69:
            print("u have autism");
            break;

        default:
            print("autism is to litle for you, u have autism, adhd, ocd, dementia and u stoopid and have 5 iq, but neggative.");
            break;
    }
}

static void casino ()
{
    print("welcome to our 100% legit 100% not a scam 10000% wins casino, that definitly doesnt try to scam you. like what is that, why woud you think that t is rigged coz it 100% is not and it is super legit");
    print("");
    print("how mutch money woud you like to play with??? $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
    int money;
    bool sucsess1 = int.TryParse(Console.ReadLine(), out money);

    if (sucsess1 == false)
    {
        print("ur getting kiked out of the casino and we take all ur money. we hoe to enjoy being homeless");
        //break;
        return;
    }

    while (money >= 0)
    {
        print("how mutch woud you like to bet?");
        int bet;
        bool sucsessProMax = int.TryParse(Console.ReadLine(), out bet);
        if (sucsessProMax == false)
        {
            print("ur getting kiked out of the casino and we take all ur money. we hope to enjoy being homeless");
            break;
        }

        int betted = bet;

        print("what number do you think there is going to be?");
        int guess;
        bool sucsessProMaxUltimate = int.TryParse(Console.ReadLine(), out guess);
        if (sucsessProMaxUltimate == false)
        {
            print("ur getting kiked out of the casino and we take all ur money. we hope to enjoy being homeless");
            break;
        }

        money -= bet;
        print("money billance:");
        printInt(money);

        Random rnd = new Random();
        int num1 = (rnd.Next(1, 10));
        int num2 = (rnd.Next(1, 10));
        int num3 = (rnd.Next(1, 10));

        print("these are the numbers");
        printInt(num1);
        printInt(num2);
        printInt(num3);

        if (num1 == num2 && num2 == num3)
        {
            print("big win - jackpot");printInt(num1);
            bet *= 69;

        }

        else if (num1 == num2 || num2 == num3 || num1 == num3)
        {
            print("not so big win");
            bet *= 3;
        }


        if (guess == num1 || guess == num2 || guess == num3)
        {
            bet *= 2;
        }

        if (betted != bet)
        {
            print("u win:");
            printInt(bet);
            money += bet;
            print("money billance:");
            printInt(money);
        }
        
        else
        {
            print("oooo poor, u loose");
            print("money billance:");
            printInt(money);
        }

        
        

    }
    

}

static void minMax ()
{
    print("zadej dve cisla");
    int num1;
    bool sucsess1 = int.TryParse(Console.ReadLine(), out num1);
    if (sucsess1 == false)
    {
        print("possibly bad news, u got autism");
    }

    int num2;
    bool sucsess2 = int.TryParse(Console.ReadLine(), out num2);
    if (sucsess2 == false)
    {
        print("possibly bad news, u got autism");
    }

    if (num1 == num2)
    {
        print("obe jsou stejy??????????? proc bys je chtl porovnat???????");
    }
    else
    {
        print("mensi cislo");
        printInt(Math.Min(num1, num2));

        print("vetsi cislo");
        printInt(Math.Max(num1, num2));
    }


}

static void kruh ()
{
    double pi = Math.PI;
    double r = 69;
    Console.WriteLine(2*pi*r);
}

static void nsd ()
{
    int x = 69;
    int y = 128;
    int count = 2;
    bool nsdGot = false;
    while (nsdGot == false && nsdGot != true)
    {
        printInt(count);
        if (y % count == 0 && x % count == 0)
        {
            nsdGot = true;
            print("nsd je");
            printInt(count);
        }
        else
        {
            if (nsdGot == false)
            {
                count++;
            }
        }

    }
}





//the run function, u chuse what des run
static void run ()
{
    print("What would you like to do? (calculator/ruleta/greed/agecheck/modulo/food/score/bitblbost/porovnavat/list/greedage/infnity/zvirata/break/switch/casino$$$/minmax/kruh/nsd)");
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
    else if (activeProgram == "switch")
    {
        nintendoSwitch();
    }
    else if (activeProgram == "casino$$$")
    {
        casino();
    }
    else if (activeProgram == "minmax")
    {
        minMax();
    }
    else if (activeProgram == "kruh")
    {
        kruh();
    }
    else if (activeProgram == "nsd")
    {
        nsd();
    }
    else
    {
        print("u stoopid");
    }
}

run();