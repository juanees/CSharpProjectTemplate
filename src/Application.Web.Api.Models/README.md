Contains your service’s REST resource types (or models).

I separate these into their own class library just to make unit testing a little easier. 
But remember that the client/caller never gets this DLL (i.e., you don’t share resource type definitions in REST services).