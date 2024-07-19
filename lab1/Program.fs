// For more information see https://aka.ms/fsharp-console-apps
let names: string list = ["James"; "Robert"; "John"; "William"; "Michael"; "David"; "Richard"]


let filteredNames: string list =
    List.filter (fun name -> name.Contains("I", System.StringComparison.OrdinalIgnoreCase)) names


let concatenatedNames: string =
    List.fold (fun acc name -> acc +  name ) "" filteredNames


printfn "Concatenated names containing 'I': %s" concatenatedNames