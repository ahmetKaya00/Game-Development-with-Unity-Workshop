using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float ziplama = 10f;
    private Rigidbody2D rb;
    private SpriteRenderer sr;

    public string CurrentColor;

    public Color ColorCam, ColorSari, ColorPembe, ColorMor;

    public GameObject bir, iki, panel;

    public Text score, PScore, PHScore;
    public int deger, number;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        rb.bodyType = RigidbodyType2D.Static;
        panel.SetActive(false);
        RandomColor();
        PHScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
        Time.timeScale = 1;

    }

    private void Update()
    {
        score.text = deger.ToString("f0");
        if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0) || Input.touchCount > 0)
        {
            rb.velocity = Vector2.up * ziplama;
            rb.bodyType = RigidbodyType2D.Dynamic;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "ColorChanger")
        {
            RandomColor();
            collision.gameObject.transform.position = transform.position + new Vector3(0f, 13f, 0f);
            bir.gameObject.transform.position = transform.position + new Vector3(0f, 10f, 0f);
            Rotate.DonmeHizi += 2;
            deger++;
            number++;
            PScore.text = number.ToString();
            if(number > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", number);
                PHScore.text = number.ToString();
            }
            return;
        }
        if (collision.tag == "Respawn")
        {
            RandomColor();
            collision.gameObject.transform.position = transform.position + new Vector3(0f, 13f, 0f);
            iki.gameObject.transform.position = transform.position + new Vector3(0f, 10f, 0f);
            deger++;
            number++;
            PScore.text = number.ToString();
            if (number > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", number);
                PHScore.text = number.ToString();
            }
            return;
        }
        if (collision.tag != CurrentColor)
        {
            panel.SetActive(true);
            Time.timeScale = 0;
            
        }
    }
    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void RandomColor()
    {
        int index = Random.Range(0, 4);

        switch (index)
        {
            case 0:
                CurrentColor = "cam";
                sr.color = new Color(ColorCam.r,ColorCam.g,ColorCam.b,1f);
                break;
            case 1:
                CurrentColor = "sari";
                sr.color = new Color(ColorSari.r, ColorSari.g, ColorSari.b, 1f);
                break;
            case 2:
                CurrentColor = "pembe";
                sr.color = new Color(ColorPembe.r, ColorPembe.g, ColorPembe.b, 1f);
                break;
            case 3:
                CurrentColor = "mor";
                sr.color = new Color(ColorMor.r, ColorMor.g, ColorMor.b, 1f);
                break;
        }
    }
}
