open System.IO
let getDirsAndCreationTimes=
    let directories= Directory.EnumerateDirectories "c:\\"
    let directoriesInfo= directories|>Seq.map( fun(dir:string)-> dir|>DirectoryInfo)
    let nameDatePairs= directoriesInfo|> Seq.map(fun dir->(dir.Name,dir.CreationTime))
    let mapOfpairs= nameDatePairs|>Map.ofSeq
    let output=mapOfpairs|> Map.map(fun key value->  (System.DateTime.Today-value).Days)
    output
let output= getDirsAndCreationTimes




