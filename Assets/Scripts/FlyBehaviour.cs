using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyBehaviour : MonoBehaviour
{
    [SerializeField] private float _velocity = 1;
    [SerializeField] private float _rotationSpeed = 10;

    private Rigidbody2D _rb;

    private void Start()
    {
        _rb  = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // 如果鼠标点击
        if (Input.GetMouseButtonDown(0))
        {
            _rb.velocity = Vector2.up * _velocity;
        }
        
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, _rb.velocity.y * _rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        GameManager.instance.GameOver();
    }
}
