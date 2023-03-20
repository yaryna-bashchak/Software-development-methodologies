# Lab2 - Doubly Linked List
### Project structure

```
Software-development-methodologies   
│
└───lab1
│   │   ...
|
└───lab2
│   │   Program.cs
│   │   DoublyLinkedList.cs
│   │   Node.cs
│   │   lab2.csproj
|
└───lab2_tests
│   │   UnitTests_DoublyLinkedList.cs
│   │   Usings.cs
│   │   lab2_tests.csproj
│
└───<other folders will be added later>
│
└───...
```
 
---

### About project

This program implements a doubly linked list of chars without using built-in lists or arrays.
There are such methods as
- append (by value)
- length
- insert (by value and index)
- delete (by index)
- deleteAll (by value)
- get (by index)
- clone
- reverse
- findFirst/findLast (by value)
- clear
- extend (by another list)

Try to run example of usage (see "How to run").

Or write your usage by changing the main function in <code>Program.cs</code>.
And if all input data is valid you the result will be written in the console. Else you will see error message.

---

### Calculation of the number of my variat and description
Number of book: 1103

Remainder of dividing the number of the book by 4: **3**

So my task is next:

- **first** implementation - list based on **built-in** arrays/lists
- **second** - refactor it by making **doubly linked list** without using built-in lists or arrays

---

### How to run
- first of all, you need to install [.Net 7.0](https://dotnet.microsoft.com/en-us/download) (if you do not already have it)
- open previous **folder "Software-development-methodologies"** (that contains folders: lab2 and lab2_tests) in [VS Code](https://code.visualstudio.com/download)
- install _C# extension_ (if you do not already have it)
<img src="https://user-images.githubusercontent.com/90560209/220602921-cdde3e17-3c4b-458c-bfd0-d0bf2fdd2529.png" height="80">

- write next commands in Terminal if you want to **run the program**

<code>$ cd lab2 </code>

<code>$ dotnet run </code>

![image](https://user-images.githubusercontent.com/90560209/226444825-9aa89d43-02e3-45d1-9e1e-f62dc54e556b.png)


- or next if you want to **run tests**

<code>$ dotnet test ./lab2_tests</code>

![image](https://user-images.githubusercontent.com/90560209/226453968-96e77690-379b-425e-ab0f-cb21a982a3dc.png)

---

### Commit with failed test

Link to my [failed test](https://github.com/yaryna-bashchak/Software-development-methodologies/actions/runs/4471636352/jobs/7856779115).

As you can see, 1 failed and 12 passed.

![image](https://user-images.githubusercontent.com/90560209/226445866-18a13bc1-8c6d-468d-801f-d9ead7cc0271.png)

---

### Висновки

Під час розроблення кожного нового методу для двобічно зв'язного списку, я, звісно, паралельно тестила їх власноруч, виводячи результати в консоль.
Саме під час цього процесу було усунено більшість недоліків і я думала, що цього вистачить.
Але, на моє здивування, написання unit-тестів таки допомогло знайти ще один недолік в програмі.
Справа в тому, що була написана окрема функція, яка перевіряла коректність введеного індексу,
тож в якому методі така перевірка була потрібна - там вона і виконувалася.
Спочатку вона працювала коректно, але потім я вирішила, що в методі insert може бути заданий індекс, який перевищує останній індекс списку на 1,
щоб можна було додати елемент в кінець списку, забувши, що цю ж перевірку також використовують методи delete або get, для яких такі умови не припустимі.
Цей баг показався потім на unit-тестах. Тому так, в моєму випадку написання цих тестів було корисне.
