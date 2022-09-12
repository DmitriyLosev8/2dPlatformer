using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] Animator _animator;

    void Update()
    {
        if (Input.GetKey(KeyCode.D) == true)
        {
            _animator.SetBool("IsMoving", true);
            transform.Translate(_speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A) == true)
        {
            _animator.SetBool("IsMoving", true);
            transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
        }
        else
        {
            _animator.SetBool("IsMoving", false);
        }
    }    
}
