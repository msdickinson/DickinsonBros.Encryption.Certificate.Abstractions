namespace DickinsonBros.Encryption.Certificate.Abstractions
{
    public interface ICertificateEncryptionService<T>
    {
        string Decrypt(byte[] encrypted);
        string Decrypt(string encrypted);
        string Encrypt(string unencrypted);
        byte[] EncryptToByteArray(string unencrypted);
    }

    public interface IConfigurationEncryptionService
    {
        string Decrypt(byte[] encrypted);
        string Decrypt(string encrypted);
        string Encrypt(string unencrypted);
        byte[] EncryptToByteArray(string unencrypted);
    }
}
