module EulerF.Problem48

let Solution = 
    [ 1..1000 ]
    |> List.sumBy (fun x -> (bigint x) ** x)
    |> (fun x -> x % 10000000000I)
