/*
 * Создано в SharpDevelop.
 * Пользователь: user
 * Дата: 30.04.2022
 * Время: 20:58
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Страховая_компания
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ЧастнымЛицамToolStripMenuItemClick(object sender, EventArgs e)
		{
	
		}
		void ДМСДляЮрЛицToolStripMenuItemClick(object sender, EventArgs e)
		{
	
		}
		void ЮридическимЛицамToolStripMenuItemClick(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			Form1 newForm = new Form1();
    		newForm.Show();
		}
		void Button2Click(object sender, EventArgs e)
		{
		    Form2 newForm = new Form2();
    		newForm.Show();
		}
		void АвтоToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form1 newForm = new Form1();
    		newForm.Show();
		}
		void ПутишествиеToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form1 newForm = new Form1();
    		newForm.Show();
		}
		void ЗдоровьеToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form1 newForm = new Form1();
    		newForm.Show();
		}
		void ИмуществоToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form1 newForm = new Form1();
    		newForm.Show();
		}
		void СтрахованиеТранспортаToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form24 newForm = new Form24();
    		newForm.Show();
		}

	}
}
