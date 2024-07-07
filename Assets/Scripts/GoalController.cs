using UnityEngine;
using UnityEngine.UI;

public class GoalController : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;
    
    public void updateScore(int delta)
    {
        score += delta;
        scoreText.text = $"{score}";
    }

    public void resetScore() {
        score = 0;
        scoreText.text = $"{0}";
    }
}
