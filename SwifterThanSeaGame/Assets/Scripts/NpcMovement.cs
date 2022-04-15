using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcMovement : MonoBehaviour
{
    public float speed = 2.5f;
    float startY;
    public float distance = 5;
    float addY;

    void Start()
    {
        startY = transform.position.y;
    }

    void Update()
    {
        addY = Mathf.PingPong(Time.time * speed, distance);
        transform.position = new Vector3(transform.position.x, startY + addY, transform.position.z);
    }
}