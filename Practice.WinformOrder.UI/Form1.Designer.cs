namespace Practice.WinformOrder.UI
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			btnEnter = new Button();
			pictureBox1 = new PictureBox();
			numUPcola = new NumericUpDown();
			label1 = new Label();
			lbCola = new Label();
			lbMilk = new Label();
			label4 = new Label();
			numUPmilk = new NumericUpDown();
			pictureBox2 = new PictureBox();
			pictureBox3 = new PictureBox();
			numUPcoffee = new NumericUpDown();
			label5 = new Label();
			lbCoffee = new Label();
			textBox1 = new TextBox();
			listView1 = new ListView();
			columnName = new ColumnHeader();
			columnQantity = new ColumnHeader();
			columnPrice = new ColumnHeader();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)numUPcola).BeginInit();
			((System.ComponentModel.ISupportInitialize)numUPmilk).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)numUPcoffee).BeginInit();
			SuspendLayout();
			// 
			// btnEnter
			// 
			btnEnter.Location = new Point(382, 309);
			btnEnter.Margin = new Padding(2);
			btnEnter.Name = "btnEnter";
			btnEnter.Size = new Size(78, 34);
			btnEnter.TabIndex = 1;
			btnEnter.Text = "Enter";
			btnEnter.UseVisualStyleBackColor = true;
			btnEnter.Click += btnEnter_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(42, 58);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(83, 102);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// numUPcola
			// 
			numUPcola.Location = new Point(145, 102);
			numUPcola.Name = "numUPcola";
			numUPcola.Size = new Size(83, 23);
			numUPcola.TabIndex = 3;
			numUPcola.ValueChanged += numUPcola_ValueChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(145, 58);
			label1.Name = "label1";
			label1.Size = new Size(139, 25);
			label1.TabIndex = 4;
			label1.Text = "可樂（30元）";
			// 
			// lbCola
			// 
			lbCola.AutoSize = true;
			lbCola.Location = new Point(244, 135);
			lbCola.Name = "lbCola";
			lbCola.Size = new Size(10, 15);
			lbCola.TabIndex = 4;
			lbCola.Text = ".";
			// 
			// lbMilk
			// 
			lbMilk.AutoSize = true;
			lbMilk.Location = new Point(506, 135);
			lbMilk.Name = "lbMilk";
			lbMilk.Size = new Size(10, 15);
			lbMilk.TabIndex = 7;
			lbMilk.Text = ".";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(407, 58);
			label4.Name = "label4";
			label4.Size = new Size(150, 25);
			label4.TabIndex = 8;
			label4.Text = "牛奶（109元）";
			// 
			// numUPmilk
			// 
			numUPmilk.Location = new Point(407, 102);
			numUPmilk.Name = "numUPmilk";
			numUPmilk.Size = new Size(83, 23);
			numUPmilk.TabIndex = 6;
			numUPmilk.ValueChanged += numUPmilk_ValueChanged;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(304, 58);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(83, 102);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 5;
			pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(42, 194);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(83, 102);
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox3.TabIndex = 5;
			pictureBox3.TabStop = false;
			// 
			// numUPcoffee
			// 
			numUPcoffee.Location = new Point(145, 238);
			numUPcoffee.Name = "numUPcoffee";
			numUPcoffee.Size = new Size(83, 23);
			numUPcoffee.TabIndex = 6;
			numUPcoffee.ValueChanged += numUPcoffee_ValueChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label5.Location = new Point(145, 194);
			label5.Name = "label5";
			label5.Size = new Size(139, 25);
			label5.TabIndex = 8;
			label5.Text = "咖啡（90元）";
			// 
			// lbCoffee
			// 
			lbCoffee.AutoSize = true;
			lbCoffee.Location = new Point(244, 271);
			lbCoffee.Name = "lbCoffee";
			lbCoffee.Size = new Size(10, 15);
			lbCoffee.TabIndex = 7;
			lbCoffee.Text = ".";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(331, 359);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(226, 138);
			textBox1.TabIndex = 10;
			// 
			// listView1
			// 
			listView1.Columns.AddRange(new ColumnHeader[] { columnName, columnQantity, columnPrice });
			listView1.Location = new Point(44, 359);
			listView1.Name = "listView1";
			listView1.Size = new Size(228, 138);
			listView1.TabIndex = 11;
			listView1.UseCompatibleStateImageBehavior = false;
			// 
			// columnName
			// 
			columnName.Text = "商品名稱";
			// 
			// columnQantity
			// 
			columnQantity.Text = "數量";
			// 
			// columnPrice
			// 
			columnPrice.Text = "總價";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(607, 532);
			Controls.Add(listView1);
			Controls.Add(textBox1);
			Controls.Add(lbCoffee);
			Controls.Add(lbMilk);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(numUPcoffee);
			Controls.Add(numUPmilk);
			Controls.Add(pictureBox3);
			Controls.Add(pictureBox2);
			Controls.Add(lbCola);
			Controls.Add(label1);
			Controls.Add(numUPcola);
			Controls.Add(pictureBox1);
			Controls.Add(btnEnter);
			Margin = new Padding(2);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)numUPcola).EndInit();
			((System.ComponentModel.ISupportInitialize)numUPmilk).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)numUPcoffee).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button btnEnter;
		private PictureBox pictureBox1;
		private NumericUpDown numUPcola;
		private Label label1;
		private Label lbCola;
		private Label lbMilk;
		private Label label4;
		private NumericUpDown numUPmilk;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private NumericUpDown numUPcoffee;
		private Label label5;
		private Label lbCoffee;
		private TextBox textBox1;
		private ListView listView1;
		private ColumnHeader columnName;
		private ColumnHeader columnQantity;
		private ColumnHeader columnPrice;
	}
}