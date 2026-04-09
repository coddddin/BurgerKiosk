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



        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int totalCost = 0;

            bool isSelected = false;

            // 1. 그룹박스 내의 라디오 버튼들 중 하나라도 체크되었는지 확인
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
                lstOrder.Items.Add("콜라  2,500원");
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
            string totalCostText = $"총 금액: {totalCost:N0}원";
            lblTotalCost.Text = totalCostText;

            groupMenu.Focus(); // 그룹박스에 포커스 설정하여 라디오 버튼이 선택된 상태로 유지되도록 함
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

            rdoHamBurger.TabStop = true;
        }

        private void rdoHamBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHamBurger.Checked)
            {
                lblError.Visible = false;
            }
        }

        private void rdoBulgogiBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBulgogiBurger.Checked)
            {
                lblError.Visible = false;
            }
        }

        private void rdoChickenBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoChickenBurger.Checked)
            {
                lblError.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMain.Focus(); // 폼이 로드될 때 lblMain에 포커스 설정
        }
    }
}
