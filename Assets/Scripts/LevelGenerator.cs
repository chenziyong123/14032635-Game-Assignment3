using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] transArray;
    private GameObject Wall;
    public float positionX;
    public float positionY;
    private int wallsid = 0;
    public GameObject level01;
    // Start is called before the first frame update
    //Data of four maps (initial x-axis, initial y-axis, x-axis creation direction, y-axis creation direction, map id)
    void Start()
    {
        level01.SetActive(false);
        CreateMap(-3.5f, -5.5f, 1, 1, 0);
        CreateMap(-23.5f, -5.5f, -1, 1, 1);
        CreateMap(-3.5f, -21.5f, 1, -1, 2);
        CreateMap(-23.5f, -21.5f, -1, -1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreateMap(float originalX, float originalY, int Xdirection, int Ydirection, int id)
    {
        
        int[,] levelMap =
        {
            {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
            {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
            {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
            {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
            {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
            {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
            {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
            {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
            {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
            {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
            {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
            {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
            {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
            {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
        };
//By traversing the horizontal and vertical of the icon
        for (int y = 0; y < levelMap.GetLength(0); y++){
        for (int x = 0; x < levelMap.GetLength(1); x++){
            //Through the horizontal and vertical (x, y) data in the levelmap, put down the corresponding walls picture
                switch (levelMap[y, x]){ 
                case 1:
                wallsid=levelMap[y, x];
                    Movemap(wallsid, x, y, originalX,originalY,Xdirection,Ydirection,id);
                break;
                case 2:
                wallsid=levelMap[y, x];
                     Movemap(wallsid, x, y, originalX,originalY,Xdirection,Ydirection,id);
                break;
                case 3:
                wallsid=levelMap[y, x];
                     Movemap(wallsid, x, y, originalX,originalY,Xdirection,Ydirection,id);
                break;
                case 4:
                wallsid=levelMap[y, x];
                     Movemap(wallsid, x, y, originalX,originalY,Xdirection,Ydirection,id);
                break;
                case 5:
                wallsid=levelMap[y, x];
                     Movemap(wallsid, x, y, originalX,originalY,Xdirection,Ydirection,id);
                break;
                case 6:
                wallsid=levelMap[y, x];
                     Movemap(wallsid, x, y, originalX,originalY,Xdirection,Ydirection,id);
                break;
                case 7:
                wallsid=levelMap[y, x];
                     Movemap(wallsid, x, y, originalX,originalY,Xdirection,Ydirection,id);
                break;
                default:
                Debug.Log("Empty");
                break;
            }
        }
        }
    }
    //Initial position (originx, originy) + levelmap (very vertical position x, y), multiplied by the icon creation direction (left to right = 1, right to left = -1, first determine whether the size of the wall is 1)
    //Pass value to rotate
    private void Movemap(int wallsid,int x,int y,float originalX,float originalY,int Xdirection,int Ydirection,int id){
                     
         Wall = (GameObject)Instantiate(transArray[wallsid], transform);
                    positionX = (originalX + x)  * Xdirection;
                    positionY = (originalY + y)  * -Ydirection;
                    Wall.transform.position = new Vector3(positionX, positionY,0);
                    rotate(Wall, y, x, id);
    }

//Make rotateMap through levelmap

    private void rotate(GameObject Wall, int x, int y, int id){
         int[,] rotateMap =
        {
        {0,1,1,1,1,1,1,1,1,1,1,1,1,3},
        {0,5,5,5,5,5,5,5,5,5,5,5,5,0},
        {0,5,0,1,1,3,5,0,1,1,1,3,5,0},
        {0,5,0,0,0,2,5,0,0,0,0,2,5,0},
        {0,5,1,1,1,2,5,1,1,1,1,2,5,1},
        {0,5,5,5,5,5,5,5,5,5,5,5,5,5},
        {0,5,0,1,1,3,5,0,3,5,0,1,1,1},
        {0,5,1,1,1,2,5,0,2,5,1,1,1,3},
        {0,5,5,5,5,5,5,0,2,5,5,5,5,5},
        {1,1,1,1,1,3,5,0,1,1,1,3,0,0},
        {0,0,0,0,0,2,5,0,0,1,1,2,0,1},
        {0,0,0,0,0,2,5,0,2,0,0,0,0,0},
        {0,0,0,0,0,2,5,0,2,0,0,1,1,0},
        {1,1,1,1,1,2,5,1,2,0,0,0,0,0},
        };

//Confirm by id the figure is the upper left corner (1), upper right corner (2), lower left corner (3), lower right corner (4)
//Confirm the rotation angle through RotateMap
    switch (id){
        case 0:
        switch (rotateMap[x, y])
        {
            case 0:
             Wall.transform.Rotate(0, 0, 0);
             break;
             case 1:
             Wall.transform.Rotate(0, 0, 90);
             break;
              case 2:
             Wall.transform.Rotate(0, 0, 180);
             break;
            case 3:
             Wall.transform.Rotate(0, 0, 270);
             break; 
            default:
            break;
        }
        break;

         case 1:
        switch (rotateMap[x, y])
        {
            case 0:
             Wall.transform.Rotate(0, 180, 0);
             break;
             case 1:
             Wall.transform.Rotate(0, 180, 90);
             break;
              case 2:
             Wall.transform.Rotate(0, 180, 180);
             break;
            case 3:
            Wall.transform.Rotate(0, 180, 270);
             break; 
            default:
            break;
        }
        break;

        case 2:
        switch (rotateMap[x, y])
        {
             case 0:
             Wall.transform.Rotate(180, 0, 0);
             break;
            case 1:
             Wall.transform.Rotate(180, 0, 90);
             break;
              case 2:
             Wall.transform.Rotate(180, 0,180);
             break;
            case 3:
             Wall.transform.Rotate(180, 0, 270);
             break;
              case 5:
             Wall.transform.Rotate(180, 180, 180);
             break;
            default:
            break;
        }
        break;

        case 3:
        switch (rotateMap[x, y])
        {
             case 0:
            Wall.transform.Rotate(180, 180, 0);
             break;
             case 1:
             Wall.transform.Rotate(180, 180, 90);
             break;
              case 2:
             Wall.transform.Rotate(180, 180, 180);
             break;
            case 3:
            Wall.transform.Rotate(180, 180, 270);
             break; 
             case 5:
            Wall.transform.Rotate(180, 180, 180);
             break; 
            default:
            break;
        }
        break;
      }
    }
}
