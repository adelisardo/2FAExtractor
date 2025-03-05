# [2Fa Extractor](https://github.com/adelisardo/2FAExtractor)

**2Fa Extractor** is a tool that extracts all 2FA (Two-Factor Authentication) codes from a Google Authenticator screenshot and presents them as a separate image for easy backup and access.

## 🚀 Features
- 📸 **Automated Extraction** – Detects and extracts all TOTP-based 2FA codes from a Google Authenticator screenshot.
- 🖼️ **Image Output** – Generates a clear image containing all extracted codes for every code (QRCode).
- ⚡ **Fast & Efficient** – Processes screenshots instantly with high accuracy.
- 🔐 **Secure & Private** – Does not store or transmit any extracted data.

## 🛠️ Installation
1. Clone this repository:
   ```bash
   git clone https://github.com/adelisardo/2FAExtractor.git
   cd 2FAExtractor
   ```
2. Restore dependencies:
   ```bash
   dotnet restore
   ```
4. Change the configurations:
   ```bash
   app.config file!
   ```

4. Run the application:
   ```bash
   dotnet run
   ```

## 📌 Usage
1. Take a screenshot of the Google Authenticator app while displaying your 2FA codes.
2. Run **[2Fa Extractor]** and provide the screenshot as input.
3. You can provide multiple screenshots at the same time.
4. The tool will extract the codes and generate output images.
4. Save the extracted codes for backup or easy access.

## ⚠️ Disclaimer
This tool is intended for **personal backup and recovery purposes** only. Unauthorized use of this tool to access someone else's data is strictly prohibited.

## 🛠️ Technologies Used
- NET 9.0 (console application)
- BarCode (Read the QR code)
- Google.Protobuf (Decode the screenshot exported from Google Authenticator)
- QRCoder (Generate output QR code images)

## 📝 License
This project is licensed under the **MIT License** – see the [LICENSE](LICENSE) file for details.

## 📬 Contact
For any questions or issues, feel free to reach out via linkedin: **https://www.linkedin.com/in/adelisardo/**

---

⭐ **If you find this project useful, consider giving it a star on GitHub!** ⭐
