using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int[] array = new int[27];
        double sr = 0, count = 0;
        public const int d = 27;
        public Form1()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < array.Length; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = " ";
                label1.Text = " ";
            }
        }

        private void grafic_Click(object sender, EventArgs e)
        {
            int[] x = array;
            int[] y = new int[27];
            for (int i = 0; i < 27; i++)

            {

                y[i] = array[i];
                x[i] = i;
                chart1.ChartAreas[0].AxisY.MajorGrid.Interval = 1;
                chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 2;
                chart1.Series[0].Points.DataBindXY(x, y);

            }
        }

        private void Izfaila_Click(object sender, EventArgs e)
        {
            try

            {
                StreamReader file = new StreamReader(@"C:\\file.txt"); // Объявление StreamReader
                string[] n = file.ReadToEnd().Split('\n'); // Чтение данных из файла
                for (int i = 0; i < 27; i++)

                {

                    dataGridView1.Rows[0].Cells[i].Value = n[i]; // Заполнение ячеек
                    array[i] = Convert.ToInt32(n[i]); // Заполнение массива 

                }

            }

            catch (FileNotFoundException) //Исключения

            {

                MessageBox.Show("File not found!"); // Исключение при отсутствии файла

            }
            catch (FormatException)


            {

                MessageBox.Show("Incorrect format!"); // Не верный формат файла

            }
            catch (Exception)
            {

                MessageBox.Show("The file is empty"); // Пустой файл

            }
        }

        private void end_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialog = MessageBox.Show
               (
                 "Вы действительно хотите выйти из программы?",
                 "Завершение программы",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning
                );
                if (dialog == DialogResult.Yes) // Возвращение значения диалогового окна
                {
                    this.Close(); // Закрытие приложения

                }
            }
        }

        private void Zadacha_Click(object sender, EventArgs e)
        {
            int temp = 0;// Нахождение среднего арифметического отрицательных элементов массива
            for (int i = 0; i < 5; i++)
            {

                if (array[i] < 0 && i%2==0)
                {
                    sr += array[i];
                    count++;
                }

            }
            label1.Text = "Среднее арифметическое отрицательных элементов :" + Math.Round(sr / count, 3);
        }

        private void vozrast_Click(object sender, EventArgs e)
        {
            // Сортировка по возрастанию
            Array.Sort(array);

            for (int i = 0; i < array.Length; i++)

                dataGridView1.Rows[0].Cells[i].Value = array[i];
        }

        private void ubivanie_Click(object sender, EventArgs e)
        {
            // Сортировка по убыванию
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)

                dataGridView1.Rows[0].Cells[i].Value = array[i];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                Form1.ActiveForm.Hide();

                Form2 f2 = new Form2();

                f2.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {

                Form1.ActiveForm.Hide();
                Form3 f3 = new Form3();
                f3.Show();

            }
        }

        private void Random_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = d; // Количество столбцов, отображаемых в объекте DataGridView.
            Random rnd = new Random(); // Рандомный массив
            for (int i = 0; i < array.Length; i++)

            {
                array[i] = rnd.Next(-50, 50); // Границы случайного массива
                dataGridView1.Rows[0].Cells[i].Value = array[i]; // Заполнение ячеек
            }
        }
    }
}
