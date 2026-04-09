namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // 새로운 주문을 누를 때마다 이전 내역을 지우고 총액을 0으로 초기화
            lstOrder.Items.Clear();
            int totalCost = 0;

            // --- 라디오버튼(단일 선택) 검사 ---
            if (rbnHam1.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }
            else if (rbnHam2.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
            }
            else if (rbnHam3.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }

            // --- 체크박스(다중 선택) 검사 ---
            if (chkFries.Checked)
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
                lstOrder.Items.Add("치즈 추가 1,500원");
            }
            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 추가 500원");
            }

            // --- 총 금액 출력 ---
            lblTotalCost.Text = "총 금액: " + totalCost + "원";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 라디오버튼 체크 해제
            rbnHam1.Checked = false;
            rbnHam2.Checked = false;
            rbnHam3.Checked = false;

            // 체크박스 옵션 체크 해제
            chkFries.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            // 출력 정보(리스트박스, 라벨) 초기화
            lstOrder.Items.Clear();
            lblTotalCost.Text = "총 금액: 0원";
        }
    }
}
