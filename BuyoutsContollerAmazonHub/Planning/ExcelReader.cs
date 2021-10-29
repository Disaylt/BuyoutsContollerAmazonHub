using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuyoutsContollerAmazonHub.Documents;
using System.IO;
using ExcelDataReader;
using System.Windows.Forms;

namespace BuyoutsContollerAmazonHub.Planning
{
    public static class ExcelReader
    {
        public static List<OrderData> GetExcelClientOrder(string pathsFile)
        {
            List<OrderData> ordersDataExcel = new List<OrderData>();
            try
            {
                using (var stream = File.Open(pathsFile, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        var sheet = reader.AsDataSet().Tables[0];
                        int numberOfRow = sheet.Rows.Count;
                        if (numberOfRow != 0 && sheet.Rows[0].ItemArray[0].ToString().ToLower().Trim() == "менеджер" && sheet.Rows[0].ItemArray[3].ToString().ToLower().Trim() == "ключ")
                        {
                            for (int i = 1; i < numberOfRow; i++)
                            {
                                OrderData orderData = new OrderData
                                {
                                    Manager = sheet.Rows[i].ItemArray[0].ToString().Trim(),
                                    SKU = sheet.Rows[i].ItemArray[1].ToString().Trim(),
                                    Amount = int.Parse(sheet.Rows[i].ItemArray[2].ToString().Trim()),
                                    KeyWord = sheet.Rows[i].ItemArray[3].ToString().Trim(),
                                };
                                ordersDataExcel.Add(orderData);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Неизвестные заголовки Excel, чтение невозможно!");
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ordersDataExcel;
        }
    }
}
