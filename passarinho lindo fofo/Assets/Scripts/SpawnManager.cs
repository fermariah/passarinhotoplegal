using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject prefabTop;
    public float spawnRate = 2f;   
    public float minY = -1f;      
    public float maxY = 3f;        
    public float topSpeed = 2f;
    float clock;
    const float cooldown = 2;
    private float timer = 0f;

    [SerializeField] GameObject obstaclePrefab;
    private void Update()
    {
        if (clock <= 0)
        {
            clock = cooldown;

            Instantiate(obstaclePrefab, new Vector2(GameManager.instance.ScreenBounds.x, Random.Range(-2, 2)), Quaternion.identity);
        }
        else
        {
            clock -= Time.deltaTime;
        }
    }

    void tempo()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    void SpawnPipe()
    {
        // Posição aleatória do cano no eixo Y
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPos = new Vector3(transform.position.x, randomY, 0);

        // Instancia o cano
        GameObject newPipe = Instantiate(prefabTop, spawnPos, Quaternion.identity);

        // Dá movimento ao cano
        newPipe.AddComponent<TopMover>().speed = topSpeed;

        // Destroi o cano depois de 10s pra não lotar a cena
        Destroy(newPipe, 10f);
    }
}