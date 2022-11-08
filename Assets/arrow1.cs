using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    float time = 0;
    public float num = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > num)
        {
            time-= num;
            GenerateArrow();
        }
    }
    void GenerateArrow()
    {
        GameObject newArrow = Instantiate(prefab);
        switch (Random.Range(0, 4))
        {
           
            case 0:
                newArrow.transform.position = new Vector3(-20, Random.Range(-10f,10f));
                newArrow.transform.eulerAngles = new Vector3(0,0,0);
                break;
            case 1:
                newArrow.transform.position = new Vector3(20, Random.Range(-10f, 10f));
                newArrow.transform.eulerAngles = new Vector3(0, 0, 180);
                break;
            case 2:
                newArrow.transform.position = new Vector3(Random.Range(-20f, 20f),-10);
                newArrow.transform.eulerAngles = new Vector3(0, 0, 90);
                break;
            case 3:
                newArrow.transform.position = new Vector3(Random.Range(-20f, 20f),10);
                newArrow.transform.eulerAngles = new Vector3(0, 0, -90);
                break;

        }
    }
}

