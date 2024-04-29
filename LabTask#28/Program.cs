using LabTask_28;
using System.Globalization;


internal class Program
{
    private static void Main(string[] args)
    {
    checkingChoose:
        Console.WriteLine("Ne qeder imtahan elave etmek isteyirsiz?");
        string input = Console.ReadLine();
        bool checkChoose = int.TryParse(input, out int choice);
        if (!checkChoose) goto checkingChoose;
        int choose = 1;

        List<Exam> examList = new();
        Student student = new("Aziz", "Rahimov", 25);

      

        while (choose <= choice)
        {
        checkingPoint:
            Console.WriteLine("Imtahan balini qeyd edin:");
            string inputPoint = Console.ReadLine();
            bool checkPoint = byte.TryParse(inputPoint, out byte point);
            if (!checkPoint) goto checkingPoint;
            Console.WriteLine("Imtahan movzusunu qeyd edin: ");
            string subject = Console.ReadLine();
        checkingDate:
            Console.WriteLine("Imtahanin baslama tarixini qeyd edin(bu formatda qeyd edin: AY.GUN.IL SAAT:SAAT ): ");
            string inputDate = Console.ReadLine();
            bool checkDate = DateTime.TryParse(inputDate, out DateTime startDate);
            if (!checkDate) goto checkingDate;
            checkingDateEnd:
            Console.WriteLine("Imtahanin bitme tarixini qeyd edin(bu formatda qeyd edin: AY.GUN.IL SAAT:SAAT ): ");
            string inputDateEnd = Console.ReadLine();
            bool checkDateEnd = DateTime.TryParse(inputDateEnd, out DateTime startDateEnd);
            if (!checkDateEnd) goto checkingDateEnd;
            Exam exam = new(student, point, subject, startDate, startDateEnd);
            examList.Add(exam);
            Console.WriteLine("Imtahan ugurla elave edildi :)");
            choose++;
        }
        GetExamGreaterThan50(examList);
        GetExamGreaterOneHours(examList);

        void GetExamGreaterThan50(List<Exam> examLists)
        {
            foreach (var item in examLists)
            {
                if (item.ExamPoint > 50)
                {
                    Console.WriteLine($"Imtahan movzusu: {item.Subject} ve Imtahan bali: {item.ExamPoint}");
                }
            }
        }
        void GetExamGreaterOneHours(List<Exam> examLists)
        {
            foreach (var item in examLists)
            {
                if (item.EndDate - item.StartDate > new TimeSpan(1,0,0))
                {
                    Console.WriteLine($"Imtahan movzusu: {item.Subject} ve Imtahan bali: {item.ExamPoint}");

                }
            }
        }
    }
}