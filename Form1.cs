/*
 * Создано в SharpDevelop.
 * Пользователь: user
 * Дата: 03.05.2022
 * Время: 10:58
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Страховая_компания
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label4Click(object sender, EventArgs e)
		{
	
		}
		void Button2Click(object sender, EventArgs e)
		{
			Form3 newForm = new Form3();
    		newForm.Show();
		}
		void Button1Click(object sender, EventArgs e)
		{
			Form4 newForm = new Form4();
    		newForm.Show();
		}
		void Button3Click(object sender, EventArgs e)
		{
			Form5 newForm = new Form5();
    		newForm.Show();
		}
		void Button4Click(object sender, EventArgs e)
		{
			Form6 newForm = new Form6();
    		newForm.Show();
		}
		void Button6Click(object sender, EventArgs e)
		{
			Form7 newForm = new Form7();
    		newForm.Show();
		}
		void Button5Click(object sender, EventArgs e)
		{
			Form8 newForm = new Form8();
    		newForm.Show();
		}
		void Button7Click(object sender, EventArgs e)
		{
			Form9 newForm = new Form9();
    		newForm.Show();
		}
		void Button8Click(object sender, EventArgs e)
		{
			Form10 newForm = new Form10();
    		newForm.Show();
		}
		void Button10Click(object sender, EventArgs e)
		{
			Form11 newForm = new Form11();
    		newForm.Show();
		}
	}
}
