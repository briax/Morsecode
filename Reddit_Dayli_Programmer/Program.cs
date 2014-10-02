using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reddit_Dayli_Programmer
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> dictionary = new Dictionary<char, string>();
            StringBuilder sb = new StringBuilder();

            dictionary.Add('a', ".-");
            dictionary.Add('b', "-..");
            dictionary.Add('c', "-.-.");
            dictionary.Add('d', "-..");
            dictionary.Add('e', ".");
            dictionary.Add('f', "..-.");
            dictionary.Add('g', "--.");
            dictionary.Add('h', "....");
            dictionary.Add('i', "..");
            dictionary.Add('j', ".---");
            dictionary.Add('k', "-.-");
            dictionary.Add('l', ".-..");
            dictionary.Add('m', "--");
            dictionary.Add('n', "-.");
            dictionary.Add('o', "---");
            dictionary.Add('p', ".--.");
            dictionary.Add('q', "--.-");
            dictionary.Add('r', ".-.");
            dictionary.Add('s', "...");
            dictionary.Add('t', "-");
            dictionary.Add('u', "..-");
            dictionary.Add('v', "...-");
            dictionary.Add('w', ".--");
            dictionary.Add('x', "-..-");
            dictionary.Add('y', "-.--");
            dictionary.Add('z', "--..");
            dictionary.Add('1', ".----");
            dictionary.Add('2', "..---");
            dictionary.Add('3', "...--");
            dictionary.Add('4', "....-");
            dictionary.Add('5', ".....");
            dictionary.Add('6', "-....");
            dictionary.Add('7', "--...");
            dictionary.Add('8', "---..");
            dictionary.Add('9', "----.");
            dictionary.Add('0', "-----");
            dictionary.Add(' ', "/");

            string input = "I like cats";

            foreach(char c in input){
                char ch = Char.ToLower(c);
                if (dictionary.ContainsKey(ch))
                {
                    sb.Append(dictionary[ch]).Append(" ");
                }
            }

            Console.WriteLine(sb);
            string output = sb.ToString();
            int length = 400;

            Console.WriteLine(output);
            
            foreach (char c in output)
            {
                if (c.Equals('.'))
                {
                    Console.Beep(2200, length);
                }
                else if (c.Equals('-'))
                {
                    Console.Beep(2200, length*3);
                }
                else if (c.Equals('/'))
                {
                    Console.Beep(38, length*7);
                }
                else if(c.Equals(' '))
                {
                    Console.Beep(38, length);
                }
            }
            
        }
    }
}
