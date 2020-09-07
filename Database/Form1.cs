using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;

namespace Database
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }



        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox_command.Text = e.Node.Text;
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            bool retValue = false;//이걸 왜사용하는지 모르겠음
            string dbIp = "192.168.0.4";//ip주소를 나타낸다.
            string dbName = "XE";//서버네임
            string dbId = "hr";//DB ID
            string dbPw = "1234";//DB PW
            OracleConnection pgOraConn = null;
            try
            {
                 pgOraConn = new OracleConnection(//오라클에 접속, 문자열주소를 참조하려면 어디를 봐야하는지
                    $"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={dbIp})(PORT=1521)))" +
                    $"(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={dbName})));User ID={dbId};Password={dbPw};Connection Timeout=30;"
                    );
                //data source=???? host= DBIP(사용하는DB주소) , PORT= oracle기본포트(1521)
                //Connect_DATA service_name=DBName u

                pgOraConn.Open();
                OracleCommand pgOraCmd = new OracleCommand($"{txt_Query.Text.Remove(txt_Query.TextLength - 1)}", pgOraConn);
                //if(txt_Query.Text.Contains("select"))
                {//

                    OracleDataAdapter oda = new OracleDataAdapter(pgOraCmd);// 명령창cmd를적용
                    DataSet ds = new DataSet();//데이터테이블 객체들 생성
                    oda.Fill(ds);//적용된 데이터가 데이터테이블(ds)형태로저장
                    dataGridView1.DataSource = ds.Tables[0];// ds의 0번째 테이블로 저장
                }

            }
            catch (Exception ae)//ae는 발생된에러
            {
                Console.WriteLine(ae.StackTrace);
                txt_Error.Text = ae.Message;
                retValue = false;
                MessageBox.Show($"DB connection fail.\n {ae.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                pgOraConn.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

