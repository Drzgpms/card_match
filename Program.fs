open Types
open Board
open Game

let rec selectDifficulty () =
    printfn "E / Easy   -> 4x4"
    printfn "N / Normal -> 6x6"
    printfn "H / Hard   -> 8x8"
    printf "Select difficulty: "

    let input =
        System.Console.ReadLine().Trim().ToLower()

    match input with
    | "e"
    | "easy" ->
        Easy

    | "n"
    | "normal" ->
        Normal

    | "h"
    | "hard" ->
        Hard

    | _ ->
        printfn "Invalid difficulty."
        printfn ""
        selectDifficulty ()

[<EntryPoint>]
let main argv =

    let difficulty = selectDifficulty ()

    let size = getSize difficulty

    let initialState =
        {
            Board = createBoard size
            Size = size
            Attempts = 0
        }

    gameLoop initialState

    0