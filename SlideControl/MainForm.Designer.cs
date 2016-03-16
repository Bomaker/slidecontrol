/*
 * Created by SharpDevelop.
 * User: Sysop
 * Date: 10.03.2016
 * Time: 20:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SlideControl
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button_eject;
		private System.Windows.Forms.Button button_prev;
		private System.Windows.Forms.Button button_rewind;
		private System.Windows.Forms.Button button_play;
		private System.Windows.Forms.Button button_ff;
		private System.Windows.Forms.Button button_rec;
		private System.Windows.Forms.Button button_cam;
		private System.Windows.Forms.Button button_menu;
		private System.Windows.Forms.Button button_next;
		private System.Windows.Forms.TextBox textBox_output;
		private System.Windows.Forms.Label label_No;
		private System.IO.Ports.SerialPort serialPort1;
		
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
			this.components = new System.ComponentModel.Container();
			this.button_rewind = new System.Windows.Forms.Button();
			this.button_eject = new System.Windows.Forms.Button();
			this.button_prev = new System.Windows.Forms.Button();
			this.button_play = new System.Windows.Forms.Button();
			this.button_ff = new System.Windows.Forms.Button();
			this.button_rec = new System.Windows.Forms.Button();
			this.button_cam = new System.Windows.Forms.Button();
			this.button_menu = new System.Windows.Forms.Button();
			this.button_next = new System.Windows.Forms.Button();
			this.textBox_output = new System.Windows.Forms.TextBox();
			this.label_No = new System.Windows.Forms.Label();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.SuspendLayout();
			// 
			// button_rewind
			// 
			this.button_rewind.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_rewind.Location = new System.Drawing.Point(82, 10);
			this.button_rewind.Name = "button_rewind";
			this.button_rewind.Size = new System.Drawing.Size(68, 62);
			this.button_rewind.TabIndex = 2;
			this.button_rewind.Text = "<<";
			this.button_rewind.UseVisualStyleBackColor = true;
			// 
			// button_eject
			// 
			this.button_eject.Font = new System.Drawing.Font("Arial", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_eject.Location = new System.Drawing.Point(8, 10);
			this.button_eject.Name = "button_eject";
			this.button_eject.Size = new System.Drawing.Size(68, 62);
			this.button_eject.TabIndex = 3;
			this.button_eject.Text = "^";
			this.button_eject.UseVisualStyleBackColor = true;
			this.button_eject.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button_ejectMouseClick);
			// 
			// button_prev
			// 
			this.button_prev.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_prev.Location = new System.Drawing.Point(230, 12);
			this.button_prev.Name = "button_prev";
			this.button_prev.Size = new System.Drawing.Size(68, 62);
			this.button_prev.TabIndex = 4;
			this.button_prev.Text = "|<<";
			this.button_prev.UseVisualStyleBackColor = true;
			// 
			// button_play
			// 
			this.button_play.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_play.Location = new System.Drawing.Point(378, 10);
			this.button_play.Name = "button_play";
			this.button_play.Size = new System.Drawing.Size(68, 62);
			this.button_play.TabIndex = 7;
			this.button_play.Text = ">";
			this.button_play.UseVisualStyleBackColor = true;
			// 
			// button_ff
			// 
			this.button_ff.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_ff.Location = new System.Drawing.Point(156, 10);
			this.button_ff.Name = "button_ff";
			this.button_ff.Size = new System.Drawing.Size(68, 62);
			this.button_ff.TabIndex = 6;
			this.button_ff.Text = ">>";
			this.button_ff.UseVisualStyleBackColor = true;
			// 
			// button_rec
			// 
			this.button_rec.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_rec.Location = new System.Drawing.Point(452, 10);
			this.button_rec.Name = "button_rec";
			this.button_rec.Size = new System.Drawing.Size(68, 62);
			this.button_rec.TabIndex = 5;
			this.button_rec.Text = "O";
			this.button_rec.UseVisualStyleBackColor = true;
			// 
			// button_cam
			// 
			this.button_cam.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_cam.Location = new System.Drawing.Point(528, 10);
			this.button_cam.Name = "button_cam";
			this.button_cam.Size = new System.Drawing.Size(68, 62);
			this.button_cam.TabIndex = 9;
			this.button_cam.Text = "[o]";
			this.button_cam.UseVisualStyleBackColor = true;
			// 
			// button_menu
			// 
			this.button_menu.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_menu.Location = new System.Drawing.Point(602, 10);
			this.button_menu.Name = "button_menu";
			this.button_menu.Size = new System.Drawing.Size(68, 62);
			this.button_menu.TabIndex = 8;
			this.button_menu.Text = "?";
			this.button_menu.UseVisualStyleBackColor = true;
			// 
			// button_next
			// 
			this.button_next.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_next.Location = new System.Drawing.Point(304, 14);
			this.button_next.Name = "button_next";
			this.button_next.Size = new System.Drawing.Size(68, 62);
			this.button_next.TabIndex = 10;
			this.button_next.Text = ">>|";
			this.button_next.UseVisualStyleBackColor = true;
			// 
			// textBox_output
			// 
			this.textBox_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_output.Location = new System.Drawing.Point(82, 82);
			this.textBox_output.Multiline = true;
			this.textBox_output.Name = "textBox_output";
			this.textBox_output.ReadOnly = true;
			this.textBox_output.Size = new System.Drawing.Size(590, 70);
			this.textBox_output.TabIndex = 11;
			this.textBox_output.WordWrap = false;
			// 
			// label_No
			// 
			this.label_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_No.Location = new System.Drawing.Point(8, 82);
			this.label_No.Name = "label_No";
			this.label_No.Size = new System.Drawing.Size(68, 70);
			this.label_No.TabIndex = 12;
			this.label_No.Text = "00";
			this.label_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// serialPort1
			// 
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1DataReceived);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(681, 167);
			this.Controls.Add(this.label_No);
			this.Controls.Add(this.textBox_output);
			this.Controls.Add(this.button_next);
			this.Controls.Add(this.button_cam);
			this.Controls.Add(this.button_menu);
			this.Controls.Add(this.button_play);
			this.Controls.Add(this.button_ff);
			this.Controls.Add(this.button_rec);
			this.Controls.Add(this.button_prev);
			this.Controls.Add(this.button_eject);
			this.Controls.Add(this.button_rewind);
			this.Name = "MainForm";
			this.Text = "myTest";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
