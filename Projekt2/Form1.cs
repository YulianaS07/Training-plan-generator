using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Projekt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!checkBoxBack.Checked && !checkBoxChest.Checked && !checkBoxArms.Checked && !checkBoxLegs.Checked && !checkBoxCardio.Checked)
            {
                MessageBox.Show("Przynajmniej jeden checkbox musi być wybrany!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGrid.Rows.Clear();

            var rand = new Random();
            int numberOfExercises = (int)numericUpDown1.Value;

            List<string> allExercises = new List<string>();
            if (checkBoxChest.Checked) allExercises.AddRange(Exercise.chest);
            if (checkBoxBack.Checked) allExercises.AddRange(Exercise.back);
            if (checkBoxArms.Checked) allExercises.AddRange(Exercise.arms);
            if (checkBoxLegs.Checked) allExercises.AddRange(Exercise.legs);
            if (checkBoxCardio.Checked) allExercises.AddRange(Exercise.cardio);

            var selectedExercises = allExercises.OrderBy(x => rand.Next()).Take(numberOfExercises).ToList();

            foreach (var exercise in selectedExercises)
            {
                var repetitions = rand.Next(6, 11);
                dataGrid.Rows.Add(exercise, repetitions);
            }
        }
        private void btnSaveXml_Click(object sender, EventArgs e)
        {
            var exercisePlan = new List<ExerciseEntry>();
            var name = textBoxName.Text;
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    var exercise = row.Cells[0].Value.ToString();
                    var repetitions = int.Parse(row.Cells[1].Value.ToString());
                    exercisePlan.Add(new ExerciseEntry(exercise, repetitions, name));
                }
            }
            SerializeExercisePlanToXml("exercisePlan.xml", exercisePlan);
        }

        private void btnLoadXml_Click(object sender, EventArgs e)
        {
            var exercisePlan = DeserializeExercisePlanFromXml("exercisePlan.xml");
            dataGrid.Rows.Clear();
            foreach (var entry in exercisePlan)
            {
                dataGrid.Rows.Add(entry.ExerciseName, entry.Repetitions);
                textBoxName.Clear();
                textBoxName.AppendText(entry.Name);
            }
            
        }


        private void SerializeExercisePlanToXml(string filePath, List<ExerciseEntry> exercisePlan)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<ExerciseEntry>));
                serializer.Serialize(writer, exercisePlan);
            }
        }
        private List<ExerciseEntry> DeserializeExercisePlanFromXml(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<ExerciseEntry>));
                return (List<ExerciseEntry>)serializer.Deserialize(reader);
            }
        }

    }

}



