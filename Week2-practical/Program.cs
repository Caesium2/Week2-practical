Main();

void Main()
{
    PrintMenu();
    int userNumber =InputOption();
    GetMessage(userNumber);
}
void PrintMenu() {

    Console.WriteLine("Please enter a valid option from below:");
    Console.WriteLine("1. Hello in French?");
    Console.WriteLine("2. Hello in Spanish?");
    Console.WriteLine("3. Hello in German?");
    Console.WriteLine("4. Hello in Italian?");
    Console.WriteLine("0. Exit application");

}

int InputOption() {
    try
    {
        return Convert.ToInt32(Console.ReadLine());
       
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Invalid input, try a number next time");
        return -1;
    }
    
}

void GetMessage(int userNum) {

    switch (userNum)
    {
        case 0:
            Console.WriteLine();
            break;
    }


}
