using System;
using System.Collections.Generic;
using System.Linq;

namespace Morse
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Dictionary<char, string> alphabet = new Dictionary<char, string>
            {
                [' '] = "/",
                ['a']= ".-",
                ['b']= "-...",
                ['c']= "-.-.",
                ['d']= "-..",
                ['e'] = ".",
                ['f']= "..-.",
                ['g']= "--.",
                ['h']= "....",
                ['i']= "..",
                ['j']= ".---",
                ['k']= "-.-",
                ['l']= ".-..",
                ['m'] = "--",
                ['n']= "-.",
                ['o']= "---",
                ['p']= ".--.",
                ['q']= "--.-",
                ['r']= ".-.",
                ['s']= "...",
                ['t']= "-",
                ['u']= "..-",
                ['v']= "...-",
                ['w']= ".--",
                ['x']= "-..-",
                ['y']= "-.--",
                ['z'] = "--..",
                ['1']= ".----",
                ['2']= "..---",
                ['3']= "...--",
                ['4'] = "....-",
                ['5']= ".....",
                ['6']= "-....",
                ['7'] = "--...",
                ['8']= "---..",
                ['9']= "----.",
                ['0'] = "-----"

            };


           

            string input = Console.ReadLine().ToLower();

            char[] characters = input.ToCharArray();


            foreach (char item in characters)
            {
                Console.Write(alphabet[item]);
            }
            

        }
    }
}
