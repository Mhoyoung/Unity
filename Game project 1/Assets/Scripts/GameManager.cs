using System.Collections;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Transform spawnPoint;
    int score = 0;
    public TextMeshProUGUI scoreText;
    public GameObject playButton;
    public GameObject player;

    Coroutine spawnCoroutine;

    IEnumerator SpawnObstacles()
    {
        float speedMultiplier = 1f;

        while (true)
        {
            if (obstaclePrefab == null)
            {
                Debug.LogWarning("Obstacle prefab is missing!");
                yield break;
            }

            float waitTime = Random.Range(0.5f, 1.5f);
            yield return new WaitForSeconds(waitTime);

            GameObject obs = Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity);
            obs.GetComponent<Obstacle>().speed *= speedMultiplier;

            Debug.Log("Spawned obstacle with speed: " + obs.GetComponent<Obstacle>().speed);

            speedMultiplier += 0.005f;
            Destroy(obs, 5f);
        }
    }

    void ScoreUp()
    {
        score++;
        scoreText.text = score.ToString();
        Debug.Log("Score: " + score);
    }

    public void GameStart()
    {
        player.SetActive(true);
        playButton.SetActive(false);

        if (spawnCoroutine != null)
            StopCoroutine(spawnCoroutine);

        spawnCoroutine = StartCoroutine(SpawnObstacles());
        InvokeRepeating(nameof(ScoreUp), 2f, 1f);
    }

    private void OnDisable()
    {
        if (spawnCoroutine != null)
            StopCoroutine(spawnCoroutine);

        CancelInvoke();
    }
}
