using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    // 나 혹은 상대에게 Rigidbody가 있어야 한다. ( IsKinematic : Off )
    // 나에게 Collider가 있어야 한다. ( IsTrigger : Off )
    // 상대에게 Collider가 있어야 한다. ( IsTrigger : Off )
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collision @ {collision.gameObject.name}");    
    }
    // 둘 다 Collider가 있어야 한다.
    // 둘 중 하나는 IsTrigger : On
    // 둘 중 하나는 Rigidbody가 있어야 한다.
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
