 Hashtables
Hashing is a technique that is used to uniquely identify a specific object from a group of similar objects

## Challenge
New Implementation for the HashTable

## Approach & Efficiency
Lists actually have fast access. If we know the index of the information we want we can access that information in O(1) time. The reason why searching for a piece of data in a collection is O(N) isn’t because the list is slow, it’s just that we have to look through all N things in the collection.

## API

set

Arguments: key, value
Returns: nothing
This method should hash the key, and set the key and value pair in the table, handling collisions as needed.
Should a given key already exist, replace its value from the value argument given to this method.

get

Arguments: key
Returns: Value associated with that key in the table

contains

Arguments: key
Returns: Boolean, indicating if the key exists in the table already.
keys

Returns: Collection of keys

hash

Arguments: key
Returns: Index in the collection for that key