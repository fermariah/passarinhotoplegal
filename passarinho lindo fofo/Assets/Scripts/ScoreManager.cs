using UnityEngine;
using TMPro; // use isso se estiver usando TextMeshPro (recomendado)

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    private int score = 0;

    public TMP_Text scoreText; // arraste o texto da UI aqui no Inspector

    private void Awake()
    {
        // Singleton para acessar de qualquer lugar
        if (instance == null) instance = this;
    }

    public void AddPoint()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
