using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statistics10Edi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnAvr_Click(object sender, EventArgs e)
        {
            List<double> list = txtNum.Text.Split(' ').Select(l => double.Parse(l)).ToList();

            var avarage = list.Average();

            lblAvr.Text = ("Avarage: " + avarage);
        }

        private void btnMed_Click(object sender, EventArgs e)
        {
            string[] numStrings = txtNum.Text.Split(' ');

            int[] numbers = numStrings.Where(str => !string.IsNullOrEmpty(str)).Select(str => Convert.ToInt32(str)).ToArray();

            if(numbers.Length > 0)
            {
                Array.Sort(numbers);

                double median;
                if(numbers.Length % 2 == 0)
                {
                    int middle1 = numbers.Length / 2 - 1;
                    int middle2 = numbers.Length / 2;
                    median = (numbers[middle1] + numbers[middle2]) / 2.0;
                }
                else
                {
                    int middle = numbers.Length / 2;
                    median = numbers[middle];
                }
                lblMed.Text = ("Median: " + median.ToString());
            }
            else
            {
                lblMed.Text = "Please enter numbers.";
            }
        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            string[] numStrings = txtNum.Text.Split(' ');

            List<int> numbers = new List<int>();
            foreach (string numString in numStrings)
            {
                if (int.TryParse(numString, out int num))
                {
                    numbers.Add(num);
                }
                else
                {
                    MessageBox.Show("Kanye is mad");
                    return;
                }
            }

            List<int> modes = FindMode(numbers);

            if (modes.Count > 0)
            {
                lblMode.Text = "Mode: " + string.Join(" ", modes);
            }
            else
            {
                lblMode.Text = "Knye found no mode";
            }
        }

        private List<int> FindMode(List<int> numbers)
        {
            var frequency = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                if (frequency.ContainsKey(number))
                {
                    frequency[number]++;
                }
                else
                {
                    frequency[number] = 1;
                }
            }

            int maxFrequency = frequency.Values.Max();

            List<int> modes = frequency.Where(kv => kv.Value == maxFrequency)
                                      .Select(kv => kv.Key)
                                      .ToList();
            return modes;
        }
    }
}
