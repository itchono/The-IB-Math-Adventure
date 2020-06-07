Module GlobalVariables
    'Global Variables that can be used throughout the entire application and are not limited to a single form.

    Public shrGamemode As Short
    'The game mode
    '1 (Math Studies), 2 (SL Math), 3 (HL Math), 4 (Hyper IB)

    Public shrUniversityTier, shrUniChoice As Short
    'The tier of university that the user can go to
    '1 to 5, with 5 being the best

    'The university that the user chooses
    '0 to 9

    Public strUserName As String
    'The username

    Public blnMaximize, blnCheat As Boolean
    'Used for determining whether to maximize or restore the window
    'Used to determine whether cheats are enabled

    Public sglGrade As Single
    'Percentage/Grade for evaluation in the game

    Public sglWindowFadeSpd As Single = 0.04
    'Adjustable fade speed for windows - fades @ 4% per second nominally, can be adjusted
    'The entire game runs using borderless windows to keep a flat design, so I needed to implement
    'Windows control myself

    Public blnTrackAch4(4) As Boolean
    'An array used to keep track of which achievements have been won
    'An array used to track achievement number 4 (A Little Bit of Everything)
End Module
