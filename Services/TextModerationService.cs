using System.Globalization;
using System.Text.RegularExpressions;

namespace EdirneGeziAPI.Services
{
    public class TextModerationService
    {
        private readonly string[] _bannedWords =
        {
            "yasak",
            "mal",
            "salak",
            "aptal",
            "gerizekali",
            "geri zekali",
            "dangalak",
            "ahmak",
            "serefsiz",
            "terbiyesiz",
            "haysiyetsiz",

            "am",
            "amcik",
            "got",
            "gotveren",
            "kaltak",
            "orospu",
            "orospu cocugu",
            "otuz birci",
            "saksocu",
            "sicmak",
            "sik",
            "siker",
            "sikmek",
            "siktir",
            "tasak",
            "yarak",
            "pic",
            "oc",
            "ibne",
            "gavat",
            "kahpe",
            "pezevenk",
            "pust",

            "fuck",
            "fucking",
            "shit",
            "bullshit",
            "bitch",
            "asshole",
            "bastard",
            "motherfucker",
            "dick",
            "cock",
            "pussy",
            "cunt",
            "whore",
            "slut",
            "porn",
            "porno",
            "xxx",
            "sex",
            "sexual",
            "rape",
            "rapist",
            "nude",
            "nudity",
            "hentai",
            "escort",
            "hooker",

            "nazi",
            "neonazi",
            "swastika",
            "white power",
            "nigger",
            "nigga",
            "faggot"
        };

        public bool IsTextSafe(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return false;

            var normalizedText = NormalizeText(text);
            var compactText = RemoveSpaces(normalizedText);

            foreach (var word in _bannedWords)
            {
                var normalizedWord = NormalizeText(word);
                var compactWord = RemoveSpaces(normalizedWord);

                if (Regex.IsMatch(
                    normalizedText,
                    $@"\b{Regex.Escape(normalizedWord)}\b",
                    RegexOptions.IgnoreCase))
                {
                    return false;
                }

                if (!string.IsNullOrWhiteSpace(compactWord) &&
                    compactText.Contains(compactWord))
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

            text = Regex.Replace(text, @"[._\-]", "");
            text = Regex.Replace(text, @"[^a-z0-9\s]", " ");
            text = Regex.Replace(text, @"\s+", " ").Trim();

            return text;
        }

        private string RemoveSpaces(string text)
        {
            return Regex.Replace(text, @"\s+", "");
        }
    }
}