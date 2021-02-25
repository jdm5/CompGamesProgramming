using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HealthBarPlayer : MonoBehaviour
{

    public GameObject objectToFollow;

    public float speed = 2.0f;

    void Update()
    {
        float interpolation = speed * Time.deltaTime;

        Vector3 position = this.transform.position;
        position.z = objectToFollow.transform.position.z;
        position.y = objectToFollow.transform.position.y + 5;
        position.x = objectToFollow.transform.position.x;

        this.transform.position = position;
    }
}