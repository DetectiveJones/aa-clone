using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score instance;
    public static int PinCount;
    public int highScore;

    public Text text;
    public Text highScoreText;

    private void Awake ()
    {
        instance = this;
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore", highScore);
            highScoreText.text = highScore.ToString();
        }

    }

    void Start ()
    {
         PinCount = 0;
    }

    void Update ()
    {
        text.text = PinCount.ToString();
        UpdateHighScore();
    }

    public void UpdateHighScore()
    {
        if (PinCount > highScore)
            highScore = PinCount;

        text.text = PinCount.ToString();

        PlayerPrefs.SetInt("HighScore", highScore);

    }

    public void ResetScore()
    {
        PinCount = 0;
        highScoreText.text = highScore.ToString();
        

    }
}
