using System;

namespace Program_TF
{
    class Program
    {
        static void Main(string[] args)
        {
            // กำหนดการใส่ ค่าความจริง True และ False เป็น 1 และ 0 ตามลำดับ
            // กำหนดการใส่ เครื่องหมาย
            // 1.เครื่องหมาย ^ (และ)     ใส่แทนด้วยเลข 1
            // 2.เครื่องหมาย v (หรือ)     ใส่แทนด้วยเลข 2
            // 3.เครื่องหมาย -> (ถ้า-แล้ว)  ใส่แทนด้วยเลข 3
            // 4.เครื่องหมาย <-> (ก็ต่อเมื่อ) ใส่แทนด้วยเลข 4
            // กำหนดการใส่ Pattern
            // 1. (A ^ B) v C           ใส่แทนด้วยเลข 1
            // 2. A ^ (B v C)           ใส่แทนด้วยเลข 2

            Console.WriteLine("P    Q    P ^ Q    P v Q    P -> Q    P <-> Q");
            Console.WriteLine("");
            Console.WriteLine("T    T      T        T        T          T");
            Console.WriteLine("T    F      F        T        F          F");
            Console.WriteLine("F    T      F        T        T          F");
            Console.WriteLine("F    F      F        F        T          T");
            Console.WriteLine("");
            
            Console.Write("Variables = ");
            int N = int.Parse(Console.ReadLine());

            int MARK,MARK1,MARK2;
            int P,Q,R,Pattern;

            if ((N < 2) || (N > 3))
            {
                Console.Write("Program Error");
            }
            if (N == 2)
            {
                Console.Write("Reality value P is ");
                P = int.Parse(Console.ReadLine());
                Console.Write("Reality value Q is ");
                Q = int.Parse(Console.ReadLine());
                Console.Write("MARK is ");
                MARK = int.Parse(Console.ReadLine());
                
                if ((P == 0) && (Q == 1) && (MARK == 1))
                {
                    Console.Write("Answer is P ^ Q = False");
                }
                if ((P == 0) && (Q == 1) && (MARK == 2))
                {
                    Console.Write("Answer is P v Q = True");
                }
                if ((P == 0) && (Q == 1) && (MARK == 3))
                {
                    Console.Write("Answer is P -> Q = True");
                }
                if ((P == 0) && (Q == 1) && (MARK == 4))
                {
                    Console.Write("Answer is P <-> Q = False");
                }
                
                if ((P == 0) && (Q == 0) && (MARK == 1))
                {
                    Console.Write("Answer is P ^ Q = False");
                }
                if ((P == 0) && (Q == 0) && (MARK == 2))
                {
                    Console.Write("Answer is P v Q = False");
                }
                if ((P == 0) && (Q == 0) && (MARK == 3))
                {
                    Console.Write("Answer is P -> Q = True");
                }
                if ((P == 0) && (Q == 0) && (MARK == 4))
                {
                    Console.Write("Answer is P <-> Q = True");
                }
                
                if ((P == 1) && (Q == 1) && (MARK == 1))
                {
                    Console.Write("Answer is P ^ Q = True");
                }
                if ((P == 1) && (Q == 1) && (MARK == 2))
                {
                    Console.Write("Answer is P v Q = True");
                }
                if ((P == 1) && (Q == 1) && (MARK == 3))
                {
                    Console.Write("Answer is P -> Q = True");
                }
                if ((P == 1) && (Q == 1) && (MARK == 4))
                {
                    Console.Write("Answer is P <-> Q = True");
                }
                
                if ((P == 1) && (Q == 0) && (MARK == 1))
                {
                    Console.Write("Answer is P ^ Q = False");
                }
                if ((P == 1) && (Q == 0) && (MARK == 2))
                {
                    Console.Write("Answer is P v Q = True");
                }
                if ((P == 1) && (Q == 0) && (MARK == 3))
                {
                    Console.Write("Answer is P -> Q = False");
                }
                if ((P == 1) && (Q == 0) && (MARK == 4))
                {
                    Console.Write("Answer is P <-> Q = False");
                }

                if ((P < 0) || (P > 1) || (Q < 0) || (Q > 1) || (MARK < 1) || (MARK > 4))
                {
                    Console.Write("Program Error");
                }
            }
            if (N == 3)
            {
                Console.Write("Reality value P is ");
                P = int.Parse(Console.ReadLine());
                Console.Write("Reality value Q is ");
                Q = int.Parse(Console.ReadLine());
                Console.Write("Reality value R is ");
                R = int.Parse(Console.ReadLine());
                Console.Write("Pattern is ");
                Pattern = int.Parse(Console.ReadLine());
                if (Pattern == 1 || Pattern == 2)
                {
                    Console.Write("MARK 1 is ");
                    MARK1 = int.Parse(Console.ReadLine());
                    Console.Write("MARK 2 is ");
                    MARK2 = int.Parse(Console.ReadLine());
                    if(Pattern == 1)
                    {
                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 1) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P ^ Q) ^ R = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 1) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P ^ Q) ^ R = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 1) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P ^ Q) ^ R = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 1) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P ^ Q) ^ R = False");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 1) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P ^ Q) ^ R = False");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 1) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P ^ Q) ^ R = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 1) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P ^ Q) ^ R = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 1) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P ^ Q) ^ R = False");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 1) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P ^ Q) v R = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 1) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P ^ Q) v R = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 1) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P ^ Q) v R = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 1) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P ^ Q) v R = False");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 1) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P ^ Q) v R = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 1) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P ^ Q) v R = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 1) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P ^ Q) v R = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 1) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P ^ Q) v R = False");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 1) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P ^ Q) -> R = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 1) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P ^ Q) -> R = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 1) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P ^ Q) -> R = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 1) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P ^ Q) -> R = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 1) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P ^ Q) -> R = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 1) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P ^ Q) -> R = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 1) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P ^ Q) -> R = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 1) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P ^ Q) -> R = True");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 1) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P ^ Q) <-> R = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 1) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P ^ Q) <-> R = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 1) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P ^ Q) <-> R = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 1) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P ^ Q) <-> R = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 1) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P ^ Q) <-> R = False");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 1) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P ^ Q) <-> R = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 1) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P ^ Q) <-> R = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 1) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P ^ Q) <-> R = True");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 2) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P v Q) ^ R = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 2) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P v Q) ^ R = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 2) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P v Q) ^ R = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 2) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P v Q) ^ R = False");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 2) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P v Q) ^ R = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 2) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P v Q) ^ R = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 2) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P v Q) ^ R = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 2) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P v Q) ^ R = False");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 2) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P v Q) v R = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 2) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P v Q) v R = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 2) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P v Q) v R = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 2) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P v Q) v R = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 2) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P v Q) v R = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 2) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P v Q) v R = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 2) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P v Q) v R = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 2) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P v Q) v R = False");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 2) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P v Q) -> R = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 2) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P v Q) -> R = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 2) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P v Q) -> R = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 2) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P v Q) -> R = False");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 2) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P v Q) -> R = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 2) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P v Q) -> R = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 2) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P v Q) -> R = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 2) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P v Q) -> R = True");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 2) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P v Q) <-> R = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 2) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P v Q) <-> R = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 2) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P v Q) <-> R = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 2) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P v Q) <-> R = False");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 2) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P v Q) <-> R = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 2) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P v Q) <-> R = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 2) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P v Q) <-> R = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 2) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P v Q) <-> R = True");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 3) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P -> Q) ^ R = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 3) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P -> Q) ^ R = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 3) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P -> Q) ^ R = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 3) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P -> Q) ^ R = False");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 3) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P -> Q) ^ R = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 3) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P -> Q) ^ R = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 3) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P -> Q) ^ R = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 3) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P -> Q) ^ R = False");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 3) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P -> Q) v R = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 3) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P -> Q) v R = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 3) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P -> Q) v R = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 3) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P -> Q) v R = False");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 3) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P -> Q) v R = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 3) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P -> Q) v R = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 3) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P -> Q) v R = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 3) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P -> Q) v R = False");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 3) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P -> Q) -> R = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 3) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P -> Q) -> R = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 3) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P -> Q) -> R = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 3) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P -> Q) -> R = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 3) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P -> Q) -> R = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 3) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P -> Q) -> R = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 3) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P -> Q) -> R = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 3) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P -> Q) -> R = False");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 3) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P -> Q) <-> R = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 3) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P -> Q) <-> R = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 3) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P -> Q) <-> R = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 3) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P -> Q) <-> R = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 3) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P -> Q) <-> R = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 3) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P -> Q) <-> R = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 3) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P -> Q) <-> R = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 3) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P -> Q) <-> R = False");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 4) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P <-> Q) ^ R = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 4) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P <-> Q) ^ R = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 4) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P <-> Q) ^ R = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 4) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P <-> Q) ^ R = False");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 4) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P <-> Q) ^ R = False");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 4) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P <-> Q) ^ R = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 4) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P <-> Q) ^ R = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 4) && (MARK2 == 1))
                        {
                            Console.Write("Answer is (P <-> Q) ^ R = False");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 4) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P <-> Q) v R = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 4) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P <-> Q) v R = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 4) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P <-> Q) v R = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 4) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P <-> Q) v R = False");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 4) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P <-> Q) v R = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 4) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P <-> Q) v R = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 4) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P <-> Q) v R = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 4) && (MARK2 == 2))
                        {
                            Console.Write("Answer is (P <-> Q) v R = True");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 4) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P <-> Q) -> R = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 4) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P <-> Q) -> R = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 4) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P <-> Q) -> R = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 4) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P <-> Q) -> R = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 4) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P <-> Q) -> R = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 4) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P <-> Q) -> R = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 4) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P <-> Q) -> R = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 4) && (MARK2 == 3))
                        {
                            Console.Write("Answer is (P <-> Q) -> R = False");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 4) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P <-> Q) <-> R = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 4) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P <-> Q) <-> R = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 4) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P <-> Q) <-> R = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 4) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P <-> Q) <-> R = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 4) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P <-> Q) <-> R = False");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 4) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P <-> Q) <-> R = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 4) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P <-> Q) <-> R = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 4) && (MARK2 == 4))
                        {
                            Console.Write("Answer is (P <-> Q) <-> R = False");
                        }
                    }
                    if (Pattern == 2)
                    {
                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 1) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P ^ (Q ^ R) = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 1) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P ^ (Q ^ R) = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 1) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P ^ (Q ^ R) = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 1) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P ^ (Q ^ R) = False");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 1) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P ^ (Q ^ R) = False");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 1) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P ^ (Q ^ R) = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 1) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P ^ (Q ^ R) = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 1) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P ^ (Q ^ R) = False");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 1) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P ^ (Q v R) = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 1) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P ^ (Q v R) = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 1) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P ^ (Q v R) = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 1) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P ^ (Q v R) = False");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 1) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P ^ (Q v R) = False");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 1) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P ^ (Q v R) = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 1) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P ^ (Q v R) = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 1) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P ^ (Q v R) = False");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 1) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P ^ (Q -> R) = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 1) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P ^ (Q -> R) = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 1) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P ^ (Q -> R) = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 1) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P ^ (Q -> R) = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 1) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P ^ (Q -> R) = False");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 1) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P ^ (Q -> R) = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 1) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P ^ (Q -> R) = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 1) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P ^ (Q -> R) = False");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 1) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P ^ (Q <-> R) = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 1) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P ^ (Q <-> R) = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 1) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P ^ (Q <-> R) = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 1) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P ^ (Q <-> R) = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 1) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P ^ (Q <-> R) = False");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 1) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P ^ (Q <-> R) = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 1) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P ^ (Q <-> R) = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 1) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P ^ (Q <-> R) = False");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 2) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P v (Q ^ R) = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 2) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P v (Q ^ R) = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 2) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P v (Q ^ R) = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 2) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P v (Q ^ R) = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 2) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P v (Q ^ R) = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 2) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P v (Q ^ R) = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 2) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P v (Q ^ R) = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 2) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P v (Q ^ R) = False");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 2) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P v (Q v R) = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 2) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P v (Q v R) = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 2) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P v (Q v R) = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 2) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P v (Q v R) = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 2) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P v (Q v R) = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 2) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P v (Q v R) = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 2) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P v (Q v R) = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 2) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P v (Q v R) = False");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 2) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P v (Q -> R) = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 2) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P v (Q -> R) = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 2) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P v (Q -> R) = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 2) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P v (Q -> R) = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 2) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P v (Q -> R) = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 2) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P v (Q -> R) = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 2) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P v (Q -> R) = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 2) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P v (Q -> R) = True");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 2) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P v (Q <-> R) = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 2) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P v (Q <-> R) = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 2) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P v (Q <-> R) = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 2) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P v (Q <-> R) = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 2) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P v (Q <-> R) = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 2) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P v (Q <-> R) = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 2) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P v (Q <-> R) = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 2) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P v (Q <-> R) = True");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 3) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P -> (Q ^ R) = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 3) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P -> (Q ^ R) = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 3) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P -> (Q ^ R) = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 3) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P -> (Q ^ R) = False");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 3) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P -> (Q ^ R) = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 3) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P -> (Q ^ R) = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 3) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P -> (Q ^ R) = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 3) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P -> (Q ^ R) = True");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 3) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P -> (Q v R) = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 3) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P -> (Q v R) = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 3) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P -> (Q v R) = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 3) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P -> (Q v R) = False");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 3) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P -> (Q v R) = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 3) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P -> (Q v R) = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 3) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P -> (Q v R) = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 3) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P -> (Q v R) = True");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 3) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P -> (Q -> R) = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 3) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P -> (Q -> R) = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 3) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P -> (Q -> R) = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 3) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P -> (Q -> R) = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 3) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P -> (Q -> R) = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 3) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P -> (Q -> R) = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 3) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P -> (Q -> R) = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 3) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P -> (Q -> R) = True");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 3) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P -> (Q <-> R) = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 3) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P -> (Q <-> R) = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 3) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P -> (Q <-> R) = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 3) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P -> (Q <-> R) = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 3) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P -> (Q <-> R) = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 3) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P -> (Q <-> R) = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 3) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P -> (Q <-> R) = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 3) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P -> (Q <-> R) = True");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 4) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P <-> (Q ^ R) = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 4) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P <-> (Q ^ R) = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 4) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P <-> (Q ^ R) = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 4) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P <-> (Q ^ R) = False");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 4) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P <-> (Q ^ R) = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 4) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P <-> (Q ^ R) = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 4) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P <-> (Q ^ R) = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 4) && (MARK2 == 1))
                        {
                            Console.Write("Answer is P <-> (Q ^ R) = False");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 4) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P <-> (Q v R) = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 4) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P <-> (Q v R) = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 4) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P <-> (Q v R) = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 4) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P <-> (Q v R) = False");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 4) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P <-> (Q v R) = False");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 4) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P <-> (Q v R) = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 4) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P <-> (Q v R) = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 4) && (MARK2 == 2))
                        {
                            Console.Write("Answer is P <-> (Q v R) = True");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 4) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P <-> (Q -> R) = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 4) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P <-> (Q -> R) = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 4) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P <-> (Q -> R) = True");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 4) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P <-> (Q -> R) = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 4) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P <-> (Q -> R) = False");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 4) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P <-> (Q -> R) = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 4) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P <-> (Q -> R) = False");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 4) && (MARK2 == 3))
                        {
                            Console.Write("Answer is P <-> (Q -> R) = False");
                        }

                        if ((P == 1) && (Q == 1) && (R == 1) && (MARK1 == 4) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P <-> (Q <-> R) = True");
                        }
                        if ((P == 1) && (Q == 1) && (R == 0) && (MARK1 == 4) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P <-> (Q <-> R) = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 1) && (MARK1 == 4) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P <-> (Q <-> R) = False");
                        }
                        if ((P == 1) && (Q == 0) && (R == 0) && (MARK1 == 4) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P <-> (Q <-> R) = True");
                        }
                        if ((P == 0) && (Q == 1) && (R == 1) && (MARK1 == 4) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P <-> (Q <-> R) = False");
                        }
                        if ((P == 0) && (Q == 1) && (R == 0) && (MARK1 == 4) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P <-> (Q <-> R) = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 1) && (MARK1 == 4) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P <-> (Q <-> R) = True");
                        }
                        if ((P == 0) && (Q == 0) && (R == 0) && (MARK1 == 4) && (MARK2 == 4))
                        {
                            Console.Write("Answer is P <-> (Q <-> R) = False");
                        }

                        if ((P < 0) || (P > 1) || (Q < 0) || (Q > 1) || (R > 1) || (R < 0) || (MARK1 < 1) || (MARK1 > 4) || (MARK2 < 1) || (MARK2 > 4))
                        {
                            Console.Write("Program Error");
                        }

                    }
                }
                
            }

             Console.ReadLine();
        }
    }
}
