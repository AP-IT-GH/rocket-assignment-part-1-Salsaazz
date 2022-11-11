using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    // Start is called before the first frame update
    private int pointsAmount = 0;
    public TextMeshProUGUI scoreText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
                pointsAmount += 1;
                SetScore();
        }
    }
    void SetScore()
    {
        scoreText.text = "Coins: " + pointsAmount;
    }
}
