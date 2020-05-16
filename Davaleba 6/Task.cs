using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_CSharp_exercises
{

    class Task
    {

        public enum TaskPriority
        {
            Low,
            Medium,
            High
        }

        public enum TaskRecurrence
        {
            Once=0,
            Day=1,
            Week=7,
            Month=30,
            Year=365
        }

        // list of tasks
        public static List<Task> tasks = new List<Task>();
        
        // tasks are medium priority by default
        TaskPriority priority = TaskPriority.Medium;
        public TaskPriority Priority
        {
            set { priority = value; }
        }

        // by default, tasks don't recur
        TaskRecurrence recurrence = TaskRecurrence.Once;
        public TaskRecurrence Recurrence
        {
            get { return recurrence; }
            set { recurrence = value; }
        }
        
        // when due to be done by
        DateTime dateDue;
        public DateTime DateDue
        {
            get { return dateDue; }
        }

        // what task involves
        string what;
        public string Description
        {
            get
            {
                if (priority != TaskPriority.Medium)
                {
                    return priority.ToString().ToUpper() + " PRIORITY: " + what;
                }
                else
                {
                    return what;
                }
            }
        }

        // constructor for new task
        public Task(DateTime TaskWhenDue,string TaskWhat) 
        {
            what = TaskWhat;
            dateDue = TaskWhenDue;
        }

        // adding a task to list
        public void Create()
        {
            tasks.Add(this);
        }
    }
}
