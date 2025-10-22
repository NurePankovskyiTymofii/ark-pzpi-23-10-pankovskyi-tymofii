//<<<<<<<<<<<<<B.1>>>>>>>>>>>>>>
// Функція обчислення квадрату числа
let square x = x * x

// Використання чистих функцій підвищує читабельність і мінімізує помилки
let numbers = [1; 2; 3; 4; 5]
let squares = List.map square numbers
printfn "Квадрати чисел: %A" squares

//<<<<<<<<<<<<<B.2>>>>>>>>>>>>>>
// Модуль для математичних операцій
module MathOperations =
    let square x = x * x
    let cube x = x * x * x

// Використання модуля
let num = 3
printfn "Квадрат: %d, Куб: %d" (MathOperations.square num) (MathOperations.cube num)

//<<<<<<<<<<<<<B.3>>>>>>>>>>>>>>
// Функція для обчислення факторіалу
let rec factorial n =
    if n <= 1 then 1
    else n * factorial (n - 1)

// Використання правильно вирівняних блоків підвищує читабельність
let result = factorial 5
printfn "Факторіал 5 = %d" result


//<<<<<<<<<<<<<B.4>>>>>>>>>>>>>>
// Змінні та функції у camelCase
let userName = "Alice"
let calculateAge birthYear currentYear = currentYear - birthYear

// Типи та модулі у PascalCase
type Person = { Name: string; Age: int }

module Utils =
    let greet person = printfn "Hello, %s!" person.Name

// Використання
let alice = { Name = userName; Age = calculateAge 1990 2025 }
Utils.greet alice


//<<<<<<<<<<<<<B.5>>>>>>>>>>>>>>
// Функція обчислює суму елементів списку
let sumList lst = List.sum lst

(* Логіка: використання вбудованої функції List.sum для
   ефективного підсумовування чисел у списку без циклів *)
let numbers_ = [1; 2; 3; 4]
let total = sumList numbers_
printfn "Сума = %d" total


//<<<<<<<<<<<<<B.6>>>>>>>>>>>>>>
/// Обчислює факторіал числа n
/// <param name="n">Ціле число</param>
/// <returns>Факторіал числа n</returns>
let rec factorial_ n =
    if n <= 1 then 1
    else n * factorial_ (n - 1)

printfn "Факторіал 5 = %d" (factorial_ 5)


//<<<<<<<<<<<<<B.7>>>>>>>>>>>>>>
// Правильне форматування та іменування у F#
module Calculator =
    /// Додає два числа
    let addNumbers x y = x + y

// Використання
let result_ = Calculator.addNumbers 5 7
printfn "Сума = %d" result_


//<<<<<<<<<<<<<B.8>>>>>>>>>>>>>>
// Модуль з функцією для тестування
module Math =
    let square x = x * x

// Простий юніт-тест
open NUnit.Framework

[<Test>]
let ``Square of 3 should be 9`` () =
    Assert.AreEqual(9, Math.square 3)


//<<<<<<<<<<<<<B.9>>>>>>>>>>>>>>
// Використання Fantomas для автоматичного форматування
let numbers = [1;2;3;4;5]
let squares = List.map (fun x -> x * x) numbers

printfn "Квадрати: %A" squares


//<<<<<<<<<<<<<B.10>>>>>>>>>>>>>>
// Поганий приклад
let f x y = x*y + x - y    // нечітке іменування, відсутні коментарі

// Хороший приклад
/// Обчислює суму квадрата x та куба y
let calculate x y =
    let squareX = x * x
    let cubeY = y * y * y
    squareX + cubeY

printfn "%d" (calculate 2 3)


//<<<<<<<<<<<<<B.11>>>>>>>>>>>>>>
// Практикуй написання чистих функцій
let isEven n = n % 2 = 0

// Використовуй модулі для організації
module ListUtils =
    let sumList lst = List.sum lst
    let evenNumbers lst = List.filter isEven lst

printfn "Парні числа: %A" (ListUtils.evenNumbers [1..10])


//<<<<<<<<<<<<<B.12>>>>>>>>>>>>>>
// Посилання на ресурси (у коментарях)
/// Офіційний стиль-код F#: https://learn.microsoft.com/en-us/dotnet/fsharp/style-guide/
/// Практика та поради: https://fsharpforfunandprofit.com/

