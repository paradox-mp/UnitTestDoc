using NUnit.Framework;
using UnityEngine;
using NSubstitute;


public class EnemyTests
{
    [Test]
    public void HumblePatternTest()
    {
        //Arrange
        IPosition enemyPosition = new MockEnemy();
        EnemyMover enemyMover = new EnemyMover(enemyPosition);
 
        //Act
        enemyMover.MoveEnemy(4f);

        //Assert
        Assert.AreEqual(new Vector3(0f, 1.58f, -4f), enemyPosition.Position);
    }

    [Test]
    public void NSubEnemyTest()
    {
        //Arrange
        IPosition enemyPosition = Substitute.For<IPosition>();
        EnemyMover enemyMover = new EnemyMover(enemyPosition);

        //Act
        enemyMover.MoveEnemy(4f);

        //Assert
        Assert.AreEqual(new Vector3(0f, 1.58f, -4f), enemyPosition.Position);




    }

    //[Test]
    //public void NonworkingTest()
    //{
    //    //Arrange
    //    Enemy enemy = new Enemy();

    //    //Act
    //    enemy.MoveEnemy(4f);

    //    //Assert
    //    Assert.AreEqual(new Vector3(0f, 1.58f, -4f), enemy.gameObject.transform.position);
    //}
}
