using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Security.Cryptography;


/// <summary>
/// Summary description for EncrptedText
/// </summary>
public class EncrptedText
{
	public EncrptedText()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public  string Encode(string password)
    {
        byte[] EncrData = new byte[password.Length];
        EncrData = Encoding.UTF8.GetBytes(password);
        string encodeData = Convert.ToBase64String(EncrData);
        return encodeData;
    }
    public string Decode(string encodeData)
    {
        UTF8Encoding encoder = new UTF8Encoding();
       Decoder utf8decode= encoder.GetDecoder();
       byte[] DecrData = Convert.FromBase64String(encodeData);
       int charCount = utf8decode.GetCharCount(DecrData, 0, DecrData.Length);
       char[] decodeChar = new char[charCount];
       utf8decode.GetChars(DecrData, 0, DecrData.Length, decodeChar, 0);
       string result = new string(decodeChar);
       return result;

    }
}