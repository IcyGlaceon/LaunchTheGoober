using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI hitsText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.CalculateScore().ToString();
        hitsText.text = player.GooberHits.ToString();
    }
}
