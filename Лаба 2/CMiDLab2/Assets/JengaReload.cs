using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.PlayerLoop;
using Valve.VR.InteractionSystem;

public class JengaReload : MonoBehaviour
{
    public GameObject Jenga;
    public GameObject JengaPrefab;

    private int ResetCount;
    private GUIContent gUIContent = new GUIContent();

    void Start()
    {
        ResetCount = 1000;
    }

    void OnGUI()
    {
        GUI.Label(new Rect( Screen.width - 100f, 10f, 100f, 50f ), gUIContent);
    }

    public void IncCount()
    {
        if (ResetCount > 0)
        {
            ResetCount -= 1;
            gUIContent.text = "Попыток осталось: " + ResetCount;
        }
    }
    

    public void ResetToInitialPosition()
    {
        if (Jenga != null)
            Destroy(Jenga);
        Jenga = Instantiate(JengaPrefab);
    }
}
