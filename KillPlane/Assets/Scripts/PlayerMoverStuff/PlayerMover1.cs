using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMover1 : MonoBehaviour
{
    [Range(3f, 15f)] [SerializeField] float speed = 5;
    [SerializeField] GameObject[] _respawnLocations;

    Vector3[] _resawnLocationsAsVector3;
    CharacterController characterController;
    Vector3 moveVector;

    CalculateClosestRepawnPoint calculateClosest = new CalculateClosestRepawnPoint();

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        _resawnLocationsAsVector3 = new Vector3[_respawnLocations.Length];
        TranslateGameObjectPositionToVector3Array(_respawnLocations, _resawnLocationsAsVector3);
    }

    void Update()
    {
        moveVector = Vector3.zero;

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        moveVector += new Vector3(horizontal, 0, vertical) * speed;

        if (characterController.isGrounded == false)
        {
            moveVector += Physics.gravity;
        }

        characterController.Move(moveVector * Time.deltaTime);
    }

    public void KillPlayer()
    {
        DestroyThisGameobject destroyThisGameobject = new DestroyThisGameobject();
        destroyThisGameobject.DestroyGameobject(this.gameObject);
    }


    public void KillPlayer1()
    {
        Destroy(gameObject);
    }

    public void ResetPlayerPosition()
    {
        characterController.enabled = false;
        characterController.transform.position = calculateClosest.CalculateClosestRespawnPoint(_resawnLocationsAsVector3, transform.position);
        characterController.enabled = true;

    }

    void TranslateGameObjectPositionToVector3Array(GameObject[] gameObjectsToBeLoaded, Vector3[] vector3ToLoadInto)
    {
        for (int i = 0; i < gameObjectsToBeLoaded.Length; i++)
        {
            vector3ToLoadInto[i] = gameObjectsToBeLoaded[i].transform.position;
        }
    }
}

public class DestroyThisGameobject
{
    public void DestroyGameobject(GameObject gameObject)
    {
        UnityEngine.Object.Destroy(gameObject);
    }
}