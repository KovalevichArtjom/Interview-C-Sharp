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
