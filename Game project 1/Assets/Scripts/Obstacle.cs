using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    // OnBecameInvisible 제거 - Destroy는 GameManager에서 관리
    // private void OnBecameInvisible()
    // {
    //     Destroy(gameObject);
    // }
}
