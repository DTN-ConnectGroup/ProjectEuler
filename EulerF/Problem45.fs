module EulerF.Problem45

let isPentagonal (y : int64) = 
    let y = float y
    let x = ((sqrt (24. * y + 1.)) + 1.) / 6.
    x % 1. = 0.

// As it happens, all Hexagonal numbers are Triangles
let Hexagonals = 
    let rec loop n = 
        seq { 
            yield n * (2L * n - 1L)
            yield! loop (n + 1L)
        }
    loop 1L

let Solution = 
    Hexagonals
    |> Seq.filter isPentagonal
    |> Seq.item 2