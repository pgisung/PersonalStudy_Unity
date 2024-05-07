using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    // �� Ȥ�� ��뿡�� Rigidbody�� �־�� �Ѵ�. ( IsKinematic : Off )
    // ������ Collider�� �־�� �Ѵ�. ( IsTrigger : Off )
    // ��뿡�� Collider�� �־�� �Ѵ�. ( IsTrigger : Off )
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collision @ {collision.gameObject.name}");    
    }
    // �� �� Collider�� �־�� �Ѵ�.
    // �� �� �ϳ��� IsTrigger : On
    // �� �� �ϳ��� Rigidbody�� �־�� �Ѵ�.
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Trigger @ {other.gameObject.name}");
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
