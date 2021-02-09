using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skor : MonoBehaviour
{
    public static int oyuncu1Skor = 0, oyuncu2Skor = 0;

    public Text oyuncu1, oyuncu2;

    private void Update()
    {
        oyuncu1.text = oyuncu1Skor.ToString();
        oyuncu2.text = oyuncu2Skor.ToString();
    }
}
