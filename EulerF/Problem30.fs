namespace EulerF


module Problem30 =
    let private fifthPower x = x * x * x * x * x

    let rec private digits x =
        seq {
            let single = x % 10

            yield single

            match((x - single) / 10) with 
            | 0 -> ()
            | n -> yield! digits n
        }

    let private sumOfDigitPowers x =
        digits x
        |> Seq.map fifthPower
        |> Seq.sum

    let private isSumOfPowers x = x = (sumOfDigitPowers x)

    let Solution =
        seq { 2..1000000 }
        |> Seq.filter isSumOfPowers
        |> Seq.sum
