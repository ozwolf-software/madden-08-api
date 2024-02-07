# Stadium

The `Stadium` class represents a stadium that a team plays in.

These can represent current in-game stadiums or created ones through a roster.

Created stadiums can be reconfigured through this library, which will adjust their visual appearance and capacity appropriately.

## Changing Configuration

The `Stadium` object uses a visitor pattern to allow more direct configuration changes, rather than having to undertake callbacks to originating objects.

```c#
Stadium stadium = ...;

Stadium reconfigured = stadium.WithConfiguration(c =>
	c.WithNorthEndzone(e => e.WithTier1(EndzoneTier1.Straight))
)
```