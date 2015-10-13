using System;


namespace Multicasting
{
    class SendViaMobile
    {
        public void sendSMS(string msg)
        {
            Console.WriteLine("SMS: " + msg);
        }

        public void Subscribe(Publisher publisher)
        {
            publisher.publishMsg += sendSMS;
        }
        public void Unsubscribe(Publisher publisher)
        {
            publisher.publishMsg -= sendSMS;
        }
    }
    class SendViaEmail
    {
        public void sendEmail(string msg)
        {
            Console.WriteLine("Email: "+msg);
        }
        public void Subscribe(Publisher publisher)
        {
            publisher.publishMsg += sendEmail;
        }
        public void Unsubscribe(Publisher publisher)
        {
            publisher.publishMsg -= sendEmail;
        }
    }
    class Publisher
    {
        public delegate void PublisMsgDel(string msg);
        public PublisMsgDel publishMsg = null;

        public void PublishMsg(string msg)
        {
            if (publishMsg != null)
            {
                publishMsg.Invoke(msg);
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Publisher pub = new Publisher();
            SendViaMobile svm = new SendViaMobile();
            SendViaEmail svem = new SendViaEmail();

            svm.Subscribe(pub);
            svem.Subscribe(pub);

            //pub.publishMsg += svm.sendSMS;
            //pub.publishMsg += svem.sendEmail;

            pub.PublishMsg("Far Cry 4 avalible");
            Console.WriteLine("\n\n");

            svm.Unsubscribe(pub);
            pub.PublishMsg("Far Cry 4 avalible");
        }
    }
}
