using UnityEngine;

public class TopScript : MonoBehaviour
{
    public GameObject pipePairPrefab; 
    public float spawnRate = 2f;      
    public float pipeSpeed = 2f;     
    public float minY = -2f;         
    public float maxY = 2f;           

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            SpawnPipePair();
            timer = 0f;
        }
    }

    void SpawnPipePair()
    {
        // Define uma posição Y aleatória para o centro do par
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPos = new Vector3(transform.position.x, randomY, 0);

        // Instancia o par de canos
        GameObject pipePair = Instantiate(pipePairPrefab, spawnPos, Quaternion.identity);

        // Adiciona movimento
        pipePair.AddComponent<TopMover>().speed = pipeSpeed;

        // Destroi após 10 segundos
        Destroy(pipePair, 10f);
    }
}
