using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _jumpForce;

    private void Update()                        
    {
        if (Input.GetKey(KeyCode.Space) == true)
        {
            _rigidbody2D.AddForce(Vector2.up * _jumpForce);
        }
    }
}
