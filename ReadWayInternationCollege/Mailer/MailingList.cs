using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReadWayInternationCollege.Mailer
{
    public class MailingList
    {
        public string MailFromNoReply
        {
            get
            {
                return "mohamedakmal03@gmail.com"/*"d015240@student.nibm.lk"*//*"tnlthanzeel@gmail.com"*/;
            }
        }

        public string[] ToAllStaff
        {
            get
            {
                return new string[] { "tnlthanzeel@gmail.com", "d015240@student.nibm.lk", "kg.prabhani@gmail.com", "edenbritishacademy@gmail.com", "mohamedakmal03@gmail.com" };
            }
        }
    }
}