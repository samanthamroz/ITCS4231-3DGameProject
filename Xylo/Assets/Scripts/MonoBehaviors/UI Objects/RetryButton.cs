using UnityEngine;

public class RetryButton : MonoBehaviour
{
    public void RetryLevel() {
        LevelManager.self.EndAttempt(true);
    }
}