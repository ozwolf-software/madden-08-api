# Player

The `Player` class represents players in the roster or franchise file, including created players, draftees, rostered players, free agents, and retirees.

## Modifying Attributes

Modifying attributes for a player is done via visitor pattern approach.  As a developer, you have the options of overwriting an attribute entirely or adjusting it with a positive or negative value.

```c#
Player player = ...;

Player modified = player.WithAttributes(a => a.AdjustAWR(2).AdjustAGI(-2).WithOVR(91));
```

The system will not allow an attribute to fall outside the 0-99 range and will appropriately cap values.