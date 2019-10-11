using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppG2.Model;
namespace AppG2.Controller
{
    public class StudentService
    {
        /// <summary>
        /// Lấy sinh viên theo mã sinh viên từ MockData
        /// </summary>
        /// lấy sv từ file
        /// <param name="pathDataFile">đường dẫn tới file chứa dư xlieeuj</param>
        /// <param name="idStudent">Ma sv</param>
        /// <returns>Sinh viên có mã tương ứng hoặc null</returns>
        public static Student GetStudent(string idStudent)
        {
            Student student = new Student
            {
                IDStudent = idStudent,
                FirstName = "Linh",
                LastName = "Nguyễn",
                DOB = new DateTime(1997, 12,01),
                POB = "Quang Binh",
                Gender = GENDER.Female
            };
            student.ListHistoryLearning = new List<HistoryLearning>();
            for(int i = 1 ; i <=12; i++)
            {
                HistoryLearning historyLearning = new HistoryLearning
                {
                    IDHistoryLearning = i.ToString(),
                    YearFrom = 2006 + i,
                    YearEnd = 2007 + i,
                    Address = "THCS Phan Bội Châu",
                    IDStudent = idStudent,
                };
                student.ListHistoryLearning.Add(historyLearning);
            }
            return student;
        }
        public static Student GetStudent(string pathDataFile,string idStudent)
        {
            if (File.Exists(pathDataFile))
            {
                CultureInfo culture = CultureInfo.InvariantCulture;
                var listLines = File.ReadAllLines(pathDataFile);
                foreach(var line in listLines)
                {
                    var rs = line.Split(new char[] { '#' });
                    Student student = new Student
                    {
                        IDStudent = rs[0],
                        FirstName = rs[1],
                        LastName = rs[2],
                        Gender = rs[3] == "Male" ? GENDER.Male : (rs[3] == "Female" ? GENDER.Female : GENDER.Other),
                        DOB = DateTime.ParseExact(rs[4], "yyyy-MM-dd", culture),
                        POB = rs[5]
                    };
                    if (student.IDStudent == idStudent)
                        return student;
                  
                }
                return null;
            }
            return null;
        }
    }
}
