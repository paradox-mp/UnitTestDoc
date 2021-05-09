using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateClosestRepawnPoint
{

    public Vector3 CalculateClosestRespawnPoint(Vector3[] vector3s, Vector3 currentPosition)
    {
        float maxDistance = int.MaxValue;
        Vector3 closestLocation = new Vector3(0, 0, 0);


        for (int i = 0; i < vector3s.Length; i++)
        {

            if ((currentPosition - vector3s[i]).magnitude < maxDistance)
            {
                maxDistance = (currentPosition - vector3s[i]).magnitude;
                closestLocation = vector3s[i];
            }
        }

        return closestLocation;
    }


}
