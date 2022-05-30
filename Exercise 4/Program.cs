namespace Exercise_4
{
    internal class Program
    {

        public static void ExamineList()
        {
            Console.WriteLine("-------------- ExamineList() ---------------");
            Console.WriteLine();
            List<int> list = new List<int>(6);
            Console.WriteLine($"The list capacity is: {list.Capacity}");
            Console.WriteLine($"The current list length is: {list.Count}");

            /*
            Console.WriteLine("--------------------------------------------");
            list.Add(55);
            Console.WriteLine($"The list capacity is: {list.Capacity}");
            Console.WriteLine($"The current list length is: {list.Count}");

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine($"list[{i}] = {list[i]}");
            
            Console.WriteLine("--------------------------------------------");
            list.Add(66);
            Console.WriteLine($"The list capacity is: {list.Capacity}");
            Console.WriteLine($"The current list length is: {list.Count}");
            */

            Console.WriteLine("--------------------------------------------");
            list.Add(66);
            list.Add(66);
            list.Add(66);
            list.Add(66);
            list.Add(66);
            list.Add(66);
            list.Add(66);
            Console.WriteLine($"The list capacity is: {list.Capacity}");
            Console.WriteLine($"The current list length is: {list.Count}");

            Console.WriteLine("--------------------------------------------");
            list.Remove(list[0]);
            list.Remove(list[1]);
            list.Remove(list[2]);
            Console.WriteLine($"The list capacity is: {list.Capacity}");
            Console.WriteLine($"The current list length is: {list.Count}");

        }

        public static void ExamineQueue()
        {
            Console.WriteLine();
            Console.WriteLine("-------------- ExamineQueue() --------------");
            Console.WriteLine();

            Thread.Sleep(200);
            Queue<string> queue = new Queue<string>();
            Console.WriteLine("ICA öppnar och kön till kassan är tom");

            Thread.Sleep(200);
            Queuing("Kalle", queue);

            Thread.Sleep(200);
            Queuing("Greta", queue);

            Thread.Sleep(200);
            Dequeuing(queue);

            Thread.Sleep(200);
            Queuing("Stina", queue);

            Thread.Sleep(200);
            Dequeuing(queue);

            Thread.Sleep(200);
            Queuing("Olle", queue);
        }
        public static void Queuing(string Name, Queue<string> queue)
        {
            queue.Enqueue(Name);
            Console.WriteLine($"{Name} ställer sig i kön");
        }

        public static void Dequeuing(Queue<string> queue)
        {
            Console.WriteLine($"{queue.Dequeue()} blir expedierad och lämnar kön");
        }

        public static void ExamineStack()
        {
            Console.WriteLine();
            Console.WriteLine("-------------- ExamineStack() --------------");
            Console.WriteLine();

            Thread.Sleep(200);
            Stack<string> stack = new Stack<string>();
            Console.WriteLine("ICA öppnar och kön till kassan är tom");

            Thread.Sleep(200);
            Pushing("Kalle", stack);

            Thread.Sleep(200);
            Pushing("Greta", stack);

            Thread.Sleep(200);
            Poping(stack);

            Thread.Sleep(200);
            Pushing("Stina", stack);

            Thread.Sleep(200);
            Poping(stack);

            Thread.Sleep(200);
            Pushing("Olle", stack);
        }
        public static void Pushing(string Name, Stack<string> queue)
        {
            queue.Push(Name);
            Console.WriteLine($"{Name} ställer sig i kön");
        }

        public static void Poping(Stack<string> queue)
        {
            Console.WriteLine($"{queue.Pop()} blir expedierad och lämnar kön");
        }


        public static void ReverseText()
        {
            Console.WriteLine();
            Console.WriteLine("-------------- ReverseText() --------------");
            Console.WriteLine();

            Stack<char> stack = new Stack<char>();

            Console.WriteLine("Var snäll och mata in en text så den blir omvänd:");

            string sentence = Console.ReadLine();

            char[] charArr = sentence.ToCharArray();

            foreach (char c in sentence)
                stack.Push(c);

            for (int i = 0; i < sentence.Length; i++)
                Console.Write(stack.Pop());

        }

        public static void CheckParantheses()
        {
            Console.WriteLine();
            Console.WriteLine("------------ CheckParantheses() ------------");
            Console.WriteLine();
            
            string sentence = "";
            bool checkNull = true;

            Console.WriteLine("Var snäll och mata in en sträng så programmet kontrollerar huruvida strängen är en välformad eller ej:");

            do
            {
                sentence = Console.ReadLine();

                if (sentence == null || sentence == "")
                { 
                    Console.WriteLine("Var snäll och mata in en sträng");
                    checkNull = true;
                }
                else
                    checkNull = false;

            } while(checkNull);

            if (CkeckTheParentheses(sentence))
                Console.WriteLine("Bra! Strängen är en välformad");
            else
                Console.WriteLine("Strängen är inte välformad!");

        }

        public static bool CkeckTheParentheses(string sentence)
        {
            Stack<char> stack = new Stack<char>();
            char[] charArr = sentence.ToCharArray();
            
            foreach (char c in charArr)
            {
                if (c == '{' || c == '[' || c == '(')
                    stack.Push(c);
                else if (c == '}' || c == ']' || c == ')')
                    stack.Pop();
            }

            if (stack.Count == 0)
                return true;
            else 
                return false;
                
        }

        public static int RecursiveOdd(int n)
        {
            Console.WriteLine($"n = {n}");
            if(n == 0)
            {
                return 1;
            }
            return (RecursiveOdd(n - 1) + 2);
        }

        public static int RecursiveEven(int n)
        {
            Console.WriteLine($"n = {n}");
            if (n == 0)
            {
                return 2;
            }
            return (RecursiveEven(n - 1) + 2);
        }

        public static int FibonacciSequences(int n)
        {
            Console.WriteLine($"n = {n}");

            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
                return FibonacciSequences(n - 1) + FibonacciSequences(n - 2);
        }

        public static int IterativeOdd(int n)
        {
            Console.WriteLine($"n = {n}");
            if (n == 0) return 1;

            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result += 2;
            }
            return result;
        }

        public static int IterativeEven(int n)
        {
            Console.WriteLine($"n = {n}");
            if (n == 0) return 2;

            int result = 2;

            for (int i = 1; i <= n; i++)
            {
                result += 2;
            }
            return result;
        }

        public static int FibonacciIterative(int n)
        {
            int result = 0;
            int previous = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = result;
                result = previous;
                previous = temp + previous;
            }
            return result;
        }

        static void Main(string[] args)
        {
            // 1.
            // Stack:
            // Stacken är en plats på minnet som följer principen "LIFO" (Last in First out)
            // och det innebär att värdet som lagras sist hämtas först
            // och tas bort från stacken.
            //
            // Heap: 
            // Heap är en plats på minnet som lagrar Reference-type som class, interface, delegate, string och object
            // Heapen gör alla värden tillgängliga oavsett lagring ordern

            // 2.
            // Value-Type:
            // Är alla primitiva värde som int, float, double, och char är Value-type.
            // Baserat på den valda typen kommer kompilatorn att allokera en plats på
            // minnet på "Stacken" eller "Heapen" för att lagra värdet.
            // En Value-type tas bort automatiskt när det är färdigkört och det används inte längre
            // 
            // Reference-Type:
            // Alla typer som ärvas från (System.Object.object) som class, interface, object, delegate och string.
            // Vanligtvis pekar "Pointers" på Reference-Type.
            // En Reference-Type tas bort av GC (Garbage Collector) när den fölorar sin pekare

            // 3.
            // Det första programmet retunerar "3" eftersom variabln är Value-Type 
            // Det andra programmet retunerar "4" eftersom variabln är Reference-Type

            //----------------------------------------------- ExamineList() --------------------------------------------
            // Övning 1: ExamineList()

            //ExamineList();

            // 2. Ökar listans kapacitet när vi försöker lägga till en ny element mer än "listans Count".
            // 3. Kapacitetsstorleken blir dubbelt så stor som den underliggande arrayen.
            // 4. Eftersom det här alternativet påverkas prestandan om man ökar kapacitet
            //    med en plats varje gång särkild när man ökar capacitiet ofta.
            // 5. Nej, Storleken stannar som den sista gången.
            // 6. När man är säker att det behövs inte att förändra storleken ofta.

            //----------------------------------------------- ExamineQueue() -------------------------------------------
            // Övning 2: ExamineQueue()

            //ExamineQueue();


            //----------------------------------------------- ExamineStack() -------------------------------------------
            // Övning 3: ExamineStack()

            //ExamineStack();

            // 1. Det är dumt att använda en stack på det här fallet eftersom "Kalle" som kom först fortfarande väntar på de andra
            // för att bli expedierade, och inte bara detta men också han ska vänta på varje ny person tills stacken blir tom för
            // att få hans tur.

            //ReverseText();

            //---------------------------------------------- CheckParantheses() ----------------------------------------
            // Övning 4: CheckParantheses()

            // CheckParantheses();

            //-------------------------------------------------- Rekursion -------------------------------------------
            // Övning 5: Rekursion
            // 1. Oavsett inmatade värdet returnerar metoden "RecursiveOdd" ett udda värde. 

            Console.WriteLine();
            Console.WriteLine("------------ RecursiveOdd() ------------");
            Console.WriteLine();
            int n = 3;
            
            Console.WriteLine($"RecursiveOdd({n}) = {RecursiveOdd(n)}");
 

            Console.WriteLine();
            Console.WriteLine("------------ RecursiveEven() ------------");
            Console.WriteLine();
            
            // 2. Oavsett inmatade värdet returnerar metoden "RecursiveEven" ett jämnt värde.
            
            Console.WriteLine($"RecursiveEven({n}) = {RecursiveEven(n)}");

            // 3. FibonacciSequences()
            Console.WriteLine();
            Console.WriteLine("------------ FibonacciSequences() ------------");
            Console.WriteLine();
            
            Console.WriteLine($"Fibonacci Sequences({n}) = {FibonacciSequences(n)}");

            //-------------------------------------------------- Iteration -------------------------------------------
            // Övning 6: Iteration
            
            Console.WriteLine();
            Console.WriteLine("------------ Iteration ------------");
            Console.WriteLine();

            Console.WriteLine($"IterativeOdd({n}): {IterativeOdd(n)}");
            Console.WriteLine($"IterativeEven({n}): {IterativeEven(n)}");
            
            Console.WriteLine();
            Console.WriteLine($"FibonacciIterative({n}): {FibonacciIterative(n)}");

            // Rekursion: Behöver mer minne men den tar kortare tid för beräkningen eftersom varje anrop behöver en plats på stacken
            
            // Iteration: Behöver mindre minne så den är mer minnesvänlig men den tar längre tid för beräkningen
            // eftersom den är helt beroende på processorn






        }
    }
}