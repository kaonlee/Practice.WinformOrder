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
		protected override void Dispose ( bool disposing )
		{
			if (disposing && ( components != null ))
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
		private void InitializeComponent ()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			btnEnter =  new Button() ;
			pictureBox1 =  new PictureBox() ;
			numUPcola =  new NumericUpDown() ;
			label1 =  new Label() ;
			lbCola =  new Label() ;
			lbMilk =  new Label() ;
			label4 =  new Label() ;
			numUPmilk =  new NumericUpDown() ;
			pictureBox2 =  new PictureBox() ;
			pictureBox3 =  new PictureBox() ;
			numUPcoffee =  new NumericUpDown() ;
			label5 =  new Label() ;
			lbCoffee =  new Label() ;
			listView1 =  new ListView() ;
			columnName =  new ColumnHeader() ;
			columnQantity =  new ColumnHeader() ;
			columnPrice =  new ColumnHeader() ;
			label2 =  new Label() ;
			tbBuyer =  new TextBox() ;
			listView2 =  new ListView() ;
			columnBuyer =  new ColumnHeader() ;
			columnSummary =  new ColumnHeader() ;
			columnEachToatal =  new ColumnHeader() ;
			label3 =  new Label() ;
			label6 =  new Label() ;
			( (System.ComponentModel.ISupportInitialize) pictureBox1  ).BeginInit();
			( (System.ComponentModel.ISupportInitialize) numUPcola  ).BeginInit();
			( (System.ComponentModel.ISupportInitialize) numUPmilk  ).BeginInit();
			( (System.ComponentModel.ISupportInitialize) pictureBox2  ).BeginInit();
			( (System.ComponentModel.ISupportInitialize) pictureBox3  ).BeginInit();
			( (System.ComponentModel.ISupportInitialize) numUPcoffee  ).BeginInit();
			SuspendLayout();
			// 
			// btnEnter
			// 
			btnEnter.Location =  new Point(534, 271) ;
			btnEnter.Margin =  new Padding(2) ;
			btnEnter.Name =  "btnEnter" ;
			btnEnter.Size =  new Size(78, 34) ;
			btnEnter.TabIndex =  1 ;
			btnEnter.Text =  "Enter" ;
			btnEnter.UseVisualStyleBackColor =  true ;
			btnEnter.Click +=  btnEnter_Click ;
			// 
			// pictureBox1
			// 
			pictureBox1.Image =  (Image) resources.GetObject("pictureBox1.Image")  ;
			pictureBox1.Location =  new Point(44, 48) ;
			pictureBox1.Name =  "pictureBox1" ;
			pictureBox1.Size =  new Size(83, 102) ;
			pictureBox1.SizeMode =  PictureBoxSizeMode.StretchImage ;
			pictureBox1.TabIndex =  2 ;
			pictureBox1.TabStop =  false ;
			// 
			// numUPcola
			// 
			numUPcola.Location =  new Point(147, 92) ;
			numUPcola.Name =  "numUPcola" ;
			numUPcola.Size =  new Size(83, 23) ;
			numUPcola.TabIndex =  3 ;
			numUPcola.ValueChanged +=  numUPcola_ValueChanged ;
			// 
			// label1
			// 
			label1.AutoSize =  true ;
			label1.Font =  new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point) ;
			label1.Location =  new Point(147, 48) ;
			label1.Name =  "label1" ;
			label1.Size =  new Size(139, 25) ;
			label1.TabIndex =  4 ;
			label1.Text =  "可樂（30元）" ;
			// 
			// lbCola
			// 
			lbCola.AutoSize =  true ;
			lbCola.Location =  new Point(246, 125) ;
			lbCola.Name =  "lbCola" ;
			lbCola.Size =  new Size(10, 15) ;
			lbCola.TabIndex =  4 ;
			lbCola.Text =  "." ;
			// 
			// lbMilk
			// 
			lbMilk.AutoSize =  true ;
			lbMilk.Location =  new Point(246, 261) ;
			lbMilk.Name =  "lbMilk" ;
			lbMilk.Size =  new Size(10, 15) ;
			lbMilk.TabIndex =  7 ;
			lbMilk.Text =  "." ;
			// 
			// label4
			// 
			label4.AutoSize =  true ;
			label4.Font =  new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point) ;
			label4.Location =  new Point(147, 184) ;
			label4.Name =  "label4" ;
			label4.Size =  new Size(150, 25) ;
			label4.TabIndex =  8 ;
			label4.Text =  "牛奶（109元）" ;
			// 
			// numUPmilk
			// 
			numUPmilk.Location =  new Point(147, 228) ;
			numUPmilk.Name =  "numUPmilk" ;
			numUPmilk.Size =  new Size(83, 23) ;
			numUPmilk.TabIndex =  6 ;
			numUPmilk.ValueChanged +=  numUPmilk_ValueChanged ;
			// 
			// pictureBox2
			// 
			pictureBox2.Image =  (Image) resources.GetObject("pictureBox2.Image")  ;
			pictureBox2.Location =  new Point(44, 184) ;
			pictureBox2.Name =  "pictureBox2" ;
			pictureBox2.Size =  new Size(83, 102) ;
			pictureBox2.SizeMode =  PictureBoxSizeMode.StretchImage ;
			pictureBox2.TabIndex =  5 ;
			pictureBox2.TabStop =  false ;
			// 
			// pictureBox3
			// 
			pictureBox3.Image =  (Image) resources.GetObject("pictureBox3.Image")  ;
			pictureBox3.Location =  new Point(319, 48) ;
			pictureBox3.Name =  "pictureBox3" ;
			pictureBox3.Size =  new Size(83, 102) ;
			pictureBox3.SizeMode =  PictureBoxSizeMode.StretchImage ;
			pictureBox3.TabIndex =  5 ;
			pictureBox3.TabStop =  false ;
			// 
			// numUPcoffee
			// 
			numUPcoffee.Location =  new Point(422, 92) ;
			numUPcoffee.Name =  "numUPcoffee" ;
			numUPcoffee.Size =  new Size(83, 23) ;
			numUPcoffee.TabIndex =  6 ;
			numUPcoffee.ValueChanged +=  numUPcoffee_ValueChanged ;
			// 
			// label5
			// 
			label5.AutoSize =  true ;
			label5.Font =  new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point) ;
			label5.Location =  new Point(422, 48) ;
			label5.Name =  "label5" ;
			label5.Size =  new Size(139, 25) ;
			label5.TabIndex =  8 ;
			label5.Text =  "咖啡（90元）" ;
			// 
			// lbCoffee
			// 
			lbCoffee.AutoSize =  true ;
			lbCoffee.Location =  new Point(519, 125) ;
			lbCoffee.Name =  "lbCoffee" ;
			lbCoffee.Size =  new Size(10, 15) ;
			lbCoffee.TabIndex =  7 ;
			lbCoffee.Text =  "." ;
			// 
			// listView1
			// 
			listView1.Columns.AddRange(new ColumnHeader[] { columnName, columnQantity, columnPrice });
			listView1.Location =  new Point(44, 359) ;
			listView1.Name =  "listView1" ;
			listView1.Size =  new Size(228, 138) ;
			listView1.TabIndex =  11 ;
			listView1.UseCompatibleStateImageBehavior =  false ;
			// 
			// columnName
			// 
			columnName.Text =  "商品名稱" ;
			// 
			// columnQantity
			// 
			columnQantity.Text =  "數量" ;
			// 
			// columnPrice
			// 
			columnPrice.Text =  "總價" ;
			// 
			// label2
			// 
			label2.AutoSize =  true ;
			label2.Location =  new Point(388, 209) ;
			label2.Name =  "label2" ;
			label2.Size =  new Size(43, 15) ;
			label2.TabIndex =  12 ;
			label2.Text =  "訂購人" ;
			// 
			// tbBuyer
			// 
			tbBuyer.Location =  new Point(388, 238) ;
			tbBuyer.Name =  "tbBuyer" ;
			tbBuyer.Size =  new Size(100, 23) ;
			tbBuyer.TabIndex =  13 ;
			// 
			// listView2
			// 
			listView2.Columns.AddRange(new ColumnHeader[] { columnBuyer, columnSummary, columnEachToatal });
			listView2.Location =  new Point(319, 359) ;
			listView2.Name =  "listView2" ;
			listView2.Size =  new Size(293, 138) ;
			listView2.TabIndex =  14 ;
			listView2.UseCompatibleStateImageBehavior =  false ;
			// 
			// columnBuyer
			// 
			columnBuyer.Text =  "Buyer" ;
			// 
			// columnSummary
			// 
			columnSummary.Text =  "Summary" ;
			// 
			// columnEachToatal
			// 
			columnEachToatal.Text =  "Payment" ;
			// 
			// label3
			// 
			label3.AutoSize =  true ;
			label3.Location =  new Point(44, 331) ;
			label3.Name =  "label3" ;
			label3.Size =  new Size(55, 15) ;
			label3.TabIndex =  12 ;
			label3.Text =  "價格總和" ;
			label3.Click +=  label3_Click ;
			// 
			// label6
			// 
			label6.AutoSize =  true ;
			label6.Location =  new Point(319, 331) ;
			label6.Name =  "label6" ;
			label6.Size =  new Size(55, 15) ;
			label6.TabIndex =  12 ;
			label6.Text =  "每人明細" ;
			label6.Click +=  label3_Click ;
			// 
			// Form1
			// 
			AutoScaleDimensions =  new SizeF(7F, 15F) ;
			AutoScaleMode =  AutoScaleMode.Font ;
			ClientSize =  new Size(847, 552) ;
			Controls.Add(listView2);
			Controls.Add(tbBuyer);
			Controls.Add(label6);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(listView1);
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
			Margin =  new Padding(2) ;
			Name =  "Form1" ;
			Text =  "Form1" ;
			Load +=  Form1_Load ;
			( (System.ComponentModel.ISupportInitialize) pictureBox1  ).EndInit();
			( (System.ComponentModel.ISupportInitialize) numUPcola  ).EndInit();
			( (System.ComponentModel.ISupportInitialize) numUPmilk  ).EndInit();
			( (System.ComponentModel.ISupportInitialize) pictureBox2  ).EndInit();
			( (System.ComponentModel.ISupportInitialize) pictureBox3  ).EndInit();
			( (System.ComponentModel.ISupportInitialize) numUPcoffee  ).EndInit();
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
		private ListView listView1;
		private ColumnHeader columnName;
		private ColumnHeader columnQantity;
		private ColumnHeader columnPrice;
		private Label label2;
		private TextBox tbBuyer;
		private ListView listView2;
		private ColumnHeader columnBuyer;
		private ColumnHeader columnSummary;
		private ColumnHeader columnEachToatal;
		private Label label3;
		private Label label6;
	}
}