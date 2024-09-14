// See https://aka.ms/new-console-template for more information



using System.Linq;
using System.Text.RegularExpressions;
using Link_p2;
public class Program
{
    static void Main(string[] args)
    {
        var classes = new[]
        {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
        var allStudents = GetAllStudents(classes);

        Console.WriteLine(string.Join(" ", allStudents));
    }
    //Напишите метод, который соберет всех учеников всех классов в один список, используя LINQ.
    static string[] GetAllStudents(Classroom[] classes)
    {
        string[] s; 
        var st = from p in classes
                      from k in p.Students  
                      where k.Length > 0
                      
                      select k;
        s = st.ToArray();    

       return s;
    }




    static long Factorial(int number)
    {

        long result;
        // Ваш код здесь
        if (number == 0)
        {
            result = 1;
        }
        else
        {
            var numbers = new List<int>();

            // Добавляем все числа от 1 до n в коллекцию
            for (int i = 1; i <= number; i++)
                numbers.Add(i);


            result = numbers.Aggregate((x, y) => x * y);

        }
        return result;
    }

    /*
      public static long Task15_2_2()
      {
          var contacts = new List<Contact>()
          {
               new Contact() { Name = "Андрей", Phone = 79994500508 },
               new Contact() { Name = "Сергей", Phone = 799990455 },
               new Contact() { Name = "Иван", Phone = 79999675334 },
               new Contact() { Name = "Игорь", Phone = 8884994 },
              new Contact() { Name = "Анна", Phone = 665565656 },
              new Contact() { Name = "Василий", Phone = 3434 }
          };
          var invalidContacts =
     (from contact in contacts // пробегаемся по контактам
      let phoneString = contact.Phone.ToString() // сохраняем в промежуточную переменную строку номера телефона
      where !phoneString.StartsWith('7') || phoneString.Length != 11 // выполняем выборку по условиям
      select contact) // добавляем объект в выборку
     .Count(); // считаем количество объектов в выборке


          var rightPhoneNum = contacts.Count(s => s.Phone != 11 || !(s.Phone.ToString().StartsWith('7')));
          Console.WriteLine("Количество неверных номеров {0}",rightPhoneNum);

          Console.WriteLine("Проверка {0}", invalidContacts); 
          return invalidContacts;
      }

      //Напишите метод, возвращающий среднее арифметическое числовых объектов коллекции.

      // метода дан ниже:
      static double Average(int[] numbers)
      {
          var num = (double) numbers.Length;
          double avr = numbers.Sum()/num;
          return avr; 
      }
    */

    public static void Task15_3_3()
    {
        var phoneBook = new List<Contact>();

        // добавляем контакты
        phoneBook.Add(new Contact("Игорь", 79990000001, "igor@example.com"));
        phoneBook.Add(new Contact("Сергей", 79990000010, "serge@example.com"));
        phoneBook.Add(new Contact("Анатолий", 79990000011, "anatoly@example.com"));
        phoneBook.Add(new Contact("Валерий", 79990000012, "valera@example.com"));
        phoneBook.Add(new Contact("Сергей", 799900000013, "serg@gmail.com"));
        phoneBook.Add(new Contact("Иннокентий", 799900000013, "innokentii@example.com"));

        //Некоторые из них имеют реальный email-адрес, а некоторые — фейковый (те, которые в домене example).

        // Нам нужно разбить их на две группы: фейковые и реальные, и вывести результат в консоль.

        //Решите эту задачу с помощью группировки.

        var correctEmail = from cor_email in phoneBook

                           group cor_email by cor_email.Email.Split("@").Last();

        foreach (var group in correctEmail)
        {
            if (group.Key.Contains("example"))
            {
                Console.WriteLine("Фейковые адреса: ");

                foreach (var contact in group)
                    Console.WriteLine(contact.Name + " " + contact.Email);

            }
            else
            {
                Console.WriteLine("Реальные адреса: ");
                foreach (var contact in group)
                    Console.WriteLine(contact.Name + " " + contact.Email);
            }

            Console.WriteLine();

        }


      







    }

    //Соедините данные и выведите на экран, кто работает в каком отделе.
    public static void Task15_4_1() {
        var departments = new List<Department>()
        {
          new Department() {Id = 1, Name = "Программирование"},
         new Department() {Id = 2, Name = "Продажи"}
        };
        var employees = new List<Employee>()
        {
         new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
         new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
         new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
        new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
        };
        var workers = from o in employees
                        join d in departments on o.DepartmentId equals d.Id
                      select new //   спроецируем выборку в новую анонимную сущность
                      {
                          Name = o.Name,
                          Departaments = d.Name
                          
                      };
          Console.WriteLine();
        foreach (var part in workers)
        {
            Console.WriteLine($"Имя сотрудника {part.Name} наименование отдела {part.Departaments}");
        }
    }
}





