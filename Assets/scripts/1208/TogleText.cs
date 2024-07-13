using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TogleText : MonoBehaviour
{
   public TMP_Text myText;
   public string offText = "";
   public string onText = "MyText";
   public bool state = false;

   public void Toggle() {
     myText.enabled = !myText.enabled;
    }
}

