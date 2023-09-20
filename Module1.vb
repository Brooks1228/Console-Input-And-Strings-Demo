Module Module1
    'Brooks Keller
    'String variables and input demo
    '9/20/23
    Sub Main()
        Dim name As String 'declare a variable to hold text
        Dim movieTitle1 As String
        Dim movieTitle2 As String
        Dim movieTitle3 As String = "Trolls World Tour" 'you cna initialize (give a value) to a variable when you create it
        Dim movieYear1, movieYear2 As String 'you can declare multiple variables of the same type on one line
        Dim movieYear3 = "2020"

        Console.Write("please enter your name -> ")
        name = Console.ReadLine() 'read from the console everything until enter key hit
        Console.WriteLine("hello " & name & "!!") 'concatonate the string literal (i added my own exclamation points for expression)

        Console.Write("please enter your first favorite movie of all time -> ") 'prompt user for input
        movieTitle1 = Console.ReadLine
        Console.Write("please enter the year it came out -> ")
        movieYear1 = Console.ReadLine()

        Console.Write("please enter your second favorite movie of all time -> ")
        movieTitle2 = Console.ReadLine
        Console.Write("please enter the year it came out -> ")
        movieYear2 = Console.ReadLine()

        'print the string. escape the quotes with an additional "
        Console.WriteLine("thank you! your top ""top 3"" movies of all time are listed below" & vbNewLine)

        'print a line of dashes for the top of the table
        Console.WriteLine("".PadRight(56, "-"))
        'uses a string formatter
        Console.WriteLine("| {0} | {1} | {2} |", "#", "title".PadRight(30), "year released".PadRight(15))
        'the above is the same as the below, which uses concatenation
        'Console.Writeline("| # | " & "title".padright(30) & " | " & "year released".padright (15) & " | ")
        Console.WriteLine("".PadRight(56, "-"))
        Console.WriteLine("| {0} | {1} | {2} |", "1", movieTitle1.PadRight(30), movieYear1.PadRight(15))
        Console.WriteLine("| {0} | {1} | {2} |", "2", movieTitle2.PadRight(30), movieYear2.PadRight(15))
        Console.WriteLine("| {0} | {1} | {2} |", "3", movieTitle3.PadRight(30), movieYear3.PadRight(15))
        Console.WriteLine("".PadRight(56, "-"))

        Console.ReadKey()
    End Sub

End Module
