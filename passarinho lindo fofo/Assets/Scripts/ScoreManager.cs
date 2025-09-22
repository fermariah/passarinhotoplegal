using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    private int score = 0;

    [Header("Assign one of these")]
    public TMP_Text tmpScoreText; // se usar TextMeshPro
    

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    private void Start()
    {
        
        UpdateScoreText();
    }

    public void AddPoint()
    {
        score++;
        UpdateScoreText();
        Debug.Log("[ScoreManager] Ponto adicionado. Score = " + score);
    }

    void UpdateScoreText()
    {
        if (tmpScoreText != null) tmpScoreText.text = score.ToString();
       
    }

    // teste manual: aperte S durante o Play para adicionar ponto
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            AddPoint();
        }
    }
}
