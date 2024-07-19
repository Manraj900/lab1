// For more information see https://aka.ms/fsharp-console-apps

// Create a sequence of the first 700 positive integers
let sequence = seq {1 .. 700}

// Convert the sequence into a list
let numberList = Seq.toList sequence

// Filter out elements that are multiples of both 7 and 5
let filteredList = List.filter (fun x -> x % 35 = 0) numberList

// Sum all the filtered numbers using fold
let sumOfFilteredNumbers = List.fold (+) 0 filteredList

// Print the filtered list
printfn "Filtered list: %A" filteredList

// Print the sum of all numbers that are multiples of both 7 and 5
printfn "The sum of all numbers that are multiples of both 7 and 5 is %d" sumOfFilteredNumbers



