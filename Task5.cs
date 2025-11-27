using System;

class ReportCard
{
    static void Main()
    {
        // ==========================
        // 🔹 1. Ask Total Students
        // ==========================
        Console.Write("Enter Total Students : ");
        int totalStudents = Convert.ToInt32(Console.ReadLine());

        // ======================================
        // 🔹 2. Arrays to Store Student Data
        // ======================================
        int[,] marks = new int[totalStudents, 3]; // English, Math, Computer
        string[] names = new string[totalStudents];
        int[] totalMarks = new int[totalStudents];

        // ====================================
        // 🔹 3. Input Student Name & Marks
        // ====================================
        for (int i = 0; i < totalStudents; i++)
        {
            Console.Write("Enter Student Name : ");
            names[i] = Console.ReadLine();

            marks[i, 0] = InputMark("Enter English Marks (Out Of 100) : ");
            marks[i, 1] = InputMark("Enter Math Marks (Out Of 100) : ");
            marks[i, 2] = InputMark("Enter Computer Marks (Out Of 100) : ");

            // Calculate Total
            totalMarks[i] = marks[i, 0] + marks[i, 1] + marks[i, 2];
            Console.WriteLine("*********************************************");
        }

        // =======================================
        // 🔹 4. Sorting Students by Total (DESC)
        // =======================================
        for (int i = 0; i < totalStudents - 1; i++)
        {
            for (int j = i + 1; j < totalStudents; j++)
            {
                if (totalMarks[j] > totalMarks[i])
                {
                    // Swap Total
                    int tempTotal = totalMarks[i];
                    totalMarks[i] = totalMarks[j];
                    totalMarks[j] = tempTotal;

                    // Swap Names
                    string tempName = names[i];
                    names[i] = names[j];
                    names[j] = tempName;

                    // Swap Marks
                    for (int s = 0; s < 3; s++)
                    {
                        int tempMark = marks[i, s];
                        marks[i, s] = marks[j, s];
                        marks[j, s] = tempMark;
                    }
                }
            }
        }

        // =======================================
        // 🔹 5. Display Report Card
        // =======================================
        Console.WriteLine("****************Report Card*******************");

        for (int i = 0; i < totalStudents; i++)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine($"Student Name: {names[i]}, Position: {i + 1}, Total: {totalMarks[i]}/300");
        }
        Console.WriteLine("****************************************");
    }

    // ======================================
    // 🛠  Method: Validate Marks Input (0-100)
    // ======================================
    static int InputMark(string message)
    {
        int mark;
        do
        {
            Console.Write(message);
            bool isValid = int.TryParse(Console.ReadLine(), out mark);

            if (!isValid || mark < 0 || mark > 100)
            {
                Console.WriteLine("❌ Invalid input! Please enter a number between 0 and 100.");
            }
        } while (mark < 0 || mark > 100);
        
        return mark;
    }
}
