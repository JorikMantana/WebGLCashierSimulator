using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public int _score;
    
    [SerializeField] private TMP_Text ScoreText;

    [SerializeField] private GameObject LosePanel;

    public void StartScore()
    {
        InvokeRepeating("ScoreMinusEverySecond", 0.5f, 0.5f);
    }

   private void Update()
   {
        if(_score > 100)
        {
            _score = 100;
        }

        if(_score <= 0)
        {
            LoseGame();
        }
   }

   public void ScoreMinusEverySecond()
   {
        _score--;
        ScoreText.text = _score.ToString();
   }

    //Проигрыш
   private void LoseGame()
   {
        LosePanel.SetActive(true);
   }

    //Убавление счета
   public void PlusScore()
   {
        _score += 10;
   }

    //Прибавление счета
   public void MinusScore()
   {
        _score -= 10;
   }
}
