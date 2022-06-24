# Hashmap LEFT JOIN
LEFT JOIN returns all rows from the left table, even if there are no matches in the right table. This means that if the ON clause matches 0 (zero) records in the right table; the join will still return a row in the result, but with NULL in each column from the right table.

## Challenge
Write a function that LEFT JOINs two hashmaps into a single data structure.

- Write a function called left join
- Arguments: two hash maps
    - The first parameter is a hashmap that has word strings as keys, and a synonym of the key as values.
    - The second parameter is a hashmap that has word strings as keys, and antonyms of the key as values.
- Return: The returned data structure that holds the results is up to you. It doesn’t need to exactly match the output below, so long as it achieves the LEFT JOIN logic

## Approach & Efficiency
The Compexity :
- O(n) for the time because the nested Loop
- O(n) for the space

## Solution
```
   public List<List<string>> LeftJoinMethod(Hashtable left,Hashtable right)
        {
            if ((left == null && right == null) || (left == null)) { return null; }
            List<List<string>> List = new List<List<string>>();
            foreach (DictionaryEntry item in left)
            {
                List.Add(new List<string> { item.Key.ToString(), item.Value.ToString() });
            }
            if (right == null)
            {
                return List;
            }
            foreach (DictionaryEntry item in right)
            {
                var s = List.Find(x => x[0] == item.Key.ToString());
                if(s != null)
                s.Add(item.Value.ToString());
            }
            return List;

        }
```
