using System.Collections;
using System.Data.SQLite;

namespace NokiaGetNumbers
{
    public class NokiaGetNumbers
    {
        private static string sTrivialQuery =
            "select * from number_data ,string_data where number_data.uid = string_data.uid;";

        private static string sNumbersQuery =
            "select s.text_data ||' '|| t.text_data as Name , c.number_full as Number\r\n                from string_data s, string_data t\r\n                join  number_data c on s.uid = c.uid \r\n                where (s.field_subtype =2 and t.field_subtype = 4)\r\n                and s.uid = t.uid\r\n                order by 1";

        private static string sConnectionString;

        private static string ConnectionString
        {
            get { return sConnectionString; }
            set { sConnectionString = string.Format("Data Source={0}", arg0: value); }
        }

        public static ArrayList GetNumbers()
        {
            SQLiteConnection connection = new SQLiteConnection(ConnectionString);
            SQLiteCommand sqLiteCommand = new SQLiteCommand(sNumbersQuery, connection);
            connection.Open();
            SQLiteDataReader sqLiteDataReader = sqLiteCommand.ExecuteReader();
            ArrayList arrayList = new ArrayList();
            while (sqLiteDataReader.Read())
                arrayList.Add(new PhoneNumber(sqLiteDataReader["Number"].ToString(), sqLiteDataReader["Name"].ToString()));
            return arrayList;
        }

        public static void setDbLocation(string p_sDbLocation)
        {
            ConnectionString = p_sDbLocation;
        }
    }
}
