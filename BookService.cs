using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace readLog
{
    public static class BookService
    {
        private static readonly string projeDizini = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
        private static readonly string DosyaYolu = Path.Combine(projeDizini, "books.json");

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
                MessageBox.Show("Kitaplar yüklenirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Book>();
            }
        }

        public static void Save(List<Book> books)
        {
            try
            {
                string json = JsonConvert.SerializeObject(books, Formatting.Indented);
                File.WriteAllText(DosyaYolu, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitaplar kaydedilirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
