[<AutoOpen>]
module EulerF.Helpers

let IsPrime n = 
    if n <= 1 then false
    else 
        let sqrtN = 
            float n
            |> sqrt
            |> int
        [ 2..sqrtN ]
        |> List.exists (fun i -> n % i = 0)
        |> not

let IsPalindrome str = str = new string(Array.rev (str.ToCharArray()))

let Divisors n = 
    seq { 
        yield 1.0
        for i in 2.0..sqrt n do
            if n % i = 0.0 && n / i = i then yield i
            else 
                if n % i = 0.0 then 
                    yield i
                    yield n / i
    } 

let DivisorCount n = Divisors n |> Seq.length
let DivisorSum n = Divisors n |> Seq.sum
