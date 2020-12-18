using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Data.SqlClient;

namespace Magenic.Bicycle.Raw.EF.Test
{
    [TestClass]
    public class TestEf
    {
        public const int SqlTimeOut = 15;
        public const string DockerSql = "Server=tcp:localhost,1466;Database=Bicycle;User Id=sa;Password=ddd20demoSQL-;";

        [TestMethod]
        public void DoAQuickADOCheck()
        {
            var sql = "select T.TABLE_SCHEMA, T.TABLE_NAME from INFORMATION_SCHEMA.TABLES T where (t.TABLE_SCHEMA != 'dbo') order by T.TABLE_SCHEMA, T.TABLE_NAME";
            
            System.Data.CommandType CmdType = System.Data.CommandType.Text;

            DataTable dt;

            using (var cn = new SqlConnection(DockerSql))
            {
                cn.Open();

                using(var cmd = new SqlCommand(sql, cn))
                {
                    cmd.CommandType = CmdType;
                    cmd.CommandTimeout = SqlTimeOut;

                    var rd = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(rd);
                }

                cn.Close();
            }

            Assert.IsNotNull(dt);
            Assert.IsTrue(dt.Rows.Count > 0);
        }
    }
}
