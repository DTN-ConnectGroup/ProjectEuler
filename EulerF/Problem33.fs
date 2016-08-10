module EulerF.Problem33

let rec gcd a b = 
    match a, b with
    | 0, b -> b
    | a, 0 -> a
    | a, b -> gcd b (a % b)

type Fraction = 
    { Num : int
      Den : int }

let Fr(x, y) = 
    { Num = x
      Den = y }

let multiply f1 f2 = 
    { Num = f1.Num * f2.Num
      Den = f1.Den * f2.Den }

let simplify frac = 
    let d = gcd frac.Num frac.Den
    let newNum = frac.Num / d
    let newDen = frac.Den / d
    { Num = newNum
      Den = newDen }

let rec digits x = 
    let ones = x % 10
    let tens = (x - ones) / 10
    tens, ones

let areEqual f1 f2 = 
    let f1 = simplify f1
    let f2 = simplify f2
    f1.Num = f2.Num && f1.Den = f2.Den

let isOne f = 
    let inValid = f.Den <> 0
    let actualcheck = f.Num = f.Den
    inValid && actualcheck

let separateFraction f = 
    let numOnes, numTens = digits f.Num
    let denOnes, denTens = digits f.Den
    let fstPair = Fr(numOnes, denOnes), Fr(numTens, denTens)
    let sndPair = Fr(numOnes, denTens), Fr(numTens, denOnes)
    fstPair, sndPair

let testPair mainFraction pair = 
    let fstTest = isOne (fst pair) && (areEqual (snd pair) mainFraction)
    let sndTest = isOne (snd pair) && (areEqual (fst pair) mainFraction)
    fstTest || sndTest

let isCurious frac = 
    let fstPair, sndPair = separateFraction frac
    let fstTest = testPair frac fstPair
    let sndTest = testPair frac sndPair
    fstTest || sndTest

let Solution = 
    (seq { 
         for d in 11..99 do
             for n in 11..d do
                 if d <> n then yield Fr(n, d)
     }
     |> Seq.filter isCurious
     |> Seq.fold multiply (Fr(1, 1))
     |> simplify).Den
