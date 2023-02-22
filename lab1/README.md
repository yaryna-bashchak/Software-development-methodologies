# Quadratic Equation Solver
### Project structure

```
Software-development-methodologies   
│
└───lab1
│   │   Program.cs
│   │   QuadraticEquationSolver.cs
│   │   Validation.cs
│   │   coefficients.txt
│   │   lab1.csproj
│
└───<other folders will be added later>
│
└───...
```
 
---

### About project

This program can solve quadratic equations. There are **two ways** to specify your equation:
1) write the three coefficients (a ≠ 0, b, c) in the **console**;
2) provide a **file** with these coefficients (see below for more information on file format).

If all input data is valid, the program will write in the console the equation, number of roots and roots themselves, if any exist.

Else you will see error message.

---

### How to run
- first of all, you need to install [.Net 7.0](https://dotnet.microsoft.com/en-us/download) (if you do not already have it)
- open this folder in [VS Code](https://code.visualstudio.com/download)
- install _C# extension_ (if you do not already have it)
<img src="https://user-images.githubusercontent.com/90560209/220602921-cdde3e17-3c4b-458c-bfd0-d0bf2fdd2529.png" height="80">

- write next command in Terminal if you want to run **interactive mode**

<code>$ dotnet run</code>

or next to run **non-interactive (file) mode** (you also can create your own file and use it)

<code>$ dotnet run coefficients.txt</code>

---

### File Format for non-interactive mode

- the file must contain 3 numbers: a b c, separated by one space;
- "." is expected as a decimal character;
- the last coefficient (c) is followed by a newline character (\n), and the file ends there.

"1 2.5 3\n" - _correct_

~~"1 2 3 4\n"~~ - _incorrect_

~~"1 2\n"~~ - _incorrect_

~~"1 2 abc\n"~~ - _incorrect_

---

### Exapmles
- **interactive mode**

<img src="https://user-images.githubusercontent.com/90560209/220610944-43042aab-2cf6-4363-b1a6-c17f00f53074.png" height="160"> <img src="https://user-images.githubusercontent.com/90560209/220611818-e0c4df64-9695-46c3-9646-8ee67f18bea0.png" height="160">

<img src="https://user-images.githubusercontent.com/90560209/220611060-a7179a51-90c3-4cfa-b2b6-a1e8fbcc43da.png" height="130"> <img src="https://user-images.githubusercontent.com/90560209/220611428-fcb00c72-52d2-42aa-bd85-fa945f225f19.png" height="130">

- **non-interactive mode**

сontents of the file "1 -7 10\n"

![image](https://user-images.githubusercontent.com/90560209/220614347-17d1e81c-9e54-4437-b07e-318df95d1c35.png)

сontents of the file "1 -7\n"

![image](https://user-images.githubusercontent.com/90560209/220614661-f0495595-4189-45a7-b0a7-aa8dcb606d55.png)

сontents of the file "1 abc 10\n"

![image](https://user-images.githubusercontent.com/90560209/220614974-7e8a58df-80bb-4902-8414-8f9646e2d487.png)

сontents of the file ""

![image](https://user-images.githubusercontent.com/90560209/220615167-74019e68-0ab3-49a9-a354-3af967dd3d02.png)

file does not exist

![image](https://user-images.githubusercontent.com/90560209/220615242-ada2b596-b80d-4bdc-a99b-d974dec1a8af.png)

---

### Revert-commit
