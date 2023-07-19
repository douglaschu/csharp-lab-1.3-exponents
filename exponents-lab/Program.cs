


bool runProgram = true;
while (runProgram)
{
    Console.WriteLine("Please enter an integer.");
    int input = int.Parse(Console.ReadLine());

    
    if (input > 0)
    {
        if (input  <= 1290 )
        {
            //only make methods for squares and cubes
            //run loop until 

            //Console.WriteLine($"x^1\tSquared\tCubed");
            Console.WriteLine(String.Format("{0,5}{1,15}{2,15}", "1st Power", "Square", "Cube"));


            for (int i = 1; i <= input; i++)
            {
                //right align
                Console.WriteLine(String.Format("{0,5}{1,15}{2,15}", i, Square(i), Cube(i)));
                //Console.WriteLine($"{i} \t {Square(i)} \t{Cube(i)}");
            }
        } else
        {
            Console.WriteLine("Please enter a smaller integer.");
        }  
        
             
    } else
    {
        Console.WriteLine("Please enter an integer greater than zero.");
    }

    //ask to continue
    while (true)
    {
        Console.WriteLine("Would you like to continue? (y/n)");
        string choice = Console.ReadLine().ToLower().Trim();
        if (choice == "n")
        {
            Console.WriteLine("See ya!");
            runProgram = false;
            break;
        }
        else if (choice == "y")
        {
            
            runProgram = true;
            break;
        } else
        {
            Console.WriteLine("Invalid input.");
        }
    }

}
static int Square(int x)
{
    return x * x;
}

static int Cube(int x)
{
    return x * x * x;
}


Console.ReadLine();