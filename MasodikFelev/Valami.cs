using System;
class Valami{

    const int N = 60;

    const int M = 30;







    static void Main(){
        Console.SetWindowSize(N, M);

        bool exit = false;
        int timer = 100;
        int babuX = N/2;
        int babuY = M/2;
        Console.SetCursorPosition(babuX, babuY);
        Console.Write('X');

        while(!exit){
            timer--;
            Thread.Sleep(100);
            Console.SetCursorPosition(0,0);
            Console.Write(timer);
            if ( Console.KeyAvailable ){
                    ConsoleKeyInfo pressed = Console.ReadKey(true); 
                    if (pressed.Key == ConsoleKey.Escape){
                        exit = true;
                    }
                    else if ( pressed.Key == ConsoleKey.UpArrow && babuY > 0){
                        Console.SetCursorPosition(babuX, babuY);
                        Console.Write(' ');
                        babuY--;
                        Console.SetCursorPosition(babuX, babuY);
                        Console.Write('X');
                    }
                    else if ( pressed.Key == ConsoleKey.DownArrow && babuY < M-1){
                        Console.SetCursorPosition(babuX, babuY);
                        Console.Write(' ');
                        babuY++;
                        Console.SetCursorPosition(babuX, babuY);
                        Console.Write('X');
                    }
                    else if ( pressed.Key == ConsoleKey.LeftArrow && babuX > 0){
                        Console.SetCursorPosition(babuX, babuY);
                        Console.Write(' ');
                        babuX--;
                        Console.SetCursorPosition(babuX, babuY);
                        Console.Write('X');
                    }
                    else if ( pressed.Key == ConsoleKey.RightArrow && babuX < N-1){
                        Console.SetCursorPosition(babuX, babuY);
                        Console.Write(' ');
                        babuX++;
                        Console.SetCursorPosition(babuX, babuY);
                        Console.Write('X');
                    }
            }
        }
        Console.ReadKey();

    }
}