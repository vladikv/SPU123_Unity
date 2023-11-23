using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    static public int score = 100;

    void Awake()
    { //a
      // ���� �������� HighScore ��� ���������� � PlayerPrefs, ��������� ���
        if (PlayerPrefs.HasKey("HighScore"))
        { // b
            score = PlayerPrefs.GetInt("HighScore");
        }
        // ��������� ������ ���������� HighScore � ���������
        PlayerPrefs.SetInt("HighScore", score); // c
    }


    // Update is called once per frame
    void Update()
    {
        Text gt = this.GetComponent<Text>();
        if(gt != null)
        {
            gt.text = "High Score: " + score;

            if (score > PlayerPrefs.GetInt("HighScore"))
            {
                PlayerPrefs.SetInt("HighScore", score);
            }
        }
    }
}
