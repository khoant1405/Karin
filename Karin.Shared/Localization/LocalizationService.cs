using Newtonsoft.Json;
using System.Globalization;

namespace Shared.Localization
{
    public class LocalizationService : ILocalizationService
    {
        private readonly string _localizationFilePath;
        private Dictionary<string, string> _localizedValues;

        public LocalizationService()
        {
            _localizationFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Shared", "Localization");
        }

        public string Get(string key)
        {
            var culture = CultureInfo.CurrentCulture.Name;
            culture = string.IsNullOrEmpty(culture) ? "vi-VN" : culture;
            var filePath = Path.Combine(_localizationFilePath, $"messages.{culture}.json");

            if (_localizedValues == null || !File.Exists(filePath))
            {
                LoadLocalizationFile(filePath);
            }

            return _localizedValues.TryGetValue(key, out string? value) ? value : key;
        }

        private void LoadLocalizationFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                _localizedValues = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            }
            else
            {
                _localizedValues = new Dictionary<string, string>();
            }
        }
    }
}
