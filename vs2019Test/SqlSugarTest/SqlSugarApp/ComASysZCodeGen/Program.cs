using SqlSugar;
using System;

namespace ComASysZCodeGen
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlSugarClient db = new SqlSugarClient(
    new ConnectionConfig()
    {
        ConnectionString = @"server=ITS-SI-D-513\SQL2017DEV;uid=sa;pwd=msk3798!;database=pjmana01",
        DbType = DbType.SqlServer,//设置数据库类型
                    IsAutoCloseConnection = true,//自动释放数据务，如果存在事务，在事务结束后释放
        InitKeyType = InitKeyType.Attribute //从实体特性中读取主键自增列信息
                });
            db.DbFirst.IsCreateAttribute().CreateClassFile(@"C:\_Tech\CsTest\vs2019Test\SqlSugarTest\SqlSugarApp\ComASysModel\Entities", "ComASysModel.Entities");
        
        
        Console.WriteLine("完了");
        }


    }
}
