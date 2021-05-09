using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestColliders : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        var player = GetComponent<PlayerMover>();
        var killPlane = GetComponent<KillPlane>();

        if (player == null || killPlane == null)
            Debug.Log("msg");
    }


}
