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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblMain = new Label();
            groupMenu = new GroupBox();
            picChicken = new PictureBox();
            picBulGogi = new PictureBox();
            picHamBurger = new PictureBox();
            rdoChickenBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoHamBurger = new RadioButton();
            groupOption = new GroupBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            chkCola = new CheckBox();
            chkPotato = new CheckBox();
            grouplistTotal = new GroupBox();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            btnOrder = new Button();
            btnReset = new Button();
            lblError = new Label();
            groupMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChicken).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBulGogi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHamBurger).BeginInit();
            groupOption.SuspendLayout();
            grouplistTotal.SuspendLayout();
            SuspendLayout();
            // 
            // lblMain
            // 
            lblMain.AutoSize = true;
            lblMain.Font = new Font("맑은 고딕", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblMain.ForeColor = Color.Blue;
            lblMain.Location = new Point(31, 20);
            lblMain.Name = "lblMain";
            lblMain.Size = new Size(344, 50);
            lblMain.TabIndex = 0;
            lblMain.Text = "버거 주문 키오스크";
            // 
            // groupMenu
            // 
            groupMenu.Controls.Add(picChicken);
            groupMenu.Controls.Add(picBulGogi);
            groupMenu.Controls.Add(picHamBurger);
            groupMenu.Controls.Add(rdoChickenBurger);
            groupMenu.Controls.Add(rdoBulgogiBurger);
            groupMenu.Controls.Add(rdoHamBurger);
            groupMenu.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            groupMenu.ForeColor = Color.Red;
            groupMenu.Location = new Point(26, 84);
            groupMenu.Name = "groupMenu";
            groupMenu.Size = new Size(214, 316);
            groupMenu.TabIndex = 0;
            groupMenu.TabStop = false;
            groupMenu.Text = "메뉴 선택";
            // 
            // picChicken
            // 
            picChicken.Image = (Image)resources.GetObject("picChicken.Image");
            picChicken.Location = new Point(126, 221);
            picChicken.Name = "picChicken";
            picChicken.Size = new Size(82, 74);
            picChicken.SizeMode = PictureBoxSizeMode.StretchImage;
            picChicken.TabIndex = 5;
            picChicken.TabStop = false;
            // 
            // picBulGogi
            // 
            picBulGogi.Image = (Image)resources.GetObject("picBulGogi.Image");
            picBulGogi.Location = new Point(126, 129);
            picBulGogi.Name = "picBulGogi";
            picBulGogi.Size = new Size(82, 74);
            picBulGogi.SizeMode = PictureBoxSizeMode.StretchImage;
            picBulGogi.TabIndex = 4;
            picBulGogi.TabStop = false;
            // 
            // picHamBurger
            // 
            picHamBurger.Image = (Image)resources.GetObject("picHamBurger.Image");
            picHamBurger.Location = new Point(126, 42);
            picHamBurger.Name = "picHamBurger";
            picHamBurger.Size = new Size(82, 74);
            picHamBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picHamBurger.TabIndex = 3;
            picHamBurger.TabStop = false;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rdoChickenBurger.ForeColor = Color.Black;
            rdoChickenBurger.Location = new Point(6, 242);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(106, 29);
            rdoChickenBurger.TabIndex = 3;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            rdoChickenBurger.CheckedChanged += rdoChickenBurger_CheckedChanged;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rdoBulgogiBurger.ForeColor = Color.Black;
            rdoBulgogiBurger.Location = new Point(5, 152);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(125, 29);
            rdoBulgogiBurger.TabIndex = 2;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            rdoBulgogiBurger.CheckedChanged += rdoBulgogiBurger_CheckedChanged;
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            rdoHamBurger.ForeColor = Color.Black;
            rdoHamBurger.Location = new Point(6, 63);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(87, 29);
            rdoHamBurger.TabIndex = 1;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            rdoHamBurger.CheckedChanged += rdoHamBurger_CheckedChanged;
            // 
            // groupOption
            // 
            groupOption.Controls.Add(chkSauce);
            groupOption.Controls.Add(chkCheese);
            groupOption.Controls.Add(chkCola);
            groupOption.Controls.Add(chkPotato);
            groupOption.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            groupOption.ForeColor = Color.Red;
            groupOption.Location = new Point(265, 84);
            groupOption.Name = "groupOption";
            groupOption.Size = new Size(155, 250);
            groupOption.TabIndex = 10;
            groupOption.TabStop = false;
            groupOption.Text = "추가 옵션";
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkSauce.ForeColor = Color.Black;
            chkSauce.Location = new Point(21, 197);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(114, 29);
            chkSauce.TabIndex = 14;
            chkSauce.TabStop = false;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkCheese.ForeColor = Color.Black;
            chkCheese.Location = new Point(22, 154);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(114, 29);
            chkCheese.TabIndex = 13;
            chkCheese.TabStop = false;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkCola.ForeColor = Color.Black;
            chkCola.Location = new Point(22, 105);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(69, 29);
            chkCola.TabIndex = 12;
            chkCola.TabStop = false;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            chkPotato.ForeColor = Color.Black;
            chkPotato.Location = new Point(22, 55);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(107, 29);
            chkPotato.TabIndex = 11;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // grouplistTotal
            // 
            grouplistTotal.Controls.Add(lblTotalCost);
            grouplistTotal.Controls.Add(lstOrder);
            grouplistTotal.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            grouplistTotal.ForeColor = Color.Red;
            grouplistTotal.Location = new Point(449, 84);
            grouplistTotal.Name = "grouplistTotal";
            grouplistTotal.Size = new Size(267, 271);
            grouplistTotal.TabIndex = 4;
            grouplistTotal.TabStop = false;
            grouplistTotal.Text = "주문 내역";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Location = new Point(36, 227);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(144, 32);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "총 금액: 0원";
            // 
            // lstOrder
            // 
            lstOrder.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lstOrder.ForeColor = Color.Blue;
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(23, 34);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(221, 184);
            lstOrder.TabIndex = 0;
            lstOrder.TabStop = false;
            lstOrder.SelectedIndexChanged += lstOrder_SelectedIndexChanged;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Lime;
            btnOrder.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnOrder.ForeColor = Color.Black;
            btnOrder.Location = new Point(449, 382);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(130, 46);
            btnOrder.TabIndex = 15;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Red;
            btnReset.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(585, 382);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(131, 46);
            btnReset.TabIndex = 16;
            btnReset.Text = "초기화";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("맑은 고딕", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 129);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(497, 358);
            lblError.Name = "lblError";
            lblError.Size = new Size(186, 21);
            lblError.TabIndex = 5;
            lblError.Text = "선택된 메뉴가 없습니다.";
            lblError.Visible = false;
            // 
            // Form1
            // 
            AcceptButton = btnOrder;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 450);
            Controls.Add(lblError);
            Controls.Add(btnReset);
            Controls.Add(btnOrder);
            Controls.Add(grouplistTotal);
            Controls.Add(groupOption);
            Controls.Add(groupMenu);
            Controls.Add(lblMain);
            Name = "Form1";
            Text = "Burger Kiosk v1.0";
            Load += Form1_Load;
            groupMenu.ResumeLayout(false);
            groupMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picChicken).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBulGogi).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHamBurger).EndInit();
            groupOption.ResumeLayout(false);
            groupOption.PerformLayout();
            grouplistTotal.ResumeLayout(false);
            grouplistTotal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMain;
        private GroupBox groupMenu;
        private GroupBox groupOption;
        private GroupBox grouplistTotal;
        private RadioButton rdoChickenBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoHamBurger;
        private PictureBox picChicken;
        private PictureBox picBulGogi;
        private PictureBox picHamBurger;
        private CheckBox chkSauce;
        private CheckBox chkCheese;
        private CheckBox chkCola;
        private Label lblTotalCost;
        private ListBox lstOrder;
        private Button btnOrder;
        private Button btnReset;
        private CheckBox chkPotato;
        private Label lblError;
    }
}
