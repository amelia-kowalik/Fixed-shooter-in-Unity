using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    public int score;
    void Start()
    {
        scoreText.text = "POINTS: " + score.ToString();
    }
    
    public void UpdateScore()
    {
        score ++;
        scoreText.text = "POINTS: " + score.ToString();
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Optional: keeps it between scenes
        }
        else
        {
            Destroy(gameObject); // Ensure only one instance exists
        }
    }
}
