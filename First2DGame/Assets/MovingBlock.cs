using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlock : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3f;

    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * moveSpeed;
    }
}
