using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    public AudioClip appleSE;
    public AudioClip bombSE;

    GameObject manager;

    AudioSource aud;

    void Start()
    {
        Application.targetFrameRate = 60;
        aud = GetComponent<AudioSource>();
        manager = GameObject.Find("GameManager");
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x, transform.position.y, z);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Apple")
        {
            manager.GetComponent<GameManager>().GetApple();
            aud.PlayOneShot(appleSE);
        }
        else
        {
            manager.GetComponent<GameManager>().GetBomb();
            aud.PlayOneShot(bombSE);
        }

        Destroy(other.gameObject);
    }
}
