﻿using ServiceCollectionLab.Impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceCollectionLab
{
    class DBProcess
    {
        readonly IDatabase db;
        public DBProcess(IDatabase db) { this.db = db; }
        
        public void SelectData()
        {
           
            db.Select();
        }
        public void SelectData1()
        {

            db.Select();
        }
        public void SelectData2()
        {

            db.Select();
        }
    }
}
