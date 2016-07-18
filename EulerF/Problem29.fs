namespace EulerF

module Problem29 =
    let Solution =
        seq {
            for a in [2.0..1.0..100.0] do
                for b in [2.0..1.0..100.0] do
                    yield a ** b
        }
        |> Set.ofSeq
        |> Set.count