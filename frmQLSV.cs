using System;
using System.Windows.Forms;

namespace lab02_2
{
    public partial class frmQLSV : Form
    {
        public frmQLSV()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Mặc định
            if (cmbFaculty.Items.Count > 0)
                cmbFaculty.SelectedIndex = 0;

            optFemale.Checked = true;

            lblMaleCount.Text = "0";
            lblFemaleCount.Text = "0";

            // --- Thêm dữ liệu test 10 sinh viên ---
            dgvStudent.Rows.Add("SV001", "Nguyễn Văn A", "Nam", 7.5, "CNTT");
            dgvStudent.Rows.Add("SV002", "Trần Thị B", "Nữ", 8.2, "QTKD");
            dgvStudent.Rows.Add("SV003", "Lê Văn C", "Nam", 6.8, "NNA");
            dgvStudent.Rows.Add("SV004", "Phạm Thị D", "Nữ", 9.0, "CNTT");
            dgvStudent.Rows.Add("SV005", "Hoàng Văn E", "Nam", 5.9, "CK");
            dgvStudent.Rows.Add("SV006", "Vũ Thị F", "Nữ", 8.0, "QTKD");
            dgvStudent.Rows.Add("SV007", "Đỗ Văn G", "Nam", 7.2, "CNTT");
            dgvStudent.Rows.Add("SV008", "Phan Thị H", "Nữ", 9.3, "NNA");
            dgvStudent.Rows.Add("SV009", "Trịnh Văn K", "Nam", 6.5, "CK");
            dgvStudent.Rows.Add("SV010", "Hoàng Thị M", "Nữ", 8.7, "CNTT");

            // Cập nhật lại số lượng nam – nữ
            UpdateGenderCount();
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string key = txtSearch.Text.ToLower();

            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                bool visible =
                    row.Cells["colStudentID"].Value.ToString().ToLower().Contains(key) ||
                    row.Cells["colFullName"].Value.ToString().ToLower().Contains(key);

