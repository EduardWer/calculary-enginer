// Калькулятор 
/* 1. Ввод команды 
 * 2. Ввод числел 
 * 3.Проверка числа
 * 4.Осуществление оперций 
 * 5.Вывод
 * 
 * Основные математические + 
*/
using System.Security.Cryptography.X509Certificates;

string command;
static long Fact(long n)
{
    if (n == 0)
        return 1;
    else
        return n * Fact(n - 1);
}

while (true)
{
    Console.WriteLine("Вас приветствует инженерный калькулятор \n" +
       "power by EduardWer\n" +
       "Основные команды:\n" +
       "+ - сложение \n" +
       "- - вычетание \n" +
       "* - умножение \n" +
       "/ - деление\n" +
       "degree - степень\n" +
       "root - квадратный корень\n" +
       "% - процент\n " +
       "facto - факториал числа");
    float first_;
    float second_; 
    Console.WriteLine("Enter your command>>");
    command = Console.ReadLine();
    command.ToLower();
    if (command == "exit")
    {
        Console.WriteLine("Oke!");
        break;
    }
    Console.WriteLine("Enter your first num");
    string first_num = Console.ReadLine();
    try
    {
        
        float.TryParse(first_num,out first_);
        // Console.WriteLine(first_);
        
        
        switch (command)
        {
            case "+":
                Console.WriteLine("Enter your second num");
                string second_num = Console.ReadLine();
                float.TryParse(second_num,out second_);
                Console.WriteLine("Your answer  "+ (first_ + second_));
                break;
            case "-":
                Console.WriteLine("Enter your second num");
                second_num = Console.ReadLine();
                float.TryParse(second_num, out second_);
                Console.WriteLine("Your answer  " + (first_ - second_));
                break;
            case "*":
                Console.WriteLine("Enter your second num");
                second_num = Console.ReadLine();
                float.TryParse(second_num, out second_);
                Console.WriteLine("Your answer  " + (first_ * second_));
                break;
            case "/":
                Console.WriteLine("Enter your second num");
                second_num = Console.ReadLine();
                float.TryParse(second_num, out second_);
                if (second_ == 0)
                {
                    Console.WriteLine("Error: Деление на 0 ");
                }
                else{Console.WriteLine("Your answer  " + (first_ / second_));}
                break;
            case "%":
                Console.WriteLine("Enter your second num");
                second_num = Console.ReadLine();
                float.TryParse(second_num, out second_);
                Console.WriteLine("Your answer  " + (first_ / second_)*100);
                break;
            case "facto":          // Факториал
                long.TryParse(first_num, out long fact);
                Console.WriteLine("Your answer " + Fact(fact));
                break;
            case "degree":         // степень
                Console.WriteLine("Enter your second num");
                second_num = Console.ReadLine();
                int.TryParse(second_num, out int second);
                Console.WriteLine("Your answer  " + Math.Pow(first_,second));
                break;
            case "root":          // корень
                Console.WriteLine("Your answer" + Math.Sqrt(first_));
                break;
            

        }

    }
    catch {
        Console.WriteLine("Error");
    }

    
}
