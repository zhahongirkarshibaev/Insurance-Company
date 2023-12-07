/*
 * Создано в SharpDevelop.
 * Пользователь: user
 * Дата: 02.05.2022
 * Время: 18:55
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
		public Form1(Form f)
		{
		InitializeComponent();
        f.BackColor = Color.Yellow;
		}
		private void button1_Click(object sender, EventArgs e)
		{
    		Form1 newForm = new Form1(this);
    		newForm.Show();
		}
		void MenuStrip1ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
	
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
				Form3 newForm = new Form3();
    			newForm.Show();
		}
	}
}

