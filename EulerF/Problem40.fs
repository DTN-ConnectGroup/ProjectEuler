module EulerF.Problem40

let FractionalPartSeq = 
    seq { 
        for i in 0..System.Int32.MaxValue do
            yield! (Helpers.Digits i |> Seq.rev)
    }

let NthDigit n = FractionalPartSeq |> Seq.item n

let Solution = 
    Seq.init 7 (fun i -> int <| 10.0 ** (float i))
    |> Seq.map NthDigit
    |> Seq.reduce (*) // a bit too fancy way to do it
