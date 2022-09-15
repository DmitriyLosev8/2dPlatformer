using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _patrolDistace;
   
    private Vector3 _targetPointPosition;
    private Vector3 _leftPoint;
    private Vector3 _rightPoint;

    private void Start()
    {
        _leftPoint = transform.position;
        _targetPointPosition = new Vector3(transform.position.x + _patrolDistace, transform.position.y, transform.position.z);
        _rightPoint = _targetPointPosition;
    }

    private void Update()                      
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPointPosition, _speed * Time.deltaTime);

        if (transform.position == _rightPoint)
        {
            _targetPointPosition = _leftPoint;
        }

        if (transform.position == _leftPoint)
        {
            _targetPointPosition = _rightPoint;
        }   
    }
}

