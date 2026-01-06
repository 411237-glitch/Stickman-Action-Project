using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameSettlementGist : MonoBehaviour {
    public Text scoreText;
    public GameObject settlementPanel;

    // 當擊敗 BOSS 後呼叫此函數
    public void ShowFinalScore(int score) {
        settlementPanel.SetActive(true);
        StartCoroutine(ScoreRoll(score));
    }

    IEnumerator ScoreRoll(int targetScore) {
        float current = 0;
        while (current < targetScore) {
            current += targetScore * Time.deltaTime; // 1秒內跑完
            scoreText.text = "FINAL SCORE: " + Mathf.FloorToInt(current).ToString();
            yield return null;
        }
        scoreText.text = "FINAL SCORE: " + targetScore.ToString();
    }
}
