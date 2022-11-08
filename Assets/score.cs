using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class score : MonoBehaviour
{ public Text text;
    public int gamescore;
    float timer = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        gamescore = 0;

       
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        gamescore += Mathf.FloorToInt(timer * 1000);
        timer %= 0.001f;
        text.text = $"점수 : {gamescore}";
    }
}
