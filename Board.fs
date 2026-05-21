module Board

open Types
open Utils
open System

let getSize difficulty =
    match difficulty with
    | Easy -> 4
    | Normal -> 6
    | Hard -> 8

let createBoard size =
    let pairCount = (size * size) / 2

    let words =
        [ "Apple"; "Banana"; "Orange"; "Grape"; "Peach"; "Cherry"; "Lemon"; "Melon"
          "Mango"; "Pear"; "Plum"; "Kiwi"; "Papaya"; "Coconut"; "Berry"; "Fig"
          "Guava"; "Lychee"; "Apricot"; "Avocado"; "Date"; "Durian"; "Olive"; "Pineapple"
          "Raspberry"; "Strawberry"; "Tomato"; "Watermelon"; "Lime"; "Tangerine"; "Dragonfruit"; "Passionfruit" ]

    let selectedWords =
        words
        |> List.take pairCount

    let cards =
        selectedWords
        |> List.collect (fun word ->
            [ { Value = word; Revealed = false; Matched = false }
              { Value = word; Revealed = false; Matched = false } ])
        |> shuffle

    cards

let printBoard (state : GameState) =
    Console.Clear()

    printfn "Attempts: %d" state.Attempts
    printfn ""

    for row in 0 .. state.Size - 1 do
        for col in 0 .. state.Size - 1 do
            let index = row * state.Size + col
            let card = state.Board[index]

            if card.Revealed || card.Matched then
                printf "| %-12s " card.Value
            else
                printf "| %-12d " (index + 1)
        printfn ""