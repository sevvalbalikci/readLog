using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace readLog
{
    public static class CommentService
    {
       private static readonly string projeDizini = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
        private static readonly string DosyaYolu = Path.Combine(projeDizini, "comments.json");

        public static List<Comment> Yukle()
        {
            if (!File.Exists(DosyaYolu))
                return new List<Comment>();

            string json = File.ReadAllText(DosyaYolu);
            return JsonConvert.DeserializeObject<List<Comment>>(json) ?? new List<Comment>();
        }

        public static void Kaydet(List<Comment> yorumlar)
        {
            string json = JsonConvert.SerializeObject(yorumlar, Formatting.Indented);
            File.WriteAllText(DosyaYolu, json);
        }
    }
}
