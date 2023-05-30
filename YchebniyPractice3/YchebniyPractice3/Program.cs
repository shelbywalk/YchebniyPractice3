namespace YchebniyPractice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("fio", 10000, 1);
            List<Employee> employees = new List<Employee>()
            {
                new("Речкин Антон Алексеевич", 19000, 1),
                new("Петрова Лариса Генадевна", 3, 12300),
                new("Гордон Михаил Иванович", 1, 9000),
                new("Крапов Глеб Давидович", 2, 17990),
                new("Нечаев Никита Романович", 2, 20000),
                new("Лесничев Антон Павлович", 3, 14200),
                new("Ухова Анна Олеговна", 3, 25000),
                new("Маргитов Ратибор Иванович", 1, 19000),
                new("Покрасов Антон Павлович", 3, 16000),
                new("Брагимов Тихон Иванов", 2, 23000),
            };

            TaskA();
            TaskB();
            TaskC();
            TaskD();
            TaskE();
            TaskF();
            
            void TaskA()
            {
                Console.WriteLine("Task A");
                foreach (var emp in employees)
                {

                    Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}, Отдел: {emp.Otdel}");
                }
            }
            void TaskB()
            {
                Console.WriteLine("Task B");
                double summa = 0;
                foreach (var emp in employees)
                {
                    summa += emp.Salary;
                }
                Console.WriteLine($"Сумма затрат на ЗП в месяц: {summa}");
            }
            void TaskC()
            {
                Console.WriteLine("Task C");
                double min = 99999999999;
                foreach (var emp in employees)
                {
                    if (emp.Salary < min)
                    {
                        min = emp.Salary;
                    }
                }
                Console.WriteLine("Минимальная ЗП " + min);
            }
            void TaskD()
            {
                Console.WriteLine("Task D");
                double max = 0;
                foreach (var emp in employees)
                {
                    if (emp.Salary > max)
                    {
                        max = emp.Salary;
                    }
                }
                Console.WriteLine("Максимальная ЗП " + max);
            }
            void TaskE()
            {
                Console.WriteLine("Task E");
                int count = 0;
                double summa = 0;
                foreach (var emp in employees)
                {
                    count++;
                    summa += emp.Salary;
                }
                Console.WriteLine($"Среднее значение ЗП: {summa / count}");
            }
            void TaskF()
            {
                Console.WriteLine("Task F");
                foreach (var emp in employees)
                {
                    Console.WriteLine("ФИО " + emp.Fio);
                }
                Console.ReadKey();
            }
        }
    }
}