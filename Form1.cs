using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = lblMain;
        }

       
        private void UpdateOrder()
        {
            lstOrder.Items.Clear();
            int totalCost = 0;

            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }

            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }
            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 1,500원");
            }
            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 500원");
            }

            lblTotalCost.Text = $"총 금액: {totalCost:N0}원";
        }

        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            bool isSelected = false;

            foreach (Control control in groupMenu.Controls)
            {
                if (control is System.Windows.Forms.RadioButton rb && rb.Checked)
                {
                    isSelected = true;
                    break;
                }
            }

            if (isSelected)
            {
                lblError.Visible = false;
            }
            else
            {
                lblError.Visible = true;
                return;
            }

            // 주문 확정 시 메시지 표시
            lblError.ForeColor = Color.Blue;
            lblError.Text = "주문이 확정되었습니다!";
            lblError.Visible = true;
            
            groupMenu.Focus();
            rdoHamBurger.TabStop = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;
            lstOrder.Items.Clear();
            lblTotalCost.Text = "총 금액: 0원";
            lblError.Visible = false;

            lblError.ForeColor = Color.Red;
            lblError.Text = "선택된 메뉴가 없습니다.";
            lblError.Visible = false;

            rdoHamBurger.TabStop = true;
        }

        private void rdoHamBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHamBurger.Checked)
                lblError.Visible = false;
            UpdateOrder();
        }

        private void rdoBulgogiBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBulgogiBurger.Checked)
                lblError.Visible = false;
            UpdateOrder();
        }

        private void rdoChickenBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoChickenBurger.Checked)
                lblError.Visible = false;
            UpdateOrder();
        }

        private void chkOption_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrder();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMain.Focus();
        }
    }
}
