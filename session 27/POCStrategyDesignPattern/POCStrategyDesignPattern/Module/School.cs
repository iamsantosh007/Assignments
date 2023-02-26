using POCStrategyDesignPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCStrategyDesignPattern.Module
{
    internal class School
    {
        private readonly IMarks _marks;

        public School(IMarks marks)
        {
            _marks = marks;
        }

        public IMarks Marks { get { return _marks; } }

        
    }
}
