# <img src="doc/xamarin_fingerprint.png" width="71" height="71"/> Fingerprint plugin for Xamarin 

Xamarin and MvvMCross plugin for accessing the fingerprint sensor.

| Type  | Stable | Pre release |
| ------------- | ----------- | ----------- |
| vanilla | [![NuGet](https://img.shields.io/nuget/v/Plugin.Fingerprint.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/Plugin.Fingerprint/) | [![NuGet](https://img.shields.io/nuget/vpre/Plugin.Fingerprint.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/Plugin.Fingerprint/) |
| MvvmCross | [![NuGet](https://img.shields.io/nuget/v/MvvmCross.Plugins.Fingerprint.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/MvvmCross.Plugins.Fingerprint/) | [![NuGet](https://img.shields.io/nuget/vpre/MvvmCross.Plugins.Fingerprint.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/MvvmCross.Plugins.Fingerprint/) |

[Changelog](doc/changelog.md)

## Support

The plugin supports the listed platforms.

If you like the quality and code you can support me [![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg?style=flat-square)](https://www.paypal.me/smstuebe) Thanks!

| Platform  | Version |
| ------------- | ----------- |
| Xamarin.Android | 4.4 |
| Xamarin.iOS     | 8.0 |
| Xamarin.Mac     | 10.12 |
| Windows UWP     | 10  |

## Setup

### iOS

Add `NSFaceIDUsageDescription` to your Info.plist to describe the reason your app uses Face ID. (see [Documentation](https://developer.apple.com/library/content/documentation/General/Reference/InfoPlistKeyReference/Articles/CocoaKeys.html#//apple_ref/doc/uid/TP40009251-SW75)). Otherwise the App will crash when you start a Face ID authentication on iOS 11.3+.

```xml
<key>NSFaceIDUsageDescription</key>
<string>Need your face to unlock secrets!</string>
```

### Android
**Set Target SDK version**

The target SDK version has to be >= 6.0. I recomment to use always the latest stable SDK version, if possible. You can set the target SDK version in your Android project properties.

**Request the permission in AndroidManifest.xml**

The first line is for the standard Android API and the second for Samsung devices using the Pass API.

```xml
<uses-permission android:name="android.permission.USE_FINGERPRINT" />
<uses-permission android:name="com.samsung.android.providers.context.permission.WRITE_USE_APP_FEATURE_SURVEY" />
```
**Set the resolver of the current Activity**

Skip this, if you use the MvvMCross Plugin or don't use the dialog.

We need the current activity to display the dialog. You can use the [Current Activity Plugin](https://github.com/jamesmontemagno/Xamarin.Plugins/tree/master/CurrentActivity) from James Montemagno or implement your own functionality to retrieve the current activity. See Sample App for details.
```csharp
CrossFingerprint.SetCurrentActivityResolver(() => CrossCurrentActivity.Current.Activity);
```

## Usage
### Example
#### vanilla
```csharp
var result = await CrossFingerprint.Current.AuthenticateAsync("Prove you have fingers!");
if (result.Authenticated)
{
    // do secret stuff :)
}
else
{
    // not allowed to do secret stuff :(
}
```

#### using MvvMCross
```csharp
var fpService = Mvx.Resolve<IFingerprint>(); // or use dependency injection and inject IFingerprint

var result = await fpService.AuthenticateAsync("Prove you have mvx fingers!");
if (result.Authenticated)
{
    // do secret stuff :)
}
else
{
    // not allowed to do secret stuff :(
}
```

### Xamarin University public lecture

[![Xamarin University public lecture](https://img.youtube.com/vi/n8m344IxlnY/0.jpg)](https://www.youtube.com/watch?v=n8m344IxlnY)

### API
The API is defined by the ```IFingerprint``` interface:

```csharp
/// <summary>
/// Checks the availability of fingerprint authentication.
/// Checks are performed in this order:
/// 1. API supports accessing the fingerprint sensor
/// 2. Permission for accessint the fingerprint sensor granted
/// 3. Device has sensor
/// 4. Fingerprint has been enrolled
/// <see cref="FingerprintAvailability.Unknown"/> will be returned if the check failed 
/// with some other platform specific reason.
/// </summary>
/// <param name="allowAlternativeAuthentication">
/// En-/Disables the use of the PIN / Passwort as fallback.
/// Supported Platforms: iOS, Mac
/// Default: false
/// </param>
Task<FingerprintAvailability> GetAvailabilityAsync(bool allowAlternativeAuthentication = false);

/// <summary>
/// Checks if <see cref="GetAvailabilityAsync"/> returns <see cref="FingerprintAvailability.Available"/>.
/// </summary>
/// <param name="allowAlternativeAuthentication">
/// En-/Disables the use of the PIN / Passwort as fallback.
/// Supported Platforms: iOS, Mac
/// Default: false
/// </param>
/// <returns><c>true</c> if Available, else <c>false</c></returns>
Task<bool> IsAvailableAsync(bool allowAlternativeAuthentication = false);

/// <summary>
/// Requests the authentication.
/// </summary>
/// <param name="reason">Reason for the fingerprint authentication request. Displayed to the user.</param>
/// <param name="cancellationToken">Token used to cancel the operation.</param>
/// <returns>Authentication result</returns>
Task<FingerprintAuthenticationResult> AuthenticateAsync(string reason, CancellationToken cancellationToken = default(CancellationToken));

/// <summary>
/// Requests the authentication.
/// </summary>
/// <param name="authRequestConfig">Configuration of the dialog that is displayed to the user.</param>
/// <param name="cancellationToken">Token used to cancel the operation.</param>
/// <returns>Authentication result</returns>
Task<FingerprintAuthenticationResult> AuthenticateAsync(AuthenticationRequestConfiguration authRequestConfig, CancellationToken cancellationToken = default(CancellationToken));
```

The returned ```FingerprintAuthenticationResult``` contains information about the authentication.
```csharp
/// <summary>
/// Indicatates whether the authentication was successful or not.
/// </summary>
public bool Authenticated { get { return Status == FingerprintAuthenticationResultStatus.Succeeded; } }

/// <summary>
/// Detailed information of the authentication.
/// </summary>
public FingerprintAuthenticationResultStatus Status { get; set; }

/// <summary>
/// Reason for the unsucessful authentication.
/// </summary>
public string ErrorMessage { get; set; }
```

### Example
#### vanilla
```csharp
var result = await CrossFingerprint.Current.AuthenticateAsync("Prove you have fingers!");
if (result.Authenticated)
{
    // do secret stuff :)
}
else
{
    // not allowed to do secret stuff :(
}
```

#### using MvvMCross
```csharp
var fpService = Mvx.Resolve<IFingerprint>(); // or use dependency injection and inject IFingerprint

var result = await fpService.AuthenticateAsync("Prove you have mvx fingers!");
if (result.Authenticated)
{
    // do secret stuff :)
}
else
{
    // not allowed to do secret stuff :(
}
```

#### mocking in unit tests

```C#
//Create mock with LigthMock (http://www.lightinject.net/)
var mockFingerprintContext = new MockContext<IFingerprint>();
var mockFingerprint = new CrossFingerprintMock(mockFingerprintContext);

mockFingerprintContext.Current = mockFingerprint;
```

### iOS
#### Limitations

You can't create a custom dialog. The standard iOS Dialog will be shown.

##### iOS 9+ only
- cancelable programmatically with passed CancellationToken
- custom fallback button title

##### iOS 10+ only
- custom cancel button title

### Android
#### Limitations

You can't use the alternative authentication method.

#### Configuration

If you don't like the default dialog, you can easily customize it. You have to inherit from `FingerprintDialogFragment` e.g. like:
```csharp
public class MyCustomDialogFragment : FingerprintDialogFragment
{
    public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
    {
        var view = base.OnCreateView(inflater, container, savedInstanceState);
        view.Background = new ColorDrawable(Color.Magenta); // make it fancyyyy :D
        return view;
    }
}
```

And somewhere in your code set your custom dialog fragment:
```csharp
CrossFingerprint.SetDialogFragmentType<MyCustomDialogFragment>();
```

### UWP
#### Limitations

You can't use the alternative authentication method.

## Testing on Simulators
### iOS
![Controlling the sensor on the iOS Simulator](doc/ios_simulator.png "Controlling the sensor on the iOS Simulator")

With the Hardware menu you can
* Toggle the enrollment status
* Trigger valid (<kbd>⌘</kbd> <kbd>⌥</kbd> <kbd>M</kbd>) and invalid (<kbd>⌘</kbd> <kbd>⌥</kbd> <kbd>N</kbd>) fingerprint sensor events

### Android
* start the emulator (Android >= 6.0)
* open the settings app
* go to Security > Fingerprint, then follow the enrollment instructions
* when it asks for touch
 * open command prompt
 * `telnet 127.0.0.1 <emulator-id>` (`adb devices` prints "emulator-&lt;emulator-id&gt;")
 * `finger touch 1`
 * `finger touch 1`

Sending fingerprint sensor events for testing the plugin can be done with the telnet commands, too.

**Note for Windows users:**
You have to enable telnet: Programs and Features > Add Windows Feature > Telnet Client

## Nice to know

### ProGuard

If you use the plugin with Link all, Release Mode and ProGuard enabled, you may have to add the follwoing rules to your proguard.cfg.

    -dontwarn com.samsung.**
    -keep class com.samsung.** {*;}

## Contribution
<img src="http://i.imgur.com/WFBeQuG.png" /> + <img src="http://i.imgur.com/P4Ay9tm.png" />
