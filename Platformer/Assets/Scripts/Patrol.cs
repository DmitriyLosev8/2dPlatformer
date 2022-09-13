using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    private float _speed = 1;
    private float _passedDistance = 0;
    private float _distanceRight = 3;
    private float _distanceLeft = 0;
    //[SerializeField] private Transform _transform;
    private Vector3 _targetPointPosition;
    private Vector3 _startPosition;
    private bool _isReached;
    private Vector3 _targetPosition;

    private void Start()
    {
        _startPosition = transform.position;
        _targetPointPosition = new Vector3(transform.position.x + _distanceRight, transform.position.y, transform.position.z);
        _targetPosition = _targetPointPosition;

         //  StartCoroutine(MovementRight());
         // StartCoroutine(MovementLeft());
         //    //Transform _startTransform = GetComponent<Transform>();

        //    //transform.Translate(_distanceOfPatrol, 0, 0);
    }


    //Transform TTarget = _transform.


    //private void Gettarget()
    //{
    //    var target = _transform.position + new Vector3(_distanceOfPatrol, 0, 0);
    //}


    


    void Update()                       //красиво оформить движение
    {
        float step = _speed * Time.deltaTime;


        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, step);


        if (transform.position == _targetPointPosition)
        {
            _targetPosition = _startPosition;
           // transform.position = Vector3.MoveTowards(transform.position, _targetPosition, step);

        }

        if (transform.position == _startPosition)
        {
            _targetPosition = _targetPointPosition;
            //transform.position = Vector3.MoveTowards(transform.position, _targetPosition, step);
        }

       
        //transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);
    }
        //float step = _speed * Time.deltaTime;

        //_targetPosition = new Vector3(transform.position.x + _distanceRight, transform.position.y, transform.position.z);

        
        //    _distanceRight -= step;
        
        //if(_distanceRight == _distanceLeft)
        //{
        //    _distanceRight = 3;
        //    _targetPosition = new Vector3(transform.position.x + _distanceLeft, transform.position.y, transform.position.z);
            
        //    _distanceLeft += step;

        //    if(_distanceLeft == _distanceRight)
        //    {
        //        _distanceLeft = 0;
        //        _targetPosition = new Vector3(transform.position.x + _distanceRight, transform.position.y, transform.position.z);
        //    }
        //}


        //transform.position =  Vector3.MoveTowards(transform.position, _targetPosition, step);


   // }

    //private void MovementRight()
    //{
    //    float step = _speed * Time.deltaTime;

    //    if (_passedDistance < _distanceRight)
    //    {
    //        _passedDistance += step;
    //        transform.Translate(step, 0, 0);

    //        if(_passedDistance == _distanceRight)
    //        {
    //            MovementLeft();
    //        }
    //    }
    //}

    //private void MovementLeft()
    //{
    //    float step = _speed * Time.deltaTime;

    //    if( _passedDistance > _distanceLeft)
    //    {
    //        _passedDistance -= step;
    //        transform.Translate(step * -1, 0, 0);
    //    }
    //}


    private IEnumerator MovementRight()
    {
       // float step = _speed * Time.deltaTime;
        //_distanceLeft = 0;

        //while (_distanceRight > _distanceLeft)
        //{
        //    float step = _speed * Time.deltaTime;
        //    _distanceRight -= step;
        //    transform.Translate(step, 0, 0);
        //    Debug.Log(_distanceRight);
        //    yield return null;

        //    if(_distanceRight <= _distanceLeft)
        //    {
        //        StartCoroutine(MovementLeft());
        //    }
        //}

        while (_isReached == false)
        {
            float step = _speed * Time.deltaTime;
            _distanceRight -= step;
            transform.Translate(step, 0, 0);
            yield return null;

            if (_distanceLeft == 0)
            {
                _isReached = true;
            }
        }

    }

    private IEnumerator MovementLeft()
    {
        //float step = _speed * Time.deltaTime;
        //_distanceRight = 3;

        //while (_distanceLeft < _distanceRight)
        //{
        //    _distanceLeft += step;
        //    transform.Translate(step, 0, 0);
        //    yield return null;
        //}
        //StartCoroutine(MovementRight());

        while (_isReached == true)
        {
            float step = _speed * Time.deltaTime;
            _distanceRight += step;
            transform.Translate(step, 0, 0);
            yield return null;
        }
    }



}
