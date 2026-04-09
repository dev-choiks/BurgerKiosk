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
            grbMenu = new GroupBox();
            rbnHam3 = new RadioButton();
            rbnHam2 = new RadioButton();
            rbnHam1 = new RadioButton();
            imgHam3 = new PictureBox();
            imgHam2 = new PictureBox();
            imgHam1 = new PictureBox();
            grbSide = new GroupBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            chkCola = new CheckBox();
            chkFries = new CheckBox();
            grbOrder = new GroupBox();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            btnOrder = new Button();
            btnClear = new Button();
            lblError = new Label();
            grbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgHam3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgHam2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgHam1).BeginInit();
            grbSide.SuspendLayout();
            grbOrder.SuspendLayout();
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
            // grbMenu
            // 
            grbMenu.Controls.Add(rbnHam3);
            grbMenu.Controls.Add(rbnHam2);
            grbMenu.Controls.Add(rbnHam1);
            grbMenu.Controls.Add(imgHam3);
            grbMenu.Controls.Add(imgHam2);
            grbMenu.Controls.Add(imgHam1);
            grbMenu.Font = new Font("한컴 말랑말랑 Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grbMenu.ForeColor = Color.Coral;
            grbMenu.Location = new Point(22, 106);
            grbMenu.Name = "grbMenu";
            grbMenu.Size = new Size(269, 293);
            grbMenu.TabIndex = 1;
            grbMenu.TabStop = false;
            grbMenu.Text = "메뉴선택";
            grbMenu.Enter += grbMenu_Enter;
            // 
            // rbnHam3
            // 
            rbnHam3.AutoSize = true;
            rbnHam3.ForeColor = Color.Black;
            rbnHam3.Location = new Point(17, 220);
            rbnHam3.Name = "rbnHam3";
            rbnHam3.Size = new Size(103, 30);
            rbnHam3.TabIndex = 2;
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
            rbnHam2.TabIndex = 1;
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
            rbnHam1.TabIndex = 0;
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
            // grbSide
            // 
            grbSide.Controls.Add(chkSauce);
            grbSide.Controls.Add(chkCheese);
            grbSide.Controls.Add(chkCola);
            grbSide.Controls.Add(chkFries);
            grbSide.Font = new Font("한컴 말랑말랑 Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grbSide.ForeColor = Color.Coral;
            grbSide.Location = new Point(310, 106);
            grbSide.Name = "grbSide";
            grbSide.Size = new Size(164, 190);
            grbSide.TabIndex = 2;
            grbSide.TabStop = false;
            grbSide.Text = "추가옵션";
            grbSide.Enter += grbSide_Enter;
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
            // grbOrder
            // 
            grbOrder.Controls.Add(lblTotalCost);
            grbOrder.Controls.Add(lstOrder);
            grbOrder.Font = new Font("한컴 말랑말랑 Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grbOrder.ForeColor = Color.Coral;
            grbOrder.Location = new Point(497, 106);
            grbOrder.Name = "grbOrder";
            grbOrder.Size = new Size(279, 236);
            grbOrder.TabIndex = 3;
            grbOrder.TabStop = false;
            grbOrder.Text = "주문내역";
            grbOrder.Enter += grbOrder_Enter;
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
            lstOrder.TabStop = false;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("한컴 말랑말랑 Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnOrder.ForeColor = Color.CornflowerBlue;
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
            btnClear.ForeColor = Color.Crimson;
            btnClear.Location = new Point(638, 348);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(138, 51);
            btnClear.TabIndex = 0;
            btnClear.Text = "초기화";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("한컴 말랑말랑 Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(497, 406);
            lblError.Name = "lblError";
            lblError.Size = new Size(157, 26);
            lblError.TabIndex = 6;
            lblError.Text = "메뉴를 선택하세요.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblError);
            Controls.Add(btnClear);
            Controls.Add(btnOrder);
            Controls.Add(grbOrder);
            Controls.Add(grbSide);
            Controls.Add(grbMenu);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Burger Kiosk";
            grbMenu.ResumeLayout(false);
            grbMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgHam3).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgHam2).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgHam1).EndInit();
            grbSide.ResumeLayout(false);
            grbSide.PerformLayout();
            grbOrder.ResumeLayout(false);
            grbOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grbMenu;
        private PictureBox imgHam3;
        private PictureBox imgHam2;
        private PictureBox imgHam1;
        private RadioButton rbnHam3;
        private RadioButton rbnHam2;
        private RadioButton rbnHam1;
        private GroupBox grbSide;
        private CheckBox chkSauce;
        private CheckBox chkCheese;
        private CheckBox chkCola;
        private CheckBox chkFries;
        private GroupBox grbOrder;
        private ListBox lstOrder;
        private Label lblTotalCost;
        private Button btnOrder;
        private Button btnClear;
        private Label lblError;
    }
}
