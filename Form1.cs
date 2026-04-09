namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;

            // [과제2] 에러 메시지 라벨 초기 세팅
            lblError.Text = "메뉴를 선택하세요.";
            lblError.ForeColor = Color.Red;
            lblError.Visible = false;

            // [과제3] Enter 키를 누르면 '주문하기' 버튼이 무조건 실행되도록 설정
            this.AcceptButton = btnOrder;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // [과제2] 실행 직후 어떤 라디오 버튼도 선택되지 않은 상태로 초기화
            rbnHam1.Checked = false;
            rbnHam2.Checked = false;
            rbnHam3.Checked = false;

            // [과제3] 키보드 Tab 키 이동 순서(TabIndex) 강제 설정
            grbMenu.TabIndex = 0;
            grbSide.TabIndex = 1;
            grbOrder.TabIndex = 2;
            btnOrder.TabIndex = 3;
            btnClear.TabIndex = 4;

            // ---------------------------------------------------
            // [과제4 추가] 상태가 변할 때마다 즉시 갱신하기 위한 이벤트 연결
            // ---------------------------------------------------
            // 모든 항목의 Checked 상태가 변할 때 Item_CheckedChanged 이벤트를 실행합니다.
            rbnHam1.CheckedChanged += Item_CheckedChanged;
            rbnHam2.CheckedChanged += Item_CheckedChanged;
            rbnHam3.CheckedChanged += Item_CheckedChanged;

            chkFries.CheckedChanged += Item_CheckedChanged;
            chkCola.CheckedChanged += Item_CheckedChanged;
            chkCheese.CheckedChanged += Item_CheckedChanged;
            chkSauce.CheckedChanged += Item_CheckedChanged;

            // 포커스가 라디오 버튼에 가서 자동으로 체크되는 것을 방지
            this.ActiveControl = lblTotalCost;
        }

        // ---------------------------------------------------
        // [과제4 추가] 항목 선택/해제 시 즉시 실행되는 이벤트 핸들러
        // ---------------------------------------------------
        private void Item_CheckedChanged(object sender, EventArgs e)
        {
            // 항목이 체크되거나 해제될 때마다 계산 및 UI 갱신 로직을 호출합니다.
            UpdateOrder();
        }

        // ---------------------------------------------------
        // [핵심] 주문 내역 갱신 및 총 금액 계산 메서드 (분리)
        // ---------------------------------------------------
        private void UpdateOrder()
        {
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

            // 메인 메뉴가 하나라도 선택되었다면 에러 메시지 숨김
            if (rbnHam1.Checked || rbnHam2.Checked || rbnHam3.Checked)
            {
                lblError.Visible = false;
            }
        }

        // ---------------------------------------------------
        // 1. 주문하기 버튼 클릭 이벤트
        // ---------------------------------------------------
        private void btnOrder_Click(object sender, EventArgs e)
        {
            // 아무 메뉴도 선택하지 않았을 경우 에러 라벨 표시 및 중단
            if (!rbnHam1.Checked && !rbnHam2.Checked && !rbnHam3.Checked)
            {
                lblError.Visible = true;
                return;
            }

            lblError.Visible = false;

            // 과제4에서는 선택 즉시 정보가 갱신되므로, 
            // 주문하기 버튼을 누르면 계산을 다시 하는 대신 완료 메시지를 띄우는 용도로 활용할 수 있습니다.
            MessageBox.Show("주문이 성공적으로 완료되었습니다!", "주문 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ---------------------------------------------------
        // 2. 초기화 버튼 클릭 이벤트
        // ---------------------------------------------------
        private void btnClear_Click(object sender, EventArgs e)
        {
            // 체크 해제 로직 (이 코드가 실행되면 CheckedChanged 이벤트가 발생하여 자동으로 화면이 비워집니다)
            rbnHam1.Checked = false;
            rbnHam2.Checked = false;
            rbnHam3.Checked = false;

            chkFries.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            // 라벨 및 에러 초기화 
            lblError.Visible = false;

            this.ActiveControl = lblTotalCost;
        }

        // 디자이너 더블클릭 자동 생성 방지용 (그대로 두시면 됩니다)
        private void grbMenu_Enter(object sender, EventArgs e) { }
        private void grbSide_Enter(object sender, EventArgs e) { }
        private void grbOrder_Enter(object sender, EventArgs e) { }
    }
}