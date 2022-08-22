using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class FnRController : ApiController
    {
        public string Deltest(string inputstring)
        {
            foreach (string eachword in inputstring.Split(new char[] { ' ', ',', '.', '-', ':', '\n', '\t' }))
            {
                System.Text.StringBuilder builder = new System.Text.StringBuilder(eachword);
                if (eachword == "Google" || eachword == "Oracle" || eachword == "Deloitte" || eachword == "Amazon" || eachword == "Microsoft")
                {
                    string temp = builder.Append("Ⓒ").ToString();
                    inputstring = inputstring.Replace(eachword, temp);
                }
            }
            return inputstring;
        }
    }
}
