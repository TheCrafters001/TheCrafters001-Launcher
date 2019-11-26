Module Module1

    Sub Main()
        Console.WriteLine("Hello! Welcome!")
        Console.Title = "Super Text Adventure!"
        Console.WriteLine("This is a Simple Super Text Adventure!")
        Console.WriteLine("It is not that super, it is just a short, simple")
        Console.WriteLine("text adventure.")
        Console.WriteLine("")
        Console.WriteLine("Press Any Key...")
        Console.WriteLine("")
        Console.ReadKey()
        Console.Beep()
        Console.Clear()

        Game()

    End Sub

    Sub game()
        ' This is the game code. Not that intresting.
        Console.WriteLine("Super Text Adventure!")
        Console.WriteLine("=====================")
        Console.WriteLine("You wake up in your bed. You think today will be a normal day.")
        Console.WriteLine("***")
        Console.WriteLine("Options: getup")
        Console.WriteLine("> ")
        Dim getup = Console.ReadLine()
        If getup.ToString = "getup" Then
            Console.WriteLine("You get out of your bed. You look around")
            Console.WriteLine("> lookaround")
            Console.WriteLine("Nothing out of the ordinary. Just your bed, door,")
            Console.WriteLine("and shoes.")
            Console.WriteLine("* * *")
            Console.WriteLine("Options:")
            Console.WriteLine("* use: ")
            Console.WriteLine("  * door ")
            Console.WriteLine("  * bed ")
            Console.WriteLine("  * shoes ")
            Dim dbfs = Console.ReadLine()
            If dbfs.ToString = "use door" Then
                Console.WriteLine("You open the door and head out to work. After you put on your shoes of course!")
                Console.WriteLine("Your day goes on pretty normally. But at the very end, you end up sleeping on your floor instead of your bed.")

            ElseIf dbfs.ToString = "use shoes" Then
                Console.WriteLine("You put on your shoes and go out shopping!")
                Console.WriteLine("Your day goes on pretty normally after that. But at the very end, you end up sleeping on your floor instead of your bed.")

            ElseIf dbfs.ToString = "use bed" Then
                Console.WriteLine("Eh, you did not want to go to work today anyways.")
            Else
                Console.WriteLine("You decide to do nothing today, not even go to work, or go shopping.")
                Console.WriteLine("The most intresting thing that happened today was that you thought of a game idea.")
            End If
        Else
            Console.WriteLine("Sorry, that is not an option. Please try again.")
            game()
        End If
        game_exit()
    End Sub

    Sub game_exit()
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("Thanks for playing!")
        Console.WriteLine("Game By TheCrafters001")
        Console.WriteLine("Built For TheCrafters001 Launcher.")
        Console.WriteLine("")
        Console.WriteLine("Press Any Key to Return to TheCrafters001 Launcher...")
        Console.WriteLine("Or press the X button at the top right to exit completely...")
        Console.WriteLine("Your choice.")

        Console.ReadKey(ConsoleKey.Enter)

        Dim launcher As New ProcessStartInfo
        launcher.FileName = ".\TheCrafters001 Launcher.exe"
        launcher.Arguments = ""
        launcher.UseShellExecute = True
        launcher.WindowStyle = ProcessWindowStyle.Normal
        Dim proc As Process = Process.Start(launcher)
        End
    End Sub

End Module
