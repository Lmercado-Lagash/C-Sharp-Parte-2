using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document();
            doc.Text = "El texto del documento va aqui";

            var blogPoster = new BlogPoster();
            var blogDelegate = new Document.SendDoc(blogPoster.PostToBlog);
            doc.ReportSendingResult(blogDelegate);

            var sendEmail = new EmailSender();
            var delegateEmail = new Document.SendDoc(sendEmail.SendEmail);
            doc.ReportSendingResult(delegateEmail);

        }
        
    }
}
