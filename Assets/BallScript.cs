using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update

    bool flag = false; // вспомогательный тэг для определения того, находится ли мяч в воздухе
    public Text score_label;
    private int score = 0;
    public GameObject lose_label;
    public GameObject pause_label;

    void Awake()
    {
        flag = false;
        score = 0;
        PlayerPrefs.SetInt("playerScore", 0);
    }

    void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            flag = true;
        }
        if (collision.gameObject.tag == "obstacle")
        {
            Time.timeScale = 0;
            pause_label.SetActive(false);
            lose_label.SetActive(true);
            //SceneManager.LoadScene("Scroller_GameWindow");
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<Rigidbody2D>().gameObject.tag == "crystal")
        {
            /*int buff = PlayerPrefs.GetInt("playerScore");
            PlayerPrefs.SetInt("playerScore", buff++);
            score_label.text = buff.ToString();
            Destroy(col.GetComponent<Rigidbody2D>().gameObject);
            Debug.Log(buff);*/
            score++;
            score_label.text = score.ToString();
            Destroy(col.GetComponent<Rigidbody2D>().gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (flag && Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1500));
            flag = false;
        }
    }

    void FixedUpdate()
    {
        Quaternion rotation_b = Quaternion.AngleAxis(16, new Vector3(0, 0, -1));
        transform.rotation *= rotation_b;
    }
}

