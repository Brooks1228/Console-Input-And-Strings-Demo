Module stringDemo2
    'Brooks Keller
    'more string functions
    '9/20/23
    Sub main()
        Dim name, input1, input2, input3 As String
        Console.Write("please enter your name -> ")
        name = Console.ReadLine() 'read from the console everything until enter key hit
        Console.WriteLine("hello " & name & "!!") 'concatonate the string literal (i added my own exclamation points for expression)
        Console.WriteLine()

        Console.WriteLine("lets play a game where you say something and i ""shout"" it back!")
        Console.Write("what should i ""shout""? -> ")
        input1 = Console.ReadLine
        Console.WriteLine(input1.ToUpper) 'the ToUpper method is a string function to make all text caps
        Console.WriteLine()

        Console.WriteLine("that was fun. lets do it again!")
        Console.Write("now, what should i ""shout""? -> ")
        input2 = Console.ReadLine
        Console.WriteLine(input2.ToUpper)
        Console.WriteLine()

        Console.WriteLine("i like this! lets do it again")
        Console.Write("one more time, what should i ""shout""? -> ")
        input3 = Console.ReadLine
        Console.WriteLine(input3.ToUpper)
        Console.WriteLine()

        Console.WriteLine("oh that was fun! let me try ""whispering"" all of back now")
        Console.WriteLine(input1.ToLower) 'the ToLower method is a string function to make all text lowercase
        Console.WriteLine(input2.ToLower)
        Console.WriteLine(input3.ToLower)

        Console.WriteLine()
        Console.WriteLine("Thanks for the fun...Have a great day!!")
        Console.ReadKey()
    End Sub
End Module
