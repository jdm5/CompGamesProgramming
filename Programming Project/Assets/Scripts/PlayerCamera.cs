using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerCamera : MonoBehaviour
{

    public GameObject objectToFollow;

    public float speed = 2.0f;

    void Update()
    {
        float interpolation = speed * Time.deltaTime;

        Vector3 position = this.transform.position;
        position.z = objectToFollow.transform.position.z - 15;
        position.y = objectToFollow.transform.position.y + 15;
        position.x = objectToFollow.transform.position.x - 15;

        this.transform.position = position;
    }
}