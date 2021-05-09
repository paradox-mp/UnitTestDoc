using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float timer = 0;

    void Update()
    {
        timer += Time.deltaTime * 4;

        MoveEnemy(timer);

        if (timer >= 8 * 4)
            timer = 0;
    }

    public void MoveEnemy(float timer)
    {
        if (timer >= 0 && timer <= 8)
            transform.position = new Vector3(timer - 4, 1.58f, -4);
        else if (timer > 8 && timer <= 16)
            transform.position = new Vector3(4f, 1.58f, timer - 4 - 8 * 1);
        else if (timer > 16 && timer <= 24)
            transform.position = new Vector3(-(timer - 4 - 8 * 2), 1.58f, 4f);
        else if (timer > 24 && timer <= 32)
            transform.position = new Vector3(-4f, 1.58f, -(timer - 4 - 8 * 3));
    }
}



//private void MoveEnemy(float timer)
//{
//    if (timer >= 0 && timer <= 8)
//        transform.position = new Vector3(timer - 4, 1.58f, -4);
//    else if (timer > 8 && timer <= 16)
//        transform.position = new Vector3(4f, 1.58f, timer - 4 - 8 * 1);
//    else if (timer > 16 && timer <= 24)
//        transform.position = new Vector3(-(timer - 4 - 8 * 2), 1.58f, 4f);
//    else if (timer > 24 && timer <= 32)
//        transform.position = new Vector3(-4f, 1.58f, -(timer - 4 - 8 * 3));

//}