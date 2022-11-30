using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextColor : MonoBehaviour
{
    public Text titleTxt;
    private float timerTroca;
    public Color cor;
    // Start is called before the first frame update
    void Start()
    {
        titleTxt = gameObject.GetComponent<Text>();
        titleTxt.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1);
    }

    // Update is called once per frame
    void Update()
    {
        cor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1);
        timerTroca += Time.deltaTime;
        if (timerTroca >= Random.Range(3, 3.5f))
        {
            titleTxt.color = cor;
            timerTroca = 0;
        }
    }
}
