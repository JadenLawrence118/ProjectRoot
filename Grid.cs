using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    [SerializeField] private int width, length;
    [SerializeField] private Tile tilePrefab;
    [SerializeField] private Transform cam;

    void Start() 
    {
        genGrid();   
    }

    void genGrid()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < length; y++)
            {  
                var spawnedTile = Instantiate(tilePrefab, new Vector3(x,y), Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";

                var isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);

                spawnedTile.Init(isOffset);
            }
        }

        cam.transform.position = new Vector3 ((float)width/2 - 0.5f, (float)length/2 - 0.5f,-10);

    }

}
