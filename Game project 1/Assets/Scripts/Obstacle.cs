using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    // OnBecameInvisible ���� - Destroy�� GameManager���� ����
    // private void OnBecameInvisible()
    // {
    //     Destroy(gameObject);
    // }
}
