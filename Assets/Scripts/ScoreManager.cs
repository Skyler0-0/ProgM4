
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public void AddScore(int points)
    {
        score += points;
        Debug.Log("Score bijgewerkt: " + score);
    }
}
