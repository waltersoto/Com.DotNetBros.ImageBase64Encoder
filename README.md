# Com.DotNetBros.ImageBase64Encoder

ImageBase64Encoder is a versatile C# class that makes it simple to convert images to Base64 strings and vice versa. It is particularly useful for embedding images in HTML or CSS, transmitting images over a network, or storing them in databases. This class is built on top of the powerful SixLabors.ImageSharp library, ensuring top-notch performance and reliability.

## Features
Easily convert images to Base64 strings and back
Supports loading images from file paths or byte arrays
Lightweight and efficient with the help of SixLabors.ImageSharp
Compatible with various image formats, automatically handled by the ImageSharp library
Installation
To use this class, you need to install the SixLabors.ImageSharp NuGet package:

``
Install-Package SixLabors.ImageSharp -Version 1.0.4
``

Then, simply add the `ImageBase64Encoder.cs` file to your project.

## Usage Examples

Here are a few examples of how to use the ImageBase64Encoder class:

### Convert an image from a file path to a Base64 

```cs
using Com.DotNetBros.ImageBase64Encoder;

string imagePath = "path/to/your/image.png";
string base64String = ImageBase64Encoder.ImageToBase64(imagePath);
Console.WriteLine("Base64 String: " + base64String);
```

### Convert an image from a byte array to a Base64 string

```cs
using Com.DotNetBros.ImageBase64Encoder;

byte[] imageBytes = File.ReadAllBytes("path/to/your/image.png");
string base64String = ImageBase64Encoder.ImageToBase64(imageBytes);
Console.WriteLine("Base64 String: " + base64String);
```

### Convert a Base64 string back to an Image object

```cs
using Com.DotNetBros.ImageBase64Encoder;

string base64String = "your_base64_string_here";
Image image = ImageBase64Encoder.Base64ToImage(base64String);

// Perform any additional image processing or save it to a file
image.Save("output_image.png");
```

## License
This project is open source and available under the [MIT License](https://github.com/waltersoto/Com.DotNetBros.ImageBase64Encoder/blob/main/LICENSE).

## Contributing
Pull requests and suggestions are welcome! If you have any ideas or improvements, please don't hesitate to submit an issue or create a pull request. 

