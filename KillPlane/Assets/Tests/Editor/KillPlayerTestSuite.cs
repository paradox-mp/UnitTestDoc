using NSubstitute;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;


//this needs to be in play mode.
public class KillPlayerTestSuite
{
    [UnityTest]
    public IEnumerator KillPlayerOnCollision()
    {
        DestroyThisGameobject destroyThisGameobject = new DestroyThisGameobject();
        GameObject _gameObject = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Player"));

        bool alive = _gameObject != null;


        //destroyThisGameobject.DestroyGameobject(_gameObject);

        //Assert.IsTrue(alive);

        Assert.IsNull(_gameObject);
        yield return null;
    }

    [Test]
    public void PlayerShouldRest()
    {
        //Arange
        HandleResetPlayer handleReset = new HandleResetPlayer();
        PlayerMover1 player = Substitute.For<PlayerMover1>(); //fails

        //Act
        //player

        //Assert
    }

    [Test]
    public void PlayerShouldNotRest()
    {

    }


    [Test]
    public void NSubEnemyTest()
    {
        IPosition enemyPosition = Substitute.For<IPosition>();
        EnemyMover enemyMover = new EnemyMover(enemyPosition);

        enemyMover.MoveEnemy(4f);

        Assert.AreEqual(new Vector3(0f, 1.58f, -4f), enemyPosition.Position);
    }

}
