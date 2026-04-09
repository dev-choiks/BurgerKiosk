namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;

            lblError.Text = "메뉴를 선택하세요.";
            lblError.ForeColor = Color.Red;
            lblError.Visible = false;

            // 기존의 this.AcceptButton = btnOrder; 코드는 Enter키로 버튼이 눌리는 것을 방지하기 위해 삭제했습니다.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 실행 직후 어떤 라디오 버튼도 선택되지 않은 상태로 만듭니다.
            rbnHam1.Checked = false;
            rbnHam2.Checked = false;
            rbnHam3.Checked = false;

            // ---------------------------------------------------
            // [과제3] 키보드 Tab 키 이동 순서(TabIndex) 강제 설정
            // ---------------------------------------------------
            grbMenu.TabIndex = 0;
            grbSide.TabIndex = 1;
            grbOrder.TabIndex = 2;
            btnOrder.TabIndex = 3;
            btnClear.TabIndex = 4;

            // ---------------------------------------------------
            // [추가] Enter 키로 메뉴를 선택/해제하기 위한 이벤트 일괄 연결
            // ---------------------------------------------------
            rbnHam1.KeyDown += CustomItem_KeyDown;
            rbnHam2.KeyDown += CustomItem_KeyDown;
            rbnHam3.KeyDown += CustomItem_KeyDown;

            chkFries.KeyDown += CustomItem_KeyDown;
            chkCola.KeyDown += CustomItem_KeyDown;
            chkCheese.KeyDown += CustomItem_KeyDown;
            chkSauce.KeyDown += CustomItem_KeyDown;

            // 포커스가 라디오 버튼에 가서 자동으로 체크되는 것을 방지합니다.
            this.ActiveControl = lblTotalCost;
        }

        // ---------------------------------------------------
        // [핵심] Enter 키를 눌렀을 때 선택/해제 상태를 반전시키는 커스텀 이벤트
        // ---------------------------------------------------
        private void CustomItem_KeyDown(object sender, KeyEventArgs e)
        {
            // 누른 키가 Enter 키라면
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 윈도우 기본 삑 소리 방지

                if (sender is CheckBox chk)
                {
                    chk.Checked = !chk.Checked; // 체크박스 상태 반전
                }
                else if (sender is RadioButton rdo)
                {
                    rdo.Checked = !rdo.Checked; // 라디오버튼 상태 반전
                }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // 아무 메뉴도 선택하지 않았을 경우 에러 라벨 표시 및 중단
            if (!rbnHam1.Checked && !rbnHam2.Checked && !rbnHam3.Checked)
            {
                lblError.Visible = true;
                return;
            }

            // 정상적으로 메뉴를 선택했다면 에러 메시지 숨기기
            lblError.Visible = false;

            // 이전 내역 초기화
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
            lblTotalCost.Text = $"총 금액: {totalCost:N0}원";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 모든 선택 상태 초기화
            rbnHam1.Checked = false;
            rbnHam2.Checked = false;
            rbnHam3.Checked = false;

            chkFries.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            lstOrder.Items.Clear();
            lblTotalCost.Text = "총 금액: 0원";
            lblError.Visible = false;

            // 초기화 후에도 키보드 조작이 꼬이지 않도록 포커스 제거
            this.ActiveControl = lblTotalCost;
        }

        // 디자인 창에서 더블클릭으로 생성된 이벤트
        private void grbMenu_Enter(object sender, EventArgs e) { }
        private void grbSide_Enter(object sender, EventArgs e) { }
        private void grbOrder_Enter(object sender, EventArgs e) { }
    }
}