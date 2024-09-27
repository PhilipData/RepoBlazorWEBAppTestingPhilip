using BCrypt.Net;
using System.Security.Cryptography;
using System.Text;

namespace BlazorWEBAppTestingPhilip.Codes
{
    public class HashingHandler
    {
        // Dont use MD5 as it has been debricated
        //public string MD5Hashing(string textToHash)
        //{
        //    byte[] inputByte  = Encoding.ASCII.GetBytes(textToHash);
        //    MD5 md5 = MD5.Create();
        //    byte[] hashedValue = md5.ComputeHash(inputByte);        
        //    return Convert.ToBase64String(hashedValue);
        //}


        public string SHA256Hashing(string textToHash)
        {
            byte[] inputByte = Encoding.ASCII.GetBytes(textToHash);
            SHA256 sha256 = SHA256.Create();
            byte[] hashedValue = sha256.ComputeHash(inputByte);
            return Convert.ToBase64String(hashedValue);
        }

        //public string HMACHashing(string textToHash)
        //{
        //    byte[] myKey = Encoding.ASCII.GetBytes("");
        //    byte[] inputByte = Encoding.ASCII.GetBytes(textToHash);

        //    HMACSHA256 hmac = new HMACSHA256();
        //    hmac.Key = myKey;
        //    hmac.ComputeHash(inputByte);
        //    byte[] hashedValue = hmac.ComputeHash(inputByte);
        //    return Convert.ToBase64String(hashedValue);
        //}

        //public string PBKDF2Hashing(string textToHash)
        //{
        //    byte[] inputByte = Encoding.ASCII.GetBytes(textToHash);
        //    byte[] SaltAsByteArray = Encoding.ASCII.GetBytes("mySalt");
        //    var hashAlgo = new System.Security.Cryptography.HashAlgorithmName("SHA256");
        //    byte[] hashedValue = System.Security.Cryptography.Rfc2898DeriveBytes.Pbkdf2(inputByte, SaltAsByteArray, 11, hashAlgo, 32);

        //    return Convert.ToBase64String(hashedValue);
        //}

        // This is supposedly the most secure encryption
        // Remember to get the needed Nugget-Packet : BCrypt.Net-Next
        public string BCryptHashing(string textToHash)
        {
            //BCrypt.Net.BCrypt.HashPassword(textToHash);
            //int workFactor = 11;
            //string salt = BCrypt.Net.BCrypt.GenerateSalt();
            //bool enhancedEntropy = true;
            //return BCrypt.Net.BCrypt.HashPassword(textToHash, salt, enhancedEntropy);

            int workFactor = 11;
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            bool enhancedEntropy = true;
            HashType hashType = HashType.SHA256;
            return BCrypt.Net.BCrypt.HashPassword(textToHash, salt, enhancedEntropy);


        }

        //public string BCryptHashing(string textToHash) =>
        //    BCrypt.Net.BCrypt.HashPassword(textToHash);

        public bool BCryptVerifierHashing(string textToHash, string hashedValueFromDB)
        {
            //return BCrypt.Net.BCrypt.Verify(textToHash, hashedValueFromDB);
            
            //BCrypt.Net.BCrypt.Verify(textToHash,hashedValueFromDB, true);

            return BCrypt.Net.BCrypt.Verify(textToHash, hashedValueFromDB, true, BCrypt.Net.HashType.SHA256);
        }

    }
}
