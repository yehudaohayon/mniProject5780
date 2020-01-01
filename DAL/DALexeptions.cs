using System;
using System.Collections.Generic;
using System.Text;
namespace DAL
{

    public class dalExeptionIdAlreadyexist : Exception
    {
        public dalExeptionIdAlreadyexist() { }

    }
    public class dalExeptionItemDoesntexist:Exception
    {
        public dalExeptionItemDoesntexist() {}
    }
    public class dalExeptionMoreThanOneAnswer : Exception
    {
        public dalExeptionMoreThanOneAnswer() { }
    }
}