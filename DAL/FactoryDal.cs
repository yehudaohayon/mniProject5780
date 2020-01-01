using System;
using System.Collections.Generic;
using System.Text;


namespace DAL
{
    public class FactoryDal
    {
        public static IDAL getDal()
        {
            return new Dal_imp();
        }
    }
}
