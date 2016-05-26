# C# AppSettings Utility

Quick and simple wrapper around the .Net ConfigurationManager accessing AppSettings from app.config.

Example uses:

```
// Get a string value from the AppSettings by default
AppSettings.Get("")

// Get an int value from the AppSettings
AppSettings.Get<int>("TimeoutValue")

// A safe check around getting a numeric value
long value;
AppSettings.TryGet<long>("IsntNumericValue", out value)
```

