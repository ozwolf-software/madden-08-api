# Introduction

This C# DLL library is designed to provide a modern API DLL for editing tools used to directly edit Madden 08 roster (`.ROS`) and franchise (`.FRA`) files.

This is a project built in C# on the .NET 8.0 framework specifically designed to bridge the gap between the old tdbaccess.dll file globally used in tools for the old Madden 08 game files by providing a more targetted and useful modern domain structure for other developers to utilise.

## Credit

This project utilises the ubiquotous `tdbaccess.dll` files produced by Artem Khassanov over at [https://www.artemkh.com/nhl/](https://www.artemkh.com/nhl/).  Without his efforts to parse the older Trivial DB file structures used by EA in the day, the games would not have enjoyed the extended life that they have.  The Madden modding community owes you a massive debt!

## Quickstart

### Download the Library

Download the latest version of the `Madden08.API.dll` file and the compatible `tdbaccess.dll` file and add them to your project.

Note: When using these DLLs, you must ensure they are in the base app location together when you build and package your app.  The external function references in the `Madden08.API.dll` file expect the `tdbaccess.dll` file to be in your apps base location.

### Instantiate A Madden API Instance

Once the DLL libraries are registered with your app, you should be able to start referencing them and instantiate a `MaddenAPI` instance.

```c#
using var api = MaddenAPI.Open("/path/to/madden/file.fra");
```

Once you have opened your API instance, you should treat it as a singleton instance for all subsequent actions you perform on your Madden file until such time as you dispose of the resource.

### Interact With Domain Entries

The `MaddenAPI` instance will provide a number of properties that provide collections of the recordsets from the Madden files.  You are able to take those entity lists, modify them as required and then return the updated items to the API instance where they will be written back into the open file.

```c#
using var api = ...;
List<Team> teams = api.Teams;

// Find a team we want to modify.
Team pittsburghSteelers = teams.Find(t => t.Name == 'Pittsburgh') ?? throw new InvalidOperationException("Could not find [ Pittsburgh Steelers ]");
// Domain objects are immutable, so lets get the new modified instance.
Team pittsburghIron = pittsburghSteelers.WithName(nickName: "Iron", otherName: "Iron");
// Send the new modified team back to the API to save it into the open file.
teams = api.Update(pittsburghIron);
```

You can also do bulk changes and update a list.

```c#
using var api = ...;
// This linq function will not mutate the objects on the API instance, but provide a localised immutable set to then return.
List<Team> teams = api.Teams.Select(t => t.AdjustSalary(-100)).toList();
// Send the modified teams back to the API to save into the open file.
teams = api.Update(teams);
```

### Persisting Changes

Once you are ready to write the file changes permanently back into the Madden file, simply call `.CompactAndSave()` on the `MaddenAPI` instance.

**Note**: This _does not_ close the file handle.  You may continue to undertake read and write actions on the Madden file until the below function is called.

### Reverting All Changes

If the `.CompactAndSave()` function has not been called yet, the `.Reload()` function on the `MaddenAPI` instance can be called to reload the original state from the file.

### Closing The File

If you declare the file as `using var api = MaddenAPI.Open("path/to/file.fra")` the file will automatically close at the end of the declaration scope (ie. method, application, etc).

Otherwise, to close the file, simply call the `.Close()` function on the `MaddenAPI` instance.  From that point onwards, a new `MaddenAPI.Open("path/to/file.fra)` call is required to open access to the file.

### Using As A Resource

The `MaddenAPI` class implements the `IDisposable` interface, so you can wrap it in a `using` block if desired.

## Further Reading

See the [Docs](/docs) and [API](/api) sections of this documentation for further information.