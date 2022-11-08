using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NewBehaviourScript : MonoBehaviour
{
    
    public float height = 7.0f;
    public float speed = 1.0f;
    public Slider hpSlider;
    Animator animator;
    Rigidbody2D rigid;
    bool touched;
    public float health = 100;
    public GameObject gameover;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            transform.eulerAngles = new Vector3(0,0, 0);
            animator.SetBool("run", true);

        }


        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, 180, 0);
            animator.SetBool("run", true);
        }
        else animator.SetBool("run", false);

        if (Input.GetKeyDown(KeyCode.UpArrow)&&touched)
        {
            rigid.AddForce(Vector3.up * height);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        touched = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        touched = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        health -= 10;
        hpSlider.value = health;
        Debug.Log("게임 오버");
        if (health == 0)
        {
            gameover.SetActive(true);
            Time.timeScale = 0;
        }
       

    }
}
