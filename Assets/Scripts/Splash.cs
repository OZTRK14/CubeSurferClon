using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Splash : MonoBehaviour
{
    public Move Movea;
    public GameObject Starter;
    // Start is called before the first frame update
    void Start()
    {
        Movea = GetComponent<Move>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
       Starter.gameObject.SetActive(false);
      Movea.enabled = true;
      

    }
}
