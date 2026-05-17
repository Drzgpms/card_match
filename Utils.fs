module Utils

open System

let rand = Random()

// List Shuffle
let shuffle list =
    list
    |> List.sortBy (fun _ -> rand.Next())

// Input Safety Handling
let rec readInput () =
    let input = Console.ReadLine().Trim().ToLower()

    match input with
    | "q"
    | "quit"
    | "exit" ->
        printfn "Game terminated."
        Environment.Exit(0)
        0

    | _ ->
        match Int32.TryParse(input) with
        | true, value -> value
        | false, _ ->
            printf "Invalid input. Try again: "
            readInput()