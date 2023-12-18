using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using Valve.VR.InteractionSystem;

public class JengaReload : MonoBehaviour
{
    public GameObject Assembly;
    public GameObject[] Assembly_Parts;
    public GameObject Respawn;

    public void ResetToInitialPosition()
    {
        Assembly_Parts = GameObject.FindGameObjectsWithTag("Respawn");
        foreach (GameObject gm in Assembly_Parts)
            Destroy(gm);
        Instantiate(Assembly, Respawn.transform.position, Quaternion.identity);
    }
}
