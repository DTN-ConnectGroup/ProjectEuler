module EulerF.Problem35

let Rotate n = n / 10 + (n % 10 * (int <| 10.0 ** float (n.ToString().Length - 1)))

let FindRotations n = 
    let rec loop n count = 
        seq { 
            yield n
            if count > 1 then yield! (loop (Rotate n) (count - 1))
        }
    loop n (n.ToString().Length)

let AreAllRotsPrime n = 
    // These optimizations are not my idea !!
    //
    if n = 2 || n = 3 || n = 5 || n = 7 then true
    else 
        let str = n.ToString()
        let sleazyTest = 
            str.Contains("5") || str.Contains("0") || str.Contains("2") || str.Contains("4") || str.Contains("6") 
            || str.Contains("8")
        if sleazyTest then false
        else FindRotations n |> Seq.forall Helpers.IsPrime

let Solution = 
    [ 1..1000000 ]
    |> List.filter AreAllRotsPrime
    |> List.length
