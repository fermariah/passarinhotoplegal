using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject player; // Referência ao player

    public Vector3 playerRenascer; // Define onde o player renasce

    public void RestartGame()
    {
        gameOverPanel.SetActive(false);

        
        player.transform.position = playerRenascer;

        
        player.SetActive(true);
    }
}
