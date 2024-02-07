# Draft Pick

The `DraftPick` class represents a draft pick in the next draft.

Do not confuse the `PickNumber` from the `Overall` property values.  The first indicates the draft picks order starting at a 0-based index.  The `Overall` property indicates the true overall in the draft.

You are able to change the owner of a pick.

## Search Tips

As draft pick order is not settled until the offseason, you will want to search the picks by round and original owner team.  For example:

```c#
var originalOwnerId = ...;
var newOwnerId = ...;
var pick = api.Picks.Find(p => p.Round = 1 && p.OriginalOwnerId == originalOwnerId).TradedTo(newOwnerId);
```