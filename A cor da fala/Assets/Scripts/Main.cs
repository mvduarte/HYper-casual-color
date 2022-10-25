using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public Color mainColor;
    private Color aleColor;
    public int ale;
    public float timeFinal;
    public GameObject[] Bt;
    public BtControler[] btControler;
    public Sprite[] aleSprites;
    public Sprite mainSprite;
    private float timer;
    public Image timeBar;
    public bool play = true;
    // Start is called before the first frame update
    void Start()
    {
        mainColor = gameObject.GetComponent<SpriteRenderer>().color;
        mainSprite = gameObject.GetComponent<SpriteRenderer>().sprite;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeFinal >= 10)
        {
            timeFinal = 10;
        }
        else if (timeFinal <= 0)
        {
            timeFinal = 0;
        }
        gameObject.GetComponent<SpriteRenderer>().sprite = mainSprite;
        timer = timer += Time.deltaTime;
        if (timer >= 0.01f&play)
        {
            timeFinal-=0.02f;
            timer = 0;
        }
        ale = Random.Range(0, 60);
        aleColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1);
        gameObject.GetComponent<SpriteRenderer>().color = mainColor;
        timeBar.fillAmount = timeFinal / 10;
    }
    public void SetColor()
    {
        mainSprite = aleSprites[Random.Range(0, aleSprites.Length)];
        mainColor = aleColor;
        if (ale <= 10)
        {
            Bt[0].GetComponent<Image>().sprite = mainSprite;
            Bt[0].GetComponent<Image>().color = aleColor;
            btControler[1].AleColor();
            btControler[2].AleColor();
            btControler[3].AleColor();
            btControler[4].AleColor();
            btControler[5].AleColor();
        }
        else if (ale <= 20&& ale >10)
        {
            Bt[1].GetComponent<Image>().color = aleColor;
            Bt[1].GetComponent<Image>().sprite = mainSprite;
            btControler[0].AleColor();
            btControler[2].AleColor();
            btControler[3].AleColor();
            btControler[4].AleColor();
            btControler[5].AleColor();
        }
        else if (ale <= 30 &&ale > 20)
        {
            Bt[2].GetComponent<Image>().color = aleColor;
            Bt[2].GetComponent<Image>().sprite = mainSprite;
            btControler[1].AleColor();
            btControler[0].AleColor();
            btControler[3].AleColor();
            btControler[4].AleColor();
            btControler[5].AleColor();
        }
        if (ale <= 40 && ale > 30)
        {
            Bt[3].GetComponent<Image>().color = aleColor;
            Bt[3].GetComponent<Image>().sprite = mainSprite;
            btControler[1].AleColor();
            btControler[2].AleColor();
            btControler[0].AleColor();
            btControler[4].AleColor();
            btControler[5].AleColor();
        }
        else if (ale <= 50 && ale > 40)
        {
            Bt[4].GetComponent<Image>().color = aleColor;
            Bt[4].GetComponent<Image>().sprite = mainSprite;
            btControler[1].AleColor();
            btControler[2].AleColor();
            btControler[3].AleColor();
            btControler[0].AleColor();
            btControler[5].AleColor();
        }
        if (ale <= 60 && ale > 50)
        {
            Bt[5].GetComponent<Image>().color = aleColor;
            Bt[5].GetComponent<Image>().sprite = mainSprite;
            btControler[1].AleColor();
            btControler[2].AleColor();
            btControler[3].AleColor();
            btControler[4].AleColor();
            btControler[0].AleColor();
        }
    }
    public void Play()
    {
        play = true;
    }
    public void Pause()
    {
        play = false;
    }
}
