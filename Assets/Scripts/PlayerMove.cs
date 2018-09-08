﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    int[,] Animal = new int[7, 10];
    int x, y;
    // Use this for initialization
    void Start()
    {
        x = 3;
        y = 2;
        Animal[x, y] = 1;
        StartCoroutine("move");
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("x" + x);
        Debug.Log("y" + y);
        MapArray.Map[x, y] = 1;
    }

    IEnumerator move()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            if (MapArray.Map[x + 1, y] == 0) //오른쪽
            {
                x++;
                transform.Translate(new Vector3(5, 0, 0), Space.World);
            }
            else if (MapArray.Map[x - 1, y] == 0) //왼쪽
            {
                x--;
                transform.Translate(new Vector3(-5, 0, 0), Space.World);
            }
            else if (MapArray.Map[x, y + 1] == 0) //위쪽
            {
                y++;
                transform.Translate(new Vector3(0, 0, 5), Space.World);
            }
            else if (MapArray.Map[x, y - 1] == 0) //아래쪽
            {
                y--;
                transform.Translate(new Vector3(0, 0, -5), Space.World);
            }
        }
       

    }
}