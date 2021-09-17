using System.Data.SqlClient;
using System;
 
namespace MSSQLApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=MSSQL;Integrated Security=True";
            do
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - Insert" + Environment.NewLine +
                    "2 - Update" + Environment.NewLine +
                    "3 - Delete" + Environment.NewLine +
                    "4 - Select by Id" + Environment.NewLine +
                    "5 - Select All" + Environment.NewLine +
                    "99 - Exit");
 
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Добавление новой записи началось");
 
                        Console.WriteLine(InsertData(connectionString));
                        break;
                    case 2:
                        Console.WriteLine("Обновление записи началось");
 
                        Console.WriteLine(UpdateData(connectionString));
                        break;
                    case 3: 
                        Console.WriteLine("Удаление записи началось");
 
                        Console.WriteLine(DeleteData(connectionString));
                        break;
                    case 4:
                        Console.WriteLine("Выбор записи по Id началось");
 
                        Console.WriteLine(SelectByIdData(connectionString));
                        break;
                    case 5: 
                        Console.WriteLine("Выбор всех записей началось");
 
                        Console.WriteLine(SelectAllData(connectionString));
                        break;
                    case 99:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Выбрано недопустимое действие");
                        break;
                }
                Console.WriteLine("Продолжить работу? (Y/N)");
            }
            while (Console.ReadLine() != "N");
        }
 
        static string InsertData(string connectionString)
        {            
            Console.Write("Введите Фамилию: ");
 
            string lastname = Console.ReadLine();
 
            Console.Write("Введите имя: ");

            string firstname = Console.ReadLine();

            Console.Write("Введите отчество(необязательно): ");

            string middlename = Console.ReadLine();

            Console.Write("Введите день рождения(в формате год-месяц-день(1996-02-19)): ");

            string birthdate = Console.ReadLine();
 
            string sqlExpression = String.Format("INSERT INTO Person (LastName, FirstName, MiddleName, BirthDate) VALUES ('{0}', '{1}','{2}','{3}')", lastname, firstname, middlename, birthdate);
 
            int number;
 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
             
                SqlCommand command = new SqlCommand(sqlExpression, connection);
 
                number = command.ExecuteNonQuery();                
            }
            return string.Format("Добавлено объектов: {0}", number);
        }
 
        static string UpdateData(string connectionString)
        {
            Console.Write("Введите старую Фамилию: ");
 
            string lastname = Console.ReadLine();
 
            Console.Write("Введите новую Фамилию: ");
 
            string lastnameNew = Console.ReadLine();

            Console.Write("Введите старое имя: ");
 
            string firstname = Console.ReadLine();

            Console.Write("Введите новое имя: ");
 
            string firstnameNew = Console.ReadLine();

            Console.Write("Введите старое отчество: ");
 
            string middlename = Console.ReadLine();

            Console.Write("Введите новое отчество: ");
 
            string middlenameNew = Console.ReadLine();

            Console.Write("Введите старую дату рождения(в формате год-месяц-день(1996-02-19)): ");
 
            string birthdate = Console.ReadLine();

            Console.Write("Введите новую дату рождения(в формате год-месяц-день(1996-02-19)): ");
 
            string birthdateNew = Console.ReadLine();
 
            string sqlExpression = String.Format("UPDATE Person SET LastName='{0}' WHERE LastName='{1}'", lastnameNew, lastname);

            string sqlExpressiona = String.Format("UPDATE Person SET FirstName='{0}' WHERE Firstname='{1}'", firstnameNew, firstname);

            string sqlExpressiono = String.Format("UPDATE Person SET MiddleName='{0}' WHERE MiddleName='{1}'", middlenameNew, middlename);

            string sqlExpressionu = String.Format("UPDATE Person SET BirthDate='{0}' WHERE BirthDate='{1}'", birthdateNew, birthdate);
 
            int number;
 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
 
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlCommand commanda = new SqlCommand(sqlExpressiona, connection);
                SqlCommand commando = new SqlCommand(sqlExpressiono, connection);
                SqlCommand commandu = new SqlCommand(sqlExpressionu, connection);
 
                number = command.ExecuteNonQuery();
                number = commanda.ExecuteNonQuery();
                number = commando.ExecuteNonQuery();
                number = commandu.ExecuteNonQuery();
            }
            return string.Format("Обновлено объектов: {0}", number);

        }
            static string DeleteData(string connectionString)
        {
            Console.Write("Введите Id: ");
 
            int id = int.Parse(Console.ReadLine());
 
            string sqlExpression = String.Format("delete from Person where id ={0}", id);
 
            int number;
 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
 
                SqlCommand command = new SqlCommand(sqlExpression, connection);
 
                number = command.ExecuteNonQuery();
            }
            return string.Format("Удалено объектов: {0}", number);
        }
        static string SelectByIdData(string connectionString)
        {  
            Console.Write("Введите Id: ");
 
            int id = int.Parse(Console.ReadLine());
 
            string queryString = String.Format("select * from Person where id = {0}", id);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("Id: {0}, LastName: {1}, FirstName: {2}, MiddleName: {3}, BirthDate: {4}",
                        reader[0], reader[1], reader[2], reader[3], reader[4]));
                    }
                }
            }
            return queryString;
        }
        static string SelectAllData(string connectionString)
        {   
            string queryString = "SELECT * FROM Person;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("Id: {0}, LastName: {1}, FirstName: {2}, MiddleName: {3}, BirthDate: {4}",
                        reader[0], reader[1], reader[2], reader[3], reader[4]));
                    }
                }
            }
        return queryString;
        }
    }
}