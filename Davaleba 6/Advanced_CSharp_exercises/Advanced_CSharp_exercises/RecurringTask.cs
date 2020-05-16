using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_CSharp_exercises
{
    class RecurringTask : Task 
    {

        
        // constructor should do what base constructor does
        public RecurringTask(DateTime TaskWhenDue, string TaskWhat)
            : base(TaskWhenDue, TaskWhat)
        {
        }

    }
}
