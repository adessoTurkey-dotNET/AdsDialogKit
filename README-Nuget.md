[![AdsDialogKit](https://raw.githubusercontent.com/CihanCakir/AdsDialogKit/main/logo.PNG)]
<!-- PROJECT SHIELDS -->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![NuGet][nuget-shield]][nuget-url]
[![MIT License][license-shield]][license-url]



<!-- PROJECT LOGO -->
# AdsDialogKit




<!-- TABLE OF CONTENTS -->



<!-- ABOUT THE PROJECT -->
## About The Project

Dialog Kit is a useful and customizable dialog box solution for user interfaces. This NuGet package allows you to quickly and easily add dialog box features to your applications. By supporting various types of dialogs, Dialog Kit can be used for communication purposes such as informative messages, alerts, confirmations and user logins. It also offers theme and style options that can be easily integrated and customized into the user interface. Dialog Kit helps you improve the user experience while speeding up your development process

This description highlights the key features and user benefits of the Dialog Kit NuGet package you have created. You can help users understand and use the package by adding this description to the NuGet package's documentation, the package's description section, or the GitHub repository. Of course, you may also want to add customization options or other noteworthy details.



### Built With


[![.Net]][.Net-shield]




<!-- GETTING STARTED -->
## Getting Started

### Prerequisites

* Download and install [.NET 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

### Installation

* Add AdsDialogKit NuGet package to your project 
```sh
dotnet add package AdsDialogKit
```

<!-- USAGE EXAMPLES -->
### Usage

##### Create The SampleStaticDialogBoxHelperMethods

```csharp
using AdsDialogKit;

public static class SampleBasicDialogBoxExtensions
{
    public static IAdsBasicDialogBox BasicDialogError(this IAdsDialogBox AdsDialogBox)
    {
        return AdsDialogBox.Basic
            .Header
                .SetTitle("Example Title For the BasicDialogError")
                .Next()
            .Body
                .SetText("Example Description For the BasicDialogError")
                .Next()
            .Footer
                .Button
                    .SetText("Agree")
                    .SetAction(AdsDialogKitButtonAction.GoToDeepLink)
                    .SetLink("")
                    .Next()
                .Button
                    .SetText("Disagree")
                    .SetAction(AdsDialogKitButtonAction.GoToDeepLink)
                    .SetLink("")
                    .Next()
                .Next()
            .Create();
    }
}
```

##### Dependency Injection

```csharp
using AdsDialogKit;

builder.Services.AddAdsDialogBox()
```

##### Call the DialogBox

```csharp
using AdsDialogKit;

public class DialogBoxController : ControllerBase
{
    readonly IAdsDialogBox _adsDialogBox;

    public DialogBoxController(IAdsDialogBox adsDialogBox)
    {
        _adsDialogBox = adsDialogBox;
    }

    [HttpGet(Name = "BasicDialogInformation")]
    public AdsDialogBox Get()
    {
        var model = SampleBasicDialogBoxExtensions.BasicDialogInformation(_adsDialogBox);
        var serializerSettings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Include,
        };
        var serializedDialogBox = JsonConvert.SerializeObject(model, serializerSettings);
        return JsonConvert.DeserializeObject<AdsDialogBox>(serializedDialogBox, serializerSettings);
    }
}
```



_For more examples, please refer to the [Sample Project](https://github.com/CihanCakir/AdsDialogKit/tree/main/sample/AdsDialogKit.Console)_



<!-- ROADMAP -->
## Roadmap

- [x] Add basic dialog box
- [x] Add examples
- [x] Add license file
- [x] Add NuGet package
- [ ] Add Changelog
- [ ] Add structral comments for methods
- [ ] Add tests

See the [open issues](https://github.com/othneildrew/Best-README-Template/issues) for a full list of proposed features (and known issues).



<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.md` for more information.



<!-- CONTACT -->
## Contact

[![LinkedIn][linkedin-shield]][linkedin-url]

Cihan Çakır - dev.cihancakir@gmail.com

Project Link: [https://github.com/CihanCakir/AdsDialogKit](https://github.com/CihanCakir/AdsDialogKit)



<!-- MARKDOWN LINKS & IMAGES -->
[contributors-shield]: https://img.shields.io/github/contributors/CihanCakir/AdsDialogKit.svg?style=for-the-badge
[contributors-url]: https://github.com/CihanCakir/AdsDialogKit/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/CihanCakir/AdsDialogKit.svg?style=for-the-badge
[forks-url]: https://github.com/CihanCakir/AdsDialogKit/network/members
[stars-shield]: https://img.shields.io/github/stars/CihanCakir/AdsDialogKit.svg?style=for-the-badge
[stars-url]: https://github.com/CihanCakir/AdsDialogKit/stargazers
[issues-shield]: https://img.shields.io/github/issues/CihanCakir/AdsDialogKit.svg?style=for-the-badge
[issues-url]: https://github.com/CihanCakir/AdsDialogKit/issues
[license-shield]: https://img.shields.io/github/license/CihanCakir/AdsDialogKit.svg?style=for-the-badge
[license-url]: https://github.com/CihanCakir/AdsDialogKit/blob/main/LICENSE.md
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/Cihancakir
[product-screenshot]: images/screenshot.png
[.Net]: https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white
[.Net-shield]: https://img.shields.io/badge/.NET-5C2D91?
[nuget-shield]: https://img.shields.io/nuget/v/AdsDialogKit?style=for-the-badge
[nuget-url]: https://www.nuget.org/packages/AdsDialogKit