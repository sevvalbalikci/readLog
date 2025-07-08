using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace readLog
{
    public static class CommentService
    {
        private static readonly string DosyaYolu =
            @"C:\Users\Şevval\source\repos\DotNetNot\readLog\comments.json";

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
