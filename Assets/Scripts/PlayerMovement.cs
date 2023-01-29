using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxisRaw("Horizontal");
        transform.position = transform.position + new Vector3(horizontalMove * moveSpeed * Time.deltaTime, 0f, 0f);
    }
}
