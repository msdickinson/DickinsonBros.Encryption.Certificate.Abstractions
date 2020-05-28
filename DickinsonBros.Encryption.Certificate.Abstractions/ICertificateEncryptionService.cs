namespace DickinsonBros.Encryption.Certificate.Abstractions
{
    public interface ICertificateEncryptionService<T>
    {
        string Decrypt(byte[] encrypted);
        byte[] Encrypt(string rawString);
    }
}
