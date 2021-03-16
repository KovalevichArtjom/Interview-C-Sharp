# Interview-C-Sharp
This repository is for storing material that has been passed and studied in preparation for interviews. 


## Question 10

Is List a thread-safe collection?

1. For read operations only 
2. Is't in any way 
3. For write operations only
4. Is in all cases

Answer: 2 <br/>
**FYI. It is safe to perform multiple read operations on a List<T>, but issues can occur if the collection is modified while it’s being read**

## Question 11

What is the difference between an operator in roles (when maintaining types) and an operator like?

1. The "as" operator is just syntactic sugar for "cast"
2. Cast changes the dynamic type, while as changes the static type
3. If an error occurs, the cast throws an InvalidCastException and the as operator returns null
4. On error, cast returns null, and the as operator throws an InvalidCastException

Answer: 3 <br/>
**FYI https://docs.microsoft.com/en-us/archive/blogs/ruericlippert/2163**

## Question 12

What is the algorithmic complexity for read and write operations for a Dictionary collection?

1. Read - О(1), Write - О(1)
2. Read - О(n), Write - О(1)
3. Read - О(n), Write - О(n)
4. Read - О(1), Write - О(n)

Answer: 1 <br/>
**FYI https://habr.com/ru/post/198104/**

## Question 13

What is the difference between the "ref" and "out" keywords?

1. The parameter with the ref keyword may not be initialized, and the parameter with the out keyword<br/> must be initialized before calling the method that uses these parameters.
2. The parameter with the out keyword may not be initialized, the parameter with the ref keyword must<br/> be initialized before calling the method that uses these parameters.
3. No difference.
4. The ref keyword is local to communicate only with value types (value types), and out is local to both<br/> value and reference types. 

Answer: 2 <br/>

## Question 15 
What is the difference between optional and named parametrs?

Answer: Optional parametrs allow you to omit function arguments, while named parametrs allow you to pass arguments by parametre name.

## Question 16
How are the String and StringBuilder classes different from each other?Why is this separation necessary?

Answer: An object of the String class is an immutable string. Whenever a method of the String class is executed, the system creates a new object in memory and allocates enough space for it. An object of the StringBuilder class is a dynamic string. When creating a string, the StringBuilder allocates more memory than is needed for this string, and adding any elements to it does not recreate the string. In the event that the allocated memory is not enough to add new elements, then the capacity of the object will be increased.

## Question 17
What is the difference between value and reference types?

Answer: value types are stored on the stack. A stack is a data structure that grows from bottom to top: each new item is pushed on top of the previous one. The lifetime of these types of variables is limited by their context. Physically, a stack is a certain area of memory in the address space. And reference types are stored on the heap, which is another area of memory that can be thought of as an unordered collection of different objects. When an object of a reference type is created on the stack, a reference to an address on the heap is pushed. When this object is no longer in use, the reference is destroyed and the memory on the heap is cleared. 
