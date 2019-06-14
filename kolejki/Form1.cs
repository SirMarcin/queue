using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolejki
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        Queue<Task> highQueue = new Queue<Task>();
        Queue<Task> lowQueue = new Queue<Task>();

        
        public Form1()
        {
            InitializeComponent();
        }
        
        public void makeTaskButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Task t = new Task(() =>
                {
                    Thread.Sleep(rnd.Next(500, 1000));
                });

                int p = rnd.Next(0, 2);
                if (p == 0)
                {
                    highQueue.Enqueue(t);
                }
                else
                {
                    lowQueue.Enqueue(t);
                }
            }
            

            highPriorityList.Text = "";
            lowPriorityList.Text = "";

            foreach (var t in highQueue)
            {
                highPriorityList.Text += $"Task #{t.Id}";
                highPriorityList.Text += Environment.NewLine;
            }

            foreach (var t in lowQueue)
            {
                lowPriorityList.Text += $"Task #{t.Id}";
                lowPriorityList.Text += Environment.NewLine;
            }
            try
            {
                foreach (var item in highQueue)
                {
                    highPriorityList.Text = "";
                    foreach (var t in highQueue)
                    {
                        highPriorityList.Text += $"Task #{t.Id}";
                        highPriorityList.Text += Environment.NewLine;
                    }
                    item.Start();
                    currentTaskTextBox.Text = $"Task #{item.Id}:";
                    currentTaskTextBox.Text += item.Status;
                    item.Wait();
                    highQueue.Dequeue();
                }

                if (highQueue.Count == 0)
                {
                    foreach (var item in lowQueue)
                    {
                        lowPriorityList.Text = "";
                        foreach (var t in lowQueue)
                        {
                            lowPriorityList.Text += $"Task #{t.Id}";
                            lowPriorityList.Text += Environment.NewLine;
                        }
                        item.Start();
                        item.Wait();
                        currentTaskTextBox.Text = $"Task #{item.Id}:";
                        currentTaskTextBox.Text += item.Status;
                        lowQueue.Dequeue();
                    }
                }

            }
            catch (Exception)
            {

            }


        }
        

    }
}
