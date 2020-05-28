namespace DickinsonBros.Encryption.Certificate.Abstractions
{
    public interface ICertificateEncryption<T>
    {
        string Decrypt(byte[] encrypted);
        byte[] Encrypt(string rawString);
    }
}
