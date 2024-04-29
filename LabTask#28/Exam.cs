using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask_28
{
    internal class Exam
    {
        public Student Student { get; set; }
        public byte ExamPoint { get; set; }
        public string Subject { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Exam(Student student,byte examPoint,string subject,DateTime startDate,DateTime endDate)
        {
            Student=student;
            ExamPoint = examPoint;
            Subject = subject;
            StartDate = startDate;
            EndDate = endDate;
        }

    }
}
