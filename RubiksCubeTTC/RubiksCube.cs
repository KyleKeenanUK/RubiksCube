using System;
using System.Collections.Generic;

public class RubiksCube
{
    private enum COLOURS
    {
        White = "W",
        Orange = "O",
        Green = "G",
        Red = "R",
        Blue = "B",
        Yellow = "Y"
    }

    private Dictionary<int, char> frontFace = new Dictionary<int, char>();
    private Dictionary<int, char> backFace = new Dictionary<int, char>();
    private Dictionary<int, char> rightFace = new Dictionary<int, char>();
    private Dictionary<int, char> leftFace = new Dictionary<int, char>();
    private Dictionary<int, char> upFace = new Dictionary<int, char>();
    private Dictionary<int, char> downFace = new Dictionary<int, char>();

    public RubiksCube()
    {
        CreateFaces();
    }

    private void CreateFaces()
    {
        frontFace = PopulateFace(COLOURS.Green);
        backFace = PopulateFace(COLOURS.Blue);
        rightFace = PopulateFace(COLOURS.Red);
        leftFace = PopulateFace(COLOURS.Orange);
        upFace = PopulateFace(COLOURS.White);
        downFace = PopulateFace(COLOURS.Yellow);
    }

    private Dictionary<int, char> PopulateFace(char colour)
    {
        return new Dictionary<int, char>()
        {
            {1, colour },
            {2, colour },
            {3, colour },
            {4, colour },
            {5, colour },
            {6, colour },
            {7, colour },
            {8, colour },
            {9, colour }
        }
    }

    public string "F, R, U, B, L, D, F', R', U', B', L', D'"
    /*
     F = Front face 
     R = Right face
     U = Up face
     B = Back face
     L = Left face
     D = Down face
     Adding a ' makes it go in the other direction
     */
}

