﻿// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello I'm Kailash Karki"

type Cuisine =
    | Korean
    | Turkish

type MovieType =
    | Regular
    | IMAX
    | DBOX
    | RegularWithSnacks
    | IMAXWithSnacks
    | DBOXWithSnacks


type Activity =
    | BoardGame
    | Chill
    | Movie of MovieType
    | Restaurant of Cuisine
    | LongDrive of int * float


let calculateBudget (activity: Activity) =
    match activity with
    | BoardGame -> 0.0
    | Chill -> 0.0
    | Movie genre ->
        match genre with
        | Regular -> 12.0
        | IMAX -> 17.0
        | DBOX -> 20.0
        | RegularWithSnacks -> 12.0 + 5.0
        | IMAXWithSnacks -> 17.0 + 5.0
        | DBOXWithSnacks -> 20.0 + 5.0
    | Restaurant cuisine ->
        match cuisine with
        | Korean -> 70.0
        | Turkish -> 65.0
    | LongDrive (kilometers, fuelPerKilometer) ->
        float kilometers * fuelPerKilometer


let activities = [
    BoardGame
    Chill
    Movie Regular
    Movie IMAXWithSnacks
    Restaurant Korean
    LongDrive (50, 1.2)
]


activities |> List.iter (fun activity ->
    let cost = calculateBudget activity
    printfn "Activity: %A, Cost: %.2f CAD" activity cost
)
