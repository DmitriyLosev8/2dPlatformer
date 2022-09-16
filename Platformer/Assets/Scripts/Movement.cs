using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] Animator _animator;

    private void Update()
    {
        if (Input.GetKey(KeyCode.D) == true)
        {
            _animator.SetTrigger("Moving");
            transform.Translate(_speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A) == true)
        {
            _animator.SetTrigger("Moving");
            transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
        }
    }    
}
