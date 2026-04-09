namespace BurgerKiosk
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
            lblTitle = new Label();
            groupBox1 = new GroupBox();
            rbnHam3 = new RadioButton();
            rbnHam2 = new RadioButton();
            rbnHam1 = new RadioButton();
            imgHam3 = new PictureBox();
            imgHam2 = new PictureBox();
            imgHam1 = new PictureBox();
            groupBox2 = new GroupBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            chkCola = new CheckBox();
            chkFries = new CheckBox();
            groupBox3 = new GroupBox();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            btnOrder = new Button();
            btnClear = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgHam3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgHam2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgHam1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("한컴 말랑말랑 Bold", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTitle.ForeColor = Color.Coral;
            lblTitle.Location = new Point(22, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(372, 61);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "버거 주문 키오스크";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbnHam3);
            groupBox1.Controls.Add(rbnHam2);
            groupBox1.Controls.Add(rbnHam1);
            groupBox1.Controls.Add(imgHam3);
            groupBox1.Controls.Add(imgHam2);
            groupBox1.Controls.Add(imgHam1);
            groupBox1.Font = new Font("한컴 말랑말랑 Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox1.ForeColor = Color.Coral;
            groupBox1.Location = new Point(22, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(269, 293);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "메뉴선택";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rbnHam3
            // 
            rbnHam3.AutoSize = true;
            rbnHam3.ForeColor = Color.Black;
            rbnHam3.Location = new Point(17, 220);
            rbnHam3.Name = "rbnHam3";
            rbnHam3.Size = new Size(103, 30);
            rbnHam3.TabIndex = 7;
            rbnHam3.TabStop = true;
            rbnHam3.Text = "치킨버거";
            rbnHam3.UseVisualStyleBackColor = true;
            // 
            // rbnHam2
            // 
            rbnHam2.AutoSize = true;
            rbnHam2.ForeColor = Color.Black;
            rbnHam2.Location = new Point(17, 135);
            rbnHam2.Name = "rbnHam2";
            rbnHam2.Size = new Size(119, 30);
            rbnHam2.TabIndex = 6;
            rbnHam2.TabStop = true;
            rbnHam2.Text = "불고기버거";
            rbnHam2.UseVisualStyleBackColor = true;
            // 
            // rbnHam1
            // 
            rbnHam1.AutoSize = true;
            rbnHam1.ForeColor = Color.Black;
            rbnHam1.Location = new Point(17, 52);
            rbnHam1.Name = "rbnHam1";
            rbnHam1.Size = new Size(85, 30);
            rbnHam1.TabIndex = 5;
            rbnHam1.TabStop = true;
            rbnHam1.Text = "햄버거";
            rbnHam1.UseVisualStyleBackColor = true;
            // 
            // imgHam3
            // 
            imgHam3.Image = Properties.Resources.ham3;
            imgHam3.Location = new Point(175, 196);
            imgHam3.Name = "imgHam3";
            imgHam3.Size = new Size(77, 76);
            imgHam3.SizeMode = PictureBoxSizeMode.StretchImage;
            imgHam3.TabIndex = 4;
            imgHam3.TabStop = false;
            // 
            // imgHam2
            // 
            imgHam2.Image = Properties.Resources.ham2;
            imgHam2.Location = new Point(175, 114);
            imgHam2.Name = "imgHam2";
            imgHam2.Size = new Size(77, 76);
            imgHam2.SizeMode = PictureBoxSizeMode.StretchImage;
            imgHam2.TabIndex = 3;
            imgHam2.TabStop = false;
            // 
            // imgHam1
            // 
            imgHam1.Image = Properties.Resources.ham1;
            imgHam1.Location = new Point(175, 32);
            imgHam1.Name = "imgHam1";
            imgHam1.Size = new Size(77, 76);
            imgHam1.SizeMode = PictureBoxSizeMode.StretchImage;
            imgHam1.TabIndex = 2;
            imgHam1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkSauce);
            groupBox2.Controls.Add(chkCheese);
            groupBox2.Controls.Add(chkCola);
            groupBox2.Controls.Add(chkFries);
            groupBox2.Font = new Font("한컴 말랑말랑 Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox2.ForeColor = Color.Coral;
            groupBox2.Location = new Point(310, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(164, 190);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "추가옵션";
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.ForeColor = Color.Black;
            chkSauce.Location = new Point(18, 143);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(105, 30);
            chkSauce.TabIndex = 3;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.ForeColor = Color.Black;
            chkCheese.Location = new Point(17, 107);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(106, 30);
            chkCheese.TabIndex = 2;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.ForeColor = Color.Black;
            chkCola.Location = new Point(18, 71);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(67, 30);
            chkCola.TabIndex = 1;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkFries
            // 
            chkFries.AutoSize = true;
            chkFries.ForeColor = Color.Black;
            chkFries.Location = new Point(18, 35);
            chkFries.Name = "chkFries";
            chkFries.Size = new Size(104, 30);
            chkFries.TabIndex = 0;
            chkFries.Text = "감자튀김";
            chkFries.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblTotalCost);
            groupBox3.Controls.Add(lstOrder);
            groupBox3.Font = new Font("한컴 말랑말랑 Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            groupBox3.ForeColor = Color.Coral;
            groupBox3.Location = new Point(497, 106);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(279, 236);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "주문내역";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Location = new Point(12, 187);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(109, 26);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "총 금액: 0원";
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(12, 36);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(259, 134);
            lstOrder.TabIndex = 0;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("한컴 말랑말랑 Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnOrder.ForeColor = Color.Coral;
            btnOrder.Location = new Point(497, 348);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(138, 51);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("한컴 말랑말랑 Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnClear.ForeColor = Color.CornflowerBlue;
            btnClear.Location = new Point(638, 348);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(138, 51);
            btnClear.TabIndex = 5;
            btnClear.Text = "초기화";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnOrder);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Burger Kiosk";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgHam3).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgHam2).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgHam1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox groupBox1;
        private PictureBox imgHam3;
        private PictureBox imgHam2;
        private PictureBox imgHam1;
        private RadioButton rbnHam3;
        private RadioButton rbnHam2;
        private RadioButton rbnHam1;
        private GroupBox groupBox2;
        private CheckBox chkSauce;
        private CheckBox chkCheese;
        private CheckBox chkCola;
        private CheckBox chkFries;
        private GroupBox groupBox3;
        private ListBox lstOrder;
        private Label lblTotalCost;
        private Button btnOrder;
        private Button btnClear;
    }
}
