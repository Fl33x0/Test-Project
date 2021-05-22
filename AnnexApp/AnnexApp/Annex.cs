using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AnnexApp
{
    public struct Annex
    {
        private string _basicWord;
        private char? _literal;

        public Annex(string s)
        {
            string _baseWordRegExp = @"^Приложение ";
            string _literalsRegExp = @"[А-ЖИК-НП-ЦШЩЭЮЯA-HJN0-9]$";
            Regex _r = new Regex(_baseWordRegExp + _literalsRegExp);

            if (_r.IsMatch(s))
            {
                _basicWord = "Приложение ";
                _literal = s.ToCharArray()[11];
            }
            else
            {
                _basicWord = null;
                _literal = null;
                throw new Exception("Неверная строка для создания экземпляра приложения");
            }
        }

        public override string ToString()
        {
            return _basicWord + _literal;
        }

        public Annex GetNextAnnex()
        {
            Annex _newAnnex = new Annex();
            _newAnnex._basicWord = "Приложение ";

            string _requiredChars = "АБВГДЕЖИКЛМНПРСТУФХЦШЩЭЮЯABCDEFGHJKLMNPQRSTUVWXYZ0123456789";
            char[] _literals = _requiredChars.ToCharArray();

            int _currentLiteralNumber = Array.IndexOf(_literals, _literal);

            _newAnnex._literal = _literals[_currentLiteralNumber + 1];

            return _newAnnex;
        }
    }
}
