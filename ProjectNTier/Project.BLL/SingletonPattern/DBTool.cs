﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.SingletonPattern
{
    using DAL.Context;
    public class DBTool
    {


        private DBTool() { }

        private static MyContext _dbInstance;

        public static MyContext DBInstance
        {
            get
            {

                if (_dbInstance == null)
                {
                    
                    _dbInstance = new MyContext();
                }

                return _dbInstance;

            }
        }




    }
}
