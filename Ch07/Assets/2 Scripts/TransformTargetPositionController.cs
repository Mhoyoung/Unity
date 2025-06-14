using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTargetPositionController : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, 2.5f);
    }
}
