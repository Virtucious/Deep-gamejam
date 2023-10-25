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

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        _playerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * Mathf.Lerp(minMovementSpeed, maxMovementSpeed, Time.time / 5f);
        Debug.Log(_playerRigidbody2D.velocity);
    }
}
