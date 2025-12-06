using System;

class ReportCard
{
    static void Main()
    {
        Console.Write("Enter Total Students : ");
        int total = int.Parse(Console.ReadLine());

        // Multi-dimensional array: [student, data]
        // 0 = name, 1 = Eng, 2 = Math, 3 = Comp, 4 = Total
        string[,] data = new string[total, 5];

        // INPUT
        for (int i = 0; i < total; i++)
        {
            Console.Write("Enter Student Name : ");
            data[i, 0] = Console.ReadLine();   // Example: Lucy, Bartolo

            Console.Write("Enter English Marks (Out Of 100) : ");
            int eng = int.Parse(Console.ReadLine());

            Console.Write("Enter Math Marks (Out Of 100) : ");
            int math = int.Parse(Console.ReadLine());

            Console.Write("Enter Computer Marks (Out Of 100) : ");
            int comp = int.Parse(Console.ReadLine());

            int totalMarks = eng + math + comp;

            data[i, 1] = eng.ToString();
            data[i, 2] = math.ToString();
            data[i, 3] = comp.ToString();
            data[i, 4] = totalMarks.ToString();

            Console.WriteLine("*********************************************");
        }

        // SORT (Descending by total marks)
        for (int i = 0; i < total - 1; i++)
        {
            for (int j = i + 1; j < total; j++)
            {
                if (int.Parse(data[j, 4]) > int.Parse(data[i, 4]))
                {
                    for (int k = 0; k < 5; k++)
                    {
                        string temp = data[i, k];
                        data[i, k] = data[j, k];
                        data[j, k] = temp;
                    }
                }
            }
        }

        // OUTPUT
        Console.WriteLine("****************Report Card*******************");

        for (int i = 0; i < total; i++)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine($"Student Name: {data[i, 0]}, Position: {i + 1}, Total: {data[i, 4]}/300");
            Console.WriteLine("****************************************");
        }
    }
}
