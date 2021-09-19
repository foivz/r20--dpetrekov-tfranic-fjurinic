using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Collections;

namespace Tennis_Track.Klase
{
    public static class EnkripcijaLozinke
    {
        private static readonly int maxSaltLength = 32;
        public static byte[] GenerateSaltedHash(string lozinka, byte[] salt)
        {
            byte[] Lozinka = new byte[32];
            Lozinka = Encoding.ASCII.GetBytes(lozinka);
            using (HashAlgorithm algorithm = new SHA256Managed())
            {
                byte[] saltedText = new byte[lozinka.Length + salt.Length];

                Lozinka.CopyTo(saltedText, 0);
                salt.CopyTo(saltedText, lozinka.Length);

                return algorithm.ComputeHash(saltedText);
            }
        }
        public static byte[] GenerateSalt()
        {
            using (RandomNumberGenerator random = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[maxSaltLength];
                random.GetNonZeroBytes(salt);
                return salt;
            }
        }
        private static bool ProvjeriLozinku(string Lozinka)
        {
            byte[] hashLozinke = GenerateSaltedHash(Lozinka, PrijavaClana.PrijavljeniCLan.SaltLozinke);
            if (StructuralComparisons.StructuralEqualityComparer.Equals(PrijavaClana.PrijavljeniCLan.HashLozinke, hashLozinke))
                return true;
            else
            {
                return false;
            }

        }
    }
}
