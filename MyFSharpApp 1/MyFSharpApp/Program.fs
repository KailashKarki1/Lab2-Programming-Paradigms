// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello I'm Kailash Karki"
type Coach = {
    Name: string
    FormerPlayer: bool
}

type Stats = {
    Wins: int
    Losses: int
}

type Team = {
    Name: string
    Coach: Coach
    Stats: Stats
}


let teams = [
    { Name = "San Antonio Spurs"; Coach = { Name = "Gregg Popovich"; FormerPlayer = true }; Stats = { Wins = 2305; Losses = 1562 } }
    { Name = "Boston Celtics"; Coach = { Name = "Joe Mazzulla"; FormerPlayer = true }; Stats = { Wins = 3634; Losses = 2480 } }
    { Name = "Los Angeles Lakers"; Coach = { Name = "JJ Redick"; FormerPlayer = false }; Stats = { Wins = 3550; Losses = 2454 } }
    { Name = "Utah Jazz"; Coach = { Name = "Will Hardy"; FormerPlayer = true }; Stats = { Wins = 2177; Losses = 1855 } }
    { Name = "Phoenix Suns"; Coach = { Name = "Mike Budenholzer"; FormerPlayer = true }; Stats = { Wins = 2429; Losses = 2096 } }
]

teams |> List.iter (fun team -> 
    printfn "Team: %s, Coach: %s, FormerPlayer: %b, Wins: %d, Losses: %d" 
        team.Name team.Coach.Name team.Coach.FormerPlayer team.Stats.Wins team.Stats.Losses)

