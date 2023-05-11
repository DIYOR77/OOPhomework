namespace homeworkoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue(" Fayzullayev Abdulla ");
            queue.Enqueue(" Akbarov Sarvar ");
            queue.Enqueue(" Nurullayev Asadbek ");
            queue.Enqueue(" Sharipov Aziz ");
            queue.Enqueue(" Akbarov Azam ");
            queue.Enqueue(" Nosirov Xurshid ");
            queue.Enqueue(" Olimov Sattor ");

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(" Mijoz : " + (i + 1) + queue.Dequeue());
                Console.ReadLine();
                Console.Clear();
            }

        }
    }
}