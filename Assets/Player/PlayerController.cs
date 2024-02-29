using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");

        float moveAmount = moveInput * moveSpeed * Time.deltaTime;

        Vector3 newPosition = transform.position + Vector3.right * moveAmount;

        transform.position = newPosition;
    }
}
