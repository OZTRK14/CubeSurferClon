using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacle : MonoBehaviour
{
    public GameObject Player;
    public Image Failimg;
    public Image Successimg;
    
    private void OnTriggerEnter(Collider other)
    {
       
        if(other.CompareTag("Collected"))
        {
            Taptic.Heavy();
            if (GameManager.instance.CubeList.Count <= 1 && GameManager.instance.Fail == false) 
            {
                Debug.Log("Fail");
                Player.GetComponent<Move>().speed = 0;
                Failimg.gameObject.SetActive(true);
               
               

            }
            else if(GameManager.instance.CubeList.Count <= 1 && GameManager.instance.Fail == true)
            {
                Successimg.gameObject.SetActive(true);
            }

            other.tag = "Bum";
            other.transform.parent = null;
            transform.GetComponent<BoxCollider>().enabled = false;
            GameManager.instance.CubeList.Remove(other.transform);
            Player.transform.position += Vector3.up * .5f;
            
        }
        if (CompareTag("Son")&& GameManager.instance.Fail == true)
        {
            Player.GetComponent<Move>().enabled = false;
            Successimg.gameObject.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
