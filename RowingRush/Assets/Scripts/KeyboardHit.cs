using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeyboardHit : MonoBehaviour
{
    string word = null;
    int wordIndex = 0;
    string alpha;
    public TextMeshProUGUI IDtext;
    public TextMeshProUGUI PWtext;

    public void alphabetFunction(string alphabet)
    {
        wordIndex++;
        word = word + alphabet;
        IDtext.text = word;
    }

    
}
