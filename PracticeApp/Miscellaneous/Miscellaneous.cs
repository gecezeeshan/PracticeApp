using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Codility
{
    public class Miscellaneous
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

        public int Distinct(int[] A)
        {
            int N = A.Length;
            HashSet<int> coll = new HashSet<int>();
            for (int a = 0; a < N; a++)
            {
                if (A[a] > 0)
                {
                    coll.Add(A[a]);

                }
            }

            return coll.Count;
        }
        public int MissingSmallParm(int[] A)
        {
            //https://app.codility.com/c/feedback/demoCC42W3-SWB/
            int N = A.Length, res = 1;
            HashSet<int> coll = new HashSet<int>();
            for (int a = 0; a < N; a++)
            {
                if (A[a] > 0)
                {
                    coll.Add(A[a]);
                }
            }


            for (int i = 1; i <= N + 1; i++)
            {

                if (!coll.Contains(i))
                {
                    res = i; break;
                }

            }
            return res;
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

        public int Factorial(int n)
        {
            // 5 = 5 * 4 * 3 * 2 * 1
            if (n == 1) return 1;
            else { return n * Factorial(n - 1); }
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
            return sum + 1;
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

        public void Test()
        {
            Console.WriteLine(string.Format("gaps are {0}", FindGap(1041)));
            Console.WriteLine(string.Format("gaps are {0}", FindGap(529)));
            Console.WriteLine(string.Format("gaps are {0}", FindGap(32)));

            Console.WriteLine(string.Format("gaps are {0}", FindGap(2342)));
            int[] A = { 4, 5 };
            int odd = FindOddByPower(A);
            Console.WriteLine("odd is " + odd);


            int jumpCount = FrogJump(10, 85, 30);
            Console.WriteLine(string.Format("Jump Count {0}", jumpCount));
            int[] B = { 2, 3 };
            Console.WriteLine(string.Format("Missing Param {0}", MissingParm(B)));

            Console.WriteLine(string.Format("Factorial {0}", Factorial(3)));


            Console.WriteLine(string.Format("Sequence {0}", Sequence(10)));

            Console.WriteLine(string.Format("Fabbonacci {0}", Fabonacci(4)));


            Console.WriteLine(string.Format("Bracess {0}", checkBraces("{{6}+[5*(4)]}")));

            int[] distinctArr = { 1, 3, 1, 2, 3 };
            Console.WriteLine(string.Format("Missing Param {0}", Distinct(distinctArr)));
        }


        public void FormatString()
        {
            string S = "0 - 22 1985--324";

            //S = Regex.Replace(S, @"\-", "");
            //S = Regex.Replace(S, @"\s", "");
            //string formatted = "";
            //if (S.Length == 14)
            //{
            //    for (int i = 0; i < S.Length; i++)
            //    {
            //        formatted += S[i];
            //        if (((i % 3) == 2) && i != S.Length - 1)
            //        {
            //            formatted += "-";
            //        }
            //    }
            //}

            S = removeNonDigits(S);
            S =  formatPhoneNumber(S, checkNumberSize(S));
            Console.WriteLine(S);

        }


        private Boolean checkNumberSize(String phoneNumber)
        {
            return phoneNumber.Length % 3 == 1;
        }

        private String removeNonDigits(String s)
        {
            return s.Replace("[^0-9]", "");
        }

        private String formatPhoneNumber(String s, bool lastGroup)
        {
            String tempNumber = "";
            int dashCounter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (dashCounter < 3)
                {
                    tempNumber = string.Concat(tempNumber,s.Substring(i, i + 1));
                }
                else if (dashCounter == 3)
                {
                    tempNumber += "-";
                    tempNumber = string.Concat(tempNumber, s.Substring(i, i + 1));
                    dashCounter = 1;
                }
            }
            if (lastGroup)
            {
                char[] temp = tempNumber.ToCharArray();
                temp[temp.Length - 2] = temp[temp.Length - 3];
                temp[temp.Length - 3] = '-';
                tempNumber = new String(temp);
            }
            return tempNumber;
        }



        public String SearchNumber(String[] A, String[] B, String P)
        {

            List<String> sortedContacts = new List<string>();
            for (int i = 0; i < B.Length; i++)
                if (B[i].Contains(P))
                    sortedContacts.Add(A[i]);

            sortedContacts.Sort();

            return sortedContacts.Count == 0 ? "NO CONTACT" :   sortedContacts[0];
        }


       public class Graph
        {
            private int V; // No. of vertices
            private LinkedList<int>[] adj; //Adjacency List

            // Constructor
            public Graph(int v)
            {
                V = v;
                adj = new LinkedList<int>[v];
                for (int i = 0; i < v; ++i)
                    adj[i] = new LinkedList<int>();
            }

            // Function to add an edge into the graph
            public void addEdge(int v, int w)
            {
                adj[v].AddLast(w);
            }

            // prints BFS traversal from a given source s
           public  bool isReachable(int s, int d)
            {
                // LinkedList<int> temp = new LinkedList<int>();

                // Mark all the vertices as not visited(By default set
                // as false)
                bool[] visited = new bool[V];

                // Create a queue for BFS
                LinkedList<int> queue = new LinkedList<int>();

                // Mark the current node as visited and enqueue it
                visited[s] = true;
                queue.AddLast(s);

                // 'i' will be used to get all adjacent vertices of a vertex
                IEnumerator i;
                while (queue.Count != 0)
                {

                    // Dequeue a vertex from queue and print it
                    s = queue.First.Value;
                    queue.RemoveFirst();
                    int n;
                    i = adj[s].GetEnumerator();

                    // Get all adjacent vertices of the dequeued vertex s
                    // If a adjacent has not been visited, then mark it
                    // visited and enqueue it
                    while (i.MoveNext())
                    {
                        n = (int)i.Current;

                        // If this adjacent node is the destination node,
                        // then return true
                        if (n == d)
                            return true;

                        // Else, continue to do BFS
                        if (!visited[n])
                        {
                            visited[n] = true;
                            queue.AddLast(n);
                        }
                    }
                }

                // If BFS is complete without visited d
                return false;
            }


        }

        public bool GraphSol(int N, int[] A, int[] B)
        {
            Graph g = new Graph(N);
            for (int i = 0; i < N; i++)
            {
                g.addEdge(A[i], B[i]);
            }
            bool notFound = false;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (!g.isReachable(i, j))
                    {
                        notFound = true;

                        break;
                    }
                }
            }

            return notFound;


        }













    }
}
