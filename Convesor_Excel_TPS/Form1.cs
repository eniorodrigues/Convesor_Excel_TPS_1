using Microsoft.Win32;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convesor_Excel_TPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Conexoes conexoesBases = new Conexoes();
        SqlConnection conn;
        Stream myStream = null;
        public static string path;
        public static string excelConnectionString;
        public string[] files;
        public string conexao;
        public string baseDeDados;
        public string tabela;
        public string caminho;
        public string directoryPath;
        public List<string> filesAdionado = new List<string>();
        public List<string> colunas = new List<string>();
        public List<string> colunasCreate = new List<string>();
        public string tipoArquivo;
        StringBuilder camposDataGrid = new StringBuilder();
        public List<String> itemsDataGrid = new List<String>();
        public SqlConnection conn1 = null;
        public bool checado;
        String databaseName;
        bool cmbSelecionado = false;
        public ExcelWorksheet planilhaSelecionada;
        public ExcelWorkbook arquivoSelecionado;
        bool criouTabelaNova = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
        }

        private void comboBoxServidor_Enter(object sender, EventArgs e)
        {
            comboBoxServidor.Items.Clear();
      
            string myServer = Environment.MachineName;

            comboBoxServidor.Items.Add(myServer);
            string ServerName = Environment.MachineName;

            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
           
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        comboBoxServidor.Items.Add(ServerName + "\\" + instanceName);
                    }
                }
            }
        }

        private void comboBoxServidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxBase.Items.Clear();
            try
            {
                List<string> coisa = conexoesBases.Conectar(comboBoxServidor.Text);
                comboBoxBase.Items.AddRange(coisa.ToArray<object>());
                comboBoxBase.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            string baseDeDados = comboBoxBase.Text;
            string conexao = comboBoxServidor.Text;

            conn = new SqlConnection("Data Source=" + conexao + "; Integrated Security=True; Initial Catalog=" + baseDeDados);
             
            if (chbNova.Checked == true)
            {
                comboBoxTabela.Enabled = false;
            }
            else
            {
                comboBoxTabela.Enabled = true;
            }
        }

        private void cmbTabela_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRepetido.Text = "0";
            lblPendencia.Text = "0";
            lblCarregada.Text = "0";
            buttonAbrir.Enabled = true;
         
            BindingSource bindingSource1 = new BindingSource();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            Button reloadButton = new Button();
            Button submitButton = new Button();

            DataTable dataTable = new DataTable();

            conn.Open();

            string comando = "select COLUMN_NAME as Coluna, '' as Excel from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME ='" + comboBoxTabela.SelectedItem + "'";

            DataTable table = new DataTable
            {
                Locale = CultureInfo.InvariantCulture
            };

            dataAdapter = new SqlDataAdapter(comando, conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            dataAdapter.Fill(table);
            bindingSource1.DataSource = table;

            dataGridSQL.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

            dataGridSQL.DataSource = bindingSource1;
            conn.Close();

        }

    private void chbNova_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbNova.Checked)
            {
                ((Control)this.tabNova).Enabled = true;
                ((Control)this.tabTP).Enabled = false;
                comboBoxTabela.Enabled = false;
                btnCarregar.Enabled = true;
                cmbPlanilha.Enabled = true;
                buttonAbrir.Enabled = true;
                txtCriar.Enabled = true;
                tab.SelectedIndex = 1;
            }
            else
            {
                ((Control)this.tabNova).Enabled = false;
                ((Control)this.tabTP).Enabled = true;
                comboBoxTabela.Enabled = true;
                btnCarregar.Enabled = false;
                cmbPlanilha.Enabled = false;
                btnCriar.Enabled = false;
                txtCriar.Enabled = false;
                tab.SelectedIndex = 0;
            }
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {

            if (chbNova.Checked == false)
            {

                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.Multiselect = true;
                cmbPlanilha.Text = "";
                lblTotal.Text = "0";
                lblCarregada.Text = "0";
                lblPendencia.Text = "0";
                lblRepetido.Text = "0";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if ((myStream = openFileDialog1.OpenFile()) != null)
                        {
                            using (myStream)
                            {
                                caminho = openFileDialog1.FileName;
                                directoryPath = Path.GetDirectoryName(openFileDialog1.FileName);
                                files = (openFileDialog1.SafeFileNames);
                                carregaColunas();
                            }
                        }
                        cmbPlanilha.Enabled = true;
                        label1.Text = openFileDialog1.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro no carregamento do arquivo " + ex.Message);
                    }
                }
            }
            else
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.Multiselect = true;
                cmbPlanilha.Text = "";
                lblTotal.Text = "0";
                lblCarregada.Text = "0";
                lblPendencia.Text = "0";
                lblRepetido.Text = "0";


                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if ((myStream = openFileDialog1.OpenFile()) != null)
                        {
                            using (myStream)
                            {
                                caminho = openFileDialog1.FileName;
                                directoryPath = Path.GetDirectoryName(openFileDialog1.FileName);
                                files = (openFileDialog1.SafeFileNames);
                              //  carregaNomeArquivo();
                            }
                        }
                        cmbPlanilha.Enabled = true;
                        label1.Text = openFileDialog1.FileName;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro no carregamento do arquivo " + ex.Message);
                    }
                }

                ltbArquivosNova.Items.AddRange(files);
            }
        }

        private void cmbPlanilha_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCarregar.Enabled = true;
            string filePath = caminho;
            FileInfo existingFile = new FileInfo(filePath);
            ExcelPackage package = new ExcelPackage(existingFile);
            ExcelWorksheet workSheet = package.Workbook.Worksheets[cmbPlanilha.SelectedIndex];
            lblTotal.Text = (workSheet.Dimension.End.Row - 1).ToString();
            lblTotal.Refresh();

            progressBar1.Maximum = (workSheet.Dimension.End.Row);
            planilhaSelecionada = workSheet;

            List<string> campos = new List<string>();

            for (int i = 1; i <= planilhaSelecionada.Dimension.End.Row; i++)
            {
                var row = planilhaSelecionada.Cells[1, i];
                foreach (var cell in row)
                {
                    campos.Add(cell.Text);
                }
            }
            dataGridExcel.DataSource = campos.Select(x => new { Value = x }).ToList();
            dataGridExcel.Show();
        }

        public void carregaColunas()
        {
            try
            {
                colunas.Clear();
                colunasCreate.Clear();
                ltbColunas.Items.Clear();
                lblEndereço.Text = caminho;
                ExcelPackage package = new ExcelPackage(caminho);
                try
                {
                    cmbPlanilha.Items.Clear();
                    for (int i = 0; i < package.Workbook.Worksheets.Count; i++)
                    {
                        cmbPlanilha.Items.Add(package.Workbook.Worksheets[i].Name);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro no carregaNomeArquivo " + ex.Message);
                }

                if(chbNova.Checked == true)
                {
                    try
                    {
                        cmbPlanilha.Items.Clear();

                        for (int i = 0; i < package.Workbook.Worksheets.Count; i++)
                        {
                            cmbPlanilha.Items.Add(package.Workbook.Worksheets[i].Name);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro no carregaNomeArquivo " + ex.Message);
                    }


                    for (int k = 1; k <= planilhaSelecionada.Dimension.End.Column; k++)
                    {
                        if (Convert.ToString((planilhaSelecionada.Cells[1, k].Value)) != null && Convert.ToString(planilhaSelecionada.Cells[1, k].Value.ToString()) != "")
                        {
                            string coluna = Convert.ToString(planilhaSelecionada.Cells[1, k].Value);
                            colunas.Add(coluna);
                            colunasCreate.Add(coluna.Trim());
                            ltbColunas.Items.Add(coluna.Trim());
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no carregacolunas " + ex.Message);
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
 
        }
        private Rectangle dragBoxFromMouseDown;
        private object valueFromMouseDown;

        private void dataGridSQL_DragDrop(object sender, DragEventArgs e)
        {
            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = dataGridSQL.PointToClient(new Point(e.X, e.Y));

            // If the drag operation was a copy then add the row to the other control.
            if (e.Effect == DragDropEffects.Copy)
            {
                string cellvalue = e.Data.GetData(typeof(string)) as string;
                var hittest = dataGridSQL.HitTest(clientPoint.X, clientPoint.Y);
                if (hittest.ColumnIndex != -1
                    && hittest.RowIndex != -1)
                    dataGridSQL[hittest.ColumnIndex, hittest.RowIndex].Value = cellvalue;

            }
      
        }

        private void dataGridSQL_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void dataGridExcel_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            var hittestInfo = dataGridExcel.HitTest(e.X, e.Y);

            if (hittestInfo.RowIndex != -1 && hittestInfo.ColumnIndex != -1)
            {
                valueFromMouseDown = dataGridExcel.Rows[hittestInfo.RowIndex].Cells[hittestInfo.ColumnIndex].Value;
                if (valueFromMouseDown != null)
                {
                    // Remember the point where the mouse down occurred. 
                    // The DragSize indicates the size that the mouse can move 
                    // before a drag event should be started.                
                    Size dragSize = SystemInformation.DragSize;

                    // Create a rectangle using the DragSize, with the mouse position being
                    // at the center of the rectangle.
                    dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
                }
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void dataGridExcel_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = dataGridExcel.DoDragDrop(valueFromMouseDown, DragDropEffects.Copy);
                }
            }
        }

        private void dataGridSQL_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //List<string> list = dataGridSQL.Rows
            //                 .OfType<DataGridViewRow>()
            //                 .Select(r => r.Cells["Excel"].Value.ToString())
            //                 .ToList();

            List<string> list = new List<string>();
            List<string> listb = new List<string>();

            foreach (DataGridViewRow item in dataGridSQL.Rows)
            {
                if (item.Cells.Count >= 2 && //atleast two columns
                    item.Cells[1].Value != null) //value is not null
                {
                    if(item.Cells[1].Value.ToString() != "")
                    {
                        list.Add(item.Cells[1].Value.ToString());
                        listb.Add(item.Cells[0].Value.ToString());
                    }
              
                }
            }


            for (int i = 0; i < list.Count; i++)
            {
                MessageBox.Show(list[i].ToString());
            }

            for (int i = 0; i < listb.Count; i++)
            {
                MessageBox.Show(listb[i].ToString());
            }

        }
    }
}
