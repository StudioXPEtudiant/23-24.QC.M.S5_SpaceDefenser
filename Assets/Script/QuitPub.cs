using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitPub : MonoBehaviour
{
    [SerializeField]
    GameObject destroy;
    public void quitPub()
    {
        destroy.SetActive(false);
    }
}
