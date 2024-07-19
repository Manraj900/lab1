// For more information see https://aka.ms/fsharp-console-apps

let productOfList list =

    let rec productHelper acc = function
        | [] -> acc
        | head :: tail -> productHelper (acc * head) tail
    
   
    productHelper 1 list

let numbers = [5; 6; 7; 8; 9]
let product = productOfList numbers
printfn "Product of the list: %d" product



