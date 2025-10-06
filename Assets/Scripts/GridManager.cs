using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;


public class GridManager : MonoBehaviour
{
    [SerializeField] private int _width, _height;
    [SerializeField] private Tiles _preFab;
    [SerializeField] private Transform _camera;
    void Start()
    {

        createGrid();
    }



    void createGrid()
    {
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                // Instatiate(O que será instanciado, Onde será instanciado e para não mexer no eixo z)
                var spawnedTile = Instantiate(_preFab, new Vector2(x, y), Quaternion.identity);

                spawnedTile.name = $"Tile{x}:{y}";

                var isDifferent = (x % 2 != y % 2);
                spawnedTile.SetColor(isDifferent);
            }
        }
        _camera.position = new Vector3((float)_width / 2 - 0.5f, (float)_height / 2 - 0.5f, -10);

    }
}
