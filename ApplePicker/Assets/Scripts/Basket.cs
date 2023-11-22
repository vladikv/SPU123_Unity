using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Text scoreGT; // a

    void Start()
    {
        
        GameObject scoreGO = GameObject.Find("ScoreCounter"); // b
                                                          // Получить компонент Text этого игрового объекта
        scoreGT = scoreGO.GetComponent<Text>(); // с
                                                // Установить начальное число очков равным 0
        scoreGT.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;

        mousePos2D.z = -Camera.main.transform.position.z;

        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

    void OnCollisionEnter(Collision coll)
    { //a
      // Отыскать яблоко, попавшее в эту корзину
        GameObject collidedWith = coll.gameObject; // b
        if (collidedWith.tag == "Apple")
        {
            Destroy(collidedWith);

            int score = int.Parse(scoreGT.text);
            // Добавить очки за пойманное яблоко
            score += 100;
            // Преобразовать число очков обратно в строку и вывести ее на экран
            scoreGT.text = score.ToString();

            // Запомнить высшее достижение
            if (score > HighScore.score)
            {
                HighScore.score = score;
            }
        }
    }
}
