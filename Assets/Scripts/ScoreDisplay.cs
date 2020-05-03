using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text playerScoreDisplay;
    public FloatReference playerDistance;

    private float highscore;

    private void Update()
    {
        ChangeAmount();
    }

    public void ChangeAmount()
    {
        if (playerDistance.value > highscore)
        {
            highscore = playerDistance.value;
        }
        playerScoreDisplay.text = highscore.ToString("F1");
    }
}
