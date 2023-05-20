using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelProgress : MonoBehaviour
{

    public Slider Levelslider;
    public Transform Player;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Levelslider.gameObject.GetComponent<Slider>().value = Player.transform.position.z / 95;
    }
}
