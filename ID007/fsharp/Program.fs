let [n; x; y] = stdin.ReadLine().Split(" ") |> Array.toList |> List.map int
let mutable cnt = 0
for i = 1 to n do
    if i % x = 0 || i % y = 0 then cnt <- cnt + 1
printfn "%d" cnt