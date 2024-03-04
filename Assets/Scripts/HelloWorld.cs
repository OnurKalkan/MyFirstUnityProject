using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    //integers
    byte levelNo = 255;
    sbyte withPositive = 127;
    short smallNo = 32_000;
    ushort smallNoNoNegative = 64_000;
    public int speed = 12;
    uint speed2 = 25;
    ulong bigNumber = 1_000_000_000_000_000_000;    
    //decimals
    float kesirliSayi = 10.5f;
    double doubleDecimal = 10.7;
    decimal decNo = 22.5m;
    //characters
    string myText = "Hello World 2!!";
    char smiley = 's';
    //Unity ozel
    public GameObject helloText;

    // Start is called before the first frame update
    void Start()
    {
        print(myText);//console msji
        Application.targetFrameRate = 100;//oyunun fpsini sabitleme
        helloText.GetComponent<TextMeshPro>().text = "Hello World!!";
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Hello Again");
        transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
        
    }
}
