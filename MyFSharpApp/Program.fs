// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello, I'm Kailash Karki"
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

// Define the 5 teams with their coaches and stats
let teams = [
    { Name = "San Antonio Spurs"; Coach = { Name = "Gregg Popovich"; FormerPlayer = true }; Stats = { Wins = 2305; Losses = 1562 } }
    { Name = "Boston Celtics"; Coach = { Name = "Joe Mazzulla"; FormerPlayer = true }; Stats = { Wins = 3634; Losses = 2480 } }
    { Name = "Los Angeles Lakers"; Coach = { Name = "JJ Redick"; FormerPlayer = true }; Stats = { Wins = 3550; Losses = 2454 } }
    { Name = "Utah Jazz"; Coach = { Name = "Will Hardy"; FormerPlayer = false }; Stats = { Wins = 2177; Losses = 1855 } }
    { Name = "Phoenix Suns"; Coach = { Name = "Mike Budenholzer"; FormerPlayer = false }; Stats = { Wins = 2429; Losses = 2096 } }
]

// Filter the list of successful teams
let successfulTeams = teams |> List.filter (fun team -> team.Stats.Wins > team.Stats.Losses)

// Map the list to calculate the success percentage for each team
let successPercentages = successfulTeams |> List.map (fun team ->
    let wins = float team.Stats.Wins
    let losses = float team.Stats.Losses
    let successPercentage = (wins / (wins + losses)) * 100.0
    (team.Name, successPercentage)
)

// Print the list of successful teams with their success percentages
successPercentages |> List.iter (fun (teamName, successPercentage) ->
    printfn "Team: %s, Success Percentage: %.2f%%" teamName successPercentage
)
