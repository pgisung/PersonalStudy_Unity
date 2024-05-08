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
        // Local <-> World <-> ( Viewport <-> Screen ) (화면)

        //Debug.Log(Input.mousePosition); // Screen 화면 픽셀 좌표

        //Debug.Log(Camera.main.ScreenToViewportPoint(Input.mousePosition)); // Viewport 화면에서의 비율 최소 0 최대 1

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );

            Debug.DrawRay(Camera.main.transform.position, ray.direction * 100.0f, Color.red, 1.0f);

            // 클래스 이용 레이어 마스크
            LayerMask mask = LayerMask.GetMask("Monster") | LayerMask.GetMask("Wall");
            // 비트 연산자 레이어 마스크
            //int mask = (1 << 8) | (1 << 9);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100.0f, mask))
            {
                Debug.Log($"Raycast Camera @ {hit.collider.gameObject.tag}");
            }
        }
    }
}

// ----- Raycast 개념
//Vector3 look = transform.TransformDirection(Vector3.forward);
//Debug.DrawRay(transform.position + Vector3.up, look * 10, Color.red);

//RaycastHit[] hits;
//hits = Physics.RaycastAll(transform.position + Vector3.up, look, 10);

//foreach (RaycastHit hit in hits)
//{
//    Debug.Log($"Raycast {hit.collider.gameObject.name}");
//}

// ----- 투영 화면 개념
//if (Input.GetMouseButtonDown(0))
//{
//    Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
//    Vector3 dir = mousePos - Camera.main.transform.position;
//    dir = dir.normalized;

//    Debug.DrawRay(Camera.main.transform.position, dir * 100.0f, Color.red, 1.0f);

//    RaycastHit hit;
//    if (Physics.Raycast(Camera.main.transform.position, dir, out hit, 100.0f))
//    {
//        Debug.Log($"Raycast Camera @ {hit.collider.gameObject.name}");
//    }
//}