using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _speed = 10.0f;

    void Start()
    {
       
    }

    float _yAngle = 0.0f;
    void Update()
    {
        _yAngle += Time.deltaTime * _speed;

        // 절대 회전값
        //transform.eulerAngles = new Vector3 (0.0f, _yAngle, 0.0f);

        // +- delta
        //transform.Rotate(new Vector3(0.0f, Time.deltaTime * _speed, 0.0f));

        // Quaternion
        transform.rotation = Quaternion.Euler(0.0f, Time.deltaTime * _speed, 0.0f);

        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * Time.deltaTime * _speed);
    }
}

// -----
//transform.position += transform.TransformDirection(Vector3.forward * Time.deltaTime * _speed);
//transform.position += transform.TransformDirection(Vector3.back * Time.deltaTime * _speed);
//transform.position += transform.TransformDirection(Vector3.left * Time.deltaTime * _speed);
//transform.position += transform.TransformDirection(Vector3.right * Time.deltaTime * _speed);

// Local -> World
// TransformDirection

// World -> Local
// InverseTransformDirection

// -----
// 1. 위치 벡터
// 2. 방향 벡터
// 1. 거리(크기)
// 2. 실제 방향