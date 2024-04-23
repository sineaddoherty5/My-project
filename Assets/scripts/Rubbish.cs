using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rubbish : MonoBehaviour
{
    public GameObject rubbish;

    // Start is called before the first frame update
    void Start()
    {
        rubbish.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            ShowRubbish();
        }
    }




    public void ShowRubbish()
    {
        rubbish.SetActive(true);

    }

}
