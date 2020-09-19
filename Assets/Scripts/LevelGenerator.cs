using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    int[,] levelMap =
     {
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {0,1,2,2,2,2,2,2,2,2,2,2,2,2,7,7,2,2,2,2,2,2,2,2,2,2,2,2,1,0},
        {0,2,5,5,5,5,5,5,5,5,5,5,5,5,4,4,5,5,5,5,5,5,5,5,5,5,5,5,2,0},
        {0,2,5,3,4,4,3,5,3,4,4,4,3,5,4,4,5,3,4,4,4,3,5,3,4,4,3,5,2,0},
        {0,2,6,4,0,0,4,5,4,0,0,0,4,5,4,4,5,4,0,0,0,4,5,4,0,0,4,6,2,0},
        {0,2,5,3,4,4,3,5,3,4,4,4,3,5,3,3,5,3,4,4,4,3,5,3,4,4,3,5,2,0},
        {0,2,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,2,0},
        {0,2,5,3,4,4,3,5,3,3,5,3,4,4,4,4,4,4,3,5,3,3,5,3,4,4,3,5,2,0},
        {0,2,5,3,4,4,3,5,4,4,5,3,4,4,3,3,4,4,3,5,4,4,5,3,4,4,3,5,2,0},
        {0,2,5,5,5,5,5,5,4,4,5,5,5,5,4,4,5,5,5,5,4,4,5,5,5,5,5,5,2,0},
        {0,1,2,2,2,2,1,5,4,3,4,4,3,0,4,4,0,3,4,4,3,4,5,1,2,2,2,2,1,0},
        {0,0,0,0,0,0,2,5,4,3,4,4,3,0,3,3,0,3,4,4,3,4,5,2,0,0,0,0,0,0},
        {0,0,0,0,0,0,2,5,4,4,0,0,0,0,0,0,0,0,0,0,4,4,5,2,0,0,0,0,0,0},
        {0,0,0,0,0,0,2,5,4,4,0,3,4,4,0,0,4,4,3,0,4,4,5,2,0,0,0,0,0,0},
        {0,2,2,2,2,2,1,5,3,3,0,4,0,0,0,0,0,0,4,0,3,3,5,1,2,2,2,2,2,0},
        {0,0,0,0,0,0,0,5,0,0,0,4,0,0,0,0,0,0,4,0,0,0,5,0,0,0,0,0,0,0},

        {0,2,2,2,2,2,1,5,3,3,0,4,0,0,0,0,0,0,4,0,3,3,5,1,2,2,2,2,2,0},
        {0,0,0,0,0,0,2,5,4,4,0,3,4,4,0,0,4,4,3,0,4,4,5,2,0,0,0,0,0,0},
        {0,0,0,0,0,0,2,5,4,4,0,0,0,0,0,0,0,0,0,0,4,4,5,2,0,0,0,0,0,0},
        {0,0,0,0,0,0,2,5,4,3,4,4,3,0,3,3,0,3,4,4,3,4,5,2,0,0,0,0,0,0},
        {0,1,2,2,2,2,1,5,4,3,4,4,3,0,4,4,0,3,4,4,3,4,5,1,2,2,2,2,1,0},
        {0,2,5,5,5,5,5,5,4,4,5,5,5,5,4,4,5,5,5,5,4,4,5,5,5,5,5,5,2,0},
        {0,2,5,3,4,4,3,5,4,4,5,3,4,4,3,3,4,4,3,5,4,4,5,3,4,4,3,5,2,0},
        {0,2,5,3,4,4,3,5,3,3,5,3,4,4,4,4,4,4,3,5,3,3,5,3,4,4,3,5,2,0},
        {0,2,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,2,0},
        {0,2,5,3,4,4,3,5,3,4,4,4,3,5,3,3,5,3,4,4,4,3,5,3,4,4,3,5,2,0},
        {0,2,6,4,0,0,4,5,4,0,0,0,4,5,4,4,5,4,0,0,0,4,5,4,0,0,4,6,2,0},
        {0,2,5,3,4,4,3,5,3,4,4,4,3,5,4,4,5,3,4,4,4,3,5,3,4,4,3,5,2,0},
        {0,2,5,5,5,5,5,5,5,5,5,5,5,5,4,4,5,5,5,5,5,5,5,5,5,5,5,5,2,0},
        {0,1,2,2,2,2,2,2,2,2,2,2,2,2,7,7,2,2,2,2,2,2,2,2,2,2,2,2,1,0},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
     };


    int vertical, horizontal, column, row;
    public Sprite wall1;
    public Sprite wall2;
    public Sprite wall3;
    public Sprite wall4;
    public Sprite pellet; //5 in array
    public Sprite powerPellet; //6 in array
    public Sprite wall7;

    SpriteRenderer powerPelletRenderer;

    // Start is called before the first frame update
    void Start()
    {
        vertical = (int)Camera.main.orthographicSize;
        horizontal = vertical * (Screen.width / Screen.height);
        column = horizontal * 2;
        row = vertical * 2;

         for(int r = 0; r < 31; r++)
         {
            for (int c = 0; c < 30; c++)
            {
                int number = levelMap[r, c];
                generateTile(c, r, number);
            }
         }
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    private void generateTile(int c, int r, int tileNumber)
    {
        GameObject test = new GameObject();
        SpriteRenderer renderer = test.AddComponent<SpriteRenderer>();
        test.transform.position = new Vector3(c, r);
        
        switch (tileNumber)
        {
            case 1: 
                renderer.sprite = wall1;
                test.transform.localScale = new Vector3(3.2f, 3.2f, 1f);

                if ((levelMap[r, c + 1] == 2) && (levelMap[r - 1, c] == 2))
                {
                    test.transform.Rotate(0f, 0f, 0f);
                }
                else if ((levelMap[r, c - 1] == 2) && (levelMap[r - 1, c] == 2))
                {
                    test.transform.Rotate(0f, 0f, -90f);
                }
                else if ((levelMap[r, c - 1] == 2) && (levelMap[r + 1, c] == 2))
                {
                    test.transform.Rotate(0f, 0f, -180f);
                }
                else if ((levelMap[r, c + 1] == 2) && (levelMap[r + 1, c] == 2))
                {
                    test.transform.Rotate(0f, 0f, -270f);
                }
                break;

            case 2:
                renderer.sprite = wall2;
                test.transform.localScale = new Vector3(3.2f, 3.2f, 1f);

                if ((levelMap[r, c + 1] == 2) || (levelMap[r, c - 1] == 2))
                {
                    test.transform.Rotate(0f, 0f, -90f);
                }
                else if ((levelMap[r - 1, c] == 2) || (levelMap[r + 1, c] == 2))
                {
                    test.transform.Rotate(0f, 0f, 0f);
                }
                break;

            case 3:
                renderer.sprite = wall3;
                test.transform.localScale = new Vector3(3.2f, 3.2f, 1f);

                if ( ((levelMap[r, c + 1] == 4) || (levelMap[r, c + 1] == 3)) && ((levelMap[r - 1, c] == 4) || (levelMap[r - 1, c] == 3)))
                {
                    test.transform.Rotate(0f, 0f, 0f);
                }
                else if (((levelMap[r, c - 1] == 4) || (levelMap[r, c - 1] == 3)) && ((levelMap[r - 1, c] == 4) || (levelMap[r - 1, c] == 3)))
                {
                    test.transform.Rotate(0f, 0f, -90f);
                }
                else if (((levelMap[r, c - 1] == 4) || (levelMap[r, c - 1] == 3)) && ((levelMap[r + 1, c] == 4) || (levelMap[r + 1, c] == 3)))
                {
                    test.transform.Rotate(0f, 0f, -180f);
                }
                else if (((levelMap[r, c + 1] == 4) || (levelMap[r, c + 1] == 3)) &&  ((levelMap[r + 1, c] == 4) || (levelMap[r + 1, c] == 3))) 
                {
                    test.transform.Rotate(0f, 0f, -270f);
                }

                if (test.transform.position == new Vector3(14f, 22f, 0f))
                    test.transform.Rotate(0f, 0f, -90f);
                if (test.transform.position == new Vector3(9f, 10f, 0f))
                    test.transform.Rotate(0f, 0f, -270f);
                if (test.transform.position == new Vector3(14f, 8f, 0f))
                    test.transform.Rotate(0f, 0f, -180f);
                if (test.transform.position == new Vector3(15f, 8f, 0f))
                    test.transform.Rotate(0f, 0f, -270f);
                if (test.transform.position == new Vector3(9f, 20f, 0f))
                    test.transform.Rotate(0f, 0f, -270f);
                if (test.transform.position == new Vector3(20f, 20f, 0f))
                    test.transform.Rotate(0f, 0f, -180f);
                if (test.transform.position == new Vector3(20f, 19f, 0f))
                    test.transform.Rotate(0f, 0f, -90f);
                if (test.transform.position == new Vector3(9f, 11f, 0f))
                    test.transform.Rotate(0f, 0f, -270f);
                if (test.transform.position == new Vector3(9f, 10f, 0f))
                    test.transform.Rotate(0f, 0f, -90f);
                if (test.transform.position == new Vector3(20f, 11f, 0f))
                    test.transform.Rotate(0f, 0f, -180f);
                if (test.transform.position == new Vector3(20f, 10f, 0f))
                    test.transform.Rotate(0f, 0f, -90f);

                break;

            case 4:
                renderer.sprite = wall4;
                test.transform.localScale = new Vector3(3.2f, 3.2f, 1f);

                if ( ((levelMap[r + 1, c] != 4) && (levelMap[r, c + 1] == 4)) || ((levelMap[r - 1, c] != 4) && (levelMap[r, c + 1] == 4)))
                {
                    test.transform.Rotate(0f, 0f, -90f);
                }
                else if (((levelMap[r + 1, c] != 4) && (levelMap[r, c - 1] == 4) ) || ((levelMap[r - 1, c] != 4) && (levelMap[r, c - 1] == 4)))
                {
                    test.transform.Rotate(0f, 0f, -90f);
                }
                else if (((levelMap[r, c - 1] != 4) && (levelMap[r + 1, c] == 4)) || ((levelMap[r, c + 1] != 4) && (levelMap[r + 1, c] == 4)))
                {
                    test.transform.Rotate(0f, 0f, 0f);
                }
                else if (((levelMap[r, c - 1] != 4) && (levelMap[r - 1, c] == 4)) || ((levelMap[r, c + 1] != 4) && (levelMap[r - 1, c] == 4)))
                {
                    test.transform.Rotate(0f, 0f, 0f);
                }

                if (test.transform.position == new Vector3(14f, 28f, 0f))
                    test.transform.Rotate(0f, 0f, 90f);
                if (test.transform.position == new Vector3(15f, 28f, 0f))
                    test.transform.Rotate(0f, 0f, 90f);
                if (test.transform.position == new Vector3(14f, 27f, 0f))
                    test.transform.Rotate(0f, 0f, 0f);
                if (test.transform.position == new Vector3(15f, 26f, 0f))
                    test.transform.Rotate(0f, 0f, -270f);
                if (test.transform.position == new Vector3(14f, 26f, 0f))
                    test.transform.Rotate(0f, 0f, 90f);
                if (test.transform.position == new Vector3(8f, 22f, 0f))
                    test.transform.Rotate(0f, 0f, -90f);
                if (test.transform.position == new Vector3(9f, 22f, 0f))
                    test.transform.Rotate(0f, 0f, -90f);
                if (test.transform.position == new Vector3(20f, 22f, 0f))
                    test.transform.Rotate(0f, 0f, -90f);
                if (test.transform.position == new Vector3(21f, 22f, 0f))
                    test.transform.Rotate(0f, 0f, -90f);
                if (test.transform.position == new Vector3(9f, 21f, 0f))
                    test.transform.Rotate(0f, 0f, -90f);
                if (test.transform.position == new Vector3(14f, 21f, 0f))
                    test.transform.Rotate(0f, 0f, -90f);
                if (test.transform.position == new Vector3(15f, 21f, 0f))
                    test.transform.Rotate(0f, 0f, -90f);
                if (test.transform.position == new Vector3(20f, 21f, 0f))
                    test.transform.Rotate(0f, 0f, -90f);
                if (test.transform.position == new Vector3(14f, 20f, 0f))
                    test.transform.Rotate(0f, 0f, -90f);
                if (test.transform.position == new Vector3(15f, 20f, 0f))
                    test.transform.Rotate(0f, 0f, -90f);
                if (test.transform.position == new Vector3(9f, 18f, 0f))
                    test.transform.Rotate(0f, 0f, -90f);
                if (test.transform.position == new Vector3(20f, 18f, 0f))
                    test.transform.Rotate(0f, 0f, -90f);
                if (test.transform.position == new Vector3(8f, 17f, 0f))
                    test.transform.Rotate(0f, 0f, -90f);
                if (test.transform.position == new Vector3(9f, 17f, 0f))
                    test.transform.Rotate(0f, 0f, -90f);
                if (test.transform.position == new Vector3(20f, 17f, 0f))
                    test.transform.Rotate(0f, 0f, -90f);
                if (test.transform.position == new Vector3(21f, 17f, 0f))
                    test.transform.Rotate(0f, 0f, -90f);

                if (test.transform.position == new Vector3(8f, 13f, 0f))
                    test.transform.Rotate(0f, 0f, 90f);
                if (test.transform.position == new Vector3(9f, 13f, 0f))
                    test.transform.Rotate(0f, 0f, 90f);
                if (test.transform.position == new Vector3(20f, 13f, 0f))
                    test.transform.Rotate(0f, 0f, 90f);
                if (test.transform.position == new Vector3(21f, 13f, 0f))
                    test.transform.Rotate(0f, 0f, 90f);
                if (test.transform.position == new Vector3(9f, 12f, 0f))
                    test.transform.Rotate(0f, 0f, 90f);
                if (test.transform.position == new Vector3(20f, 12f, 0f))
                    test.transform.Rotate(0f, 0f, 90f);
                if (test.transform.position == new Vector3(14f, 10f, 0f))
                    test.transform.Rotate(0f, 0f, 90f);
                if (test.transform.position == new Vector3(15f, 10f, 0f))
                    test.transform.Rotate(0f, 0f, 90f);
                if (test.transform.position == new Vector3(9f, 9f, 0f))
                    test.transform.Rotate(0f, 0f, 90f);
                if (test.transform.position == new Vector3(14f, 9f, 0f))
                    test.transform.Rotate(0f, 0f, 90f);
                if (test.transform.position == new Vector3(15f, 9f, 0f))
                    test.transform.Rotate(0f, 0f, 90f);
                if (test.transform.position == new Vector3(20f, 9f, 0f))
                    test.transform.Rotate(0f, 0f, 90f);
                if (test.transform.position == new Vector3(8f, 8f, 0f))
                    test.transform.Rotate(0f, 0f, 90f);
                if (test.transform.position == new Vector3(9f, 8f, 0f))
                    test.transform.Rotate(0f, 0f, 90f);
                if (test.transform.position == new Vector3(20f, 8f, 0f))
                    test.transform.Rotate(0f, 0f, 90f);
                if (test.transform.position == new Vector3(21f, 8f, 0f))
                    test.transform.Rotate(0f, 0f, 90f);
                if (test.transform.position == new Vector3(14f, 4f, 0f))
                    test.transform.Rotate(0f, 0f, 90f);
                if (test.transform.position == new Vector3(15f, 4f, 0f))
                    test.transform.Rotate(0f, 0f, 90f);
                if (test.transform.position == new Vector3(14f, 2f, 0f))
                    test.transform.Rotate(0f, 0f, 90f);
                if (test.transform.position == new Vector3(15f, 2f, 0f))
                    test.transform.Rotate(0f, 0f, 90f);

                break;

            case 5:
                renderer.sprite = pellet;
                break;

            case 6:
                test.AddComponent<PowerPelletBlink>();
                renderer.sprite = powerPellet;
                break;

            case 7:
                renderer.sprite = wall7;
                test.transform.localScale = new Vector3(3.2f, 3.2f, 1f);

                if (levelMap[r, c - 1] == 7 && levelMap[r + 1, c] == 0)
                    test.transform.localScale = new Vector3(-3.2f, 3.2f, 1);
                else if (levelMap[r, c + 1] == 7 && levelMap[r - 1, c] == 0)
                    test.transform.localScale = new Vector3(3.2f, -3.2f, 1);
                if (levelMap[r, c - 1] == 7 && levelMap[r - 1, c] == 0)
                    test.transform.localScale = new Vector3(-3.2f, -3.2f, 1);

                break;

            default:
                break;
        }
        
    }
}
