namespace DesignPattern.bridges
{
    public class OracleConverter : IDataConvert
    {
        public void Convert(Data data)
        {
            Console.WriteLine("查询Oracle转换数据");
        }
    }
}
