# Team

The `Team` class represents a team in the roster or franchise file, including franchise "teams" such as free agency, retirees and pro bowl teams.

## Name Changing

There is a singular function for changing a team's name that uses optional fields.

```c#
Team team = ...;
// each property below can be left out if not being changed.
Team modified = team.WithName(name: "Honolulu", nickName: "Honu", shortName: "HON", otherName: "Honu");
```

## Future Functionality

At present, the library does not provide the ability to change custom art assets for teams to run a custom league.  This feature will be made available in a future release.