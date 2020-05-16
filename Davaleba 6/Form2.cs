using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_CSharp_exercises
{
    public partial class Form2 : Form
    {
        List<Form2> fs = new List<Form2>();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // we'll sort our dictionary by the date/time of when task due
            SortedDictionary<DateTime, string> SortedTasks = new SortedDictionary<DateTime, string>();

            Task t1 = new Task(System.DateTime.Now.AddDays(7), "Give up smoking");
            t1.Create();

            Task t2 = new Task(System.DateTime.Now.AddDays(20), "Give up drinking");
            t2.Create();

            Task t3 = new Task(System.DateTime.Now.AddDays(11), "Audtion for BGT");
            t3.Priority = Task.TaskPriority.High;
            t3.Create();

            // cat needs feeding every week
            Task t4 = new RecurringTask(System.DateTime.Today.AddDays(6), "Feed the cat");
            t4.Recurrence = Task.TaskRecurrence.Week;
            t4.Create();

            // create dictionary of normal tasks
            foreach (Task t in Task.tasks) {
                if (t.Recurrence == Task.TaskRecurrence.Once)
                {
                    // normal task: just add once
                    SortedTasks.Add(t.DateDue, t.Description);
                } else {

                    // add in recurring tasks to end of current year
                    DateTime thisDate = t.DateDue;;
                    while (true)
                     {
                        if (thisDate.Year > System.DateTime.Today.Year) { break; }
                        SortedTasks.Add(thisDate, t.Description);
                        thisDate = thisDate.AddDays((int)t.Recurrence);
                    }

                }
            }


            // list out tasks in date order
            string s="";
            foreach (KeyValuePair<DateTime, string> t in SortedTasks)
            {
                s += t.Key.ToString("dd MMM") + " - " + t.Value + "\n";
            }

            MessageBox.Show(s);
            
        }
    }
}
