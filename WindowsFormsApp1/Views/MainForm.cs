using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        Models.Rectangle[] rectangles;
        
        bool BGenerated = false;
       
        public MainForm() // Конструктор класса MainForm
        {
            InitializeComponent();

        }
        void AddToValueList(Type enumType)  // Метод для добавления значений перечисления в список ValuelistBox
        {
            ValuelistBox.Items.Clear(); // Очищаем список перед добавлением новых элементов
            Array array = Enum.GetValues(enumType); // Получаем значения enum
            foreach (var element in array) // Перебираем каждое значение перечисления
            {
                ValuelistBox.Items.Add(element);  // Добавляем каждый элемент в список ValuelistBox
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (EnumlistBox.SelectedIndex) // Проверяем индекс выбранного элемента в EnumlistBox
            {
                case 0:
                    AddToValueList(typeof(Models.Enums.colors)); // Добавляем значения перечисления colors
                    break;
                case 1:
                    AddToValueList(typeof(Models.Enums.Genre));  // Добавляем значения перечисления Genre
                    break;
                case 2:
                    AddToValueList(typeof(Models.Enums.Education)); // Добавляем значения перечисления Education
                    break;
                case 3:
                    AddToValueList(typeof(Models.Enums.TimeOfYear)); // Добавляем значения перечисления TimeOfYear
                    break;
                case 4:
                    AddToValueList(typeof(Models.Enums.WeekDay)); // Добавляем значения перечисления WeekDay
                    break;
                case 5:
                    AddToValueList(typeof(Models.Enums.Manufactures)); // Добавляем значения перечисления Manufactures
                    break;
            }
        }

        private void ValuelistBox_SelectedIndexChanged(object sender, EventArgs e) // Обработчик события изменения выбранного элемента в ValuelistBox
        {
            var text = ValuelistBox.SelectedIndex + 1; // Получаем индекс выбранного элемента и добавляем 1 для отображения
            ValueBox.Text = text.ToString();  // Устанавливаем текстовое поле ValueBox на полученное значение
        }

        private void button1_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки для парсинга текста в значение перечисления WeekDay
        {
            string inputText = ParseBox.Text.Trim(); // Получаем введенный текст и убираем лишние пробелы

            if (Enum.TryParse(inputText, true, out Models.Enums.WeekDay weekday)) // Пытаемся распознать текст как значение перечисления
            {
                int dayNumber = (int)weekday; // Получаем числовой эквивалент
                TextOfTheDay.Text = $"Это день недели ({weekday} = {dayNumber})"; // Выводим результат
            }
            else
            {
                TextOfTheDay.Text = "Нет такого дня недели"; // Если распознать не удалось
            }

        }

        private void ButtonYear_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки для изменения цвета фона и тд
        {
            switch (YearSelector.SelectedIndex) // Проверяем индекс выбранного элемента в YearSelector
            {
                case 0: // Если выбран первый элемент
                    tabPage.BackColor = Color.Green; // Устанавливаем цвет фона таба на зеленый
                    break;
                case 1: //ну дальше так и будет в целом
                    tabPage.BackColor = Color.Yellow;
                    break;
                case 2:
                    MessageBox.Show("Томская зима сурова"); //нуачто
                    break;
                case 3:
                    MessageBox.Show("Сессия близко"); //онет
                    break;
                case 4:
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BGenerated = true;
            Random rnd = new Random();
            int Amount;
            if (Int32.TryParse(NumLabel.Text, out Amount))
            {
                Amount = int.Parse(NumLabel.Text);

                MessageBox.Show(Amount.ToString());
                rectangles = new Models.Rectangle[Amount];
                System.Diagnostics.Trace.WriteLine("message");


                for (int i = 0; i < Amount; i++)
                {
                    Models.Rectangle rec = new Models.Rectangle(rnd.Next(0, 500), rnd.Next(0, 500), new Point2D(rnd.Next(0, 500), rnd.Next(0, 500))); //Пришлось доопределять
                    rec.name = "Rectangle" + i;
                    rec.Color = "Red";
                    rectangles[i] = rec;
                    RectanglesList.Items.Add(rec.name);
                    RectanglesList2.Items.Add(rec.name);
                    Debug.WriteLine("Send to debug output.");
                }
            }
            else
            {
                MessageBox.Show("Dont do this man");
            }
        }
        void ChangeTextBoxesToRecData(int index)
        {
            var Width = rectangles[index].Width;
            var Height = rectangles[index].Height;
            var Color = rectangles[index].Color;
            int Id = rectangles[index].Id;

            NumLabel.Text = Id.ToString();
            Widthbox.Text = Width.ToString();
            LenghtBox.Text = Height.ToString();
            ColorBox.Text = Color.ToString();
        }
        private void ListOfRectanlges_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeTextBoxesToRecData(RectanglesList.SelectedIndex);
        }

        private void Widthbox_TextChanged(object sender, EventArgs e)
        {
            var Width = 0;
            if (Int32.TryParse(Widthbox.Text, out Width) && BGenerated)
            {
                var rec = rectangles[RectanglesList.SelectedIndex];
                rec.Width = Width;
            }
            else
            {
                MessageBox.Show("Write only DIGITS!!!");
                Widthbox.BackColor = Color.Red;
            }
        }
        private void Heightbox_TextChanged(Object sender, EventArgs e)
        {
            var Height = 0;
            if (Int32.TryParse(HeightBox.Text, out Height) && BGenerated)
            {
                var rec = rectangles[RectanglesList.SelectedIndex];
                rec.Height = Height;
            }
            else
            {
                MessageBox.Show("Write only DIGITS!!!");
                HeightBox.BackColor = Color.Red;
            }
        }

        private void ChangeValues_Click(object sender, EventArgs e)
        {
            var Height = 0;
            if (Int32.TryParse(CountOf.Text, out Height) && BGenerated)
            {
                var rec = rectangles[RectanglesList.SelectedIndex];
                rec.Height = Height;
            }
            else
            {
                MessageBox.Show("Write only DIGITS!!!");
            }
        }

        private void ColorBox_TextChanged(object sender, EventArgs e)
        {
            if (BGenerated)
            {
                var rec = rectangles[RectanglesList.SelectedIndex];
                var Color = ColorBox.Text;
                rec.Color = Color;
            }
        }
        private int FindRectangleWithMaxWidth(Models.Rectangle[] rectangles)
        {
            int maxWidth = 0;
            int index = 0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                if (maxWidth < rectangles[i].Width)
                {
                    maxWidth = rectangles[i].Width;
                    index = i;
                }
            }
            return index;

        }

        private void FRWMW_Click(object sender, EventArgs e)
        {
            if (BGenerated)
              RectanglesList.SelectedIndex = FindRectangleWithMaxWidth(rectangles);
        }

        
    }
}


            
        

    

