// For more information see https://aka.ms/fsharp-console-apps
let names : string list = [" Charles"; "Babbage  "; "  Von Neumann  "; "  Dennis Ritchie  "]

let trimmedNames : string list = List.map (fun (name : string) -> name.Trim()) names

// Print the results
trimmedNames |> List.iter (printfn "%s")



