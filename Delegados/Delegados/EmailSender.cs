using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    public class EmailSender
    {
        private int sendResult;
        public int SendEmail()
        {
            Console.WriteLine("Simulacion de envío de correo...");
            sendResult = 0;
            return sendResult;
        }
    }
}
