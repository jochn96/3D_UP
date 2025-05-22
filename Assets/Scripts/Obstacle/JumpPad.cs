using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 20f; // 점프 강도

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("점패닿음");

            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                // 기존의 Y 방향 속도를 제거하고 위로 힘을 가함
                Vector3 launchVelocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
                rb.velocity = launchVelocity;
                rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
            }
        }
    }
}
