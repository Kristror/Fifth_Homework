using System;

namespace SchoolBoys
{
    partial class Program
    {
        class Pupils
        {
            private string name;
            private string surname;
            private UInt16 grade1;
            private UInt16 grade2;
            private UInt16 grade3;

            public Pupils(string str)
            {
                string[] words = str.Split(' ');
                surname = words[0];
                name = words[1];
                UInt16.TryParse(words[2], out grade1);
                UInt16.TryParse(words[3], out grade2);
                UInt16.TryParse(words[4], out grade3);
            }
            public double Average
            {
                get
                {
                    double sum = grade1 + grade2 + grade3;
                    return sum/3;
                }
            }
            public static void Worst(Pupils[] pupils)
            {
                for (int i = 0; i < pupils.Length; i++)
                    for (int j = i + 1; j < pupils.Length; j++)
                        if (pupils[i].Average > pupils[j].Average)
                        {
                            var tmp = pupils[j];
                            pupils[j] = pupils[i];
                            pupils[i] = tmp;
                        }
                int countworse = 0;
                for(int i = 1; i < pupils.Length; i++)
                {
                    if(pupils[i].Average > pupils[i - 1].Average)
                    {
                        countworse++;
                    }
                    if (countworse == 3)
                    {
                        countworse = i;
                        break;
                    }
                }
                Pupils.Print(pupils, countworse);
            }

            public static void Print(Pupils[] pupils)
            {
                foreach(var pupil in pupils)
                {
                    Console.WriteLine($"{pupil.surname} {pupil.name} {pupil.Average:f2}");
                }
            }
            public static void Print(Pupils[] pupils, int count)
            {
               for(int i = 0; i< count; i++) 
               { 
                    Console.WriteLine($"{pupils[i].surname} {pupils[i].name} {pupils[i].Average:f2}");
               }
            }
        }
    }
}
