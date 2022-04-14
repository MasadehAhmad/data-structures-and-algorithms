# Stacks and Queues
A stack is a data structure that consists of Nodes. Each Node references the next Node in the stack, but does not reference its previous.
A Queue is a linear structure which follows a particular order in which the operations are performed. The order is First In First Out (FIFO).

## Challenge
Using a Linked List as the underlying data storage mechanism, implement both a Stack and a Queue

Node

Create a Node class that has properties for the value stored in the Node, and a pointer to the next node.

Stack

Create a Stack class that has a top property. It creates an empty Stack when instantiated.

This object should be aware of a default empty value assigned to top when the stack is created.

The class should contain the following methods:

push

Arguments: value

adds a new node with that value to the top of the stack with an O(1) Time performance.

pop

Arguments: none

Returns: the value from node from the top of the stack

Removes the node from the top of the stack

Should raise exception when called on empty stack

peek

Arguments: none

Returns: Value of the node located at the top of the stack

Should raise exception when called on empty stack

is empty

Arguments: none

Returns: Boolean indicating whether or not the stack is empty.

Queue

Create a Queue class that has a front property. It creates an empty Queue when instantiated.

This object should be aware of a default empty value assigned to front when the queue is created.

The class should contain the following methods:

enqueue

Arguments: value

adds a new node with that value to the back of the queue with an O(1) Time performance.

dequeue

Arguments: none

Returns: the value from node from the front of the queue

Removes the node from the front of the queue

Should raise exception when called on empty queue

peek

Arguments: none

Returns: Value of the node located at the front of the queue

Should raise exception when called on empty stack

is empty

Arguments: none

Returns: Boolean indicating whether or not the queue is empty


## Approach & Efficiency
All method have Complexity O(1) Time and Space 

## API
Stack :

1. Push - Nodes or items that are put into the stack are pushed
2. Pop - Nodes or items that are removed from the stack are popped. When you attempt to pop an empty stack an exception will be raised.
3. Peek - When you peek you will view the value of the top Node in the stack. When you attempt to peek an empty stack an exception will be raised.
4. IsEmpty - returns true when stack is empty otherwise returns false.

Queue :

1. Enqueue - Nodes or items that are added to the queue.

2. Dequeue - Nodes or items that are removed from the queue. If called when the queue is empty an exception will be raised.

3. Peek - When you peek you will view the value of the front Node in the queue. If called when the queue is empty an exception will be raised.

4. IsEmpty - returns true when queue is empty otherwise returns false.