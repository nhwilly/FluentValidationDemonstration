# FluentValidationDemonstration

This is a demonstration project to show the differences in using FluentValidation in Blazor, enabled by various packages.  The one most focused on is Blazilla a fork of Blazored.FluentValidation with upgrades.

The issue that drove this is that Blazor InteractiveServer rendering mode is not populating the `<ValidationMessage For...>` properly while the web assembly version works fine.

The same razor component, view model and validator are used, but with different rendering mode attributes.

The behavior should be the same in all modes, but it is not.
