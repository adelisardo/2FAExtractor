using System.Web;
using QRCoder;


const string sourcePath = "D:\\";
const string destinationPath = "D:\\";

var imagesPath = Directory.EnumerateFiles(sourcePath);
int i = 0;
foreach (var imagePath in imagesPath)
{
    //Validate files and extract QR code content

    string qrCodeContent = "";
    string base64Data = HttpUtility.UrlDecode(qrCodeContent.Replace("otpauth-migration://offline?data=", ""));
    byte[] binaryData = Convert.FromBase64String(base64Data);

    MigrationPayload payload = MigrationPayload.Parser.ParseFrom(binaryData);

    string secret;
    int j = 0;
    foreach (var otp in payload.OtpParameters)
    {
        secret = Base32Encoding.ToString(otp.Secret.ToByteArray());
        using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
        using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(GenerateOtpAuthUrl(secret, otp.Name, otp.Issuer), QRCodeGenerator.ECCLevel.Q))
        using (PngByteQRCode qrCode = new PngByteQRCode(qrCodeData))
        {
            byte[] qrCodeImage = qrCode.GetGraphic(20);
            File.WriteAllBytes(Path.Combine(destinationPath, $"{i}-{j}.png"), qrCodeImage);
        }
        j++;
    }
    i++;
}

static string GenerateOtpAuthUrl(string secret, string accountName, string issuer)
{
    return $"otpauth://totp/{Uri.EscapeDataString(issuer)}:{Uri.EscapeDataString(accountName)}?secret={secret}&issuer={Uri.EscapeDataString(issuer)}&algorithm=SHA1&digits=6&period=30";
}
