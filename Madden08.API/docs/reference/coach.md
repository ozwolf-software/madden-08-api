# Coach

The `Coach` class represents a coach in a Madden file.

Cities have a name, region and state, a population, and are flagged whether they can be used in a franchise.

## Modifying Attributes

Modifying attributes for a coach is done via visitor pattern approach.

```c#
Coach coach = ...;

Coach modified = coach.WithAttributes(a => a.WithMotivation(90).WithKnowledge(75));
```

The system will not allow an attribute to fall outside the 0-99 range and will appropriately cap values.

## Modifying Strategy

Modifying a strategy for a coach is done via the visitor pattern approach.

```c#
Coach coach = ...;
Playbook offensePlaybook = ...;
Playbook defensePlaybook = ...;

Coach modified = coach.WithStrategy(s => s.WithOffensePlaybook(offensePlaybook.Id).WithOffenseAggression(65).WithDefensePlaybook(defensePlaybook.Id));
```