using System;
using System.Linq;

namespace BankHacks.Libraries
{
    public class tankbattle
    {
        int lv_seed;
        string lv_encryptedValues_full;
        int[] lv_values = new int[11];
        bool lv_decryptSuccess;
        int lv_currentIndex;
        string lv_encryptedValue;
        string lv_decryptedValue_temp;
        string lv_decryptedValue;
        string lv_encryptedData;
        int lv_i;
        int lv_j;
        int lv_charactersDecrypted;
        int lv_charactersEncrypted;
        int lv_numberOfZeroes;
        int lv_valueIndex;


        private Starcode StarCode = new Starcode();

        public string gf_Bank_Encrypt(string Decrypted_Bank, string Player_Handle)
        {
             
            lv_seed = StarCode.StringToInt(StarCode.StringSub(Player_Handle, StarCode.StringLength(Player_Handle), StarCode.StringLength(Player_Handle)));
            lv_currentIndex = lv_seed;
            int[] lv_values = Decrypted_Bank.Split(',').Select(int.Parse).ToArray();
            lv_i = 0;
            while ((lv_i < 8)) {
                if ((lv_values[lv_i] == 0)) {
                    lv_numberOfZeroes = 8;
                }
                else {
                    lv_numberOfZeroes = (StarCode.StringLength(StarCode.IntToString((999999999 / lv_values[lv_i]))) - 1);
                }
                lv_charactersEncrypted = 0;
                while ((lv_charactersEncrypted < lv_numberOfZeroes)) {
                    lv_encryptedData = (lv_encryptedData + StarCode.gf_Bank_Crypt_Character(0, lv_currentIndex, false, ""));
                    lv_currentIndex += (lv_seed + lv_charactersEncrypted);
                    lv_charactersEncrypted += 1;
                }
                lv_valueIndex = 1;
                while ((lv_charactersEncrypted < 9)) {
                    lv_encryptedData = (lv_encryptedData + StarCode.gf_Bank_Crypt_Character(StarCode.StringToInt(StarCode.StringSub(StarCode.IntToString(lv_values[lv_i]), lv_valueIndex, lv_valueIndex)), lv_currentIndex, false, ""));
                    lv_currentIndex += (lv_seed + lv_charactersEncrypted);
                    lv_charactersEncrypted += 1;
                    lv_valueIndex += 1;
                }
                lv_encryptedData = (lv_encryptedData + StarCode.gf_Bank_Crypt_Character(lv_seed, lv_currentIndex, false, ""));
                lv_currentIndex += (lv_seed + lv_charactersEncrypted);
                lv_i += 1;
            }
            lv_encryptedData = (lv_encryptedData + StarCode.gf_Bank_Crypt_Character(lv_values[lv_i], lv_currentIndex, false, ""));
            lv_currentIndex += lv_seed;
            lv_encryptedData = (lv_encryptedData + StarCode.gf_Bank_Crypt_Character(lv_seed, lv_currentIndex, false, ""));
            lv_currentIndex += lv_seed;
            lv_i += 1;
            lv_encryptedData = (lv_encryptedData + StarCode.gf_Bank_Crypt_Character(lv_values[lv_i], lv_currentIndex, false, ""));
            lv_currentIndex += lv_seed;
            lv_encryptedData = (lv_encryptedData + StarCode.gf_Bank_Crypt_Character(lv_seed, lv_currentIndex, false, ""));
            return lv_encryptedData;
            Array.Clear(lv_values, 0, lv_values.Length);

        }

