using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] transArray;
    private GameObject Wall;
    public float positionX;
    public float positionY;
    // Start is called before the first frame update
    void Start()
    {
        CreateMap(-4, -6, 1, 1, 1);
        CreateMap(-23, -6, -1, 1, 2);
        CreateMap(-4, -22, 1, -1, 3);
        CreateMap(-23, -22, -1, -1, 4);
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
            {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
        };

        for (int y = 0; y < levelMap.GetLength(0); y++){
        for (int x = 0; x < levelMap.GetLength(1); x++){
                switch (levelMap[y, x]){ 
                case 1:
                    Wall = (GameObject)Instantiate(transArray[0], transform);
                    positionX = (originalX + x)  * Xdirection;
                    positionY = (originalY + y)  * -Ydirection;
                    Wall.transform.position = new Vector3(positionX, positionY,0);
                    rotate(Wall, y, x, id);
                break;
                case 2:
                    Wall = (GameObject)Instantiate(transArray[1], transform);
                    positionX = (originalX + x)  * Xdirection;
                    positionY = (originalY + y)  * -Ydirection;
                    Wall.transform.position = new Vector3(positionX, positionY,0);
                    rotate(Wall, y, x, id);
                break;
                case 3:
                    Wall = (GameObject)Instantiate(transArray[2], transform);
                    positionX = (originalX + x)  * Xdirection;
                    positionY = (originalY + y)  * -Ydirection;
                    Wall.transform.position = new Vector3(positionX, positionY,0);
                    rotate(Wall, y, x, id);
                break;
                case 4:
                    Wall = (GameObject)Instantiate(transArray[3], transform);
                    positionX = (originalX + x)  * Xdirection;
                    positionY = (originalY + y)  * -Ydirection;
                    Wall.transform.position = new Vector3(positionX, positionY,0);
                    rotate(Wall, y, x, id);
                break;
                case 5:
                    Wall = (GameObject)Instantiate(transArray[4], transform);
                    positionX = (originalX + x)  * Xdirection;
                    positionY = (originalY + y)  * -Ydirection;
                    Wall.transform.position = new Vector3(positionX, positionY,0);
                    rotate(Wall, y, x, id);
                break;
                case 6:
                    Wall = (GameObject)Instantiate(transArray[5], transform);
                    positionX = (originalX + x)  * Xdirection;
                    positionY = (originalY + y)  * -Ydirection;
                    Wall.transform.position = new Vector3(positionX, positionY,0);
                    rotate(Wall, y, x, id);
                break;
                case 7:
                    Wall = (GameObject)Instantiate(transArray[6], transform);
                    positionX = (originalX + x)  * Xdirection;
                    positionY = (originalY + y)  * -Ydirection;
                    Wall.transform.position = new Vector3(positionX, positionY,0);
                    rotate(Wall, y, x, id);
                break;
                default:
                Debug.Log("Empty");
                break;
            }
        }
        }
    
        
    }

    private void rotate(GameObject Wall, int x, int y, int id){
         int[,] rotateMap =
        {
        {0,3,3,3,3,3,3,3,3,3,3,3,3,3},
        {0,5,5,5,5,5,5,5,5,5,5,5,5,0},
        {0,5,0,3,3,3,5,0,3,3,3,3,5,0},
        {0,6,0,0,0,2,5,0,0,0,0,2,5,0},
        {0,5,1,1,1,2,5,1,1,1,1,2,5,1},
        {0,5,5,5,5,5,5,5,5,5,5,5,5,5},
        {0,5,0,3,3,3,5,0,3,5,0,3,3,3},
        {0,5,1,1,1,2,5,0,2,5,1,1,1,3},
        {0,5,5,5,5,5,5,0,2,5,5,5,5,5},
        {1,1,1,1,1,3,5,0,1,3,3,3,0,0},
        {0,0,0,0,0,2,5,0,0,1,1,2,0,1},
        {0,0,0,0,0,2,5,0,2,0,0,0,0,0},
        {0,0,0,0,0,2,5,0,2,0,0,3,3,0},
        {1,1,1,1,1,2,5,1,2,0,0,0,0,0},
        {0,0,0,0,0,0,5,0,0,0,0,0,0,0},
        };

    switch (id){
        case 1:
        switch (rotateMap[x, y])
        {
            case 0:
             Wall.transform.Rotate(0f, 0f, 0f);
             break;
             case 1:
             Wall.transform.Rotate(0f, 0f, 90f);
             break;
              case 2:
            Wall.transform.Rotate(0f, 0f, 180f);
             break;
            case 3:
             Wall.transform.Rotate(0f, 0f, 270f);
             break; 
            default:
            break;
        }
        break;

         case 2:
        switch (rotateMap[x, y])
        {
            case 0:
             Wall.transform.Rotate(0f, 180f, 0f);
             break;
             case 1:
             Wall.transform.Rotate(0f, 180f, 90f);
             break;
              case 2:
             Wall.transform.Rotate(0f, 180f, 180f);
             break;
            case 3:
            Wall.transform.Rotate(0f, 180f, 270f);
             break; 
            default:
            break;
        }
        break;

        case 3:
        switch (rotateMap[x, y])
        {
             case 0:
             Wall.transform.Rotate(180f, 0f, 0f);
             break;
            case 1:
             Wall.transform.Rotate(180f, 0f, 90f);
             break;
              case 2:
             Wall.transform.Rotate(180f, 0f,180f);
             break;
            case 3:
             Wall.transform.Rotate(180f, 0f, 270f);
             break;
              case 5:
             Wall.transform.Rotate(180f, 180f,180f);
             break;
             case 6:
            Wall.transform.Rotate(180f, 180f, 180f);
             break;
            default:
            break;
        }
        break;

        case 4:
        switch (rotateMap[x, y])
        {
             case 0:
            Wall.transform.Rotate(180f, 180f, 0f);
             break;
             case 1:
             Wall.transform.Rotate(180f, 180f, 90f);
             break;
              case 2:
             Wall.transform.Rotate(180f, 180f,180f);
             break;
            case 3:
            Wall.transform.Rotate(180f, 180f, 270f);
             break; 
             case 5:
            Wall.transform.Rotate(180f, 180f, 180f);
             break; 
             case 6:
            Wall.transform.Rotate(180f, 180f, 180f);
             break;
            default:
            break;
        }
        break;
      }
    }
}
