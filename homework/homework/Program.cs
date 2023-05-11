using System.Diagnostics;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<student> list = new List<student>();

            list.Add(new student(1, "Abdulloh Halilov", "+998998153214"));
            list.Add(new student(2, "Abdumuxtorov Xojianvar", "+998946154212"));
            list.Add(new student(3, "Axrorbek Yo'ldoshov", "+998919793211"));
            list.Add(new student(4, "Asadbek Murodaliyev", "+998998153214"));
            list.Add(new student(5, "Asatov Ergash", "+998902021454"));
            list.Add(new student(6, "Avazbek Muqimjonov", "+998944562"));
            list.Add(new student(7, "Azamat G'iyosov", "+998977422336"));
            list.Add(new student(8, "Aziz Samadov", "+998931425425"));
            list.Add(new student(9, "Diyor Axmatov", "+998998153214"));
            list.Add(new student(10, "Humoyunmirzo", "+998 90 536 77 32"));
            list.Add(new student(11, "Dilshodbek", "+998 93 533 12 75"));
            list.Add(new student(12, "Nurbek", "+998 99 526 46 64"));
            list.Add(new student(13, "Quvonchbek", "+998 90 035 69 28"));
            list.Add(new student(14, "Sharafiddin", "+998 91 844 45 19"));
            list.Add(new student(15, "Muhammadali", "+998 94 933 24 35"));
            list.Add(new student(16, "Temurbek", "+998 91 319 85 26"));
            list.Add(new student(17, "Tursunboy", "+998 94 114 56 75"));
            list.Add(new student(18, "Chingizbek", "+998 93 375 25 52"));
            list.Add(new student(19, "Xusan", "+998 90 827 11 85"));
            list.Add(new student(20, "Zarina", "+998 99 452 12 24"));
            list.Add(new student(21, "Xojiakbar", "+998 94 555 44 33"));
            list.Add(new student(22, "Zikrillo", "+998 91 156 24 65"));
            list.Add(new student(23, "Mahmudjon", "+998 97 295 47 32"));

            Console.Write(" Enter student ID: ");
            int id=int.Parse(Console.ReadLine());

            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            foreach (student student in list)
            {
                if(student.Id == id)
                {
                    Console.WriteLine($" Fullname : {student.FullName}");
                    Console.WriteLine($" Phone number  : {student.PhoneNumber}");
                    break;
                }
            }
            sw.Stop();
            Console.WriteLine(" Time: "+sw.Elapsed);




        }

    }
    class student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public student(int id, string fullName, string phoneNumber)
        {
            Id = id;
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }
    }
}