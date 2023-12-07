/*
 * Создано в SharpDevelop.
 * Пользователь: user
 * Дата: 03.05.2022
 * Время: 21:46
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Страховая_компания
{
	partial class Form17
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form17));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(94, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(298, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Что делать при несчастном случае в путишествии";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(446, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "В случае смерти Застрахованного лица:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(446, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Обратится в страховую компанию со следующими документами:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(446, 172);
			this.label4.TabIndex = 3;
			this.label4.Text = resources.GetString("label4.Text");
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(12, 240);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(446, 22);
			this.label5.TabIndex = 4;
			this.label5.Text = "В случае установления инвалидности Застрахованному лицу:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(13, 256);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(445, 167);
			this.label6.TabIndex = 5;
			this.label6.Text = resources.GetString("label6.Text");
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(13, 423);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(445, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "В случае получения травмы Застрахованным лицом:";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(13, 441);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(445, 71);
			this.label8.TabIndex = 7;
			this.label8.Text = resources.GetString("label8.Text");
			// 
			// Form17
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(470, 514);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form17";
			this.Text = "Несчастный случай";
			this.ResumeLayout(false);

		}
	}
}
