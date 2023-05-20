using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LavaObstacle : MonoBehaviour
{
    public GameObject Player;
    public Image Failimg;
    private void OnTriggerEnter(Collider other)
    {

        
        if (other.CompareTag("Collected"))
        {
            Taptic.Heavy();
            other.tag = "Bum";
            if (GameManager.instance.CubeList.Count <= 1)
            {
                Player.GetComponent<Move>().speed = 0;
                Failimg.gameObject.SetActive(true);
            }

            other.transform.parent = null;
            GameManager.instance.CubeList.Remove(other.transform);
            transform.GetComponent<BoxCollider>().enabled = false;
            if(GameManager.instance.CubeList.Count>=1)
            {
                other.transform.position = Vector3.Lerp(other.transform.position, new Vector3(0, -500, 0), .1f);
                Invoke("Cubedel", 0.2f);
            }
            

            Debug.Log("Lav");
        }
    }

    void Cubedel()
    {

        transform.GetComponent<BoxCollider>().enabled = true;
        Debug.Log("Methot çalýþtý");

    }


    private void Start()
    {
        
    }
}
