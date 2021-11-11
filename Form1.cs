using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB_3
{
    public partial class Form1 : Form
    {
        private CContainer cont;
        public Form1()
        {
            InitializeComponent();
            cont = new CContainer(pb1);
        }
        // Відрисовка фігури
        private void btDraw_Click(object sender, EventArgs e)
        {
            cont.Draw();
        }
        // Створення нової фігури
        private void btAdd_Click(object sender, EventArgs e)
        {
            float field2 = WrongTextBox(tbX1), field3 = WrongTextBox(tbY1), field4 = WrongTextBox(tb1side1), field5 = WrongTextBox(tb1side2);
            cont.Add(cbType1.SelectedIndex, field2, field3, field4, field5, cbColor1.SelectedIndex);
            lb1.Items.Add(cont.ToString(cont.GetLength()-1));
        }
       
        // Відображення параметрів виділенної фігури
        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lb1.SelectedIndex;
            if (index!=-1)
            {
                string[] paramlist = cont.ToString(index).Split(' ');
                cbType2.SelectedIndex = Convert.ToInt32(paramlist[0]); tbX2.Text = paramlist[1]; tbY2.Text = paramlist[2];
                tb2side1.Text = paramlist[3]; tb2side2.Text = paramlist[4]; cbColor2.SelectedIndex = Convert.ToInt32(paramlist[5]);
            }
        }
        // Збереження параметрів при редагуванні
        private void btSaveParams_Click(object sender, EventArgs e)
        {
            int index = lb1.SelectedIndex;
            if (index != -1)
            {
                float field2 = WrongTextBox(tbX2), field3 = WrongTextBox(tbY2), field4 = WrongTextBox(tb2side1), field5 = WrongTextBox(tb2side2);
                cont.Remove(index); lb1.Items.RemoveAt(index);
                cont.AddAt(cbType2.SelectedIndex, field2, field3, field4, field5, cbColor2.SelectedIndex,index);
                lb1.Items.Insert(index, cont.ToString(index));
            }
            else { MessageBox.Show("Ви не виділили жоден елемент", "Помилка"); }
        }
        // Пошук об'єкта
        private void btSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text != "" & cbSelectSearch.SelectedIndex != -1)
            {
                int request;

                try
                {
                    request = Convert.ToInt32(tbSearch.Text);
                }
                catch(FormatException)
                {
                    request = 999;
                }
                
                int searched_index;

                string[,] search_mas = new string[6, cont.GetLength()];
                string[] paramlist = new string[6];
                for (int i = 0; i < cont.GetLength(); i++)
                {
                    paramlist = cont.ToString(i).Split(' ');
                    for (int j = 0; j < 6; j++)
                    {
                        search_mas[j, i] = paramlist[j];
                    }
                }

                searched_index = SearchIndexInList(search_mas, cbSelectSearch.SelectedIndex, request);

                if (searched_index == -1) { lSearchResult.Text = "Нічого не знайдено"; }
                else
                {
                    lb1.SelectedIndex = searched_index;
                    lSearchResult.Text = $"Шуканий елемент виділено\nЙого номер {searched_index}";
                }
            }
            else if (tbSearch.Text == "") { MessageBox.Show("Ви не ввели пошуковий запит", "Помилка"); }
            else {MessageBox.Show("Ви не задали критерій пошуку", "Помилка");}
            
        }
        // Очистка дошки
        private void btClearBoard_Click(object sender, EventArgs e)
        {
            pb1.Image = null;
        }
        // Видалення знайденого елемента
        private void btRemove_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text != "" & cbSelectSearch.SelectedIndex != -1)
            {

                int request;

                try
                {
                    request = Convert.ToInt32(tbSearch.Text);
                }
                catch (FormatException)
                {
                    request = 999;
                }

                int searched_index;

                string[,] search_mas = new string[6, cont.GetLength()];
                string[] paramlist = new string[6];
                for (int i = 0; i < cont.GetLength(); i++)
                {
                    paramlist = cont.ToString(i).Split(' ');
                    for (int j = 0; j < 6; j++)
                    {
                        search_mas[j, i] = paramlist[j];
                    }
                }

                searched_index = SearchIndexInList(search_mas, cbSelectSearch.SelectedIndex, request);
                if (searched_index != -1) { cont.Remove(searched_index); lb1.Items.RemoveAt(searched_index); }
                if (searched_index == -1) { lSearchResult.Text = "Нічого не знайдено"; }
                else
                {
                    lSearchResult.Text = $"Шуканий елемент видалено\nЙого номер був {searched_index}";
                }
            }
            else if (tbSearch.Text == "") { MessageBox.Show("Ви не ввели пошуковий запит", "Помилка"); }
            else { MessageBox.Show("Ви не задали критерій пошуку", "Помилка"); }
        }
        //Видалення виділеного елемента
        private void btRemoveSelected_Click(object sender, EventArgs e)
        {
            int index=lb1.SelectedIndex;
            if (index == -1) { MessageBox.Show("Ви не виділили жоден елемент","Помилка"); }
            else { cont.Remove(index); lb1.Items.RemoveAt(index); }
        }





        // Метод пошуку данних у массиві, виводить індекс знайденного елемента, або 1. 
        // Використовується при пошуці.
        public int SearchIndexInList(string[,] search_mas, int param_number, int search_request)
        {
            int searched_index = -1;
            for (int i = 0; i < cont.GetLength(); i++)
            {
                if (Convert.ToInt32(search_mas[param_number,i]) == search_request) { searched_index = i; i = cont.GetLength(); }
            }
            return searched_index;
        }
        
        // Метод що оброблює даині з текстбоксу, запобігаючи помилкам.
        // В разі помилки в даних, виведе значення за замовчуванням.
        public float WrongTextBox(TextBox textBox)
        {
            float field;
            if (textBox.Text == "" || textBox.Text == " ") { field = -1; }
            else
            {
                bool x;
                x = float.TryParse(textBox.Text, out field);
                if (!x) field = 20;
            }
            return field;
        }


        
    }
}
