using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    public float minMovementSpeed = 1f;
    public float maxMovementSpeed = 4f;
    public float jumpForce = 1f;

    public static PlayerController instance;

    private Rigidbody2D _playerRigidbody2D;
    private float pressedTime;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        _playerRigidbody2D = GetComponent<Rigidbody2D>();
        pressedTime = 0f;
    }

    
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        if (movement == 0f)
        {
            pressedTime = 0f;
        }
        if (movement != 0)
        {
            transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * Mathf.Lerp(minMovementSpeed, maxMovementSpeed, Time.time / 5f);
        }
        Debug.Log(_playerRigidbody2D.velocity);
    }
}
