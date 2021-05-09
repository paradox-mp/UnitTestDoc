using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumbleEnemy : MonoBehaviour, IPosition
{
    EnemyMover enemyMover;

    float timer = 0;

    private void Start()
    {
        enemyMover = new EnemyMover(this);
    }

    public Vector3 Position
    {
        get { return transform.position; }
        set { transform.position = value; }
    }

    void Update()
    {
        timer += Time.deltaTime * 4;

        enemyMover.MoveEnemy(timer);

        if (timer >= 8 * 4)
            timer = 0;
    }

    private void OnTriggerEnter(Collider collision)
    {
        var player = collision.GetComponent<PlayerMover1>();
        if (player == null)
            return;

        player.KillPlayer();
    }
}
