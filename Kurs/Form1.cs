using System.Linq.Expressions;

namespace Kurs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ToolTip a = new ToolTip();
            a.SetToolTip(button4, "����� ���������� ��� ���������.");
            ToolTip b = new ToolTip();
            b.SetToolTip(button2, "��������� ������� ���������� �������.");
            ToolTip c = new ToolTip();
            c.SetToolTip(button3, "������� ������� �� ������ ���������� ������.");
            ToolTip d = new ToolTip();
            d.SetToolTip(button1, "�������� �������.");
            ToolTip e = new ToolTip();
            e.SetToolTip(button5, "�������� ������ � ������� ����� ������.");
            ToolTip f = new ToolTip();
            f.SetToolTip(button6, "�������� ������� � ������� ����� ������. (� � ������� ������������)");
        }
        int[,] data = new int[100, 100];
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    Random random = new Random();
                    data[i, j] = random.Next(-100, 100);
                    dataGridView1.Rows[i].Cells[j].Value = data[i, j].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount + 1; j++)
                {
                    data[i, j] = 0;
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Columns.Clear();
            dataGridView2.RowCount = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    try { if (Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value) != 0) data[i, j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value.ToString()); }
                    catch { MessageBox.Show("������� ����� �����!"); }
                }
            }
            //����������� ��������
            if (radioButton1.Checked)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    int min = int.MaxValue;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        if (data[i, j] < min)
                        {
                            min = data[i, j];
                            data[i, dataGridView1.ColumnCount + 1] = min;
                        }
                    }
                }
                int max = int.MinValue;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (data[i, dataGridView1.ColumnCount + 1] > max) max = data[i, dataGridView1.ColumnCount + 1];
                }
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    bool isWrong = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        if (data[i, j] == max)
                        {
                            for (int k = 0; k < dataGridView1.Columns.Count; k++)
                            {
                                if (data[i, k] < max)
                                {
                                    isWrong = true;
                                    break;
                                }
                            }
                            if (isWrong == false)
                            {
                                textBox1.Text += (i + 1).ToString() + " ";
                                break;
                            }
                        }

                    }
                }
            }
            //����������� ��������
            if (radioButton2.Checked)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    int max = int.MinValue;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        if (data[i, j] > max)
                        {
                            max = data[i, j];
                            data[i, dataGridView1.ColumnCount + 1] = max;
                        }
                    }
                }
                int min = int.MaxValue;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (data[i, dataGridView1.ColumnCount + 1] < min) min = data[i, dataGridView1.ColumnCount + 1];
                }
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    bool isWrong = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        if (data[i, j] == min)
                        {
                            for (int k = 0; k < dataGridView1.Columns.Count; k++)
                            {
                                if (data[i, k] > min)
                                {
                                    isWrong = true;
                                    break;
                                }
                            }
                            if (isWrong == false)
                            {
                                textBox1.Text += (i + 1).ToString() + " ";
                                break;
                            }
                        }

                    }
                }
            }
            //������
            if (radioButton3.Checked)
            {
                int[] temp = new int[dataGridView1.ColumnCount];
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    int max = int.MinValue;
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        if (data[j, i] > max) max = data[j, i];
                    }
                    temp[i] = max;
                }
                int[,] risk = new int[dataGridView1.RowCount, dataGridView1.ColumnCount + 1];
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    for (int j = 0; j < dataGridView1.RowCount; j++)
                    {
                        risk[j, i] = temp[i] - data[j, i];
                    }
                }


                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    int max = int.MinValue;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        if (risk[i, j] > max)
                        {
                            max = risk[i, j];
                            risk[i, dataGridView1.ColumnCount] = max;
                        }
                    }
                }
                int min = int.MaxValue;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (risk[i, dataGridView1.ColumnCount] < min) min = risk[i, dataGridView1.ColumnCount];
                }
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    bool isWrong = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        if (risk[i, j] == min)
                        {
                            for (int k = 0; k < dataGridView1.Columns.Count; k++)
                            {
                                if (risk[i, k] > min)
                                {
                                    isWrong = true;
                                    break;
                                }
                            }
                            if (isWrong == false)
                            {
                                textBox1.Text += (i + 1).ToString() + " ";
                                break;
                            }
                        }

                    }
                }
            }
            //�������� ���������
            if (radioButton4.Checked)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    int max = int.MinValue;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        if (data[i, j] > max)
                        {
                            max = data[i, j];
                            data[i, dataGridView1.ColumnCount + 1] = max;
                        }
                    }
                }
                int max2 = int.MinValue;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (data[i, dataGridView1.ColumnCount + 1] > max2) max2 = data[i, dataGridView1.ColumnCount + 1];
                }
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    bool isWrong = false;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        if (data[i, j] == max2)
                        {
                            for (int k = 0; k < dataGridView1.Columns.Count; k++)
                            {
                                if (data[i, k] > max2)
                                {
                                    isWrong = true;
                                    break;
                                }
                            }
                            if (isWrong == false)
                            {
                                textBox1.Text += (i + 1).ToString() + " ";
                                break;
                            }
                        }

                    }
                }
            }
            //�������� �������
            if (radioButton5.Checked)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    int MatV = 0;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        MatV += data[i, j];
                    }
                    data[i, dataGridView1.ColumnCount + 1] = MatV / dataGridView1.ColumnCount;
                }
                int max2 = int.MinValue;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (data[i, dataGridView1.ColumnCount + 1] > max2) max2 = data[i, dataGridView1.ColumnCount + 1];
                }
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    int MatV2 = 0;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        MatV2 += data[i, j];
                    }
                    if (MatV2 / dataGridView1.ColumnCount == max2) textBox1.Text += (i + 1).ToString() + " ";
                }
            }
            //�������� �������
            if (radioButton6.Checked)
            {
                double[] Temp = new double[dataGridView1.RowCount];
                double Lambd = Convert.ToDouble(textBox2.Text);
                if (Lambd > 1 || Lambd < 0)
                {
                    MessageBox.Show("������ ������ ���� �� ������ 1 � �� ������ 0!");
                }
                else
                {
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        int max = int.MinValue;
                        int min = int.MaxValue;
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            if (data[i, j] > max) max = data[i, j];
                            if (data[i, j] < min) min = data[i, j];
                        }
                        Temp[i] = Lambd * min + (1 - Lambd) * max;
                    }
                    double max2 = int.MinValue;
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if (Temp[i] > max2) max2 = Temp[i];
                    }
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        int max = int.MinValue;
                        int min = int.MaxValue;
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            if (data[i, j] > max) max = data[i, j];
                            if (data[i, j] < min) min = data[i, j];
                        }
                        if ((Lambd * min + (1 - Lambd) * max) == max2) textBox1.Text += (i + 1).ToString() + " ";
                    }
                }
            }

            //�������� ��������
            if (radioButton8.Checked)
            {
                double GeneralProb = 0;
                double[] probs = new double[dataGridView1.ColumnCount];
                for (int i = 0; i < probs.Length; i++)
                {
                    try
                    {
                        probs[i] = Convert.ToDouble(dataGridView2.Rows[0].Cells[i].Value.ToString());
                        GeneralProb += probs[i];
                    }
                    catch { MessageBox.Show("������� �������� �����������"); }
                }

                if (GeneralProb > 1 || GeneralProb < 0.99)
                {
                    MessageBox.Show("����� ������������ ������ ���� ����� �������!");
                }
                else
                {

                    double[] Temp = new double[dataGridView1.RowCount];
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        double min = int.MaxValue;
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            if (data[i, j] * probs[j] < min) min = data[i, j] * probs[j];
                            Temp[i] = min;
                        }
                    }

                    double max = int.MinValue;
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if (Temp[i] > max) max = Temp[i];
                    }
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        bool isWrong = false;
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            if (data[i, j] * probs[j] == max)
                            {
                                for (int k = 0; k < dataGridView1.Columns.Count; k++)
                                {
                                    if (data[i, k] * probs[k] < max)
                                    {
                                        isWrong = true;
                                        break;
                                    }
                                }
                                if (isWrong == false)
                                {
                                    textBox1.Text += (i + 1).ToString() + " ";
                                    break;
                                }
                            }

                        }
                    }
                }
            }
            //�������� ������������
            if (radioButton9.Checked)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    int Proizv = 1;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        Proizv *= data[i, j];
                    }
                    data[i, dataGridView1.ColumnCount + 1] = Proizv;
                }
                int max2 = int.MinValue;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (data[i, dataGridView1.ColumnCount + 1] > max2) max2 = data[i, dataGridView1.ColumnCount + 1];
                }
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    int Proizv2 = 1;
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        Proizv2 *= data[i, j];
                    }
                    if (Proizv2 == max2) textBox1.Text += (i + 1).ToString() + " ";
                }
            }

        }
        //���������� ������
        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }
        //���������� ��������
        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add(" ", " ");
            if (radioButton8.Checked) dataGridView2.ColumnCount = dataGridView1.ColumnCount;
        }
        //����������
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�������� ����������� ���������� �������� � �����, ��������� ��������� �������." +
                "\n�������� ������ �������� ��� �������� ������� � ������� ������ ������� �������." +
                "\n(���� ��������� ���� ��� �����, ��������� � ��)", "����� ����������");
        }
        //����� ����� ��� �������
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                label4.Visible = true;
                textBox2.Visible = true;
            }
            else
            {
                label4.Visible = false;
                textBox2.Visible = false;
            }
        }
        //����� ����� ��� ��������
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                dataGridView2.Visible = true;
                dataGridView2.ColumnCount = dataGridView1.ColumnCount;
                dataGridView2.RowCount = 1;
            }
            else
            {
                dataGridView2.Visible = false;
            }
        }
        //������ ���� ������
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || (int)e.KeyChar == 8 || e.KeyChar == 45 || e.KeyChar == 44) || e.KeyChar == '-') e.KeyChar = (char)0;
            if (e.KeyChar == 44 && textBox2.Text.Contains(",")) e.KeyChar = (char)0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
