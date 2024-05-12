using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int scorePlayer = 0;
    [SerializeField] Text scoreTextPlayer;
    public int scoreEnemy = 0;
    [SerializeField] Text scoreTextEnemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreTextPlayer.text = scorePlayer.ToString();
        scoreTextEnemy.text = scoreEnemy.ToString();
    }
}
