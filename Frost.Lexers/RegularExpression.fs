module Frost.Lexers

type RE = 
    | CharExpr of char
    | Concatenation of RE * RE
    | Alternation of RE * RE
    | Closure of RE

let (>>) r1 r2 = Concatenation(r1, r2)
let (/) r1 r2 = Alternation(r1, r2)
let (!!) r = Closure r

(*
let m = CharExpr '1'
let n = CharExpr '2'
let r = Alternation(Concatenation(Closure m, n), Closure(Alternation(m, n)))
let r1 = ((!! m) >> n) / (!! (m / n))
*)

