using System;
using System.Net;
using System.Net.Mail;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        //сбор данных
            Console.WriteLine("Введите логин");
            string log = (Console.ReadLine());
            Console.WriteLine("Введите пароль");
            string pass = (Console.ReadLine());
            Console.WriteLine("Кому отправить письмо:");
            string fr = (Console.ReadLine());

        //создание отправителя и получателя
            MailAddress from = new MailAddress(fr, "NAME");
            MailAddress to = new MailAddress("address@yandex.ru");

        //создание объекта письма 
            MailMessage objectMail = new MailMessage(from, to);
            objectMail.Subject = "Текст";
            objectMail.Body = "<h2>Письмо-тест работы stmp-клиента</h2>";
            objectMail.IsBodyHtml = true;

        //отправка письма
            SmtpClient smtp = new SmtpClient("smpt.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(log, pass);
            smtp.EnableSsl = true;
            smtp.Send(objectMail);
            Console.Read();
        }
    }
}
