// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Grid : MonoBehaviour
// {
//     [SerializeField] private int _width, _height;
//     [SerializeField] private Tile _tilePrefab;
//     [SerializeField] private Transform _cam;
//     void Start(){
//         GenerateGrid();
//     }
//     void GenerateGrid(){
//         for (int x = 0; x < _width; x++){
//             for (int y = 0; y < _height; y++){
//                 var spawnTile = Instantiate(_tilePrefab,new Vector3(x,y), Quaternion.identity);
//                 spawnTile.name = $"Tile {x} {y}";

//                 var isOffset
//             }
//         }
//         _cam.transform.position = new Vector3((float)_width/2- 0.5f,(float)_height/2- 0.5f, -2);
//     }
// }
