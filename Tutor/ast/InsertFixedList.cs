﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.ast
{
    public class InsertFixedList : InsertStrategy
    {
        public List<PythonNode> Insert(PythonNode context, PythonNode inserted, int index)
        {
            var newList = new List<PythonNode>();
            newList.AddRange(context.Children);
            newList.Insert(index, inserted);
            return newList;
        }
    }
}
