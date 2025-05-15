using Godot;
using System;

public partial class NewScript : Node
{
	public override void _Ready()
    {
        int[,] matrix = new int[10, 10];

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                matrix[i, j] = (i + 1) * (j + 1);
            }
        }

        GD.Print("\n\n@-------------------------Multiplication-Table-------------------------@");

        for (int i = 0; i < 10; i++)
        {
            string row = "";
            for (int j = 0; j < 10; j++)
            {
                row += matrix[i, j] + "\t";
            }
            GD.PrintRaw(row + "\n");
        }

        GD.Print("@----------------------------------------------------------------------@\n\n");
    }

    public override void _Process(double delta)
    {
    }
}
