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
		private System.IO.Ports.SerialPort serialPort;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Button button_stop;
		
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
			this.serialPort = new System.IO.Ports.SerialPort(this.components);
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.button_stop = new System.Windows.Forms.Button();
			this.tableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_rewind
			// 
			this.button_rewind.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button_rewind.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_rewind.Location = new System.Drawing.Point(82, 2);
			this.button_rewind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button_rewind.Name = "button_rewind";
			this.button_rewind.Size = new System.Drawing.Size(73, 77);
			this.button_rewind.TabIndex = 2;
			this.button_rewind.Text = "|<";
			this.button_rewind.UseVisualStyleBackColor = true;
			this.button_rewind.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button_rewindMouseClick);
			// 
			// button_eject
			// 
			this.button_eject.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button_eject.Font = new System.Drawing.Font("Arial", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_eject.Location = new System.Drawing.Point(3, 2);
			this.button_eject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button_eject.Name = "button_eject";
			this.button_eject.Size = new System.Drawing.Size(73, 77);
			this.button_eject.TabIndex = 3;
			this.button_eject.Text = "^";
			this.button_eject.UseVisualStyleBackColor = true;
			this.button_eject.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button_ejectMouseClick);
			// 
			// button_prev
			// 
			this.button_prev.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button_prev.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_prev.Location = new System.Drawing.Point(240, 2);
			this.button_prev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button_prev.Name = "button_prev";
			this.button_prev.Size = new System.Drawing.Size(73, 77);
			this.button_prev.TabIndex = 4;
			this.button_prev.Text = "<<";
			this.button_prev.UseVisualStyleBackColor = true;
			this.button_prev.Click += new System.EventHandler(this.Button_prevClick);
			// 
			// button_play
			// 
			this.button_play.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button_play.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_play.Location = new System.Drawing.Point(477, 2);
			this.button_play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button_play.Name = "button_play";
			this.button_play.Size = new System.Drawing.Size(73, 77);
			this.button_play.TabIndex = 7;
			this.button_play.Text = ">";
			this.button_play.UseVisualStyleBackColor = true;
			this.button_play.Click += new System.EventHandler(this.Button_playClick);
			// 
			// button_ff
			// 
			this.button_ff.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button_ff.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_ff.Location = new System.Drawing.Point(161, 2);
			this.button_ff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button_ff.Name = "button_ff";
			this.button_ff.Size = new System.Drawing.Size(73, 77);
			this.button_ff.TabIndex = 6;
			this.button_ff.Text = ">|";
			this.button_ff.UseVisualStyleBackColor = true;
			this.button_ff.Click += new System.EventHandler(this.Button_ffClick);
			// 
			// button_rec
			// 
			this.button_rec.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button_rec.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_rec.Location = new System.Drawing.Point(556, 2);
			this.button_rec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button_rec.Name = "button_rec";
			this.button_rec.Size = new System.Drawing.Size(73, 77);
			this.button_rec.TabIndex = 5;
			this.button_rec.Text = "O";
			this.button_rec.UseVisualStyleBackColor = true;
			this.button_rec.Click += new System.EventHandler(this.Button_recClick);
			// 
			// button_cam
			// 
			this.button_cam.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button_cam.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_cam.Location = new System.Drawing.Point(635, 2);
			this.button_cam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button_cam.Name = "button_cam";
			this.button_cam.Size = new System.Drawing.Size(73, 77);
			this.button_cam.TabIndex = 9;
			this.button_cam.Text = "[o]";
			this.button_cam.UseVisualStyleBackColor = true;
			this.button_cam.Click += new System.EventHandler(this.Button_camClick);
			// 
			// button_menu
			// 
			this.button_menu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button_menu.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_menu.Location = new System.Drawing.Point(714, 2);
			this.button_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button_menu.Name = "button_menu";
			this.button_menu.Size = new System.Drawing.Size(75, 77);
			this.button_menu.TabIndex = 8;
			this.button_menu.Text = "?";
			this.button_menu.UseVisualStyleBackColor = true;
			this.button_menu.Click += new System.EventHandler(this.Button_menuClick);
			// 
			// button_next
			// 
			this.button_next.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button_next.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_next.Location = new System.Drawing.Point(398, 2);
			this.button_next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button_next.Name = "button_next";
			this.button_next.Size = new System.Drawing.Size(73, 77);
			this.button_next.TabIndex = 10;
			this.button_next.Text = ">>";
			this.button_next.UseVisualStyleBackColor = true;
			this.button_next.Click += new System.EventHandler(this.Button_nextClick);
			// 
			// textBox_output
			// 
			this.tableLayoutPanel.SetColumnSpan(this.textBox_output, 9);
			this.textBox_output.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_output.Location = new System.Drawing.Point(82, 83);
			this.textBox_output.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox_output.Multiline = true;
			this.textBox_output.Name = "textBox_output";
			this.textBox_output.ReadOnly = true;
			this.textBox_output.Size = new System.Drawing.Size(707, 77);
			this.textBox_output.TabIndex = 11;
			this.textBox_output.WordWrap = false;
			// 
			// label_No
			// 
			this.label_No.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_No.Location = new System.Drawing.Point(3, 81);
			this.label_No.Name = "label_No";
			this.label_No.Size = new System.Drawing.Size(73, 81);
			this.label_No.TabIndex = 12;
			this.label_No.Text = "00";
			this.label_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// serialPort
			// 
			this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPortDataReceived);
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 11;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel.Controls.Add(this.button_rewind, 2, 0);
			this.tableLayoutPanel.Controls.Add(this.button_ff, 3, 0);
			this.tableLayoutPanel.Controls.Add(this.button_next, 6, 0);
			this.tableLayoutPanel.Controls.Add(this.button_prev, 4, 0);
			this.tableLayoutPanel.Controls.Add(this.button_play, 7, 0);
			this.tableLayoutPanel.Controls.Add(this.button_cam, 9, 0);
			this.tableLayoutPanel.Controls.Add(this.button_rec, 8, 0);
			this.tableLayoutPanel.Controls.Add(this.button_menu, 10, 0);
			this.tableLayoutPanel.Controls.Add(this.button_eject, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.label_No, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.textBox_output, 2, 1);
			this.tableLayoutPanel.Controls.Add(this.button_stop, 5, 0);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 2;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(792, 162);
			this.tableLayoutPanel.TabIndex = 1;
			// 
			// button_stop
			// 
			this.button_stop.AccessibleName = "stop";
			this.button_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_stop.Location = new System.Drawing.Point(319, 3);
			this.button_stop.Name = "button_stop";
			this.button_stop.Size = new System.Drawing.Size(73, 75);
			this.button_stop.TabIndex = 13;
			this.button_stop.Text = "[X]";
			this.button_stop.UseVisualStyleBackColor = true;
			this.button_stop.Click += new System.EventHandler(this.Button_stopClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(792, 162);
			this.Controls.Add(this.tableLayoutPanel);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.Text = "SlideControl Panel";
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
