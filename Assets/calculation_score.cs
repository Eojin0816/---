using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class calculation_score : MonoBehaviour
{
    public InputField sField, nField;
    public score component;
    public void GameOverclick()
    {

        ranking_manager.ranks.Add(new rank()
        {snumber=sField.text,
        name=nField.text,
        score=component.gamescore
        });
        SceneManager.LoadScene("ranking");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
