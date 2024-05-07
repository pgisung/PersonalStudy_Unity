using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _speed = 10.0f;

    void Start()
    {
        Managers.Input.KeyAction -= OnKeyboard;
        Managers.Input.KeyAction += OnKeyboard;
    }

    void Update()
    {

    }

    void OnKeyboard()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.2f);
            transform.position += Vector3.forward * Time.deltaTime * _speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.2f);
            transform.position += Vector3.back * Time.deltaTime * _speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.2f);
            transform.position += Vector3.left * Time.deltaTime * _speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.2f);
            transform.position += Vector3.right * Time.deltaTime * _speed;
        }
    }
}

// ----- Transforming the kind of coordinator
// Local -> World
// TransformDirection

// World -> Local
// InverseTransformDirection

// -----Vector3
// 1. 위치 벡터
// 2. 방향 벡터
// 1. 거리(크기)
// 2. 실제 방향

// -----Moving
//transform.position += transform.TransformDirection(Vector3.forward * Time.deltaTime * _speed);
//transform.position += transform.TransformDirection(Vector3.back * Time.deltaTime * _speed);
//transform.position += transform.TransformDirection(Vector3.left * Time.deltaTime * _speed);
//transform.position += transform.TransformDirection(Vector3.right * Time.deltaTime * _speed);

//transform.Translate(Vector3.forward * Time.deltaTime * _speed);
//transform.Translate(Vector3.back * Time.deltaTime * _speed);
//transform.Translate(Vector3.left * Time.deltaTime * _speed);
//transform.Translate(Vector3.right * Time.deltaTime * _speed);

// -----Rotating
// float _yAngle = 0.0f;
// _yAngle += Time.deltaTime * _speed;
// 절대 회전값
//transform.eulerAngles = new Vector3 (0.0f, _yAngle, 0.0f);
// +- delta
//transform.Rotate(new Vector3(0.0f, Time.deltaTime * _speed, 0.0f));
// Quaternion
//transform.rotation = Quaternion.Euler(new Vector3(0.0f, _yAngle, 0.0f));