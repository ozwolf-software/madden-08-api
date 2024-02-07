# Basic Concepts

## Immutability

All domain objects are `record` objects, meaning they are initialized as immutable and readable only.  Any modification to a domain object will result in a new object reference.  This means if you pull an item out of a collection and modify it, it needs to be put back into the collection.

The `MaddenAPI` instance will do this automatically for you if you do an `.Update()` call with the modified object or objects.  The returned list of objects will be the modified state.

## What Gets Saved

This library only has targetted saving of modified fields.  So while it's possible as a developer to do your own `this with { Something = something };` call on a record to modify its state, the update and save functionality of the library only writes certain values back that are guaranteed to reduce the risk of corrupting your Madden files.

It is recommended to only use the helper methods on the domain objects to modify their state.

## 