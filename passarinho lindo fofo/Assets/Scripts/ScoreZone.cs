using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    private bool alreadyScored = false;

    private void Awake()
    {
        // garante que o collider está como trigger (apenas debug)
        var col = GetComponent<Collider2D>();
        if (col == null) Debug.LogWarning("[ScoreZone] Nenhum Collider2D encontrado no ScoreZone!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log($"[ScoreZone] TriggerEnter por {other.name} (tag={other.tag})");

        if (alreadyScored)
        {
            Debug.Log("[ScoreZone] Já pontuado, ignorando.");
            return;
        }

        if (other.CompareTag("Player"))
        {
            if (ScoreManager.instance == null)
            {
                Debug.LogError("[ScoreZone] ScoreManager.instance é null!");
                return;
            }

            ScoreManager.instance.AddPoint();
            alreadyScored = true;
            Debug.Log("[ScoreZone] Ponto contabilizado para " + gameObject.name);
        }
    }
}


