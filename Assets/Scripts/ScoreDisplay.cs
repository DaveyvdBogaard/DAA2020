using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text playerScoreDisplay;
    public FloatReference playerDistance;

    public FloatReference highscore;

    private void Update()
    {
        ChangeAmount();
    }

    public void ChangeAmount()
    {
        if (playerDistance.value > highscore.value)
        {
            highscore.value = playerDistance.value;
        }
        playerScoreDisplay.text = highscore.value.ToString("F1");
    }
}
