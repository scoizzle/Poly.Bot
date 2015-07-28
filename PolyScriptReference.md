PolyBot Reference
=================

Flow Control
------------

### Iterative for loop
`for(i; 1 -> 5) {
	
}`

### Foreach loop
`foreach( Item in List ) {
	
}`

Data structures
---------------

### Lists

#### Appending to a list
`List + Item;`

Managing module data
--------------------

### Getting the module context
`Mod = Bot.Module.ModuleName;`

### Functions
All of the functions in your module are available through the module context. First, get the module context. Then, call your function.
`Mod = Bot.Module.Weather;
Result = Mod.QueryAPI('/forecast/q/' + State + '/' + City + '.json');`