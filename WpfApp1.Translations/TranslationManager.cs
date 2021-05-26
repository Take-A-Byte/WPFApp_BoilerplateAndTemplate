namespace WpfApp1.Translations
{
    using System;
    using System.Globalization;

    public class TranslationManager
    {
        #region Public Methods

        public string GetTranslation(string name)
        {
            return Resources.ResourceManager.GetString(name, CultureInfo.CurrentUICulture);
        }

        #endregion Public Methods

        #region Private Methods

        private string LanguageToCultureName(SupportedLanguage language)
        {
            switch (language)
            {
                case SupportedLanguage.English:
                    return "en";

                default:
                    return "en";
            }
        }

        #endregion Private Methods
    }
}