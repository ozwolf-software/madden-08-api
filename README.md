# ![Madden](Madden08.API/images/docs/logo.png) 08 API DLL

This is a project built in C# on the .NET 8.0 framework specifically designed to bridge the gap between the old tdbaccess.dll file globally used in tools for the old Madden 08 game files by providing a more targetted and useful modern domain structure for other developers to utilise.

## Credit

This project utilises the ubiquotous `tdbaccess.dll` files produced by Artem Khassanov over at [https://www.artemkh.com/nhl/](https://www.artemkh.com/nhl/).  Without his efforts to parse the older Trivial DB file structures used by EA in the day, the games would not have enjoyed the extended life that they have.  The Madden modding community owes you a massive debt!

## Usage

Both the `Madden08.API.dll` and `tdbaccess.dll` need to be in the same directory of your application to work, as the `Madden08.API.dll` file is dependent on the latter, it is pathed to be next to it.

Also ensure you use the `tdbaccess.dll` file published here, as it is the x64 version of the file and overwriting it with one from an older Madden tool may inadvertently replace it with the 32-bit x86 version.

### Instantiating the Library

To instantiate the library and open a file, use the following code:

```c#
using MaddenAPI api = MaddenAPI.Open("path/to/my/file.fra"); // or a .ros file.

List<Player> players = api.Players;

int playerId = 273;

Player player = players.Find(p => p.ID == playerId) ?? throw new InvalidDataException($"Could not find player [ {playerId} ]");

PlayerAttributes updateAttributes = player.Attributes.WithAWR(99);

Player updatedPlayer = player.WithJerseyNumber(55).WithAttributes(updatedAttributes);

api.Update(updatedPlayer);

api.CompactAndSave();
```

Your interactions with your Madden file will be via the properties and functions exposed by this class.

Always remember to call `MaddenAPI.Close();` if you have not used the `using` keyword.

For further information, please look at the code documentation for the `MaddenAPI` class.

## Developer Philosophy

This library is designed to work on immutable `record` objects.  All domain objects returned for reading and modification are records, meaning any changes to them will generate a new reference instance to work with.

A modified domain object will not be persisted back to the central database file until the appropriate `Update` function on the core file class is called with the modified object.

### Type Modifications

All domain objects have helper functions built into them for the most common object changes expected.

For example, the `Player` class has a `Player.WithWeight(int weight)` function that returns a new `Player` with the adjusted weight.  Under the hood, this is simply doing a `this with { Weight = weight };` call to return the instance.

Some domain objects have logic functions on them as well, besides property modifiers.  `Player` also has the `Player.Released()` function that will move them to the free agency team and zero out their current contract.

If developers want to do other modifications to these types, as they are records, they can write their own code for it:

```c#
Player player = api.Players.First(p => p.ID == id); // do null check
Player modified = player with { DraftRound = 1, DraftPick = 1};
api.Update(modified);
```

**Note**: The `Update` functions on the `MaddenAPI` object are only designed to write specific fields back to the file, so while you may directy modify a value on an object via the C# `with` function, the `Update` functions are not guaranteed to write it back to the file.

## Future Changes & Contributions

This project will continue to expand with new domain objects and functionality for developers to write data.

We welcome anyone wanting to do a PR on this project to add functionality to it, though not all PRs will be openly accepted as the primary purpose and design philosophy of this library is meant to be maintained.