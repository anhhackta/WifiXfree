using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Wifi_Xfree
{
    public class PasswordManager
    {
        public string PasswordFilePath { get; private set; }

        public PasswordManager(string passwordFilePath)
        {
            PasswordFilePath = passwordFilePath;
            EnsurePasswordFileExists();
        }

        private void EnsurePasswordFileExists()
        {
            if (!File.Exists(PasswordFilePath))
            {
                File.WriteAllText(PasswordFilePath, "");
            }
        }

        public List<string> LoadPasswordsFromFile()
        {
            if (File.Exists(PasswordFilePath))
            {
                return File.ReadAllLines(PasswordFilePath).ToList();
            }
            else
            {
                throw new FileNotFoundException("File không tồn tại.");
            }
        }

        public void SavePasswordsToFile(List<string> passwords)
        {
            File.WriteAllLines(PasswordFilePath, passwords);
        }

        public bool IsValidPassword(string password)
        {
            return password.Length > 7 && !password.Contains("\"");
        }

        public bool IsDuplicatePassword(string newPassword, List<string> existingPasswords)
        {
            return existingPasswords.Contains(newPassword);
        }

    }
}