using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCupcake : MonoBehaviour
{
    public float speed = 5f;
    public GameObject Cupcake;
    public Transform aimObject;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject spawnedCupcake = Instantiate(Cupcake, aimObject.position, aimObject.rotation);
            spawnedCupcake.GetComponent<Rigidbody>().velocity = speed * aimObject.forward;

        }
    }


}
