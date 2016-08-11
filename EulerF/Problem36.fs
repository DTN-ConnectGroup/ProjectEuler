module EulerF.Problem36

let DecToBinary n =
    let rec loop n acc =
        match n with 
        | 0 | 1 -> (string n) + acc
        | _ -> 
            let bit = string <| n % 2 
            loop (n/2) (bit + acc)
    
    loop n ""

let IsPalindrome str = str = new string(Array.rev (str.ToCharArray()))

let IsDblBasePalindrome n = IsPalindrome (n.ToString()) && IsPalindrome (DecToBinary n)

let Solution = [1..999999] |> List.filter IsDblBasePalindrome |> List.sum 