using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Text score;
    
    void Start()
    {
        GameData.GameScore = 0;
        score.text = "Score: " + GameData.GameScore.ToString();

    }
    public void Score()
    {

        GameData.GameScore += 0;
        score.text = "Score: " + GameData.GameScore.ToString();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