        public string gf_Bank_Decrypt(string Encrypted_Bank, string Player_Handle)
        {
            lv_encryptedValues_full = "";
            lv_decryptSuccess = true;
            lv_encryptedValue = "";
            lv_decryptedValue_temp = "";
            lv_decryptedValue = "";
            lv_seed = StarCode.StringToInt(StarCode.StringSub(Player_Handle, StarCode.StringLength(Player_Handle), StarCode.StringLength(Player_Handle)));
            lv_currentIndex = lv_seed;
            lv_encryptedValues_full = Encrypted_Bank;


            lv_i = 0;
            while ((lv_i < 8) && (lv_decryptSuccess == true))
            {
                lv_encryptedValue = StarCode.StringSub(lv_encryptedValues_full, (1 + (lv_i * 10)), (10 + (lv_i * 10)));
                lv_decryptedValue = "";
                lv_charactersDecrypted = 0;
                while ((lv_charactersDecrypted < 10) && (lv_decryptSuccess == true))
                {
                    lv_decryptedValue_temp = StarCode.gf_Bank_Crypt_Character(0, lv_currentIndex, true, StarCode.StringSub(lv_encryptedValue, (lv_charactersDecrypted + 1), (lv_charactersDecrypted + 1)));
                    if ((StarCode.StringLength(lv_decryptedValue_temp) > 1))
                    {
                        lv_decryptSuccess = false;
                    }
                    else
                    {
                        lv_decryptedValue = (lv_decryptedValue + lv_decryptedValue_temp);
                    }
                    lv_currentIndex += (lv_seed + lv_charactersDecrypted);
                    lv_charactersDecrypted += 1;
                }
                if ((StarCode.StringSub(lv_decryptedValue, 10, 10) == StarCode.IntToString(lv_seed)))
                {
                    lv_values[lv_i] = StarCode.StringToInt(StarCode.StringSub(lv_decryptedValue, 1, 9));
                }
                else
                {
                    lv_decryptSuccess = false;
                }
                lv_i += 1;
            }
            if ((lv_decryptSuccess == true))
            {
                lv_encryptedValue = StarCode.StringSub(lv_encryptedValues_full, (1 + (lv_i * 10)), (2 + (lv_i * 10)));
                lv_decryptedValue = "";
                lv_charactersDecrypted = 0;
                lv_decryptedValue_temp = StarCode.gf_Bank_Crypt_Character(0, lv_currentIndex, true, StarCode.StringSub(lv_encryptedValue, 1, 1));
                if ((StarCode.StringLength(lv_decryptedValue_temp) > 1))
                {
                    lv_decryptSuccess = false;
                }
                else
                {
                    lv_decryptedValue = lv_decryptedValue_temp;
                }
                lv_currentIndex += lv_seed;
                lv_decryptedValue_temp = StarCode.gf_Bank_Crypt_Character(0, lv_currentIndex, true, StarCode.StringSub(lv_encryptedValue, 2, 2));
                lv_currentIndex += lv_seed;
                if ((lv_decryptSuccess == true) && (StarCode.StringLength(lv_decryptedValue_temp) == 1) && (lv_decryptedValue_temp == StarCode.IntToString(lv_seed)))
                {
                    lv_values[8] = StarCode.StringToInt(lv_decryptedValue);
                }
                else
                {
                    lv_decryptSuccess = false;
                }
            }

            if ((lv_decryptSuccess == true))
            {
                lv_encryptedValue = StarCode.StringSub(lv_encryptedValues_full, (3 + (lv_i * 10)), (4 + (lv_i * 10)));
                lv_decryptedValue = "";
                lv_charactersDecrypted = 0;
                lv_decryptedValue_temp = StarCode.gf_Bank_Crypt_Character(0, lv_currentIndex, true, StarCode.StringSub(lv_encryptedValue, 1, 1));
                if ((StarCode.StringLength(lv_decryptedValue_temp) > 1))
                {
                    lv_decryptSuccess = false;
                }
                else
                {
                    lv_decryptedValue = lv_decryptedValue_temp;
                }
                lv_currentIndex += lv_seed;
                lv_decryptedValue_temp = StarCode.gf_Bank_Crypt_Character(0, lv_currentIndex, true, StarCode.StringSub(lv_encryptedValue, 2, 2));
                lv_currentIndex += lv_seed;
                if ((lv_decryptSuccess == true) && (StarCode.StringLength(lv_decryptedValue_temp) == 1) && (lv_decryptedValue_temp == StarCode.IntToString(lv_seed)))
                {
                    lv_values[9] = StarCode.StringToInt(lv_decryptedValue);
                }
                else
                {
                    lv_decryptSuccess = false;
                }
            }
            return string.Join(",",lv_values);
            Array.Clear(lv_values, 0, lv_values.Length);
        }
    }
}

