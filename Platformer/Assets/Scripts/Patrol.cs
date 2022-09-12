using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    private float _speed = 1;
    private float _passedDistance = 0;
    private float _distanceOfPatrol = 3;


    void Update()
    {
        
        float step = _speed * Time.deltaTime;      ///Разбить на методы влево и вправо или даже сделать один метод движения
        _passedDistance += step;

        if(_passedDistance < _distanceOfPatrol)
        {
            transform.Translate(step, 0, 0);
            Debug.Log(_passedDistance);
        }
        else                            // сделать, чтобы разворачивался и в обратную сторону
        {
            Debug.Log("gggggggggggggggggggggggGGGGGGGGGGGGGGGGGGGGGG");
            transform.Translate(step * -1, 0, 0);
        }
        

        //if (_passedDistance == distanceOfPatrol)
        //{

        //    Debug.Log("gggggggggggggggggggggggGGGGGGGGGGGGGGGGGGGGGG");
        //    transform.Translate(step * -1, 0, 0);
        //}
    }
}
