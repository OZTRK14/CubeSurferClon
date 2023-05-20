using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class Collect : MonoBehaviour
{
    public Transform Cubes;
    public Transform Collecter;
    public Transform player;
    public ParticleSystem Ps;
    public TextMeshProUGUI ScoreText;
    public Transform Character;
    public Transform First;




    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Diamond"))
        {
            
            other.gameObject.SetActive(false);
            GameManager.instance.Diamond++;
            Ps.Play();
            Debug.Log("diamond sayý :" + GameManager.instance.Diamond);

        }

            if (other.CompareTag("Collect"))
        {
            Taptic.Light();
            other.transform.tag = "Collected";
            other.transform.parent = Cubes;
            Ps.Play();
           //* Character.transform.DOJump(new Vector3(First.transform.position.x, First.transform.position.y+2f, First.transform.position.z) , 0.5f,1,.1f);
            
            //transform.parent.position = new Vector3(transform.parent.position.x, GameManager.instance.CubeList.Count + .1f, transform.parent.position.z);

            player.transform.position += Vector3.up * 1.1f;
            GameManager.instance.CubeList.Add(other.transform);
            //Cubes.transform.localPosition += Vector3.up * 1.2f;
            //*transform.parent.position = new Vector3(transform.parent.position.x, GameManager.instance.CubeList.Count , transform.parent.position.z);
            //Collecter.transform.position = new Vector3(player.position.x, 0.5f, player.position.z);
            other.transform.position = new Vector3(transform.parent.position.x, 1f, transform.parent.position.z);
        }
    }

    private void Update()
    {
        transform.position = new Vector3(player.transform.position.x, 0.5f, player.transform.position.z);
        ScoreText.GetComponent<TextMeshProUGUI>().text = GameManager.instance.Diamond.ToString();
        PlayerPrefs.SetInt(nameof(GameManager.instance.Diamond), GameManager.instance.Diamond);
       
    }
    private void Start()
    {
        GameManager.instance.Diamond = PlayerPrefs.GetInt(nameof(GameManager.instance.Diamond));

        Input.multiTouchEnabled = false;
    }

}
