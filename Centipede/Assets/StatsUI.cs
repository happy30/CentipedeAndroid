using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsUI : MonoBehaviour
{
    public Text ShotsText;
    public Text MushroomHitsText;
    public Text MushroomDestroyedText;
    public Text CentipedeHeadsShotText;
    public Text CentipedeBodiesShotText;
    public Text ScoreText;

    private void Update()
    {
        ShotsText.text = "Shots: " + Stats.Shots;
        MushroomHitsText.text = "Mushroom Hits: " + Stats.MushroomHits;
        MushroomDestroyedText.text = "Mushrooms Destroyed: " + Stats.MushroomDestroyed;
        CentipedeHeadsShotText.text = "Centipede Heads Shot: " + Stats.CentipedeHeadsShot;
        CentipedeBodiesShotText.text = "Centipede Bodies Shot: " + Stats.CentipedeBodiesShot;
        ScoreText.text = "Score: " + Stats.Score;
    }

}
