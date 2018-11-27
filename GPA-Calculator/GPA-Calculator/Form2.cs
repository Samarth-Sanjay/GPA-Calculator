using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_Calculator
{
    public partial class Form2 : Form
    {
        List<int> allHours = new List<int>();
        List<string> allGrades = new List<string>();
        List<decimal> allGPA = new List<decimal>();

        BindingList<string> displayList = new BindingList<string>();

        private int selectedIndex = -1;

        public Form2()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                var selectedGrade = groupBoxGrades.Controls.OfType<RadioButton>()
                    .FirstOrDefault(n => n.Checked);
                if (selectedGrade != null)
                {
                    var currentGrade = selectedGrade.Text;
                    var currentHours = Int32.Parse(comboBoxCreditHours.Text);

                    var currentGradeVal = (int)Enum.Parse(typeof(GradeVal), currentGrade);

                    selectedGrade.Checked = false;
                    comboBoxCreditHours.Text = "";

                    initCalculateGPA(currentGrade, currentHours, currentGradeVal);

                    ShowDetail();

                    lstDetail.SelectedIndex = -1;
                }
            }
        }

        public decimal CalculateGradePoint(string gVal, int cHours) => (int)Enum.Parse(typeof(GradeVal), gVal) * cHours;

        public void initCalculateGPA(string currentGrade, int currentHours, int currentGradeVal)
        {
            allGrades.Add(currentGrade);
            allHours.Add(currentHours);
            CalculateGPA();
        }

        public void CalculateGPA(bool update = false)
        {


            int totalHours = allHours.Sum();

            var totalGradeNum = allGrades.Count();
            decimal currentGPA = 0m;
            for (int i = 0; i < totalGradeNum; i++)
            {
                currentGPA += CalculateGradePoint(allGrades.ElementAt(i), allHours.ElementAt(i));
                if (update)
                {
                    allGPA.Add(currentGPA / allHours.Take(i + 1).Sum());
                }
            }

            if (!update)
                allGPA.Add(currentGPA / totalHours);
        }

        public void ShowDetail(bool update = false)
        {
            if (!update)
            {
                var i = displayList.Count();

                var displayVal = $"{i + 1} - {allGrades.ElementAt(i)} - {allHours.ElementAt(i)} - ({allGPA.ElementAt(i).ToString("0.000")})";

                displayList.Add(displayVal);
            }
            else
            {
                displayList.Clear();

                for (int i = 0; i < allGPA.Count(); i++)
                {
                    var displayVal =
                        $"{i + 1} - {allGrades.ElementAt(i)} - {allHours.ElementAt(i)} - ({allGPA.ElementAt(i).ToString("0.000")})";

                    displayList.Add(displayVal);
                }
            }

            lstDetail.DataSource = displayList;


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to close this program", "Closing Program", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void displayErrorBox(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Entry Error");
        }

        public bool isValid()
        {
            if (!groupBoxGrades.Controls.OfType<RadioButton>().Any(x => x.Checked))
            {
                displayErrorBox("Grade must be selected");
                return false;
            }
            else if (String.IsNullOrWhiteSpace(comboBoxCreditHours.Text))
            {
                displayErrorBox("Credit Hours must be selected");
                return false;
            }

            return true;
        }
        private void LstDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDetail.SelectedItem != null)
                selectedIndex = displayList.IndexOf(lstDetail.SelectedItem.ToString());
        }
        public enum GradeVal
        {
            A = 4,
            B = 3,
            C = 2,
            D = 1,
            F = 0
        };

        private void buttonResetAll_Click(object sender, EventArgs e)
        {
            allGrades.Clear();
            allHours.Clear();
            allGPA.Clear();
            displayList.Clear();
            lstDetail.SelectedIndex = -1;
        }

        private void buttonRemoveSelected_Click(object sender, EventArgs e)
        {
            if (displayList.Any())
            {
                allGrades.RemoveAt(selectedIndex);
                allHours.RemoveAt(selectedIndex);
                allGPA.Clear();
                displayList.RemoveAt(selectedIndex);
                CalculateGPA(true);
                ShowDetail(true);
                lstDetail.SelectedIndex = -1;
            }

        }
    }
}
