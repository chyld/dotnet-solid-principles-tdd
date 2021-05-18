# C# OOP: SOLID Checkpoint

## Background

You just joined a team where all the previous developers just left. The application you inherited is a suite of office productivity tools, with features related to calendars, reminders and to-dos. But it turns out that they didn't really care about code quality at all, sadly.

The domain looks like this:

![solid checkpoint domain](./images/solid-checkpoint-domain.png?raw=true)

Your new Product Owner tells you that users and previous developers have reported a number of problems, and it's your job to fix them using SOLID principles to guide your changes.

## Bugfix Tickets

### Problem #1: Single Responsibility Principle

You get the following message:

```
Hey - users are reporting that their Todos are all messed up.

When they change an owner name on a Todo, it should update on all of them, but it's not.

Can you fix that?
```

1. Look through the codebase.
1. Find an obvious violation of the Single Responsibility Principle.
1. Fix it.
1. Run all tests in the `App.Tests` directory and make sure they pass.

If you need a clue as to where it is in the domain, scroll to the bottom.

### Problem #2: Open/Closed Principle

You get the following message:

```
Hey there - I saw you fixed the owner thing.  Awesome!  So glad we hired you :)

So we have a new feature coming up where users will be able to add Holidays to the calendar.

Last time I asked the developer to add a new thing to the Calendar, they said it required changing lots of code in Calendar.  

Can you check and make sure things are setup well if want to add new things to Calendar?
```

1. Look through the codebase.
1. Find the related violation of the Open/Closed Principle.
1. Fix it.
1. Run all tests in the `App.Tests` directory and make sure they pass.

If you need a clue as to where it is in the domain, scroll to the bottom.

### Problem #3: Liskov Substitution Principle

You get the following message:

```
You're doing great!  You're the best developer we've ever had!

So there's this thing where we allow users to create Reminders, Todos, and Events with null titles (don't ask why, it's a long story).

When this happens, they shouldn't appear in the iCalendar Export, but right now they are, and it's causing the exports to crash.

Can you fix that?
```

1. Look through the codebase.
1. Find the related violation of the Liskov Substitution Principle.
1. Fix it.
1. Run all tests in the `App.Tests` directory and make sure they pass.

If you need a clue as to where it is in the domain, scroll to the bottom.

### Problem #4: Interface Segregation Principle

You get the following message:

```
Ugh!  I hate to bother you with yet _another_ problem, but this thing keeps happening where new developers keep mistakenly writing code that adds Events to the TodoList.

The TodoList should only be able to take things that users can complete, like Todos and Reminders.

Can you fix that so that new developers don't mistakenly add Events to TodoLists?
```

1. Look through the codebase.
1. Find the related violation of the Interface Segregation Principle.
1. Fix it.
1. Run all tests in the `App.Tests` directory and make sure they pass.

If you need a clue as to where it is in the domain, scroll to the bottom.

### Problem #5: Dependency Inversion Principle

You get the following message:

```
OMG we're almost done!  Just one more thing.

Right now a Calendar can only print itself out using the monthly format, like this:

February
         1   2   3   4   5
 6   7   8   9  10  11  12
13  14  15  16  17  18  19
20  21  22  23  24  25  26
27  28

But we paid our previous developers to create a new formatter to look like this:

2017-01-03
 - Event 1 at Jan 3, 2017 4:04:00 AM (ends at Jan 3, 2017 5:04:00 AM)
 - Event 2 at Jan 3, 2017 5:05:00 AM (ends at Jan 3, 2017 6:05:00 AM)

But it's not "wired up" yet - can you make it so that calendars can be formatted in both ways?
```

1. Look through the codebase.
1. Find the related violation of the Dependency Inversion Principle.
1. Fix it.
1. Run all tests in the `App.Tests` directory and make sure they pass.

If you need a clue as to where it is in the domain, scroll to the bottom.

```
SCROLL FOR HINTS (if you need them)...


    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
  -    -
  \    /
   \  /
    \/

Are you _sure_ you need hints?

    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
    | |
  -    -
  \    /
   \  /
    \/

```
## Hints

Only read these if you are totally stuck and the test output isn't helping.

### SRP

The Single Responsibility Principle violation appears in the highlighted part of the domain:

<details>
  <summary>Click to reveal image</summary>
  
  ![](./images/solid-checkpoint-srp.png?raw=true)
</details>

### OCP

The Open/Closed Principle violation appears in the highlighted part of the domain:

<details>
  <summary>Click to reveal image</summary>
  
  ![](./images/solid-checkpoint-ocp.png?raw=true)
</details>

### LSP

The Liskov Substitution Principle violation appears in the highlighted part of the domain:

<details>
  <summary>Click to reveal image</summary>
  
  ![](./images/solid-checkpoint-lsp.png?raw=true)
</details>

### ISP

The Interface Segregation Principle violation appears in the highlighted part of the domain:

<details>
  <summary>Click to reveal image</summary>
  
  ![](./images/solid-checkpoint-isp.png?raw=true)
</details>

### DIP

The Dependency Inversion Principle violation appears in the highlighted part of the domain:

<details>
  <summary>Click to reveal image</summary>
  
  ![](./images/solid-checkpoint-dip.png?raw=true)
</details>

