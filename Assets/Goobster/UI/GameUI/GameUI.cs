using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    //[SerializeField] private Player player;
    [SerializeField] private GameManager gameManager;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI hitsText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = gameManager.score.ToString();
        hitsText.text = gameManager.hits.ToString();
    }
}
