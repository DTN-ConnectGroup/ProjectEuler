module EulerF.Problem30

let fifthPower x = x * x * x * x * x

let rec digits x = 
    seq { 
        let single = x % 10
        yield single
        match ((x - single) / 10) with
        | 0 -> ()
        | n -> yield! digits n
    }

let sumOfDigitPowers x = 
    digits x
    |> Seq.map fifthPower
    |> Seq.sum

let isSumOfPowers x = x = (sumOfDigitPowers x)

let Solution = 
    seq { 2..1000000 }
    |> Seq.filter isSumOfPowers
    |> Seq.sum
