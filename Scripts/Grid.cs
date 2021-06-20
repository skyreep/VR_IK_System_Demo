using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Grid : MonoBehaviour
{
    private int width;
    private int height;
    private int[,] gridArray;

    public Grid(int width, int height)
    {
        this.width = width;
        this.height = height;

        gridArray = new int[width, height];

        Debug.Log(width + " " + height);

        for (int x = 0; x < gridArray.GetLength(0); x++;) {
            for (int y = 0; y < gridArray.GetLength(1); y++;) {
                UtilsClass.CreateWorldText();
            }
        }
    }
}
