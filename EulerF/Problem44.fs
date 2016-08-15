module EulerF.Problem44

let isPentagonal (y:int64) =
    let y = float y
    let x = ((sqrt (24. * y + 1.)) + 1.) / 6.
    x % 1. = 0.

let PentagonalsAux =
    let rec loop n = 
        seq {
            yield  n * (3L * n - 1L) / 2L
            yield! loop (n+1L)
        }
    loop 1L

let Pentagonals = PentagonalsAux |> Seq.take 10000

let Solution = 
    seq {
        for i in Pentagonals do 
            for j in Pentagonals do 
                if isPentagonal (i+j) && isPentagonal (abs (i-j)) then yield abs (i-j)
    } |> Seq.item 1