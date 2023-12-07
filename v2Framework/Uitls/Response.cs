using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v2Framework.Uitls
{
    public class Response
    {
        public int code { get; set; }
        public string msg { get; set; }
        public string result { get; set; }

        public Response()
        {
            this.code = 0;
            this.msg = "Successful";
        }

        public Response(int code, string msg, string result)
        {
            this.code = code;
            this.msg = msg;
            this.result = result;
        }

    }
}
