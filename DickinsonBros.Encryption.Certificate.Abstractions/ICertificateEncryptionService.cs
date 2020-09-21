namespace DickinsonBros.Encryption.Certificate.Abstractions
{
    public interface ICertificateEncryptionService<T>
    {
        string Decrypt(byte[] encrypted);
        string Decrypt(string encrypted);
        string Encrypt(string unencrypted);
        byte[] EncryptToByteArray(string unencrypted);
    }
}
