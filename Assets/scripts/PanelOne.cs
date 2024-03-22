using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOne : MonoBehaviour
{

    public GameObject ui;

    // Start is called before the first frame update
    void Start()
    {
        HideUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            ShowUI();
        }
    }


    public void HideUI()
    {
        ui.SetActive(false); 
    }

    public void ShowUI()
    {
        ui.SetActive(true);
    }

}

