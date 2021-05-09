using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerResetTestSuite
{
    [Test]
    public void Test1CalcualteClosetPosition()
    {
        //Arrange
        Vector3 closestPoint;
        Vector3 currentPosition = Vector3.zero;
        Vector3[] vector3s = new Vector3[] { new Vector3(1f, 1f, 1f), new Vector3(3f, 2f, 1f) };
        CalculateClosestRepawnPoint calculateClosestRepawnPoint = new CalculateClosestRepawnPoint();

        //Act
        closestPoint = calculateClosestRepawnPoint.CalculateClosestRespawnPoint(vector3s, currentPosition);

        //Assert
        Assert.AreEqual(new Vector3(1f, 1f, 1f), closestPoint);
    }

    [Test]
    public void Test2CalcualteClosetPosition()
    {
        //Arrange
        Vector3 closestPoint;
        Vector3 currentPosition = new Vector3(7f, 4f, 3f);
        Vector3[] vector3s = new Vector3[] { new Vector3(17f, 6f, 2f), new Vector3(93f, 2f, 18f), new Vector3(57f, 97f, 37f) };
        CalculateClosestRepawnPoint calculateClosestRepawnPoint = new CalculateClosestRepawnPoint();

        //Act
        closestPoint = calculateClosestRepawnPoint.CalculateClosestRespawnPoint(vector3s, currentPosition);

        //Assert
        Assert.AreEqual(new Vector3(17f, 6f, 2f), closestPoint);
    }

    [Test]
    public void Test3CalcualteClosetPosition()
    {
        //When two points are equal distance away, method should return first in array

        //Arrange
        Vector3 closestPoint;
        Vector3 currentPosition = new Vector3(2f, 2f, 2f);
        Vector3[] vector3s = new Vector3[] { new Vector3(1f, 1f, 1f), new Vector3(3f, 3f, 3f) };
        CalculateClosestRepawnPoint calculateClosestRepawnPoint = new CalculateClosestRepawnPoint();

        //Act
        closestPoint = calculateClosestRepawnPoint.CalculateClosestRespawnPoint(vector3s, currentPosition);

        //Assert
        Assert.AreEqual(new Vector3(1f, 1f, 1f), closestPoint);
    }

    [Test]
    public void Test4CalcualteClosetPosition()
    {
        //Arrange
        Vector3 closestPoint;
        Vector3 currentPosition = new Vector3(2f, 2f, 2f);
        Vector3[] vector3s = new Vector3[] { Vector3.zero, new Vector3(0f, -10f, 10f) };
        CalculateClosestRepawnPoint calculateClosestRepawnPoint = new CalculateClosestRepawnPoint();

        //Act
        closestPoint = calculateClosestRepawnPoint.CalculateClosestRespawnPoint(vector3s, currentPosition);

        //Assert
        Assert.AreEqual(Vector3.zero, closestPoint);
    }

    [Test]
    public void Test5CalcualteClosetPosition()
    {
        //Arrange
        Vector3 closestPoint;
        Vector3 currentPosition = new Vector3(-2f, -2f, -2f);
        Vector3[] vector3s = new Vector3[] { new Vector3(-1f, -1f, -1f), new Vector3(-4f, -3f, -2f) };
        CalculateClosestRepawnPoint calculateClosestRepawnPoint = new CalculateClosestRepawnPoint();

        //Act
        closestPoint = calculateClosestRepawnPoint.CalculateClosestRespawnPoint(vector3s, currentPosition);

        //Assert
        Assert.AreEqual(new Vector3(-1f, -1f, -1f), closestPoint);
    }
}
