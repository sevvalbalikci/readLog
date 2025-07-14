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
        private static readonly string projeDizini = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
        private static readonly string DosyaYolu = Path.Combine(projeDizini, "book.json");

        public static List<Book> Load()
        {
            try
            {
                if (!File.Exists(DosyaYolu))
                    return new List<Book>();

                string json = File.ReadAllText(DosyaYolu);
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
            File.WriteAllText(DosyaYolu, json);
        }
    }
}
