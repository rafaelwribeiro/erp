using System.Security.Cryptography;

namespace erp.application.ExtensionUtils;

public static class StringPasswordExtention
{
    public static string EncryptPassword(this string password)
    {
        // Generate a random salt
        byte[] salt;
        new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
        

        // Create the hash of the password with the salt
        var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
        byte[] hash = pbkdf2.GetBytes(20);

        // Combine the salt and hash into one array
        byte[] hashWithSalt = new byte[36];
        Array.Copy(salt, 0, hashWithSalt, 0, 16);
        Array.Copy(hash, 0, hashWithSalt, 16, 20);

        // Convert the byte array to a base64 string
        string hashedPassword = Convert.ToBase64String(hashWithSalt);

        return hashedPassword;
    }

    public static bool VerifyPassword(this string password, string? hashedPassword)
    {
        // Convert the base64 string back to a byte array
        byte[] hashWithSalt = Convert.FromBase64String(hashedPassword ?? "123");

        // Extract the salt from the byte array
        byte[] salt = new byte[16];
        Array.Copy(hashWithSalt, 0, salt, 0, 16);

        // Calculate the hash of the provided password with the salt
        var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
        byte[] hash = pbkdf2.GetBytes(20);

        // Compare the generated hash with the stored hash
        for (int i = 0; i < 20; i++)
        {
            if (hashWithSalt[i + 16] != hash[i])
            {
                return false;
            }
        }
        return true;
    }
}
