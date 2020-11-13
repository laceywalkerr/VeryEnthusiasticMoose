using System;

namespace EnthusiasticMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.writeline is not a return, fyi
            Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            // Let the moose speak!
            MooseSays("H I, I'M  E N T H U S I A S T I C !");
            MooseSays("I really am enthusiastic");

            // Ask some questions
            Question("Is Canada real?", "it seems unlikley", "I knew it!");
            Question("Are you enthusiastic?", "Frankly, I don't believe you. It's 2020, no one is entusiastic.", "Honestly, me either. This is a farse and I'm constantly exhausted.");
            Question("Do you love C# yet?", "Good job sucking up to your instructor!", "Really? Same. It's fine I guess. Keep calm and carry on.");
            Question("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Alright, then. Keep your secrets.");
            Question("Do you want to build a snowman?", "A snowman appears, it talks! The snowman says: HI! MY NAME IS OLAF AND I LIKE WARM HUGS!", "Okay, bye.");
        }

        // This is a method(){}
        static void Question(string question, string trueResponse, string falseResponse)
        {
            bool answer = MooseAsks(question);
            if (answer)
            {
                MooseSays(trueResponse);
            }
            else
            {
                MooseSays(falseResponse);
            }
        }

        static bool MooseAsks(string question)
        {
            Console.Write($"{question} (Y/N): ");
            string answer = Console.ReadLine().ToLower();

            while (answer != "y" && answer != "n")
            {
                Console.Write($"{question} (Y/N): ");
                answer = Console.ReadLine().ToLower();
            }

            if (answer == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void MooseSays(string message)
        {
            Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
            ");
        }
    }
}

// Lets talk about :       
// Console.Write($"{question} (Y/N): ");
//    string answer = Console.ReadLine().ToLower();
//          while (answer != "y" && answer != "n")
//            {
//                Console.Write($"{question} (Y/N): ");
//                answer = Console.ReadLine().ToLower();
//            }

// string interpilation: ($"{question} (Y/N):")
// "Write" is a method
// Console is an object, you can see by the "." (dot) notation
// a string is an object
// string answer = variable deleration and assignment. the answer variables type is string. answer is being reassigned.

//