                row.Visible = visible;
            }
        }

        private int GetSelectedRow(string studentID)
        {
            if (string.IsNullOrWhiteSpace(studentID))
                return -1;

            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                var cellVal = dgvStudent.Rows[i].Cells[0].Value;
                if (cellVal != null && cellVal.ToString().Trim() == studentID.Trim())
                    return i;
            }
            return -1;
        }

        private void InsertUpdate(int selectedRow)
        {
            // Nếu selectedRow == dgvStudent.Rows.Count thì thêm mới; nếu < count thì cập nhật
            if (selectedRow < 0)
                return;

            // Nếu là thêm mới (selectedRow == current rows count) -> add row
            if (selectedRow >= dgvStudent.Rows.Count)
            {
                dgvStudent.Rows.Add(
                    txtStudentID.Text.Trim(),
                    txtFullName.Text.Trim(),
                    optFemale.Checked ? "Nữ" : "Nam",
                    float.Parse(txtAverageScore.Text).ToString(),
                    cmbFaculty.Text
                );
            }
            else
            {
                dgvStudent.Rows[selectedRow].Cells[0].Value = txtStudentID.Text.Trim();
                dgvStudent.Rows[selectedRow].Cells[1].Value = txtFullName.Text.Trim();
                dgvStudent.Rows[selectedRow].Cells[2].Value = optFemale.Checked ? "Nữ" : "Nam";
                dgvStudent.Rows[selectedRow].Cells[3].Value = float.Parse(txtAverageScore.Text).ToString();
                dgvStudent.Rows[selectedRow].Cells[4].Value = cmbFaculty.Text;
            }
        }

        private void UpdateGenderCount()
        {
            int male = 0;
            int female = 0;

            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                if (row.IsNewRow) continue;
                var cell = row.Cells[2].Value;
                if (cell == null) continue;
                string gender = cell.ToString().Trim();
                if (gender == "Nam") male++;
                else if (gender == "Nữ") female++;
            }

            lblMaleCount.Text = male.ToString();
            lblFemaleCount.Text = female.ToString();
        }

        private void ClearInput()
        {
            txtStudentID.Clear();
            txtFullName.Clear();
            txtAverageScore.Clear();
            if (cmbFaculty.Items.Count > 0) cmbFaculty.SelectedIndex = 0;
            optFemale.Checked = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra bắt buộc
                if (string.IsNullOrWhiteSpace(txtStudentID.Text) ||
                    string.IsNullOrWhiteSpace(txtFullName.Text) ||
                    string.IsNullOrWhiteSpace(txtAverageScore.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }

                // Kiểm tra điểm trung bình hợp lệ
                if (!float.TryParse(txtAverageScore.Text.Trim(), out float score))
                {
                    MessageBox.Show("Điểm trung bình phải là số!");
                    return;
                }

                // Optional: kiểm tra khoảng điểm (0-10)
                if (score < 0 || score > 10)
                {
                    MessageBox.Show("Điểm trung bình phải nằm trong khoảng 0 - 10.");
                    return;
                }

                int index = GetSelectedRow(txtStudentID.Text.Trim());

                if (index == -1)
                {
                    // Thêm mới
                    dgvStudent.Rows.Add(
                        txtStudentID.Text.Trim(),
                        txtFullName.Text.Trim(),
                        optFemale.Checked ? "Nữ" : "Nam",
                        score.ToString(),
                        cmbFaculty.Text
                    );
                    MessageBox.Show("Thêm mới dữ liệu thành công!");
                }
                else
                {
                    // Cập nhật
                    InsertUpdate(index);
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                }

                UpdateGenderCount();
                // Nếu muốn xóa input sau khi thêm, bỏ comment dòng dưới:
                // ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtStudentID.Text.Trim();
                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("Vui lòng nhập MSSV cần xóa vào ô Mã SV!");
                    return;
                }

                int index = GetSelectedRow(id);
                if (index == -1)
                {
                    MessageBox.Show("Không tìm thấy MSSV cần xóa!");
                    return;
                }

                var confirm = MessageBox.Show("Xác nhận xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    dgvStudent.Rows.RemoveAt(index);
                    MessageBox.Show("Xóa sinh viên thành công!");
                    UpdateGenderCount();
                    // Có thể ClearInput nếu muốn:
                    // ClearInput();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
       
        private void cmbFilterFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        void ApplyFilters()
        {
            string keyword = txtSearch.Text.ToLower();
            string filterFaculty = cmbFilterFaculty.SelectedItem?.ToString() ?? "Tất cả";

            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                bool matchKeyword =
                    row.Cells["colStudentID"].Value.ToString().ToLower().Contains(keyword) ||
                    row.Cells["colFullName"].Value.ToString().ToLower().Contains(keyword);

                bool matchFaculty =
                    filterFaculty == "Tất cả" ||
                    row.Cells["colFaculty"].Value.ToString() == filterFaculty;

                row.Visible = matchKeyword && matchFaculty;
            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.RowIndex >= dgvStudent.Rows.Count) return;

                DataGridViewRow row = dgvStudent.Rows[e.RowIndex];

                var idCell = row.Cells[0].Value;
                var nameCell = row.Cells[1].Value;
                var genderCell = row.Cells[2].Value;
                var scoreCell = row.Cells[3].Value;
                var facultyCell = row.Cells[4].Value;

                txtStudentID.Text = idCell != null ? idCell.ToString() : "";
                txtFullName.Text = nameCell != null ? nameCell.ToString() : "";
                txtAverageScore.Text = scoreCell != null ? scoreCell.ToString() : "";
                cmbFaculty.Text = facultyCell != null ? facultyCell.ToString() : "";

                string gender = genderCell != null ? genderCell.ToString() : "";
                optFemale.Checked = gender == "Nữ";
                optMale.Checked = gender == "Nam";
            }
            catch
            {
                // im lặng để không làm phiền user
            }
        }

        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
