using System;
using System.Collections.Generic;
using System.Text;

namespace SortLetters
{
    public class Sorting
    {
        static char[] Swap(int start, int end, char[] input)
        {
            char temp = input[start];
            input[start] = input[end];
            input[end] = temp;

            return input;
        }
        public static char[] SortLetters(char[] input)
        {
            int end = input.Length - 1;
            int count = 0;
            for (int start = 0; start < end;)
            {
                if (input[start] == 'b')
                {
                    Swap(start, end, input);
                    end--;
                    count++;
                }
                else if (input[start] == 'g')
                {
                    int find = end;

                    while (find > start)
                    {
                        if (input[find] == 'r')
                        {
                            Swap(start, find, input);
                            start++;
                            break;
                        }
                        else if (input[find] == 'b' && input[end] == 'g')
                        {
                            Swap(end, find, input);
                            end--;
                            find--;
                            count++;
                        }
                        else { find--; }
                    }
                    if (input[start] == 'g' && input[end] == 'b' || input[start] == 'g' && input[end] == 'g')
                    {
                        start++;
                    }
                }
                else
                {
                    start++;
                }
            }
            return input;
        }
    }
}
