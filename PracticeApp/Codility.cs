using System;
using System.Collections.Generic;

namespace PracticeApp
{
    public class Codility
    {
        public int FindGap(int num)
        {
            string str = Convert.ToString(num, 2);
            int zeroCount = 0, maxNum = 0;

            Console.WriteLine(string.Format("{0} equavelent binary is {1}", num, str));
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i].ToString() == "0")
                {
                    zeroCount++;
                }
                else if (str[i].ToString() == "1" && zeroCount > 0)
                {
                    if (maxNum < zeroCount) { maxNum = zeroCount; }
                    zeroCount = 0;
                }
            }

            return maxNum;
        }
        public int FindOddByPower(int[] A)
        {
            int res = 0;
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(string.Format("{0} of current  {1} is {2}", Convert.ToString(res, 2), Convert.ToString(A[i], 2), Convert.ToString(res ^ A[i], 2)));
                res = res ^ A[i];
            }
            return res;
        }

        public int FindOdd(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int missingVal = 0;
            for (int i = 0; i < A.Length; i++)
            {
                bool isFound = false;
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[i] == A[j] && i != j)
                    {
                        isFound = true;
                        break;
                    }
                }
                if (!isFound)
                {
                    missingVal = A[i];
                }

            }
            return missingVal;
        }

        public int[] CyclicRotation(int[] A, int K)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            for (int x = 0; x < K; x++)
            {
                int myVal = A[0];
                for (int i = 0; i < A.Length; i++)
                {
                    if (i == A.Length - 1)
                    {
                        A[0] = myVal;
                    }
                    else
                    {
                        var b = A[i + 1];
                        A[i + 1] = myVal;
                        myVal = b;
                    }

                }
            }
            return A;
        }

        public int FrogJump(int x, int y, int d)
        {

            if ((y - x) % d == 0)
            {
                return (y - x) / d;
            }
            return (y - x) / d + 1;
        }

        public int MissingParm(int[] A)
        {
            if (A.Length == 0) return 0;
            int max = 1;
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
                if (A[i] > max)
                {
                    max = A[i];
                }
            }

            int _actualSum = (1 + max) * max / 2;
            return _actualSum - sum;
        }

        public int Factorial(int n) {
            // 5 = 5 * 4 * 3 * 2 * 1
            if (n == 1) return 1;
            else { return n * Factorial(n-1);  }
        }


        public int Sequence(int n)
        {
            // 5 = 5 * 4 * 3 * 2 * 1
            if (n == 1) { Console.WriteLine(1); return 1; }
            else { Console.WriteLine(n); return Sequence(n - 1); }
        }

        public int Fabonacci(int n)
        {
            int a = 0, b = 1, c = 0, sum = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
                sum += c;
            }
            return sum+1;
        }


        

        public bool checkBraces(String braces)
        {
            bool isCorrect;
            Stack<char> stack = new Stack<char>();
            int openBCount = 0;
            int closeBCount = 0;

            for (int c = 0; c <= braces.Length - 1; c++)
            {
                //check for open braces push to stack

                if (braces[c] == '{' || braces[c] == '[' || braces[c] == '(')
                {


                    stack.Push(braces[c]);
                    openBCount++;

                }                                                                       ////check for close braces. pop the open braces
                                                                                        //compare it to the closed braces using the the 
                                                                                        //method ValidatePerBraces                                                                      
                                                                                        //therefor checking for CORRECTNEES of how the braces                                                                       //are closed
                else if (braces[c] == '}' || braces[c] == ']' || braces[c] == ')')
                {

                    closeBCount++;
                    if (!ValidatePerBraces(stack.Pop(), braces[c]))
                    {
                        isCorrect = false; //return false in case where they dont match
                        return isCorrect;
                    }

                }
                //for braces to be complete, open and close braces
                //should be even, if they are not even then it is 
                //for sure wrong at least for the specification.
                if (c >= braces.Length - 1)
                {

                    if (openBCount != closeBCount)
                    {
                        isCorrect = false;
                        return isCorrect;
                    }
                }

            }


            isCorrect = true; // true if they all match

            return isCorrect;
        }

        // returns true if validated
        public bool ValidatePerBraces(char a, char b)
        {

            return a == '(' && b == ')' || a == '[' && b == ']' || a == '{' && b == '}';

        }
    }
}
