[<AutoOpen>]
module EulerF.Helpers

let Memoize f = 
    let cache = ref Map.empty
    fun input -> 
        if Map.containsKey input !cache then (!cache).[input]
        else 
            let answer = f input
            cache := Map.add input answer !cache
            answer

let private IsPrimeAux = 
    let naive n = 
        if n <= 1 then false
        else 
            let sqrtN = 
                float n
                |> sqrt
                |> int
            [ 2..sqrtN ]
            |> List.exists (fun i -> n % i = 0)
            |> not
    Memoize naive

let IsPrime n = IsPrimeAux n
let IsPalindrome str = str = new string(Array.rev (str.ToCharArray()))

let private DivisorsAux = 
    let naive n = 
        seq { 
            yield 1.0
            for i in 2.0..sqrt n do
                if n % i = 0.0 && n / i = i then yield i
                else 
                    if n % i = 0.0 then 
                        yield i
                        yield n / i
        }
    Memoize naive

let Divisors n = DivisorsAux n
let DivisorCount n = Divisors n |> Seq.length
let DivisorSum n = Divisors n |> Seq.sum

let private FibonacciBigIntAux = 
    let naive n = 
        if n <= 1I then 1I
        else 
            let rec loop prev cur i = 
                if i = n then cur
                else loop cur (prev + cur) (i + 1I)
            loop 1I 1I 1I
    Memoize naive

let FibonacciBigInt n = FibonacciBigIntAux n
