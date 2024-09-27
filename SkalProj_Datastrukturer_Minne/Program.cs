﻿using System;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            while (true)
            {
                Console.WriteLine(
                    "Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }

                switch (input)
                {
                    case '1':
                        Console.WriteLine("EL");
                        ExamineList();
                        break;
                    case '2':
                        Console.WriteLine("EQ");
                        ExamineQueue();
                        break;
                    case '3':
                        Console.WriteLine("ES");
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            List<string> theList = new List<string>();
            while (true)
            {
                Console.WriteLine(" +word = add 'word' to the list");
                Console.WriteLine(" -word = remove 'word' from the list");
                Console.WriteLine(" x = exit to main menu");
                string input = Console.ReadLine(); //  +Pölsa   -Pölsa
                char nav = input[0]; // + or -
                string value = input.Substring(1); // Pölsa
                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        Console.WriteLine($"Add: '{value}', Count: {theList.Count}, Capacity: {theList.Capacity}");
                        break;
                    case '-':
                        theList.Remove(value);
                        Console.WriteLine($"Remove: '{value}', Count: {theList.Count}, Capacity: {theList.Capacity}");
                        break;
                    case 'x':
                        return;
                    default:
                        Console.WriteLine("Use commands starting with + or -");
                        break;
                }
            }
            /*
            2. När ökar listans kapacitet? (Alltså den underliggande arrayens storlek)
            Den ökar när jag lägger till en element som det inte finns plats till.
            3. Med hur mycket ökar kapaciteten?
            Den blir dubbelt så stor.
            4. Varför ökar inte listans kapacitet i samma takt som element läggs till?
            För att det skulle ta mer tid att öka den så många gånger.
            5. Minskar kapaciteten när element tas bort ur listan?
            Nej.
            6. När är det då fördelaktigt att använda en egendefinierad array istället för en lista?
            När jag vet hur många element som behöver lagras.
             */
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            Queue<string> theQueue = new Queue<string>();
            while (true)
            {
                Console.WriteLine(" +name = add 'name' to the queue");
                Console.WriteLine(" - = remove the first in the queue");
                Console.WriteLine(" x = exit to main menu");
                string input = Console.ReadLine(); //  +Pölsa   -Pölsa
                char nav = input[0]; // + or -
                string value = input.Substring(1); // Pölsa
                switch (nav)
                {
                    case '+':
                        theQueue.Enqueue(value);
                        Console.WriteLine($"Add: '{value}', Count: {theQueue.Count}");
                        break;
                    case '-':
                        if (theQueue.Count == 0)
                        {
                            Console.WriteLine("The queue is already empty");
                            break; // If I don't have this it will crash when queue is empty and user types -
                        }

                        value = theQueue.Dequeue();
                        Console.WriteLine($"Remove: '{value}', Count: {theQueue.Count}");
                        break;
                    case 'x':
                        return;
                    default:
                        Console.WriteLine("Use commands starting with + or -");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            Stack<string> theStack = new Stack<string>();
            while (true)
            {
                Console.WriteLine(" +name = add 'name' to the stack");
                Console.WriteLine(" - = remove the first in the stack");
                Console.WriteLine(" r = reverse some text");
                Console.WriteLine(" x = exit to main menu");
                string input = Console.ReadLine(); //  
                char nav = input[0]; // + or -
                string value = input.Substring(1); // Pölsa
                switch (nav)
                {
                    case '+':
                        theStack.Push(value);
                        Console.WriteLine($"Add: '{value}', Count: {theStack.Count}");
                        break;
                    case '-':
                        if (theStack.Count == 0)
                        {
                            Console.WriteLine("The stack is already empty");
                            break; // If I don't have this it will crash when queue is empty and user types -
                        }

                        value = theStack.Pop();
                        Console.WriteLine($"Remove: '{value}', Count: {theStack.Count}");
                        break;
                    case 'r':
                        ReverseText();
                        break;
                    case 'x':
                        return;
                    default:
                        Console.WriteLine("Use commands starting with + or -");
                        break;
                }
            }
            // 1. Det är inte så smart att använda en stack till ICA-kön för att den som går till kassan först får vänta till sist.
        }

        static void ReverseText()
        {
            Stack<char> theStack = new Stack<char>();
            Console.WriteLine(" write some text to reverse");
            string? input = Console.ReadLine();
            if (input == null)
            {
                return;
            }
            foreach (char c in input)
            {
                theStack.Push(c);
            }

            string inputReversed = "";
            while (theStack.Count > 0)
            {
                inputReversed += theStack.Pop();
            }

            Console.WriteLine(inputReversed);
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }
    }
}