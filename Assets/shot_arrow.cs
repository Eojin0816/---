using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot_arrow : MonoBehaviour
{
    float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        Vector3 pos = transform.position;

        if (pos.x > 30
            || pos.x < -30
            || pos.y > 30
            || pos.y < -30)
            Destroy(gameObject);
    }
}
