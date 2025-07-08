using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace readLog

{
    public static class BookService
    {
        private static readonly string FilePath =
            @"C:\Users\Şevval\source\repos\DotNetNot\readLog\books.json";

        public static List<Book> Load()
        {
            try
            {
                if (!File.Exists(FilePath))
                    return new List<Book>();

                string json = File.ReadAllText(FilePath);
                if (string.IsNullOrWhiteSpace(json))
                    return new List<Book>();

                return JsonConvert.DeserializeObject<List<Book>>(json) ?? new List<Book>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Book>();
            }
        }

        public static void Save(List<Book> books)
        {
            string json = JsonConvert.SerializeObject(books, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }
    }
}
