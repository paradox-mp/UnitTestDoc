using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover
{
    IPosition _enemyPosition;

    public EnemyMover(IPosition position)
    {
        _enemyPosition = position;
    }

    public void MoveEnemy(float timer)
    {
        if (timer >= 0 && timer <= 8)
            _enemyPosition.Position = new Vector3(timer - 4, 1.58f, -4);
        else if (timer > 8 && timer <= 16)
            _enemyPosition.Position = new Vector3(4f, 1.58f, timer - 4 - 8 * 1);
        else if (timer > 16 && timer <= 24)
            _enemyPosition.Position = new Vector3(-(timer - 4 - 8 * 2), 1.58f, 4f);
        else if (timer > 24 && timer <= 32)
            _enemyPosition.Position = new Vector3(-4f, 1.58f, -(timer - 4 - 8 * 3));
    }
}





//else
//should have some kind of catch like a string that says not valid input
