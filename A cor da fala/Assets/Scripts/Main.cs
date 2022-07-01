using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public Color mainColor;
    private Color aleColor;
    public int ale;
    public GameObject[] Bt;
    public BtControler[] btControler;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        mainColor = gameObject.GetComponent<SpriteRenderer>().color;

    }

    // Update is called once per frame
    void Update()
    {
        timer = timer += Time.deltaTime;
        if (timer <= 0.001f)
        {
            SetColor();
        }
        ale = Random.Range(0, 60);
        aleColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1);
        gameObject.GetComponent<SpriteRenderer>().color = mainColor;
    }
    public void SetColor()
    {
        mainColor = aleColor;
        if (ale <= 10)
        {
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
            btControler[0].AleColor();
            btControler[2].AleColor();
            btControler[3].AleColor();
            btControler[4].AleColor();
            btControler[5].AleColor();
        }
        else if (ale <= 30 &&ale > 20)
        {
            Bt[2].GetComponent<Image>().color = aleColor;
            btControler[1].AleColor();
            btControler[0].AleColor();
            btControler[3].AleColor();
            btControler[4].AleColor();
            btControler[5].AleColor();
        }
        if (ale <= 40 && ale > 30)
        {
            Bt[3].GetComponent<Image>().color = aleColor;
            btControler[1].AleColor();
            btControler[2].AleColor();
            btControler[0].AleColor();
            btControler[4].AleColor();
            btControler[5].AleColor();
        }
        else if (ale <= 50 && ale > 40)
        {
            Bt[4].GetComponent<Image>().color = aleColor;
            btControler[1].AleColor();
            btControler[2].AleColor();
            btControler[3].AleColor();
            btControler[0].AleColor();
            btControler[5].AleColor();
        }
        if (ale <= 60 && ale > 50)
        {
            Bt[5].GetComponent<Image>().color = aleColor;
            btControler[1].AleColor();
            btControler[2].AleColor();
            btControler[3].AleColor();
            btControler[4].AleColor();
            btControler[0].AleColor();
        }
    }
}
