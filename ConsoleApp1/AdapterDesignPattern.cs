using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EmployeeFiredEvent
    {
        //private readonly sendClkkk sendgridClient;
        private readonly IUserNotificationService sendgridClient;
        //public EmployeeFiredEvent(sendClkkk sendClkkk)
        public EmployeeFiredEvent(IUserNotificationService sendClkkk)
        {
            this.sendgridClient = sendClkkk;
        }
    }
    public class sendClkkk
    {
        public void sendEmail()
        {
            Console.WriteLine("Sending Email");
        }
    }

    public interface IUserNotificationService
    {
        public void NotifyUser(string userid , string message);
    }

    //this is class adapter     
    //adapter Inherites Adaptee and interface and inherets the method 
    public class ClassAdapter : sendClkkk, IUserNotificationService
    {
        public void NotifyUser(string userid, string message)
        {
            throw new NotImplementedException();
        }
    }


    //object adapter
    public class ObjectAdapter : IUserNotificationService
    {
        private readonly sendClkkk _clkkk;
        public ObjectAdapter(sendClkkk clkkk)
        {
            _clkkk = clkkk;
        }
        
        public void NotifyUser(string userid, string message)
        {
            //inject the adaptee and use it into the adapter
            _clkkk.sendEmail();
        }
    }
}
