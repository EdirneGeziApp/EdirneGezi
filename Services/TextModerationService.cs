using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace EdirneGeziAPI.Services
{
    public class TextModerationService
    {
        private readonly string[] _bannedWords =
        {
            "küfür1",
            "yasak",
            "mal",
            "salak",
            "aptal",
            "gerizekali",
            "gerizekalı"
        };

        public bool IsTextSafe(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return false;

            var normalizedText = NormalizeText(text);

            foreach (var word in _bannedWords)
            {
                var normalizedWord = NormalizeText(word);

                if (Regex.IsMatch(
                    normalizedText,
                    $@"\b{Regex.Escape(normalizedWord)}\b",
                    RegexOptions.IgnoreCase))
                {
                    return false;
                }
            }

            return true;
        }

        private string NormalizeText(string text)
        {
            text = text.ToLower(new CultureInfo("tr-TR"));

            text = text
                .Replace("ı", "i")
                .Replace("ğ", "g")
                .Replace("ü", "u")
                .Replace("ş", "s")
                .Replace("ö", "o")
                .Replace("ç", "c");

            text = Regex.Replace(text, @"[^a-z0-9\s]", " ");
            text = Regex.Replace(text, @"\s+", " ").Trim();

            return text;
        }
    }
}