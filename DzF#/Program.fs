// Дополнительные сведения о F# см. на http://fsharp.org
// Дополнительную справку см. в проекте "Учебник по F#".
open System;
let solveQuadratic a b c =
  let disc = b * b - 4.0 * a *c
  let calc op = ((op (-b) (sqrt disc)) / (2.0*a))  
  calc (+), calc(-)
Console.Write("Введите параметр a: ");
let a = Console.ReadLine() |> float
Console.Write("Введите параметр b: ");
let b = Console.ReadLine() |> float
Console.Write("Введите параметр c: ");
let c = Console.ReadLine() |> float
Console.WriteLine("Вы ввели уравнение: {0}*x^2 + {1}*x + {2} = 0", a, b, c); 
Console.Write("Ответ: ");
solveQuadratic a b c |> printfn "%A"
Console.ReadKey() |> ignore
[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0// возвращение целочисленного кода выхода
