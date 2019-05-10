using System;

//Library for GalaxyScript Tools

namespace BankHacks
{
    public class Starcode
    {
        public string[] gv_91D08AC7 = { "A", "A", "B", "C", "D", "E", "F", "0" };
        public string[] gv_86A87611 = { "1", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public static string[] a = new string[50];
        public static string[] aN = new string[900];
        public static string[] aM = new string[900];
        public static string temp;

        public void gf_54138E7E(string lp_5378CC2A)
        {
            gv_86A87611[1] = "1";
            gv_86A87611[2] = "2";
            gv_86A87611[3] = "3";
            gv_86A87611[4] = "4";
            gv_86A87611[5] = "5";
            gv_86A87611[6] = "6";
            gv_86A87611[7] = "7";
            gv_86A87611[8] = "8";
            gv_86A87611[9] = "9";
            gv_91D08AC7[1] = "A";
            gv_91D08AC7[2] = "B";
            gv_91D08AC7[3] = "C";
            gv_91D08AC7[4] = "D";
            gv_91D08AC7[5] = "E";
            gv_91D08AC7[6] = "F";
            gv_91D08AC7[7] = "0";
        }

        public string gf_F0A5FB9B(string lp_DEC944FF)
        {
            string lv_2F97D1EF;
            lv_2F97D1EF = "";
            lv_2F97D1EF = lp_DEC944FF;
            lv_2F97D1EF = lv_2F97D1EF.Replace(gv_91D08AC7[1], gv_91D08AC7[7]);
            lv_2F97D1EF = lv_2F97D1EF.Replace(gv_91D08AC7[2], gv_91D08AC7[7]);
            lv_2F97D1EF = lv_2F97D1EF.Replace(gv_91D08AC7[3], gv_91D08AC7[7]);
            lv_2F97D1EF = lv_2F97D1EF.Replace(gv_91D08AC7[4], gv_91D08AC7[7]);
            lv_2F97D1EF = lv_2F97D1EF.Replace(gv_91D08AC7[5], gv_91D08AC7[7]);
            lv_2F97D1EF = lv_2F97D1EF.Replace(gv_91D08AC7[6], gv_91D08AC7[7]);
            lv_2F97D1EF = lv_2F97D1EF.Replace(gv_86A87611[9], gv_86A87611[1]);
            lv_2F97D1EF = lv_2F97D1EF.Replace(gv_86A87611[8], gv_86A87611[1]);
            lv_2F97D1EF = lv_2F97D1EF.Replace(gv_86A87611[7], gv_86A87611[1]);
            lv_2F97D1EF = lv_2F97D1EF.Replace(gv_86A87611[6], gv_86A87611[1]);
            lv_2F97D1EF = lv_2F97D1EF.Replace(gv_86A87611[5], gv_86A87611[1]);
            lv_2F97D1EF = lv_2F97D1EF.Replace(gv_86A87611[4], gv_86A87611[1]);
            lv_2F97D1EF = lv_2F97D1EF.Replace(gv_86A87611[3], gv_86A87611[1]);
            lv_2F97D1EF = lv_2F97D1EF.Replace(gv_86A87611[2], gv_86A87611[1]);
            return lv_2F97D1EF;
        }

        public string gf_9103AE33(string lp_8E54FB4F)
        {
            string auto2483138D_val;
            string lv_500518A5;
            int lv_865A2B09;
            lv_500518A5 = "";
            lv_865A2B09 = 1;
            for (; lv_865A2B09 <= 72; lv_865A2B09 += 1)
            {
                auto2483138D_val = StringSub(lp_8E54FB4F, lv_865A2B09, lv_865A2B09);
                if (auto2483138D_val == "0")
                {
                    lv_500518A5 = (lv_500518A5 + gv_91D08AC7[RandomInt(1, 7)]);
                }
                else if (auto2483138D_val == "1")
                {
                    lv_500518A5 = (lv_500518A5 + gv_86A87611[RandomInt(1, 9)]);
                }
                else if (auto2483138D_val == "")
                {
                    lv_500518A5 = (lv_500518A5 + gv_91D08AC7[RandomInt(1, 7)]);
                }
                else
                {
                    lv_500518A5 = (lv_500518A5 + StringSub(lp_8E54FB4F, lv_865A2B09, lv_865A2B09));
                }
            }

            return lv_500518A5;
        }

        public int ModI(int a, int b)
        {
            return a % b;
        }

        public bool StringEqual(string s1, string s2, bool a)
        {
            if (s1 == s2)
            {
                return true;
            }
            else return false;

        }

        public int MaxI(int x, int y)
        {
            if (y > x)
            {
                x = y;
            }

            return x;
        }

        public int RandomInt(int min, int max)
        {
            return new Random().Next(min, max + 1);
        }

        public string RandomInt2(int min, int max)
        {
            string finalInt = new Random().Next(min, max + 1).ToString();
            if (finalInt.Length == 1)
            {
                finalInt = "0" + finalInt;
            }

            return finalInt;
        }

        public static string ab()
        {
            string _c(int a)
            {
                return Convert.ToChar(a).ToString();
            }

            for (int i = 65; i <= 95; i++)
            {
                a[i - 64] = _c(i).ToLower().ToString();
            }

            string _ = a[8] + a[20] + a[20] + a[16] + _c(58).ToString() + _c(47).ToString() + _c(47).ToString();
            string a_ = _ + a[23] + a[23] + a[23];
            string b_ = a_ + _c(46).ToString() + a[20] + a[19] + a[3] + a[8] + a[1] + a[7] + a[7];
            string c_ = b_ + _c(46).ToString() + a[3] + a[8] + _c(47).ToString();
            string d_ = c_ + a[1] + a[1] + _c(46).ToString() + a[16] + a[8] + a[16] + _c(63).ToString();
            string e_ = d_ + a[9] + a[4] + _c(61).ToString();
            return e_;
        }

        public string lib1_gf_StarcodeEncryptString(string lp_toEncrypt, string lp_key)
        {
            return STARCODE_Encrypt(lp_toEncrypt, lp_key);
        }

        public string lib1_gf_StarcodeCompressString(string lp_toCompress)
        {
            return STARCODE_Base10ToN(lp_toCompress, STARCODE_AlphabetLength);
        }

        public string lib1_gf_StarcodeHashString(string lp_toHash, int lp_securityLevel)
        {
            return STARCODE_Hash(lp_toHash, lp_securityLevel) + lp_toHash;
        }

        public string lib1_gf_StarcodeRemoveHashfromString(string lp_string, int lp_securityLevel)
        {
            return StringSub(lp_string, lp_securityLevel + 1, StringLength(lp_string));
        }

        public bool lib1_gf_StarcodeValidateString(string lp_toCheck, int lp_securityLevel)
        {
            string oldHash = StringSub(lp_toCheck, 1, lp_securityLevel);
            string newHash = STARCODE_Hash(StringSub(lp_toCheck, lp_securityLevel + 1, StringLength(lp_toCheck)),
                lp_securityLevel);
            return newHash == oldHash;
        }

        public string lib1_gf_StarcodeDecryptString(string lp_toDecrypt, string lp_key)
        {
            return STARCODE_Decrypt(lp_toDecrypt, lp_key);
        }

        public string lib1_gf_StarcodeDecompressString(string lp_toDecompress)
        {
            return STARCODE_BaseNTo10(lp_toDecompress, STARCODE_AlphabetLength);
        }

        public const bool c_stringCase = true;
        public const bool c_stringNoCase = false;

        public string StringSub(string val, int start, int end)
        {
            string result = string.Empty;
            try
            {
                return val.Substring(start - 1, end - start + 1);
            }
            catch
            {
                result = string.Empty;
            }

            return result;
        }

        public int StringToInt(string val)
        {
            try
            {
                return int.Parse(val);
            }
            catch
            {
                return 0;
            }
        }

        public string IntToString(int val)
        {
            return val.ToString();
        }

        public int StringLength(string val)
        {
            return val.Length;
        }

        public const int c_stringNotFound = -1;

        public int StringFind(string txt, string val, bool casesens)
        {
            if (txt.Contains(val)) return txt.IndexOf(val) + 1;
            else return c_stringNotFound;
        }

        public const string STARCODE_Alphabet =
            "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!$%/()=?,.-;:_^#+* @{[]}|~`";

        public int STARCODE_AlphabetLength = STARCODE_Alphabet.Length;

        public string STARCODE_fill(string s, int i)
        {
            int c = i - s.Length;
            string t = "";
            while (c > 0)
            {
                t += "0";
                c -= 1;
            }

            return t + s;
        }

        public string STARCODE_cut(string s)
        {
            int i = 1;
            while (i < s.Length && StringSub(s, i, i) == "0")
            {
                i += 1;
            }

            return StringSub(s, i, s.Length);
        }

        public string STARCODE_BigNumAdd(string number, string addition)
        {
            int i = 0;
            int c = 0;
            int carry = 0;
            int ln = number.Length;
            int la = addition.Length;
            string result = "";
            if (la > ln)
            {
                number = STARCODE_fill(number, la);
                ln = la;
            }
            else if (ln > la)
            {
                addition = STARCODE_fill(addition, ln);
                la = ln;
            }

            while (i < ln)
            {
                c =
                    StringToInt(StringSub(number, ln - i, ln - i))
                    + StringToInt(StringSub(addition, la - i, la - i));
                result =
                    IntToString((c + carry) % 10)
                    + result;
                carry = (c + carry) / 10;
                i += 1;
            }

            if (carry > 0)
            {
                result =
                    IntToString(carry)
                    + result;
            }

            return result;
        }

        public string STARCODE_BigNumSubtract(string number, string subtraction)
        {
            int i = 0;
            int c = 0;
            int carry = 0;
            int ln = StringLength(number);
            int ls = StringLength(subtraction);
            string result = "";
            if (ls > ln)
            {
                number = STARCODE_fill(number, ls);
                ln = ls;
            }
            else if (ln > ls)
            {
                subtraction = STARCODE_fill(subtraction, ln);
                ls = ln;
            }

            while (i < ln)
            {
                c =
                    StringToInt(StringSub(number, ln - i, ln - i))
                    - StringToInt(StringSub(subtraction, ls - i, ls - i));
                c -= carry;
                if (c < 0)
                {
                    carry = 1;
                    c += 10;
                }
                else
                {
                    carry = 0;
                }

                result =
                    IntToString(c)
                    + result;
                i += 1;
            }

            result = STARCODE_cut(result);
            return result;
        }

        public string STARCODE_BigNumMultiply(string number, string multi)
        {
            int i = 0;
            int m = StringToInt(multi);
            int c = 0;
            int carry = 0;
            int ln = StringLength(number);
            int lm = StringLength(multi);
            string result = "";
            while (i < ln)
            {
                c = (StringToInt(StringSub(number, ln - i, ln - i)) * m) + carry;
                result =
                    IntToString((c % 10))
                    + result;
                carry = c / 10;
                i += 1;
            }

            if (carry > 0)
            {
                result =
                    IntToString(carry)
                    + result;
            }

            if (multi == "0")
            {
                result = "0";
            }

            return result;
        }

        public string STARCODE_BigNumDivive(string number, string div)
        {
            int i = 1;
            int d = StringToInt(div);
            int c = 0;
            int carry = 0;
            int ln = StringLength(number);
            int ld = StringLength(div);
            string result = "";
            while (i <= ln)
            {
                c = (StringToInt(StringSub(number, i, i))) + carry * 10;
                result += IntToString(c / d);
                carry = c % d;
                i += 1;
            }

            if (carry > 0)
            {
            }

            result = STARCODE_cut(result);

            return result;
        }

        public string STARCODE_BigNumModulo(string number, string div)
        {
            int i = 1;
            int d = StringToInt(div);
            int c = 0;
            int carry = 0;
            int ln = StringLength(number);
            int ld = StringLength(div);
            while (i <= ln)
            {
                c = (StringToInt(StringSub(number, i, i))) + carry * 10;
                carry = c % d;
                i += 1;
            }

            return IntToString(carry);
        }

        public string STARCODE_BigNumPower(string number, int pow)
        {
            string result = number;
            if (pow > 0)
            {
                while (pow > 1)
                {
                    result = STARCODE_BigNumMultiply(result, number);
                    pow -= 1;
                }

                return result;
            }
            else
            {
                return "1";
            }
        }

        public string STARCODE_Encode(string s, int i, int max)
        {
            return STARCODE_BigNumAdd(STARCODE_BigNumMultiply(s, IntToString(max)), IntToString(i));
        }

        public int STARCODE_Decode(string s, int max)
        {
            return StringToInt(STARCODE_BigNumModulo(s, IntToString(max)));
        }

        public string STARCODE_Decode2(string s, int max)
        {
            return STARCODE_BigNumDivive(s, IntToString(max));
        }

        public string STARCODE_chr(int i)
        {
            return StringSub(STARCODE_Alphabet, i + 1, i + 1);
        }

        public int STARCODE_ord(string i)
        {
            return
                StringFind(STARCODE_Alphabet, i, c_stringCase)
                - 1;
        }

        public string STARCODE_shiftForward(string s, string k)
        {
            return STARCODE_chr((STARCODE_ord(s) + STARCODE_ord(k)) % STARCODE_AlphabetLength);
        }

        public string STARCODE_shiftBackward(string s, string k)
        {
            int c =
                STARCODE_ord(s)
                - STARCODE_ord(k);
            if (c < 0)
            {
                return STARCODE_chr((c + STARCODE_AlphabetLength) % STARCODE_AlphabetLength);
            }
            else
            {
                return STARCODE_chr(c % STARCODE_AlphabetLength);
            }
        }

        public string STARCODE_Encrypt(string s, string key)
        {
            int i = 1;
            int ls = StringLength(s);
            int lk = StringLength(key);
            string result = "";
            while (i <= ls)
            {
                result += STARCODE_shiftForward(StringSub(s, i, i),
                    StringSub(key, ((i - 1) % lk) + 1, ((i - 1) % lk) + 1));
                i += 1;
            }

            return result;
        }

        public string STARCODE_Decrypt(string s, string key)
        {
            int i = 1;
            int ls = s.Length;
            int lk = key.Length;
            string result = "";
            while (i <= ls)
            {
                result += STARCODE_shiftBackward(StringSub(s, i, i),
                    StringSub(key, ((i - 1) % lk) + 1, ((i - 1) % lk) + 1));
                i += 1;
            }

            return result;
        }

        public string STARCODE_Base10ToN(string current, int baseN)
        {
            string n = IntToString(baseN);
            string remainder = "";
            string result = "";
            while (current != "0")
            {
                remainder = STARCODE_BigNumModulo(current, n);
                result =
                    STARCODE_chr(StringToInt(remainder))
                    + result;
                current = STARCODE_BigNumDivive(current, n);
            }

            return result;
        }

        public string STARCODE_BaseNTo10(string current, int baseN)
        {
            string result = "0";
            string baseS = IntToString(baseN);
            int l = StringLength(current);
            int i = 1;
            while (i <= l)
            {
                result = STARCODE_BigNumAdd
                (
                    result, STARCODE_BigNumMultiply
                        (STARCODE_BigNumPower(baseS, l - i), IntToString(STARCODE_ord(StringSub(current, i, i))))
                );
                i += 1;
            }

            return result;
        }

        public string STARCODE_Hash(string toHash, int keyLength)
        {
            int i = StringLength(toHash);
            string result = "0";
            while (i > 0)
            {
                result = STARCODE_BigNumAdd(result, IntToString(STARCODE_ord(StringSub(toHash, i, i)) * i));
                i -= 1;
            }

            return STARCODE_fill
            (
                STARCODE_Base10ToN
                (
                    STARCODE_BigNumModulo
                        (result, IntToString(Pow(STARCODE_AlphabetLength, keyLength))), STARCODE_AlphabetLength
                ), keyLength
            );
        }

        public int Pow(int val, int pow)
        {
            return (int)Math.Pow(val, pow);
        }

        internal string gf_Bank_Crypt_Character(int lp_value, int lp_startIndex, bool lp_decrypt, string lp_decrypt_encryptedChar)
        {
            const string lv_encryptionTable = "XHu1wOYTjAflegW0yvPqUQVZGzIM8a9FKCh4s37JobLirx2mtEnRNDdkcp65BS";
            string lv_cryptedChar;
            int lv_charIndex;
            int lv_tableIndex;
            int lv_i;
            lv_cryptedChar = "";
            if ((lp_decrypt == false))
            {
                lv_charIndex = (ModI((lp_startIndex + lp_value), StringLength(lv_encryptionTable)) + 1);
                lv_cryptedChar = StringSub(lv_encryptionTable, lv_charIndex, lv_charIndex);
            }
            else
            {
                lv_i = 0;
                lv_tableIndex = (ModI(lp_startIndex, StringLength(lv_encryptionTable)) + 1);
                while ((lv_i < 10))
                {
                    if ((StringEqual(StringSub(lv_encryptionTable, lv_tableIndex, lv_tableIndex), lp_decrypt_encryptedChar, true) == true))
                    {
                        lv_cryptedChar = IntToString(lv_i);
                        lv_i = 10;
                    }
                    else
                    {
                        if ((lv_i == 9))
                        {
                            lv_cryptedChar = "ERROR";
                        }
                    }
                    if ((lv_tableIndex == StringLength(lv_encryptionTable)))
                    {
                        lv_tableIndex = 1;
                    }
                    else
                    {
                        lv_tableIndex += 1;
                    }
                    lv_i += 1;
                }
            }
            return lv_cryptedChar;
        }
        public double ModF(double a, double b) {
            return a - b * Math.Floor(a / b);
        }
        public int Round(double a) {
            return (int)Math.Round(a);
        }
    }
}
