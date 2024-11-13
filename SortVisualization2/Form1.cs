using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SortVisualization2.Algorithms;
using SortVisualization2.Entity;
using SortVisualization2.Options;

namespace SortVisualization2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //adding the next 2 lines will make the bubble sort work but will make the screen in half bars... so not really working
            this.Load += new EventHandler(Form1_Load);
            //this.Load += new EventHandler((sender, e) => { this.WindowState = FormWindowState.Maximized; });
        }

        private Graphics graphic;
        private List<Element> elements = new List<Element>();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; // Maximize the window
            graphic = pnlMonitor.CreateGraphics();
        }

        private void pnlMonitor_Paint(object sender, PaintEventArgs e)
        {
            //elements.Clear(); // Clear existing elements to prevent duplicates

            var rand = new Random();
            int padding = ArrayOptions.Padding;

            //create random array
            for (int index = 0; index < ArrayOptions.Length; index++)
            {
                var start = new Point(padding, MonitorOptions.Height);
                int value = MonitorOptions.Height - rand.Next(50) * 10;     //rand.Next(50) will return a number close to 50, * 10 will make the number bigger
                var end = new Point(padding, value);
                var element = new Element(start, end, MonitorOptions.Height - value);

                elements.Add(element);
                padding += ArrayOptions.Width + ArrayOptions.Space;
            }
            //draw to panel

            elements.ForEach(c =>
                {
                    c.Draw(graphic);
                });
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            //sort 
            int loopCount = 0;
            for(int i = 0; i < elements.Count - 1; i++)
            {
                //for (int j = 0; j < elements.Count - 1; j++)
                for (int j = 0; j < elements.Count - i - 1; j++)//I changed this line to make the algorithm more efficient

                {
                    if (elements[j].Value > elements[j + 1].Value)
                    {
                        ElementHelper.DrawSwap(elements[j], elements[j + 1], graphic);
                        ElementHelper.ElementSwap(elements, j, j + 1);
                    }
                    loopCount++;
                    lblLoopCount.Text = loopCount.ToString(); //Will display the loop number in the label lblLoopCount
                    lblLoopCount.Update();
                }
            }
            //for (int i = 0; i < elements.Count; i++)
            //{
            //    elements[i].Selected(graphic);
            //}

            ElementHelper.CompletedList(elements, graphic);//can be used to show the final sorted list in a different color
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            QuickSort.QuickSortAlgorithm(elements, 0, elements.Count - 1, graphic);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Generate new elements
            elements.Clear();
            pnlMonitor.Invalidate(); // Trigger repaint
            int loopCount = 0;//reset the loop count to 0
            lblLoopCount.Text = loopCount.ToString(); //Will display the loop number in the label lblLoopCount

        }
    }
}
