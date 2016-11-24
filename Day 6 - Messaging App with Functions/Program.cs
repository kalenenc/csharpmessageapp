using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6___Messaging_App_with_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----- Beginning ----
            bool running = true;
            string[] messageArray = new string[10];
            int counter = 0;

            while (running == true)
            {
                GetInfo("Would you like to save a message or retrieve a message? Enter either 'save' or 'retrieve.' You can enter up to 10 messages. Enter 'exit' to leave.");
                string input = Console.ReadLine().ToLower();

                if (input == "retrieve")
                {
                    Console.WriteLine("What message would you like to retrieve? give the ID");
                    int position = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine(messageArray[position]);
                    //retrieveMessage(position, messageArray);
                    Console.ReadLine();
                }

                //SAVE A MESSAGE
                else if (input == "save")
                {
                    GetInfo("Please write a message you would like to save");
                    string newMessage;
                    ReadMessage(newMessage);
                    MakeMessage(messageArray, newMessage, counter);
                    counter++;
                }
                //EXIT
                else if (input == "exit")
                {
                    running = false;
                    Console.WriteLine("Okay. Press enter to leave.");
                    break;
                }

                else if (input != "retrieve" || input != "save")
                {
                    Console.WriteLine("Please write either 'retrieve' or 'save'. Enter 'exit' to leave. Press enter to go back to the main menu");
                    Console.ReadLine();
                }
            }

            Console.ReadLine();
            // ---- End ----
        }

        static void GetInfo(string prompt)
        {
            Console.WriteLine(prompt);
        }

        static void MakeMessage (string[] messageArray, string newMessage, int counter)
        {
            messageArray[counter] = newMessage; 
            Console.WriteLine("Cool. Your message was saved with an ID of " + counter + ". Press enter to go back to main menu.");
            Console.ReadLine();
        }

        static void retrieveMessage(int position, string[] messageArray)
        {
            if ((messageArray[position] != null) && (position <= 9))
            {
                Console.WriteLine("Your message is the following: " + messageArray[position] + ". Press enter to go back to the main menu");
            }
            else if (messageArray[position] == null)
            {
                Console.WriteLine("Sorry! This isn't a valid ID. Are you sure you have a message in this position? Press enter to go back to main menu.");
            }
            else if (position > 10)
            {
                Console.WriteLine("You can only store up to 10 messages. Press enter to go back to the main menu.");
            }
        }

        static string ReadMessage(string message)
        {
            message = Console.ReadLine();
            return message;
        }

    }
  }

