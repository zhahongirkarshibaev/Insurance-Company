﻿/*
 * Создано в SharpDevelop.
 * Пользователь: user
 * Дата: 03.05.2022
 * Время: 18:46
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Страховая_компания
{
	partial class Form16
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(123, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(189, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Что делать при потере багажа?";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(442, 42);
			this.label2.TabIndex = 1;
			this.label2.Text = "1. Незамедлительно на месте происшествия обратитесь в транспортную организацию дл" +
	"я получения документа, фиксирующего факт гибели либо утраты багажа.";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(442, 32);
			this.label3.TabIndex = 2;
			this.label3.Text = "2. В течение 35 календарных дней после возвращения из поездки, но не ранее 21 дня" +
	" со дня утраты багажа обратитесь в Страховую компанию ";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(246, 46);
			this.label4.TabIndex = 3;
			this.label4.Text = "Для звонков по Москве +79771506717\r\nДля звонков по МО +79160028071\r\nДля звонков и" +
	"з-за за рубежа +79854569874";
			// 
			// Form16
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 261);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form16";
			this.Text = "Утеря багажа";
			this.ResumeLayout(false);

		}
	}
}
