using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnScrpt : MonoBehaviour
{
    public GameObject tree;
    public Text text;
    public void ActiveSwitch(){
        if (tree.active)
        {
            tree.SetActive(false);
            text.text = "Какое дерево??";
        }
        else
        {
            tree.SetActive(true);
            text.text = "Так и знал, что понравилось!)";
        }

    }
}
