using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.Networking;
using UnityEngine.EventSystems;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    int x = 3;
    public Text Mytxt;
    public GameObject Cuba;
    public GameObject Cubb;
    void Start1()
    {
        Mytxt.text = x.ToString();
    }
    public void ClickBut()
    {
        Cuba.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        x -= 1;
        Mytxt.text = x.ToString();
        if (x == 0)
        {
            Cuba.SetActive(false);
        }
    }
}
   
