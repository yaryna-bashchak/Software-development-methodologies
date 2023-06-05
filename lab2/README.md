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
- run the following command to install all needed packages
<code>$ dotnet restore</code>

- write next commands in Terminal if you want to **run the program**

<code>$ cd lab2 </code>

<code>$ dotnet run </code>

![image](https://user-images.githubusercontent.com/90560209/226444825-9aa89d43-02e3-45d1-9e1e-f62dc54e556b.png)

- or next if you want to **run tests** (if you have trobles with running the tests do steps below)

<code>$ dotnet test ./lab2_tests</code>

![image](https://user-images.githubusercontent.com/90560209/226453968-96e77690-379b-425e-ab0f-cb21a982a3dc.png)

#### If you have errors when running the tests, it's probably because you don't have the NUnit packages installed (even after restore).

Follow the next steps:

- install _NuGet Gallery_ extention (if you do not already have it)

<img src="https://user-images.githubusercontent.com/90560209/226548216-92ceeca0-8f9a-4e59-a023-e5f2713fe34b.png" height="80">

- open NuGet Gallery

![image](https://user-images.githubusercontent.com/90560209/226548521-a836523e-d625-4046-89d5-ee967a23aa14.png)

- find and install next 4 packages (choose install only for **lab2_tests.csproj**)

Microsoft.NET.Test.Sdk

<img src="https://user-images.githubusercontent.com/90560209/226549915-451e98c4-5ad7-4f0d-bf81-af73be8b0d06.png" height="150"> <img src="https://user-images.githubusercontent.com/90560209/226549405-1732dcdd-67c8-4b10-abcb-2987bc097b84.png" height="150">

NUnit

<img src="https://user-images.githubusercontent.com/90560209/226549367-db191e82-aeb9-4a6b-a367-799df4bbeb8b.png" height="150"> <img src="https://user-images.githubusercontent.com/90560209/226549385-1a788edf-1b63-4f34-91a3-8bb412ee1e60.png" height="150">

NUnit3TestAdapter

<img src="https://user-images.githubusercontent.com/90560209/226550092-58844f05-8d9f-4719-b7ff-e172f19f2fae.png" height="150"> <img src="https://user-images.githubusercontent.com/90560209/226550098-ad62ab22-8af2-4744-aafa-67cec4a3d7dd.png" height="150">

NUnit.Analyzers

<img src="https://user-images.githubusercontent.com/90560209/226550189-a8e1ab6d-2ccd-489f-a5a4-f697e0f9f709.png" height="150"> <img src="https://user-images.githubusercontent.com/90560209/226550201-536c8bfc-b97f-4855-84c0-7cd1bdf12b3d.png" height="150">

- try to run tests again by command

<code>$ dotnet test ./lab2_tests</code>

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
